using System.Collections;
using System.Collections.Generic;

public class RLK_008t:MinionBase{
//NAME=复活的食尸鬼
//TEXT=<b>突袭</b>。<i>不会留下<b>尸体</b>。</i>
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_012:WeaponBase{
//NAME=断魂
//TEXT=在你的英雄攻击并消灭一个随从后，获得2具 <b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=2|RACE=NONE
}
public class RLK_015:SpellBase{
//NAME=凛风冲击
//TEXT=对一个敌人造成$3点伤害并将其<b>冻结</b>。对所有其他敌人造成$1点伤害。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=FROST
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
		new EffectGiveAbility(owner.myPlayer,owner,target,"Frozen").Resolve();
		TaskDamageTargets(owner.myPlayer.otherPlayer.hero.Merge(owner.myPlayer.otherPlayer.board).Exclude(target),1);
	}
}
public class RLK_018:SpellBase{
//NAME=凋零打击
//TEXT=对一个随从造成$3点伤害。如果该随从死亡，召唤一个2/2并具有<b>突袭</b>的僵尸。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_018t:MinionBase{
//NAME=狂暴僵尸
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_024:SpellBase{
//NAME=灵界打击
//TEXT=<b>吸血</b> 对一个随从造成$6点伤害。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("LifeSteal");
	}
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,6).Resolve();
	}
}
public class RLK_025:SpellBase{
//NAME=冰霜打击
//TEXT=对一个随从造成$3点伤害。如果该随从死亡，<b>发现</b>一张冰霜符文牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=FROST
}
public class RLK_025e:Ability{
//NAME=冰川突进
//TEXT=在本回合中，你施放的下一个法术的法力值消耗减少（2）点。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_025o:Ability{
//NAME=冰川突进
//TEXT=在本回合中，你施放的下一个法术的法力值消耗减少（2）点。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_029:MinionBase{
//NAME=裂肤石像鬼
//TEXT=<b>嘲讽</b>，<b>亡语：</b>随机对一个敌人造成4点伤害。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=6|RACE=UNDEAD
}
public class RLK_034:SpellBase{
//NAME=心脏打击
//TEXT=对一个随从造成$3点伤害。如果该随从死亡，获得一具<b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
		if(target.GetTag(GameTag.Health)<=0)
		{
			owner.myPlayer.ChangeTag(GameTag.CntCorpse,1);
		}
	}
}
public class RLK_035:SpellBase{
//NAME=邪爆
//TEXT=引爆一具<b>尸体</b>，对所有随从造成$1点伤害。如果有随从存活，重复此效果。
//MAJ=DEATHKNIGHT|COST=5|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
    	int CNT=0;
        List<Card> AllMinions = owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board);
        while(AllMinions.Count>0 && CNT<5)
        {
            TaskDamageTargets(AllMinions,1);
            CNT+=1;
            AllMinions = owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board);
        }
    }
}
public class RLK_038:SpellBase{
//NAME=冰冷触摸
//TEXT=对一个敌人造成$2点伤害，并使其<b>冻结</b>。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=FROST
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
	}
}
public class RLK_039:SpellBase{
//NAME=天灾谷物
//TEXT=获得4具<b>尸体</b>。将四个谷物箱洗入你的牌库，当抽到谷物箱时，召唤一个2/2的亡灵。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=NONE
}
public class RLK_039t:SpellBase{
//NAME=谷物箱
//TEXT=<b>抽到时施放</b> 召唤一个2/2的亡灵农夫。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=NONE
}
public class RLK_042:SpellBase{
//NAME=寒冬号角
//TEXT=复原两个法力水晶。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=FROST
}
public class RLK_048:SpellBase{
//NAME=反魔法护罩
//TEXT=使你的所有随从获得+1/+1和<b>扰魔</b>。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_048e:Ability{
//NAME=反魔法护罩
//TEXT=+1/+1和<b>扰魔</b>。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_051:SpellBase{
//NAME=吸血鬼之血
//TEXT=使你的英雄获得+5生命值。消耗3具<b>尸体</b>，多获得5点并抽一张牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(hp:5);
		if(owner.myPlayer.GetTag(GameTag.CntCorpse)>=3)
		{
			owner.myPlayer.ChangeTag(GameTag.CntCorpse,-3);
			TaskBuffMyHero(hp:5);
			TaskDraw();
		}
	}
}
public class RLK_051e:Ability{
//NAME=吸血鬼之力
//TEXT=生命值提高。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_056:SpellBase{
//NAME=邪恶狂热
//TEXT=选择一个敌方随从，使你的所有随从攻击该随从。再次召唤死亡的友方随从。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_057:SpellBase{
//NAME=黑暗突变
//TEXT=将一个亡灵变形成为一个4/5并具有<b>突袭</b>的亡灵怪物。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_057t:MinionBase{
//NAME=亡灵怪物
//TEXT=<b>突袭</b>
//MAJ=DEATHKNIGHT|COST=4|ATK=4|HP=5|RACE=UNDEAD
}
public class RLK_060:SpellBase{
//NAME=亡者大军
//TEXT=将最多5具<b>尸体</b>复活为2/2并具有<b>突袭</b>的复活的食尸鬼。
//MAJ=DEATHKNIGHT|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_061:MinionBase{
//NAME=战场通灵师
//TEXT=在你的回合结束时，将一具<b>尸体</b>复活为1/3并具有<b>嘲讽</b>的复活的步兵。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=2|RACE=NONE
}
public class RLK_061t:MinionBase{
//NAME=复活的步兵
//TEXT=<b>嘲讽</b>。<i>不会留下<b>尸体</b>。</i>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=3|RACE=UNDEAD
}
public class RLK_062:MinionBase{
//NAME=蛛魔护群守卫
//TEXT=<b>嘲讽</b>。<b>战吼：</b>召唤本随从的两个复制。
//MAJ=DEATHKNIGHT|COST=4|ATK=1|HP=3|RACE=UNDEAD
}
public class RLK_063:SpellBase{
//NAME=冰霜巨龙之怒
//TEXT=造成$5点伤害。<b>冻结</b>所有敌方随从。召唤一条5/5的冰霜巨龙。
//MAJ=DEATHKNIGHT|COST=7|ATK=0|HP=0|RACE=FROST
}
public class RLK_063t:MinionBase{
//NAME=冰霜巨龙
//TEXT=
//MAJ=DEATHKNIGHT|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class RLK_066:MinionBase{
//NAME=鲜血魔术师
//TEXT=<b>战吼：</b>消耗一具<b>尸体</b>，<b>发现</b>一张鲜血符文牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=3|RACE=NONE
}
public class RLK_066e:Ability{
//NAME=寒冬赠礼
//TEXT=生命值提高。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_067:WeaponBase{
//NAME=堕落的灰烬使者
//TEXT=<b>吸血</b>
//MAJ=DEATHKNIGHT|COST=6|ATK=5|HP=2|RACE=NONE
}
public class RLK_070:MinionBase{
//NAME=被感染的农夫
//TEXT=<b>亡语：</b>召唤一个2/2的亡灵农夫。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class RLK_070t:MinionBase{
//NAME=亡灵农夫
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_071:MinionBase{
//NAME=帕奇维克
//TEXT=<b>战吼：</b>随机消灭你对手手牌，牌库和战场上的各一个随从。
//MAJ=DEATHKNIGHT|COST=7|ATK=4|HP=6|RACE=UNDEAD
    public override void Battlecry(Card target=null)
    {
        TaskDestroyRandomEnemyMinion();
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.hand)
        {
            if(c.cardType==CardType.Minion)
            {
                Pool.Add(c);
            }
        }
        Card Target = Pool.Choice(owner.myPlayer.randomGen);
        if(Target!=null)
        {
            new EffectDestroy(owner.myPlayer,owner,Target).Resolve();
        }

        List<Card> Pool2 = new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.deck)
        {
            if(c.cardType==CardType.Minion)
            {
                Pool2.Add(c);
            }
        }
        Card Target2 = Pool2.Choice(owner.myPlayer.randomGen);
        if(Target2!=null)
        {
            new EffectDestroy(owner.myPlayer,owner,Target2).Resolve();
        }
    }
}
public class RLK_077:MinionBase{
//NAME=魔心操纵者
//TEXT=<b>战吼：</b> 召唤两个1/1并具有<b>突袭</b>和<b>复生</b>的斗士。
//MAJ=DEATHKNIGHT|COST=5|ATK=3|HP=3|RACE=NONE
}
public class RLK_077t:MinionBase{
//NAME=着魔斗士
//TEXT=<b>突袭</b>，<b>复生</b>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=NONE
}
public class RLK_079:MinionBase{
//NAME=喷毒尸骸
//TEXT=<b>战吼：</b> 对一个敌人和你的英雄造成2点伤害。
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=2|RACE=UNDEAD
}
public class RLK_082:MinionBase{
//NAME=死亡使者萨鲁法尔
//TEXT=<b>嘲讽</b>。<b>亡语：</b>将本随从移回你的手牌，且本牌消耗生命值，而非法力值。
//MAJ=DEATHKNIGHT|COST=5|ATK=3|HP=6|RACE=UNDEAD
	private bool Act=false;
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Battlecry(Card target=null)
	{
		if(Act)
		{
			TaskDamageMyHero(5);
		}
	}
	public override void Deathrattle()
	{
		Act=true;
		new EffectMove(owner.myPlayer,owner,(ZoneType)owner.GetTag(GameTag.ZoneType),ZoneType.Hand).Resolve();
	}
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			if(Act)
				return -5;
		}
		return 0;
	}
}
public class RLK_083:MinionBase{
//NAME=死亡寒冰
//TEXT=在你施放一个法术后，随机对两个敌人造成1点伤害。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class RLK_085:MinionBase{
//NAME=玛洛加尔领主
//TEXT=<b>战吼：</b>将你的所有<b>尸体</b>复活为1/1并具有<b>突袭</b>的复活的傀儡。每有一个放不下的傀儡，使一个傀儡获得+2/+2。
//MAJ=DEATHKNIGHT|COST=8|ATK=9|HP=7|RACE=UNDEAD
}
public class RLK_085e:Ability{
//NAME=白骨风暴
//TEXT=+2/+2。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_085t:MinionBase{
//NAME=复活的傀儡
//TEXT=<b>突袭</b>。<i>不会留下<b>尸体</b>。</i>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class RLK_086:WeaponBase{
//NAME=霜之哀伤
//TEXT=<b>亡语：</b>召唤被该武器消灭的所有 随从。
//MAJ=DEATHKNIGHT|COST=6|ATK=4|HP=3|RACE=NONE
}
public class RLK_087:SpellBase{
//NAME=窒息
//TEXT=消灭攻击力最高的敌方随从。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.otherPlayer.board.Count>0)
			new EffectDestroy(owner.myPlayer,owner,owner.myPlayer.otherPlayer.board[0]).Resolve();
		//TaskDestroyRandomEnemyMinion();
	}
}
public class RLK_101:SpellBase{
//NAME=解冻
//TEXT=抽一张牌。消耗2具<b>尸体</b>，再抽一张。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=FROST
    public override void Battlecry(Card target=null)
    {
        TaskDraw();
        if(owner.myPlayer.GetTag(GameTag.CntCorpse)>=2)
        {
            owner.myPlayer.ChangeTag(GameTag.CntCorpse,-2);
            TaskDraw();
        }
    }
}
public class RLK_104:MinionBase{
//NAME=街头扫把
//TEXT=<b>战吼：</b>对所有其他随从造成2点伤害。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=NONE
}
public class RLK_110:MinionBase{
//NAME=伊米亚破霜者
//TEXT=<b>战吼：</b>你手牌中每有一张冰霜法术牌，便获得+1攻击力。
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=2|RACE=NONE
}
public class RLK_110e:Ability{
//NAME=破冰之力
//TEXT=+1攻击力
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_113:MinionBase{
//NAME=脆皮僵尸
//TEXT=<b>亡语：</b>如果此时是你对手的回合，则对你的对手造成3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=UNDEAD
}
public class RLK_115:MinionBase{
//NAME=丑恶巨怪
//TEXT=敌方角色无法被治疗。
//MAJ=DEATHKNIGHT|COST=4|ATK=3|HP=6|RACE=UNDEAD
}
public class RLK_116:MinionBase{
//NAME=死灵殡葬师
//TEXT=<b>战吼：</b>如果在你的上回合之后有友方亡灵死亡，<b>发现</b>一张邪恶符文牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=3|RACE=NONE
}
public class RLK_117:MinionBase{
//NAME=虚魂下士
//TEXT=在本随从攻击后消灭本随从。
//MAJ=NEUTRAL|COST=2|ATK=5|HP=5|RACE=UNDEAD
}
public class RLK_118:SpellBase{
//NAME=坟墓守卫
//TEXT=召唤两个2/2并具有<b>嘲讽</b>的僵尸。消耗4具<b>尸体</b>，使其获得<b>复生</b>。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_118t3:MinionBase{
//NAME=凶恶僵尸
//TEXT=<b>嘲讽</b>
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_119:MinionBase{
//NAME=达卡莱入殓师
//TEXT=<b>战吼：</b>使一个友方亡灵获得<b>复生</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=UNDEAD
}
public class RLK_120:MinionBase{
//NAME=绞肉机
//TEXT=<b>战吼：</b>随机绞碎你牌库中的一个随从，获得4具<b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=4|RACE=MECHANICAL
}
public class RLK_121:MinionBase{
//NAME=死亡侍僧
//TEXT=在一个友方亡灵死亡后，抽一张牌。
//MAJ=DEATHKNIGHT|COST=3|ATK=2|HP=4|RACE=NONE
}
public class RLK_122:SpellBase{
//NAME=天灾军团
//TEXT=用随机亡灵填满你的面板。
//MAJ=DEATHKNIGHT|COST=9|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		List<string> ToListSummon = new List<string>(){
			"NX2_018",
			"WW_358",
			"MIS_006",
			"TOY_828",
			"RLK_552",
			"RLK_833",
			"RLK_834"
		};
		foreach(string s in ToListSummon)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid(s),ZoneType.Board);
		}
	}
}
public class RLK_123:MinionBase{
//NAME=白骨投手
//TEXT=<b>战吼：</b> 如果在你的上回合之后有友方亡灵死亡，造成2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class RLK_125:SpellBase{
//NAME=湮灭
//TEXT=消灭一个随从。对你的英雄造成3点伤害。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
        TaskDamageMyHero(3);
    }
}
public class RLK_206:SpellBase{
//NAME=轻蔑印记
//TEXT=抽一张牌，如果不是随从牌，对生命值最低的敌人造成$4点伤害。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_207:MinionBase{
//NAME=凶猛的外来者
//TEXT=<b>突袭</b>。<b>流放：</b>你的下一张<b>流放</b>牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=1|ATK=2|HP=1|RACE=NONE
}
public class RLK_207e:Ability{
//NAME=由外而内
//TEXT=你的下一张<b>流放</b>牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_208:SpellBase{
//NAME=邪多雷战队
//TEXT=造成$4点伤害。如果你的牌库中没有随从牌，召唤四个1/1并具有<b>突袭</b>的伊利达雷。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class RLK_209:SpellBase{
//NAME=释放邪能
//TEXT=对所有敌人造成$1点伤害。<b>法力渴求（6）：</b><b>吸血</b>。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=FEL
	public override void Battlecry(Card target=null)
	{
		TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),1);
	}
}
public class RLK_210:MinionBase{
//NAME=失心流亡者
//TEXT=在你使用一张<b>流放</b>牌后，随机将一张<b>流放</b>牌置入你的手牌。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=3|RACE=NONE
}
public class RLK_211:SpellBase{
//NAME=魔鬼交易
//TEXT=召唤两个3/3并具有<b>吸血</b>的邪能邪犬。如果你的牌库中没有随从牌，再召唤两个。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=FEL
}
public class RLK_211t:MinionBase{
//NAME=邪能邪犬
//TEXT=<b>吸血</b>
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class RLK_212:MinionBase{
//NAME=安尼赫兰蛮魔
//TEXT=<b>嘲讽</b>。<b>突袭</b>。每当本随从受到伤害并存活下来时，对敌方英雄造成等量的伤害。
//MAJ=DEMONHUNTER|COST=9|ATK=9|HP=9|RACE=DEMON
}
public class RLK_213:MinionBase{
//NAME=复仇重击者
//TEXT=<b>突袭</b>。在本局对战中，你每使用过一张<b>流放</b>牌，本牌的法力值消耗便减少（1）点。
//MAJ=DEMONHUNTER|COST=7|ATK=5|HP=5|RACE=DEMON
}
public class RLK_214:WeaponBase{
//NAME=食魂者之镰
//TEXT=<b>对战开始时：</b>吞食你套牌中3张不同的随从牌。留下灵魂，用以<b>发现</b>这些随从。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=2|RACE=NONE
}
public class RLK_214t:SpellBase{
//NAME=受缚之魂
//TEXT=<b>发现</b>一张被食魂者之镰吞食的随从牌。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class RLK_215:MinionBase{
//NAME=被遗忘的费勒林
//TEXT=<b>战吼：</b>随机将一张<b>流放</b>牌分别置入你手牌的最左边和最右边，其法力值消耗减少（2）点。
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=3|RACE=NONE
}
public class RLK_216:MinionBase{
//NAME=尸腐鼠
//TEXT=<b>战吼：</b>使你牌库中所有<b>亡语</b>牌的法力值消耗减少（1）点。
//MAJ=ROGUE|COST=2|ATK=2|HP=1|RACE=UNDEAD
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListBuff = new List<Card>();
		foreach(Card c in owner.myPlayer.deck)
		{
			if(c.HasAbility("Deathrattle"))
			{
				ToListBuff.Add(c);
			}
		}
		TaskBuffTargets(ToListBuff,mana:-1);
	}
}
public class RLK_216e:Ability{
//NAME=腐烂
//TEXT=法力值消耗减少（1）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_217:MinionBase{
//NAME=天灾幻术师
//TEXT=<b>亡语：</b>将你牌库中另一个<b>亡语</b>随从的4/4复制置入你的手牌，其法力值消耗减少（4）点。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=UNDEAD
	public override void Deathrattle()
	{
		List<CardDbf> ToDrawList= new List<CardDbf>();
		foreach(Card c in owner.myPlayer.deck)
		{
			if(c.cardType==CardType.Minion)
			{
				if(c.HasAbility("Deathrattle") && c.cardDbf!=owner.cardDbf)
				{
					ToDrawList.Add(c.cardDbf);
				}
			}
		}
		CardDbf ToDraw = ToDrawList.Choice(owner.myPlayer.randomGen);
		if(ToDraw!=null)
		{
			Card Created = TaskCreate(ToDraw,ZoneType.Hand);
			Created.SetTag(GameTag.Attack,4);
			Created.SetTag(GameTag.Health,4);
			Created.SetTag(GameTag.AttackDef,4);
			Created.SetTag(GameTag.HealthDef,4);
			new EffectChange(owner.myPlayer,owner,Created,manaChange:-4).Resolve();
		}
	}
}
public class RLK_217e:Ability{
//NAME=幻象
//TEXT=4/4。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_217e2:Ability{
//NAME=幻影
//TEXT=法力值消耗减少（4）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_218:MinionBase{
//NAME=银月城奥术师
//TEXT=<b>法术伤害+2</b>。<b>战吼：</b>在本回合中，你的法术不能以英雄为目标。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class RLK_218e:Ability{
//NAME=疯狂奥术
//TEXT=在本回合中无法成为法术的目标。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_218e2:Ability{
//NAME=奥术狂乱
//TEXT=在本回合中无法成为法术的目标。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_218e3:Ability{
//NAME=疯狂奥能
//TEXT=在本回合中，你的法术不能以英雄为目标。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_219:MinionBase{
//NAME=日怒教士
//TEXT=<b>战吼：</b>为所有友方角色恢复3点生命值。<b>法力渴求（6）：</b>改为恢复6点。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class RLK_220:MinionBase{
//NAME=顽强的萨莱因
//TEXT=<b>吸血</b>。每当本随从进行攻击，对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=UNDEAD
}
public class RLK_221:MinionBase{
//NAME=水晶掮客
//TEXT=<b>法力渴求（5）：</b>随机召唤一个法力值消耗为（3）的随从。<b>法力渴求（10）：</b>改为召唤法力值消耗为（8）的随从。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=NONE
}
public class RLK_222:MinionBase{
//NAME=阿斯塔洛·血誓
//TEXT=<b>战吼：</b>将护卫阿斯塔洛置入你的手牌。<b>法力渴求（5）：</b>造成2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("RLK_222t1"),ZoneType.Hand);
		if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=5)
		{
			new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
		}
	}
}
public class RLK_222t1:MinionBase{
//NAME=护卫阿斯塔洛
//TEXT=<b>战吼：</b>将火焰使者阿斯塔洛置入你的手牌。<b>法力渴求（8）：</b>获得5点护甲值。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("RLK_222t2"),ZoneType.Hand);
		if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=8)
		{
			TaskBuffMyHero(arm:5);
		}
	}
}
public class RLK_222t2:MinionBase{
//NAME=火焰使者阿斯塔洛
//TEXT=<b>战吼：</b>造成7点伤害，随机分配到所有敌人身上。<b>法力渴求（10）：</b>改为造成14点。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=10)
		{
			TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),14);
		}
		else{
			TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),7);
		}
	}
}
public class RLK_223:MinionBase{
//NAME=萨萨里安
//TEXT=<b>复生</b>。<b>战吼，亡语：</b>随机对一个敌人造成2点伤害。
//MAJ=DEATHKNIGHT|COST=4|ATK=3|HP=3|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Reborn");
	}
	public override void Battlecry(Card target=null)
	{
		TaskDamageRandomEnemy(2);
	}
	public override void Deathrattle()
	{
		TaskDamageRandomEnemy(2);
	}
}
public class RLK_224:MinionBase{
//NAME=监督者弗里吉达拉
//TEXT=<b>战吼：</b>抽两张法术牌。如果两张都是冰霜法术牌，对所有敌人造成2点伤害。
//MAJ=DEATHKNIGHT|COST=6|ATK=3|HP=6|RACE=NONE
}
public class RLK_225:MinionBase{
//NAME=凋零毒牙
//TEXT=<b>战吼：</b>感染所有敌方随从。当感染的随从死亡时，为你召唤一个2/2并具有<b>嘲讽</b>的僵尸。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class RLK_225e:Ability{
//NAME=染疫
//TEXT=<b>亡语：</b>为你的对手召唤一个2/2并具有<b>嘲讽</b>的僵尸。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_226:MinionBase{
//NAME=伊米亚死亡使者
//TEXT=<b>嘲讽</b>。<b>亡语：</b>消耗3具<b>尸体</b>，召唤一个3/3并具有<b>嘲讽</b>的复活的伊米亚人。
//MAJ=DEATHKNIGHT|COST=3|ATK=4|HP=3|RACE=UNDEAD
}
public class RLK_226t:MinionBase{
//NAME=复活的伊米亚人
//TEXT=<b>嘲讽</b>。<i>不会留下<b>尸体</b>。</i>
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class RLK_503:MinionBase{
//NAME=扛包收尸人
//TEXT=<b>战吼：</b>获得一具<b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=3|RACE=UNDEAD
}
public class RLK_504:MinionBase{
//NAME=僵尸新娘
//TEXT=<b>战吼：</b>消耗最多10具<b>尸体</b>，召唤一个攻击力和生命值等同于消耗尸体数并具有<b>嘲讽</b>的复活的新郎。
//MAJ=DEATHKNIGHT|COST=5|ATK=4|HP=4|RACE=UNDEAD
}
public class RLK_505:MinionBase{
//NAME=髓骨使御者
//TEXT=<b>战吼：</b>消耗最多5具<b>尸体</b>。每消耗一具尸体，随机对一个敌人造成2点伤害。
//MAJ=DEATHKNIGHT|COST=6|ATK=5|HP=5|RACE=UNDEAD
}
public class RLK_506:MinionBase{
//NAME=白骨卫士指挥官
//TEXT=<b>嘲讽</b>。<b>战吼：</b>将最多6具<b>尸体</b>复活为1/3并具有<b>嘲讽</b>的复活的步兵。
//MAJ=DEATHKNIGHT|COST=8|ATK=8|HP=8|RACE=UNDEAD
}
public class RLK_506t:MinionBase{
//NAME=复活的新郎
//TEXT=<b>嘲讽</b>。<i>不会留下<b>尸体</b>。</i>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class RLK_511:MinionBase{
//NAME=寒冬先锋
//TEXT=<b>亡语：</b>抽一张冰霜法术牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=3|HP=2|RACE=UNDEAD
	public override void Deathrattle()
	{
		TaskDrawSchool(SpellSchoolType.Frost);
	}
}
public class RLK_512:SpellBase{
//NAME=冰川突进
//TEXT=造成$4点伤害。在本回合中，你的下一个法术法力值消耗减少（2）点。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=FROST
}
public class RLK_516:WeaponBase{
//NAME=碎骨手斧
//TEXT=在你的英雄攻击随从后，对敌方英雄造成2点伤害。
//MAJ=DEATHKNIGHT|COST=1|ATK=2|HP=2|RACE=NONE
}
public class RLK_518:MinionBase{
//NAME=银月城哨兵
//TEXT=<b>嘲讽</b>。<b>法力渴求（8）：</b>获得+2/+2和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=NONE
}
public class RLK_518e:Ability{
//NAME=银月城的力量
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_527:MinionBase{
//NAME=时空守卫
//TEXT=<b>战吼：</b>直到你的下个回合结束，在此期间你召唤的龙获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=3|HP=4|RACE=DRAGON
}
public class RLK_527e2:Ability{
//NAME=来自未来
//TEXT=拥有<b>圣盾</b>和<b>嘲讽</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_529:MinionBase{
//NAME=淬毒渗透者
//TEXT=<b>剧毒</b>。<b>战吼：</b>如果在你的上回合之后有友方亡灵死亡，对一个随从造成1点伤害。
//MAJ=ROGUE|COST=4|ATK=2|HP=5|RACE=NONE
}
public class RLK_531:MinionBase{
//NAME=步军重生官
//TEXT=<b>战吼：</b> 复活一个友方亡灵，使其获得<b>复生</b>。
//MAJ=WARLOCK|COST=5|ATK=4|HP=4|RACE=NONE
}
public class RLK_532:MinionBase{
//NAME=行尸
//TEXT=<b>嘲讽</b>。如果你弃掉了这张随从牌，则会召唤它。
//MAJ=WARLOCK|COST=3|ATK=2|HP=5|RACE=UNDEAD
}
public class RLK_533:SpellBase{
//NAME=天灾补给
//TEXT=抽三张牌，从中选择一张弃掉。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_534:SpellBase{
//NAME=灵魂弹幕
//TEXT=当你使用或弃掉这张牌时，造成$6点伤害，随机分配到所有敌人身上。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sc==owner)
		{
			if(sz==ZoneType.Hand && tz==ZoneType.Grave)
			{
				TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),6);
			}
		}
	}
}
public class RLK_535:MinionBase{
//NAME=野蛮的伊米亚人
//TEXT=<b>突袭</b>，<b>战吼：</b>弃两张牌。
//MAJ=WARLOCK|COST=5|ATK=7|HP=7|RACE=UNDEAD
}
public class RLK_536:SpellBase{
//NAME=薄葬
//TEXT=触发一个友方随从的<b>亡语</b>，然后将其消灭。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_537:SpellBase{
//NAME=扭曲束缚
//TEXT=消灭一个随从，随机使你手牌中的一张亡灵牌获得其属性值。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_537e:Ability{
//NAME=扭曲束缚
//TEXT=属性值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_538:MinionBase{
//NAME=噬魂者
//TEXT=在一个友方随从死亡后，获得其<b>亡语</b>。
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=UNDEAD
}
public class RLK_538e:Ability{
//NAME=吞噬灵魂
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_539:MinionBase{
//NAME=达尔坎·德拉希尔
//TEXT=<b>吸血</b>。在你的回合结束时，对敌方英雄造成6点伤害。
//MAJ=WARLOCK|COST=7|ATK=6|HP=6|RACE=UNDEAD
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,CauseEvent));
	}
	public void CauseEvent()
	{
		if(CondInPlay())
			TaskDamageEnemyHero(6);
	}
}
public class RLK_540:MinionBase{
//NAME=流形泥浆怪
//TEXT=<b>战吼：</b> 随机弃掉一张亡灵牌。<b>亡语：</b>召唤被弃掉的亡灵的一个复制。
//MAJ=WARLOCK|COST=5|ATK=5|HP=3|RACE=NONE
}
public class RLK_540e:Ability{
//NAME=变形中
//TEXT=弃掉了{0}。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_541:MinionBase{
//NAME=维萨鲁斯
//TEXT=你的奥术法术会施放两次。
//MAJ=MAGE|COST=5|ATK=3|HP=5|RACE=ELEMENTAL
}
public class RLK_542:MinionBase{
//NAME=奥能散射机
//TEXT=<b>亡语：</b>将2张奥术箭置入你的手牌。
//MAJ=MAGE|COST=3|ATK=3|HP=2|RACE=NONE
}
public class RLK_543:MinionBase{
//NAME=魔导师学徒
//TEXT=你的奥术法术的法力值消耗减少（1）点。
//MAJ=MAGE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class RLK_544:SpellBase{
//NAME=奥术防御者
//TEXT=召唤两个5/6并具有<b>嘲讽</b>和<b>扰魔</b>的魔像。
//MAJ=MAGE|COST=8|ATK=0|HP=0|RACE=ARCANE
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("RLK_544t"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("RLK_544t"),ZoneType.Board);
	}
}
public class RLK_544t:MinionBase{
//NAME=魔像卫士
//TEXT=<b>嘲讽</b>。<b>扰魔</b>
//MAJ=MAGE|COST=5|ATK=5|HP=6|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskInitAbility("Elusive");
	}
}
public class RLK_545:MinionBase{
//NAME=能量塑形师
//TEXT=<b>战吼：</b>将你手牌中的所有法术牌变形成为法力值消耗增加（3）点的法术牌。<i>（保留其原始法力值消耗。）</i>
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=NONE
}
public class RLK_546:SpellBase{
//NAME=广阔智慧
//TEXT=<b>发现</b>两张法力值消耗小于或等于（3）点的法术牌。交换其法力值消耗。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_546e:Ability{
//NAME=无尽智慧
//TEXT=这张卡牌的法力值消耗被交换过。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_547:MinionBase{
//NAME=棱光元素
//TEXT=<b>战吼：</b> <b>发现</b>一张任意职业的法术牌，其法力值消耗减少（1）点。
//MAJ=MAGE|COST=2|ATK=1|HP=3|RACE=ELEMENTAL
}
public class RLK_547e:Ability{
//NAME=奇异能量
//TEXT=法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_548:MinionBase{
//NAME=奥术浮龙
//TEXT=<b>战吼：</b>将一张奥术箭置入你的手牌。
//MAJ=MAGE|COST=1|ATK=1|HP=2|RACE=NONE
}
public class RLK_550:MinionBase{
//NAME=腐鳃
//TEXT=<b>战吼：</b>使你的其他随从获得“<b>亡语：</b>使你的所有随从获得+1/+1。”
//MAJ=SHAMAN|COST=5|ATK=3|HP=6|RACE=UNDEAD
}
public class RLK_550e:Ability{
//NAME=死鱼眼
//TEXT=<b>亡语：</b>使你的所有随从获得+1/+1。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_550e2:Ability{
//NAME=死亡视界
//TEXT=+1/+1。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_551:MinionBase{
//NAME=瘟血狂战士
//TEXT=<b>嘲讽</b>，<b>吸血</b>，<b>复生</b>，<b>亡语：</b>随机对一个敌人造成3点伤害。
//MAJ=SHAMAN|COST=7|ATK=3|HP=8|RACE=UNDEAD
}
public class RLK_552:MinionBase{
//NAME=无息的勇士
//TEXT=<b>战吼：</b>如果在你的上回合之后有友方亡灵死亡，召唤两个3/2的僵尸。
//MAJ=SHAMAN|COST=3|ATK=3|HP=2|RACE=UNDEAD
}
public class RLK_553:SpellBase{
//NAME=先知先觉
//TEXT=抽两张随从牌。每有一张法力值消耗大于或等于（5）点的牌，召唤一个2/3并具有<b>嘲讽</b>的幽灵。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_553t:MinionBase{
//NAME=鬼影幻灵
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class RLK_554:MinionBase{
//NAME=恐惧感知者
//TEXT=<b><b>嘲讽</b>，复生</b>  <b>亡语：</b>召唤一个4/4并具有<b>嘲讽</b>的亡灵。
//MAJ=SHAMAN|COST=5|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_554t:MinionBase{
//NAME=达卡莱亡魂
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class RLK_567:SpellBase{
//NAME=殒命暗影
//TEXT=每当你施放一个法术，变形成为该法术的复制。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_567e:Ability{
//NAME=死亡映像
//TEXT=始终复制你最后使用的牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_567e2:Ability{
//NAME=死亡之影
//TEXT=变形成为最近的法术牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_568:MinionBase{
//NAME=配药师
//TEXT=<b>战吼：</b>随机将一份药剂置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=1|HP=2|RACE=NONE
}
public class RLK_569:SpellBase{
//NAME=药水腰带
//TEXT=<b>发现</b>2份药剂。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_570:MinionBase{
//NAME=食尸鬼炼金师
//TEXT=<b>战吼：</b>你的下一份药剂的法力值消耗为（0）点。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=UNDEAD
}
public class RLK_570e:Ability{
//NAME=黄色药水
//TEXT=+2攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_570e2:Ability{
//NAME=药水助力
//TEXT=攻击力提高。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_570e3:Ability{
//NAME=蓝色酒精
//TEXT=法力值消耗减少（3）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_570e4:Ability{
//NAME=药师核准
//TEXT=你的下一份药剂的法力值消耗为（0）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t:SpellBase{
//NAME=混合药水
//TEXT=
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t1:SpellBase{
//NAME=黏稠药剂
//TEXT=随机召唤一个法力值消耗为（3）的随从。<i>将另一份药剂置入你的手牌，即可混合在一起！</i>
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t1t:MinionBase{
//NAME=橘色软泥怪
//TEXT=
//MAJ=ROGUE|COST=3|ATK=3|HP=4|RACE=NONE
}
public class RLK_570t1t1:SpellBase{
//NAME=调好的药剂
//TEXT=随机召唤一个法力值消耗为（3）的随从。将一张另一职业的牌置入你的手牌，其法力值消耗减少（3）点。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t1t2:SpellBase{
//NAME=调好的药剂
//TEXT=随机召唤一个法力值消耗为（3）的随从。随机消灭一个敌方随从。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t1t3:SpellBase{
//NAME=调好的药剂
//TEXT=造成$3点伤害。随机召唤一个法力值消耗为（3）的随从。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t1t4:SpellBase{
//NAME=调好的药剂
//TEXT=随机召唤两个法力值消耗为（3）的随从。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t2:SpellBase{
//NAME=恐怖药剂
//TEXT=随机消灭一个敌方随从。<i>将另一份药剂置入你的手牌，即可混合在一起！</i>
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t2e:Ability{
//NAME=绿色药水
//TEXT=<b>剧毒</b>，<b>复生</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t2t1:SpellBase{
//NAME=调好的药剂
//TEXT=造成$3点伤害。随机消灭一个敌方随从。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t2t2:SpellBase{
//NAME=调好的药剂
//TEXT=随机消灭两个敌方随从。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t3:SpellBase{
//NAME=泡泡药剂
//TEXT=造成$3点伤害。<i>将另一份药剂置入你的手牌，即可混合在一起！</i>
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t3t:SpellBase{
//NAME=调好的药剂
//TEXT=造成$3点伤害，触发两次。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t4:SpellBase{
//NAME=缥缈药剂
//TEXT=将一张另一职业的牌置入你的手牌，其法力值消耗减少（3）点。<i>将另一份药剂置入你的手牌，即可混合在一起！</i>
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t4t1:SpellBase{
//NAME=调好的药剂
//TEXT=将一张另一职业的牌置入你的手牌，其法力值消耗减少（3）点。随机消灭一个敌方随从。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t4t2:SpellBase{
//NAME=调好的药剂
//TEXT=造成$3点伤害。将一张另一职业的牌置入你的手牌，其法力值消耗减少（3）点。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t4t3:SpellBase{
//NAME=调好的药剂
//TEXT=将两张其他职业的牌置入你的手牌，其法力值消耗减少（3）点。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570t5:SpellBase{
//NAME=闪光药剂
//TEXT=抽两张牌。<i>将另一份药剂置入你的手牌，即可混合在一起！</i>
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570tt1:SpellBase{
//NAME=调好的药剂
//TEXT=抽两张牌。随机召唤一个法力值消耗为（3）的随从。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570tt2:SpellBase{
//NAME=调好的药剂
//TEXT=造成$3点伤害。抽两张牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570tt3:SpellBase{
//NAME=调好的药剂
//TEXT=抽两张牌。将一张另一职业的牌置入你的手牌，其法力值消耗减少（3）点。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570tt4:SpellBase{
//NAME=调好的药剂
//TEXT=抽两张牌。随机消灭一个敌方随从。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_570tt5:SpellBase{
//NAME=调好的药剂
//TEXT=抽四张牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_571:MinionBase{
//NAME=邪恶药剂师
//TEXT=在你的回合结束时，随机将一份药剂置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=2|HP=4|RACE=UNDEAD
}
public class RLK_572:MinionBase{
//NAME=药剂大师普崔塞德
//TEXT=在一个随从死亡后，将一份药剂置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=1|HP=4|RACE=UNDEAD
}
public class RLK_573:SpellBase{
//NAME=鬼魅攻击
//TEXT=造成$1点伤害。<b>连击：</b>抽一张牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
		if(owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)>0)
		{
			TaskDraw();
		}
	}
}
public class RLK_590:SpellBase{
//NAME=太阳之井
//TEXT=用随机法术牌填满你的手牌。你每有一张其他手牌，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=9|ATK=0|HP=0|RACE=HOLY
}
public class RLK_591:MinionBase{
//NAME=白骨领主霜语
//TEXT=<b>亡语：</b>在本局对战的剩余时间内，每回合中你的第一张牌法力值消耗为（0）点。你的英雄会在3回合后死亡。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=UNDEAD
}
public class RLK_591e:Ability{
//NAME=巫妖死亡计数
//TEXT=你的英雄会在3回合后死亡。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_591e2:Ability{
//NAME=巫妖的死亡诅咒
//TEXT=法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_592:MinionBase{
//NAME=无敌
//TEXT=<b>复生。</b><b>战吼，亡语：</b>随机使另一个友方亡灵获得+5/+5和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=8|ATK=5|HP=5|RACE=UNDEAD
}
public class RLK_592e:Ability{
//NAME=无敌的缰绳
//TEXT=+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_593:MinionBase{
//NAME=洛瑟玛·塞隆
//TEXT=<b>战吼：</b> 使你牌库中所有随从牌的属性值翻倍。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=NONE
}
public class RLK_593e:Ability{
//NAME=精英战术
//TEXT=攻击力和生命值翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_600:SpellBase{
//NAME=阳炎冶锻
//TEXT=装备一把4/2的剑。随机使你手牌中的一张随从牌获得+4/+2。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class RLK_600e:Ability{
//NAME=过热
//TEXT=+4/+2。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_600t:WeaponBase{
//NAME=火焰大剑
//TEXT=
//MAJ=WARRIOR|COST=4|ATK=4|HP=2|RACE=NONE
}
public class RLK_601:SpellBase{
//NAME=破釜沉舟
//TEXT=抽一张<b>嘲讽</b>随从牌。<b>法力渴求（7）：</b>使其属性值翻倍。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class RLK_601e:Ability{
//NAME=坚持不懈
//TEXT=属性值翻倍。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_602:MinionBase{
//NAME=银怒坚兵
//TEXT=<b>突袭</b>。<b>扰魔</b>。<b>嘲讽</b>
//MAJ=WARRIOR|COST=6|ATK=4|HP=8|RACE=NONE
}
public class RLK_603:SpellBase{
//NAME=凤凰之光
//TEXT=抽两张牌。每有一个受伤的友方角色，本牌的法力值消耗便减少（1）点。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class RLK_604:MinionBase{
//NAME=索利贝洛尔
//TEXT=<b>突袭</b>。<b>亡语：</b>进入<b>休眠</b>状态。施放一个火焰法术以复活索利贝洛尔！
//MAJ=WARRIOR|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class RLK_604a:MinionBase{
//NAME=索利贝洛尔
//TEXT=<b>突袭</b>。<b>亡语：</b>进入<b>休眠</b>状态。施放一个火焰法术以复活索利贝洛尔！<i>（还能复活一次。）</i>
//MAJ=WARRIOR|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class RLK_604b:MinionBase{
//NAME=索利贝洛尔
//TEXT=<b>突袭</b>
//MAJ=WARRIOR|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class RLK_604t:MinionBase{
//NAME=凤凰蛋
//TEXT=<b>休眠</b> 施放一个火焰法术以复活索利贝洛尔！
//MAJ=WARRIOR|COST=21|ATK=0|HP=1|RACE=NONE
}
public class RLK_604t2:MinionBase{
//NAME=凤凰蛋
//TEXT=<b>休眠</b> 施放一个火焰法术以复活索利贝洛尔！
//MAJ=WARRIOR|COST=21|ATK=0|HP=1|RACE=NONE
}
public class RLK_605:SpellBase{
//NAME=炫目之力
//TEXT=使一个随从获得+1/+1。每有一个受伤的友方角色，重复一次。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class RLK_605e:Ability{
//NAME=着火了！
//TEXT=+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_607:MinionBase{
//NAME=搅局破法者
//TEXT=在你的回合结束时，你的对手弃掉一张法术牌。
//MAJ=WARRIOR|COST=5|ATK=4|HP=6|RACE=NONE
}
public class RLK_607e:Ability{
//NAME=破坏法术
//TEXT=储存着{0}。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_608:MinionBase{
//NAME=巨盾卫士阿斯维顿
//TEXT=<b>嘲讽</b>。<b>战吼：</b>施放你对手使用的上一张法术牌的复制。
//MAJ=WARRIOR|COST=3|ATK=3|HP=4|RACE=NONE
}
public class RLK_609:MinionBase{
//NAME=日怒勇士
//TEXT=在你施放一个火焰法术后，对所有随从造成1点伤害。
//MAJ=WARRIOR|COST=1|ATK=1|HP=3|RACE=NONE
}
public class RLK_650:MinionBase{
//NAME=盘桓僵尸
//TEXT=<b>亡语：</b>召唤一个1/1并具有“<b>亡语：</b>召唤一个1/1的僵尸”的徒手僵尸。
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class RLK_650t:MinionBase{
//NAME=徒手僵尸
//TEXT=<b>亡语：</b>召唤一个1/1的僵尸。
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class RLK_650t2:MinionBase{
//NAME=空手僵尸
//TEXT=
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class RLK_651:MinionBase{
//NAME=地穴看守者
//TEXT=<b>嘲讽</b>。你每有1点护甲值，本牌的法力值消耗便减少（1）点。
//MAJ=DRUID|COST=8|ATK=4|HP=6|RACE=UNDEAD
}
public class RLK_652:SpellBase{
//NAME=无尽虫群
//TEXT=复活所有法力值消耗小于或等于（2）点的友方随从。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NONE
}
public class RLK_653:MinionBase{
//NAME=感染的食尸鬼
//TEXT=<b>亡语：</b>随机使一个友方随从获得“<b>亡语：</b>召唤一个感染的食尸鬼。”
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=UNDEAD
}
public class RLK_653e:Ability{
//NAME=被感染
//TEXT=<b>亡语：</b>召唤一个感染的食尸鬼。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_654:SpellBase{
//NAME=甲虫通灵术
//TEXT=<b>抉择：</b>获得12点护甲值；或者召唤两只3/3并具有<b>嘲讽</b>的甲虫。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class RLK_654a:SpellBase{
//NAME=甲虫汁液
//TEXT=获得12点护甲值。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class RLK_654b:SpellBase{
//NAME=爬虫点心
//TEXT=召唤两只3/3并具有<b>嘲讽</b>的甲虫。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class RLK_654t:MinionBase{
//NAME=甲虫
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class RLK_655:SpellBase{
//NAME=枯萎
//TEXT=选择一个随从。每个友方亡灵各从选中的随从处偷取1点攻击力和生命值。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class RLK_655e:Ability{
//NAME=枯竭
//TEXT=属性值降低。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_655e2:Ability{
//NAME=生命虹吸
//TEXT=属性值提高。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_655e2a:Ability{
//NAME=Life Siphon
//TEXT=Increased Attack.
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_655e2b:Ability{
//NAME=Life Siphon
//TEXT=Increased Health.
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_655ea:Ability{
//NAME=Withered
//TEXT=Reduced Attack.
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_655eb:Ability{
//NAME=Withered
//TEXT=Reduced Health.
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_656:SpellBase{
//NAME=壳质护板
//TEXT=获得4点护甲值。在你的下个回合开始时，再获得4点。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_656e:Ability{
//NAME=蜕壳
//TEXT=下个回合获得4点护甲值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_657:MinionBase{
//NAME=地底虫王
//TEXT=<b>突袭</b>。<b>战吼，亡语：</b>获得6点护甲值。
//MAJ=DRUID|COST=7|ATK=6|HP=6|RACE=UNDEAD
}
public class RLK_658:MinionBase{
//NAME=纳多克斯长老
//TEXT=<b>战吼：</b>消灭一个友方亡灵，你的所有随从获得其攻击力。
//MAJ=DRUID|COST=5|ATK=5|HP=4|RACE=UNDEAD
}
public class RLK_658e:Ability{
//NAME=纳多克斯之力
//TEXT=属性值提高。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_659:MinionBase{
//NAME=阿努布雷坎
//TEXT=<b>战吼：</b>获得5点护甲值。在本回合中，你的下3张随从牌消耗护甲值而非法力值。
//MAJ=DRUID|COST=8|ATK=7|HP=7|RACE=UNDEAD
}
public class RLK_659e:Ability{
//NAME=硬化甲壳
//TEXT=在本回合中，你的下3张随从牌消耗护甲值而非法力值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_659e2:Ability{
//NAME=硬化甲壳
//TEXT=消耗护甲值，而非法力值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_677:MinionBase{
//NAME=圣殿扰咒师
//TEXT=每当你的对手以另一随从为目标施放法术时，使其改为指向本随从。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=NONE
}
public class RLK_705:SpellBase{
//NAME=墓地夜战
//TEXT=召唤两个1/1并具有<b>复生</b>的僵尸。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_705t:MinionBase{
//NAME=蹒跚的僵尸
//TEXT=<b>复生</b>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class RLK_706:MinionBase{
//NAME=亚历山德罗斯·莫格莱尼
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，在你的回合结束时，对你的对手造成3点伤害。
//MAJ=DEATHKNIGHT|COST=7|ATK=7|HP=7|RACE=UNDEAD
	public override void Battlecry(Card target=null)
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		TaskDamageEnemyHero(3);
	}
}
public class RLK_706e3:Ability{
//NAME=莫格莱尼来摸你
//TEXT=在本局对战的剩余时间内，在你的回合结束时，对你的对手造成3点伤害。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_707:SpellBase{
//NAME=墓地之力
//TEXT=使你的所有随从获得+1攻击力。消耗5具<b>尸体</b>，改为获得+3攻击力。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_707e:Ability{
//NAME=墓地印记
//TEXT=+1攻击力
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_707e2:Ability{
//NAME=墓地力量
//TEXT=+3攻击力。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_708:MinionBase{
//NAME=堕寒男爵
//TEXT=<b>战吼，亡语：</b>抽一张牌。
//MAJ=DEATHKNIGHT|COST=3|ATK=2|HP=2|RACE=UNDEAD
	public override void Battlecry(Card target=null)
	{
		TaskDraw();
	}
	public override void Deathrattle()
	{
		TaskDraw();
	}
}
public class RLK_709:SpellBase{
//NAME=冷酷严冬
//TEXT=对所有敌人造成$2点伤害。抽一张牌。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=FROST
	public override void Battlecry(Card target=null)
	{
		TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),2);
		TaskDraw();
	}
}
public class RLK_710:WeaponBase{
//NAME=霜牙之剑
//TEXT=在你的英雄攻击后，使你手牌中一张法术牌的法力值消耗减少（1）点。
//MAJ=DEATHKNIGHT|COST=3|ATK=2|HP=3|RACE=NONE
}
public class RLK_710e:Ability{
//NAME=冰封之风
//TEXT=法力值消耗减少（1）点。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_711:MinionBase{
//NAME=凶恶的血虫
//TEXT=<b>战吼：</b> 使你手牌中的一张随从牌获得等同于本随从攻击力的攻击力。
//MAJ=DEATHKNIGHT|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class RLK_711e:Ability{
//NAME=血虫馈赠
//TEXT=攻击力提高。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_712:SpellBase{
//NAME=活力分流
//TEXT=使你手牌中的所有随从牌获得+1/+1。消耗2具<b>尸体</b>，再获得+1/+1。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListBuff = new List<Card>();
		foreach(Card c in owner.myPlayer.hand)
		{
			if(c.cardType==CardType.Minion)
			{
				ToListBuff.Add(c);
			}
		}
		TaskBuffTargets(ToListBuff,atk:1,hp:1);
		if(owner.myPlayer.GetTag(GameTag.CntCorpse)>=2)
		{
			owner.myPlayer.ChangeTag(GameTag.CntCorpse,-2);
			TaskBuffTargets(ToListBuff,atk:1,hp:1);
		}
	}
}
public class RLK_712e:Ability{
//NAME=分流活力
//TEXT=+1/+1。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_713:MinionBase{
//NAME=亡语者女士
//TEXT=<b>亡语：</b>复制你手牌中的所有冰霜法术牌。
//MAJ=DEATHKNIGHT|COST=4|ATK=4|HP=3|RACE=UNDEAD
}
public class RLK_715:SpellBase{
//NAME=符文熔铸
//TEXT=抽一张武器牌。消耗一具<b>尸体</b>，使其法力值消耗减少（1）点。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_715e:Ability{
//NAME=符文铸炼
//TEXT=法力值消耗减少（1）点。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_720:MinionBase{
//NAME=侏儒嚼嚼怪
//TEXT=<b>嘲讽</b>，<b>吸血</b>。在你的回合结束时，攻击生命值最低的敌人。
//MAJ=DEATHKNIGHT|COST=6|ATK=5|HP=6|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskInitAbility("LifeSteal");
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(CondInPlay())
		{
			Card Target = null;
			foreach(Card c in owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero))
			{
				if(c!=null)
				{
					if(Target!=null)
					{
						if(c.GetTag(GameTag.Health)<=Target.GetTag(GameTag.Health))
						{
							Target=c;
						}
					}
					else{
						Target=c;
					}
				}
			}
			if(Target!=null)
				new EffectAttack(owner.myPlayer,owner,Target).Resolve();
		}
	}
}
public class RLK_730:SpellBase{
//NAME=血液沸腾
//TEXT=<b>吸血</b>。感染所有敌方随从。在你的回合结束时，使其受到2点伤害。
//MAJ=DEATHKNIGHT|COST=5|ATK=0|HP=0|RACE=SHADOW
	private List<Card> Affected = new List<Card>();
	public override void Init()
	{
		TaskInitAbility("LifeSteal");
	}
	public override void Battlecry(Card target=null)
	{
		Affected = owner.myPlayer.otherPlayer.board;
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		TaskDamageTargets(this.Affected,2);
		for(int i=this.Affected.Count-1;i>=0;i--)
		{
			if(this.Affected[i].GetTag(GameTag.ZoneType)!=(int)ZoneType.Board)
			{
				this.Affected.RemoveAt(i);
			}
		}
	}
}
public class RLK_730e:Ability{
//NAME=沸腾之血
//TEXT=在你的对手回合结束时，受到2点伤害。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_731:MinionBase{
//NAME=黑暗堕落者新兵
//TEXT=<b>战吼：</b>消耗2具<b>尸体</b>，使你手牌中的所有随从牌获得+2攻击力。
//MAJ=DEATHKNIGHT|COST=3|ATK=2|HP=5|RACE=UNDEAD
}
public class RLK_731e:Ability{
//NAME=堕入黑暗
//TEXT=+2攻击力。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_740:WeaponBase{
//NAME=米奈希尔之力
//TEXT=<b>战吼：</b>消耗最多3具<b>尸体</b>，<b>冻结</b>等量的敌方随从。
//MAJ=DEATHKNIGHT|COST=4|ATK=4|HP=2|RACE=NONE
}
public class RLK_741:MinionBase{
//NAME=窃魂者
//TEXT=<b>战吼：</b> 消灭所有其他随从。每消灭一个敌方随从，获得1具<b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=8|ATK=5|HP=5|RACE=UNDEAD
}
public class RLK_744:MinionBase{
//NAME=缝合巨人
//TEXT=在本局对战中，你每消耗过一具<b>尸体</b>，本牌的法力值消耗便减少（1）点。
//MAJ=DEATHKNIGHT|COST=9|ATK=8|HP=8|RACE=UNDEAD
}
public class RLK_745:MinionBase{
//NAME=恶毒恐魔
//TEXT=<b>复生</b>。 在你的回合结束时，消耗4具<b>尸体</b>，召唤一个本随从的复制。
//MAJ=DEATHKNIGHT|COST=4|ATK=2|HP=4|RACE=UNDEAD
}
public class RLK_752:MinionBase{
//NAME=霜雪塑形师
//TEXT=<b>战吼：</b>召唤两个2/1且具有“<b>亡语：</b>随机对一个敌人造成2点伤害。”的白霜元素。
//MAJ=DEATHKNIGHT|COST=5|ATK=4|HP=3|RACE=UNDEAD
}
public class RLK_753:MinionBase{
//NAME=掘骨恶鬼
//TEXT=<b>战吼：</b>消耗一具<b>尸体</b>，获得+1/+2。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_753e:Ability{
//NAME=开挖
//TEXT=+1/+2。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_790t:SpellBase{
//NAME=临时-太阳之井追踪器
//TEXT=<b>太阳之井</b>={0}
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_803:MinionBase{
//NAME=大法师罗曼斯
//TEXT=<b>战吼：</b>再次施放你在本局对战中施放的每个套牌之外的法术。
//MAJ=MAGE|COST=9|ATK=5|HP=7|RACE=NONE
}
public class RLK_803e:Ability{
//NAME=发力充盈
//TEXT=你的奥术法术会施放两次。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_804:SpellBase{
//NAME=咒术之箭
//TEXT=对一个随从造成$2点伤害。<b>法力渴求（6）：</b>抽取相同数量的牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class RLK_812:SpellBase{
//NAME=起尸术
//TEXT=复活一个法力值消耗小于或等于（3）点的友方随从。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_813:MinionBase{
//NAME=白骨召唤者
//TEXT=<b>嘲讽</b>。<b>亡语：</b>复活一个在本局对战中死亡的友方亡灵。
//MAJ=PRIEST|COST=4|ATK=2|HP=5|RACE=NONE
}
public class RLK_814:MinionBase{
//NAME=异教水晶工匠
//TEXT=<b>战吼：</b>如果你的手牌中有暗影法术牌，获得+1/+1。
//MAJ=PRIEST|COST=1|ATK=1|HP=2|RACE=NONE
}
public class RLK_814e:Ability{
//NAME=暗影流转
//TEXT=+1/+1
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_815:SpellBase{
//NAME=暗言术：丧
//TEXT=对所有敌人造成$2点伤害。如果在你的上回合之后有友方亡灵死亡，则再造成$2点。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_816:MinionBase{
//NAME=女武神席瓦娜
//TEXT=<b>战吼：</b> 将一张黑暗幻象<i>永久</i>置入你的手牌。
//MAJ=PRIEST|COST=6|ATK=6|HP=6|RACE=UNDEAD
}
public class RLK_816t3:SpellBase{
//NAME=黑暗幻象
//TEXT=<b>发现</b>一张暗影法术牌。<i>（本牌保留在你手牌中。）</i>
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_817:SpellBase{
//NAME=奥术箭袋
//TEXT=从你的牌库中<b>发现</b>一张法术牌。如果选中的是奥术法术牌，使其获得<b>法术伤害+1</b>。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class RLK_818:SpellBase{
//NAME=弹溅射击
//TEXT=随机对三个敌人造成$1点伤害。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class RLK_819:SpellBase{
//NAME=永歌传送门
//TEXT=召唤$1只4/4并具有<b>突袭</b>的山猫<i>（受<b>法术伤害</b>加成影响）</i>。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class RLK_819t:MinionBase{
//NAME=永歌山猫
//TEXT=<b>突袭</b>
//MAJ=HUNTER|COST=4|ATK=4|HP=4|RACE=BEAST
}
public class RLK_820:MinionBase{
//NAME=哈杜伦·明翼
//TEXT=<b>战吼：</b>使你手牌和牌库中所有奥术法术牌获得<b>法术伤害+1</b>。
//MAJ=HUNTER|COST=3|ATK=3|HP=4|RACE=NONE
}
public class RLK_821:MinionBase{
//NAME=天灾驯兽师
//TEXT=<b>战吼：</b>制造一个自定义的僵尸兽。
//MAJ=HUNTER|COST=1|ATK=1|HP=2|RACE=UNDEAD
}
public class RLK_822:MinionBase{
//NAME=纠缠梦魇
//TEXT=<b>亡语：</b>纠缠你的一张手牌。当你使用被纠缠的牌时，召唤一个4/3的士兵。
//MAJ=PRIEST|COST=3|ATK=4|HP=3|RACE=UNDEAD
}
public class RLK_822e:Ability{
//NAME=冷汗
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_822e2:Ability{
//NAME=暗夜恐怖
//TEXT=召唤一个4/3的士兵。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_822t:MinionBase{
//NAME=被纠缠的士兵
//TEXT=
//MAJ=PRIEST|COST=3|ATK=4|HP=3|RACE=NONE
}
public class RLK_823:SpellBase{
//NAME=不死盟军
//TEXT=在本回合中，在你使用一张亡灵牌后，使其获得<b>复生</b>。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_823e:Ability{
//NAME=墓地召唤
//TEXT=在本回合中，在你使用一张亡灵牌后，使其获得<b>复生</b>。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_824:MinionBase{
//NAME=肢体商贩
//TEXT=在你召唤一个亡灵后，使其获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=UNDEAD
}
public class RLK_824e:Ability{
//NAME=亡灵强韧
//TEXT=+1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_825:MinionBase{
//NAME=哮雷龙鹰
//TEXT=<b>战吼：</b>造成1点伤害。<i>（在本局对战中，你的英雄每攻击一次都会提升！）</i>
//MAJ=HUNTER|COST=4|ATK=3|HP=3|RACE=BEAST
}
public class RLK_826:MinionBase{
//NAME=银月城远行者
//TEXT=<b>战吼：</b>使你手牌中所有奥术法术牌获得<b>法术伤害+1</b>。
//MAJ=HUNTER|COST=2|ATK=2|HP=3|RACE=NONE
}
public class RLK_826e:Ability{
//NAME=银月城远行者的法强
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_827:MinionBase{
//NAME=锐眼侦察兵
//TEXT=每当你的英雄攻击随从时，将被攻击随从的生命值变为1。
//MAJ=HUNTER|COST=3|ATK=3|HP=4|RACE=NONE
}
public class RLK_827e:Ability{
//NAME=猎人印记
//TEXT=本随从的生命值变为1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_828:WeaponBase{
//NAME=奎尔萨拉斯的希望
//TEXT=在你的英雄攻击后，使你的所有随从获得+1/+1<i>（无论它们在哪）</i>。
//MAJ=HUNTER|COST=6|ATK=4|HP=2|RACE=NONE
}
public class RLK_828e:Ability{
//NAME=太阳之井的光辉
//TEXT=+1/+1
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_829:SpellBase{
//NAME=挖坟掘墓
//TEXT=抽两张牌。如果在你的上回合之后有友方亡灵死亡，本牌的法力值消耗为（1）点。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_830:MinionBase{
//NAME=血肉巨兽
//TEXT=<b>嘲讽</b>。<b>亡语：</b>抽取另一张亡灵牌并召唤一个它的复制。
//MAJ=NEUTRAL|COST=9|ATK=4|HP=8|RACE=UNDEAD
}
public class RLK_831:MinionBase{
//NAME=魔药播撒者
//TEXT=<b>亡语：</b>随机将你对手手牌中的一张随从牌变形成为魔药播撒者。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class RLK_832:MinionBase{
//NAME=高阶教徒巴萨莱弗
//TEXT=<b>战吼：</b>复活在你的上回合之后死亡的所有友方亡灵。
//MAJ=PRIEST|COST=4|ATK=3|HP=5|RACE=NONE
}
public class RLK_833:MinionBase{
//NAME=骨鸡蛋
//TEXT=<b>亡语：</b>召唤一只3/3的亡灵小鸡。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=2|RACE=UNDEAD
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("RLK_833t"),ZoneType.Board);
	}
}
public class RLK_833t:MinionBase{
//NAME=骨积咕咕鸡
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class RLK_834:MinionBase{
//NAME=蛛魔元老
//TEXT=<b>战吼：</b><b>发现</b>一张法术牌。如果在你的上回合之后有友方亡灵死亡，其法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=UNDEAD
}
public class RLK_834e:Ability{
//NAME=蛛魔视界
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_843:SpellBase{
//NAME=奥术箭
//TEXT=造成$2点伤害。<b>法力渴求（8）：</b>改为造成$3点伤害。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=8)
		{
			new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
		}
		else{
			new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
		}
	}
}
public class RLK_845:MinionBase{
//NAME=心灵吞食者
//TEXT=<b>亡语：</b>将你对手牌库中的一张牌的复制置入你的手牌。
//MAJ=PRIEST|COST=2|ATK=3|HP=2|RACE=UNDEAD
}
public class RLK_867:MinionBase{
//NAME=维库通灵师
//TEXT=<b>战吼：</b>使一个友方随从获得“<b>亡语：</b>召唤一个2/2并具有<b>突袭</b>的僵尸。”
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_867e:Ability{
//NAME=通灵之光
//TEXT=<b>亡语：</b>召唤一个2/2并具有<b>突袭</b>的僵尸。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_900:MinionBase{
//NAME=天灾暴怒者
//TEXT=<b>复生</b>，<b>战吼：</b>死亡。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=4|RACE=UNDEAD
}
public class RLK_907t:MinionBase{
//NAME=白霜元素
//TEXT=<b>亡语：</b>随机对一个敌人造成2点伤害。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=1|RACE=ELEMENTAL
}
public class RLK_909:SpellBase{
//NAME=织亡者光环
//TEXT=使一个随从获得“<b>亡语：</b>召唤两个3/2的僵尸。”<b>过载：</b>（1）
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_909e:Ability{
//NAME=巫毒与你同在
//TEXT=<b>亡语：</b>召唤两个3/2的僵尸。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_909t:MinionBase{
//NAME=达卡莱僵尸
//TEXT=
//MAJ=SHAMAN|COST=2|ATK=3|HP=2|RACE=UNDEAD
}
public class RLK_910:SpellBase{
//NAME=暗影弥漫
//TEXT=使你的所有随从获得“<b>亡语：</b>随机对一个敌人造成3点伤害。”
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_910e:Ability{
//NAME=魔精飞弹
//TEXT=<b>亡语：</b>随机对一个敌人造成3点伤害。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_911:SpellBase{
//NAME=彼界来客
//TEXT=召唤你手牌中每一个随从的复制。使其随机攻击敌方随从，然后死亡。
//MAJ=SHAMAN|COST=9|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_912:MinionBase{
//NAME=天灾巨魔
//TEXT=本随从获得的<b>亡语</b>会触发两次。
//MAJ=SHAMAN|COST=1|ATK=1|HP=3|RACE=UNDEAD
}
public class RLK_913:MinionBase{
//NAME=达库鲁大王
//TEXT=<b>突袭</b>，<b>风怒</b>。 在本随从攻击并消灭随从后，为你复活被消灭的随从。
//MAJ=SHAMAN|COST=9|ATK=6|HP=8|RACE=NONE
}
public class RLK_914:MinionBase{
//NAME=幽影恶鬼
//TEXT=<b>亡语：</b> 随机将一张暗影法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=1|RACE=UNDEAD
}
public class RLK_915:MinionBase{
//NAME=琥珀雏龙
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，则造成3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=DRAGON
}
public class RLK_916:MinionBase{
//NAME=胆大的幼龙
//TEXT=<b>突袭</b>。<b>战吼：</b>如果你的手牌中有龙牌，便获得+1/+1。
//MAJ=PALADIN|COST=4|ATK=4|HP=4|RACE=DRAGON
}
public class RLK_916e:Ability{
//NAME=英勇
//TEXT=+1/+1
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_917:SpellBase{
//NAME=青铜龙军团
//TEXT=<b>发现</b>一张龙牌。<b>法力渴求（7）：</b>召唤一条5/5并具有<b>嘲讽</b>的幼龙。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class RLK_917t:MinionBase{
//NAME=青铜防御者
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=DRAGON
}
public class RLK_918:SpellBase{
//NAME=为了奎尔萨拉斯！
//TEXT=使一个友方随从获得+3攻击力。在本回合中，使你的英雄获得+2攻击力。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class RLK_918e:Ability{
//NAME=为了奎尔萨拉斯！
//TEXT=+3攻击力
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_918e2:Ability{
//NAME=为了奎尔萨拉斯！
//TEXT=+2攻击力。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_919:MinionBase{
//NAME=阿纳克洛斯
//TEXT=<b>战吼：</b> 将所有其他随从送入2回合后的未来。
//MAJ=PALADIN|COST=7|ATK=8|HP=8|RACE=DRAGON
}
public class RLK_919e:Ability{
//NAME=时间旅行
//TEXT=将一个随从送入2回合后的未来。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_921:MinionBase{
//NAME=血色士兵
//TEXT=<b>圣盾</b>。<b>战吼：</b>对你的英雄造成2点伤害。
//MAJ=PALADIN|COST=1|ATK=2|HP=1|RACE=NONE
}
public class RLK_922:SpellBase{
//NAME=鲜血圣印
//TEXT=使一个随从获得+3/+3和<b>圣盾</b>。对你的英雄造成$3点伤害。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class RLK_922e:Ability{
//NAME=血之圣印
//TEXT=+3/+3
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_923:SpellBase{
//NAME=馑时锦食
//TEXT=在本回合中，使你的英雄获得+3攻击力。<b>法力渴求（4）：</b>以及<b>吸血</b>。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class RLK_923e1:Ability{
//NAME=锦食
//TEXT=在本回合中+3攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_923e3:Ability{
//NAME=馑时
//TEXT=在本回合中<b>吸血</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_924:MinionBase{
//NAME=血骑士领袖莉亚德琳
//TEXT=在你召唤攻击力低于本随从的随从后，使其获得<b>圣盾</b>和<b>突袭</b>。
//MAJ=PALADIN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class RLK_924e:Ability{
//NAME=鲜血淬炼
//TEXT=获得<b>突袭</b>和<b>圣盾</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_926:MinionBase{
//NAME=浴血骑士
//TEXT=在你的回合结束时，对你的英雄造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=5|RACE=NONE
}
public class RLK_927:MinionBase{
//NAME=鲜血远征军
//TEXT=<b>战吼：</b>在本回合中，你的下一个圣骑士随从消耗生命值，而非法力值。
//MAJ=PALADIN|COST=6|ATK=5|HP=5|RACE=NONE
}
public class RLK_927e:Ability{
//NAME=征伐
//TEXT=消耗生命值，而非法力值。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_950:MinionBase{
//NAME=传送导师
//TEXT=<b>战吼：</b>选择一个敌方随从，与敌方牌库中的随机一个随从交换。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class RLK_951:MinionBase{
//NAME=验尸官
//TEXT=<b>战吼：</b><b>冻结</b>一个敌方随从。<b>法力渴求（6）：</b>先将其<b>沉默</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class RLK_952:MinionBase{
//NAME=附魔师
//TEXT=在你的回合中，敌方随从受到的伤害翻倍。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class RLK_955:MinionBase{
//NAME=银月城军备官
//TEXT=<b>突袭</b>。<b>法力渴求（7）：</b>获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class RLK_955e:Ability{
//NAME=补给充足
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_956:MinionBase{
//NAME=蛛魔飞虫
//TEXT=<b>战吼：</b>如果在你的上回合之后有友方亡灵死亡，召唤一个2/2的蛛魔。
//MAJ=DRUID|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class RLK_956t:MinionBase{
//NAME=飞掠蛛魔
//TEXT=
//MAJ=DRUID|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_957:MinionBase{
//NAME=女妖
//TEXT=<b>亡语：</b>随机使一个友方亡灵获得+2/+1。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=UNDEAD
}
public class RLK_957e:Ability{
//NAME=女妖的哀嚎
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_958:MinionBase{
//NAME=骷髅帮手
//TEXT=<b>战吼：</b>使一个友方亡灵获得+2攻击力。
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=2|RACE=UNDEAD
}
public class RLK_958e:Ability{
//NAME=骨弓之助
//TEXT=+2攻击力。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_960:SpellBase{
//NAME=力量余烬
//TEXT=召唤两个1/2并具有<b>嘲讽</b>的守卫。<b>法力渴求（6）：</b>使其获得+1/+2。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class RLK_960e:Ability{
//NAME=强化的余烬
//TEXT=+1/+2。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_960t:MinionBase{
//NAME=烬缚守卫
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=1|ATK=1|HP=2|RACE=NONE
}
public class RLK_970:MinionBase{
//NAME=陆行鸟牧人
//TEXT=每当你使用一张随从牌，使其获得+1/+1和“<b>亡语：</b>召唤一只1/1的陆行鸟。”
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=NONE
}
public class RLK_970e:Ability{
//NAME=陆行鸟骑术
//TEXT=+1/+1。<b>亡语：</b>召唤一只1/1的陆行鸟。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_970t:MinionBase{
//NAME=陆行鸟
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class RLK_COIN1:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_COIN2:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_025:SpellBase{
//NAME=冰霜打击
//TEXT=对一个随从造成$3点伤害。如果该随从死亡，<b>发现</b>一张冰霜符文牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=FROST
}
public class RLK_Prologue_056:SpellBase{
//NAME=邪恶狂热
//TEXT=选择一个敌方随从，使你的所有随从攻击该随从。再次召唤死亡的友方随从。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_066:MinionBase{
//NAME=鲜血魔术师
//TEXT=<b>战吼：</b>消耗一具<b>尸体</b>，<b>发现</b>一张鲜血符文牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=3|RACE=NONE
}
public class RLK_Prologue_218:MinionBase{
//NAME=银月城奥术师
//TEXT=<b>法术伤害+2</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class RLK_Prologue_219:MinionBase{
//NAME=日怒教士
//TEXT=<b>战吼：</b>为所有友方角色恢复3点生命值。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class RLK_Prologue_503:MinionBase{
//NAME=扛包收尸人
//TEXT=<b>战吼：</b>获得一具<b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=3|RACE=UNDEAD
}
public class RLK_Prologue_518:MinionBase{
//NAME=银月城哨兵
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=NONE
}
public class RLK_Prologue_804:SpellBase{
//NAME=咒术之箭
//TEXT=对一个随从造成$2点伤害。抽两张牌。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class RLK_Prologue_Anasterian_003t:MinionBase{
//NAME=安纳斯特里亚·逐日者
//TEXT=<b>突袭</b>。同时对其攻击目标相邻的随从造成伤害。
//MAJ=PALADIN|COST=5|ATK=5|HP=12|RACE=BLOODELF
}
public class RLK_Prologue_Arthas_001hp:HeroBase{
//NAME=阿尔萨斯
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_Arthas_001hp2:HeroBase{
//NAME=阿尔萨斯
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_Arthas_001p:HeroPowerBase{
//NAME=援军
//TEXT=<b>英雄技能</b> 召唤一个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_Arthas_002hp:HeroBase{
//NAME=阿尔萨斯
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_Arthas_002p:HeroPowerBase{
//NAME=食尸鬼冲锋
//TEXT=<b>英雄技能</b> 召唤一个1/1并具有<b>冲锋</b>的食尸鬼。它会在回合结束时死亡。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_Arthas_003hp:HeroBase{
//NAME=阿尔萨斯
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_Arthas_003p:HeroPowerBase{
//NAME=食尸鬼冲锋
//TEXT=<b>英雄技能</b> 召唤一个1/1并具有<b>冲锋</b>的食尸鬼。它会在回合结束时死亡。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_Arthas_004hp:HeroBase{
//NAME=阿尔萨斯
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_Arthas_004p:HeroPowerBase{
//NAME=食尸鬼冲锋
//TEXT=<b>英雄技能</b> 召唤一个1/1并具有<b>冲锋</b>的食尸鬼。它会在回合结束时死亡。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_AT_020:MinionBase{
//NAME=恐怖末日守卫
//TEXT=
//MAJ=WARLOCK|COST=7|ATK=6|HP=8|RACE=DEMON
}
public class RLK_Prologue_AT_074:SpellBase{
//NAME=英勇圣印
//TEXT=使一个随从获得+3攻击力和 <b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class RLK_Prologue_AT_074e2:Ability{
//NAME=英勇圣印
//TEXT=+3攻击力并具有<b>圣盾</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_AT_075:MinionBase{
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
public class RLK_Prologue_AT_075e:Ability{
//NAME=骑士之威
//TEXT=战马训练师使其获得+2攻击力和<b>嘲讽</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_AV_269:SpellBase{
//NAME=侧翼合击
//TEXT=召唤一个4/2并具有<b>突袭</b>的恶魔。如果它在本回合中死亡，再召唤一个。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_AV_269e:Ability{
//NAME=Woe Is Me
//TEXT=If this dies summon another.
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_AV_269t:MinionBase{
//NAME=落雪萨特
//TEXT=<b>突袭</b>
//MAJ=DEMONHUNTER|COST=3|ATK=4|HP=2|RACE=DEMON
}
public class RLK_Prologue_BAR_032:SpellBase{
//NAME=穿刺射击
//TEXT=对一个随从造成$6点伤害，超过目标生命值的伤害会命中敌方英雄。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_BAR_871:MinionBase{
//NAME=士兵车队
//TEXT=在你的回合开始时，召唤两个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=1|HP=3|RACE=NONE
}
public class RLK_Prologue_Bow_003w:WeaponBase{
//NAME=风行者战弓
//TEXT=在你的英雄攻击后，召唤两个银月城哨兵。
//MAJ=HUNTER|COST=5|ATK=3|HP=2|RACE=NONE
}
public class RLK_Prologue_BRM_013:SpellBase{
//NAME=快速射击
//TEXT=造成$3点伤害。 如果你没有其他手牌，则抽一张牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_BT_035:SpellBase{
//NAME=混乱打击
//TEXT=在本回合中，使你的英雄获得+2攻击力。抽一张牌。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=FEL
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(atk:2);
		TaskDraw();
	}
}
public class RLK_Prologue_BT_035e:Ability{
//NAME=混乱打击
//TEXT=在本回合中获得+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_BT_036:SpellBase{
//NAME=协同打击
//TEXT=召唤三个1/1并具有<b>突袭</b>的伊利达雷。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_036t"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_036t"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_036t"),ZoneType.Board);
	}
}
public class RLK_Prologue_BT_036t:MinionBase{
//NAME=伊利达雷新兵
//TEXT=<b>突袭</b>
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=NONE
}
public class RLK_Prologue_BT_351:MinionBase{
//NAME=战斗邪犬
//TEXT=在你的英雄攻击后，获得+1攻击力。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=2|RACE=DEMON
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(owner.myPlayer.hero.Count>0)
			{
				if(sc==owner.myPlayer.hero[0])
				{
					new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
				}
			}
		}
	}
}
public class RLK_Prologue_BT_351e:Ability{
//NAME=邪能驱使
//TEXT=攻击力提高。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_BT_416:MinionBase{
//NAME=暴怒邪吼者
//TEXT=<b>战吼：</b>你的下一张恶魔牌的法力值消耗减少（2）点。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=4|RACE=NONE
}
public class RLK_Prologue_BT_416e:Ability{
//NAME=邪能之吼
//TEXT=你的下一张恶魔牌的法力值消耗减少（2）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_BT_423:MinionBase{
//NAME=灰舌将领
//TEXT=<b>嘲讽，吸血</b>
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=5|RACE=NONE
}
public class RLK_Prologue_BT_430:WeaponBase{
//NAME=埃辛诺斯战刃
//TEXT=在攻击一个随从后，你的英雄可以再次攻击。
//MAJ=DEMONHUNTER|COST=5|ATK=3|HP=3|RACE=NONE
}
public class RLK_Prologue_BT_491:SpellBase{
//NAME=幽灵视觉
//TEXT=抽一张牌。<b>流放：</b>再抽一张。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_BT_512:SpellBase{
//NAME=心中的恶魔
//TEXT=在本回合中，使你的英雄获得+8 攻击力。
//MAJ=DEMONHUNTER|COST=8|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(atk:8);
	}
}
public class RLK_Prologue_BT_512e:Ability{
//NAME=恶魔之力
//TEXT=+8攻击力
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_BT_514:SpellBase{
//NAME=献祭光环
//TEXT=对所有随从造成$1点伤害两次。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=FEL
}
public class RLK_Prologue_BT_601:SpellBase{
//NAME=古尔丹之颅
//TEXT=抽三张牌。<b>流放：</b>这些牌的法力值消耗减少（3）点。
//MAJ=DEMONHUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_CS2_087:SpellBase{
//NAME=力量祝福
//TEXT=使一个随从获得+3攻击力。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class RLK_Prologue_CS2_087_AI:SpellBase{
//NAME=力量祝福
//TEXT=使一个随从获得+3攻击力。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class RLK_Prologue_CS2_087e:Ability{
//NAME=力量祝福
//TEXT=+3攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_CS2_091:WeaponBase{
//NAME=圣光的正义
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=4|RACE=NONE
}
public class RLK_Prologue_CS2_092:SpellBase{
//NAME=王者祝福
//TEXT=使一个随从获得+4/+4。<i>（+4攻击力/+4生命值）</i>
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class RLK_Prologue_CS2_092_AI:SpellBase{
//NAME=王者祝福
//TEXT=使一个随从获得+4/+4。<i>（+4攻击力/+4生命值）</i>
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class RLK_Prologue_CS2_092e:Ability{
//NAME=王者祝福
//TEXT=+4/+4。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_CS2_093:SpellBase{
//NAME=奉献
//TEXT=对所有敌人造成$2点伤害。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),2);
    }
}
public class RLK_Prologue_CS2_094:SpellBase{
//NAME=愤怒之锤
//TEXT=造成$3点伤害。抽一张牌。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        TaskDraw();
    }
}
public class RLK_Prologue_CS3_017:MinionBase{
//NAME=甘尔葛战刃铸造师
//TEXT=<b>流放：</b>在本回合中，使你的英雄获得+3攻击力。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=2|RACE=DEMON
}
public class RLK_Prologue_CS3_017e:Ability{
//NAME=邪能重拳
//TEXT=在本回合中+3攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_CS3_029:SpellBase{
//NAME=正义追击
//TEXT=使你本局对战中召唤的白银之手新兵获得+1攻击力。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class RLK_Prologue_CS3_029e:Ability{
//NAME=正义追击
//TEXT=你的白银之手新兵拥有+1攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_CS3_029e2:Ability{
//NAME=正义追击
//TEXT=+1攻击力
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_DAL_373:SpellBase{
//NAME=奇迹瞬间
//TEXT=<b>双生法术</b> 造成$2点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_DAL_373ts:SpellBase{
//NAME=奇迹瞬间
//TEXT=造成$2点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_DMF_056e:Ability{
//NAME=古神之血
//TEXT=消耗生命值，而非法力值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_DMF_222:MinionBase{
//NAME=获救的流民
//TEXT=在你使用一张<b>流放</b>牌后，获得+1/+1。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=3|RACE=NONE
}
public class RLK_Prologue_DMF_222e:Ability{
//NAME=流民的决心
//TEXT=+1/+1。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_DS1_183:SpellBase{
//NAME=多重射击
//TEXT=随机对两个敌方随从造成$3点 伤害。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_DS1_185:SpellBase{
//NAME=奥术射击
//TEXT=造成$2点伤害。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=ARCANE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
    }
}
public class RLK_Prologue_EX1_008:MinionBase{
//NAME=银色侍从
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class RLK_Prologue_EX1_044e:Ability{
//NAME=等级提升
//TEXT=攻击力和生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_EX1_185:MinionBase{
//NAME=攻城恶魔
//TEXT=<b>嘲讽</b> 你的其他恶魔拥有+1攻击力。
//MAJ=WARLOCK|COST=7|ATK=5|HP=8|RACE=DEMON
}
public class RLK_Prologue_EX1_185e:Ability{
//NAME=攻城略地
//TEXT=攻城恶魔使本随从获得+1攻击力。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_EX1_302:SpellBase{
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
public class RLK_Prologue_EX1_309:SpellBase{
//NAME=灵魂虹吸
//TEXT=消灭一个随从，为你的英雄恢复#3点生命值。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_Prologue_EX1_313:MinionBase{
//NAME=深渊领主
//TEXT=<b>战吼：</b>对你的英雄造成5点伤害。
//MAJ=WARLOCK|COST=4|ATK=5|HP=6|RACE=DEMON
}
public class RLK_Prologue_EX1_317:SpellBase{
//NAME=感知恶魔
//TEXT=从你的牌库中抽两张恶魔牌。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
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
public class RLK_Prologue_EX1_319:MinionBase{
//NAME=烈焰小鬼
//TEXT=<b>战吼：</b>对你的英雄造成3点伤害。
//MAJ=WARLOCK|COST=1|ATK=3|HP=2|RACE=DEMON
	public override void Battlecry(Card target=null)
	{
		TaskDamageMyHero(3);
	}
}
public class RLK_Prologue_EX1_349:SpellBase{
//NAME=神恩术
//TEXT=抽若干数量的牌，直到你的手牌数量等同于你对手的手牌数量。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        while(true)
        {
            if(owner.myPlayer.deck.Count==0)
            {
                break;
            }
            if(owner.myPlayer.hand.Count>=owner.myPlayer.otherPlayer.hand.Count)
            {
                break;
            }
            TaskDraw();
        }
    }
}
public class RLK_Prologue_EX1_354:SpellBase{
//NAME=圣疗术
//TEXT=恢复#8点生命值，抽三张牌。
//MAJ=PALADIN|COST=8|ATK=0|HP=0|RACE=HOLY
}
public class RLK_Prologue_EX1_609:SecretBase{
//NAME=狙击
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，对该随从造成$4点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_EX1_610:SecretBase{
//NAME=爆炸陷阱
//TEXT=<b>奥秘：</b>当你的英雄受到攻击，对所有敌人造成$2点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class RLK_Prologue_EX1_617:SpellBase{
//NAME=致命射击
//TEXT=随机消灭一个敌方随从。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDestroyRandomEnemyMinion();
    }
}
public class RLK_Prologue_EX1_619:SpellBase{
//NAME=生而平等
//TEXT=将所有随从的生命值变为1。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        TaskSetHpTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
    }
}
public class RLK_Prologue_EX1_619e:Ability{
//NAME=生而平等
//TEXT=生命值变为1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_Frostmourne_001:WeaponBase{
//NAME=霜之哀伤
//TEXT=<b>亡语：</b>召唤被该武器消灭的所有 随从。
//MAJ=DEATHKNIGHT|COST=7|ATK=5|HP=5|RACE=NONE
}
public class RLK_Prologue_Frostmourne_001s:SpellBase{
//NAME=巫妖王之剑
//TEXT=<b>抽到时施放</b> 装备霜之哀伤。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_FroznThrn_004hb3:HeroBase{
//NAME=冰封王座
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_Gavinrad_002t:MinionBase{
//NAME=严厉的格文拉德
//TEXT=你的白银之手新兵拥有+1/+1。
//MAJ=PALADIN|COST=3|ATK=2|HP=6|RACE=NONE
}
public class RLK_Prologue_Gavinrad_002te1:Ability{
//NAME=振奋士气
//TEXT=+1/+1
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_GIL_145:SpellBase{
//NAME=敲响警钟
//TEXT=<b>回响</b> 使一个随从获得+1/+2。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_GIL_145e:Ability{
//NAME=钟声
//TEXT=+1/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_GIL_685:MinionBase{
//NAME=圣光楷模
//TEXT=如果本随从的攻击力大于或等于3，便拥有<b>嘲讽</b>和<b>吸血</b>。
//MAJ=PALADIN|COST=3|ATK=2|HP=5|RACE=NONE
}
public class RLK_Prologue_GVG_060:MinionBase{
//NAME=军需官
//TEXT=<b>战吼：</b>使你的白银之手新兵获得+2/+2。
//MAJ=PALADIN|COST=5|ATK=2|HP=5|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> SliverHands = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.cardDbf.m_noteMiniGuid.Contains("CS2_101t"))
            {
                SliverHands.Add(c);
            }
        }
        TaskBuffTargets(SliverHands,atk:2,hp:2);
    }
}
public class RLK_Prologue_GVG_060e:Ability{
//NAME=装备精良
//TEXT=+2/+2
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_GVG_061:SpellBase{
//NAME=作战动员
//TEXT=召唤三个1/1的白银之手新兵，装备一把1/4的武器。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("CS2_101t");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(CardDbf.GetCardDbfByGuid("CS2_091"),ZoneType.Weapon);
    }
}
public class RLK_Prologue_ICC_055:SpellBase{
//NAME=吸取灵魂
//TEXT=<b>吸血</b> 对一个随从造成 $3点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_Prologue_Illidan_004hb:HeroBase{
//NAME=伊利丹·怒风
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_Illidan_004p:HeroPowerBase{
//NAME=恶魔之爪
//TEXT=<b>英雄技能</b> 在本回合中+$a2攻击力。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_Illidan_004p2:HeroPowerBase{
//NAME=恶魔冲击
//TEXT=<b>英雄技能</b> 造成$3点伤害。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_Illidan_004pe1:Ability{
//NAME=恶魔之爪
//TEXT=在本回合中，你的英雄拥有+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_IllidanD_004hb2:HeroBase{
//NAME=恶魔形态伊利丹
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_InnerGate_003t:MinionBase{
//NAME=奎尔萨拉斯内城门
//TEXT=希尔瓦娜斯<b>免疫</b>。<b>亡语：</b>对希尔瓦娜斯造成20点伤害。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=10|RACE=NONE
}
public class RLK_Prologue_LichKing_004hp2:HeroBase{
//NAME=巫妖王
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_Lightbringer_003e:Ability{
//NAME=光明使者的祝福
//TEXT=<b>圣盾</b>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_Lightbringer_003w:WeaponBase{
//NAME=光明使者之锤
//TEXT=
//MAJ=PALADIN|COST=4|ATK=3|HP=4|RACE=NONE
}
public class RLK_Prologue_LOOT_013:MinionBase{
//NAME=粗俗的矮劣魔
//TEXT=<b>嘲讽，战吼：</b>对你的英雄造成2点伤害。
//MAJ=WARLOCK|COST=2|ATK=2|HP=4|RACE=DEMON
}
public class RLK_Prologue_LOOT_333:SpellBase{
//NAME=等级提升
//TEXT=使你的白银之手新兵获得+2/+2和<b>嘲讽</b>。
//MAJ=PALADIN|COST=6|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> SliverHands = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.cardDbf.m_noteMiniGuid.Contains("CS2_101t"))
            {
                SliverHands.Add(c);
            }
        }
        TaskBuffTargets(SliverHands,atk:2,hp:2);
        foreach(Card c in SliverHands)
        {
            new EffectGiveAbility(owner.myPlayer,owner,c,"Taunt").Resolve();
        }
    }
}
public class RLK_Prologue_LOOT_333e:Ability{
//NAME=等级+1
//TEXT=+2/+2并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_LOOT_522:SpellBase{
//NAME=碾压墙
//TEXT=消灭对手场上最左边和最右边的随从。
//MAJ=HUNTER|COST=7|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_MalGanis_001hb:HeroBase{
//NAME=玛尔加尼斯
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=40|RACE=NONE
}
public class RLK_Prologue_MalGanis_001p:HeroPowerBase{
//NAME=食尸鬼冲锋
//TEXT=<b>英雄技能</b> 召唤一个1/1并具有<b>冲锋</b>的食尸鬼。它会在回合结束时死亡。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_OG_223:SpellBase{
//NAME=神圣之力
//TEXT=使一个随从获得+1/+2。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
	public override void Battlecry(Card target=null)
	{
		new EffectChange(owner.myPlayer,owner,target,atkChange:1,hpChange:2).Resolve();
	}
}
public class RLK_Prologue_OG_223e:Ability{
//NAME=圣光之赐
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_OG_273:SpellBase{
//NAME=惩黑除恶
//TEXT=召唤五个1/1的白银之手新兵。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_OG_310:MinionBase{
//NAME=夜色镇执法官
//TEXT=每当你召唤一个生命值为1的随从，便使其获得<b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=NONE
}
public class RLK_Prologue_OuterGate_003t:MinionBase{
//NAME=银月城的精灵之门
//TEXT=希尔瓦娜斯<b>免疫</b>。<b>亡语：</b>召唤奎尔萨拉斯内城门。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=15|RACE=NONE
}
public class RLK_Prologue_RLK_008t:MinionBase{
//NAME=复活的食尸鬼
//TEXT=<b>突袭</b>。<i>不会留下<b>尸体</b>。</i>
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_Prologue_RLK_012:WeaponBase{
//NAME=断魂
//TEXT=在你的英雄攻击并消灭一个随从后，获得2具 <b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=2|RACE=NONE
}
public class RLK_Prologue_RLK_015:SpellBase{
//NAME=凛风冲击
//TEXT=对一个敌人造成$3点伤害并将其<b>冻结</b>。对所有其他敌人造成$1点伤害。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=FROST
}
public class RLK_Prologue_RLK_018:SpellBase{
//NAME=凋零打击
//TEXT=对一个随从造成$3点伤害。如果该随从死亡，召唤一个2/2并具有<b>突袭</b>的僵尸。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_Prologue_RLK_018t:MinionBase{
//NAME=狂暴僵尸
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_Prologue_RLK_024:SpellBase{
//NAME=灵界打击
//TEXT=<b>吸血</b> 对一个随从造成$6点伤害。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("LifeSteal");
	}
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,6).Resolve();
	}
}
public class RLK_Prologue_RLK_024_AI:SpellBase{
//NAME=灵界打击
//TEXT=<b>吸血</b> 对一个随从造成$6点伤害。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("LifeSteal");
	}
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,6).Resolve();
	}
}
public class RLK_Prologue_RLK_025e:Ability{
//NAME=冰川突进
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗减少（2）点。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_025o:Ability{
//NAME=冰川突进
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗减少（2）点。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_034:SpellBase{
//NAME=心脏打击
//TEXT=对一个随从造成$3点伤害。如果该随从死亡，获得一具<b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
		if(target.GetTag(GameTag.Health)<=0)
		{
			owner.myPlayer.ChangeTag(GameTag.CntCorpse,1);
		}
	}
}
public class RLK_Prologue_RLK_035:SpellBase{
//NAME=邪爆
//TEXT=引爆一具<b>尸体</b>，对所有随从造成$1点伤害。如果有随从存活，重复此效果。
//MAJ=DEATHKNIGHT|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_Prologue_RLK_038:SpellBase{
//NAME=冰冷触摸
//TEXT=对一个敌人造成$2点伤害，并使其<b>冻结</b>。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=FROST
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
	}
}
public class RLK_Prologue_RLK_042:SpellBase{
//NAME=寒冬号角
//TEXT=复原两个法力水晶。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=FROST
}
public class RLK_Prologue_RLK_048:SpellBase{
//NAME=反魔法护罩
//TEXT=使你的所有随从获得+1/+1和<b>扰魔</b>。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_Prologue_RLK_048e:Ability{
//NAME=反魔法护罩
//TEXT=+1/+1和<b>扰魔</b>。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_051:SpellBase{
//NAME=吸血鬼之血
//TEXT=使你的英雄获得+5生命值。消耗3具<b>尸体</b>，多获得5点并抽一张牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(hp:5);
		if(owner.myPlayer.GetTag(GameTag.CntCorpse)>=3)
		{
			owner.myPlayer.ChangeTag(GameTag.CntCorpse,-3);
			TaskBuffMyHero(hp:5);
			TaskDraw();
		}
	}
}
public class RLK_Prologue_RLK_060:SpellBase{
//NAME=亡者大军
//TEXT=将最多5具<b>尸体</b>复活为2/2并具有<b>突袭</b>的复活的食尸鬼。
//MAJ=DEATHKNIGHT|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_Prologue_RLK_061:MinionBase{
//NAME=战场通灵师
//TEXT=在你的回合结束时，将一具<b>尸体</b>复活为1/2并具有<b>嘲讽</b>的复活的步兵。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=3|RACE=NONE
}
public class RLK_Prologue_RLK_061t:MinionBase{
//NAME=复活的步兵
//TEXT=<b>嘲讽</b>。<i>不会留下<b>尸体</b>。</i>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=2|RACE=UNDEAD
}
public class RLK_Prologue_RLK_062:MinionBase{
//NAME=蛛魔护群守卫
//TEXT=<b>嘲讽</b>。<b>战吼：</b>召唤本随从的两个复制。
//MAJ=DEATHKNIGHT|COST=4|ATK=1|HP=3|RACE=UNDEAD
}
public class RLK_Prologue_RLK_063:SpellBase{
//NAME=冰霜巨龙之怒
//TEXT=造成$5点伤害。<b>冻结</b>所有敌方随从。召唤一条5/5的冰霜巨龙。
//MAJ=DEATHKNIGHT|COST=7|ATK=0|HP=0|RACE=FROST
}
public class RLK_Prologue_RLK_063t:MinionBase{
//NAME=冰霜巨龙
//TEXT=
//MAJ=DEATHKNIGHT|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class RLK_Prologue_RLK_070:MinionBase{
//NAME=被感染的农夫
//TEXT=<b>亡语：</b>召唤一个2/2的亡灵农夫。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class RLK_Prologue_RLK_070t:MinionBase{
//NAME=亡灵农夫
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_Prologue_RLK_071:MinionBase{
//NAME=帕奇维克
//TEXT=<b>战吼：</b>随机消灭你对手手牌，牌库和战场上的各一个随从。
//MAJ=DEATHKNIGHT|COST=7|ATK=4|HP=6|RACE=UNDEAD
    public override void Battlecry(Card target=null)
    {
        TaskDestroyRandomEnemyMinion();
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.hand)
        {
            if(c.cardType==CardType.Minion)
            {
                Pool.Add(c);
            }
        }
        Card Target = Pool.Choice(owner.myPlayer.randomGen);
        if(Target!=null)
        {
            new EffectDestroy(owner.myPlayer,owner,Target).Resolve();
        }

        List<Card> Pool2 = new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.deck)
        {
            if(c.cardType==CardType.Minion)
            {
                Pool2.Add(c);
            }
        }
        Card Target2 = Pool2.Choice(owner.myPlayer.randomGen);
        if(Target2!=null)
        {
            new EffectDestroy(owner.myPlayer,owner,Target2).Resolve();
        }
    }
}
public class RLK_Prologue_RLK_079:MinionBase{
//NAME=喷毒尸骸
//TEXT=<b>战吼：</b> 对一个敌人和你的英雄造成2点伤害。
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=2|RACE=UNDEAD
}
public class RLK_Prologue_RLK_082:MinionBase{
//NAME=死亡使者萨鲁法尔
//TEXT=<b>嘲讽</b>。<b>亡语：</b>将本随从移回你的手牌，且本牌消耗生命值，而非法力值。
//MAJ=DEATHKNIGHT|COST=5|ATK=3|HP=5|RACE=UNDEAD
	private bool Act=false;
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Battlecry(Card target=null)
	{
		if(Act)
		{
			TaskDamageMyHero(5);
		}
	}
	public override void Deathrattle()
	{
		Act=true;
		new EffectMove(owner.myPlayer,owner,(ZoneType)owner.GetTag(GameTag.ZoneType),ZoneType.Hand).Resolve();
	}
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			if(Act)
				return -5;
		}
		return 0;
	}
}
public class RLK_Prologue_RLK_083:MinionBase{
//NAME=死亡寒冰
//TEXT=在你施放一个法术后，随机对两个敌人造成1点伤害。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class RLK_Prologue_RLK_087:SpellBase{
//NAME=窒息
//TEXT=消灭攻击力最高的敌方随从。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_Prologue_RLK_101:SpellBase{
//NAME=解冻
//TEXT=抽一张牌。消耗2具<b>尸体</b>，再抽一张。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=FROST
    public override void Battlecry(Card target=null)
    {
        TaskDraw();
        if(owner.myPlayer.GetTag(GameTag.CntCorpse)>=2)
        {
            owner.myPlayer.ChangeTag(GameTag.CntCorpse,-2);
            TaskDraw();
        }
    }
}
public class RLK_Prologue_RLK_110:MinionBase{
//NAME=伊米亚破霜者
//TEXT=<b>战吼：</b>你手牌中每有一张冰霜法术牌，便获得+1攻击力。
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=2|RACE=NONE
}
public class RLK_Prologue_RLK_110e:Ability{
//NAME=破冰之力
//TEXT=+1攻击力
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_113:MinionBase{
//NAME=脆皮僵尸
//TEXT=<b>亡语：</b>如果此时是你对手的回合，则对你的对手造成3点伤害。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=UNDEAD
}
public class RLK_Prologue_RLK_115:MinionBase{
//NAME=丑恶巨怪
//TEXT=敌方角色无法被治疗。
//MAJ=DEATHKNIGHT|COST=4|ATK=3|HP=6|RACE=UNDEAD
}
public class RLK_Prologue_RLK_118:SpellBase{
//NAME=坟墓守卫
//TEXT=召唤两个2/2并具有<b>嘲讽</b>的僵尸。消耗4具<b>尸体</b>，使其获得<b>复生</b>。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_Prologue_RLK_118t3:MinionBase{
//NAME=凶恶僵尸
//TEXT=<b>嘲讽</b>
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_Prologue_RLK_120:MinionBase{
//NAME=绞肉机
//TEXT=<b>战吼：</b>随机绞碎你牌库中的一个随从，获得3具<b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=4|RACE=MECHANICAL
}
public class RLK_Prologue_RLK_125:SpellBase{
//NAME=湮灭
//TEXT=消灭一个随从。你的英雄受到等同于该随从生命值的 伤害。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int ToTake = target.GetTag(GameTag.Health);
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
        TaskDamageMyHero(ToTake);
    }
}
public class RLK_Prologue_RLK_125_AI:SpellBase{
//NAME=湮灭
//TEXT=消灭一个随从。你的英雄受到等同于该随从生命值的 伤害。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_223:MinionBase{
//NAME=萨萨里安
//TEXT=<b>复生</b>。<b>战吼，亡语：</b>随机对一个敌人造成2点伤害。
//MAJ=DEATHKNIGHT|COST=4|ATK=3|HP=3|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Reborn");
	}
	public override void Battlecry(Card target=null)
	{
		TaskDamageRandomEnemy(2);
	}
	public override void Deathrattle()
	{
		TaskDamageRandomEnemy(2);
	}
}
public class RLK_Prologue_RLK_224:MinionBase{
//NAME=监督者弗里吉达拉
//TEXT=<b>战吼：</b>抽两张法术牌。如果两张都是冰霜法术牌，对所有敌人造成2点伤害。
//MAJ=DEATHKNIGHT|COST=6|ATK=5|HP=6|RACE=NONE
}
public class RLK_Prologue_RLK_226:MinionBase{
//NAME=伊米亚死亡使者
//TEXT=<b>嘲讽</b>。<b>亡语：</b>消耗3具<b>尸体</b>，召唤一个3/3并具有<b>嘲讽</b>的复活的伊米亚人。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class RLK_Prologue_RLK_226t:MinionBase{
//NAME=复活的伊米亚人
//TEXT=<b>嘲讽</b>。<i>不会留下<b>尸体</b>。</i>
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class RLK_Prologue_RLK_505:MinionBase{
//NAME=髓骨使御者
//TEXT=<b>战吼：</b>消耗最多5具<b>尸体</b>。每消耗一具尸体，随机对一个敌人造成2点伤害。
//MAJ=DEATHKNIGHT|COST=6|ATK=5|HP=5|RACE=UNDEAD
}
public class RLK_Prologue_RLK_506:MinionBase{
//NAME=白骨卫士指挥官
//TEXT=<b>嘲讽</b>。<b>战吼：</b>将最多6具<b>尸体</b>复活为1/2并具有<b>嘲讽</b>的复活的步兵。
//MAJ=DEATHKNIGHT|COST=8|ATK=8|HP=8|RACE=UNDEAD
}
public class RLK_Prologue_RLK_511:MinionBase{
//NAME=寒冬先锋
//TEXT=<b>亡语：</b>抽一张冰霜法术牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=2|RACE=UNDEAD
	public override void Deathrattle()
	{
		TaskDrawSchool(SpellSchoolType.Frost);
	}
}
public class RLK_Prologue_RLK_512:SpellBase{
//NAME=冰川突进
//TEXT=造成$4点伤害。在本回合中，你的下一个法术法力值消耗减少（2）点。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=FROST
}
public class RLK_Prologue_RLK_653:MinionBase{
//NAME=感染的食尸鬼
//TEXT=<b>亡语：</b>随机使一个友方随从获得“<b>亡语：</b>召唤一个感染的食尸鬼。”
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=UNDEAD
}
public class RLK_Prologue_RLK_653e:Ability{
//NAME=被感染
//TEXT=<b>亡语：</b>召唤一个感染的食尸鬼。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_705:SpellBase{
//NAME=墓地夜战
//TEXT=召唤两个1/1并具有<b>复生</b>的僵尸。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_705t:MinionBase{
//NAME=蹒跚的僵尸
//TEXT=<b>复生</b>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class RLK_Prologue_RLK_707:SpellBase{
//NAME=墓地之力
//TEXT=使你的所有随从获得+1攻击力。消耗5具<b>尸体</b>，改为获得+3攻击力。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class RLK_Prologue_RLK_707e:Ability{
//NAME=墓地印记
//TEXT=+1攻击力
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_707e2:Ability{
//NAME=墓地力量
//TEXT=+3攻击力。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_708:MinionBase{
//NAME=堕寒男爵
//TEXT=<b>战吼，亡语：</b>抽一张牌。
//MAJ=DEATHKNIGHT|COST=3|ATK=2|HP=2|RACE=UNDEAD
	public override void Battlecry(Card target=null)
	{
		TaskDraw();
	}
	public override void Deathrattle()
	{
		TaskDraw();
	}
}
public class RLK_Prologue_RLK_709:SpellBase{
//NAME=冷酷严冬
//TEXT=对所有敌人造成$2点伤害。抽一张牌。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=FROST
}
public class RLK_Prologue_RLK_711:MinionBase{
//NAME=凶恶的血虫
//TEXT=<b>战吼：</b> 使你手牌中的一张随从牌获得等同于本随从攻击力的攻击力。
//MAJ=DEATHKNIGHT|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class RLK_Prologue_RLK_711e:Ability{
//NAME=血虫馈赠
//TEXT=攻击力提高。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_712:SpellBase{
//NAME=活力分流
//TEXT=使你手牌中的所有随从牌获得+1/+1。消耗3具<b>尸体</b>，再获得+1/+1。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListBuff = new List<Card>();
		foreach(Card c in owner.myPlayer.hand)
		{
			if(c.cardType==CardType.Minion)
			{
				ToListBuff.Add(c);
			}
		}
		TaskBuffTargets(ToListBuff,atk:1,hp:1);
		if(owner.myPlayer.GetTag(GameTag.CntCorpse)>=3)
		{
			owner.myPlayer.ChangeTag(GameTag.CntCorpse,-3);
			TaskBuffTargets(ToListBuff,atk:1,hp:1);
		}
	}
}
public class RLK_Prologue_RLK_712e:Ability{
//NAME=分流活力
//TEXT=+1/+1。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_720:MinionBase{
//NAME=侏儒嚼嚼怪
//TEXT=<b>嘲讽</b>，<b>吸血</b>。在你的回合结束时，攻击生命值最低的敌人。
//MAJ=DEATHKNIGHT|COST=6|ATK=5|HP=6|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskInitAbility("LifeSteal");
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(CondInPlay())
		{
			Card Target = null;
			foreach(Card c in owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero))
			{
				if(c!=null)
				{
					if(Target!=null)
					{
						if(c.GetTag(GameTag.Health)<=Target.GetTag(GameTag.Health))
						{
							Target=c;
						}
					}
					else{
						Target=c;
					}
				}
			}
			if(Target!=null)
				new EffectAttack(owner.myPlayer,owner,Target).Resolve();
		}
	}
}

public class RLK_Prologue_RLK_730:SpellBase{
//NAME=血液沸腾
//TEXT=<b>吸血</b>。感染所有敌方随从。在你的回合结束时，使其受到2点伤害。
//MAJ=DEATHKNIGHT|COST=5|ATK=0|HP=0|RACE=SHADOW
	private List<Card> Affected = new List<Card>();
	public override void Init()
	{
		TaskInitAbility("LifeSteal");
	}
	public override void Battlecry(Card target=null)
	{
		Affected = owner.myPlayer.otherPlayer.board;
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		TaskDamageTargets(this.Affected,2);
		for(int i=this.Affected.Count-1;i>=0;i--)
		{
			if(this.Affected[i].GetTag(GameTag.ZoneType)!=(int)ZoneType.Board)
			{
				this.Affected.RemoveAt(i);
			}
		}
	}
}
public class RLK_Prologue_RLK_730e:Ability{
//NAME=沸腾之血
//TEXT=在你的对手回合结束时，受到2点伤害。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_731:MinionBase{
//NAME=黑暗堕落者新兵
//TEXT=<b>战吼：</b>消耗2具<b>尸体</b>，使你手牌中的所有随从牌获得+2攻击力。
//MAJ=DEATHKNIGHT|COST=3|ATK=2|HP=5|RACE=UNDEAD
}
public class RLK_Prologue_RLK_731e:Ability{
//NAME=堕入黑暗
//TEXT=+2攻击力。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_740:WeaponBase{
//NAME=米奈希尔之力
//TEXT=<b>战吼：</b>消耗最多3具<b>尸体</b>，<b>冻结</b>等量的敌方随从。
//MAJ=DEATHKNIGHT|COST=4|ATK=4|HP=2|RACE=NONE
}
public class RLK_Prologue_RLK_741:MinionBase{
//NAME=窃魂者
//TEXT=<b>战吼：</b> 消灭所有其他随从。每消灭一个敌方随从，获得1具<b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=8|ATK=5|HP=5|RACE=UNDEAD
}
public class RLK_Prologue_RLK_744:MinionBase{
//NAME=缝合巨人
//TEXT=在本局对战中，你每消耗过一具<b>尸体</b>，本牌的法力值消耗便减少（1）点。
//MAJ=DEATHKNIGHT|COST=10|ATK=8|HP=8|RACE=UNDEAD
}
public class RLK_Prologue_RLK_752:MinionBase{
//NAME=霜雪塑形师
//TEXT=<b>战吼：</b>召唤两个2/1且具有“<b>亡语：</b>随机对一个敌人造成2点伤害。”的白霜元素。
//MAJ=DEATHKNIGHT|COST=5|ATK=3|HP=3|RACE=UNDEAD
}
public class RLK_Prologue_RLK_753:MinionBase{
//NAME=掘骨恶鬼
//TEXT=<b>战吼：</b>消耗一具<b>尸体</b>，获得+1/+2。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class RLK_Prologue_RLK_753e:Ability{
//NAME=开挖
//TEXT=+1/+2。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_817:SpellBase{
//NAME=奥术箭袋
//TEXT=从你的牌库中<b>发现</b>一张法术牌。如果选中的是奥术法术牌，使其获得<b>法术伤害+1</b>。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class RLK_Prologue_RLK_826:MinionBase{
//NAME=银月城远行者
//TEXT=<b>战吼：</b>使你手牌中所有奥术法术牌获得<b>法术伤害+1</b>。
//MAJ=HUNTER|COST=2|ATK=2|HP=3|RACE=NONE
}
public class RLK_Prologue_RLK_826e:Ability{
//NAME=银月城远行者的法强
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_RLK_830:MinionBase{
//NAME=血肉巨兽
//TEXT=<b>嘲讽</b>。<b>亡语：</b>抽取另一张亡灵牌并召唤一个它的复制。
//MAJ=NEUTRAL|COST=9|ATK=4|HP=8|RACE=UNDEAD
}
public class RLK_Prologue_RLK_907t:MinionBase{
//NAME=白霜元素
//TEXT=<b>亡语：</b>随机对一个敌人造成2点伤害。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=1|RACE=ELEMENTAL
}
public class RLK_Prologue_RLK_957:MinionBase{
//NAME=女妖
//TEXT=<b>亡语：</b>随机使一个友方亡灵获得+2/+1。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=UNDEAD
}
public class RLK_Prologue_RLK_957e:Ability{
//NAME=女妖的哀嚎
//TEXT=+2/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_SCH_158e2:Ability{
//NAME=研习恶魔
//TEXT=消耗减少（1）枚。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_SCH_422:SpellBase{
//NAME=二段跳
//TEXT=从你的牌库中抽一张<b>流放</b>牌。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_SW_040:SpellBase{
//NAME=邪能弹幕
//TEXT=对生命值最低的敌人造成$2点伤害两次。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=FEL
    public override void Battlecry(Card target=null)
    {
        TaskDamageEnemyHero(2);
        TaskDamageEnemyHero(2);
    }
}
public class RLK_Prologue_SW_043:MinionBase{
//NAME=邪能吞食者
//TEXT=<b>战吼：</b>抽一张邪能法术牌，使其法力值消耗减少（2）点。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=3|RACE=DEMON
}
public class RLK_Prologue_SW_043e:Ability{
//NAME=吞噬
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_Sylvanas_003e1:Ability{
//NAME=防御姿态
//TEXT=在本回合中，你的英雄拥有+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_Sylvanas_003hb:HeroBase{
//NAME=希尔瓦娜斯·风行者
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_Sylvanas_003p:HeroPowerBase{
//NAME=迅速射击
//TEXT=<b>英雄技能</b> 随机对两个敌方随从造成$1点 伤害。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_SylvanasB_003hb2:HeroBase{
//NAME=希尔瓦娜斯·风行者
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_TB_HunterP_02e:Ability{
//NAME=拥抱力量
//TEXT=法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_TheScourge_003s:SpellBase{
//NAME=天灾军团
//TEXT=用随机亡灵填满你的面板。
//MAJ=DEATHKNIGHT|COST=9|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		List<string> ToListSummon = new List<string>(){
			"NX2_018",
			"WW_358",
			"MIS_006",
			"TOY_828",
			"RLK_552",
			"RLK_833",
			"RLK_834"
		};
		foreach(string s in ToListSummon)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid(s),ZoneType.Board);
		}
	}
}
public class RLK_Prologue_TSC_053:MinionBase{
//NAME=虹彩闪鳞纳迦
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NAGA
}
public class RLK_Prologue_TSC_827:MinionBase{
//NAME=凶恶的滑矛纳迦
//TEXT=在你施放一个法术后，直到你的下个回合，获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NAGA
}
public class RLK_Prologue_TSC_827e:Ability{
//NAME=凶恶
//TEXT=直到你的下个回合，获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_TSC_938:MinionBase{
//NAME=宝藏守卫
//TEXT=<b>嘲讽</b>，<b>亡语：</b>抽一张牌。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NAGA
}
public class RLK_Prologue_TwinSlice:SpellBase{
//NAME=双刃斩击
//TEXT=在本回合中，使你的英雄获得+2攻击力。将“二次斩击”置入你的手牌。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(atk:2);
		TaskCreate(CardDbf.GetCardDbfByGuid("BT_175t"),ZoneType.Hand);
	}
}
public class RLK_Prologue_ULD_145:MinionBase{
//NAME=英勇狂热者
//TEXT=每当你召唤一个随从，获得+1攻击力。
//MAJ=PALADIN|COST=1|ATK=2|HP=1|RACE=NONE
}
public class RLK_Prologue_ULD_145e:Ability{
//NAME=狂热
//TEXT=攻击力提高。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_ULD_728:SpellBase{
//NAME=制伏
//TEXT=将一个随从的攻击力和生命值变为1。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_ULD_728e:Ability{
//NAME=被制伏
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_UNG_960:SpellBase{
//NAME=迷失丛林
//TEXT=召唤两个1/1的白银之手新兵。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target = null)
    {
        base.Battlecry(target);
        new EffectCreate(owner.myPlayer,new Card(CardDbf.GetCardDbfByGuid("CS2_101t"),owner.myPlayer),ZoneType.Board).Resolve();
        new EffectCreate(owner.myPlayer,new Card(CardDbf.GetCardDbfByGuid("CS2_101t"),owner.myPlayer),ZoneType.Board).Resolve();    
    }
}
public class RLK_Prologue_Uther_002hb:HeroBase{
//NAME=乌瑟尔·光明使者
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class RLK_Prologue_Uther_002p:HeroPowerBase{
//NAME=光明使者之锤
//TEXT=<b>英雄技能</b> 装备一把3/4的光明使者之锤。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_YOD_012:SpellBase{
//NAME=空中团战
//TEXT=<b>双生法术</b> 召唤两个1/1并具有<b>嘲讽</b>的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_YOD_012ts:SpellBase{
//NAME=空中团战
//TEXT=召唤两个1/1并具有<b>嘲讽</b>的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_YOP_001:SpellBase{
//NAME=伊利达雷研习
//TEXT=<b>发现</b>一张<b>流放</b>牌。你的下一张<b>流放</b>牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class RLK_Prologue_YOP_001e:Ability{
//NAME=孤独流放
//TEXT=你的下一张<b>流放</b>牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Shop_DKBlood:Ability{
//NAME=鲜血套牌插画
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Shop_DKFrost:Ability{
//NAME=冰霜套牌插画
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class RLK_Shop_DKUnholy:Ability{
//NAME=邪恶套牌插画
//TEXT=
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
