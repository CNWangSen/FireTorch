using System.Collections;
using System.Collections.Generic;

public class CS3_001:MinionBase{
//NAME=守护者艾格文
//TEXT=<b>法术伤害+2</b>，<b>亡语：</b>你抽到的下一张随从牌会继承这些能力。
//MAJ=MAGE|COST=5|ATK=5|HP=5|RACE=NONE
}
public class CS3_001e:Ability{
//NAME=守护者的遗产
//TEXT=<b>法术伤害+2</b>和“<b>亡语：</b>传递守护者的遗产。”
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS3_001e2:Ability{
//NAME=守护者的遗产（玩家）
//TEXT=你抽到的下一张随从牌会继承守护者的遗产。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS3_002:SpellBase{
//NAME=末日仪式
//TEXT=消灭一个友方随从。如果你拥有5个或更多随从，召唤一个5/5的恶魔。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class CS3_002t:MinionBase{
//NAME=恶魔暴君
//TEXT=
//MAJ=WARLOCK|COST=5|ATK=5|HP=5|RACE=DEMON
}
public class CS3_003:MinionBase{
//NAME=邪魂狱卒
//TEXT=<b>战吼：</b>使你的对手弃掉一张随从牌。<b>亡语：</b>移回弃掉的牌。
//MAJ=WARLOCK|COST=5|ATK=4|HP=6|RACE=DEMON
}
public class CS3_005:MinionBase{
//NAME=梵妮莎·范克里夫
//TEXT=<b>连击：</b>将你对手使用的上一张牌的一张复制置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=2|HP=3|RACE=NONE
}
public class CS3_007:MinionBase{
//NAME=电击学徒
//TEXT=<b>法术伤害+1</b> <b>过载：</b>（1）
//MAJ=SHAMAN|COST=1|ATK=3|HP=2|RACE=NONE
}
public class CS3_008:MinionBase{
//NAME=血帆桨手
//TEXT=<b>战吼：</b>你的下一张武器牌的法力值消耗减少（1）点。
//MAJ=WARRIOR|COST=1|ATK=2|HP=1|RACE=PIRATE
}
public class CS3_008e:Ability{
//NAME=拿好武器！
//TEXT=你的下一张武器牌法力值消耗减少（1）点。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS3_009:SpellBase{
//NAME=战争储备箱
//TEXT=随机将一张战士随从牌，法术牌和武器牌分别置入你的 手牌。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class CS3_012:MinionBase{
//NAME=诺达希尔德鲁伊
//TEXT=<b>战吼：</b>在本回合中，你施放的下一个法术的法力值消耗减少（3）点。
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=NONE
}
public class CS3_012e:Ability{
//NAME=自然仪式
//TEXT=在本回合中，你的下一张法术牌法力值消耗减少（3）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS3_013:MinionBase{
//NAME=暗影之灵
//TEXT=<b>亡语：</b>对敌方英雄造成3点伤害。
//MAJ=PRIEST|COST=3|ATK=4|HP=3|RACE=UNDEAD
	public override void Deathrattle()
	{
		TaskDamageEnemyHero(3);
	}
}
public class CS3_014:MinionBase{
//NAME=赤红教士
//TEXT=<b>过量治疗：</b>抽一张牌。
//MAJ=PRIEST|COST=1|ATK=1|HP=3|RACE=NONE
}
public class CS3_014e:Ability{
//NAME=神圣亲和
//TEXT=+1攻击力。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS3_015:MinionBase{
//NAME=选种饲养员
//TEXT=<b>战吼：</b> 从你的牌库中<b>发现</b>一张野兽牌的复制。
//MAJ=HUNTER|COST=2|ATK=1|HP=3|RACE=NONE
}
public class CS3_016:SecretBase{
//NAME=清算
//TEXT=<b>奥秘：</b>在一个敌方随从造成3点或以上伤害后，将其消灭。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class CS3_017:MinionBase{
//NAME=甘尔葛战刃铸造师
//TEXT=<b>流放：</b>在本回合中，使你的英雄获得+3攻击力。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class CS3_017e:Ability{
//NAME=邪能重拳
//TEXT=在本回合中+3攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS3_019:MinionBase{
//NAME=考瓦斯·血棘
//TEXT=<b>冲锋</b>，<b>吸血</b> 在你使用一张<b>流放</b>牌后，将本随从移回你的手牌。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CS3_020:MinionBase{
//NAME=伊利达雷审判官
//TEXT=<b>突袭</b> 在你的英雄攻击一个敌人后，本随从也会攻击。
//MAJ=DEMONHUNTER|COST=8|ATK=8|HP=8|RACE=DEMON
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,this.CauseEvent));
	}
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc.GetTag(GameTag.ZoneType) == (int)ZoneType.Hero && CondInPlay())
        {
            if(tc.GetTag(GameTag.Health)>0)
            {
            	new EffectAttack(owner.myPlayer,owner,tc).Resolve();
            }
        }
    }
}
public class CS3_021:MinionBase{
//NAME=被奴役的邪能领主
//TEXT=<b>嘲讽</b> 同时对其攻击目标相邻的随从造成伤害。
//MAJ=WARLOCK|COST=7|ATK=4|HP=10|RACE=DEMON
}
public class CS3_022:MinionBase{
//NAME=雾帆劫掠者
//TEXT=<b>战吼：</b>如果你装备着武器，造成2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=PIRATE
}
public class CS3_024:MinionBase{
//NAME=泰兰·弗丁
//TEXT=<b>嘲讽</b>，<b>圣盾</b> <b>亡语：</b>抽取你的法力值消耗最高的 随从牌。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskInitAbility("DivineShield");
	}
	public override void Deathrattle()
	{
		Card ToDraw = null;
		foreach(Card c in owner.myPlayer.deck)
		{
			if(ToDraw!=null)
			{
				if(ToDraw.GetTag(GameTag.Mana) < c.GetTag(GameTag.Mana))
				{
					ToDraw=c;
				}
			}
			else{
				ToDraw = c;
			}
		}
		if(ToDraw!=null)
			TaskDraw(ToDraw);
	}
}
public class CS3_025:MinionBase{
//NAME=伦萨克大王
//TEXT=<b>突袭</b> 每当本随从攻击时，使你手牌中的所有随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=NONE
}
public class CS3_025e:Ability{
//NAME=集结呐喊
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS3_027:SpellBase{
//NAME=专注意志
//TEXT=<b>沉默</b>一个随从，然后使其获得+3生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CS3_027e:Ability{
//NAME=专注意志
//TEXT=+3生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS3_028:SpellBase{
//NAME=暗中生长
//TEXT=从你的牌库中<b>发现</b>一张法术牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class CS3_029:SpellBase{
//NAME=正义追击
//TEXT=使你本局对战中召唤的白银之手新兵获得+1攻击力。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class CS3_029e:Ability{
//NAME=正义追击
//TEXT=你的白银之手新兵拥有+1攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS3_029e2:Ability{
//NAME=正义追击
//TEXT=+1攻击力。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS3_030:MinionBase{
//NAME=战歌侦察骑兵
//TEXT=<b>突袭</b>
//MAJ=WARRIOR|COST=4|ATK=5|HP=4|RACE=NONE
}
public class CS3_031:MinionBase{
//NAME=生命的缚誓者阿莱克丝塔萨
//TEXT=<b>战吼：</b>选择一个角色。如果是友方角色，为其恢复8点生命值；如果是敌方角色，对其造成8点伤害。
//MAJ=NEUTRAL|COST=9|ATK=8|HP=8|RACE=DRAGON
    public override void Battlecry(Card target=null)
    {
        if(target.myPlayer==owner.myPlayer)
        {
            new EffectHeal(owner.myPlayer,owner,target,8).Resolve();
        }
        else{
            new EffectDamage(owner.myPlayer,owner,target,8).Resolve();
        }
    }
}
public class CS3_032:MinionBase{
//NAME=龙巢之母奥妮克希亚
//TEXT=在每个回合结束时，用1/1的雏龙填满你的面板。
//MAJ=NEUTRAL|COST=9|ATK=8|HP=8|RACE=DRAGON
}
public class CS3_033:MinionBase{
//NAME=沉睡者伊瑟拉
//TEXT=<b>战吼：</b>将每种 梦境牌各一张置 入你的手牌。
//MAJ=NEUTRAL|COST=9|ATK=4|HP=12|RACE=DRAGON
}
public class CS3_034:MinionBase{
//NAME=织法者玛里苟斯
//TEXT=<b>战吼：</b> 抽取法术牌直到达到你的手牌上限。
//MAJ=NEUTRAL|COST=9|ATK=4|HP=12|RACE=DRAGON
}
public class CS3_035:MinionBase{
//NAME=永恒者诺兹多姆
//TEXT=<b>对战开始时：</b>如果双方玩家的套牌中都有这张随从牌，则每个回合只有15秒。
//MAJ=NEUTRAL|COST=7|ATK=8|HP=8|RACE=DRAGON
}
public class CS3_035e:Ability{
//NAME=诺兹多姆时间
//TEXT=每个回合只有15秒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CS3_036:MinionBase{
//NAME=灭世者死亡之翼
//TEXT=<b>战吼：</b>消灭所有其他随从。每消灭一个随从，便弃一张牌。
//MAJ=NEUTRAL|COST=10|ATK=12|HP=12|RACE=DRAGON
}
public class CS3_037:MinionBase{
//NAME=翡翠天爪枭
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class CS3_038:MinionBase{
//NAME=红鳃锋颚战士
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=1|RACE=MURLOC
}
