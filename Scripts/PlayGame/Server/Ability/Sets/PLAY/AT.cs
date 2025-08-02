using System.Collections;
using System.Collections.Generic;

public class AT_001:SpellBase{
//NAME=炎枪术
//TEXT=对一个随从造成$25点伤害。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class AT_002:SecretBase{
//NAME=轮回
//TEXT=<b>奥秘：</b>当一个友方随从死亡时，随机召唤一个法力值消耗相同的随从。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class AT_003:MinionBase{
//NAME=英雄之魂
//TEXT=你的英雄技能会额外造成1点伤害。
//MAJ=MAGE|COST=2|ATK=3|HP=2|RACE=UNDEAD
}
public class AT_004:SpellBase{
//NAME=奥术冲击
//TEXT=对一个随从造成$2点伤害。该法术受到的<b>法术伤害</b>增益效果翻倍。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
	
}
public class AT_005:SpellBase{
//NAME=变形术：野猪
//TEXT=使一个随从变形成为一个4/2并具有<b>冲锋</b>的野猪。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class AT_005t:MinionBase{
//NAME=野猪
//TEXT=<b>冲锋</b>
//MAJ=MAGE|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class AT_006:MinionBase{
//NAME=达拉然铁骑士
//TEXT=<b>法术伤害+1</b> <b>激励：</b>获得<b>法术伤害+1</b>。
//MAJ=MAGE|COST=4|ATK=3|HP=5|RACE=NONE
}
public class AT_006e:Ability{
//NAME=达拉然之力
//TEXT=法术伤害提高。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_007:MinionBase{
//NAME=嗜法者
//TEXT=<b>战吼：</b>双方玩家各获取一张随机法术牌，你获取的那张法力值消耗减少（2）点。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=NONE
}
public class AT_007e:Ability{
//NAME=法术嗜好
//TEXT=法力值消耗减少（2）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_008:MinionBase{
//NAME=考达拉幼龙
//TEXT=你可以使用任意次数的英雄技能。
//MAJ=MAGE|COST=6|ATK=6|HP=7|RACE=DRAGON
}
public class AT_009:MinionBase{
//NAME=罗宁
//TEXT=<b>亡语：</b>将三张奥术飞弹置入你的手牌。
//MAJ=MAGE|COST=8|ATK=7|HP=7|RACE=NONE
}
public class AT_010:MinionBase{
//NAME=暴躁的牧羊人
//TEXT=<b>战吼：</b>如果你控制任何野兽，则随机召唤一个野兽。
//MAJ=HUNTER|COST=5|ATK=3|HP=3|RACE=NONE
}
public class AT_011:MinionBase{
//NAME=神圣勇士
//TEXT=<b>过量治疗：</b>获得+2攻击力。
//MAJ=PRIEST|COST=2|ATK=1|HP=4|RACE=NONE
}
public class AT_011e:Ability{
//NAME=圣光的祝福
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_012:MinionBase{
//NAME=暗影子嗣
//TEXT=<b>战吼，激励：</b>对每个英雄造成4点伤害。
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class AT_013:SpellBase{
//NAME=真言术：耀
//TEXT=选择一个随从。每当其进行攻击，为你的英雄恢复 4点生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class AT_013e:Ability{
//NAME=真言术：耀
//TEXT=当本随从攻击时，为将其强化的英雄恢复#4点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_014:MinionBase{
//NAME=暗影魔
//TEXT=每当你抽一张牌时，使其法力值消耗减少（1）点。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=NONE
}
public class AT_014e:Ability{
//NAME=暗影魔
//TEXT=法力值消耗减少（1）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_015:SpellBase{
//NAME=策反
//TEXT=将一个敌方随从的一张复制置入你的手牌。其法力值消耗为（1）点。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
}
public class AT_016:SpellBase{
//NAME=迷乱
//TEXT=将所有随从的攻击力和生命值 互换。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		List<Card> targets = new List<Card>();
		List<int> atkChanges = new List<int>();
		List<int> hpChanges = new List<int>();
		foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
		{
			targets.Add(c);
			atkChanges.Add(-c.GetTag(GameTag.Attack)+c.GetTag(GameTag.Health));
			hpChanges.Add(-c.GetTag(GameTag.Health)+c.GetTag(GameTag.Attack));
		}
		new EffectChange(owner.myPlayer,owner,targets:targets,atkChanges:atkChanges,hpChanges:hpChanges).Resolve();
	}
}
public class AT_016e:Ability{
//NAME=迷乱
//TEXT=攻击力和生命值互换。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_017:MinionBase{
//NAME=暮光守护者
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便获得+1攻击力和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=DRAGON
}
public class AT_017e:Ability{
//NAME=暮光的拥抱
//TEXT=+1攻击力并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_018:MinionBase{
//NAME=银色神官帕尔崔丝
//TEXT=<b>战吼，激励：</b>随机召唤一个<b>传说</b>随从。
//MAJ=PRIEST|COST=7|ATK=5|HP=4|RACE=NONE
}
public class AT_019:MinionBase{
//NAME=恐惧战马
//TEXT=<b>亡语：</b> 在回合结束时，召唤一匹恐惧战马。
//MAJ=WARLOCK|COST=4|ATK=1|HP=1|RACE=DEMON
}
public class AT_019e:Ability{
//NAME=恐惧战马
//TEXT=在回合结束时，召唤一匹恐惧战马。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_020:MinionBase{
//NAME=恐怖末日守卫
//TEXT=
//MAJ=WARLOCK|COST=7|ATK=6|HP=8|RACE=DEMON
}
public class AT_021:MinionBase{
//NAME=小鬼骑士
//TEXT=每当你弃掉一张牌时，便获得+2/+1。
//MAJ=WARLOCK|COST=2|ATK=3|HP=2|RACE=DEMON
}
public class AT_021e:Ability{
//NAME=邪火之怒
//TEXT=属性值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_022:SpellBase{
//NAME=加拉克苏斯之拳
//TEXT=当你使用或弃掉这张牌时，随机对一个敌人造成$4点伤害。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=FEL
}
public class AT_023:MinionBase{
//NAME=虚空碾压者
//TEXT=<b>激励：</b>随机消灭每个玩家的一个随从。
//MAJ=WARLOCK|COST=6|ATK=5|HP=4|RACE=DEMON
}
public class AT_024:SpellBase{
//NAME=恶魔融合
//TEXT=使一个恶魔获得+3/+3。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class AT_024e:Ability{
//NAME=黑暗融合
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_025:SpellBase{
//NAME=黑暗交易
//TEXT=随机消灭两个敌方随从，随机弃两张牌。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class AT_026:MinionBase{
//NAME=愤怒卫士
//TEXT=每当本随从受到伤害，对你的英雄造成等量的伤害。
//MAJ=WARLOCK|COST=2|ATK=4|HP=3|RACE=DEMON
}
public class AT_027:MinionBase{
//NAME=威尔弗雷德·菲兹班
//TEXT=你通过英雄技能抽到的卡牌，其法力值消耗为（0）点。
//MAJ=WARLOCK|COST=6|ATK=4|HP=4|RACE=NONE
}
public class AT_027e:Ability{
//NAME=召唤大师
//TEXT=法力值消耗为（0）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_028:MinionBase{
//NAME=影踪骁骑兵
//TEXT=<b>连击：</b> 获得+4攻击力。
//MAJ=ROGUE|COST=5|ATK=3|HP=7|RACE=NONE
}
public class AT_028e:Ability{
//NAME=真气突进
//TEXT=+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_029:MinionBase{
//NAME=锈水海盗
//TEXT=每当你装备一把武器，使武器获得+1攻击力。
//MAJ=ROGUE|COST=1|ATK=2|HP=1|RACE=PIRATE
}
public class AT_029e:Ability{
//NAME=暗钩手
//TEXT=+1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_030:MinionBase{
//NAME=幽暗城勇士
//TEXT=<b>连击：</b>造成1点伤害。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=UNDEAD
}
public class AT_031:MinionBase{
//NAME=窃贼
//TEXT=每当本随从攻击英雄时，将幸运币置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class AT_032:MinionBase{
//NAME=走私商贩
//TEXT=<b>战吼：</b>如果你控制任何海盗，便获得+1/+1。
//MAJ=ROGUE|COST=3|ATK=4|HP=3|RACE=NONE
}
public class AT_032e:Ability{
//NAME=走私交易
//TEXT=+1/+1。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_032e_copy:Ability{
//NAME=Shady Deals Copy
//TEXT=+1/+1。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_033:SpellBase{
//NAME=剽窃
//TEXT=随机获取3张<i>（你对手职业的）</i>卡牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class AT_034:WeaponBase{
//NAME=淬毒利刃
//TEXT=你的英雄技能不会取代该武器，改为+1攻击力。
//MAJ=ROGUE|COST=2|ATK=1|HP=3|RACE=NONE
}
public class AT_034e:Ability{
//NAME=小心剧毒
//TEXT=攻击力提高。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_035:SpellBase{
//NAME=危机四伏
//TEXT=将三张伏击牌洗入你对手的牌库。当你的对手抽到该牌，便为你召唤一个4/4的蛛魔。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class AT_035t:SpellBase{
//NAME=蛛魔伏击
//TEXT=<b>抽到时施放</b> 为你的对手召唤一个4/4的蛛魔。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class AT_036:MinionBase{
//NAME=阿努巴拉克
//TEXT=<b>亡语：</b>召唤一个4/4并具有“<b>亡语：</b>召唤阿努巴拉克”的蛛魔。
//MAJ=ROGUE|COST=8|ATK=8|HP=4|RACE=UNDEAD
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("AT_036t"),ZoneType.Board);
	}
}
public class AT_036t:MinionBase{
//NAME=蛛魔
//TEXT=<b>亡语：</b>召唤阿努巴拉克。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=UNDEAD
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("AT_036"),ZoneType.Board);
	}
}
public class AT_037:SpellBase{
//NAME=活体根须
//TEXT=<b>抉择：</b>造成$2点伤害；或者召唤两个1/1的树苗。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class AT_037a:SpellBase{
//NAME=缠人根须
//TEXT=造成$2点伤害。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class AT_037b:SpellBase{
//NAME=并蒂树苗
//TEXT=召唤两个1/1的树苗。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class AT_037t:MinionBase{
//NAME=树苗
//TEXT=
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=NONE
}
public class AT_038:MinionBase{
//NAME=达纳苏斯豹骑士
//TEXT=<b>战吼：</b>获得一个空的法力水晶。 <b>亡语：</b>失去一个法力水晶。
//MAJ=DRUID|COST=2|ATK=2|HP=3|RACE=NONE
}
public class AT_039:MinionBase{
//NAME=狂野争斗者
//TEXT=<b>激励：</b>在本回合中，使你的英雄获得+2攻击力。
//MAJ=DRUID|COST=4|ATK=5|HP=4|RACE=BEAST
}
public class AT_039e:Ability{
//NAME=生来狂野
//TEXT=在本回合中，+2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_040:MinionBase{
//NAME=荒野行者
//TEXT=<b>战吼：</b>使一个友方野兽获得+3生命值。
//MAJ=DRUID|COST=4|ATK=4|HP=4|RACE=NONE
}
public class AT_040e:Ability{
//NAME=灵魂羁绊
//TEXT=+3生命值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_041:MinionBase{
//NAME=荒野骑士
//TEXT=在本局对战中，你每召唤过一只野兽，本牌的法力值消耗便减少（1）点。
//MAJ=DRUID|COST=7|ATK=6|HP=6|RACE=NONE
}
public class AT_041e:Ability{
//NAME=野性呼唤
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_042:MinionBase{
//NAME=刃牙德鲁伊
//TEXT=<b>抉择：</b>变形成为2/1并具有<b>冲锋</b>；或者变形成为3/2并具有<b>潜行</b>。
//MAJ=DRUID|COST=2|ATK=2|HP=1|RACE=NONE
}
public class AT_042a:MinionBase{
//NAME=雄狮形态
//TEXT=<b>冲锋</b>
//MAJ=DRUID|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class AT_042b:MinionBase{
//NAME=黑豹形态
//TEXT=<b>潜行</b>
//MAJ=DRUID|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class AT_042t:MinionBase{
//NAME=刃牙德鲁伊
//TEXT=<b>冲锋</b>
//MAJ=DRUID|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class AT_042t2:MinionBase{
//NAME=刃牙德鲁伊
//TEXT=<b>潜行</b>
//MAJ=DRUID|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class AT_043:SpellBase{
//NAME=星界沟通
//TEXT=获得十个法力水晶。弃掉 你的手牌。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class AT_044:SpellBase{
//NAME=腐根
//TEXT=消灭一个随从。随机将一张随从牌置入对手的手牌。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class AT_045:MinionBase{
//NAME=艾维娜
//TEXT=你的随从牌的法力值消耗为（1）点。
//MAJ=DRUID|COST=9|ATK=5|HP=5|RACE=NONE
}
public class AT_045e:Ability{
//NAME=强心迷雾
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_045ee:Ability{
//NAME=唤雾者之息
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_045eee:Ability{
//NAME=艾维娜的祝福
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_046:MinionBase{
//NAME=海象人图腾师
//TEXT=<b>战吼：</b>随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=2|ATK=3|HP=2|RACE=NONE
    public override void Battlecry(Card target = null)
    {
    	List<string> po = new List<string>(){"NEW1_009","CS2_051","CS2_058","CS2_050"};
        new EffectCreate(owner.myPlayer,new Card(CardDbf.GetCardDbfByGuid(po.Choice(owner.myPlayer.randomGen)), owner.myPlayer), ZoneType.Board).Resolve();
    }
}
public class AT_047:MinionBase{
//NAME=德莱尼图腾师
//TEXT=<b>战吼：</b>每有一个友方图腾，便获得+1/+1。
//MAJ=SHAMAN|COST=4|ATK=4|HP=5|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		int Num=0;
		foreach(Card c in owner.myPlayer.board)
		{
			if(c.raceType.Contains(RaceType.Totem) || c.raceType.Contains(RaceType.All))
			{
				Num+=1;
			}
		}
		new EffectChange(owner.myPlayer,owner,owner,atkChange:Num,hpChange:Num).Resolve();
	}
}
public class AT_047e:Ability{
//NAME=经验丰富
//TEXT=属性值提高。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_048:SpellBase{
//NAME=治疗波
//TEXT=恢复#8点生命值。揭示双方牌库里的一张随从牌。如果你的牌法力值 消耗较大，改为恢复#16点生命值。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class AT_049:MinionBase{
//NAME=雷霆崖勇士
//TEXT=<b>战吼，激励：</b>使你的图腾获得+2攻击力。
//MAJ=SHAMAN|COST=5|ATK=3|HP=6|RACE=NONE
}
public class AT_049e:Ability{
//NAME=雷霆崖之力
//TEXT=攻击力提高。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_050:WeaponBase{
//NAME=灌魔之锤
//TEXT=<b>亡语：</b>你的英雄技能改为“造成 2点伤害”。
//MAJ=SHAMAN|COST=3|ATK=2|HP=3|RACE=NONE
}
public class AT_050t:HeroPowerBase{
//NAME=雷霆震击
//TEXT=造成$2点伤害。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AT_051:SpellBase{
//NAME=元素毁灭
//TEXT=对所有随从造成$4到$5点伤害。<b>过载：</b>（2）
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class AT_052:MinionBase{
//NAME=图腾魔像
//TEXT=<b>过载：</b>（1）
//MAJ=SHAMAN|COST=2|ATK=3|HP=4|RACE=TOTEM
	public override void Battlecry(Card target=null)
	{
		owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
	}
}
public class AT_053:SpellBase{
//NAME=先祖知识
//TEXT=抽两张牌。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		owner.myPlayer.SetTag(GameTag.ManaOverLoad,1);
		TaskDraw();
		TaskDraw();
	}
}
public class AT_054:MinionBase{
//NAME=唤雾者伊戈瓦尔
//TEXT=<b>战吼：</b>使你的手牌和牌库里的所有随从牌获得+1/+1。
//MAJ=SHAMAN|COST=6|ATK=4|HP=4|RACE=UNDEAD
}
public class AT_055:SpellBase{
//NAME=快速治疗
//TEXT=恢复#5点生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class AT_056:SpellBase{
//NAME=强风射击
//TEXT=对一个随从及其相邻的随从造成$2点伤害。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class AT_057:MinionBase{
//NAME=兽栏大师
//TEXT=<b>战吼：</b>在本回合中，使一个友方野兽获得<b>免疫</b>。
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=NONE
}
public class AT_057o:Ability{
//NAME=吃饱喝足
//TEXT=在本回合中<b>免疫</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_058:MinionBase{
//NAME=皇家雷象
//TEXT=<b>战吼：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，抽这张牌。
//MAJ=HUNTER|COST=2|ATK=3|HP=2|RACE=BEAST
	public override void Battlecry(Card target=null)
	{
		TaskDrawType(CardType.Minion);
	}
}
public class AT_059:MinionBase{
//NAME=神勇弓箭手
//TEXT=<b>激励：</b>如果你没有其他手牌，则对敌方英雄造成2点伤害。
//MAJ=HUNTER|COST=1|ATK=2|HP=1|RACE=NONE
}
public class AT_060:SecretBase{
//NAME=捕熊陷阱
//TEXT=<b>奥秘：</b>在你的英雄受到攻击后，召唤一个3/3并具有<b>嘲讽</b>的灰熊。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AT_061:SpellBase{
//NAME=子弹上膛
//TEXT=在本回合中，每当你施放一个法术，随机获取一张 猎人卡牌。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_061e:Ability{
//NAME=子弹上膛
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_062:SpellBase{
//NAME=天降蛛群
//TEXT=召唤三只1/1并具有“<b>亡语：</b>随机获取一张野兽牌”的 结网蛛。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class AT_063:MinionBase{
//NAME=酸喉
//TEXT=每当有敌方随从受到伤害时，将其消灭。
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=BEAST
	public override void RegisterEventEffect()
	{
		owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterTakeDamage(this,this.CauseEvent));
	}
	public override void UnRegisterEventEffect()
	{
		owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
	}
	public void CauseEvent(Card source,Card target, int amount)
	{
		if(CondInPlay())
		{
			new EffectDestroy(owner.myPlayer,owner,target).Resolve();
		}
	}
}
public class AT_063t:MinionBase{
//NAME=恐鳞
//TEXT=在你的回合结束时，对所有敌人造成 1点伤害。
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class AT_064:SpellBase{
//NAME=怒袭
//TEXT=造成$3点伤害。获得3点 护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        TaskBuffMyHero(arm:3);
    }
}
public class AT_065:WeaponBase{
//NAME=国王护卫者
//TEXT=<b>战吼：</b>如果你控制任何具有<b>嘲讽</b>的随从，便获得+1耐久度。
//MAJ=WARRIOR|COST=3|ATK=3|HP=2|RACE=NONE
}
public class AT_065e:Ability{
//NAME=国王护卫者
//TEXT=+1耐久度。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_066:MinionBase{
//NAME=奥格瑞玛狼骑士
//TEXT=<b>激励：</b>使你的武器获得+1攻击力。
//MAJ=WARRIOR|COST=3|ATK=3|HP=3|RACE=NONE
}
public class AT_066e:Ability{
//NAME=奥格瑞玛之锋
//TEXT=攻击力提高。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_067:MinionBase{
//NAME=猛犸人头领
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=WARRIOR|COST=4|ATK=5|HP=3|RACE=NONE
}
public class AT_068:SpellBase{
//NAME=加固
//TEXT=使你具有<b>嘲讽</b>的随从获得+2/+2。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AT_068e:Ability{
//NAME=加固
//TEXT=+2/+2。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_069:MinionBase{
//NAME=格斗陪练师
//TEXT=<b>嘲讽</b> <b>战吼：</b>使一个随从获得<b>嘲讽</b>。
//MAJ=WARRIOR|COST=2|ATK=3|HP=2|RACE=NONE
}
public class AT_069e:Ability{
//NAME=训练完成
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_070:MinionBase{
//NAME=天空上尉库拉格
//TEXT=<b>冲冲冲冲锋</b> 每有一个友方海盗，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=6|RACE=PIRATE
}
public class AT_071:MinionBase{
//NAME=阿莱克丝塔萨的勇士
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便获得+1攻击力和<b>冲锋</b>。
//MAJ=WARRIOR|COST=2|ATK=2|HP=3|RACE=NONE
}
public class AT_071e:Ability{
//NAME=阿莱克丝塔萨之赐
//TEXT=+1攻击力并获得<b>冲锋</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_072:MinionBase{
//NAME=瓦里安·乌瑞恩
//TEXT=<b>战吼：</b>抽三张牌。将抽到的随从牌直接置入战场。
//MAJ=WARRIOR|COST=10|ATK=7|HP=7|RACE=NONE
}
public class AT_073:SecretBase{
//NAME=争强好胜
//TEXT=<b>奥秘：</b>在你的回合开始时，使你的所有随从获得+1/+1。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class AT_073e:Ability{
//NAME=争强好胜
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_074:SpellBase{
//NAME=英勇圣印
//TEXT=使一个随从获得+3攻击力和 <b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class AT_074e2:Ability{
//NAME=英勇圣印
//TEXT=+3攻击力并具有<b>圣盾</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_075:MinionBase{
//NAME=战马训练师
//TEXT=你的白银之手新兵拥有+2攻击力和<b>嘲讽</b>。
//MAJ=PALADIN|COST=3|ATK=3|HP=4|RACE=NONE
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.cardDbf.m_noteMiniGuid.Contains("CS2_101t") &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "AT_075e";
    }
}
public class AT_075e:Ability{
//NAME=骑士之威
//TEXT=战马训练师使其获得+2攻击力和<b>嘲讽</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
	public override void Init()
	{
		new EffectGiveAbility(owner.myPlayer,owner,owner,"Taunt").Resolve();
	}
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 2;
        }
        return 0;
    }
}
public class AT_076:MinionBase{
//NAME=鱼人骑士
//TEXT=<b>激励：</b>随机召唤一个鱼人。
//MAJ=PALADIN|COST=4|ATK=3|HP=4|RACE=MURLOC
}
public class AT_077:WeaponBase{
//NAME=白银之枪
//TEXT=<b>战吼：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，+1耐久度。
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=NONE
}
public class AT_077e:Ability{
//NAME=额外突刺
//TEXT=+1耐久度。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_078:SpellBase{
//NAME=精英对决
//TEXT=除了每个玩家攻击力最高的随从之外，消灭所有 其他随从。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class AT_079:MinionBase{
//NAME=神秘挑战者
//TEXT=<b>战吼：</b>将每种不同的<b>奥秘</b>从你的牌库中置入战场。
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=NONE
}
public class AT_080:MinionBase{
//NAME=要塞指挥官
//TEXT=每个回合你可以使用两次英雄技能。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class AT_081:MinionBase{
//NAME=纯洁者耶德瑞克
//TEXT=<b>战吼：</b>使所有敌方随从的攻击力变为1。
//MAJ=PALADIN|COST=7|ATK=3|HP=7|RACE=NONE
}
public class AT_081e:Ability{
//NAME=被净化
//TEXT=攻击力变为1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_082:MinionBase{
//NAME=低阶侍从
//TEXT=<b>激励：</b> 获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class AT_082e:Ability{
//NAME=刻苦训练
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_083:MinionBase{
//NAME=龙鹰骑士
//TEXT=<b>激励：</b>在本回合中，获得<b>风怒</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class AT_083e:Ability{
//NAME=龙鹰骑士
//TEXT=在本回合中<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_084:MinionBase{
//NAME=持枪侍从
//TEXT=<b>战吼：</b>使一个友方随从获得+2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=NONE
}
public class AT_084e:Ability{
//NAME=装备
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_085:MinionBase{
//NAME=湖之仙女
//TEXT=你的英雄技能的法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
}
public class AT_085e:Ability{
//NAME=仙女的祝福
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_086:MinionBase{
//NAME=破坏者
//TEXT=<b>战吼：</b>下个回合敌方英雄技能的法力值消耗增加（5）点。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=NONE
}
public class AT_086e:Ability{
//NAME=邪恶之力
//TEXT=在本回合中，你的英雄技能的法力值消耗为（5）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_087:MinionBase{
//NAME=银色骑手
//TEXT=<b>冲锋</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=1|RACE=NONE
}
public class AT_088:MinionBase{
//NAME=穆戈尔的勇士
//TEXT=50%几率攻击错误的敌人。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=5|RACE=NONE
}
public class AT_089:MinionBase{
//NAME=白骨卫士军官
//TEXT=<b>激励：</b> 获得+1生命值。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=UNDEAD
}
public class AT_089e:Ability{
//NAME=白骨之盾
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_090:MinionBase{
//NAME=穆克拉的勇士
//TEXT=<b>激励：</b>使你的其他随从获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=3|RACE=BEAST
}
public class AT_090e:Ability{
//NAME=金刚之力
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_091:MinionBase{
//NAME=赛场医师
//TEXT=<b>激励：</b>为你的英雄恢复#2点生命值。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=8|RACE=NONE
}
public class AT_092:MinionBase{
//NAME=冰霜暴怒者
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=5|HP=2|RACE=ELEMENTAL
}
public class AT_093:MinionBase{
//NAME=冰冷的雪地狗头人
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
}
public class AT_094:MinionBase{
//NAME=火焰杂耍者
//TEXT=<b>战吼：</b>随机对一个敌人造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class AT_095:MinionBase{
//NAME=沉默的骑士
//TEXT=<b>潜行</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class AT_096:MinionBase{
//NAME=发条骑士
//TEXT=<b>战吼：</b>使一个友方机械获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=MECHANICAL
}
public class AT_096e:Ability{
//NAME=上紧发条
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_097:MinionBase{
//NAME=赛场观众
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class AT_098:MinionBase{
//NAME=杂耍吞法者
//TEXT=<b>战吼：</b>复制对手的英雄技能。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=5|RACE=NONE
}
public class AT_099:MinionBase{
//NAME=科多兽骑手
//TEXT=<b>激励：</b>召唤一个3/5的作战科多兽。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=5|RACE=NONE
}
public class AT_099t:MinionBase{
//NAME=作战科多兽
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=3|HP=5|RACE=BEAST
}
public class AT_100:MinionBase{
//NAME=白银之手教官
//TEXT=<b>激励：</b>召唤一个1/1的白银之手新兵。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterUseHeroPower(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			TaskCreate(CardDbf.GetCardDbfByGuid("CS2_101t"),ZoneType.Board);
		}
	}
}
public class AT_101:MinionBase{
//NAME=格斗士
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=5|HP=6|RACE=NONE
}
public class AT_102:MinionBase{
//NAME=俘获的冰虫
//TEXT=
//MAJ=NEUTRAL|COST=7|ATK=5|HP=9|RACE=BEAST
}
public class AT_103:MinionBase{
//NAME=北海海怪
//TEXT=<b>战吼：</b>造成4点伤害。
//MAJ=NEUTRAL|COST=9|ATK=9|HP=7|RACE=BEAST
}
public class AT_104:MinionBase{
//NAME=海象人龟骑士
//TEXT=<b>战吼：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，则为你的英雄恢复#7点生命值。
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=NONE
}
public class AT_105:MinionBase{
//NAME=受伤的克瓦迪尔
//TEXT=<b>战吼：</b>对自身造成3点伤害。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=4|RACE=UNDEAD
}
public class AT_106:MinionBase{
//NAME=圣光勇士
//TEXT=<b>战吼：</b> <b>沉默</b>一个恶魔。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=NONE
}
public class AT_108:MinionBase{
//NAME=重甲战马
//TEXT=<b>战吼：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，则获得<b>冲锋</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=3|RACE=BEAST
}
public class AT_109:MinionBase{
//NAME=银色警卫
//TEXT=无法攻击。 <b>激励：</b>在本回合中可正常进行攻击。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=4|RACE=NONE
}
public class AT_109e:Ability{
//NAME=士气振奋
//TEXT=在本回合中可进行攻击。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_110:MinionBase{
//NAME=角斗场主管
//TEXT=<b>激励：</b>将本随从移回你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=NONE
}
public class AT_111:MinionBase{
//NAME=零食商贩
//TEXT=<b>战吼：</b>为每个英雄恢复#4点生命值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class AT_112:MinionBase{
//NAME=大师级枪骑士
//TEXT=<b>战吼：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，则获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=6|RACE=NONE
}
public class AT_113:MinionBase{
//NAME=征募官
//TEXT=<b>激励：</b>将一个2/2的侍从置入你的手牌。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NONE
}
public class AT_114:MinionBase{
//NAME=邪灵拷问者
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=NONE
}
public class AT_115:MinionBase{
//NAME=击剑教头
//TEXT=<b>战吼：</b>你的下一个英雄技能的法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class AT_115e:Ability{
//NAME=击剑练习
//TEXT=你的英雄技能的法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_116:MinionBase{
//NAME=龙眠教官
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便获得+1攻击力和<b>嘲讽</b>。
//MAJ=PRIEST|COST=2|ATK=1|HP=4|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		if(CondHoldAnotherRace(RaceType.Dragon))
		{
			new EffectGiveAbility(owner.myPlayer,owner,owner,"Taunt").Resolve();
			new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
		}
	}
}
public class AT_116e:Ability{
//NAME=放马过来！
//TEXT=+1攻击力并具有<b>嘲讽</b>。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_117:MinionBase{
//NAME=庆典司仪
//TEXT=<b>战吼：</b>如果你控制任何具有<b>法术伤害</b>的随从，便获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=NONE
}
public class AT_117e:Ability{
//NAME=节日庆典
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_118:MinionBase{
//NAME=十字军统领
//TEXT=<b>战吼：</b> 随机将一张圣骑士牌置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class AT_119:MinionBase{
//NAME=克瓦迪尔劫掠者
//TEXT=<b>激励：</b>获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=UNDEAD
}
public class AT_119e:Ability{
//NAME=受到鼓舞
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_120:MinionBase{
//NAME=冰霜巨人
//TEXT=在本局对战中，你每使用一次英雄技能，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=10|ATK=8|HP=8|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
            {
                return -owner.myPlayer.GetTag(GameTag.CntHeroPowerUsed);
            }   
        }
        return 0;
    }
}
public class AT_121:MinionBase{
//NAME=人气选手
//TEXT=每当你使用一张具有<b>战吼</b>的牌，便获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			int cty = sc.GetTag(GameTag.CardType);
			if(cty==(int)CardType.Minion || cty==(int)CardType.Weapon)
			{
				if(sc.HasAbility("Battlecry"))
				{
					new EffectChange(owner.myPlayer,owner,owner,atkChange:1,hpChange:1).Resolve();
				}
			}
		}
	}
}
public class AT_121_G:MinionBase{
//NAME=人气选手
//TEXT=每当你使用一张具有<b>战吼</b>的牌，便获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			int cty = sc.GetTag(GameTag.CardType);
			if(cty==(int)CardType.Minion || cty==(int)CardType.Weapon)
			{
				if(sc.HasAbility("Battlecry"))
				{
					new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:2).Resolve();
				}
			}
		}
	}
}
public class AT_121e:Ability{
//NAME=信心爆棚
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_122:MinionBase{
//NAME=穿刺者戈莫克
//TEXT=<b>战吼：</b>如果你拥有至少四个其他随从，则造成4点伤害。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class AT_123:MinionBase{
//NAME=冰喉
//TEXT=<b>嘲讽，亡语：</b> 如果你的手牌中有龙牌，则对所有随从造成3点伤害。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=DRAGON
}
public class AT_124:MinionBase{
//NAME=博尔夫·碎盾
//TEXT=每当你的英雄受到伤害，改为由本随从承担。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=9|RACE=NONE
}
public class AT_125:MinionBase{
//NAME=冰吼
//TEXT=<b>冲锋</b> 无法攻击英雄。
//MAJ=NEUTRAL|COST=9|ATK=10|HP=10|RACE=NONE
}
public class AT_127:MinionBase{
//NAME=虚灵勇士萨兰德
//TEXT=<b>激励：</b>随机将一张法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=NONE
}
public class AT_128:MinionBase{
//NAME=骷髅骑士
//TEXT=<b>亡语：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，则将骷髅骑士移回你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=7|HP=4|RACE=UNDEAD
}
public class AT_129:MinionBase{
//NAME=光明邪使菲奥拉
//TEXT=每当<b>你</b>以本随从为目标施放一个法术时，获得<b><b>圣盾</b>。</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=UNDEAD
}
public class AT_130:MinionBase{
//NAME=破海者
//TEXT=当你抽到该牌时，对你的随从造成 1点伤害。
//MAJ=WARRIOR|COST=6|ATK=6|HP=7|RACE=UNDEAD
}
public class AT_131:MinionBase{
//NAME=黑暗邪使艾蒂丝
//TEXT=每当<b>你</b>以本随从为目标施放一个法术时，随机对一个敌人造成3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=UNDEAD
}
public class AT_132:MinionBase{
//NAME=裁决者图哈特
//TEXT=<b>战吼：</b>以更强的英雄技能来替换你的初始英雄技能。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=4|RACE=NONE
}
public class AT_132_DRUIDa:HeroPowerBase{
//NAME=恐怖变形
//TEXT=<b>英雄技能</b> 本回合+$a2攻击力。+$d2护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AT_132_DRUIDb:HeroPowerBase{
//NAME=恐怖变形
//TEXT=<b>英雄技能</b> 本回合+$a2攻击力。+$d2护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AT_132_DRUIDc:HeroPowerBase{
//NAME=恐怖变形
//TEXT=<b>英雄技能</b> 本回合+$a2攻击力。+$d2护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AT_132_DRUIDe:Ability{
//NAME=恐怖利爪
//TEXT=在本回合中，+2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_132_HUNTER_H1:HeroPowerBase{
//NAME=弩炮射击
//TEXT=<b>英雄技能</b> 对敌方英雄造成$3点伤害。0<b>英雄技能</b> 造成$3点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AT_132_ROGUE_H1:HeroPowerBase{
//NAME=浸毒匕首
//TEXT=<b>英雄技能</b> 装备一把2/2的 匕首。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AT_132_ROGUEt:WeaponBase{
//NAME=浸毒匕首
//TEXT=
//MAJ=ROGUE|COST=1|ATK=2|HP=2|RACE=NONE
}
public class AT_132_ROGUEt_H1:WeaponBase{
//NAME=浸毒匕首
//TEXT=
//MAJ=ROGUE|COST=1|ATK=2|HP=2|RACE=NONE
}
public class AT_132_SHAMANa:MinionBase{
//NAME=治疗图腾
//TEXT=在你的回合结束时，为所有友方随从恢复#1点生命值。
//MAJ=SHAMAN|COST=1|ATK=0|HP=2|RACE=NONE
}
public class AT_132_SHAMANb:MinionBase{
//NAME=灼热图腾
//TEXT=
//MAJ=SHAMAN|COST=1|ATK=1|HP=1|RACE=NONE
}
public class AT_132_SHAMANc:MinionBase{
//NAME=石爪图腾
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=1|ATK=0|HP=2|RACE=NONE
}
public class AT_132_SHAMANd:MinionBase{
//NAME=空气之怒图腾
//TEXT=<b>法术伤害+1</b>
//MAJ=SHAMAN|COST=1|ATK=0|HP=2|RACE=NONE
}
public class AT_132_SHAMANe:MinionBase{
//NAME=力量图腾
//TEXT=在你的回合结束时，使另一个友方随从获得+1攻击力。
//MAJ=SHAMAN|COST=1|ATK=0|HP=2|RACE=NONE
}
public class AT_132_WARLOCKa:HeroPowerBase{
//NAME=灵魂分流
//TEXT=<b>英雄技能</b> 抽一张牌。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AT_132_WARLOCKb:HeroPowerBase{
//NAME=灵魂分流
//TEXT=<b>英雄技能</b> 抽一张牌。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class AT_133:MinionBase{
//NAME=加基森枪骑士
//TEXT=<b>战吼：</b>揭示双方牌库里的一张随从牌。如果你的牌法力值消耗较大，则获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class AT_133e:Ability{
//NAME=胜利！
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class AT_COIN:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
