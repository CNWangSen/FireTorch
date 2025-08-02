using System;
using System.Collections;
using System.Collections.Generic;

public class DiscardOnTurnEnd:Ability
{
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
		{
			new EffectMove(owner.myPlayer,owner,ZoneType.Hand,ZoneType.Grave).Resolve();
		}
	}
}

public class CastWhenDrawn:Ability
{
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sc==owner && sz==ZoneType.Deck && tz==ZoneType.Hand)
		{
			foreach(Ability abi in owner.abilityList)
			{
				abi.Battlecry();
			}
			new EffectMove(owner.myPlayer,owner,ZoneType.Hand,ZoneType.Grave).Resolve();
			TaskDraw();
		}
	}
}