using System.Collections;
using System.Collections.Generic;

public class BRM_001:SpellBase{
//NAME=严正警戒
//TEXT=抽两张牌。在本回合中每有一个随从死亡，本牌的法力值消耗便减少（1）点。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=NONE
}
public class BRM_001e:Ability{
//NAME=熔化
//TEXT=在本回合中，攻击力变为0。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BRM_002:MinionBase{
//NAME=火妖
//TEXT=在你施放一个法术后，造成2点伤害，随机分配到所有敌人身上。
//MAJ=MAGE|COST=3|ATK=2|HP=4|RACE=NONE
}
public class BRM_003:SpellBase{
//NAME=龙息术
//TEXT=造成$4点伤害。在本回合中每有一个随从死亡，本牌的法力值消耗便减少（1）点。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class BRM_003e:Ability{
//NAME=龙息之力
//TEXT=在本回合中，法力值消耗减少（3）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BRM_004:MinionBase{
//NAME=暮光雏龙
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便获得+2生命值。
//MAJ=PRIEST|COST=1|ATK=2|HP=1|RACE=DRAGON
	public override void Battlecry(Card target=null)
	{
		if(CondHoldAnotherRace(RaceType.Dragon))
		{
			new EffectChange(owner.myPlayer,owner,owner,hpChange:2).Resolve();
		}
	}
}
public class BRM_004e:Ability{
//NAME=暮光坚韧
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BRM_004t:MinionBase{
//NAME=雏龙
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class BRM_005:SpellBase{
//NAME=恶魔之怒
//TEXT=对所有非恶魔随从造成$2点 伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class BRM_006:MinionBase{
//NAME=小鬼首领
//TEXT=每当本随从受到伤害，召唤一个1/1的 小鬼。
//MAJ=WARLOCK|COST=3|ATK=2|HP=4|RACE=DEMON
    public override void AfterTakeDamage(Card source,int amount)
    {
        if(amount>0)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("BG_BRM_006t"),ZoneType.Board);
        }
    }
}
public class BRM_006t:MinionBase{
//NAME=小鬼
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class BRM_006_G:MinionBase{
//NAME=小鬼首领
//TEXT=每当本随从受到伤害，召唤一个1/1的 小鬼。
//MAJ=WARLOCK|COST=3|ATK=2|HP=4|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
    public override void AfterTakeDamage(Card source,int amount)
    {
        if(amount>0)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("BG_BRM_006t_G"),ZoneType.Board);
        }
    }
}
public class BRM_006t_G:MinionBase{
//NAME=小鬼
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BRM_007:SpellBase{
//NAME=夜幕奇袭
//TEXT=选择一个随从。将该随从的三张复制洗入你的牌库。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BRM_008:MinionBase{
//NAME=黑铁潜藏者
//TEXT=<b>战吼：</b> 对所有未受伤的敌方随从造成2点伤害。
//MAJ=ROGUE|COST=4|ATK=4|HP=3|RACE=NONE
}
public class BRM_009:MinionBase{
//NAME=火山邪木
//TEXT=<b>嘲讽</b> 在本回合中每有一个随从死亡，本牌的法力值消耗便减少（1）点。
//MAJ=DRUID|COST=9|ATK=7|HP=8|RACE=NONE
}
public class BRM_010:MinionBase{
//NAME=烈焰德鲁伊
//TEXT=<b>抉择：</b>变形成为5/2的随从；或者变形成为2/5的随从。
//MAJ=DRUID|COST=3|ATK=2|HP=2|RACE=NONE
}
public class BRM_010a:MinionBase{
//NAME=火焰猎豹形态
//TEXT=
//MAJ=DRUID|COST=3|ATK=5|HP=2|RACE=BEAST
}
public class BRM_010b:MinionBase{
//NAME=火鹰形态
//TEXT=
//MAJ=DRUID|COST=3|ATK=2|HP=5|RACE=BEAST
}
public class BRM_010t:MinionBase{
//NAME=烈焰德鲁伊
//TEXT=
//MAJ=DRUID|COST=3|ATK=5|HP=2|RACE=BEAST
}
public class BRM_010t2:MinionBase{
//NAME=烈焰德鲁伊
//TEXT=
//MAJ=DRUID|COST=3|ATK=2|HP=5|RACE=BEAST
}
public class BRM_011:SpellBase{
//NAME=熔岩震击
//TEXT=造成$2点伤害。 将你所有<b>过载</b>的法力水晶解锁。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class BRM_011t:Ability{
//NAME=熔岩震击
//TEXT=所有在本回合中使用的牌不会造成<b>过载</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BRM_012:MinionBase{
//NAME=火焰驱逐者
//TEXT=<b>战吼：</b>获得1-4点攻击力。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=4|ATK=3|HP=6|RACE=ELEMENTAL
}
public class BRM_012e:Ability{
//NAME=着火了！
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BRM_013:SpellBase{
//NAME=快速射击
//TEXT=造成$3点伤害。 如果你没有其他手牌，则抽一张牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BRM_014:MinionBase{
//NAME=熔火怒犬
//TEXT=<b>战吼：</b>如果你没有其他手牌，则获得+3/+3。
//MAJ=HUNTER|COST=4|ATK=4|HP=4|RACE=BEAST
}
public class BRM_014e:Ability{
//NAME=狂暴怒意
//TEXT=+3/+3
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BRM_015:SpellBase{
//NAME=复仇打击
//TEXT=对所有随从造成$1点伤害。如果你的生命值小于或等于12点，则改为造成$3点伤害。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BRM_016:MinionBase{
//NAME=掷斧者
//TEXT=每当本随从受到伤害，对敌方英雄造成 2点伤害。
//MAJ=WARRIOR|COST=4|ATK=2|HP=6|RACE=NONE
}
public class BRM_017:SpellBase{
//NAME=复活术
//TEXT=随机召唤一个在本局对战中死亡的友方随从。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class BRM_018:MinionBase{
//NAME=龙王配偶
//TEXT=<b>战吼：</b>你的下一张龙牌的法力值消耗减少（2）点。
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=DRAGON
}
public class BRM_018e:Ability{
//NAME=无可束缚
//TEXT=你的下一张龙牌的法力值消耗减少（2）点。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BRM_019:MinionBase{
//NAME=恐怖的奴隶主
//TEXT=在本随从受到伤害并存活下来后，召唤另一个恐怖的奴隶主。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class BRM_020:MinionBase{
//NAME=龙人巫师
//TEXT=每当<b>你</b>以本随从为目标施放一个法术时，获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=DRAGON
}
public class BRM_020e:Ability{
//NAME=龙人之力
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BRM_022:MinionBase{
//NAME=龙蛋
//TEXT=每当本随从受到 伤害，召唤一条2/1的雏龙。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=2|RACE=NONE
}
public class BRM_022t:MinionBase{
//NAME=黑色雏龙
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=DRAGON
}
public class BRM_024:MinionBase{
//NAME=龙人打击者
//TEXT=<b>战吼：</b>如果你对手的生命值小于或等于15点，便获得+3/+3。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=DRAGON
}
public class BRM_024e:Ability{
//NAME=巨型龙爪
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BRM_025:MinionBase{
//NAME=火山幼龙
//TEXT=在本回合中每有一个随从死亡，本牌的 法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=4|RACE=DRAGON
}
public class BRM_026:MinionBase{
//NAME=饥饿的巨龙
//TEXT=<b>战吼：</b>为你的对手随机召唤一个法力值消耗为（1）的随从。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=6|RACE=DRAGON
}
public class BRM_027:MinionBase{
//NAME=管理者埃克索图斯
//TEXT=<b>亡语：</b> 用炎魔之王拉格纳罗斯替换你的英雄。
//MAJ=NEUTRAL|COST=9|ATK=9|HP=7|RACE=NONE
}
public class BRM_027h:HeroBase{
//NAME=炎魔之王拉格纳罗斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=8|RACE=NONE
}
public class BRM_027p:HeroPowerBase{
//NAME=死吧，虫子！
//TEXT=随机对一个敌人造成$8点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BRM_027pH:HeroPowerBase{
//NAME=死吧，虫子！
//TEXT=随机对一个敌人造成$8点伤害。施放两次。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BRM_028:MinionBase{
//NAME=索瑞森大帝
//TEXT=在你的回合结束时，你所有手牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		TaskBuffTargets(owner.myPlayer.hand,mana:-1);
	}
}
public class BRM_028e:Ability{
//NAME=索瑞森大帝的眷顾
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BRM_029:MinionBase{
//NAME=雷德·黑手
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，则消灭一个<b>传说</b>随从。
//MAJ=NEUTRAL|COST=7|ATK=8|HP=4|RACE=NONE
}
public class BRM_030:MinionBase{
//NAME=奈法利安
//TEXT=<b>战吼：</b>随机将两张<i>（你对手职业的）</i>法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=9|ATK=8|HP=8|RACE=DRAGON
}
public class BRM_030t:SpellBase{
//NAME=扫尾
//TEXT=造成$4点伤害。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=0|RACE=NONE
}
public class BRM_031:MinionBase{
//NAME=克洛玛古斯
//TEXT=每当你抽一张牌时，将该牌的另一张复制置入你的手牌。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=8|RACE=DRAGON
}
public class BRM_033:MinionBase{
//NAME=黑翼技师
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class BRM_033e:Ability{
//NAME=龙血
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BRM_034:MinionBase{
//NAME=黑翼腐蚀者
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，则造成5点伤害。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		if(CondHoldAnotherRace(RaceType.Dragon))
		{
			new EffectDamage(owner.myPlayer,owner,target,5).Resolve();
		}
	}
}
