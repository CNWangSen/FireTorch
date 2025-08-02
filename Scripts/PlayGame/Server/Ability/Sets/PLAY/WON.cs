using System.Collections;
using System.Collections.Generic;

public class WON_003:MinionBase{
//NAME=荒野骑士
//TEXT=在本局对战中，你每召唤过一只野兽，本牌的法力值消耗便减少（1）点。
//MAJ=DRUID|COST=7|ATK=6|HP=6|RACE=NONE
}
public class WON_003e:Ability{
//NAME=兽群呼唤
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_009:MinionBase{
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
public class WON_009e:Ability{
//NAME=腐化
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_010:MinionBase{
//NAME=卡拉克西织珀者
//TEXT=<b>嘲讽</b>。<b>战吼：</b> 如果你的克苏恩至少有10点攻击力，便获得+5生命值。
//MAJ=DRUID|COST=4|ATK=4|HP=5|RACE=NONE
}
public class WON_010e:Ability{
//NAME=琥珀甲壳
//TEXT=+5生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_011:MinionBase{
//NAME=玛洛恩
//TEXT=<b>亡语：</b>进入<b>休眠</b>状态。在2只友方野兽死亡后复活。
//MAJ=DRUID|COST=7|ATK=9|HP=7|RACE=BEAST
}
public class WON_011e:Ability{
//NAME=玛洛恩的沉眠
//TEXT=<b>休眠</b>。2只友方野兽死亡后唤醒。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_012:MinionBase{
//NAME=艾维娜
//TEXT=你的随从牌的法力值消耗为（1）点。
//MAJ=DRUID|COST=9|ATK=5|HP=5|RACE=NONE
}
public class WON_013:MinionBase{
//NAME=老鼠师父
//TEXT=<b>战吼，亡语：</b>将两张1/1并具有<b>嘲讽</b>的龟置入你的手牌。
//MAJ=DRUID|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class WON_013t:MinionBase{
//NAME=武僧神龟
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class WON_013t2:MinionBase{
//NAME=武僧神龟
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class WON_013t3:MinionBase{
//NAME=武僧神龟
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class WON_013t4:MinionBase{
//NAME=武僧神龟
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class WON_014:SpellBase{
//NAME=鼓舞
//TEXT=<b>抉择：</b>获得一个空的法力水晶；或者抽一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class WON_014s:SpellBase{
//NAME=生长
//TEXT=获得一个空的法力水晶。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class WON_014s2:SpellBase{
//NAME=活力
//TEXT=抽一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class WON_015:LocationBase{
//NAME=塞纳里奥要塞
//TEXT=在本回合中，你的下一张<b>抉择</b>牌同时拥有两种效果。
//MAJ=DRUID|COST=1|ATK=0|HP=2|RACE=NONE
}
public class WON_015e:Ability{
//NAME=塞纳里奥警戒
//TEXT=在本回合中，你的下一张<b>抉择</b>牌同时拥有两种效果。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_018:SecretBase{
//NAME=狙击
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，对该随从造成$6点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
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
        }
    }
}
public class WON_021:SpellBase{
//NAME=天降蛛群
//TEXT=召唤三只1/1并具有“<b>亡语：</b>随机获取一张野兽牌”的 结网蛛。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WON_022:SpellBase{
//NAME=探险帽
//TEXT=使一个随从获得+1/+1，以及“<b>亡语：</b>获取一张探险帽”。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class WON_023:SpellBase{
//NAME=子弹上膛
//TEXT=在本回合中，每当你施放一个法术，随机获取一张 猎人卡牌。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_024:MinionBase{
//NAME=酸喉
//TEXT=每当有敌方随从受到伤害时，将其消灭。
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=BEAST
    public override void RegisterEventEffect()
    {
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterTakeDamage(this,this.CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
    }
    public void CauseEvent(Card source,Card target, int amount)
    {
        if(CondInPlay())
        {
            new EffectDestroy(owner.myPlayer,owner,target).Resolve();
        }
    }
}
public class WON_025:MinionBase{
//NAME=恐鳞
//TEXT=在你的回合结束时，对所有敌人造成 1点伤害。
//MAJ=HUNTER|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class WON_026:MinionBase{
//NAME=敦霍尔德卧底
//TEXT=如果这张牌在你的手牌中，每个回合都会随机变成一张法力值消耗为（3）并获得<b>剧毒</b>的随从牌。
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=NONE
}
public class WON_026e:Ability{
//NAME=变幻
//TEXT=随机变成法力值消耗为（3）的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_026e2:Ability{
//NAME=敦霍尔德卧底
//TEXT=<b>剧毒</b>。
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=NONE
}
public class WON_027:MinionBase{
//NAME=迷时迅猛龙
//TEXT=<b>回响</b>。<b>战吼：</b><b>进化</b>你的迷时迅猛龙。
//MAJ=HUNTER|COST=2|ATK=1|HP=1|RACE=BEAST
}
public class WON_028:SpellBase{
//NAME=冰虫考验
//TEXT=召唤你牌库中法力值消耗小于或等于（3）点的两只野兽的复制。
//MAJ=HUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class WON_029:MinionBase{
//NAME=达拉然铁骑士
//TEXT=<b>法术伤害+1</b> <b>激励：</b>获得<b>法术伤害+1</b>。
//MAJ=MAGE|COST=4|ATK=3|HP=5|RACE=NONE
}
public class WON_031:MinionBase{
//NAME=法力浮龙
//TEXT=每当你施放一个法术，便获得 +1攻击力。
//MAJ=MAGE|COST=1|ATK=1|HP=3|RACE=NONE
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
                new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
            }
        }
    }
}
public class WON_033:MinionBase{
//NAME=煤烟喷吐装置
//TEXT=<b>法术伤害+1</b> <b>战吼：</b>如果你控制着其他机械，随机获取一张火焰法术牌。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=MECHANICAL
}
public class WON_035:MinionBase{
//NAME=地精炎术师
//TEXT=<b>战吼：</b>如果你控制任何机械，则造成6点伤害，随机分配到所有敌人身上。
//MAJ=MAGE|COST=4|ATK=5|HP=4|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(CondCtrlAnotherRace(RaceType.Mechanical))
        {
            TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),6);
        }
    }
}
public class WON_036:MinionBase{
//NAME=尤格-萨隆的仆从
//TEXT=<b>战吼：</b>随机施放一个法力值消耗大于或等于（5）点的法术<i>（目标随机而定）</i>。
//MAJ=MAGE|COST=5|ATK=5|HP=4|RACE=NONE
}
public class WON_037:SpellBase{
//NAME=秘法宝典
//TEXT=随机获取3张法师法术牌。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class WON_038:MinionBase{
//NAME=烈焰巨兽
//TEXT=<b>突袭</b>。当你抽到该牌时，对所有除机械外的角色造成 2点伤害。
//MAJ=MAGE|COST=7|ATK=7|HP=7|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("Rush");
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc==owner && sz==ZoneType.Deck && tz==ZoneType.Hand)
        {
            List<Card> ToListDamage = new List<Card>();
            foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Merge(owner.myPlayer.hero).Merge(owner.myPlayer.otherPlayer.hero))
            {
                if(!c.raceType.Contains(RaceType.Mechanical))
                {
                    ToListDamage.Add(c);
                }
            }
            TaskDamageTargets(ToListDamage,2);
        }
    }
}
public class WON_039:MinionBase{
//NAME=黑色沼泽卧底
//TEXT=如果这张牌在你的手牌中，每个回合都会随机变成一张法力值消耗为（2）并获得<b>法术伤害+1</b>的随从牌。
//MAJ=MAGE|COST=2|ATK=2|HP=2|RACE=NONE
}
public class WON_039e:Ability{
//NAME=变幻
//TEXT=随机变成法力值消耗为（2）的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_039e2:Ability{
//NAME=黑色沼泽卧底
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_040:SpellBase{
//NAME=时光之末迪斯科
//TEXT=随机施放5个来自过去的<b>奥秘</b>。在你的回合开始时，摧毁这些奥秘。
//MAJ=MAGE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class WON_040e:Ability{
//NAME=迪斯科之末
//TEXT=在你的回合开始时，摧毁此奥秘。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_041:MinionBase{
//NAME=时空跃迁者克罗米
//TEXT=<b>战吼：</b>前往一个历史时期。将其他历史时期洗入你的牌库。
//MAJ=MAGE|COST=6|ATK=4|HP=4|RACE=NONE
}
public class WON_041e:Ability{
//NAME=回到过去
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_041t:SpellBase{
//NAME=开启黑暗之门
//TEXT=<b>抽到时施放</b> 随机获取两张<b>传说</b>随从牌。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class WON_041t2:SpellBase{
//NAME=海加尔山之战
//TEXT=<b>抽到时施放</b> 使你的所有随从获得+2/+2。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class WON_041t2e:Ability{
//NAME=战斗祝福
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_041t3:SpellBase{
//NAME=逃离敦霍尔德
//TEXT=<b>抽到时施放</b> 随机获取两张 法术牌。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class WON_041t4:SpellBase{
//NAME=净化斯坦索姆
//TEXT=<b>抽到时施放</b> 对所有敌人造成$2点伤害。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class WON_045:MinionBase{
//NAME=象牙骑士
//TEXT=<b>战吼：</b><b>发现</b>一张法术牌。为你的英雄恢复等同于其法力值消耗的生命值。
//MAJ=PALADIN|COST=4|ATK=4|HP=4|RACE=NONE
}
public class WON_046:MinionBase{
//NAME=污手街惩罚者
//TEXT=在你的回合结束时，使你手牌中的所有随从牌获得+1/+1。
//MAJ=PALADIN|COST=4|ATK=4|HP=4|RACE=NONE
}
public class WON_046e:Ability{
//NAME=走私
//TEXT=污手街惩罚者使其获得属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_048:SpellBase{
//NAME=圣疗术
//TEXT=恢复#8点生命值，抽三张牌。
//MAJ=PALADIN|COST=6|ATK=0|HP=0|RACE=HOLY
}
public class WON_049:SpellBase{
//NAME=精英对决
//TEXT=除了每个玩家攻击力最高的随从之外，消灭所有 其他随从。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WON_051:SpellBase{
//NAME=永时祝福
//TEXT=随机使你手牌中的四张随从牌分别获得+4/+4，+3/+3，+2/+2和+1/+1。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class WON_051e:Ability{
//NAME=永时祝福
//TEXT=+{0}/+{0}。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_052:MinionBase{
//NAME=青铜龙骑士
//TEXT=<b>嘲讽</b>。<b>战吼：</b>如果本随从的攻击力大于或等于5点，召唤一个它的复制。
//MAJ=PALADIN|COST=4|ATK=3|HP=5|RACE=DRAGON
}
public class WON_053:MinionBase{
//NAME=时光探险者露妮
//TEXT=<b>战吼：</b><b>发现</b>一张来自未来的地标牌！
//MAJ=PALADIN|COST=3|ATK=3|HP=4|RACE=NONE
}
public class WON_053t:LocationBase{
//NAME=洛丹伦城郊
//TEXT=选择一个随从，消灭所有攻击力小于它的随从。
//MAJ=PALADIN|COST=3|ATK=0|HP=2|RACE=NONE
}
public class WON_053t2:LocationBase{
//NAME=双足飞龙栖木
//TEXT=随机召唤一个法力值消耗为（3）的随从。使其获得<b>冲锋</b>。
//MAJ=PALADIN|COST=3|ATK=0|HP=2|RACE=NONE
}
public class WON_053t2e:Ability{
//NAME=栖木加速
//TEXT=<b>冲锋</b>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_053t3:LocationBase{
//NAME=泽尼达尔
//TEXT=你在本回合中的下一个<b>战吼</b>将触发两次。
//MAJ=PALADIN|COST=3|ATK=0|HP=2|RACE=NONE
}
public class WON_053t3e:Ability{
//NAME=泽尼达尔之光
//TEXT=你在本回合中的下一个<b>战吼</b>将触发两次。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_053t4:LocationBase{
//NAME=暗夜要塞
//TEXT=随机施放三个圣骑士<b>奥秘</b>。
//MAJ=PALADIN|COST=3|ATK=0|HP=2|RACE=NONE
}
public class WON_053t5:LocationBase{
//NAME=瓦德拉肯
//TEXT=获取两张具有+2/+2的随机龙牌。
//MAJ=PALADIN|COST=3|ATK=0|HP=2|RACE=NONE
}
public class WON_053t5e:Ability{
//NAME=驯龙高手
//TEXT=+2/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_053t6:LocationBase{
//NAME=寇茹废墟
//TEXT=抽两张牌，交换其法力值消耗。
//MAJ=PALADIN|COST=3|ATK=0|HP=2|RACE=NONE
}
public class WON_053t6e:Ability{
//NAME=寇茹的祝福
//TEXT=法力值消耗被交换过。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_053t7:LocationBase{
//NAME=大地神殿
//TEXT=选择一个友方随从。召唤一个它的具有+3生命值和<b>嘲讽</b>且无法攻击的复制。
//MAJ=PALADIN|COST=3|ATK=0|HP=2|RACE=NONE
}
public class WON_053t7e:Ability{
//NAME=深岩之洲防御者
//TEXT=+3生命值和<b>嘲讽</b>。无法攻击。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_053te:Ability{
//NAME=泽尼达尔附加效果
//TEXT=你在本回合中的下一个<b>战吼</b>将触发两次。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_056:MinionBase{
//NAME=博物馆馆长
//TEXT=<b>战吼：发现</b>一张<b>亡语</b>牌，其法力值消耗减少（1）点。
//MAJ=PRIEST|COST=2|ATK=1|HP=2|RACE=NONE
}
public class WON_056e:Ability{
//NAME=馆藏
//TEXT=法力值消耗减少（1）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_057:MinionBase{
//NAME=玛瑙主教
//TEXT=<b>战吼：</b>随机召唤一个在本局对战中死亡的友方随从。
//MAJ=PRIEST|COST=4|ATK=3|HP=4|RACE=NONE
}
public class WON_058:MinionBase{
//NAME=暗影子嗣
//TEXT=<b>战吼，激励：</b>对每个英雄造成4点伤害。
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class WON_061:MinionBase{
//NAME=暗影魔
//TEXT=每当你抽一张牌时，使其法力值消耗减少（1）点。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=NONE
}
public class WON_061e:Ability{
//NAME=暗影魔
//TEXT=法力值消耗减少（1）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_062:MinionBase{
//NAME=暗影投弹手
//TEXT=<b>战吼：</b>对每个英雄造成3点伤害。
//MAJ=PRIEST|COST=1|ATK=3|HP=1|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageEnemyHero(3);
        TaskDamageMyHero(3);
    }
}
public class WON_063:MinionBase{
//NAME=银色神官帕尔崔丝
//TEXT=<b>战吼，激励：</b>随机召唤一个<b>传说</b>随从。
//MAJ=PRIEST|COST=7|ATK=5|HP=4|RACE=NONE
}
public class WON_064:SpellBase{
//NAME=暗言术：禁
//TEXT=<b>可交易</b> 消灭一个攻击力为4的随从。<b>腐蚀：</b>消灭所有攻击力为4的随从。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class WON_064ts:SpellBase{
//NAME=暗言术：禁
//TEXT=<b>可交易</b>。<b>已腐蚀</b> 消灭所有攻击力为4的随从。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class WON_065:MinionBase{
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
public class WON_065e:Ability{
//NAME=医疗援助
//TEXT=+1生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_066:MinionBase{
//NAME=时光大盗姆诺兹多
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则<b>发现</b>一张龙牌，并对所有其他随从造成等同于其法力值消耗的伤害。
//MAJ=PRIEST|COST=7|ATK=6|HP=6|RACE=DRAGON
}
public class WON_067:MinionBase{
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
public class WON_070:SpellBase{
//NAME=青玉飞镖
//TEXT=造成$3点伤害。 <b>连击：</b>召唤一个{0}的<b>青玉魔像</b>。0造成$3点伤害。 <b>连击：</b>召唤一个<b>青玉魔像</b>。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WON_071:SpellBase{
//NAME=剽窃
//TEXT=随机获取3张<i>（你对手职业的）</i>卡牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WON_073:MinionBase{
//NAME=黑铁潜藏者
//TEXT=<b>战吼：</b> 对所有未受伤的敌方随从造成2点伤害。
//MAJ=ROGUE|COST=4|ATK=4|HP=3|RACE=NONE
}
public class WON_075:MinionBase{
//NAME=克苏恩之刃
//TEXT=<b>战吼：</b>消灭一个随从。你的克苏恩会获得其攻击力和生命值<i>（无论它在哪里）。</i>
//MAJ=ROGUE|COST=7|ATK=4|HP=4|RACE=NONE
}
public class WON_076:MinionBase{
//NAME=阿努巴拉克
//TEXT=<b>亡语：</b>召唤一个4/4并具有“<b>亡语：</b>召唤阿努巴拉克”的蛛魔。
//MAJ=ROGUE|COST=8|ATK=8|HP=4|RACE=UNDEAD
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("WON_076t"),ZoneType.Board);
    }
}
public class WON_076t:MinionBase{
//NAME=蛛魔
//TEXT=<b>亡语：</b>召唤阿努巴拉克。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=UNDEAD
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("WON_076"),ZoneType.Board);
    }
}
public class WON_077:MinionBase{
//NAME=海加尔山卧底
//TEXT=如果这张牌在你的手牌中，每个回合都会随机变成一张法力值消耗为（4）并获得<b>潜行</b>的随从牌。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=NONE
}
public class WON_077e:Ability{
//NAME=变幻
//TEXT=随机变成法力值消耗为（4）的随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_077e2:Ability{
//NAME=海加尔山卧底
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_078:SpellBase{
//NAME=青玉电报
//TEXT=检视你对手的三张手牌，将其中一张洗入对手的牌库。召唤一个{0}的<b>青玉魔像</b>。0检视你对手的三张手牌，将其中一张洗入对手的牌库。召唤一个<b>青玉魔像</b>。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class WON_079:MinionBase{
//NAME=甲虫之王
//TEXT=<b>战吼：</b>为你的对手召唤一个0/1的锣。<b>连击：</b>获得<b>突袭</b>。
//MAJ=ROGUE|COST=4|ATK=3|HP=3|RACE=UNDEAD
}
public class WON_079t:MinionBase{
//NAME=甲虫之锣
//TEXT=每当本随从受到伤害时，用1/1的甲虫填满敌方面板。
//MAJ=ROGUE|COST=4|ATK=0|HP=1|RACE=NONE
}
public class WON_079t2:MinionBase{
//NAME=甲虫
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class WON_081:MinionBase{
//NAME=海象人图腾师
//TEXT=<b>战吼：</b>随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=2|ATK=3|HP=2|RACE=NONE
    public override void Battlecry(Card target = null)
    {
    	List<string> po = new List<string>(){"NEW1_009","CS2_051","CS2_058","CS2_050"};
        new EffectCreate(owner.myPlayer,new Card(CardDbf.GetCardDbfByGuid(po.Choice(owner.myPlayer.randomGen)), owner.myPlayer), ZoneType.Board).Resolve();
    }
}
public class WON_082:SpellBase{
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
public class WON_083:MinionBase{
//NAME=邪恶的巫医
//TEXT=每当你施放一个法术，随机召唤一个基础图腾。
//MAJ=SHAMAN|COST=3|ATK=3|HP=4|RACE=NONE
}
public class WON_084:MinionBase{
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
public class WON_085:MinionBase{
//NAME=雷霆崖勇士
//TEXT=<b>战吼，激励：</b>使你的图腾获得+2攻击力。
//MAJ=SHAMAN|COST=5|ATK=3|HP=6|RACE=NONE
}
public class WON_086:SpellBase{
//NAME=神奇四鱼
//TEXT=召唤四个1/1的鱼人。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WON_090:MinionBase{
//NAME=砾岩旅伴
//TEXT=<b>战吼：</b>抽一张<b>过载</b>牌。在本回合中，你不会<b>过载</b>。
//MAJ=SHAMAN|COST=2|ATK=2|HP=1|RACE=ELEMENTAL
}
public class WON_090e:Ability{
//NAME=砾岩荷载
//TEXT=在本回合中不会<b>过载</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_091:SpellBase{
//NAME=图腾团聚
//TEXT=召唤全部五种<i>（？！）</i>基础图腾。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class WON_092e:Ability{
//NAME=随风而行
//TEXT=使你的英雄获得<b>圣盾</b>，并使其在本回合中获得+2攻击力和<b>风怒</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_092h:HeroBase{
//NAME=时光之风奥拉基尔
//TEXT=<b>战吼：</b>抽取具有<b>冲锋</b>，<b>圣盾</b>，<b>嘲讽</b>和 <b>风怒</b>的随从牌 各一张。
//MAJ=SHAMAN|COST=7|ATK=0|HP=30|RACE=NONE
}
public class WON_092he:Ability{
//NAME=时光之风
//TEXT=+3攻击力及<b>风怒</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_092p:HeroPowerBase{
//NAME=伴风而行
//TEXT=使你的英雄获得<b>圣盾</b>，并使其在本回合中获得+$a2攻击力和<b>风怒</b>。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WON_093:SpellBase{
//NAME=恶魔融合
//TEXT=使一个恶魔获得+3/+3。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class WON_093e:Ability{
//NAME=黑暗融合
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_095:SpellBase{
//NAME=暗色炸弹
//TEXT=对一个角色造成$3点伤害。如果该角色死亡，抽一张暗影法术牌。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        if(target.GetTag(GameTag.ZoneType)==(int)ZoneType.Grave)
        {
            TaskDrawSchool(SpellSchoolType.Shadow);
        }
    }
}
public class WON_096:MinionBase{
//NAME=黑市摊贩
//TEXT=<b>战吼：发现</b>一张 法力值消耗为（1）的卡牌。
//MAJ=WARLOCK|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class WON_097:SpellBase{
//NAME=狂乱传染
//TEXT=造成$13点伤害，随机分配到所有角色身上。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class WON_098:MinionBase{
//NAME=镀银魔像
//TEXT=如果你弃掉了这张随从牌，则会召唤它。
//MAJ=WARLOCK|COST=3|ATK=3|HP=4|RACE=NONE
}
public class WON_099:MinionBase{
//NAME=小鬼骑士
//TEXT=每当你弃掉一张牌时，便获得+2/+1。
//MAJ=WARLOCK|COST=2|ATK=3|HP=2|RACE=DEMON
}
public class WON_099e:Ability{
//NAME=邪火之怒
//TEXT=属性值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_100:SpellBase{
//NAME=黑暗交易
//TEXT=随机消灭两个敌方随从，随机弃两张牌。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class WON_103:LocationBase{
//NAME=维希度斯的窟穴
//TEXT=检视你手牌中的三张牌，选择一张弃掉。抽两张牌。
//MAJ=WARLOCK|COST=3|ATK=0|HP=2|RACE=NONE
}
public class WON_103e:Ability{
//NAME=碎碎黏黏
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_104:MinionBase{
//NAME=虚灵大盗的魔女
//TEXT=<b>战吼：</b>召唤一个1/3并具有<b>嘲讽</b>的虚空行者。如果你的对手拥有的随从更多，则重复召唤。
//MAJ=WARLOCK|COST=4|ATK=2|HP=4|RACE=NONE
}
public class WON_105:MinionBase{
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
public class WON_105e:Ability{
//NAME=黑暗力量
//TEXT=消耗生命值，而非法力值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_106t:WeaponBase{
//NAME=锈蚀铁钩
//TEXT=
//MAJ=WARRIOR|COST=1|ATK=1|HP=3|RACE=NONE
}
public class WON_108:MinionBase{
//NAME=污手玩具商
//TEXT=在你的回合结束时，随机使你手牌中的一张随从牌获得+2/+2。
//MAJ=WARRIOR|COST=3|ATK=4|HP=3|RACE=NONE
}
public class WON_108e:Ability{
//NAME=走私
//TEXT=污手玩具商使其获得属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_110:SpellBase{
//NAME=失窃物资
//TEXT=抽一张<b>嘲讽</b>随从牌，使其获得+2/+2。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WON_110e:Ability{
//NAME=走私
//TEXT=失窃物资使其获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_111:MinionBase{
//NAME=上古之神护卫
//TEXT=<b>战吼：</b> 如果你的克苏恩至少有10点攻击力，则获得10点护甲值。
//MAJ=WARRIOR|COST=6|ATK=6|HP=6|RACE=NONE
}
public class WON_114:MinionBase{
//NAME=钢铁战蝎
//TEXT=<b>战吼，亡语：</b>将一张“地雷” 牌洗入你对手的牌库。当抽到“地雷”时，便会受到10点伤害。
//MAJ=WARRIOR|COST=6|ATK=6|HP=5|RACE=MECHANICAL
}
public class WON_115:SpellBase{
//NAME=旧时惊爆
//TEXT=获取2张<b>零件</b>牌。召唤两个1/1的砰砰机器人。将一张“炸弹”牌洗入你对手的牌库。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=NONE
}
public class WON_116:MinionBase{
//NAME=象牙城堡
//TEXT=<b>战吼：</b><b>发现</b>一张<b>嘲讽</b>随从牌，并获得等同于其法力值消耗的 护甲值。
//MAJ=WARRIOR|COST=4|ATK=4|HP=3|RACE=NONE
}
public class WON_117:MinionBase{
//NAME=霍巴特·钩锤
//TEXT=<b>战吼：</b>如果你装备着武器，使你的手牌和牌库里的所有随从牌获得+2/+2。
//MAJ=WARRIOR|COST=4|ATK=2|HP=2|RACE=NONE
}
public class WON_117e:Ability{
//NAME=走私
//TEXT=+2/+2。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_118:MinionBase{
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
public class WON_124:MinionBase{
//NAME=暮光地卜师
//TEXT=<b>嘲讽</b>。<b>战吼：</b>使你的克苏恩获得+1/+1和<b>嘲讽</b><i>（无论它在哪里）。</i>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=NONE
}
public class WON_124e:Ability{
//NAME=地卜术
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_125:MinionBase{
//NAME=克苏恩的侍从
//TEXT=<b>圣盾</b>，<b>战吼：</b>使你的克苏恩获得+3/+3<i>（无论它在哪里）。</i>
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=UNDEAD
}
public class WON_127:MinionBase{
//NAME=克苏恩的信徒
//TEXT=<b>战吼：</b> 造成2点伤害。使你的克苏恩获得+2/+2<i>（无论它在哪里）。</i>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class WON_128:MinionBase{
//NAME=淤泥喷射者
//TEXT=<b>嘲讽，亡语：</b>召唤一个1/2并具有<b>嘲讽</b>的泥浆怪。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=UNDEAD
}
public class WON_128t:MinionBase{
//NAME=腐臭软泥
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class WON_130:MinionBase{
//NAME=暗金教信使
//TEXT=<b>战吼：</b> <b>发现</b>一张法师、牧师或术士卡牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class WON_131:MinionBase{
//NAME=疯狂的信徒
//TEXT=<b>嘲讽</b>。每当本随从受到伤害，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=NONE
}
public class WON_133:MinionBase{
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
public class WON_133e:Ability{
//NAME=索瑞森大帝的眷顾
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_134:MinionBase{
//NAME=维克洛尔大帝
//TEXT=<b><b>嘲讽</b>，战吼：</b>如果你的克苏恩至少有10点攻击力，则召唤另一名双子皇帝。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=7|RACE=NONE
}
public class WON_134t:MinionBase{
//NAME=维克尼拉斯大帝
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=7|ATK=6|HP=7|RACE=NONE
}
public class WON_135:MinionBase{
//NAME=克苏恩
//TEXT=<b>战吼：</b> 造成等同于本随从攻击力的伤害，随机分配到所有敌人身上。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=6|RACE=NONE
}
public class WON_136:MinionBase{
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
public class WON_137:MinionBase{
//NAME=唐·汉古
//TEXT=<b>战吼：</b>随机使你手牌中的一张随从牌获得+5/+5。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class WON_137e:Ability{
//NAME=走私
//TEXT=唐·汉古使其获得+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_138:MinionBase{
//NAME=鲨鱼拳击手
//TEXT=<b>亡语：</b>随机使一个友方海盗获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=PIRATE
}
public class WON_138e:Ability{
//NAME=鲨鱼铁拳
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_139:MinionBase{
//NAME=时间线加速机
//TEXT=<b>战吼：</b>抽一张机械牌，并使其法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=MECHANICAL
}
public class WON_140:MinionBase{
//NAME=未来特使
//TEXT=<b>战吼：</b>使你手牌中所有龙牌的法力值消耗减少（1）点，并使它们获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=DRAGON
}
public class WON_140e:Ability{
//NAME=未来的祝福
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_141:MinionBase{
//NAME=展馆茶杯
//TEXT=<b>战吼：</b>随机使三个不同类型的友方随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class WON_141e:Ability{
//NAME=茗碗一啜
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_142:MinionBase{
//NAME=展馆茶壶
//TEXT=<b>战吼：</b>随机使三个不同类型的友方随从获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class WON_142e:Ability{
//NAME=解渴痛饮
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_143:MinionBase{
//NAME=永恒融合怪
//TEXT=<b>激励，暴怒，<b>法术迸发</b>，荣誉消灭，超杀：</b>随机召唤一个法力值消耗为（1）的随从。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=ALL
}
public class WON_144:MinionBase{
//NAME=克苏恩的眼柄
//TEXT=<b>嘲讽。</b><b>吸血</b> 每当你的克苏恩获得攻击力或生命值时，本随从也会获得<i>（无论它在哪里）</i>。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=1|RACE=NONE
}
public class WON_146:MinionBase{
//NAME=索莉多米
//TEXT=<b>休眠</b>2回合。唤醒时，使你手牌中所有龙牌的法力值消耗减少（4）点。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=DRAGON
}
public class WON_146e:Ability{
//NAME=时间之沙
//TEXT=<b>休眠</b>。 2回合后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_162:MinionBase{
//NAME=百兽之王
//TEXT=<b>嘲讽</b> 你每控制一只其他野兽，便拥有+1攻击力。
//MAJ=HUNTER|COST=3|ATK=1|HP=5|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            int Num=0;
            foreach(Card c in owner.myPlayer.board)
            {
                if(c.raceType.Contains(RaceType.Beast))
                {
                    Num+=1;
                }
            }
            return Num;
        }
        return 0;
    }
}
public class WON_300:MinionBase{
//NAME=兔妖教头
//TEXT=<b>战吼：</b>使一个友方野兽获得+3/+3。
//MAJ=DRUID|COST=4|ATK=4|HP=4|RACE=NONE
}
public class WON_302:MinionBase{
//NAME=泥潭守护者
//TEXT=<b>抉择：</b>召唤一个2/2的泥浆怪；或者获得一个空的法力水晶。
//MAJ=DRUID|COST=4|ATK=3|HP=4|RACE=NONE
}
public class WON_303:MinionBase{
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
public class WON_304:MinionBase{
//NAME=黑暗鸦人
//TEXT=<b>嘲讽</b>，<b>战吼：</b>使你的克苏恩获得+4/+4<i>（无论它在哪里）。</i>
//MAJ=DRUID|COST=6|ATK=5|HP=7|RACE=NONE
}
public class WON_305:MinionBase{
//NAME=展览馆守卫
//TEXT=<b>战吼：</b>选择一个友方野兽，召唤一个它的复制。
//MAJ=DRUID|COST=5|ATK=5|HP=4|RACE=NONE
}
public class WON_306:SpellBase{
//NAME=眼镜蛇射击
//TEXT=对一个随从和敌方英雄造成$3点伤害。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class WON_307:MinionBase{
//NAME=豺狼人土枪手
//TEXT=<b>亡语：</b>随机使你手牌中的一张随从牌获得+2/+2。
//MAJ=HUNTER|COST=3|ATK=4|HP=3|RACE=NONE
}
public class WON_308:MinionBase{
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
public class WON_309:SpellBase{
//NAME=银月城传送门
//TEXT=使一个随从获得+2/+2。随机召唤一个法力值消耗为（2）的随从。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class WON_310:MinionBase{
//NAME=夜色镇执法官
//TEXT=每当你召唤一个生命值为1的随从，便使其获得<b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=4|HP=3|RACE=NONE
}
public class WON_311:MinionBase{
//NAME=奥达曼守护者
//TEXT=<b>战吼：</b> 将一个随从的攻击力和生命值变为3。
//MAJ=PALADIN|COST=3|ATK=3|HP=4|RACE=NONE
}
public class WON_312:MinionBase{
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
public class WON_313:MinionBase{
//NAME=兜帽侍僧
//TEXT=<b>嘲讽</b>。每当一个角色获得治疗时，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i>
//MAJ=PRIEST|COST=4|ATK=3|HP=6|RACE=NONE
}
public class WON_314:MinionBase{
//NAME=缩小射线工程师
//TEXT=<b>战吼：</b>在本回合中，使一个随从获得-3攻击力。
//MAJ=PRIEST|COST=2|ATK=3|HP=2|RACE=NONE
}
public class WON_315:MinionBase{
//NAME=夜色镇炼金师
//TEXT=<b>战吼：</b> 恢复#5点生命值。
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=NONE
}
public class WON_316:MinionBase{
//NAME=影踪骁骑兵
//TEXT=<b>连击：</b> 获得+4攻击力。
//MAJ=ROGUE|COST=5|ATK=3|HP=7|RACE=NONE
}
public class WON_317:MinionBase{
//NAME=幽暗城商贩
//TEXT=<b>亡语：</b> 随机获取一张<i>（你对手职业的）</i>卡牌。
//MAJ=ROGUE|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class WON_318:WeaponBase{
//NAME=淬毒利刃
//TEXT=你的英雄技能不会取代该武器，改为+1攻击力。
//MAJ=ROGUE|COST=2|ATK=1|HP=3|RACE=NONE
}
public class WON_320:SpellBase{
//NAME=治疗波
//TEXT=恢复#8点生命值。揭示双方牌库里的一张随从牌。如果你的牌法力值 消耗较大，改为恢复#16点生命值。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class WON_321:WeaponBase{
//NAME=灌魔之锤
//TEXT=<b>亡语：</b>你的英雄技能改为“造成 2点伤害”。
//MAJ=SHAMAN|COST=3|ATK=2|HP=3|RACE=NONE
}
public class WON_322:MinionBase{
//NAME=渡魂者
//TEXT=每当一个随从死亡，使你的克苏恩获得+1/+1<i>（无论它在哪里）。</i>
//MAJ=WARLOCK|COST=4|ATK=3|HP=5|RACE=NONE
}
public class WON_323:SpellBase{
//NAME=末日灾祸
//TEXT=对一个角色造成$3点伤害。如果“末日灾祸”消灭该角色，随机召唤一个恶魔。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class WON_324:MinionBase{
//NAME=唤魔者克鲁尔
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则召唤你手牌中的所有 恶魔。
//MAJ=WARLOCK|COST=9|ATK=9|HP=9|RACE=DEMON
}
public class WON_325:SpellBase{
//NAME=弹射之刃
//TEXT=随机对一个随从造成$1点伤害。重复此效果，直到某个随从死亡。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class WON_326:WeaponBase{
//NAME=黄铜指虎
//TEXT=在你的英雄攻击后，随机使你手牌中的一张随从牌获得+1/+1。
//MAJ=WARRIOR|COST=3|ATK=2|HP=3|RACE=NONE
}
public class WON_328:MinionBase{
//NAME=穆克拉的勇士
//TEXT=<b>激励：</b>使你的其他随从获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=3|RACE=BEAST
}
public class WON_329:MinionBase{
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
public class WON_330:MinionBase{
//NAME=异教药剂师
//TEXT=<b>战吼：</b>每有一个敌方随从，便为你的英雄恢复#2点生命值。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class WON_331:MinionBase{
//NAME=污手街情报员
//TEXT=<b>战吼：</b><b>发现</b>一张 猎人、圣骑士或战士卡牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class WON_332:MinionBase{
//NAME=玉莲帮密探
//TEXT=<b>战吼：</b><b>发现</b>一张德鲁伊、潜行者或萨满祭司卡牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class WON_333:SpellBase{
//NAME=黑暗曙光
//TEXT=<b>发现</b>一张圣骑士随从牌。使其获得+2/+2。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class WON_334:MinionBase{
//NAME=神秘挑战者
//TEXT=<b>战吼：</b>将每种不同的<b>奥秘</b>从你的牌库中置入战场。
//MAJ=PALADIN|COST=5|ATK=5|HP=5|RACE=NONE
}
public class WON_335:SpellBase{
//NAME=转生
//TEXT=消灭一个随从，然后将其复活，并具有所有生命值。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class WON_336:MinionBase{
//NAME=升腾者海纳泽尔
//TEXT=<b>法术伤害+1</b> 你的法术拥有<b>吸血</b>。
//MAJ=SHAMAN|COST=5|ATK=4|HP=6|RACE=ELEMENTAL
}
public class WON_337:SpellBase{
//NAME=铁炉堡传送门
//TEXT=获得4点护甲值。随机召唤一个法力值消耗为（4）的 随从。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class WON_338:MinionBase{
//NAME=掷斧者
//TEXT=每当本随从受到伤害，对敌方英雄造成 2点伤害。
//MAJ=WARRIOR|COST=4|ATK=2|HP=6|RACE=NONE
}
public class WON_339:MinionBase{
//NAME=兽人铸甲师
//TEXT=<b>嘲讽</b> 每当本随从造成伤害时，获得等量的护甲值。
//MAJ=WARRIOR|COST=5|ATK=3|HP=7|RACE=NONE
}
public class WON_340:MinionBase{
//NAME=盗墓匪贼
//TEXT=<b>亡语：</b>获取一张 幸运币。
//MAJ=ROGUE|COST=4|ATK=6|HP=4|RACE=UNDEAD
}
public class WON_341:SpellBase{
//NAME=炎枪术
//TEXT=对一个随从造成$25点伤害。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class WON_342:SpellBase{
//NAME=策反
//TEXT=将一个敌方随从的一张复制置入你的手牌。其法力值消耗为（1）点。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
}
public class WON_344:MinionBase{
//NAME=嗜法者
//TEXT=<b>战吼：</b>双方玩家各获取一张随机法术牌，你获取的那张法力值消耗减少（2）点。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=NONE
}
public class WON_344e:Ability{
//NAME=法术嗜好
//TEXT=法力值消耗减少（2）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_345:MinionBase{
//NAME=瓦斯坦恩·鹿盔
//TEXT=<b>亡语：</b>从你的牌库中召唤一个<b>嘲讽</b>随从。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=6|RACE=NONE
}
public class WON_347:SpellBase{
//NAME=走私货物
//TEXT=随机使你手牌中的一张野兽牌获得+2/+2。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_347e:Ability{
//NAME=走私
//TEXT=走私货物使其获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class WON_350:SpellBase{
//NAME=盛气凌人
//TEXT=<b>发现</b>一张<b>嘲讽</b>随从牌。使其获得+1/+2。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class WON_351:MinionBase{
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
public class WON_357:MinionBase{
//NAME=苦痛侍僧
//TEXT=每当本随从受到伤害，抽一张牌。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=NONE
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
        if(amount>0)
            TaskDraw();
    }
}
public class WON_365:MinionBase{
//NAME=杂耍小鬼
//TEXT=<b>法术伤害+2</b>
//MAJ=NEUTRAL|COST=3|ATK=0|HP=7|RACE=DEMON
}
public class WON_366:MinionBase{
//NAME=狼人欺诈者
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=6|HP=5|RACE=NONE
}
