using System.Collections.Generic;

public class CallBackBeforeTakeDamage:UnitEffectCallBack
{
    public delegate void EventBeforeTakeDamage(Card source,Card target, int amount);
    public event EventBeforeTakeDamage myEv;
    public CallBackBeforeTakeDamage(Ability SourceAbility, EventBeforeTakeDamage Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card source,Card target, int amount)
    {
        this.myEv.Invoke(source ,target, amount);
    }
}
public class CallBackAfterTakeDamage:UnitEffectCallBack
{
    public delegate void EventAfterTakeDamage(Card source,Card target, int amount);
    public event EventAfterTakeDamage myEv;
    public CallBackAfterTakeDamage(Ability SourceAbility, EventAfterTakeDamage Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card source,Card target, int amount)
    {
        this.myEv.Invoke(source ,target, amount);
    }
}

public class EffectDamage:UnitEffect
{
	public int AmountSingle;
    public List<Card> TargetList;
    public List<int> AmountList;
    public Card AssignVfxCard;
    public bool CreateVfx;
    public bool Silent;
    public bool DamagerBuffEnabled=false;
    public bool Clean=false;

	public EffectDamage(Player srcPlayer, Card source, Card target=null, int amount=0,List<Card> targets=null, List<int> amounts=null, Card assignVfxCard=null, bool createVfx=true, bool silent=false, bool dmgbuffen=true, bool cleandeath=true)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = source;
        this.TargetCard = target;
        this.AmountSingle = amount;
        this.TargetList = targets;
        this.AmountList = amounts;
        this.AssignVfxCard = assignVfxCard;
        this.CreateVfx = createVfx;
        this.Silent = silent;
        this.DamagerBuffEnabled=dmgbuffen;
        this.Clean=cleandeath;
	}
	public override void Resolve()
	{
		if (this.SourceCard.myPlayer.hero.Count == 0)
        {
            return;
        }
        int CustomVfxAsset = this.SourceCard.cardDbf.DbfId;
        if (this.AssignVfxCard != null)
        {
            CustomVfxAsset = this.AssignVfxCard.cardDbf.DbfId;
        }
        int SpellDamageBuffer = 0;
        if (this.SourceCard.cardType == CardType.Spell && this.DamagerBuffEnabled)
        {
            SpellDamageBuffer = this.SourceCard.GetTag(GameTag.SpellDamage);
            //this.SourceCard = this.SourceCard.myPlayer.hero[0];
        }

        if (this.TargetList == null)
        {
            this.TargetList = new List<Card>();
            this.AmountList = new List<int>();
        }
        if (this.TargetCard != null)
        {
            this.TargetList.Add(this.TargetCard);
            this.AmountList.Add(this.AmountSingle);
        }

        List<int> targetsIDs = new List<int>();
        List<int> realDmgs = new List<int>();
        for (int j = this.TargetList.Count - 1; j >= 0; j--)
        {
            targetsIDs.Add(this.TargetList[j].GetTag(GameTag.EntityId));
        }
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0 && this.CreateVfx)
        {
            new CreateVfxCommand(this.SourceCard.GetTag(GameTag.EntityId), targetsIDs, dbfID: CustomVfxAsset, vfxType: VfxType.Damage).AddToQueue();
        }

        for(int j = 0; j< this.TargetList.Count; j++)
        {
            Card c = this.TargetList[j];
            int realDmg = this.AmountList[j] * ((int)System.Math.Pow(2,this.SourceCard.GetTag(GameTag.DamageEff))) * (1+c.GetTag(GameTag.DamageTakenEff)) + SpellDamageBuffer;
            /*
            if (c.myPlayer.FriendTakeDamageEvent!=null)
                c.myPlayer.FriendTakeDamageEvent.Invoke(this.SourceCard, c, realDmg);
            */
            for (int i = c.abilityList.Count - 1; i >= 0; i--)
            {
                Ability abi = c.abilityList[i];
                realDmg = abi.BeforeTakeDamage(this.SourceCard, realDmg);
            }
            for(int i = this.SourceCard.abilityList.Count-1;i>=0;i--)
            {
                Ability abi = this.SourceCard.abilityList[i];
                abi.MakeDamage(c, realDmg);
            }
            //this.SourceCard.MakeDamage(this.TargetCard, realDmg);
            //c.TakeDamage(this.SourceCard, realDmg);
            realDmgs.Add(realDmg);
        }


        for (int j = this.TargetList.Count - 1; j >= 0; j--)
        {
            //new EffectTakeDamage(this.TargetList[j].myPlayer, this.TargetList[j], this.SourceCard, realDmgs[j]).Resolve();
            this.TargetList[j].hateCard = this.SourceCard;

            if (this.TargetList[j].GetTag(GameTag.Armor) >= realDmgs[j])
            {
                this.TargetList[j].SetTag(GameTag.ArmorMod,this.TargetList[j].GetTag(GameTag.ArmorMod)-realDmgs[j]);
                realDmgs[j] = 0;
            }
            else
            {
                realDmgs[j] -= this.TargetList[j].GetTag(GameTag.Armor);
                this.TargetList[j].SetTag(GameTag.ArmorMod,0);
                
                //this.TargetList[j].SetTag(GameTag.Health, this.TargetList[j].GetTag(GameTag.Health)-realDmgs[j]);
                this.TargetList[j].SetTag(GameTag.Damage, this.TargetList[j].GetTag(GameTag.Damage)+realDmgs[j]);
                this.TargetList[j].ChangeTag(GameTag.CntDamageTakenThisTurn,realDmgs[j]);
            }
        }

        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            for (int i = this.TargetList.Count - 1; i >= 0; i--)
            {
                new ChangeActorTagCommand(this.TargetList[i].GetTag(GameTag.EntityId), Cdmg: realDmgs[i]).AddToQueue();
            }
            new UpdateActorCommand(this.SourcePlayer.myGame).AddToQueue();
        }

        for (int j = this.TargetList.Count - 1; j >= 0; j--)
        {            
            Card targetJ = this.TargetList[j];
            for(int i = targetJ.abilityList.Count-1;i>=0;i--)
            {
                Ability abi = targetJ.abilityList[i];
                abi.TakeDamage(this.TargetCard, realDmgs[j]);
            }
            if (targetJ.GetTag(GameTag.Damage)>0)//this.TargetList[j].GetTag(GameTag.Health)<this.TargetList[j].GetTag(GameTag.HealthDef))//
            {
                targetJ.SetTag(GameTag.IsInjured, 1);
            }
            for (int i = targetJ.abilityList.Count - 1; i >= 0; i--)
            {
                Ability abi = targetJ.abilityList[i];
                abi.AfterTakeDamage(this.SourceCard, realDmgs[j]);
            }

            for(int i = this.SourceCard.abilityList.Count-1;i>=0;i--)
            {
                Ability abi = this.SourceCard.abilityList[i];
                abi.AfterMakeDamage(targetJ, realDmgs[j]);
            }

            Player targetJPlayer = targetJ.myPlayer;
            if(!this.Silent)
            {
                for(int i = targetJPlayer.EffectCallBacks.Count-1;i>=0;i--)
                {
                    if(targetJPlayer.EffectCallBacks[i] is CallBackAfterTakeDamage)
                    {
                        targetJPlayer.EffectCallBacks[i].Resolve(this.SourceCard,targetJ,realDmgs[j]); 
                    }
                }                
            }
            if (targetJ.GetTag(GameTag.Health) < 0)
            {
                for (int i = this.SourceCard.abilityList.Count - 1; i >= 0; i--)
                {
                    Ability abi = this.SourceCard.abilityList[i];
                    abi.OverKill(targetJ, -this.SourceCard.GetTag(GameTag.Health));
                }
            }
        }
        if(this.Clean)
            this.SourcePlayer.myGame.CleanDeath();
	}
}