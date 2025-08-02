using System.Collections.Generic;

public class EffectBaconshopSell:UnitEffect
{
    int TargetId;
	public EffectBaconshopSell(Player srcPlayer, int id)
	{
        this.SourcePlayer = srcPlayer;
        this.TargetId = id;
	}
	public override void Resolve()
	{
        this.SourcePlayer.SetTag(GameTag.ManaLeft,this.SourcePlayer.GetTag(GameTag.ManaLeft) + 1);
        new EffectMove(this.SourcePlayer,this.SourcePlayer.GetCardFromID(this.TargetId), ZoneType.Board, ZoneType.Removed, silent: true).Resolve();
    }
}