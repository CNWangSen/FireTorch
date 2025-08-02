using System.Collections;
using System.Collections.Generic;

public class GAME_001:Ability{
//NAME=幸运币祝福
//TEXT=后手出牌会使你的生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GAME_002:MinionBase{
//NAME=幸运币化身
//TEXT=<i>你失去了先手，但比赛依然掌握在 你的手里。</i>
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=NONE
}
public class GAME_003:Ability{
//NAME=幸运币复仇
//TEXT=后手出牌会使你的第一个随从获得增强。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GAME_003e:Ability{
//NAME=幸运币复仇
//TEXT=后手出牌会使你的第一个随从获得增强。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GAME_004:Ability{
//NAME=暂离
//TEXT=你的回合时间减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GAME_005:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target = null)
    {
        owner.myPlayer.SetTag(GameTag.ManaLeft,owner.myPlayer.GetTag(GameTag.ManaLeft) + 1);
        TaskBuffMyHero();
    }
}
public class GAME_005e:Ability{
//NAME=幸运币
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GAME_006:SpellBase{
//NAME=不不不
//TEXT=出于某种原因，你曾经拥有的一张牌被删除了。拿着这张牌吧，它将成为那张牌的替代品！
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GAME_011:Ability{
//NAME=锦标赛简要流程
//TEXT=你的回合时间减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
