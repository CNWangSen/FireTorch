using System.Collections.Generic;

public class EffectPlayerDefeat:UnitEffect
{
	public EffectPlayerDefeat(Player srcPlayer)
	{
        this.SourcePlayer = srcPlayer;
	}
	public override void Resolve()
	{
		if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            if (this.SourcePlayer.hero.Count == 0)
            {
                Game.NowGame.EndGame();
            }
        }
    }
}