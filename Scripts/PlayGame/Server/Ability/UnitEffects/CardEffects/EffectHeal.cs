using System.Collections.Generic;

public class CallBackAfterTakeHeal:UnitEffectCallBack
{
    public delegate void EventAfterTakeHeal(Card source,Card target, int amount);
    public event EventAfterTakeHeal myEv;
    public CallBackAfterTakeHeal(Ability SourceAbility, EventAfterTakeHeal Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card source,Card target, int amount)
    {
        this.myEv.Invoke(source ,target, amount);
    }
}

public class EffectHeal:UnitEffect
{
	public int AmountSingle;
    public List<Card> TargetList;
    public List<int> AmountList;
    public Card AssignVfxCard;
    public bool VisualFx;

	public EffectHeal(Player srcPlayer, Card source, Card target=null, int amount=0, List<Card> targets=null, List<int> amounts=null, Card assignVfxCard=null, bool visualFx=true)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = source;
        this.TargetCard = target;
        this.AmountSingle = amount;
        this.TargetList = targets;
        this.AmountList = amounts;
        this.AssignVfxCard = assignVfxCard;
        this.VisualFx = visualFx;
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
        if (this.SourceCard.cardType == CardType.Spell)
        {
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
        List<int> realHeals = new List<int>();
        for(int i= this.TargetList.Count-1;i>=0;i--)
        {
            Card c = this.TargetList[i];
            int realheal = this.AmountList[i]*(1+this.SourcePlayer.GetTag(GameTag.HealEff));

            targetsIDs.Add(c.GetTag(GameTag.EntityId));
            for (int j = c.abilityList.Count - 1; j >= 0; j--)
            {
                Ability abi = c.abilityList[j];
                realheal = abi.BeforeTakeHeal(this.SourceCard, realheal);
            }

            for(int j = this.SourceCard.abilityList.Count-1;j>=0;j--)
            {
                Ability abi = this.SourceCard.abilityList[j];
                abi.MakeHeal(c, realheal);
            }
            //new EffectMakeHeal(this.SourceCard.myPlayer, this.SourceCard, c, realheal).Resolve();
            //this.SourceCard.MakeHeal(c, realheal);
            //realheal = c.TakeHeal(this.SourceCard, realheal);

            //c.SetTag(GameTag.Health,c.GetTag(GameTag.Health)+realheal);
            if(c.GetTag(GameTag.Damage)>realheal)
            {
            }
            else{
                realheal = c.GetTag(GameTag.Damage);
                c.SetTag(GameTag.IsInjured,0);
            }
            c.SetTag(GameTag.Damage,c.GetTag(GameTag.Damage)-realheal);

            if (c.GetTag(GameTag.Health) >= c.cardDbf.MaxHealth)
            {
                realheal = realheal-(c.GetTag(GameTag.Health) - c.cardDbf.MaxHealth);
                c.SetTag(GameTag.Health,c.cardDbf.MaxHealth);
                c.SetTag(GameTag.IsInjured,0);
            }
            for(int j = c.abilityList.Count-1;j>=0;j--)
            {
                Ability abi = c.abilityList[j];
                abi.TakeHeal(this.SourceCard, realheal);
            }
            //this.myPlayer.OnFriendTakeHeal(source, this, amount);
            //if(realheal>0)
            //{
                for(int j = c.myPlayer.EffectCallBacks.Count-1;j>=0;j--)
                {
                    if(c.myPlayer.EffectCallBacks[j] is CallBackAfterTakeHeal)
                    {
                        c.myPlayer.EffectCallBacks[j].Resolve(c,this.SourceCard,realheal); 
                    }
                }                
            //}


            realHeals.Add(realheal);
        }

        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            if(this.VisualFx)
                new CreateVfxCommand(this.SourceCard.GetTag(GameTag.EntityId), targetsIDs, dbfID: CustomVfxAsset, vfxType:VfxType.Heal).AddToQueue();
            for (int i = this.TargetList.Count - 1; i >= 0; i--)
            {

                new ChangeActorTagCommand(this.TargetList[i].GetTag(GameTag.EntityId), Cheal: realHeals[i]).AddToQueue();
            }
            new UpdateActorCommand(this.SourcePlayer.myGame).AddToQueue();
        }
        this.SourcePlayer.myGame.UpdateAura();
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            new UpdateActorCommand(this.SourcePlayer.myGame).AddToQueue();
        }
	}
}