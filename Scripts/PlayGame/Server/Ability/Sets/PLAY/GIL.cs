using System.Collections;
using System.Collections.Generic;

public class GIL_000:Ability{
//NAME=回响附魔
//TEXT=回合结束时如果这张牌仍在手牌中，将其摧毁。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_113:MinionBase{
//NAME=狂暴的狼人
//TEXT=<b>突袭</b>
//MAJ=WARRIOR|COST=3|ATK=3|HP=3|RACE=NONE
}
public class GIL_116:MinionBase{
//NAME=奥术锁匠
//TEXT=<b>战吼：</b> <b>发现</b>一张<b>奥秘</b>牌，并将其置入战场。
//MAJ=MAGE|COST=4|ATK=2|HP=2|RACE=NONE
}
public class GIL_117:MinionBase{
//NAME=狼人憎恶
//TEXT=在你的回合结束时，对所有其他受伤的随从造成2点伤害。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=UNDEAD
}
public class GIL_118:MinionBase{
//NAME=癫狂的医生
//TEXT=<b>亡语：</b>为你的英雄恢复#8点生命值。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=NONE
}
public class GIL_119:MinionBase{
//NAME=坩埚元素
//TEXT=你的其他元素拥有+2攻击力。
//MAJ=NEUTRAL|COST=8|ATK=7|HP=7|RACE=ELEMENTAL
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Elemental) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "GIL_119e";
    }
}
public class GIL_119e:Ability{
//NAME=殚精竭虑
//TEXT=坩埚元素使其获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 2;
        }
        return 0;
    }
}
public class GIL_120:MinionBase{
//NAME=暴怒的双头巨人
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=7|ATK=5|HP=9|RACE=NONE
}
public class GIL_121:MinionBase{
//NAME=黑沼枭兽
//TEXT=<b>法术伤害+2</b>
//MAJ=NEUTRAL|COST=7|ATK=2|HP=8|RACE=NONE
}
public class GIL_124:MinionBase{
//NAME=苔藓恐魔
//TEXT=<b>战吼：</b>消灭所有其他攻击力小于或等于2的随从。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=7|RACE=NONE
}
public class GIL_125:MinionBase{
//NAME=疯帽客
//TEXT=<b>战吼：</b>随机向其他随从丢出三顶帽子。每顶帽子可使随从获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=NONE
}
public class GIL_125e:Ability{
//NAME=帽子
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_128:MinionBase{
//NAME=艾莫莉丝
//TEXT=<b>战吼：</b>使你手牌中所有随从牌的攻击力和生命值翻倍。
//MAJ=HUNTER|COST=10|ATK=8|HP=8|RACE=DRAGON
}
public class GIL_128e:Ability{
//NAME=艾莫莉丝标记
//TEXT=攻击力和生命值翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_130:MinionBase{
//NAME=阴郁的牡鹿
//TEXT=<b>嘲讽，战吼：</b>如果你的牌库中只有法力值消耗为奇数的牌，则获得+2/+2。
//MAJ=DRUID|COST=5|ATK=2|HP=6|RACE=BEAST
}
public class GIL_130e:Ability{
//NAME=寓言
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_134:SpellBase{
//NAME=圣水
//TEXT=对一个随从造成$4点伤害。如果“圣水”消灭该随从，将一张该随从的复制置入你的手牌。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class GIL_142:MinionBase{
//NAME=变色龙卡米洛斯
//TEXT=如果这张牌在你的手牌中，每个回合都会变成你对手手牌中的一张牌。
//MAJ=PRIEST|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class GIL_142e:Ability{
//NAME=变形
//TEXT=随机变成你对手手牌中的一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_143:MinionBase{
//NAME=凶恶的鳞皮兽
//TEXT=<b>吸血</b>，<b>突袭</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=BEAST
}
public class GIL_145:SpellBase{
//NAME=敲响警钟
//TEXT=<b>回响</b> 使一个随从获得+1/+2。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GIL_145e:Ability{
//NAME=钟声
//TEXT=+1/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_147:SpellBase{
//NAME=燃烬风暴
//TEXT=造成$5点伤害，随机分配到所有敌人身上。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class GIL_152:MinionBase{
//NAME=黑嚎炮塔
//TEXT=无法攻击。每当本随从受到伤害时，随机对一个敌人造成3点 伤害。
//MAJ=WARRIOR|COST=7|ATK=3|HP=8|RACE=NONE
}
public class GIL_155:MinionBase{
//NAME=赤环蜂
//TEXT=<b>突袭</b> 受伤时拥有+3攻 击力。
//MAJ=WARRIOR|COST=2|ATK=1|HP=3|RACE=BEAST
}
public class GIL_155e:Ability{
//NAME=激怒
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_156:MinionBase{
//NAME=石英元素
//TEXT=受伤时无法攻击。
//MAJ=PRIEST|COST=5|ATK=5|HP=8|RACE=ELEMENTAL
}
public class GIL_188:MinionBase{
//NAME=镰刀德鲁伊
//TEXT=<b>抉择：</b>变形成为4/2并具有<b>突袭</b>；或者变形成为2/4并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=3|ATK=2|HP=2|RACE=NONE
}
public class GIL_188a:MinionBase{
//NAME=恐豹形态
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class GIL_188b:MinionBase{
//NAME=恐狼形态
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class GIL_188t:MinionBase{
//NAME=镰刀德鲁伊
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class GIL_188t2:MinionBase{
//NAME=镰刀德鲁伊
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class GIL_188t3:MinionBase{
//NAME=镰刀德鲁伊
//TEXT=<b>突袭，嘲讽</b>
//MAJ=DRUID|COST=3|ATK=4|HP=4|RACE=BEAST
}
public class GIL_190:MinionBase{
//NAME=夜鳞龙后
//TEXT=每当一个友方随从获得治疗时，召唤一条3/3的雏龙。
//MAJ=PRIEST|COST=7|ATK=4|HP=9|RACE=DRAGON
}
public class GIL_190t:MinionBase{
//NAME=夜鳞雏龙
//TEXT=
//MAJ=PRIEST|COST=3|ATK=3|HP=3|RACE=DRAGON
}
public class GIL_191:SpellBase{
//NAME=恶魔法阵
//TEXT=召唤四个1/1的小鬼。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class GIL_191t:MinionBase{
//NAME=小鬼
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class GIL_198:MinionBase{
//NAME=窃魂者阿扎莉娜
//TEXT=<b>战吼：</b>将你的手牌替换成对手手牌的 复制。
//MAJ=NEUTRAL|COST=7|ATK=3|HP=3|RACE=UNDEAD
}
public class GIL_200:MinionBase{
//NAME=暮湾镇猎手
//TEXT=<b>潜行</b> 如果这张牌在你的手牌中，每个回合使其攻击力和生命值互换。
//MAJ=HUNTER|COST=3|ATK=2|HP=5|RACE=NONE
}
public class GIL_200e:Ability{
//NAME=Swapped Stats
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_200t:MinionBase{
//NAME=暮湾镇猎手
//TEXT=<b>潜行</b> 如果这张牌在你的手牌中，每个回合使其攻击力和生命值互换。
//MAJ=HUNTER|COST=3|ATK=5|HP=2|RACE=NONE
}
public class GIL_201:MinionBase{
//NAME=南瓜农夫
//TEXT=<b>吸血</b> 如果这张牌在你的手牌中，每个回合使其攻击力和生命值互换。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class GIL_201t:MinionBase{
//NAME=南瓜农夫
//TEXT=<b>吸血</b> 如果这张牌在你的手牌中，每个回合使其攻击力和生命值互换。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=NONE
}
public class GIL_202:MinionBase{
//NAME=吉尔尼斯皇家卫兵
//TEXT=<b>圣盾，突袭</b> 如果这张牌在你的手牌中，每个回合使其攻击力和生命值互换。
//MAJ=NEUTRAL|COST=8|ATK=3|HP=8|RACE=NONE
}
public class GIL_202t:MinionBase{
//NAME=吉尔尼斯皇家卫兵
//TEXT=<b>圣盾，突袭</b> 如果这张牌在你的手牌中，每个回合使其攻击力和生命值互换。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=3|RACE=NONE
}
public class GIL_203:SpellBase{
//NAME=责难
//TEXT=下个回合敌方法术的法力值消耗增加（5）点。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GIL_203e:Ability{
//NAME=责难
//TEXT=在本回合中，你的法术法力值消耗增加（5）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_203e2:Ability{
//NAME=Rebuking
//TEXT=Costs (5) more.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_207:MinionBase{
//NAME=魅影民兵
//TEXT=<b>回响，嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=UNDEAD
}
public class GIL_212:MinionBase{
//NAME=唤鸦者
//TEXT=<b>战吼：</b>随机将两张法力值消耗为（1）的随从牌置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=1|RACE=NONE
}
public class GIL_213:MinionBase{
//NAME=杂毛秘术师
//TEXT=<b>战吼：</b> 随机将一张法力值消耗为（2）的随从牌置入每个玩家的手牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class GIL_504:HeroBase{
//NAME=女巫哈加莎
//TEXT=<b>战吼：</b>对所有随从造成3点伤害。
//MAJ=SHAMAN|COST=8|ATK=0|HP=30|RACE=NONE
}
public class GIL_504h:HeroPowerBase{
//NAME=蛊惑
//TEXT=<b>被动</b> 在你使用一张随从牌后，随机将一张萨满祭司法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_506:SpellBase{
//NAME=偷袭
//TEXT=<b>回响</b> 对一个随从造成 $2点伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GIL_507:MinionBase{
//NAME=失魂的守卫
//TEXT=<b>嘲讽，战吼：</b> 你每有一张手牌，便获得+1生命值。
//MAJ=DRUID|COST=5|ATK=4|HP=1|RACE=NONE
}
public class GIL_507e:Ability{
//NAME=强体
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_508:MinionBase{
//NAME=夜行蝙蝠
//TEXT=<b>战吼：</b>如果你的英雄在本回合受到过伤害，召唤两只1/1的 蝙蝠。
//MAJ=WARLOCK|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class GIL_508t:MinionBase{
//NAME=蝙蝠
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class GIL_510:MinionBase{
//NAME=迷雾幽灵
//TEXT=每当你使用一张<b>回响</b>牌时，获得+1/+1。
//MAJ=ROGUE|COST=4|ATK=3|HP=5|RACE=UNDEAD
}
public class GIL_510e:Ability{
//NAME=迷雾
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_513:MinionBase{
//NAME=迷失的幽魂
//TEXT=<b>亡语：</b>使你的所有随从获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=UNDEAD
}
public class GIL_513e:Ability{
//NAME=恐怖献祭
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_515:MinionBase{
//NAME=捕鼠人
//TEXT=<b>突袭，战吼：</b>消灭一个友方随从，并获得其攻击力和生命值。
//MAJ=WARLOCK|COST=3|ATK=2|HP=2|RACE=UNDEAD
}
public class GIL_515e:Ability{
//NAME=饱餐
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_518:SpellBase{
//NAME=飞翼冲击
//TEXT=对一个随从造成$4点伤害。如果在本回合中有一个随从死亡，该牌的法力值消耗为（1）点。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class GIL_526:MinionBase{
//NAME=龙骨卫士
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便获得+1攻击力和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=7|ATK=3|HP=11|RACE=UNDEAD
}
public class GIL_526e:Ability{
//NAME=为了龙族
//TEXT=+1攻击力并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_527:MinionBase{
//NAME=邪魂审判官
//TEXT=<b>嘲讽，吸血</b>
//MAJ=NEUTRAL|COST=4|ATK=1|HP=6|RACE=DEMON
}
public class GIL_528:MinionBase{
//NAME=迅捷的信使
//TEXT=<b>突袭</b> 如果这张牌在你的手牌中，每个回合使其攻击力和生命值互换。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
}
public class GIL_528t:MinionBase{
//NAME=迅捷的信使
//TEXT=<b>突袭</b> 如果这张牌在你的手牌中，每个回合使其攻击力和生命值互换。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=2|RACE=NONE
}
public class GIL_529:MinionBase{
//NAME=幻术士
//TEXT=<b>法术伤害+1</b> 如果这张牌在你的手牌中，每个回合使其攻击力和生命值互换。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=NONE
}
public class GIL_529t:MinionBase{
//NAME=幻术士
//TEXT=<b>法术伤害+1</b> 如果这张牌在你的手牌中，每个回合使其攻击力和生命值互换。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=1|RACE=NONE
}
public class GIL_530:MinionBase{
//NAME=阴燃电鳗
//TEXT=<b>战吼：</b> 如果你的牌库中只有法力值消耗为偶数的牌，造成2点伤害。
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        bool OnlyEven = true;
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardDbf.ManaCost%2==1)
            {
                OnlyEven=false;
                break;
            }
        }
        if(OnlyEven)
        {
            new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
        }
    }
}
public class GIL_531:MinionBase{
//NAME=女巫的学徒
//TEXT=<b>嘲讽，战吼：</b>随机将一张萨满祭司法术牌置入你的手牌。
//MAJ=SHAMAN|COST=1|ATK=0|HP=1|RACE=BEAST
}
public class GIL_534:MinionBase{
//NAME=荆棘帮暴徒
//TEXT=在你的英雄攻击后，使本随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=QUILBOAR
}
public class GIL_534t:Ability{
//NAME=加强
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_537:SpellBase{
//NAME=致命武装
//TEXT=揭示你牌库中的一张武器牌。对所有随从造成等同于其攻击力的伤害。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class GIL_543:SpellBase{
//NAME=黑暗附体
//TEXT=对一个友方角色造成$2点伤害。<b>发现</b>一张恶魔牌。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class GIL_545:MinionBase{
//NAME=幽灵战马
//TEXT=<b>圣盾，突袭</b>
//MAJ=PALADIN|COST=5|ATK=3|HP=4|RACE=UNDEAD
}
public class GIL_547:MinionBase{
//NAME=达利乌斯·克罗雷
//TEXT=<b>突袭</b> 在克罗雷攻击并消灭一个随从后，获得+2/+2。
//MAJ=WARRIOR|COST=5|ATK=4|HP=5|RACE=NONE
}
public class GIL_547e:Ability{
//NAME=血牙
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_548:SpellBase{
//NAME=怨灵之书
//TEXT=抽三张牌。 弃掉抽到的所有法术牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class GIL_549:MinionBase{
//NAME=时光修补匠托奇
//TEXT=<b>战吼：</b>随机将一张来自过去的<b>传说</b>随从牌置入你的手牌。
//MAJ=MAGE|COST=6|ATK=5|HP=5|RACE=NONE
}
public class GIL_553:SpellBase{
//NAME=精灵之森
//TEXT=你每有一张手牌，便召唤一个1/1的小精灵。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class GIL_553t:MinionBase{
//NAME=小精灵
//TEXT=
//MAJ=DRUID|COST=0|ATK=1|HP=1|RACE=UNDEAD
}
public class GIL_557:MinionBase{
//NAME=被诅咒的海盗
//TEXT=<b>突袭，亡语：</b> 从你的牌库中抽一张<b>连击</b>牌。
//MAJ=ROGUE|COST=6|ATK=5|HP=3|RACE=PIRATE
}
public class GIL_558:MinionBase{
//NAME=沼泽水蛭
//TEXT=<b>吸血</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class GIL_561:MinionBase{
//NAME=黑瘴林树精
//TEXT=<b>战吼：</b>复原你的英雄技能。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class GIL_562:MinionBase{
//NAME=邪巢诱捕蛛
//TEXT=<b>剧毒，突袭</b>
//MAJ=HUNTER|COST=5|ATK=1|HP=3|RACE=BEAST
}
public class GIL_565:MinionBase{
//NAME=逝网蜘蛛
//TEXT=<b>战吼：</b>如果你的英雄在本回合受到过伤害，获得<b>吸血</b>。
//MAJ=WARLOCK|COST=5|ATK=4|HP=6|RACE=BEAST
}
public class GIL_571:SpellBase{
//NAME=巫术时刻
//TEXT=随机召唤一个在本局对战中死亡的友方野兽。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<CardDbf> ToListSummon = new List<CardDbf>();
        foreach(Card c in owner.myPlayer.grave)
        {
            if(c.cardType==CardType.Minion && c.raceType.Contains(RaceType.Beast))
            {
                ToListSummon.Add(c.cardDbf);
            }
        }
        CardDbf ToSummon = ToListSummon.Choice(owner.myPlayer.randomGen);
        if(ToSummon!=null)
        {
            TaskCreate(ToSummon,ZoneType.Board);
        }
    }
}
public class GIL_577:SecretBase{
//NAME=捕鼠陷阱
//TEXT=<b>奥秘：</b>当你的对手在一回合中使用三张牌后，召唤一只6/6的老鼠。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GIL_577t:MinionBase{
//NAME=末日骇鼠
//TEXT=
//MAJ=HUNTER|COST=6|ATK=6|HP=6|RACE=BEAST
}
public class GIL_578:MinionBase{
//NAME=女伯爵阿莎摩尔
//TEXT=<b>战吼：</b>从你的牌库中抽一张<b>突袭</b>牌、<b>吸血</b>牌和<b>亡语</b>牌。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=NONE
}
public class GIL_580:MinionBase{
//NAME=城镇公告员
//TEXT=<b>战吼：</b>从你的牌库中抽一张具有<b>突袭</b>的随从牌。
//MAJ=WARRIOR|COST=1|ATK=1|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDrawKey("Rush");
    }
}
public class GIL_581:MinionBase{
//NAME=缚沙者
//TEXT=<b>战吼：</b>从你的牌库中抽一张元素牌。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=NONE
}
public class GIL_583:MinionBase{
//NAME=图腾啃食者
//TEXT=<b>嘲讽，战吼：</b>消灭你的所有图腾。每消灭一个图腾，便获得+2/+2。
//MAJ=SHAMAN|COST=4|ATK=2|HP=3|RACE=BEAST
}
public class GIL_583e:Ability{
//NAME=啃食图腾
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_584:MinionBase{
//NAME=女巫森林吹笛人
//TEXT=<b>战吼：</b>从你的牌库中抽一张法力值消耗最低的随从牌。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=DEMON
}
public class GIL_586:SpellBase{
//NAME=大地之力
//TEXT=使一个随从获得+2/+2。如果该随从是元素，则随机将一张元素牌置入你的手牌。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class GIL_586e:Ability{
//NAME=风暴之躯
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_596:WeaponBase{
//NAME=银剑
//TEXT=在你的英雄攻击后，你的所有随从获得+1/+1。
//MAJ=PALADIN|COST=8|ATK=3|HP=4|RACE=NONE
}
public class GIL_596e:Ability{
//NAME=银质
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_598:MinionBase{
//NAME=苔丝·格雷迈恩
//TEXT=<b>战吼：</b>重新使用在本局对战中你所使用过的另一职业的卡牌<i>（目标随机而定）</i>。
//MAJ=ROGUE|COST=7|ATK=6|HP=6|RACE=NONE
}
public class GIL_600:SpellBase{
//NAME=静电震击
//TEXT=对一个随从造成$2点伤害。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class GIL_601:MinionBase{
//NAME=巨鳞蠕虫
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便获得+1攻击力和<b>突袭</b>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=BEAST
}
public class GIL_601e:Ability{
//NAME=凶猛沙虫
//TEXT=+1攻击力和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_607:MinionBase{
//NAME=毒药贩子
//TEXT=每当你使用一张法力值消耗为（1）的随从牌，使其获得<b>剧毒</b>。
//MAJ=HUNTER|COST=4|ATK=2|HP=4|RACE=NONE
}
public class GIL_607e:Ability{
//NAME=廉价毒药
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_607t:MinionBase{
//NAME=狩猎犬
//TEXT=<b>回响，突袭</b>
//MAJ=HUNTER|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class GIL_608:MinionBase{
//NAME=女巫森林小鬼
//TEXT=<b>潜行，亡语：</b>随机使一个友方随从获得+2生命值。
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Stealth");
    }
    public override void Deathrattle()
    {
        Card ToBuff=owner.myPlayer.board[0];//.Choice(owner.myPlayer.randomGen);
        if(ToBuff!=null)
        {
            new EffectChange(owner.myPlayer,owner,ToBuff,hpChange:2).Resolve();
        }
    }
}
public class GIL_608e:Ability{
//NAME=灌注
//TEXT=+2生命值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_614:MinionBase{
//NAME=巫毒娃娃
//TEXT=<b>战吼：</b>选择一个随从。<b>亡语：</b>消灭选择的随从。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=NONE
}
public class GIL_614e1:Ability{
//NAME=被巫毒娃娃诅咒
//TEXT=当巫毒娃娃被摧毁时，消灭本随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_614e2:Ability{
//NAME=巫毒娃娃的诅咒
//TEXT=<b>亡语：</b>消灭{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_616:MinionBase{
//NAME=分裂腐树
//TEXT=<b>亡语：</b>召唤两个2/2的分裂树苗。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=4|RACE=UNDEAD
}
public class GIL_616t:MinionBase{
//NAME=分裂树苗
//TEXT=<b>亡语：</b>召唤两个1/1的树枝。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=UNDEAD
}
public class GIL_616t2:MinionBase{
//NAME=树枝
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class GIL_618:MinionBase{
//NAME=格林达·鸦羽
//TEXT=你手牌中的所有随从牌拥有<b>回响</b>。
//MAJ=WARLOCK|COST=6|ATK=3|HP=7|RACE=UNDEAD
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
                new EffectEmote(owner.myPlayer,owner,"回响！").Resolve();
                TaskCreate(sc.cardDbf,ZoneType.Hand);
            }
        }
    }
}
public class GIL_618e:Ability{
//NAME=鸦羽的召唤
//TEXT=拥有<b>回响</b>。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_620:MinionBase{
//NAME=人偶大师多里安
//TEXT=每当你抽到一张随从牌，召唤一个它的1/1复制。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=6|RACE=NONE
}
public class GIL_620e:Ability{
//NAME=恐怖人偶
//TEXT=人偶大师多里安制作了一个1/1复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_622:MinionBase{
//NAME=吸血蚊
//TEXT=<b>战吼：</b>对敌方英雄造成3点伤害。为你的英雄恢复#3点生命值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=BEAST
}
public class GIL_623:MinionBase{
//NAME=女巫森林灰熊
//TEXT=<b>嘲讽</b>。<b>战吼：</b> 你的对手每有一张手牌，本随从便失去1点生命值。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=12|RACE=BEAST
}
public class GIL_623e:Ability{
//NAME=老灰熊
//TEXT=生命值降低。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_624:MinionBase{
//NAME=暗夜徘徊者
//TEXT=<b>战吼：</b>如果它是战场上唯一的一个随从，获得+3/+3。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=BEAST
}
public class GIL_624e:Ability{
//NAME=追猎
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_634:MinionBase{
//NAME=警钟哨卫
//TEXT=<b>战吼，亡语：</b>将一个<b>奥秘</b>从你的牌库中置入战场。
//MAJ=PALADIN|COST=4|ATK=3|HP=4|RACE=NONE
}
public class GIL_635:MinionBase{
//NAME=教堂石像兽
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，则获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class GIL_637:SpellBase{
//NAME=凶猛咆哮
//TEXT=抽一张牌。你每有一张手牌，便获得1点护甲值。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDraw();
        TaskBuffMyHero(arm:owner.myPlayer.hand.Count);
    }
}
public class GIL_640:MinionBase{
//NAME=古董收藏家
//TEXT=每当你抽一张牌时，便获得+1/+1。
//MAJ=MAGE|COST=5|ATK=4|HP=4|RACE=NONE
}
public class GIL_640e:Ability{
//NAME=罕见发现
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_645:MinionBase{
//NAME=篝火元素
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，抽一张牌。
//MAJ=MAGE|COST=5|ATK=5|HP=5|RACE=ELEMENTAL
}
public class GIL_646:MinionBase{
//NAME=发条自动机
//TEXT=使你的英雄技能的伤害和治疗效果翻倍。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=MECHANICAL
}
public class GIL_648:MinionBase{
//NAME=总督察
//TEXT=<b>战吼：</b>摧毁所有敌方<b>奥秘</b>。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=NONE
}
public class GIL_650:MinionBase{
//NAME=驯犬大师肖尔
//TEXT=你的其他随从拥有<b>突袭</b>。
//MAJ=HUNTER|COST=4|ATK=3|HP=6|RACE=NONE
}
public class GIL_650e:Ability{
//NAME=出击！
//TEXT=驯犬大师肖尔使其获得<b>突袭</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_653:WeaponBase{
//NAME=樵夫之斧
//TEXT=<b>亡语：</b>随机使一个友方随从获得+2/+1。
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=NONE
}
public class GIL_653e:Ability{
//NAME=樵夫
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_654:SpellBase{
//NAME=战路
//TEXT=<b>回响</b> 对所有随从造成 $1点伤害。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GIL_655:MinionBase{
//NAME=腐树巨人
//TEXT=在一个友方随从攻击后，获得+1攻击力。
//MAJ=WARRIOR|COST=5|ATK=2|HP=7|RACE=UNDEAD
}
public class GIL_655e:Ability{
//NAME=生长
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_658:MinionBase{
//NAME=碎枝
//TEXT=<b>战吼：</b>选择一个友方随从。将它的一张10/10复制置入你的手牌，其法力值消耗为（10）点。
//MAJ=DRUID|COST=8|ATK=8|HP=8|RACE=UNDEAD
}
public class GIL_658e:Ability{
//NAME=碎枝化
//TEXT=碎枝将其变为了10/10。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_661:SpellBase{
//NAME=神圣赞美诗
//TEXT=为所有友方角色恢复#6点 生命值。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class GIL_663:SpellBase{
//NAME=女巫森林苹果
//TEXT=将两张2/2的树人置入你的手牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class GIL_663t:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class GIL_664:MinionBase{
//NAME=三眼乌鸦
//TEXT=每当你施放一个法术，随机召唤一个法力值消耗为（2）的 随从。
//MAJ=MAGE|COST=4|ATK=3|HP=3|RACE=BEAST
}
public class GIL_665:SpellBase{
//NAME=虚弱诅咒
//TEXT=<b>回响</b> 直到你的下个回合，使所有敌方随从获得-2攻击力。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class GIL_665e:Ability{
//NAME=虚弱诅咒
//TEXT=直到下个回合，获得-2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_667:MinionBase{
//NAME=腐烂的苹果树
//TEXT=<b>嘲讽</b>。<b>亡语：</b>为你的英雄恢复#6点生命值。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=UNDEAD
}
public class GIL_672:WeaponBase{
//NAME=幽灵弯刀
//TEXT=<b>吸血</b> 每当你使用一张另一职业的卡牌时，获得+1耐久度。
//MAJ=ROGUE|COST=4|ATK=2|HP=2|RACE=NONE
}
public class GIL_672e:Ability{
//NAME=阴森可怖
//TEXT=耐久度提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_677:MinionBase{
//NAME=面具收集者
//TEXT=<b>回响，战吼：</b>随机将一张<b>传说</b>随从牌置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=2|HP=2|RACE=NONE
}
public class GIL_678:MinionBase{
//NAME=冥光鱼人
//TEXT=<b>回响</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=MURLOC
}
public class GIL_680:MinionBase{
//NAME=胡桃精
//TEXT=<b>回响</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class GIL_681:MinionBase{
//NAME=梦魇融合怪
//TEXT=<i>本随从拥有全部随从类型。</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=ALL
}
public class GIL_682:MinionBase{
//NAME=泥沼狩猎者
//TEXT=<b>突袭，战吼：</b>为你的对手召唤两个2/1的泥沼怪。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=8|RACE=NONE
}
public class GIL_682t:MinionBase{
//NAME=泥沼怪
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class GIL_683:MinionBase{
//NAME=沼泽幼龙
//TEXT=<b>战吼：</b>为你的对手召唤一个2/1并具有<b>剧毒</b>的幼龙猎手。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=4|RACE=DRAGON
}
public class GIL_683t:MinionBase{
//NAME=幼龙猎手
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class GIL_685:MinionBase{
//NAME=圣光楷模
//TEXT=如果本随从的攻击力大于或等于3，便拥有<b>嘲讽</b>和<b>吸血</b>。
//MAJ=PALADIN|COST=3|ATK=2|HP=5|RACE=NONE
}
public class GIL_687:SpellBase{
//NAME=通缉令
//TEXT=对一个随从造成$3点伤害。如果“通缉令”消灭该随从，将一张幸运币置入你的手牌。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class GIL_691:MinionBase{
//NAME=大法师阿鲁高
//TEXT=每当你抽到一张随从牌，将一张它的复制置入你的手牌。
//MAJ=MAGE|COST=2|ATK=2|HP=2|RACE=NONE
}
public class GIL_692:MinionBase{
//NAME=吉恩·格雷迈恩
//TEXT=<b>对战开始时：</b>如果你的套牌中只有法力值消耗为偶数的牌，你的初始英雄技能的法力值消耗变为（1）点。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=5|RACE=NONE
	public override void RegisterEventEffect()
	{
		base.RegisterEventEffect();
		owner.myPlayer.AddCallBack(new CallBackAfterGameStart(this,CauseEvent));
	}
	public void CauseEvent()
	{
		bool OnlyEven = true;
		foreach(Card c in owner.myPlayer.deck)
		{
			if(c.cardDbf.ManaCost%2==1)
			{
				OnlyEven=false;
				break;
			}
		}
		if(OnlyEven)
		{
			if(owner.myPlayer.power.Count>0)
			{
				Card PowCard = owner.myPlayer.power[0];
				new EffectChange(owner.myPlayer,owner,PowCard,1-PowCard.GetTag(GameTag.Mana)).Resolve();
			}
		}
	}
}
public class GIL_692e:Ability{
//NAME=乌尔诅咒
//TEXT=你的<b>英雄技能</b>的法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_693:MinionBase{
//NAME=鲜血女巫
//TEXT=在你的回合开始时，对你的英雄造成 1点伤害。
//MAJ=WARLOCK|COST=4|ATK=3|HP=6|RACE=NONE
}
public class GIL_694:MinionBase{
//NAME=利亚姆王子
//TEXT=<b>战吼：</b>将你牌库中所有法力值消耗为（1）的牌变为<b>传说</b>随从牌。
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class GIL_696:SpellBase{
//NAME=搜索
//TEXT=<b>回响</b> 随机将一张<i>（你对手职业的）</i>卡牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GIL_800:MinionBase{
//NAME=暮陨者艾维娜
//TEXT=在每个玩家的回合中，使用的第一张牌法力值消耗为（0）点。
//MAJ=DRUID|COST=5|ATK=3|HP=7|RACE=NONE
}
public class GIL_800e2:Ability{
//NAME=魔音
//TEXT=法力值消耗为（0）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_801:SpellBase{
//NAME=急速冷冻
//TEXT=<b>冻结</b>一个随从。如果该随从已被<b>冻结</b>，则将其消灭。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FROST
    public override void Battlecry(Card target=null)
    {
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
    }
}
public class GIL_803:MinionBase{
//NAME=民兵指挥官
//TEXT=<b>突袭，战吼：</b>在本回合获得+3攻击力。
//MAJ=WARRIOR|COST=4|ATK=2|HP=5|RACE=NONE
}
public class GIL_803e:Ability{
//NAME=草莽
//TEXT=在本回合中+3攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_805:MinionBase{
//NAME=破棺者
//TEXT=<b>亡语：</b>从你的手牌中召唤一个<b>亡语</b>随从。
//MAJ=PRIEST|COST=6|ATK=6|HP=5|RACE=UNDEAD
    public override void Deathrattle()
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.hand)
        {
            if(c.HasAbility("Deathrattle"))
            {
                Pool.Add(c);
            }
        }
        Card ToMove = Pool.Choice(owner.myPlayer.randomGen);
        if(ToMove!=null)
        {
            new EffectMove(owner.myPlayer,ToMove,ZoneType.Hand,ZoneType.Board).Resolve();
        }
    }
}
public class GIL_807:MinionBase{
//NAME=塑沼者
//TEXT=每当你施放一个法术，从你的牌库中抽一张随从牌。
//MAJ=SHAMAN|COST=7|ATK=4|HP=8|RACE=ELEMENTAL
}
public class GIL_809:MinionBase{
//NAME=破铜烂铁机器人
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=0|HP=9|RACE=MECHANICAL
}
public class GIL_813:SpellBase{
//NAME=鲜活梦魇
//TEXT=选择一个友方随从，召唤一个该随从的复制，且剩余生命值为1点。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class GIL_815:MinionBase{
//NAME=恶毒的银行家
//TEXT=<b>战吼：</b>选择一个友方随从，将一个复制洗入你的牌库。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class GIL_816:MinionBase{
//NAME=沼泽龙蛋
//TEXT=<b>亡语：</b>随机将一张龙牌置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=NONE
}
public class GIL_817:MinionBase{
//NAME=玻璃骑士
//TEXT=<b>圣盾</b> 每当有角色获得你的治疗时，获得<b>圣盾</b>。
//MAJ=PALADIN|COST=4|ATK=4|HP=3|RACE=NONE
}
public class GIL_819:MinionBase{
//NAME=女巫的坩埚
//TEXT=在一个友方随从死亡后，随机将一张萨满祭司法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=4|RACE=NONE
}
public class GIL_820:MinionBase{
//NAME=沙德沃克
//TEXT=<b>战吼：</b>重复在本局对战中你所使用过的所有其他卡牌的<b>战吼</b>效果<i>（目标随机而定）</i>。
//MAJ=SHAMAN|COST=9|ATK=6|HP=6|RACE=NONE
}
public class GIL_825:MinionBase{
//NAME=高弗雷勋爵
//TEXT=<b>战吼：</b>对所有其他随从造成2点伤害。如果有随从死亡，则重复此<b>战吼</b>效果。
//MAJ=WARLOCK|COST=7|ATK=4|HP=4|RACE=UNDEAD
}
public class GIL_826:MinionBase{
//NAME=噬月者巴库
//TEXT=<b>对战开始时：</b>如果你的套牌中只有法力值消耗为奇数的牌，升级你的英雄技能。
//MAJ=NEUTRAL|COST=9|ATK=7|HP=8|RACE=BEAST
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterGameStart(this,CauseEvent));
    }
    public void CauseEvent()
    {
        bool OnlyEven = true;
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardDbf.ManaCost%2==0)
            {
                OnlyEven=false;
                break;
            }
        }
        if(OnlyEven)
        {
            if(owner.myPlayer.power.Count>0)
            {
                Card PowCard = owner.myPlayer.power[0];
                CardDbf Upgraded = CardDbf.GetCardDbfByGuid(PowCard.cardDbf.m_noteMiniGuid+"2");
                
                if(Upgraded!=null)
                {
                    new EffectDestroy(owner.myPlayer,owner,PowCard).Resolve();
                    TaskCreate(Upgraded,ZoneType.Power);
                }
            }
        }
    }
}
public class GIL_827:MinionBase{
//NAME=闪狐
//TEXT=<b>战吼：</b>随机将一张<i>（你对手职业的）</i>卡牌置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class GIL_828:SpellBase{
//NAME=凶猛狂暴
//TEXT=使一个野兽获得+3/+3。将它的三张复制洗入你的牌库，且这些复制都具有+3/+3。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class GIL_828e:Ability{
//NAME=凶猛狂暴
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_833:MinionBase{
//NAME=森林向导
//TEXT=在你的回合结束时，双方玩家各抽 一张牌。
//MAJ=DRUID|COST=4|ATK=1|HP=6|RACE=NONE
}
public class GIL_835:MinionBase{
//NAME=南瓜宝宝
//TEXT=<b>回响，战吼：</b>恢复#2点生命值。
//MAJ=PRIEST|COST=2|ATK=2|HP=1|RACE=NONE
}
public class GIL_836:SpellBase{
//NAME=炽焰祈咒
//TEXT=<b>发现</b>一张<b>战吼</b>随从牌。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=FIRE
}
public class GIL_837:MinionBase{
//NAME=闪光飞蛾
//TEXT=<b>战吼：</b> 如果你的牌库中只有法力值消耗为奇数的牌，使你所有其他随从的生命值翻倍。
//MAJ=PRIEST|COST=5|ATK=4|HP=4|RACE=BEAST
}
public class GIL_837e:Ability{
//NAME=飞蛾之尘
//TEXT=生命值翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_838:MinionBase{
//NAME=黑猫
//TEXT=<b>法术伤害+1，战吼：</b>如果你的牌库中只有法力值消耗为奇数的牌，抽一张牌。
//MAJ=MAGE|COST=3|ATK=3|HP=3|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        bool OnlyEven = true;
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardDbf.ManaCost%2==0)
            {
                OnlyEven=false;
                break;
            }
        }
        if(OnlyEven)
        {
            TaskDraw();
        }
    }
}
public class GIL_840:MinionBase{
//NAME=白衣幽魂
//TEXT=<b>战吼：</b>对你牌库中的所有随从施放“心灵之火”<i>（使其攻击力等同于生命值）</i>。
//MAJ=PRIEST|COST=6|ATK=5|HP=5|RACE=UNDEAD
}
public class GIL_840e:Ability{
//NAME=天使坚毅
//TEXT=攻击力等同于其生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_902:MinionBase{
//NAME=刺喉海盗
//TEXT=<b>连击：</b>使你的武器获得+1攻击力。
//MAJ=ROGUE|COST=3|ATK=2|HP=4|RACE=PIRATE
}
public class GIL_902e:Ability{
//NAME=锐利
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GIL_903:SecretBase{
//NAME=隐秘的智慧
//TEXT=<b>奥秘：</b>当你的对手在一回合中使用三张牌后，抽两张牌。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class GIL_905:MinionBase{
//NAME=食腐幼龙
//TEXT=<b>战吼：</b>如果在本回合中有一个随从死亡，获得<b>剧毒</b>。
//MAJ=HUNTER|COST=5|ATK=3|HP=7|RACE=DRAGON
}
public class GIL_905e:Ability{
//NAME=腐蚀吐息
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
