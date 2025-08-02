using System;
using System.Collections;
using System.Collections.Generic;

public class DS1_233:SpellBase{
//NAME=心灵震爆
//TEXT=对敌方英雄造成$5点伤害。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageEnemyHero(5);
    }
}