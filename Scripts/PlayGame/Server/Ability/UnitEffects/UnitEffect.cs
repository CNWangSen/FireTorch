public class UnitEffect
{
	public Player SourcePlayer;
	public Card SourceCard;
	public ZoneType SourceZone;

	public Player TargetPlayer;
	public Card TargetCard;
	public ZoneType TargetZone;

    public virtual void Resolve()
    {
    }
    public virtual int Resolve(int c=0)
    {
        return -1;
    }
}


public class UnitEffectCallBack
{
	public Ability SourceAbility;
    public virtual void Resolve()
    {
    }

    public virtual void Resolve(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
    }

    public virtual void Resolve(Card sourceCard, string Abiname)
    {
    }

    public virtual void Resolve(Card source,Card target)
    {
    }

    public virtual void Resolve(Card source,Card target, int amount)
    {
    }

    public virtual int Resolve(Card source, int amount)
    {
        return 0;
    }
}


public class ActionHistory
{
    public ActionType actType;
    public int SourceId;
    public int TargetId;

    public int SourcePlayerId;
    public int SourceZoneType;
    public int SourceCardDbfId;

    public int TargetPlayerId;
    public int TargetZoneType;
    public int TargetCardDbfId;

    public int HappenRoundNum;
    public int HappenTurnNum;

    public int TargetingOpt;

    public ActionHistory(ActionType actionType,int srcCid, int tarCid=-1, int srcPid=-1, int srcZt=-1, int srcCdbf=-1, int tarPid=-1, int tarZt=-1,int tarCdbf=-1, int rn=-1, int tn=-1, int opt=-1)
    {
        this.actType = actionType;
        this.SourceId = srcCid;
        this.TargetId = tarCid;

        this.SourcePlayerId = srcPid;
        this.SourceZoneType = srcZt;
        this.SourceCardDbfId = srcCdbf;
        this.TargetPlayerId = tarPid;
        this.TargetZoneType = tarZt;
        this.TargetCardDbfId = tarCdbf;
        this.HappenRoundNum = rn;
        this.HappenTurnNum = tn;

        this.TargetingOpt = opt;
    }

    public ActionHistory GetClone()
    {
        return new ActionHistory(this.actType,this.SourceId,this.TargetId,this.SourcePlayerId,this.SourceZoneType,this.SourceCardDbfId,
            this.TargetPlayerId,this.TargetZoneType,this.TargetCardDbfId,
            this.HappenRoundNum,this.HappenTurnNum,this.TargetingOpt);
    }
}