using System.Collections;
using System.Collections.Generic;

public class BG24_001:MinionBase{
//NAME=花岗岩守护者
//TEXT=<b>嘲讽</b>。每当本随从被攻击时，将攻击者的生命值降为1。
//MAJ=NEUTRAL|COST=7|ATK=1|HP=28|RACE=ELEMENTAL
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void BeforeAttacked(Card source = null)
	{
		new EffectChange(owner.myPlayer,owner,source,hpChange:1-source.GetTag(GameTag.Health)).Resolve();
	}
}
public class BG24_001_G:MinionBase{
//NAME=花岗岩守护者
//TEXT=<b>嘲讽</b>。每当本随从被攻击时，将攻击者的生命值降为1。
//MAJ=NEUTRAL|COST=7|ATK=2|HP=56|RACE=ELEMENTAL
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}
	public override void BeforeAttacked(Card source = null)
	{
		new EffectChange(owner.myPlayer,owner,source,hpChange:1-source.GetTag(GameTag.Health)).Resolve();
	}
}
public class BG24_001e:Ability{
//NAME=破碎
//TEXT=生命值降为1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_003:MinionBase{
//NAME=虚空幼龙
//TEXT=在你的回合结束时，使你的其他龙获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=2|HP=4|RACE=DRAGON
}
public class BG24_003_G:MinionBase{
//NAME=虚空幼龙
//TEXT=在你的回合结束时，使你的其他龙获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=4|HP=8|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG24_003_Ge:Ability{
//NAME=再入虚空
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_003e:Ability{
//NAME=再入虚空
//TEXT=+1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_004:MinionBase{
//NAME=折跃之翼
//TEXT=攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=0|ATK=12|HP=4|RACE=DRAGON
	public override void BeforeAttack(Card target)
	{
		new EffectGiveAbility(owner.myPlayer,owner,owner,"Immue").Resolve();
	}
	public override void AfterAttack(Card target)
	{
		new EffectRemoveAbility(owner.myPlayer,owner,owner,"Immue").Resolve();
	}
}
public class BG24_004_G:MinionBase{
//NAME=折跃之翼
//TEXT=攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=0|ATK=24|HP=8|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void BeforeAttack(Card target)
	{
		new EffectGiveAbility(owner.myPlayer,owner,owner,"Immue").Resolve();
	}
	public override void AfterAttack(Card target)
	{
		new EffectRemoveAbility(owner.myPlayer,owner,owner,"Immue").Resolve();
	}
}
public class BG24_005:MinionBase{
//NAME=罪奔者布兰契
//TEXT=<b>复生</b>。本随从<b>复生</b>时会具有所有生命值和附加效果。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Reborn");
	}
}
public class BG24_005_G:MinionBase{
//NAME=罪奔者布兰契
//TEXT=<b>复生</b>。本随从<b>复生</b>时会具有所有生命值和附加效果。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=8|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Reborn");
		TaskSetGolden();
	}
}
public class BG24_005e2:Ability{
//NAME=Reborn Removed
//TEXT=<b>Reborn</b> has been removed.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_008:MinionBase{
//NAME=齿驱扑翼机
//TEXT=<b>圣盾</b> 在一个友方随从失去<b>圣盾</b>后，使你手牌中的一张随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("DivineShield");
	}
}
public class BG24_008_G:MinionBase{
//NAME=齿驱扑翼机
//TEXT=<b>圣盾</b> 在一个友方随从失去<b>圣盾</b>后，使你手牌中的一张随从牌获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("DivineShield");
	}
}
public class BG24_008_Ge:Ability{
//NAME=齿轮驱动
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_008e:Ability{
//NAME=齿轮驱动
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_009:MinionBase{
//NAME=挑食魔犬
//TEXT=<b>战吼：</b>随机吞食酒馆中的一个随从，获得其属性值。
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=DEMON
}
public class BG24_009_G:MinionBase{
//NAME=挑食魔犬
//TEXT=<b>战吼：</b>随机吞食酒馆中的一个随从，获得其双倍属性值。
//MAJ=NEUTRAL|COST=0|ATK=2|HP=2|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG24_009e:Ability{
//NAME=吞吃客人
//TEXT=吞食了随从的属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_012:MinionBase{
//NAME=奔波尔霸
//TEXT=<b>战吼：</b>你每控制一个鱼人，使一个友方鱼人获得+3/+3。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=3|RACE=MURLOC
}
public class BG24_012_G:MinionBase{
//NAME=奔波尔霸
//TEXT=<b>战吼：</b>你每控制一个鱼人，使一个友方鱼人获得+6/+6。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG24_012e:Ability{
//NAME=泡泡武装
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_017:MinionBase{
//NAME=随从滚球
//TEXT=当你出售本随从时，随机使一个友方随从获得本随从的属性值。
//MAJ=NEUTRAL|COST=0|ATK=5|HP=5|RACE=ALL
}
public class BG24_017_G:MinionBase{
//NAME=随从滚球
//TEXT=当你出售本随从时，随机使两个友方随从获得本随从的属性值。
//MAJ=NEUTRAL|COST=0|ATK=10|HP=10|RACE=ALL
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG24_017e:Ability{
//NAME=抱团打滚
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_018:MinionBase{
//NAME=蓝壳始祖龟
//TEXT=如果你输掉了上一场战斗，出售本随从可以获得5枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=4|HP=7|RACE=NONE
}
public class BG24_018_G:MinionBase{
//NAME=蓝壳始祖龟
//TEXT=如果你输掉了上一场战斗，出售本随从可以获得10枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=8|HP=14|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG24_020:MinionBase{
//NAME=茶水大师西塔尔
//TEXT=在你使用没有类型的随从牌后，使3个不同类型的友方随从获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=6|HP=6|RACE=NONE
}
public class BG24_020_G:MinionBase{
//NAME=茶水大师西塔尔
//TEXT=在你使用没有类型的随从牌后，使3个不同类型的友方随从获得+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=12|HP=12|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG24_020_Ge:Ability{
//NAME=饮茶时间
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_020e:Ability{
//NAME=饮茶时间
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_022:MinionBase{
//NAME=谋略大师伦德尔
//TEXT=在你的回合结束时，偷取酒馆中等级最高的牌。
//MAJ=NEUTRAL|COST=0|ATK=4|HP=5|RACE=NONE
}
public class BG24_022_G:MinionBase{
//NAME=谋略大师伦德尔
//TEXT=在你的回合结束时，偷取酒馆中等级最高的2张牌。
//MAJ=NEUTRAL|COST=0|ATK=8|HP=10|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG24_023:MinionBase{
//NAME=戒卫石裔魔
//TEXT=<b>战吼：</b>使一个随从获得+6生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=2|HP=6|RACE=NONE
}
public class BG24_023_G:MinionBase{
//NAME=戒卫石裔魔
//TEXT=<b>战吼：</b>使一个随从获得+12生命值和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=4|HP=12|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG24_023_Ge:Ability{
//NAME=石盾
//TEXT=+12生命值并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_023e:Ability{
//NAME=石盾
//TEXT=+6生命值并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_300:MinionBase{
//NAME=瞌睡雏龙
//TEXT=<b><b>嘲讽</b></b>。每当本随从受到攻击时，永久获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=3|RACE=DRAGON
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void BeforeAttacked(Card source)
	{
		new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
	}
}
public class BG24_300_G:MinionBase{
//NAME=瞌睡雏龙
//TEXT=<b><b>嘲讽</b></b>。每当本随从受到攻击时，永久获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=6|RACE=DRAGON
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskSetGolden();
	}
	public override void BeforeAttacked(Card source)
	{
		new EffectChange(owner.myPlayer,owner,owner,atkChange:2).Resolve();
	}
}
public class BG24_300_Ge:Ability{
//NAME=惊醒
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_300e:Ability{
//NAME=惊醒
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_500:MinionBase{
//NAME=琥珀卫士
//TEXT=<b>战斗开始时：</b>使另一条友方的龙获得+7/+7和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=3|ATK=7|HP=7|RACE=DRAGON
	public override void OnCombatStart()
	{
		Card ToBuff = FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Dragon).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:7,hpChange:7).Resolve();
			new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"DivineShield").Resolve();
		}
	}
}
public class BG24_500_G:MinionBase{
//NAME=琥珀卫士
//TEXT=<b>战斗开始时：</b>使两条其他友方的龙获得+7/+7和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=3|ATK=14|HP=14|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void OnCombatStart()
	{
		Card ToBuff = FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Dragon).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:7,hpChange:7).Resolve();
			new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"DivineShield").Resolve();
		}
		Card ToBuff2 = FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Dragon).Choice(owner.myPlayer.randomGen);
		if(ToBuff2!=null)
		{
			new EffectChange(owner.myPlayer,owner,ToBuff2,atkChange:7,hpChange:7).Resolve();
			new EffectGiveAbility(owner.myPlayer,owner,ToBuff2,"DivineShield").Resolve();
		}
	}
}
public class BG24_500_Ge:Ability{
//NAME=琥珀保护
//TEXT=+14/+14。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_500e:Ability{
//NAME=琥珀保护
//TEXT=+7/+7。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_704:MinionBase{
//NAME=审讯官怀特迈恩
//TEXT=<b>战斗开始时：</b>使本随从对面的敌方随从获得<b>嘲讽</b>，并使其受到的伤害翻倍。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=5|RACE=NONE
	private float GetX(int myindex,int myN)
	{
        float minx = -11.86f;
        float maxx = 11.21f;
        float cx = (minx + maxx) / 2f;
        float bw = (maxx - minx);
        float c1 = -bw / 12f;
        float c2 = bw / 6f;
        float myx= cx + c1 * (myN - 1) + c2 * myindex;
        return myx;
	}
	public override void OnCombatStart()
	{
		float myX = GetX(owner.myPlayer.board.IndexOf(owner),owner.myPlayer.board.Count);
		Card Near1 = null;
		float Dis1 = 1000f;

		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(c.GetTag(GameTag.Health)<=0)
			{
				continue;
			}
			float Dis = GetX(owner.myPlayer.otherPlayer.board.IndexOf(c),owner.myPlayer.otherPlayer.board.Count);
			if(Near1==null)
			{
				Near1=c;
				Dis1=Dis;
			}
			else{
				if(Dis<Dis1)
				{
					Near1=c;
					Dis1=Dis;
				}
			}
		}

		if(Near1!=null)
		{
			new EffectGiveAbility(owner.myPlayer,owner,Near1,"BG24_704_e").Resolve();
		}
	}
}
public class BG24_704_e:Ability{
//NAME=污秽
//TEXT=<b>嘲讽</b>且受到的伤害翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
		owner.SetTag(GameTag.DamageTakenEff,1);
	}
}
public class BG24_704_e_G:Ability{
//NAME=污秽
//TEXT=<b>嘲讽</b>且受到的伤害变为三倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
		owner.SetTag(GameTag.DamageTakenEff,2);
	}
}
public class BG24_704_G:MinionBase{
//NAME=审讯官怀特迈恩
//TEXT=<b>战斗开始时：</b>使本随从对面的敌方随从获得<b>嘲讽</b>，并使其受到的伤害变为三倍。
//MAJ=NEUTRAL|COST=5|ATK=16|HP=10|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
	private float GetX(int myindex,int myN)
	{
        float minx = -11.86f;
        float maxx = 11.21f;
        float cx = (minx + maxx) / 2f;
        float bw = (maxx - minx);
        float c1 = -bw / 12f;
        float c2 = bw / 6f;
        float myx= cx + c1 * (myN - 1) + c2 * myindex;
        return myx;
	}
	public override void OnCombatStart()
	{
		float myX = GetX(owner.myPlayer.board.IndexOf(owner),owner.myPlayer.board.Count);
		Card Near1 = null;
		float Dis1 = 1000f;

		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(c.GetTag(GameTag.Health)<=0)
			{
				continue;
			}
			float Dis = GetX(owner.myPlayer.otherPlayer.board.IndexOf(c),owner.myPlayer.otherPlayer.board.Count);
			if(Near1==null)
			{
				Near1=c;
				Dis1=Dis;
			}
			else{
				if(Dis<Dis1)
				{
					Near1=c;
					Dis1=Dis;
				}
			}
		}

		if(Near1!=null)
		{
			new EffectGiveAbility(owner.myPlayer,owner,Near1,"BG24_704_e").Resolve();
		}
	}
}
public class BG24_707:MinionBase{
//NAME=刺鬃废料铁匠
//TEXT=在一个友方<b>嘲讽</b>随从死亡后，获取一张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=QUILBOAR
}
public class BG24_707_G:MinionBase{
//NAME=刺鬃废料铁匠
//TEXT=在一个友方<b>嘲讽</b>随从死亡后，获取2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=2|ATK=8|HP=8|RACE=QUILBOAR
}
public class BG24_708:MinionBase{
//NAME=梵妮莎·范克里夫
//TEXT=每当本随从攻击时，使你的海盗永久获得+2/+1。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=7|RACE=PIRATE
	public override void AfterAttack(Card target=null)
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Pirate),atk:2,hp:1);
	}
}
public class BG24_708_G:MinionBase{
//NAME=梵妮莎·范克里夫
//TEXT=每当本随从攻击时，使你的海盗永久获得+4/+2。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=14|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void AfterAttack(Card target=null)
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Pirate),atk:4,hp:2);
	}
}
public class BG24_708e:Ability{
//NAME=迪菲亚支援
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_708e_G:Ability{
//NAME=迪菲亚支援
//TEXT=+4/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_712:MinionBase{
//NAME=自行堡垒
//TEXT=在你的回合结束时，使4个友方<b>嘲讽</b>随从获得+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=4|HP=6|RACE=NONE
}
public class BG24_712_G:MinionBase{
//NAME=自行堡垒
//TEXT=在你的回合结束时，使4个友方<b>嘲讽</b>随从获得+8/+8。
//MAJ=NEUTRAL|COST=0|ATK=8|HP=12|RACE=NONE
}
public class BG24_712e:Ability{
//NAME=强固
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_712e_G:Ability{
//NAME=强固
//TEXT=+8/+8。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_715:MinionBase{
//NAME=耐心的侦查员
//TEXT=当你出售本随从时，<b>发现</b>一个等级1的随从。<i>（每回合都会升级！）</i>
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=NONE
}
public class BG24_715_G:MinionBase{
//NAME=耐心的侦查员
//TEXT=当你出售本随从时，<b>发现</b>两个等级1的随从。<i>（每回合都会升级！）</i>
//MAJ=NEUTRAL|COST=0|ATK=2|HP=2|RACE=NONE
}
public class BG24_719:MinionBase{
//NAME=无面信徒
//TEXT=<b>战吼：</b>将一个随从变形成为高一级的随从。
//MAJ=NEUTRAL|COST=0|ATK=6|HP=4|RACE=NONE
}
public class BG24_719_G:MinionBase{
//NAME=无面信徒
//TEXT=<b>战吼：</b>将一个随从变形成为高2级的随从。
//MAJ=NEUTRAL|COST=0|ATK=12|HP=8|RACE=NONE
}
public class BG24_HERO_100:HeroBase{
//NAME=德纳修斯大帝
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG24_HERO_100_Buddy:MinionBase{
//NAME=阴蔽的权贵
//TEXT=当你出售本随从时，<b>发现</b>一个<b>任务</b>。完成该任务即可获取一袋8枚装的铸币。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class BG24_HERO_100_Buddy_G:MinionBase{
//NAME=阴蔽的权贵
//TEXT=当你出售本随从时，<b>发现</b>一个<b>任务</b>。完成该任务即可获取一袋16枚装的铸币。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=6|RACE=NONE
}
public class BG24_HERO_100_Buddy_Gt:SpellBase{
//NAME=大袋钱币
//TEXT=获得16枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_HERO_100_Buddyt:SpellBase{
//NAME=小袋钱币
//TEXT=获得8枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_HERO_100_SKIN_A:HeroBase{
//NAME=歌纳修斯大帝
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG24_HERO_100_SKIN_B:HeroBase{
//NAME=战车御者德纳修斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG24_HERO_100_SKIN_C:HeroBase{
//NAME=首脑德纳修斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG24_HERO_100_SKIN_D:HeroBase{
//NAME=蝙蝠德纳修斯大帝
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG24_HERO_100p:HeroPowerBase{
//NAME=悬案疑云
//TEXT=<b>被动</b> 对战开始时，从两个<b>任务</b>中选择一个。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_HERO_204:HeroBase{
//NAME=强化机器人
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG24_HERO_204_Buddy:MinionBase{
//NAME=强化医疗机
//TEXT=酒馆中具有<b>嘲讽</b>，<b>复生</b>，<b>风怒</b>或<b>圣盾</b>的随从，每有其中一种效果，便拥有+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=MECHANICAL
}
public class BG24_HERO_204_Buddy_G:MinionBase{
//NAME=强化医疗机
//TEXT=酒馆中具有<b>嘲讽</b>，<b>复生</b>，<b>风怒</b>或<b>圣盾</b>的随从，每有其中一种效果，便拥有+4/+4。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=MECHANICAL
}
public class BG24_HERO_204_Buddye2:Ability{
//NAME=调整强化
//TEXT=强化医疗机使其属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_HERO_204_SKIN_A:HeroBase{
//NAME=强化音乐机器人
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG24_HERO_204_SKIN_B:HeroBase{
//NAME=角斗机器人
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG24_HERO_204_SKIN_C:HeroBase{
//NAME=锡兵机器人
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG24_HERO_204_SKIN_D:HeroBase{
//NAME=魔能机器人
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG24_HERO_204p:HeroPowerBase{
//NAME=强化
//TEXT=<b>被动</b> 在每次<b>刷新</b>后，使酒馆中的一个随从获得<b>嘲讽</b>，<b>风怒</b>，<b>复生</b>或<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_HERO_204pe:Ability{
//NAME=强化复生人
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_HERO_204pe2:Ability{
//NAME=强化圣盾人
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_HERO_204pe3:Ability{
//NAME=强化嘲讽人
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_HERO_204pe4:Ability{
//NAME=强化风怒人
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_112:SpellBase{
//NAME=追踪脚印
//TEXT=<b>任务：</b>酒馆<b>刷新</b>{0}次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_114:SpellBase{
//NAME=集合列队
//TEXT=<b>任务：</b>召唤{0}个随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_120:SpellBase{
//NAME=揭露匪首
//TEXT=<b>任务：</b>在{0}场战斗中输掉或平局。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_123:SpellBase{
//NAME=寻找凶器
//TEXT=<b>任务：</b>提升一个友方随从的属性值{0}次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_124:SpellBase{
//NAME=推演凶案
//TEXT=<b>任务：</b>{0}个友方随从死亡。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_125:SpellBase{
//NAME=排序分析
//TEXT=<b>任务：</b>在{0}场战斗中将你的随从按攻击力由低到高排列。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_126:SpellBase{
//NAME=追查钱财
//TEXT=<b>任务：</b>花费{0}枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_151:SpellBase{
//NAME=非凡组合
//TEXT=<b>任务：</b> 使用{0}张{2}牌或{3}牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_311:SpellBase{
//NAME=呼吼求援
//TEXT=<b>任务：</b>使用{0}张<b>战吼</b>随从牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_313:SpellBase{
//NAME=邀请宾客
//TEXT=<b>任务：</b>购买{0}个随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_314:SpellBase{
//NAME=采集指纹
//TEXT=<b>任务：</b>将{0}张牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_318:SpellBase{
//NAME=保护证人
//TEXT=<b>任务：</b>使一个友方<b>嘲讽</b>随从被攻击{0}次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_320:SpellBase{
//NAME=挖掘骸骨
//TEXT=<b>任务：</b>触发{0}次友方<b>亡语</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_328:SpellBase{
//NAME=结案
//TEXT=<b>任务：</b>赢得对战。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_351:SpellBase{
//NAME=雇用调查员
//TEXT=<b>任务：</b>在有未花费的铸币的情况下结束回合{0}次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_352:SpellBase{
//NAME=案情破局
//TEXT=<b>任务：</b>友方随从攻击{0}次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Quest_Bob:SpellBase{
//NAME=开始调查
//TEXT=3回合后，从三个<b>任务</b>中选择一个！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_QuestsPlayerEnch_t:SpellBase{
//NAME=Discover Quest + Reward [DNT]
//TEXT=<b>Discover</b> a Quest and Reward pair. [DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_107:Ability{
//NAME=尖啸零食
//TEXT=在你的回合结束时，2个友方随从触发其<b>战吼</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_109:Ability{
//NAME=失窃的黄金
//TEXT=<b>战斗开始时：</b>使你最左边和最右边的随从变为金色。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_111:Ability{
//NAME=邪恶双子
//TEXT=<b>战斗开始时：</b>召唤你生命值最高的随从的一个复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_113:Ability{
//NAME=仪式匕首
//TEXT=在一个友方<b>亡语</b>随从死亡后，使其永久获得+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_113_ALT:Ability{
//NAME=仪式匕首
//TEXT=每场战斗中你的第一个<b>亡语</b>额外触发一次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_113e:Ability{
//NAME=“崇高”牺牲
//TEXT=+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_115:Ability{
//NAME=西塔尔的阳伞
//TEXT=在你的回合结束时，使你最右边的随从直到下回合获得<b>潜行</b>，并使其获得+8生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_115e:Ability{
//NAME=遮蔽
//TEXT=+8生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_115e2:Ability{
//NAME=阴凉
//TEXT=直到下个回合，获得<b>潜行</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_123:Ability{
//NAME=精美的螺号
//TEXT=每回合中你的第一个<b>战吼</b>额外触发2次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_125:Ability{
//NAME=冒烟的枪
//TEXT=你的随从拥有+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_125e:Ability{
//NAME=硝烟未散
//TEXT=+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_128:Ability{
//NAME=镜盾
//TEXT=在每次<b>刷新</b>后，使酒馆中的一个随从获得+6/+6和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_128e:Ability{
//NAME=镜盾
//TEXT=+6/+6和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_129:Ability{
//NAME=神秘罪碑
//TEXT=在你<b>发现</b>一张卡牌后，额外获取一张复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_130:Ability{
//NAME=鬼魅面具
//TEXT=获取一张“{0}”。你的回合结束效果额外触发一次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_131:Ability{
//NAME=血手
//TEXT=在你的回合开始时，使你手牌中的一张随从牌获得+12/+12。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_131e:Ability{
//NAME=血手印
//TEXT=+12/+12。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_134:Ability{
//NAME=好友同行
//TEXT=在你的回合开始时，随机获取2个{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_135:Ability{
//NAME=美味尤物
//TEXT=在你的回合开始时，转动尤格-萨隆的命运之轮。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_136:Ability{
//NAME=小小手下
//TEXT=在你的回合结束时，使等级3或更低的3个友方随从获得+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_136e:Ability{
//NAME=不那么小了
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_138:Ability{
//NAME=受害者的怨灵
//TEXT=在每场战斗后，获取上一个死亡的友方随从的一张原始版复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_210:Ability{
//NAME=黄金时代
//TEXT=你拥有无限的铸币，却只有15秒的回合时间。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_305:Ability{
//NAME=心能贿赂
//TEXT=在你出售一个随从后，使酒馆中的一个随从获得其属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_305e:Ability{
//NAME=受贿心能
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_306:Ability{
//NAME=煮熟的书
//TEXT=在你购买一个随从后，使其获得+1/+1并升级此效果。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_306e:Ability{
//NAME=煮熟
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_308:Ability{
//NAME=青虎蓝宝石
//TEXT=在本回合中每<b>刷新</b>一次，酒馆中的随从拥有+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_308e:Ability{
//NAME=青虎之灵
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_309:Ability{
//NAME=细节中的恶魔
//TEXT=在你的回合结束时，你最左边和最右边的随从各吞食一个酒馆中的随从，获得其属性值。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_309e:Ability{
//NAME=暂时满意了……
//TEXT=吞食了随从的属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_310:Ability{
//NAME=共犯
//TEXT=获取你的金色<b>伙伴</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_311:Ability{
//NAME=另一具藏匿遗体
//TEXT=<b>发现</b>一个你当前等级的随从。<i>（可以无限赢取！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_312:Ability{
//NAME=源生法杖
//TEXT=<b>战斗开始时：</b>使你的所有随从获得+12/+12。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_312e:Ability{
//NAME=强力宝杖
//TEXT=+12/+12。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_313:Ability{
//NAME=神奇的智慧之球
//TEXT=偶尔来一手有用的<b>刷新</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_313e:Ability{
//NAME=惊人智慧
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_321:Ability{
//NAME=另我人格
//TEXT=酒馆中偶数等级的随从拥有+7/+7。<i>（下回合切换为奇数！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_321e:Ability{
//NAME=人格切换
//TEXT=+7/+7。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_321t:Ability{
//NAME=另我人格
//TEXT=酒馆中奇数等级的随从拥有+7/+7。<i>（下回合切换为偶数！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_331:Ability{
//NAME=展馆之乱
//TEXT=在你的回合结束时，每有一个不同的友方随从类型，使你的随从获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_331e:Ability{
//NAME=樽盏之乱
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_350:Ability{
//NAME=偷来的神灯
//TEXT=你只需2个复制即可将随从变为金色。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_361:Ability{
//NAME=秘密宝库
//TEXT=在你的回合开始时，获得1枚铸币。<i>（每回合都会升级！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_362:Ability{
//NAME=泽鲁斯的精华
//TEXT=在你的回合结束时，获取一张可以变形成为随机随从的“百变泽鲁斯”。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_363:Ability{
//NAME=虚灵证物
//TEXT=在每个回合开始时，从2个新奖励中选择一个。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_363e:Ability{
//NAME=虚灵证物玩家效果
//TEXT=每回合切换你的奖励。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_364:Ability{
//NAME=烈性毒药
//TEXT=你的随从拥有+7/+7，在其攻击后便会死亡。死得很惨。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_364e:Ability{
//NAME=易爆
//TEXT=+7/+7。攻击后死亡。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_708:Ability{
//NAME=血杯
//TEXT=在你的回合结束时，使你最右边的随从获得等同于你缺失的生命值的攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_708_e:Ability{
//NAME=鲜血之吻
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_712:Ability{
//NAME=堕罪堡勋章
//TEXT=在你使用一张随从牌后，使2个与其等级相同的其他友方随从获得+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_712e:Ability{
//NAME=堕入罪孽
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_715:Ability{
//NAME=增幅强化装置
//TEXT=在你的回合开始时。获取一张可以使随从获得+5/+5和一项随机效果的强化零件。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_715e:Ability{
//NAME=你好！你好！你好！
//TEXT=+5/+5和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_715e2:Ability{
//NAME=泼风快刀
//TEXT=+5/+5和<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_715e3:Ability{
//NAME=重甲护身
//TEXT=+5/+5和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_715e4:Ability{
//NAME=再试一次
//TEXT=+5/+5和<b>复生</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_715t:SpellBase{
//NAME=超大号角
//TEXT=使一个随从获得+5/+5和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_715t2:SpellBase{
//NAME=炫目旋刃
//TEXT=使一个随从获得+5/+5和<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_715t3:SpellBase{
//NAME=护身铠甲
//TEXT=使一个随从获得+5/+5和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_715t4:SpellBase{
//NAME=死亡回溯装置
//TEXT=使一个随从获得+5/+5和<b>复生</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_718:Ability{
//NAME=绑票麻袋
//TEXT=<b>塑造法术：</b>选择一张非金色的牌，将其移入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_718t:SpellBase{
//NAME=绑票麻袋
//TEXT=选择一张非金色的牌，将其移入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG24_Reward_719:Ability{
//NAME=金锤
//TEXT=<b>塑造法术：</b>直到下回合，使一个友方随从变为金色。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG24_Reward_719t:SpellBase{
//NAME=金锤
//TEXT=直到下回合，使一个友方随从变为金色。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG24_Reward_719te:Ability{
//NAME=金锤灌顶
//TEXT=直到下回合变为金色。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
