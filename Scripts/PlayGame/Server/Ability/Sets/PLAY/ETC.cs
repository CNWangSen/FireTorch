using System.Collections;
using System.Collections.Generic;

public class ETC_026:MinionBase{
//NAME=吉他独演者
//TEXT=<b>战吼：</b>如果你没有控制其他随从，抽一张法术牌，一张随从牌和一张武器牌。
//MAJ=DEMONHUNTER|COST=5|ATK=4|HP=3|RACE=NONE
}
public class ETC_028:MinionBase{
//NAME=口琴独演者
//TEXT=<b>战吼：</b>如果你没有控制其他随从，<b>发现</b>并施放一个<b>奥秘</b>。
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=NONE
}
public class ETC_029:MinionBase{
//NAME=键盘独演者
//TEXT=<b>战吼：</b>如果你没有控制其他随从，召唤两个1/2并具有<b>法术伤害+1</b>的扩音器。
//MAJ=MAGE|COST=4|ATK=2|HP=4|RACE=NAGA
}
public class ETC_029t:MinionBase{
//NAME=键盘扩音器
//TEXT=<b>法术伤害+1</b>
//MAJ=MAGE|COST=1|ATK=1|HP=2|RACE=MECHANICAL
}
public class ETC_034:MinionBase{
//NAME=歌剧独演者
//TEXT=<b>战吼：</b>如果你没有控制其他随从，对所有敌方随从造成3点伤害。
//MAJ=WARLOCK|COST=5|ATK=4|HP=6|RACE=DEMON
}
public class ETC_035:MinionBase{
//NAME=鼓乐独演者
//TEXT=<b>嘲讽</b>。<b>战吼：</b>如果你没有控制其他随从，获得+2/+2和<b>突袭</b>。
//MAJ=WARRIOR|COST=5|ATK=5|HP=5|RACE=DRAGON
}
public class ETC_035e:Ability{
//NAME=鼓点独奏
//TEXT=+2/+2。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_068:MinionBase{
//NAME=次中音号小鬼
//TEXT=<b>战吼：</b>受到疲劳伤害。获得等量的攻击力和生命值。0<b>战吼：</b>受到{0}点疲劳伤害。获得等量的攻击力和生命值。
//MAJ=WARLOCK|COST=2|ATK=2|HP=2|RACE=DEMON
}
public class ETC_068e:Ability{
//NAME=哆来咪
//TEXT=属性值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_069:SpellBase{
//NAME=渐强声浪
//TEXT=受到疲劳伤害。对所有敌人造成等量的伤害。0受到{0}点疲劳伤害。对所有敌人造成等量的伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=FEL
}
public class ETC_070:MinionBase{
//NAME=疯狂的指挥
//TEXT=<b>战吼：</b>受到疲劳伤害。召唤相同数量的3/3的小鬼。0<b>战吼：</b>受到{0}点疲劳伤害。召唤相同数量的3/3的小鬼。
//MAJ=WARLOCK|COST=4|ATK=3|HP=4|RACE=NONE
}
public class ETC_070t:MinionBase{
//NAME=管弦乐小鬼
//TEXT=
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class ETC_071:MinionBase{
//NAME=末日管弦家林恩
//TEXT=<b>嘲讽</b>。<b>亡语：</b>双方玩家各抽两张牌，各弃两张牌，并各摧毁牌库顶的两张牌。
//MAJ=WARLOCK|COST=5|ATK=3|HP=6|RACE=NONE
}
public class ETC_072:MinionBase{
//NAME=B-Box拳手
//TEXT=<b>连击：</b>造成4点伤害，随机分配到所有敌人身上。
//MAJ=ROGUE|COST=3|ATK=4|HP=3|RACE=MECHANICAL
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)>0)
		{
			TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),4);
		}
	}
}
public class ETC_073:MinionBase{
//NAME=押韵狂人
//TEXT=<b>突袭</b>。<b>连击：</b>在本局对战中，你每使用过一张其他<b>连击</b>牌，便获得+1/+1。0<i>（已使用0张）</i>
//MAJ=ROGUE|COST=3|ATK=1|HP=3|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
	public override void Battlecry(Card target=null)
	{
		List<string> ComboPool = new List<string>(){"ETC_077","ETC_072","EX1_131","VAN_EX1_131","CORE_OG_070","OG_070","EX1_613","VAN_EX1_613","AV_201","DMF_515","ETC_073","VAC_460","RLK_573","VAN_CS2_073","CORE_CS2_073","CS2_073","DMF_519"};
		int ComboNum = 0;
		foreach(Card c in owner.myPlayer.grave.Merge(owner.myPlayer.board))
		{
			if(ComboPool.Contains(c.cardDbf.m_noteMiniGuid))
			{
				ComboNum+=1;
			}
		}
		new EffectChange(owner.myPlayer,owner,owner,atkChange:ComboNum,hpChange:ComboNum).Resolve();
	}
}
public class ETC_073e:Ability{
//NAME=热力升级！
//TEXT=+1/+1。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_074:SpellBase{
//NAME=串烧磁带
//TEXT=<b>发现</b>一张你的对手在本局对战中使用过的牌的复制。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=FIRE
}
public class ETC_075:SpellBase{
//NAME=闭麦收工
//TEXT=抽两张牌。<b>压轴：</b>使你的武器获得+2攻击力。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_075e:Ability{
//NAME=OHHHHH！！
//TEXT=+2攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_076:SpellBase{
//NAME=街舞起跳
//TEXT=将一个友方随从移回你的手牌。召唤一个具有其属性值和<b>突袭</b>的舞者。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class ETC_076t:MinionBase{
//NAME=街舞舞者
//TEXT=<b>突袭</b>
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=NONE
}
public class ETC_077:MinionBase{
//NAME=八爪碟机
//TEXT=<b>连击：</b>随机将一张<b>连击</b>牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=4|HP=1|RACE=MECHANICAL
	public override void Battlecry(Card target=null)
	{
		List<string> ComboPool = new List<string>(){"ETC_077","ETC_072","EX1_131","VAN_EX1_131","CORE_OG_070","OG_070","EX1_613","VAN_EX1_613","AV_201","DMF_515","ETC_073","VAC_460","RLK_573","VAN_CS2_073","CORE_CS2_073","CS2_073","DMF_519"};
		if(owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)>0)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid(ComboPool.Choice(owner.myPlayer.randomGen)),ZoneType.Hand);
		}
	}
}
public class ETC_078:MinionBase{
//NAME=MC布林顿
//TEXT=<b>战吼：</b>双方玩家各装备一把1/2的麦克风。你对手的麦克风使其受到的所有伤害增加1点！
//MAJ=ROGUE|COST=5|ATK=5|HP=5|RACE=MECHANICAL
}
public class ETC_078e2:Ability{
//NAME=惨遭取笑
//TEXT=你的英雄受到的所有伤害提高一点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_078t:WeaponBase{
//NAME=坏掉的麦克风
//TEXT=你的英雄受到的所有伤害提高1点。
//MAJ=ROGUE|COST=1|ATK=1|HP=2|RACE=NONE
}
public class ETC_078t2:WeaponBase{
//NAME=黄金麦克风
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=2|RACE=NONE
}
public class ETC_079:SpellBase{
//NAME=舞动全场（ft.迦罗娜）
//TEXT=将所有友方随从移回你的手牌。在本回合中，其法力值消耗为（1）点。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_079e:Ability{
//NAME=舞动全场
//TEXT=在本回合中法力值消耗为（1）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_080:MinionBase{
//NAME=乐队经理精英牛头人酋长
//TEXT=在构筑你的套牌时，用3张牌组建一支乐队。<b>战吼：发现</b>其中一张！
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterDiscoverEnd(this,TripleRewardCauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void TripleRewardCauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc==owner)
        {
            new EffectMove(owner.myPlayer, tc,ZoneType.Aside,ZoneType.Hand).Resolve();
        }
    }
	public override void Battlecry(Card target=null)
	{
		List<Card> ToDis = new List<Card>();
		ToDis.Add(new Card(CardDbf.GetCardDbfByGuid("EX1_559"),owner.myPlayer));
		ToDis.Add(new Card(CardDbf.GetCardDbfByGuid("SGS_990013"),owner.myPlayer));
		ToDis.Add(new Card(CardDbf.GetCardDbfByGuid("NX2_033"),owner.myPlayer));
		new EffectDiscoverStart(owner.myPlayer,owner,ToDis).Resolve();
	}
}
public class ETC_081:MinionBase{
//NAME=虚空协奏者
//TEXT=在你的回合中，你的英雄<b>免疫</b>。
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=DEMON
}
public class ETC_081e:Ability{
//NAME=刺耳虚空
//TEXT=<b>免疫</b>
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_082:SpellBase{
//NAME=绝望哀歌
//TEXT=对一个角色造成$3点伤害。如果消灭该角色，从你的牌库中召唤一个恶魔。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class ETC_083:SpellBase{
//NAME=邪魔修音
//TEXT=<b>发现</b>两张恶魔牌。<b>压轴：</b>使其获得+1/+2。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class ETC_083e:Ability{
//NAME=邪魔修音
//TEXT=+1/+2。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_084:WeaponBase{
//NAME=邪弦竖琴
//TEXT=每当你的英雄即将在你的回合受到伤害，改为恢复2点生命值。失去1点耐久度。
//MAJ=WARLOCK|COST=1|ATK=0|HP=3|RACE=NONE
}
public class ETC_085:SpellBase{
//NAME=罪孽交响曲
//TEXT=<b>发现</b>并演奏一段乐章。将其他六段乐章洗入你的牌库。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ETC_085e:Ability{
//NAME=罪孽交响
//TEXT=法力值消耗减少（6）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_085e2:Ability{
//NAME=暴食无尽
//TEXT=+6/+6。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_085t:SpellBase{
//NAME=嫉妒乐章
//TEXT=移除你对手的牌库顶的六张牌。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_085t2:SpellBase{
//NAME=傲慢乐章
//TEXT=抽一张随从牌，并使其法力值消耗减少（6）点。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_085t3:SpellBase{
//NAME=愤怒乐章
//TEXT=对所有角色造成$6点伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_085t4:SpellBase{
//NAME=暴食乐章
//TEXT=随机使你手牌，牌库和战场上的各一个随从获得+6/+6。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_085t6:SpellBase{
//NAME=欲望乐章
//TEXT=<b>吸血</b>。对敌方英雄造成$6点伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_085t7:SpellBase{
//NAME=贪婪乐章
//TEXT=抽六张牌。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_085t8:SpellBase{
//NAME=怠惰乐章
//TEXT=召唤一个6/6并具有<b>嘲讽</b>和<b>复生</b>的恶魔。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_086:MinionBase{
//NAME=强音雷象
//TEXT=<b>嘲讽</b>。<b>亡语：</b>对所有敌方随从造成3点 伤害。
//MAJ=NEUTRAL|COST=10|ATK=6|HP=12|RACE=BEAST
}
public class ETC_087:MinionBase{
//NAME=扩音机
//TEXT=<b>战吼：</b>将你的法力值上限和手牌上限变为11。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=MECHANICAL
}
public class ETC_088:MinionBase{
//NAME=幽灵写手
//TEXT=<b>战吼：</b><b>发现</b>一张法术牌。<b>压轴：</b>再<b>发现</b>一张。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=UNDEAD
}
public class ETC_089:MinionBase{
//NAME=静滞波形
//TEXT=在每个回合开始时，失去1点攻击力或生命值<i>（随机而定）。</i>
//MAJ=NEUTRAL|COST=3|ATK=5|HP=6|RACE=ELEMENTAL
}
public class ETC_089e:Ability{
//NAME=唰唰杂音
//TEXT=-1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_089e2:Ability{
//NAME=沙沙杂音
//TEXT=-1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_098:MinionBase{
//NAME=狼人场务
//TEXT=<b>战吼：</b>为你的对手召唤一个0/3的乐器箱。<i>（打破乐器箱可以获得一张随机武器牌！）</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class ETC_098t:MinionBase{
//NAME=乐器箱
//TEXT=<b>亡语：</b>随机将一张武器牌置入你对手的 手牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=3|RACE=NONE
}
public class ETC_099:MinionBase{
//NAME=公演增强幼龙
//TEXT=<b>可交易</b> <b>压轴：</b>消灭一个敌方随从。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=DRAGON
}
public class ETC_101:MinionBase{
//NAME=牛铃独演者
//TEXT=<b>战吼：</b>如果你没有控制其他随从，造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=NONE
}
public class ETC_102:MinionBase{
//NAME=空气吉他手
//TEXT=<b>战吼：</b>使你的武器获得+1耐久度。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class ETC_102e:Ability{
//NAME=喧闹虚无
//TEXT=+1耐久度。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_103:MinionBase{
//NAME=风潮浪客
//TEXT=<b>战吼：</b><b>发现</b>一张不在对手牌库中的对手职业的法术牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=NONE
}
public class ETC_104:MinionBase{
//NAME=人潮冲浪者
//TEXT=<b>亡语：</b>使任意一个其他随从获得+1/+1和此<b>亡语</b>。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class ETC_104e:Ability{
//NAME=人潮冲浪
//TEXT=+1/+1。<b>亡语：</b>使任意一个其他随从获得+1/+1和此<b>亡语</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_105:MinionBase{
//NAME=立体声图腾
//TEXT=在你的回合结束时，随机使你手牌中的一张随从牌获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=3|RACE=TOTEM
}
public class ETC_105e:Ability{
//NAME=低音增强
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_106:MinionBase{
//NAME=频率振荡机
//TEXT=<b>战吼：</b>你的下一张机械牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=MECHANICAL
}
public class ETC_106e:Ability{
//NAME=振荡
//TEXT=你的下一张机械牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_107:MinionBase{
//NAME=喧哗歌迷
//TEXT=<b>战吼：</b>选择一个随从。当本随从存活时，选中的随从拥有+3攻击力。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=QUILBOAR
}
public class ETC_107e:Ability{
//NAME=喧哗潮流
//TEXT=本随从存活时，{0}拥有+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_107e2:Ability{
//NAME=歌迷的最爱
//TEXT=从{0}处获得了额外效果。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_108:MinionBase{
//NAME=痴醉歌迷
//TEXT=<b>战吼：</b>选择一个随从。当本随从存活时，选中的随从拥有<b>潜行</b>。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
}
public class ETC_108e:Ability{
//NAME=痴醉迷蒙
//TEXT=本随从存活时，{0}拥有<b>潜行</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_109:MinionBase{
//NAME=吵吵歌迷
//TEXT=<b>战吼：</b>选择一个随从。当本随从存活时，选中的随从无法攻击。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=MECHANICAL
}
public class ETC_109e:Ability{
//NAME=吵吵闹闹
//TEXT=本随从存活时，{0}无法攻击。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_110:MinionBase{
//NAME=封面艺人
//TEXT=<b>战吼：</b>变形成为一个随从的3/3的复制。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class ETC_110e:Ability{
//NAME=音障封面
//TEXT=3/3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_111:MinionBase{
//NAME=商品卖家
//TEXT=在你的回合结束时，随机将一张法术牌置于你对手的牌库顶。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NAGA
}
public class ETC_113:MinionBase{
//NAME=摄影师菲兹尔
//TEXT=<b>战吼：</b>拍摄你当前的手牌，并将照片洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		Card Photo = TaskCreate(CardDbf.GetCardDbfByGuid("ETC_113t"),ZoneType.Deck,randpos:true);
		foreach(Card c in owner.myPlayer.hand)
		{
			Photo.attachmentList.Add(c);
		}
	}
}
public class ETC_113e:Ability{
//NAME=菲兹尔的照片记录
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_113t:SpellBase{
//NAME=菲兹尔的照片
//TEXT=将照片中的卡牌置入你的手牌。0将照片中的{0}张卡牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		foreach(Card c in owner.attachmentList)
		{
			TaskCreate(c.cardDbf,ZoneType.Hand);
		}
	}

}
public class ETC_121:MinionBase{
//NAME=摇滚教父沃恩
//TEXT=<b>战吼：</b>复制你手牌中每个不同类型的随从牌各一张。
//MAJ=WARRIOR|COST=3|ATK=4|HP=3|RACE=NONE
}
public class ETC_200:SpellBase{
//NAME=突进舞台
//TEXT=抽两张<b>突袭</b>随从牌，使其法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_200e:Ability{
//NAME=突进舞台
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_201:SpellBase{
//NAME=一串香蕉
//TEXT=使一个随从获得+1/+1。<i>（还剩3根香蕉！）</i>
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ETC_201e:Ability{
//NAME=香蕉
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_201t:SpellBase{
//NAME=一串香蕉
//TEXT=使一个随从获得+1/+1。<i>（还剩2根香蕉！）</i>
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ETC_201t2:SpellBase{
//NAME=一串香蕉
//TEXT=使一个随从获得+1/+1。<i>（最后一根香蕉！）</i>
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ETC_205:SpellBase{
//NAME=加大音量
//TEXT=抽三张法术牌。<b>压轴：</b>从中<b>发现</b>一张复制。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class ETC_206:SpellBase{
//NAME=巅峰无限
//TEXT=<b>发现</b>一张法术牌，其法力值消耗减少（1）点。<b>压轴：</b>在回合结束时将本牌移回你的手牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ETC_206e:Ability{
//NAME=巅峰无限
//TEXT=在你的回合结束时，获取一张震撼全场。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_206e2:Ability{
//NAME=无限
//TEXT=法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_207:SpellBase{
//NAME=一桶欢猢
//TEXT=召唤一只1/4并具有<b>嘲讽</b>的猴子。<i>（还剩3只猴子！）</i>
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ETC_207t:SpellBase{
//NAME=一桶欢猢
//TEXT=召唤一只1/4并具有<b>嘲讽</b>的猴子。<i>（还剩2只猴子！）</i>
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ETC_207t2:SpellBase{
//NAME=一桶欢猢
//TEXT=召唤一只1/4并具有<b>嘲讽</b>的猴子。<i>（最后一只猴子！）</i>
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ETC_208:SpellBase{
//NAME=荆棘谷之心
//TEXT=<b>可交易</b> 复活所有法力值消耗大于或等于（5）点的友方野兽。
//MAJ=HUNTER|COST=8|ATK=0|HP=0|RACE=NONE
}
public class ETC_209:MinionBase{
//NAME=硬核信徒
//TEXT=<b>战吼：</b>造成2点伤害。<b>压轴：</b>改为对所有敌人。
//MAJ=DEATHKNIGHT|COST=3|ATK=2|HP=1|RACE=UNDEAD
}
public class ETC_210:SpellBase{
//NAME=通灵最强音
//TEXT=<b>吸血</b>。造成${0}点伤害。召唤{1}个{2}/{3}的灵魂。<i>（随你消耗过的<b>尸体</b>数量随机提升）</i>
//MAJ=DEATHKNIGHT|COST=10|ATK=0|HP=0|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("LifeSteal");
	}
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,7).Resolve();
		TaskCreate(CardDbf.GetCardDbfByGuid("ICCA08_033"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("ICCA08_033"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("ICCA08_033"),ZoneType.Board);
	}
}
public class ETC_305:SpellBase{
//NAME=暗弦术：改
//TEXT=使一个随从获得-5/-5。如果该随从拥有0点攻击力，将其消灭。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class ETC_305e:Ability{
//NAME=扭曲变形
//TEXT=-5/-5。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_312:WeaponBase{
//NAME=爱豆的爱
//TEXT=你的英雄技能法力值消耗为（0）点。在你使用技能后，失去1点耐久度。
//MAJ=PRIEST|COST=1|ATK=0|HP=2|RACE=NONE
}
public class ETC_312e:Ability{
//NAME=唱吧！
//TEXT=你的英雄技能的法力值消耗为（0）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_314:SpellBase{
//NAME=悦耳流行歌
//TEXT=对所有随从造成$3点伤害。召唤一个6/6的流行歌星。<i>（每回合切换。）</i>
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=HOLY
}
public class ETC_314t:SpellBase{
//NAME=刺耳流行歌
//TEXT=对所有随从造成$6点伤害。召唤一个3/3的流行歌星。<i>（每回合切换。）</i>
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=HOLY
}
public class ETC_314t2:MinionBase{
//NAME=流行歌星
//TEXT=
//MAJ=PRIEST|COST=1|ATK=1|HP=1|RACE=NONE
}
public class ETC_316:SpellBase{
//NAME=争宠互撕
//TEXT=选择两个敌方随从，使其互相攻击！将死亡的随从的复制置入你的手牌。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class ETC_317:WeaponBase{
//NAME=迪斯科战槌
//TEXT=<b>亡语：</b>随机使一个友方随从获得+1/+1。<i>（装备期间，使用随从牌以提升此效果！）</i>
//MAJ=PALADIN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class ETC_317e:Ability{
//NAME=迪斯科之力
//TEXT=属性值提高。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_318:SpellBase{
//NAME=布吉舞乐
//TEXT=从你的牌库中召唤两个法力值消耗为（1）的随从。<b>压轴：</b>再召唤一个。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class ETC_320:SpellBase{
//NAME=光芒汇聚
//TEXT=<b>可交易</b> 将一个友方<b>圣盾</b>转化为一个5/5的元素。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class ETC_320t:MinionBase{
//NAME=活化灯光
//TEXT=
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=ELEMENTAL
}
public class ETC_321:MinionBase{
//NAME=吵吵演艺团
//TEXT=<b>嘲讽</b>，<b>圣盾</b>。<b>亡语：</b>召唤三个1/2并具有<b>嘲讽</b>和<b>圣盾</b>的机械。
//MAJ=PALADIN|COST=9|ATK=3|HP=6|RACE=MECHANICAL
}
public class ETC_324:MinionBase{
//NAME=摇摆舞虫
//TEXT=<b>圣盾</b>。在一个友方角色失去<b>圣盾</b>后，抽一张牌。
//MAJ=PALADIN|COST=4|ATK=4|HP=3|RACE=BEAST
}
public class ETC_325:MinionBase{
//NAME=音乐治疗师
//TEXT=<b>突袭</b>。<b>压轴：</b>获得<b>吸血</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class ETC_326:MinionBase{
//NAME=狗仔队
//TEXT=<b>战吼：</b><b>发现</b>一张<b>传说</b>随从牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class ETC_328:MinionBase{
//NAME=领舞
//TEXT=<b>亡语：</b>从你的牌库中召唤一个攻击力小于本随从攻击力的随从。
//MAJ=PALADIN|COST=6|ATK=4|HP=2|RACE=NONE
}
public class ETC_329:MinionBase{
//NAME=舞王坎格尔
//TEXT=<b>吸血</b>。<b>亡语：</b>将本随从与你手牌中的一个随从互换，并使其获得<b>吸血</b>。
//MAJ=PALADIN|COST=5|ATK=3|HP=3|RACE=NONE
}
public class ETC_330:SpellBase{
//NAME=星光节律
//TEXT=使你的英雄获得<b>圣盾</b>。在本局对战的剩余时间内，使用神圣法术牌会复原此效果。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class ETC_330e1:Ability{
//NAME=感受节律
//TEXT=在你施放神圣法术后获得<b>圣盾</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_332:MinionBase{
//NAME=梦中男神
//TEXT=<b>战吼：</b>为所有其他友方随从恢复#3点生命值。每有一个被<b>过量治疗</b>，便获得+1/+1。
//MAJ=PRIEST|COST=2|ATK=1|HP=2|RACE=NAGA
}
public class ETC_332e:Ability{
//NAME=如梦似幻
//TEXT=+1/+1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_334:MinionBase{
//NAME=碎心歌手赫达尼斯
//TEXT=<b>战吼：</b>对本随从造成4点伤害。<b>过量治疗：</b>随机对一个敌人造成5点伤害。
//MAJ=PRIEST|COST=4|ATK=4|HP=8|RACE=NONE
}
public class ETC_335:SpellBase{
//NAME=真爱永恒
//TEXT=你每个回合使用的第一张法术牌的法力值消耗减少（2）点。此效果持续到你在你的回合中未使用法术牌为止。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class ETC_335e:Ability{
//NAME=永恒真爱
//TEXT=你每个回合使用的第一张法术牌的法力值消耗减少（2）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_336:MinionBase{
//NAME=自由飞鸟
//TEXT=<b>冲锋</b>。<b>战吼：</b>在本局对战中，你每使用过一张其他自由飞鸟，便获得+1/+1。0<i>（已使用0张）</i>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=BEAST
}
public class ETC_336e:Ability{
//NAME=鸟儿的自由
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_337:MinionBase{
//NAME=放克鱼人
//TEXT=<b>圣盾</b>。你的<b>圣盾</b>随从拥有+2攻击力。
//MAJ=PALADIN|COST=3|ATK=2|HP=2|RACE=MURLOC
}
public class ETC_337e:Ability{
//NAME=放克风
//TEXT=+2攻击力
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_338:SpellBase{
//NAME=真弦术：合
//TEXT=选择一个随从，将一张它的复制置入你的手牌。<b>压轴：</b>使其均获得+1/+2。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class ETC_338e:Ability{
//NAME=同步协调
//TEXT=+1/+2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_339:MinionBase{
//NAME=心动歌手
//TEXT=<b>过量治疗：</b>随机召唤一个法力值消耗等同于<b>过量治疗</b>量的随从。
//MAJ=PRIEST|COST=3|ATK=2|HP=5|RACE=UNDEAD
}
public class ETC_349:MinionBase{
//NAME=过气明星
//TEXT=<b>亡语：</b>随机召唤一个来自过去的法力值消耗为（5）的随从。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=UNDEAD
}
public class ETC_350:MinionBase{
//NAME=派对动物
//TEXT=<b>战吼：</b>使你手牌中每个不同类型的各一张随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class ETC_350e:Ability{
//NAME=认真轰趴
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_355:MinionBase{
//NAME=剃刀沼泽摇滚明星
//TEXT=在你获得护甲值后，再获得2点。
//MAJ=WARRIOR|COST=1|ATK=1|HP=3|RACE=QUILBOAR
}
public class ETC_356:SpellBase{
//NAME=变音和弦
//TEXT=<b>吸血</b>。对一个随从造成$6点伤害。如果你有<b>过载</b>的法力水晶，本牌的法力值消耗减少（3）点。
//MAJ=SHAMAN|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class ETC_357:MinionBase{
//NAME=铜管元素
//TEXT=<b>突袭</b>，<b>圣盾</b>，<b>嘲讽</b>，<b>风怒</b>
//MAJ=SHAMAN|COST=4|ATK=3|HP=3|RACE=ELEMENTAL
}
public class ETC_358:MinionBase{
//NAME=萨克斯独演者
//TEXT=<b>战吼：</b>如果你没有控制其他随从，将一张萨克斯独演者置入你的手牌。
//MAJ=SHAMAN|COST=1|ATK=1|HP=2|RACE=MURLOC
}
public class ETC_359:MinionBase{
//NAME=驭流骑士
//TEXT=<b>战吼：</b>如果你有<b>过载</b>的法力水晶，从你的牌库中<b>发现</b>一张法术牌。
//MAJ=SHAMAN|COST=1|ATK=2|HP=1|RACE=NAGA
}
public class ETC_362:SpellBase{
//NAME=跳吧，虫子！
//TEXT=将一个随从变形成为炎魔之王拉格纳罗斯。<b>过载：</b>（2）
//MAJ=SHAMAN|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class ETC_363:SpellBase{
//NAME=主歌乐句
//TEXT=在本回合中，使你的英雄获得+2攻击力。获得2点护甲值。<b>压轴：</b>演奏你的上一个乐句。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ETC_363e:Ability{
//NAME=主歌独唱
//TEXT=在本回合中获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_363e2:Ability{
//NAME=乐句休止
//TEXT=用来终止乐句循环。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_364:SpellBase{
//NAME=副歌乐句
//TEXT=抽一张随从牌，使其获得+3/+3。<b>压轴：</b>演奏你的上一个乐句。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_364e:Ability{
//NAME=副歌齐唱
//TEXT=+3/+3。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_365:SpellBase{
//NAME=过渡乐句
//TEXT=召唤一个3/4并具有<b>嘲讽</b>的乐手和一个4/3并具有<b>突袭</b>的乐手。<b>压轴：</b>演奏你的上一个乐句。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ETC_365t:MinionBase{
//NAME=硬派摇滚乐手
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=3|ATK=3|HP=4|RACE=NONE
}
public class ETC_365t2:MinionBase{
//NAME=狂躁摇滚乐手
//TEXT=<b>突袭</b>
//MAJ=WARRIOR|COST=3|ATK=4|HP=3|RACE=NONE
}
public class ETC_367:SpellBase{
//NAME=音乐狂欢
//TEXT=在本回合中，每当你使用一张随从牌，随机将一张萨满祭司法术牌置入你的手牌。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_367e:Ability{
//NAME=音乐狂欢
//TEXT=在本回合中，当你使用一张随从牌，随机将一张萨满祭司法术牌置入你的手牌。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_369:SpellBase{
//NAME=清冷音韵
//TEXT=恢复#8点生命值。<b>压轴：</b>召唤一个3/3并具有<b>嘲讽</b>的元素。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=FROST
}
public class ETC_369t:MinionBase{
//NAME=清冷元素
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=3|ATK=3|HP=3|RACE=ELEMENTAL
}
public class ETC_370:SpellBase{
//NAME=聚集观众
//TEXT=随机召唤法力值消耗为（6），（5），（4）和（3）的随从各一个。<b>过载：</b>（2）
//MAJ=SHAMAN|COST=7|ATK=0|HP=0|RACE=NONE
}
public class ETC_371:MinionBase{
//NAME=因扎
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你的<b>过载</b>牌法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NONE
}
public class ETC_371e1:Ability{
//NAME=超级酷炫
//TEXT=在本局对战的剩余时间内，你的<b>过载<b>牌法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_371e2:Ability{
//NAME=超级酷炫
//TEXT=法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_372:SpellBase{
//NAME=掌声雷动
//TEXT=抽一张牌。你每控制一个不同类型的随从，重复一次。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ETC_373:SpellBase{
//NAME=集会鼓圈
//TEXT=<b>抉择：</b>召唤五个2/2的树人；或者使你的所有随从获得+2/+4和<b>嘲讽</b>。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class ETC_373a:SpellBase{
//NAME=花朵力量
//TEXT=召唤五个2/2的树人。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class ETC_373b:SpellBase{
//NAME=美妙振动
//TEXT=使你的所有随从获得+2/+4和 <b>嘲讽</b>。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class ETC_373be:Ability{
//NAME=根音符
//TEXT=+2/+4。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_373t:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
	
	public override void Deathrattle()
	{
		if(owner.hateCard!=null)
		{
			TaskCreate(owner.hateCard.cardDbf,ZoneType.Hand);
		}
		else{
			TaskCreate(CardDbf.GetCardDbfByGuid("EX1_161"),ZoneType.Hand);
		}
		
	}
}
public class ETC_375:MinionBase{
//NAME=沉静的吹笛人
//TEXT=<b>抉择：</b>抽一张野兽牌；或者<b>发现</b>一张野兽牌。
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=NONE
}
public class ETC_375a:SpellBase{
//NAME=和善欢颜
//TEXT=抽一张野兽牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ETC_375b:SpellBase{
//NAME=馨暖嬉笑
//TEXT=<b>发现</b>一张野兽牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ETC_376:MinionBase{
//NAME=盛夏花童
//TEXT=<b>战吼：</b>抽两张法力值消耗大于或等于（6）点的牌。<b>压轴：</b>使其法力值消耗减少（1）点。
//MAJ=DRUID|COST=5|ATK=4|HP=5|RACE=NONE
}
public class ETC_376e:Ability{
//NAME=阳光
//TEXT=法力值消耗减少（1）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_379:SpellBase{
//NAME=悦耳轻音乐
//TEXT=在本回合中，使你的英雄获得+2攻击力。获得4点护甲值。<i>（每回合切换。）</i>
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ETC_379e:Ability{
//NAME=悦耳鼓声
//TEXT=在本回合中获得+2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_379e2:Ability{
//NAME=刺耳鼓声
//TEXT=在本回合中，+4攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_379t:SpellBase{
//NAME=刺耳轻音乐
//TEXT=在本回合中，使你的英雄获得+4攻击力。获得2点护甲值。<i>（每回合切换。）</i>
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ETC_382:MinionBase{
//NAME=自由之魂
//TEXT=<b>战吼，亡语：</b>在本局对战中，你的英雄技能多获得1点护甲值。
//MAJ=DRUID|COST=1|ATK=1|HP=2|RACE=BEAST
}
public class ETC_384:SpellBase{
//NAME=散布消息
//TEXT=抽两张牌。你的英雄每有一点攻击力，本牌的法力值消耗便减少（1）点。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class ETC_385:MinionBase{
//NAME=潮流猎豹
//TEXT=<b>战吼，亡语：</b>在本局对战中，你的英雄技能使你的英雄多获得1点攻击力。
//MAJ=DRUID|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class ETC_386:MinionBase{
//NAME=佐克·雾鼻
//TEXT=<b>战吼：</b>召唤两个{0}/{1}并具有<b>嘲讽</b>的野猪人。<i>（随你的英雄本回合获得的攻击力和护甲值提升！）</i>
//MAJ=DRUID|COST=6|ATK=6|HP=6|RACE=QUILBOAR
}
public class ETC_386t:MinionBase{
//NAME=雾鼻歌迷
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=QUILBOAR
}
public class ETC_387:SpellBase{
//NAME=根音古韵
//TEXT=<b>秘密抉择：</b>2回合后召唤三棵5/5的古树；或者4回合后召唤三个8/8的巨人。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class ETC_387b:SpellBase{
//NAME=古树之韵
//TEXT=2回合后，<b>秘密</b>召唤三棵5/5的古树。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class ETC_387bt:MinionBase{
//NAME=古树
//TEXT=
//MAJ=DRUID|COST=5|ATK=5|HP=5|RACE=NONE
}
public class ETC_387c:SpellBase{
//NAME=巨人之舞
//TEXT=4回合后，<b>秘密</b>召唤三个8/8的巨人。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class ETC_387ct:MinionBase{
//NAME=树巨人
//TEXT=
//MAJ=DRUID|COST=8|ATK=8|HP=8|RACE=NONE
}
public class ETC_387t:SpellBase{
//NAME=根音古韵
//TEXT=<b>秘密抉择：</b>2回合后召唤三棵5/5的古树；或者4回合后召唤三个8/8的巨人。02回合后<b>秘密</b>召唤三棵5/5的古树。04回合后<b>秘密</b>召唤三个8/8的巨人。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class ETC_388:WeaponBase{
//NAME=实木手鼓
//TEXT=<b>亡语：</b>召唤1棵5/5的古树。<i>（装备期间，使用法力值消耗5点或以上的卡牌以提升此效果！）</i>
//MAJ=DRUID|COST=4|ATK=2|HP=3|RACE=NONE
}
public class ETC_394:SpellBase{
//NAME=混乱品味
//TEXT=对一个随从造成$2点伤害。<b>压轴：</b><b>发现</b>一张邪能法术牌。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=FEL
}
public class ETC_395:MinionBase{
//NAME=DJ法力风暴
//TEXT=<b>战吼：</b>将你手牌中的法术牌法力值消耗变为（0）点。在你使用其中一张后，其余的法力值消耗增加（1）点。
//MAJ=MAGE|COST=10|ATK=8|HP=8|RACE=NONE
}
public class ETC_395e:Ability{
//NAME=豪斯 in the House！
//TEXT=在你使用其他减费的法术牌后，本牌的法力值消耗增加（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_395e2:Ability{
//NAME=加大音量
//TEXT=在你使用其他减费的法术牌后，本牌的法力值消耗增加（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_398:MinionBase{
//NAME=暗影之眼
//TEXT=你的英雄拥有<b>吸血</b>。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=3|RACE=DEMON
}
public class ETC_399:MinionBase{
//NAME=哈维利亚·墨鸦
//TEXT=<b>突袭</b>。在一个友方<b>突袭</b>随从攻击后，使你的随从获得+1攻击力。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=3|RACE=NONE
}
public class ETC_399e:Ability{
//NAME=哀伤之弦
//TEXT=+1攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_400:MinionBase{
//NAME=乐器杀手
//TEXT=每当你的武器被摧毁时，随机装备一把恶魔猎手武器。
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=6|RACE=NONE
}
public class ETC_405:WeaponBase{
//NAME=战刃吉他
//TEXT=<b>亡语：</b>抽1张牌。<i>（装备期间，使用<b>流放</b>牌以提升此效果！）</i>
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=2|RACE=NONE
}
public class ETC_408:MinionBase{
//NAME=滑铲铁腿
//TEXT=<b>突袭</b>。<b>战吼：</b>在本局对战中，你每使用过一个不同类型的随从牌，便获得+1/+1。0<i>（已使用0个）</i>
//MAJ=WARRIOR|COST=3|ATK=2|HP=3|RACE=NONE
}
public class ETC_408e:Ability{
//NAME=滑铲
//TEXT=+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_409:MinionBase{
//NAME=融合独奏团
//TEXT=<b>战吼：</b>在本局对战中，你每使用过一个不同类型的随从牌，便随机获得一项<b>额外效果</b>。0<i>（已使用0个）</i>
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=ALL
}
public class ETC_409e:Ability{
//NAME=曲风融合
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_410:MinionBase{
//NAME=蛇啮鼓手
//TEXT=<b>突袭</b>。<b>战吼：</b>在本回合中每有一个随从死亡，便获得+1/+1。0<i>（已死亡0个）</i>
//MAJ=DEMONHUNTER|COST=2|ATK=1|HP=1|RACE=NAGA
}
public class ETC_410e:Ability{
//NAME=蛇牙穿刺
//TEXT=+1/+1。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_411:SpellBase{
//NAME=保安！！
//TEXT=召唤两个1/1并具有<b>突袭</b>的伊利达雷。<b>流放：</b>再召唤一个。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ETC_413:SpellBase{
//NAME=低沉摇摆
//TEXT=在本回合中，使你的英雄获得+2攻击力和<b>免疫</b>，然后攻击每个敌方随从。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		
		Card Hero = owner.myPlayer.hero[0];
		if(Hero!=null)
		{
			TaskBuffMyHero(atk:2);
			new EffectGiveAbility(owner.myPlayer,owner,owner.myPlayer.hero[0],"Immue").Resolve();
			List<Card> ToAtk= new List<Card>();
			foreach(Card c in owner.myPlayer.otherPlayer.board)
			{
				ToAtk.Add(c);
			}
			foreach(Card c in ToAtk)
			{
				new EffectAttack(owner.myPlayer,Hero,c).Resolve();
			}
		}
	}
}
public class ETC_413e:Ability{
//NAME=摇摆
//TEXT=在本回合中获得+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_413e2:Ability{
//NAME=低沉
//TEXT=在本回合中<b>免疫</b>。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_417:SpellBase{
//NAME=黑石摇滚
//TEXT=使你牌库中的所有随从牌获得等同于其法力值消耗的攻击力和生命值。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class ETC_417e:Ability{
//NAME=黑石摇滚
//TEXT=属性值提高。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_418:MinionBase{
//NAME=乐器技师
//TEXT=<b>战吼：</b> 抽一张武器牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=NONE
}
public class ETC_419:MinionBase{
//NAME=摇滚缝合怪
//TEXT=<b>突袭</b>。在本随从攻击后，获得+1攻击力并随机攻击一个敌方随从。
//MAJ=NEUTRAL|COST=8|ATK=3|HP=10|RACE=UNDEAD
}
public class ETC_419e:Ability{
//NAME=正在摇滚
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_420:MinionBase{
//NAME=服装裁缝
//TEXT=<b>战吼：</b>使一个友方随从获得等同于本随从的攻击力和生命值。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class ETC_420e:Ability{
//NAME=时尚衣装
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_422:MinionBase{
//NAME=计拍侏儒
//TEXT=在你使用一张法力值消耗为（{0}）的卡牌后，抽一张法力值消耗为（{1}）的牌。<i>（然后调高！）</i>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=MECHANICAL
}
public class ETC_423:WeaponBase{
//NAME=奥金利斧
//TEXT=<b>亡语：</b>召唤一个1/1并具有<b>吸血</b>的亡灵。<i>（装备期间，在你的回合中使你的生命值发生变化以提升此效果！）</i>
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=2|RACE=NONE
}
public class ETC_423t:MinionBase{
//NAME=凋零猪头
//TEXT=<b>吸血</b>
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class ETC_424:SpellBase{
//NAME=死亡嘶吼
//TEXT=选择一个随从。将其<b>亡语</b>传播到相邻随从上。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ETC_424e:Ability{
//NAME=死亡之墙
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_425:MinionBase{
//NAME=音响工程师普兹克
//TEXT=<b>战吼：</b>将两张3/3的机器人置入你对手的手牌。<b>亡语：</b>为你自己召唤这些机器人。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class ETC_425t:MinionBase{
//NAME=音响机器人
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class ETC_427:SpellBase{
//NAME=悦耳金属
//TEXT=随机使你手牌中的4张随从牌获得+2/+2。<i>（每回合切换。）</i>
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListBuff = new List<Card>();
		List<Card> MinionInHand = new List<Card>();
		foreach(Card c in MinionInHand)
		{
			if(c.cardType==CardType.Minion)
			{
				MinionInHand.Add(c);
			}
		}
		while(true)
		{
			if(ToListBuff.Count>=4 || MinionInHand.Count==0)
			{
				break;
			}
			Card ToAdd = MinionInHand.Choice(owner.myPlayer.randomGen);
			if(ToAdd!=null)
			{
				MinionInHand.Remove(ToAdd);
				ToListBuff.Add(ToAdd);
			}
		}
		TaskBuffTargets(ToListBuff,atk:2,hp:2);
	}
}
public class ETC_427e:Ability{
//NAME=悦耳现场
//TEXT=+2/+2。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_427e2:Ability{
//NAME=刺耳现场
//TEXT=+4/+4。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_427t:SpellBase{
//NAME=刺耳金属
//TEXT=随机使你手牌中的2张随从牌获得+4/+4。<i>（每回合切换。）</i>
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ETC_428:MinionBase{
//NAME=碎骨速弹吉他手
//TEXT=<b>战吼：</b>消耗5具<b>尸体</b>，触发并获得一个在本局对战中死亡的友方随从的<b>亡语</b>。
//MAJ=DEATHKNIGHT|COST=5|ATK=5|HP=4|RACE=UNDEAD
}
public class ETC_428e:Ability{
//NAME=碎骨速弹
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_449:LocationBase{
//NAME=粉丝俱乐部
//TEXT=为所有友方角色恢复#3点生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=2|RACE=NONE
}
public class ETC_506:SpellBase{
//NAME=悦耳迪斯科
//TEXT=<b>发现</b>一张法力值消耗为（5）的随从牌。召唤该随从并使其获得+1/+1。<i>（每回合切换。）</i>
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class ETC_506e:Ability{
//NAME=悦耳律动
//TEXT=+1/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_506t:SpellBase{
//NAME=刺耳迪斯科
//TEXT=<b>发现</b>一张法力值消耗为（1）的随从牌。召唤该随从并使其获得+5/+5。<i>（每回合切换。）</i>
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class ETC_506te:Ability{
//NAME=刺耳律动
//TEXT=+5/+5。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_518:WeaponBase{
//NAME=搓盘机
//TEXT=<b>亡语：</b>复原1个法力水晶。<i>（装备期间，使用<b>连击</b>牌以提升此效果！）</i>
//MAJ=ROGUE|COST=3|ATK=3|HP=2|RACE=NONE
}
public class ETC_520:WeaponBase{
//NAME=科多兽皮组鼓
//TEXT=<b>亡语：</b>对所有随从造成1点伤害。<i>（装备期间，获得护甲值以提升此效果！）</i>
//MAJ=WARRIOR|COST=4|ATK=3|HP=2|RACE=NONE
}
public class ETC_521:WeaponBase{
//NAME=星界键盘
//TEXT=在你施放一个法术后，召唤一个属性值等同于其法力值消耗的元素。失去1点耐久度。
//MAJ=MAGE|COST=2|ATK=0|HP=3|RACE=NONE
}
public class ETC_521t:MinionBase{
//NAME=星界造物
//TEXT=
//MAJ=MAGE|COST=1|ATK=1|HP=1|RACE=ELEMENTAL
}
public class ETC_522:MinionBase{
//NAME=尖叫女妖
//TEXT=<b>吸血</b>。在你的英雄获得生命值后，召唤一个具有等量攻击力与生命值的灵魂。
//MAJ=DEATHKNIGHT|COST=5|ATK=3|HP=6|RACE=UNDEAD
}
public class ETC_522t:MinionBase{
//NAME=死忠歌迷
//TEXT=
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class ETC_523:MinionBase{
//NAME=死亡金属骑士
//TEXT=<b>嘲讽</b>。在本回合中，如果你的英雄受到治疗，本牌改为消耗生命值而非法力值。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=4|RACE=UNDEAD
}
public class ETC_526:MinionBase{
//NAME=凯吉·海德
//TEXT=<b>亡语：</b>召唤一只9/9并具有<b>冲锋</b>和<b>嘲讽</b>的凋零野猪。
//MAJ=DEATHKNIGHT|COST=8|ATK=5|HP=1|RACE=UNDEAD
}
public class ETC_526t:MinionBase{
//NAME=凋零野猪
//TEXT=<b>冲锋</b>，<b>嘲讽</b>
//MAJ=DEATHKNIGHT|COST=9|ATK=9|HP=9|RACE=UNDEAD
}
public class ETC_528:SpellBase{
//NAME=灯光表演
//TEXT=向敌人发射2道可以造成$2点伤害的灯光。你此后的灯光表演多发射一道。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class ETC_532:SpellBase{
//NAME=倒带
//TEXT=<b>发现</b>你在本局对战中施放过的其他法术的一张复制。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class ETC_533:LocationBase{
//NAME=狂欢舞台
//TEXT=消耗3具<b>尸体</b>，使一个友方随从获得<b>复生</b>。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=2|RACE=NONE
}
public class ETC_534:MinionBase{
//NAME=全息技师
//TEXT=在任意随从受到刚好1点伤害后，将其消灭。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=NONE
}
public class ETC_535:SpellBase{
//NAME=元素混合
//TEXT=随机将法力值消耗为（1），（2）和（3）的元素牌各一张置入你的手牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ETC_536:MinionBase{
//NAME=音频切分机
//TEXT=<b>亡语：</b>复制你手牌中法力值消耗最高的法术牌。
//MAJ=MAGE|COST=2|ATK=3|HP=2|RACE=MECHANICAL
	public override void Battlecry(Card target=null)
	{
		Card MaxCost = null;
		foreach(Card c in owner.myPlayer.hand)
		{
			if(c.cardType==CardType.Spell)
			{
				if(MaxCost!=null)
				{
					if(c.GetTag(GameTag.Mana)>=MaxCost.GetTag(GameTag.Mana))
					{
						MaxCost=c;
					}
				}
				else{
					MaxCost=c;
				}
			}
		}
		TaskCreate(MaxCost.cardDbf,ZoneType.Hand);
	}
}
public class ETC_540:MinionBase{
//NAME=烟火技师
//TEXT=在你施放一个法术后，随机将一张火焰法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=NONE
}
public class ETC_541:MinionBase{
//NAME=盗版之王托尼
//TEXT=<b>战吼：</b>将你的牌库替换成对手牌库的复制。<b>压轴：</b>抽一张牌。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=6|RACE=PIRATE
}
public class ETC_542:MinionBase{
//NAME=音乐节保安
//TEXT=<b>嘲讽</b>。<b>压轴：</b>迫使所有敌方随从攻击本随从。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=NONE
}
public class ETC_543:MinionBase{
//NAME=举烛观众
//TEXT=<b>圣盾</b>。<b>压轴：</b>使相邻的随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class ETC_717:SpellBase{
//NAME=悦耳嘻哈
//TEXT=造成$1点伤害。使你的武器获得+3攻击力。<i>（每回合切换。）</i>
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class ETC_717e:Ability{
//NAME=悦耳节拍
//TEXT=+3攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_717t:SpellBase{
//NAME=刺耳嘻哈
//TEXT=造成$3点伤害。使你的武器获得+1攻击力。<i>（每回合切换。）</i>
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class ETC_717te:Ability{
//NAME=刺耳节拍
//TEXT=+1攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_742:MinionBase{
//NAME=摇滚巨石
//TEXT=<b>突袭</b>。<b>战吼：</b>如果你使用的上一张牌法力值消耗为（1）点，便获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=ELEMENTAL
}
public class ETC_742e:Ability{
//NAME=滚滚而来
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_813:WeaponBase{
//NAME=爵士贝斯
//TEXT=<b>亡语：</b>你的下一张法术牌法力值消耗减少（1）点。<i>（装备期间，<b>过载</b>以提升此效果！）</i>
//MAJ=SHAMAN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class ETC_813e:Ability{
//NAME=电流滑步
//TEXT=你的下一张法术牌法力值消耗减少。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_813e2:Ability{
//NAME=电流滑步
//TEXT=法力值消耗减少。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_831:MinionBase{
//NAME=刺鬃乐师
//TEXT=<b>压轴：</b>你召唤的下一只野兽获得+1/+1。
//MAJ=HUNTER|COST=1|ATK=1|HP=3|RACE=QUILBOAR
}
public class ETC_831e:Ability{
//NAME=刺鬃缪斯
//TEXT=你召唤的下一只野兽获得+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_831e1:Ability{
//NAME=刺鬃缪斯
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_832:WeaponBase{
//NAME=丛林弹唱琴
//TEXT=<b>亡语：</b>随机召唤一只法力值消耗为（1）的野兽。<i>（装备期间，施放法术以提升此效果！）</i>
//MAJ=HUNTER|COST=4|ATK=4|HP=2|RACE=NONE
}
public class ETC_833:MinionBase{
//NAME=箭矢工匠
//TEXT=在你施放一个法术后，对生命值最低的敌人造成1点伤害。
//MAJ=HUNTER|COST=2|ATK=2|HP=3|RACE=NAGA
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.cardType==CardType.Spell)
			{
				TaskDamageEnemyHero(1);
			}	
		}
	}
}
public class ETC_836:MinionBase{
//NAME=穆克拉先生
//TEXT=<b>突袭</b>。<b>战吼：</b>用香蕉填满你对手的手牌。
//MAJ=HUNTER|COST=6|ATK=10|HP=10|RACE=BEAST
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
    public override void Battlecry(Card target=null)
    {
        CardDbf bana=CardDbf.GetCardDbfByGuid("EX1_014t");
        for(int i =0;i<12;i++)
        {
        	TaskCreate(bana,ZoneType.Hand,ToEn:true);
        }
    }
}
public class ETC_838:SpellBase{
//NAME=宏大梦想
//TEXT=从你的手牌中召唤法力值消耗最高的野兽，使其<b>休眠</b>2回合。
//MAJ=HUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ETC_838e2:Ability{
//NAME=暖场热身
//TEXT=<b>休眠</b>。 2回合后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_840:MinionBase{
//NAME=班卓龙
//TEXT=<b>突袭</b>。每当本随从攻击时，抽一张野兽牌并获得其属性值。
//MAJ=HUNTER|COST=10|ATK=5|HP=6|RACE=BEAST
}
public class ETC_840e:Ability{
//NAME=恐龙明星
//TEXT=属性值提高。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_COIN1:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_COIN2:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ETC_t8t:MinionBase{
//NAME=厌烦的末日领主
//TEXT=<b>嘲讽</b>，<b>复生</b>
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=DEMON
}
