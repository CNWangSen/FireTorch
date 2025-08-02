using System.Collections.Generic;

public class EffectGiveAttachment:UnitEffect
{
    public Card AttachmentCard;
	public EffectGiveAttachment(Player srcPlayer, Card source,Card target, Card Power)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = source;
        this.TargetCard = target;
        this.AttachmentCard = Power;
	}
	public override void Resolve()
	{
        this.AttachmentCard.SetTag(GameTag.ZoneType,(int)ZoneType.MinionPower);
		this.TargetCard.attachmentList.Add(this.AttachmentCard);
        this.AttachmentCard.attachedTo = this.TargetCard;
        this.AttachmentCard.SetTag(GameTag.AttacksLeftThisTurn,this.AttachmentCard.GetTag(GameTag.AttacksForOneTurn));
        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
            new GiveActorAttachmentCommand(this.SourcePlayer.GetTag(GameTag.PlayerID),this.SourceCard.GetTag(GameTag.EntityId),this.TargetCard.GetTag(GameTag.EntityId),CardDbf.GetCardDbfByDbfId(this.AttachmentCard.cardDbf.DbfId),this.AttachmentCard.GetTag(GameTag.EntityId)).AddToQueue();
    }
}