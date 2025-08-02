public class EffectEmote:UnitEffect
{
	public string EmoteString;
    public CardDbf SourceDbf;
    public float Dur;

	public EffectEmote(Player srcPlayer, Card cardToEmote=null, string txt="", CardDbf dbToEmote=null,float dur=1f)
	{
		this.SourcePlayer = srcPlayer;
		this.SourceCard = cardToEmote;
        this.SourceDbf = dbToEmote;
		this.EmoteString = txt;
        this.Dur = dur;
	}
	public override void Resolve()
	{
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            if(SourceCard!=null)
            {
                ZoneType zt = (ZoneType)SourceCard.GetTag(GameTag.ZoneType);
                if(zt==ZoneType.Board || zt==ZoneType.Hero || zt==ZoneType.Power || zt==ZoneType.Hand || zt==ZoneType.Weapon)
                {
                    new CreateEmoteCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.SourceCard.GetTag(GameTag.EntityId), null, this.EmoteString,this.Dur).AddToQueue();
                }
                else{
                    SourceDbf=SourceCard.cardDbf;
                }
                
            }

            if(SourceDbf!=null)
            {
                new CreateEmoteCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), -1, SourceDbf,this.EmoteString,this.Dur).AddToQueue();
            }

        }
	}
}