using System.Collections;
using System.Collections.Generic;

public class THD_001:HeroBase{
//NAME=巫妖王
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_001hp:HeroPowerBase{
//NAME=无情的食尸鬼
//TEXT=召唤一个1/1并具有<b>复生</b>和<b>冲锋</b>的僵尸。它会在回合结束时死亡。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_001p:SpellBase{
//NAME=尸体收藏家
//TEXT=在你消耗<b>尸体</b>后，召唤一个属性值等同于所消耗<b>尸体</b>的复活的骷髅。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_001pt:MinionBase{
//NAME=复活的骷髅
//TEXT=<i>不会留下<b>尸体</b>。</i>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class THD_002:HeroBase{
//NAME=无头骑士
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_002hp:HeroPowerBase{
//NAME=捣蛋南瓜
//TEXT=使你的随从获得“<b>亡语：</b>召唤一个2/1并具有<b>突袭</b>的南瓜宝宝。”
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_002hpe:Ability{
//NAME=不给糖就捣蛋
//TEXT=<b>亡语：</b>召唤一个2/1并具有<b>突袭</b>的南瓜宝宝。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_002hpt:MinionBase{
//NAME=南瓜宝宝
//TEXT=<b>突袭</b>
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=1|RACE=NONE
}
public class THD_002p:SpellBase{
//NAME=邪恶糖果
//TEXT=<b>被动</b> 每回合中你的第一张随从牌拥有<b>回响</b>。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_002pe:Ability{
//NAME=邪恶糖果
//TEXT=每回合中你的第一张随从牌拥有<b>回响</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_002pe2:Ability{
//NAME=邪恶糖果
//TEXT=拥有<b>回响</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_003:HeroBase{
//NAME=矿坑老板雷斯卡
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_003hp:HeroPowerBase{
//NAME=无情的食尸鬼
//TEXT=召唤一个1/1并具有<b>冲锋</b>和<b>复生</b>的食尸鬼。它会在回合结束时死亡。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_003hpt:MinionBase{
//NAME=无情的食尸鬼
//TEXT=<b>冲锋</b>，<b>复生</b>。在你的回合结束时死亡。
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class THD_003p:SpellBase{
//NAME=无尽挖掘
//TEXT=<b>被动</b> 在5个友方亡灵死亡后，<b>发掘</b>。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_003pe:Ability{
//NAME=无尽挖掘玩家附加效果
//TEXT=<b>被动</b> 每回合中，在第一个友方恶魔死亡后，从你的牌库中抽一张随从牌并使其获得+1攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_004:HeroBase{
//NAME=伊利丹·怒风
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_004hp:HeroPowerBase{
//NAME=恶魔之恨
//TEXT=在本回合中+1攻击力和<b>吸血</b>。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_004hpe:Ability{
//NAME=恶魔之恨
//TEXT=在本回合中+1攻击力和<b>吸血</b>。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_004p:SpellBase{
//NAME=内心邪能
//TEXT=在一个友方角色攻击后，使你手牌中的一张邪能法术牌的法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_004pe3:Ability{
//NAME=内心邪能
//TEXT=法力值消耗减少。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_005:HeroBase{
//NAME=枪手库尔特鲁斯
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_005hp:HeroPowerBase{
//NAME=飞旋利爪
//TEXT=在本回合中+2攻击力。将你的手牌洗入牌库，然后抽取相同数量的牌。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_005p:SpellBase{
//NAME=翠绿护目镜
//TEXT=<b>被动</b> 使你最左边的手牌法力值消耗减少（1）点，但不能少于（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_005pe:Ability{
//NAME=翠绿护目镜玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_005pe2:Ability{
//NAME=翠绿护目镜
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_006:HeroBase{
//NAME=哈维利亚·墨鸦
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_006hp:HeroPowerBase{
//NAME=返场
//TEXT=随机获取一张<b>流放</b>牌。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_006p:SpellBase{
//NAME=翠绿之歌
//TEXT=你手牌中最左边和最右边的牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_006pe3:Ability{
//NAME=翠绿之歌
//TEXT=法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_007:HeroBase{
//NAME=林地守护者欧穆
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_007hp:HeroPowerBase{
//NAME=林地召唤
//TEXT=获取一张2/2的树人。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_007p:SpellBase{
//NAME=快速成长
//TEXT=在你召唤一个树人后，使其随机<b>进化</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_008:HeroBase{
//NAME=洞穴专家古夫
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_008hp:HeroPowerBase{
//NAME=自然恩赐
//TEXT=<b>抉择：</b>获得在本回合中的<b>+2法术伤害</b>；或者获得$d3点护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_008hps1:SpellBase{
//NAME=星光
//TEXT=在本回合中获得<b>法术伤害+2</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_008p:SpellBase{
//NAME=守护者的洞察
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_008pe:Ability{
//NAME=守护者的洞察玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_009:HeroBase{
//NAME=古夫·符文图腾
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_009hp:HeroPowerBase{
//NAME=野性狂暴
//TEXT=在本回合中+1攻击力。每回合可使用三次。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_009hpe:Ability{
//NAME=野性之力
//TEXT=在本回合中+1攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_009p:SpellBase{
//NAME=毒牙之力
//TEXT=在你的英雄获得攻击力后，还会获得等量的护甲值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_010:HeroBase{
//NAME=祖尔金
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_010hp:HeroPowerBase{
//NAME=诱捕
//TEXT=<b>发现</b>一张<b>奥秘</b>牌，其法力值消耗减少（1）点。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_010hpe:Ability{
//NAME=诱捕
//TEXT=法力值消耗减少（1）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_010p:SpellBase{
//NAME=阿曼尼战士
//TEXT=在你使用一张<b>奥秘</b>牌后，召唤一个2/2的狂战士。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_010pt:MinionBase{
//NAME=狂战士
//TEXT=
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=NONE
}
public class THD_011:HeroBase{
//NAME=希尔瓦娜斯·风行者
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_011hp:HeroPowerBase{
//NAME=重拾灵魂
//TEXT=使你在上一场战斗中死亡的随从获得+2/+1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_011p:SpellBase{
//NAME=易碎之骨
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_011pe:Ability{
//NAME=易碎之骨玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_012:HeroBase{
//NAME=暴龙王克鲁什
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=35|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class THD_012hp:HeroPowerBase{
//NAME=顶级捕食者
//TEXT=在本回合中 +8攻击力。
//MAJ=HUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class THD_012hpe:Ability{
//NAME=顶级捕食者
//TEXT=在本回合中 +8攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_012p:SpellBase{
//NAME=王者法则
//TEXT=在你施放一个法术后，使你手牌中的一张野兽牌减少与该法术相同的法力值消耗。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_012pe2:Ability{
//NAME=王者法则
//TEXT=法力值消耗减少。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_013:HeroBase{
//NAME=探险者晨拥
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_013hp:HeroPowerBase{
//NAME=冰霜灼烧
//TEXT=<b>冻结</b>一个角色。如果该角色已被<b>冻结</b>，则对其造成$2点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_013p:SpellBase{
//NAME=冰霜凝结
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_013pe:Ability{
//NAME=冰霜凝结玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_014:HeroBase{
//NAME=卡德加
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_014hp:HeroPowerBase{
//NAME=召唤元素
//TEXT=召唤一个2/3的元素。它会复制你的 法术。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class THD_014p:SpellBase{
//NAME=奥金晶体
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_014pe:Ability{
//NAME=奥金晶体玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_015:HeroBase{
//NAME=凯尔萨斯·逐日者
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_015hp:HeroPowerBase{
//NAME=引火
//TEXT=烧掉你牌库中的一张牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_015p:SpellBase{
//NAME=热能对流
//TEXT=<b>被动</b> 在你摧毁你牌库里的一张牌后，随机使你手牌中的一张火焰法术牌获得法术伤害+2。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_015pe:Ability{
//NAME=热能对流附加效果
//TEXT=<b>被动</b> 在你摧毁你牌库里的一张牌后，随机使你手牌中的一张火焰法术牌获得法术伤害+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_015pe2:Ability{
//NAME=热能对流附加效果
//TEXT=<b>法术伤害+2</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_016:HeroBase{
//NAME=克尔苏加德
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_016hp:HeroPowerBase{
//NAME=自掘坟墓
//TEXT=触发所有随从的 <b>亡语</b>两次。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class THD_016p:SpellBase{
//NAME=邪恶赠礼
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_016pe:Ability{
//NAME=邪恶赠礼玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_017:HeroBase{
//NAME=艾萨拉女王
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_017hp:HeroPowerBase{
//NAME=统领魔法
//TEXT=删除此条
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_017hp2:HeroPowerBase{
//NAME=统领纳迦
//TEXT=获取一张法力值消耗小于或等于（3）点的纳迦牌。<i>变换之潮会切换本技能。</i>
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_017hp3:HeroPowerBase{
//NAME=统领魔法
//TEXT=获取一张法力值消耗小于或等于（3）点的法师法术牌。<i>变换之潮会切换本技能。</i>
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_017p:SpellBase{
//NAME=变换之潮
//TEXT=在你使用一张纳迦牌后，复原一个法力水晶并切换至法术牌。<i>同时切换你的英雄技能。</i>1在你使用一张法术牌后，复原一个法力水晶并切换至纳迦牌。<i>同时切换你的英雄技能。</i>
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_018:HeroBase{
//NAME=V-07-TR-0N
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_018hp:HeroPowerBase{
//NAME=强化
//TEXT=使你的英雄获得在本回合中的+1攻击力，以及<b>圣盾</b>。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_018p:SpellBase{
//NAME=冲击偏转
//TEXT=<b>被动</b> 在一个友方角色失去<b>圣盾</b>后，使你手牌中的一张随从牌获得+1/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_018pe:Ability{
//NAME=冲击偏转附加效果
//TEXT=<b>被动</b> 在一个友方角色失去<b>圣盾</b>后，使你手牌中的一张随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_019:HeroBase{
//NAME=火车王里诺艾
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_019hp:HeroPowerBase{
//NAME=莽撞援军
//TEXT=在本回合中，你使用的下一张随从牌不再消耗法力值，转而消耗生命值。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_019hpe:Ability{
//NAME=我是！火车王！
//TEXT=在本回合中，你使用的下一张随从牌不再消耗法力值，转而消耗生命值。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_019p:SpellBase{
//NAME=我们上吧！
//TEXT=双方玩家卡牌的法力值消耗减少（1）点。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_020:HeroBase{
//NAME=诺兹多姆
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_020hp:HeroPowerBase{
//NAME=巨龙军团
//TEXT=抽一张龙牌，其法力值消耗减少（1）点。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_020hpe:Ability{
//NAME=巨龙军团
//TEXT=法力值消耗减少（1）点。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_020p:SpellBase{
//NAME=时间刚好
//TEXT=对战开始时拥有一个额外的法力水晶。你只有30秒的时间来进行你的回合。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_020pe:Ability{
//NAME=时间刚好附加效果
//TEXT=你只有30秒的时间来进行你的回合。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_021:HeroBase{
//NAME=裂心者伊露希亚
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=40|RACE=NONE
}
public class THD_021hp:HeroPowerBase{
//NAME=放空心智
//TEXT=获取你对手牌库中一张牌的复制。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_021p:SpellBase{
//NAME=苦痛思绪
//TEXT=<b>被动</b> 每回合你使用的第一张你套牌之外的牌会消耗生命值，而非法力值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_021pe:Ability{
//NAME=苦痛思绪玩家附加效果
//TEXT=<b>被动</b> 每回合你使用的第一张你套牌之外的牌会消耗生命值，而非法力值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_021pe2:Ability{
//NAME=苦痛思绪
//TEXT=<b>被动</b> 每回合你使用的第一张你套牌之外的牌会消耗生命值，而非法力值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_022:HeroBase{
//NAME=泽瑞拉
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=32|RACE=NONE
}
public class THD_022hp:HeroPowerBase{
//NAME=圣光耀闪
//TEXT=恢复#2点生命值。<b>法力渴求（8）：</b>改为恢复#4点。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_022p:SpellBase{
//NAME=净化碎片
//TEXT=你的生命值上限为60点，达到该值即可获胜。对敌方英雄造成的伤害会治疗你的英雄。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_023:HeroBase{
//NAME=死亡阴影瓦莉拉
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_023hp:HeroPowerBase{
//NAME=手法娴熟
//TEXT=在本回合中，你使用的下一张牌法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_023p:SpellBase{
//NAME=沼泽诅咒
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_023pe:Ability{
//NAME=沼泽诅咒玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_024:HeroBase{
//NAME=经理马林
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_024hp:HeroPowerBase{
//NAME=投资回报
//TEXT=将三张幸运币洗入你的牌库。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_024p:SpellBase{
//NAME=把握机遇
//TEXT=当你使用最右边的手牌时，抽一张牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_025:HeroBase{
//NAME=海盗帕奇斯
//TEXT=
//MAJ=ROGUE|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_025hp:HeroPowerBase{
//NAME=带头冲锋
//TEXT=抽一张海盗牌。在你使用一张海盗牌后，法力值消耗减少（1）点。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class THD_025p:SpellBase{
//NAME=填弹完毕
//TEXT=在你召唤一个海盗后，使其随机对一个敌人造成1点伤害。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_026:HeroBase{
//NAME=风领主奥拉基尔
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_026hp:HeroPowerBase{
//NAME=听我号令！
//TEXT=使一个随从获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_026p:SpellBase{
//NAME=元素唤醒
//TEXT=在你使用一张<b>传说</b>元素牌后，唤起一种元素之力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_027:HeroBase{
//NAME=可敬的布鲁坎
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_027hp:HeroPowerBase{
//NAME=双重震击
//TEXT=召唤一个1/1的元素。<i>（每有一个你使用过元素牌的连续的回合，便+1/+1。）</i>
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_027p:SpellBase{
//NAME=自然力量
//TEXT=在你使用6张元素牌后，唤起两种元素之力。（0/6）
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_027pe:Ability{
//NAME=自然力量玩家附加效果
//TEXT=<b>被动</b> 自然法术伤害+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_027pe_Copy:Ability{
//NAME=自然力量玩家附加效果复制
//TEXT=在你使用8张元素牌后，唤起两种元素之力。（0/8）
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_028:HeroBase{
//NAME=女巫哈加莎
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_028hp:HeroPowerBase{
//NAME=图腾力量
//TEXT=随机召唤一个基础图腾。如果你有<b>过载</b>的法力水晶，改为召唤一个非基础图腾。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_028p:SpellBase{
//NAME=战斗图腾
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_028pe:Ability{
//NAME=战斗图腾玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_029:HeroBase{
//NAME=拉格纳罗斯
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_029hp:HeroPowerBase{
//NAME=唤醒火焰
//TEXT=向一个圣殿魔像灌注火焰之力。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_029p:SpellBase{
//NAME=岩浆地板
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_029pe:Ability{
//NAME=岩浆地板玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_030:HeroBase{
//NAME=加拉克苏斯大王
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_030hp:HeroPowerBase{
//NAME=恶魔之血
//TEXT=随机使你手牌中的一张恶魔牌获得+3/+2。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_030p:SpellBase{
//NAME=探底利器
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_030pe:Ability{
//NAME=探底利器玩家附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_031:HeroBase{
//NAME=奈姆希·灵沼
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_031hp:HeroPowerBase{
//NAME=灵魂编织
//TEXT=抽一张牌。在回合结束时，弃掉它。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class THD_031p:SpellBase{
//NAME=沼泽补给
//TEXT=<b>被动</b> 每回合中你第一次弃牌时，抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_031pe:Ability{
//NAME=沼泽补给附加效果
//TEXT=<b>被动</b> 每回合中你第一次弃牌时，抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_032:HeroBase{
//NAME=至尊盗王拉法姆
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=45|RACE=NONE
}
public class THD_032hp:HeroPowerBase{
//NAME=它归我了！
//TEXT=<b>发现</b>一张你的对手职业的法力值消耗小于或等于（3）点的法术牌。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_032p:SpellBase{
//NAME=看我的法杖！
//TEXT=你的<b>传说</b>牌的法力值消耗减少（1）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_033:HeroBase{
//NAME=达利乌斯·克罗雷
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_033hp:HeroPowerBase{
//NAME=开炮！
//TEXT=开炮！如果消灭任意随从，复原此技能。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_033p:SpellBase{
//NAME=火炮专家
//TEXT=<b>对战开始时：</b>召唤一门火炮。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_033pe:Ability{
//NAME=火炮专家附加效果
//TEXT=<b>对战开始时：</b>召唤一门火炮。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_034:HeroBase{
//NAME=砰砰博士
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_034hp2:HeroPowerBase{
//NAME=灵感爆发
//TEXT=召唤一个 1/1的砰砰机器人。<i>警告：该机器人随时可能爆炸。</i>
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_034p:SpellBase{
//NAME=爆破弹幕
//TEXT=在一个友方机械死亡后，将一张“炸弹”牌洗入你对手的牌库，并获得1点护甲值。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_035:HeroBase{
//NAME=洛卡拉
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=ORC
}
public class THD_035hp:HeroPowerBase{
//NAME=勇武过人
//TEXT=对一个随从造成1点伤害。如果该随从依然存活，使其获得+2攻击力；如果该随从死亡，获得$d2点护甲值。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_035p:SpellBase{
//NAME=火箭背包
//TEXT=<b>被动</b> 你的所有随从拥有<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_035pe:Ability{
//NAME=火箭背包附加效果
//TEXT=<b>被动</b> 你的所有随从拥有<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_036:HeroBase{
//NAME=德纳修斯大帝
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_036hp:HeroPowerBase{
//NAME=旷世杰作
//TEXT=消耗你所有的法力值，随机 召唤一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_036p:SpellBase{
//NAME=食尸鬼突进
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_036pe:Ability{
//NAME=食尸鬼突进附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_037:HeroBase{
//NAME=瓦里安·乌瑞恩
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_037hp:HeroPowerBase{
//NAME=乌瑞恩之怒
//TEXT=在本回合中，使你的英雄获得<b>风怒</b>。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_037hpe:Ability{
//NAME=乌瑞恩之怒
//TEXT=在本回合中<b>风怒</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_037p:SpellBase{
//NAME=乌瑞恩之刃
//TEXT=<b>被动</b> 在你的回合开始时，如果你未装备武器，则装备你手牌中最左边的武器。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_037pe:Ability{
//NAME=乌瑞恩之刃附加效果
//TEXT=<b>被动</b> 在你的回合开始时，如果你未装备武器，则装备你手牌中最左边的武器。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_038:HeroBase{
//NAME=克苏恩
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_038hp:HeroPowerBase{
//NAME=呼唤克苏恩！
//TEXT=<b>发现</b>一个克苏恩的信徒。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_038p:SpellBase{
//NAME=在劫难逃
//TEXT=克苏恩会出现在你的起始手牌中。在3个友方随从死亡后，使你的克苏恩获得+2/+2。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_039:HeroBase{
//NAME=腐蚀者恩佐斯
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_039hp:HeroPowerBase{
//NAME=再度崛起
//TEXT=召唤一个你使用的上一张<b>亡语</b>随从牌的1/1的复制。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_039hpe:Ability{
//NAME=再度崛起
//TEXT=1/1。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_039p:SpellBase{
//NAME=黑暗邪谋
//TEXT=在你使用一张<b>亡语</b>随从牌后，触发其<b>亡语</b>。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_040:HeroBase{
//NAME=伊莉斯·逐星
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_040hp:HeroPowerBase{
//NAME=艾露恩神像
//TEXT=<b>抉择：</b>在本回合中<b>法术伤害+2</b>；或者获取你施放的上一个法术的一张复制。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_040hpa:SpellBase{
//NAME=赋能神像
//TEXT=在本回合中获得<b>法术伤害+2</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_040hpae:Ability{
//NAME=月光
//TEXT=你在本回合中拥有<b>法术伤害+2</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_040hpb:SpellBase{
//NAME=威能神像
//TEXT=获取你施放的上一个法术的一张复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_040p:SpellBase{
//NAME=逐星
//TEXT=<b>被动</b> 在一回合中你施放4个法术后，将一张“月火术”置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_040pe:Ability{
//NAME=逐星附加效果
//TEXT=<b>被动</b> 在一回合中你施放4个法术后，将一张“月火术”置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_042:HeroBase{
//NAME=布莱恩·铜须
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_042hp:HeroPowerBase{
//NAME=挥响皮鞭
//TEXT=你的下一个<b>战吼</b>会触发两次。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_042hpe:Ability{
//NAME=挥响皮鞭
//TEXT=你的下一个战吼会触发两次。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_042p:SpellBase{
//NAME=布莱恩的鞍座
//TEXT=在你使用一张<b>战吼</b>随从牌后，随机将其变形成为一只法力值消耗相同的野兽。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_043:HeroBase{
//NAME=凯尔萨斯·逐日者
//TEXT=
//MAJ=MAGE|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_043hp:HeroPowerBase{
//NAME=不稳定的魔法
//TEXT=在你的回合开始时获取一张可用的法术牌，并在回合结束时弃掉。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_043hpe:Ability{
//NAME=不稳定的魔法
//TEXT=在你的回合结束时弃掉。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_043p:SpellBase{
//NAME=邪能灌注
//TEXT=你的套牌之外的牌法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_043pe2:Ability{
//NAME=邪能灌注
//TEXT=你的套牌之外的牌法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_044:HeroBase{
//NAME=芬利·莫格顿爵士
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=40|RACE=NONE
}
public class THD_044hp:HeroPowerBase{
//NAME=浮上水面
//TEXT=抽一张鱼人牌。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_044p:SpellBase{
//NAME=正义之剑
//TEXT=你的鱼人拥有<b>突袭</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_100:HeroBase{
//NAME=阿尔福斯
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_100hp:HeroPowerBase{
//NAME=爱宠福利
//TEXT=消耗最多3具<b>尸体</b>。每消耗一具，使你一张手牌的法力值消耗减少（1）点。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_100hpe:Ability{
//NAME=爱宠福利
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_100p:SpellBase{
//NAME=挖掘邪恶
//TEXT=在你使用一张邪恶符文牌后，<b>发掘</b>。切换为鲜血。<i><b>传说</b>宝藏来自随机职业。</i>
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_100p2:SpellBase{
//NAME=挖掘冰霜
//TEXT=在你使用一张冰霜符文牌后，<b>发掘</b>。切换为邪恶。<i><b>传说</b>宝藏来自随机职业。</i>
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_100p3:SpellBase{
//NAME=挖掘鲜血
//TEXT=在你使用一张鲜血符文牌后，<b>发掘</b>。切换为冰霜。<i><b>传说</b>宝藏来自随机职业。</i>
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_102:HeroBase{
//NAME=塔姆辛·罗姆
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_102hp:HeroPowerBase{
//NAME=鲜血的契印
//TEXT=受到$1点伤害。召唤一个1/1的恶魔。<i>此效果每回合都会提高。</i>
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_102hpt:MinionBase{
//NAME=塔姆辛的宠物
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class THD_102hpt2:MinionBase{
//NAME=塔姆辛的魔仆
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class THD_102hpt3:HeroPowerBase{
//NAME=灵魂绑定
//TEXT=受到$1点伤害。造成$1点伤害。<i>此效果每回合都会提高。</i>
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_102p:SpellBase{
//NAME=香氛护命匣
//TEXT=你有两条命。在你的英雄死后，你的英雄技能会由召唤恶魔改为造成伤害。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_102t:HeroBase{
//NAME=转生的塔姆辛
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class THD_103:HeroBase{
//NAME=灭世泰坦萨格拉斯
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_103hp:HeroPowerBase{
//NAME=扭曲虚空
//TEXT=消灭所有随从。<i>只能使用一次。</i>
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDestroyTargets(FindAllMin());
    }
}
public class THD_103p:SpellBase{
//NAME=终结将近
//TEXT=在你的第一个回合开始时，将一张法力值消耗为（10）的可造成30点伤害的法术牌洗入你的牌库。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_103pt2:SpellBase{
//NAME=末日来临！
//TEXT=造成$30点伤害！！
//MAJ=WARLOCK|COST=10|ATK=0|HP=0|RACE=FEL
}
public class THD_104:HeroBase{
//NAME=碎心歌手赫达尼斯
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_104hp:HeroPowerBase{
//NAME=俘获观众
//TEXT=使一个随从获得+2/+2。如果它已被<b><b>沉默</b></b>，抽一张牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class THD_104hpe:Ability{
//NAME=善于倾听
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_104p:SpellBase{
//NAME=追星入迷
//TEXT=当一个随从进入你的手牌时，使其获得-2攻击力且法力值消耗减少（1）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_104pe:Ability{
//NAME=追星
//TEXT=法力值消耗减少（1）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_104pe2:Ability{
//NAME=追星入迷
//TEXT=-2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_105:HeroBase{
//NAME=风暴之王托里姆
//TEXT=
//MAJ=SHAMAN|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_105hp:HeroPowerBase{
//NAME=驾驭风暴
//TEXT=召唤一个基础图腾。如果你有<b>过载</b>的法力水晶，则召唤两个。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_105p:SpellBase{
//NAME=泰坦电涌
//TEXT=你的图腾拥有+2攻击力<i>（无论它们在哪）</i>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_105pe:Ability{
//NAME=泰坦之威
//TEXT=+2攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_106:HeroBase{
//NAME=精英牛头人歌王
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_106hp:HeroPowerBase{
//NAME=即兴乐句
//TEXT=获取一张2/1并具有<b>嘲讽</b>的摇滚乐手。<b>压轴：</b>召唤它。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_106hpt:MinionBase{
//NAME=摇滚乐手
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=1|ATK=2|HP=1|RACE=NONE
}
public class THD_106p:SpellBase{
//NAME=继续摇滚
//TEXT=在你的回合结束时，随机使你手牌中一张<b>嘲讽</b>随从牌获得+2/+2。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_106pe:Ability{
//NAME=摇滚起来！
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_107:HeroBase{
//NAME=哈维利亚·墨鸦
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_107hp:HeroPowerBase{
//NAME=忧虑之歌
//TEXT=选择一个随从，使其在本回合中受到的所有伤害提高一点。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class THD_107hpe:Ability{
//NAME=盛怒
//TEXT=在本回合中受到的所有伤害提高一点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_107p:SpellBase{
//NAME=流放之曲
//TEXT=你手牌中最左边和最右边的牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_107pe3:Ability{
//NAME=流放之曲
//TEXT=法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_108:HeroBase{
//NAME=女伯爵莉亚德琳
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=35|RACE=NONE
}
public class THD_108hp:HeroPowerBase{
//NAME=耐心
//TEXT=复原你的法力水晶。锁定本技能，持续回合数为复原的法力水晶数量。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_108hp2:HeroPowerBase{
//NAME=耐心
//TEXT=复原你的法力水晶。<i>（0回合后可以再次使用！）</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_108p:SpellBase{
//NAME=莉亚德琳的勇士
//TEXT=在你对友方随从施放一个法术后，抽一张牌，其法力值消耗减少（2）点。<i>每回合限一次。</i>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class THD_108pe:Ability{
//NAME=莉亚德琳的勇士
//TEXT=法力值消耗减少（2）点。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
