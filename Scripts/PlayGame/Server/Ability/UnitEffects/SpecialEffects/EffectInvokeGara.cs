using System.Collections.Generic;

public class EffectInvokeGara:UnitEffect
{
	public EffectInvokeGara(Player srcPlayer,Card srcCard)
	{
        this.SourcePlayer = srcPlayer;
        this.SourceCard = srcCard;
	}
	public override void Resolve()
	{
        this.SourcePlayer.ChangeTag(GameTag.CntInvokeGara,1);
        if(this.SourcePlayer.hero.Count>0)
        {
            new EffectChange(this.SourcePlayer,this.SourceCard,this.SourcePlayer.hero[0],atkChange:3).Resolve();
        }
    }
}