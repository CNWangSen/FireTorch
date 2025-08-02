using System.Collections.Generic;

public class EffectRemoveAttachment:UnitEffect
{
    public Card AttachmentCard;
	public EffectRemoveAttachment(Player srcPlayer, Card source,Card target, Card Power)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = source;
        this.TargetCard = target;
        this.AttachmentCard = Power;
	}
	public override void Resolve()
	{
        this.TargetCard.attachmentList.Remove(this.AttachmentCard);
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
            new RemoveActorAttachmentCommand(this.SourcePlayer.GetTag(GameTag.PlayerID), this.SourceCard.GetTag(GameTag.EntityId), this.TargetCard.GetTag(GameTag.EntityId),this.AttachmentCard.GetTag(GameTag.EntityId)).AddToQueue();
    }
}