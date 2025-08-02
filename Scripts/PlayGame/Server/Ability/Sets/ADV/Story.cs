using System.Collections;
using System.Collections.Generic;

public class Story_01_Aethas:HeroBase{
//NAME=艾萨斯·夺日者
//TEXT=<i>他代表着肯瑞托中的部落成员，但他的日子就要到头了。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_01_AethasHP:HeroPowerBase{
//NAME=奥能绽放
//TEXT=对敌方英雄造成$2点伤害，并在本回合中获得<b>法术伤害+2</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_01_AethasHPe:Ability{
//NAME=奥能绽放
//TEXT=在本回合中，你拥有<b>法术伤害+2</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_01_Antonidas:HeroBase{
//NAME=大法师安东尼达斯
//TEXT=<i>吉安娜一心想拜入他的门下！她只需先说服这名导师。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_AntonidasHP:HeroPowerBase{
//NAME=聪慧绝顶
//TEXT=<b>被动</b> 你的法术会施放两次。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_01_ArcaneKeysmith:MinionBase{
//NAME=奥术锁匠
//TEXT=<b>战吼：</b> <b>发现</b>一张<b>奥秘</b>牌，并将其置入战场。
//MAJ=MAGE|COST=4|ATK=2|HP=2|RACE=NONE
}
public class Story_01_Archimonde:HeroBase{
//NAME=阿克蒙德
//TEXT=<i>这位强大的入侵者自信可以取胜……或许他过于自信了。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_01_ArchimondeHP:HeroPowerBase{
//NAME=混乱之雨
//TEXT=召唤两个6/6的地狱火。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class Story_01_Arthas:HeroBase{
//NAME=阿尔萨斯王子
//TEXT=<i>他的心已被巫妖王的邪恶侵染腐化，然而此时此刻，无人知晓。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_ArthasHP:HeroPowerBase{
//NAME=自卫打击
//TEXT=对所有敌方随从造成2点伤害。如果有随从死亡，则使你的所有随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_01_Bigglesworth:MinionBase{
//NAME=助手比格沃斯
//TEXT=<b>战吼：</b> 从你对手的牌库中<b>发现</b>一张随从牌的复制。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=3|RACE=NONE
}
public class Story_01_BookofRunes:MinionBase{
//NAME=符文之书
//TEXT=在你的回合结束时，你所有手牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class Story_01_CobaltSpellkin:MinionBase{
//NAME=深蓝系咒师
//TEXT=<b>战吼：</b>随机将两张你职业的法力值消耗为（1）的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=5|RACE=DRAGON
}
public class Story_01_FeralSpirit:SpellBase{
//NAME=野性狼魂
//TEXT=召唤两只2/3并具有<b>嘲讽</b>的幽灵狼。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("VAN_EX1_tk11");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class Story_01_FocusingIris:WeaponBase{
//NAME=聚焦之虹
//TEXT=<b>法术伤害+1</b>。<b>战吼：</b>用3/6的水元素填满你的面板。
//MAJ=MAGE|COST=8|ATK=0|HP=3|RACE=NONE
}
public class Story_01_Garrosh:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=<i>征服，战争，好战的渴望驱使着萨尔的继任者。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_01_GarroshHP:HeroPowerBase{
//NAME=部落炮舰
//TEXT=对塞拉摩城门造成$4点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_01_GrayCat:MinionBase{
//NAME=灰猫
//TEXT=<b>法术伤害+1</b>，<b>战吼：</b>抽一张牌。
//MAJ=MAGE|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class Story_01_GromHP:HeroPowerBase{
//NAME=装备血吼
//TEXT=装备血吼。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_01_Grommash:HeroBase{
//NAME=格罗玛什·地狱咆哮
//TEXT=<i>勇猛的兽人战士经历着内心的斗争，战况比之现实更为激烈。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_Iceball:SpellBase{
//NAME=冰球术
//TEXT=造成$6点伤害。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=FROST
}
public class Story_01_Jaina:HeroBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_Jaina2:HeroBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_JainaHP:HeroPowerBase{
//NAME=陨冰
//TEXT=随机对两个敌方随从造成$2点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_01_JainaHP2:HeroPowerBase{
//NAME=二级陨冰
//TEXT=随机对两个敌方随从造成$3点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_01_JainaMid:HeroBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_JainaMid2:HeroBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_JainaMid3:HeroBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_JainaMid4:HeroBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_JainaMid5:HeroBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_JainaMidHP:HeroPowerBase{
//NAME=召唤元素
//TEXT=召唤一个3/6的水元素。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_01_JainaMidHP2:HeroPowerBase{
//NAME=三级召唤元素
//TEXT=召唤一个5/8的水元素。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_01_JainaMidHP3:HeroPowerBase{
//NAME=二级召唤元素
//TEXT=召唤一个4/7的水元素。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_01_JainaYoung:HeroBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_JainaYoungHP:HeroPowerBase{
//NAME=冰霜冲击
//TEXT=造成$1点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_01_JainaYoungHP2:HeroPowerBase{
//NAME=二级冰霜冲击
//TEXT=造成$2点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_01_JainaYoungHP3:HeroPowerBase{
//NAME=三级冰霜冲击
//TEXT=造成$3点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_01_Kaelthas:HeroBase{
//NAME=凯尔萨斯王子
//TEXT=<i>他早已听闻吉安娜的魔法技艺，却不曾了解她和另一位金发王子的恋情。如何向他开口呢……</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_01_KaelthasHP:HeroPowerBase{
//NAME=火焰魔法
//TEXT=<b>被动</b> 在你施放一个法术后，将一张“火球术”置入你的牌库，其法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_01_KaelthasHPe:Ability{
//NAME=火焰魔法附加效果
//TEXT=法力值消耗增加（2）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_01_Kalec:MinionBase{
//NAME=大法师卡雷
//TEXT=你每个回合使用的第一张法术牌的法力值消耗为（0）点。<b>战吼：</b>从你的牌库中抽一张法术牌。
//MAJ=MAGE|COST=5|ATK=4|HP=6|RACE=DRAGON
}
public class Story_01_LibramofWisdom:SpellBase{
//NAME=智慧圣契
//TEXT=使一个随从获得+1/+1，以及“<b>亡语：</b>将一张‘智慧圣契’法术牌置入你的手牌。”
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,atkChange:1,hpChange:1).Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,target,"BT_025e").Resolve();
    }
}
public class Story_01_LordaeronAttendant:MinionBase{
//NAME=洛丹伦侍从
//TEXT=<b>战吼：</b>在本局对战中，你的圣契的法力值消耗减少（1）点。
//MAJ=PALADIN|COST=1|ATK=1|HP=3|RACE=NONE
}
public class Story_01_Malfurion:MinionBase{
//NAME=玛法里奥·怒风
//TEXT=
//MAJ=MAGE|COST=4|ATK=4|HP=7|RACE=NONE
}
public class Story_01_Malkorok:MinionBase{
//NAME=马尔考罗克
//TEXT=<b>战吼：</b>随机装备一把武器。
//MAJ=WARRIOR|COST=7|ATK=6|HP=5|RACE=NONE
}
public class Story_01_Nordrassil:MinionBase{
//NAME=诺达希尔
//TEXT=
//MAJ=MAGE|COST=4|ATK=4|HP=7|RACE=NONE
}
public class Story_01_RunicSpell:Ability{
//NAME=符文法术
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_01_Shandris:MinionBase{
//NAME=珊蒂斯·羽月
//TEXT=<b>潜行，战吼：</b>消灭对手场上最左边和最右边的随从。
//MAJ=HUNTER|COST=7|ATK=5|HP=6|RACE=NONE
}
public class Story_01_StaffofAntonidas:WeaponBase{
//NAME=安东尼达斯之杖
//TEXT=每当你施放一个法术，将一张“火球术”法术牌置入你的手牌。
//MAJ=MAGE|COST=7|ATK=0|HP=3|RACE=NONE
}
public class Story_01_StargazeElemental:MinionBase{
//NAME=观星元素
//TEXT=在你使用最右边的一张手牌后，抽 一张牌。
//MAJ=MAGE|COST=3|ATK=2|HP=4|RACE=ELEMENTAL
}
public class Story_01_TheramoreGates:MinionBase{
//NAME=塞拉摩城门
//TEXT=<b>嘲讽，亡语：</b>对你的英雄造成3点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=10|RACE=NONE
}
public class Story_01_TheramoreGuard:MinionBase{
//NAME=塞拉摩守卫
//TEXT=<b>冲锋，亡语：</b>对你的英雄造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=NONE
}
public class Story_01_Thrall:HeroBase{
//NAME=萨尔
//TEXT=<i>前任大酋长赶回来维系和平，可他真的能做到吗？</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_01_ThrallHP:HeroPowerBase{
//NAME=空气之灵
//TEXT=使所有友方随从获得<b>风怒</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_01_ThrallHPe:Ability{
//NAME=风灵指引
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_01_ThrallMinion:MinionBase{
//NAME=萨尔
//TEXT=
//MAJ=MAGE|COST=4|ATK=4|HP=7|RACE=NONE
}
public class Story_01_Tyrande:MinionBase{
//NAME=泰兰德·语风
//TEXT=
//MAJ=MAGE|COST=4|ATK=4|HP=7|RACE=NONE
}
public class Story_01_Upgrade:SpellBase{
//NAME=升级
//TEXT=如果你装备着武器，使其获得+1/+1。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_01_VoltaicBurst:SpellBase{
//NAME=流电爆裂
//TEXT=召唤两个1/1并具有<b>突袭</b>的“火花”。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class Story_01_WaterElemental:MinionBase{
//NAME=水元素
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=4|ATK=4|HP=7|RACE=ELEMENTAL
}
public class Story_01_WaterElemental2:MinionBase{
//NAME=水元素
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=4|ATK=5|HP=8|RACE=ELEMENTAL
}
public class Story_02_Baine:MinionBase{
//NAME=被囚禁的贝恩
//TEXT=<b>休眠</b> 击败凯拉格，将贝恩送回父亲身边。
//MAJ=WARRIOR|COST=4|ATK=4|HP=5|RACE=NONE
}
public class Story_02_BeastCompanion:SpellBase{
//NAME=野兽伙伴
//TEXT=随机召唤一个野兽伙伴。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_02_Blackhand:HeroBase{
//NAME=黑手酋长
//TEXT=<i>他将兽人各氏族整合成了部落，一手造就了域中霸业。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_BlackhandHP:HeroPowerBase{
//NAME=黑手
//TEXT=随机消灭一个受伤的敌方随从。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_BloodmaulBrute:MinionBase{
//NAME=血槌蛮兵
//TEXT=在你的回合结束时， 召唤两个2/2的血槌重槌手并使其攻击随机敌人。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=8|RACE=NONE
}
public class Story_02_BloodmaulMauler:MinionBase{
//NAME=血槌重槌手
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class Story_02_Burgle:SpellBase{
//NAME=剽窃
//TEXT=随机将两张<i>（你对手职业的）</i>卡牌置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_02_Cairne:MinionBase{
//NAME=凯恩·血蹄
//TEXT=<b>冲锋</b>，<b>亡语：</b>召唤一个5/5的贝恩·血蹄。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=NONE
}
public class Story_02_Centaur:HeroBase{
//NAME=凯拉格
//TEXT=<i>半人马和牛头人之间的纠纷由来已久，争夺着领土和 资源。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_02_CentaurHP:HeroPowerBase{
//NAME=绑票
//TEXT=将一个敌方随从装进袋子里（米莎除外）。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_Daelin:HeroBase{
//NAME=戴林·普罗德摩尔
//TEXT=<i>战争结束后，吉安娜的父亲决意要根除部落的残余势力。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_02_DaelinHP:HeroPowerBase{
//NAME=战舰起航
//TEXT=召唤一艘库尔提拉斯战舰。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_02_Darkscale:HeroBase{
//NAME=暗鳞女士
//TEXT=<i>心怀怨恨的纳迦时常在这片海岸线上寻衅滋事……</i>
//MAJ=MAGE|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_02_DarkscaleHP:HeroPowerBase{
//NAME=龙卷风
//TEXT=对一个随从造成$4点伤害，超过其生命值的伤害将由左侧或右侧的随从承担。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_Doomhammer:WeaponBase{
//NAME=毁灭之锤
//TEXT=<b>风怒，过载：</b>（2）
//MAJ=SHAMAN|COST=5|ATK=2|HP=8|RACE=NONE
}
public class Story_02_EnchantedFamiliar:MinionBase{
//NAME=魔法伙伴
//TEXT=你的法术的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class Story_02_EnchantedFamiliare:Ability{
//NAME=附魔援助
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_02_EVILCableRat:MinionBase{
//NAME=怪盗布缆鼠
//TEXT=<b>战吼：</b>将一张<b>跟班</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=BEAST
}
public class Story_02_EVILMiscreant:MinionBase{
//NAME=怪盗恶霸
//TEXT=<b>连击：</b>随机将两张<b>跟班</b>牌置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=1|HP=4|RACE=NONE
}
public class Story_02_FrenziedCrocolisk:MinionBase{
//NAME=狂乱的鳄鱼
//TEXT=<b>战吼：</b>如果你手牌中有另一职业的卡牌，则获得+1/+1和<b>突袭</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class Story_02_Gorgrom:HeroBase{
//NAME=食龙者高格鲁姆
//TEXT=<i>这头巨大的戈隆扬言要将雷克萨的族人一举全歼。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_02_GorgromHP:HeroPowerBase{
//NAME=巨怪生长
//TEXT=获得2点护甲值。如果你的护甲值小于5点，则改为获得3点护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_GronnTrap:MinionBase{
//NAME=戈隆陷阱
//TEXT=<b>嘲讽</b> 无法攻击。在你的回合开始时，对敌方英雄造成4点伤害。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=10|RACE=NONE
}
public class Story_02_Haratha:MinionBase{
//NAME=哈拉萨
//TEXT=<b>嘲讽，亡语：</b>对所有敌方随从造成2点 伤害。
//MAJ=HUNTER|COST=3|ATK=4|HP=5|RACE=BEAST
}
public class Story_02_HenchClanBurglar:MinionBase{
//NAME=荆棘帮蟊贼
//TEXT=<b>战吼：</b><b>发现</b>一张另一职业的法术牌。
//MAJ=ROGUE|COST=4|ATK=4|HP=3|RACE=PIRATE
}
public class Story_02_HuntmasterBow:WeaponBase{
//NAME=狩猎大师的弓
//TEXT=在你的英雄攻击后，召唤三条1/1的蛇。
//MAJ=HUNTER|COST=7|ATK=5|HP=2|RACE=NONE
}
public class Story_02_Intimidation:SpellBase{
//NAME=威吓
//TEXT=随机将两张<b>嘲讽</b>随从牌置入你的手牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_KulTiranGuard:MinionBase{
//NAME=库尔提拉斯步兵
//TEXT=<b>法术伤害+2，亡语：</b>对敌方英雄造成3点 伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class Story_02_Leoroxx:HeroBase{
//NAME=莱欧洛克斯
//TEXT=<i>雷克萨的父亲认为自己绝对正确。但事情真的如此吗？</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_LeoroxxHP:HeroPowerBase{
//NAME=训斥
//TEXT=在一回合内，使一个敌方随从的攻击力降低1点。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_Maim:MinionBase{
//NAME=麦姆·黑手
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便获得+1攻击力和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=7|ATK=3|HP=11|RACE=NONE
}
public class Story_02_Marshspawn:MinionBase{
//NAME=沼泽之子
//TEXT=<b>战吼：</b>如果你在上回合施放过法术，<b>发现</b>一张法术牌。
//MAJ=SHAMAN|COST=3|ATK=3|HP=4|RACE=ELEMENTAL
}
public class Story_02_Misha:HeroBase{
//NAME=米莎
//TEXT=<i>想赢得熊的信任并不轻松。你需要耐心。还有零食。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_MishaHP:HeroPowerBase{
//NAME=狂野鞭笞
//TEXT=随机对两个随从各造成1-3点伤害。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_02_MishaTrap:MinionBase{
//NAME=凶恶的捕熊陷阱
//TEXT=<b>嘲讽</b> 无法攻击。在你的回合开始时，对米莎造成4点伤害。
//MAJ=NEUTRAL|COST=0|ATK=2|HP=40|RACE=NONE
}
public class Story_02_Mogrin:MinionBase{
//NAME=伤兵莫戈林
//TEXT=在你的回合开始时，本随从失去2点生命值。无法攻击。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=12|RACE=NONE
}
public class Story_02_MokNathalBow:WeaponBase{
//NAME=莫克纳萨猎弓
//TEXT=<b>战吼：</b>如果你的牌库里没有随从牌，则用随机猎人法术牌填满你的手牌。
//MAJ=HUNTER|COST=7|ATK=4|HP=2|RACE=NONE
}
public class Story_02_Monsoon:SpellBase{
//NAME=季风
//TEXT=对所有随从造成$6点伤害，再对所有敌方随从造成$3点 伤害。
//MAJ=SHAMAN|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class Story_02_Quilboar:HeroBase{
//NAME=残暴的野猪人
//TEXT=<i>这些怪兽正在引起骚乱。最好调查 一番。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_QuilboarHP:HeroPowerBase{
//NAME=都过来！
//TEXT=召唤两个4/2的野猪人猎手。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_QuilboarHunter:MinionBase{
//NAME=野猪人猎手
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=QUILBOAR
}
public class Story_02_Reprimande:Ability{
//NAME=训斥
//TEXT=攻击力降低。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_02_Rexxar:HeroBase{
//NAME=雷克萨
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_RexxarHP:HeroPowerBase{
//NAME=二级战斧投掷
//TEXT=随机对一个敌方随从造成5点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_RexxarMid:HeroBase{
//NAME=雷克萨
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_RexxarMid2:HeroBase{
//NAME=雷克萨
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_RexxarMid3:HeroBase{
//NAME=雷克萨
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_RexxarMid4:HeroBase{
//NAME=雷克萨
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_RexxarMidHP:HeroPowerBase{
//NAME=召唤米莎
//TEXT=召唤米莎。如果她已经在场，则为其恢复1点生命值。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_RexxarMidHP2:HeroPowerBase{
//NAME=二级召唤米莎
//TEXT=召唤米莎。如果她已经在场，则为其恢复2点生命值。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_RexxarMidHP3:HeroPowerBase{
//NAME=三级召唤米莎
//TEXT=召唤米莎。如果她已经在场，则为其恢复3点生命值。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_RexxarMidHP4:HeroPowerBase{
//NAME=战斧投掷
//TEXT=随机对一个敌方随从造成4点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_RexxarWar:HeroBase{
//NAME=雷克萨
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_RexxarWarHP:HeroPowerBase{
//NAME=动物之友
//TEXT=使一只野兽获得+2/+2。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_02_RexxarYoung:HeroBase{
//NAME=雷克萨
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_RexxarYoung2:HeroBase{
//NAME=雷克萨
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_02_Spirit:MinionBase{
//NAME=灵鹰
//TEXT=所有友方攻击无视<b>嘲讽</b>。<b>亡语：</b>对敌方英雄造成5点伤害。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=BEAST
}
public class Story_02_Spirite:Ability{
//NAME=灵翼飞行
//TEXT=你的攻击无视<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_02_Spirite2:Ability{
//NAME=灵翼飞行
//TEXT=灵鹰使其无视<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_02_Sporlar:MinionBase{
//NAME=斯孢勒
//TEXT=你的其他随从拥有+1攻击力。
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class Story_02_Sporlare:Ability{
//NAME=孢子生长
//TEXT=孢子使本随从获得+1攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_02_StuffedSack:MinionBase{
//NAME=塞满的袋子
//TEXT=<b>亡语：</b>将被偷走的随从还给你！
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=NONE
}
public class Story_02_TeachersPet:MinionBase{
//NAME=教师的爱宠
//TEXT=<b>嘲讽，亡语：</b>随机召唤一只法力值消耗为（3）的野兽。
//MAJ=HUNTER|COST=5|ATK=4|HP=5|RACE=BEAST
}
public class Story_02_Tethik:MinionBase{
//NAME=泰希克
//TEXT=<b>嘲讽</b>
//MAJ=HUNTER|COST=3|ATK=4|HP=4|RACE=BEAST
}
public class Story_02_Tuffer:MinionBase{
//NAME=特弗
//TEXT=<b>冲锋</b>
//MAJ=HUNTER|COST=3|ATK=4|HP=3|RACE=BEAST
}
public class Story_02_Warship:MinionBase{
//NAME=库尔提拉斯战舰
//TEXT=<b>嘲讽</b> 在你的回合开始时，随机从你的牌库中召唤两个随从。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
}
public class Story_02_WinkFox:MinionBase{
//NAME=魅眼狐
//TEXT=<b>战吼：</b>复制你对手的牌库中的一张牌，并将其置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class Story_02_WoundedFootman:MinionBase{
//NAME=受伤的步兵
//TEXT=<b>法术伤害+2，战吼：</b>对自身造成2点伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class Story_03_Anduin:HeroBase{
//NAME=安度因·乌瑞恩王子
//TEXT=<i>瓦里安国王的儿子真是愚不可及，竟然来侵扰部落。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_03_AnduinHP:HeroPowerBase{
//NAME=祥和钟杵
//TEXT=在本回合中，使祥和圣钟<b>休眠</b>。造成4点伤害，随机分配到所有敌人身上。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_03_Baine:MinionBase{
//NAME=贝恩·血蹄
//TEXT=<b>战吼：</b>为你的英雄恢复#10点生命值。
//MAJ=SHAMAN|COST=4|ATK=5|HP=6|RACE=NONE
}
public class Story_03_Beram:MinionBase{
//NAME=博拉姆
//TEXT=<b>风怒</b>
//MAJ=SHAMAN|COST=4|ATK=2|HP=4|RACE=NONE
}
public class Story_03_Cairne:HeroBase{
//NAME=酋长凯恩·血蹄
//TEXT=<i>这位牛头人酋长拥有广博的智慧，丰富的领导经验……还有不少敌人。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_03_CairneHP:HeroPowerBase{
//NAME=战争践踏
//TEXT=对所有敌人造成$1点伤害。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_03_ChargedDoomhammer:WeaponBase{
//NAME=充能的毁灭之锤
//TEXT=<b>风怒</b>，<b>亡语：</b> 使你的所有随从获得<b>风怒</b>。
//MAJ=SHAMAN|COST=5|ATK=3|HP=8|RACE=NONE
}
public class Story_03_ClanTrainer:MinionBase{
//NAME=氏族训练官
//TEXT=你的其他随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=NONE
}
public class Story_03_ClanTrainere:Ability{
//NAME=训练有素
//TEXT=氏族训练官使本随从获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_03_ClanWarrior:MinionBase{
//NAME=氏族战士
//TEXT=<b>嘲讽</b> 当有所有生命值时，本随从拥有+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=6|RACE=NONE
}
public class Story_03_CorruptGarrosh:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=<b>战吼：</b>为你的英雄恢复#5点生命值。对所有敌人造成5点伤害。
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_CorruptGarroshHP:HeroPowerBase{
//NAME=亚煞极之心
//TEXT=<b>被动</b> 在你的回合结束时，将一张你牌库中的随从牌置入你的手牌，其法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_03_DivineBell:MinionBase{
//NAME=圣钟
//TEXT=无法攻击。使友方随从获得+1/+1和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class Story_03_DivineBelle:Ability{
//NAME=煞的力量
//TEXT=本随从拥有+1/+1和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_03_EarthElemental:MinionBase{
//NAME=土元素
//TEXT=<b>嘲讽</b>，<b>过载：</b>（3）
//MAJ=SHAMAN|COST=4|ATK=4|HP=5|RACE=ELEMENTAL
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,2);
    }
}
public class Story_03_ElementalRift:MinionBase{
//NAME=元素裂隙
//TEXT=在你的回合结束时，随机召唤两个元素。<b>亡语：</b>消灭所有元素随从。
//MAJ=SHAMAN|COST=4|ATK=2|HP=7|RACE=NONE
}
public class Story_03_EvenTotem:MinionBase{
//NAME=对偶图腾
//TEXT=如果场上有攻击力为偶数的敌方随从，在你的回合结束时，对这些敌方随从造成2点伤害。
//MAJ=SHAMAN|COST=2|ATK=0|HP=2|RACE=TOTEM
}
public class Story_03_FireElemental:HeroBase{
//NAME=灼热的火元素
//TEXT=<i>躁动的元素发出威胁，即将摧毁部落城市奥格瑞玛！</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_FireElementalHP:HeroPowerBase{
//NAME=焚身化骨
//TEXT=你每控制一个元素，就对所有敌人造成$1点伤害。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_03_FreshPerspective:SpellBase{
//NAME=清新视界
//TEXT=将所有敌方随从移回对手的手牌，并且法力值消耗减半。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_03_Garrosh:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_Garrosh2:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_Garrosh3:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_GarroshArmadaHP:HeroPowerBase{
//NAME=部落炮舰
//TEXT=对塞拉摩城门造成4点伤害，或者随机对一个敌方随从造成2点伤害。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_03_GarroshHP:HeroPowerBase{
//NAME=召唤苦工
//TEXT=召唤一个1/2并具有<b>突袭</b>的战歌苦工。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_03_GarroshHP2:HeroPowerBase{
//NAME=二级召唤苦工
//TEXT=召唤一个2/4并具有<b>突袭</b>的战歌苦工。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_03_GarroshMidHP:HeroPowerBase{
//NAME=装备血吼
//TEXT=装备血吼。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class Story_03_GarroshMidHP2:HeroPowerBase{
//NAME=二级装备血吼
//TEXT=装备血吼。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_03_GarroshMidHP3:HeroPowerBase{
//NAME=三级装备血吼
//TEXT=装备血吼。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_03_Geyah:HeroBase{
//NAME=盖亚安祖母
//TEXT=<i>饱受玛格汉兽人爱戴的老祖母有话要对你讲。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_GeyahHP:HeroPowerBase{
//NAME=智者的劝谏
//TEXT=为所有随从恢复#2点生命值。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_03_Gorehowl:WeaponBase{
//NAME=血吼
//TEXT=<b>剧毒</b> 攻击随从不会消耗耐久度，改为降低1点攻击力。
//MAJ=WARRIOR|COST=7|ATK=7|HP=1|RACE=NONE
}
public class Story_03_Harmonized:Ability{
//NAME=宁静祥和
//TEXT=<b>休眠</b>。 在你的回合唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_03_Harmonized2:Ability{
//NAME=宁静祥和
//TEXT=<b>休眠</b>。 在你的回合唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_03_HordeArmorsmith:MinionBase{
//NAME=部落铸甲师
//TEXT=每当一个友方随从受到伤害，便获得1点护甲值。
//MAJ=WARRIOR|COST=2|ATK=1|HP=4|RACE=NONE
}
public class Story_03_HordeGarrosh:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_HordeGarrosh2:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_Jaina:HeroBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=<i>她的据点和部落的领地接壤，但她住不了多久了……</i>
//MAJ=MAGE|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_03_JainaHP:HeroPowerBase{
//NAME=召唤元素
//TEXT=召唤一个5/8的水元素。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_03_Karnuk:MinionBase{
//NAME=年轻的卡纳克
//TEXT=<b>吸血</b>，<b>流放：</b>召唤一个2/3的光照元素。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=7|RACE=NONE
}
public class Story_03_Magatha:MinionBase{
//NAME=玛加萨·恐怖图腾
//TEXT=<b>剧毒</b>，<b>冲锋</b>
//MAJ=SHAMAN|COST=3|ATK=4|HP=6|RACE=NONE
}
public class Story_03_MakGoraGarrosh:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_MightofHellscream:SpellBase{
//NAME=地狱咆哮之力
//TEXT=使你所有受伤的随从获得+2攻击力。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_03_MightofHellscreame:Ability{
//NAME=力量
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_03_OddTotem:MinionBase{
//NAME=奇兵图腾
//TEXT=如果场上有攻击力为奇数的敌方随从，在你的回合结束时，对敌方英雄造成4点伤害。
//MAJ=SHAMAN|COST=2|ATK=0|HP=2|RACE=TOTEM
}
public class Story_03_Rehgar:HeroBase{
//NAME=雷加尔·大地之怒
//TEXT=<i>他是萨尔信任的朋友，希望与联盟维持和平。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_RehgarHP:HeroPowerBase{
//NAME=平衡决断
//TEXT=召唤一个奇兵图腾或对偶图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_03_Rexxar:MinionBase{
//NAME=雷克萨
//TEXT=<b>战吼：</b>召唤一个动物伙伴。
//MAJ=HUNTER|COST=6|ATK=6|HP=5|RACE=NONE
}
public class Story_03_Runespear:WeaponBase{
//NAME=符文之矛
//TEXT=在你的英雄攻击后，<b>发现</b>一张法术牌，并向随机目标施放。
//MAJ=SHAMAN|COST=8|ATK=3|HP=3|RACE=NONE
}
public class Story_03_Saurfang:MinionBase{
//NAME=瓦罗克·萨鲁法尔
//TEXT=<b>冲锋</b> 在一个友方<b>突袭</b>随从攻击后，对敌方英雄造成4点伤害。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=8|RACE=NONE
}
public class Story_03_Sha:MinionBase{
//NAME=煞
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=NONE
}
public class Story_03_SupplyTower:MinionBase{
//NAME=补给塔楼
//TEXT=无法攻击。 在你的回合开始时，为相邻的随从恢复2点生命值。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=7|RACE=NONE
}
public class Story_03_Thrall:HeroBase{
//NAME=萨尔
//TEXT=<i>萨尔他回来了，带着一群叛徒，来对抗大酋长，对抗真正的部落。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_03_ThrallHP:HeroPowerBase{
//NAME=充能毁灭之锤
//TEXT=装备充能的毁灭之锤。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_03_ThrallMinion:MinionBase{
//NAME=萨尔大酋长
//TEXT=在你的回合，你的英雄拥有+2攻击力和<b>风怒</b>。<b>亡语：</b>将本随从洗入你的牌库。
//MAJ=SHAMAN|COST=7|ATK=5|HP=6|RACE=NONE
}
public class Story_03_TrickTotem:MinionBase{
//NAME=戏法图腾
//TEXT=在你的回合结束时，随机施放一个法力值消耗小于或等于（3）点的法术。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=3|RACE=TOTEM
}
public class Story_03_WarsongAxe:WeaponBase{
//NAME=战歌之斧
//TEXT=在攻击一个随从后，你的英雄可以再次攻击。
//MAJ=WARRIOR|COST=3|ATK=4|HP=2|RACE=NONE
}
public class Story_03_WarsongCommander:MinionBase{
//NAME=战歌指挥官
//TEXT=你的<b>冲锋</b>随从拥有+3攻击力。
//MAJ=WARRIOR|COST=2|ATK=3|HP=3|RACE=NONE
}
public class Story_03_WarsongCommandere:Ability{
//NAME=冲锋
//TEXT=战歌指挥官使本随从获得+3攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_03_WarsongPeon:MinionBase{
//NAME=战歌苦工
//TEXT=<b>突袭</b>
//MAJ=WARRIOR|COST=2|ATK=1|HP=2|RACE=NONE
}
public class Story_03_WarsongPeon2:MinionBase{
//NAME=战歌苦工
//TEXT=<b>突袭</b>
//MAJ=WARRIOR|COST=2|ATK=2|HP=4|RACE=NONE
}
public class Story_03_YoungGarrosh:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_YoungGarrosh2:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_YShaarjsPower:SpellBase{
//NAME=亚煞极之力
//TEXT=<b>任务：</b>消灭六个敌方随从。<b>奖励：</b>堕入腐蚀。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_03_Zarzhet:HeroBase{
//NAME=地下女王扎宰特
//TEXT=<i>亡灵蛛魔迅速袭击了部落……还有部落的苦工。</i>
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_03_ZarzhetHP:HeroPowerBase{
//NAME=黑暗转换
//TEXT=随机对一个敌方随从造成$2点伤害。如果该随从死亡，则召唤一个食尸鬼。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_04_Alonsus:HeroBase{
//NAME=阿隆索斯·法奥
//TEXT=<i>战火在祖国大地上燃烧，宽仁的大主教召唤你前来服役。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_04_AlonsusHP:HeroPowerBase{
//NAME=神圣祈祷
//TEXT=为一个友方随从和你的英雄恢复$1点生命值。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_04_Arthas:HeroBase{
//NAME=阿尔萨斯王子
//TEXT=<i>命中注定的时 刻到了。</i>
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=300|RACE=NONE
}
public class Story_04_Arthase:Ability{
//NAME=受训学徒
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_ArthasHP:HeroPowerBase{
//NAME=天灾大军
//TEXT=召唤三个2/2的食尸鬼。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_ArthasMinion:MinionBase{
//NAME=阿尔萨斯王子
//TEXT=<b>激励：</b>获得+2攻击力。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=PALADIN|COST=4|ATK=3|HP=6|RACE=NONE
}
public class Story_04_ArthasMinionDormant:MinionBase{
//NAME=阿尔萨斯王子
//TEXT=<b>休眠</b>
//MAJ=PALADIN|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_04_BlackrockRaider:MinionBase{
//NAME=黑石袭击者
//TEXT=你的武器拥有+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=NONE
}
public class Story_04_BlackrockRaidere:Ability{
//NAME=尖锐利刃
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_Blademaster:HeroBase{
//NAME=黑石剑圣
//TEXT=<i>战败的兽人卷土 重来，绑架了人类村民！</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_04_BlademasterHP:HeroPowerBase{
//NAME=乱刃风暴
//TEXT=对攻击力最高的敌方随从造成3点伤害，对其余敌方随从造成1点伤害。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_04_BloodclawDragon:MinionBase{
//NAME=血爪巨龙
//TEXT=<b>冲锋</b> 每当本随从攻击时，随机使一个友方随从获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=DRAGON
}
public class Story_04_BloodclawDragone:Ability{
//NAME=巨龙威能
//TEXT=+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_DarknessBeckons:SpellBase{
//NAME=黑暗的召唤
//TEXT=抽三张牌。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_04_DarkPortal:HeroBase{
//NAME=黑暗之门
//TEXT=<i>部落当年从这座诡异的传送门中涌出，现在又要用它趁机逃亡。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=100|RACE=NONE
}
public class Story_04_DarkPortalHP:HeroPowerBase{
//NAME=残酷后撤
//TEXT=消灭一个友方随从。使你的所有随从获得+1/+1。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_04_DivertForces:SpellBase{
//NAME=转移兵力
//TEXT=选择一个友方随从，将它的一张复制洗入你的牌库。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_04_Doomhammer:HeroBase{
//NAME=奥格瑞姆·毁灭之锤
//TEXT=<i>部落的大酋长带着他无情的军队，前来征服洛丹伦。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_04_DoomhammerHP:HeroPowerBase{
//NAME=装备毁灭之锤
//TEXT=装备毁灭之锤。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_04_DoomhammerWeapon:WeaponBase{
//NAME=毁灭之锤
//TEXT=<b>风怒，过载：</b>（2）
//MAJ=SHAMAN|COST=5|ATK=2|HP=8|RACE=NONE
}
public class Story_04_DragonRoar:SpellBase{
//NAME=巨龙怒吼
//TEXT=随机将两张龙牌置入你的手牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_04_ExhaustedRecruit:MinionBase{
//NAME=疲劳的新兵
//TEXT=<b>休眠</b> 当你累计恢复了5点生命值时，唤醒本随从。<i>（还剩下5点！）</i>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_04_FightTrainer:MinionBase{
//NAME=战斗训练师
//TEXT=<b>嘲讽</b> 在你使用一张随从牌后，对所有敌方随从造成1点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class Story_04_FinalStand:SpellBase{
//NAME=决一死战
//TEXT=<b>任务：</b>存活10个回合。 <b>奖励：</b>胜利。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_Frostmourne:WeaponBase{
//NAME=霜之哀伤
//TEXT=<b>亡语：</b>召唤被该武器消灭的所有 随从。
//MAJ=DEATHKNIGHT|COST=7|ATK=5|HP=3|RACE=NONE
}
public class Story_04_GuldanReinforcements:SpellBase{
//NAME=古尔丹的援助
//TEXT=古尔丹背叛了你。消灭所有友方随从。
//MAJ=WARRIOR|COST=8|ATK=0|HP=0|RACE=NONE
}
public class Story_04_HolyWrath:SpellBase{
//NAME=神圣愤怒
//TEXT=抽一张牌，并造成等同于其法力值消耗的伤害。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_04_Iceblade:HeroBase{
//NAME=维宁·冰刃
//TEXT=<i>阿尔萨斯和吉安娜在调查城外的灾祸时遭遇了埋伏。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_04_IcebladeHP:HeroPowerBase{
//NAME=感染
//TEXT=在你的回合结束时，将一个非<b>传说</b>敌方随从变形成为1/1的骷髅，并夺取其控制权。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_IcebladeWeapon:WeaponBase{
//NAME=冰刃
//TEXT=<b>战吼，亡语：</b> 对所有敌方随从造成2点伤害。
//MAJ=DEATHKNIGHT|COST=4|ATK=2|HP=2|RACE=NONE
}
public class Story_04_Infectione:Ability{
//NAME=感染
//TEXT=本随从会在1回合后变形成为骷髅。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_Jaina:MinionBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=<b>法术迸发：</b>召唤一个3/6的水元素。<b>亡语：</b>洗入你的牌库。
//MAJ=MAGE|COST=6|ATK=5|HP=4|RACE=NONE
}
public class Story_04_KelThuzad:MinionBase{
//NAME=克尔苏加德的灵魂
//TEXT=<b>法术迸发：</b>如果法术消灭了任意随从，召唤被消灭的随从。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=NONE
}
public class Story_04_Khadgar:MinionBase{
//NAME=卡德加
//TEXT=<b>法术伤害+2</b> 你每召唤一个随从，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=25|ATK=7|HP=5|RACE=NONE
}
public class Story_04_KingTerenas:MinionBase{
//NAME=泰瑞纳斯国王
//TEXT=<b>战吼：</b>随机使你手牌中的一张随从牌获得+5/+5。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=6|RACE=NONE
}
public class Story_04_KingTerenase:Ability{
//NAME=国王恩赏
//TEXT=+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_LibramofCompassion:SpellBase{
//NAME=悲悯圣契
//TEXT=选择一个友方随从。随机为一个友方随从恢复等同于所选随从攻击力的生命值。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_04_LibramofHoliness:SpellBase{
//NAME=圣洁圣契
//TEXT=使一个随从获得+3生命值。为你的英雄恢复3点生命值。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_04_LibramofHolinesse:Ability{
//NAME=圣洁圣契
//TEXT=+3生命值。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_LibramofJustice:SpellBase{
//NAME=正义圣契
//TEXT=装备一把1/4的武器。将所有敌方随从的生命值变为1。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BT_011t"),ZoneType.Weapon);
        TaskSetHpTargets(owner.myPlayer.otherPlayer.board,1);
    }
}
public class Story_04_Lightbringer:WeaponBase{
//NAME=光明使者之锤
//TEXT=在你的英雄攻击后，随机使一个友方随从获得<b>圣盾</b>和<b>嘲讽</b>。
//MAJ=PALADIN|COST=4|ATK=3|HP=4|RACE=NONE
}
public class Story_04_Lightbringere:Ability{
//NAME=光明使者的祝福
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_MalGanis:HeroBase{
//NAME=玛尔加尼斯
//TEXT=<i>恐惧魔王号令着天灾军团，拦住了你的去路。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_04_MalGanisHP:HeroPowerBase{
//NAME=纳斯雷兹姆的赏赐
//TEXT=<b>被动</b> 在你的回合结束时，使你最左边和最右边的随从获得+3/+3。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_MalganisHPe:Ability{
//NAME=纳斯雷兹姆的赏赐
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_RadiantLightspawn:MinionBase{
//NAME=闪亮的光耀之子
//TEXT=<b>嘲讽，战吼：</b> 在本局对战中，你的圣契的法力值消耗减少（2）点。
//MAJ=PALADIN|COST=5|ATK=4|HP=6|RACE=ELEMENTAL
}
public class Story_04_RadiantLightspawne:Ability{
//NAME=闪亮的光耀之子
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_RavenousDrake:MinionBase{
//NAME=贪食幼龙
//TEXT=<b>嘲讽</b> 你的武器每有1点攻击力，该牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=DRAGON
}
public class Story_04_RoyalUrn:MinionBase{
//NAME=王室骨灰瓮
//TEXT=无法攻击 在你的回合开始时，随机为一个受伤的友方随从恢复5点生命值。
//MAJ=PALADIN|COST=2|ATK=0|HP=5|RACE=NONE
}
public class Story_04_Saurfang:HeroBase{
//NAME=瓦罗克·萨鲁法尔
//TEXT=<i>尽管部落已经后撤，这位传奇战士仍是联盟的巨大威胁。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_04_SaurfangHP:HeroPowerBase{
//NAME=狂放之怒
//TEXT=使一个友方随从获得+3攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_SilverHandCrusader:MinionBase{
//NAME=白银之手远征军
//TEXT=<b>战吼：</b>如果你的牌库中没有中立卡牌，随机将五张圣骑士卡牌置入你的手牌。
//MAJ=PALADIN|COST=7|ATK=7|HP=7|RACE=NONE
}
public class Story_04_SilverHandZealot:MinionBase{
//NAME=白银之手狂热者
//TEXT=<b>战吼：</b> 如果你的牌库中没有中立卡牌，便装备一把4/2的真银圣剑。
//MAJ=PALADIN|COST=4|ATK=4|HP=2|RACE=NONE
}
public class Story_04_TimeOut:SpellBase{
//NAME=暂避锋芒
//TEXT=直到你的 下个回合，你的英雄<b>免疫</b>。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_04_TiredRecruit:MinionBase{
//NAME=劳累的新兵
//TEXT=<b>嘲讽</b>，<b>战吼：</b>对自身造成3点伤害。<b>亡语：</b>进入<b>休眠</b>状态。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=4|RACE=NONE
}
public class Story_04_Tirion:MinionBase{
//NAME=提里奥·弗丁
//TEXT=<b>圣盾</b>，<b>嘲讽</b>，<b>亡语：</b>装备一把1/5的 公正之剑。
//MAJ=PALADIN|COST=8|ATK=6|HP=6|RACE=NONE
}
public class Story_04_TuralyonMinion:MinionBase{
//NAME=图拉扬
//TEXT=<b>突袭</b> 每当其攻击一个随从，将目标的攻击力和生命值变为3。
//MAJ=PALADIN|COST=6|ATK=3|HP=12|RACE=NONE
}
public class Story_04_UnboundRagee:Ability{
//NAME=激怒
//TEXT=+3攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_UnbrokenFaith:SpellBase{
//NAME=不灭信仰
//TEXT=使一个随从获得+2/+2。 抽一张牌。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_04_UnbrokenFaithe:Ability{
//NAME=不灭信仰
//TEXT=+2/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_04_Uther:HeroBase{
//NAME=乌瑟尔·光明使者
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_04_Uther2:HeroBase{
//NAME=乌瑟尔·光明使者
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_04_Uther3:HeroBase{
//NAME=乌瑟尔·光明使者
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_04_Uther4:HeroBase{
//NAME=乌瑟尔·光明使者
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_04_UtherHP:HeroPowerBase{
//NAME=光明使者之锤
//TEXT=装备一把3/4的战锤。在用该战锤攻击后，使一个友方随从获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_04_UtherHP2:HeroPowerBase{
//NAME=二级光明使者之锤
//TEXT=装备一把3/4的战锤。在用该战锤攻击后，使一个友方随从获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_04_UtherHP3:HeroPowerBase{
//NAME=神圣风暴
//TEXT=对一个敌方随从造成$4点伤害，相邻的随从均会受到超过其生命值的伤害。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_04_UtherHP4:HeroPowerBase{
//NAME=二级神圣风暴
//TEXT=对一个敌方随从造成$5点伤害，相邻的随从均会受到超过其生命值的伤害。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_04_UtherPriest:HeroBase{
//NAME=乌瑟尔·光明使者
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_04_UtherYoung:HeroBase{
//NAME=乌瑟尔·光明使者
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_04_UtherYoung2:HeroBase{
//NAME=乌瑟尔·光明使者
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_04_UtherYoung3:HeroBase{
//NAME=乌瑟尔·光明使者
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_04_WallsLordaeron:MinionBase{
//NAME=洛丹伦城墙
//TEXT=无法攻击。 <b>亡语：</b>对你的英雄造成10点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=10|RACE=NONE
}
public class Story_04_YoungUtherHP:HeroPowerBase{
//NAME=轰炸黑暗之门
//TEXT=如果你控制一个随从，对黑暗之门造成10点伤害。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Alleria:MinionBase{
//NAME=奥蕾莉亚·风行者
//TEXT=在你的回合开始时，对敌方英雄造成2点伤害。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=HUNTER|COST=1|ATK=5|HP=6|RACE=NONE
}
public class Story_05_AlleriaDormant:MinionBase{
//NAME=奥蕾莉亚·风行者
//TEXT=<b>休眠</b>
//MAJ=HUNTER|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_05_AllianceCommander:SpellBase{
//NAME=统率联盟
//TEXT=<b>双生法术</b> 召唤两个2/2并具有<b>嘲讽</b>的侍从和一个1/4的联盟攻城塔。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_05_AllianceCommanderts:SpellBase{
//NAME=统率联盟
//TEXT=召唤两个2/2并具有<b>嘲讽</b>的侍从和一个1/4的联盟攻城塔。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_05_AncientBrewmaster:MinionBase{
//NAME=年迈的酒仙
//TEXT=<b>战吼：</b>使一个友方随从从战场上移回你的手牌。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=NONE
}
public class Story_05_Anduin:HeroBase{
//NAME=安度因
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_Anduin2:HeroBase{
//NAME=安度因
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_Anduin3:HeroBase{
//NAME=安度因
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_Anduin4:HeroBase{
//NAME=安度因
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_AnduinHP:HeroPowerBase{
//NAME=圣光思维
//TEXT=从你的牌库中<b>发现</b>一张牌，其法力值消耗减少（1）点。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_05_AnduinHP2:HeroPowerBase{
//NAME=祥和钟杵
//TEXT=在本回合中，使祥和圣钟<b>休眠</b>。造成4点伤害，随机分配到所有敌人身上。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_AnduinKing:HeroBase{
//NAME=安度因
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_AnduinKingHP:HeroPowerBase{
//NAME=装备萨拉迈恩
//TEXT=装备萨拉迈恩。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_05_AnduinSI7:HeroBase{
//NAME=安度因
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_AnduinSI7HP:HeroPowerBase{
//NAME=渗透者的望远镜
//TEXT=检视你对手的牌库顶的三张牌。选择一张置于牌库顶，并使其法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_05_AnduinSI7HPe:Ability{
//NAME=潜入
//TEXT=法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_AnduinYoung:HeroBase{
//NAME=安度因
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_AnduinYoung2:HeroBase{
//NAME=安度因
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_AnduinYoungHP:HeroPowerBase{
//NAME=未知命运
//TEXT=<b>发现</b>一张任意职业的法术牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_05_AnduinYoungHP2:HeroPowerBase{
//NAME=二级未知命运
//TEXT=<b>发现</b>两张任意职业的法术牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Apotheosis:SpellBase{
//NAME=神圣化身
//TEXT=使一个随从获得+2/+3和<b>吸血</b>。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class Story_05_Apotheosise:Ability{
//NAME=神圣化身
//TEXT=+2/+3和<b>吸血</b>。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Bananas:SpellBase{
//NAME=香蕉
//TEXT=<i>现在你可以挑战美猴王了！</i>使一个随从获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_05_BlightCauldron:MinionBase{
//NAME=凋零坩埚
//TEXT=无法攻击。<b>嘲讽</b> 在你的回合开始时，使一个友方随从获得<b>剧毒</b>。<b>亡语：</b>推进战斗。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=50|RACE=NONE
}
public class Story_05_Durja:MinionBase{
//NAME=寻风者杜尔加
//TEXT=<b>嘲讽</b>，<b>风怒</b>。<b>亡语：</b>推进战斗。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=20|RACE=NONE
}
public class Story_05_FaithsDefender:SpellBase{
//NAME=守护信仰
//TEXT=<b>双生法术</b> 使一个友方随从获得<b>嘲讽</b>。抽两张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_05_FaithsDefendere:Ability{
//NAME=保卫信仰
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_FaithsDefenderts:SpellBase{
//NAME=守护信仰
//TEXT=使一个友方随从获得<b>嘲讽</b>。抽两张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Fearbreaker:WeaponBase{
//NAME=碎惧者
//TEXT=在你的英雄攻击后，使你手牌中的一张随从牌获得+1/+1。
//MAJ=PRIEST|COST=4|ATK=3|HP=4|RACE=NONE
}
public class Story_05_Fearbreakere:Ability{
//NAME=无所畏惧
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_ForbiddenWords:SpellBase{
//NAME=禁忌咒文
//TEXT=消耗你所有的法力值。消灭一个攻击力小于或等于所消耗法力值的随从。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Garrosh:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=<i>部落的大酋长触及了不可思议的力量！结局很难看。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_05_GarroshHP:HeroPowerBase{
//NAME=装备血吼
//TEXT=装备血吼。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Greymane:MinionBase{
//NAME=吉恩·格雷迈恩
//TEXT=你的英雄技能法力值消耗减少（2）点。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=NEUTRAL|COST=1|ATK=6|HP=5|RACE=NONE
}
public class Story_05_Greymanee:Ability{
//NAME=吉尔尼斯式节俭
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_GreymaneMinionDormant:MinionBase{
//NAME=吉恩·格雷迈恩
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_05_HighPriestRohan:MinionBase{
//NAME=高阶牧师洛汉
//TEXT=在你的回合结束时，召唤两个在本局对战中死亡的友方随从。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=7|RACE=NONE
}
public class Story_05_HordeAdventurer:MinionBase{
//NAME=部落冒险者
//TEXT=<b>战吼：</b>将斥候报告交给纳兹格林将军。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=6|RACE=NONE
}
public class Story_05_JadeWarlord:MinionBase{
//NAME=青玉战神
//TEXT=在你的回合结束时，获得+1攻击力。<b>亡语：</b>消灭所有友方随从，推进战斗。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=10|RACE=NONE
}
public class Story_05_JadeWarlorde:Ability{
//NAME=征服者的意志
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Jaina:HeroBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=<i>大法师曾给了你随时前往塞拉摩拜访她的能力！现在 去吧。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_JainaDormant:MinionBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_05_JainaHP:HeroPowerBase{
//NAME=变形魔法
//TEXT=将一个敌方随从变形成为1/1的 生物。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_05_JainaMinion:MinionBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=在你的回合结束时，随机<b>冻结</b>一个敌方随从。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=MAGE|COST=1|ATK=5|HP=4|RACE=NONE
}
public class Story_05_JourneyBelow:SpellBase{
//NAME=深渊探险
//TEXT=<b>发现</b>一张<b>亡语</b>牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_05_LightProphecy:SpellBase{
//NAME=圣光预兆
//TEXT=<b>发现</b>一张法力值消耗为（4）的随从牌。召唤该随从并使其获得+3生命值。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Lorthemar:MinionBase{
//NAME=洛瑟玛·塞隆
//TEXT=在你的回合结束时，随机使另一个友方随从获得+1/+1。<b>亡语：</b>洗入你的牌库。
//MAJ=HUNTER|COST=6|ATK=5|HP=5|RACE=NONE
}
public class Story_05_MarkedShot:SpellBase{
//NAME=标记射击
//TEXT=对一个随从造成$4点伤害。<b>发现</b>一张法术牌。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_05_MassResurrection:SpellBase{
//NAME=群体复活
//TEXT=召唤三个在本局对战中死亡的友方随从。
//MAJ=PRIEST|COST=9|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Mekkatorque:MinionBase{
//NAME=格尔宾·梅卡托克
//TEXT=<b>法术迸发：</b>召唤一项惊人的发明。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=NEUTRAL|COST=1|ATK=6|HP=5|RACE=NONE
}
public class Story_05_MekkatorqueDormant:MinionBase{
//NAME=格尔宾·梅卡托克
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_05_MekkatorqueE:Ability{
//NAME=被禁锢的梅卡托克
//TEXT=<b>休眠</b>。 4回合后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_MercifulHeart:SecretBase{
//NAME=怜悯之心
//TEXT=<b>奥秘：</b>当一个友方随从死亡时，将其移回你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_05_MetalBrew:SpellBase{
//NAME=金铁酒
//TEXT=使一个友方随从获得<b>嘲讽</b>。抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Moira:HeroBase{
//NAME=茉艾拉·索瑞森
//TEXT=<i>战争一触即发，赶快化解茉艾拉和瓦里安之间的分歧！</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_MoiraHP:HeroPowerBase{
//NAME=王室扈从
//TEXT=召唤一个3/3的竞技场奴隶主。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_05_MonkeyKing:HeroBase{
//NAME=美猴王
//TEXT=<i>传说，这个神秘的人物在被囚禁前知道祥和钟杵的位置。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_05_MonkeyKingHP:HeroPowerBase{
//NAME=飞猴在天
//TEXT=随机对三个敌方随从各造成$1-$3点伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Nathanos:MinionBase{
//NAME=纳萨诺斯·凋零者
//TEXT=<b>嘲讽</b> 在你的回合结束时，随机对两个敌方随从造成$3点伤害。<b>亡语：</b>推进战斗。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=20|RACE=NONE
}
public class Story_05_Nazgrim:HeroBase{
//NAME=纳兹戈林将军
//TEXT=<i>你在潘达利亚的外交任务一切顺利——不包括被部落将军劫持的那部分。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_05_NazgrimHP:HeroPowerBase{
//NAME=别想逃！
//TEXT=随机使一个友方随从随机攻击敌方随从。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_05_RepairBot:MinionBase{
//NAME=修理机器人
//TEXT=在你的回合结束时，为一个受伤的友方角色恢复#6点生命值。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=MECHANICAL
}
public class Story_05_SamtheWise:MinionBase{
//NAME=睿智的萨姆
//TEXT=在你的回合开始时，为自身恢复3点生命值。<b>亡语：</b>赠出金铁酒，推进战斗。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=15|RACE=NONE
}
public class Story_05_Saurfang:HeroBase{
//NAME=瓦罗克·萨鲁法尔
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_05_SaurfangHP:HeroPowerBase{
//NAME=大胆决断
//TEXT=使你生命值最低的随从获得+1/+2。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_SaurfangHPe:Ability{
//NAME=决心
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_Shalamayne:WeaponBase{
//NAME=萨拉迈恩
//TEXT=在你攻击后，使你的传说随从获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=NONE
}
public class Story_05_Shalamaynee:Ability{
//NAME=王室之韧
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_05_ShalamayneVarian:WeaponBase{
//NAME=萨拉迈恩
//TEXT=在你攻击后，使你的<b>突袭</b>随从获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=NONE
}
public class Story_05_SiegeTower:MinionBase{
//NAME=联盟攻城塔
//TEXT=在你的回合开始时，对一个随机敌人造成1-2点伤害。为你的英雄恢复1点生命值。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=MECHANICAL
}
public class Story_05_SolvetheRiddles:SpellBase{
//NAME=解开谜题
//TEXT=<b>任务：</b>击败青玉战神，野性珀尾蝎和睿智的萨姆。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_05_StewardofScrolls:MinionBase{
//NAME=卷轴管理者
//TEXT=<b>法术伤害+1</b> <b>战吼：</b><b>发现</b>一张法术牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=ELEMENTAL
}
public class Story_05_Sylvanas:HeroBase{
//NAME=希尔瓦娜斯·风行者
//TEXT=<i>新任大酋长对暗夜精灵发动了举世震惊的暴行。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=100|RACE=NONE
}
public class Story_05_SylvanasHP:HeroPowerBase{
//NAME=装备风行者战弓
//TEXT=装备风行者战弓。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_05_TownCrier:MinionBase{
//NAME=城镇公告员
//TEXT=<b>战吼：</b>从你的牌库中抽一张具有<b>突袭</b>的随从牌。
//MAJ=WARRIOR|COST=1|ATK=1|HP=2|RACE=NONE
}
public class Story_05_TrainingSword:WeaponBase{
//NAME=训练用剑
//TEXT=在你的英雄攻击后，获得+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class Story_05_UndercityHuckster:MinionBase{
//NAME=幽暗城商贩
//TEXT=<b>亡语：</b>随机将一张<i>（你对手职业的）</i>卡牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=2|HP=2|RACE=NONE
}
public class Story_05_UntamedAmbertail:MinionBase{
//NAME=野性珀尾蝎
//TEXT=在你的回合结束时，造成3点伤害，随机分配到所有敌人身上。<b>亡语：</b>消灭所有友方随从，推进战斗。
//MAJ=NEUTRAL|COST=1|ATK=6|HP=10|RACE=NONE
}
public class Story_05_Varian:HeroBase{
//NAME=瓦里安国王
//TEXT=<i>和每个父亲一样，瓦里安也想给孩子最好的。但他也不太明白，什么才是最好的……</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_VarianHP:HeroPowerBase{
//NAME=训诫
//TEXT=随机将一个敌方随从移回对手的 手牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_05_VarianMinion:MinionBase{
//NAME=瓦里安·乌瑞恩
//TEXT=<b>战吼：</b>召唤两个军情七处特工。<b>亡语：</b>将本随从洗入你的牌库。
//MAJ=WARRIOR|COST=6|ATK=7|HP=7|RACE=NONE
}
public class Story_05_Velen:HeroBase{
//NAME=先知维伦
//TEXT=<i>德莱尼年迈的领袖非常了解圣光，却不太了解人类的天性……</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_05_VelenHP:HeroPowerBase{
//NAME=祝福之环
//TEXT=对所有敌方随从造成2点伤害。如果有随从死亡，抽一张牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_05_WarMachine:MinionBase{
//NAME=部落战争机器
//TEXT=<b>嘲讽</b> 在你的回合结束时，对所有敌方随从造成1点伤害。<b>亡语：</b>推进战斗。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=20|RACE=NONE
}
public class Story_05_WindrunnersBow:WeaponBase{
//NAME=风行者战弓
//TEXT=在你的英雄攻击后，召唤三个后援。
//MAJ=HUNTER|COST=6|ATK=4|HP=2|RACE=NONE
}
public class Story_05_YouthfulBrewmaster:MinionBase{
//NAME=年轻的酒仙
//TEXT=<b>战吼：</b>使一个友方随从从战场上移回你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class Story_06_ArcaneWraith:MinionBase{
//NAME=奥术怨灵
//TEXT=<b>战吼：</b>如果你控制一个<b>潜行</b>的随从，抽两张牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=ELEMENTAL
}
public class Story_06_AssassinsTraining:SpellBase{
//NAME=奇袭训练
//TEXT=抽取你牌库剩下的牌。你牌库中法术牌的法力值消耗减少（1）点。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Broll:MinionBase{
//NAME=布罗尔·熊皮
//TEXT=<b>法术迸发：</b>变形成为一只3/6并具有<b>突袭</b>的熊。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=DRUID|COST=1|ATK=1|HP=3|RACE=NONE
}
public class Story_06_BrollBear:MinionBase{
//NAME=布罗尔·熊皮
//TEXT=<b>突袭</b> <b>亡语：</b><b>休眠</b>2回合。
//MAJ=DRUID|COST=1|ATK=3|HP=6|RACE=NONE
}
public class Story_06_BrollDormant:MinionBase{
//NAME=布罗尔·熊皮
//TEXT=<b>休眠</b>
//MAJ=DRUID|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_06_ChoGall_007hb:HeroBase{
//NAME=古加尔
//TEXT=<i>双头食人魔，古尔丹恶名远播的走狗，成了暮光之锤的首领。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=100|RACE=NONE
}
public class Story_06_ChoGall_07p:HeroPowerBase{
//NAME=暗影箭雨
//TEXT=<b>被动</b> 对敌方英雄造成2点伤害，并弃掉其手牌中法力值消耗最低的牌。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_CleverDisguise:SpellBase{
//NAME=聪明的伪装
//TEXT=随机将另一职业的两张法术牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Daerion_003hb:HeroBase{
//NAME=刺客戴里恩
//TEXT=<i>他专注于自己的猎物，没发现你来了……</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_06_Daerion_03p:HeroPowerBase{
//NAME=锐利思维
//TEXT=从你的牌库中装备一把武器，并使其获得+1攻击力。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Daerion_03pe:Ability{
//NAME=锐利
//TEXT=+1攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_EbonGryphon:MinionBase{
//NAME=黑色狮鹫
//TEXT=<b>突袭</b>，<b>战吼：</b>从你的牌库中抽一张随从牌。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class Story_06_FelFuror:SpellBase{
//NAME=邪能躁动
//TEXT=使你的恶魔获得+1攻击力。<b>连击：</b>使你的所有随从获得+1攻击力。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_FelFurore:Ability{
//NAME=邪能躁怒
//TEXT=+1攻击力。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_FutureGladiator:SpellBase{
//NAME=角斗士训练
//TEXT=<b>任务：</b>消灭训练图腾。<b>奖励：</b>胜利！
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Garona:MinionBase{
//NAME=半兽人迦罗娜
//TEXT=同时对其攻击目标的相邻随从造成伤害。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=ROGUE|COST=4|ATK=5|HP=4|RACE=NONE
}
public class Story_06_Garona_006hb:HeroBase{
//NAME=半兽人迦罗娜
//TEXT=<i>多年前她刺杀了瓦里安的父亲，但她现在好像完全变了一个人。她到底有什么秘密？</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_06_Garona_06p:HeroPowerBase{
//NAME=装备弑君者
//TEXT=装备弑君者。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_GaronaDormant:MinionBase{
//NAME=半兽人迦罗娜
//TEXT=<b>休眠</b>
//MAJ=ROGUE|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_06_GaronaShadow:MinionBase{
//NAME=半兽人迦罗娜
//TEXT=在你的回合结束时，对所有敌人造成 1点伤害。
//MAJ=ROGUE|COST=4|ATK=2|HP=9|RACE=NONE
}
public class Story_06_GarroshMinion:MinionBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=<b>冲锋</b> 受伤时拥有+5攻 击力。
//MAJ=WARRIOR|COST=7|ATK=6|HP=5|RACE=NONE
}
public class Story_06_GarroshMinione:Ability{
//NAME=激怒
//TEXT=+5攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_HastyBlade:WeaponBase{
//NAME=急促之刃
//TEXT=<b>亡语：</b>随机使一个友方随从获得<b>冲锋</b>。
//MAJ=ROGUE|COST=1|ATK=2|HP=3|RACE=NONE
}
public class Story_06_HastyBladee:Ability{
//NAME=抓紧冲刺！
//TEXT=拥有<b>冲锋</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Hawkstrider:MinionBase{
//NAME=战斗陆行鸟
//TEXT=<b>潜行</b>，<b>突袭</b> 你的武器每有1点攻击力，该牌的法力值消耗便减少（1）点。
//MAJ=ROGUE|COST=4|ATK=3|HP=3|RACE=BEAST
}
public class Story_06_Helka_002hb:HeroBase{
//NAME=赫尔卡·恐怖图腾
//TEXT=<i>赫尔卡想让你来带领她新的角斗士小队！至于</i>你<i>的意愿，她不是很在意。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_06_Helka_02p:HeroPowerBase{
//NAME=角斗开始
//TEXT=随机召唤一个角斗士。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_06_JainaMinion:MinionBase{
//NAME=吉安娜·普罗德摩尔
//TEXT=<b>法术迸发：</b>召唤一个3/6的水元素。<b>亡语：</b>洗入你的牌库。
//MAJ=MAGE|COST=6|ATK=5|HP=4|RACE=NONE
}
public class Story_06_Jorach_008hb:HeroBase{
//NAME=乔拉齐·拉文霍德
//TEXT=<i>他发出了神秘的邀约，请你前往他的庄园。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=300|RACE=NONE
}
public class Story_06_Jorach_08p:HeroPowerBase{
//NAME=迷雾重重
//TEXT=<b>被动</b> 在你的回合开始时，使一个沉默暗影获得+1攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Kathranatir:MinionBase{
//NAME=卡萨纳提尔
//TEXT=<b>战吼：</b>随机从你的手牌和牌库中召唤一个恶魔。
//MAJ=WARLOCK|COST=8|ATK=5|HP=5|RACE=DEMON
}
public class Story_06_Kingslayers:WeaponBase{
//NAME=弑君者
//TEXT=敌方英雄受到的所有伤害效果 翻倍。
//MAJ=ROGUE|COST=3|ATK=2|HP=1|RACE=NONE
}
public class Story_06_Lilian:MinionBase{
//NAME=莉莉安·沃斯
//TEXT=<b>潜行</b>，<b>亡语：</b>对敌方英雄造成4点伤害。
//MAJ=ROGUE|COST=4|ATK=4|HP=5|RACE=NONE
}
public class Story_06_LoGosh:MinionBase{
//NAME=洛戈什
//TEXT=<b>激励：</b>抽一张牌。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=WARRIOR|COST=1|ATK=3|HP=5|RACE=NONE
}
public class Story_06_LoGoshDormant:MinionBase{
//NAME=洛戈什
//TEXT=<b>休眠</b>
//MAJ=WARRIOR|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_06_ManaWyrm:MinionBase{
//NAME=变幻法力浮龙
//TEXT=<b>潜行</b>，<b>亡语：</b>获得一个空的法力水晶。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class Story_06_Meryl:MinionBase{
//NAME=梅瑞尔·冬风
//TEXT=<b>法术伤害+2</b> <b>亡语：</b><b>休眠</b>2回合。
//MAJ=MAGE|COST=5|ATK=4|HP=4|RACE=NONE
}
public class Story_06_MerylDormant:MinionBase{
//NAME=梅瑞尔·冬风
//TEXT=<b>休眠</b>
//MAJ=MAGE|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_06_NoMercy:SpellBase{
//NAME=绝不留情
//TEXT=在本回合中，你的武器的攻击力翻倍。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_06_NoMercye:Ability{
//NAME=绝不留情
//TEXT=武器的攻击力翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Rehgar_001hb:HeroBase{
//NAME=雷加尔·大地之怒
//TEXT=<i>高明的训练师，善于把草台班子培养成竞技场的战斗之星。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_06_Rehgar_01p:HeroPowerBase{
//NAME=团队导师
//TEXT=为训练图腾恢复2点生命值。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_RehgarMinion:MinionBase{
//NAME=雷加尔·大地之怒
//TEXT=<b>法术迸发：</b>随机召唤一个图腾。
//MAJ=SHAMAN|COST=6|ATK=5|HP=4|RACE=NONE
}
public class Story_06_SanguineStrike:SpellBase{
//NAME=血色打击
//TEXT=对所有敌方随从造成$2点伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_ShadyBusiness:SecretBase{
//NAME=暗中交易
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，召唤一个7/5的拉文霍德刺客。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_ShroudedinMysterye:Ability{
//NAME=迷雾重重
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_SilentShadow:MinionBase{
//NAME=沉默暗影
//TEXT=永久<b>潜行</b>。隐藏属性值。在你的回合结束时，对所有敌人造成1点伤害。
//MAJ=ROGUE|COST=4|ATK=2|HP=9|RACE=NONE
}
public class Story_06_SilentShadow2:MinionBase{
//NAME=沉默暗影
//TEXT=永久<b>潜行</b>。隐藏属性值。在你的回合结束时，对所有敌人造成1点伤害。
//MAJ=ROGUE|COST=4|ATK=1|HP=15|RACE=NONE
}
public class Story_06_SilentShadow3:MinionBase{
//NAME=沉默暗影
//TEXT=永久<b>潜行</b>。隐藏属性值。在你的回合结束时，对所有敌人造成1点伤害。
//MAJ=ROGUE|COST=4|ATK=1|HP=13|RACE=NONE
}
public class Story_06_SilentShadow4:MinionBase{
//NAME=沉默暗影
//TEXT=永久<b>潜行</b>。隐藏属性值。在你的回合结束时，对所有敌人造成1点伤害。
//MAJ=ROGUE|COST=4|ATK=6|HP=6|RACE=NONE
}
public class Story_06_Stasia_005hb:HeroBase{
//NAME=斯塔西亚·坠影
//TEXT=<i>联盟和部落的领袖会议期间，一名可疑的袭击者闯了 进来。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_06_Stasia_05p:HeroPowerBase{
//NAME=冰霜飞溅
//TEXT=敌方手牌中每有一张法术牌，便随机对一个敌方随从造成$1点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Steeldancer:MinionBase{
//NAME=钢铁舞者
//TEXT=<b>战吼：</b>随机召唤一个法力值消耗等同于你的武器攻击力的随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class Story_06_Subtlety:SpellBase{
//NAME=敏锐
//TEXT=在本回合中，你使用的下一个<b>奥秘</b>的法力值消耗为（0）点。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Taoshi:MinionBase{
//NAME=陶矢
//TEXT=在你的回合结束时，对所有敌人造成 1点伤害。
//MAJ=ROGUE|COST=4|ATK=1|HP=15|RACE=NONE
}
public class Story_06_TessGreymane:MinionBase{
//NAME=苔丝·格雷迈恩
//TEXT=在你的回合结束时，对所有敌人造成 1点伤害。
//MAJ=ROGUE|COST=4|ATK=6|HP=6|RACE=NONE
}
public class Story_06_Tethys:MinionBase{
//NAME=舰队上将特塞斯
//TEXT=在你的回合结束时，对所有敌人造成 1点伤害。
//MAJ=ROGUE|COST=4|ATK=1|HP=13|RACE=NONE
}
public class Story_06_ThistleDagger:WeaponBase{
//NAME=蓟草匕首
//TEXT=在你的英雄攻击后，抽一张牌，并额外将它的一张复制置入你的手牌。
//MAJ=ROGUE|COST=4|ATK=2|HP=2|RACE=NONE
}
public class Story_06_ThrallMinion:MinionBase{
//NAME=萨尔大酋长
//TEXT=在你的回合时，你的英雄拥有+2攻击力和<b>风怒</b>。
//MAJ=SHAMAN|COST=7|ATK=5|HP=6|RACE=NONE
}
public class Story_06_ToxicVial:SpellBase{
//NAME=毒剂之瓶
//TEXT=使一个随从获得<b>剧毒</b>。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_TrainingTotem:MinionBase{
//NAME=训练图腾
//TEXT=每当本随从攻击并消灭一个随从，获得+1攻击力。<b>亡语：</b>胜利！
//MAJ=SHAMAN|COST=2|ATK=1|HP=30|RACE=TOTEM
}
public class Story_06_TrainingToteme:Ability{
//NAME=训练有成
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_TrickTotem:MinionBase{
//NAME=戏法图腾
//TEXT=在你的回合结束时，随机施放一个法力值消耗小于或等于（3）点的法术。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=3|RACE=TOTEM
}
public class Story_06_Upheaval:SpellBase{
//NAME=颠覆
//TEXT=将你对手手牌中的一张随从牌移回对手的牌库。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Valeera_001hp:HeroBase{
//NAME=瓦莉拉
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_06_Valeera_002hp:HeroBase{
//NAME=瓦莉拉
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_06_Valeera_003hp:HeroBase{
//NAME=瓦莉拉
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_06_Valeera_004hp:HeroBase{
//NAME=瓦莉拉
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_06_Valeera_005hp:HeroBase{
//NAME=瓦莉拉
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_06_Valeera_006hp:HeroBase{
//NAME=瓦莉拉
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_06_Valeera_007hp:HeroBase{
//NAME=瓦莉拉
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_06_Valeera_008hp:HeroBase{
//NAME=瓦莉拉
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_06_Valeera_009hb:HeroBase{
//NAME=着魔的瓦莉拉
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_06_Valeera_03p:HeroPowerBase{
//NAME=飘忽不定
//TEXT=使一个友方随从 获得<b>潜行</b>和+1攻击力。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Valeera_03pe:Ability{
//NAME=暗影遮蔽
//TEXT=+1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Valeera_04p:HeroPowerBase{
//NAME=二级飘忽不定
//TEXT=使一个友方随从获得<b>潜行</b>和+2攻击力。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Valeera_04pe:Ability{
//NAME=暗影遮蔽
//TEXT=+2攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Valeera_05p:HeroPowerBase{
//NAME=手法娴熟
//TEXT=从你对手的牌库中偷取一张牌并置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Valeera_06p:HeroPowerBase{
//NAME=二级手法娴熟
//TEXT=从你对手的牌库中偷取一张牌并置入你的手牌。其法力值消耗减少（1）点。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Valeera_06pe:Ability{
//NAME=巧手减费
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Valeera_07p:HeroPowerBase{
//NAME=刀扇
//TEXT=对所有敌人造成$1点伤害。抽一张牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Valeera_08p:HeroPowerBase{
//NAME=二级刀扇
//TEXT=对所有敌人造成$2点伤害。抽一张牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Valeera_09p:HeroPowerBase{
//NAME=邪能传送门
//TEXT=随机从你的牌库中召唤一个恶魔。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_06_Varian:MinionBase{
//NAME=瓦里安·乌瑞恩
//TEXT=<b>激励：</b>抽一张牌。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=WARRIOR|COST=1|ATK=3|HP=5|RACE=NONE
}
public class Story_06_VarianDormant:MinionBase{
//NAME=瓦里安·乌瑞恩
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_06_Vendellin_004hb:HeroBase{
//NAME=芬德林·魂火
//TEXT=<i>瓦里安的敌人一个比一个强。这一个有点奇怪……</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_06_Vendellin_04p:HeroPowerBase{
//NAME=恶魔附体
//TEXT=随机夺取一个非<b>传说</b>敌方随从的控制权，并使其变形成为恶魔。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_06_WandThief:MinionBase{
//NAME=魔杖窃贼
//TEXT=<b>连击：</b><b>发现</b>一张法师法术牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class Story_06_Wrathion:MinionBase{
//NAME=拉希奥
//TEXT=<b>嘲讽</b>，<b>战吼：</b>你每控制一个沉默暗影，便抽一张牌。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=NONE
}
public class Story_06_Wyvern:MinionBase{
//NAME=炸毛的飞龙
//TEXT=<b>突袭</b>，<b>连击：</b>在本回合中，你每使用一张其他牌，便获得+2/+2。
//MAJ=ROGUE|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class Story_07_Alexstrasza:MinionBase{
//NAME=阿莱克丝塔萨
//TEXT=如果你的英雄死亡，将其复活。<i>（还剩3次）</i><b>亡语：</b><b>休眠</b>2回合。
//MAJ=NEUTRAL|COST=1|ATK=5|HP=4|RACE=DRAGON
}
public class Story_07_AlexstraszaDormant:MinionBase{
//NAME=阿莱克丝塔萨
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=DRAGON
}
public class Story_07_Archimonde_005hb:HeroBase{
//NAME=阿克蒙德
//TEXT=<i>恶魔大举入侵艾泽拉斯，恶魔之王终于现身。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_07_Archimonde_005p:HeroPowerBase{
//NAME=混乱之雨
//TEXT=召唤两个6/6的地狱火。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class Story_07_AthleticStudies:SpellBase{
//NAME=体能研习
//TEXT=<b>发现</b>一张<b>突袭</b>随从牌。你的下一张<b>突袭</b>随从牌法力值消耗减少（1）点。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Blackmoore_001hb:HeroBase{
//NAME=埃德拉斯·布莱克摩尔
//TEXT=<i>眼光老辣的决斗发烧友，打算利用你在比赛中赚上一笔。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Blackmoore_001p:HeroPowerBase{
//NAME=角斗
//TEXT=随机召唤一个斗士。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Blackmoore_001pe:Ability{
//NAME=赛场斗士
//TEXT=+1攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_07_BurningTendon:MinionBase{
//NAME=装甲板连接束
//TEXT=每当你的英雄在你的回合受到伤害，便获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class Story_07_BurningTendone:Ability{
//NAME=盛怒
//TEXT=属性值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_07_CallWarchief:SpellBase{
//NAME=大酋长的召唤
//TEXT=随机召唤两个部落随从并使其获得+2/+2。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_07_CallWarchiefe:Ability{
//NAME=荣耀征召
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_07_CapturedCrocolisk:MinionBase{
//NAME=被捕获的鳄鱼
//TEXT=<b>嘲讽</b> 在你的回合结束时，获得+1攻击力。<b>亡语：</b>推进战斗。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=10|RACE=BEAST
}
public class Story_07_CapturedCrocoliske:Ability{
//NAME=暴躁的鳄鱼
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_07_CorruptedBlood:MinionBase{
//NAME=堕落之血
//TEXT=<b>亡语：</b>随机对敌人发射三枚飞弹，每枚飞弹造成2点伤害。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=NONE
}
public class Story_07_CorruptGarrosh:HeroBase{
//NAME=加尔鲁什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Deathwing_006hb:HeroBase{
//NAME=死亡之翼
//TEXT=<i>他曾是高贵的大地守护者，如今却背叛了自己的职责，一心只想毁灭世界。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=200|RACE=NONE
}
public class Story_07_Deathwing_006hb2:HeroBase{
//NAME=死亡之翼
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=100|RACE=NONE
}
public class Story_07_Deathwing_006hb3:HeroBase{
//NAME=死亡之翼
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_07_Deathwing_006p:HeroPowerBase{
//NAME=灼热之握
//TEXT=消灭最左边的敌方随从。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Deathwing_006p2:HeroPowerBase{
//NAME=粉碎
//TEXT=消灭最左边的敌方随从，并摧毁对手最左边的手牌。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Deathwing_006p3:HeroPowerBase{
//NAME=大灾变
//TEXT=消灭最左边的敌方随从，并摧毁对手最左边的手牌和牌库顶的牌。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Devastate:SpellBase{
//NAME=毁灭打击
//TEXT=对一个受伤的随从造成$4点 伤害。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_07_DrekThar_002hb:HeroBase{
//NAME=德雷克塔尔
//TEXT=<i>这位年长的萨满祭司会帮助你沟通元素之灵，运用它们的力量。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_DrekThar_002p:HeroPowerBase{
//NAME=萨满试炼
//TEXT=召唤一个元素。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_07_DrekTharMinion:MinionBase{
//NAME=德雷克塔尔
//TEXT=<b>法术迸发：</b>随机召唤一个元素。<b>亡语：</b>洗入你的牌库。
//MAJ=SHAMAN|COST=4|ATK=4|HP=5|RACE=NONE
}
public class Story_07_EarthenMight:SpellBase{
//NAME=大地之力
//TEXT=使一个随从获得+2/+2。如果该随从是元素，则随机将一张元素牌置入你的手牌。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class Story_07_ElementalGathering:SpellBase{
//NAME=元素聚集
//TEXT=召唤三个元素之灵。<b>过载：</b>（2）。
//MAJ=SHAMAN|COST=10|ATK=0|HP=0|RACE=NONE
}
public class Story_07_EventheOdds:SpellBase{
//NAME=调平赔率
//TEXT=为一个友方角色恢复#2点生命值。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_07_FeverPitch:SpellBase{
//NAME=狂热投掷
//TEXT=随机对随从发射三枚飞弹，每枚飞弹造成$2点伤害。
//MAJ=NEUTRAL|COST=7|ATK=0|HP=0|RACE=NONE
}
public class Story_07_FireSpiritWolf:MinionBase{
//NAME=火焰幽灵狼
//TEXT=<b>嘲讽</b>，<b>突袭</b> <b>战吼：</b><b>发现</b>一张萨满祭司法术牌。
//MAJ=SHAMAN|COST=2|ATK=3|HP=4|RACE=NONE
}
public class Story_07_FocusingIrisSpell:SpellBase{
//NAME=聚焦之虹
//TEXT=将你的英雄技能替换为聚焦之虹。
//MAJ=MAGE|COST=10|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Garrosh_008hb:HeroBase{
//NAME=加尔鲁什
//TEXT=<i>他摒弃了智慧，也失去了荣耀。你不得不亲手废除他的职权。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_07_Garrosh_008p:HeroPowerBase{
//NAME=亚煞极之心
//TEXT=<b>被动</b> 在你的回合结束时，将一张你牌库中的随从牌置入你的手牌，其法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Garrosh_008p2:HeroPowerBase{
//NAME=装备血吼
//TEXT=装备血吼。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Grommash:MinionBase{
//NAME=格罗玛什·地狱咆哮
//TEXT=<b>冲锋</b> 受伤时拥有+6攻击力。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=WARRIOR|COST=8|ATK=4|HP=9|RACE=NONE
}
public class Story_07_GrommashDormant:MinionBase{
//NAME=格罗玛什·地狱咆哮
//TEXT=<b>休眠</b>
//MAJ=WARRIOR|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_07_HideousAmalgamation:MinionBase{
//NAME=丑恶的融合怪
//TEXT=在你的回合结束时，你每控制一个堕落之血，便对所有敌人造成1点伤害。
//MAJ=NEUTRAL|COST=8|ATK=2|HP=7|RACE=NONE
}
public class Story_07_Jaina_007hb:HeroBase{
//NAME=吉安娜
//TEXT=<i>你的这位故友将要动用巨力，攻击部落，痛报塞拉摩的冤仇。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_07_Jaina_007p:HeroPowerBase{
//NAME=聚焦之虹
//TEXT=召唤一个水元素。每次使用都会提升。
//MAJ=MAGE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Jaina_007p2:HeroPowerBase{
//NAME=陨冰
//TEXT=随机对两个敌方随从造成$2点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Kalecgos:MinionBase{
//NAME=卡雷苟斯
//TEXT=你每个回合使用的第一张法术牌的法力值消耗为（0）点。<b>战吼：</b><b>发现</b>一张法术牌。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=MAGE|COST=8|ATK=4|HP=12|RACE=DRAGON
}
public class Story_07_KalecgosDormant:MinionBase{
//NAME=卡雷苟斯
//TEXT=<b>休眠</b>
//MAJ=MAGE|COST=11|ATK=0|HP=1|RACE=DRAGON
}
public class Story_07_Mannoroth_004hb:HeroBase{
//NAME=玛诺洛斯
//TEXT=<i>多年以前，他欺骗兽人喝下了他的血，从此恶魔便控制了兽人。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_07_Mannoroth_004p:HeroPowerBase{
//NAME=血之诅咒
//TEXT=使所有敌方随从的生命值降低2点，并使其攻击力提高1点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Mannoroth_004pe:Ability{
//NAME=受到诅咒
//TEXT=攻击力提高，生命值降低。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_07_MountainCat:MinionBase{
//NAME=山豹
//TEXT=<b>嘲讽</b>，<b>亡语：</b>消灭两只山豹以推进战斗。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=8|RACE=BEAST
}
public class Story_07_Nozdormu:MinionBase{
//NAME=诺兹多姆
//TEXT=<b>战吼：</b> 将每个玩家的法力水晶重置为十个。<b>亡语：</b><b>休眠</b>1回合。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=8|RACE=DRAGON
}
public class Story_07_NozdormuDormant:MinionBase{
//NAME=诺兹多姆
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=DRAGON
}
public class Story_07_OgreBrute:MinionBase{
//NAME=食人魔步兵
//TEXT=<b>嘲讽</b> 50%几率攻击错误的敌人。<b>亡语：</b>推进 战斗。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=15|RACE=NONE
}
public class Story_07_Peon:MinionBase{
//NAME=苦工
//TEXT=<b>暴怒：</b>随机将一张你职业的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class Story_07_PepTalk:SpellBase{
//NAME=抚慰之语
//TEXT=为所有角色恢复#2点生命值。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_07_RegenerativeBlood:SpellBase{
//NAME=再生之血
//TEXT=场上每有一个随从，为你的英雄恢复1点生命值。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_07_RouseRabble:SpellBase{
//NAME=引起动乱
//TEXT=造成$3点伤害，随机分配到所有随从身上。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_07_SpiritofAir:MinionBase{
//NAME=空气之灵
//TEXT=<b>扰魔</b>。<b>亡语：</b>推进战斗，并为萨尔恢复15点生命值。
//MAJ=SHAMAN|COST=1|ATK=1|HP=8|RACE=ELEMENTAL
}
public class Story_07_SpiritofAirt:MinionBase{
//NAME=空气之灵
//TEXT=<b>扰魔</b>。<b>亡语：</b>为所有友方角色恢复2点生命值。
//MAJ=SHAMAN|COST=6|ATK=1|HP=8|RACE=ELEMENTAL
}
public class Story_07_SpiritofEarth:MinionBase{
//NAME=大地之灵
//TEXT=<b>嘲讽</b>，<b>亡语：</b>推进战斗，并为萨尔恢复15点生命值。
//MAJ=SHAMAN|COST=1|ATK=1|HP=8|RACE=ELEMENTAL
}
public class Story_07_SpiritofEartht:MinionBase{
//NAME=大地之灵
//TEXT=<b>嘲讽</b>，<b>亡语：</b>为所有友方角色恢复2点生命值。
//MAJ=SHAMAN|COST=6|ATK=1|HP=8|RACE=ELEMENTAL
}
public class Story_07_SpiritofFire:MinionBase{
//NAME=火焰之灵
//TEXT=对火焰法术<b>免疫</b>。在你的回合结束时，对所有敌方随从造成1点伤害。<b>亡语：</b>推进战斗，并为萨尔恢复15点生命值。
//MAJ=SHAMAN|COST=1|ATK=2|HP=8|RACE=ELEMENTAL
}
public class Story_07_SpiritofFiret:MinionBase{
//NAME=火焰之灵
//TEXT=对火焰法术<b>免疫</b>。在你的回合结束时，对所有敌方随从造成1点伤害。<b>亡语：</b>为所有友方角色恢复2点生命值。
//MAJ=SHAMAN|COST=6|ATK=2|HP=8|RACE=ELEMENTAL
}
public class Story_07_SpiritoftheWild:MinionBase{
//NAME=自然之灵
//TEXT=对自然法术<b>免疫</b>。在你的回合开始时，随机使一个友方随从获得+1/+1。<b>亡语：</b>推进战斗。
//MAJ=SHAMAN|COST=1|ATK=2|HP=8|RACE=ELEMENTAL
}
public class Story_07_SpiritoftheWilde:Ability{
//NAME=野性之魂
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_07_SpiritoftheWildt:MinionBase{
//NAME=自然之灵
//TEXT=对自然法术<b>免疫</b>。在你的回合开始时，随机使一个友方随从获得+1/+1。<b>亡语：</b>为所有友方角色恢复2点生命值。
//MAJ=SHAMAN|COST=6|ATK=2|HP=8|RACE=ELEMENTAL
}
public class Story_07_SpiritofWater:MinionBase{
//NAME=水流之灵
//TEXT=对冰霜法术<b>免疫</b>。在你的回合开始时，为自身恢复1点生命值。<b>亡语：</b>推进战斗，并为萨尔恢复15点生命值。
//MAJ=SHAMAN|COST=1|ATK=2|HP=8|RACE=ELEMENTAL
}
public class Story_07_SpiritofWatert:MinionBase{
//NAME=水流之灵
//TEXT=对冰霜法术<b>免疫</b>。在你的回合开始时，为自身恢复1点生命值。<b>亡语：</b>为所有友方角色恢复2点生命值。
//MAJ=SHAMAN|COST=6|ATK=2|HP=8|RACE=ELEMENTAL
}
public class Story_07_Stranger_003hb:HeroBase{
//NAME=神秘的陌生人
//TEXT=<i>他对格罗玛什·地狱咆哮和解放兽人的行为评价不高。为什么会这样？</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Stranger_003hb2:HeroBase{
//NAME=奥格瑞姆·毁灭之锤
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Stranger_003p:HeroPowerBase{
//NAME=装备毁灭之锤
//TEXT=装备毁灭之锤。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Taretha:MinionBase{
//NAME=塔蕾莎·福克斯顿
//TEXT=<b>战吼：</b>为你的英雄恢复#10点生命值。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=6|RACE=NONE
}
public class Story_07_TarethasMemory:SpellBase{
//NAME=塔蕾莎的回忆
//TEXT=使你的所有随从获得“<b>亡语：</b>为你的英雄恢复#4点生命值。”
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_07_TarethasMemorye:Ability{
//NAME=塔蕾莎的遗韵
//TEXT=<b>亡语：</b>为你的英雄恢复#2点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Thrall_001hp:HeroBase{
//NAME=萨尔
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Thrall_002hp:HeroBase{
//NAME=萨尔
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Thrall_003hp:HeroBase{
//NAME=萨尔
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Thrall_004hp:HeroBase{
//NAME=萨尔
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Thrall_004p:HeroPowerBase{
//NAME=装备毁灭之锤
//TEXT=装备毁灭之锤。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Thrall_005hp:HeroBase{
//NAME=萨尔
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Thrall_005p:HeroPowerBase{
//NAME=二级装备毁灭之锤
//TEXT=装备毁灭之锤。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Thrall_006hp:HeroBase{
//NAME=萨尔
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Thrall_006p:HeroPowerBase{
//NAME=空气之灵
//TEXT=使所有友方随从获得<b>风怒</b>。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Thrall_007hp:HeroBase{
//NAME=萨尔
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Thrall_007p:HeroPowerBase{
//NAME=二级空气之灵
//TEXT=使所有友方随从获得<b>风怒</b>。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Thrall_008hp:HeroBase{
//NAME=萨尔
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_07_Thrall_008p:HeroPowerBase{
//NAME=充能毁灭之锤
//TEXT=装备充能的毁灭之锤。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Ultraxion:MinionBase{
//NAME=奥卓克希昂
//TEXT=在你的回合开始时，使你的随从获得+2攻击力。<b>亡语：</b>推进 战斗。
//MAJ=NEUTRAL|COST=6|ATK=1|HP=12|RACE=DRAGON
}
public class Story_07_Ultraxione:Ability{
//NAME=超凡力量
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_07_Warmaster:MinionBase{
//NAME=战争大师黑角
//TEXT=<b>嘲讽</b> 在你的回合开始时，召唤一条1/1的雏龙。<b>亡语：</b>推进战斗。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=20|RACE=NONE
}
public class Story_07_WildElemental:MinionBase{
//NAME=狂野元素
//TEXT=在你的回合结束时，随机使另一个友方随从获得+1生命值。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=ELEMENTAL
}
public class Story_07_WildElementale:Ability{
//NAME=狂放生命
//TEXT=生命值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_07_WildSpiritWolf:MinionBase{
//NAME=狂野幽灵狼
//TEXT=<b>嘲讽</b>，<b>风怒</b> <b>战吼：</b><b>发现</b>一张萨满祭司法术牌。
//MAJ=SHAMAN|COST=3|ATK=4|HP=4|RACE=NONE
}
public class Story_07_Ysera:MinionBase{
//NAME=伊瑟拉
//TEXT=在你的回合结束时，将一张梦境牌置入你的手牌。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=DRUID|COST=9|ATK=4|HP=12|RACE=DRAGON
}
public class Story_07_YseraDormant:MinionBase{
//NAME=伊瑟拉
//TEXT=<b>休眠</b>
//MAJ=DRUID|COST=11|ATK=0|HP=1|RACE=DRAGON
}
public class Story_08_AncientofWind:MinionBase{
//NAME=风之古树
//TEXT=<b>抉择：</b>使你的所有随从获得<b>突袭</b>；或者召唤一只3/4并具有<b>冲锋</b>的角鹰兽。
//MAJ=DRUID|COST=7|ATK=5|HP=5|RACE=NONE
}
public class Story_08_AncientofWinde:Ability{
//NAME=风之赐福
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_AncientofWindta:SpellBase{
//NAME=风之赐福
//TEXT=使你的所有随从获得<b>突袭</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_AncientofWindtb:SpellBase{
//NAME=风之护卫
//TEXT=召唤一只3/4并具有<b>冲锋</b>的角鹰兽。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_ArchdruidsBlessing:SpellBase{
//NAME=大德鲁伊的祝福
//TEXT=随机为友方角色恢复#8点生命值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class Story_08_ArchdruidsRage:SpellBase{
//NAME=大德鲁伊的愤怒
//TEXT=随机对敌人造成$8点伤害。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class Story_08_Archimonde_004hb:HeroBase{
//NAME=阿克蒙德
//TEXT=<i>千百年过去了，恶魔最终回到了艾泽拉斯，再次入侵这个世界。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_08_Archimonde_004p:HeroPowerBase{
//NAME=混乱之雨
//TEXT=召唤两个6/6的地狱火。
//MAJ=NEUTRAL|COST=6|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Cenarius_001hb:HeroBase{
//NAME=塞纳留斯
//TEXT=<i>古老的森林之王洞察了你的内心，选择你来当他的学徒。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_Cenarius_001p:HeroPowerBase{
//NAME=学无止境
//TEXT=随机使敌方英雄获得一张训练牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_CenariusDormant:MinionBase{
//NAME=塞纳留斯
//TEXT=<b>休眠</b>
//MAJ=DRUID|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_08_CenariusMinion:MinionBase{
//NAME=塞纳留斯
//TEXT=<b>暴怒：</b>使你的其他随从获得+2/+2。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=DRUID|COST=6|ATK=2|HP=8|RACE=NONE
}
public class Story_08_CorruptingRage:SpellBase{
//NAME=腐化之怒
//TEXT=对所有龙和野兽随从造成$4点伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class Story_08_DarnassianNightsaber:MinionBase{
//NAME=达纳苏斯夜刃豹
//TEXT=<b>暴怒：</b>从你的牌库中抽一张法术牌。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=BEAST
}
public class Story_08_EmeraldExplorer:MinionBase{
//NAME=翡翠龙探险者
//TEXT=<b>嘲讽</b> <b>战吼：</b><b>发现</b>一张 龙牌。
//MAJ=DRUID|COST=6|ATK=4|HP=8|RACE=DRAGON
}
public class Story_08_Fandral:MinionBase{
//NAME=梦魇中的范达尔
//TEXT=敌方<b>抉择</b>牌的法力值消耗增加（1）点。
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=NONE
}
public class Story_08_Fandrale:Ability{
//NAME=梦魇
//TEXT=你的<b>抉择</b>牌法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Fertilize:SpellBase{
//NAME=施肥
//TEXT=<b>训练牌</b> 恢复#3点生命值。如果目标恢复了所有生命值，则召唤一个树人。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class Story_08_ForestOwl:MinionBase{
//NAME=森林猫头鹰
//TEXT=<b>战吼，亡语：</b><b>发现</b>一张<b>抉择</b>法术牌。
//MAJ=DRUID|COST=4|ATK=3|HP=4|RACE=BEAST
}
public class Story_08_Gibberling:MinionBase{
//NAME=聒噪怪
//TEXT=<b>法术迸发：</b>召唤一个聒噪怪。
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=NONE
}
public class Story_08_Guidance:SpellBase{
//NAME=灵魂指引
//TEXT=检视两张法术牌。将其中一张置入你的手牌；或者<b>过载：</b>（1），获取这两张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Hamuul:MinionBase{
//NAME=哈缪尔·符文图腾
//TEXT=你每个回合使用的第一张自然法术牌法力值消耗为（0）点。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=DRUID|COST=5|ATK=3|HP=5|RACE=NONE
}
public class Story_08_HamuulDormant:MinionBase{
//NAME=哈缪尔·符文图腾
//TEXT=<b>休眠</b>
//MAJ=DRUID|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_08_Hamuule:Ability{
//NAME=符文图腾的天赋
//TEXT=消耗为（0）。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Hopelessness:SpellBase{
//NAME=绝望
//TEXT=消灭生命值最低的敌方随从。选择一个友方随从，获得被消灭随从的生命值。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Hopelessnesse:Ability{
//NAME=盗走希望
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Illidan:MinionBase{
//NAME=伊利丹·怒风
//TEXT=在你的回合开始时，随机将一张恶魔猎手法术牌置入你的手牌。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=3|RACE=NONE
}
public class Story_08_Illidan_003hb:HeroBase{
//NAME=伊利丹
//TEXT=<i>你的兄弟体内的恶魔之力改变了他，他对自己的盟友发起了攻击。</i>
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_08_Illidan_003p:HeroPowerBase{
//NAME=装备战刃
//TEXT=装备埃辛诺斯战刃。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Illidan_005hb:HeroBase{
//NAME=伊利丹
//TEXT=<i>伊利丹对族人心怀怨气，不愿让玛维将他送回监狱。</i>
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_08_Illidan_005p:HeroPowerBase{
//NAME=恶魔变形
//TEXT=对一个敌方随从造成4点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_08_IllidanDormant:MinionBase{
//NAME=伊利丹·怒风
//TEXT=<b>休眠</b>
//MAJ=DEMONHUNTER|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_08_Keeper:MinionBase{
//NAME=梦境守护者
//TEXT=<b>战吼：</b>恢复#3点生命值。<b>腐蚀：</b>改为造成3点伤害。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=NONE
}
public class Story_08_KeeperCorrupt:MinionBase{
//NAME=梦境守护者
//TEXT=<b>已腐蚀</b> <b>战吼：</b>造成3点伤害。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=NONE
}
public class Story_08_LivingLava:MinionBase{
//NAME=活体熔岩
//TEXT=每当你施放一个火焰法术，便获得+2/+2。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=6|RACE=ELEMENTAL
}
public class Story_08_Malfurion_001hp:HeroBase{
//NAME=玛法里奥
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_Malfurion_002hp:HeroBase{
//NAME=玛法里奥
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_Malfurion_003hp:HeroBase{
//NAME=玛法里奥
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_Malfurion_003p:HeroPowerBase{
//NAME=强效激活
//TEXT=在本回合中，如果你施放过法术，便获得一个仅限本回合可用的法力水晶。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Malfurion_004e:Ability{
//NAME=扎根
//TEXT=<b>休眠</b>。 在你的回合唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Malfurion_004hp:HeroBase{
//NAME=玛法里奥
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_Malfurion_004p:HeroPowerBase{
//NAME=缠绕根须
//TEXT=使一个敌方随从<b>休眠</b>1回合。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Malfurion_005e:Ability{
//NAME=扎根
//TEXT=<b>休眠</b>。 2回合后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Malfurion_005hp:HeroBase{
//NAME=玛法里奥
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_Malfurion_005p:HeroPowerBase{
//NAME=二级缠绕根须
//TEXT=使一个敌方随从<b>休眠</b>2回合。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Malfurion_006hp:HeroBase{
//NAME=玛法里奥
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_Malfurion_006p:HeroPowerBase{
//NAME=驱散梦魇
//TEXT=移除一个友方随从的诅咒。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Malfurion_007hp:HeroBase{
//NAME=玛法里奥
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_Malfurion_007p:HeroPowerBase{
//NAME=宁静
//TEXT=恢复#2点生命值。此时如果目标拥有所有生命值，使其获得<b>法术伤害+1</b>。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Malfurion_007pe:Ability{
//NAME=宁静
//TEXT=<b>法术伤害+1</b>
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Malfurion_008hp:HeroBase{
//NAME=玛法里奥
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_Malfurion_008p:HeroPowerBase{
//NAME=二级宁静
//TEXT=恢复#3点生命值。此时如果目标拥有所有生命值，使其获得<b>法术伤害+2</b>。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Malfurion_008pe:Ability{
//NAME=宁静
//TEXT=<b>法术伤害+2</b>
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_MalfurionBear:HeroBase{
//NAME=熊形态
//TEXT=将你的英雄技能替换为野性力量（每有一个友方随从，便为你的英雄恢复2点生命值。）
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_MalfurionBear_001p:HeroPowerBase{
//NAME=野性力量
//TEXT=每有一个友方随从，便为你的英雄恢复2点生命值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_MalfurionCat:HeroBase{
//NAME=猎豹形态
//TEXT=将你的英雄技能替换为野性狂暴（每有一个友方随从，便获得2点攻击力。）
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_MalfurionCat_001p:HeroPowerBase{
//NAME=野性狂暴
//TEXT=每有一个友方随从，获得2点攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_MalfurionCat_001pe1:Ability{
//NAME=野性狂暴
//TEXT=+2攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_MalfurionCat_001pe2:Ability{
//NAME=野性狂暴
//TEXT=+4攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_MalfurionCat_001pe3:Ability{
//NAME=野性狂暴
//TEXT=+6攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_MalfurionCat_001pe4:Ability{
//NAME=野性狂暴
//TEXT=+8攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_MalfurionCat_001pe5:Ability{
//NAME=野性狂暴
//TEXT=+10攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_MalfurionCat_001pe6:Ability{
//NAME=野性狂暴
//TEXT=+12攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_MalfurionCat_001pe7:Ability{
//NAME=野性狂暴
//TEXT=+14攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Mannoroth_002hb:HeroBase{
//NAME=玛诺洛斯
//TEXT=<i>强大的深渊领主带领着恶魔大军，把永恒之井变成了传送门，试图带来更多入侵者。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_08_Mannoroth_002p:HeroPowerBase{
//NAME=邪能风暴
//TEXT=对所有非恶魔随从造成$1点伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Naisha:MinionBase{
//NAME=娜萨
//TEXT=<b>潜行</b> 在你的回合结束时，召唤一个1/1的 女猎手。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class Story_08_NatureStudies:SpellBase{
//NAME=自然研习
//TEXT=<b>发现</b>一张法术牌。你的下一张法术牌法力值消耗减少（1）点。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class Story_08_NetherweaveBandage:SpellBase{
//NAME=灵纹布绷带
//TEXT=为一个随从恢复4点生命值。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class Story_08_NightmareDemon:MinionBase{
//NAME=梦魇恶魔
//TEXT=<b>战吼：</b>消灭所有敌方随从。
//MAJ=WARLOCK|COST=8|ATK=4|HP=10|RACE=DEMON
}
public class Story_08_NightsaberCub:MinionBase{
//NAME=夜刃豹幼崽
//TEXT=在本随从攻击英雄后，获得+1生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class Story_08_NightsaberCube:Ability{
//NAME=快快长大
//TEXT=+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Nordrassil:MinionBase{
//NAME=诺达希尔
//TEXT=无法攻击。<b>免疫</b>。<b>战吼：</b>在本局对战中，你每施放过一个法术，对敌方英雄造成1点伤害。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=10|RACE=NONE
}
public class Story_08_Planting:SpellBase{
//NAME=种植
//TEXT=<b>训练牌</b> 召唤两个2/2并具有<b>嘲讽</b>的树人。召唤的树人会<b>休眠</b>两回合。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class Story_08_Plantinge:Ability{
//NAME=种植
//TEXT=<b>休眠</b>。 2回合后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Powershifting:SpellBase{
//NAME=强力变形
//TEXT=<b>抉择：</b>在两回合内，将你的英雄替换为猎豹形态；或者熊形态。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class Story_08_PriestessMaiev:MinionBase{
//NAME=女祭司玛维
//TEXT=在你的回合结束时，为所有其他友方角色恢复#5点生命值。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class Story_08_PriestessMaievDormant:MinionBase{
//NAME=女祭司玛维
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_08_PriestessMaievFake:MinionBase{
//NAME=女祭司玛维
//TEXT=在你的回合结束时，为所有其他友方角色恢复#5点生命值。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class Story_08_Ragnaros_007hb:HeroBase{
//NAME=拉格纳罗斯
//TEXT=<i>炎魔之王即将烧毁世界之树，快和其他守护者一同阻止他！</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=90|RACE=NONE
}
public class Story_08_Ragnaros_007p:HeroPowerBase{
//NAME=炎魔之王的怒火
//TEXT=造成8点伤害，分配到所有敌人身上。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Saurfang:MinionBase{
//NAME=瓦罗克·萨鲁法尔
//TEXT=<b>战吼：</b>对敌方英雄造成3点伤害。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=8|RACE=NONE
}
public class Story_08_Saurfang_008h2:HeroBase{
//NAME=瓦罗克·萨鲁法尔
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_08_Saurfang_008p:HeroPowerBase{
//NAME=部落残兵
//TEXT=如果你拥有少于三个随从，则在本回合中你的随从拥有+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Saurfang_008pe:Ability{
//NAME=奋力求生
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_SentinelHuntress:MinionBase{
//NAME=女猎手哨兵
//TEXT=<b>嘲讽</b> 在本回合中，如果你使用过法力值消耗大于或等于（5）的牌，则这张牌的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=5|RACE=NONE
}
public class Story_08_SonofFlamee:Ability{
//NAME=燃起火焰
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_StormRage:SpellBase{
//NAME=风暴之怒
//TEXT=对玛诺洛斯和所有敌方随从造成致命伤害。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class Story_08_Sylvanas_008hb:HeroBase{
//NAME=希尔瓦娜斯·风行者
//TEXT=<i>新的大酋长上任后，部落与联盟间的紧张局势一触即发。</i>
//MAJ=HUNTER|COST=0|ATK=0|HP=100|RACE=NONE
}
public class Story_08_Sylvanas_008p:HeroPowerBase{
//NAME=算计
//TEXT=<b>被动</b> 在一个友方随从死亡后，抽一张牌。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Tyrande:MinionBase{
//NAME=泰兰德·语风
//TEXT=<b>战吼：</b>选择一个角色。如果是友方角色，为其恢复8点生命值；如果是敌方角色，对其造成8点伤害。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=PRIEST|COST=6|ATK=2|HP=8|RACE=NONE
}
public class Story_08_TyrandeDormant:MinionBase{
//NAME=祭司泰兰德
//TEXT=<b>休眠</b>
//MAJ=PRIEST|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_08_TyrandeDormant2:MinionBase{
//NAME=泰兰德·语风
//TEXT=<b>休眠</b>
//MAJ=PRIEST|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_08_TyrandePriestess:MinionBase{
//NAME=祭司泰兰德
//TEXT=<b>法术迸发</b>：为所有友方角色恢复2点生命值。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=PRIEST|COST=6|ATK=2|HP=8|RACE=NONE
}
public class Story_08_UndercityHuckster:MinionBase{
//NAME=幽暗城商贩
//TEXT=<b>亡语：</b>随机将一张<i>（你对手职业的）</i>卡牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=2|HP=2|RACE=NONE
}
public class Story_08_WayofArchdruid:SpellBase{
//NAME=大德鲁伊之道
//TEXT=<b>抉择：</b>随机对敌人造成$8点伤害；或者随机为友方角色恢复#8点生命值。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class Story_08_Weeding:SpellBase{
//NAME=拔除
//TEXT=<b>训练牌</b> 对一个随从造成$1点伤害。如果消灭该随从，抽一张牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class Story_08_WellofEternity:MinionBase{
//NAME=永恒之井
//TEXT=<b>免疫</b> 在你的回合开始时，随机召唤一个恶魔。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=12|RACE=NONE
}
public class Story_08_WildStag:MinionBase{
//NAME=狂野雄鹿
//TEXT=<b>嘲讽</b>，<b>战吼：</b>你手牌中每有一张<b>抉择</b>法术牌，便获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=BEAST
}
public class Story_08_WildStage:Ability{
//NAME=已被选召
//TEXT=+1/+1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_WilloftheWisps:SpellBase{
//NAME=精灵的意志
//TEXT=用1/1的小精灵填满你的面板
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class Story_08_WindrunnersBow:WeaponBase{
//NAME=风行者战弓
//TEXT=在你的英雄攻击后，召唤三个后援。
//MAJ=HUNTER|COST=6|ATK=4|HP=2|RACE=NONE
}
public class Story_08_WindwardHippogryph:MinionBase{
//NAME=临风角鹰兽
//TEXT=<b>冲锋</b>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=BEAST
}
public class Story_08_Xavius_006hb:HeroBase{
//NAME=萨维斯
//TEXT=<i>翡翠梦境中的腐蚀之源从未被根除……直到如今。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_08_Xavius_006p:HeroPowerBase{
//NAME=梦魇诅咒
//TEXT=随机诅咒一个敌方随从，使其在回合结束时攻击其英雄。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_08_Xavius_006pe:Ability{
//NAME=梦魇
//TEXT=在你的回合结束时，对你的英雄造成等同于本随从攻击力的伤害。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_AbyssalEnforcer:MinionBase{
//NAME=渊狱惩击者
//TEXT=<b>战吼：</b>对所有其他角色造成3点伤害。
//MAJ=WARLOCK|COST=7|ATK=6|HP=6|RACE=DEMON
}
public class Story_09_AnimatedBroomstick:MinionBase{
//NAME=活化扫帚
//TEXT=<b>突袭，战吼：</b>使你的其他随从获得<b>突袭</b>。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class Story_09_Atiesh:WeaponBase{
//NAME=埃提耶什
//TEXT=在你施放一个法术后，随机召唤一个法力值消耗相同的随从。 失去1点耐久度。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=3|RACE=NONE
}
public class Story_09_BabyElekk:MinionBase{
//NAME=幼年雷象
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=4|RACE=BEAST
}
public class Story_09_Batterhead:MinionBase{
//NAME=莽头食人魔
//TEXT=<b>突袭</b> 在本随从攻击并消灭一个随从后，可再次攻击。
//MAJ=NEUTRAL|COST=8|ATK=3|HP=12|RACE=NONE
}
public class Story_09_Blackhand_004hb:HeroBase{
//NAME=部落的酋长们
//TEXT=<i>腐蚀兽人的时刻到了。他们即将成为基尔加丹的部队。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Blackhand_004p:HeroPowerBase{
//NAME=战争工具
//TEXT=<i>战斗前夕，兽人酋长们聚在了一起……</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_BladedLady:MinionBase{
//NAME=刀锋舞娘
//TEXT=<b>突袭</b> 如果你的英雄的攻击力大于或等于6点，则法力值消耗为（1）点。
//MAJ=DEMONHUNTER|COST=6|ATK=6|HP=6|RACE=DEMON
//MAJ=DEMONHUNTER|COST=6|ATK=6|HP=6|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Rush");
    }
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.myPlayer.hero.Count>0)
            {
                if(owner.myPlayer.hero[0].GetTag(GameTag.Attack)>=6)
                {
                    return -5;
                }
            }
        }
        return 0;
    }
}
public class Story_09_BlastcrystalPotion:SpellBase{
//NAME=爆晶药水
//TEXT=消灭一个随从，和你的一个法力水晶。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_BloodclawDragon:MinionBase{
//NAME=血爪巨龙
//TEXT=<b>嘲讽</b>。<b>冲锋</b> 每当本随从受到伤害，对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=7|RACE=DRAGON
}
public class Story_09_BonechewerRaider:MinionBase{
//NAME=噬骨骑兵
//TEXT=<b>战吼：</b>如果有受伤的随从，便获得+1/+1和<b>突袭</b>。
//MAJ=WARRIOR|COST=3|ATK=3|HP=3|RACE=NONE
}
public class Story_09_BonechewerVanguard:MinionBase{
//NAME=噬骨先锋
//TEXT=<b>嘲讽</b> 每当本随从受到伤害，便获得+2攻击力。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=10|RACE=NONE
}
public class Story_09_CacheofCash:MinionBase{
//NAME=现金储备箱
//TEXT=<b>亡语：</b>使每个玩家获得两张幸运币。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=NONE
}
public class Story_09_ChoGall:MinionBase{
//NAME=古加尔
//TEXT=<b>法术迸发：</b>在本回合中，你施放的下一个法术不再消耗法力值，转而消耗生命值。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=WARLOCK|COST=7|ATK=7|HP=7|RACE=NONE
}
public class Story_09_ChoGallDormant:MinionBase{
//NAME=古加尔
//TEXT=<b>休眠</b>
//MAJ=WARLOCK|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_09_Clefthoof:MinionBase{
//NAME=裂蹄牛
//TEXT=
//MAJ=HUNTER|COST=4|ATK=3|HP=5|RACE=BEAST
}
public class Story_09_CouncilNecrolyte:MinionBase{
//NAME=暗影议会亡灵侍僧
//TEXT=<b>战吼：</b>摧毁一张你牌库中的灵魂残片，造成3点伤害。
//MAJ=WARLOCK|COST=3|ATK=3|HP=4|RACE=NONE
}
public class Story_09_CouncilWarlock:MinionBase{
//NAME=暗影议会术士
//TEXT=你的恶魔牌法力值消耗减少（1）点。<b>亡语：</b>将“暗影议会”置入你的手牌。
//MAJ=WARLOCK|COST=2|ATK=3|HP=3|RACE=NONE
}
public class Story_09_CouncilWarlock_Puzzle:MinionBase{
//NAME=暗影议会术士
//TEXT=你的恶魔牌法力值消耗减少（1）点。<b>亡语：</b>将“暗影议会”置入你的手牌。
//MAJ=WARLOCK|COST=2|ATK=3|HP=3|RACE=NONE
}
public class Story_09_CurseofWeakness:SpellBase{
//NAME=虚弱诅咒
//TEXT=<b>回响</b> 直到你的下个回合，使所有敌方随从获得-2攻击力。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_DarkestHour:SpellBase{
//NAME=至暗时刻
//TEXT=消灭所有友方随从。每消灭一个随从，便随机从你的牌库中召唤一个随从。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_Darkglare:MinionBase{
//NAME=黑眼
//TEXT=在你的英雄受到伤害后，复原一个 法力水晶。
//MAJ=WARLOCK|COST=2|ATK=2|HP=3|RACE=DEMON
}
public class Story_09_DeathwebSpider:MinionBase{
//NAME=逝网蜘蛛
//TEXT=<b>战吼：</b>如果你的英雄在本回合受到过伤害，获得<b>吸血</b>。
//MAJ=WARLOCK|COST=5|ATK=4|HP=6|RACE=BEAST
}
public class Story_09_DemonfirePuzzle:SpellBase{
//NAME=恶魔之火
//TEXT=对一个随从造成$2点伤害，如果该随从是友方恶魔，则改为使其获得+2/+2。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_09_DesperateClaw:WeaponBase{
//NAME=绝望之爪
//TEXT=当你有<b>过载</b>的法力水晶时，拥有+1攻击力。
//MAJ=SHAMAN|COST=3|ATK=2|HP=3|RACE=NONE
}
public class Story_09_DireWolfAlphaPuzzle:MinionBase{
//NAME=恐狼前锋
//TEXT=相邻的随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class Story_09_DisturbedSpirit:MinionBase{
//NAME=被打扰的灵魂
//TEXT=每当一个随从死亡，便获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class Story_09_DisturbedSpirite:Ability{
//NAME=受到打扰
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_DoomguardPuzzle:MinionBase{
//NAME=末日守卫
//TEXT=<b>冲锋</b>，<b>战吼：</b>随机弃两张牌。
//MAJ=WARLOCK|COST=5|ATK=5|HP=7|RACE=DEMON
	public override void Init()
	{
		TaskInitAbility("Charge");
	}
	public override void Battlecry(Card target=null)
	{
		TaskRandomDiscard();
		TaskRandomDiscard();
	}
}
public class Story_09_DragonEggPuzzle:MinionBase{
//NAME=龙蛋
//TEXT=每当本随从受到 伤害，召唤一条2/1的雏龙。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=2|RACE=NONE
}
public class Story_09_DrainSoul:SpellBase{
//NAME=吸取灵魂
//TEXT=<b>吸血</b> 对一个随从造成 $3点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_Draka:MinionBase{
//NAME=德拉卡
//TEXT=所有狼拥有+1生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=5|RACE=NONE
}
public class Story_09_Drakae:Ability{
//NAME=德拉卡的力量
//TEXT=+1生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_DreadInfernal:MinionBase{
//NAME=恐惧地狱火
//TEXT=<b>战吼：</b>对所有其他角色造成1点伤害。
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=DEMON
}
public class Story_09_DunemaulShaman:MinionBase{
//NAME=砂槌萨满祭司
//TEXT=<b>风怒，过载：</b>（1） 50%几率攻击错误的敌人。
//MAJ=SHAMAN|COST=4|ATK=5|HP=4|RACE=NONE
}
public class Story_09_Durotan:HeroBase{
//NAME=杜隆坦
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_DurotanMinion:MinionBase{
//NAME=杜隆坦
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class Story_09_Duskbreaker:MinionBase{
//NAME=破晓之龙
//TEXT=<b>战吼：</b> 如果你的手牌中有龙牌，则对所有其他随从造成3点伤害。
//MAJ=PRIEST|COST=4|ATK=3|HP=3|RACE=DRAGON
}
public class Story_09_ElekkGrazer:MinionBase{
//NAME=食草雷象
//TEXT=<b>嘲讽</b>，<b>亡语：</b>召唤一只2/4并具有<b>嘲讽</b>的幼年雷象。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=BEAST
}
public class Story_09_EnsnareSoul:SpellBase{
//NAME=诱捕灵魂
//TEXT=对你的英雄造成$3点伤害。将两个在本局对战中死亡的友方随从移回你的手牌。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_FallenSoldier:MinionBase{
//NAME=阵亡士兵
//TEXT=<b>亡语：</b>将一张幸运币置入你对手的手牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=5|RACE=NONE
}
public class Story_09_FantasticFirebird:MinionBase{
//NAME=炫目火鸟
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=ELEMENTAL
}
public class Story_09_FelfirePotion:SpellBase{
//NAME=邪火药水
//TEXT=对所有角色造成$5点伤害。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=FEL
}
public class Story_09_Felhound:MinionBase{
//NAME=地狱犬
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=DEMON
}
public class Story_09_FelLordBetrug:MinionBase{
//NAME=邪能领主贝图格
//TEXT=每当你抽到一张随从牌，召唤一个它的复制。该复制具有<b>突袭</b>，并会在回合结束时死亡。
//MAJ=WARLOCK|COST=8|ATK=5|HP=7|RACE=DEMON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.cardType==CardType.Minion && sz==ZoneType.Deck && tz==ZoneType.Hand)
			{
				Card CreatedCard=TaskCreate(sc.cardDbf,ZoneType.Board);
				new EffectGiveAbility(owner.myPlayer,owner,CreatedCard,"Rush");
				new EffectGiveAbility(owner.myPlayer,owner,CreatedCard,"DieAfterTurnEnd");
			}	
		}
	}
}
public class Story_09_Felrattler:MinionBase{
//NAME=邪能响尾蛇
//TEXT=<b>突袭</b>，<b>亡语：</b>对所有敌方随从造成 1点伤害。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=2|RACE=BEAST
}
public class Story_09_Fenris:HeroBase{
//NAME=芬里斯·狼脉
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Fenris2:HeroBase{
//NAME=芬里斯·狼脉
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_FenrisMinion:MinionBase{
//NAME=芬里斯·狼脉
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class Story_09_FiendishCircle:SpellBase{
//NAME=恶魔法阵
//TEXT=召唤四个1/1的小鬼。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class Story_09_FlameImp:MinionBase{
//NAME=烈焰小鬼
//TEXT=<b>战吼：</b>对你的英雄造成3点伤害。
//MAJ=WARLOCK|COST=1|ATK=3|HP=2|RACE=DEMON
	public override void Battlecry(Card target=null)
	{
		TaskDamageMyHero(3);
	}
}
public class Story_09_FontofPower:SpellBase{
//NAME=能量之泉
//TEXT=<b>发现</b>一张法师随从牌。如果你的牌库中没有随从牌，则保留全部三张牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class Story_09_ForgottenShaman:MinionBase{
//NAME=被遗忘的部族萨满
//TEXT=<b>战吼：</b>将所有敌方随从移回你对手的手牌。<b>亡语：</b>将本随从洗入你的牌库。
//MAJ=NEUTRAL|COST=6|ATK=1|HP=5|RACE=NONE
}
public class Story_09_ForgottenShaman2:MinionBase{
//NAME=被遗忘的部族萨满
//TEXT=<b>战吼：</b>将所有敌方随从移回你对手的手牌。
//MAJ=NEUTRAL|COST=6|ATK=1|HP=5|RACE=NONE
}
public class Story_09_ForgottenWarrior:MinionBase{
//NAME=被遗忘的部族斗士
//TEXT=<b>暴怒：</b>对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=6|RACE=NONE
}
public class Story_09_Garona:MinionBase{
//NAME=半兽人迦罗娜
//TEXT=同时对其攻击目标的相邻随从造成伤害。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=NONE
}
public class Story_09_GrimoireofSacrifice:SpellBase{
//NAME=牺牲魔典
//TEXT=消灭一个友方随从。对所有敌方随从造成$2点伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_Grommash:MinionBase{
//NAME=格罗玛什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=8|ATK=4|HP=9|RACE=NONE
}
public class Story_09_Grommash_004hb:HeroBase{
//NAME=格罗玛什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Grommash_004hb2:HeroBase{
//NAME=格罗玛什·地狱咆哮
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Guldan_001hp:HeroBase{
//NAME=古尔丹
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Guldan_001p:HeroPowerBase{
//NAME=抗拒
//TEXT=你手牌中每有一张法术牌，便为你的英雄恢复1点生命值。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Guldan_002hp:HeroBase{
//NAME=古尔丹
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Guldan_002p:HeroPowerBase{
//NAME=二级抗拒
//TEXT=你手牌中每有一张法术牌，便为你的英雄恢复2点生命值。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Guldan_003hp:HeroBase{
//NAME=古尔丹
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Guldan_004hp:HeroBase{
//NAME=古尔丹
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Guldan_004p:HeroPowerBase{
//NAME=统一之杯
//TEXT=如果场上没有敌方随从，则为一位兽人酋长提供玛诺洛斯之血。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Guldan_005hp:HeroBase{
//NAME=古尔丹
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Guldan_005p:HeroPowerBase{
//NAME=恶魔替代
//TEXT=对你的英雄造成1点伤害。将一个非<b>传说</b>敌方随从替换为法力值消耗减少（1）点的友方恶魔。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Guldan_006hp:HeroBase{
//NAME=古尔丹
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Guldan_006p:HeroPowerBase{
//NAME=二级恶魔替代
//TEXT=受到1点伤害。将一个非传说敌方随从替换为法力值消耗增加（1）点的友方恶魔（最高不超过10点）。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Guldan_007hp:HeroBase{
//NAME=古尔丹
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Guldan_007p:HeroPowerBase{
//NAME=毁灭之雨
//TEXT=对一个随从造成3点伤害。如果该随从死亡，则对相邻随从造成2点伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Guldan_008hp:HeroBase{
//NAME=古尔丹
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Guldan_008p:HeroPowerBase{
//NAME=二级毁灭之雨
//TEXT=对一个随从造成3点伤害。如果该随从死亡，则对相邻随从造成2点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_09_GuldanBoardClear:SpellBase{
//NAME=清场
//TEXT=消灭战场上的所有随从！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_HandofGuldan:SpellBase{
//NAME=古尔丹之手
//TEXT=当你使用或弃掉这张牌时，抽三张牌。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_HarvestSoul:SpellBase{
//NAME=收割灵魂
//TEXT=消灭一个随从，并使塔隆戈尔之魂获得其属性值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_HarvestSoule:Ability{
//NAME=灵魂能量
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Helboar:MinionBase{
//NAME=地狱野猪
//TEXT=<b>亡语：</b>随机使你手牌中的一张野兽牌获得+1/+1。
//MAJ=HUNTER|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class Story_09_HellfirePuzzle:SpellBase{
//NAME=地狱烈焰
//TEXT=对所有角色造成$3点伤害。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(FindAllChar(),3);
    }
}
public class Story_09_HoardingDragon:MinionBase{
//NAME=藏宝巨龙
//TEXT=<b>亡语：</b>使你的对手获得两张幸运币。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=6|RACE=DRAGON
}
public class Story_09_HungryDragon:MinionBase{
//NAME=饥饿的巨龙
//TEXT=<b>战吼：</b>为你的对手随机召唤一个法力值消耗为（1）的随从。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=6|RACE=DRAGON
}
public class Story_09_Hurkan:HeroBase{
//NAME=胡尔坎·裂颅
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Hurkan2:HeroBase{
//NAME=胡尔坎·裂颅
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_HurkanMinion:MinionBase{
//NAME=胡尔坎·裂颅
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class Story_09_Hysteria:SpellBase{
//NAME=狂乱
//TEXT=选择一个敌方随从，使其随机攻击随从，直至死亡。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_Imp:MinionBase{
//NAME=小鬼
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class Story_09_JumboImpPuzzle:MinionBase{
//NAME=巨型小鬼
//TEXT=如果这张牌在你的手牌中，每当一个友方恶魔死亡，法力值消耗就减少（1）点。
//MAJ=WARLOCK|COST=10|ATK=8|HP=8|RACE=DEMON
}
public class Story_09_Kargath:HeroBase{
//NAME=卡加斯·刃拳
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Kargath2:HeroBase{
//NAME=卡加斯·刃拳
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_KargathMinion:MinionBase{
//NAME=卡加斯·刃拳
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class Story_09_Kilrogg:HeroBase{
//NAME=基尔罗格·死眼
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Kilrogg2:HeroBase{
//NAME=基尔罗格·死眼
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_KilroggMinion:MinionBase{
//NAME=基尔罗格·死眼
//TEXT=每当你的对手抽一张牌，随机对一个敌人造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=7|RACE=NONE
}
public class Story_09_KilroggMinion2:MinionBase{
//NAME=基尔罗格·死眼
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=7|RACE=NONE
}
public class Story_09_LakeThresher:MinionBase{
//NAME=止水湖蛇颈龙
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=BEAST
}
public class Story_09_Lethal:SpellBase{
//NAME=斩杀
//TEXT=消灭所有敌方随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Locust:MinionBase{
//NAME=蝗虫
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class Story_09_Maim:MinionBase{
//NAME=麦姆·黑手
//TEXT=每当使用一张龙牌时，失去1点攻击力。
//MAJ=NEUTRAL|COST=7|ATK=3|HP=10|RACE=NONE
}
public class Story_09_Maime:Ability{
//NAME=巨龙驯服
//TEXT=攻击力降低。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Medivh_005hb:HeroBase{
//NAME=麦迪文
//TEXT=<i>这个强大的陌生人无视了遥远的空间距离，直接侵入了你的心灵！</i>
//MAJ=MAGE|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_09_Medivh_005p:HeroPowerBase{
//NAME=装备埃提耶什
//TEXT=装备埃提耶什。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_09_MortalCoilPuzzle:SpellBase{
//NAME=死亡缠绕
//TEXT=对一个随从造成$1点伤害。如果“死亡缠绕”消灭该随从，抽一张牌。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
        if(target.GetTag(GameTag.ZoneType)==(int)ZoneType.Grave)
        {
            TaskDraw();
        }
    }
}
public class Story_09_Nerzhul_003hb:HeroBase{
//NAME=耐奥祖
//TEXT=<i>耐奥祖受到所有兽人氏族的尊重。主人的计划应该用得到他。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Nerzhul_003p:HeroPowerBase{
//NAME=灵魂滋长
//TEXT=对所有非<b>亡语</b>随从造成$1点伤害。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_09_NightshadeMatron:MinionBase{
//NAME=夜影主母
//TEXT=<b>突袭，战吼：</b> 弃掉你手牌中法力值消耗最高的牌。
//MAJ=WARLOCK|COST=4|ATK=5|HP=5|RACE=DEMON
}
public class Story_09_Orgrim_004hb:HeroBase{
//NAME=奥格瑞姆·毁灭之锤
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Orgrim_006hb:HeroBase{
//NAME=奥格瑞姆·毁灭之锤
//TEXT=<i>战争的势头转向了这位暴虐的新贵。他作为大酋长，控制着你的命运。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_09_Orgrim_006p:HeroPowerBase{
//NAME=大酋长的复仇
//TEXT=<b>被动</b> 当你装备着武器时，你的所有随从拥有+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Orgrim_006pe:Ability{
//NAME=复仇
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_OrgrimMinion:MinionBase{
//NAME=奥格瑞姆·毁灭之锤
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class Story_09_OrgrimMinion2:MinionBase{
//NAME=奥格瑞姆·毁灭之锤
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class Story_09_PowerofGuldan:SpellBase{
//NAME=古尔丹之力
//TEXT=抽三张牌。<b>流放：</b>这些牌的法力值消耗减少（3）点。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_PrimordialProtector:MinionBase{
//NAME=始生保护者
//TEXT=<b>战吼：</b>抽取你法力值消耗最高的法术牌，随机召唤一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=6|RACE=ELEMENTAL
}
public class Story_09_PrimordialStudies:SpellBase{
//NAME=始生研习
//TEXT=<b>发现</b>一张<b>法术伤害</b>随从牌。你的下一张<b>法术伤害</b>随从牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class Story_09_Puzzle1_1:SpellBase{
//NAME=第一个饮血
//TEXT=开始斩杀谜题1-1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Puzzle1_2:SpellBase{
//NAME=大酋长的荣耀
//TEXT=开始斩杀谜题1-2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Puzzle1_3:SpellBase{
//NAME=可疑的想法
//TEXT=开始斩杀谜题1-3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Puzzle1_4:SpellBase{
//NAME=重要献祭
//TEXT=开始斩杀谜题1-4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Puzzle1_5:SpellBase{
//NAME=狼群狩猎
//TEXT=开始斩杀谜题1-5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Puzzle1_6:SpellBase{
//NAME=找准弱点
//TEXT=开始斩杀谜题1-6。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Puzzle1_7:SpellBase{
//NAME=数量优势
//TEXT=开始斩杀谜题1-7。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Puzzle1_8:SpellBase{
//NAME=术士的杰作
//TEXT=开始斩杀谜题1-8。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Puzzle2_1_1:SpellBase{
//NAME=引导灵魂
//TEXT=开始清场谜题1-1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Puzzle2_1_2:SpellBase{
//NAME=邪恶集会
//TEXT=开始清场谜题1-2。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Puzzle2_1_3:SpellBase{
//NAME=高效方法
//TEXT=开始清场谜题1-3。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_09_RagingInfernal:MinionBase{
//NAME=盛怒地狱火
//TEXT=战场上每有一个其他恶魔，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=10|ATK=8|HP=8|RACE=DEMON
}
public class Story_09_RainofFire:SpellBase{
//NAME=火焰之雨
//TEXT=对所有角色造成$1点伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=FEL
}
public class Story_09_RaiseDead:SpellBase{
//NAME=亡者复生
//TEXT=对你的英雄造成$3点伤害。将两个在本局对战中死亡的友方随从移回你的手牌。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_RavenFamiliar:MinionBase{
//NAME=乌鸦魔仆
//TEXT=<b>战吼：</b>揭示双方牌库里的一张法术牌。如果你的牌法力值消耗较大，抽这张牌。
//MAJ=MAGE|COST=2|ATK=2|HP=2|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        TaskDrawType(CardType.Spell);
    }
}
public class Story_09_RavenousFamiliar:MinionBase{
//NAME=贪婪的魔仆
//TEXT=<b>突袭，超杀</b>：弃掉你手牌中法力值消耗最低的牌，抽一张牌。
//MAJ=WARLOCK|COST=2|ATK=3|HP=4|RACE=BEAST
}
public class Story_09_RendBlackhand:MinionBase{
//NAME=雷德·黑手
//TEXT=如果有随从的攻击力为（0），则对其发起攻击。
//MAJ=NEUTRAL|COST=7|ATK=8|HP=4|RACE=NONE
}
public class Story_09_Riftcleaver:MinionBase{
//NAME=裂隙屠夫
//TEXT=<b>战吼：</b>消灭一个随从。你的英雄受到等同于该随从生命值的 伤害。
//MAJ=WARLOCK|COST=6|ATK=7|HP=5|RACE=DEMON
}
public class Story_09_RingToss:SpellBase{
//NAME=套圈圈
//TEXT=<b>发现</b>一张<b>奥秘</b>牌并将其施放。<b>腐蚀：</b>改为<b>发现</b>两张。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_09_RingTosst:SpellBase{
//NAME=套圈圈
//TEXT=<b>已腐蚀</b> <b>发现</b>两张<b>奥秘</b>牌并将其施放。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_09_RitualofDoom:SpellBase{
//NAME=末日仪式
//TEXT=消灭一个友方随从。如果你拥有5个或更多随从，召唤一个5/5的恶魔。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_SchoolSpirits:SpellBase{
//NAME=校园精魂
//TEXT=对所有随从造成$2点伤害。将两张灵魂残片洗入你的 牌库。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_SenseDemons:SpellBase{
//NAME=感知恶魔
//TEXT=从你的牌库中抽两张恶魔牌。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card Drawn = TaskDrawRace(RaceType.Demon);
        if(Drawn==null)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("EX1_317t"),ZoneType.Hand);
        }
        Card Drawn2 = TaskDrawRace(RaceType.Demon);
        if(Drawn2==null)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("EX1_317t"),ZoneType.Hand);
        }
    }
}
public class Story_09_SerpentshrinePortal:SpellBase{
//NAME=毒蛇神殿传送门
//TEXT=造成$3点伤害。随机召唤一个法力值消耗为（3）的随从。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class Story_09_ServantofKalimos:MinionBase{
//NAME=卡利莫斯的仆从
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，则<b>发现</b>一张元素牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=ELEMENTAL
}
public class Story_09_Shadowbolt:SpellBase{
//NAME=暗影箭
//TEXT=对一个随从造成$4点伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_09_ShadowCouncil:SpellBase{
//NAME=暗影议会
//TEXT=随机将你的手牌替换成恶魔牌，并使它们获得+2/+2。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=FEL
}
public class Story_09_ShadowCouncil_Puzzle:SpellBase{
//NAME=暗影议会
//TEXT=随机将你的手牌替换成恶魔牌，并使它们获得+2/+2。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=FEL
}
public class Story_09_ShadowreaverWarlock:MinionBase{
//NAME=暴掠术士
//TEXT=<b>法术迸发：</b>将法术牌的一张复制置入你的手牌，其法力值消耗为（0）点。
//MAJ=WARLOCK|COST=1|ATK=2|HP=4|RACE=NONE
}
public class Story_09_ShadowreaverWarlocke:Ability{
//NAME=暴掠
//TEXT=法力值消耗为（1）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_SkeletonPuzzle:MinionBase{
//NAME=骷髅
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class Story_09_Soularium:SpellBase{
//NAME=莫瑞甘的灵界
//TEXT=抽三张牌。在你的回合结束时，弃掉它们。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		for(int i=0;i<3;i++)
		{
			Card Drawn = TaskDraw();
			if(Drawn!=null)
			{
				new EffectGiveAbility(owner.myPlayer,owner,Drawn,"DiscardOnTurnEnd").Resolve();
			}
		}
	}
}
public class Story_09_SoulRend:SpellBase{
//NAME=灵魂撕裂
//TEXT=对所有随从造成$5点伤害。每消灭一个随从，便摧毁你牌库中的一张牌。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),5);
    }
}
public class Story_09_SoulShear:SpellBase{
//NAME=灵魂剥离
//TEXT=对一个随从造成$3点伤害。将两张灵魂残片洗入你的 牌库。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_Soulwringer:MinionBase{
//NAME=绞魂者
//TEXT=<b>战吼：</b>你的牌库中每有一张灵魂残片，召唤一个3/3并具有<b>突袭</b>的灵魂。0<i>（召唤0个）</i>
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=DEMON
}
public class Story_09_SpiritJailer:MinionBase{
//NAME=精魂狱卒
//TEXT=<b>战吼：</b>将两张灵魂残片洗入你的 牌库。
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=DEMON
}
public class Story_09_Sporebat:MinionBase{
//NAME=孢子蝠
//TEXT=<b>嘲讽</b>
//MAJ=HUNTER|COST=4|ATK=4|HP=5|RACE=BEAST
}
public class Story_09_StormwatcherPuzzle:MinionBase{
//NAME=风暴看守
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=7|ATK=4|HP=8|RACE=ELEMENTAL
}
public class Story_09_SuspiciousElemental:MinionBase{
//NAME=可疑的元素
//TEXT=<b>战吼：</b>对所有敌方元素造成2点伤害。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=DEMON
}
public class Story_09_Teron_007hb:HeroBase{
//NAME=阵亡士兵
//TEXT=<i>战争蹂躏着艾泽拉斯的人民。或许你可以利用这个……</i>
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=60|RACE=NONE
}
public class Story_09_Teron_007hb2:HeroBase{
//NAME=塔隆·血魔
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=60|RACE=NONE
}
public class Story_09_Teron_007p:HeroPowerBase{
//NAME=黑暗灌注
//TEXT=<b>被动</b> 将随从受到的致命伤害转化为这个士兵的生命值。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Terongor:MinionBase{
//NAME=塔隆戈尔
//TEXT=<b>战吼：</b>消灭一个随从。如果在本回合被抽到，则改为消灭所有敌方随从。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class Story_09_TerongorShaman:MinionBase{
//NAME=塔隆戈尔
//TEXT=<b>战吼：</b>使所有友方<b>亡语</b>随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class Story_09_TerongorShamane:Ability{
//NAME=塔隆戈尔的祝福
//TEXT=+1/+1
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_TerongorSpirit:MinionBase{
//NAME=塔隆戈尔之魂
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=6|HP=8|RACE=NONE
}
public class Story_09_TerongorSpirit3:MinionBase{
//NAME=塔隆戈尔之魂
//TEXT=当本随从的生命值达到20点时，将它的意识注入阵亡士兵的 体内。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=8|RACE=NONE
}
public class Story_09_Throne_002hb:HeroBase{
//NAME=元素王座
//TEXT=<i>年轻的萨满祭司依照传统拜访了这处圣地，接受元素的祝福和力量。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Throne_002p:HeroPowerBase{
//NAME=元素之怒
//TEXT=<b>被动</b> 如果你的手牌数少于你的对手，则摧毁对手牌库顶的牌。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_TombGuardian_008hb:HeroBase{
//NAME=墓穴守卫
//TEXT=<i>你背叛了奥格瑞姆，这样你就能把部队转移到萨格拉斯之墓，将它的力量取为己用。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=100|RACE=NONE
}
public class Story_09_TombGuardian_008p:HeroPowerBase{
//NAME=萨格拉斯之眼
//TEXT=<b>被动</b> 每隔一个回合，摧毁你对手的1个法力水晶，直至剩下1个。<i>（每次使用都会提升）</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_TormentSoul:SpellBase{
//NAME=折磨灵魂
//TEXT=摧毁三张你牌库中的灵魂残片，对所有随从造成3点伤害。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class Story_09_ViciousFelhound:MinionBase{
//NAME=邪恶的地狱犬
//TEXT=<b>嘲讽</b> 如果你控制两只或更多邪恶的地狱犬，每有一只，你的恶魔牌法力值消耗减少（1）点。<b>亡语：</b>召唤一只2/2并具有<b>突袭</b>的地狱犬。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=DEMON
}
public class Story_09_VioletWurm:MinionBase{
//NAME=紫色岩虫
//TEXT=<b>亡语：</b>召唤七只1/1的肉虫。
//MAJ=NEUTRAL|COST=8|ATK=7|HP=7|RACE=BEAST
}
public class Story_09_VoidDrinker:MinionBase{
//NAME=虚空吸食者
//TEXT=<b>嘲讽，战吼：</b>摧毁一张你牌库中的灵魂残片，获得+3/+3。
//MAJ=WARLOCK|COST=5|ATK=4|HP=5|RACE=DEMON
}
public class Story_09_VolcanicDrake:MinionBase{
//NAME=火山幼龙
//TEXT=在本回合中每有一个随从死亡，本牌的 法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=4|RACE=DRAGON
}
public class Story_09_VulgarHomunculus:MinionBase{
//NAME=粗俗的矮劣魔
//TEXT=<b>嘲讽，战吼：</b>对你的英雄造成2点伤害。
//MAJ=WARLOCK|COST=2|ATK=2|HP=4|RACE=DEMON
}
public class Story_09_Warrior_001hb:HeroBase{
//NAME=被遗忘的战士
//TEXT=<i>已经没人记得古尔丹的村子的头领了，但他残暴的遗风尚在。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Warrior_001p:HeroPowerBase{
//NAME=欺凌弱者
//TEXT=对敌方英雄造成等同于攻击力最高的随从的攻击力的伤害。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_09_WeakenedElemental:MinionBase{
//NAME=虚弱的元素
//TEXT=<b>战吼：</b>对自身造成2点伤害。<b>亡语：</b>使你的所有随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=6|RACE=ELEMENTAL
}
public class Story_09_WeakenedElementale:Ability{
//NAME=已强化
//TEXT=+1/+1
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_WildSpiritWolf_Puzzle:MinionBase{
//NAME=狂野幽灵狼
//TEXT=每当一个友方随从受到伤害时，同时对敌方英雄造成该伤害。
//MAJ=SHAMAN|COST=5|ATK=4|HP=6|RACE=NONE
}
public class Story_09_WorthlessImpPuzzle:MinionBase{
//NAME=游荡小鬼
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class Story_09_WretchedElemental:MinionBase{
//NAME=虚弱的元素
//TEXT=在你施放一个法术 或使用一张元素牌后，使本随从获得+1生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=ELEMENTAL
}
public class Story_09_WretchedElementale:Ability{
//NAME=正在提升
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_09_Zuluhed:HeroBase{
//NAME=疲惫的祖鲁希德
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_Zuluhed2:HeroBase{
//NAME=疲惫的祖鲁希德
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_09_ZuluhedMinion:MinionBase{
//NAME=疲惫的祖鲁希德
//TEXT=<b>战吼：</b>使你的所有随从获得+2/+2和<b>吸血</b>。
//MAJ=NEUTRAL|COST=7|ATK=5|HP=9|RACE=NONE
}
public class Story_09_ZuluhedMinion2:MinionBase{
//NAME=疲惫的祖鲁希德
//TEXT=
//MAJ=NEUTRAL|COST=7|ATK=5|HP=9|RACE=NONE
}
public class Story_09_ZuluhedMinione:Ability{
//NAME=遭受重击
//TEXT=+2/+2，<b>吸血</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Akama:MinionBase{
//NAME=阿卡玛
//TEXT=永久<b>潜行</b>。<b>法术迸发：</b>对敌方英雄造成3点伤害。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=5|RACE=NONE
}
public class Story_10_Akama_008hb:HeroBase{
//NAME=阿卡玛
//TEXT=<i>你曾经最亲密的战友阿卡玛暗中背叛了你，现在，他开始行动了。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=60|RACE=NONE
}
public class Story_10_Akama_008p:HeroPowerBase{
//NAME=闪电链
//TEXT=对一个随从造成$1点伤害。弹跳至相邻的随从，直到某个随从死亡。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_10_AkamaDormant:MinionBase{
//NAME=阿卡玛
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_10_Anubarak_006hb:HeroBase{
//NAME=阿努巴拉克
//TEXT=<i>巫妖王召唤了阿努巴拉克和阿尔萨斯王子来协助他。不能让他们得逞。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_10_Anubarak_006p:HeroPowerBase{
//NAME=蛛网之怒
//TEXT=将一个友方随从移回你的手牌，使其获得+4/+4。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Anubarak_006pe:Ability{
//NAME=愤怒
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Arthas_001hb:HeroBase{
//NAME=阿尔萨斯王子
//TEXT=<i>为了证明你的哥哥是错的，你必须清理森林中的所有敌人，无论他们有多危险……</i>
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_10_Arthas_001p:HeroPowerBase{
//NAME=装备霜之哀伤
//TEXT=装备霜之哀伤。
//MAJ=DEATHKNIGHT|COST=6|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Arthas_007hb:HeroBase{
//NAME=死亡骑士阿尔萨斯
//TEXT=<i>如果阿尔萨斯抵达了冰封王座，见到了巫妖王，就全完了。这是你阻止他的最后机会。</i>
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_10_Arthas_007p:HeroPowerBase{
//NAME=黑暗决心
//TEXT=<b>被动</b> 如果你的随从数量多于你的对手，则在你的回合开始时抽一张牌。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_10_BladeofthePenitent:WeaponBase{
//NAME=悔过之刃
//TEXT=攻击力等同于你在本回合中施放的法术数量。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=4|RACE=NONE
}
public class Story_10_BloodElfAllies:SpellBase{
//NAME=血精灵盟军
//TEXT=<b>发现</b>一张血精灵随从牌。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_10_BrokenAllies:SpellBase{
//NAME=破碎者盟军
//TEXT=<b>发现</b>一张破碎者随从牌。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_10_BrothersStormrage_004:HeroPowerBase{
//NAME=兄弟情仇
//TEXT=<b>抉择：</b>恢复#2点生命值，此时如果目标拥有所有生命值，使其获得<b>法术伤害+1</b>；或者抽三张牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_10_ElderVoidwalker:MinionBase{
//NAME=古老虚空行者
//TEXT=<b>嘲讽</b>，<b>亡语：</b>随机将两张恶魔牌从你的手牌置入战场。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=6|RACE=DEMON
}
public class Story_10_EyeofSargeras:MinionBase{
//NAME=萨格拉斯之眼
//TEXT=无法攻击 消耗50点法力值，激活萨格拉斯之眼，消灭巫妖王。<i>（还剩50点）</i>
//MAJ=NEUTRAL|COST=3|ATK=0|HP=40|RACE=NONE
}
public class Story_10_FatesDemand:SpellBase{
//NAME=命运所需
//TEXT=对所有敌方随从造成你的武器的伤害。抽三张牌。
//MAJ=DEATHKNIGHT|COST=8|ATK=0|HP=0|RACE=NONE
}
public class Story_10_FesteringGhoul:MinionBase{
//NAME=生疮的食尸鬼
//TEXT=<b>战吼：</b>本局对战中每有一个随从死亡，随机对一个敌人造成1点伤害。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=5|RACE=NONE
}
public class Story_10_FlameCrash:SpellBase{
//NAME=烈焰冲撞
//TEXT=消灭一个敌方随从，对敌方英雄造成等同于该随从生命值的伤害。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Frostmourne:WeaponBase{
//NAME=霜之哀伤
//TEXT=<b>战吼：</b>移除你所有 的随从。 <b>亡语：</b>再次召唤之前移除的随从。
//MAJ=DEATHKNIGHT|COST=6|ATK=5|HP=3|RACE=NONE
}
public class Story_10_FrostWyrm:MinionBase{
//NAME=冰霜巨龙
//TEXT=<b>+2冰霜法术伤害</b> <b>亡语：</b>随机<b>冻结</b>三个敌人。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=DRAGON
}
public class Story_10_GreaterMyrmidon:MinionBase{
//NAME=高阶仆从
//TEXT=<b>嘲讽</b>，<b>战吼，亡语：</b>随机将一张<b>流放</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=5|RACE=NONE
}
public class Story_10_IcecrownObelisk:MinionBase{
//NAME=冰冠方尖碑
//TEXT=<b>亡语：</b>获得本随从的控制权。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=15|RACE=NONE
}
public class Story_10_Illidan_001hp:HeroBase{
//NAME=伊利丹
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_10_Illidan_002hp:HeroBase{
//NAME=伊利丹
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_10_Illidan_003hp:HeroBase{
//NAME=伊利丹
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_10_Illidan_003p:HeroPowerBase{
//NAME=古尔丹之颅
//TEXT=抽三张牌。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Illidan_004hp:HeroBase{
//NAME=伊利丹
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_10_Illidan_004p:HeroPowerBase{
//NAME=二级古尔丹之颅
//TEXT=抽三张牌。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Illidan_005hp:HeroBase{
//NAME=伊利丹
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_10_Illidan_005p:HeroPowerBase{
//NAME=流放苦战
//TEXT=你手牌中每有一张<b>流放</b>牌，便获得+1攻击力。<i>（当前1点）</i>
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Illidan_006hp:HeroBase{
//NAME=伊利丹
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_10_Illidan_006p:HeroPowerBase{
//NAME=二级流放苦战
//TEXT=你手牌中每有一张<b>流放</b>牌，便获得+1攻击力。<i>（当前1点）</i>
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Illidan_007hp:HeroBase{
//NAME=伊利丹
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_10_Illidan_007p:HeroPowerBase{
//NAME=装备战刃
//TEXT=装备埃辛诺斯战刃。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Illidan_008hp:HeroBase{
//NAME=伊利丹
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_10_Illidan_008p:HeroPowerBase{
//NAME=召唤盟军
//TEXT=<b>发现</b>一张盟军随从牌。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_10_IllidanMal_004hp:HeroBase{
//NAME=伊利丹和玛法里奥
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_10_IllidariStudies:SpellBase{
//NAME=伊利达雷研习
//TEXT=<b>发现</b>一张<b>流放</b>牌。你的下一张<b>流放</b>牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Kaelthas:MinionBase{
//NAME=凯尔萨斯·逐日者
//TEXT=在每回合中，你每施放三个法术，第三个法术的法力值消耗为（1）点。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=7|RACE=NONE
}
public class Story_10_KaelthasDormant:MinionBase{
//NAME=凯尔萨斯·逐日者
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_10_KaldoreiMemories:SpellBase{
//NAME=卡多雷记忆
//TEXT=随机召唤一个泰达希尔生物。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_10_LadyVashj:MinionBase{
//NAME=瓦丝琪女士
//TEXT=<b>法术伤害+1</b> <b>战吼：</b>抽三张随从牌，并使其法力值消耗减少（3）点。<b>亡语：</b>将本随从洗入你的牌库。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=4|RACE=NONE
}
public class Story_10_LadyVashj2:MinionBase{
//NAME=瓦丝琪女士
//TEXT=<b>法术伤害+1</b> <b>暴怒：</b>从你的牌库中抽三张法术牌，并使其法力值消耗减少（3）点。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=4|RACE=NONE
}
public class Story_10_LadyVashjDormant:MinionBase{
//NAME=瓦丝琪女士
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_10_LordofOutland:SpellBase{
//NAME=外域之王
//TEXT=抽三张牌，在本回合中获得+3攻击力，并在你对手的下个回合摧毁对手的三个法力水晶。
//MAJ=DEMONHUNTER|COST=9|ATK=0|HP=0|RACE=NONE
}
public class Story_10_LordofOutlande:Ability{
//NAME=法力烧尽
//TEXT=本回合开始时减少三个法力水晶。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Magtheridon_005hb:HeroBase{
//NAME=玛瑟里顿
//TEXT=<i>这个深渊领主已经征服了外域这个破碎的世界，至少他是这么想的……</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=100|RACE=NONE
}
public class Story_10_Magtheridon_005p:HeroPowerBase{
//NAME=顺劈斩
//TEXT=对所有敌人造成$2点伤害。每有一个随从死亡，从你的手牌中召唤一个随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Maiev_003hb:HeroBase{
//NAME=玛维·影歌
//TEXT=<i>千百年来，她始终自视为你的看守者。她坚决要将你抓捕回去。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_10_Maiev_003p:HeroPowerBase{
//NAME=装备守望者的战刃
//TEXT=装备守望者的战刃。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Malfurion_004hb:HeroBase{
//NAME=玛法里奥·怒风
//TEXT=<i>他出现得太不是时候了——你的关键法术即将完成！</i>
//MAJ=DRUID|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_10_Malfurion_004p:HeroPowerBase{
//NAME=宁静
//TEXT=恢复#2点生命值。此时如果目标拥有所有生命值，使其获得<b>法术伤害+1</b>。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Manipulate:SpellBase{
//NAME=操纵
//TEXT=将每个玩家手牌中的各一个随机随从置入战场。如果你的随从法力值消耗更高，使其攻击敌方英雄。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=NONE
}
public class Story_10_MoargPainsmith:MinionBase{
//NAME=莫尔葛痛苦工匠
//TEXT=<b>嘲讽</b>，<b>战吼：</b>每有一个友方恶魔，便获得+1/+1。<b>亡语：</b>使所有友方随从获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=DEMON
}
public class Story_10_MoargPainsmithe:Ability{
//NAME=痛苦打造
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_10_MoargPainsmithe2:Ability{
//NAME=痛苦打造
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_10_MurgulReaver:MinionBase{
//NAME=深海鱼人掠夺者
//TEXT=<b>战吼：</b>从你的牌库中召唤三个法力值消耗小于或等于（3）点的<b>亡语</b>随从。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=MURLOC
}
public class Story_10_NagaAllies:SpellBase{
//NAME=纳迦盟军
//TEXT=<b>发现</b>一张纳迦随从牌。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_10_NagaArmy:SpellBase{
//NAME=纳迦大军
//TEXT=<b>发现</b>一张纳迦随从牌。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_10_NagaMyrmidon:MinionBase{
//NAME=纳迦侍从
//TEXT=<b>嘲讽</b>，<b>亡语：</b>从你的手牌中召唤一个法力值消耗小于或等于（3）点的<b>亡语</b>随从。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=NONE
}
public class Story_10_ParasiticShadowfiend:MinionBase{
//NAME=寄生暗影魔
//TEXT=<b>吸血</b>，<b>亡语：</b>获得一个空的法力水晶。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class Story_10_PoisonTreant:MinionBase{
//NAME=剧毒树人
//TEXT=<b>剧毒</b>，<b>战吼：</b>摧毁一张你牌库中的灵魂残片，造成3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=NONE
}
public class Story_10_PrimordialStudies:SpellBase{
//NAME=始生研习
//TEXT=<b>发现</b>一张<b>法术伤害</b>随从牌。你的下一张<b>法术伤害</b>随从牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class Story_10_RuthlessWrathguard:MinionBase{
//NAME=鲁莽的愤怒卫士
//TEXT=<b>冲锋</b>，<b>吸血</b> 在你使用一张恶魔牌后，将本随从移回你的手牌。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class Story_10_SageInvisibility:SpellBase{
//NAME=贤者隐身术
//TEXT=在本回合中，你的所有<b>潜行</b>随从<b>免疫</b>。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_10_SageInvisibilitye:Ability{
//NAME=贤者
//TEXT=在本回合中<b>免疫</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_10_SecondSlice:SpellBase{
//NAME=二次斩击
//TEXT=在本回合中，使你的英雄获得+2攻击力。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_10_ShadowDemon:MinionBase{
//NAME=影魔
//TEXT=<b>+2邪能法术伤害</b> <b>亡语：</b>弃掉你对手的两张手牌。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=DEMON
}
public class Story_10_ShadowStrike:SpellBase{
//NAME=暗影打击
//TEXT=使一个友方随从获得<b>潜行</b>，并对敌方英雄造成等同于该随从攻击力的伤害。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_10_SkullofGuldan:MinionBase{
//NAME=古尔丹之颅
//TEXT=对敌人造成40点伤害，夺取古尔丹之颅。<i>（还剩40点）</i>
//MAJ=NEUTRAL|COST=3|ATK=0|HP=2|RACE=NONE
}
public class Story_10_SkullofGuldanSpell:SpellBase{
//NAME=古尔丹之颅
//TEXT=抽三张牌。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_10_StalkingSaber:MinionBase{
//NAME=追猎刃豹
//TEXT=<b>潜行</b> 每当本随从攻击时，获得+1耐久度。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=BEAST
}
public class Story_10_StalkingSabere:Ability{
//NAME=刃豹之力
//TEXT=耐久度提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_10_StolenVengeance:WeaponBase{
//NAME=失窃的复仇
//TEXT=<b>吸血</b> <b>流放：</b>对所有敌方随从造成3点伤害。
//MAJ=DEMONHUNTER|COST=3|ATK=2|HP=2|RACE=NONE
}
public class Story_10_SulkingImp:MinionBase{
//NAME=生闷气的小鬼
//TEXT=<b>战吼：</b>对一个敌方随从造成2点伤害。如果目标随从死亡，则将本随从移回你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=DEMON
}
public class Story_10_SummonShadowDemons:SpellBase{
//NAME=召唤影魔
//TEXT=召唤一个6/6的影魔。<b>流放：</b>召唤两个影魔。
//MAJ=DEMONHUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class Story_10_TIchondrius_002hb:HeroBase{
//NAME=提克迪奥斯
//TEXT=<i>击败这个恶魔，偷取他的力量，对你和你兄弟的目标都有帮助……对吧？</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_10_Tichondrius_002p:HeroPowerBase{
//NAME=腐臭蝠群
//TEXT=随机对三个敌方随从各造成$1点 伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_10_Tranquility:SpellBase{
//NAME=宁静
//TEXT=恢复#2点生命值。此时如果目标拥有所有生命值，使其获得<b>法术伤害+1</b>。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class Story_10_TwinSlice:SpellBase{
//NAME=双刃斩击
//TEXT=在本回合中，使你的英雄获得+2攻击力。将“二次斩击”置入你的手牌。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskBuffMyHero(atk:2);
        TaskCreate(CardDbf.GetCardDbfByGuid("BT_175t"),ZoneType.Hand);
    }
}
public class Story_10_Tyrande:MinionBase{
//NAME=泰兰德·语风
//TEXT=
//MAJ=PRIEST|COST=4|ATK=4|HP=7|RACE=NONE
}
public class Story_10_TyrandeTrapped:MinionBase{
//NAME=被困的泰兰德
//TEXT=<b>休眠</b> 击败维拉斯，解救泰兰德。
//MAJ=PRIEST|COST=4|ATK=4|HP=5|RACE=NONE
}
public class Story_10_UnleashedTerrorguard:MinionBase{
//NAME=获释的恐惧卫士
//TEXT=<b>战吼：</b>战场上每有一个友方随从，将一张灵魂残片洗入你的 牌库。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=6|RACE=DEMON
}
public class Story_10_Velas_004hb:HeroBase{
//NAME=死亡骑士维拉斯
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_10_Velas_004p:HeroPowerBase{
//NAME=墓地召唤
//TEXT=随机召唤一个亡灵。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_10_VengefulCryptLord:MinionBase{
//NAME=复仇地穴领主
//TEXT=每当本随从受到伤害，随机召唤一个蛛魔随从。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=4|RACE=NONE
}
public class Story_10_WardensDetermination:SpellBase{
//NAME=守望者的决心
//TEXT=使你手牌，牌库和战场上的所有随从获得+2/+2。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_10_WardensDeterminatione:Ability{
//NAME=坚定
//TEXT=+2/+2
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_10_WardensGlaive:WeaponBase{
//NAME=守望者的战刃
//TEXT=如果该武器消灭了敌方随从，使相邻的随从<b>休眠</b>2回合。
//MAJ=ROGUE|COST=5|ATK=3|HP=2|RACE=NONE
}
public class Story_11_AbyssalEnvoy:MinionBase{
//NAME=深渊使者
//TEXT=在你的回合结束时，随机吞食一个敌方随从并获得其属性值。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=1|RACE=NONE
}
public class Story_11_AbyssalEnvoye:Ability{
//NAME=吞噬者
//TEXT=属性值提高
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_AbyssalJailor_013hb:HeroBase{
//NAME=深渊狱卒
//TEXT=<i>唯有极为坚韧的意志，才能战胜牢笼中的黑暗。</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=70|RACE=NONE
}
public class Story_11_AbyssalKey:SpellBase{
//NAME=深渊钥匙
//TEXT=<i>将你放出永恒王宫的牢笼。</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_AbyssalWarden:MinionBase{
//NAME=深渊看守
//TEXT=<b>战吼，亡语：</b>消灭所有敌方<b>传说</b>随从。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=NONE
}
public class Story_11_AbyssalWarden2:MinionBase{
//NAME=深渊看守
//TEXT=<b>战吼，亡语：</b>消灭所有敌方<b>传说</b>随从。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=NONE
}
public class Story_11_Activate:SpellBase{
//NAME=启动海兽号
//TEXT=消灭所有敌方随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_AncientTrident:WeaponBase{
//NAME=上古三叉戟
//TEXT=在你的英雄攻击后，<b>发现</b>一张法术牌，并向随机目标施放。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=NONE
}
public class Story_11_AquaticForm:SpellBase{
//NAME=水栖形态
//TEXT=<b>探底</b>。如果你在本回合中有足够的法力值使用选中的牌，则抽取这张牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ArcanotronPuzzle:MinionBase{
//NAME=奥能金刚
//TEXT=双方玩家拥有 <b>法术伤害+2</b>。
//MAJ=NEUTRAL|COST=0|ATK=2|HP=2|RACE=MECHANICAL
}
public class Story_11_Azshara_016hb:HeroBase{
//NAME=艾萨拉女王
//TEXT=<i>如果这就是一切的终结，至少你在终结之前获知了真相。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=100|RACE=NONE
}
public class Story_11_Azshara_016p:HeroPowerBase{
//NAME=光中之光
//TEXT=对一个敌方随从造成$2点伤害。如果该随从死亡，摧毁你对手法力值消耗最低的手牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_AzsharanMoonPuzzle:MinionBase{
//NAME=艾萨拉的观月仪
//TEXT=<b>圣盾</b>，<b>战吼：</b>将一张沉没的观月仪置于你的牌库底。
//MAJ=PALADIN|COST=3|ATK=4|HP=2|RACE=MECHANICAL
}
public class Story_11_AzsharanSweeper:MinionBase{
//NAME=艾萨拉的清道夫
//TEXT=<b>战吼：</b>将一张沉没的清道夫置于你的牌库底。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=MECHANICAL
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("TSC_776t"),ZoneType.Deck);
    }
}
public class Story_11_BackupPlan:SpellBase{
//NAME=后备方案
//TEXT=在费林造成16点伤害后，召唤海兽号。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BackupPlane:Ability{
//NAME=后备方案
//TEXT=造成16点伤害以召唤海兽号。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BagofCoinsPuzzle:SpellBase{
//NAME=一袋钱币
//TEXT=将三张幸运币置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BehemothsLure:MinionBase{
//NAME=巨鳗的诱饵
//TEXT=当被攻击时使攻击者获得生物荧光。在你的回合结束时，随机迫使一个敌方随从攻击黑水巨鳗。
//MAJ=PRIEST|COST=2|ATK=1|HP=4|RACE=BEAST
}
public class Story_11_BiggestFix:SpellBase{
//NAME=最大的大修
//TEXT=修好引擎室的各个部分。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Bioluminescente:Ability{
//NAME=荧光
//TEXT=<b>法术伤害+1</b>
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BitterTears:SpellBase{
//NAME=苦涩回忆
//TEXT=当费林受到伤害时，为你的英雄恢复等量的生命值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BitterTearse:Ability{
//NAME=苦涩回忆
//TEXT=费林会在受到伤害时治疗你的英雄。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BlackwaterBehemoth:MinionBase{
//NAME=黑水巨鳗
//TEXT=<b>巨型+1</b> 在你的回合结束时，对没有生物荧光的敌方随从造成3点伤害。<b>亡语：</b>推进战斗。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=10|RACE=BEAST
}
public class Story_11_BoardClear:SpellBase{
//NAME=维修海兽号
//TEXT=修理引擎室的各个部分。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BoldCharge:SpellBase{
//NAME=大胆冲锋
//TEXT=使哈鲁斯获得<b>冲锋</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BoldCharge2:SpellBase{
//NAME=二级大胆冲锋
//TEXT=使哈鲁斯和相邻的随从获得<b>冲锋</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BoldCharge2e:Ability{
//NAME=大胆向前
//TEXT=所有友方随从拥有<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BoldCharge3:SpellBase{
//NAME=三级大胆冲锋
//TEXT=使所有友方随从获得<b>突袭</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BoldCharge3e:Ability{
//NAME=大胆向前
//TEXT=使所有友方随从获得<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BoldChargee:Ability{
//NAME=大胆向前
//TEXT=拥有<b>冲锋</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BombMinions:SpellBase{
//NAME=炸弹
//TEXT=<b>抽到时施放</b> 随机友方随从受到5点伤害。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Bookworm:HeroPowerBase{
//NAME=书虫
//TEXT=<b>被动</b> 在一本故事书被召唤后，获得+3生命值并抽3张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BrightIdea:SpellBase{
//NAME=好主意
//TEXT=使伊妮获得<b>暴怒：</b>将一张海床救生员置入你的手牌，其法力值消耗为（0）点。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BrightIdeae:Ability{
//NAME=好主意
//TEXT=<b>暴怒：</b>将一张海床救生员置入你的手牌，其法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Bubblebote:Ability{
//NAME=吐出来
//TEXT=<b>亡语：</b>召唤本随从上次攻击的随从。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BubblebotPuzzle:MinionBase{
//NAME=泡泡机器人
//TEXT=<b>战吼：</b> 使你的所有其他机械获得<b>圣盾</b>和<b>嘲讽</b>。
//MAJ=PALADIN|COST=4|ATK=4|HP=4|RACE=MECHANICAL
}
public class Story_11_BubblerPuzzle:MinionBase{
//NAME=泡泡元素
//TEXT=在本随从受到刚好一点伤害后，消灭本随从。<i>（啪！）</i>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=4|RACE=ELEMENTAL
}
public class Story_11_BubbleUp:SpellBase{
//NAME=气泡上浮
//TEXT=使卡耶获得<b>亡语：</b>随机使一个友方随从获得<b>圣盾</b>。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_BubbleUpe:Ability{
//NAME=气泡上浮
//TEXT=<b>亡语：</b>随机使一个友方随从获得<b>圣盾</b>。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Captain_006hb:HeroBase{
//NAME=玛雅船长
//TEXT=<i>这位勇敢的船长需要帮助，别让他们落水！</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Captain_006p:HeroPowerBase{
//NAME=正在沉没
//TEXT=<b>被动</b> 在对手的回合结束时消灭最外侧的随从，对所有敌人造成2点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Capture:SpellBase{
//NAME=夺取
//TEXT=达斯利使所有纳迦随从获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Capturee:Ability{
//NAME=正在夺取！
//TEXT=达斯利使所有纳迦随从获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Caye_012hp:HeroBase{
//NAME=卡耶·星暮
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Caye_012p:HeroPowerBase{
//NAME=鼓舞
//TEXT=随机使你手牌中的一张随从牌获得+1/+1，抽一张牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Caye_012pe:Ability{
//NAME=备受鼓舞
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Caye_013hp:HeroBase{
//NAME=卡耶·星暮
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Caye_013p:HeroPowerBase{
//NAME=二级鼓舞
//TEXT=随机使你手牌中的一张随从牌获得+2/+2，抽一张牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Caye_013pe:Ability{
//NAME=更受鼓舞
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Caye_1:MinionBase{
//NAME=卡耶·星暮
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=PRIEST|COST=2|ATK=3|HP=4|RACE=NONE
}
public class Story_11_Caye_1Dormant:MinionBase{
//NAME=卡耶·星暮
//TEXT=<b>休眠</b>
//MAJ=PRIEST|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_Caye_2:MinionBase{
//NAME=卡耶·星暮
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=PRIEST|COST=2|ATK=4|HP=5|RACE=NONE
}
public class Story_11_Caye_2Dormant:MinionBase{
//NAME=卡耶·星暮
//TEXT=<b>休眠</b>
//MAJ=PRIEST|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_Caye_3:MinionBase{
//NAME=卡耶·星暮
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=PRIEST|COST=3|ATK=5|HP=6|RACE=NONE
}
public class Story_11_Caye_3Dormant:MinionBase{
//NAME=卡耶·星暮
//TEXT=<b>休眠</b>
//MAJ=PRIEST|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_CharmOffensive:SpellBase{
//NAME=魅力攻势
//TEXT=使所有敌方随从的攻击力降低1点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_CharmOffensivee:Ability{
//NAME=魅惑
//TEXT=攻击力降低。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Clapback:SpellBase{
//NAME=还手
//TEXT=当敌方随从攻击时，格蕾丝会对其造成1点伤害。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Clapbacke:Ability{
//NAME=还手
//TEXT=在一个敌方随从攻击后，对其造成1点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ClockworkGoblinPuzzle:MinionBase{
//NAME=发条地精
//TEXT=<b>战吼：</b>将一张“炸弹” 牌洗入你对手的牌库。当抽到“炸弹”时，便会受到5点伤害。
//MAJ=WARRIOR|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class Story_11_Compass_009p:HeroPowerBase{
//NAME=芬利的罗盘
//TEXT=每有一个友方随从，随机对一个敌人造成1点伤害。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Crowbar:WeaponBase{
//NAME=结实的撬棍
//TEXT=<i>用于撬开狭窄的缝隙。</i>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class Story_11_Crowbar2:WeaponBase{
//NAME=水手的撬棍
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
}
public class Story_11_Crowbar3:WeaponBase{
//NAME=烫手的撬棍
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
}
public class Story_11_CrystalPowerPuzzle:SpellBase{
//NAME=水晶之力
//TEXT=<b>抉择：</b>对一个随从造成$2点伤害；或者恢复#5点生命值。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class Story_11_Dathril2:MinionBase{
//NAME=达斯利·伊文兰尔
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=10|RACE=NAGA
}
public class Story_11_Dathril_011hp:HeroBase{
//NAME=达斯利·伊文兰尔
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Dathril_011p:HeroPowerBase{
//NAME=达斯利的护符
//TEXT=<b>被动</b> 你的攻击会为所有友方角色恢复2点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Dathril_012hb:HeroBase{
//NAME=达斯利·伊文兰尔
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=70|RACE=NONE
}
public class Story_11_Dathril_012p:HeroPowerBase{
//NAME=捕捉
//TEXT=对一个敌人造成$2点伤害。如果你在本回合中使用过纳迦牌，则改为造成$3点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Dathril_Dormant:MinionBase{
//NAME=达斯利·伊文兰尔
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_DathrilMinion:MinionBase{
//NAME=年轻的达斯利·伊文兰尔
//TEXT=<i>正直的贵族，费林最好的朋友。</i>
//MAJ=HUNTER|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_DathrilsAmulet:SpellBase{
//NAME=达斯利的护符
//TEXT=当达斯利攻击时，为所有友方随从恢复1点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_DathrilsAmulet2e:Ability{
//NAME=达斯利的护符
//TEXT=当本角色攻击时，为所有友方随从恢复1点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_DreamTeam:SpellBase{
//NAME=梦幻团队
//TEXT=卡耶使你的<b>传说</b>随从获得+1/+2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_DreamTeame:Ability{
//NAME=梦幻团队
//TEXT=+1/+2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_DredgeLord:SpellBase{
//NAME=探底之王
//TEXT=使费林获得<b>法术迸发</b>：将一张<b>探底</b>法术牌置入你的手牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_DredgeLorde:Ability{
//NAME=正在探底
//TEXT=<b>法术迸发</b>：将一张<b>探底</b>法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Drill:WeaponBase{
//NAME=积雷钻头
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=4|HP=1|RACE=NONE
}
public class Story_11_Drill2:WeaponBase{
//NAME=过载钻头
//TEXT=<i>攻击海兽号以施展积雷过载！</i>
//MAJ=NEUTRAL|COST=0|ATK=100|HP=1|RACE=NONE
}
public class Story_11_Drill3:WeaponBase{
//NAME=炎钻5000型
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=1|ATK=4|HP=1|RACE=NONE
}
public class Story_11_EnchantedStatue2:HeroBase{
//NAME=附魔的雕像
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=60|RACE=NONE
}
public class Story_11_EnchantedStatue_010hb:HeroBase{
//NAME=附魔的雕像
//TEXT=<i>雕像雕琢出了女祭司依苏蕾尔的形象，仿佛凝视着你的灵魂。</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=60|RACE=NONE
}
public class Story_11_EnragedWavelord:MinionBase{
//NAME=愤怒的波涛领主
//TEXT=<b>突袭</b>。在成灾洪水被触发后，获得+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=ELEMENTAL
}
public class Story_11_EnragedWavelorde:Ability{
//NAME=怒涛
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Errgl_009hb:HeroBase{
//NAME=厄戈尔表弟
//TEXT=<i>厄戈尔虽说是位破坏力惊人的稀客，但总能受到莫格顿家的欢迎。</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_11_ExcavationPuzzle:MinionBase{
//NAME=挖掘专家
//TEXT=<b>战吼：</b><b>探底</b>。选中的牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=NONE
}
public class Story_11_ExceptionalAide:SpellBase{
//NAME=优秀助手
//TEXT=使卡耶获得能力，在攻击时为你的英雄恢复2点生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ExceptionalAide2:SpellBase{
//NAME=二级优秀助手
//TEXT=使卡耶获得能力，在攻击时为你的英雄恢复3点生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ExceptionalAide2e:Ability{
//NAME=越发优秀
//TEXT=当本角色攻击时，为你的英雄恢复3点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ExceptionalAide3:SpellBase{
//NAME=三级优秀助手
//TEXT=使卡耶获得能力，在攻击时为你的英雄恢复4点生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ExceptionalAide3e:Ability{
//NAME=秀出天际
//TEXT=当本角色攻击时，为你的英雄恢复4点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ExceptionalAidee:Ability{
//NAME=优秀
//TEXT=当本角色攻击时，为你的英雄恢复2点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ExplorersPride:SpellBase{
//NAME=探险者的骄傲
//TEXT=每回合随机将一张圣骑士法术牌置入你的牌库。这些牌只能在你的手牌中存在1回合。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ExplorersPridee:Ability{
//NAME=探险者的骄傲
//TEXT=每回合随机将一张圣骑士法术牌置入你的牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ExplorersSceptor:WeaponBase{
//NAME=探险者之杖
//TEXT=<b>法术伤害+1</b>，<b>战吼：</b>获得8点护甲值。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=2|RACE=NONE
}
public class Story_11_ExploretheSeas:SpellBase{
//NAME=探索大海
//TEXT=<b>任务线：</b>施放4个法术。<b>奖励：</b>获得3点护甲值和3点攻击力。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ExploretheSeas2:SpellBase{
//NAME=危险水域
//TEXT=<b>任务线：</b>施放5个法术。<b>奖励：</b>获得5点护甲值，抽一张牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ExploretheSeas3:SpellBase{
//NAME=无法回头
//TEXT=<b>任务线：</b>施放6个法术。<b>奖励：</b>探险者之杖。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ExploretheSease:Ability{
//NAME=探险
//TEXT=+3攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Extinguish:SpellBase{
//NAME=灭火
//TEXT=修复引擎室的各个部分。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FacelessSummonPuzzle:MinionBase{
//NAME=无面召唤者
//TEXT=<b>战吼：</b>随机召唤一个法力值消耗为（3）的随从。
//MAJ=MAGE|COST=6|ATK=5|HP=5|RACE=NONE
}
public class Story_11_Faelin_000hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_000p:HeroPowerBase{
//NAME=选择船员
//TEXT=从对战面板对侧选择你的最后一位船员。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_001hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_001p:HeroPowerBase{
//NAME=深入探底
//TEXT=<b>探底</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_002hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_002p:HeroPowerBase{
//NAME=二级深入探底
//TEXT=<b>探底</b>。如果你在本回合中有足够的法力值使用选中的牌，则抽取这张牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_003hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_003p:HeroPowerBase{
//NAME=三级深入探底
//TEXT=<b>探底</b>。如果你在本回合中有足够的法力值使用选中的牌，则抽取这张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_005hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_005p:HeroPowerBase{
//NAME=四级深入探底
//TEXT=<b>探底</b>。 如果选中的是法术牌，使其法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_006hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_006p:HeroPowerBase{
//NAME=一级建议
//TEXT=<b>发现</b>点有用的东西！
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_007hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_007p:HeroPowerBase{
//NAME=二级建议
//TEXT=<b>发现</b>点有用的东西！
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_009hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_009p:HeroPowerBase{
//NAME=回收
//TEXT=召唤一个属性值等同于在本局对战中死亡的友方机械数量的机械。（当前0点）
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_009pe:Ability{
//NAME=已回收
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_010hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_010p:HeroPowerBase{
//NAME=二级回收
//TEXT=召唤一个属性值等同于在本局对战中死亡的友方机械数量的机械。（当前0点）
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_011hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_011p:HeroPowerBase{
//NAME=三级回收
//TEXT=召唤一个属性值等同于在本局对战中死亡的友方机械数量的机械。（当前0点）
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_012hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_015hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_015p:HeroPowerBase{
//NAME=支援船员
//TEXT=你场上每有一个<b>传说</b>随从，抽一张牌。如果他们拥有所有生命值，则使抽到的牌法力值消耗降低（1）点。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_016hp:HeroBase{
//NAME=费林大使
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Faelin_016p:HeroPowerBase{
//NAME=二级支援船员
//TEXT=你场上每有一个<b>传说</b>随从，抽一张牌。如果他们拥有所有生命值，则使抽到的牌法力值消耗降低（1）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_016p2:HeroPowerBase{
//NAME=费林的护符
//TEXT=对所有敌人造成$2点伤害。每有一个随从死亡，从你的手牌中召唤一个随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Faelin_1:MinionBase{
//NAME=费林大使
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=DRUID|COST=4|ATK=4|HP=5|RACE=NONE
}
public class Story_11_Faelin_1Dormant:MinionBase{
//NAME=费林大使
//TEXT=<b>休眠</b>
//MAJ=DRUID|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_Faelin_2:MinionBase{
//NAME=费林大使
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=DRUID|COST=4|ATK=4|HP=5|RACE=NONE
}
public class Story_11_Faelin_2Dormant:MinionBase{
//NAME=费林大使
//TEXT=<b>休眠</b>
//MAJ=DRUID|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_FaelinMinion:MinionBase{
//NAME=年轻的费林
//TEXT=<i>辛艾萨莉最耀眼的反派。</i>
//MAJ=DRUID|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_FaelinsAmulet:SpellBase{
//NAME=费林的护符
//TEXT=当费林攻击时，为所有友方随从恢复1点生命值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FaelinsAmulet11:SpellBase{
//NAME=费林的护符
//TEXT=<i>饱含情谊的纪念品，承载着沉甸甸的岁月。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FaelinsAmulet16:SpellBase{
//NAME=费林的护符
//TEXT=<i>释放护符的力量来对抗艾萨拉女王，安全撤离。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FaelinsAmulete:Ability{
//NAME=费林的护符
//TEXT=攻击会为所有友方随从恢复1点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Finley_009hp:HeroBase{
//NAME=芬利爵士
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Finley_009p:HeroPowerBase{
//NAME=换！
//TEXT=将你的手牌和牌库底的牌交换。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Finley_1:MinionBase{
//NAME=芬利爵士
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=PALADIN|COST=1|ATK=1|HP=3|RACE=MURLOC
}
public class Story_11_Finley_1Dormant:MinionBase{
//NAME=芬利爵士
//TEXT=<b>休眠</b>
//MAJ=PALADIN|COST=11|ATK=0|HP=1|RACE=MURLOC
}
public class Story_11_Finley_2:MinionBase{
//NAME=芬利爵士
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=PALADIN|COST=2|ATK=2|HP=4|RACE=MURLOC
}
public class Story_11_Finley_2Dormant:MinionBase{
//NAME=芬利爵士
//TEXT=<b>休眠</b>
//MAJ=PALADIN|COST=11|ATK=0|HP=1|RACE=MURLOC
}
public class Story_11_Finley_3:MinionBase{
//NAME=芬利爵士
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>2回合。
//MAJ=PALADIN|COST=3|ATK=3|HP=5|RACE=MURLOC
}
public class Story_11_Finley_3Dormant:MinionBase{
//NAME=芬利爵士
//TEXT=<b>休眠</b>
//MAJ=PALADIN|COST=11|ATK=0|HP=1|RACE=MURLOC
}
public class Story_11_FinleyPrologue:MinionBase{
//NAME=芬利爵士
//TEXT=<i>这位可敬的鱼人会用丰富的才能和换牌的手段，在智力层面压制敌人。</i>
//MAJ=PALADIN|COST=1|ATK=1|HP=3|RACE=MURLOC
}
public class Story_11_FinleysCompass:SpellBase{
//NAME=芬利的罗盘
//TEXT=在你的回合结束时，每有一个友方随从，芬利随机对一个敌方随从造成1点伤害。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FinleysCompasse:Ability{
//NAME=芬利的罗盘
//TEXT=每有一个友方随从，随机对一个敌方随从造成1点伤害。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FinleysDad:MinionBase{
//NAME=芬利的父亲
//TEXT=<b>免疫</b>。如果芬利的母亲在场，获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=4|RACE=MURLOC
}
public class Story_11_FinleysDade:Ability{
//NAME=莫格顿一家
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FinleysMum:MinionBase{
//NAME=芬利的母亲
//TEXT=<b>免疫</b>。如果芬利的父亲在场，获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=4|RACE=MURLOC
}
public class Story_11_FinleysPithHelmet:SpellBase{
//NAME=芬利的冒险头盔
//TEXT=在你的回合开始时，使所有友方随从获得+2生命值。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FinleysPithHelmete:Ability{
//NAME=芬利的冒险头盔
//TEXT=在你的回合开始时，使所有友方随从获得+2生命值。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FireballPuzzle:SpellBase{
//NAME=火球术
//TEXT=造成$6点伤害。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class Story_11_FireElemental:MinionBase{
//NAME=火元素
//TEXT=每当你的对手使用卡牌时，对敌方英雄造成4点伤害。
//MAJ=SHAMAN|COST=6|ATK=6|HP=5|RACE=ELEMENTAL
}
public class Story_11_FirstMatePip:MinionBase{
//NAME=大副皮普
//TEXT=<b>突袭</b>。每当本随从攻击时，使你手牌中的所有随从牌获得+1/+1，并偷取对手手牌中的幸运币。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=8|RACE=NONE
}
public class Story_11_FirstMatePipe:Ability{
//NAME=皮普特惠
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FizzyElementalPuzzle:MinionBase{
//NAME=泡沫元素
//TEXT=<b>突袭</b> <b>嘲讽</b>
//MAJ=DRUID|COST=9|ATK=10|HP=10|RACE=ELEMENTAL
}
public class Story_11_FlamecannonPuzzle:SpellBase{
//NAME=烈焰轰击
//TEXT=随机对一个敌方随从造成 $4点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class Story_11_FlamestrikePuzzle:SpellBase{
//NAME=烈焰风暴
//TEXT=对所有敌方随从造成$5点伤害。
//MAJ=MAGE|COST=7|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,5);
    }
}
public class Story_11_FlamewreathedFaceless:MinionBase{
//NAME=投火无面者
//TEXT=<b>嘲讽</b>，<b>亡语：</b>使对手获得3个法力水晶。
//MAJ=SHAMAN|COST=4|ATK=7|HP=7|RACE=NONE
}
public class Story_11_FondMemory:SpellBase{
//NAME=深情回忆
//TEXT=<i>重演费林的特殊回忆。</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FragileCargo:MinionBase{
//NAME=易碎货物
//TEXT=费林或其盟友必须击败本随从，将它抢救回来。<b>亡语：</b>里面可能……有惊喜！
//MAJ=NEUTRAL|COST=2|ATK=0|HP=4|RACE=NONE
}
public class Story_11_FramebotPuzzle:MinionBase{
//NAME=可升级机器人
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=1|HP=5|RACE=MECHANICAL
}
public class Story_11_FreezingPotion:SpellBase{
//NAME=冰冻药水
//TEXT=<b>冻结</b>一个敌人。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=FROST
}
public class Story_11_FreezingPotione:Ability{
//NAME=吐出来
//TEXT=<b>亡语：</b>召唤本随从上次攻击的随从。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FreezingPotionMinion:MinionBase{
//NAME=冰冻药水
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class Story_11_FreshSeawaterB:SpellBase{
//NAME=召唤鲜活海水。
//TEXT=召唤鲜活海水。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_FrontLines:SpellBase{
//NAME=战争前线
//TEXT=从双方玩家的牌库中各召唤一个随从。重复，直到任意一方的随从数量达到上限。
//MAJ=PALADIN|COST=9|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Frostbolt:SpellBase{
//NAME=寒冰箭
//TEXT=对一个角色造成$3点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,target,"Frozen").Resolve();
    }
}
public class Story_11_Gaia:MinionBase{
//NAME=盖亚，巨力机甲
//TEXT=<b>巨型+2</b> 在一个友方机械攻击后，对所有敌人造成1点伤害。
//MAJ=MAGE|COST=8|ATK=5|HP=7|RACE=MECHANICAL
}
public class Story_11_Gaiat:MinionBase{
//NAME=盖亚的钻头
//TEXT=<b>突袭</b>
//MAJ=MAGE|COST=3|ATK=2|HP=3|RACE=MECHANICAL
}
public class Story_11_Gaiat2:MinionBase{
//NAME=盖亚的钻头
//TEXT=<b>突袭</b>
//MAJ=MAGE|COST=3|ATK=2|HP=3|RACE=MECHANICAL
}
public class Story_11_GiantShark:MinionBase{
//NAME=大鲨鱼
//TEXT=<b>嘲讽</b>。当一个随从被召唤时，攻击它。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=7|RACE=BEAST
}
public class Story_11_GiantTentacle:MinionBase{
//NAME=巨型触须
//TEXT=<b>亡语：</b><b>休眠</b>4回合。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=15|RACE=BEAST
}
public class Story_11_GiantTentacle_Dormant:MinionBase{
//NAME=巨型触须
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=BEAST
}
public class Story_11_GiantTentaclePuzzle:MinionBase{
//NAME=巨型触须
//TEXT=<b>嘲讽</b>，<b>亡语：</b>召唤一个惊喜！
//MAJ=NEUTRAL|COST=1|ATK=1|HP=15|RACE=BEAST
}
public class Story_11_GiantTentacleRight:MinionBase{
//NAME=巨型触须
//TEXT=<b>亡语：</b><b>休眠</b>4回合。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=15|RACE=BEAST
}
public class Story_11_GiantTentDormantRight:MinionBase{
//NAME=巨型触须
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=BEAST
}
public class Story_11_GoneFishinPuzzle:SpellBase{
//NAME=垂钓时光
//TEXT=<b>探底</b>。<b>连击：</b>抽一张牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Grace_005hp:HeroBase{
//NAME=格蕾丝·法希尔
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Grace_005p:HeroPowerBase{
//NAME=挥剑
//TEXT=对一个敌人造成2点伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Grace_1:MinionBase{
//NAME=格蕾丝·法希尔
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class Story_11_Grace_1Dormant:MinionBase{
//NAME=格蕾丝·法希尔
//TEXT=<b>休眠</b>
//MAJ=ROGUE|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_Grace_2:MinionBase{
//NAME=格蕾丝·法希尔
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=ROGUE|COST=3|ATK=4|HP=3|RACE=NONE
}
public class Story_11_Grace_2Dormant:MinionBase{
//NAME=格蕾丝·法希尔
//TEXT=<b>休眠</b>
//MAJ=ROGUE|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_Grace_3:MinionBase{
//NAME=格蕾丝·法希尔
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=ROGUE|COST=4|ATK=5|HP=7|RACE=NONE
}
public class Story_11_Grace_3Dormant:MinionBase{
//NAME=格蕾丝·法希尔
//TEXT=<b>休眠</b>
//MAJ=ROGUE|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_GracefulBlade:WeaponBase{
//NAME=优雅之刃
//TEXT=<b>战吼：</b>造成1点伤害。<b>连击：</b>获得<b>吸血</b>。
//MAJ=ROGUE|COST=3|ATK=2|HP=3|RACE=NONE
}
public class Story_11_GracefulBlade_005p:HeroPowerBase{
//NAME=优雅之刃
//TEXT=装备优雅之刃。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_GracefulBladee:Ability{
//NAME=越发优雅
//TEXT=拥有<b>吸血</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_GracefulSword:SpellBase{
//NAME=优雅之刃
//TEXT=使格蕾丝获得+1攻击力和<b>吸血</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_GracefulSword2:SpellBase{
//NAME=二级优雅之刃
//TEXT=使格蕾丝获得+2攻击力和<b>吸血</b>和无视<b>嘲讽</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_GracefulSword2e:Ability{
//NAME=二级优雅之剑
//TEXT=+2攻击力，<b>吸血</b>且无视<b>嘲讽</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_GracefulSworde:Ability{
//NAME=优雅之剑
//TEXT=+1攻击力和<b>吸血</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_GracePrologue:MinionBase{
//NAME=格蕾丝·法希尔
//TEXT=<i>她擅长在合适的时机造成合适的伤害，堪称强大的斗士。</i>
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class Story_11_Greasefire:MinionBase{
//NAME=猛火元素
//TEXT=<b>嘲讽</b>。每当本随从受到攻击时，为每个玩家抽一张牌，并使用法力值消耗较高的牌。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=8|RACE=ELEMENTAL
}
public class Story_11_Halus_010hp:HeroBase{
//NAME=哈鲁斯·观日者
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Halus_010p:HeroPowerBase{
//NAME=大胆冲锋
//TEXT=使一个友方随从获得<b>冲锋</b>。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Halus_1:MinionBase{
//NAME=哈鲁斯·观日者
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=WARRIOR|COST=2|ATK=3|HP=4|RACE=NONE
}
public class Story_11_Halus_1Dormant:MinionBase{
//NAME=哈鲁斯·观日者
//TEXT=<b>休眠</b>
//MAJ=WARRIOR|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_Halus_2:MinionBase{
//NAME=哈鲁斯·观日者
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=WARRIOR|COST=3|ATK=4|HP=5|RACE=NONE
}
public class Story_11_Halus_2Dormant:MinionBase{
//NAME=哈鲁斯·观日者
//TEXT=<b>休眠</b>
//MAJ=WARRIOR|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_Halus_3:MinionBase{
//NAME=哈鲁斯·观日者
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=WARRIOR|COST=4|ATK=5|HP=6|RACE=NONE
}
public class Story_11_Halus_3Dormant:MinionBase{
//NAME=哈鲁斯·观日者
//TEXT=<b>休眠</b>
//MAJ=WARRIOR|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_HalusPrologue:MinionBase{
//NAME=哈鲁斯·观日者
//TEXT=<i>他是个出色的护卫……冲向战场时除外！</i>
//MAJ=WARRIOR|COST=2|ATK=3|HP=4|RACE=NONE
}
public class Story_11_Hammer:WeaponBase{
//NAME=侏儒之锤
//TEXT=<i>用于敲击某个区域。</i>。<b>战吼：</b>你使用的下一张机械牌法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=2|RACE=NONE
}
public class Story_11_Hammer2:WeaponBase{
//NAME=水中之锤
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=1|ATK=3|HP=2|RACE=NONE
}
public class Story_11_Hammer3:WeaponBase{
//NAME=火焰之锤
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=1|ATK=3|HP=2|RACE=NONE
}
public class Story_11_Hammere:Ability{
//NAME=锤子
//TEXT=你的下一张机械牌的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Handmaiden_005p:HeroPowerBase{
//NAME=纳沙塔尔的险恶
//TEXT=对一个敌人造成1点伤害。在本局对战中，你每使用过一张纳迦牌，伤害都会提高。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Handmaiden_011hb:HeroBase{
//NAME=伊文兰尔女士
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Handmaiden_015hb:HeroBase{
//NAME=侍女扎恩拉
//TEXT=<i>扎恩拉年轻时便投身王庭，从未认可过你和达斯利的友谊。</i>
//MAJ=PRIEST|COST=0|ATK=0|HP=80|RACE=NONE
}
public class Story_11_Hedra:MinionBase{
//NAME=异端纳迦海德拉
//TEXT=每当一个法术被施放时，召唤一个法力值消耗等同于该法术的随从。
//MAJ=DRUID|COST=7|ATK=4|HP=5|RACE=NAGA
}
public class Story_11_HighSeasRevenge:SpellBase{
//NAME=公海复仇
//TEXT=使格蕾丝获得<b>亡语：</b>场上每有一个敌方随从，抽一张牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_HighSeasRevengee:Ability{
//NAME=公海复仇
//TEXT=<b>亡语：</b>场上每有一个敌方随从，抽一张牌。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Hooktusk_003hb:HeroBase{
//NAME=钩牙船长
//TEXT=<i>在海盗圈，输给她都算是种荣耀……但你不是海盗。</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_11_Hooktusk_003p:HeroPowerBase{
//NAME=勒索
//TEXT=使一个敌方随从<b>休眠</b>。你的对手必须付出一定代价才能将其唤醒。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Hooktusk_003pe:Ability{
//NAME=被扣押
//TEXT=<b>休眠</b>。花费0点法力值后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_HungryOrca:MinionBase{
//NAME=饥饿的虎鲸
//TEXT=每当本随从攻击时，双方玩家抽若干数量的牌，直到拥有四张手牌。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=NONE
}
public class Story_11_Hurricane_005hb:HeroBase{
//NAME=飓风元素
//TEXT=<i>元素在大海上肆虐，突然向你发难……</i>
//MAJ=SHAMAN|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_11_Hurricane_005p:HeroPowerBase{
//NAME=暴风
//TEXT=随机对一个敌人造成0点伤害。<i>（每次使用都会提升）</i>
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_IciclePuzzle:SpellBase{
//NAME=冰刺
//TEXT=对一个随从造成$2点伤害。如果它已被<b>冻结</b>，抽一张牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FROST
}
public class Story_11_IgnitionFire:MinionBase{
//NAME=点火火种
//TEXT=当被攻击时引燃武器。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=3|RACE=NONE
}
public class Story_11_IgnitionFireA:SpellBase{
//NAME=召唤一个点火火种。
//TEXT=召唤一个点火火种。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Ini_001p:HeroPowerBase{
//NAME=快速维修
//TEXT=<i>正在维修海兽号……</i>
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Ini_004hp:HeroBase{
//NAME=伊妮·积雷
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Ini_004p:HeroPowerBase{
//NAME=快速维修
//TEXT=<i>正在维修海兽号……</i>
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Ini_008hp:HeroBase{
//NAME=伊妮·积雷
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Ini_008p:HeroPowerBase{
//NAME=快速维修
//TEXT=<i>正在维修海兽号……</i>
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Ini_014hp:HeroBase{
//NAME=伊妮·积雷
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Ini_014p:HeroPowerBase{
//NAME=快速维修
//TEXT=<i>正在维修海兽号……</i>
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Ini_1:MinionBase{
//NAME=伊妮·积雷
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class Story_11_Ini_1Dormant:MinionBase{
//NAME=伊妮·积雷
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_Ini_2:MinionBase{
//NAME=伊妮·积雷
//TEXT=<b>战吼：</b><b>发现</b>一项能力。<b>亡语：</b><b>休眠</b>4回合。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class Story_11_Ini_2Dormant:MinionBase{
//NAME=伊妮·积雷
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=NONE
}
public class Story_11_InisToolkite:Ability{
//NAME=吐出来
//TEXT=<b>亡语：</b>召唤本随从上次攻击的随从。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_IniToolkit:MinionBase{
//NAME=伊妮工具包
//TEXT=<b>亡语：</b><b>发现</b>一张武器牌。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=MECHANICAL
}
public class Story_11_IniTracker:Ability{
//NAME=伊妮追踪器
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Jailor_013p:HeroPowerBase{
//NAME=束缚
//TEXT=<b>被动</b> 敌方卡牌法力值消耗增加（0）点。在其回合开始时改变。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Jailor_013pe:Ability{
//NAME=束缚
//TEXT=在本回合中不能使用卡牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Jal:MinionBase{
//NAME=神枪手贾尔
//TEXT=在你使用一张军情七处牌后，对敌方英雄造成等同于其法力值消耗的伤害。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=6|RACE=NONE
}
public class Story_11_LadyAshvane:MinionBase{
//NAME=艾什凡女勋爵
//TEXT=<b>嘲讽</b> 在你的回合结束时，随机对两个敌方随从造成$3点伤害。<b>亡语：</b>推进战斗。
//MAJ=NEUTRAL|COST=2|ATK=5|HP=10|RACE=NONE
}
public class Story_11_LadyStheno:MinionBase{
//NAME=赛丝诺女士
//TEXT=在你施放一个法术后，攻击生命值最低的友方角色。
//MAJ=DEMONHUNTER|COST=3|ATK=2|HP=4|RACE=NAGA
}
public class Story_11_LargeTentacle:MinionBase{
//NAME=大型触须
//TEXT=当恐怖触须死亡时失去1点攻击力。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=10|RACE=BEAST
}
public class Story_11_LargeTentacle_Dormant:MinionBase{
//NAME=大型触须
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=BEAST
}
public class Story_11_LargeTentacleDormantM:MinionBase{
//NAME=大型触须
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=BEAST
}
public class Story_11_LargeTentaclee:Ability{
//NAME=损伤
//TEXT=攻击力降低。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_LargeTentacleMid:MinionBase{
//NAME=大型触须
//TEXT=当恐怖触须死亡时失去1点攻击力。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=10|RACE=BEAST
}
public class Story_11_LargeTentaclePuzzle:MinionBase{
//NAME=大型触须
//TEXT=<b>嘲讽</b>，当恐怖触须死亡时失去1点攻击力。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=10|RACE=BEAST
}
public class Story_11_LargeTentacleRight:MinionBase{
//NAME=大型触须
//TEXT=当恐怖触须死亡时失去1点攻击力。<b>亡语：</b><b>休眠</b>3回合。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=10|RACE=BEAST
}
public class Story_11_LargeTentDormantRight:MinionBase{
//NAME=大型触须
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=BEAST
}
public class Story_11_LeadtheExpedition:SpellBase{
//NAME=带队前行
//TEXT=<i>释放护符的力量来对抗艾萨拉女王，安全撤离。</i>
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Leviathan_000hb:HeroBase{
//NAME=海兽号
//TEXT=<i>你雇佣了最好的潜艇，还有机师伊妮·积雷，出发前往辛艾萨莉的遗迹。</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Leviathan_001hb:HeroBase{
//NAME=海兽号
//TEXT=<i>乘员已经就绪！但这艘潜艇……？</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Leviathan_001p:HeroPowerBase{
//NAME=操控潜艇
//TEXT=<i>这艘潜艇堪称现代工程学的奇迹！最好不要按错按钮……</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Leviathan_004hb:HeroBase{
//NAME=海兽号
//TEXT=<i>潜艇的行进顺畅了许多，特别是在把水排到了舱</i>外<i>之后。</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Leviathan_008hb:HeroBase{
//NAME=海兽号
//TEXT=<i>与海怪的战斗带来了严重的伤害，以及偷渡者！</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Leviathan_014hb:HeroBase{
//NAME=海兽号
//TEXT=<i>这一次，你需要用到书中的内容了。</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=200|RACE=NONE
}
public class Story_11_LeviathanEngine:MinionBase{
//NAME=燃料箱
//TEXT=<b>未启动</b> <i>需要调整才能启动！</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=5|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine1_2:MinionBase{
//NAME=浸水的燃料箱
//TEXT=<b>已浸水，未启动</b> <i>修理通常从这里开始。</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=5|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine1_2b:MinionBase{
//NAME=受潮的燃料箱
//TEXT=<b>未启动</b> <i>需要调整加热才能使用！</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=5|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine1_2c:MinionBase{
//NAME=燃料箱
//TEXT=<b>已启动</b> <i>燃料流动正常，准备供能！</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=5|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine1_3:MinionBase{
//NAME=失火的燃料箱
//TEXT=<b>已失火，未启动</b> <i>需要冷却，别搞坏了！</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=5|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine1_3b:MinionBase{
//NAME=积灰的燃料箱
//TEXT=<b>未启动</b> <i>需要清洗调校才能恢复！</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=5|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine2:MinionBase{
//NAME=锅炉
//TEXT=<b>未启动</b> <i>需要撬开才能点火！</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=10|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine2_2:MinionBase{
//NAME=浸水的锅炉
//TEXT=<b>已浸水，未启动</b>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=10|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine2_2b:MinionBase{
//NAME=受潮的锅炉
//TEXT=<b>未启动</b> <i>需要用加热过的工具撬开。</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=10|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine2_2c:MinionBase{
//NAME=锅炉
//TEXT=<b>已启动</b> <i>可以给锅炉供燃料了！</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=10|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine2_3:MinionBase{
//NAME=失火的锅炉
//TEXT=<b>已失火，未启动</b> <i>熄灭火焰。不要伤到锅炉。</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=10|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine2_3b:MinionBase{
//NAME=积灰的锅炉
//TEXT=<b>未启动</b> <i>用工具打开锅炉，清空灰尘。</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=10|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine3:MinionBase{
//NAME=压力阀
//TEXT=<b>未启动</b> <i>控制流量以启动。</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=10|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine3_2:MinionBase{
//NAME=浸水的压力阀
//TEXT=<b>已浸水，未启动</b>
//MAJ=NEUTRAL|COST=7|ATK=1|HP=10|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine3_2b:MinionBase{
//NAME=受潮的压力阀
//TEXT=<b>未启动</b> <i>排干水之前无法安全使用。</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=10|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine3_2c:MinionBase{
//NAME=压力阀
//TEXT=<b>已启动</b> <i>可以正常操作了！</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=10|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine3_3:MinionBase{
//NAME=失火的压力阀
//TEXT=<b>已失火，未启动</b> <i>仔细扑灭火焰，使其恢复运转。</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=15|RACE=MECHANICAL
}
public class Story_11_LeviathanEngine3_3b:MinionBase{
//NAME=积灰的压力阀
//TEXT=<b>未启动</b> <i>需要用沾了水的工具敲打才能使用。</i>
//MAJ=NEUTRAL|COST=7|ATK=0|HP=10|RACE=MECHANICAL
}
public class Story_11_LeviathanMissiles:SpellBase{
//NAME=海兽导弹
//TEXT=当伊妮受到攻击时，随机对敌方随从造成1-3点伤害。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_LeviathanMissilese:Ability{
//NAME=海兽导弹
//TEXT=当伊妮受到攻击时，随机对敌方随从造成1-3点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_LeviathansClawPuzzle:MinionBase{
//NAME=海兽号的探爪
//TEXT=<b>突袭</b>。<b>圣盾</b>。在本随从攻击后，抽一张牌。
//MAJ=PALADIN|COST=3|ATK=4|HP=2|RACE=MECHANICAL
}
public class Story_11_LightningBloom:SpellBase{
//NAME=雷霆绽放
//TEXT=在本回合中，获得两个法力水晶。<b>过载：</b>（2）
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class Story_11_LightningStormPuzzle:SpellBase{
//NAME=闪电风暴
//TEXT=对所有敌方随从造成$3点伤害，<b>过载：</b>（2）
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,2);
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,3);
    }
}
public class Story_11_Looter_002hb:HeroBase{
//NAME=老响劫
//TEXT=<i>他对战利品特别敏感，但有时金子也能吸引他的注意。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=40|RACE=NONE
}
public class Story_11_Looter_002p:HeroPowerBase{
//NAME=偷来的幸运币
//TEXT=<b>被动</b> 使你的敌人猜测双方手牌的法力值消耗总和哪一方更大，猜中即可获取一张幸运币。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Looter_002pb:SpellBase{
//NAME=低！
//TEXT=猜测敌人手牌法力值消耗的总和比你的低。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Looter_002pt:SpellBase{
//NAME=高！
//TEXT=猜测敌人手牌法力值消耗的总和比你的高。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_MechafishPuzzle:MinionBase{
//NAME=机械鱼
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=MECHANICAL
}
public class Story_11_MechaShark:MinionBase{
//NAME=机械鲨鱼
//TEXT=在你召唤一个机械后，造成3点伤害，随机分配到所有敌人身上。
//MAJ=MAGE|COST=3|ATK=4|HP=3|RACE=MECHANICAL
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(tz==ZoneType.Board && (sc.raceType.Contains(RaceType.Pirate)) && owner.GetTag(GameTag.ZoneType) == (int)ZoneType.Board)
        {
            TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),3);
        }
    }
}
public class Story_11_MetaltoothLeapPuzzle:MinionBase{
//NAME=金刚刃牙兽
//TEXT=<b>战吼：</b>使你的其他机械获得+2攻击力。
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class Story_11_Mission10a_Lorebook1:MinionBase{
//NAME=上古敕令
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission10a_Lorebook2:MinionBase{
//NAME=纳迦的起源
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission10a_Lorebook2b:MinionBase{
//NAME=纳迦的起源
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission10a_Lorebook3:MinionBase{
//NAME=芬利的感谢信
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission10a_Lorebook4:MinionBase{
//NAME=汤姆留在瓶里的信
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission10b_Lorebook1:MinionBase{
//NAME=依苏蕾尔的雕像
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission10b_Lorebook2:MinionBase{
//NAME=辛艾萨莉水晶
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission11_Lorebook1:MinionBase{
//NAME=出使计划
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission11_Lorebook2:MinionBase{
//NAME=达斯利未寄出的信
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission12_Lorebook1:MinionBase{
//NAME=朋友的约定
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission12_Lorebook2:MinionBase{
//NAME=伊文兰尔家族史
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission13_Lorebook1:MinionBase{
//NAME=女王法令
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission13_Lorebook2:MinionBase{
//NAME=犯人的日志
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission15_Lorebook1:MinionBase{
//NAME=扎恩拉的命令
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission15_Lorebook2:MinionBase{
//NAME=深渊势力
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission16_Lorebook1:MinionBase{
//NAME=伊文兰尔护符
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission16_Lorebook2:MinionBase{
//NAME=永恒的女王
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission1_Lorebook1:MinionBase{
//NAME=海兽号操作手册
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission1_Lorebook2:MinionBase{
//NAME=积雷的日志节选
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission2_Lorebook1:MinionBase{
//NAME=远古卷轴
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission2_Lorebook2:MinionBase{
//NAME=大副的日志
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission3_Lorebook1:MinionBase{
//NAME=钩牙的日记
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission3_Lorebook2:MinionBase{
//NAME=桅台中的便笺
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission3_Lorebook3:MinionBase{
//NAME=格蕾丝的便笺
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission5a_Lorebook1:MinionBase{
//NAME=水手的歌谣
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission5a_Lorebook2:MinionBase{
//NAME=卡耶的日志
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission5a_Lorebook3:MinionBase{
//NAME=芬利的沉思录
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission5a_Lorebook4:MinionBase{
//NAME=哈鲁斯的日记
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission5b_Lorebook1:MinionBase{
//NAME=汤姆的命令
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission5b_Lorebook2:MinionBase{
//NAME=暮色号
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission6_Lorebook1:MinionBase{
//NAME=玛雅的日记
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission6_Lorebook2:MinionBase{
//NAME=伊妮的涂鸦
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission6_Lorebook3:MinionBase{
//NAME=格蕾丝的便笺，第二部分
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission7_Lorebook1:MinionBase{
//NAME=消化了一半的典籍
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission7_Lorebook2:MinionBase{
//NAME=上古海洋生物
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission7_Lorebook3:MinionBase{
//NAME=上古海洋生物
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission9a_Lorebook1:MinionBase{
//NAME=鱼人指南
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission9a_Lorebook2:MinionBase{
//NAME=入门菜谱，第6卷
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission9b_Lorebook1:MinionBase{
//NAME=莫格顿访谈录
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Mission9b_Lorebook2:MinionBase{
//NAME=罗盘上的便笺
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i> 持续一回合。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_MoltenGiantPuzzle:MinionBase{
//NAME=熔核巨人
//TEXT=你的英雄每受到1点伤害，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=20|ATK=8|HP=8|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand && owner.myPlayer.hero.Count>0)
            {
                return -owner.myPlayer.hero[0].GetTag(GameTag.Damage);
            }   
        }
        return 0;
    }
}
public class Story_11_MoonlitGuidance:SpellBase{
//NAME=月光指引
//TEXT=<b>发现</b>你牌库中一张牌的复制。如果你在本回合中使用这张复制，则抽取本体。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class Story_11_MortalCoil:SpellBase{
//NAME=死亡缠绕
//TEXT=对一个随从造成$1点伤害。如果“死亡缠绕”消灭该随从，抽一张牌。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
        if(target.GetTag(GameTag.ZoneType)==(int)ZoneType.Grave)
        {
            TaskDraw();
        }
    }
}
public class Story_11_Mothership:MinionBase{
//NAME=母舰
//TEXT=<b>突袭</b>，<b>亡语：</b>随机召唤两个法力值消耗小于或等于（3）点的机械。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=4|RACE=MECHANICAL
}
public class Story_11_Motivate3:SpellBase{
//NAME=三级鼓舞
//TEXT=使卡耶获得<b>亡语：</b>随机使你手牌中的一张随从牌获得+3/+3，抽一张牌。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Motivate3e:Ability{
//NAME=鼓舞之极
//TEXT=<b>亡语：</b>随机使你手牌中的一张随从牌获得+3/+3。抽一张牌。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Motivate3e2:Ability{
//NAME=鼓舞之极
//TEXT=+3/+3
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Murgill:MinionBase{
//NAME=老鱼鳃
//TEXT=<b>嘲讽</b>。在你使用一张鱼人牌后，对所有敌人造成2点伤害。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=MURLOC
}
public class Story_11_Murloc_009hb:HeroBase{
//NAME=摩戈洛
//TEXT=<i>它的攻击倾向令人担心……即便是从鱼人的标准来看。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_11_Murloc_009p:HeroPowerBase{
//NAME=鱼人狂欢
//TEXT=<b>被动</b> 在一个友方鱼人死亡后，使你的一个鱼人获得+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Murloc_009pe:Ability{
//NAME=狂欢！
//TEXT=+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_MurlocMenace:MinionBase{
//NAME=来犯的鱼人
//TEXT=<b>战吼：</b>在本局对战中你每使用过一张鱼人牌，对敌方随从造成1点伤害。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=2|RACE=MURLOC
}
public class Story_11_MurlocMenace2:MinionBase{
//NAME=来犯的鱼人
//TEXT=在每个回合结束时，对所有敌人造成1-4点伤害。<b>亡语：</b>你的对手获得一个空的法力水晶。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=MURLOC
}
public class Story_11_NagaGiant:MinionBase{
//NAME=纳迦巨人
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=20|ATK=8|HP=8|RACE=NAGA
}
public class Story_11_NagaGuard_010hb:HeroBase{
//NAME=纳迦卫兵
//TEXT=<i>即便这里有纳迦驻守，现在也没有退缩的余地了。</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_11_NagaSpear_010p:HeroPowerBase{
//NAME=上古三叉戟
//TEXT=装备一把上古三叉戟。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_NatureStudies:SpellBase{
//NAME=自然研习
//TEXT=<b>发现</b>一张法术牌。你的下一张法术牌法力值消耗减少（1）点。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class Story_11_Nemesis_005hb:HeroBase{
//NAME=私掠者汤姆
//TEXT=<i>如果格蕾丝需要和这艘船的船长对质，那我们现在就去！</i>
//MAJ=ROGUE|COST=0|ATK=0|HP=50|RACE=NONE
}
public class Story_11_NervousPassenger:MinionBase{
//NAME=紧张的乘客
//TEXT=费林或其盟友必须击败本随从，将它抢救回来。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=3|RACE=NONE
}
public class Story_11_NoSurprises:SpellBase{
//NAME=没有惊喜
//TEXT=在格蕾丝攻击后，检视你对手的3张手牌并选择一张，使其无法在下回合中使用。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_NoSurprisese:Ability{
//NAME=毫不意外
//TEXT=在攻击后检视你对手的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_NoSurprisese2:Ability{
//NAME=意料之中
//TEXT=下回合中无法使用。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Orgozoa:MinionBase{
//NAME=奥戈佐亚
//TEXT=在你的回合开始时，召唤一个1/1的纳迦小学生。<b>亡语：</b>消灭所有友方随从，推进战斗。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=7|RACE=NONE
}
public class Story_11_Overboard:SpellBase{
//NAME=落水追击
//TEXT=使你手牌，牌库和战场上的所有随从获得+2/+2。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Ozumat_007hb:HeroBase{
//NAME=厄祖玛特
//TEXT=<i>这只巨兽潜伏在波涛之下，等待着毫无防备的猎物……</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=100|RACE=NONE
}
public class Story_11_Ozumat_007p:HeroPowerBase{
//NAME=厄祖玛特的触须
//TEXT=<b>被动</b> 消灭厄祖玛特的触须以击败它。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_PanickedSailor:MinionBase{
//NAME=恐慌的水手
//TEXT=费林或其盟友必须击败本随从，将它抢救回来。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=5|RACE=NONE
}
public class Story_11_ParrrleyPuzzle:SpellBase{
//NAME=海盗谈判
//TEXT=交换此牌与你对手牌库中的一张牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Pashmar:MinionBase{
//NAME=帕什玛
//TEXT=在你的回合结束时，获得+1攻击力。必须和希里瓦兹同时被消灭。<b>亡语：</b>推进战斗。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=5|RACE=NAGA
}
public class Story_11_Pashmare:Ability{
//NAME=帕什玛之触
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Patrol_001hb:HeroBase{
//NAME=巡逻船长
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Patrol_001p:HeroPowerBase{
//NAME=鱼叉猛刺
//TEXT=对一个随从造成$2点伤害。如果该随从死亡，则将一张奥术射击置入你的手牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_PowerUp:SpellBase{
//NAME=力量强化
//TEXT=使芬利获得<b>圣盾</b>和<b>风怒</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_PowerUpe:Ability{
//NAME=力量强化
//TEXT=<b>圣盾</b>，<b>风怒</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_PriestessMemory:SpellBase{
//NAME=女祭司的回忆
//TEXT=将一张神圣法术牌置入你的手牌。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Prologue_Lorebook1:MinionBase{
//NAME=格蕾丝的信
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Prologue_Lorebook2:MinionBase{
//NAME=芬利的信
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Prologue_Lorebook3:MinionBase{
//NAME=哈鲁斯的信
//TEXT=<b>故事书</b> <i>点击这里来阅读。</i>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_PureofHeart:SpellBase{
//NAME=心灵纯净
//TEXT=在你的回合结束时，哈鲁斯会使你的英雄获得+2护甲值。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_PureofHearte:Ability{
//NAME=最纯洁的心
//TEXT=在你的回合结束时，使你的英雄获得+2护甲值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Puzzle14_1:SpellBase{
//NAME=戳破泡泡
//TEXT=开始修补谜题1-1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Puzzle14_2:SpellBase{
//NAME=凝视深渊
//TEXT=开始修补谜题1-2。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Puzzle14_3:SpellBase{
//NAME=巨大的问题
//TEXT=开始修补谜题1-3。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Puzzle1_1:SpellBase{
//NAME=发动引擎
//TEXT=使用正确的工具，启动海兽号。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Puzzle4_1:SpellBase{
//NAME=深水之下
//TEXT=开始清场谜题1-1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Puzzle4_2:SpellBase{
//NAME=巨鲨“坦克”
//TEXT=开始清场谜题1-2。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Puzzle4_3:SpellBase{
//NAME=承受压力
//TEXT=开始清场谜题1-3。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Puzzle8_1:SpellBase{
//NAME=火上加油
//TEXT=开始灭火谜题1-1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Puzzle8_2:SpellBase{
//NAME=炉火沸腾
//TEXT=开始灭火谜题1-2。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Puzzle8_3:SpellBase{
//NAME=热浪来袭
//TEXT=开始灭火谜题1-3。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_PyroblastPuzzle:SpellBase{
//NAME=炎爆术
//TEXT=造成$10点伤害。
//MAJ=MAGE|COST=10|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,10).Resolve();
    }
}
public class Story_11_QueensVengeance:SpellBase{
//NAME=女王的复仇
//TEXT=对一个随从造成$4点伤害。<b>发现</b>一张宝藏牌。
//MAJ=MAGE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class Story_11_QuickFix:SpellBase{
//NAME=快速维修
//TEXT=使伊妮获得<b>法术迸发</b>：随机将一把武器掷入你的手中。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_QuickFix2:SpellBase{
//NAME=二级快速维修
//TEXT=使伊妮获得<b>法术迸发</b>：随机将一把更好的武器掷入你的手中。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_QuickFix2e:Ability{
//NAME=快速维修
//TEXT=<b>法术迸发</b>：随机将一把更好的武器掷入你的手中。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_QuickFixe:Ability{
//NAME=快速维修
//TEXT=<b>法术迸发</b>：随机将一把武器掷入你的手中。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_RadarDetector:SpellBase{
//NAME=雷达探测
//TEXT=扫描你牌库底的5张牌。抽取探测到的机械牌，然后洗混你的牌库。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_RadianceofAzshara:MinionBase{
//NAME=艾萨拉之辉
//TEXT=<b>扰魔</b>。在你的回合结束时，对所有敌方随从造成1点伤害。<b>亡语：</b>推进战斗。
//MAJ=SHAMAN|COST=1|ATK=3|HP=10|RACE=ELEMENTAL
}
public class Story_11_RearrangeCargo:SpellBase{
//NAME=重新安排货物
//TEXT=在你对手场上的最左侧或最右侧召唤一个0/10的垃圾堆来占据该位置。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_RearrangeCargoa:SpellBase{
//NAME=最左边的位置
//TEXT=在你对手场上的左侧制造一个垃圾堆。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class Story_11_RearrangeCargob:SpellBase{
//NAME=最右边的位置
//TEXT=在你对手场上的右侧制造一个垃圾堆。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class Story_11_RemoteControlPuzzle:MinionBase{
//NAME=遥控傀儡
//TEXT=在本随从受到伤害后，将两张傀儡部件洗入你的牌库。当抽到傀儡部件时，召唤一个2/1的机械。
//MAJ=WARRIOR|COST=4|ATK=3|HP=6|RACE=MECHANICAL
}
public class Story_11_Renew:SpellBase{
//NAME=复苏
//TEXT=恢复#3点 生命值。<b>发现</b>一张法术牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class Story_11_RighteousDefender:SpellBase{
//NAME=正义防御者
//TEXT=每回合随机将一张战士法术牌置入你的牌库。这些牌只能在你的手牌中存在1回合。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_RighteousDefendere:Ability{
//NAME=正义防御者
//TEXT=每回合随机将一张战士法术牌置入你的牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_RocketBoots:SpellBase{
//NAME=火箭靴
//TEXT=使一个随从获得<b>突袭</b>。抽 一张牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_RubbishPile:MinionBase{
//NAME=垃圾堆
//TEXT=<i>只是用来占位的，真的。</i>
//MAJ=NEUTRAL|COST=2|ATK=0|HP=10|RACE=NONE
}
public class Story_11_Ruins_011hb:HeroBase{
//NAME=伊文兰尔家族的遗迹
//TEXT=<i>这么多年过去，往事终于消散。</i>
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Ruins_011p:HeroPowerBase{
//NAME=远古记忆
//TEXT=<i>这里承载着费林的深刻回忆。</i>
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_RunedOrb:SpellBase{
//NAME=符文宝珠
//TEXT=造成$2点伤害。<b>发现</b>一张法术牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class Story_11_SalvageBot:MinionBase{
//NAME=废品机器人
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
}
public class Story_11_ScaldingPuzzle:SpellBase{
//NAME=间歇热泉
//TEXT=造成$2点伤害。<b>探底</b>。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=FIRE
}
public class Story_11_Scrappy:SpellBase{
//NAME=废料回收
//TEXT=每回合随机将一张潜行者法术牌置入你的牌库。这些牌只能在你的手牌中存在1回合。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Scrappye:Ability{
//NAME=废料回收
//TEXT=每回合随机将一张潜行者法术牌置入你的牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SeafloorGatewayPuzzle:SpellBase{
//NAME=海床传送口
//TEXT=抽一张机械牌。使你手牌中所有机械牌的法力值消耗减少（1）点。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDrawRace(RaceType.Mechanical);
        List<Card> ToBuff = new List<Card>();
        foreach(Card c in owner.myPlayer.hand)
        {
            if(c.raceType.Contains(RaceType.Mechanical))
            {
                ToBuff.Add(c);
            }
        }
        TaskBuffTargets(ToBuff,mana:-1);
    }
}
public class Story_11_SeafloorSaviorPuzzle:MinionBase{
//NAME=海床救生员
//TEXT=<b>战吼：</b><b>探底</b>。如果选中的是随从牌，使其获得本随从的攻击力和生命值。
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=MECHANICAL
}
public class Story_11_SeaReaver:MinionBase{
//NAME=破海者
//TEXT=当你抽到该牌时，对你的随从造成 1点伤害。
//MAJ=WARRIOR|COST=6|ATK=6|HP=7|RACE=NONE
}
public class Story_11_SeascoutPuzzle:MinionBase{
//NAME=海底侦察兵
//TEXT=<b>战吼：</b>如果你控制任何机械，则召唤两条2/1的机械鱼。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class Story_11_SeaSummoning:SpellBase{
//NAME=海洋召唤
//TEXT=你的手牌中每有一张法术牌，召唤一条2/2的闪光狮子鱼。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SeaSummoningt:MinionBase{
//NAME=闪光狮子鱼
//TEXT=
//MAJ=DRUID|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class Story_11_Seawater:MinionBase{
//NAME=鲜活海水
//TEXT=当被攻击时沾湿武器。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=3|RACE=NONE
}
public class Story_11_SecretsoftheSands:SpellBase{
//NAME=沙中的秘密
//TEXT=使芬利获得<b>战吼：</b>获得一个升级过的英雄技能。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SecretsoftheSandse:Ability{
//NAME=沙中秘密
//TEXT=升级过的英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SecurityAutoPuzzle:MinionBase{
//NAME=安保自动机
//TEXT=在你召唤一个机械后，获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=MECHANICAL
}
public class Story_11_SecurityQuestion:SpellBase{
//NAME=伊妮的安全问题
//TEXT=选择正确的密码，解锁积雷过载装置。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SecurityQuestiona:SpellBase{
//NAME=选项1
//TEXT=050404
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SecurityQuestionb:SpellBase{
//NAME=选项2
//TEXT=01101110 01101111
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SecurityQuestionc:SpellBase{
//NAME=选项3
//TEXT=0123456
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SelfishShellfishPuzzl:MinionBase{
//NAME=自私的扇贝
//TEXT=<b>亡语：</b>你的对手抽两张牌。生成一个惊喜。
//MAJ=NEUTRAL|COST=4|ATK=7|HP=7|RACE=BEAST
    public override void Deathrattle()
    {
        new EffectDraw(owner.myPlayer.otherPlayer).Resolve();
        new EffectDraw(owner.myPlayer.otherPlayer).Resolve();
    }
}
public class Story_11_SerpentWig:SpellBase{
//NAME=毒蛇假发
//TEXT=使一个随从获得+1/+2。如果你在此牌在你手中时使用过纳迦牌，将一张毒蛇假发置入你的手牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ShadyParrot:MinionBase{
//NAME=卑劣的鹦鹉
//TEXT=每当一个友方海盗攻击时，使所有友方随从获得+2/+1。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=6|RACE=BEAST
}
public class Story_11_ShadyParrot2:MinionBase{
//NAME=卑劣的鹦鹉
//TEXT=每当一个友方<b>传说</b>随从攻击时，使所有友方随从获得+2/+1。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=6|RACE=BEAST
}
public class Story_11_ShadyParrote:Ability{
//NAME=鹦鹉之力
//TEXT=+2/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ShipShape:SpellBase{
//NAME=航行顺利
//TEXT=使卡耶获得能力，使相邻的随从获得+1/+1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ShipShapee:Ability{
//NAME=航行顺利
//TEXT=相邻的随从拥有+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ShipShapee2:Ability{
//NAME=一切顺利
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Silivaz:MinionBase{
//NAME=希里瓦兹
//TEXT=在你的回合结束时，获得+1攻击力。必须和帕什玛同时被消灭。<b>亡语：</b>推进战斗。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=7|RACE=NAGA
}
public class Story_11_Sivara:MinionBase{
//NAME=指挥官西瓦拉
//TEXT=<b>嘲讽</b>。在你的回合结束时，随机<b>冻结</b>一个敌方随从。<b>亡语：</b>推进战斗。
//MAJ=MAGE|COST=4|ATK=3|HP=5|RACE=NAGA
}
public class Story_11_SouthseaPuzzle:MinionBase{
//NAME=南海恶徒
//TEXT=<b>战吼：</b>从你对手的牌库中<b>发现</b>一张牌。你的对手也会抽到<b>发现</b>的牌。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=5|RACE=PIRATE
}
public class Story_11_SpammyArcanistPuzzle:MinionBase{
//NAME=话痨奥术师
//TEXT=<b>战吼：</b>对所有其他随从造成1点伤害。如果有随从死亡，则重复此效果。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=4|RACE=NONE
}
public class Story_11_SparkDrill:MinionBase{
//NAME=火花钻机
//TEXT=<b>突袭，亡语：</b>将两张1/1并具有<b>突袭</b>的“火花”置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=1|RACE=MECHANICAL
}
public class Story_11_SpiritedSeahorse:MinionBase{
//NAME=亢奋的海马
//TEXT=<b>突袭</b> 每当本随从攻击时，使你的英雄在本回合中获得+3攻击力。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=BEAST
}
public class Story_11_SpiritedSeahorsee:Ability{
//NAME=亢奋
//TEXT=在本回合中+3攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SplosiveSolutions:SpellBase{
//NAME=爆破方案
//TEXT=使伊妮获得能力，使其有50%的几率在对手施放法术时将一枚炸弹掷入对手的牌库。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SplosiveSolutionse:Ability{
//NAME=爆破方案
//TEXT=有50%的几率在对手施放法术时将一枚炸弹掷入对手的牌库。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SpreadingMadness:SpellBase{
//NAME=狂乱传染
//TEXT=造成$9点伤害，随机分配到所有角色身上。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class Story_11_Statue_010p:HeroPowerBase{
//NAME=辛艾萨莉水晶
//TEXT=<b>被动</b> 友方随从攻击时会随机为友方角色恢复生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_StormTyrant:MinionBase{
//NAME=残暴风暴
//TEXT=<b>突袭</b>，<b>圣盾</b>，<b>风怒</b>。
//MAJ=NEUTRAL|COST=7|ATK=3|HP=5|RACE=ELEMENTAL
}
public class Story_11_StormTyrant2:MinionBase{
//NAME=残暴风暴
//TEXT=<b>圣盾</b>。在每个回合结束时，对所有其他随从造成2点伤害。
//MAJ=NEUTRAL|COST=7|ATK=3|HP=5|RACE=ELEMENTAL
}
public class Story_11_Sundering_011hb:HeroBase{
//NAME=大分裂
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_Sundering_011p:HeroPowerBase{
//NAME=成灾洪水
//TEXT=对所有敌方随从造成1点伤害。每有一个随从死亡，获得1点伤害。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SunkenBanshee:MinionBase{
//NAME=沉没的女妖
//TEXT=在你的回合结束时，召唤两个3/4的沉没的灵魂并使其攻击随机敌人。
//MAJ=NEUTRAL|COST=8|ATK=5|HP=7|RACE=NONE
}
public class Story_11_SunkenHopes:SpellBase{
//NAME=沉没的希望
//TEXT=使达斯利获得<b>法术迸发</b>：为你的对手<b>探底</b>。如果选中的是法术牌，则将其法力值消耗增加到10点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SunkenHopese:Ability{
//NAME=沉没的希望
//TEXT=<b>法术迸发</b>：为你的对手<b>探底</b>。如果选中的是法术牌，则将其法力值消耗增加到10点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SunkenHopesee:Ability{
//NAME=沉没
//TEXT=法力值消耗为（6）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SunkenSentinel:MinionBase{
//NAME=沉没的哨兵
//TEXT=<b>圣盾</b>，<b>嘲讽</b>，<b>吸血</b>
//MAJ=NEUTRAL|COST=5|ATK=5|HP=6|RACE=NONE
}
public class Story_11_SunkenSpirit:MinionBase{
//NAME=沉没的灵魂
//TEXT=<b>法术伤害+1</b>，<b>亡语：</b>将一张女祭司的回忆置于你的牌库底。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class Story_11_SunkenSweeper:MinionBase{
//NAME=沉没的清道夫
//TEXT=<b>战吼：</b>随机将3张机械牌置入你的手牌。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=MECHANICAL
}
public class Story_11_SunkenSword:WeaponBase{
//NAME=沉没的剑
//TEXT=<b>战吼：</b>将一张沉没的剑置入你的牌库底。<b>亡语：</b><b>探底</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class Story_11_SuperiorEfficiency:SpellBase{
//NAME=超强效率
//TEXT=卡耶使你的英雄技能法力值消耗减少（1）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SuperiorEfficiency2e:Ability{
//NAME=效率
//TEXT=你的英雄技能的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SuperiorEfficiencye:Ability{
//NAME=效率
//TEXT=使你的英雄技能的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SupplyChain:SpellBase{
//NAME=补给链
//TEXT=抽两张牌，获得2点护甲值，为你的英雄恢复2点生命值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SupportBot:SpellBase{
//NAME=机器支援
//TEXT=使伊妮获得<b>暴怒：</b>将一张泡泡机器人置入你的手牌，其法力值消耗为（0）点。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SupportBote:Ability{
//NAME=机器支援
//TEXT=<b>暴怒：</b>将一张泡泡机器人置入你的手牌，其法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SupportCrewe:Ability{
//NAME=支援
//TEXT=法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Swap:SpellBase{
//NAME=调换
//TEXT=使芬利获得<b>法术迸发</b>：将一张调换法术牌置入你的手牌。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Swap2:SpellBase{
//NAME=二级调换
//TEXT=使芬利获得<b>法术迸发</b>：将一张二级调换法术牌置入你的手牌。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Swap2e:Ability{
//NAME=正在调换
//TEXT=<b>法术迸发</b>：将一张调换法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Swap3:SpellBase{
//NAME=三级调换
//TEXT=使芬利获得<b>法术迸发</b>：将一张三级调换法术牌置入你的手牌。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Swap3e:Ability{
//NAME=正在调换
//TEXT=<b>法术迸发</b>：将一张调换法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Swape:Ability{
//NAME=正在调换
//TEXT=<b>法术迸发</b>：将一张调换法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SwapPlayer:SpellBase{
//NAME=调换
//TEXT=将你的手牌和牌库底的牌交换。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SwapPlayer2:SpellBase{
//NAME=二级调换
//TEXT=将你的手牌和牌库底的牌交换。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class Story_11_SwapPlayer3:SpellBase{
//NAME=三级调换
//TEXT=将你的手牌和牌库底的牌交换。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Swash:SpellBase{
//NAME=挥剑
//TEXT=在每个回合结束时，对格蕾丝对面的敌人造成2点伤害。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Swash2:SpellBase{
//NAME=二级挥剑
//TEXT=在每个回合结束时，对格蕾丝对面的敌人造成3点伤害。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Swash2e:Ability{
//NAME=唰！
//TEXT=对格蕾丝对面的敌人造成3点伤害。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Swashe:Ability{
//NAME=唰！
//TEXT=对格蕾丝对面的敌人造成2点伤害。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Tenacity:SpellBase{
//NAME=坚韧
//TEXT=在你的回合结束时，哈鲁斯会使你生命值最高的随从获得<b>嘲讽</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Tenacitye:Ability{
//NAME=坚韧
//TEXT=在你的回合结束时，使你生命值最高的随从获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_TerrifyingTen_Dormant:MinionBase{
//NAME=恐怖触须
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=BEAST
}
public class Story_11_TerrifyingTenDormantR:MinionBase{
//NAME=恐怖触须
//TEXT=<b>休眠</b>
//MAJ=NEUTRAL|COST=11|ATK=0|HP=1|RACE=BEAST
}
public class Story_11_TerrifyingTentacle:MinionBase{
//NAME=恐怖触须
//TEXT=<b>亡语：</b><b>休眠</b>5回合。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=20|RACE=BEAST
}
public class Story_11_TerrifyingTentacleR:MinionBase{
//NAME=恐怖触须
//TEXT=<b>亡语：</b><b>休眠</b>5回合。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=20|RACE=BEAST
}
public class Story_11_Tooltime:SpellBase{
//NAME=专业调校
//TEXT=为你的对手召唤一个点火火种或一个鲜活海水。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Training:SpellBase{
//NAME=训练
//TEXT=当哈鲁斯攻击时，相邻的随从也会攻击目标。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Traininge:Ability{
//NAME=练起来
//TEXT=在哈鲁斯攻击后，相邻的随从也会攻击。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_TrashedDreams:SpellBase{
//NAME=破败的梦想
//TEXT=使费林获得<b>亡语：</b>召唤一个0/10的垃圾堆。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_TrashedDreamse:Ability{
//NAME=破败的梦想
//TEXT=<b>亡语：</b>召唤一个0/10的垃圾堆。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_TrenchSurveyorPuzzle:MinionBase{
//NAME=海沟勘测机
//TEXT=<b>战吼：</b><b>探底</b>。如果选中的是机械牌，抽取这张牌。
//MAJ=MAGE|COST=2|ATK=3|HP=2|RACE=MECHANICAL
    public override void Battlecry(Card target=null)
    {
        TaskDrawRace(RaceType.Mechanical);
    }
}
public class Story_11_TrueHeroism:SpellBase{
//NAME=真正的英雄
//TEXT=使哈鲁斯获得<b>亡语：</b>随机为友方角色恢复15点生命值。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_TrueHeroism2e:Ability{
//NAME=升华的英雄
//TEXT=<b>亡语：</b>随机为友方角色恢复18点生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_TrueHeroisme:Ability{
//NAME=真正的英雄
//TEXT=<b>亡语：</b>随机为友方角色恢复15点生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_TuskarrPuzzle:MinionBase{
//NAME=拖网海象人
//TEXT=<b>战吼：</b><b>探底</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=PIRATE
}
public class Story_11_UnknownEnemy_012hb:HeroBase{
//NAME=神秘访客
//TEXT=<i>谁会在这样的时刻突然前来？</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class Story_11_UnstableShadowBlast:SpellBase{
//NAME=不稳定的暗影震爆
//TEXT=对一个随从造成$6点伤害，超过目标生命值的伤害会命中你的英雄。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class Story_11_UpliftingPresence:SpellBase{
//NAME=提振士气
//TEXT=卡耶可以提升你选中的船员的能力。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_UpliftingPresencee:Ability{
//NAME=振奋
//TEXT=提升你的船员能力的效果。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Valiance:SpellBase{
//NAME=英勇
//TEXT=使芬利获得<b>暴怒：</b>随机召唤一个鱼人。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Valiancee:Ability{
//NAME=英勇
//TEXT=<b>暴怒：</b>随机召唤一个鱼人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_VespersCannon:SpellBase{
//NAME=暮色号的火炮
//TEXT=在你的回合开始时，格蕾丝召唤一门2/2的暮色号的火炮。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_VespersCannone:Ability{
//NAME=暮色号的火炮
//TEXT=<b>被动</b> 在你的回合开始时，召唤一门2/2的暮色号的火炮。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_VespersCannonMinion:MinionBase{
//NAME=暮色号的火炮
//TEXT=<b>自动攻击：</b> 对本随从对面的敌人造成1点伤害。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=MECHANICAL
}
public class Story_11_Vortex:SpellBase{
//NAME=漩涡
//TEXT=随机对一个敌方随从造成$3点伤害。如果该随从死亡，再次施放本法术。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class Story_11_WardenoftheTides:MinionBase{
//NAME=潮汐守望者
//TEXT=<b>嘲讽</b>，<b>圣盾</b>。如果场上有友方元素随从，获得+5生命值。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NAGA
}
public class Story_11_WardenoftheTidese:Ability{
//NAME=涨潮
//TEXT=+5生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_WaterElemental:MinionBase{
//NAME=水元素
//TEXT=<b>嘲讽</b> <b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=4|ATK=3|HP=6|RACE=ELEMENTAL
}
public class Story_11_Waterlogged:SpellBase{
//NAME=浸水
//TEXT=<i>排出海兽号一个浸水部位的水。</i>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class Story_11_WaterTap:SpellBase{
//NAME=水闸
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class Story_11_WaterTape:Ability{
//NAME=水闸
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_WaterTapee:Ability{
//NAME=水闸
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_Wrench:WeaponBase{
//NAME=二手的扳手
//TEXT=<i>用于调校大型构件。</i>
//MAJ=NEUTRAL|COST=1|ATK=3|HP=2|RACE=NONE
}
public class Story_11_Wrench2:WeaponBase{
//NAME=灌水的扳手
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=1|ATK=4|HP=2|RACE=NONE
}
public class Story_11_Wrench3:WeaponBase{
//NAME=着火的扳手
//TEXT=<b>风怒</b> <i>特别适合受潮的设备！</i>
//MAJ=NEUTRAL|COST=1|ATK=4|HP=2|RACE=NONE
}
public class Story_11_Zainra2:MinionBase{
//NAME=扎恩拉·伊文兰尔
//TEXT=<i>艾萨拉女王的侍女。</i>
//MAJ=MAGE|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_ZainraMinion:MinionBase{
//NAME=年轻的扎恩拉
//TEXT=<i>艾萨拉女王的侍女。</i>
//MAJ=MAGE|COST=2|ATK=2|HP=1|RACE=NONE
}
public class Story_11_Zaqul:MinionBase{
//NAME=扎库尔
//TEXT=在你的回合结束时，有50%的几率使你的对手获得一张深渊诅咒。<b>亡语：</b>推进战斗。
//MAJ=NEUTRAL|COST=1|ATK=6|HP=10|RACE=NAGA
}
public class Story_11_Zaqule:Ability{
//NAME=扎库尔
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ZinAzshariCrystal:SpellBase{
//NAME=辛艾萨莉水晶
//TEXT=当本随从攻击时，随机为友方角色恢复等量的生命值。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class Story_11_ZinAzshariCrystale:Ability{
//NAME=辛艾萨莉水晶
//TEXT=当本随从攻击时，随机为友方角色恢复等量的生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
