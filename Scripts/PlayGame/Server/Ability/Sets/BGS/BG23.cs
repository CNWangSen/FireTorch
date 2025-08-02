using System.Collections;
using System.Collections.Generic;

public class BG23_000:MinionBase{
//NAME=迷你侍从
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NAGA
}
public class BG23_000_G:MinionBase{
//NAME=迷你侍从
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+4攻击力。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=6|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_000_Ge:Ability{
//NAME=迷你三叉戟
//TEXT=直到下个回合，+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_000_Gt:SpellBase{
//NAME=迷你三叉戟
//TEXT=直到下个回合，使一个随从获得+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_000e:Ability{
//NAME=迷你三叉戟
//TEXT=直到下个回合，+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_000t:SpellBase{
//NAME=迷你三叉戟
//TEXT=直到下个回合，使一个随从获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_001:MinionBase{
//NAME=蜗牛骑兵
//TEXT=每回合一次：当你施放法术时，获得+2生命值。
//MAJ=NEUTRAL|COST=1|ATK=5|HP=2|RACE=NAGA
}
public class BG23_001_G:MinionBase{
//NAME=蜗牛骑兵
//TEXT=每回合一次：当你施放法术时，获得+4生命值。
//MAJ=NEUTRAL|COST=1|ATK=10|HP=4|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_001_Ge:Ability{
//NAME=黏滑
//TEXT=+4生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_001e:Ability{
//NAME=黏滑
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_002:MinionBase{
//NAME=贝类收藏家
//TEXT=<b>战吼：</b>获取一张铸币牌。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=3|RACE=NAGA
}
public class BG23_002_G:MinionBase{
//NAME=贝类收藏家
//TEXT=<b>战吼：</b>获取2张铸币牌。
//MAJ=NEUTRAL|COST=1|ATK=8|HP=6|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_003:MinionBase{
//NAME=小动物照管员
//TEXT=每当你对一个随从施放法术时，使其获得+1/+2。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=7|RACE=NAGA
}
public class BG23_003_G:MinionBase{
//NAME=小动物照管员
//TEXT=每当你对一个随从施放法术时，使其获得+2/+4。
//MAJ=NEUTRAL|COST=5|ATK=10|HP=14|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_003_Ge:Ability{
//NAME=释放
//TEXT=+2/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_003e:Ability{
//NAME=释放
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_004:MinionBase{
//NAME=深海钓客
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+2生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NAGA
}
public class BG23_004_G:MinionBase{
//NAME=深海钓客
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+4生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=4|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_004_Ge:Ability{
//NAME=钓客的诱饵
//TEXT=直到下个回合，+4生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_004_Gt:SpellBase{
//NAME=钓客的诱饵
//TEXT=直到下个回合，使一个随从获得+4生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_004e:Ability{
//NAME=钓客的诱饵
//TEXT=直到下个回合，+2生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_004t:SpellBase{
//NAME=钓客的诱饵
//TEXT=直到下个回合，使一个随从获得+2生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_005:MinionBase{
//NAME=雷鳞海妖
//TEXT=在你的回合结束时，你对你的<b>塑造法术</b>随从施放其法术。
//MAJ=NEUTRAL|COST=1|ATK=6|HP=5|RACE=NAGA
}
public class BG23_005_G:MinionBase{
//NAME=雷鳞海妖
//TEXT=在你的回合结束时，你对你的<b>塑造法术</b>随从施放其法术，触发两次。
//MAJ=NEUTRAL|COST=1|ATK=12|HP=10|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_006:MinionBase{
//NAME=鳗缚弓箭手
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+8攻击力。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=4|RACE=NAGA
}
public class BG23_006_G:MinionBase{
//NAME=鳗缚弓箭手
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+16攻击力。
//MAJ=NEUTRAL|COST=1|ATK=8|HP=8|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_006_Ge:Ability{
//NAME=释放电力
//TEXT=直到下个回合，+16攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_006_Gt:SpellBase{
//NAME=放电
//TEXT=直到下个回合，使一个随从获得+16攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_006e:Ability{
//NAME=释放电力
//TEXT=直到下个回合，+8攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_006t:SpellBase{
//NAME=放电
//TEXT=直到下个回合，使一个随从获得+8攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_007:MinionBase{
//NAME=乘波骑士
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+2/+2和<b>风怒</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=8|RACE=NAGA
}
public class BG23_007_G:MinionBase{
//NAME=乘波骑士
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+4/+4和<b>风怒</b>。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=16|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_007_Ge:Ability{
//NAME=海底坐骑
//TEXT=直到下个回合，获得+4/+4和<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_007_Gt:SpellBase{
//NAME=海底坐骑
//TEXT=直到下个回合，使一个随从获得+4/+4和<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_007e:Ability{
//NAME=海底坐骑
//TEXT=直到下个回合，获得+2/+2和<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_007t:SpellBase{
//NAME=海底坐骑
//TEXT=直到下个回合，使一个随从获得+2/+2和<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_008:MinionBase{
//NAME=闪鳞纳迦
//TEXT=<b>嘲讽</b>，<b>塑造法术：</b>直到下个回合，使一个随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=6|RACE=NAGA
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class BG23_008_G:MinionBase{
//NAME=闪鳞纳迦
//TEXT=<b>嘲讽</b>，<b>塑造法术：</b>直到下个回合，使一个随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=1|ATK=8|HP=12|RACE=NAGA
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskSetGolden();
	}
}
public class BG23_008_Ge:Ability{
//NAME=闪鳞头冠
//TEXT=直到下个回合，获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_008_Gt:SpellBase{
//NAME=闪鳞头冠
//TEXT=直到下个回合，使一个随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_008e:Ability{
//NAME=闪鳞头冠
//TEXT=直到下个回合，获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_008t:SpellBase{
//NAME=闪鳞头冠
//TEXT=直到下个回合，使一个随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_009:MinionBase{
//NAME=熔岩潜伏者
//TEXT=每回合施放在本随从身上的第一个<b>塑造法术</b>附加效果永久有效。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=5|RACE=NAGA
}
public class BG23_009_G:MinionBase{
//NAME=熔岩潜伏者
//TEXT=每回合施放在本随从身上的前两个<b>塑造法术</b>附加效果永久有效。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=10|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_010:MinionBase{
//NAME=日暮蛮兵
//TEXT=每当你施放一个法术，便获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=3|RACE=NAGA
}
public class BG23_010_G:MinionBase{
//NAME=日暮蛮兵
//TEXT=每当你施放一个法术，便获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=6|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_010_Ge:Ability{
//NAME=藤壶加身
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_010e:Ability{
//NAME=藤壶加身
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_011:MinionBase{
//NAME=滩头指挥官
//TEXT=<b>塑造法术：</b>直到下个回合，每有一个友方纳迦，使一个随从获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NAGA
}
public class BG23_011_G:MinionBase{
//NAME=滩头指挥官
//TEXT=<b>塑造法术：</b>直到下个回合，每有一个友方纳迦，使一个随从获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_011_Ge:Ability{
//NAME=抢滩猛攻
//TEXT=直到下个回合，属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_011_Gt:SpellBase{
//NAME=抢滩猛攻
//TEXT=直到下个回合，每有一个友方纳迦，使一个随从获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_011e:Ability{
//NAME=抢滩猛攻
//TEXT=直到下个回合，属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_011t:SpellBase{
//NAME=抢滩猛攻
//TEXT=直到下个回合，每有一个友方纳迦，使一个随从获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_012:MinionBase{
//NAME=已腐蚀的侍从
//TEXT=<b>战斗开始时：</b>本随从的属性值翻倍。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=3|RACE=NAGA
	public override void OnCombatStart()
	{
		new EffectChange(owner.myPlayer,owner,owner,atkChange:owner.GetTag(GameTag.Attack),hpChange:owner.GetTag(GameTag.Health)).Resolve();
	}
}
public class BG23_012_G:MinionBase{
//NAME=已腐蚀的侍从
//TEXT=<b>战斗开始时：</b>本随从的属性值变为三倍。
//MAJ=NEUTRAL|COST=1|ATK=6|HP=6|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void OnCombatStart()
	{
		new EffectChange(owner.myPlayer,owner,owner,atkChange:owner.GetTag(GameTag.Attack)*2,hpChange:2*owner.GetTag(GameTag.Health)).Resolve();
	}
}
public class BG23_012_Ge:Ability{
//NAME=腐蚀
//TEXT=属性值变为三倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_012e:Ability{
//NAME=腐蚀
//TEXT=属性值翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_013:MinionBase{
//NAME=潮汐主母阿茜萨
//TEXT=每当你施放一个法术，使四个友方纳迦获得+1/+1。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=8|RACE=NAGA
}
public class BG23_013_G:MinionBase{
//NAME=潮汐主母阿茜萨
//TEXT=每当你施放一个法术，使四个友方纳迦获得+2/+2。
//MAJ=NEUTRAL|COST=6|ATK=12|HP=16|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_013_Ge:Ability{
//NAME=照耀
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_013e:Ability{
//NAME=照耀
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_014:MinionBase{
//NAME=复仇者帕什玛
//TEXT=<b>复仇（3）：</b>获取一张你当前或更低等级的<b>塑造法术</b>的法术牌。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=5|RACE=NAGA
}
public class BG23_014_G:MinionBase{
//NAME=复仇者帕什玛
//TEXT=<b>复仇（3）：</b>获取2张你当前或更低等级的<b>塑造法术</b>的法术牌。
//MAJ=NEUTRAL|COST=1|ATK=8|HP=10|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_015:MinionBase{
//NAME=照看者奥戈佐亚
//TEXT=<b>塑造法术：发现</b>一张纳迦牌。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=7|RACE=NONE
}
public class BG23_015_G:MinionBase{
//NAME=照看者奥戈佐亚
//TEXT=<b>塑造法术：发现</b>2张纳迦牌。
//MAJ=NEUTRAL|COST=1|ATK=6|HP=14|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_015_Gt:SpellBase{
//NAME=艾萨拉的孵化场
//TEXT=<b>发现</b>2张纳迦牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_015t:SpellBase{
//NAME=艾萨拉的孵化场
//TEXT=<b>发现</b>一张纳迦牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG23_016:MinionBase{
//NAME=海礁探险者
//TEXT=<b>战吼：发现</b>你尚未控制的一个类型的一张随从牌。
//MAJ=NEUTRAL|COST=0|ATK=3|HP=3|RACE=NONE
}
public class BG23_016_G:MinionBase{
//NAME=海礁探险者
//TEXT=<b>战吼：发现</b>你尚未控制的一个类型的2张随从牌。
//MAJ=NEUTRAL|COST=0|ATK=6|HP=6|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_017:MinionBase{
//NAME=鲜血勇士
//TEXT=<b>战吼，亡语：</b>在本局对战中，你的<b>鲜血宝石</b>使随从额外获得+1/+1。
//MAJ=NEUTRAL|COST=7|ATK=18|HP=3|RACE=QUILBOAR
}
public class BG23_017_G:MinionBase{
//NAME=鲜血勇士
//TEXT=<b>战吼，亡语：</b>在本局对战中，你的<b>鲜血宝石</b>使随从额外获得+2/+2。
//MAJ=NEUTRAL|COST=7|ATK=36|HP=6|RACE=QUILBOAR
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_018:MinionBase{
//NAME=暗视长者
//TEXT=在你花掉5枚铸币后，对四个友方野猪人各使用一张<b>鲜血宝石</b>。<i>（还剩5枚！）</i>
//MAJ=NEUTRAL|COST=0|ATK=6|HP=7|RACE=QUILBOAR
}
public class BG23_018_G:MinionBase{
//NAME=暗视长者
//TEXT=在你花掉5枚铸币后，对四个友方野猪人各使用一张<b>鲜血宝石</b>，触发两次。<i>（还剩5枚！）</i>
//MAJ=NEUTRAL|COST=0|ATK=12|HP=14|RACE=QUILBOAR
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_018t:SpellBase{
//NAME=Darkgaze Mass Blood Gem
//TEXT=Give certain friendly minions +{0}/+{1}.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_190:MinionBase{
//NAME=光明使者乌瑟尔
//TEXT=<b>战吼：</b> 将一个随从的攻击力和生命值变为15。
//MAJ=NEUTRAL|COST=0|ATK=5|HP=6|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		Card ToBuff = owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:15-ToBuff.GetTag(GameTag.Attack),hpChange:15-ToBuff.GetTag(GameTag.Health)).Resolve();
		}
	}
}
public class BG23_190_G:MinionBase{
//NAME=光明使者乌瑟尔
//TEXT=<b>战吼：</b> 将一个随从的攻击力和生命值变为30。
//MAJ=NEUTRAL|COST=0|ATK=10|HP=12|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_190_Ge:Ability{
//NAME=光明
//TEXT=攻击力和生命值为30。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_190e:Ability{
//NAME=光明
//TEXT=攻击力和生命值为15。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_192:MinionBase{
//NAME=大副皮普
//TEXT=本随从仅需2个复制即可变为金色。
//MAJ=NEUTRAL|COST=0|ATK=5|HP=4|RACE=PIRATE
}
public class BG23_192_G:MinionBase{
//NAME=大副皮普
//TEXT=<i>（本随从仅需2个复制即变为了金色。）</i>
//MAJ=NEUTRAL|COST=0|ATK=10|HP=8|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_318:MinionBase{
//NAME=莽神火车王
//TEXT=<b>亡语：</b>消灭击杀本随从的随从。
//MAJ=NEUTRAL|COST=0|ATK=6|HP=2|RACE=NONE
	public override int BeforeTakeDamage(Card source,int amount)
	{
		Hate = source;
		return amount;
	}
	private Card Hate=null;
	public override void Deathrattle()
	{
		if(Hate!=null)
		{
			if(Hate.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
			{
				new EffectDestroy(owner.myPlayer,owner,Hate).Resolve();
				//new EffectDestroy(owner.myPlayer,owner,Hate).Resole();
			}
		}
	}
}
public class BG23_318_G:MinionBase{
//NAME=莽神火车王
//TEXT=<b>亡语：</b>消灭击杀本随从的随从。
//MAJ=NEUTRAL|COST=0|ATK=12|HP=4|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
		//owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
	public override int BeforeTakeDamage(Card source,int amount)
	{
		Hate = source;
		return amount;
	}
	private Card Hate=null;
	public override void Deathrattle()
	{
		//UnityEngine.Debug.Log("Fuck!!!");
		if(Hate!=null)
		{
			if(Hate.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
			{
				new EffectDestroy(owner.myPlayer,owner,Hate).Resolve();
				//new EffectDestroy(owner.myPlayer,owner,Hate).Resole();
			}
		}
	}
}
public class BG23_350:MinionBase{
//NAME=伊瑞尔
//TEXT=在本随从攻击后，使每个类型的各一个友方随从获得+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=1|HP=4|RACE=NONE
	public override void AfterAttack(Card target=null)
	{
		TaskBuffTargets(owner.myPlayer.board,atk:1,hp:2);
	}
}
public class BG23_350_G:MinionBase{
//NAME=伊瑞尔
//TEXT=在本随从攻击后，使每个类型的各一个友方随从获得+2/+4。
//MAJ=NEUTRAL|COST=0|ATK=2|HP=8|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void AfterAttack(Card target=null)
	{
		TaskBuffTargets(owner.myPlayer.board,atk:2,hp:4);
	}
}
public class BG23_350_Ge:Ability{
//NAME=圣光之缚
//TEXT=+2/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_350e:Ability{
//NAME=圣光之缚
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_352:MinionBase{
//NAME=小费酒客
//TEXT=在你的回合结束时，如果你有未花费的铸币，获得+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=2|HP=2|RACE=NONE
}
public class BG23_352_G:MinionBase{
//NAME=小费酒客
//TEXT=在你的回合结束时，如果你有未花费的铸币，获得+2/+4。
//MAJ=NEUTRAL|COST=0|ATK=4|HP=4|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_352_Ge:Ability{
//NAME=小费
//TEXT=+2/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_352e:Ability{
//NAME=小费
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_353:MinionBase{
//NAME=宝藏追寻者伊莉斯
//TEXT=在你<b>刷新</b>5次后，找到<b>黄金</b>猿！<i>（还剩5次！）</i>
//MAJ=NEUTRAL|COST=0|ATK=5|HP=5|RACE=NONE
}
public class BG23_353_G:MinionBase{
//NAME=宝藏追寻者伊莉斯
//TEXT=在你<b>刷新</b>5次后，找到两尊<b>黄金</b>猿！<i>（还剩5次！）</i>
//MAJ=NEUTRAL|COST=0|ATK=10|HP=10|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_353_Gt:MinionBase{
//NAME=黄金猿
//TEXT=<b>嘲讽</b> <i>（你找到啦！）</i>
//MAJ=NEUTRAL|COST=0|ATK=6|HP=6|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}
}
public class BG23_357:MinionBase{
//NAME=心灵泥魔
//TEXT=<b>战吼：</b>选择一个友方恶魔，使其吞食酒馆中的一个随从，获得其属性值。
//MAJ=NEUTRAL|COST=0|ATK=3|HP=2|RACE=DEMON
}
public class BG23_357_G:MinionBase{
//NAME=心灵泥魔
//TEXT=<b>战吼：</b>选择一个友方恶魔，使其吞食酒馆中的一个随从，获得其双倍属性值。
//MAJ=NEUTRAL|COST=0|ATK=6|HP=4|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_357e:Ability{
//NAME=心灵泥浆
//TEXT=吞食了随从的属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_361:MinionBase{
//NAME=军团监工
//TEXT=酒馆中的随从拥有+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=4|HP=2|RACE=DEMON
}
public class BG23_361_G:MinionBase{
//NAME=军团监工
//TEXT=酒馆中的随从拥有+4/+2。
//MAJ=NEUTRAL|COST=0|ATK=8|HP=4|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_361e:Ability{
//NAME=监熬美味
//TEXT=军团监工使其属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_362:MinionBase{
//NAME=艾卓曼德斯
//TEXT=每当本随从攻击时，对目标及其相邻随从造成3点伤害。
//MAJ=NEUTRAL|COST=0|ATK=3|HP=6|RACE=DRAGON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackBeforeAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc==owner)
			{
				List<Card> ToListDamage = FindAdj(tc);
				ToListDamage.Add(tc);
				TaskDamageTargets(ToListDamage,3);
			}
		}
	}
}
public class BG23_362_G:MinionBase{
//NAME=艾卓曼德斯
//TEXT=每当本随从攻击时，对目标及其相邻随从造成3点伤害，触发两次。
//MAJ=NEUTRAL|COST=0|ATK=6|HP=12|RACE=DRAGON
	public override void Init()
	{
		owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackBeforeAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc==owner)
			{
				List<Card> ToListDamage = FindAdj(tc);
				ToListDamage.Add(tc);
				TaskDamageTargets(ToListDamage,3);
				
				ToListDamage = FindAdj(tc);
				ToListDamage.Add(tc);
				TaskDamageTargets(ToListDamage,3);
			}
		}
	}
}
public class BG23_HERO_201:HeroBase{
//NAME=厄祖玛特
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_201_Buddy:MinionBase{
//NAME=塔穆佐
//TEXT=<b>复仇（2）：</b>使“触须”技能获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=BEAST
}
public class BG23_HERO_201_Buddy_G:MinionBase{
//NAME=塔穆佐
//TEXT=<b>复仇（2）：</b>使“触须”技能获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=8|HP=8|RACE=BEAST
	public override void Init()
	{
		owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
}
public class BG23_HERO_201_SKIN_A:HeroBase{
//NAME=冰川恐魔厄祖玛特
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_201_SKIN_B:HeroBase{
//NAME=水中战将厄祖玛特
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_201p:HeroPowerBase{
//NAME=触须
//TEXT=<b>被动：</b> 在战斗中，当你有空位时，召唤一条1/1并具有<b>嘲讽</b>的触须。<i>（在你出售一个随从后获得+1/+1！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_HERO_201pt:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class BG23_HERO_201pt2:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class BG23_HERO_201pt2_G:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=BEAST
	public override void Init()
	{
		TaskInitAbility("Taunt");
		owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
}
public class BG23_HERO_201pt3:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class BG23_HERO_201pt3_G:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=BEAST
}
public class BG23_HERO_201pt4:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class BG23_HERO_201pt4_G:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=BEAST
}
public class BG23_HERO_201pt5:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class BG23_HERO_201pt5_G:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=BEAST
}
public class BG23_HERO_201pt6:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class BG23_HERO_201pt6_G:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=BEAST
}
public class BG23_HERO_201pt_G:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=BEAST
}
public class BG23_HERO_201pt_SKIN_A:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class BG23_HERO_201pt_SKIN_A_G:MinionBase{
//NAME=厄祖玛特的触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=BEAST
}
public class BG23_HERO_303:HeroBase{
//NAME=摩洛克·福尔摩斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_303_Buddy:MinionBase{
//NAME=蛙生
//TEXT=在你用“特邀侦探”猜中随从后，获取一张猜中的随从的原始版复制。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=BEAST
}
public class BG23_HERO_303_Buddy_G:MinionBase{
//NAME=蛙生
//TEXT=在你用“特邀侦探”猜中随从后，获取2张猜中的随从的原始版复制。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=10|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_HERO_303_SKIN_A:HeroBase{
//NAME=哲学家福尔摩斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_303_SKIN_B:HeroBase{
//NAME=警长福尔摩斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_303p2:HeroPowerBase{
//NAME=特邀侦探
//TEXT=检视2个随从。猜中来自你下一个对手的上一场战斗的随从，即可获得一张铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_HERO_303pt:MinionBase{
//NAME=没有随从
//TEXT=<i>（你猜对手在上一场战斗中没有随从。）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class BG23_HERO_304:HeroBase{
//NAME=瓦丝琪女士
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_304_Buddy:MinionBase{
//NAME=盘牙精英
//TEXT=在一个<b>塑造法术</b>随从出现在酒馆中后，获取其法术的一张复制。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NAGA
}
public class BG23_HERO_304_Buddy_G:MinionBase{
//NAME=盘牙精英
//TEXT=在一个<b>塑造法术</b>随从出现在酒馆中后，获取其法术的2张复制。
//MAJ=NEUTRAL|COST=2|ATK=6|HP=4|RACE=NAGA
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_HERO_304_SKIN_A:HeroBase{
//NAME=瓦丝琪女男爵
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_304_SKIN_B:HeroBase{
//NAME=蛇语者瓦丝琪
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_304_SKIN_C:HeroBase{
//NAME=多面乐手瓦丝琪
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_304_SKIN_D:HeroBase{
//NAME=蛇发女妖瓦丝琪
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_304p:HeroPowerBase{
//NAME=深海遗物
//TEXT=<b>发现</b>一张你当前或更低等级的<b>塑造法术</b>的法术牌，其效果永久有效。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BG23_HERO_305:HeroBase{
//NAME=劫匪之王托瓦格尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_305_Buddy:MinionBase{
//NAME=垂滴的蜡烛巨龙
//TEXT=<b>战吼：刷新</b>酒馆，使其中的随从变为每个对手的战队中等级最高的随从。
//MAJ=NEUTRAL|COST=4|ATK=7|HP=5|RACE=DRAGON
}
public class BG23_HERO_305_Buddy_G:MinionBase{
//NAME=垂滴的蜡烛巨龙
//TEXT=<b>战吼：刷新</b>酒馆，使其中的随从变为每个对手的战队中等级最高的随从。
//MAJ=NEUTRAL|COST=4|ATK=14|HP=10|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_HERO_305_SKIN_A:HeroBase{
//NAME=图书之王托瓦格尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_305_SKIN_B:HeroBase{
//NAME=火花囤积者托瓦格尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_305_SKIN_C:HeroBase{
//NAME=大巫妖托瓦格尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_305_SKIN_D:HeroBase{
//NAME=金库大盗托瓦格尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_305p:HeroPowerBase{
//NAME=完美犯罪
//TEXT=偷取酒馆中的所有牌。每个回合，你的下一个英雄技能消耗的铸币减少（1）枚。
//MAJ=NEUTRAL|COST=11|ATK=0|HP=0|RACE=NONE
}
public class BG23_HERO_306:HeroBase{
//NAME=希尔瓦娜斯·风行者
//TEXT=不要妄想邀请她一起游泳。女王绝不沉浮。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG23_HERO_306_Buddy:MinionBase{
//NAME=纳萨诺斯·凋零者
//TEXT=<b>战吼：</b>移除一个友方随从。使其相邻随从获得其属性值。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=UNDEAD
}
public class BG23_HERO_306_Buddy_e:Ability{
//NAME=凋零之召
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_HERO_306_Buddy_G:MinionBase{
//NAME=纳萨诺斯·凋零者
//TEXT=<b>战吼：</b>移除一个友方随从。使其相邻随从获得其双倍属性值。
//MAJ=NEUTRAL|COST=6|ATK=12|HP=12|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG23_HERO_306e:Ability{
//NAME=灌注灵魂
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG23_HERO_306p:HeroPowerBase{
//NAME=重拾灵魂
//TEXT=使你在上一场战斗中死亡的随从获得+2/+1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BG23_Spellcraft_e:Ability{
//NAME=Spellcraft In-Hand Ench [DNT]
//TEXT=Attachment is discarded at end of turn. [DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
