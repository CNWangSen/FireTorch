using System.Collections;
using System.Collections.Generic;

public class Mekka1:MinionBase{
//NAME=导航小鸡
//TEXT=在你的回合开始时，消灭本随从，并抽三张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=1|RACE=MECHANICAL
}
public class Mekka2:MinionBase{
//NAME=修理机器人
//TEXT=在你的回合结束时，为一个受伤的角色恢复#6点生命值。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=MECHANICAL
}
public class Mekka3:MinionBase{
//NAME=壮胆机器人3000型
//TEXT=在你的回合结束时，随机使一个随从获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=4|RACE=MECHANICAL
}
public class Mekka3e:Ability{
//NAME=壮胆！
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Mekka4:MinionBase{
//NAME=变鸡器
//TEXT=在你的回合开始时，随机将一个随从变为1/1的小鸡。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=MECHANICAL
}
public class Mekka4e:Ability{
//NAME=变形
//TEXT=被变形为小鸡。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Mekka4t:MinionBase{
//NAME=小鸡
//TEXT=<i>小鸡快跑！</i>
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=BEAST
}
public class hexfrog:MinionBase{
//NAME=青蛙
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=0|ATK=0|HP=1|RACE=BEAST
}
public class PRO_001:MinionBase{
//NAME=精英牛头人酋长
//TEXT=<b>战吼：</b>让两位玩家都具有摇滚的能力！（双方各获得一张强力和弦牌）
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class PRO_001a:SpellBase{
//NAME=我是鱼人
//TEXT=召唤三个、四个或者五个1/1的 鱼人。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class PRO_001at:MinionBase{
//NAME=鱼人
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=MURLOC
}
public class PRO_001b:SpellBase{
//NAME=潜行者的伎俩
//TEXT=造成$4点伤害。抽一张牌。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class PRO_001c:SpellBase{
//NAME=部落的力量
//TEXT=随机召唤一名部落勇士。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
