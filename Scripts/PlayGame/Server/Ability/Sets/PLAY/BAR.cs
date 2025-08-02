using System.Collections;
using System.Collections.Generic;

public class BAR_321:SpellBase{
	public override void Battlecry(Card target=null)
	{
		new EffectChange(owner.myPlayer,owner,owner.myPlayer.weapon[0],atkChange:1).Resolve();
		TaskBuffMyHero(atk:1);
		new EffectGiveAbility(owner.myPlayer,owner,owner.myPlayer.hero[0],"Immue").Resolve();
	}
}
public class BAR_069:MinionBase{
//NAME=受伤的掠夺者
//TEXT=<b>嘲讽</b>，<b>战吼：</b>对本随从造成6点伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=10|RACE=CENTAUR
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,owner,6).Resolve();
	}
}
public class BAR_327:SpellBase{
//NAME=邪恶召唤
//TEXT=召唤两个2/2并具有<b>吸血</b>的\n恶魔。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MECHANICAL
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BAR_327t"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("BAR_327t"),ZoneType.Board);
	}
}
public class BAR_327t:MinionBase{
//NAME=贪食邪犬
//TEXT=<b>吸血</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=CENTAUR
	public override void Init()
	{
		TaskInitAbility("LifeSteal");
	}
}
public class BAR_536:SpellBase{
//NAME=生命之种（等级1）
//TEXT=抽一张野兽牌，其法力值消耗减少（1）点。<i>（当你有5点法力值时升级。）</i>
	public override void Battlecry(Card target=null)
	{
		Card Drawn = TaskDrawRace(RaceType.Beast);
		int ManaReduce = 1;
		if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=10)
		{
			ManaReduce=3;
		}
		else{
			if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=5)
			{
				ManaReduce=2;
			}
		}
		new EffectChange(owner.myPlayer,owner,Drawn,manaChange:-ManaReduce).Resolve();
	}
}
public class BAR_542:SpellBase{
//NAME=清凉的泉水
//TEXT=抽两张牌。每抽到一张法术牌，便复原两个法力水晶。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MECHANICAL
	public override void Battlecry(Card target=null)
	{
		int Cnt=0;
		for(int i=0;i<2;i++)
		{
			Card Draw=TaskDraw();
			if(Draw!=null)
			{
				if(Draw.cardType==CardType.Spell)
				{
					Cnt+=1;
				}
			}
		}
		owner.myPlayer.ChangeTag(GameTag.ManaLeft,2*Cnt);		
	}
}

public class BAR_721:MinionBase{
//NAME=曼科里克
//TEXT=<b>战吼：</b>帮助曼科里克寻找他的妻子！她曾出现在你牌库中的某个地方。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BAR_721t"),ZoneType.Deck);
	}
}
public class BAR_721t:SpellBase{
//NAME=奥格拉，曼科里克的妻子
//TEXT=<b>抽到时施放</b>\n召唤一个3/7的曼科里克，立即攻击敌方英雄。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("CastWhenDrawn");
	}
	public override void Battlecry(Card target=null)
	{
		Card Summoned = TaskCreate(CardDbf.GetCardDbfByGuid("BAR_721t2"),ZoneType.Board);
		if(Summoned.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
		{
			if(owner.myPlayer.otherPlayer.hero.Count>0)
				new EffectAttack(owner.myPlayer,Summoned,owner.myPlayer.otherPlayer.hero[0]).Resolve();
		}
	}
}
public class BAR_721t2:MinionBase{
//NAME=怒火攻心的曼科里克
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=3|HP=7|RACE=NONE
}
public class BAR_801:SpellBase{
//NAME=击伤猎物
//TEXT=造成$1点伤害。召唤一只1/1并具有<b>突袭</b>的土狼。
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
		TaskCreate(CardDbf.GetCardDbfByGuid("BAR_035t"),ZoneType.Board);
	}
}
public class BAR_035t:SpellBase{
//NAME=迅捷土狼
//TEXT=<b>突袭</b>
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
}
public class BAR_845:SpellBase{
//NAME=仇怨累积
//TEXT=对所有随从造成$2点伤害。每消灭一个随从，获得2点\n护甲值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MECHANICAL
	public override void Battlecry(Card target=null)
	{
		int GraveCnt = owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Count;
		TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),2);
		int GraveDiff = owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Count - GraveCnt;
		for(int i=0;i<GraveDiff;i++)
		{
			TaskBuffMyHero(arm:2);
		}
	}
}
public class BAR_891:SpellBase{
//NAME=怒火（等级1）
//TEXT=在本回合中，使你的英雄获得+2攻击力。<i>（当你有5点法力值时升级。）</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MECHANICAL
	public override void Battlecry(Card target=null)
	{
		Card Drawn = TaskDrawRace(RaceType.Beast);
		int ManaReduce = 2;
		if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=10)
		{
			ManaReduce=4;
		}
		else{
			if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=5)
			{
				ManaReduce=3;
			}
		}
		TaskBuffMyHero(atk:ManaReduce);
	}
}

public class BAR_891t2:SpellBase{
//NAME=怒火（等级3）
//TEXT=在本回合中，使你的英雄获得+4攻击力。<i>（当你有5点法力值时升级。）</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MECHANICAL
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(atk:4);
	}
}
public class BAR_911:SpellBase
{
//NAME=灵魂撕裂
//TEXT=对所有随从造成$5点伤害。每消灭一个随从，便摧毁你牌库中的一张牌。
	public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),5);
        for(int i=0;i<7;i++)
        {
        	Card ToDis = owner.myPlayer.deck.Choice(owner.myPlayer.randomGen);
        	if(ToDis!=null)
        		new EffectMove(owner.myPlayer,ToDis,ZoneType.Deck,ZoneType.Grave).Resolve();
        }
    }
}