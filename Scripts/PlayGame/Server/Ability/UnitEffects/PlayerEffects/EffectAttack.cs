using System.Collections.Generic;

public class CallBackBeforeAttack:UnitEffectCallBack
{
    public delegate void EventBeforeAttack(Card sc,Card tc,ZoneType sz,ZoneType tz);
    public event EventBeforeAttack myEv;
    public CallBackBeforeAttack(Ability SourceAbility, EventBeforeAttack Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        this.myEv.Invoke(sc,tc,sz,tz);
    }
}

public class CallBackAfterAttack:UnitEffectCallBack
{
    public delegate void EventAfterAttack(Card sc,Card tc,ZoneType sz,ZoneType tz);
    public event EventAfterAttack myEv;
    public CallBackAfterAttack(Ability SourceAbility, EventAfterAttack Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        this.myEv.Invoke(sc,tc,sz,tz);
    }
}

public class EffectAttack:UnitEffect
{
	public bool Insert;
	public bool Exhaust;
    public int SourceId;
    public int TargetId;
	public EffectAttack(Player srcPlayer, Card SourceCard=null, Card TargetCard=null, bool insert=false, bool exhaust=true, int SourceId=-1, int TargetId=-1)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = SourceCard;
        this.TargetCard = TargetCard;
        this.Insert = insert;
        this.Exhaust = exhaust;
        this.SourceId = SourceId;
        this.TargetId = TargetId;
	}
	public override void Resolve()
	{
        if(this.SourceId!=-1)
        {
            if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer) == 0)//if (this.SourcePlayer.GetTag(GameTag.IsControledByAI) == 1 && this.SourcePlayer.GetTag(GameTag.IsSimPlayer) == 0)
                new FakeDragCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.SourceId, this.TargetId, this.SourcePlayer.GetTag(GameTag.IsControledByAI) == 1).AddToQueue();
            this.SourceCard = this.SourcePlayer.GetCardFromID(this.SourceId);
            this.TargetCard = this.SourcePlayer.GetCardFromID(this.TargetId);
        }

		if(this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
            new CreatureAttackCommand(this.SourceCard.GetTag(GameTag.EntityId), this.TargetCard.GetTag(GameTag.EntityId), 0).AddToQueue();
        for (int i = this.SourceCard.abilityList.Count-1;i>=0;i--)
        {
            Ability abi = this.SourceCard.abilityList[i];
            abi.BeforeAttack(this.TargetCard);
        }
        for(int i=this.TargetCard.abilityList.Count-1;i>=0;i--)
        {
            Ability abi = this.TargetCard.abilityList[i];
            abi.BeforeAttacked(this.SourceCard);
        }
        for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
        {
            if(this.SourcePlayer.EffectCallBacks[i] is CallBackBeforeAttack)
            {
                this.SourcePlayer.EffectCallBacks[i].Resolve(this.SourceCard,this.TargetCard,ZoneType.Board,ZoneType.Board); 
            }
        }
        //this.SourcePlayer.BeforeFriendAttack(this.SourceCard,this.TargetCard);

        if (this.Exhaust)
        {
            this.SourceCard.SetTag(GameTag.AttacksLeftThisTurn, this.SourceCard.GetTag(GameTag.AttacksLeftThisTurn) - 1);
        }

        if (this.TargetCard.GetTag(GameTag.Health) <= 0 || this.TargetCard.GetTag(GameTag.ZoneType)==(int)ZoneType.Grave)
        {
            this.SourceCard.SetTag(GameTag.IsCanceled,1);
        }
        if (this.SourceCard.GetTag(GameTag.IsCanceled)>0 && this.Insert==false)
        {
            this.SourceCard.SetTag(GameTag.IsCanceled,0);
            return;
        }


        if (this.SourceCard.GetTag(GameTag.CardType) == (int)CardType.Minion)
        {
            if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
            {
                new CreatureAttackCommand(this.SourceCard.GetTag(GameTag.EntityId), this.TargetCard.GetTag(GameTag.EntityId), 1).AddToQueue();
            }
        }
        else
        {
            if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
            {
                new CreatureAttackCommand(this.SourceCard.GetTag(GameTag.EntityId), this.TargetCard.GetTag(GameTag.EntityId), 1).AddToQueue();
            }
        }

        int amount1 = this.SourceCard.GetTag(GameTag.Attack);
        int amount2 = this.TargetCard.GetTag(GameTag.Attack);
        for(int i=this.TargetCard.abilityList.Count-1;i>=0;i--)
        {
            Ability abi = this.TargetCard.abilityList[i];
            amount1 = abi.BeforeTakeDamage(this.SourceCard, amount1);
        }
        for(int i=this.SourceCard.abilityList.Count-1;i>=0;i--)
        {
            Ability abi = this.SourceCard.abilityList[i];
            amount2 = abi.BeforeTakeDamage(this.TargetCard, amount2);
        }
        //if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer) == 0)
        //{
        //    new ChangeActorTagCommand(this.TargetCard.GetTag(GameTag.EntityId), amount1).AddToQueue();
        //    new ChangeActorTagCommand(this.SourceCard.GetTag(GameTag.EntityId), amount2).AddToQueue();
        //}

        new EffectDamage(this.SourcePlayer, this.SourceCard, this.TargetCard, amount1, createVfx:false,cleandeath:false).Resolve();
        new EffectDamage(this.SourcePlayer, this.TargetCard, this.SourceCard, amount2, createVfx:false,cleandeath:false).Resolve();
        this.SourcePlayer.myGame.CleanDeath();
        //new EffectMakeDamage(this.TargetCard.myPlayer, this.TargetCard, this.SourceCard, amount2).Resolve();
        //new EffectTakeDamage(this.SourcePlayer, this.SourceCard, this.TargetCard, amount2).Resolve();

        //this.SourcePlayer.OnFriendTakeDamage(this.TargetCard,this.SourceCard,amount2);
        //new EffectMakeDamage(this.SourcePlayer, this.SourceCard, this.TargetCard, amount1).Resolve();
        //new EffectTakeDamage(this.TargetCard.myPlayer, this.TargetCard, this.SourceCard, amount1).Resolve();

        //this.SourcePlayer.otherPlayer.OnFriendTakeDamage(this.SourceCard, this.TargetCard, amount1);


        for (int i = this.SourceCard.abilityList.Count-1;i>=0;i--)
        {
            Ability abi = this.SourceCard.abilityList[i];
            abi.AfterAttack(this.TargetCard);
        }
        for(int i = this.TargetCard.abilityList.Count-1;i>=0;i--)
        {
            Ability abi = this.TargetCard.abilityList[i];
            abi.AfterAttacked(this.SourceCard);
        }
        if (this.SourceCard.GetTag(GameTag.CardType) == (int)CardType.Minion)
        {

        }
        else
        {

            for (int i = 0; i < this.SourcePlayer.weapon.Count; i++)
            {
                foreach (Ability abi in this.SourcePlayer.weapon[i].abilityList)
                {
                    abi.AfterAttack();
                }
                //myPlayer.GetArea().weaponVisual.SetHea(myPlayer.weapon.hp);

            }
        }
        for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
        {
            if(this.SourcePlayer.EffectCallBacks[i] is CallBackAfterAttack)
            {
                this.SourcePlayer.EffectCallBacks[i].Resolve(this.SourceCard,this.TargetCard,ZoneType.Board,ZoneType.Board); 
            }
        }
        //this.SourcePlayer.AfterFriendAttack(this.SourceCard, this.TargetCard);
        //if (this.TargetCard.GetTag(GameTag.Health) < 0)
        //{
            //for (int i = this.SourceCard.abilityList.Count - 1; i >= 0; i--)
            //{
                //Ability abi = this.SourceCard.abilityList[i];
                //abi.OverKill(this.TargetCard, -this.SourceCard.GetTag(GameTag.Health));
            //}
        //}
        //this.SourcePlayer.myGame.CleanDeath();
        this.SourcePlayer.myGame.actionHistorys.Add(
            new ActionHistory(ActionType.CardAttack,
                this.SourceCard.GetTag(GameTag.EntityId),this.TargetCard.GetTag(GameTag.EntityId),
                this.SourcePlayer.GetTag(GameTag.PlayerID),this.SourceCard.GetTag(GameTag.ZoneType),this.SourceCard.cardDbf.DbfId,
                this.TargetCard.GetTag(GameTag.PlayerID),this.TargetCard.GetTag(GameTag.ZoneType),this.TargetCard.cardDbf.DbfId,
                this.SourcePlayer.myGame.GetTag(GameTag.NowRoundNum),this.SourcePlayer.GetTag(GameTag.NowTurnNum))
            );
	}
}