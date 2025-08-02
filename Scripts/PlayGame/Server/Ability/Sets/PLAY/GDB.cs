using System.Collections.Generic;
using System;

public class GDB_142:MinionBase{
	public override void Init()
	{
		TaskInitAbility("Charge");
	}
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListDestroy = owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Exclude(owner);
		TaskDestroyTargets(ToListDestroy);
        new EffectEmote(owner.myPlayer,owner,"从未感觉……").Resolve();
        new EffectEmote(owner.myPlayer,owner,"如此强大！").Resolve();

	}
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			return -100;
		}
		return 0;
	}
}