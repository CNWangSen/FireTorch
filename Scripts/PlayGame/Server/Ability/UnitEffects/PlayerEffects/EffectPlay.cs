using System.Collections.Generic;

public class CallBackBeforePlay:UnitEffectCallBack
{
    public delegate void EventBeforePlayCard(Card sc,Card tc,ZoneType sz,ZoneType tz);
    public event EventBeforePlayCard myEv;
    public CallBackBeforePlay(Ability SourceAbility, EventBeforePlayCard Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        this.myEv.Invoke(sc,tc,sz,tz);
    }
}
public class CallBackAfterPlay:UnitEffectCallBack
{
    public delegate void EventAfterPlayCard(Card sc,Card tc,ZoneType sz,ZoneType tz);
    public event EventAfterPlayCard myEv;
    public CallBackAfterPlay(Ability SourceAbility, EventAfterPlayCard Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        this.myEv.Invoke(sc,tc,sz,tz);
    }
}

public class EffectPlay:UnitEffect
{
	public int MinionIndex;
    public int CardId;
    public int TargetId;

	public EffectPlay(Player srcPlayer, Card playedCard = null, Card target = null, int minionindex = -1, int CardId = -1, int TargetId = -1)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = playedCard;
        this.TargetCard = target;
        this.MinionIndex = minionindex;
        this.CardId = CardId;
        this.TargetId = TargetId;
	}
	public override void Resolve()
	{
        if(this.CardId!= -1)
        {
            if ((this.SourcePlayer.GetTag(GameTag.IsSimPlayer) == 0))
                new FakeDragCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.CardId, this.TargetId, this.SourcePlayer.GetTag(GameTag.IsControledByAI) == 1).AddToQueue();
            this.SourceCard = this.SourcePlayer.GetCardFromID(this.CardId);
            this.TargetCard = this.SourcePlayer.GetCardFromID(this.TargetId);
        }
        /*
        if (target != null)
            this.cardsTargetedThisTurn.Add(target);
        this.cardsPlayedThisGame[this.cardsPlayedThisGame.Count - 1].Add(playedCard);
        */
        ZoneType SrcZone = (ZoneType)this.SourceCard.GetTag(GameTag.ZoneType);
        for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
        {
            if(this.SourcePlayer.EffectCallBacks[i] is CallBackBeforePlay)
            {
                this.SourcePlayer.EffectCallBacks[i].Resolve(this.SourceCard,this.TargetCard,SrcZone,ZoneType.Board); 
            }
        }


        if (this.SourceCard.GetTag(GameTag.IsCanceled)==0)
        {
            
            int ManaCosted = this.SourceCard.GetTag(GameTag.Mana);
            if (ManaCosted>=0)
                this.SourcePlayer.SetTag(GameTag.ManaLeft,this.SourcePlayer.GetTag(GameTag.ManaLeft) - ManaCosted);
            switch (this.SourceCard.cardType)
            {
                case (CardType.Spell):
                    {
                        new EffectMove(this.SourcePlayer, this.SourceCard, SrcZone, ZoneType.Grave).Resolve();
                        break;
                    }
                case (CardType.Minion):
                    {

                        if(this.MinionIndex == -1001)//Marvel Snap Board Left
                        {
                            new EffectMove(this.SourcePlayer, this.SourceCard, SrcZone, ZoneType.BoardLeft,-1).Resolve();
                        }
                        if(this.MinionIndex == -1002)//Marvel Snap Board Middle
                        {
                            new EffectMove(this.SourcePlayer, this.SourceCard, SrcZone, ZoneType.Board,-1).Resolve();
                        }
                        if(this.MinionIndex == -1003)//Marvel Snap Board Right
                        {
                            new EffectMove(this.SourcePlayer, this.SourceCard, SrcZone, ZoneType.BoardRight,-1).Resolve();
                        }
                        if(this.MinionIndex >= -1)
                        {
                            new EffectMove(this.SourcePlayer, this.SourceCard, SrcZone, ZoneType.Board, this.MinionIndex).Resolve();
                        }                        
                        break;
                    }
                case (CardType.Weapon):
                    {
                        new EffectMove(this.SourcePlayer, this.SourceCard, SrcZone, ZoneType.Weapon).Resolve();
                        break;
                    }
                case (CardType.Secret):
                    {
                        new EffectMove(this.SourcePlayer, this.SourceCard, SrcZone, ZoneType.Head).Resolve();
                        break;
                    }
                case (CardType.Hero):
                    {
                        Card OldHero = this.SourcePlayer.hero[0];
                        new EffectChange(this.SourcePlayer,this.SourceCard,this.SourceCard,atkChange:-this.SourceCard.GetTag(GameTag.Attack)+OldHero.GetTag(GameTag.Attack),hpChange:-this.SourceCard.GetTag(GameTag.Health)+OldHero.GetTag(GameTag.Health),armChange:this.SourceCard.GetTag(GameTag.Armor),visualFx:false).Resolve();
                        new EffectMove(this.SourcePlayer, this.SourceCard, SrcZone, ZoneType.Hero, 0).Resolve();
                        new EffectMove(this.SourcePlayer, OldHero, ZoneType.Hero, ZoneType.Removed, silent:true).Resolve();
                        break;                        
                    }
                default:
                    {
                        new EffectMove(this.SourcePlayer, this.SourceCard, SrcZone, ZoneType.Grave, -1).Resolve();
                        break;
                    }
            }
            if ((this.SourcePlayer.GetTag(GameTag.IsSimPlayer) == 0)){
                if(this.SourceCard.cardType==CardType.Minion)
                {
                    //new CreateSpellTableVfxCommand(this.SourceCard.GetTag(GameTag.EntityId),SpellType.SUMMON_IN_FRIENDLY).AddToQueue();
                    if(this.SourceCard.HasAbility("Battlecry"))
                        new CreateSpellTableVfxCommand(this.SourceCard.GetTag(GameTag.EntityId),SpellType.BATTLECRY).AddToQueue();
                }                
            }

            if (this.SourceCard.abilityList.Count != 0)
            {
                for (int i = 0; i < this.SourceCard.abilityList.Count; i++)
                {
                    this.SourceCard.abilityList[i].Battlecry(this.TargetCard);
                }
            }
            /*
                if (CardPlayedEvent != null)
                    CardPlayedEvent.Invoke(playedCard, target, SrcZone, ZoneType.Board);
            */
            for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
            {
                if(this.SourcePlayer.EffectCallBacks[i] is CallBackAfterPlay)
                {
                    this.SourcePlayer.EffectCallBacks[i].Resolve(this.SourceCard,this.TargetCard,SrcZone,ZoneType.Board); 
                }
            }
            if(this.TargetCard!=null)
            {
                this.SourcePlayer.myGame.actionHistorys.Add(
                new ActionHistory(ActionType.PlayCard,
                    this.SourceCard.GetTag(GameTag.EntityId),this.TargetCard.GetTag(GameTag.EntityId),
                    this.SourcePlayer.GetTag(GameTag.PlayerID),this.SourceCard.GetTag(GameTag.ZoneType),this.SourceCard.cardDbf.DbfId,
                    this.TargetCard.GetTag(GameTag.PlayerID),this.TargetCard.GetTag(GameTag.ZoneType),this.TargetCard.cardDbf.DbfId,
                    this.SourcePlayer.myGame.GetTag(GameTag.NowRoundNum),this.SourcePlayer.GetTag(GameTag.NowTurnNum))
                );     
            }
            else
            {
                this.SourcePlayer.myGame.actionHistorys.Add(
                new ActionHistory(ActionType.PlayCard,
                    this.SourceCard.GetTag(GameTag.EntityId),-1,
                    this.SourcePlayer.GetTag(GameTag.PlayerID),this.SourceCard.GetTag(GameTag.ZoneType),this.SourceCard.cardDbf.DbfId,
                    -1,-1,-1,
                    this.SourcePlayer.myGame.GetTag(GameTag.NowRoundNum),this.SourcePlayer.GetTag(GameTag.NowTurnNum))
                );
            }
        }
        //this.SourcePlayer.myGame.CleanDeath();
	}
}