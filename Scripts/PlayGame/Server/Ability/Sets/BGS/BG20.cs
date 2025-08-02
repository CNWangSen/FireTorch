using System.Collections;
using System.Collections.Generic;

public class BG20_100:MinionBase{
//NAME=剃刀沼泽地卜师
//TEXT=<b>战吼：</b>获取一张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=1|RACE=QUILBOAR
}
public class BG20_100_G:MinionBase{
//NAME=剃刀沼泽地卜师
//TEXT=<b>战吼：</b>获取2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=1|ATK=6|HP=2|RACE=QUILBOAR
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG20_101:MinionBase{
//NAME=路霸野猪人
//TEXT=<b>暴怒：</b>获取一张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=QUILBOAR
}
public class BG20_101_G:MinionBase{
//NAME=路霸野猪人
//TEXT=<b>暴怒：</b>获取2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=8|RACE=QUILBOAR
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG20_102:MinionBase{
//NAME=坚牙野猪人
//TEXT=在<b>鲜血宝石</b>被用于本随从后，直到下个回合，获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=3|RACE=QUILBOAR
}
public class BG20_102_G:MinionBase{
//NAME=坚牙野猪人
//TEXT=在<b>鲜血宝石</b>被用于本随从后，获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=3|ATK=10|HP=6|RACE=QUILBOAR
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG20_102_Ge:Ability{
//NAME=那是真的硬
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_102e:Ability{
//NAME=坚硬獠牙
//TEXT=直到下个回合，获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_103:MinionBase{
//NAME=刺背蛮兵
//TEXT=每个回合中第一张被用于本随从的<b>鲜血宝石</b>使其额外获得+3/+3。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=QUILBOAR
}
public class BG20_103_G:MinionBase{
//NAME=刺背蛮兵
//TEXT=每个回合中第一张被用于本随从的<b>鲜血宝石</b>使其额外获得+6/+6。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=6|RACE=QUILBOAR
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG20_104:MinionBase{
//NAME=狂棍野猪人
//TEXT=<b>风怒</b> 在本随从攻击后，获取一张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=7|RACE=QUILBOAR
	public override void Init()
	{
		TaskInitAbility("WindFury");
	}
}
public class BG20_104_G:MinionBase{
//NAME=狂棍野猪人
//TEXT=<b>风怒</b> 在本随从攻击后，获取2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=14|RACE=QUILBOAR
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("WindFury");
	}
}
public class BG20_105:MinionBase{
//NAME=荆棘召唤者
//TEXT=<b>亡语：</b>获取一张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=QUILBOAR
}
public class BG20_105_G:MinionBase{
//NAME=荆棘召唤者
//TEXT=<b>亡语：</b>获取2张 <b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=2|ATK=6|HP=4|RACE=QUILBOAR
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG20_106:MinionBase{
//NAME=震地者
//TEXT=在<b>鲜血宝石</b>被用于本随从后，直到下个回合，使你的其他随从获得+2攻击力。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=8|RACE=QUILBOAR
}
public class BG20_106_G:MinionBase{
//NAME=震地者
//TEXT=在<b>鲜血宝石</b>被用于本随从后，直到下个回合，使你的其他随从获得+4攻击力。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=16|RACE=QUILBOAR
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG20_106e:Ability{
//NAME=大地震颤
//TEXT=直到下个回合，+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_201:MinionBase{
//NAME=扛旗野猪人
//TEXT=在你的回合结束时，对相邻的随从使用一张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=5|RACE=QUILBOAR
}
public class BG20_201_G:MinionBase{
//NAME=扛旗野猪人
//TEXT=在你的回合结束时，对相邻的随从使用2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=10|RACE=QUILBOAR
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG20_202:MinionBase{
//NAME=亡灵侍僧
//TEXT=<b>战吼：</b>对一个友方随从使用两张<b>鲜血宝石</b>并使其偷取相邻随从的所有<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=QUILBOAR
}
public class BG20_202_G:MinionBase{
//NAME=亡灵侍僧
//TEXT=<b>战吼：</b>对一个友方随从使用四张<b>鲜血宝石</b>并使其偷取相邻随从的所有<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=6|RACE=QUILBOAR
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG20_203:MinionBase{
//NAME=野猪预言者
//TEXT=<b>嘲讽</b>。在你使用一张野猪人后，获取一张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class BG20_203_G:MinionBase{
//NAME=野猪预言者
//TEXT=<b>嘲讽</b>。在你使用一张野猪人后，获取2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=6|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}
}
public class BG20_204:MinionBase{
//NAME=刺背骑士
//TEXT=<b>风怒</b>，<b>圣盾</b>。在本随从第一次受到伤害并存活下来后，获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=9|RACE=QUILBOAR
    public override void Init()
    {
        TaskInitAbility("WindFury");
        TaskInitAbility("DivineShield");
    }
    private int cnt=0;
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
    	if(amount>0 && cnt<1)
    	{
    		if(!owner.HasAbility("DivineShield"))
    		{
    			cnt+=1;
    			new EffectGiveAbility(owner.myPlayer,owner,owner,"DivineShield").Resolve();
    		}
    	}
    }
}
public class BG20_204_G:MinionBase{
//NAME=刺背骑士
//TEXT=<b>风怒</b>，<b>圣盾</b>。在本随从前两次受到伤害并存活下来后，获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=5|ATK=12|HP=18|RACE=QUILBOAR
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("WindFury");
        TaskInitAbility("DivineShield");
    }
    private int cnt=0;
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
    	if(amount>0 && cnt<2)
    	{
    		if(!owner.HasAbility("DivineShield"))
    		{
    			cnt+=1;
    			new EffectGiveAbility(owner.myPlayer,owner,owner,"DivineShield").Resolve();
    		}
    	}
    }
}
public class BG20_205:MinionBase{
//NAME=阿迦玛甘，野猪之神
//TEXT=你的<b>鲜血宝石</b>使随从额外获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=BEAST
}
public class BG20_205_G:MinionBase{
//NAME=阿迦玛甘，野猪之神
//TEXT=你的<b>鲜血宝石</b>使随从额外获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=12|HP=12|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_206:MinionBase{
//NAME=獠牙队长
//TEXT=在你花掉3枚铸币后，获取一张<b>鲜血宝石</b>。<i>（还剩3枚！）</i>
//MAJ=NEUTRAL|COST=6|ATK=9|HP=5|RACE=QUILBOAR
}
public class BG20_206_G:MinionBase{
//NAME=獠牙队长
//TEXT=在你花掉3枚铸币后，获取2张<b>鲜血宝石</b>。<i>（还剩3枚！）</i>
//MAJ=NEUTRAL|COST=6|ATK=18|HP=10|RACE=QUILBOAR
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_207:MinionBase{
//NAME=劲爆二人组
//TEXT=<b>嘲讽</b> 在<b>鲜血宝石</b>被用于另一个友方野猪人后，获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=6|RACE=QUILBOAR
}
public class BG20_207_G:MinionBase{
//NAME=劲爆二人组
//TEXT=<b>嘲讽</b> 在<b>鲜血宝石</b>被用于另一个友方野猪人后，获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=12|RACE=QUILBOAR
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_207_Ge:Ability{
//NAME=野猪最爱
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_207e:Ability{
//NAME=野猪最爱
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_210:MinionBase{
//NAME=妖术毁灭抢掠者
//TEXT=在你的回合结束时，如果你拥有六个或更少随从，获得+3/+3。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=DEMON
}
public class BG20_210_G:MinionBase{
//NAME=妖术毁灭抢掠者
//TEXT=在你的回合结束时，如果你拥有六个或更少随从，获得+6/+6。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=10|RACE=DEMON
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_210_Ge:Ability{
//NAME=妖术毁灭之怒
//TEXT=+6/+6。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_210e:Ability{
//NAME=妖术毁灭之力
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_301:MinionBase{
//NAME=晾膘的游客
//TEXT=当你出售本随从时，获取2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=2|RACE=QUILBOAR
}
public class BG20_301_G:MinionBase{
//NAME=晾膘的游客
//TEXT=当你出售本随从时，获取4张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=QUILBOAR
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_302:MinionBase{
//NAME=阿格姆·棘咒
//TEXT=在<b>鲜血宝石</b>被用于本随从后，使每个类型的各一个友方随从获得+2/+1。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=5|RACE=QUILBOAR
}
public class BG20_302_G:MinionBase{
//NAME=阿格姆·棘咒
//TEXT=在<b>鲜血宝石</b>被用于本随从后，使每个类型的各一个友方随从获得+4/+2。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=10|RACE=QUILBOAR
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_302_Ge:Ability{
//NAME=荆棘诅咒
//TEXT=+4/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_302e:Ability{
//NAME=荆棘诅咒
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_303:MinionBase{
//NAME=卡尔加
//TEXT=在你的回合结束时，对你的其他随从各使用一张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=QUILBOAR
}
public class BG20_303_G:MinionBase{
//NAME=卡尔加
//TEXT=在你的回合结束时，对你的其他随从各使用2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=8|RACE=QUILBOAR
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_304:MinionBase{
//NAME=大德鲁伊哈缪尔
//TEXT=<b>战吼：</b><b>刷新</b>酒馆，使其中的随从变为你的多数随从的类型的随从。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
}
public class BG20_304_G:MinionBase{
//NAME=大德鲁伊哈缪尔
//TEXT=<b>战吼：</b><b>刷新</b>酒馆，使其中的随从变为你的多数随从的类型的随从。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=8|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}

public class BG20_401:MinionBase{
//NAME=机鱼圣者
//TEXT=在另一个友方随从失去<b>圣盾</b>后，获得 <b>圣盾</b>。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=4|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("DivineShield");
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterRemoveAbility(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc, string abiname)
	{
		if(CondInPlay() && sc!=owner)
		{
			if(abiname=="DivineShield")
			{
				if(!owner.HasAbility("DivineShield"))
					new EffectGiveAbility(owner.myPlayer,owner,owner,"DivineShield").Resolve();
			}
		}
	}
}
public class BG20_401_G:MinionBase{
//NAME=机鱼圣者
//TEXT=在另一个友方随从失去<b>圣盾</b>后，获得 <b>圣盾</b>。
//MAJ=NEUTRAL|COST=4|ATK=12|HP=8|RACE=MECHANICAL
	public override void Init()
	{
		owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
		TaskInitAbility("DivineShield");
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterRemoveAbility(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc, string abiname)
	{
		if(CondInPlay() && sc!=owner)
		{
			if(abiname=="DivineShield")
			{
				if(!owner.HasAbility("DivineShield"))
					new EffectGiveAbility(owner.myPlayer,owner,owner,"DivineShield").Resolve();
			}
		}
	}
}
public class BG20_GEM:SpellBase{
//NAME=鲜血宝石
//TEXT=使一个随从获得+{0}/+{1}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_GEM_No_Impact:SpellBase{
//NAME=无影响鲜血宝石
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_GEMe:Ability{
//NAME=Blood Gem
//TEXT=Increased stats from Blood Gem (but invisible banner)
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_GEMe2:Ability{
//NAME=鲜血宝石
//TEXT=+{0}/+{1}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_GEMt:SpellBase{
//NAME=大型鲜血宝石
//TEXT=使所有友方随从获得+{0}/+{1}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_100:HeroBase{
//NAME=洛卡拉
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_100_Buddy:MinionBase{
//NAME=冰嚎，强力猛狼
//TEXT=在一个友方随从消灭敌人后，永久获得+1生命值。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=2|RACE=BEAST
}
public class BG20_HERO_100_Buddy_e:Ability{
//NAME=嚎叫
//TEXT=+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_100_Buddy_G:MinionBase{
//NAME=冰嚎，强力猛狼
//TEXT=在一个友方随从消灭敌人后，永久获得+2生命值。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=4|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_HERO_100_Buddy_Ge:Ability{
//NAME=嚎叫
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_100_SKIN_A4:HeroBase{
//NAME=奥术战士洛卡拉
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_100_SKIN_B:HeroBase{
//NAME=摩卡拉
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_100_SKIN_C:HeroBase{
//NAME=偷家的洛卡拉
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_100_SKIN_D:HeroBase{
//NAME=摇滚乐手洛卡拉
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_100_SKIN_E:HeroBase{
//NAME=护火者洛卡拉
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_100_SKIN_F:HeroBase{
//NAME=竞技场冠军洛卡拉
//TEXT=
//MAJ=PALADIN|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_100p:HeroPowerBase{
//NAME=战斗的荣耀
//TEXT=<b>被动</b> 在友方随从消灭敌人后，使其永久获得+1攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_100p_e2:Ability{
//NAME=荣耀
//TEXT=+1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_101:HeroBase{
//NAME=泽瑞拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_101_Buddy:MinionBase{
//NAME=幼年雷象
//TEXT=在你使用一张攻击力等同于生命值的随从牌后，获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=BEAST
}
public class BG20_HERO_101_Buddy_e:Ability{
//NAME=流浪之光
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_101_Buddy_G:MinionBase{
//NAME=幼年雷象
//TEXT=在你使用一张攻击力等同于生命值的随从牌后，获得+4/+4。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_HERO_101_Buddy_Ge:Ability{
//NAME=流浪之光
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_101_SKIN_A:HeroBase{
//NAME=至高天域泽瑞拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_101_SKIN_B:HeroBase{
//NAME=雷象驭手泽瑞拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_101_SKIN_C:HeroBase{
//NAME=优雅来宾泽瑞拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_101_SKIN_D2:HeroBase{
//NAME=节日守护者泽瑞拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_101_SKIN_E4:HeroBase{
//NAME=米达的勇士泽瑞拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_101_SKIN_F:HeroBase{
//NAME=圣光守卫泽瑞拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_101_SKIN_G:HeroBase{
//NAME=长发姑娘泽瑞拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_101_SKIN_H:HeroBase{
//NAME=堕落者泽瑞拉
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_101p:HeroPowerBase{
//NAME=亲见圣光
//TEXT=选择酒馆中的一个随从，将其属性值变为2并置入你的手牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_101pe2:Ability{
//NAME=和平之誓
//TEXT=攻击力和生命值变为2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_102:HeroBase{
//NAME=萨鲁法尔大王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_102_Buddy:MinionBase{
//NAME=德拉诺什·萨鲁法尔
//TEXT=在你购买一个随从后，获得其属性值。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=6|RACE=NONE
}
public class BG20_HERO_102_Buddy_G:MinionBase{
//NAME=德拉诺什·萨鲁法尔
//TEXT=在你购买一个随从后，获得其双倍 属性值。
//MAJ=NEUTRAL|COST=4|ATK=12|HP=12|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_HERO_102_Buddye:Ability{
//NAME=部落的活力
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_102_SKIN_A:HeroBase{
//NAME=海上司令萨鲁法尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_102_SKIN_B:HeroBase{
//NAME=冲锋统帅萨鲁法尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_102_SKIN_C:HeroBase{
//NAME=关羽萨鲁法尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_102_SKIN_D:HeroBase{
//NAME=巨龙装甲萨鲁法尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_102_SKIN_E4:HeroBase{
//NAME=暗影之盔萨鲁法尔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_102e:Ability{
//NAME=为了部落！
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_102p:HeroPowerBase{
//NAME=为了部落！
//TEXT=使一个酒馆中的随从获得+{1}/+{2}。<i>（每{0}回合翻倍！）</i>3使一个酒馆中的随从获得+{1}/+{2}。<i>（{0}回合后翻倍！）</i>
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_102pe:Ability{
//NAME=萨鲁法尔玩家附加效果
//TEXT=使你购买的下一个随从获得额外攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_102pe2:Ability{
//NAME=为了部落！
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_102pe3:Ability{
//NAME=为了部落！
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_102pe_Buddy:Ability{
//NAME=萨鲁法尔玩家附加效果（伙伴）
//TEXT=在本回合中，使你购买的下一个随从获得额外生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_103:HeroBase{
//NAME=亡语者布莱克松
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_103_Buddy:MinionBase{
//NAME=亡首圣贤
//TEXT=在你获取一张 <b>鲜血宝石</b>后， 额外获取一张。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=7|RACE=QUILBOAR
}
public class BG20_HERO_103_Buddy_G:MinionBase{
//NAME=亡首圣贤
//TEXT=在你获取一张 <b>鲜血宝石</b>后， 额外获取两张。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=14|RACE=QUILBOAR
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_HERO_103_SKIN_A:HeroBase{
//NAME=潮语者布莱克松
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_103_SKIN_B2:HeroBase{
//NAME=火炬手布莱克松
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_103_SKIN_C4:HeroBase{
//NAME=契语者布莱克松
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_103p:HeroPowerBase{
//NAME=血脉连接
//TEXT=获取2张<b>鲜血宝石</b>。<i>（每回合两次。）</i>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_201:HeroBase{
//NAME=沃金
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_201_Buddy:MinionBase{
//NAME=加德林大师
//TEXT=成为灵魂互换目标的随从还会获得对方的生命值。
//MAJ=NEUTRAL|COST=5|ATK=7|HP=6|RACE=NONE
}
public class BG20_HERO_201_Buddy_e:Ability{
//NAME=祝福之手
//TEXT=复制加德林的攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_201_Buddy_G:MinionBase{
//NAME=加德林大师
//TEXT=成为灵魂互换目标的随从还会获得对方的双倍生命值。
//MAJ=NEUTRAL|COST=5|ATK=14|HP=12|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_HERO_201_SKIN_A:HeroBase{
//NAME=惬意的沃金
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_201_SKIN_B:HeroBase{
//NAME=霜狼军官沃金
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_201_SKIN_C:HeroBase{
//NAME=赦罪沃金
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_201_SKIN_D:HeroBase{
//NAME=流行朋克沃金
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_201e:Ability{
//NAME=Modified Attack
//TEXT=Attack is increased or decreased.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_201e2:Ability{
//NAME=Modified Health
//TEXT=Health is increased or decreased.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_201e3:Ability{
//NAME=Stats Set DEPRECATED
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_201p:HeroPowerBase{
//NAME=灵魂互换
//TEXT=选择2个随从。直到下个回合，它们会获得对方的攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_201p2:HeroPowerBase{
//NAME=灵魂互换
//TEXT=选择一个随从，与{0}一起获得攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_201p2e:Ability{
//NAME=互换灵魂
//TEXT=属性值与另一随从互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_201p2e2:Ability{
//NAME=灵魂所得
//TEXT=直到下个回合，获得攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_201p3e:Ability{
//NAME=获得标记
//TEXT=攻击力可获得。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_202:HeroBase{
//NAME=阮大师
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_202_Buddy:MinionBase{
//NAME=雷·火掌
//TEXT=“风暴之力”会提供3个选项，而非2个。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=5|RACE=NONE
}
public class BG20_HERO_202_Buddy_G:MinionBase{
//NAME=雷·火掌
//TEXT=“风暴之力”会提供4个选项，而非2个。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=10|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_HERO_202_SKIN_A:HeroBase{
//NAME=班禄阮大师
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_202_SKIN_B4:HeroBase{
//NAME=神秘导师阮大师
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_202_SKIN_C:HeroBase{
//NAME=太阳之井阮大师
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_202_SKIN_D:HeroBase{
//NAME=MVP阮大师
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_202_SKIN_E:HeroBase{
//NAME=庆典阮大师
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_202p:HeroPowerBase{
//NAME=风暴之力
//TEXT=<b>被动</b> 在每个回合开始时，从两个新英雄技能中选择一个。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_202pe:Ability{
//NAME=切换英雄技能
//TEXT=每个回合，随机变形成为一个英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_202pt:SpellBase{
//NAME=切换你的英雄技能
//TEXT=触发风暴之力效果
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_242:HeroBase{
//NAME=古夫·符文图腾
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_242_Buddy:MinionBase{
//NAME=科多兽宝宝
//TEXT=<b>战吼：刷新</b>酒馆，使其中的随从变为每个等级一个。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=BEAST
}
public class BG20_HERO_242_Buddy_G:MinionBase{
//NAME=科多兽宝宝
//TEXT=<b>战吼：刷新</b>酒馆，使其中的随从变为每个等级一个。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=12|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_HERO_242_SKIN_A:HeroBase{
//NAME=暴风城卫兵古夫
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_242_SKIN_B:HeroBase{
//NAME=绿洲古夫
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_242p:HeroPowerBase{
//NAME=自然的平衡
//TEXT=使每个等级的各一个友方随从获得+2/+1。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_242pe:Ability{
//NAME=古夫的祝福
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_280:HeroBase{
//NAME=库尔特鲁斯·陨烬
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_280_Buddy:MinionBase{
//NAME=活体梦魇
//TEXT=在你购买一张牌后，酒馆中的随从在本回合中拥有+2/+1。
//MAJ=NEUTRAL|COST=2|ATK=6|HP=4|RACE=UNDEAD
}
public class BG20_HERO_280_Buddy_G:MinionBase{
//NAME=活体梦魇
//TEXT=在你购买一张牌后，酒馆中的随从在本回合中拥有+4/+2。
//MAJ=NEUTRAL|COST=2|ATK=12|HP=8|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_HERO_280_Buddye:Ability{
//NAME=活体梦魇玩家强化
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_280_Buddye2:Ability{
//NAME=暗夜一击
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_280_SKIN_A:HeroBase{
//NAME=皮衣侍者库尔特鲁斯
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_280_SKIN_B2:HeroBase{
//NAME=踏火艺人陨烬
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_280_SKIN_C3:HeroBase{
//NAME=尊贵的陨烬
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_280_SKIN_D:HeroBase{
//NAME=摩尔特鲁斯·陨烬
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_280_SKIN_E:HeroBase{
//NAME=枪刃库尔特鲁斯
//TEXT=
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_280e:Ability{
//NAME=库尔特鲁斯监控
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_280p:HeroPowerBase{
//NAME=一决胜负
//TEXT=<b>被动</b> 在一回合内购买3个随从，即可使它们获得+2/+2并强化此被动效果。<i>（还剩3个！）</i>
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_280p2:HeroPowerBase{
//NAME=汲取动力
//TEXT=<b>被动</b> 在一回合内购买4个随从，即可使你手牌和战场上的随从获得+2/+2并强化此被动效果。<i>（还剩4个！）</i>
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_280p2e:Ability{
//NAME=动力增长
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_280p2e2:Ability{
//NAME=Marked for Showdown
//TEXT=Will be buffed by Final Showdown.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_280p3:HeroPowerBase{
//NAME=关闭传送门
//TEXT=<b>被动</b> 在一回合内购买5个随从，即可使你在本局对战中的所有随从获得+2/+2并完成此被动效果。<i>（还剩{0}个！）</i>
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_280p3e2:Ability{
//NAME=传送门关闭
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_280p5:HeroPowerBase{
//NAME=战刃飞旋
//TEXT=<b>被动</b> 每回合一次：在你购买3个随从后，获取所购买的一个随从的一张原始版复制。<i>（还剩{0}个！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_280pe:Ability{
//NAME=决战准备
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_282:HeroBase{
//NAME=塔姆辛·罗姆
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_282_Buddy:MinionBase{
//NAME=怪物
//TEXT=在一个友方随从死亡后，获得其攻击力。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=14|RACE=UNDEAD
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sz==ZoneType.Board && tz==ZoneType.Grave)
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:sc.GetTag(GameTag.Attack));
			}
		}
	}
}
public class BG20_HERO_282_Buddy_G:MinionBase{
//NAME=怪物
//TEXT=在一个友方随从死亡后，获得其攻击力，获得两次。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=28|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sz==ZoneType.Board && tz==ZoneType.Grave)
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:sc.GetTag(GameTag.Attack));
				new EffectChange(owner.myPlayer,owner,owner,atkChange:sc.GetTag(GameTag.Attack));
			}
		}
	}
}
public class BG20_HERO_282_Buddye:Ability{
//NAME=吞噬
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_282_SKIN_A:HeroBase{
//NAME=交际舞者塔姆辛
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_282_SKIN_B:HeroBase{
//NAME=舞者塔姆辛
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_282_SKIN_C4:HeroBase{
//NAME=暗影法师塔姆辛
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_282_SKIN_D:HeroBase{
//NAME=叛变者塔姆辛
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_282p:HeroPowerBase{
//NAME=香氛护命匣
//TEXT=<b>战斗开始时：</b>消灭你生命值最低的随从。使你的其他随从获得其属性值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_282pe:Ability{
//NAME=香氛
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_283:HeroBase{
//NAME=狂风之翼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_283_Buddy:MinionBase{
//NAME=飞行训练师
//TEXT=你的航线效果会触发两次。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class BG20_HERO_283_Buddy_G:MinionBase{
//NAME=飞行训练师
//TEXT=你的航线效果会触发三次。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_HERO_283_SKIN_A:HeroBase{
//NAME=星辰冲击狂风之翼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_283_SKIN_B2:HeroBase{
//NAME=风火之翼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_283_SKIN_C3:HeroBase{
//NAME=墓翼蝠狂风之翼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_283_SKIN_D4:HeroBase{
//NAME=巡天骁骑狂风之翼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_283_SKIN_E:HeroBase{
//NAME=衔灯狂风之翼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_283p:HeroPowerBase{
//NAME=杜加尔的狮鹫
//TEXT=选择一条新航线，完成飞行时获得特效！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_283p_t1:HeroPowerBase{
//NAME=西部荒野
//TEXT=<b>被动</b> 1回合后，使你最左边的随从获得+2/+2。<i>（还剩1回合！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_283p_t1e:Ability{
//NAME=西部荒野
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_283p_t2:HeroPowerBase{
//NAME=铁炉堡
//TEXT=<b>被动</b> 2回合后，获得2枚铸币。<i>（还剩2回合！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_283p_t3:HeroPowerBase{
//NAME=东瘟疫之地
//TEXT=<b>被动</b> 3回合后，<b>发现</b>一个你当前等级的随从。<i>（还剩3回合！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_301:HeroBase{
//NAME=吞噬者穆坦努斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_301_Buddy:MinionBase{
//NAME=噩梦软浆怪
//TEXT=当你“吞噬”本随从时，将它的属性值吐到额外1个随从身上。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=NONE
}
public class BG20_HERO_301_Buddy_G:MinionBase{
//NAME=噩梦软浆怪
//TEXT=当你“吞噬”本随从时，将它的属性值吐到额外2个随从身上。
//MAJ=NEUTRAL|COST=3|ATK=8|HP=6|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
	}
}
public class BG20_HERO_301_SKIN_A:HeroBase{
//NAME=石头鱼
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_301_SKIN_B:HeroBase{
//NAME=大胃王穆坦努斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_301_SKIN_C:HeroBase{
//NAME=派对焦点穆坦努斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_301_SKIN_D2:HeroBase{
//NAME=吞火者穆坦努斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_301_SKIN_E:HeroBase{
//NAME=被吞噬者穆坦努斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_301_SKIN_F:HeroBase{
//NAME=清场者穆坦努斯
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_301p:HeroPowerBase{
//NAME=吞噬
//TEXT=移除一个友方随从，将它的属性值吐到另一个随从身上。获得1枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_301pe:Ability{
//NAME=嗉质唾展
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666:HeroBase{
//NAME=迪亚波罗
//TEXT=
//MAJ=WARRIOR|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG20_HERO_666p:HeroPowerBase{
//NAME=恐惧领域
//TEXT=<b>被动</b> 每4个回合，所有敌人均会与恐惧之王及你的战队战斗，争夺战利品。<i>（还剩{0}回合！）</i>
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p2e:Ability{
//NAME=灵魂石
//TEXT=封存着随从。如果你赢了，就能获得一张复制。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p2e3:Ability{
//NAME=灵魂石
//TEXT=恐惧将至……
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t0:MinionBase{
//NAME=迪亚波罗，恐惧之王
//TEXT=<b>亡语：</b>使你的对手获得2件战利品！<i>（如果该角色幸存，则改为迪亚波罗获得2件战利品。）</i>
//MAJ=WARRIOR|COST=0|ATK=4|HP=4|RACE=DEMON
}
public class BG20_HERO_666p_t1a:SpellBase{
//NAME=地狱符印
//TEXT=<b>战斗开始时：</b>随机对3个敌方随从造成1点伤害。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t1b:SpellBase{
//NAME=魔法地狱符印
//TEXT=<b>战斗开始时：</b>随机对3个敌方随从造成3点伤害。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t1c:SpellBase{
//NAME=稀有地狱符印
//TEXT=<b>战斗开始时：</b>随机对3个敌方随从造成9点伤害。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t1d:SpellBase{
//NAME=暗金地狱符印
//TEXT=<b>战斗开始时：</b>随机对3个敌方随从造成27点伤害。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t3_e:Ability{
//NAME=恐怖
//TEXT=直到下个回合，+{0}/+{1}。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t3a:SpellBase{
//NAME=恐怖利爪
//TEXT=直到下个回合，使一个友方随从获得+2/+2。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t3b:SpellBase{
//NAME=魔法恐怖利爪
//TEXT=直到下个回合，使一个友方随从获得+6/+6。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t3c:SpellBase{
//NAME=稀有恐怖利爪
//TEXT=直到下个回合，使一个友方随从获得+12/+12。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t3d:SpellBase{
//NAME=暗金恐怖利爪
//TEXT=直到下个回合，使一个友方随从的攻击力和生命值翻倍。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t4a:SpellBase{
//NAME=熔岩魔角
//TEXT=直到下个回合，使一个友方随从获得<b>风怒</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t4a_e:Ability{
//NAME=狂傲魔角
//TEXT=直到下个回合，获得<b>风怒</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t4a_e2:Ability{
//NAME=强韧魔角
//TEXT=直到下个回合，获得<b>复生</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t4a_e3:Ability{
//NAME=坚利魔角
//TEXT=直到下个回合，获得<b>圣盾</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t4b:SpellBase{
//NAME=魔法熔岩魔角
//TEXT=直到下个回合，使一个友方随从获得<b>复生</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t4c:SpellBase{
//NAME=稀有熔岩魔角
//TEXT=直到下个回合，使一个友方随从获得<b>圣盾</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t4d:SpellBase{
//NAME=暗金熔岩魔角
//TEXT=直到下个回合，使一个友方随从获得<b>风怒</b>，<b>复生</b>和<b>圣盾</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t5_e:Ability{
//NAME=魔蹄加持
//TEXT=直到下个回合，+0攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t5a:SpellBase{
//NAME=狱火之蹄
//TEXT=直到下个回合，使你的随从获得+1攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t5b:SpellBase{
//NAME=魔法狱火之蹄
//TEXT=直到下个回合，使你的随从获得+3攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t5c:SpellBase{
//NAME=稀有狱火之蹄
//TEXT=直到下个回合，使你的随从获得+9攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t5d:SpellBase{
//NAME=暗金狱火之蹄
//TEXT=直到下个回合，使你的随从获得+27攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t6a:SpellBase{
//NAME=黑暗灵魂石
//TEXT=<b>奥秘：</b>在你的最后一个随从死亡后，随机召唤一个恶魔。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t6b:SpellBase{
//NAME=魔法黑暗灵魂石
//TEXT=<b>奥秘：</b>在你的最后一个随从死亡后，随机召唤2个恶魔。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t6c:SpellBase{
//NAME=稀有黑暗灵魂石
//TEXT=<b>奥秘：</b>在你的最后一个随从死亡后，随机召唤3个恶魔。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG20_HERO_666p_t6d:SpellBase{
//NAME=暗金黑暗灵魂石
//TEXT=<b>奥秘：</b>在你的最后一个随从死亡后，随机召唤4个恶魔。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
