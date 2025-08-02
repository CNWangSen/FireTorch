using System.Collections;
using System.Collections.Generic;

public class SW_001:WeaponBase{
//NAME=星空墨水套装
//TEXT=在你消耗5点法力值用于法术牌上后，使你手牌中的一张法术牌法力值消耗减少（5）点。失去1点耐久度。
//MAJ=MAGE|COST=2|ATK=0|HP=2|RACE=NONE
}
public class SW_001e:Ability{
//NAME=铭文附魔
//TEXT=你的下一张法术牌法力值消耗减少（5）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_001e2:Ability{
//NAME=铭文降耗
//TEXT=法力值消耗减少（5）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_003:WeaponBase{
//NAME=符文秘银杖
//TEXT=在你抽四张牌后，使你的手牌法力值消耗减少（1）点。失去1点耐久度。
//MAJ=WARLOCK|COST=5|ATK=0|HP=2|RACE=NONE
}
public class SW_003e:Ability{
//NAME=附魔之尘
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_006:MinionBase{
//NAME=顽固的嫌疑人
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（3）的随从。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
    public static List<CardDbf> Pool=new List<CardDbf>();
    
    public override void Deathrattle()
    {
        if(Pool.Count==0)
        {
            foreach(CardDbf db in CardDbf.AllCardDbf)
            {
                if(db.CardType==CardType.Minion)
                {
                    if(db.ManaCost==3)
                    {
                        //if(!db.Description.Contains("亡语"))
                        //{
                            Pool.Add(db);
                        //}
                    }
                }
            }
        }
        TaskCreate(Pool.Choice(owner.myPlayer.randomGen),ZoneType.Board);
    }
}
public class SW_012:WeaponBase{
//NAME=暗影布缝针
//TEXT=在你施放一个暗影法术后，对所有敌人造成1点伤害。失去1点耐久度。
//MAJ=PRIEST|COST=1|ATK=0|HP=3|RACE=NONE
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
                if(sc.spellType.Contains(SpellSchoolType.Shadow))
                {
                    owner.ChangeTag(GameTag.Health,-1);
                    TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),1);
                    //new EffectChange(owner.myPlayer,owner,owner,hpChange:-1,createVfx:false).Resolve();
                }
            }
        }
    }
}
public class SW_021:MinionBase{
//NAME=怯懦的步兵
//TEXT=<b>亡语：</b>从你的牌库中召唤一个随从。
//MAJ=WARRIOR|COST=6|ATK=6|HP=2|RACE=NONE
}
public class SW_023:SpellBase{
//NAME=挑衅
//TEXT=<b>可交易</b> 选择一个友方随从，使所有敌方随从攻击该随从。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_024:MinionBase{
//NAME=洛萨
//TEXT=在你的回合结束时，随机攻击一个敌方随从。如果目标随从死亡，获得+3/+3。
//MAJ=WARRIOR|COST=7|ATK=7|HP=7|RACE=NONE
}
public class SW_024e:Ability{
//NAME=为了暴风王国！
//TEXT=+3/+3
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_025:WeaponBase{
//NAME=拍卖行木槌
//TEXT=在你的英雄攻击后，使你手牌中一张<b>战吼</b>随从牌的法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SW_025e:Ability{
//NAME=成交！
//TEXT=法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_026:MinionBase{
//NAME=幽灵狼前锋
//TEXT=在你使用一张<b>过载</b>牌后，召唤一只2/3并具有<b>嘲讽</b>的幽灵狼。
//MAJ=SHAMAN|COST=4|ATK=2|HP=5|RACE=UNDEAD
}
public class SW_027:SpellBase{
//NAME=海上威胁
//TEXT=对一个随从造成$2点伤害。如果你控制一个海盗，则改为造成$5点伤害。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(CondCtrlAnotherRace(RaceType.Pirate))
        {
            new EffectDamage(owner.myPlayer,owner,target,5).Resolve();
        }
        else{
            new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
        }
    }
}
public class SW_028:SpellBase{
//NAME=开进码头
//TEXT=<b>任务线：</b>使用三张海盗牌。<b>奖励：</b>抽一张武器牌。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_028t:SpellBase{
//NAME=制造混乱
//TEXT=<b>任务线：</b>使用三张海盗牌。<b>奖励：</b>随机对一个敌人造成$2点伤害，触发两次。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_028t2:SpellBase{
//NAME=保证补给
//TEXT=<b>任务线：</b>使用三张海盗牌。<b>奖励：</b>船长洛卡拉。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_028t5:MinionBase{
//NAME=船长洛卡拉
//TEXT=<b>战吼：</b>召唤毁灭战舰！
//MAJ=WARRIOR|COST=5|ATK=7|HP=7|RACE=PIRATE
}
public class SW_028t6:MinionBase{
//NAME=毁灭战舰
//TEXT=<b>在你的回合开始时：</b>召唤一个海盗，装备一把战士武器，并向敌人发射两发炮弹，每发造成2点伤害。
//MAJ=WARRIOR|COST=5|ATK=0|HP=1|RACE=NONE
}
public class SW_029:MinionBase{
//NAME=港口匪徒
//TEXT=<b>战吼：</b>抽一张海盗牌。
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=PIRATE
    public override void Battlecry(Card target=null)
    {
        TaskDrawRace(RaceType.Pirate);
    }
}
public class SW_030:MinionBase{
//NAME=货物保镖
//TEXT=在你的回合结束时，获得3点护甲值。
//MAJ=WARRIOR|COST=3|ATK=2|HP=4|RACE=PIRATE
}
public class SW_031:SpellBase{
//NAME=号令元素
//TEXT=<b>任务线：</b>使用三张<b>过载</b>牌。 <b>奖励：</b>解锁你<b>过载</b>的法力水晶。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_031t:SpellBase{
//NAME=搬移磐石
//TEXT=<b>任务线：</b>使用三张<b>过载</b>牌。<b>奖励：</b>召唤一个3/3并具有<b>嘲讽</b>的元素。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_031t2:SpellBase{
//NAME=驯服火焰
//TEXT=<b>任务线：</b>使用两张<b>过载</b>牌。<b>奖励：</b>风暴召唤者布鲁坎。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_031t7:MinionBase{
//NAME=风暴召唤者布鲁坎
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你的法术会施放两次。
//MAJ=SHAMAN|COST=5|ATK=7|HP=7|RACE=NONE
}
public class SW_031t7e:Ability{
//NAME=风暴召唤者
//TEXT=法术会施放两次。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_031t8:MinionBase{
//NAME=活体土石
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=3|ATK=3|HP=3|RACE=ELEMENTAL
}
public class SW_032:MinionBase{
//NAME=花岗岩熔铸体
//TEXT=<b>战吼：</b>使你手牌和牌库中的元素牌法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=4|ATK=4|HP=5|RACE=ELEMENTAL
}
public class SW_032e:Ability{
//NAME=熔铸
//TEXT=法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_033:MinionBase{
//NAME=运河慢步者
//TEXT=<b>突袭</b>，<b>吸血</b> <b>过载：</b>（1）
//MAJ=SHAMAN|COST=4|ATK=6|HP=4|RACE=ELEMENTAL
}
public class SW_034:SpellBase{
//NAME=小巧玩具
//TEXT=随机召唤四个法力值消耗为（5）的随从，使其变为2/2。
//MAJ=SHAMAN|COST=6|ATK=0|HP=0|RACE=NONE
}
public class SW_034e:Ability{
//NAME=小巧玩具
//TEXT=2/2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_035:SpellBase{
//NAME=充能召唤
//TEXT=<b>发现</b>一个法力值消耗为（1）的随从并召唤它。<i>（在本局对战中你每使用一张<b>过载</b>牌都会升级！）</i>
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class SW_036:MinionBase{
//NAME=双面投资者
//TEXT=在你的回合结束时，使你的一张手牌法力值消耗减少（1）点。<i>（50%的几率改为消耗增加。）</i>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class SW_036e:Ability{
//NAME=优质投资
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_036e2:Ability{
//NAME=不良投资
//TEXT=法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_037:MinionBase{
//NAME=怒缚蛮兵
//TEXT=<b>嘲讽</b> 在本回合中每抽一张牌，本牌的法力值消耗便减少（1）点。
//MAJ=DEMONHUNTER|COST=7|ATK=6|HP=7|RACE=DEMON
}
public class SW_037e:Ability{
//NAME=准备出击
//TEXT=法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_039:SpellBase{
//NAME=一决胜负
//TEXT=<b>任务线：</b>在一回合中抽四张牌。<b>奖励：</b>使抽到的牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_039t:SpellBase{
//NAME=汲取动力
//TEXT=<b>任务线：</b>在一回合中抽五张牌。<b>奖励：</b>使抽到的牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_039t2e:Ability{
//NAME=Faster Moves
//TEXT=Costs (2) less.
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_039t3:SpellBase{
//NAME=关闭传送门
//TEXT=<b>任务线：</b>在一回合中抽五张牌。 <b>奖励：</b>屠魔者库尔特鲁斯。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_039t3_t:MinionBase{
//NAME=屠魔者库尔特鲁斯
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你抽到的牌法力值消耗减少（2）点。
//MAJ=DEMONHUNTER|COST=5|ATK=7|HP=7|RACE=NONE
}
public class SW_039t3_te:Ability{
//NAME=超凡速度
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_039te:Ability{
//NAME=快速移动
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_040:SpellBase{
//NAME=邪能弹幕
//TEXT=对生命值最低的敌人造成$2点伤害两次。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=FEL
    public override void Battlecry(Card target=null)
    {
        TaskDamageEnemyHero(2);
        TaskDamageEnemyHero(2);
    }
}
public class SW_041:SpellBase{
//NAME=敏捷咒符
//TEXT=在你的下个回合开始时，抽一张牌，并使其法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class SW_041e2:Ability{
//NAME=轻盈如羽
//TEXT=法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_042:MinionBase{
//NAME=固执的商贩
//TEXT=<b>可交易</b> <b>亡语：</b>从你的牌库中召唤一个固执的商贩。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=3|RACE=NONE
}
public class SW_043:MinionBase{
//NAME=邪能吞食者
//TEXT=<b>战吼：</b>抽一张邪能法术牌，使其法力值消耗减少（2）点。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=3|RACE=DEMON
}
public class SW_043e:Ability{
//NAME=吞噬
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_044:MinionBase{
//NAME=杰斯·织暗
//TEXT=<b>战吼：</b> 施放你在本局对战中使用过的所有邪能法术<i>（尽可能以敌人为目标）</i>。
//MAJ=DEMONHUNTER|COST=8|ATK=7|HP=5|RACE=NONE
}
public class SW_045:MinionBase{
//NAME=拍卖师亚克森
//TEXT=每当你<b>交易</b>时，将抽牌改为从你的牌库中<b>发现</b>一张牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class SW_046:SpellBase{
//NAME=城建税
//TEXT=<b>可交易</b> <b>吸血</b>，对所有敌方随从造成$1点伤害。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class SW_047:MinionBase{
//NAME=大领主弗塔根
//TEXT=<b>圣盾</b> 在一个友方随从失去<b>圣盾</b>后，使你手牌中的一张随从牌获得+5/+5。
//MAJ=PALADIN|COST=6|ATK=5|HP=5|RACE=NONE
}
public class SW_047e:Ability{
//NAME=大领主的祝福
//TEXT=+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_048:WeaponBase{
//NAME=棱彩珠宝工具
//TEXT=在一个友方随从失去<b>圣盾</b>后，使你手牌中的随从牌获得+1/+1。失去1点耐久度。
//MAJ=PALADIN|COST=1|ATK=0|HP=3|RACE=NONE
}
public class SW_048e:Ability{
//NAME=精工黎明石
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_049:SpellBase{
//NAME=受祝福的货物
//TEXT=<b>发现</b>一张<b>奥秘</b>牌，武器牌或<b>圣盾</b>随从牌。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class SW_050:MinionBase{
//NAME=变装大师
//TEXT=你改用另一职业开始对战，直到你使用潜行者牌。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class SW_050e:Ability{
//NAME=伪装
//TEXT=扮成其他人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_052:SpellBase{
//NAME=探查内鬼
//TEXT=<b>任务线：</b>使用两张军情七处牌。<b>奖励：</b>将一张间谍小工具置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_052t:SpellBase{
//NAME=了解真相
//TEXT=<b>任务线：</b>使用两张军情七处牌。<b>奖励：</b>将一张间谍小工具置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_052t2:SpellBase{
//NAME=标出叛徒
//TEXT=<b>任务线：</b>使用两张军情七处牌。<b> 奖励：</b>间谍大师斯卡布斯。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_052t3:MinionBase{
//NAME=间谍大师斯卡布斯
//TEXT=<b>战吼：</b>将每种间谍小工具各一张置入你的手牌。
//MAJ=ROGUE|COST=5|ATK=7|HP=7|RACE=NONE
}
public class SW_052t4:SpellBase{
//NAME=声光干扰器
//TEXT=将一个敌方随从移回其拥有者的手牌，并使其无法在下回合中使用。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_052t4e:Ability{
//NAME=受到干扰
//TEXT=无法使用。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_052t5:MinionBase{
//NAME=间谍机器人
//TEXT=<b>战吼：</b>检视你对手牌库中的三张牌。选择一张置于牌库顶。
//MAJ=ROGUE|COST=1|ATK=3|HP=2|RACE=MECHANICAL
}
public class SW_052t6:SpellBase{
//NAME=迷雾发生器
//TEXT=使一个随从获得+2攻击力和 <b>潜行</b>。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_052t6e:Ability{
//NAME=迷醉烟雾
//TEXT=+2攻击力并具有<b>潜行</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_052t7:WeaponBase{
//NAME=隐蔽式旋刃
//TEXT=<b>亡语：</b>随机将该武器投向一个敌方随从。
//MAJ=ROGUE|COST=1|ATK=3|HP=2|RACE=NONE
}
public class SW_052t8_t:MinionBase{
//NAME=潜藏的鼹鼠
//TEXT=<b>潜行</b>。在本随从攻击后，随机将一张<i>（你对手职业的）</i>牌置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=2|HP=3|RACE=BEAST
}
public class SW_054:MinionBase{
//NAME=暴风城卫兵
//TEXT=<b>嘲讽</b>，<b>战吼：</b>使相邻的随从获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=NONE
}
public class SW_054e:Ability{
//NAME=为了联盟！
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_055:MinionBase{
//NAME=不耐烦的店长
//TEXT=<b>可交易</b> <b>突袭</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class SW_056:MinionBase{
//NAME=香料面包师
//TEXT=<b>战吼：</b>为你的英雄恢复等同于你手牌数量的生命值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=NONE
}
public class SW_057:MinionBase{
//NAME=包裹速递员
//TEXT=除非你有至少八张手牌，否则无法进行 攻击。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=6|RACE=NONE
}
public class SW_059:MinionBase{
//NAME=矿道工程师
//TEXT=<b>战吼：</b><b>发现</b>一张机械牌，并使其法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=NONE
}
public class SW_059e:Ability{
//NAME=工程改进
//TEXT=法力值消耗减少。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_060:MinionBase{
//NAME=卖花女郎
//TEXT=在你的回合结束时，使你手牌中的一张自然法术牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class SW_060t:Ability{
//NAME=漂亮的花
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_061:MinionBase{
//NAME=公会商人
//TEXT=<b>可交易</b> <b>法术伤害+2</b>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=NONE
}
public class SW_062:MinionBase{
//NAME=闪金镇豺狼人
//TEXT=<b>突袭</b> 你每有一张其他手牌，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=10|ATK=5|HP=4|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Rush");
    }
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            return -owner.myPlayer.hand.Exclude(owner).Count;
        }
        return 0;
    }
}
public class SW_063:MinionBase{
//NAME=战场军官
//TEXT=相邻的随从拥有 <b>风怒</b>。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (FindAdj().Contains(c) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "WindFury";
    }
}
public class SW_063e:Ability{
//NAME=准备战斗！
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_064:MinionBase{
//NAME=北郡农民
//TEXT=<b>战吼：</b>选择一只友方野兽，将它的三张3/3的复制洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class SW_064e:Ability{
//NAME=农场饲养
//TEXT=3/3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_065:MinionBase{
//NAME=熊猫人进口商
//TEXT=<b>战吼：</b><b>发现</b>一张你的套牌之外的法术牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=NONE
}
public class SW_066:MinionBase{
//NAME=王室图书管理员
//TEXT=<b>可交易</b> <b>战吼：</b><b>沉默</b>一个 随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class SW_067:MinionBase{
//NAME=监狱守卫
//TEXT=<b>战吼：</b>使一个友方随从获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NONE
}
public class SW_068:MinionBase{
//NAME=莫尔葛熔魔
//TEXT=<b>嘲讽</b>，<b>亡语：</b>获得8点护甲值。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=DEMON
}
public class SW_068_COPY:MinionBase{
//NAME=莫尔葛熔魔
//TEXT=<b>嘲讽</b>，<b>亡语：</b>获得8点护甲值。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=DEMON
}
public class SW_069:MinionBase{
//NAME=热情的柜员
//TEXT=在你的回合结束时，储存一张你牌库中的牌。<b>亡语：</b>将储存的牌置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class SW_069e:Ability{
//NAME=安全储存
//TEXT=储存着{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_070:MinionBase{
//NAME=邮箱舞者
//TEXT=<b>战吼：</b>将一张幸运币置入你的手牌。<b>亡语：</b>使你的对手获得一张幸运币。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class SW_071:MinionBase{
//NAME=雄狮卫士
//TEXT=<b>战吼：</b>如果你的生命值小于或等于15点，则获得+2/+4和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=NONE
}
public class SW_071e:Ability{
//NAME=保护国王！
//TEXT=+2/+4并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_072:MinionBase{
//NAME=锈烂蝰蛇
//TEXT=<b>可交易</b> <b>战吼：</b>摧毁对手的武器。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=BEAST
}
public class SW_073:MinionBase{
//NAME=奶酪商贩
//TEXT=每当你的对手施放一个法术，随机将一张法力值消耗相同的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=NONE
}
public class SW_074:MinionBase{
//NAME=贵族
//TEXT=<b>战吼：</b> 制作你的一张随机手牌的金色复制。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class SW_075:MinionBase{
//NAME=艾尔文野猪
//TEXT=<b>亡语：</b>在本局对战中如果有7只你的艾尔文野猪死亡，装备一把15/3的锯齿符文剑。0<i>（0/7）</i>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class SW_075t:WeaponBase{
//NAME=锯齿符文剑
//TEXT=在你的英雄攻击后，摧毁你对手的法力水晶。
//MAJ=NEUTRAL|COST=10|ATK=15|HP=3|RACE=NONE
}
public class SW_076:MinionBase{
//NAME=城市建筑师
//TEXT=<b>战吼：</b> 召唤两个0/5并具有<b>嘲讽</b>的城堡石墙。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=NONE
}
public class SW_076t:MinionBase{
//NAME=城堡石墙
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=2|ATK=0|HP=5|RACE=NONE
}
public class SW_077:MinionBase{
//NAME=监狱囚徒
//TEXT=起始<b>休眠</b>状态。在你使用三张牌后唤醒。
//MAJ=NEUTRAL|COST=2|ATK=5|HP=4|RACE=NONE
}
public class SW_077e:Ability{
//NAME=已锁住
//TEXT=<b>休眠</b>。使用3张牌后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_078:MinionBase{
//NAME=普瑞斯托女士
//TEXT=<b>战吼：</b>随机使你牌库中的所有随从牌变形成为龙牌。<i>（保留其原始属性值和法力值消耗。）</I>
//MAJ=NEUTRAL|COST=6|ATK=6|HP=7|RACE=NONE
}
public class SW_078e:Ability{
//NAME=巨龙形态
//TEXT=属性值已调整。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_078e2:Ability{
//NAME=巨龙消耗
//TEXT=法力值消耗已调整。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_079:MinionBase{
//NAME=飞行管理员杜加尔
//TEXT=<b>战吼：</b> 选择一条航线，进入<b>休眠</b>。当你完成飞行时唤醒并获得特效！
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class SW_079e4:Ability{
//NAME=西部荒野航线
//TEXT=<b>休眠</b>。 1回合后召唤一个2/2的冒险者。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_079e5:Ability{
//NAME=铁炉堡航线
//TEXT=<b>休眠</b>。 3回合后为你的英雄恢复10点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_079e6:Ability{
//NAME=瘟疫之地航线
//TEXT=<b>休眠</b>。 5回合后造成12点伤害，随机分配到所有敌人身上。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_079t:SpellBase{
//NAME=西部荒野
//TEXT=一回合后召唤一个2/2并具有随机效果的冒险者。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_079t2:SpellBase{
//NAME=铁炉堡
//TEXT=三回合后，为你的英雄恢复10点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_079t2e:Ability{
//NAME=铁炉堡航线
//TEXT=三回合后，为你的英雄恢复10点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_079t3:SpellBase{
//NAME=东瘟疫之地
//TEXT=五回合后，造成12点伤害，随机分配到所有敌人身上。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_079t3e:Ability{
//NAME=瘟疫之地航线
//TEXT=五回合后，造成12点伤害，随机分配到所有敌人身上。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_079te:Ability{
//NAME=西部荒野航线
//TEXT=下个回合，召唤一个2/2的冒险者。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_080:MinionBase{
//NAME=考内留斯·罗姆
//TEXT=在每个玩家的回合开始和结束时， 抽一张牌。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=NONE
}
public class SW_081:MinionBase{
//NAME=瓦里安，暴风城国王
//TEXT=<b>战吼：</b>抽一张<b>突袭</b>随从牌以获得<b>突袭</b>。依此法检定是否可获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=NEUTRAL|COST=8|ATK=7|HP=7|RACE=NONE
}
public class SW_084:MinionBase{
//NAME=血缚小鬼
//TEXT=每当本随从攻击时，对你的英雄造成2点伤害。
//MAJ=WARLOCK|COST=2|ATK=2|HP=5|RACE=DEMON
}
public class SW_085:SpellBase{
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
public class SW_085t:MinionBase{
//NAME=邪魔
//TEXT=<b>嘲讽</b>
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class SW_086:MinionBase{
//NAME=阴暗的酒保
//TEXT=<b>可交易</b> <b>战吼：</b>使你的所有恶魔获得+2/+2。
//MAJ=WARLOCK|COST=5|ATK=4|HP=4|RACE=NONE
}
public class SW_086e:Ability{
//NAME=灵魂涓滴
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_087:SpellBase{
//NAME=恐惧坐骑
//TEXT=使一个随从获得+1/+1。当该随从死亡时，召唤一匹无尽的恐惧战马。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class SW_087e:Ability{
//NAME=骑乘恐惧战马
//TEXT=+1/+1。<b>亡语：</b>召唤一匹永无止尽的恐惧战马。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_087e2:Ability{
//NAME=塔姆辛的恐惧战马
//TEXT=在回合结束时，召唤一匹恐惧战马。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_087t:MinionBase{
//NAME=塔姆辛的恐惧战马
//TEXT=<b>亡语：</b>在回合结束时，召唤塔姆辛的恐惧战马。
//MAJ=WARLOCK|COST=4|ATK=1|HP=1|RACE=DEMON
}
public class SW_088:SpellBase{
//NAME=恶魔来袭
//TEXT=造成$3点伤害。召唤两个1/3并具有<b>嘲讽</b>的虚空行者。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=FEL
}
public class SW_089:MinionBase{
//NAME=资深顾客
//TEXT=<b>战吼：</b>对所有其他随从造成等同于你手牌数量的伤害。
//MAJ=WARLOCK|COST=6|ATK=3|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.board).Exclude(owner),owner.myPlayer.hand.Count);
    }
}
public class SW_090:SpellBase{
//NAME=纳斯雷兹姆之触
//TEXT=对一个随从造成$2点伤害。如果该随从死亡，则为你的英雄恢复3点生命值。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class SW_091:SpellBase{
//NAME=恶魔之种
//TEXT=<b>任务线：</b>在你的回合中受到10点伤害。<b>奖励：</b><b>吸血</b>。对敌方英雄造成$3点伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_091t:SpellBase{
//NAME=建立连接
//TEXT=<b>任务线：</b>在你的回合中受到10点伤害。<b>奖励：</b><b>吸血</b>。对敌方英雄造成$3点伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_091t3:SpellBase{
//NAME=完成仪式
//TEXT=<b>任务线：</b>在你的回合中受到10点伤害。<b>奖励：</b>枯萎化身塔姆辛。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_091t4:MinionBase{
//NAME=枯萎化身塔姆辛
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你在你的回合受到的伤害改为伤害你的对手。
//MAJ=WARLOCK|COST=5|ATK=7|HP=7|RACE=UNDEAD
}
public class SW_091t5:Ability{
//NAME=枯萎化身
//TEXT=在本局对战的剩余时间内，你在你的回合受到的伤害改为伤害你的对手。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_092:MinionBase{
//NAME=安纳塞隆
//TEXT=如果你的手牌数量达到上限，该牌的法力值消耗为（1）点。
//MAJ=WARLOCK|COST=6|ATK=8|HP=6|RACE=DEMON
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            if(owner.myPlayer.hand.Count==owner.myPlayer.maxnum[(int)ZoneType.Hand])
            {
                return -owner.GetTag(GameTag.Mana)+1;
            }   
        }
        return 0;
    }
}
public class SW_093:MinionBase{
//NAME=暴风城海盗
//TEXT=<b>战吼：</b>在本回合中，使你的英雄获得+2攻击力。
//MAJ=WARRIOR|COST=3|ATK=3|HP=4|RACE=PIRATE
    public override void Battlecry(Card target=null)
    {
        TaskBuffMyHero(atk:2);
    }
}
public class SW_093e:Ability{
//NAME=受雇抢劫
//TEXT=在本回合中，+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_094:SpellBase{
//NAME=厚重板甲
//TEXT=<b>可交易</b> 获得8点护甲值。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class SW_095:SpellBase{
//NAME=投资良机
//TEXT=抽一张<b>过载</b>牌。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_097:MinionBase{
//NAME=遥控傀儡
//TEXT=在本随从受到伤害后，将两张傀儡部件洗入你的牌库。当抽到傀儡部件时，召唤一个2/1的机械。
//MAJ=WARRIOR|COST=4|ATK=3|HP=6|RACE=MECHANICAL
}
public class SW_097t:SpellBase{
//NAME=傀儡部件
//TEXT=<b>抽到时施放</b> 召唤一个2/1的损坏的傀儡。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_107:SpellBase{
//NAME=火热促销
//TEXT=<b>可交易</b> 对所有随从造成 $3点伤害。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class SW_108:SpellBase{
//NAME=初始之火
//TEXT=对一个随从造成$2点伤害。将“传承之火”置入你的手牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FIRE
}
public class SW_108t:SpellBase{
//NAME=传承之火
//TEXT=对一个随从造成$2点伤害。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FIRE
}
public class SW_109:MinionBase{
//NAME=笨拙的信使
//TEXT=<b>战吼：</b>从你的手牌中施放法力值消耗最高的法术。
//MAJ=MAGE|COST=7|ATK=4|HP=5|RACE=NONE
}
public class SW_110:SpellBase{
//NAME=点燃
//TEXT=造成$2点伤害。将一张伤害提高一点的“点燃”洗入 你的牌库。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class SW_111:MinionBase{
//NAME=圣殿蜡烛商
//TEXT=在你施放一个火焰法术后，抽一张 法术牌。
//MAJ=MAGE|COST=5|ATK=4|HP=5|RACE=ELEMENTAL
}
public class SW_112:MinionBase{
//NAME=普瑞斯托的炎术师
//TEXT=<b>战吼：</b>你的下一个火焰法术拥有<b>法术伤害+2</b>。
//MAJ=MAGE|COST=2|ATK=2|HP=3|RACE=NONE
}
public class SW_112e:Ability{
//NAME=火热灼烧！
//TEXT=你的下一个火焰法术拥有<b>法术伤害+2</b>。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_112e2:Ability{
//NAME=火热灼烧！
//TEXT=你的下一个火焰法术拥有<b>法术伤害+2</b>。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_113:MinionBase{
//NAME=首席法师安东尼达斯
//TEXT=<b>战吼：</b>如果你在上三个回合中都施放过火焰法术，随机对敌人施放三个火球术。0<i>（0/3）</i>
//MAJ=MAGE|COST=8|ATK=6|HP=6|RACE=NONE
}
public class SW_114:SpellBase{
//NAME=强行透支
//TEXT=<b>可交易</b> 解锁你<b>过载</b>的法力水晶，并造成等量的 伤害。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,owner.myPlayer.GetTag(GameTag.ManaOverLoad)).Resolve();
        owner.myPlayer.SetTag(GameTag.ManaOverLoad,0);
    }
}
public class SW_115:MinionBase{
//NAME=伯尔纳·锤喙
//TEXT=在你使用一张<b>战吼</b> 随从牌后，重复一次本回合使用的第一个<b>战吼</b>。
//MAJ=SHAMAN|COST=2|ATK=1|HP=4|RACE=NONE
}
public class SW_305:MinionBase{
//NAME=乌瑞恩首席剑士
//TEXT=<b>圣盾</b>，<b>战吼：</b>如果本随从拥有至少4点攻击力，获得<b>突袭</b>。
//MAJ=PALADIN|COST=4|ATK=3|HP=5|RACE=NONE
}
public class SW_306:MinionBase{
//NAME=劳累的驮骡
//TEXT=<b>嘲讽</b> 当你抽到该牌时，将它的一张复制置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class SW_307:MinionBase{
//NAME=旅行商人
//TEXT=<b>可交易</b> <b>战吼：</b>你每控制一个其他友方随从，便获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class SW_307e:Ability{
//NAME=生意火爆
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_310:WeaponBase{
//NAME=伪造的匕首
//TEXT=<b>战吼：</b>获取在本局对战中死亡的一个随机友方<b>亡语</b>随从的一张复制。
//MAJ=ROGUE|COST=4|ATK=4|HP=2|RACE=NONE
}
public class SW_310e:Ability{
//NAME=伪造的匕首
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_311:SpellBase{
//NAME=锁喉
//TEXT=对敌方英雄造成$2点伤害，将三张流血洗入你的牌库。抽到流血时，再造成$2点伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class SW_311t:SpellBase{
//NAME=流血
//TEXT=<b>抽到时施放</b> 对敌方英雄造成$2点伤害。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_313:SpellBase{
//NAME=挺身而出
//TEXT=<b>任务线：</b>使用三张不同的法力值消耗为（1）的牌。<b>奖励：</b>装备一把1/4的圣光的正义。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_313e1:Ability{
//NAME=荡平道路
//TEXT=法力值消耗减少（1）点。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_313t:SpellBase{
//NAME=荡平道路
//TEXT=<b>任务线：</b>使用三张不同的法力值消耗为（1）的牌。<b>奖励：</b>升级你的英雄技能。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_313t2:SpellBase{
//NAME=为逝者复仇
//TEXT=<b>任务线：</b>使用三张不同的法力值消耗为（1）的牌。<b>奖励：</b>圣光化身凯瑞尔。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_313t4:MinionBase{
//NAME=圣光化身凯瑞尔
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你的白银之手新兵拥有+2/+2。
//MAJ=PALADIN|COST=5|ATK=7|HP=7|RACE=NONE
}
public class SW_313t4e:Ability{
//NAME=圣光之力
//TEXT=在本局对战的剩余时间内，你的白银之手新兵拥有+2/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_313t4ee:Ability{
//NAME=圣光威能
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_314:WeaponBase{
//NAME=光明使者之锤
//TEXT=<b>吸血</b> 无法攻击英雄。
//MAJ=PALADIN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class SW_315:MinionBase{
//NAME=联盟旗手
//TEXT=<b>战吼：</b>抽一张随从牌。使你手牌中的随从牌获得+1/+1。
//MAJ=PALADIN|COST=3|ATK=2|HP=2|RACE=NONE
}
public class SW_315e:Ability{
//NAME=暴风城的骄傲
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_316:SpellBase{
//NAME=神圣坐骑
//TEXT=使一个随从获得+1/+1和<b>圣盾</b>。当该随从死亡时，召唤一匹战马。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectGiveAbility(owner.myPlayer,owner,target,"DivineShield").Resolve();
        new EffectChange(owner.myPlayer,owner,target,atkChange:1,hpChange:1).Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,target,"SW_316e").Resolve();
    }
}
public class SW_316e:Ability{
//NAME=骑乘战马
//TEXT=+1/+1和<b>圣盾</b>。<b>亡语：</b>召唤一匹战马。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("SW_316t"),ZoneType.Board);
    }
}
public class SW_316t:MinionBase{
//NAME=凯瑞尔的战马
//TEXT=<b>圣盾</b>
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("DivineShield");
    }
}
public class SW_317:MinionBase{
//NAME=古墓卫士
//TEXT=<b>吸血</b>，<b>战吼：</b>对一个敌方随从造成等同于本随从攻击力的伤害。
//MAJ=PALADIN|COST=3|ATK=1|HP=4|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,owner.GetTag(GameTag.Attack)).Resolve();
    }
}
public class SW_319:MinionBase{
//NAME=农夫
//TEXT=在你的回合开始时，抽一张牌。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class SW_320:SpellBase{
//NAME=硕鼠成群
//TEXT=召唤七只1/1的老鼠。战场上放不下的老鼠会进入你的手牌，并获得+4/+4。
//MAJ=HUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class SW_320e:Ability{
//NAME=身形巨硕
//TEXT=+4/+4
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_321:SpellBase{
//NAME=瞄准射击
//TEXT=造成$3点伤害。你的下一个英雄技能会额外造成2点伤害。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class SW_321e:Ability{
//NAME=瞄准
//TEXT=你的下一个英雄技能会额外造成2点伤害。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_322:SpellBase{
//NAME=保卫矮人区
//TEXT=<b>任务线：</b>通过三张法术牌造成伤害。<b>奖励：</b>你的英雄技能能够以随从为目标。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_322e:Ability{
//NAME=熟练掌握
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_322e2:Ability{
//NAME=塔维什·雷矛强化效果
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你的法术牌会复原你的英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_322e3:Ability{
//NAME=无不中的
//TEXT=你的英雄技能能够以随从为目标。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_322t:SpellBase{
//NAME=占据高地
//TEXT=<b>任务线：</b>通过两张法术牌造成伤害。<b>奖励：</b>将你的英雄技能法力值消耗变为（0）点。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_322t2:SpellBase{
//NAME=干掉他们
//TEXT=<b>任务线：</b>通过两张法术牌造成伤害。<b>奖励：</b>射击大师塔维什。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_322t4:MinionBase{
//NAME=射击大师塔维什
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你施放的法术会复原你的英雄技能。
//MAJ=HUNTER|COST=5|ATK=7|HP=7|RACE=NONE
}
public class SW_323:MinionBase{
//NAME=鼠王
//TEXT=<b>突袭</b>，<b>亡语：</b>进入<b>休眠</b>状态。在5个友方随从死亡后复活。
//MAJ=HUNTER|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class SW_323e:Ability{
//NAME=鼠王眠寝
//TEXT=<b>休眠</b>。5个友方随从死亡后唤醒。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_400:MinionBase{
//NAME=被困的女巫
//TEXT=<b>战吼：</b>如果你控制一个<b>任务</b>，<b>发现</b>一张法术牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class SW_405:SpellBase{
//NAME=简略情报
//TEXT=抽一张法力值消耗小于或等于（4）点的<b>亡语</b>牌。触发其 <b>亡语</b>。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card ToDraw = null;
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.HasAbility("Deathrattle"))
            {
                if(c.GetTag(GameTag.Mana)<=4)
                {
                    ToDraw = c;
                }
            }
        }
        if(ToDraw!=null)
        {
            TaskDraw(ToDraw);    
            for(int i = ToDraw.abilityList.Count-1; i>0; i--)
            {
                ToDraw.abilityList[i].Deathrattle();
            }
        }
    }
}
public class SW_411:MinionBase{
//NAME=军情七处线人
//TEXT=<b>战吼：</b>在本局对战中，你每使用过一张其他军情七处牌，便获得+1/+1。
//MAJ=ROGUE|COST=4|ATK=3|HP=3|RACE=NONE
}
public class SW_411e:Ability{
//NAME=情报完备
//TEXT=+1/+1
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_412:SpellBase{
//NAME=军情七处的要挟
//TEXT=<b>可交易</b> 对一个未受伤的角色造成$3点伤害。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_413:MinionBase{
//NAME=军情七处探员
//TEXT=<b>突袭</b> 在本随从攻击一个随从后，获得<b>潜行</b>。
//MAJ=ROGUE|COST=3|ATK=2|HP=4|RACE=NONE
}
public class SW_417:MinionBase{
//NAME=军情七处刺客
//TEXT=在本局对战中，你每使用过一张军情七处牌，本牌的法力值消耗便减少（1）点。<b>连击：</b>消灭一个敌方随从。
//MAJ=ROGUE|COST=7|ATK=4|HP=4|RACE=NONE
}
public class SW_418:MinionBase{
//NAME=军情七处潜伏者
//TEXT=<b>潜行</b>，<b>战吼：</b>你抽到的下一张牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class SW_418e:Ability{
//NAME=机密情报
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_418e2:Ability{
//NAME=间谍工具
//TEXT=你抽到的下一张牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_419:MinionBase{
//NAME=艾露恩神谕者
//TEXT=在你使用一张法力值消耗小于或等于（2）点的随从牌后，召唤一个它的复制。
//MAJ=DRUID|COST=3|ATK=2|HP=4|RACE=NONE
}
public class SW_422:SpellBase{
//NAME=播种施肥
//TEXT=<b>抉择：</b>使你的所有随从获得+1攻击力；或者召唤一个2/2的树人。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class SW_422a:SpellBase{
//NAME=新生幼苗
//TEXT=召唤一个2/2的树人。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class SW_422b:SpellBase{
//NAME=肥料滋养
//TEXT=使你的所有随从获得+1攻击力。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class SW_422e:Ability{
//NAME=重新种植
//TEXT=+1攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_422t:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class SW_428:SpellBase{
//NAME=游园迷梦
//TEXT=<b>任务线：</b>使你的英雄获得4点攻击力。<b>奖励：</b>获得5点 护甲值。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_428t:SpellBase{
//NAME=保护松鼠
//TEXT=<b>任务线：</b>使你的英雄获得5点攻击力。<b>奖励：</b>获得5点护甲值，抽一张牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_428t2:SpellBase{
//NAME=野性暴朋
//TEXT=<b>任务线：</b>使你的英雄获得6点攻击力。<b>奖励：</b>铁肤古夫。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_428t4:MinionBase{
//NAME=铁肤古夫
//TEXT=<b>嘲讽</b>，<b>战吼：</b>在本回合中使你的英雄获得+8攻击力。获得8点护甲值。
//MAJ=DRUID|COST=5|ATK=8|HP=8|RACE=BEAST
}
public class SW_428t4e:Ability{
//NAME=古夫的祝福
//TEXT=在本回合中你的英雄拥有攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_429:SpellBase{
//NAME=紧壳商品
//TEXT=<b>可交易</b> 召唤两只2/7并具有<b>嘲讽</b>的龟。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NONE
}
public class SW_429t:MinionBase{
//NAME=金壳龟
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=4|ATK=2|HP=7|RACE=BEAST
}
public class SW_431:MinionBase{
//NAME=花园猎豹
//TEXT=<b>突袭</b> 每当本随从攻击时，使你的英雄在本回合中获得+3攻击力。
//MAJ=DRUID|COST=4|ATK=4|HP=4|RACE=BEAST
}
public class SW_431e:Ability{
//NAME=嗷！
//TEXT=在本回合中+3攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_432:SpellBase{
//NAME=科多兽坐骑
//TEXT=使一个随从获得+4/+2和<b>突袭</b>。当该随从死亡时，召唤一只科多兽。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class SW_432e:Ability{
//NAME=骑乘科多兽
//TEXT=+4/+2和<b>突袭</b>，<b>亡语：</b>召唤一只科多兽。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_432t:MinionBase{
//NAME=古夫的科多兽
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class SW_433:SpellBase{
//NAME=寻求指引
//TEXT=<b>任务线：</b>使用法力值消耗为（2），（3），（4）的牌各一张。<b>奖励：</b>从你的牌库中<b>发现</b>一张牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_433t:SpellBase{
//NAME=发现虚空碎片
//TEXT=<b>任务线：</b>使用法力值消耗为（5）和（6）的牌各一张。<b>奖励：</b>从你的牌库中<b>发现</b>一张牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_433t2:SpellBase{
//NAME=照亮虚空
//TEXT=<b>任务线：</b>使用法力值消耗为（7）和（8）的牌各一张。<b>奖励：</b>圣徒泽瑞拉。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_433t3:MinionBase{
//NAME=圣徒泽瑞拉
//TEXT=<b>嘲讽</b>，<b>战吼：</b>将净化的碎片洗入你的 牌库。
//MAJ=PRIEST|COST=5|ATK=7|HP=7|RACE=NONE
}
public class SW_433t3a:SpellBase{
//NAME=净化的碎片
//TEXT=消灭敌方英雄。
//MAJ=PRIEST|COST=10|ATK=0|HP=0|RACE=HOLY
}
public class SW_434:MinionBase{
//NAME=放贷的鲨鱼
//TEXT=<b>战吼：</b>使你的对手获得一张幸运币。 <b>亡语：</b>使你获得两张幸运币。
//MAJ=ROGUE|COST=3|ATK=3|HP=4|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        CardDbf Coin = CardDbf.GetCardDbfByGuid("GAME_005");
        TaskCreate(Coin,ZoneType.Hand,ToEn:true);
        TaskCreate(Coin,ZoneType.Hand,ToEn:true);
    }
    public override void Deathrattle()
    {
        CardDbf Coin = CardDbf.GetCardDbfByGuid("GAME_005");
        TaskCreate(Coin,ZoneType.Hand);
        TaskCreate(Coin,ZoneType.Hand);
    }
}
public class SW_436:MinionBase{
//NAME=柳魔锐爪兽
//TEXT=在你的英雄获得攻击力后，本随从获得+2攻击力。
//MAJ=DRUID|COST=2|ATK=1|HP=4|RACE=BEAST
}
public class SW_436e:Ability{
//NAME=柳魔邪爪
//TEXT=+2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_437:SpellBase{
//NAME=堆肥
//TEXT=使你的所有随从获得“<b>亡语：</b>抽一张牌。”
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class SW_437e:Ability{
//NAME=肥料充足
//TEXT=<b>亡语：</b>抽一张牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_439:MinionBase{
//NAME=活泼的松鼠
//TEXT=<b>亡语：</b>将四张橡果洗入你的牌库。当抽到橡果时，召唤一只2/1的松鼠。
//MAJ=DRUID|COST=1|ATK=2|HP=1|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        for(int i=0;i<6;i++)
        {
            CardDbf ToSummon = CardDbf.GetCardDbfByGuid("SW_439t");
            TaskCreate(ToSummon,ZoneType.Deck,randpos:true);
        }
    }
}
public class SW_439t:SpellBase{
//NAME=橡果
//TEXT=<b>抽到时施放</b> 召唤一只2/1的 松鼠。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("CastWhenDrawn");
    }
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("SW_439t2"),ZoneType.Board);
    }
}
public class SW_439t2:MinionBase{
//NAME=满足的松鼠
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class SW_440:SpellBase{
//NAME=墓园召唤
//TEXT=<b>发现</b>一张<b>亡语</b>随从牌。如果你有足够的法力值使用这张随从牌，触发其<b>亡语</b>。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class SW_441:SpellBase{
//NAME=纳鲁碎片
//TEXT=<b>可交易</b> <b>沉默</b>所有敌方随从。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class SW_442:SpellBase{
//NAME=虚空碎片
//TEXT=<b>吸血</b> 造成$4点伤害。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class SW_443:SpellBase{
//NAME=雷象坐骑
//TEXT=使一个随从获得+4/+7和<b>嘲讽</b>。当该随从死亡时，召唤一只雷象。
//MAJ=PRIEST|COST=7|ATK=0|HP=0|RACE=NONE
}
public class SW_443e:Ability{
//NAME=骑乘雷象
//TEXT=+4/+7并具有<b>嘲讽</b>。 <b>亡语：</b>召唤一只雷象。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_443t:MinionBase{
//NAME=泽瑞拉的雷象
//TEXT=<b>嘲讽</b>
//MAJ=PRIEST|COST=6|ATK=4|HP=7|RACE=BEAST
}
public class SW_444:MinionBase{
//NAME=暮光欺诈者
//TEXT=<b>战吼：</b>如果有英雄在本回合中受到伤害，抽一张暗影法术牌。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        bool Active=false;
        foreach(Card c in owner.myPlayer.hero.Merge(owner.myPlayer.otherPlayer.hero))
        {
            if(c.GetTag(GameTag.CntDamageTakenThisTurn)>0)
            {
                TaskDrawSchool(SpellSchoolType.Shadow);
            }
        }
    }
}
public class SW_445:MinionBase{
//NAME=灵能魔
//TEXT=在你施放一个暗影法术后，对双方英雄造成2点伤害。
//MAJ=PRIEST|COST=3|ATK=3|HP=4|RACE=NONE
}
public class SW_446:MinionBase{
//NAME=虚触侍从
//TEXT=双方英雄受到的所有伤害提高一点。
//MAJ=PRIEST|COST=1|ATK=1|HP=3|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTakeDamage(this,this.CauseEvent));
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterTakeDamage(this,this.CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        owner.myPlayer.RemoveCallBackOf(this);
        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
    }
    public void CauseEvent(Card source,Card target, int amount)
    {
        if(CondInPlay())
        {
            if(target.cardType==CardType.Hero)
            {
                new EffectDamage(owner.myPlayer,owner,target,1,silent:true).Resolve();
            }
        }
    }
}
public class SW_446e:Ability{
//NAME=虚空之触
//TEXT=双方英雄受到的所有伤害提高一点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_447:MinionBase{
//NAME=沙德拉斯·月树
//TEXT=<b>战吼：</b>使你接下来抽到的三张法术牌获得<b>抽到时施放</b>效果。
//MAJ=DRUID|COST=8|ATK=5|HP=5|RACE=NONE
}
public class SW_447e:Ability{
//NAME=艾露恩的指引
//TEXT=接下来抽到的三张法术牌获得<b>抽到时施放</b>效果。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_447e2:Ability{
//NAME=艾露恩的指引2
//TEXT=接下来抽到的三张法术牌获得<b>抽到时施放</b>效果。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_448:MinionBase{
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
public class SW_450:SpellBase{
//NAME=巫师的计策
//TEXT=<b>任务线：</b>施放火焰，冰霜和奥术法术各一个。<b>奖励：</b>抽一张法术牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_450t:SpellBase{
//NAME=拖延时间
//TEXT=<b>任务线：</b>施放火焰，冰霜和奥术法术各一个。<b>奖励：</b><b>发现</b>上述派系中的一张法术牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_450t2:SpellBase{
//NAME=抵达传送大厅
//TEXT=<b>任务线：</b>施放火焰，冰霜和奥术法术各一个。<b>奖励：</b>奥术师晨拥。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class SW_450t4:MinionBase{
//NAME=奥术师晨拥
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你拥有<b>法术伤害+3</b>。
//MAJ=MAGE|COST=5|ATK=7|HP=7|RACE=NONE
}
public class SW_450t4e:Ability{
//NAME=晨拥之力
//TEXT=<b>法术伤害+3</b>
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_451:MinionBase{
//NAME=魔变鱼人
//TEXT=<b>嘲讽</b>，<b>战吼：</b>如果你在本回合中施放过邪能法术，获得+2/+2。
//MAJ=DEMONHUNTER|COST=1|ATK=1|HP=2|RACE=MURLOC
}
public class SW_451e:Ability{
//NAME=强力变形
//TEXT=+2/+2
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_452:SpellBase{
//NAME=混乱吸取
//TEXT=<b>吸血</b> 对一个随从造成$3点伤害。<b>流放：</b>改为 造成$5点。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=FEL
}
public class SW_454:WeaponBase{
//NAME=雄狮之怒
//TEXT=攻击力等同于 你在本回合中抽牌的数量。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=2|RACE=NONE
}
public class SW_455:MinionBase{
//NAME=老鼠窝
//TEXT=<b>亡语：</b>召唤五只1/1的老鼠。
//MAJ=HUNTER|COST=4|ATK=2|HP=2|RACE=NONE
}
public class SW_455t:MinionBase{
//NAME=老鼠
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class SW_457:WeaponBase{
//NAME=制皮工具
//TEXT=在三个友方野兽死亡后，抽一张野兽牌并使其获得+1/+1。失去1点耐久度。
//MAJ=HUNTER|COST=1|ATK=0|HP=3|RACE=NONE
}
public class SW_457e:Ability{
//NAME=强化皮革
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_458:SpellBase{
//NAME=山羊坐骑
//TEXT=使一个随从获得+2/+2和攻击时具有<b>免疫</b>。当该随从死亡时，召唤一只山羊。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class SW_458e:Ability{
//NAME=骑乘山羊
//TEXT=+2/+2和攻击时<b>免疫</b>。<b>亡语：</b>召唤一只山羊。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_458t:MinionBase{
//NAME=塔维什的山羊
//TEXT=在攻击时<b>免疫</b>。
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class SW_459:MinionBase{
//NAME=暴风城吹笛人
//TEXT=在本随从攻击后，使你的野兽获得+1/+1。
//MAJ=HUNTER|COST=3|ATK=1|HP=6|RACE=DEMON
}
public class SW_459e:Ability{
//NAME=着迷
//TEXT=+1/+1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_460:SpellBase{
//NAME=集群撕咬
//TEXT=选择一个敌方随从，使你的所有随从攻击该随从，并将死亡的友方随从移回你的手牌。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_462:SpellBase{
//NAME=炽热连击
//TEXT=在本回合中，你的下一张火焰法术牌法力值消耗减少 （2）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=FIRE
}
public class SW_462e:Ability{
//NAME=炽热连击
//TEXT=你使用的下一张火焰法术牌法力值消耗减少（2）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_463:MinionBase{
//NAME=进口狼蛛
//TEXT=<b>可交易</b> <b>亡语：</b>召唤两只1/1并具有<b>剧毒</b>和<b>突袭</b>的 蜘蛛。
//MAJ=HUNTER|COST=5|ATK=4|HP=5|RACE=BEAST
}
public class SW_463t:MinionBase{
//NAME=入侵的蜘蛛
//TEXT=<b>剧毒</b>，<b>突袭</b>
//MAJ=HUNTER|COST=2|ATK=1|HP=1|RACE=BEAST
}
public class SW_700:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_701:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=9|RACE=NONE
}
public class SW_702:HeroPowerBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_710:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_710t0:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_710t1:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_710t2:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_710t3:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_710t4:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_710t5:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_710t6:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_710t7:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_710t8:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_710t9:SpellBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_711:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class SW_712:HeroPowerBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_COIN1:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class SW_COIN2:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
