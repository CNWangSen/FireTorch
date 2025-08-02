using System.Collections;
using System.Collections.Generic;

public class CS1_042:MinionBase{
//NAME=闪金镇步兵
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class CS1_069:MinionBase{
//NAME=沼泽爬行者
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=NONE
}
public class CS1_112:SpellBase{
//NAME=神圣新星
//TEXT=对所有敌方随从造成$2点伤害，为所有友方角色恢复#2点 生命值。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
	public override void Battlecry(Card target=null)
	{
		 TaskDamageEnemyHero(1);
	}
}
public class CS1_113:SpellBase{
//NAME=精神控制
//TEXT=夺取一个敌方随从的控制权。
//MAJ=PRIEST|COST=9|ATK=0|HP=0|RACE=SHADOW
}
public class CS1_129:SpellBase{
//NAME=心灵之火
//TEXT=使一个随从的攻击力等同于其生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CS1_129e:Ability{
//NAME=心灵之火
//TEXT=本随从的攻击力等同于其生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS1_130:SpellBase{
//NAME=神圣惩击
//TEXT=对一个随从造成$3点伤害。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
	}
}
public class CS1_130_Puzzle:SpellBase{
//NAME=神圣惩击
//TEXT=造成$2点伤害。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
