using System.Collections;
using System.Collections.Generic;

public class CORE_AT_003:MinionBase{
//NAME=英雄之魂
//TEXT=你的英雄技能会额外造成1点伤害。
//MAJ=MAGE|COST=2|ATK=3|HP=2|RACE=UNDEAD
}
public class CORE_AT_008:MinionBase{
//NAME=考达拉幼龙
//TEXT=你可以使用任意次数的英雄技能。
//MAJ=MAGE|COST=6|ATK=6|HP=7|RACE=DRAGON
}
public class CORE_AT_011:MinionBase{
//NAME=神圣勇士
//TEXT=<b>过量治疗：</b>获得+2攻击力。
//MAJ=PRIEST|COST=2|ATK=1|HP=4|RACE=NONE
}
public class CORE_AT_021:MinionBase{
//NAME=小鬼骑士
//TEXT=每当你弃掉一张牌时，便获得+2/+1。
//MAJ=WARLOCK|COST=2|ATK=3|HP=2|RACE=DEMON
}
public class CORE_AT_029:MinionBase{
//NAME=锈水海盗
//TEXT=每当你装备一把武器，使武器获得+1攻击力。
//MAJ=ROGUE|COST=1|ATK=2|HP=1|RACE=PIRATE
}
public class CORE_AT_037:SpellBase{
//NAME=活体根须
//TEXT=<b>抉择：</b>造成$2点伤害；或者召唤两个1/1的树苗。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class CORE_AT_047:MinionBase{
//NAME=德莱尼图腾师
//TEXT=<b>战吼：</b>每有一个友方图腾，便获得+1/+1。
//MAJ=SHAMAN|COST=4|ATK=4|HP=5|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int Num=0;
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.raceType.Contains(RaceType.Totem) || c.raceType.Contains(RaceType.All))
            {
                Num+=1;
            }
        }
        new EffectChange(owner.myPlayer,owner,owner,atkChange:Num,hpChange:Num).Resolve();
    }
}
public class CORE_AT_053:SpellBase{
//NAME=先祖知识
//TEXT=抽两张牌。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.SetTag(GameTag.ManaOverLoad,1);
        TaskDraw();
        TaskDraw();
    }
}
public class CORE_AT_055:SpellBase{
//NAME=快速治疗
//TEXT=恢复#5点生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class CORE_AT_061:SpellBase{
//NAME=子弹上膛
//TEXT=在本回合中，每当你施放一个法术，随机获取一张 猎人卡牌。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CORE_AT_062:SpellBase{
//NAME=天降蛛群
//TEXT=召唤三只1/1并具有“<b>亡语：</b>随机获取一张野兽牌”的 结网蛛。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class CORE_AT_064:SpellBase{
//NAME=怒袭
//TEXT=造成$3点伤害。获得3点 护甲值。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        TaskBuffMyHero(arm:3);
    }
}
public class CORE_AT_075:MinionBase{
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
public class CORE_AT_092:MinionBase{
//NAME=冰霜暴怒者
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=5|HP=2|RACE=ELEMENTAL
}
public class CORE_AT_132:MinionBase{
//NAME=裁决者图哈特
//TEXT=<b>战吼：</b>以更强的英雄技能来替换你的初始英雄技能。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=4|RACE=NONE
}
public class CORE_AV_226:SecretBase{
//NAME=冰霜陷阱
//TEXT=<b>奥秘：</b>当你的对手施放一个法术时，改为将其移回拥有者的手牌，并且法力值消耗增加（1）点。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=FROST
}
public class CORE_BAR_535:MinionBase{
//NAME=厚皮科多兽
//TEXT=<b>嘲讽</b>，<b>亡语：</b>获得5点护甲值。
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        TaskBuffMyHero(arm:5);
    }
}
public class CORE_BAR_551:MinionBase{
//NAME=巴拉克·科多班恩
//TEXT=<b>战吼：</b> 抽取法力值消耗为（1），（2）和（3）点的法术牌各一张。
//MAJ=HUNTER|COST=5|ATK=3|HP=5|RACE=NONE
}
public class CORE_BOT_020:MinionBase{
//NAME=滑板机器人
//TEXT=<b>磁力</b> <b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
}
public class CORE_BOT_021:MinionBase{
//NAME=青铜门卫
//TEXT=<b>磁力</b> <b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=MECHANICAL
}
public class CORE_BOT_083:MinionBase{
//NAME=毒物学家
//TEXT=<b>战吼：</b>使你的武器获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CORE_BOT_103:MinionBase{
//NAME=观星者露娜
//TEXT=在你使用最右边的一张手牌后，抽 一张牌。
//MAJ=MAGE|COST=3|ATK=2|HP=4|RACE=NONE
}
public class CORE_BOT_104:MinionBase{
//NAME=掷弹机器人
//TEXT=<b>战吼：</b>造成5点伤害，随机分配到所有非机械随从身上。
//MAJ=WARRIOR|COST=5|ATK=3|HP=4|RACE=MECHANICAL
}
public class CORE_BOT_222:SpellBase{
//NAME=灵魂炸弹
//TEXT=对一个随从和你的英雄各造成$4点伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_BOT_312:MinionBase{
//NAME=量产型恐吓机
//TEXT=<b>磁力</b> <b>亡语：</b>召唤三个1/1的微型机器人。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=MECHANICAL
}
public class CORE_BOT_420:SpellBase{
//NAME=植树造林
//TEXT=召唤两个2/2的树人。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class CORE_BOT_451:SpellBase{
//NAME=流电爆裂
//TEXT=召唤两个1/1并具有<b>突袭</b>的“火花”。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
        TaskCreate(CardDbf.GetCardDbfByGuid("BOT_102t"),ZoneType.Board);
        TaskCreate(CardDbf.GetCardDbfByGuid("BOT_102t"),ZoneType.Board);
    }
}
public class CORE_BOT_453:SpellBase{
//NAME=迸射流星
//TEXT=对一个随从及其相邻的随从造成$1点伤害。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
    public override void Battlecry(Card target=null)
    {
        Card Left=null;
        Card Right=null;
        int Index = target.myPlayer.board.IndexOf(target);
        if(Index-1>=0)
        {
            Left=target.myPlayer.board[Index-1];
        }
        if(Index+1<=target.myPlayer.board.Count-1)
        {
            Right=target.myPlayer.board[Index+1];
        }
        List<Card> ToListDamage=new List<Card>();
        if(Left!=null)
        {
            ToListDamage.Add(Left);
        }
        ToListDamage.Add(target);
        if(Right!=null)
        {
            ToListDamage.Add(Right);
        }
        TaskDamageTargets(ToListDamage,1);
    }
}
public class CORE_BOT_533:MinionBase{
//NAME=凶恶的雨云
//TEXT=<b>战吼：</b>随机将一张元素牌置入你的手牌。
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class CORE_BOT_548:MinionBase{
//NAME=奇利亚斯
//TEXT=<b>磁力，圣盾，嘲讽，吸血，突袭</b>
//MAJ=NEUTRAL|COST=5|ATK=3|HP=2|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("Magnetic");
        TaskInitAbility("DivineShield");
        TaskInitAbility("Taunt");
        TaskInitAbility("LifeSteal");
        TaskInitAbility("Rush");
    }
}
public class CORE_BOT_563:MinionBase{
//NAME=战争机兵
//TEXT=<b>磁力</b>
//MAJ=NEUTRAL|COST=5|ATK=6|HP=5|RACE=MECHANICAL
}
public class CORE_BOT_563e:Ability{
//NAME=战争机兵
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CORE_BRM_006:MinionBase{
//NAME=小鬼首领
//TEXT=每当本随从受到伤害，召唤一个1/1的 小鬼。
//MAJ=WARLOCK|COST=3|ATK=2|HP=4|RACE=DEMON
    public override void AfterTakeDamage(Card source,int amount)
    {
        if(amount>0)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("BRM_006t"),ZoneType.Board);
        }
    }
}
public class CORE_BRM_013:SpellBase{
//NAME=快速射击
//TEXT=造成$3点伤害。 如果你没有其他手牌，则抽一张牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_BT_035:SpellBase{
//NAME=混乱打击
//TEXT=在本回合中，使你的英雄获得+2攻击力。抽一张牌。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=FEL
    public override void Battlecry(Card target=null)
    {
        TaskBuffMyHero(atk:2);
        TaskDraw();
    }
}
public class CORE_BT_036:SpellBase{
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
public class CORE_BT_117:SpellBase{
//NAME=剑刃风暴
//TEXT=对所有随从造成$1点伤害。重复此效果，直到某个随从 死亡。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int GraveCnt = owner.myPlayer.grave.Merge(owner.myPlayer.otherPlayer.grave).Count;
        if(GraveCnt>0)
        {
            while(owner.myPlayer.grave.Merge(owner.myPlayer.otherPlayer.grave).Count==GraveCnt)
            {
                TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
            }
        }
    }
}
public class CORE_BT_134:SpellBase{
//NAME=沼泽射线
//TEXT=对一个随从造成$3点伤害。如果你拥有至少七个法力水晶，则法力值消耗为（0）点。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
    }
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=7)
                return -3;
        }
        return 0;
    }
}
public class CORE_BT_187:MinionBase{
//NAME=凯恩·日怒
//TEXT=<b>冲锋</b> 所有友方攻击无视 <b>嘲讽</b>。
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=5|RACE=NONE
}
public class CORE_BT_188:MinionBase{
//NAME=暗影珠宝师汉纳尔
//TEXT=在你使用一张<b>奥秘</b>牌后，<b>发现</b>一张不同职业的<b>奥秘</b>牌。
//MAJ=ROGUE|COST=2|ATK=1|HP=4|RACE=NONE
}
public class CORE_BT_235:SpellBase{
//NAME=混乱新星
//TEXT=对所有随从造成$4点伤害。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=FEL
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),4);
    }
}
public class CORE_BT_271:WeaponBase{
//NAME=斩炎
//TEXT=同时对其攻击目标相邻的随从 造成伤害。
//MAJ=DEMONHUNTER|COST=7|ATK=5|HP=3|RACE=NONE
}
public class CORE_BT_292:SpellBase{
//NAME=阿达尔之手
//TEXT=使一个随从获得+2/+1。 抽一张牌。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class CORE_BT_304:MinionBase{
//NAME=改进型恐惧魔王
//TEXT=<b>嘲讽，亡语：</b>召唤一个5/5并具有<b>吸血</b>的恐惧魔王。
//MAJ=WARLOCK|COST=8|ATK=5|HP=7|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BT_304t"),ZoneType.Board);
    }
}
public class CORE_BT_323:MinionBase{
//NAME=盲眼监视者
//TEXT=<b>战吼：</b>检视你牌库中的三张牌。选择一张置于牌库顶。
//MAJ=DEMONHUNTER|COST=2|ATK=3|HP=2|RACE=DEMON
}
public class CORE_BT_334:MinionBase{
//NAME=女伯爵莉亚德琳
//TEXT=<b>战吼：</b>将你在本局对战中施放在友方角色上的所有法术的复制置入你的手牌。
//MAJ=PALADIN|COST=7|ATK=4|HP=6|RACE=NONE
}
public class CORE_BT_351:MinionBase{
//NAME=战斗邪犬
//TEXT=在你的英雄攻击后，获得+1攻击力。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=3|RACE=DEMON
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
public class CORE_BT_355:MinionBase{
//NAME=怒鳞纳迦
//TEXT=在一个友方随从死亡后，随机对一个敌人造成3点伤害。
//MAJ=DEMONHUNTER|COST=3|ATK=3|HP=3|RACE=NAGA
}
public class CORE_BT_416:MinionBase{
//NAME=暴怒邪吼者
//TEXT=<b>战吼：</b>你的下一张恶魔牌的法力值消耗减少（2）点。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=4|RACE=NONE
}
public class CORE_BT_423:MinionBase{
//NAME=灰舌将领
//TEXT=<b>嘲讽，吸血</b>
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=5|RACE=NONE
}
public class CORE_BT_427:SpellBase{
//NAME=灵魂盛宴
//TEXT=在本回合中每有一个友方随从死亡，抽一张牌。0<i>（抽0张牌）</i>
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_BT_429:SpellBase{
//NAME=恶魔变形
//TEXT=将你的英雄技能替换为“造成5点伤害。”使用两次后，换回原技能。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=FEL
}
public class CORE_BT_430:WeaponBase{
//NAME=埃辛诺斯战刃
//TEXT=在攻击一个随从后，你的英雄可以再次攻击。
//MAJ=DEMONHUNTER|COST=5|ATK=3|HP=3|RACE=NONE
}
public class CORE_BT_480:MinionBase{
//NAME=火色魔印奔行者
//TEXT=<b>流放：</b>抽一张牌。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CORE_BT_491:SpellBase{
//NAME=幽灵视觉
//TEXT=抽一张牌。<b>流放：</b>再抽一张。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_BT_514:SpellBase{
//NAME=献祭光环
//TEXT=对所有随从造成$1点伤害两次。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=FEL
}
public class CORE_BT_707:SecretBase{
//NAME=伏击
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，召唤一个2/3并具有<b>剧毒</b>的伏击者。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_BT_801:SpellBase{
//NAME=眼棱
//TEXT=<b>吸血</b>。 对一个随从造成$3点伤害。<b>流放：</b>法力值消耗为（1）点。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=FEL
}
public class CORE_BT_921:WeaponBase{
//NAME=奥达奇战刃
//TEXT=<b>吸血</b>
//MAJ=DEMONHUNTER|COST=3|ATK=2|HP=2|RACE=NONE
}
public class CORE_BT_922:WeaponBase{
//NAME=棕红之翼
//TEXT=<b>战吼：</b>召唤两只1/1的邪翼蝠。
//MAJ=DEMONHUNTER|COST=2|ATK=1|HP=2|RACE=NONE
}
public class CORE_CFM_120:MinionBase{
//NAME=亡灵药剂师
//TEXT=<b>亡语：</b>为每个英雄恢复#4点生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=UNDEAD
    public override void Deathrattle()
    {
        TaskHealMyHero(4);
        TaskHealEnemyHero(4);
    }
}
public class CORE_CFM_605:MinionBase{
//NAME=龙人侦测者
//TEXT=<b>战吼：</b> 如果你的手牌中有龙牌，便<b>发现</b>你对手牌库中一张牌的复制。
//MAJ=PRIEST|COST=4|ATK=4|HP=5|RACE=DRAGON
    public override void Battlecry(Card target=null)
    {
        if(CondHoldAnotherRace(RaceType.Dragon))
        {
            Card ToCopy = owner.myPlayer.otherPlayer.deck.Choice(owner.myPlayer.randomGen);
            if(ToCopy!=null)
                TaskCreate(ToCopy.cardDbf,ZoneType.Hand);
        }
    }
}
public class CORE_CFM_606:MinionBase{
//NAME=法力晶簇
//TEXT=<b>过量治疗：</b>召唤一个2/2的水晶。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class CORE_CFM_751:MinionBase{
//NAME=渊狱惩击者
//TEXT=<b>战吼：</b>对所有其他角色造成3点伤害。
//MAJ=WARLOCK|COST=7|ATK=6|HP=6|RACE=DEMON
}
public class CORE_CFM_753:MinionBase{
//NAME=污手街供货商
//TEXT=<b>战吼：</b>使你手牌中的所有随从牌获得+1/+1。
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CORE_CFM_790:MinionBase{
//NAME=卑劣的脏鼠
//TEXT=<b>嘲讽，战吼：</b>使你的对手随机从手牌中召唤一个随从。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=6|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.hand)
        {
            if(c.cardType==CardType.Minion)
            {
                Pool.Add(c);
            }
        }
        Card ToMove = Pool.Choice(owner.myPlayer.randomGen);
        if(ToMove!=null)
        {
            new EffectMove(owner.myPlayer.otherPlayer,ToMove,ZoneType.Hand,ZoneType.Board).Resolve();
        }
    }
}
public class CORE_CS1_112:SpellBase{
//NAME=神圣新星
//TEXT=对所有敌方随从造成$2点伤害，为所有友方角色恢复#2点 生命值。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
         TaskDamageEnemyHero(1);
    }
}
public class CORE_CS1_130:SpellBase{
//NAME=神圣惩击
//TEXT=对一个随从造成$3点伤害。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
    }
}
public class Core_CS2_008:SpellBase{
//NAME=月火术
//TEXT=造成$1点伤害。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=ARCANE
}
public class CORE_CS2_009:SpellBase{
//NAME=野性印记
//TEXT=使一个随从获得<b>嘲讽</b>和+2/+3。<i>（+2攻击力/+3生命值）</i>
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class CORE_CS2_012:SpellBase{
//NAME=横扫
//TEXT=对一个敌人造成$4点伤害，并对所有其他敌人 造成$1点伤害。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class CORE_CS2_013:SpellBase{
//NAME=野性成长
//TEXT=获得一个空的法力水晶。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)==10)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("CS2_013t"),ZoneType.Hand);
        }
        else{
            owner.myPlayer.ChangeTag(GameTag.ManaThisTurn,1);
        }
    }
}
public class CORE_CS2_023:SpellBase{
//NAME=奥术智慧
//TEXT=抽两张牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
    public override void Battlecry(Card target=null)
    {
        //TaskDamageEnemyHero(1);
        TaskBuffMyHero(0);
        new EffectDraw(owner.myPlayer,owner).Resolve();
        new EffectDraw(owner.myPlayer,owner).Resolve();
        //if(owner.myPlayer.hero.Count>0)
        //    new EffectChange(owner.myPlayer,owner, owner.myPlayer.hero[0], armChange: 2).Resolve();
    }
}
public class CORE_CS2_024:SpellBase{
//NAME=寒冰箭
//TEXT=对一个角色造成$3点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FROST
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,target,"Frozen").Resolve();
    }
}
public class CORE_CS2_028:SpellBase{
//NAME=暴风雪
//TEXT=对所有敌方随从造成$2点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=6|ATK=0|HP=0|RACE=FROST
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,2);
    }
}
public class CORE_CS2_029:SpellBase{
//NAME=火球术
//TEXT=造成$6点伤害。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,6).Resolve();
    }
}
public class CORE_CS2_032:SpellBase{
//NAME=烈焰风暴
//TEXT=对所有敌方随从造成$5点伤害。
//MAJ=MAGE|COST=7|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,5);
    }
}
public class CORE_CS2_033:MinionBase{
//NAME=水元素
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=4|ATK=3|HP=6|RACE=ELEMENTAL
}
public class CORE_CS2_039:SpellBase{
//NAME=风怒
//TEXT=使一个随从获得<b>风怒</b>。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        new EffectGiveAbility(owner.myPlayer,owner,target,"WindFury").Resolve();
    }
}
public class CORE_CS2_039e:Ability{
//NAME=风怒
//TEXT=<b>风怒</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CORE_CS2_042:MinionBase{
//NAME=火元素
//TEXT=<b>战吼：</b>造成4点伤害。
//MAJ=SHAMAN|COST=6|ATK=6|HP=5|RACE=ELEMENTAL
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,4).Resolve();
    }
}
public class CORE_CS2_045:SpellBase{
//NAME=石化武器
//TEXT=在本回合中，使一个友方角色获得+3攻击力。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        target.ChangeTag(GameTag.AttackFot,3);
        new EffectChange(owner.myPlayer,owner,target).Resolve();
    }
}
public class CORE_CS2_046:SpellBase{
//NAME=嗜血
//TEXT=在本回合中，使你的所有随从获得+3攻击力。
//MAJ=SHAMAN|COST=5|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        foreach(Card c in owner.myPlayer.board)
        {
            c.ChangeTag(GameTag.AttackFot,3);
        }
        new EffectChange(owner.myPlayer,owner,owner).Resolve();
    }
}
public class CORE_CS2_053:SpellBase{
//NAME=视界术
//TEXT=抽一张牌，该牌的法力值消耗减少（3）点。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card Drawn=TaskDraw();
        if(Drawn!=null)
        {
            new EffectChange(owner.myPlayer,owner,Drawn,manaChange:-3).Resolve();
        }
    }
}
public class CORE_CS2_062:SpellBase{
//NAME=地狱烈焰
//TEXT=对所有角色造成$3点伤害。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(FindAllChar(),3);
    }
}
public class CORE_CS2_064:MinionBase{
//NAME=恐惧地狱火
//TEXT=<b>战吼：</b>对所有其他角色造成1点伤害。
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=DEMON
}
public class CORE_CS2_065:MinionBase{
//NAME=虚空行者
//TEXT=<b>嘲讽</b>
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=DEMON
}
public class CORE_CS2_072:SpellBase{
//NAME=背刺
//TEXT=对一个未受伤的随从造成$2点 伤害。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
    }
}
public class CORE_CS2_073:SpellBase{
//NAME=冷血
//TEXT=使一个随从获得+2攻击力；<b>连击：</b>改为获得+4攻击力。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)>0)
        {
            new EffectChange(owner.myPlayer,owner,target,atkChange:4).Resolve();
        }
        else{
            new EffectChange(owner.myPlayer,owner,target,atkChange:2).Resolve();
        }
    }
}
public class CORE_CS2_074:SpellBase{
//NAME=致命药膏
//TEXT=使你的武器获得+2攻击力。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class CORE_CS2_075:SpellBase{
//NAME=影袭
//TEXT=对敌方英雄造成$3点伤害。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target =null)
    {
        TaskDamageEnemyHero(3);
    }
}
public class CORE_CS2_076:SpellBase{
//NAME=刺杀
//TEXT=消灭一个敌方随从。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class CORE_CS2_077:SpellBase{
//NAME=疾跑
//TEXT=抽四张牌。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CORE_CS2_080:WeaponBase{
//NAME=刺客之刃
//TEXT=
//MAJ=ROGUE|COST=4|ATK=2|HP=5|RACE=NONE
}
public class CORE_CS2_088:MinionBase{
//NAME=列王守卫
//TEXT=<b>嘲讽</b>，<b>战吼：</b>为你的英雄恢复#6点生命值。
//MAJ=PALADIN|COST=7|ATK=5|HP=7|RACE=NONE
}
public class CORE_CS2_089:SpellBase{
//NAME=圣光术
//TEXT=为你的英雄恢复#8点生命值。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class CORE_CS2_092:SpellBase{
//NAME=王者祝福
//TEXT=使一个随从获得+4/+4。<i>（+4攻击力/+4生命值）</i>
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class CORE_CS2_093:SpellBase{
//NAME=奉献
//TEXT=对所有敌人造成$2点伤害。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),2);
    }
}
public class CORE_CS2_094:SpellBase{
//NAME=愤怒之锤
//TEXT=造成$3点伤害。抽一张牌。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        TaskDraw();
    }
}
public class CORE_CS2_097:WeaponBase{
//NAME=真银圣剑
//TEXT=每当你的英雄进攻，便为其恢复#3点生命值。
//MAJ=PALADIN|COST=4|ATK=4|HP=2|RACE=NONE
}
public class CORE_CS2_106:WeaponBase{
//NAME=炽炎战斧
//TEXT=
//MAJ=WARRIOR|COST=2|ATK=3|HP=2|RACE=NONE
}
public class CORE_CS2_108:SpellBase{
//NAME=斩杀
//TEXT=消灭一个受伤的敌方随从。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_CS2_117:MinionBase{
//NAME=大地之环先知
//TEXT=<b>战吼：</b> 恢复#3点生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class CORE_CS2_120:MinionBase{
//NAME=淡水鳄
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class CORE_CS2_122:MinionBase{
//NAME=团队领袖
//TEXT=你的其他随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class CORE_CS2_142:MinionBase{
//NAME=狗头人地卜师
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CORE_CS2_146:MinionBase{
//NAME=南海船工
//TEXT=如果你装备着武器，本随从拥有 <b>冲锋</b>。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=PIRATE
    public override void Battlecry(Card target = null)
    {
        base.Battlecry(target);
        if (owner.myPlayer.weapon.Count != 0)
        {
            new EffectGiveAbility(owner.myPlayer, owner, owner, "Charge").Resolve();
            new EffectChange(owner.myPlayer,owner,owner,visualFx:false).Resolve();
        }
    }
}
public class CORE_CS2_179:MinionBase{
//NAME=森金持盾卫士
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class CORE_CS2_181:MinionBase{
//NAME=负伤剑圣
//TEXT=<b>战吼：</b>对自身造成4点伤害。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=7|RACE=NONE
}
public class CORE_CS2_182:MinionBase{
//NAME=冰风雪人
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class CORE_CS2_188:MinionBase{
//NAME=叫嚣的中士
//TEXT=<b>战吼：</b>在本回合中，使一个随从获得+2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CORE_CS2_189:MinionBase{
//NAME=精灵弓箭手
//TEXT=<b>战吼：</b>造成1点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
    }
}
public class Core_CS2_200:MinionBase{
//NAME=石拳食人魔
//TEXT=
//MAJ=NEUTRAL|COST=6|ATK=6|HP=7|RACE=NONE
}
public class CORE_CS2_203:MinionBase{
//NAME=铁喙猫头鹰
//TEXT=<b>战吼：</b> <b>沉默</b>一个随从。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=1|RACE=BEAST
}
public class CORE_CS2_222:MinionBase{
//NAME=暴风城勇士
//TEXT=你的其他随从拥有+1/+1。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=NONE
}
public class CORE_CS2_234:SpellBase{
//NAME=暗言术：痛
//TEXT=消灭一个攻击力小于或等于3的随从。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_CS2_235:MinionBase{
//NAME=北郡牧师
//TEXT=每当一个随从获得治疗时，抽一张牌。
//MAJ=PRIEST|COST=1|ATK=1|HP=3|RACE=NONE
}
public class CORE_CS3_002:SpellBase{
//NAME=末日仪式
//TEXT=消灭一个友方随从。如果你拥有5个或更多随从，召唤一个5/5的恶魔。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_CS3_003:MinionBase{
//NAME=邪魂狱卒
//TEXT=<b>战吼：</b>使你的对手弃掉一张随从牌。<b>亡语：</b>移回弃掉的牌。
//MAJ=WARLOCK|COST=5|ATK=4|HP=6|RACE=DEMON
}
public class CORE_CS3_005:MinionBase{
//NAME=梵妮莎·范克里夫
//TEXT=<b>连击：</b>将你对手使用的上一张牌的一张复制置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=2|HP=3|RACE=NONE
}
public class CORE_CS3_008:MinionBase{
//NAME=血帆桨手
//TEXT=<b>战吼：</b>你的下一张武器牌的法力值消耗减少（1）点。
//MAJ=WARRIOR|COST=1|ATK=2|HP=1|RACE=PIRATE
}
public class CORE_CS3_009:SpellBase{
//NAME=战争储备箱
//TEXT=随机将一张战士随从牌，法术牌和武器牌分别置入你的 手牌。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class CORE_CS3_012:MinionBase{
//NAME=诺达希尔德鲁伊
//TEXT=<b>战吼：</b>在本回合中，你施放的下一个法术的法力值消耗减少（3）点。
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=NONE
}
public class CORE_CS3_014:MinionBase{
//NAME=赤红教士
//TEXT=<b>过量治疗：</b>抽一张牌。
//MAJ=PRIEST|COST=1|ATK=1|HP=3|RACE=NONE
}
public class CORE_CS3_016:SecretBase{
//NAME=清算
//TEXT=<b>奥秘：</b>在一个敌方随从造成3点或以上伤害后，将其消灭。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class CORE_CS3_019:MinionBase{
//NAME=考瓦斯·血棘
//TEXT=<b>冲锋</b>，<b>吸血</b> 在你使用一张<b>流放</b>牌后，将本随从移回你的手牌。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CORE_CS3_021:MinionBase{
//NAME=被奴役的邪能领主
//TEXT=<b>嘲讽</b> 同时对其攻击目标相邻的随从造成伤害。
//MAJ=WARLOCK|COST=7|ATK=4|HP=10|RACE=DEMON
}
public class CORE_CS3_027:SpellBase{
//NAME=专注意志
//TEXT=<b>沉默</b>一个随从，然后使其获得+3生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_CS3_029:SpellBase{
//NAME=正义追击
//TEXT=使你本局对战中召唤的白银之手新兵获得+1攻击力。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class CORE_CS3_030:MinionBase{
//NAME=战歌侦察骑兵
//TEXT=<b>突袭</b>
//MAJ=WARRIOR|COST=4|ATK=5|HP=4|RACE=NONE
}
public class CORE_DAL_086:MinionBase{
//NAME=夺日者间谍
//TEXT=<b>战吼：</b>如果你控制一个<b>奥秘</b>，便获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class CORE_DAL_371:SpellBase{
//NAME=标记射击
//TEXT=对一个随从造成$4点伤害。<b>发现</b>一张法术牌。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class CORE_DAL_416:MinionBase{
//NAME=荆棘帮蟊贼
//TEXT=<b>战吼：</b><b>发现</b>一张另一职业的法术牌。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=PIRATE
}
public class CORE_DAL_422:MinionBase{
//NAME=至尊盗王拉法姆
//TEXT=<b>嘲讽</b> <b>战吼：</b>将你的手牌和牌库里的卡牌替换为<b>传说</b>随从。
//MAJ=WARLOCK|COST=7|ATK=7|HP=8|RACE=NONE
}
public class CORE_DAL_609:MinionBase{
//NAME=卡雷苟斯
//TEXT=你每个回合使用的第一张法术牌的法力值消耗为（0）点。<b>战吼：</b><b>发现</b>一张法术牌。
//MAJ=MAGE|COST=8|ATK=4|HP=12|RACE=DRAGON
}
public class CORE_DAL_721:MinionBase{
//NAME=亡者卡特琳娜
//TEXT=在你的回合结束时，复活另一个友方亡灵随从。
//MAJ=PRIEST|COST=7|ATK=6|HP=8|RACE=UNDEAD
}
public class CORE_DAL_729:MinionBase{
//NAME=拉祖尔女士
//TEXT=<b>战吼：</b><b>发现</b>一张你的对手手牌的复制。
//MAJ=PRIEST|COST=3|ATK=3|HP=2|RACE=NONE
}
public class CORE_DED_009:SpellBase{
//NAME=狗狗饼干
//TEXT=<b>可交易</b> 使一个随从获得+2/+3。在你<b>交易</b>此牌后，使一个友方随从获得<b>突袭</b>。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_DMF_057:SpellBase{
//NAME=月蚀
//TEXT=对一个随从造成$3点伤害。在本回合中，你施放的下一个法术的法力值消耗减少（2）点。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class CORE_DMF_058:SpellBase{
//NAME=日蚀
//TEXT=在本回合中，你施放的下一个法术将施放两次。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class CORE_DMF_060:MinionBase{
//NAME=幽影猫头鹰
//TEXT=<b>突袭</b> 在本局对战中，你每施放一个法术，本牌的法力值消耗便减少（1）点。
//MAJ=DRUID|COST=7|ATK=4|HP=4|RACE=BEAST
}
public class CORE_DMF_224:SpellBase{
//NAME=演员大接力
//TEXT=召唤七个1/1并具有<b>突袭</b>的伊利达雷。在本回合中，如果他们全部死亡，再召唤七个。
//MAJ=DEMONHUNTER|COST=7|ATK=0|HP=0|RACE=NONE
    private bool Act=false;
    private int Cnt=0;
    private int Cnt2=0;
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
        for(int i=0;i<7;i++)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("BT_036t"),ZoneType.Board);
            Cnt2+=1;
        }
        Act=true;
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(Act)
        {
            if(sc.cardDbf.m_noteMiniGuid=="BT_036t")
            {
                Cnt+=1;
                if(Cnt==Cnt2)
                {
                    for(int i=0;i<7;i++)
                    {
                        TaskCreate(CardDbf.GetCardDbfByGuid("BT_036t"),ZoneType.Board);
                    }
                    Act=false;  
                }
            }
        }
    }
}
public class CORE_DMF_238:WeaponBase{
//NAME=纳鲁之锤
//TEXT=<b>战吼：</b>召唤一个6/6并具有<b>嘲讽</b>的神圣元素。
//MAJ=PALADIN|COST=6|ATK=3|HP=3|RACE=NONE
}
public class CORE_DMF_240:MinionBase{
//NAME=救赎者洛萨克森
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，在你召唤一个白银之手新兵后，使其获得<b>圣盾</b>。
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=DEMON
    public override void UnRegisterEventEffect()
    {
    }
    public override void Battlecry(Card target=null)
    {
        List<Card> targets = new List<Card>();
        List<int> Buffs = new List<int>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.raceType.Contains(RaceType.Totem))
            {
                targets.Add(c);
                Buffs.Add(2);
            }
        }
        new EffectChange(owner.myPlayer,owner,targets:targets,atkChanges:Buffs).Resolve();
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc, ZoneType sz, ZoneType tz)
    {
        if(tz==ZoneType.Board && (sc.cardDbf.m_noteMiniGuid.Contains("CS2_101t")))
        {
            new EffectGiveAbility(owner.myPlayer,owner,sc,"DivineShield").Resolve();
        }
    }
}
public class CORE_DMF_521:MinionBase{
//NAME=吞剑艺人
//TEXT=<b>嘲讽，战吼：</b>装备一把3/2的剑。
//MAJ=WARRIOR|COST=4|ATK=2|HP=5|RACE=PIRATE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("DMF_521t"),ZoneType.Weapon);
    }
}
public class CORE_DMF_522:SpellBase{
//NAME=雷区挑战
//TEXT=造成$5点伤害，随机分配到所有随从身上。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageRandomDistributeTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),5);
    }
}
public class CORE_DMF_709:MinionBase{
//NAME=巨型图腾埃索尔
//TEXT=在你的回合结束时，使你手牌，牌库和战场上的所有其他图腾获得+1/+1。
//MAJ=SHAMAN|COST=3|ATK=0|HP=4|RACE=TOTEM
}
public class CORE_DMF_733:MinionBase{
//NAME=基利，艾露恩之眷
//TEXT=<b>战吼：</b> 将一张日蚀和一张月蚀置入你的手牌。
//MAJ=DRUID|COST=3|ATK=2|HP=2|RACE=NONE
}
public class CORE_DMF_734:MinionBase{
//NAME=格雷布
//TEXT=<b>嘲讽</b>，<b>亡语：</b>随机使一个友方随从获得“<b>亡语：</b>召唤格雷布。”
//MAJ=DRUID|COST=5|ATK=4|HP=6|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        Card ToBuff = owner.myPlayer.board.Choice(owner.myPlayer.randomGen);
        if(ToBuff!=null)
        {
            new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"DMF_734e").Resolve();
        }
    }
}
public class CORE_DRG_026:MinionBase{
//NAME=疯狂巨龙死亡之翼
//TEXT=<b>战吼：</b>攻击所有其他随从。
//MAJ=WARRIOR|COST=8|ATK=12|HP=12|RACE=DRAGON
    public override void Battlecry(Card target =null)
    {
        List<Card> ToListAttack = new List<Card>();
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Exclude(owner))
        {
            ToListAttack.Add(c);
        }
        foreach(Card c in ToListAttack)
        {
            if(CondInPlay())
                new EffectAttack(owner.myPlayer,owner,c).Resolve();
        }
    }
}
public class CORE_DRG_037:MinionBase{
//NAME=菲里克·飞刺
//TEXT=<b>战吼：</b>消灭一个随从及其所有的复制<i>（无论它们在哪）</i>。
//MAJ=ROGUE|COST=6|ATK=4|HP=4|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
        List<Card> ToListDestroy = new List<Card>();
        Player op = owner.myPlayer.otherPlayer;
        Player p =owner.myPlayer;
        foreach(Card c in op.deck.Merge(op.hand).Merge(op.board).Merge(p.deck).Merge(p.hand).Merge(p.board))
        {
            if(c.cardDbf==target.cardDbf)
            {
                ToListDestroy.Add(c);
            }
        }
        TaskDestroyTargets(ToListDestroy);
    }
}
public class CORE_DRG_079:MinionBase{
//NAME=辟法巨龙
//TEXT=<b>突袭</b>。<b>圣盾</b>。<b>扰魔</b>
//MAJ=NEUTRAL|COST=6|ATK=5|HP=3|RACE=DRAGON
}
public class CORE_DRG_090:MinionBase{
//NAME=永恒巨龙姆诺兹多
//TEXT=<b>战吼：</b>使用你的对手上个回合使用的所有卡牌。
//MAJ=PRIEST|COST=8|ATK=8|HP=8|RACE=DRAGON
}
public class CORE_DRG_226:MinionBase{
//NAME=琥珀看守者
//TEXT=<b>战吼：</b> 恢复#8点生命值。
//MAJ=PALADIN|COST=5|ATK=4|HP=6|RACE=DRAGON
}
public class CORE_DRG_229:MinionBase{
//NAME=青铜龙探险者
//TEXT=<b>吸血</b> <b>战吼：</b><b>发现</b>一张 龙牌。
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=DRAGON
}
public class CORE_DRG_256:MinionBase{
//NAME=灭龙弩炮
//TEXT=在你使用你的英雄技能后，随机对一个敌人造成5点伤害。
//MAJ=HUNTER|COST=4|ATK=3|HP=5|RACE=MECHANICAL
}
public class CORE_DS1_184:SpellBase{
//NAME=追踪术
//TEXT=从你的牌库中<b>发现</b>一张牌。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_DS1_185:SpellBase{
//NAME=奥术射击
//TEXT=造成$2点伤害。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=ARCANE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
    }
}
public class CORE_EX1_002:MinionBase{
//NAME=黑骑士
//TEXT=<b>战吼：</b>消灭一个具有<b>嘲讽</b>的敌方随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class CORE_EX1_004:MinionBase{
//NAME=年轻的女祭司
//TEXT=在你的回合结束时，随机使另一个友方随从获得+1生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class CORE_EX1_005:MinionBase{
//NAME=王牌猎人
//TEXT=<b>可交易</b> <b>战吼：</b>消灭一个攻击力大于或等于7的随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=NONE
}
public class CORE_EX1_007:MinionBase{
//NAME=苦痛侍僧
//TEXT=每当本随从受到伤害，抽一张牌。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=NONE
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
        if(amount>0)
            TaskDraw();
    }
}
public class CORE_EX1_008:MinionBase{
//NAME=银色侍从
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CORE_EX1_010:MinionBase{
//NAME=狼人渗透者
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class CORE_EX1_011:MinionBase{
//NAME=巫医
//TEXT=<b>战吼：</b> 恢复#2点生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class CORE_EX1_012:MinionBase{
//NAME=血法师萨尔诺斯
//TEXT=<b>法术伤害+1</b>，<b>亡语：</b>抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=UNDEAD
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTakeDamage(this,this.CauseEvent));
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterTakeDamage(this,this.CauseEvent));
    }
    public void CauseEvent(Card source,Card target, int amount)
    {
        if(CondInPlay())
        {
            if(source.cardType==CardType.Spell || source.cardType==CardType.Secret)
            {
                new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
            }
        }
    }
    public override void Deathrattle()
    {
        TaskDraw();
    }
}
public class CORE_EX1_014:MinionBase{
//NAME=穆克拉
//TEXT=<b>战吼：</b>使你的对手获得两根香蕉。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=5|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        CardDbf bana=CardDbf.GetCardDbfByGuid("EX1_014t");
        TaskCreate(bana,ZoneType.Hand,true);
        TaskCreate(bana,ZoneType.Hand,true);
    }
}
public class CORE_EX1_016:MinionBase{
//NAME=希尔瓦娜斯·风行者
//TEXT=<b>亡语：</b>随机夺取一个敌方随从的控制权。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=UNDEAD
    public override void Deathrattle()
    {
        Card ToSteal = owner.myPlayer.otherPlayer.board.Choice(owner.myPlayer.randomGen);
        if(ToSteal!=null)
        {
            new EffectMove(owner.myPlayer.otherPlayer,ToSteal,ZoneType.Board,ZoneType.Board,toEn:true).Resolve();
        }
    }
}
public class CORE_EX1_017:MinionBase{
//NAME=丛林猎豹
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class CORE_EX1_028:MinionBase{
//NAME=荆棘谷猛虎
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class CORE_EX1_043:MinionBase{
//NAME=暮光幼龙
//TEXT=<b>战吼：</b> 你每有一张手牌，便获得+1生命值。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=1|RACE=DRAGON
    public override void Battlecry(Card target =null)
    {
        int Num=owner.myPlayer.hand.Count;
        new EffectChange(owner.myPlayer,owner,owner,hpChange:Num).Resolve();
    }
}
public class CORE_EX1_046:MinionBase{
//NAME=黑铁矮人
//TEXT=<b>战吼：</b>在本回合中，使一个随从获得+2攻击力。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class CORE_EX1_049:MinionBase{
//NAME=年轻的酒仙
//TEXT=<b>战吼：</b>使一个友方随从从战场上移回你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class CORE_EX1_050:MinionBase{
//NAME=寒光智者
//TEXT=<b>战吼：</b>每个玩家抽两张牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=MURLOC
}
public class CORE_EX1_059:MinionBase{
//NAME=疯狂的炼金师
//TEXT=<b>战吼：</b> 使一个随从的攻击力和生命值互换。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
    public override void Battlecry(Card target=null)
    {
        int atk = target.GetTag(GameTag.Attack);
        int hp = target.GetTag(GameTag.Health);
        new EffectChange(owner.myPlayer,owner,target,atkChange:hp-atk,hpChange:atk-hp).Resolve();
    }
}
public class CORE_EX1_066:MinionBase{
//NAME=酸性沼泽软泥怪
//TEXT=<b>战吼：</b> 摧毁对手的武器。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class CORE_EX1_082:MinionBase{
//NAME=疯狂投弹者
//TEXT=<b>战吼：</b>造成3点伤害，随机分配到所有其他角色身上。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class CORE_EX1_084:MinionBase{
//NAME=战歌指挥官
//TEXT=每当你召唤一个攻击力小于或等于3的随从，使其获得<b>冲锋</b>。
//MAJ=WARRIOR|COST=3|ATK=2|HP=3|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay() && tz==ZoneType.Board)
        {
            if(sc!=owner)
            {
                if(sc.cardType==CardType.Minion)
                {
                    if(sc.GetTag(GameTag.Attack)<=3)
                    {
                        new EffectGiveAbility(owner.myPlayer,owner,sc,"Charge").Resolve();
                    }
                }
            }
        }
    }
}
public class CORE_EX1_085:MinionBase{
//NAME=精神控制技师
//TEXT=<b>战吼：</b>如果你的对手有4个或者更多随从，夺取其中一个的控制权。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class CORE_EX1_093:MinionBase{
//NAME=阿古斯防御者
//TEXT=<b>战吼：</b>使相邻的随从获得+1/+1和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class CORE_EX1_095:MinionBase{
//NAME=加基森拍卖师
//TEXT=每当你施放一个法术，抽一张牌。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=4|RACE=NONE
}
public class CORE_EX1_096:MinionBase{
//NAME=战利品贮藏者
//TEXT=<b>亡语：</b>抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class CORE_EX1_103:MinionBase{
//NAME=寒光先知
//TEXT=<b>战吼：</b>使你的其他鱼人获得+2生命值。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=MURLOC
}
public class CORE_EX1_105:MinionBase{
//NAME=山岭巨人
//TEXT=你每有一张其他手牌，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=12|ATK=8|HP=8|RACE=ELEMENTAL
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
            {
                return -owner.myPlayer.hand.Count+1;
            }   
        }
        return 0;
    }
}
public class CORE_EX1_110:MinionBase{
//NAME=凯恩·血蹄
//TEXT=<b>亡语：</b>召唤一个5/5的贝恩·血蹄。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("EX1_110t"),ZoneType.Board);
    }
}
public class CORE_EX1_116:MinionBase{
//NAME=火车王里诺艾
//TEXT=<b>冲锋</b>，<b>战吼：</b> 为你的对手召唤两条1/1的雏龙。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=2|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("EX1_116t");
        TaskCreate(ToSummon,ZoneType.Board,true);
        TaskCreate(ToSummon,ZoneType.Board,true);
    }
}
public class CORE_EX1_124:SpellBase{
//NAME=刺骨
//TEXT=造成$2点伤害。<b>连击：</b>改为造成$4点伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_EX1_129:SpellBase{
//NAME=刀扇
//TEXT=对所有敌方随从造成$1点伤害，抽一张牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_EX1_130:SecretBase{
//NAME=崇高牺牲
//TEXT=<b>奥秘：</b>当一个敌人攻击时，召唤一个2/1的防御者，并使其成为攻击的目标。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_EX1_134:MinionBase{
//NAME=军情七处特工
//TEXT=<b>连击：</b>造成2点伤害。
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class CORE_EX1_144:SpellBase{
//NAME=暗影步
//TEXT=将一个友方随从移回你的手牌，它的法力值消耗减少 （2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        new EffectMove(owner.myPlayer,target,ZoneType.Board,ZoneType.Hand).Resolve();
        new EffectChange(owner.myPlayer,owner,target,manaChange:-2).Resolve();
    }
}
public class CORE_EX1_145:SpellBase{
//NAME=伺机待发
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
    private bool on = false;
    public override void Battlecry(Card target = null)
    {

        base.Battlecry(target);
        on = true;
        foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
        {
            if (c.cardType == CardType.Spell)
            {
                new EffectChange(owner.myPlayer,owner, c, -2, 0, 0, 0).Resolve();
            }
        }

    }
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,EX1_145CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void EX1_145CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if (sc.cardType == CardType.Spell && on && sc!=owner)
        {
            foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
            {
                if (c.cardType == CardType.Spell)
                {
                    new EffectChange(owner.myPlayer,owner, c, 2, 0, 0, 0).Resolve();
                }
            }
            on = false;
        }
    }
}
public class CORE_EX1_154:SpellBase{
//NAME=愤怒
//TEXT=<b>抉择：</b> 对一个随从造成$3点伤害；或者造成$1点伤害并抽一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        new EffectDraw(owner.myPlayer).Resolve();
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
    }
}
public class CORE_EX1_158:SpellBase{
//NAME=丛林之魂
//TEXT=使你的所有随从获得“<b>亡语：</b>召唤一个2/2的树人”。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class CORE_EX1_160:SpellBase{
//NAME=野性之力
//TEXT=<b>抉择：</b>使你的所有随从获得+1/+1；或者召唤一只3/2的 猎豹。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_EX1_162:MinionBase{
//NAME=恐狼前锋
//TEXT=相邻的随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class CORE_EX1_164:SpellBase{
//NAME=滋养
//TEXT=<b>抉择：</b>获得两个法力水晶；或者抽三张牌。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        if(target.myPlayer==owner.myPlayer)
        {
            TaskDraw();
            TaskDraw();
            TaskDraw();
        }
        else{
            owner.myPlayer.ChangeTag(GameTag.ManaThisTurn,2);
            owner.myPlayer.ChangeTag(GameTag.ManaLeft,2);
        }
    }
}
public class CORE_EX1_165:MinionBase{
//NAME=利爪德鲁伊
//TEXT=<b>抉择：</b>变形成为7/6并具有<b>突袭</b>；或者变形成为4/9并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=6|ATK=4|HP=6|RACE=NONE
}
public class CORE_EX1_169:SpellBase{
//NAME=激活
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class CORE_EX1_178:MinionBase{
//NAME=战争古树
//TEXT=<b>抉择：</b> +5攻击力；或者+5生命值并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=7|ATK=5|HP=5|RACE=NONE
}
public class CORE_EX1_186:MinionBase{
//NAME=军情七处渗透者
//TEXT=<b>战吼：</b>随机摧毁一个敌方<b>奥秘</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=NONE
}
public class CORE_EX1_187:MinionBase{
//NAME=奥术吞噬者
//TEXT=每当你施放一个法术，便获得+2/+2。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=8|RACE=ELEMENTAL
}
public class CORE_EX1_188:MinionBase{
//NAME=贫瘠之地饲养员
//TEXT=<b>战吼：</b>随机召唤一只野兽。
//MAJ=NEUTRAL|COST=7|ATK=5|HP=5|RACE=NONE
}
public class CORE_EX1_189:MinionBase{
//NAME=光明之翼
//TEXT=<b>战吼：</b>随机将一张<b>传说</b>随从牌置入你的 手牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=DRAGON
}
public class CORE_EX1_190:MinionBase{
//NAME=大检察官怀特迈恩
//TEXT=<b>战吼：</b>召唤所有在本回合中死亡的友方 随从。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=7|RACE=NONE
}
public class CORE_EX1_193:MinionBase{
//NAME=心灵咒术师
//TEXT=<b>战吼：</b>复制你对手的牌库中的一张牌，并将其置入你的手牌。
//MAJ=PRIEST|COST=1|ATK=1|HP=2|RACE=UNDEAD
}
public class CORE_EX1_194:SpellBase{
//NAME=能量灌注
//TEXT=使一个随从获得+2/+6。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class CORE_EX1_195:MinionBase{
//NAME=库尔提拉斯教士
//TEXT=<b>战吼：</b>使一个友方随从获得+2生命值。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=NONE
}
public class CORE_EX1_197:SpellBase{
//NAME=暗言术：毁
//TEXT=消灭所有攻击力大于或等于5的随从。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_EX1_198:MinionBase{
//NAME=娜塔莉·塞林
//TEXT=<b>战吼：</b>消灭一个随从并获得其生命值。
//MAJ=PRIEST|COST=8|ATK=8|HP=1|RACE=NONE
}
public class CORE_EX1_238:SpellBase{
//NAME=闪电箭
//TEXT=造成$3点伤害，<b>过载：</b>（1）
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
    }
}
public class CORE_EX1_246:SpellBase{
//NAME=妖术
//TEXT=使一个随从变形成为一只0/1并具有<b>嘲讽</b>的青蛙。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class CORE_EX1_248:SpellBase{
//NAME=野性狼魂
//TEXT=召唤两只2/3并具有<b>嘲讽</b>的幽灵狼。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("VAN_EX1_tk11");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
    }
}
public class CORE_EX1_249:MinionBase{
//NAME=迦顿男爵
//TEXT=在你的回合结束时，对所有其他角色造成2点伤害。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=ELEMENTAL
}
public class CORE_EX1_250:MinionBase{
//NAME=土元素
//TEXT=<b>嘲讽</b>，<b>过载：</b>（2）
//MAJ=SHAMAN|COST=5|ATK=7|HP=8|RACE=ELEMENTAL
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,2);
    }
}
public class CORE_EX1_258:MinionBase{
//NAME=无羁元素
//TEXT=在你使用一张具有<b>过载</b>的牌后，便获得+1/+1。
//MAJ=SHAMAN|COST=3|ATK=3|HP=4|RACE=ELEMENTAL
}
public class CORE_EX1_259:SpellBase{
//NAME=闪电风暴
//TEXT=对所有敌方随从造成$3点伤害，<b>过载：</b>（1）
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,3);
    }
}
public class CORE_EX1_275:SpellBase{
//NAME=冰锥术
//TEXT=<b>冻结</b>一个随从和其相邻的随从，并对它们造成$1点伤害。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class CORE_EX1_279:SpellBase{
//NAME=炎爆术
//TEXT=造成$10点伤害。
//MAJ=MAGE|COST=10|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,10).Resolve();
    }
}
public class CORE_EX1_284:MinionBase{
//NAME=碧蓝幼龙
//TEXT=<b>法术伤害+1</b>，<b>战吼：</b>抽一张牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=DRAGON
}
public class CORE_EX1_287:SecretBase{
//NAME=法术反制
//TEXT=<b>奥秘：</b>当你的对手施放一个法术时，<b>反制</b>该法术。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterPlay(this,EX1_287CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
    }
    public void EX1_287CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Head && sc.cardType == CardType.Spell)
        {
            new EffectMove(owner.myPlayer, owner, ZoneType.Head, ZoneType.Grave).Resolve();
            sc.SetTag(GameTag.IsCanceled,1);
        }
    }
}
public class CORE_EX1_289:SecretBase{
//NAME=寒冰护体
//TEXT=<b>奥秘：</b>当你的英雄受到攻击时，获得8点护甲值。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class CORE_EX1_294:SecretBase{
//NAME=镜像实体
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，召唤一个该随从的复制。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterPlay(this,EX1_609CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
    }
    public void EX1_609CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Head && sc.cardType == CardType.Minion)
        {
            new EffectMove(owner.myPlayer, owner, ZoneType.Head, ZoneType.Grave).Resolve();
            TaskCreate(sc.cardDbf,ZoneType.Board);
        }
    }
}
public class CORE_EX1_298:MinionBase{
//NAME=炎魔之王拉格纳罗斯
//TEXT=无法攻击。在你的回合结束时，随机对一个敌人造成8点伤害。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=ELEMENTAL
    public override void Init()
    {
        owner.SetTag(GameTag.AttacksForOneTurn,0);
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
            TaskDamageRandomEnemy(8);
    }

}
public class CORE_EX1_302:SpellBase{
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
public class CORE_EX1_304:MinionBase{
//NAME=虚空恐魔
//TEXT=<b>战吼：</b>消灭两侧相邻的随从，并获得他们的攻击力和生命值。
//MAJ=WARLOCK|COST=3|ATK=3|HP=4|RACE=DEMON
}
public class CORE_EX1_309:SpellBase{
//NAME=灵魂虹吸
//TEXT=消灭一个随从，为你的英雄恢复#3点生命值。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_EX1_310:MinionBase{
//NAME=末日守卫
//TEXT=<b>冲锋</b>，<b>战吼：</b>随机弃两张牌。
//MAJ=WARLOCK|COST=5|ATK=5|HP=7|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
    public override void Battlecry(Card target=null)
    {
        TaskRandomDiscard();
        TaskRandomDiscard();
    }
}
public class CORE_EX1_312:SpellBase{
//NAME=扭曲虚空
//TEXT=消灭所有随从和地标。
//MAJ=WARLOCK|COST=8|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        TaskDestroyTargets(FindAllMin());
    }
}
public class CORE_EX1_316:SpellBase{
//NAME=力量的代价
//TEXT=使一个友方随从获得+4/+4，该随从会在回合结束时死亡。死得很惨。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_EX1_319:MinionBase{
//NAME=烈焰小鬼
//TEXT=<b>战吼：</b>对你的英雄造成3点伤害。
//MAJ=WARLOCK|COST=1|ATK=3|HP=2|RACE=DEMON
    public override void Battlecry(Card target=null)
    {
        TaskDamageMyHero(3);
    }
}
public class CORE_EX1_323:HeroBase{
//NAME=加拉克苏斯大王
//TEXT=<b>战吼：</b>装备一把3/8的血怒。
//MAJ=WARLOCK|COST=8|ATK=0|HP=30|RACE=NONE
}
public class CORE_EX1_335:MinionBase{
//NAME=光耀之子
//TEXT=本随从的攻击力始终等同于其生命值。
//MAJ=PRIEST|COST=3|ATK=0|HP=4|RACE=ELEMENTAL
}
public class CORE_EX1_362:MinionBase{
//NAME=银色保卫者
//TEXT=<b>战吼：</b>使一个其他友方随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class CORE_EX1_382:MinionBase{
//NAME=奥尔多卫士
//TEXT=<b>战吼：</b>使一个敌方随从的攻击力变为1。
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,atkChange:1-target.GetTag(GameTag.Attack)).Resolve();
    }
}
public class CORE_EX1_383:MinionBase{
//NAME=提里奥·弗丁
//TEXT=<b>圣盾</b>，<b>嘲讽</b>，<b>亡语：</b>装备一把5/3的 灰烬使者。
//MAJ=PALADIN|COST=8|ATK=8|HP=8|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("DivineShield");
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("EX1_383t"),ZoneType.Weapon);
    }
}
public class CORE_EX1_391:SpellBase{
//NAME=猛击
//TEXT=对一个随从造成$2点伤害，如果 它依然存活，则抽一张牌。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_EX1_399:MinionBase{
//NAME=古拉巴什狂暴者
//TEXT=每当本随从受到伤害，获得+3攻击力。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=8|RACE=NONE
}
public class CORE_EX1_400:SpellBase{
//NAME=旋风斩
//TEXT=对所有随从造成$1点伤害。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
    }
}
public class CORE_EX1_402:MinionBase{
//NAME=铸甲师
//TEXT=每当一个友方随从受到伤害，便获得1点护甲值。
//MAJ=WARRIOR|COST=2|ATK=1|HP=4|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTakeDamage(this,this.CauseEvent));
    }
    public void CauseEvent(Card source,Card target, int amount)
    {
        if(CondInPlay())
        {
            if(amount>0)
            {
                TaskBuffMyHero(arm:1);
            }
        }
    }
}
public class CORE_EX1_407:SpellBase{
//NAME=绝命乱斗
//TEXT=随机选择一个随从，消灭除了该随从外的所有其他随从。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> ToListDestroy = new List<Card>();
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
        {
            ToListDestroy.Add(c);
        }
        Card ToSpare = ToListDestroy.Choice(owner.myPlayer.randomGen);
        if(ToSpare!=null)
        {
            ToListDestroy.Remove(ToSpare);
        }
        TaskDestroyTargets(ToListDestroy);
    }
}
public class CORE_EX1_410:SpellBase{
//NAME=盾牌猛击
//TEXT=你每有1点护甲值，便对一个随从造成1点伤害。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_EX1_411:WeaponBase{
//NAME=血吼
//TEXT=攻击随从不会消耗耐久度，改为降低1点攻击力。
//MAJ=WARRIOR|COST=7|ATK=7|HP=1|RACE=NONE
}
public class CORE_EX1_414:MinionBase{
//NAME=格罗玛什·地狱咆哮
//TEXT=<b>冲锋</b> 受伤时拥有+6攻 击力。
//MAJ=WARRIOR|COST=8|ATK=4|HP=9|RACE=NONE
}
public class CORE_EX1_506:MinionBase{
//NAME=鱼人猎潮者
//TEXT=<b>战吼：</b>召唤一个1/1的鱼人斥候。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=MURLOC
}
public class CORE_EX1_506a:MinionBase{
//NAME=鱼人斥候
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class CORE_EX1_507:MinionBase{
//NAME=鱼人领军
//TEXT=你的其他鱼人拥有+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MURLOC
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Murloc) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "EX1_507e";
    }
}
public class CORE_EX1_509:MinionBase{
//NAME=鱼人招潮者
//TEXT=每当你召唤一个鱼人，便获得 +1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=MURLOC
}
public class CORE_EX1_522:MinionBase{
//NAME=耐心的刺客
//TEXT=<b>潜行</b> <b>剧毒</b>
//MAJ=ROGUE|COST=2|ATK=1|HP=2|RACE=NONE
}
public class CORE_EX1_531:MinionBase{
//NAME=食腐土狼
//TEXT=每当一个友方野兽死亡，便获得+2/+1。
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class CORE_EX1_534:MinionBase{
//NAME=长鬃草原狮
//TEXT=<b>亡语：</b>召唤两只2/2的土狼。
//MAJ=HUNTER|COST=6|ATK=7|HP=5|RACE=BEAST
    public override void Deathrattle()
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("EX1_534t");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class CORE_EX1_539:SpellBase{
//NAME=杀戮命令
//TEXT=造成$3点伤害。如果你控制一个野兽，则改为造成 $5点伤害。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int dmg=3;
        if(CondCtrlAnotherRace(RaceType.Beast))
        {
            dmg=5;
        }
        new EffectDamage(owner.myPlayer,owner,target,dmg).Resolve();
    }
}
public class CORE_EX1_543:MinionBase{
//NAME=暴龙王克鲁什
//TEXT=<b>冲锋</b>
//MAJ=HUNTER|COST=9|ATK=8|HP=8|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class CORE_EX1_554:SecretBase{
//NAME=毒蛇陷阱
//TEXT=<b>奥秘：</b>当你的随从受到攻击时，召唤三条1/1的蛇。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_EX1_564:MinionBase{
//NAME=无面操纵者
//TEXT=<b>战吼：</b>选择一个随从，成为它的复制。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class CORE_EX1_565:MinionBase{
//NAME=火舌图腾
//TEXT=相邻的随从拥有+2攻击力。
//MAJ=SHAMAN|COST=2|ATK=0|HP=3|RACE=TOTEM
}
public class CORE_EX1_567:WeaponBase{
//NAME=毁灭之锤
//TEXT=<b>风怒，过载：</b>（2）
//MAJ=SHAMAN|COST=5|ATK=2|HP=8|RACE=NONE
}
public class CORE_EX1_571:SpellBase{
//NAME=自然之力
//TEXT=召唤三个2/2的树人。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class CORE_EX1_573:MinionBase{
//NAME=塞纳留斯
//TEXT=<b>抉择：</b>使你的所有其他随从获得+2/+2；或者召唤两个2/2并具有<b>嘲讽</b>的树人。
//MAJ=DRUID|COST=8|ATK=5|HP=8|RACE=NONE
}
public class CORE_EX1_575:MinionBase{
//NAME=法力之潮图腾
//TEXT=在你的回合结束时，抽一张牌。
//MAJ=SHAMAN|COST=3|ATK=0|HP=3|RACE=TOTEM
}
public class CORE_EX1_581:SpellBase{
//NAME=闷棍
//TEXT=将一个敌方随从移回你对手的 手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_EX1_586:MinionBase{
//NAME=海巨人
//TEXT=战场上每有一个其他随从，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=10|ATK=8|HP=8|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
            {
                return -owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Count;
            }
        }
        return 0;
    }
}
public class CORE_EX1_603:MinionBase{
//NAME=严酷的监工
//TEXT=<b>战吼：</b>对一个随从造成1点伤害，并使其获得+2攻击力。
//MAJ=WARRIOR|COST=2|ATK=2|HP=3|RACE=NONE
}
public class CORE_EX1_604:MinionBase{
//NAME=暴乱狂战士
//TEXT=每当一个随从 受到伤害，便获得+1攻击力。
//MAJ=WARRIOR|COST=3|ATK=2|HP=4|RACE=NONE
}
public class CORE_EX1_606:SpellBase{
//NAME=盾牌格挡
//TEXT=获得5点护甲值。抽一张牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskBuffMyHero(arm:5);
        TaskDraw();
    }
}
public class CORE_EX1_610:SecretBase{
//NAME=爆炸陷阱
//TEXT=<b>奥秘：</b>当你的英雄受到攻击，对所有敌人造成$2点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class CORE_EX1_611:SecretBase{
//NAME=冰冻陷阱
//TEXT=<b>奥秘：</b>当一个敌方随从攻击时，将其移回拥有者的手牌，并且法力值消耗增加（2）点。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=FROST
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackBeforeAttack(this,EX1_611CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
    }
    public void EX1_611CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Head && sc.cardType == CardType.Minion)
        {
            sc.SetTag(GameTag.IsCanceled,1);
            new EffectMove(owner.myPlayer, owner, ZoneType.Head, ZoneType.Grave).Resolve();
            new EffectMove(owner.myPlayer.otherPlayer, sc, ZoneType.Board,ZoneType.Hand).Resolve();
            new EffectChange(owner.myPlayer.otherPlayer,owner,sc, manaChange:2).Resolve();
        }
    }
}
public class CORE_EX1_617:SpellBase{
//NAME=致命射击
//TEXT=随机消灭一个敌方随从。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDestroyRandomEnemyMinion();
    }
}
public class CORE_EX1_619:SpellBase{
//NAME=生而平等
//TEXT=将所有随从的生命值变为1。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        TaskSetHpTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1,hpDef:1);
    }
}
public class CORE_EX1_620:MinionBase{
//NAME=熔核巨人
//TEXT=你的英雄每缺失一点生命值，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=22|ATK=8|HP=8|RACE=ELEMENTAL
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand && owner.myPlayer.hero.Count>0)
            {
                return -owner.myPlayer.hero[0].GetTag(GameTag.Damage);
            }   
        }
        return 0;
    }
}
public class CORE_EX1_622:SpellBase{
//NAME=暗言术：灭
//TEXT=消灭一个攻击力大于或等于5的随从。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_EX1_623:MinionBase{
//NAME=圣殿执行者
//TEXT=<b>战吼：</b>使一个友方随从获得+3生命值。
//MAJ=PRIEST|COST=5|ATK=5|HP=6|RACE=NONE
}
public class CORE_EX1_625:SpellBase{
//NAME=暗影形态
//TEXT=你的英雄技能变为“造成2点伤害”。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_FB_Champs_LOOT_080:SpellBase{
//NAME=小型法术翡翠
//TEXT=召唤两只3/3的狼。<i>（使用一个<b>奥秘</b>后升级。）</i>
//MAJ=HUNTER|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class CORE_FIX_SW_084:MinionBase{
//NAME=血缚小鬼
//TEXT=每当本随从攻击时，对你的英雄造成2点伤害。
//MAJ=WARLOCK|COST=2|ATK=2|HP=5|RACE=DEMON
}
public class CORE_FP1_007:MinionBase{
//NAME=蛛魔之卵
//TEXT=<b>亡语：</b>召唤一个4/4的蛛魔。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=2|RACE=NONE
}
public class CORE_FP1_011:MinionBase{
//NAME=结网蛛
//TEXT=<b>亡语：</b>随机获取一张野兽牌。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class CORE_FP1_020:SecretBase{
//NAME=复仇
//TEXT=<b>奥秘：</b>当你的随从死亡时，随机使一个友方随从获得+3/+2。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class CORE_FP1_022:MinionBase{
//NAME=空灵召唤者
//TEXT=<b>亡语：</b> 随机将一张恶魔牌从你的手牌置入战场。
//MAJ=WARLOCK|COST=4|ATK=3|HP=4|RACE=DEMON
    public override void Deathrattle()
    {
        Card ToSummon = FindRace(owner.myPlayer.hand,RaceType.Demon).Choice(owner.myPlayer.randomGen);
        if(ToSummon!=null)
        {
            new EffectMove(owner.myPlayer,ToSummon,ZoneType.Hand,ZoneType.Board).Resolve();
        }
    }
}
public class CORE_FP1_031:MinionBase{
//NAME=瑞文戴尔男爵
//TEXT=你的随从的<b>亡语</b>将触发两次。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=7|RACE=UNDEAD
}
public class CORE_GIFT_01:MinionBase{
//NAME=哈斯·石酒
//TEXT=<b>战吼：</b>将你的手牌替换为炉石传说史上知名的一副手牌。<i>（每场对战限一次）</i>
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class CORE_GIFT_02:SpellBase{
//NAME=吉安娜的礼物
//TEXT=<b>发现</b>一张<b>临时</b>的寒冰箭，奥术智慧或火球术。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIFT_03:SpellBase{
//NAME=雷克萨的礼物
//TEXT=<b>发现</b>一张<b>临时</b>的快速射击，致命射击或爆炸射击。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIFT_04:SpellBase{
//NAME=阿尔萨斯的礼物
//TEXT=<b>发现</b>一张<b>临时</b>的黑暗突变，凛风冲击或灵界打击。
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIFT_05:SpellBase{
//NAME=乌瑟尔的礼物
//TEXT=<b>发现</b>一张<b>临时</b>的生而平等，奉献或王者祝福。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIFT_06:SpellBase{
//NAME=萨尔的礼物
//TEXT=<b>发现</b>一张<b>临时</b>的闪电风暴，妖术或嗜血。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIFT_07:SpellBase{
//NAME=加尔鲁什的礼物
//TEXT=<b>发现</b>一张<b>临时</b>的斩杀，盾牌格挡或绝命乱斗。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIFT_08:SpellBase{
//NAME=伊利丹的礼物
//TEXT=<b>发现</b>一张<b>临时</b>的邪能弹幕，混乱打击或混乱新星。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIFT_09:SpellBase{
//NAME=瓦莉拉的礼物
//TEXT=<b>发现</b>一张<b>临时</b>的背刺，致命药膏或刀扇。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIFT_10:SpellBase{
//NAME=玛法里奥的礼物
//TEXT=<b>发现</b>一张<b>临时</b>的野性之怒，野性成长或横扫。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIFT_11:SpellBase{
//NAME=古尔丹的礼物
//TEXT=<b>发现</b>一张<b>临时</b>的死亡缠绕，灵魂虹吸或扭曲虚空。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIFT_12:SpellBase{
//NAME=安度因的礼物
//TEXT=<b>发现</b>一张<b>临时</b>的真言术：盾，暗言术：痛或精神控制。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIL_124:MinionBase{
//NAME=苔藓恐魔
//TEXT=<b>战吼：</b>消灭所有其他攻击力小于或等于2的随从。
//MAJ=NEUTRAL|COST=6|ATK=2|HP=7|RACE=NONE
}
public class CORE_GIL_191:SpellBase{
//NAME=恶魔法阵
//TEXT=召唤四个1/1的小鬼。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class CORE_GIL_191t:MinionBase{
//NAME=小鬼
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class CORE_GIL_534:MinionBase{
//NAME=荆棘帮暴徒
//TEXT=在你的英雄攻击后，使本随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=QUILBOAR
}
public class CORE_GIL_547:MinionBase{
//NAME=达利乌斯·克罗雷
//TEXT=<b>突袭</b> 在克罗雷攻击并消灭一个随从后，获得+2/+2。
//MAJ=WARRIOR|COST=5|ATK=4|HP=5|RACE=NONE
}
public class CORE_GIL_577:SecretBase{
//NAME=捕鼠陷阱
//TEXT=<b>奥秘：</b>当你的对手在一回合中使用三张牌后，召唤一只6/6的老鼠。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_GIL_580:MinionBase{
//NAME=城镇公告员
//TEXT=<b>战吼：</b>从你的牌库中抽一张具有<b>突袭</b>的随从牌。
//MAJ=WARRIOR|COST=1|ATK=1|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDrawKey("Rush");
    }
}
public class CORE_GIL_598:MinionBase{
//NAME=苔丝·格雷迈恩
//TEXT=<b>战吼：</b>重新使用在本局对战中你所使用过的另一职业的卡牌<i>（目标随机而定）</i>。
//MAJ=ROGUE|COST=7|ATK=6|HP=6|RACE=NONE
}
public class CORE_GIL_600:SpellBase{
//NAME=静电震击
//TEXT=对一个随从造成$2点伤害。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class CORE_GIL_622:MinionBase{
//NAME=吸血蚊
//TEXT=<b>战吼：</b>对敌方英雄造成3点伤害。为你的英雄恢复#3点生命值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=BEAST
}
public class CORE_GIL_650:MinionBase{
//NAME=驯犬大师肖尔
//TEXT=你的其他随从拥有<b>突袭</b>。
//MAJ=HUNTER|COST=4|ATK=3|HP=6|RACE=NONE
}
public class CORE_GIL_653:WeaponBase{
//NAME=樵夫之斧
//TEXT=<b>亡语：</b>随机使一个友方随从获得+2/+1。
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CORE_GIL_663:SpellBase{
//NAME=女巫森林苹果
//TEXT=将两张2/2的树人置入你的手牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class CORE_GIL_667:MinionBase{
//NAME=腐烂的苹果树
//TEXT=<b>嘲讽</b>。<b>亡语：</b>为你的英雄恢复#6点生命值。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=UNDEAD
}
public class CORE_GIL_672:WeaponBase{
//NAME=幽灵弯刀
//TEXT=<b>吸血</b> 每当你使用一张另一职业的卡牌时，获得+1耐久度。
//MAJ=ROGUE|COST=4|ATK=2|HP=2|RACE=NONE
}
public class CORE_GIL_692:MinionBase{
//NAME=吉恩·格雷迈恩
//TEXT=<b>对战开始时：</b>如果你的套牌中只有法力值消耗为偶数的牌，你的初始英雄技能的法力值消耗变为（1）点。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=5|RACE=NONE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterGameStart(this,CauseEvent));
    }
    public void CauseEvent()
    {
        bool OnlyEven = true;
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardDbf.ManaCost%2==1)
            {
                OnlyEven=false;
                break;
            }
        }
        if(OnlyEven)
        {
            if(owner.myPlayer.power.Count>0)
            {
                Card PowCard = owner.myPlayer.power[0];
                new EffectChange(owner.myPlayer,owner,PowCard,1-PowCard.GetTag(GameTag.Mana)).Resolve();
            }
        }
    }
}
public class CORE_GIL_801:SpellBase{
//NAME=急速冷冻
//TEXT=<b>冻结</b>一个随从。如果该随从已被<b>冻结</b>，则将其消灭。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FROST
    public override void Battlecry(Card target=null)
    {
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
    }
}
public class CORE_GIL_826:MinionBase{
//NAME=噬月者巴库
//TEXT=<b>对战开始时：</b>如果你的套牌中只有法力值消耗为奇数的牌，升级你的英雄技能。
//MAJ=NEUTRAL|COST=9|ATK=7|HP=8|RACE=BEAST
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterGameStart(this,CauseEvent));
    }
    public void CauseEvent()
    {
        bool OnlyEven = true;
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardDbf.ManaCost%2==0)
            {
                OnlyEven=false;
                break;
            }
        }
        if(OnlyEven)
        {
            if(owner.myPlayer.power.Count>0)
            {
                Card PowCard = owner.myPlayer.power[0];
                CardDbf Upgraded = CardDbf.GetCardDbfByGuid(PowCard.cardDbf.m_noteMiniGuid+"2");
                
                if(Upgraded!=null)
                {
                    new EffectDestroy(owner.myPlayer,owner,PowCard).Resolve();
                    TaskCreate(Upgraded,ZoneType.Power);
                }
            }
        }
    }
}
public class CORE_GIL_828:SpellBase{
//NAME=凶猛狂暴
//TEXT=使一个野兽获得+3/+3。将它的三张复制洗入你的牌库，且这些复制都具有+3/+3。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class CORE_GVG_008:SpellBase{
//NAME=圣光炸弹
//TEXT=对所有随从造成等同于其攻击力的伤害。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=HOLY
}
public class CORE_GVG_013:MinionBase{
//NAME=齿轮大师
//TEXT=如果你控制任何机械，便拥有 +2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            if(CondCtrlAnotherRace(RaceType.Mechanical))
            {
                return 2;
            }
        }
        return 0;
    }
}
public class CORE_GVG_021:MinionBase{
//NAME=玛尔加尼斯
//TEXT=你的英雄<b>免疫</b>。你的其他恶魔拥有+2/+2。
//MAJ=WARLOCK|COST=9|ATK=9|HP=7|RACE=DEMON
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Demon) && (c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board || c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hero) && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        if(c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
        {
            return "GVG_021e";
        }
        else{
            return "Immue";
        }
    }
}
public class CORE_GVG_044:MinionBase{
//NAME=蜘蛛坦克
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=MECHANICAL
}
public class CORE_GVG_053:MinionBase{
//NAME=盾甲侍女
//TEXT=<b>战吼：</b> 获得5点护甲值。
//MAJ=WARRIOR|COST=5|ATK=5|HP=5|RACE=NONE
}
public class CORE_GVG_061:SpellBase{
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
public class CORE_GVG_076:MinionBase{
//NAME=自爆绵羊
//TEXT=<b>亡语：</b>对所有随从造成2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=MECHANICAL
}
public class CORE_GVG_085:MinionBase{
//NAME=吵吵机器人
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=MECHANICAL
}
public class CORE_GVG_109:MinionBase{
//NAME=小个子法师
//TEXT=<b>潜行，法术伤害+1</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=NONE
}
public class CORE_GVG_110:MinionBase{
//NAME=砰砰博士
//TEXT=<b>战吼：</b> 召唤两个1/1的砰砰机器人。<i>警告：该机器人随时可能爆炸。</i>
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("GVG_110t"),ZoneType.Board);
        TaskCreate(CardDbf.GetCardDbfByGuid("GVG_110t"),ZoneType.Board);
    }
}
public class CORE_GVG_121:MinionBase{
//NAME=发条巨人
//TEXT=你的对手每有一张手牌，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=12|ATK=8|HP=8|RACE=MECHANICAL
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            return -owner.myPlayer.otherPlayer.hand.Count;
        }
        return 0;
    }
}
public class CORE_ICC_018:MinionBase{
//NAME=幻影海盗
//TEXT=<b>战吼：</b> 获得等同于你的武器属性的属性值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=PIRATE
}
public class CORE_ICC_019:MinionBase{
//NAME=骷髅法师
//TEXT=<b>亡语：</b>如果此时是你对手的回合，则召唤一个8/8的骷髅。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=2|RACE=UNDEAD
}
public class CORE_ICC_021:MinionBase{
//NAME=自爆肿胀蝠
//TEXT=<b>亡语：</b>对所有敌方随从造成2点伤害。
//MAJ=HUNTER|COST=4|ATK=2|HP=1|RACE=BEAST
}
public class CORE_ICC_023:MinionBase{
//NAME=雪鳍企鹅
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=BEAST
}
public class CORE_ICC_025:MinionBase{
//NAME=骷髅捣蛋鬼
//TEXT=<b>战吼：</b>召唤一个5/5的骷髅。 <b>亡语：</b>为你的对手召唤一个5/5的骷髅。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=UNDEAD
}
public class CORE_ICC_026:MinionBase{
//NAME=冷酷的死灵法师
//TEXT=<b>战吼：</b>召唤两个1/1的骷髅。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=UNDEAD
}
public class CORE_ICC_027:MinionBase{
//NAME=白骨幼龙
//TEXT=<b>亡语：</b>随机将一张龙牌置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=5|RACE=DRAGON
}
public class CORE_ICC_028:MinionBase{
//NAME=阳焰瓦格里
//TEXT=<b>战吼：</b>使相邻的随从获得+2生命值。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=UNDEAD
}
public class CORE_ICC_029:MinionBase{
//NAME=深蓝刃鳞龙兽
//TEXT=在你的回合结束时，随机使另一个友方随从获得+3攻击力。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=DRAGON
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
            TaskBuffRandomTarget(owner.myPlayer.board.Exclude(owner),atk:3);
    }
}
public class CORE_ICC_031:MinionBase{
//NAME=暗夜嗥狼
//TEXT=每当本随从受到伤害，获得+2攻击力。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=NONE
}
public class CORE_ICC_032:MinionBase{
//NAME=制毒师
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=5|ATK=2|HP=5|RACE=UNDEAD
}
public class CORE_ICC_034:MinionBase{
//NAME=傲慢的十字军
//TEXT=<b>亡语：</b>如果此时是你对手的回合，则召唤一个2/2的食尸鬼。
//MAJ=PALADIN|COST=4|ATK=5|HP=2|RACE=UNDEAD
}
public class CORE_ICC_038:MinionBase{
//NAME=正义保护者
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
        TaskInitAbility("DivineShield");
    }
}
public class CORE_ICC_039:SpellBase{
//NAME=黑暗裁决
//TEXT=将一个随从的攻击力和生命值变为3。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_ICC_041:SpellBase{
//NAME=亵渎
//TEXT=对所有随从造成$1点伤害，如果有随从死亡，则再次施放该法术。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        int Cnt=0;
        while(true)
        {
            List<Card> ToListDamage = new List<Card>();
            foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
            {
                ToListDamage.Add(c);
            }
            TaskDamageTargets(ToListDamage,1);  
            Cnt+=1;
            if(Cnt>14)
            {
                break;
            }
            bool HasDeath=false;
            foreach(Card c in ToListDamage)
            {
                if(c.GetTag(GameTag.ZoneType)==(int)ZoneType.Grave)
                {
                    HasDeath=true;
                    break;
                }
            }
            if(!HasDeath)
            {
                break;
            }
        }
    }
}
public class CORE_ICC_047:MinionBase{
//NAME=命运织网蛛
//TEXT=<b>秘密亡语：</b> <b>抉择：</b>对所有随从造成3点伤害；或者使所有随从获得+2/+2。
//MAJ=DRUID|COST=5|ATK=5|HP=3|RACE=UNDEAD
}
public class CORE_ICC_049:SpellBase{
//NAME=剧毒箭矢
//TEXT=对一个随从造成$2点伤害，如果它依然存活，则使其获得<b>剧毒</b>。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class CORE_ICC_050:SpellBase{
//NAME=蛛网
//TEXT=召唤两只1/2并具有<b>剧毒</b>的 蜘蛛。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_ICC_051:MinionBase{
//NAME=虫群德鲁伊
//TEXT=<b>抉择：</b>变形成为1/2并具有<b>剧毒</b>；或者变形成为1/5并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=2|ATK=1|HP=2|RACE=NONE
}
public class CORE_ICC_052:SpellBase{
//NAME=装死
//TEXT=触发一个友方随从的<b>亡语</b>。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_ICC_054:SpellBase{
//NAME=传播瘟疫
//TEXT=召唤一只1/5并具有<b>嘲讽</b>的甲虫。如果你的对手拥有的随从更多，则再次施放该法术。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        int Cnt=0;
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("ICC_832t4");
        while(true)
        {
            TaskCreate(ToSummon,ZoneType.Board);
            Cnt+=1;
            if(owner.myPlayer.board.Count>=owner.myPlayer.otherPlayer.board.Count || Cnt>=14)
            {
                break;
            }
        }
    }
}
public class CORE_ICC_055:SpellBase{
//NAME=吸取灵魂
//TEXT=<b>吸血</b> 对一个随从造成 $3点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_ICC_056:SpellBase{
//NAME=低温静滞
//TEXT=使一个随从获得+3/+3，并使其<b>冻结</b>。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=FROST
}
public class CORE_ICC_058:MinionBase{
//NAME=冷冻鱼人
//TEXT=<b>战吼：</b> <b>冻结</b>一个敌人。
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=MURLOC
}
public class CORE_ICC_062:MinionBase{
//NAME=熔甲卫士
//TEXT=<b>亡语：</b>如果此时是你对手的回合，则获得 6点护甲值。
//MAJ=WARRIOR|COST=3|ATK=4|HP=3|RACE=NONE
}
public class CORE_ICC_064:WeaponBase{
//NAME=血刃剃刀
//TEXT=<b>战吼，亡语：</b> 对所有随从造成1点伤害。
//MAJ=WARRIOR|COST=4|ATK=2|HP=2|RACE=NONE
}
public class CORE_ICC_065:MinionBase{
//NAME=白骨大亨
//TEXT=<b>亡语：</b> 将两张1/1的“骷髅”置入你的手牌。
//MAJ=ROGUE|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class CORE_ICC_067:MinionBase{
//NAME=维库食尸鬼
//TEXT=<b>亡语：</b>如果此时是你对手的回合，则召唤一个2/2的食尸鬼。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=UNDEAD
}
public class CORE_ICC_068:MinionBase{
//NAME=寒冰行者
//TEXT=你的英雄技能还会 <b>冻结</b>目标。
//MAJ=MAGE|COST=2|ATK=1|HP=3|RACE=ELEMENTAL
}
public class CORE_ICC_069:MinionBase{
//NAME=鬼影巫师
//TEXT=<b>战吼：</b>将一张“镜像”法术牌置入你的手牌。
//MAJ=MAGE|COST=4|ATK=2|HP=6|RACE=UNDEAD
}
public class CORE_ICC_071:WeaponBase{
//NAME=光之悲恸
//TEXT=在一个友方随从失去<b>圣盾</b>后，获得+1攻击力。
//MAJ=PALADIN|COST=4|ATK=1|HP=4|RACE=NONE
}
public class CORE_ICC_075:MinionBase{
//NAME=卑鄙的恐惧魔王
//TEXT=在你的回合结束时，对所有敌方随从造成1点伤害。
//MAJ=WARLOCK|COST=5|ATK=4|HP=5|RACE=DEMON
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
            TaskDamageTargets(owner.myPlayer.otherPlayer.board,1);
    }
}
public class CORE_ICC_078:SpellBase{
//NAME=雪崩
//TEXT=<b>冻结</b>一个随从，并对其相邻的随从造成$3点伤害。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=FROST
}
public class CORE_ICC_079:SpellBase{
//NAME=铁齿铜牙
//TEXT=使你的英雄获得3点护甲值，并在本回合中获得 +3攻击力。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class CORE_ICC_081:MinionBase{
//NAME=达卡莱防御者
//TEXT=<b>嘲讽</b>，<b>过载：</b>（3）
//MAJ=SHAMAN|COST=3|ATK=2|HP=8|RACE=NONE
}
public class CORE_ICC_082:SecretBase{
//NAME=寒冰克隆
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，将两张该随从的复制置入你的手牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class CORE_ICC_083:MinionBase{
//NAME=末日学徒
//TEXT=你对手法术的法力值消耗增加（1）点。
//MAJ=MAGE|COST=3|ATK=3|HP=2|RACE=UNDEAD
}
public class CORE_ICC_085:SpellBase{
//NAME=终极感染
//TEXT=造成$5点伤害。抽五张牌。获得5点护甲值。召唤一个5/5的食尸鬼。
//MAJ=DRUID|COST=10|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,5).Resolve();
        for(int i=0;i<5;i++)
        {
            TaskDraw();
        }
        TaskBuffMyHero(arm:5);
        TaskCreate(CardDbf.GetCardDbfByGuid("ICC_085t"),ZoneType.Board);
    }
}
public class CORE_ICC_086:SpellBase{
//NAME=冰封秘典
//TEXT=将每种不同的<b>奥秘</b>从你的牌库中置入战场。
//MAJ=MAGE|COST=8|ATK=0|HP=0|RACE=FROST
}
public class CORE_ICC_088:MinionBase{
//NAME=巫毒妖术师
//TEXT=<b>嘲讽</b> <b>冻结</b>任何受到本随从伤害的角色。
//MAJ=SHAMAN|COST=5|ATK=2|HP=7|RACE=NONE
}
public class CORE_ICC_089:SpellBase{
//NAME=冰钓术
//TEXT=从你的牌库中抽两张鱼人牌。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=FROST
}
public class CORE_ICC_090:MinionBase{
//NAME=雪怒巨人
//TEXT=在本局对战中，你每<b>过载</b>一个法力水晶，本牌的法力值消耗便减少（1）点。
//MAJ=SHAMAN|COST=11|ATK=8|HP=8|RACE=ELEMENTAL
}
public class CORE_ICC_091:SpellBase{
//NAME=亡者之牌
//TEXT=复制你的手牌并洗入你的牌库。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<CardDbf> ToListShuffle = new List<CardDbf>();
        foreach(Card c in owner.myPlayer.hand)
        {
            ToListShuffle.Add(c.cardDbf);
            TaskCreate(c.cardDbf,ZoneType.Deck,randpos:true);
        }
    }
}
public class CORE_ICC_092:MinionBase{
//NAME=阿彻鲁斯老兵
//TEXT=<b>战吼：</b>使一个友方随从获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=UNDEAD
}
public class CORE_ICC_093:MinionBase{
//NAME=海象人渔夫
//TEXT=<b>战吼：</b>使一个友方随从获得<b>法术伤害+1</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class CORE_ICC_094:MinionBase{
//NAME=堕落残阳祭司
//TEXT=<b>战吼：</b>使一个友方随从获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=UNDEAD
}
public class CORE_ICC_096:MinionBase{
//NAME=熔火巨像
//TEXT=<b>战吼：</b>弃掉你手牌中所有的武器牌，并获得这些武器的属性值。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=UNDEAD
}
public class CORE_ICC_097:MinionBase{
//NAME=墓地蹒跚者
//TEXT=每当你的武器被摧毁时，便获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class CORE_ICC_098:MinionBase{
//NAME=墓穴潜伏者
//TEXT=<b>战吼：</b>随机将一个在本局对战中死亡并具有<b>亡语</b>的随从置入你的手牌。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=3|RACE=UNDEAD
}
public class CORE_ICC_099:MinionBase{
//NAME=自爆憎恶
//TEXT=<b>亡语：</b>对你所有的随从造成5点伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=6|RACE=UNDEAD
}
public class CORE_ICC_200:SecretBase{
//NAME=眼镜蛇陷阱
//TEXT=<b>奥秘：</b>当你的随从受到攻击时，召唤一条2/3并具有<b>剧毒</b>的眼镜蛇。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_ICC_201:SpellBase{
//NAME=命运骨骰
//TEXT=抽一张牌。如果这张牌有<b>亡语</b>，则再次施放本法术。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        while(true)
        {
            Card Drawn = TaskDraw();
            bool Stop=true;
            if(Drawn!=null)
            {
                if(Drawn.HasAbility("Deathrattle"))
                {
                    Stop=false;
                }
            }
            if(Stop)
            {
                break;
            }
        }
    }
}
public class CORE_ICC_204:MinionBase{
//NAME=普崔塞德教授
//TEXT=在你使用一个<b>奥秘</b>后，随机将一个猎人的<b>奥秘</b>置入战场。
//MAJ=HUNTER|COST=4|ATK=5|HP=4|RACE=UNDEAD
}
public class CORE_ICC_206:SpellBase{
//NAME=变节
//TEXT=选择一个友方随从，交给你的 对手。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        new EffectMove(owner.myPlayer,target,ZoneType.Board,ZoneType.Board,toEn:true).Resolve();
    }
}
public class CORE_ICC_207:SpellBase{
//NAME=吞噬意志
//TEXT=复制你对手的牌库中的三张牌，并将其置入你的手牌。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_ICC_210:MinionBase{
//NAME=暗影升腾者
//TEXT=在你的回合结束时，随机使另一个友方随从获得+1/+1。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class CORE_ICC_212:MinionBase{
//NAME=酷虐侍僧
//TEXT=<b>吸血</b>
//MAJ=PRIEST|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class CORE_ICC_213:SpellBase{
//NAME=永恒奴役
//TEXT=<b>发现</b>一个在本局对战中死亡的友方随从，并召唤该随从。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_ICC_214:MinionBase{
//NAME=黑曜石雕像
//TEXT=<b>嘲讽</b>，<b>吸血</b> <b>亡语：</b>随机消灭一个敌方随从。
//MAJ=PRIEST|COST=9|ATK=4|HP=8|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("LifeSteal");
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        TaskDestroyRandomEnemyMinion();
    }
}
public class CORE_ICC_215:MinionBase{
//NAME=大主教本尼迪塔斯
//TEXT=<b>战吼：</b>复制你对手的牌库，并洗入你的 牌库。
//MAJ=PRIEST|COST=7|ATK=4|HP=6|RACE=NONE
}
public class CORE_ICC_218:MinionBase{
//NAME=咆哮魔
//TEXT=每当本随从受到伤害，随机弃掉 一张牌。
//MAJ=WARLOCK|COST=3|ATK=3|HP=6|RACE=DEMON
}
public class CORE_ICC_220:MinionBase{
//NAME=死鳞骑士
//TEXT=<b>吸血</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class CORE_ICC_221:SpellBase{
//NAME=吸血药膏
//TEXT=在本回合中，你的武器获得 <b>吸血</b>。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class CORE_ICC_233:SpellBase{
//NAME=末日回旋镖
//TEXT=对一个随从投掷你的武器。武器会造成伤害，然后移回你的手牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_ICC_235:SpellBase{
//NAME=暗影精华
//TEXT=随机挑选你牌库里的一个随从，召唤一个5/5的复制。
//MAJ=PRIEST|COST=7|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_ICC_236:WeaponBase{
//NAME=破冰斧
//TEXT=消灭所有受到该武器伤害的被<b>冻结</b>的随从。
//MAJ=SHAMAN|COST=3|ATK=1|HP=3|RACE=NONE
}
public class CORE_ICC_238:MinionBase{
//NAME=活化狂战士
//TEXT=在你使用一张随从牌后，对其造成1点 伤害。
//MAJ=WARRIOR|COST=1|ATK=1|HP=3|RACE=NONE
}
public class CORE_ICC_240:MinionBase{
//NAME=符文熔铸游魂
//TEXT=在你的回合时，你的武器不会失去 耐久度。
//MAJ=ROGUE|COST=4|ATK=5|HP=3|RACE=UNDEAD
}
public class CORE_ICC_243:MinionBase{
//NAME=巨型尸蛛
//TEXT=你的<b>亡语</b>牌的法力值消耗减少（2）点。
//MAJ=HUNTER|COST=5|ATK=4|HP=6|RACE=BEAST
}
public class CORE_ICC_244:SpellBase{
//NAME=殊死一搏
//TEXT=使一个随从获得“<b>亡语：</b>回到战场，并具有1点生命值。”
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class CORE_ICC_245:MinionBase{
//NAME=黑色卫士
//TEXT=每当你的英雄获得治疗时，便随机对一个敌方随从造成等量的 伤害。
//MAJ=PALADIN|COST=6|ATK=3|HP=9|RACE=UNDEAD
}
public class CORE_ICC_252:MinionBase{
//NAME=冰冷鬼魂
//TEXT=<b>战吼：</b>如果有敌人被<b>冻结</b>，抽一张牌。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=UNDEAD
}
public class CORE_ICC_257:MinionBase{
//NAME=唤尸者
//TEXT=<b>战吼：</b>使一个友方随从获得“<b>亡语：</b>再次召唤该随从。”
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class CORE_ICC_281:SpellBase{
//NAME=灵魂洪炉
//TEXT=从你的牌库中抽两张武器牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_ICC_289:MinionBase{
//NAME=莫拉比
//TEXT=每当有其他随从被<b>冻结</b>，将一张被<b>冻结</b>随从的复制置入你的 手牌。
//MAJ=SHAMAN|COST=6|ATK=4|HP=4|RACE=NONE
}
public class CORE_ICC_314:MinionBase{
//NAME=巫妖王
//TEXT=<b>嘲讽</b> 在你的回合结束时，随机将一张<b>巫妖王</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=UNDEAD
}
public class CORE_ICC_405:MinionBase{
//NAME=腐面
//TEXT=在本随从受到伤害并存活下来后，随机召唤一个<b>传说</b>随从。
//MAJ=WARRIOR|COST=8|ATK=4|HP=6|RACE=UNDEAD
}
public class CORE_ICC_407:MinionBase{
//NAME=侏儒吸血鬼
//TEXT=<b>战吼：</b>移除你对手的牌库顶的一张牌。
//MAJ=WARLOCK|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class CORE_ICC_408:MinionBase{
//NAME=瓦格里摄魂者
//TEXT=在本随从受到伤害并存活下来后，召唤一个2/2的食尸鬼。
//MAJ=WARRIOR|COST=3|ATK=1|HP=4|RACE=UNDEAD
}
public class CORE_ICC_415:MinionBase{
//NAME=缝合追踪者
//TEXT=<b>战吼：</b> 从你的牌库中<b>发现</b>一张随从牌的复制。
//MAJ=HUNTER|COST=3|ATK=2|HP=2|RACE=UNDEAD
    public override void Battlecry(Card target=null)
    {
        List<CardDbf> Pool = new List<CardDbf>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardType==CardType.Minion)
            {
                Pool.Add(c.cardDbf);
            }
        }
        CardDbf ToCreate = Pool.Choice(owner.myPlayer.randomGen);
        if(ToCreate!=null)
        {
            TaskCreate(ToCreate,ZoneType.Hand);
        }
    }
}
public class CORE_ICC_419:MinionBase{
//NAME=熊鲨
//TEXT=<b>扰魔</b>
//MAJ=HUNTER|COST=3|ATK=4|HP=3|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Elusive");
    }
}
public class CORE_ICC_450:MinionBase{
//NAME=死亡幽魂
//TEXT=<b>战吼：</b>每有一个受伤的随从，便获得+1/+1。
//MAJ=WARRIOR|COST=5|ATK=3|HP=3|RACE=UNDEAD
}
public class CORE_ICC_466:MinionBase{
//NAME=萨隆苦囚
//TEXT=<b>嘲讽</b> <b>战吼：</b>召唤一个本随从的复制。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=3|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        Card Another = new Card(owner.cardDbf,owner.myPlayer);
        Another.SetTag(GameTag.Attack,owner.GetTag(GameTag.Attack));
        Another.SetTag(GameTag.Health,owner.GetTag(GameTag.Health));
        Another.SetTag(GameTag.Damage,owner.GetTag(GameTag.Damage));
        new EffectCreate(owner.myPlayer,Another,ZoneType.Board).Resolve();
    }
}
public class CORE_ICC_467:MinionBase{
//NAME=亡语者
//TEXT=<b>战吼：</b>在本回合中，使一个友方随从获得<b>免疫</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=UNDEAD
}
public class CORE_ICC_468:MinionBase{
//NAME=失心农夫
//TEXT=每当本随从攻击时，对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class CORE_ICC_469:SpellBase{
//NAME=强制牺牲
//TEXT=选择一个友方随从，消灭该随从和一个随机敌方随从。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_ICC_481:HeroBase{
//NAME=死亡先知萨尔
//TEXT=<b>战吼：</b>随机将你的所有随从变形成为法力值消耗增加（2）点的随从。
//MAJ=SHAMAN|COST=5|ATK=0|HP=30|RACE=NONE
}
public class CORE_ICC_700:MinionBase{
//NAME=开心的食尸鬼
//TEXT=在本回合中，如果你的英雄受到治疗，则 法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class CORE_ICC_701:MinionBase{
//NAME=游荡恶鬼
//TEXT=<b>战吼：</b>摧毁双方手牌中和牌库中所有法力值消耗为（1）的 法术牌。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=6|RACE=UNDEAD
}
public class CORE_ICC_702:MinionBase{
//NAME=孱弱的掘墓者
//TEXT=<b>亡语：</b>随机将一个具有<b>亡语</b>的随从置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=UNDEAD
}
public class CORE_ICC_705:MinionBase{
//NAME=骨魇
//TEXT=<b>战吼：</b>使一个友方随从获得+4/+4和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=7|ATK=5|HP=5|RACE=UNDEAD
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,atkChange:4,hpChange:4).Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,target,"Taunt").Resolve();
    }
}
public class CORE_ICC_706:MinionBase{
//NAME=蛛魔拆解者
//TEXT=法术的法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class CORE_ICC_801:MinionBase{
//NAME=咆哮的指挥官
//TEXT=<b>战吼：</b>从你的牌库中抽一张具有<b>圣盾</b>的随从牌。
//MAJ=PALADIN|COST=3|ATK=2|HP=2|RACE=UNDEAD
}
public class CORE_ICC_802:SpellBase{
//NAME=灵魂鞭笞
//TEXT=<b>吸血</b> 对所有随从造成 $1点伤害。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_ICC_807:MinionBase{
//NAME=硬壳清道夫
//TEXT=<b>战吼：</b>使你具有<b>嘲讽</b>的随从获得+2/+2。
//MAJ=DRUID|COST=4|ATK=2|HP=3|RACE=NONE
}
public class CORE_ICC_808:MinionBase{
//NAME=地穴领主
//TEXT=<b>嘲讽</b> 在你召唤一个随从后，获得+1生命值。
//MAJ=DRUID|COST=3|ATK=1|HP=6|RACE=UNDEAD
}
public class CORE_ICC_809:MinionBase{
//NAME=瘟疫科学家
//TEXT=<b>连击：</b>使一个友方随从获得<b>剧毒</b>。
//MAJ=ROGUE|COST=3|ATK=2|HP=3|RACE=UNDEAD
}
public class CORE_ICC_810:MinionBase{
//NAME=亡斧惩罚者
//TEXT=<b>战吼：</b>随机使你手牌中一个具有<b>吸血</b>的随从获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=UNDEAD
}
public class CORE_ICC_811:MinionBase{
//NAME=莉莉安·沃斯
//TEXT=<b>战吼：</b>随机将你手牌中所有的法术牌替换成<i>（你对手职业的）</i>法术牌。
//MAJ=ROGUE|COST=4|ATK=4|HP=5|RACE=UNDEAD
}
public class CORE_ICC_812:MinionBase{
//NAME=绞肉车
//TEXT=<b>亡语：</b>从你的牌库中召唤一个攻击力小于本随从攻击力的随从。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=4|RACE=MECHANICAL
}
public class CORE_ICC_820:MinionBase{
//NAME=寒刃勇士
//TEXT=<b>冲锋，吸血</b>
//MAJ=PALADIN|COST=4|ATK=3|HP=2|RACE=UNDEAD
}
public class CORE_ICC_823:SpellBase{
//NAME=模拟幻影
//TEXT=复制你手牌中法力值消耗最低的随从牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class CORE_ICC_825:MinionBase{
//NAME=憎恶弓箭手
//TEXT=<b>亡语：</b>随机召唤一个在本局对战中死亡的友方野兽。
//MAJ=HUNTER|COST=7|ATK=6|HP=7|RACE=UNDEAD
}
public class CORE_ICC_827:HeroBase{
//NAME=虚空之影瓦莉拉
//TEXT=<b>战吼：</b>获得<b>潜行</b>直到你的下个回合。
//MAJ=ROGUE|COST=9|ATK=0|HP=30|RACE=NONE
}
public class CORE_ICC_828:HeroBase{
//NAME=死亡猎手雷克萨
//TEXT=<b>战吼：</b> 对所有敌方随从造成2点伤害。
//MAJ=HUNTER|COST=6|ATK=0|HP=30|RACE=NONE
}
public class CORE_ICC_829:HeroBase{
//NAME=黑锋骑士乌瑟尔
//TEXT=<b>战吼：</b> 装备一把5/3并具有<b>吸血</b>的武器。
//MAJ=PALADIN|COST=9|ATK=0|HP=30|RACE=NONE
}
public class CORE_ICC_830:HeroBase{
//NAME=暗影收割者安度因
//TEXT=<b>战吼：</b>消灭所有攻击力大于或等于5的随从。
//MAJ=PRIEST|COST=8|ATK=0|HP=30|RACE=NONE
}
public class CORE_ICC_831:HeroBase{
//NAME=鲜血掠夺者古尔丹
//TEXT=<b>战吼：</b>召唤所有在本局对战中死亡的友方恶魔。
//MAJ=WARLOCK|COST=10|ATK=0|HP=30|RACE=NONE
}
public class CORE_ICC_832:HeroBase{
//NAME=污染者玛法里奥
//TEXT=<b>抉择：</b>召唤两只具有<b>剧毒</b>的蜘蛛；或者召唤两只具有<b>嘲讽</b>的甲虫。
//MAJ=DRUID|COST=7|ATK=0|HP=30|RACE=NONE
}
public class CORE_ICC_833:HeroBase{
//NAME=冰霜女巫吉安娜
//TEXT=<b>战吼：</b>召唤一个3/6的水元素。在本局对战中，你的所有元素拥有<b>吸血</b>。
//MAJ=MAGE|COST=9|ATK=0|HP=30|RACE=NONE
}
public class CORE_ICC_834:HeroBase{
//NAME=天灾领主加尔鲁什
//TEXT=<b>战吼：</b>装备一把4/3的影之哀伤，影之哀伤同时对其攻击目标相邻的随从造成伤害。
//MAJ=WARRIOR|COST=8|ATK=0|HP=30|RACE=NONE
}
public class CORE_ICC_835:MinionBase{
//NAME=哈多诺克斯
//TEXT=<b>亡语：</b>召唤所有你在本局对战中死亡的，并具有<b>嘲讽</b>的随从。
//MAJ=DRUID|COST=9|ATK=3|HP=7|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        List<CardDbf> ToListSummon = new List<CardDbf>();
        foreach(Card c in owner.myPlayer.grave)
        {
            if(c.HasAbility("Taunt") && c.cardType==CardType.Minion)
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
public class CORE_ICC_836:SpellBase{
//NAME=冰龙吐息
//TEXT=随机对一个敌方随从造成$2点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FROST
}
public class CORE_ICC_837:SpellBase{
//NAME=放马过来
//TEXT=获得10点护甲值。使你对手的手牌中所有随从牌的法力值消耗减少（2）点。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_ICC_838:MinionBase{
//NAME=辛达苟萨
//TEXT=<b>战吼：</b>召唤两个0/1的被冰封的勇士。
//MAJ=MAGE|COST=8|ATK=8|HP=8|RACE=DRAGON
}
public class CORE_ICC_841:MinionBase{
//NAME=鲜血女王兰娜瑟尔
//TEXT=<b>吸血</b> 在本局对战中，你每弃掉一张牌，便拥有+1攻击力。
//MAJ=WARLOCK|COST=5|ATK=1|HP=6|RACE=UNDEAD
}
public class CORE_ICC_849:SpellBase{
//NAME=黑暗之拥
//TEXT=选择一个敌方随从。在你的回合开始时，获得该随从的 控制权。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_ICC_850:WeaponBase{
//NAME=暗影之刃
//TEXT=<b>战吼：</b>在本回合中，你的英雄<b>免疫</b>。
//MAJ=ROGUE|COST=3|ATK=3|HP=2|RACE=NONE
}
public class CORE_ICC_851:MinionBase{
//NAME=凯雷塞斯王子
//TEXT=<b>战吼：</b>如果你的牌库里没有法力值消耗为（2）的牌，则使你牌库里所有随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
    public override void Battlecry(Card target=null)
    {
        bool HasTwo = false;
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.GetTag(GameTag.Mana)==2)
            {
                HasTwo=true;
            }
        }
        if(!HasTwo)
        {
            TaskBuffTargets(owner.myPlayer.deck,atk:1,hp:1);
        }
    }
}
public class CORE_ICC_852:MinionBase{
//NAME=塔达拉姆王子
//TEXT=<b>战吼：</b>如果你的牌库里没有法力值消耗为（3）的牌，则变形成为一个随从的3/3的复制。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class CORE_ICC_853:MinionBase{
//NAME=瓦拉纳王子
//TEXT=<b>战吼：</b>如果你的牌库里没有法力值消耗为（4）的牌，则获得<b>吸血</b>和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class CORE_ICC_854:MinionBase{
//NAME=阿尔福斯
//TEXT=<b>亡语：</b>随机将一张<b>巫妖王</b>牌置入你的 手牌。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=BEAST
}
public class CORE_ICC_855:MinionBase{
//NAME=海德尼尔冰霜骑士
//TEXT=<b>战吼：</b><b>冻结</b>你的其他随从。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=NONE
}
public class CORE_ICC_856:MinionBase{
//NAME=织法者
//TEXT=<b>法术伤害+2</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=UNDEAD
}
public class CORE_ICC_858:MinionBase{
//NAME=浴火者伯瓦尔
//TEXT=<b>圣盾</b> 在一个友方随从失去<b>圣盾</b>后，获得+2攻击力。
//MAJ=PALADIN|COST=5|ATK=1|HP=7|RACE=UNDEAD
}
public class CORE_ICC_900:MinionBase{
//NAME=死灵恶鬼
//TEXT=每当你的其他随从死亡时，召唤一个2/2的食尸鬼。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=3|RACE=UNDEAD
}
public class CORE_ICC_901:MinionBase{
//NAME=达卡莱附魔师
//TEXT=你的回合结束效果会触发两次。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class CORE_ICC_902:MinionBase{
//NAME=摧心者
//TEXT=双方英雄技能均无法使用。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=UNDEAD
}
public class CORE_ICC_903:MinionBase{
//NAME=血色狂欢者
//TEXT=<b>战吼：</b>消灭一个友方随从，并获得+2/+2。
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class CORE_ICC_904:MinionBase{
//NAME=邪骨骷髅
//TEXT=<b>战吼：</b>在本回合中每有一个随从死亡，便获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=1|RACE=UNDEAD
}
public class CORE_ICC_905:MinionBase{
//NAME=血虫
//TEXT=<b>吸血</b>
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=BEAST
}
public class CORE_ICC_910:MinionBase{
//NAME=鬼灵匪贼
//TEXT=<b>连击：</b>造成伤害，数值等同于在本回合中你使用的其他牌的 数量。
//MAJ=ROGUE|COST=6|ATK=5|HP=5|RACE=UNDEAD
}
public class CORE_ICC_911:MinionBase{
//NAME=哀泣女妖
//TEXT=每当你使用一张牌，便移除你的牌库顶的三张牌。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=5|RACE=UNDEAD
}
public class CORE_ICC_912:MinionBase{
//NAME=夺尸者
//TEXT=<b>战吼：</b> 如果你的牌库里有<b>嘲讽</b>随从牌，则获得<b>嘲讽</b>。依此法检定是否可获得<b>圣盾</b>，<b>吸血</b>和<b>风怒</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=UNDEAD
}
public class CORE_ICC_913:MinionBase{
//NAME=被污染的狂热者
//TEXT=<b>圣盾</b> <b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=UNDEAD
}
public class CORE_KAR_004:SecretBase{
//NAME=豹子戏法
//TEXT=<b>奥秘：</b>在你的对手施放一个法术后，召唤一只4/2并具有<b>潜行</b>的猎豹。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_KAR_006:MinionBase{
//NAME=神秘女猎手
//TEXT=你的<b>奥秘</b>牌法力值消耗为（0）点。
//MAJ=HUNTER|COST=3|ATK=3|HP=4|RACE=NONE
}
public class CORE_KAR_009:MinionBase{
//NAME=呓语魔典
//TEXT=<b>战吼：</b>随机将一张法师法术牌置入你的 手牌。
//MAJ=MAGE|COST=1|ATK=1|HP=2|RACE=NONE
}
public class CORE_KAR_036:MinionBase{
//NAME=奥术畸体
//TEXT=在你施放一个法术后，使本随从获得+1生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=ELEMENTAL
}
public class CORE_KAR_063:WeaponBase{
//NAME=幽灵之爪
//TEXT=当你拥有<b>法术伤害</b>时，拥有 +2攻击力。
//MAJ=SHAMAN|COST=1|ATK=1|HP=3|RACE=NONE
}
public class CORE_KAR_065:MinionBase{
//NAME=展览馆守卫
//TEXT=<b>战吼：</b>选择一个友方野兽，召唤一个它的复制。
//MAJ=DRUID|COST=5|ATK=5|HP=4|RACE=NONE
}
public class CORE_KAR_069:MinionBase{
//NAME=吹嘘海盗
//TEXT=<b>战吼：</b>随机将一张另一职业的卡牌置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=1|HP=2|RACE=PIRATE
}
public class CORE_KAR_073:SpellBase{
//NAME=大漩涡传送门
//TEXT=对所有敌方随从造成$1点伤害。随机召唤一个法力值消耗为（1）的随从。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class CORE_KAR_076:SpellBase{
//NAME=火焰之地传送门
//TEXT=造成$6点伤害。随机召唤一个法力值消耗为（6）的随从。
//MAJ=MAGE|COST=7|ATK=0|HP=0|RACE=FIRE
}
public class CORE_KAR_077:SpellBase{
//NAME=银月城传送门
//TEXT=使一个随从获得+2/+2。随机召唤一个法力值消耗为（2）的随从。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class CORE_KAR_300:MinionBase{
//NAME=魔法乌鸦
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=BEAST
}
public class CORE_LOE_003:MinionBase{
//NAME=虚灵巫师
//TEXT=<b>战吼： 发现</b>一张法术牌。
//MAJ=MAGE|COST=5|ATK=6|HP=4|RACE=NONE
}
public class CORE_LOE_011:MinionBase{
//NAME=雷诺·杰克逊
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则为你的英雄恢复所有生命值。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=6|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(CondDeckUni())
            TaskHealMyHero(tofull:true);
    }
}
public class CORE_LOE_012:MinionBase{
//NAME=盗墓匪贼
//TEXT=<b>亡语：</b>获取一张 幸运币。
//MAJ=ROGUE|COST=4|ATK=6|HP=4|RACE=UNDEAD
}
public class CORE_LOE_039:MinionBase{
//NAME=A3型机械金刚
//TEXT=<b>战吼：</b>如果你控制着其他机械，<b>发现</b>一张机械牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=MECHANICAL
}
public class CORE_LOE_050:MinionBase{
//NAME=骑乘迅猛龙
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（1）的随从。
//MAJ=DRUID|COST=3|ATK=3|HP=2|RACE=BEAST
}
public class CORE_LOE_076:MinionBase{
//NAME=芬利·莫格顿爵士
//TEXT=<b>战吼：</b><b>发现</b>一个新的基础英雄技能。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=MURLOC
}
public class CORE_LOE_077:MinionBase{
//NAME=布莱恩·铜须
//TEXT=你的<b>战吼</b>会触发 两次。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.cardType==CardType.Minion || sc.cardType==CardType.Weapon || sc.cardType==CardType.Hero)
            {
                new EffectChange(owner.myPlayer,owner,sc).Resolve();
                foreach(Ability abi in sc.abilityList)
                {
                    abi.Battlecry(tc);
                }
            }
        }
    }
}
public class CORE_LOE_079:MinionBase{
//NAME=伊莉斯·逐星
//TEXT=<b>战吼：</b>将“黄金猿藏宝图”洗入你的牌库。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class Core_LOE_115:SpellBase{
//NAME=乌鸦神像
//TEXT=<b>抉择：</b> <b>发现</b>一张随从牌；或者<b>发现</b>一张法术牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_LOEA10_3:MinionBase{
//NAME=鱼人宝宝
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=MURLOC
}
public class CORE_LOOT_026:MinionBase{
//NAME=法多雷突袭者
//TEXT=<b>战吼：</b> 将三张伏击牌洗入你的牌库。 当抽到伏击牌时，召唤一只4/4的蜘蛛。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=NONE
}
public class CORE_LOOT_043:SpellBase{
//NAME=小型法术紫水晶
//TEXT=<b>吸血</b> 对一个随从造成$3点伤害。<i>（受到来自你的卡牌的伤害后升级。）</i>
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_LOOT_051:SpellBase{
//NAME=小型法术玉石
//TEXT=对一个随从造成$2点伤害。0<i>（获得3点护甲值后升级。）</i>
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class CORE_LOOT_079:SecretBase{
//NAME=游荡怪物
//TEXT=<b>奥秘：</b> 当一个敌人攻击你的英雄时，随机召唤一个法力值消耗为（3）的随从，并使其成为攻击的目标。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_LOOT_101:SecretBase{
//NAME=爆炸符文
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，对该随从造成$6点伤害，超过其生命值的伤害将由对方英雄 承受。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FIRE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterPlay(this,EX1_609CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
    }
    public void EX1_609CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Head && sc.cardType == CardType.Minion)
        {
            new EffectMove(owner.myPlayer, owner, ZoneType.Head, ZoneType.Grave).Resolve();
            new EffectDamage(owner.myPlayer,owner, sc, 6).Resolve();
            if(sc.GetTag(GameTag.Health)<0)
                TaskDamageEnemyHero(-sc.GetTag(GameTag.Health));
        }
    }
}
public class CORE_LOOT_124:MinionBase{
//NAME=孤胆英雄
//TEXT=<b>战吼：</b>如果你没有控制其他随从，则获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class CORE_LOOT_125:MinionBase{
//NAME=石皮蜥蜴
//TEXT=<b>圣盾</b> <b>剧毒</b>
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=BEAST
}
public class CORE_LOOT_137:MinionBase{
//NAME=贪睡巨龙
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=9|ATK=6|HP=12|RACE=DRAGON
}
public class CORE_LOOT_204:SecretBase{
//NAME=诈死
//TEXT=<b>奥秘：</b>当一个友方随从死亡时，将其移回你的手牌，它的法力值消耗减少（2）点。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_LOOT_211:MinionBase{
//NAME=精灵咏唱者
//TEXT=<b>连击：</b>从你的牌库中抽两张随从牌。
//MAJ=ROGUE|COST=4|ATK=3|HP=3|RACE=NONE
}
public class CORE_LOOT_222:WeaponBase{
//NAME=蜡烛弓
//TEXT=你的英雄在攻击时<b>免疫</b>。
//MAJ=HUNTER|COST=1|ATK=1|HP=3|RACE=NONE
}
public class CORE_LOOT_231:MinionBase{
//NAME=奥术工匠
//TEXT=每当你施放一个法术，便获得等同于其法力值消耗的护甲值。
//MAJ=MAGE|COST=1|ATK=1|HP=3|RACE=ELEMENTAL
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
                TaskBuffMyHero(arm:sc.GetTag(GameTag.Mana));
            }
        }
    }
}
public class CORE_LOOT_309:SpellBase{
//NAME=橡树的召唤
//TEXT=获得6点护甲值。从你的牌库中召唤一个法力值消耗小于或等于（4）点的随从。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        TaskBuffMyHero(arm:6);
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardType==CardType.Minion && c.GetTag(GameTag.Mana)<=4)
            {
                Pool.Add(c);
            }
        }
        Card ToSummon = Pool.Choice(owner.myPlayer.randomGen);
        new EffectMove(owner.myPlayer,ToSummon,ZoneType.Deck,ZoneType.Board).Resolve();
    }
}
public class CORE_LOOT_413:MinionBase{
//NAME=硬壳甲虫
//TEXT=<b>亡语：</b> 获得3点护甲值。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class CORE_LOOT_507:SpellBase{
//NAME=小型法术钻石
//TEXT=复活两个不同的友方随从。0<i>（施放四个法术后升级。）</i>
//MAJ=PRIEST|COST=7|ATK=0|HP=0|RACE=HOLY
}
public class CORE_LOOT_516:MinionBase{
//NAME=蛇发女妖佐拉
//TEXT=<b>战吼：</b>选择一个友方随从。将它的金色复制置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NAGA
}
public class CORE_NEW1_008:MinionBase{
//NAME=知识古树
//TEXT=<b>抉择：</b>抽两张牌；或者恢复#7点生命值。
//MAJ=DRUID|COST=7|ATK=7|HP=7|RACE=NONE
}
public class CORE_NEW1_010:MinionBase{
//NAME=风领主奥拉基尔
//TEXT=<b>冲锋，圣盾，嘲讽，风怒</b>
//MAJ=SHAMAN|COST=8|ATK=3|HP=6|RACE=ELEMENTAL
    public override void Init()
    {
        TaskInitAbility("Charge");
        TaskInitAbility("DivineShield");
        TaskInitAbility("Taunt");
        TaskInitAbility("WindFury");
    }
}
public class CORE_NEW1_018:MinionBase{
//NAME=血帆袭击者
//TEXT=<b>战吼：</b> 获得等同于你的武器攻击力的攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=PIRATE
}
public class CORE_NEW1_020:MinionBase{
//NAME=狂野炎术师
//TEXT=在你施放一个法术后，对所有随从造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=UNDEAD
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
                TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
            }
        }
    }
}
public class CORE_NEW1_021:MinionBase{
//NAME=末日预言者
//TEXT=在你的回合开始时，消灭所有随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=7|RACE=NONE
}
public class CORE_NEW1_022:MinionBase{
//NAME=恐怖海盗
//TEXT=<b>嘲讽</b> 你的武器每有1点攻击力，该牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=PIRATE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.myPlayer.weapon.Count>0)
            {
                return -owner.myPlayer.weapon[0].GetTag(GameTag.Attack);
            }
        }
        return 0;
    }
}
public class CORE_NEW1_023:MinionBase{
//NAME=精灵龙
//TEXT=<b>扰魔</b>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=DRAGON
}
public class CORE_NEW1_026:MinionBase{
//NAME=紫罗兰教师
//TEXT=每当你施放一个法术，召唤一个1/1的紫罗兰学徒。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class CORE_NEW1_027:MinionBase{
//NAME=南海船长
//TEXT=你的其他海盗拥有+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=PIRATE
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Pirate) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "NEW1_027e";
    }
}
public class CORE_NEW1_031:SpellBase{
//NAME=动物伙伴
//TEXT=随机召唤一个野兽伙伴。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<string> ToListSummon = new List<string>(){"NEW1_032","NEW1_033","NEW1_034"};
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid(ToListSummon.Choice(owner.myPlayer.randomGen));
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class CORE_OG_028:MinionBase{
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
public class CORE_OG_044:MinionBase{
//NAME=范达尔·鹿盔
//TEXT=你的<b>抉择</b>牌和英雄技能可以同时拥有两种效果。
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=NONE
}
public class CORE_OG_047:SpellBase{
//NAME=野性之怒
//TEXT=<b>抉择：</b>使你的英雄在本回合中获得+4攻击力；或者获得8点护甲值。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class CORE_OG_070:MinionBase{
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
public class CORE_OG_109:MinionBase{
//NAME=夜色镇图书管理员
//TEXT=<b>战吼：</b> 随机弃一张牌。 <b>亡语：</b> 抽一张牌。
//MAJ=WARLOCK|COST=2|ATK=3|HP=2|RACE=NONE
}
public class CORE_OG_218:MinionBase{
//NAME=血蹄勇士
//TEXT=<b>嘲讽</b> 受伤时拥有+3攻 击力。
//MAJ=WARRIOR|COST=4|ATK=2|HP=6|RACE=NONE
}
public class CORE_OG_229:MinionBase{
//NAME=光耀之主拉格纳罗斯
//TEXT=在你的回合结束时，为一个受伤的友方角色恢复#8点生命值。
//MAJ=PALADIN|COST=8|ATK=8|HP=8|RACE=ELEMENTAL
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
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
public class CORE_OG_241:MinionBase{
//NAME=着魔村民
//TEXT=<b>亡语：</b>召唤一个1/1的暗影兽。
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CORE_OG_254:MinionBase{
//NAME=奥秘吞噬者
//TEXT=<b>战吼：</b>摧毁所有敌方<b>奥秘</b>。每摧毁一个，便获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=NONE
}
public class CORE_OG_273:SpellBase{
//NAME=惩黑除恶
//TEXT=召唤五个1/1的白银之手新兵。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class CORE_ONY_024:MinionBase{
//NAME=奥妮克希亚幼龙
//TEXT=<b>嘲讽</b>，<b>战吼：</b>对一个敌方随从造成等同于你的护甲值的伤害。
//MAJ=WARRIOR|COST=4|ATK=4|HP=5|RACE=DRAGON
}
public class CORE_REV_023:MinionBase{
//NAME=拆迁修理工
//TEXT=<b>可交易</b> <b>战吼：</b>摧毁一个敌方地标。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class CORE_REV_923:LocationBase{
//NAME=淤泥之池
//TEXT=将一个友方随从变形成为法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=1|ATK=0|HP=3|RACE=NONE
}
public class CORE_REV_990:LocationBase{
//NAME=赤红深渊
//TEXT=对一个随从造成1点伤害，并使其获得+2攻击力。
//MAJ=WARRIOR|COST=1|ATK=0|HP=3|RACE=NONE
}
public class CORE_RLK_012:WeaponBase{
//NAME=断魂
//TEXT=在你的英雄攻击并消灭一个随从后，获得2具 <b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=2|RACE=NONE
}
public class CORE_RLK_035:SpellBase{
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
public class CORE_RLK_042:SpellBase{
//NAME=寒冬号角
//TEXT=复原两个法力水晶。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=FROST
}
public class CORE_RLK_051:SpellBase{
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
public class CORE_RLK_062:MinionBase{
//NAME=蛛魔护群守卫
//TEXT=<b>嘲讽</b>。<b>战吼：</b>召唤本随从的两个复制。
//MAJ=DEATHKNIGHT|COST=4|ATK=1|HP=3|RACE=UNDEAD
}
public class CORE_RLK_063:SpellBase{
//NAME=冰霜巨龙之怒
//TEXT=造成$5点伤害。<b>冻结</b>所有敌方随从。召唤一条5/5的冰霜巨龙。
//MAJ=DEATHKNIGHT|COST=7|ATK=0|HP=0|RACE=FROST
}
public class CORE_RLK_066:MinionBase{
//NAME=鲜血魔术师
//TEXT=<b>战吼：</b>消耗一具<b>尸体</b>，<b>发现</b>一张鲜血符文牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=3|RACE=NONE
}
public class CORE_RLK_086:WeaponBase{
//NAME=霜之哀伤
//TEXT=<b>亡语：</b>召唤被该武器消灭的所有 随从。
//MAJ=DEATHKNIGHT|COST=6|ATK=4|HP=3|RACE=NONE
}
public class CORE_RLK_087:SpellBase{
//NAME=窒息
//TEXT=消灭攻击力最高的敌方随从。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_RLK_116:MinionBase{
//NAME=死灵殡葬师
//TEXT=<b>战吼：</b>如果在你的上回合之后有友方亡灵死亡，<b>发现</b>一张邪恶符文牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=2|HP=3|RACE=NONE
}
public class CORE_RLK_121:MinionBase{
//NAME=死亡侍僧
//TEXT=在一个友方亡灵死亡后，抽一张牌。
//MAJ=DEATHKNIGHT|COST=3|ATK=2|HP=4|RACE=NONE
}
public class CORE_RLK_122:SpellBase{
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
            "RLK_658"
        };
        foreach(string s in ToListSummon)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid(s),ZoneType.Board);
        }
    }
}
public class CORE_RLK_504:MinionBase{
//NAME=僵尸新娘
//TEXT=<b>战吼：</b>消耗最多10具<b>尸体</b>，召唤一个属性值等同于消耗尸体数的复活的新郎。
//MAJ=DEATHKNIGHT|COST=5|ATK=4|HP=4|RACE=UNDEAD
}
public class CORE_RLK_505:MinionBase{
//NAME=髓骨使御者
//TEXT=<b>战吼：</b>消耗最多5具<b>尸体</b>。每消耗一具尸体，随机对一个敌人造成2点伤害。
//MAJ=DEATHKNIGHT|COST=6|ATK=5|HP=5|RACE=UNDEAD
}
public class CORE_RLK_712:SpellBase{
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
public class CORE_RLK_740:WeaponBase{
//NAME=米奈希尔之力
//TEXT=<b>战吼：</b>消耗最多3具<b>尸体</b>，<b>冻结</b>等量的敌方随从。
//MAJ=DEATHKNIGHT|COST=4|ATK=4|HP=2|RACE=NONE
}
public class CORE_RLK_741:MinionBase{
//NAME=窃魂者
//TEXT=<b>战吼：</b> 消灭所有其他随从。每消灭一个敌方随从，获得1具<b>尸体</b>。
//MAJ=DEATHKNIGHT|COST=8|ATK=5|HP=5|RACE=UNDEAD
}
public class CORE_SCH_158:SpellBase{
//NAME=恶魔研习
//TEXT=<b>发现</b>一张恶魔牌。你的下一张恶魔牌法力值消耗减少（1）点。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_SCH_160:MinionBase{
//NAME=魔杖工匠
//TEXT=<b>战吼：</b>随机将一张你职业的法力值消耗为（1）的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CORE_SCH_312:MinionBase{
//NAME=巡游向导
//TEXT=<b>战吼：</b> 你的下一个英雄技能的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.power.Count>0)
        {
            Card PowCard = owner.myPlayer.power[0];
            PowCard.SetTag(GameTag.ManaFot,-PowCard.GetTag(GameTag.Mana));
            new EffectChange(owner.myPlayer,owner,PowCard).Resolve();
        }
    }
}
public class CORE_SCH_706:SecretBase{
//NAME=抄袭
//TEXT=<b>奥秘：</b>在你对手的回合结束时，将其使用的卡牌的复制置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CORE_SCH_713:MinionBase{
//NAME=异教低阶牧师
//TEXT=<b>战吼：</b>下个回合你的对手法术的法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        foreach(Card c in owner.myPlayer.otherPlayer.hand.Merge(owner.myPlayer.otherPlayer.board))
        {
            if(c.cardType==CardType.Spell)
            {
                c.ChangeTag(GameTag.ManaFot,1);
            }
        }
    }
}
public class CORE_SW_030:MinionBase{
//NAME=货物保镖
//TEXT=在你的回合结束时，获得3点护甲值。
//MAJ=WARRIOR|COST=3|ATK=2|HP=4|RACE=PIRATE
}
public class CORE_SW_066:MinionBase{
//NAME=王室图书管理员
//TEXT=<b>可交易</b> <b>战吼：</b><b>沉默</b>一个 随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class CORE_SW_072:MinionBase{
//NAME=锈烂蝰蛇
//TEXT=<b>可交易</b> <b>战吼：</b>摧毁对手的武器。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=BEAST
}
public class Core_SW_084:MinionBase{
//NAME=血缚小鬼
//TEXT=每当本随从攻击时，对你的英雄造成2点伤害。
//MAJ=WARLOCK|COST=2|ATK=2|HP=5|RACE=DEMON
}
public class CORE_SW_085:SpellBase{
//NAME=暗巷契约
//TEXT=召唤一个属性值等同于你的手牌数量并具有<b>嘲讽</b>的邪魔。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("SW_085t");
        int Cnt = owner.myPlayer.hand.Count;
        ToSummon.Attack=Cnt;
        ToSummon.MaxHealth=Cnt;
        ToSummon.ManaCost=Cnt;
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class CORE_SW_094:SpellBase{
//NAME=厚重板甲
//TEXT=<b>可交易</b> 获得8点护甲值。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class CORE_SW_107:SpellBase{
//NAME=火热促销
//TEXT=<b>可交易</b> 对所有随从造成 $3点伤害。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class CORE_SW_114:SpellBase{
//NAME=强行透支
//TEXT=<b>可交易</b> 解锁你<b>过载</b>的法力水晶，并造成等量的 伤害。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,owner.myPlayer.GetTag(GameTag.ManaOverLoad)).Resolve();
        owner.myPlayer.SetTag(GameTag.ManaOverLoad,0);
    }
}
public class CORE_SW_429:SpellBase{
//NAME=紧壳商品
//TEXT=<b>可交易</b> 召唤两只2/7并具有<b>嘲讽</b>的龟。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NONE
}
public class CORE_SW_431:MinionBase{
//NAME=花园猎豹
//TEXT=<b>突袭</b> 每当本随从攻击时，使你的英雄在本回合中获得+3攻击力。
//MAJ=DRUID|COST=4|ATK=4|HP=4|RACE=BEAST
}
public class CORE_SW_441:SpellBase{
//NAME=纳鲁碎片
//TEXT=<b>可交易</b> <b>沉默</b>所有敌方随从。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class CORE_SW_442:SpellBase{
//NAME=虚空碎片
//TEXT=<b>吸血</b> 造成$4点伤害。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class CORE_SW_448:MinionBase{
//NAME=黑暗主教本尼迪塔斯
//TEXT=<b>对战开始时：</b>如果你的套牌中所有法术牌都是暗影法术牌，则进入暗影形态。
//MAJ=PRIEST|COST=5|ATK=5|HP=6|RACE=NONE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterGameStart(this,CauseEvent));
    }
    public void CauseEvent()
    {
        bool OnlyShadow = true;
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardType==CardType.Spell)
            {
                if(!c.spellType.Contains(SpellSchoolType.Shadow))
                {
                    OnlyShadow=false;
                    break;
                }
            }
        }
        if(OnlyShadow)
        {
            if(owner.myPlayer.power.Count>0)
            {
                Card PowCard = owner.myPlayer.power[0];
                new EffectDestroy(owner.myPlayer,owner,PowCard).Resolve();
            }
            TaskCreate(CardDbf.GetCardDbfByGuid("EX1_625t"),ZoneType.Power);
        }
    }
}
public class CORE_TOY_100:MinionBase{
//NAME=侏儒飞行员诺莉亚
//TEXT=<b>突袭</b>。同时对其攻击目标相邻的随从造成伤害。<b>亡语：</b>对所有敌人造成2点伤害。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=2|RACE=NONE
}
public class CORE_TOY_101:MinionBase{
//NAME=暗夜精灵女猎手
//TEXT=<b>战吼：</b>对三个不同的敌人各造成3点伤害。<i>（目标由你选定！）</i>
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class CORE_TOY_102:MinionBase{
//NAME=人类步兵
//TEXT=<b>嘲讽</b>。相邻随从在攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=NONE
}
public class CORE_TOY_103:MinionBase{
//NAME=战歌步兵
//TEXT=<b>突袭</b> 在本随从攻击并消灭一个随从后，可再次攻击。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=NONE
}
public class CORE_TRL_111:WeaponBase{
//NAME=猎头者之斧
//TEXT=<b>战吼：</b>如果你控制一个野兽，便获得+1耐久度。
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CORE_TRL_124:SpellBase{
//NAME=团伙劫掠
//TEXT=从你的牌库中抽两张海盗牌。 <b>连击：</b>并抽一张 武器牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class CORE_TRL_243:SpellBase{
//NAME=飞扑
//TEXT=在本回合中，使你的英雄获得+2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CORE_TRL_252:MinionBase{
//NAME=高阶祭司耶克里克
//TEXT=<b>嘲讽，吸血</b> 当你弃掉这张牌时，将这张牌的两张复制置入你的手牌。
//MAJ=WARLOCK|COST=4|ATK=3|HP=5|RACE=NONE
}
public class CORE_TRL_307:SpellBase{
//NAME=圣光闪现
//TEXT=恢复#4点生命值。抽一张牌。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class CORE_TRL_315:MinionBase{
//NAME=火焰狂人
//TEXT=每当你的英雄技能消灭一个随从，抽 一张牌。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=NONE
}
public class CORE_TRL_339:SpellBase{
//NAME=主人的召唤
//TEXT=从你的牌库中<b>发现</b>一张随从牌。如果三张牌都是野兽，则抽取全部三张牌。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardType==CardType.Minion)
            {
                Pool.Add(c);
            }
        }
        List<Card> ToListDiscover = new List<Card>();
        bool AllBeast=true;
        while(true)
        {
            if(ToListDiscover.Count>=3 || Pool.Count==0)
            {
                break;
            }
            Card ToAdd = Pool.Choice(owner.myPlayer.randomGen);

            if(ToAdd!=null)
            {
                Pool.Remove(ToAdd);
                ToListDiscover.Add(ToAdd);                
                if(!ToAdd.raceType.Contains(RaceType.Beast))
                {
                    AllBeast=false;
                }
            }
        }
        if(AllBeast)
        {
            foreach(Card c in ToListDiscover)
            {
                TaskDraw(c);
            }
        }
        else{
            TaskDraw(ToListDiscover.Choice(owner.myPlayer.randomGen));
        }
    }
}
public class CORE_TRL_345:MinionBase{
//NAME=卡格瓦，青蛙之神
//TEXT=<b>战吼：</b>将你上回合使用的所有法术牌移回你的手牌。
//MAJ=SHAMAN|COST=6|ATK=4|HP=6|RACE=BEAST
}
public class CORE_TRL_348:MinionBase{
//NAME=魔泉山猫
//TEXT=<b>突袭，战吼：</b>将一张1/1并具有<b>突袭</b>的山猫置入你的手牌。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class CORE_TSC_217:MinionBase{
//NAME=游荡贤者
//TEXT=<b>流放：</b>使你最左边和最右边的手牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=2|RACE=NAGA
}
public class CORE_TSC_827:MinionBase{
//NAME=凶恶的滑矛纳迦
//TEXT=在你施放一个法术后，直到你的下个回合，获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NAGA
}
public class CORE_tt_004:MinionBase{
//NAME=腐肉食尸鬼
//TEXT=每当一个随从死亡，便获得+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class CORE_ULD_178:MinionBase{
//NAME=希亚玛特
//TEXT=<b>战吼：</b>从<b>突袭，嘲讽，圣盾</b>或<b>风怒</b>中获得两种效果<i>（由你选择）</i>。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=ELEMENTAL
}
public class CORE_ULD_191:MinionBase{
//NAME=欢快的同伴
//TEXT=<b>战吼：</b>使一个友方随从获得+2生命值。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class CORE_ULD_195:MinionBase{
//NAME=惊恐的仆从
//TEXT=<b>嘲讽，战吼：</b> <b>发现</b>一张具有<b>嘲讽</b>的随从牌。
//MAJ=WARRIOR|COST=2|ATK=2|HP=3|RACE=NONE
}
public class CORE_ULD_209:MinionBase{
//NAME=狐人恶棍
//TEXT=<b>战吼：发现</b>一张法术牌或选择一个 神秘选项。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class CORE_ULD_258:MinionBase{
//NAME=硕铠鼠
//TEXT=<b>嘲讽</b> 在你的回合结束时，使你手牌中所有<b>嘲讽</b>随从牌获得+2/+2。
//MAJ=WARRIOR|COST=6|ATK=4|HP=8|RACE=BEAST
}
public class CORE_ULD_271:MinionBase{
//NAME=受伤的托维尔人
//TEXT=<b>嘲讽</b>。<b>战吼：</b>对本随从造成3点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=6|RACE=NONE
}
public class CORE_ULD_707:SpellBase{
//NAME=愤怒之灾祸
//TEXT=消灭所有受伤的随从。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CORE_ULD_723:MinionBase{
//NAME=鱼人木乃伊
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class CORE_UNG_018:SpellBase{
//NAME=烈焰喷涌
//TEXT=造成$2点伤害。 将一张1/2的元素牌置入你的手牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FIRE
}
public class Core_UNG_019:MinionBase{
//NAME=空气元素
//TEXT=<b>扰魔</b>
//MAJ=SHAMAN|COST=1|ATK=3|HP=1|RACE=ELEMENTAL
}
public class CORE_UNG_020:MinionBase{
//NAME=秘法学家
//TEXT=<b>战吼：</b>抽一张<b>奥秘</b>牌。
//MAJ=MAGE|COST=2|ATK=2|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDrawType(CardType.Secret);
    }
}
public class CORE_UNG_034:MinionBase{
//NAME=光照元素
//TEXT=你的法术的法力值消耗减少（1）点。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand && c.cardType==CardType.Spell && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "UNG_034e";
    }
}
public class Core_UNG_072:MinionBase{
//NAME=石丘防御者
//TEXT=<b>嘲讽</b>，<b>战吼：</b> <b>发现</b>一张具有<b>嘲讽</b>的随从牌。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class CORE_UNG_108:SpellBase{
//NAME=大地之鳞
//TEXT=使一个友方随从获得+1/+1，然后获得等同于其攻击力的 护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class CORE_UNG_205:MinionBase{
//NAME=冰川裂片
//TEXT=<b>战吼：</b> <b>冻结</b>一个敌人。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=ELEMENTAL
}
public class Core_UNG_211:MinionBase{
//NAME=荒蛮之主卡利莫斯
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，则施放一个元素祈咒。
//MAJ=SHAMAN|COST=7|ATK=7|HP=7|RACE=ELEMENTAL
}
public class CORE_UNG_809:MinionBase{
//NAME=火羽精灵
//TEXT=<b>战吼：</b>将一张1/2的元素牌置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=ELEMENTAL
    public override void Battlecry(Card target =null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("UNG_809t1"),ZoneType.Hand);
    }
}
public class CORE_UNG_813:MinionBase{
//NAME=风暴看守
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=7|ATK=4|HP=8|RACE=ELEMENTAL
}
public class CORE_UNG_817:SpellBase{
//NAME=海潮涌动
//TEXT=<b>吸血</b> 对一个随从造成$5点伤害。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class CORE_UNG_833:MinionBase{
//NAME=拉卡利地狱犬
//TEXT=<b>嘲讽</b>，<b>战吼：</b>弃掉你手牌中法力值消耗最低的两张牌。
//MAJ=WARLOCK|COST=4|ATK=3|HP=8|RACE=DEMON
}
public class CORE_UNG_844:MinionBase{
//NAME=巨齿刀叶
//TEXT=无法攻击。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=8|RACE=NONE
}
public class CORE_UNG_848:MinionBase{
//NAME=始生幼龙
//TEXT=<b>嘲讽，战吼：</b> 对所有其他随从造成2点伤害。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=8|RACE=DRAGON
}
public class CORE_UNG_912:MinionBase{
//NAME=宝石鹦鹉
//TEXT=<b>战吼：</b>随机将一张野兽牌置入你的手牌。
//MAJ=HUNTER|COST=1|ATK=1|HP=2|RACE=BEAST
}
public class CORE_UNG_928:MinionBase{
//NAME=焦油爬行者
//TEXT=<b>嘲讽</b> 在你对手的回合拥有+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=ELEMENTAL
}
public class CORE_UNG_941:SpellBase{
//NAME=远古雕文
//TEXT=<b>发现</b>一张法术牌，使其法力值消耗减少（2）点。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class CORE_UNG_952:SpellBase{
//NAME=剑龙骑术
//TEXT=使一个随从获得+2/+6和<b>嘲讽</b>。当该随从死亡时，召唤一只剑龙。
//MAJ=PALADIN|COST=6|ATK=0|HP=0|RACE=NONE
}
public class CORE_UNG_963:MinionBase{
//NAME=“太阳裂片”莱拉
//TEXT=每当你施放一个法术，随机将一张牧师法术牌置入你的手牌。
//MAJ=PRIEST|COST=4|ATK=3|HP=5|RACE=ELEMENTAL
}
public class CORE_VAN_EX1_561:MinionBase{
//NAME=阿莱克丝塔萨
//TEXT=<b>战吼：</b> 将一方英雄的剩余生命值变为15。
//MAJ=NEUTRAL|COST=9|ATK=8|HP=8|RACE=DRAGON
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,hpChange:15-target.GetTag(GameTag.Health)).Resolve();
    }
}
public class CORE_VAN_EX1_563:MinionBase{
//NAME=玛里苟斯
//TEXT=<b>法术伤害+5</b>
//MAJ=NEUTRAL|COST=9|ATK=4|HP=12|RACE=DRAGON
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.cardType==CardType.Spell && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "EX1_563e";
    }
}
public class CORE_VAN_EX1_572:MinionBase{
//NAME=伊瑟拉
//TEXT=在你的回合结束时，随机获取两张梦境牌。
//MAJ=NEUTRAL|COST=9|ATK=4|HP=12|RACE=DRAGON
}
public class CORE_WON_065:MinionBase{
//NAME=随船外科医师
//TEXT=在你召唤一个随从后，使其获 得+1生命值。
//MAJ=PRIEST|COST=1|ATK=1|HP=2|RACE=DRAGON
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
        if(tz==ZoneType.Board && owner.GetTag(GameTag.ZoneType) == (int)ZoneType.Board && sc!=owner)
        {
            new EffectChange(owner.myPlayer,owner,sc,hpChange:1).Resolve();
        }
    }
}
public class CORE_YOD_006:MinionBase{
//NAME=奔逃的魔刃豹
//TEXT=<b>潜行</b> 每当本随从攻击，便获得一个仅限本回合可用的法力水晶。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=BEAST
}
public class CORE_YOP_001:SpellBase{
//NAME=伊利达雷研习
//TEXT=<b>发现</b>一张<b>流放</b>牌。你的下一张<b>流放</b>牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CORE_YOP_032:MinionBase{
//NAME=护甲商贩
//TEXT=<b>战吼：</b>使每个英雄获得4点护甲值。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NONE
}
