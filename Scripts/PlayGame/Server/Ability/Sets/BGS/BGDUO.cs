using System.Collections;
using System.Collections.Generic;

public class BGDUO_100:MinionBase{
//NAME=远行者周卓
//TEXT=每回合中有1次免费<b>传递</b>。<i>（还剩1次！）</i>
//MAJ=NEUTRAL|COST=2|ATK=4|HP=3|RACE=NONE
}
public class BGDUO_100_G:MinionBase{
//NAME=远行者周卓
//TEXT=每回合中有2次免费<b>传递</b>。<i>（还剩2次！）</i>
//MAJ=NEUTRAL|COST=2|ATK=8|HP=6|RACE=NONE
}
public class BGDUO_100e:Ability{
//NAME=远行快递
//TEXT=免费传递
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_104:MinionBase{
//NAME=热心的沙龙酒保
//TEXT=<b>战吼：</b>你的队友获取一张铸币牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=4|RACE=NONE
}
public class BGDUO_104_G:MinionBase{
//NAME=热心的沙龙酒保
//TEXT=<b>战吼：</b>你的队友获取2张铸币牌。
//MAJ=NEUTRAL|COST=2|ATK=6|HP=8|RACE=NONE
}
public class BGDUO_105:MinionBase{
//NAME=宽厚的驼鹿
//TEXT=<b>亡语：</b>召唤你的队友战队中一个随从<i>（宽厚的驼鹿除外）</i>的复制，将其生命值变为1。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=2|RACE=BEAST
}
public class BGDUO_105_G:MinionBase{
//NAME=宽厚的驼鹿
//TEXT=<b>亡语：</b>召唤你的队友战队中2个随从<i>（宽厚的驼鹿除外）</i>的复制，将其生命值变为1。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=4|RACE=BEAST
}
public class BGDUO_105e2:Ability{
//NAME=天啦鹿
//TEXT=生命值变为1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_107:MinionBase{
//NAME=护雏的龙希尔
//TEXT=在你的回合结束时，使你的队友的随从获得+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=DRAGON
}
public class BGDUO_107_G:MinionBase{
//NAME=护雏的龙希尔
//TEXT=在你的回合结束时，使你的队友的随从获得+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=8|HP=6|RACE=DRAGON
}
public class BGDUO_107_Ge:Ability{
//NAME=遭受溺爱
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_107_Gs:SpellBase{
//NAME=Doting Dracthyr Golden Spell [DNT]
//TEXT=Gives your minions +4 Attack. [DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_107e:Ability{
//NAME=遭受溺爱
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_107s:SpellBase{
//NAME=Doting Dracthyr Spell [DNT]
//TEXT=Gives your minions +2 Attack. [DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_108:MinionBase{
//NAME=镜中鬼怪
//TEXT=当你购买或<b>发现</b>本随从时，获取一张额外复制并<b>传递</b>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=ALL
}
public class BGDUO_108_G:MinionBase{
//NAME=镜中鬼怪
//TEXT=当你购买或<b>发现</b>本随从时，获取2张额外复制并<b>传递</b>。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=8|RACE=ALL
}
public class BGDUO_109:MinionBase{
//NAME=增援系统
//TEXT=在你的回合结束时，使你的队友战队中的一个随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=MECHANICAL
}
public class BGDUO_109_G:MinionBase{
//NAME=增援系统
//TEXT=在你的回合结束时，使你的队友战队中的2个随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=10|RACE=MECHANICAL
}
public class BGDUO_109_Gs:SpellBase{
//NAME=Support System Golden Spell [DNT]
//TEXT=Gives 2 friendly minions <b>Divine Shield</b>. [DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_109e:Ability{
//NAME=坚实后盾
//TEXT=<b><b>圣盾</b>。</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_109s:SpellBase{
//NAME=Support System Spell [DNT]
//TEXT=Gives a friendly minion <b>Divine Shield</b>. [DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_110:MinionBase{
//NAME=活泼的淡水元素
//TEXT=<b>亡语：</b>你和你的队友各获得两次消耗为（0）的<b>刷新</b>。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=4|RACE=ELEMENTAL
}
public class BGDUO_110_G:MinionBase{
//NAME=活泼的淡水元素
//TEXT=<b>亡语：</b>你和你的队友各获得四次消耗为（0）的<b>刷新</b>。
//MAJ=NEUTRAL|COST=4|ATK=12|HP=8|RACE=ELEMENTAL
}
public class BGDUO_110_Gs:SpellBase{
//NAME=Feisty Freshwater Golden Spell [DNT]
//TEXT=Makes your next 4 <b>Refreshes</b> cost (0). [DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_110s:SpellBase{
//NAME=Feisty Freshwater Spell [DNT]
//TEXT=Makes your next 2 <b>Refreshes</b> cost (0). [DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_111:MinionBase{
//NAME=大方的地卜师
//TEXT=<b>亡语：</b> 你和你的队友各获取一张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=QUILBOAR
}
public class BGDUO_111_G:MinionBase{
//NAME=大方的地卜师
//TEXT=<b>亡语：</b> 你和你的队友各获取2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=QUILBOAR
}
public class BGDUO_112:MinionBase{
//NAME=墓后解说员
//TEXT=<b>复仇（3）：</b>你的队友获取一张其多数随从的类型的随从牌。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=7|RACE=UNDEAD
}
public class BGDUO_112_G:MinionBase{
//NAME=墓后解说员
//TEXT=<b>复仇（3）：</b>你的队友获取2张其多数随从的类型的随从牌。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=14|RACE=UNDEAD
}
public class BGDUO_113:Ability{
//NAME=瓶中传送门
//TEXT=<b>传递</b>一个非金色随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=TAVERN
}
public class BGDUO_114:MinionBase{
//NAME=过路旅客
//TEXT=每回合中你的队伍第一次<b>传递</b>时，获得+1/+2。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
}
public class BGDUO_114_G:MinionBase{
//NAME=过路旅客
//TEXT=每回合中你的队伍第一次<b>传递</b>时，获得+2/+4。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=4|RACE=NONE
}
public class BGDUO_114_Ge:Ability{
//NAME=一路顺风
//TEXT=+2/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_114e:Ability{
//NAME=一路顺风
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_115:MinionBase{
//NAME=跳跳娃娃
//TEXT=本随从第一次被出售时，改为<b>传递</b>它。0本随从第一次被出售时，改为<b>传递</b>它。<i>（已出售过！）</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=ALL
}
public class BGDUO_115_G:MinionBase{
//NAME=跳跳娃娃
//TEXT=本随从第一次被出售时，改为<b>传递</b>它。0本随从第一次被出售时，改为<b>传递</b>它。<i>（已出售过！）</i>
//MAJ=NEUTRAL|COST=3|ATK=6|HP=8|RACE=ALL
}
public class BGDUO_117:MinionBase{
//NAME=滩涂跳跳鱼
//TEXT=在本随从被<b>传递</b>后，获得+4/+4。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=MURLOC
}
public class BGDUO_117_G:MinionBase{
//NAME=滩涂跳跳鱼
//TEXT=在本随从被<b>传递</b>后，获得+8/+8。
//MAJ=NEUTRAL|COST=3|ATK=8|HP=8|RACE=MURLOC
}
public class BGDUO_117_Ge:Ability{
//NAME=小溅人
//TEXT=+8/+8。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_117e:Ability{
//NAME=小溅人
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_118:MinionBase{
//NAME=打劫共犯
//TEXT=在你的回合开始时，你和你的队友各获得1枚铸币。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=PIRATE
}
public class BGDUO_118_G:MinionBase{
//NAME=打劫共犯
//TEXT=在你的回合开始时，你和你的队友各获得2枚铸币。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=PIRATE
}
public class BGDUO_118_Gs:SpellBase{
//NAME=Plunder Pal Golden Spell [DNT]
//TEXT=使你获得2枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_118s:SpellBase{
//NAME=Plunder Pal Spell [DNT]
//TEXT=使你获得1枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_119:MinionBase{
//NAME=兽人指挥
//TEXT=<b>战吼：</b>使一个随从获得+{0}/+{1}<i>（在本局对战中，你的队伍每使用过一张兽人指挥都会升级）</i>。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=NONE
}
public class BGDUO_119_G:MinionBase{
//NAME=兽人指挥
//TEXT=<b>战吼：</b>使一个随从获得+{0}/+{1}<i>（在本局对战中，你的队伍每使用过一张兽人指挥都会升级）</i>。
//MAJ=NEUTRAL|COST=3|ATK=8|HP=8|RACE=NONE
}
public class BGDUO_119e:Ability{
//NAME=受兽人指挥
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_119pe:Ability{
//NAME=Orc-estra Conductor Player Ench [DNT]
//TEXT=Counts the number of Orc-estra Conductor your team played. [DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_119s:SpellBase{
//NAME=Orc-estra Conductor Teammate Trigger [DNT]
//TEXT=Increments your Orc-estra Conductor player ench. [DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_120:MinionBase{
//NAME=井边许愿者
//TEXT=<b>塑造法术：</b><b>传递</b>一个不同的非金色随从。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=NONE
}
public class BGDUO_120_G:MinionBase{
//NAME=井边许愿者
//TEXT=<b>塑造法术：</b><b>传递</b>一个不同的非金色随从。
//MAJ=NEUTRAL|COST=5|ATK=12|HP=12|RACE=NONE
}
public class BGDUO_120_Gt:SpellBase{
//NAME=井边许愿
//TEXT=<b>传递</b>一个非金色随从<i>（井边许愿者除外）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BGDUO_120t:SpellBase{
//NAME=井边许愿
//TEXT=<b>传递</b>一个非金色随从<i>（井边许愿者除外）</i>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BGDUO_121:MinionBase{
//NAME=堕落者信使
//TEXT=<b>战吼：</b>在本局对战中，你的队伍酒馆中的随从拥有+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=9|HP=6|RACE=DEMON
}
public class BGDUO_121_G:MinionBase{
//NAME=堕落者信使
//TEXT=<b>战吼：</b>在本局对战中，你的队伍酒馆中的随从拥有+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=18|HP=12|RACE=DEMON
}
public class BGDUO_121_Gs:SpellBase{
//NAME=Man'ari Messenger Golden Spell [DNT]
//TEXT=使酒馆中的随从获得+2/+2。[DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_121e:Ability{
//NAME=消息送到
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_121pe:Ability{
//NAME=Man'ari Messenger Player Enchant [DNT]
//TEXT=Tavern minions have increased stats. [DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_121s:SpellBase{
//NAME=Man'ari Messenger Spell [DNT]
//TEXT=使酒馆中的随从获得+1/+1。[DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_122:MinionBase{
//NAME=风暴分流者
//TEXT=每回合一次：在你<b>传递</b>酒馆法术牌后，获取一张它的新复制。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=5|RACE=NAGA
}
public class BGDUO_122_G:MinionBase{
//NAME=风暴分流者
//TEXT=每回合一次：在你<b>传递</b>酒馆法术牌后，获取2张它的新复制。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=10|RACE=NAGA
}
public class BGDUO_123:Ability{
//NAME=接着！
//TEXT=使你的随从获得+2攻击力。<i>（被<b>传递</b>后升级，+2攻击力！）</i>
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=TAVERN
}
public class BGDUO_123e:Ability{
//NAME=接住了！
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_124:Ability{
//NAME=招募流程
//TEXT=随机获取一张你的队友多数随从的类型的随从牌，然后<b>传递</b>它。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=TAVERN
}
public class BGDUO_125:MinionBase{
//NAME=流沙幻象
//TEXT=<b>战斗开始时：</b>变形成为你的队友生命值最高的随从的复制。
//MAJ=NEUTRAL|COST=7|ATK=1|HP=1|RACE=NONE
}
public class BGDUO_125_G:MinionBase{
//NAME=流沙幻象
//TEXT=<b>战斗开始时：</b>变形成为你的队友生命值最高的随从的金色复制。
//MAJ=NEUTRAL|COST=7|ATK=2|HP=2|RACE=NONE
}
public class BGDUO_HERO_100:HeroBase{
//NAME=无名者
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BGDUO_HERO_100_Buddy:MinionBase{
//NAME=无面者
//TEXT=当你出售本随从时，获取一张你队友的英雄技能对应的<b>伙伴</b>。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=1|RACE=NONE
}
public class BGDUO_HERO_100_Buddy_G:MinionBase{
//NAME=无面者
//TEXT=当你出售本随从时，获取2张你队友的英雄技能对应的<b>伙伴</b>。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=NONE
}
public class BGDUO_HERO_100p:HeroPowerBase{
//NAME=[x]
//TEXT=<b>被动 对战开始时：</b>复制你的队友的英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_HERO_101:HeroBase{
//NAME=软泥教授弗洛普
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BGDUO_HERO_101_Buddy:MinionBase{
//NAME=神奇黏液宝宝
//TEXT=在你的回合开始时，获取你的队友等级最高的随从的一张原始版复制<i>（<b>伙伴</b>除外）</i>。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=1|RACE=NONE
}
public class BGDUO_HERO_101_Buddy_G:MinionBase{
//NAME=神奇黏液宝宝
//TEXT=在你的回合开始时，获取你的队友等级最高的随从的2张原始版复制<i>（<b>伙伴</b>除外）</i>。
//MAJ=NEUTRAL|COST=0|ATK=12|HP=2|RACE=NONE
}
public class BGDUO_HERO_101p:HeroPowerBase{
//NAME=神奇黏液
//TEXT=选择一个友方随从。<b>战斗开始时：</b>将其变形成为你的队友的等级最高的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_HERO_101pe2:Ability{
//NAME=黏液包覆
//TEXT=即将变形。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_HERO_104:HeroBase{
//NAME=郭雅夫人
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BGDUO_HERO_104_Buddy:MinionBase{
//NAME=楚先生
//TEXT=每回合一次：在你<b>传递</b>一个随从后，获取一张它的原始版复制<i>（<b>伙伴</b>除外）</i>。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=6|RACE=NONE
}
public class BGDUO_HERO_104_Buddy_G:MinionBase{
//NAME=楚先生
//TEXT=每回合一次：在你<b>传递</b>一个随从后，获取2张它的原始版复制<i>（<b>伙伴</b>除外）</i>。
//MAJ=NEUTRAL|COST=4|ATK=12|HP=12|RACE=NONE
}
public class BGDUO_HERO_104p:HeroPowerBase{
//NAME=高效互换
//TEXT=<b>传递</b>一个非金色随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_HERO_222:HeroBase{
//NAME=古
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BGDUO_HERO_222_Buddy:MinionBase{
//NAME=威猛的哈尔弗斯
//TEXT=在你的回合开始时，<b>发现</b>一张你当前等级的随从牌。<i>（50%的几率<b>传递</b>发现的牌！）</i>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=5|RACE=NONE
}
public class BGDUO_HERO_222_Buddy_G:MinionBase{
//NAME=威猛的哈尔弗斯
//TEXT=在你的回合开始时，<b>发现</b>2张你当前等级的随从牌。<i>（50%的几率<b>传递</b>发现的牌！）</i>
//MAJ=NEUTRAL|COST=4|ATK=10|HP=10|RACE=NONE
}
public class BGDUO_HERO_222_SKIN_A:HeroBase{
//NAME=腐蚀者古
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BGDUO_HERO_222p:HeroPowerBase{
//NAME=双重麻烦
//TEXT=<b>被动</b> 每当你使用一张金色随从牌时，你和加尔均会获取三连奖励。<i>（还剩3次！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_HERO_222t:SpellBase{
//NAME=[DNT] Cho Gall HP Decrement
//TEXT=双重麻烦队友标记。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BGDUO_HERO_223:HeroBase{
//NAME=加尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BGDUO_HERO_223_Buddy:MinionBase{
//NAME=睿智的哈尔弗斯
//TEXT=在你的回合开始时，<b>发现</b>一张你当前等级的酒馆法术牌。<i>（50%的几率<b>传递</b>发现的牌！）</i>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=5|RACE=NONE
}
public class BGDUO_HERO_223_Buddy_G:MinionBase{
//NAME=睿智的哈尔弗斯
//TEXT=在你的回合开始时，<b>发现</b>2张你当前等级的酒馆法术牌。<i>（50%的几率<b>传递</b>发现的牌！）</i>
//MAJ=NEUTRAL|COST=4|ATK=10|HP=10|RACE=NONE
}
public class BGDUO_HERO_223_SKIN_A:HeroBase{
//NAME=腐蚀者加尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BGDUO_HERO_223p:HeroPowerBase{
//NAME=双重麻烦
//TEXT=<b>被动</b> 每当你使用一张金色随从牌时，你和古均会获取三连奖励。<i>（还剩3次！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
