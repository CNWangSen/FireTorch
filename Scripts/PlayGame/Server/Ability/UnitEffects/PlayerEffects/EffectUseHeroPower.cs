using System.Collections.Generic;

public class CallBackAfterUseHeroPower:UnitEffectCallBack
{
    public delegate void EventAfterUseHeroPower(Card sc,Card tc,ZoneType sz,ZoneType tz);
    public event EventAfterUseHeroPower myEv;
    public CallBackAfterUseHeroPower(Ability SourceAbility, EventAfterUseHeroPower Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        this.myEv.Invoke(sc,tc,sz,tz);
    }
}

public class EffectUseHeroPower:UnitEffect
{
    public int SourceId;
    public int TargetId;
	public EffectUseHeroPower(Player srcPlayer, Card OnePower=null, Card Target = null,int SourceId = -1,int TargetId=-1)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = OnePower;
        this.TargetCard = Target;
        this.SourceId = SourceId;
        this.TargetId = TargetId;
	}
	public override void Resolve()
	{
        if(this.SourceId!=-1)
        {
            if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer) == 0)// && this.TargetId!=-1)
                new FakeDragCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.SourceId, this.TargetId, this.SourcePlayer.GetTag(GameTag.IsControledByAI) == 1).AddToQueue();  
            this.SourceCard=this.SourcePlayer.GetCardFromID(this.SourceId);
            this.TargetCard=this.SourcePlayer.GetCardFromID(this.TargetId);
        }

        this.SourcePlayer.SetTag(GameTag.ManaLeft,this.SourcePlayer.GetTag(GameTag.ManaLeft) - this.SourceCard.GetTag(GameTag.Mana));
        this.SourceCard.SetTag(GameTag.AttacksLeftThisTurn,this.SourceCard.GetTag(GameTag.AttacksLeftThisTurn)-1);
        this.SourcePlayer.ChangeTag(GameTag.CntHeroPowerUsed,1);
        if (this.SourceCard.abilityList.Count != 0)
        {
            foreach (Ability abi in this.SourceCard.abilityList)
            {
                abi.Battlecry(this.TargetCard);
            }
        }
        
        for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
        {
            if(this.SourcePlayer.EffectCallBacks[i] is CallBackAfterUseHeroPower)
            {
                this.SourcePlayer.EffectCallBacks[i].Resolve(this.SourceCard,this.TargetCard,(ZoneType)this.SourceCard.GetTag(GameTag.ZoneType),ZoneType.Board); 
            }
        }
        if(this.TargetCard!=null)
        {
            this.SourcePlayer.myGame.actionHistorys.Add(
            new ActionHistory(ActionType.HeroPower,
                this.SourceCard.GetTag(GameTag.EntityId),this.TargetCard.GetTag(GameTag.EntityId),
                this.SourcePlayer.GetTag(GameTag.PlayerID),this.SourceCard.GetTag(GameTag.ZoneType),this.SourceCard.cardDbf.DbfId,
                this.TargetCard.GetTag(GameTag.PlayerID),this.TargetCard.GetTag(GameTag.ZoneType),this.TargetCard.cardDbf.DbfId,
                this.SourcePlayer.myGame.GetTag(GameTag.NowRoundNum),this.SourcePlayer.GetTag(GameTag.NowTurnNum))
            );     
        }
        else
        {
            this.SourcePlayer.myGame.actionHistorys.Add(
            new ActionHistory(ActionType.HeroPower,
                this.SourceCard.GetTag(GameTag.EntityId),-1,
                this.SourcePlayer.GetTag(GameTag.PlayerID),this.SourceCard.GetTag(GameTag.ZoneType),this.SourceCard.cardDbf.DbfId,
                -1,-1,-1,
                this.SourcePlayer.myGame.GetTag(GameTag.NowRoundNum),this.SourcePlayer.GetTag(GameTag.NowTurnNum))
            );
        }
        //this.SourcePlayer.myGame.CleanDeath();
	}
}