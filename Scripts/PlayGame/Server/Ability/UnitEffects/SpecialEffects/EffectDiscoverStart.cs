using System.Collections.Generic;

public class EffectDiscoverStart:UnitEffect
{
    List<Card> TargetList;
	public EffectDiscoverStart(Player srcPlayer, Card sourceCard, List<Card> Options)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = sourceCard;
        this.TargetList = Options;
	}
	public override void Resolve()
	{
        if (this.TargetList.Count == 0)
        {
            return;
        }
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer) ==1 || this.SourcePlayer.GetTag(GameTag.IsLowPlayer) == 0)
        {
            new EffectCreate(this.SourcePlayer,this.TargetList.Choice(this.SourcePlayer.randomGen), ZoneType.Hand).Resolve();
            return;
        }
        this.SourcePlayer.ChoiceSource = this.SourceCard;
        foreach (Card c in this.TargetList)
        {
            new EffectCreate(this.SourcePlayer,c, ZoneType.Aside).Resolve();
        }
    }
}