using System.Collections;
using System.Collections.Generic;

public class DEEP_000:SecretBase{
//NAME=召唤结界
//TEXT=<b>奥秘：</b>当你的回合开始时，召唤你法力值消耗最高的随从的一个复制。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DEEP_001:SpellBase{
//NAME=错位化石
//TEXT=<b>发现</b>一张野兽牌和一张亡灵牌，交换其属性值。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DEEP_001e:Ability{
//NAME=“新”物种！
//TEXT=属性值与另一张牌互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DEEP_002:SpellBase{
//NAME=元素伙伴
//TEXT=随机召唤一个元素伙伴。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<string> ToListSummon = new List<string>(){"DEEP_002t","DEEP_002t2","DEEP_002t3"};
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid(ToListSummon.Choice(owner.myPlayer.randomGen));
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class DEEP_002t:MinionBase{
//NAME=霍法
//TEXT=你的法术的法力值 消耗减少（1）点。
//MAJ=MAGE|COST=3|ATK=4|HP=2|RACE=ELEMENTAL
}
public class DEEP_002t2:MinionBase{
//NAME=烙欧克
//TEXT=<b>法术伤害+2</b>
//MAJ=MAGE|COST=3|ATK=2|HP=4|RACE=ELEMENTAL
}
public class DEEP_002t3:MinionBase{
//NAME=米霜
//TEXT=<b>扰魔</b>
//MAJ=MAGE|COST=3|ATK=4|HP=4|RACE=ELEMENTAL
	public override void Init()
	{
		TaskInitAbility("Elusive");
	}
}
public class DEEP_002te:Ability{
//NAME=挥霍之法
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DEEP_003:SpellBase{
//NAME=磷光射击
//TEXT=造成$1点伤害，随机召唤一个法力值消耗与伤害量相同的随从。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=ARCANE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
        TaskCreate(CardDbf.GetCardDbfByGuid("VAC_447"),ZoneType.Board);
    }
}
public class DEEP_004:MinionBase{
//NAME=地幔塑型者
//TEXT=本牌在你手中时，你每施放一个法术，本牌的法力值消耗便减少（1）点。
//MAJ=MAGE|COST=5|ATK=5|HP=5|RACE=ELEMENTAL
}
public class DEEP_005:MinionBase{
//NAME=黑曜亡魂
//TEXT=<b>嘲讽</b>。<b>亡语：</b>随机召唤两个法力值消耗小于或等于（3）点的<b>亡语</b>随从。
//MAJ=HUNTER|COST=6|ATK=4|HP=6|RACE=ELEMENTAL
}
public class DEEP_006:MinionBase{
//NAME=岩石幼龙
//TEXT=<b>圣盾</b>，<b>嘲讽</b>，<b>吸血</b>，<b>扰魔</b>。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=8|RACE=DRAGON
}
public class DEEP_007:MinionBase{
//NAME=无畏爵士芬利
//TEXT=<b>战吼：</b>如果你已经<b>发掘</b>过两次，将所有敌方随从变形成为1/1的鱼人。
//MAJ=PALADIN|COST=3|ATK=2|HP=3|RACE=MURLOC
}
public class DEEP_008:MinionBase{
//NAME=针岩图腾
//TEXT=在你的回合结束时，获得2点护甲值并抽一张牌。
//MAJ=SHAMAN|COST=2|ATK=0|HP=2|RACE=TOTEM
}
public class DEEP_009:SpellBase{
//NAME=向下深挖
//TEXT=对一个随从造成$8点伤害。<b>发掘</b>一个宝藏。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class DEEP_010:SpellBase{
//NAME=余震
//TEXT=对所有随从造成$1点伤害，触发三次。如果你在上个回合施放过法术，则法力值消耗减少（1）点。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
    }
}
public class DEEP_011:SpellBase{
//NAME=灼燃之心
//TEXT=对一个随从造成$2点伤害，如果它依然存活，使你的英雄在本回合中获得+3攻击力。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        
    }
}
public class DEEP_011e:Ability{
//NAME=火焰之心
//TEXT=在本回合中+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DEEP_012:MinionBase{
//NAME=影石潜伏者
//TEXT=<b>突袭</b>。<b>战吼：</b>夺取你的武器并获得其属性值。<b>亡语：</b>还回武器。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=ELEMENTAL
}
public class DEEP_012e:Ability{
//NAME=“借来的”
//TEXT=持有{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DEEP_013:SpellBase{
//NAME=邪能陷隙
//TEXT=对所有随从造成$2点伤害。在你的下个回合开始时，再对所有随从造成$2点伤害。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=FEL
}
public class DEEP_013t:SpellBase{
//NAME=邪能陷隙
//TEXT=在你的下个回合开始时，再对所有随从造成$2点伤害。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=FEL
}
public class DEEP_014:WeaponBase{
//NAME=疾速矿锄
//TEXT=在你的英雄攻击后，抽一张牌。
//MAJ=ROGUE|COST=2|ATK=1|HP=2|RACE=NONE
}
public class DEEP_015:MinionBase{
//NAME=义肢假手
//TEXT=<b>磁力</b>。<b>复生</b> 可以<b>磁力</b>吸附在机械或亡灵上。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=1|RACE=MECHANICAL
}
public class DEEP_015e:Ability{
//NAME=义肢假手
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DEEP_016:WeaponBase{
//NAME=石英碎击槌
//TEXT=<b>吸血</b>。<b>冻结</b>任何受到你的英雄伤害的角色。
//MAJ=DEATHKNIGHT|COST=4|ATK=3|HP=3|RACE=NONE
}
public class DEEP_017:SpellBase{
//NAME=采矿事故
//TEXT=召唤两个1/1并具有“<b>亡语：</b>召唤一个1/1的脆弱的食尸鬼”的白银之手新兵。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card t = TaskCreate(CardDbf.GetCardDbfByGuid("CS2_101t"),ZoneType.Board);
        Card t2 = TaskCreate(CardDbf.GetCardDbfByGuid("CS2_101t"),ZoneType.Board);
        new EffectGiveAbility(owner.myPlayer,owner,t,"Deathrattle").Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,t2,"Deathrattle").Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,t,"DEEP_017e").Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,t2,"DEEP_017e").Resolve();
    }
}
public class DEEP_017e:Ability{
//NAME=悲惨命运
//TEXT=<b>亡语：</b>召唤一个1/1并具有<b>冲锋</b>且会在回合结束时死亡的食尸鬼。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("HERO_11bpt"),ZoneType.Board);
    }
}
public class DEEP_018:SpellBase{
//NAME=魔菇采掘
//TEXT=使一个随从获得<b>圣盾</b>。<b>发掘</b>一个宝藏。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DEEP_019:LocationBase{
//NAME=赤红岩床
//TEXT=选择一个 受伤的随从，召唤一个它的<b>休眠</b>一回合的复制。
//MAJ=WARRIOR|COST=4|ATK=0|HP=2|RACE=NONE
}
public class DEEP_019e:Ability{
//NAME=赤色抑制
//TEXT=<b>休眠</b>。1回合后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DEEP_020:MinionBase{
//NAME=深岩矿工布莱恩
//TEXT=<b>战吼：</b>如果你的套牌里没有相同的牌，则在本局对战的剩余时间内，你的<b>战吼</b>会触发两次。
//MAJ=WARRIOR|COST=8|ATK=2|HP=4|RACE=NONE
}
public class DEEP_020e:Ability{
//NAME=矿岩深凿
//TEXT=你的战吼会触发两次。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DEEP_021:SpellBase{
//NAME=暗言术：窃
//TEXT=将一个敌方随从移回<b>你</b>的手牌。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class DEEP_022:SpellBase{
//NAME=愚人金
//TEXT=随机获取其他职业的金色海盗牌和元素牌各一张。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DEEP_023:MinionBase{
//NAME=隐藏宝石
//TEXT=<b>潜行</b>。在你的回合结束时，为所有友方角色恢复#2点生命值。
//MAJ=PRIEST|COST=2|ATK=2|HP=2|RACE=ELEMENTAL
}
public class DEEP_024:MinionBase{
//NAME=亮石旋岩虫
//TEXT=<b><b>吸血</b>。快枪：</b>造成5点伤害。<b>锻造：</b>将<b>快枪</b>变为<b>战吼</b>。
//MAJ=PRIEST|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class DEEP_024t:MinionBase{
//NAME=亮石旋岩虫
//TEXT=<b>已锻造</b> <b>吸血</b>。<b>战吼：</b>造成5点伤害。
//MAJ=PRIEST|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class DEEP_025:SpellBase{
//NAME=破碎映像
//TEXT=选择一个非<b>泰坦</b>随从，将一个它的复制置入你的牌库和战场。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DEEP_026:SpellBase{
//NAME=大地坠饰
//TEXT=从你的牌库中<b>发现</b>一张随从牌，为你的英雄恢复等同于其法力值消耗的生命值。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class DEEP_027:MinionBase{
//NAME=暗石守卫
//TEXT=<b>嘲讽</b>。<b>抉择：</b>弃两张牌；或者摧毁你的一个法力水晶。<b>锻造：</b>无需弃牌或摧毁。
//MAJ=DRUID|COST=4|ATK=6|HP=8|RACE=ELEMENTAL
}
public class DEEP_027a:SpellBase{
//NAME=碎裂形态
//TEXT=弃两张牌。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DEEP_027b:SpellBase{
//NAME=法力裂解
//TEXT=摧毁你的一个法力水晶。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class DEEP_027t:MinionBase{
//NAME=暗石守卫
//TEXT=<b>已锻造</b>。<b>嘲讽</b>
//MAJ=DRUID|COST=4|ATK=6|HP=8|RACE=ELEMENTAL
}
public class DEEP_028:SpellBase{
//NAME=晶体结积
//TEXT=获得三个空的法力水晶，每有一个超过上限的法力水晶，召唤一个3/7并具有<b>嘲讽</b>的元素。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NONE
}
public class DEEP_028t:MinionBase{
//NAME=晶体截击者
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=5|ATK=3|HP=7|RACE=ELEMENTAL
}
public class DEEP_029:MinionBase{
//NAME=穴居人宝石投掷者
//TEXT=<b>压轴：</b>你每有一个法力水晶，随机对一个敌人造成1点伤害。
//MAJ=DRUID|COST=3|ATK=3|HP=2|RACE=NONE
}
public class DEEP_030:MinionBase{
//NAME=源质晶簇
//TEXT=<b>战吼，亡语：</b>抽一张牌，并对你的英雄造成2点伤害。
//MAJ=WARLOCK|COST=2|ATK=2|HP=1|RACE=ELEMENTAL
}
public class DEEP_031:SpellBase{
//NAME=混乱化形
//TEXT=造成$5点伤害。随机召唤一个法力值消耗为（5）的随从。摧毁你牌库底的5张牌。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=FEL
}
public class DEEP_032:SpellBase{
//NAME=灵魂冻结
//TEXT=<b>冻结</b>一个随从及其相邻随从，对你的英雄造成等同于所<b>冻结</b>随从数量的伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=FROST
}
public class DEEP_033:MinionBase{
//NAME=化石水晶龙
//TEXT=<b>战吼：</b>随机获得两项<b>额外效果</b>。<b>发掘</b>一个宝藏。
//MAJ=PALADIN|COST=4|ATK=3|HP=4|RACE=BEAST
}
public class DEEP_034:MinionBase{
//NAME=页岩蛛
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=ELEMENTAL
}
public class DEEP_035:MinionBase{
//NAME=炫彩旋岩虫
//TEXT=<b>亡语：</b>使你的每个随从各获得一项随机<b>额外效果</b>。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=ELEMENTAL
}
public class DEEP_036:MinionBase{
//NAME=塞拉赞恩
//TEXT=<b>嘲讽</b>。<b>亡语：</b>使你手牌和牌库中的所有元素牌属性值翻倍。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=5|RACE=ELEMENTAL
}
public class DEEP_036e:Ability{
//NAME=大地母亲的恩惠
//TEXT=攻击力和生命值翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DEEP_037:MinionBase{
//NAME=玛鲁特·缚石
//TEXT=<b>战吼：</b>如果你的套牌里没有相同的牌，<b>发现</b>一个元素并召唤，并将其余的置入你的手牌。
//MAJ=NEUTRAL|COST=7|ATK=5|HP=6|RACE=NONE
}
public class DEEP_999t1:SpellBase{
//NAME=心灵之花
//TEXT=使一个友方随从获得+2/+2。 随机对一个敌方 随从造成$2点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DEEP_999t1e:Ability{
//NAME=心灵之花
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DEEP_999t2:MinionBase{
//NAME=深岩之洲晶簇
//TEXT=在你的回合结束时，对所有敌人造成 2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=ELEMENTAL
}
public class DEEP_999t3:SpellBase{
//NAME=世界之柱碎片
//TEXT=<b>发现</b>一个元素并召唤，并将其余的置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DEEP_999t4:MinionBase{
//NAME=艾泽里特龙
//TEXT=<b>战吼：</b>使你手牌，牌库和战场上的所有其他随从获得+3/+3。
//MAJ=PALADIN|COST=4|ATK=5|HP=5|RACE=ELEMENTAL
}
public class DEEP_999t4e:Ability{
//NAME=艾泽里特耀光
//TEXT=+3/+3。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DEEP_999t5:MinionBase{
//NAME=艾泽里特鱼人
//TEXT=<b>战吼：</b>将你的<b>所有</b>其他随从变形成为法力值消耗增加（3）点的随从。<i>（保留其原始法力值消耗。）</i>
//MAJ=SHAMAN|COST=4|ATK=5|HP=5|RACE=ELEMENTAL
}
public class DEEP_999t5e:Ability{
//NAME=艾泽里特幽光
//TEXT=法力值消耗已调整。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
