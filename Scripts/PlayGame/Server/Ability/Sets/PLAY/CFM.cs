using System.Collections;
using System.Collections.Generic;

public class CFM_020:MinionBase{
//NAME=缚链者拉兹
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则在本局对战中，你的英雄技能的法力值消耗为（0）点。
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=NONE
}
public class CFM_020e:Ability{
//NAME=拉兹强化
//TEXT=你的<b>英雄技能</b>的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_021:SpellBase{
//NAME=冰冻药水
//TEXT=<b>冻结</b>一个敌人。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=FROST
}
public class CFM_025:MinionBase{
//NAME=发条强盗机器人
//TEXT=每当本随从攻击随从并存活下来时，抽一张牌。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=MECHANICAL
}
public class CFM_026:SecretBase{
//NAME=军备宝箱
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，随机使你手牌中的一张随从牌获得+2/+2。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CFM_026e:Ability{
//NAME=走私
//TEXT=军备宝箱使其获得+2/+2。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_039:MinionBase{
//NAME=杂耍小鬼
//TEXT=<b>法术伤害+2</b>
//MAJ=NEUTRAL|COST=3|ATK=0|HP=7|RACE=DEMON
}
public class CFM_060:MinionBase{
//NAME=猩红法力浮龙
//TEXT=每当你施放一个法术，便获得 +2攻击力。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=6|RACE=NONE
}
public class CFM_060e:Ability{
//NAME=法力强攻
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_061:MinionBase{
//NAME=锦鱼人水语者
//TEXT=<b>战吼：</b>恢复#6点生命值。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=4|ATK=4|HP=6|RACE=NONE
}
public class CFM_062:MinionBase{
//NAME=污手街守护者
//TEXT=<b>嘲讽，战吼：</b>使相邻的随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=7|ATK=6|HP=6|RACE=NONE
}
public class CFM_063:MinionBase{
//NAME=化学怪人
//TEXT=<b>战吼：</b> 使一个随从的攻击力和生命值互换。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class CFM_063e:Ability{
//NAME=化学怪人
//TEXT=化学怪人使其攻击力和生命值互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_064:MinionBase{
//NAME=黑金大亨
//TEXT=每当你召唤一个具有<b>战吼</b>的随从时，便使这张牌（在你手牌中时）获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=NONE
}
public class CFM_064e:Ability{
//NAME=体型增大
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_065:SpellBase{
//NAME=火山药水
//TEXT=对所有随从造成$2点伤害。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class CFM_066:MinionBase{
//NAME=暗金教侍从
//TEXT=<b>战吼：</b> 在本回合中，你使用的下一个<b>奥秘</b>的法力值消耗为（1）点。
//MAJ=MAGE|COST=1|ATK=2|HP=1|RACE=NONE
    private bool on = false;
    public override void Battlecry(Card target = null)
    {

        base.Battlecry(target);
        on = true;
        foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
        {
            if (c.cardType == CardType.Secret)
            {
                new EffectChange(owner.myPlayer,owner, c, -3, 0, 0, 0).Resolve();
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
        if (sc.cardType == CardType.Secret && on && sc!=owner)
        {
            foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
            {
                if (c.cardType == CardType.Secret)
                {
                    new EffectChange(owner.myPlayer,owner, c, 3, 0, 0, 0).Resolve();
                }
            }
            on = false;
        }
    }
}
public class CFM_067:MinionBase{
//NAME=猢狲医者
//TEXT=<b>战吼：</b>为一个随从恢复所有生命值。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
}
public class CFM_094:SpellBase{
//NAME=邪火药水
//TEXT=对所有角色造成$5点伤害。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=FEL
}
public class CFM_095:MinionBase{
//NAME=鼬鼠挖掘工
//TEXT=<b>亡语：</b>将本随从洗入你对手的牌库。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class CFM_120:MinionBase{
//NAME=亡灵药剂师
//TEXT=<b>亡语：</b>为每个英雄恢复#4点生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=UNDEAD
    public override void Deathrattle()
    {
        TaskHealMyHero(4);
        TaskHealEnemyHero(4);
    }
}
public class CFM_300:MinionBase{
//NAME=公辩律师
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=2|ATK=0|HP=7|RACE=NONE
}
public class CFM_305:SpellBase{
//NAME=风驰电掣
//TEXT=使你手牌中的所有随从牌获得+1/+1。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_305e:Ability{
//NAME=走私
//TEXT=风驰电掣使其获得+1/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_308:MinionBase{
//NAME=遗忘之王库恩
//TEXT=<b>抉择：</b>获得10点护甲值；或者复原你的法力水晶。
//MAJ=DRUID|COST=10|ATK=7|HP=7|RACE=UNDEAD
}
public class CFM_308a:SpellBase{
//NAME=遗忘护甲
//TEXT=获得10点护甲值。
//MAJ=DRUID|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_308b:SpellBase{
//NAME=遗忘法力
//TEXT=复原你的法力水晶。
//MAJ=DRUID|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_310:SpellBase{
//NAME=神奇四鱼
//TEXT=召唤四个1/1的鱼人。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class CFM_310t:MinionBase{
//NAME=剃鳃鱼人
//TEXT=
//MAJ=SHAMAN|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class CFM_312:MinionBase{
//NAME=青玉酋长
//TEXT=<b>战吼：</b>召唤一个{0}的<b>青玉魔像</b>，使其获得<b>嘲讽</b>。0<b>战吼：</b>召唤一个<b>青玉魔像</b>，使其获得 <b>嘲讽</b>。
//MAJ=SHAMAN|COST=6|ATK=5|HP=5|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.CntJadeGolem,1);
        int JadeTime=owner.myPlayer.GetTag(GameTag.CntJadeGolem);
        string JadeID="CFM_712_t";
        if(JadeTime<=9)
        {
            JadeID+="0"; 
        }
        if(JadeTime>=30)
        {
            JadeTime=30;
        }
        JadeID+=JadeTime.ToString();
        CardDbf Jade = CardDbf.GetCardDbfByGuid(JadeID);
        Card JadeCard = TaskCreate(Jade,ZoneType.Board);
        new EffectGiveAbility(owner.myPlayer,owner,JadeCard,"Taunt").Resolve();
    }
}
public class CFM_313:SpellBase{
//NAME=先到先得
//TEXT=<b>发现</b>一张具有<b>过载</b>的牌。 <b>过载：</b> （1）
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_315:MinionBase{
//NAME=雄斑虎
//TEXT=<b>战吼：</b>召唤一个1/1的雌斑虎。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("CFM_315t"),ZoneType.Board);
    }
}
public class CFM_315t:MinionBase{
//NAME=雌斑虎
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class CFM_316:MinionBase{
//NAME=瘟疫鼠群
//TEXT=<b>亡语：</b>召唤若干个1/1的老鼠，数量等同于本随从的攻击力。
//MAJ=HUNTER|COST=3|ATK=2|HP=2|RACE=BEAST
}
public class CFM_316t:MinionBase{
//NAME=老鼠
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class CFM_321:MinionBase{
//NAME=污手街情报员
//TEXT=<b>战吼：</b><b>发现</b>一张 猎人、圣骑士或战士卡牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CFM_324:MinionBase{
//NAME=白眼大侠
//TEXT=<b>嘲讽，亡语：</b> 将风暴守护者洗入你的牌库。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NONE
}
public class CFM_324t:MinionBase{
//NAME=风暴守护者
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=5|ATK=10|HP=10|RACE=NONE
}
public class CFM_325:MinionBase{
//NAME=蹩脚海盗
//TEXT=如果你装备着武器，本随从拥有 +2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=PIRATE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            if(owner.myPlayer.weapon.Count>0)
            {
                return 2;
            }
        }
        return 0;
    }
}
public class CFM_325e:Ability{
//NAME=装备
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_328:MinionBase{
//NAME=竞技推广员
//TEXT=<b>战吼：</b>如果你控制一个生命值大于或等于6的随从，抽两张牌。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
}
public class CFM_333:MinionBase{
//NAME=金手指纳克斯
//TEXT=在纳克斯攻击一名随从后，还会命中敌方英雄。
//MAJ=HUNTER|COST=5|ATK=3|HP=7|RACE=BEAST
}
public class CFM_334:SpellBase{
//NAME=走私货物
//TEXT=随机使你手牌中的一张野兽牌获得+2/+2。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_334e:Ability{
//NAME=走私
//TEXT=走私货物使其获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_335:MinionBase{
//NAME=驮运科多兽
//TEXT=<b>战吼：</b>造成等同于本随从攻击力的伤害。
//MAJ=HUNTER|COST=4|ATK=2|HP=4|RACE=BEAST
}
public class CFM_336:MinionBase{
//NAME=豺狼人土枪手
//TEXT=<b>亡语：</b>随机使你手牌中的一张随从牌获得+2/+2。
//MAJ=HUNTER|COST=3|ATK=4|HP=3|RACE=NONE
}
public class CFM_336e:Ability{
//NAME=走私
//TEXT=豺狼人土枪手使其获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_337:WeaponBase{
//NAME=食人鱼喷枪
//TEXT=在你的英雄攻击后，召唤一个1/1的食人鱼。
//MAJ=HUNTER|COST=5|ATK=2|HP=4|RACE=NONE
}
public class CFM_337t:MinionBase{
//NAME=食人鱼
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class CFM_338:MinionBase{
//NAME=穴居人驯兽师
//TEXT=<b>战吼：</b>随机使你手牌中的一张野兽牌获得+1/+1。
//MAJ=HUNTER|COST=2|ATK=3|HP=2|RACE=NONE
}
public class CFM_338e:Ability{
//NAME=走私
//TEXT=穴居人驯兽师使其获得+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_341:MinionBase{
//NAME=女警萨莉
//TEXT=<b>亡语：</b>对所有敌方随从造成等同于本随从攻击力的伤害。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=UNDEAD
}
public class CFM_342:MinionBase{
//NAME=土地精海盗
//TEXT=<b>战吼：</b> 如果你的武器至少有3点攻击力，便获得+4/+4。
//MAJ=ROGUE|COST=6|ATK=5|HP=5|RACE=PIRATE
}
public class CFM_342e:Ability{
//NAME=劫掠之刃
//TEXT=+4/+4。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_343:MinionBase{
//NAME=青玉巨兽
//TEXT=<b>嘲讽，战吼：</b>召唤一个{0}的<b>青玉魔像</b>。0<b>嘲讽，战吼：</b>召唤一个<b>青玉魔像</b>。
//MAJ=DRUID|COST=5|ATK=3|HP=6|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.CntJadeGolem,1);
        int JadeTime=owner.myPlayer.GetTag(GameTag.CntJadeGolem);
        string JadeID="CFM_712_t";
        if(JadeTime<=9)
        {
            JadeID+="0"; 
        }
        if(JadeTime>=30)
        {
            JadeTime=30;
        }
        JadeID+=JadeTime.ToString();
        CardDbf Jade = CardDbf.GetCardDbfByGuid(JadeID);
        TaskCreate(Jade,ZoneType.Board);
    }
}
public class CFM_344:MinionBase{
//NAME=飞火流星·芬杰
//TEXT=<b>潜行</b> 每当本随从攻击并消灭一个随从，便从你的牌库中召唤两个鱼人。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=4|RACE=MURLOC
}
public class CFM_602:SpellBase{
//NAME=青玉护符
//TEXT=<b>抉择：</b>召唤一个{0}的<b>青玉魔像</b>；或者将该牌的三张复制洗入你的牌库。0<b>抉择：</b>召唤一个<b>青玉魔像</b>；或者将该牌的三张复制洗入你的 牌库。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(target==owner.myPlayer.hero[0])
        {
            TaskCreate(owner.cardDbf,ZoneType.Deck);
        }
        else{
            owner.myPlayer.ChangeTag(GameTag.CntJadeGolem,1);
            int JadeTime=owner.myPlayer.GetTag(GameTag.CntJadeGolem);
            string JadeID="CFM_712_t";
            if(JadeTime<=9)
            {
                JadeID+="0"; 
            }
            if(JadeTime>=30)
            {
                JadeTime=30;
            }
            JadeID+=JadeTime.ToString();
            CardDbf Jade = CardDbf.GetCardDbfByGuid(JadeID);
            TaskCreate(Jade,ZoneType.Board);            
        }
    }
}
public class CFM_602a:SpellBase{
//NAME=雕琢玉像
//TEXT=召唤一个{0}的<b>青玉魔像</b>。0召唤一个<b>青玉魔像</b>。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_602b:SpellBase{
//NAME=青玉秘藏
//TEXT=将三张“青玉护符”洗入你的 牌库。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_603:SpellBase{
//NAME=疯狂药水
//TEXT=直到回合结束，获得一个攻击力小于或等于2的敌方随从的控制权。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class CFM_603e:Ability{
//NAME=疯狂药水
//TEXT=在本回合中，本随从的控制权发生了变化。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_604:SpellBase{
//NAME=强效治疗药水
//TEXT=为一个友方角色恢复#12点 生命值。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class CFM_605:MinionBase{
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
public class CFM_606:MinionBase{
//NAME=法力晶簇
//TEXT=<b>过量治疗：</b>召唤一个2/2的水晶。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=ELEMENTAL
}
public class CFM_606t:MinionBase{
//NAME=水晶
//TEXT=
//MAJ=PRIEST|COST=2|ATK=2|HP=2|RACE=ELEMENTAL
}
public class CFM_608:SpellBase{
//NAME=爆晶药水
//TEXT=消灭一个随从，和你的一个法力水晶。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class CFM_609:MinionBase{
//NAME=邪兽人噬魂魔
//TEXT=在你的回合开始时，对本随从造成2点 伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=7|RACE=NONE
}
public class CFM_610:MinionBase{
//NAME=魔瘾结晶者
//TEXT=<b>战吼：</b>使你的所有恶魔获得+1/+1。
//MAJ=WARLOCK|COST=4|ATK=5|HP=4|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Demon),atk:1,hp:1);
    }
}
public class CFM_610_G:MinionBase{
//NAME=魔瘾结晶者
//TEXT=<b>战吼：</b>使你的所有恶魔获得+1/+1。
//MAJ=WARLOCK|COST=4|ATK=5|HP=4|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Demon),atk:2,hp:2);
    }
}
public class CFM_610e:Ability{
//NAME=噬魂暗影
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_611:SpellBase{
//NAME=血怒药水
//TEXT=使一个随从获得+3攻击力。如果该随从是恶魔，还会获得+3生命值。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class CFM_611e:Ability{
//NAME=恶魔气息
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_611e2:Ability{
//NAME=恶魔气息
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_614:SpellBase{
//NAME=玉莲印记
//TEXT=使你所有的随从获得+1/+1。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskBuffTargets(owner.myPlayer.board,atk:1,hp:1);
    }
}
public class CFM_614e:Ability{
//NAME=野蛮印记
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_616:SpellBase{
//NAME=妙手空空
//TEXT=每控制一个友方随从，便获得一个空的法力水晶。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class CFM_617:MinionBase{
//NAME=天神唤梦者
//TEXT=<b>战吼：</b>如果你控制一个攻击力大于或等于5的随从，便获得+2/+2。
//MAJ=DRUID|COST=3|ATK=3|HP=3|RACE=NONE
}
public class CFM_617e:Ability{
//NAME=梦境视界
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_619:MinionBase{
//NAME=暗金教炼金师
//TEXT=<b>战吼：</b>随机将一张药水牌置入你的手牌。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class CFM_620:SecretBase{
//NAME=变形药水
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，将其变形成为1/1的绵羊。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class CFM_621:MinionBase{
//NAME=卡扎库斯
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则为你创建一个自定义 法术。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class CFM_621_m2:MinionBase{
//NAME=暗金教恶魔
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=DEMON
}
public class CFM_621_m3:MinionBase{
//NAME=暗金教恶魔
//TEXT=
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=DEMON
}
public class CFM_621_m4:MinionBase{
//NAME=暗金教恶魔
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=DEMON
}
public class CFM_621_m5:MinionBase{
//NAME=绵羊
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class CFM_621e:Ability{
//NAME=金棘草
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_621e2:Ability{
//NAME=金棘草
//TEXT=+4生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_621e3:Ability{
//NAME=金棘草
//TEXT=+6生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t:SpellBase{
//NAME=卡扎库斯药水
//TEXT={0} {1}
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t10:SpellBase{
//NAME=虚空花
//TEXT=召唤一个2/2的恶魔。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t11:SpellBase{
//NAME=次级药水
//TEXT=制造一个法力值消耗为（1）的法术。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t12:SpellBase{
//NAME=强效药水
//TEXT=制造一个法力值消耗为（5）的法术。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t13:SpellBase{
//NAME=超级药水
//TEXT=制造一个法力值消耗为（10）的法术。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t14:SpellBase{
//NAME=卡扎库斯药水
//TEXT={0} {1}
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t15:SpellBase{
//NAME=卡扎库斯药水
//TEXT={0} {1}
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t16:SpellBase{
//NAME=火焰之心
//TEXT=造成$5点伤害。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t17:SpellBase{
//NAME=石鳞鱼油
//TEXT=获得7点护甲值。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t18:SpellBase{
//NAME=邪能花
//TEXT=对所有随从造成$4点伤害。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t19:SpellBase{
//NAME=冰盖草
//TEXT=随机<b>冻结</b>两个敌方随从。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t2:SpellBase{
//NAME=火焰之心
//TEXT=造成$3点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t20:SpellBase{
//NAME=虚空花
//TEXT=召唤一个5/5的恶魔。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t21:SpellBase{
//NAME=神秘羊毛
//TEXT=随机使一个敌方随从变形成为1/1的绵羊。1随机使一个敌方随从变形。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t22:SpellBase{
//NAME=皇血草
//TEXT=抽两张牌。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t23:SpellBase{
//NAME=暗影之油
//TEXT=随机将两张恶魔牌置入你的手牌。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t24:SpellBase{
//NAME=金棘草
//TEXT=使你的所有随从获得+4生命值。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t25:SpellBase{
//NAME=火焰之心
//TEXT=造成$8点伤害。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t26:SpellBase{
//NAME=石鳞鱼油
//TEXT=获得10点护甲值。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t27:SpellBase{
//NAME=冰盖草
//TEXT=随机<b>冻结</b>三个敌方随从。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t28:SpellBase{
//NAME=虚空花
//TEXT=召唤一个8/8的恶魔。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t29:SpellBase{
//NAME=神秘羊毛
//TEXT=使所有随从变形成为1/1的绵羊。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t3:SpellBase{
//NAME=石鳞鱼油
//TEXT=获得4点护甲值。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t30:SpellBase{
//NAME=皇血草
//TEXT=抽三张牌。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t31:SpellBase{
//NAME=暗影之油
//TEXT=随机将三张恶魔牌置入你的手牌。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t32:SpellBase{
//NAME=金棘草
//TEXT=使你的所有随从获得+6生命值。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t33:SpellBase{
//NAME=邪能花
//TEXT=对所有随从造成$6点伤害。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t37:SpellBase{
//NAME=亡灵腐液
//TEXT=召唤一个在本局对战中死亡的友方随从。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t38:SpellBase{
//NAME=亡灵腐液
//TEXT=召唤两个在本局对战中死亡的友方随从。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t39:SpellBase{
//NAME=亡灵腐液
//TEXT=召唤三个在本局对战中死亡的友方随从。
//MAJ=NEUTRAL|COST=10|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t4:SpellBase{
//NAME=邪能花
//TEXT=对所有随从造成$2点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t5:SpellBase{
//NAME=冰盖草
//TEXT=随机<b>冻结</b>一个敌方随从。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t6:SpellBase{
//NAME=金棘草
//TEXT=使你的所有随从获得+2生命值。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t8:SpellBase{
//NAME=皇血草
//TEXT=抽一张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_621t9:SpellBase{
//NAME=暗影之油
//TEXT=随机将一张恶魔牌置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_623:SpellBase{
//NAME=强能奥术飞弹
//TEXT=随机对敌人发射三枚飞弹，每枚飞弹造成$3点伤害。
//MAJ=MAGE|COST=7|ATK=0|HP=0|RACE=ARCANE
    public override void Battlecry(Card target=null)
    {
        TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),3,single:3);
    }
}
public class CFM_626:MinionBase{
//NAME=暗金教鸦人祭司
//TEXT=<b>战吼：</b>使一个友方随从获得+3生命值。
//MAJ=PRIEST|COST=3|ATK=3|HP=4|RACE=NONE
}
public class CFM_626e:Ability{
//NAME=坚韧
//TEXT=+3生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_630:SpellBase{
//NAME=伪造的幸运币
//TEXT=在本回合中，获得一个法力 水晶。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaLeft,1);
        TaskBuffMyHero();
    }
}
public class CFM_631:WeaponBase{
//NAME=黄铜指虎
//TEXT=在你的英雄攻击后，随机使你手牌中的一张随从牌获得+1/+1。
//MAJ=WARRIOR|COST=3|ATK=2|HP=3|RACE=NONE
}
public class CFM_631e:Ability{
//NAME=走私
//TEXT=黄铜指虎使其获得属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_634:MinionBase{
//NAME=玉莲帮刺客
//TEXT=<b>潜行</b>。每当本随从攻击并消灭一个随从时，便获得<b>潜行</b>。
//MAJ=ROGUE|COST=5|ATK=5|HP=5|RACE=NONE
}
public class CFM_636:MinionBase{
//NAME=暗影暴怒者
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=3|ATK=5|HP=1|RACE=UNDEAD
}
public class CFM_637:MinionBase{
//NAME=海盗帕奇斯
//TEXT=在你使用一张海盗牌后，从你的牌库中召唤本随从。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=PIRATE
    public override void Init()
    {
        base.Init();
        new EffectGiveAbility(owner.myPlayer,owner,owner,"Charge",createVfx:false).Resolve();
    }
	public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,CFM_637CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }

    public void CFM_637CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(tz==ZoneType.Board && (sc.raceType.Contains(RaceType.Pirate)) && owner.GetTag(GameTag.ZoneType) == (int)ZoneType.Deck)
        {
            if(owner.myPlayer.board.Count<7)
                new EffectMove(owner.myPlayer,owner,ZoneType.Deck,ZoneType.Board).Resolve();
        }
    }
}
public class CFM_639:MinionBase{
//NAME=污手街惩罚者
//TEXT=在你的回合结束时，使你手牌中的所有随从牌获得+1/+1。
//MAJ=PALADIN|COST=4|ATK=4|HP=4|RACE=NONE
}
public class CFM_639e:Ability{
//NAME=走私
//TEXT=污手街惩罚者使其获得属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_643:MinionBase{
//NAME=霍巴特·钩锤
//TEXT=<b>战吼：</b>如果你装备着武器，使你的手牌和牌库里的所有随从牌获得+2/+2。
//MAJ=WARRIOR|COST=4|ATK=2|HP=2|RACE=NONE
}
public class CFM_643e:Ability{
//NAME=走私
//TEXT=霍巴特·钩锤使其获得+1攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_643e2:Ability{
//NAME=走私
//TEXT=霍巴特·钩锤使其获得+1攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_646:MinionBase{
//NAME=后街男巫
//TEXT=<b>亡语：</b>对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=NONE
}
public class CFM_647:MinionBase{
//NAME=吹箭鱼人
//TEXT=<b>战吼：</b>造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=MURLOC
}
public class CFM_648:MinionBase{
//NAME=犯罪高手
//TEXT=<b>战吼：</b>召唤一个6/6的食人魔。
//MAJ=NEUTRAL|COST=6|ATK=1|HP=1|RACE=NONE
}
public class CFM_648t:MinionBase{
//NAME=“小伙伴”
//TEXT=
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=NONE
}
public class CFM_649:MinionBase{
//NAME=暗金教信使
//TEXT=<b>战吼：</b> <b>发现</b>一张法师、牧师或术士卡牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CFM_650:MinionBase{
//NAME=暗鳞劫掠者
//TEXT=<b>战吼：</b>随机使你手牌中的一张鱼人牌获得+1/+1。
//MAJ=PALADIN|COST=1|ATK=2|HP=1|RACE=MURLOC
}
public class CFM_650e:Ability{
//NAME=走私
//TEXT=暗鳞劫掠者使其获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_651:MinionBase{
//NAME=纳迦海盗
//TEXT=<b>战吼：</b>使你的武器获得+1攻击力。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=PIRATE
}
public class CFM_651e:Ability{
//NAME=锋利无比
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_652:MinionBase{
//NAME=二流打手
//TEXT=<b>嘲讽</b> 如果你的对手控制至少三个随从，则其法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=NONE
}
public class CFM_653:MinionBase{
//NAME=重装佣兵
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=NONE
}
public class CFM_654:MinionBase{
//NAME=热心的酒保
//TEXT=在你的回合结束时，为你的英雄恢复#1点生命值。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class CFM_655:MinionBase{
//NAME=毒性污水软泥怪
//TEXT=<b>战吼：</b>使对手的武器失去1点耐久度。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=NONE
}
public class CFM_656:MinionBase{
//NAME=街头调查员
//TEXT=<b>战吼：</b>使所有敌方随从失去<b>潜行</b>。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=NONE
}
public class CFM_657:MinionBase{
//NAME=暗金教窃歌者
//TEXT=<b>战吼：</b> <b>沉默</b>一个随从。
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=NONE
}
public class CFM_658:MinionBase{
//NAME=后院保镖
//TEXT=每当一个友方随从死亡，便获得+1 攻击力。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class CFM_658e:Ability{
//NAME=拦截
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_659:MinionBase{
//NAME=加基森名媛
//TEXT=<b>战吼：</b> 恢复#2点生命值。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CFM_660:MinionBase{
//NAME=狂热铸魂者
//TEXT=<b>战吼：</b>选择一个友方随从，将它的一张复制洗入你的牌库。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=NONE
}
public class CFM_661:SpellBase{
//NAME=缩小药水
//TEXT=在本回合中，使所有敌方随从获得-3攻击力。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        TaskBuffTargets(owner.myPlayer.otherPlayer.board,atk:-3);
    }
}
public class CFM_661e:Ability{
//NAME=缩小
//TEXT=在本回合中-3攻击力。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_662:SpellBase{
//NAME=龙息药水
//TEXT=对所有非龙随从造成$5点伤害。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
        {
            if(!c.raceType.Contains(RaceType.Dragon))
            {
                Pool.Add(c);
            }
        }
        TaskDamageTargets(Pool,5);
    }
}
public class CFM_663:MinionBase{
//NAME=暗金教恶魔商贩
//TEXT=在你的回合结束时，随机将一张恶魔牌置入你的手牌。
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=NONE
}
public class CFM_665:MinionBase{
//NAME=狼人欺诈者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=6|HP=5|RACE=NONE
}
public class CFM_666:MinionBase{
//NAME=功夫大师
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=5|ATK=3|HP=5|RACE=NONE
}
public class CFM_667:MinionBase{
//NAME=爆破小队
//TEXT=<b>战吼：</b>对一个敌方随从造成5点伤害。 <b>亡语：</b>对你的英雄造成5点伤害。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=2|RACE=NONE
}
public class CFM_668:MinionBase{
//NAME=魅影歹徒
//TEXT=<b>战吼：</b>召唤本随从的两个复制。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=2|RACE=NONE
}
public class CFM_668t:MinionBase{
//NAME=魅影歹徒
//TEXT=<b>战吼：</b>召唤本随从的两个复制。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=2|RACE=NONE
}
public class CFM_668t2:MinionBase{
//NAME=魅影歹徒
//TEXT=<b>战吼：</b>召唤本随从的两个复制。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=2|RACE=NONE
}
public class CFM_669:MinionBase{
//NAME=穴居人强盗
//TEXT=每当你的对手施放一个法术，将一张幸运币置入你的手牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=NONE
}
public class CFM_670:MinionBase{
//NAME=诺格弗格市长
//TEXT=所有角色都会随机选择目标。
//MAJ=NEUTRAL|COST=9|ATK=5|HP=4|RACE=NONE
}
public class CFM_671:MinionBase{
//NAME=凛风巫师
//TEXT=<b>战吼：</b>如果有敌人被<b>冻结</b>，便获得+2/+2。
//MAJ=MAGE|COST=5|ATK=5|HP=5|RACE=NONE
}
public class CFM_671e:Ability{
//NAME=寒风凛冽
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_672:MinionBase{
//NAME=郭雅夫人
//TEXT=<b>战吼：</b>选择一个友方随从，召唤你牌库中的它的所有复制。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=3|RACE=NONE
}
public class CFM_685:MinionBase{
//NAME=唐·汉古
//TEXT=<b>战吼：</b>随机使你手牌中的一张随从牌获得+5/+5。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class CFM_685e:Ability{
//NAME=走私
//TEXT=唐·汉古使其获得+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_687:MinionBase{
//NAME=墨水大师索莉娅
//TEXT=<b>战吼：</b>在本回合中，如果你的牌库里没有相同的牌，你所施放的下一个法术的法力值消耗为（0）点。
//MAJ=MAGE|COST=7|ATK=5|HP=5|RACE=NONE
}
public class CFM_687e:Ability{
//NAME=免费法术
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗为（0）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_688:MinionBase{
//NAME=野猪骑士斯派克
//TEXT=<b>战吼：</b>如果有敌方随从拥有<b>嘲讽</b>，便获得<b>冲锋</b>。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=QUILBOAR
}
public class CFM_690:SpellBase{
//NAME=青玉飞镖
//TEXT=造成$3点伤害。 <b>连击：</b>召唤一个{0}的<b>青玉魔像</b>。0造成$3点伤害。 <b>连击：</b>召唤一个<b>青玉魔像</b>。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CFM_691:MinionBase{
//NAME=青玉游荡者
//TEXT=<b>潜行，亡语：</b>召唤一个{0}的<b>青玉魔像</b>。0<b>潜行，亡语：</b>召唤一个<b>青玉魔像</b>。
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Stealth");
    }
    public override void Deathrattle()
    {
        owner.myPlayer.ChangeTag(GameTag.CntJadeGolem,1);
        int JadeTime=owner.myPlayer.GetTag(GameTag.CntJadeGolem);
        string JadeID="CFM_712_t";
        if(JadeTime<=9)
        {
            JadeID+="0"; 
        }
        if(JadeTime>=30)
        {
            JadeTime=30;
        }
        JadeID+=JadeTime.ToString();
        CardDbf Jade = CardDbf.GetCardDbfByGuid(JadeID);
        TaskCreate(Jade,ZoneType.Board);   
    }
}
public class CFM_693:MinionBase{
//NAME=加基森摆渡人
//TEXT=<b>连击：</b>将一个友方随从移回你的手牌。
//MAJ=ROGUE|COST=2|ATK=2|HP=3|RACE=NONE
}
public class CFM_694:MinionBase{
//NAME=暗影大师
//TEXT=<b>战吼：</b>使一个<b>潜行</b>的随从获得+2/+2。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=NONE
}
public class CFM_694e:Ability{
//NAME=教导有方
//TEXT=+2/+2。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_696:SpellBase{
//NAME=衰变
//TEXT=随机将所有 敌方随从变形成为法力值消耗减少（1）点的随从。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        List<Card> ToListMorph = new List<Card>();
        List<CardDbf> Dbfs= new List<CardDbf>();
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
        {
            ToListMorph.Add(c);
            Dbfs.Add(CardDbf.GetCardDbfByGuid("LOOT_412"));
        }
        new EffectMorph(owner.myPlayer,owner,targets:ToListMorph,newDbfs:Dbfs).Resolve();
    }
}
public class CFM_697:MinionBase{
//NAME=玉莲帮幻术师
//TEXT=在本随从攻击英雄后，随机变形成为 法力值消耗为（6）的随从。
//MAJ=SHAMAN|COST=4|ATK=3|HP=5|RACE=NONE
}
public class CFM_699:MinionBase{
//NAME=海魔钉刺者
//TEXT=<b>战吼：</b>在本回合中，你使用的下一张鱼人牌不再消耗法力值，转而消耗生命值。
//MAJ=WARLOCK|COST=4|ATK=4|HP=2|RACE=MURLOC
}
public class CFM_699e:Ability{
//NAME=海魔强化
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_707:SpellBase{
//NAME=青玉闪电
//TEXT=造成$3点伤害，召唤一个{0}的<b>青玉魔像</b>。0造成$3点伤害，召唤一个<b>青玉魔像</b>。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        owner.myPlayer.ChangeTag(GameTag.CntJadeGolem,1);
        int JadeTime=owner.myPlayer.GetTag(GameTag.CntJadeGolem);
        string JadeID="CFM_712_t";
        if(JadeTime<=9)
        {
            JadeID+="0"; 
        }
        if(JadeTime>=30)
        {
            JadeTime=30;
        }
        JadeID+=JadeTime.ToString();
        CardDbf Jade = CardDbf.GetCardDbfByGuid(JadeID);
        TaskCreate(Jade,ZoneType.Board);
    }
}
public class CFM_712_t01:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class CFM_712_t02:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CFM_712_t03:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class CFM_712_t04:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class CFM_712_t05:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class CFM_712_t06:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=NONE
}
public class CFM_712_t07:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=NONE
}
public class CFM_712_t08:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=NONE
}
public class CFM_712_t09:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=9|ATK=9|HP=9|RACE=NONE
}
public class CFM_712_t10:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=10|HP=10|RACE=NONE
}
public class CFM_712_t11:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=11|HP=11|RACE=NONE
}
public class CFM_712_t12:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=12|HP=12|RACE=NONE
}
public class CFM_712_t13:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=13|HP=13|RACE=NONE
}
public class CFM_712_t14:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=14|HP=14|RACE=NONE
}
public class CFM_712_t15:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=15|HP=15|RACE=NONE
}
public class CFM_712_t16:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=16|HP=16|RACE=NONE
}
public class CFM_712_t17:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=17|HP=17|RACE=NONE
}
public class CFM_712_t18:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=18|HP=18|RACE=NONE
}
public class CFM_712_t19:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=19|HP=19|RACE=NONE
}
public class CFM_712_t20:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=20|HP=20|RACE=NONE
}
public class CFM_712_t21:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=21|HP=21|RACE=NONE
}
public class CFM_712_t22:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=22|HP=22|RACE=NONE
}
public class CFM_712_t23:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=23|HP=23|RACE=NONE
}
public class CFM_712_t24:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=24|HP=24|RACE=NONE
}
public class CFM_712_t25:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=25|HP=25|RACE=NONE
}
public class CFM_712_t26:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=26|HP=26|RACE=NONE
}
public class CFM_712_t27:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=27|HP=27|RACE=NONE
}
public class CFM_712_t28:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=28|HP=28|RACE=NONE
}
public class CFM_712_t29:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=29|HP=29|RACE=NONE
}
public class CFM_712_t30:MinionBase{
//NAME=青玉魔像
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=30|HP=30|RACE=NONE
}
public class CFM_713:SpellBase{
//NAME=青玉绽放
//TEXT=召唤一个{0}的<b>青玉魔像</b>，获得一个空的法力水晶。0召唤一个<b>青玉魔像</b>，获得一个空的法力水晶。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaThisTurn,1);
        owner.myPlayer.ChangeTag(GameTag.CntJadeGolem,1);
        int JadeTime=owner.myPlayer.GetTag(GameTag.CntJadeGolem);
        string JadeID="CFM_712_t";
        if(JadeTime<=9)
        {
            JadeID+="0"; 
        }
        if(JadeTime>=30)
        {
            JadeTime=30;
        }
        JadeID+=JadeTime.ToString();
        CardDbf Jade = CardDbf.GetCardDbfByGuid(JadeID);
        TaskCreate(Jade,ZoneType.Board);
    }
}
public class CFM_715:MinionBase{
//NAME=青玉之灵
//TEXT=<b>战吼：</b>召唤一个{0}的<b>青玉魔像</b>。0<b>战吼：</b>召唤一个 <b>青玉魔像</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=ELEMENTAL
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.CntJadeGolem,1);
        int JadeTime=owner.myPlayer.GetTag(GameTag.CntJadeGolem);
        string JadeID="CFM_712_t";
        if(JadeTime<=9)
        {
            JadeID+="0"; 
        }
        if(JadeTime>=30)
        {
            JadeTime=30;
        }
        JadeID+=JadeTime.ToString();
        CardDbf Jade = CardDbf.GetCardDbfByGuid(JadeID);
        TaskCreate(Jade,ZoneType.Board);
    }
}
public class CFM_716:SpellBase{
//NAME=鱼死网破
//TEXT=对所有受伤的随从造成$3点 伤害。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> DamagedTargets = new List<Card>();
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
        {
            if(c.GetTag(GameTag.Damage)>0)
            {
                DamagedTargets.Add(c);
            }
        }
        TaskDamageTargets(DamagedTargets,3);
    }
}
public class CFM_717:WeaponBase{
//NAME=青玉之爪
//TEXT=<b>战吼：</b>召唤一个{0}的<b>青玉魔像</b>。 <b>过载：</b>（1）0<b>战吼：</b>召唤一个<b>青玉魔像</b>。 <b>过载：</b>（1）
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
        owner.myPlayer.ChangeTag(GameTag.CntJadeGolem,1);
        int JadeTime=owner.myPlayer.GetTag(GameTag.CntJadeGolem);
        string JadeID="CFM_712_t";
        if(JadeTime<=9)
        {
            JadeID+="0"; 
        }
        if(JadeTime>=30)
        {
            JadeTime=30;
        }
        JadeID+=JadeTime.ToString();
        CardDbf Jade = CardDbf.GetCardDbfByGuid(JadeID);
        TaskCreate(Jade,ZoneType.Board);
    }
}
public class CFM_750:MinionBase{
//NAME=唤魔者克鲁尔
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则召唤你手牌中的所有 恶魔。
//MAJ=WARLOCK|COST=9|ATK=9|HP=9|RACE=DEMON
}
public class CFM_751:MinionBase{
//NAME=渊狱惩击者
//TEXT=<b>战吼：</b>对所有其他角色造成3点伤害。
//MAJ=WARLOCK|COST=7|ATK=6|HP=6|RACE=DEMON
}
public class CFM_752:SpellBase{
//NAME=失窃物资
//TEXT=抽一张<b>嘲讽</b>随从牌，使其获得+2/+2。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class CFM_752e:Ability{
//NAME=走私
//TEXT=失窃物资使其获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_753:MinionBase{
//NAME=污手街供货商
//TEXT=<b>战吼：</b>使你手牌中的所有随从牌获得+1/+1。
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=NONE
}
public class CFM_753e:Ability{
//NAME=走私
//TEXT=污手街供货商使其获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_754:MinionBase{
//NAME=污手玩具商
//TEXT=在你的回合结束时，随机使你手牌中的一张随从牌获得+2/+2。
//MAJ=WARRIOR|COST=3|ATK=4|HP=3|RACE=NONE
}
public class CFM_754e:Ability{
//NAME=走私
//TEXT=污手玩具商使其获得属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_755:MinionBase{
//NAME=污手街典当师
//TEXT=<b>战吼：</b>随机使你手牌中的一张武器牌获得+1/+1。
//MAJ=WARRIOR|COST=3|ATK=3|HP=3|RACE=NONE
}
public class CFM_755e:Ability{
//NAME=走私
//TEXT=污手街拍卖师使其获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_756:MinionBase{
//NAME=兽人铸甲师
//TEXT=<b>嘲讽</b> 每当本随从造成伤害时，获得等量的护甲值。
//MAJ=WARRIOR|COST=5|ATK=3|HP=7|RACE=NONE
}
public class CFM_759:MinionBase{
//NAME=海象人执法官
//TEXT=<b>亡语：</b>如果本随从的攻击力大于或等于2，抽一张牌。
//MAJ=PALADIN|COST=1|ATK=1|HP=2|RACE=NONE
}
public class CFM_760:MinionBase{
//NAME=暗金教水晶侍女
//TEXT=在本局对战中，你每使用一张<b>奥秘</b>牌，本牌的法力值消耗便减少（2）点。
//MAJ=MAGE|COST=6|ATK=6|HP=5|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            return -2*owner.myPlayer.GetTag(GameTag.CntSecretUsed);
        }
        return 0;
    }
}
public class CFM_781:MinionBase{
//NAME=收集者沙库尔
//TEXT=<b>潜行</b>。每当本随从攻击时，随机将一张<i>（你对手职业的）</i>牌置入你的手牌。
//MAJ=ROGUE|COST=3|ATK=2|HP=3|RACE=NONE
}
public class CFM_790:MinionBase{
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
public class CFM_800:SecretBase{
//NAME=战术撤离
//TEXT=<b>奥秘：</b>当一个友方随从死亡时，将其移回你的手牌。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_806:MinionBase{
//NAME=拉希奥
//TEXT=<b>嘲讽，战吼：</b>抽若干数量的牌，直到你抽到一张非龙牌。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=NONE
}
public class CFM_807:MinionBase{
//NAME=大富翁比尔杜
//TEXT=在你施放一个法术后，复原你的 英雄技能。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class CFM_808:MinionBase{
//NAME=“鲨鱼”加佐
//TEXT=每当本随从攻击时，双方玩家抽若干数量的牌，直到拥有三张手牌。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=UNDEAD
}
public class CFM_809:MinionBase{
//NAME=野猪骑士塔纳利
//TEXT=<b>战吼：</b>如果你的对手没有手牌，便获得 <b>冲锋</b>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=QUILBOAR
}
public class CFM_810:MinionBase{
//NAME=野猪骑士蕾瑟兰
//TEXT=<b>战吼：</b>如果你的对手拥有6张或者更多手牌，便获得<b>冲锋</b>。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=QUILBOAR
}
public class CFM_811:SpellBase{
//NAME=新月视界
//TEXT=抽两张牌，抽到的随从牌法力值消耗减少（2）点。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class CFM_815:MinionBase{
//NAME=燃鬃·自走炮
//TEXT=<b>嘲讽</b> <b>吸血</b>。<b>圣盾</b>
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
        TaskInitAbility("LifeSteal");
        TaskInitAbility("DivineShield");
    }
}
public class CFM_816:MinionBase{
//NAME=兔妖教头
//TEXT=<b>战吼：</b>使一个友方野兽获得+3/+3。
//MAJ=DRUID|COST=4|ATK=4|HP=4|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(target.raceType.Contains(RaceType.Beast))
        {
            if(target.myPlayer==owner.myPlayer)
            {
                new EffectChange(owner.myPlayer,owner,target,atkChange:3,hpChange:3).Resolve();
            }
        }
    }
}
public class CFM_816_G:MinionBase{
//NAME=兔妖教头
//TEXT=<b>战吼：</b>使一个友方野兽获得+3/+3。
//MAJ=DRUID|COST=4|ATK=4|HP=4|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Battlecry(Card target=null)
    {
        if(target.raceType.Contains(RaceType.Beast))
        {
            if(target.myPlayer==owner.myPlayer)
            {
                new EffectChange(owner.myPlayer,owner,target,atkChange:6,hpChange:6).Resolve();
            }
        }
    }
}
public class CFM_816e:Ability{
//NAME=变大
//TEXT=+3/+3。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_851:MinionBase{
//NAME=勇敢的记者
//TEXT=每当你的对手抽一张牌时，便获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class CFM_851e:Ability{
//NAME=刨根问底
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_852:MinionBase{
//NAME=玉莲帮密探
//TEXT=<b>战吼：</b><b>发现</b>一张德鲁伊、潜行者或萨满祭司卡牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class CFM_853:MinionBase{
//NAME=污手街走私者
//TEXT=<b>战吼：</b>随机使你手牌中的一张随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class CFM_853e:Ability{
//NAME=走私
//TEXT=污手街走私者使其获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class CFM_854:MinionBase{
//NAME=远古之树
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=6|ATK=3|HP=8|RACE=NONE
}
public class CFM_855:MinionBase{
//NAME=迪菲亚清道夫
//TEXT=<b>战吼：</b><b>沉默</b>一个具有<b>亡语</b>的随从。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=7|RACE=NONE
}
public class CFM_900:MinionBase{
//NAME=无证药剂师
//TEXT=在你召唤一个随从后，对你的英雄造成5点伤害。
//MAJ=WARLOCK|COST=3|ATK=5|HP=5|RACE=DEMON
}
public class CFM_902:MinionBase{
//NAME=艾雅·黑掌
//TEXT=<b>战吼，亡语：</b>召唤一个{0}的<b>青玉魔像</b>。0<b>战吼，亡语：</b>召唤一个<b>青玉魔像</b>。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.CntJadeGolem,1);
        int JadeTime=owner.myPlayer.GetTag(GameTag.CntJadeGolem);
        string JadeID="CFM_712_t";
        if(JadeTime<=9)
        {
            JadeID+="0"; 
        }
        if(JadeTime>=30)
        {
            JadeTime=30;
        }
        JadeID+=JadeTime.ToString();
        CardDbf Jade = CardDbf.GetCardDbfByGuid(JadeID);
        TaskCreate(Jade,ZoneType.Board);
    }
    public override void Deathrattle()
    {
        owner.myPlayer.ChangeTag(GameTag.CntJadeGolem,1);
        int JadeTime=owner.myPlayer.GetTag(GameTag.CntJadeGolem);
        string JadeID="CFM_712_t";
        if(JadeTime<=9)
        {
            JadeID+="0"; 
        }
        if(JadeTime>=30)
        {
            JadeTime=30;
        }
        JadeID+=JadeTime.ToString();
        CardDbf Jade = CardDbf.GetCardDbfByGuid(JadeID);
        TaskCreate(Jade,ZoneType.Board);
    }
}
public class CFM_905:SpellBase{
//NAME=三教九流
//TEXT=从你的牌库中抽三张法力值消耗为（1）的随从牌。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class CFM_940:SpellBase{
//NAME=盛气凌人
//TEXT=<b>发现</b>一张<b>嘲讽</b>随从牌。使其获得+1/+2。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class CFM_940e:Ability{
//NAME=越发气盛
//TEXT=+1/+2。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
