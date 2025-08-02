

public class CallBackAfterMove:UnitEffectCallBack
{
    public delegate void EventAfterMove(Card sc,Card tc,ZoneType sz,ZoneType tz);
    public event EventAfterMove myEv;
    public CallBackAfterMove(Ability SourceAbility, EventAfterMove Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        this.myEv.Invoke(sc,tc,sz,tz);
    }
}


public class EffectMove:UnitEffect
{
	public int TargetIndex;
	public bool Silent;
    public bool ToEn;

	public EffectMove(Player srcPlayer, Card cardToMove, ZoneType sourceZone, ZoneType targetZone, int targetIndex = -1, bool silent = false, bool toEn = false)
	{
		this.SourcePlayer = srcPlayer;
		this.SourceCard = cardToMove;
		this.SourceZone = sourceZone;
        this.TargetZone = targetZone;
		this.TargetIndex = targetIndex;
		this.Silent = silent;
        this.ToEn = toEn;
    }
	public override void Resolve()
	{
		if (this.SourceCard == null)
        {
            return;
        }
        if (this.ToEn)
        {
            if (this.SourcePlayer.otherPlayer.zones[(int)this.TargetZone].Count >= this.SourcePlayer.maxnum[(int)this.TargetZone])
            {
                if(this.TargetZone==ZoneType.Weapon)
                {
                    new EffectMove(this.SourcePlayer.otherPlayer,this.SourcePlayer.otherPlayer.weapon[0],ZoneType.Weapon,ZoneType.Grave).Resolve();
                }
                else
                {
                    this.TargetZone = ZoneType.Grave;    
                }
                
            }
        }
        else 
        {
            if (this.SourcePlayer.zones[(int)this.TargetZone].Count >= this.SourcePlayer.maxnum[(int)this.TargetZone])
            {
                if(this.TargetZone==ZoneType.Weapon)
                {
                    new EffectMove(this.SourcePlayer,this.SourcePlayer.weapon[0],ZoneType.Weapon,ZoneType.Grave).Resolve();
                }           
                else
                {
                    this.TargetZone = ZoneType.Grave;
                }
            }  
        }

        this.SourcePlayer.zones[(int)this.SourceZone].Remove(this.SourceCard);

        if (this.ToEn)
        {
            foreach (Ability abi in this.SourceCard.abilityList)
            {
                abi.UnRegisterEventEffect();
            }
            this.SourceCard.myPlayer = this.SourcePlayer.otherPlayer;
            foreach (Ability abi in this.SourceCard.abilityList)
            {
                abi.RegisterEventEffect();
            }
        }

        if (this.TargetIndex == -1)
        {
            if (this.ToEn)
            {
                this.SourcePlayer.otherPlayer.zones[(int)this.TargetZone].Add(this.SourceCard);
            }
            else
            {
                this.SourcePlayer.zones[(int)this.TargetZone].Add(this.SourceCard);
            }

        }
        else
        {
            if (this.ToEn)
            {
                this.SourcePlayer.otherPlayer.zones[(int)this.TargetZone].Insert(this.TargetIndex, this.SourceCard);
            }
            else
            {
                this.SourcePlayer.zones[(int)this.TargetZone].Insert(this.TargetIndex, this.SourceCard);
            }
        }

        this.SourceCard.SetTag(GameTag.ZoneType,(int)this.TargetZone);

        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            new ChangeActorZoneCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), (int)this.SourceZone, this.SourceCard.GetTag(GameTag.EntityId), (int)this.TargetZone, this.TargetIndex, this.ToEn==true?1:0).AddToQueue();
            new UpdateActorCommand(this.SourcePlayer.myGame).AddToQueue();
        }
        for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
        {
            if(this.SourcePlayer.EffectCallBacks[i] is CallBackAfterMove)
            {
                this.SourcePlayer.EffectCallBacks[i].Resolve(this.SourceCard,this.SourceCard,this.SourceZone,this.TargetZone); 
            }
        }
        /*
        if (CardMoveEvent != null && !this.Silent)
        {
            CardMoveEvent.Invoke(this.SourceCard, this.SourceCard, this.SourceZone, this.TargetZone);
        }
        */
        if(this.TargetZone==ZoneType.Hand && this.SourceZone==ZoneType.Board)
            new EffectChange(this.SourcePlayer,this.SourceCard,this.SourceCard,hpChange:-this.SourceCard.GetTag(GameTag.Health)+this.SourceCard.cardDbf.MaxHealth,visualFx:false).Resolve();

        foreach (Card c in this.SourcePlayer.board)
        {
            c.SetTag(GameTag.ZoneIndex, this.SourcePlayer.board.IndexOf(c));
        }

        this.SourcePlayer.myGame.UpdateAura();
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            new UpdateActorCommand(this.SourcePlayer.myGame).AddToQueue();
        }
	}
}