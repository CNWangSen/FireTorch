using System.Collections;
using System.Collections.Generic;


public class YOD_003:MinionBase
{
//NAME=飞翼守护者
//TEXT=<b>嘲讽</b>。<b>复生</b>。<b>扰魔</b>
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskInitAbility("Reborn");
		TaskInitAbility("Elusive");
	}
}


public class YOD_010:MinionBase{
//NAME=炮火机甲
//TEXT=<b>复生</b>
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Reborn");
	}
}
public class YOD_022:MinionBase{
//NAME=冒进的艇长
//TEXT=在你使用一张随从牌后，对所有随从造成1点伤害。
//MAJ=WARRIOR|COST=1|ATK=1|HP=3|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.cardType==CardType.Minion && sc!=owner)
			{
				TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
			}
		}
	}
}

public class YOD_032:MinionBase
{
//NAME=狂暴邪翼蝠
//TEXT=在本回合中，你的对手每受到1点伤害，本牌的法力值消耗便减少（1）点。
//MAJ=WARRIOR|COST=1|ATK=1|HP=3|RACE=NONE
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			if(owner.myPlayer.otherPlayer.hero.Count>0)
			{
				return -owner.myPlayer.otherPlayer.hero[0].GetTag(GameTag.CntDamageTakenThisTurn);
			}
		}
		return 0;
	}
}

