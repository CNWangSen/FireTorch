using System.Collections;
using System.Collections.Generic;

public class NX2_001:SpellBase{
//NAME=撕裂现实
//TEXT=随机将2张来自过去的法师法术牌置入你的手牌，其法力值消耗减少（2）点。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class NX2_001e:Ability{
//NAME=撕裂
//TEXT=法力值消耗减少（2）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_002:MinionBase{
//NAME=鬼灵学徒
//TEXT=在你施放一个法术后，对所有敌方随从造成1点伤害。
//MAJ=MAGE|COST=3|ATK=1|HP=4|RACE=UNDEAD
}
public class NX2_003:MinionBase{
//NAME=织漩者
//TEXT=<b>战吼：</b>如果你在上回合施放过法术，<b>发现</b>一张元素牌。
//MAJ=MAGE|COST=3|ATK=4|HP=3|RACE=ELEMENTAL
}
public class NX2_003t:MinionBase{
//NAME=殒命神尊
//TEXT=<b>已注能</b> <b>战吼：</b><b>发现</b>一张火焰，冰霜或奥术法术牌。
//MAJ=MAGE|COST=2|ATK=3|HP=2|RACE=UNDEAD
}
public class NX2_004:SpellBase{
//NAME=洗劫
//TEXT=对一个随从造成$1点伤害。在本回合中，如果你使用过另一职业的卡牌，改为造成$4点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_005:MinionBase{
//NAME=缝合造物
//TEXT=<b>连击：</b>获得+2/+2。<b>注能（{0}）：</b>获得+3/+3。<b>法力渴求（{1}）：</b>获得+4/+4。
//MAJ=ROGUE|COST=3|ATK=1|HP=1|RACE=UNDEAD
}
public class NX2_005e:Ability{
//NAME=缝合威力
//TEXT=+2/+2。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_005e2:Ability{
//NAME=缝合之力
//TEXT=+4/+4。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_005t:MinionBase{
//NAME=缝合造物
//TEXT=<b>已注能</b> <b>连击：</b>获得+2/+2。<b>法力渴求（8）：</b>获得+4/+4。
//MAJ=ROGUE|COST=3|ATK=4|HP=4|RACE=UNDEAD
}
public class NX2_006:MinionBase{
//NAME=旗标骷髅
//TEXT=在你的英雄攻击后，召唤一个1/1的亡灵海盗。
//MAJ=ROGUE|COST=1|ATK=1|HP=3|RACE=PIRATE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,CauseEvent));
    }

    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc.GetTag(GameTag.ZoneType) == (int)ZoneType.Hero && CondInPlay())
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("NX2_006t"),ZoneType.Board);
        }
    }
}
public class NX2_006t:MinionBase{
//NAME=僵尸海盗
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=PIRATE
}
public class NX2_007:MinionBase{
//NAME=霜鳍咀嚼者
//TEXT=<b>战吼：</b> 如果你在上个回合使用过元素牌，则召唤三个1/1的鱼人。
//MAJ=SHAMAN|COST=3|ATK=2|HP=3|RACE=ELEMENTAL
}
public class NX2_007t:MinionBase{
//NAME=冷鳃鱼人
//TEXT=
//MAJ=SHAMAN|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class NX2_008:SpellBase{
//NAME=炽焰变幻
//TEXT=选择一个随从，将其变形成为你<b>发现</b>的法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=FIRE
}
public class NX2_009:SpellBase{
//NAME=冰冷贮藏
//TEXT=<b>冻结</b>一个随从，将一张它的复制置入你的手牌。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=FROST
}
public class NX2_010:MinionBase{
//NAME=死亡甲虫
//TEXT=<b>嘲讽</b>。<b>法力渴求（11）：</b>获得+4/+4和<b>冲锋</b>。
//MAJ=DRUID|COST=6|ATK=6|HP=6|RACE=UNDEAD
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=11)
        {
            new EffectChange(owner.myPlayer,owner,owner,atkChange:4,hpChange:4).Resolve();
            new EffectGiveAbility(owner.myPlayer,owner,owner,"Charge").Resolve();
        }
    }
}
public class NX2_010e:Ability{
//NAME=致命死亡
//TEXT=+4/+4。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_011:SpellBase{
//NAME=死中新生
//TEXT=抽三张牌。<b>注能（6）：</b>法力值消耗为（1）点。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class NX2_011t:SpellBase{
//NAME=死中新生
//TEXT=<b>已注能</b> 抽三张牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class NX2_012:SpellBase{
//NAME=斜掠
//TEXT=在本回合中，使你的英雄获得+2攻击力。对一个随从造成等同于你的英雄攻击力的伤害。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class NX2_012e:Ability{
//NAME=斜掠
//TEXT=在本回合中，+2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_013:SecretBase{
//NAME=僵尸蜂群
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，召唤四只1/1的尸蜂攻击它。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class NX2_013t:MinionBase{
//NAME=尸蜂
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class NX2_013t2:SecretBase{
//NAME=强化僵尸蜂群
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，召唤四只2/2的尸蜂攻击它。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class NX2_013t3:MinionBase{
//NAME=尸蜂
//TEXT=
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class NX2_014:MinionBase{
//NAME=坠饰追踪者
//TEXT=<b>战吼：</b>抽一张法力值消耗为（1）的法术牌。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class NX2_014e:Ability{
//NAME=被污染
//TEXT=<b>剧毒</b>
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_015:SpellBase{
//NAME=可靠伙伴
//TEXT=从你的牌库中<b>发现</b>一张野兽牌并召唤。<b>法力渴求（10）：</b>还会召唤一个它的复制。
//MAJ=HUNTER|COST=7|ATK=0|HP=0|RACE=NONE
}
public class NX2_016:SpellBase{
//NAME=鳍形鬼状
//TEXT=使所有友方恶魔和鱼人获得“<b>亡语：</b>召唤一个2/2的小鬼鱼人。”
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class NX2_016e:Ability{
//NAME=鳍形鬼状
//TEXT=<b>亡语：</b>召唤一个2/2的小鬼鱼人。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_016t:MinionBase{
//NAME=小鬼鱼人
//TEXT=
//MAJ=WARLOCK|COST=2|ATK=2|HP=2|RACE=MURLOC
}
public class NX2_017:SpellBase{
//NAME=瘟疫爆发
//TEXT=对所有随从造成$2点伤害。如果你在本局对战中弃过牌，再造成$1点。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class NX2_018:MinionBase{
//NAME=腐烂通灵师
//TEXT=<b>战吼：</b><b>探底</b>。如果选中的是亡灵牌，对敌方英雄造成5点伤害。
//MAJ=PRIEST|COST=4|ATK=5|HP=4|RACE=UNDEAD
}
public class NX2_019:SpellBase{
//NAME=精神灼烧
//TEXT=对一个随从造成$2点伤害。如果该随从死亡，则对敌方英雄造成$3点伤害。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
		if(target.GetTag(GameTag.Health)<=0)
		{
			TaskDamageEnemyHero(3);
		}
	}
}
public class NX2_020:SpellBase{
//NAME=野蛮残食
//TEXT=消灭一个随从。为所有友方角色恢复生命值，数值相当于该随从的生命值。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class NX2_021:MinionBase{
//NAME=亡者骑士
//TEXT=<b>战吼：</b>对你的英雄造成5点伤害。<b>法力渴求（7）：</b>改为为你的英雄恢复5点生命值。
//MAJ=PALADIN|COST=3|ATK=5|HP=5|RACE=UNDEAD
}
public class NX2_022:MinionBase{
//NAME=金翼巨龙
//TEXT=<b>突袭</b>。<b>战吼：</b>如果你的手牌中有机械牌，便获得<b>风怒</b>。
//MAJ=PALADIN|COST=4|ATK=3|HP=5|RACE=DRAGON
}
public class NX2_023:MinionBase{
//NAME=纯净馆长
//TEXT=<b>嘲讽</b>。<b>战吼：</b>如果你的牌库中没有中立卡牌，抽取每个随从类型的随从牌各一张。
//MAJ=PALADIN|COST=5|ATK=4|HP=6|RACE=MECHANICAL
}
public class NX2_024:MinionBase{
//NAME=蹒跚的肉用僵尸
//TEXT=<b>突袭</b>。<b>亡语：</b>对你的英雄造成4点伤害。
//MAJ=DEMONHUNTER|COST=1|ATK=2|HP=3|RACE=UNDEAD
}
public class NX2_025:WeaponBase{
//NAME=灾难之握
//TEXT=<b>亡语：</b>随机将一张<b>流放</b>牌置入你的 手牌。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=2|RACE=NONE
}
public class NX2_026:MinionBase{
//NAME=邪鳞唤醒师
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过三个法术，从你的牌库中召唤一个不同的恶魔。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=DEMONHUNTER|COST=6|ATK=5|HP=7|RACE=DEMON
    public override void Battlecry(Card target=null)
    {
        if(this.CntCasted>=3)
        {
            List<Card> ToListSummon = new List<Card>();
            foreach(Card c in owner.myPlayer.deck)
            {
                if(c.raceType.Contains(RaceType.Demon) && c.cardDbf!=owner.cardDbf)
                {
                    ToListSummon.Add(c);
                }
            }
            Card ToSummon = ToListSummon.Choice(owner.myPlayer.randomGen);
            if(ToSummon!=null)
            {
                new EffectMove(owner.myPlayer,ToSummon,ZoneType.Deck,ZoneType.Board).Resolve();
            }
            this.CntCasted=0;
        }
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
        {
            if(sc.cardType==CardType.Spell)
            {
                this.CntCasted+=1;
            }
        }
    }
    private int CntCasted=0;
}
public class NX2_027:MinionBase{
//NAME=血肉塑造者
//TEXT=<b>嘲讽</b>。<b>战吼：</b>如果你的护甲值大于或等于5点，召唤一个本随从的复制。
//MAJ=WARRIOR|COST=6|ATK=3|HP=8|RACE=UNDEAD
}
public class NX2_027e:Ability{
//NAME=完全修复
//TEXT=耐久度已恢复。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_027e2:Ability{
//NAME=血肉强健
//TEXT=+2攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_028:MinionBase{
//NAME=钩拳-3000型
//TEXT=在你的英雄攻击后，获得4点护甲值并抽一张牌。
//MAJ=WARRIOR|COST=3|ATK=4|HP=3|RACE=PIRATE
}
public class NX2_029:SpellBase{
//NAME=训练课程
//TEXT=<b>发现</b>一张<b>嘲讽</b>随从牌。如果你在本回合使用发现的牌，重复此效果。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class NX2_029e:Ability{
//NAME=训练课程
//TEXT=如果你在本回合使用，<b>发现</b>另一张<b>嘲讽</b>随从牌。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_029e1:Ability{
//NAME=训练所得
//TEXT=如果你在本回合使用，<b>发现</b>另一张<b>嘲讽</b>随从牌。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_030:MinionBase{
//NAME=腐肉杀手蟹
//TEXT=<b>战吼：</b>消灭一个亡灵，获得<b>复生</b>。
//MAJ=NEUTRAL|COST=0|ATK=3|HP=2|RACE=ALL
}
public class NX2_032:MinionBase{
//NAME=沉沦的大主教
//TEXT=<b>亡语：</b>消耗你所有的法力值，召唤相同数量的2/2的并具有<b>突袭</b>的僵尸。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=UNDEAD
}
public class NX2_032t:MinionBase{
//NAME=食尸鬼
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class NX2_033:MinionBase{
//NAME=巨怪塔迪乌斯
//TEXT=<b>嘲讽</b>。你的法力值消耗为奇数的牌的法力值消耗减少（2）点。<i>（每回合切换极性！）</i>
//MAJ=NEUTRAL|COST=10|ATK=11|HP=11|RACE=UNDEAD
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "NX2_033e";
    }
}
public class NX2_033e:Ability{
//NAME=正极引力
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            return -2;
        }
        return 0;
    }
}
public class NX2_033e2:Ability{
//NAME=负极引力
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class NX2_034:MinionBase{
//NAME=战争之骑士瑞文戴尔
//TEXT=<b>亡语：</b>将其他3位骑士洗入你的牌库。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=UNDEAD
}
public class NX2_034t:MinionBase{
//NAME=饥荒之骑士布劳缪克丝
//TEXT=<b>吸血</b>。<b>亡语：</b>在本局对战中，如果你的四位骑士均已死亡，消灭敌方英雄。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=UNDEAD
}
public class NX2_034t1:MinionBase{
//NAME=死亡之骑士库尔塔兹
//TEXT=<b>突袭</b>。<b>亡语：</b>在本局对战中，如果你的四位骑士均已死亡，消灭敌方英雄。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=UNDEAD
}
public class NX2_034t2:MinionBase{
//NAME=征服之骑士瑟里耶克
//TEXT=<b>嘲讽</b>。<b>亡语：</b>在本局对战中，如果你的四位骑士均已死亡，消灭敌方英雄。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=UNDEAD
}
public class NX2_035:MinionBase{
//NAME=霜鳞海妖
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过三个法术，随机<b>冻结</b>3个敌方随从。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=DEATHKNIGHT|COST=3|ATK=2|HP=3|RACE=UNDEAD
}
public class NX2_036:LocationBase{
//NAME=构造区
//TEXT=消灭一个友方随从，召唤一个4/5并具有<b>突袭</b>的亡灵。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=3|RACE=NONE
}
public class NX2_036t:MinionBase{
//NAME=蹒跚的恐魔
//TEXT=<b>突袭</b>
//MAJ=DEATHKNIGHT|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class NX2_037:MinionBase{
//NAME=冰霜女王辛达苟萨
//TEXT=<b>巨型+2</b> 在一个敌方随从被<b>冻结</b>后，将其消灭。
//MAJ=DEATHKNIGHT|COST=7|ATK=6|HP=6|RACE=DRAGON
}
public class NX2_037t:MinionBase{
//NAME=辛达苟萨之翼
//TEXT=<b>突袭</b>。<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=DEATHKNIGHT|COST=1|ATK=2|HP=1|RACE=DRAGON
}
public class NX2_037t2:MinionBase{
//NAME=辛达苟萨之翼
//TEXT=<b>突袭</b>。<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=DEATHKNIGHT|COST=1|ATK=2|HP=1|RACE=DRAGON
}
public class NX2_044:MinionBase{
//NAME=可疑的摊贩
//TEXT=<b>战吼：</b><b>发现</b>一张法力值消耗为（1）的卡牌。你的对手如果猜中了你的选择，即可获取一张复制。
//MAJ=WARLOCK|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class NX2_050:MinionBase{
//NAME=错误产物
//TEXT=<i>本随从拥有全部随从类型。</i>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=ALL
}
public class NX2_051:MinionBase{
//NAME=黑暗堕落者影兵
//TEXT=<b>突袭</b>。<b>法力渴求（6）：</b>获得<b>复生</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
