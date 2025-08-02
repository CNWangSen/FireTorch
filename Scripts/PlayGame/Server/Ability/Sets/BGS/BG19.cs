using System.Collections;
using System.Collections.Generic;

public class BG19_010:MinionBase{
//NAME=下水道老鼠
//TEXT=<b>亡语：</b>召唤一只2/3并具有<b>嘲讽</b>的龟。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=BEAST
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG19_010t"),ZoneType.Board);
	}
}
public class BG19_010_G:MinionBase{
//NAME=下水道老鼠
//TEXT=<b>亡语：</b>召唤一只4/6并具有<b>嘲讽</b>的龟。
//MAJ=NEUTRAL|COST=2|ATK=6|HP=4|RACE=BEAST
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG19_010_Gt"),ZoneType.Board);
	}
}
public class BG19_010_Gt:MinionBase{
//NAME=半甲龟
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=4|HP=6|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}
}
public class BG19_010t:MinionBase{
//NAME=半甲龟
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=3|RACE=BEAST
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}

public class FP1_010:MinionBase{
//NAME=迈克斯纳
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=6|ATK=2|HP=8|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Poisonous");
    }
}
public class FP1_010_G:MinionBase{
//NAME=迈克斯纳
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=6|ATK=2|HP=8|RACE=BEAST
    public override void Init()
    {
    	TaskSetGolden();
        TaskInitAbility("Poisonous");
    }
}
public class TB_BaconUps_155:MinionBase{
//NAME=迈克斯纳
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=6|ATK=2|HP=8|RACE=BEAST
    public override void Init()
    {
    	TaskSetGolden();
        TaskInitAbility("Poisonous");
    }
}