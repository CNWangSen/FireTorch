using System.Collections.Generic;

public class EffectChangeIndex:UnitEffect
{
    int TargetId;
    int TargetIndex;
	public EffectChangeIndex(Player srcPlayer, int id, int index)
	{
        this.SourcePlayer = srcPlayer;
        this.TargetId = id;
        this.TargetIndex = index;
	}
	public override void Resolve()
	{
        Card cardToInsert = this.SourcePlayer.GetCardFromID(this.TargetId);
        this.SourcePlayer.board.Remove(cardToInsert);

        if (this.TargetIndex < 0 || this.TargetIndex >= this.SourcePlayer.board.Count)
        {
            this.SourcePlayer.board.Add(cardToInsert);
        }
        else
        {
            this.SourcePlayer.board.Insert(this.TargetIndex, cardToInsert);
        }

        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
            new ChangeActorIndexCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.TargetId, (int)ZoneType.Board, this.TargetIndex).AddToQueue();
    }
}