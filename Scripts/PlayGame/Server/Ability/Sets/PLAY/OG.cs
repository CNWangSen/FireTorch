using System.Collections;
using System.Collections.Generic;

public class OG_006:MinionBase{
//NAME=恶鳍审判者
//TEXT=<b>战吼：</b> 你的英雄技能变为“召唤一个1/1的鱼人”。
//MAJ=PALADIN|COST=1|ATK=1|HP=3|RACE=MURLOC
}
public class OG_006a:MinionBase{
//NAME=白银之手鱼人
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class OG_006b:HeroPowerBase{
//NAME=潮汐之力
//TEXT=召唤一个1/1的白银之手鱼人。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class OG_023:SpellBase{
//NAME=原始融合
//TEXT=你每有一个图腾，就使一个随从获得+1/+1。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class OG_023t:Ability{
//NAME=原始灌注
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_024:MinionBase{
//NAME=投火无面者
//TEXT=<b>过载：</b>（2）
//MAJ=SHAMAN|COST=4|ATK=7|HP=7|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,3);
    }
}
public class OG_026:MinionBase{
//NAME=永恒哨卫
//TEXT=<b>战吼：</b>将你所有<b>过载</b>的法力水晶解锁。
//MAJ=SHAMAN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class OG_027:SpellBase{
//NAME=异变
//TEXT=随机将你的 所有随从变形成为法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class OG_028:MinionBase{
//NAME=深渊魔物
//TEXT=<b>嘲讽</b> 在本局对战中，你每召唤一个图腾，本牌的法力值消耗便减少（1）点。
//MAJ=SHAMAN|COST=6|ATK=5|HP=5|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
            {
                int Cnt=0;
                foreach(Card c in owner.myPlayer.grave.Merge(owner.myPlayer.board))
                {
                    if(c.raceType.Contains(RaceType.Totem))
                    {
                        Cnt+=1;
                    }
                }
                return -Cnt;
            }
        }
        return 0;
    }
}
public class OG_031:WeaponBase{
//NAME=暮光神锤
//TEXT=<b>亡语：</b>召唤一个4/2的元素。
//MAJ=SHAMAN|COST=5|ATK=4|HP=2|RACE=NONE
}
public class OG_031a:MinionBase{
//NAME=暮光元素
//TEXT=
//MAJ=SHAMAN|COST=3|ATK=4|HP=2|RACE=ELEMENTAL
}
public class OG_033:WeaponBase{
//NAME=钢铁触须
//TEXT=<b>亡语：</b>将这把武器移回你的手牌。
//MAJ=WARRIOR|COST=5|ATK=2|HP=2|RACE=NONE
}
public class OG_034:MinionBase{
//NAME=异种群居蝎
//TEXT=在本回合中，除非你的英雄进行过攻击，否则无法进行攻击。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=5|RACE=BEAST
}
public class OG_042:MinionBase{
//NAME=亚煞极
//TEXT=在你的回合结束时，将一个随从从你的牌库置入战场。
//MAJ=NEUTRAL|COST=10|ATK=10|HP=10|RACE=NONE
}
public class OG_044:MinionBase{
//NAME=范达尔·鹿盔
//TEXT=你的<b>抉择</b>牌和英雄技能可以同时拥有两种效果。
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=NONE
}
public class OG_044a:MinionBase{
//NAME=利爪德鲁伊
//TEXT=<b>突袭</b>，<b>嘲讽</b>
//MAJ=DRUID|COST=6|ATK=7|HP=9|RACE=BEAST
}
public class OG_044b:MinionBase{
//NAME=烈焰德鲁伊
//TEXT=
//MAJ=DRUID|COST=3|ATK=5|HP=5|RACE=BEAST
}
public class OG_044c:MinionBase{
//NAME=刃牙德鲁伊
//TEXT=<b>冲锋，潜行</b>
//MAJ=DRUID|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class OG_044e:Ability{
//NAME=范达尔附魔
//TEXT=你的<b>抉择</b>牌和英雄技能可以同时拥有两种效果。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_045:SpellBase{
//NAME=寄生感染
//TEXT=使你的所有随从获得 “<b>亡语：</b>随机将一张野兽牌置入你的手牌”。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class OG_045a:Ability{
//NAME=蛛魔孢子
//TEXT=死亡时获得一张野兽牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_047:SpellBase{
//NAME=野性之怒
//TEXT=<b>抉择：</b>使你的英雄在本回合中获得+4攻击力；或者获得8点护甲值。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class OG_047a:SpellBase{
//NAME=脊刺异变
//TEXT=在本回合中，使你的英雄获得+4攻击力。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class OG_047b:SpellBase{
//NAME=鳞甲异变
//TEXT=获得8点护甲值。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class OG_047e:Ability{
//NAME=脊刺
//TEXT=在本回合中+4攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_048:SpellBase{
//NAME=亚煞极印记
//TEXT=使一个随从获得+2/+2。 如果该随从是野兽，抽一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,atkChange:2,hpChange:2).Resolve();
        if(target.raceType.Contains(RaceType.Beast))
        {
            TaskDraw();
        }
    }
}
public class OG_048e:Ability{
//NAME=亚煞极印记
//TEXT=+2/+2。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_051:MinionBase{
//NAME=禁忌古树
//TEXT=<b>战吼：</b>消耗你所有的法力值，每消耗一点法力值，便获得+1/+1。
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=NONE
}
public class OG_051e:Ability{
//NAME=禁忌力量
//TEXT=属性值提高。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_058:WeaponBase{
//NAME=锈蚀铁钩
//TEXT=
//MAJ=WARRIOR|COST=1|ATK=1|HP=3|RACE=NONE
}
public class OG_061:SpellBase{
//NAME=搜寻猎物
//TEXT=造成$1点伤害。召唤一个1/1的獒犬。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class OG_061t:MinionBase{
//NAME=獒犬
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class OG_070:MinionBase{
//NAME=执刃教徒
//TEXT=<b>连击：</b>获得+1/+1。
//MAJ=ROGUE|COST=1|ATK=1|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)>0)
        {
            new EffectChange(owner.myPlayer,owner,owner,atkChange:1,hpChange:1).Resolve();
        }
    }
}
public class OG_070e:Ability{
//NAME=嗜血之刃
//TEXT=+1/+1。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_072:SpellBase{
//NAME=深渊探险
//TEXT=<b>发现</b>一张<b>亡语</b>牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class OG_073:SpellBase{
//NAME=菊花茶
//TEXT=抽一张牌。将两张该牌的复制置入你的手牌。
//MAJ=ROGUE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class OG_080:MinionBase{
//NAME=毒心者夏克里尔
//TEXT=<b>战吼，亡语：</b>随机将一张毒素牌置入你的手牌。
//MAJ=ROGUE|COST=4|ATK=3|HP=2|RACE=NONE
    private List<string> Poitions = new List<string>(){"OG_080b","OG_080c","OG_080d","OG_080e","OG_080f"};
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid(this.Poitions.Choice(owner.myPlayer.randomGen)),ZoneType.Hand);
    }
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid(this.Poitions.Choice(owner.myPlayer.randomGen)),ZoneType.Hand);   
    }
}
public class OG_080ae:Ability{
//NAME=血蓟
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_080b:SpellBase{
//NAME=皇血草毒素
//TEXT=抽一张牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        TaskDraw();
    }
}
public class OG_080c:SpellBase{
//NAME=血蓟毒素
//TEXT=将一个友方随从移回你的手牌。 它的法力值消耗减少（2）点。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        new EffectMove(owner.myPlayer,target,(ZoneType)target.GetTag(GameTag.ZoneType),ZoneType.Hand).Resolve();
        new EffectChange(owner.myPlayer,owner,target,manaChange:-2).Resolve();
    }
}
public class OG_080d:SpellBase{
//NAME=石南草毒素
//TEXT=使一个随从获得+3攻击力。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,atkChange:3).Resolve();
    }
}
public class OG_080de:Ability{
//NAME=枯叶草
//TEXT=获得潜行直到你的下个回合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_080e:SpellBase{
//NAME=枯叶草毒素
//TEXT=直到你的下个回合，使一个友方随从获得<b>潜行</b>。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        new EffectGiveAbility(owner.myPlayer,owner,target,"StealthFot").Resolve();
    }
}
public class OG_080ee:Ability{
//NAME=石南草
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_080f:SpellBase{
//NAME=火焰花毒素
//TEXT=造成$2点伤害。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
    }
}
public class OG_081:SpellBase{
//NAME=冰爆
//TEXT=消灭一个被<b>冻结</b>的随从。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FROST
}
public class OG_082:MinionBase{
//NAME=异变的狗头人
//TEXT=<b>法术伤害+2</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=NONE
}
public class OG_083:MinionBase{
//NAME=暮光烈焰召唤者
//TEXT=<b>战吼：</b>对所有敌方随从造成1点伤害。
//MAJ=MAGE|COST=3|ATK=2|HP=2|RACE=NONE
}
public class OG_085:MinionBase{
//NAME=癫狂的唤冰者
//TEXT=在你施放一个法术后，随机<b>冻结</b> 一个敌人。
//MAJ=MAGE|COST=4|ATK=2|HP=4|RACE=NONE
}
public class OG_086:SpellBase{
//NAME=禁忌烈焰
//TEXT=消耗你所有的法力值，对一个随从造成等同于所消耗法力值数量的伤害。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=FIRE
}
public class OG_087:MinionBase{
//NAME=尤格-萨隆的仆从
//TEXT=<b>战吼：</b>随机施放一个法力值消耗大于或等于（5）点的法术<i>（目标随机而定）</i>。
//MAJ=MAGE|COST=5|ATK=5|HP=4|RACE=NONE
}
public class OG_090:SpellBase{
//NAME=秘法宝典
//TEXT=随机获取3张法师法术牌。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class OG_094:SpellBase{
//NAME=真言术：触
//TEXT=使一个随从获得+2/+6。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class OG_094e:Ability{
//NAME=触须
//TEXT=+2/+6
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_096:MinionBase{
//NAME=暮光暗愈者
//TEXT=<b>战吼：</b>如果你的克苏恩至少有10点攻击力，便为你的英雄恢复#10点生命值。
//MAJ=PRIEST|COST=5|ATK=6|HP=5|RACE=NONE
}
public class OG_100:SpellBase{
//NAME=暗言术：骇
//TEXT=消灭所有攻击力小于或等于2的随从。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class OG_101:SpellBase{
//NAME=禁忌畸变
//TEXT=消耗你所有的法力值，随机 召唤一个法力值消耗相同的随从。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class OG_102:MinionBase{
//NAME=黑暗低语者
//TEXT=<b>战吼：</b>与另一个友方随从交换属性值。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=NONE
}
public class OG_102e:Ability{
//NAME=能量交替
//TEXT=属性互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_104:SpellBase{
//NAME=暗影之握
//TEXT=在本回合中，你的治疗效果转而造成等量的伤害。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class OG_104e:Ability{
//NAME=拥抱暗影
//TEXT=你的治疗效果会造成伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_109:MinionBase{
//NAME=夜色镇图书管理员
//TEXT=<b>战吼：</b> 随机弃一张牌。 <b>亡语：</b> 抽一张牌。
//MAJ=WARLOCK|COST=2|ATK=3|HP=2|RACE=NONE
}
public class OG_113:MinionBase{
//NAME=夜色镇议员
//TEXT=在你召唤一个随从后，获得+1攻击力。
//MAJ=WARLOCK|COST=3|ATK=1|HP=5|RACE=NONE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(tz==ZoneType.Board && CondInPlay() && sc!=owner)
        {
            new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
        }
    }
}
public class OG_113e:Ability{
//NAME=人民的力量
//TEXT=攻击力提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_114:SpellBase{
//NAME=禁忌仪式
//TEXT=消耗你所有的法力值，召唤相同数量的1/1的触须。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class OG_114a:MinionBase{
//NAME=黏滑的触须
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=NONE
}
public class OG_116:SpellBase{
//NAME=狂乱传染
//TEXT=造成$13点伤害，随机分配到所有角色身上。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class OG_118:SpellBase{
//NAME=弃暗投明
//TEXT=将你的英雄技能和术士卡牌替换成另一职业的。这些牌的法力值消耗减少（1）点。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class OG_118e:Ability{
//NAME=弃暗投明套牌强化
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_118f:Ability{
//NAME=新的使命
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_120:MinionBase{
//NAME=阿诺玛鲁斯
//TEXT=<b>亡语：</b>对所有随从造成8点伤害。
//MAJ=MAGE|COST=8|ATK=8|HP=6|RACE=ELEMENTAL
}
public class OG_121:MinionBase{
//NAME=古加尔
//TEXT=<b>战吼：</b>将你在本局对战中弃掉的所有牌移回你的手牌，这些牌会消耗生命值而非法力值。
//MAJ=WARLOCK|COST=8|ATK=8|HP=8|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<string> ToListCreate = new List<string>(){"OG_121","LOOT_017","ICC_055"};
        foreach(string s in ToListCreate)
        {
            Card c = TaskCreate(CardDbf.GetCardDbfByGuid(s),ZoneType.Hand);
            new EffectGiveAbility(owner.myPlayer,owner,c,"OG_121e").Resolve();
        }
    }
}
public class OG_121e:Ability{
//NAME=黑暗力量
//TEXT=消耗生命值，而非法力值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            return -owner.cardDbf.ManaCost;
        }
        return 0;
    }
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.hero.Count>0)
            new EffectDamage(owner.myPlayer,owner,owner.myPlayer.hero[0],owner.cardDbf.ManaCost,createVfx:false).Resolve();
        //TaskDamageMyHero(owner.cardDbf.ManaCost);
    }
}
public class OG_122:MinionBase{
//NAME=山谷之王穆克拉
//TEXT=<b>战吼：</b>将两根香蕉置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        CardDbf bana=CardDbf.GetCardDbfByGuid("EX1_014t");
        TaskCreate(bana,ZoneType.Hand);
        TaskCreate(bana,ZoneType.Hand);
    }
}
public class OG_123:MinionBase{
//NAME=百变泽鲁斯
//TEXT=如果这张牌在你的手牌中，每个回合都会随机变成一张随从牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class OG_123e:Ability{
//NAME=变形
//TEXT=随机变成一张随从牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_131:MinionBase{
//NAME=维克洛尔大帝
//TEXT=<b><b>嘲讽</b>，战吼：</b>如果你的克苏恩至少有10点攻击力，则召唤另一名双子皇帝。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=7|RACE=NONE
}
public class OG_133:MinionBase{
//NAME=恩佐斯
//TEXT=<b>战吼：</b>召唤所有你在本局对战中死亡的，并具有<b>亡语</b>的随从。
//MAJ=NEUTRAL|COST=10|ATK=5|HP=7|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<CardDbf> ToListSummon = new List<CardDbf>();
        foreach(Card c in owner.myPlayer.grave)
        {
            if(c.HasAbility("Deathrattle") && c.cardType==CardType.Minion)
            {
                ToListSummon.Add(c.cardDbf);
            }
        }
        foreach(CardDbf d in ToListSummon)
        {
            TaskCreate(d,ZoneType.Board);
        }
    }
}
public class OG_134:MinionBase{
//NAME=尤格-萨隆
//TEXT=<b>战吼：</b> 在本局对战中，你每施放过一个法术，便随机施放一个法术<i>（目标随机而定）</i>。
//MAJ=NEUTRAL|COST=10|ATK=7|HP=5|RACE=NONE
}
public class OG_138:MinionBase{
//NAME=蛛魔先知
//TEXT=在你的回合开始时，本牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=UNDEAD
}
public class OG_138e:Ability{
//NAME=宰相之赐
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_141:MinionBase{
//NAME=无面巨兽
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=10|HP=10|RACE=NONE
}
public class OG_142:MinionBase{
//NAME=惊骇恐魔
//TEXT=
//MAJ=NEUTRAL|COST=8|ATK=6|HP=10|RACE=NONE
}
public class OG_145:MinionBase{
//NAME=闹闹机器人
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=5|ATK=3|HP=4|RACE=MECHANICAL
}
public class OG_147:MinionBase{
//NAME=腐化治疗机器人
//TEXT=<b>亡语：</b>为敌方英雄恢复#8点生命值。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=MECHANICAL
}
public class OG_149:MinionBase{
//NAME=暴虐食尸鬼
//TEXT=<b>战吼：</b>对所有其他随从造成1点伤害。
//MAJ=WARRIOR|COST=3|ATK=3|HP=3|RACE=UNDEAD
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Exclude(owner),1);
    }
}
public class OG_150:MinionBase{
//NAME=畸变狂战士
//TEXT=受伤时拥有+2攻 击力。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class OG_150e:Ability{
//NAME=激怒
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_151:MinionBase{
//NAME=恩佐斯的触须
//TEXT=<b>亡语：</b>对所有随从造成1点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class OG_152:MinionBase{
//NAME=畸变的龙鹰
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=7|ATK=5|HP=5|RACE=BEAST
}
public class OG_153:MinionBase{
//NAME=毒沼爬行者
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=7|ATK=6|HP=8|RACE=NONE
}
public class OG_156:MinionBase{
//NAME=怒鳍猎潮者
//TEXT=<b>战吼：</b>召唤一个1/1并具有<b>嘲讽</b>的软泥怪。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=MURLOC
}
public class OG_156a:MinionBase{
//NAME=软泥怪
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class OG_158:MinionBase{
//NAME=狂热的新兵
//TEXT=<b>亡语：</b>随机使一个友方随从获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class OG_158e:Ability{
//NAME=新兵手册
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_161:MinionBase{
//NAME=腐化先知
//TEXT=<b>战吼：</b>对所有非鱼人随从造成2点伤害。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=3|RACE=MURLOC
}
public class OG_162:MinionBase{
//NAME=克苏恩的信徒
//TEXT=<b>战吼：</b> 造成2点伤害。使你的克苏恩获得+2/+2<i>（无论它在哪里）。</i>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class OG_173:MinionBase{
//NAME=远古造物之血
//TEXT=在你的回合结束时，如果你控制两个远古造物之血，则将其融合成远古造物。
//MAJ=NEUTRAL|COST=9|ATK=9|HP=9|RACE=NONE
}
public class OG_173a:MinionBase{
//NAME=远古造物
//TEXT=
//MAJ=NEUTRAL|COST=9|ATK=30|HP=30|RACE=NONE
}
public class OG_174:MinionBase{
//NAME=无面蹒跚者
//TEXT=<b>嘲讽</b>，<b>战吼：</b>复制一个友方随从的攻击力和生命值。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=1|RACE=NONE
}
public class OG_174e:Ability{
//NAME=无面之力
//TEXT=复制属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_176:SpellBase{
//NAME=暗影打击
//TEXT=对一个 未受伤的角色造成$5点伤害。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class OG_179:MinionBase{
//NAME=炽炎蝙蝠
//TEXT=<b>亡语：</b>随机对一个敌人造成1点伤害。
//MAJ=HUNTER|COST=1|ATK=2|HP=1|RACE=BEAST
	public override void Deathrattle()
	{
		TaskDamageRandomEnemy(1);
	}
}
public class OG_188:MinionBase{
//NAME=卡拉克西织珀者
//TEXT=<b>嘲讽</b>。<b>战吼：</b> 如果你的克苏恩至少有10点攻击力，便获得+5生命值。
//MAJ=DRUID|COST=4|ATK=4|HP=5|RACE=NONE
}
public class OG_188e:Ability{
//NAME=琥珀甲壳
//TEXT=+5生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_195:SpellBase{
//NAME=上古之神的小精灵
//TEXT=<b>抉择：</b>召唤七个1/1的小精灵；或者使你的所有随从获得+2/+2。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class OG_195a:SpellBase{
//NAME=小精灵大军
//TEXT=召唤七个1/1的小精灵。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class OG_195b:SpellBase{
//NAME=小精灵之力
//TEXT=使你的所有随从获得+2/+2。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class OG_195c:MinionBase{
//NAME=小精灵
//TEXT=
//MAJ=DRUID|COST=0|ATK=1|HP=1|RACE=UNDEAD
}
public class OG_195e:Ability{
//NAME=身强体壮
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_198:SpellBase{
//NAME=禁忌治疗
//TEXT=消耗你所有的法力值，恢复等同于所消耗法力值数量两倍的生命值。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=HOLY
}
public class OG_200:MinionBase{
//NAME=末日践行者
//TEXT=在你的回合开始时，将本随从的攻击力 变为7。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=7|RACE=NONE
}
public class OG_200e:Ability{
//NAME=末日不再
//TEXT=攻击力变为7。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_202:MinionBase{
//NAME=泥潭守护者
//TEXT=<b>抉择：</b>召唤一个2/2的泥浆怪；或者获得一个空的法力水晶。
//MAJ=DRUID|COST=4|ATK=3|HP=4|RACE=NONE
}
public class OG_202a:SpellBase{
//NAME=亚煞极之力
//TEXT=召唤一个2/2的泥浆怪。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class OG_202ae:Ability{
//NAME=亚煞极之力
//TEXT=+3/+3。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_202b:SpellBase{
//NAME=尤格-萨隆之赐
//TEXT=获得一个空的法力水晶。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class OG_202c:MinionBase{
//NAME=泥浆怪
//TEXT=
//MAJ=DRUID|COST=2|ATK=2|HP=2|RACE=NONE
}
public class OG_206:SpellBase{
//NAME=雷暴术
//TEXT=对一个随从造成$4点伤害，<b>过载：</b>（1）
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class OG_207:MinionBase{
//NAME=无面召唤者
//TEXT=<b>战吼：</b>随机召唤一个法力值消耗为（3）的随从。
//MAJ=MAGE|COST=6|ATK=5|HP=5|RACE=NONE
}
public class OG_209:MinionBase{
//NAME=升腾者海纳泽尔
//TEXT=<b>法术伤害+1</b> 你的法术拥有<b>吸血</b>。
//MAJ=SHAMAN|COST=5|ATK=4|HP=6|RACE=ELEMENTAL
}
public class OG_211:SpellBase{
//NAME=兽群呼唤
//TEXT=召唤全部三个动物伙伴。
//MAJ=HUNTER|COST=8|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<string> ToListSummon = new List<string>(){"NEW1_032","NEW1_033","NEW1_034"};
        
        foreach(string s in ToListSummon)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid(s),ZoneType.Board);
        }
    }
}
public class OG_216:MinionBase{
//NAME=寄生恶狼
//TEXT=<b>亡语：</b>召唤两只1/1的蜘蛛。
//MAJ=HUNTER|COST=4|ATK=3|HP=3|RACE=BEAST
    public override void Deathrattle()
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("OG_216a");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class OG_216_G:MinionBase{
//NAME=寄生恶狼
//TEXT=<b>亡语：</b>召唤两只1/1的蜘蛛。
//MAJ=HUNTER|COST=4|ATK=3|HP=3|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Deathrattle()
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("OG_216a_G");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class OG_216a:MinionBase{
//NAME=蜘蛛
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class OG_216a_G:MinionBase{
//NAME=蜘蛛
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class OG_218:MinionBase{
//NAME=血蹄勇士
//TEXT=<b>嘲讽</b> 受伤时拥有+3攻 击力。
//MAJ=WARRIOR|COST=4|ATK=2|HP=6|RACE=NONE
}
public class OG_218e:Ability{
//NAME=激怒
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_220:MinionBase{
//NAME=马尔考罗克
//TEXT=<b>战吼：</b>随机装备一把武器。
//MAJ=WARRIOR|COST=7|ATK=6|HP=5|RACE=NONE
}
public class OG_221:MinionBase{
//NAME=无私的英雄
//TEXT=<b>亡语：</b>随机使一个友方随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=1|ATK=2|HP=1|RACE=NONE
}
public class OG_222:WeaponBase{
//NAME=集结之刃
//TEXT=<b>战吼：</b>使你具有<b>圣盾</b>的随从获得+1/+1。
//MAJ=PALADIN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class OG_222e:Ability{
//NAME=集结号令
//TEXT=+1/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_223:SpellBase{
//NAME=神圣之力
//TEXT=使一个随从获得+1/+2。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,atkChange:1,hpChange:2).Resolve();
    }
}
public class OG_223e:Ability{
//NAME=圣光之赐
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_229:MinionBase{
//NAME=光耀之主拉格纳罗斯
//TEXT=在你的回合结束时，为一个受伤的友方角色恢复#8点生命值。
//MAJ=PALADIN|COST=8|ATK=8|HP=8|RACE=ELEMENTAL
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
        {
            List<Card> ToListHeal = new List<Card>();
            foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.hero))
            {
                if(c.GetTag(GameTag.Damage)>0)
                {
                    ToListHeal.Add(c);
                }
            }
            Card ToHeal = ToListHeal.Choice(owner.myPlayer.randomGen);
            if(ToHeal!=null)
            {
                new EffectHeal(owner.myPlayer,owner,ToHeal,8).Resolve();
            }
        }
    }
}
public class OG_234:MinionBase{
//NAME=夜色镇炼金师
//TEXT=<b>战吼：</b> 恢复#5点生命值。
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=NONE
}
public class OG_239:SpellBase{
//NAME=末日降临
//TEXT=消灭所有随从。每消灭一个随从，便抽一张牌。
//MAJ=WARLOCK|COST=10|ATK=0|HP=0|RACE=SHADOW
}
public class OG_241:MinionBase{
//NAME=着魔村民
//TEXT=<b>亡语：</b>召唤一个1/1的暗影兽。
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=NONE
}
public class OG_241a:MinionBase{
//NAME=暗影兽
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=NONE
}
public class OG_247:MinionBase{
//NAME=扭曲的狼人
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=1|RACE=NONE
}
public class OG_248:MinionBase{
//NAME=浆岩暴怒者
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=UNDEAD
}
public class OG_249:MinionBase{
//NAME=被感染的牛头人
//TEXT=<b>嘲讽</b> <b>亡语：</b>召唤一个2/2的泥浆怪。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=3|RACE=NONE
}
public class OG_249a:MinionBase{
//NAME=泥浆怪
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class OG_254:MinionBase{
//NAME=奥秘吞噬者
//TEXT=<b>战吼：</b>摧毁所有敌方<b>奥秘</b>。每摧毁一个，便获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=NONE
}
public class OG_254e:Ability{
//NAME=无穷奥秘
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_255:MinionBase{
//NAME=厄运召唤者
//TEXT=<b>战吼：</b>使你的克苏恩获得+2/+2<i>（无论它在哪里）。</i>如果克苏恩死亡，将其洗入你的牌库。
//MAJ=NEUTRAL|COST=8|ATK=7|HP=9|RACE=NONE
}
public class OG_256:MinionBase{
//NAME=恩佐斯的子嗣
//TEXT=<b>亡语：</b>使你的所有随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
    public override void Init()
    {
        //owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
    }
    public override void Deathrattle()
    {
        TaskBuffTargets(owner.myPlayer.board,atk:1,hp:1);
    }
}
public class OG_256e:Ability{
//NAME=黏呼呼的
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_267:MinionBase{
//NAME=南海畸变船长
//TEXT=<b>亡语：</b>使你的武器获得+2攻击力。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=PIRATE
}
public class OG_267e:Ability{
//NAME=深海鱼油
//TEXT=+2攻击力
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_270a:MinionBase{
//NAME=蛛魔士兵
//TEXT=
//MAJ=NEUTRAL|COST=8|ATK=7|HP=7|RACE=NONE
}
public class OG_271:MinionBase{
//NAME=梦魇之龙
//TEXT=在你的回合开始时，本随从的攻击力 翻倍。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=8|RACE=DRAGON
}
public class OG_271e:Ability{
//NAME=恐惧化身
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_272:MinionBase{
//NAME=暮光召唤师
//TEXT=<b>亡语：</b>召唤一个5/5的无面破坏者。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=1|RACE=NONE
}
public class OG_272t:MinionBase{
//NAME=无面破坏者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=5|RACE=NONE
}
public class OG_273:SpellBase{
//NAME=惩黑除恶
//TEXT=召唤五个1/1的白银之手新兵。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class OG_276:SpellBase{
//NAME=苦战傀儡
//TEXT=将每个受伤的友方随从的各一张复制置入你的手牌。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class OG_279:MinionBase{
//NAME=克苏恩
//TEXT=<b>战吼：</b> 造成等同于本随从攻击力的伤害，随机分配到所有敌人身上。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=6|RACE=NONE
}
public class OG_280:MinionBase{
//NAME=克苏恩
//TEXT=<b>战吼：</b> 造成等同于本随从攻击力的伤害，随机分配到所有敌人身上。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=6|RACE=NONE
}
public class OG_281:MinionBase{
//NAME=邪灵召唤师
//TEXT=<b>战吼：</b>使你的克苏恩获得+2/+2<i>（无论它在哪里）。</i>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class OG_281e:Ability{
//NAME=狂热献祭
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_282:MinionBase{
//NAME=克苏恩之刃
//TEXT=<b>战吼：</b>消灭一个随从。你的克苏恩会获得其攻击力和生命值<i>（无论它在哪里）。</i>
//MAJ=ROGUE|COST=7|ATK=4|HP=4|RACE=NONE
}
public class OG_282e:Ability{
//NAME=利刃之赐
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_283:MinionBase{
//NAME=克苏恩的侍从
//TEXT=<b>圣盾</b>，<b>战吼：</b>使你的克苏恩获得+3/+3<i>（无论它在哪里）。</i>
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=UNDEAD
}
public class OG_284:MinionBase{
//NAME=暮光地卜师
//TEXT=<b>嘲讽</b>。<b>战吼：</b>使你的克苏恩获得+1/+1和<b>嘲讽</b><i>（无论它在哪里）。</i>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=NONE
}
public class OG_284e:Ability{
//NAME=地卜术
//TEXT=<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_286:MinionBase{
//NAME=暮光尊者
//TEXT=在你的回合结束时，使你的克苏恩 获得+1/+1<i>（无论它在哪里）。</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class OG_290:MinionBase{
//NAME=上古之神先驱
//TEXT=在你的回合开始时，将一个法力值消耗为（10）的随从从你的牌库置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=6|RACE=NONE
}
public class OG_290e:Ability{
//NAME=奋勇争先
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_291:MinionBase{
//NAME=暗影施法者
//TEXT=<b>战吼：</b>选择一个友方随从，将它的一张1/1的复制置入你的手牌，其法力值消耗为（1）点。
//MAJ=ROGUE|COST=5|ATK=4|HP=4|RACE=NONE
}
public class OG_291e:Ability{
//NAME=浮光暗影
//TEXT=暗影施法者将它变成了1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_292:MinionBase{
//NAME=狼人追猎者
//TEXT=<b>战吼：</b>使你手牌中所有<b>亡语</b>随从牌获得+1/+1。
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=NONE
}
public class OG_292e:Ability{
//NAME=月圆之赐
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_293:MinionBase{
//NAME=黑暗鸦人
//TEXT=<b>嘲讽</b>，<b>战吼：</b>使你的克苏恩获得+4/+4<i>（无论它在哪里）。</i>
//MAJ=DRUID|COST=6|ATK=5|HP=7|RACE=NONE
}
public class OG_293e:Ability{
//NAME=鸦人献祭
//TEXT=+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_293f:Ability{
//NAME=黑暗卫士
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_295:MinionBase{
//NAME=异教药剂师
//TEXT=<b>战吼：</b>每有一个敌方随从，便为你的英雄恢复#2点生命值。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class OG_300:MinionBase{
//NAME=波戈蒙斯塔
//TEXT=每当波戈蒙斯塔攻击并消灭一个随从，便获得+2/+2。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=7|RACE=NONE
    public override void AfterAttack(Card target)
    {
        if(target!=null)
        {
            if(target.GetTag(GameTag.Health)<=0)
            {
                new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:2).Resolve();
            }
        }
    }
}
public class OG_300_G:MinionBase{
//NAME=波戈蒙斯塔
//TEXT=每当波戈蒙斯塔攻击并消灭一个随从，便获得+2/+2。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=7|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void AfterAttack(Card target)
    {
        if(target!=null)
        {
            if(target.GetTag(GameTag.Health)<=0)
            {
                new EffectChange(owner.myPlayer,owner,owner,atkChange:4,hpChange:4).Resolve();
            }
        }
    }
}
public class OG_300e:Ability{
//NAME=美味佳肴
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_301:MinionBase{
//NAME=上古之神护卫
//TEXT=<b>战吼：</b> 如果你的克苏恩至少有10点攻击力，则获得10点护甲值。
//MAJ=WARRIOR|COST=6|ATK=6|HP=6|RACE=NONE
}
public class OG_302:MinionBase{
//NAME=渡魂者
//TEXT=每当一个随从死亡，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i>
//MAJ=WARLOCK|COST=4|ATK=3|HP=5|RACE=NONE
}
public class OG_302e:Ability{
//NAME=灵魂之力
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_303:MinionBase{
//NAME=异教女巫
//TEXT=<b>法术伤害+1</b> 在你施放一个法术后，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i>
//MAJ=MAGE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class OG_303e:Ability{
//NAME=巫术献祭
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_308:MinionBase{
//NAME=巨型沙虫
//TEXT=每当本随从攻击并消灭一个随从，可再次攻击。
//MAJ=HUNTER|COST=8|ATK=8|HP=8|RACE=BEAST
}
public class OG_309:MinionBase{
//NAME=哈霍兰公主
//TEXT=<b>战吼：</b>触发一个友方随从的<b>亡语</b>。
//MAJ=HUNTER|COST=5|ATK=6|HP=5|RACE=BEAST
}
public class OG_310:MinionBase{
//NAME=夜色镇执法官
//TEXT=每当你召唤一个生命值为1的随从，便使其获得<b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=4|HP=3|RACE=NONE
}
public class OG_311:SpellBase{
//NAME=黑暗曙光
//TEXT=<b>发现</b>一张圣骑士随从牌。使其获得+2/+2。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class OG_311e:Ability{
//NAME=希望信标
//TEXT=+2/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_312:MinionBase{
//NAME=恩佐斯的副官
//TEXT=<b>战吼：</b>装备一把1/3的锈蚀铁钩。
//MAJ=WARRIOR|COST=1|ATK=1|HP=1|RACE=PIRATE
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("OG_058"),ZoneType.Weapon);
	}
}
public class OG_312e:Ability{
//NAME=已升级
//TEXT=耐久度提高。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_313:MinionBase{
//NAME=腐化灰熊
//TEXT=在你召唤一只野兽后，使其获得+1/+1。
//MAJ=DRUID|COST=2|ATK=2|HP=3|RACE=BEAST
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }

    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(tz==ZoneType.Board && owner.GetTag(GameTag.ZoneType) == (int)ZoneType.Board && sc.raceType.Contains(RaceType.Beast))
        {
            new EffectChange(owner.myPlayer,owner,sc,hpChange:1,atkChange:1).Resolve();
        }
    }
}
public class OG_313e:Ability{
//NAME=腐化
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_314:SpellBase{
//NAME=化血为脓
//TEXT=对一个随从造成$1点伤害，如果它依然存活，则召唤一个2/2的泥浆怪。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class OG_314b:MinionBase{
//NAME=泥浆怪
//TEXT=
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=NONE
}
public class OG_315:MinionBase{
//NAME=血帆教徒
//TEXT=<b>战吼：</b>如果你控制着其他海盗，使你的武器获得+1/+1。
//MAJ=WARRIOR|COST=3|ATK=3|HP=4|RACE=PIRATE
}
public class OG_315e:Ability{
//NAME=重铸
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_316:MinionBase{
//NAME=传令官沃拉兹
//TEXT=<b>战吼：</b>召唤所有其他友方随从的复制，他们均为1/1。
//MAJ=PRIEST|COST=6|ATK=5|HP=5|RACE=NONE
}
public class OG_316k:Ability{
//NAME=暗影力量
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_317:MinionBase{
//NAME=黑龙领主死亡之翼
//TEXT=<b>亡语：</b>将你手牌中所有的龙牌置入战场。
//MAJ=NEUTRAL|COST=10|ATK=12|HP=12|RACE=DRAGON
}
public class OG_318:MinionBase{
//NAME=艾尔文灾星霍格
//TEXT=每当本随从受到伤害，召唤一个2/2并具有<b>嘲讽</b>的豺狼人。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=NONE
}
public class OG_318t:MinionBase{
//NAME=豺狼人
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class OG_319:MinionBase{
//NAME=维克尼拉斯大帝
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=7|ATK=6|HP=7|RACE=NONE
}
public class OG_320:MinionBase{
//NAME=午夜幼龙
//TEXT=<b>战吼：</b>你每有一张其他手牌，便获得+1攻击力。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=4|RACE=DRAGON
}
public class OG_320e:Ability{
//NAME=腐化之力
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_321:MinionBase{
//NAME=疯狂的信徒
//TEXT=<b>嘲讽</b>。每当本随从受到伤害，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=NONE
}
public class OG_321e:Ability{
//NAME=信仰之力
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_322:MinionBase{
//NAME=黑水海盗
//TEXT=你的武器法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=PIRATE
}
public class OG_323:MinionBase{
//NAME=被感染的贮藏者
//TEXT=<b>亡语：</b>抽一张牌。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=NONE
}
public class OG_325:MinionBase{
//NAME=腐肉虫
//TEXT=
//MAJ=HUNTER|COST=3|ATK=2|HP=5|RACE=BEAST
}
public class OG_326:MinionBase{
//NAME=暮色野猪
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=4|HP=1|RACE=BEAST
}
public class OG_327:MinionBase{
//NAME=裂地触须
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class OG_328:MinionBase{
//NAME=异变之主
//TEXT=<b>战吼：</b>将一个友方随从随机变形成为一个法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=4|ATK=4|HP=5|RACE=NONE
}
public class OG_330:MinionBase{
//NAME=幽暗城商贩
//TEXT=<b>亡语：</b>随机获取一张<i>（你对手职业的）</i>卡牌。
//MAJ=ROGUE|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class OG_334:MinionBase{
//NAME=兜帽侍僧
//TEXT=<b>嘲讽</b>。每当一个角色获得治疗时，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i>
//MAJ=PRIEST|COST=4|ATK=3|HP=6|RACE=NONE
}
public class OG_335:MinionBase{
//NAME=变幻之影
//TEXT=<b>亡语：</b>复制你对手的牌库中的一张牌，并将其置入你的手牌。
//MAJ=PRIEST|COST=4|ATK=4|HP=3|RACE=UNDEAD
    public override void Deathrattle()
    {
        Card ToCopy = owner.myPlayer.otherPlayer.deck.Choice(owner.myPlayer.randomGen);
        if(ToCopy!=null)
            TaskCreate(ToCopy.cardDbf,ZoneType.Hand);
    }
}
public class OG_337:MinionBase{
//NAME=巨型独眼怪
//TEXT=<b>嘲讽，战吼：</b>每有一个敌方随从，便获得+1生命值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class OG_337e:Ability{
//NAME=毁灭之眼
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_338:MinionBase{
//NAME=阴暗渔夫纳特
//TEXT=你的对手在回合开始时，有50%的几率额外抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=4|RACE=NONE
}
public class OG_339:MinionBase{
//NAME=斯克拉姆狂热者
//TEXT=<b>战吼：</b> 使你的克苏恩 获得+2/+2<i>（无论它在哪里）</i>。
//MAJ=NEUTRAL|COST=6|ATK=7|HP=6|RACE=NONE
}
public class OG_339e:Ability{
//NAME=狂热献祭
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class OG_340:MinionBase{
//NAME=深渊滑行者索苟斯
//TEXT=<b>嘲讽</b>。<b>扰魔</b>
//MAJ=NEUTRAL|COST=9|ATK=5|HP=9|RACE=NONE
}
