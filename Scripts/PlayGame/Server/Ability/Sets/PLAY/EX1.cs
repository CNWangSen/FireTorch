using System.Collections;
using System.Collections.Generic;

public class EX1_001:MinionBase{
//NAME=圣光护卫者
//TEXT=每当一个角色获得治疗，便获得 +2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class EX1_001e:Ability{
//NAME=护佑之力
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_002:MinionBase{
//NAME=黑骑士
//TEXT=<b>战吼：</b>消灭一个具有<b>嘲讽</b>的敌方随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class EX1_004:MinionBase{
//NAME=年轻的女祭司
//TEXT=在你的回合结束时，随机使另一个友方随从获得+1生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class EX1_004e:Ability{
//NAME=艾露恩的赐福
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_005:MinionBase{
//NAME=王牌猎人
//TEXT=<b>可交易</b> <b>战吼：</b>消灭一个攻击力大于或等于7的随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=NONE
}
public class EX1_006:MinionBase{
//NAME=报警机器人
//TEXT=在你的回合开始时，随机将你的手牌中的一张随从牌与本随从 交换。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=3|RACE=MECHANICAL
}
public class EX1_007:MinionBase{
//NAME=苦痛侍僧
//TEXT=每当本随从受到伤害，抽一张牌。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=NONE
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
        if(amount>0)
            TaskDraw();
    }
}
public class EX1_008:MinionBase{
//NAME=银色侍从
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class EX1_009:MinionBase{
//NAME=愤怒的小鸡
//TEXT=受伤时拥有+5攻 击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class EX1_009e:Ability{
//NAME=激怒
//TEXT=+5攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_010:MinionBase{
//NAME=狼人渗透者
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class EX1_011:MinionBase{
//NAME=巫医
//TEXT=<b>战吼：</b> 恢复#2点生命值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
}
public class EX1_012:MinionBase{
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
public class EX1_014:MinionBase{
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
public class EX1_014t:SpellBase{
//NAME=香蕉
//TEXT=使一个随从获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,atkChange:1,hpChange:1).Resolve();
    }
}
public class EX1_014te:Ability{
//NAME=香蕉
//TEXT=拥有+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_015:MinionBase{
//NAME=工程师学徒
//TEXT=<b>战吼：</b>抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=NONE
}
public class EX1_016:MinionBase{
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
public class EX1_017:MinionBase{
//NAME=丛林猎豹
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class EX1_019:MinionBase{
//NAME=破碎残阳祭司
//TEXT=<b>战吼：</b>使一个友方随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=NONE
}
public class EX1_019e:Ability{
//NAME=祭司的祝福
//TEXT=+1/+1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_020:MinionBase{
//NAME=血色十字军战士
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=NONE
}
public class EX1_021:MinionBase{
//NAME=萨尔玛先知
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class EX1_023:MinionBase{
//NAME=银月城卫兵
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class EX1_025:MinionBase{
//NAME=机械幼龙技工
//TEXT=<b>战吼：</b>召唤一个2/1的机械幼龙。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=NONE
}
public class EX1_025t:MinionBase{
//NAME=机械幼龙
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=MECHANICAL
}
public class EX1_028:MinionBase{
//NAME=荆棘谷猛虎
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class EX1_029:MinionBase{
//NAME=麻风侏儒
//TEXT=<b>亡语：</b>对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
    public override void Deathrattle()
    {
        TaskDamageEnemyHero(2);
    }
}
public class EX1_029_Puzzle:MinionBase{
//NAME=麻风侏儒
//TEXT=<b>亡语：</b>对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
    public override void Deathrattle()
    {
        TaskDamageEnemyHero(2);
    }
}
public class EX1_032:MinionBase{
//NAME=烈日行者
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=NONE
}
public class EX1_033:MinionBase{
//NAME=风怒鹰身人
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=NONE
}
public class EX1_043:MinionBase{
//NAME=暮光幼龙
//TEXT=<b>战吼：</b> 你每有一张手牌，便获得+1生命值。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=1|RACE=DRAGON
    public override void Battlecry(Card target =null)
    {
        int Num=owner.myPlayer.hand.Count;
        new EffectChange(owner.myPlayer,owner,owner,hpChange:Num).Resolve();
    }
}
public class EX1_043e:Ability{
//NAME=暮光审判
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_044:MinionBase{
//NAME=任务达人
//TEXT=每当你使用一张牌时，便获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class EX1_044e:Ability{
//NAME=升级
//TEXT=攻击力和生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_045:MinionBase{
//NAME=上古看守者
//TEXT=无法攻击。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=5|RACE=NONE
}
public class EX1_046:MinionBase{
//NAME=黑铁矮人
//TEXT=<b>战吼：</b>在本回合中，使一个随从获得+2攻击力。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class EX1_046e:Ability{
//NAME=淬火
//TEXT=在本回合中，+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_048:MinionBase{
//NAME=破法者
//TEXT=<b>战吼：</b> <b>沉默</b>一个随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=NONE
}
public class EX1_049:MinionBase{
//NAME=年轻的酒仙
//TEXT=<b>战吼：</b>使一个友方随从从战场上移回你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class EX1_050:MinionBase{
//NAME=寒光智者
//TEXT=<b>战吼：</b>每个玩家抽两张牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=MURLOC
}
public class EX1_055:MinionBase{
//NAME=魔瘾者
//TEXT=在本回合中，每当你施放一个法术，便获得+2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=NONE
}
public class EX1_055o:Ability{
//NAME=嗜魔增幅
//TEXT=魔瘾者的攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_057:MinionBase{
//NAME=年迈的酒仙
//TEXT=<b>战吼：</b>使一个友方随从从战场上移回你的手牌。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=NONE
}
public class EX1_058:MinionBase{
//NAME=日怒保卫者
//TEXT=<b>战吼：</b>使相邻的随从获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class EX1_059:MinionBase{
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
public class EX1_059e:Ability{
//NAME=实验！
//TEXT=疯狂的炼金师使其攻击力和生命值互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_062:MinionBase{
//NAME=老瞎眼
//TEXT=<b>冲锋</b>，在战场上每有一个其他鱼人便拥有+1攻击力。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=MURLOC
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            int num = 0;
            foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
            {
                if(c.raceType.Contains(RaceType.Murloc) && c!=owner)
                {
                    num+=1;
                }
            }
            return num;
        }
        return 0;
    }
}
public class EX1_062_G:MinionBase{
//NAME=老瞎眼
//TEXT=<b>冲锋</b>，在战场上每有一个其他鱼人便拥有+1攻击力。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=MURLOC
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            int num = 0;
            foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
            {
                if(c.raceType.Contains(RaceType.Murloc) && c!=owner)
                {
                    num+=2;
                }
            }
            return num;
        }
        return 0;
    }
}
public class EX1_066:MinionBase{
//NAME=酸性沼泽软泥怪
//TEXT=<b>战吼：</b> 摧毁对手的武器。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class EX1_067:MinionBase{
//NAME=银色指挥官
//TEXT=<b>冲锋</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=2|RACE=NONE
}
public class EX1_076:MinionBase{
//NAME=小个子召唤师
//TEXT=你每个回合使用的第一张随从牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class EX1_076e:Ability{
//NAME=浓缩即精华
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_080:MinionBase{
//NAME=奥秘守护者
//TEXT=每当有一张<b>奥秘</b>牌被使用时，便获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class EX1_080o:Ability{
//NAME=守护奥秘
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_082:MinionBase{
//NAME=疯狂投弹者
//TEXT=<b>战吼：</b>造成3点伤害，随机分配到所有其他角色身上。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class EX1_083:MinionBase{
//NAME=工匠大师欧沃斯巴克
//TEXT=<b>战吼：</b> 随机使另一个随从变形成为一个5/5的魔暴龙或一个1/1的松鼠。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class EX1_084:MinionBase{
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
public class EX1_084e:Ability{
//NAME=突袭
//TEXT=拥有<b>突袭</b>。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_085:MinionBase{
//NAME=精神控制技师
//TEXT=<b>战吼：</b>如果你的对手有4个或者更多随从，夺取其中一个的控制权。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class EX1_089:MinionBase{
//NAME=奥术傀儡
//TEXT=<b>冲锋</b>，<b>战吼：</b>使你的对手获得一个法力水晶。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.otherPlayer.ChangeTag(GameTag.ManaThisTurn,1);
    }
}
public class EX1_091:MinionBase{
//NAME=秘教暗影祭司
//TEXT=<b>战吼：</b>夺取一个攻击力小于或等于2的敌方随从的控制权。
//MAJ=PRIEST|COST=6|ATK=4|HP=5|RACE=NONE
}
public class EX1_093:MinionBase{
//NAME=阿古斯防御者
//TEXT=<b>战吼：</b>使相邻的随从获得+1/+1和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> ToListBuff = FindAdj(owner);
        TaskBuffTargets(ToListBuff,atk:1,hp:1);
        List<string> abis = new List<string>();
        foreach(Card c in ToListBuff)
        {
            abis.Add("Taunt");
        }
        new EffectGiveAbility(owner.myPlayer,owner,targets:ToListBuff,abinames:abis).Resolve();
    }
}
public class EX1_093_G:MinionBase{
//NAME=阿古斯防御者
//TEXT=<b>战吼：</b>使相邻的随从获得+1/+1和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Battlecry(Card target=null)
    {
        List<Card> ToListBuff = FindAdj(owner);
        TaskBuffTargets(ToListBuff,atk:2,hp:2);
        List<string> abis = new List<string>();
        foreach(Card c in ToListBuff)
        {
            abis.Add("Taunt");
        }
        new EffectGiveAbility(owner.myPlayer,owner,targets:ToListBuff,abinames:abis).Resolve();
    }
}

public class EX1_093e:Ability{
//NAME=阿古斯之手
//TEXT=+1/+1并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_095:MinionBase{
//NAME=加基森拍卖师
//TEXT=每当你施放一个法术，抽一张牌。
//MAJ=NEUTRAL|COST=7|ATK=4|HP=4|RACE=NONE
}
public class EX1_096:MinionBase{
//NAME=战利品贮藏者
//TEXT=<b>亡语：</b>抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class EX1_097:MinionBase{
//NAME=憎恶
//TEXT=<b>嘲讽，亡语：</b>对所有角色造成2点伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=UNDEAD
}
public class EX1_100:MinionBase{
//NAME=游学者周卓
//TEXT=每当一个玩家施放一个法术，复制该法术，将其置入另一个玩家的手牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=4|RACE=NONE
}
public class EX1_102:MinionBase{
//NAME=攻城车
//TEXT=在你的回合开始时，随机对一个敌人造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=MECHANICAL
}
public class EX1_103:MinionBase{
//NAME=寒光先知
//TEXT=<b>战吼：</b>使你的其他鱼人获得+2生命值。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=MURLOC
}
public class EX1_103e:Ability{
//NAME=鱼人怒吼
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_105:MinionBase{
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
public class EX1_110:MinionBase{
//NAME=凯恩·血蹄
//TEXT=<b>亡语：</b>召唤一个5/5的贝恩·血蹄。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class EX1_110t:MinionBase{
//NAME=贝恩·血蹄
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class EX1_112:MinionBase{
//NAME=格尔宾·梅卡托克
//TEXT=<b>战吼：</b>召唤一项惊人的发明。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=NONE
}
public class EX1_116:MinionBase{
//NAME=火车王里诺艾
//TEXT=<b>冲锋，战吼：</b> 为你的对手召唤两条1/1的雏龙。
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
public class EX1_116t:MinionBase{
//NAME=雏龙
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=DRAGON
}
public class EX1_124:SpellBase{
//NAME=刺骨
//TEXT=造成$2点伤害；<b>连击：</b>改为造成$4点伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_126:SpellBase{
//NAME=背叛
//TEXT=使一个敌方随从对其相邻的随从 造成等同于其攻击力的伤害。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_128:SpellBase{
//NAME=隐藏
//TEXT=直到你的下个回合，使所有友方随从获得<b>潜行</b>。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class EX1_128e:Ability{
//NAME=被隐藏
//TEXT=获得潜行直到你的下个回合。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_129:SpellBase{
//NAME=刀扇
//TEXT=对所有敌方随从造成$1点伤害，抽一张牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_130:SecretBase{
//NAME=崇高牺牲
//TEXT=<b>奥秘：</b>当一个敌人攻击时，召唤一个2/1的防御者，并使其成为攻击的目标。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class EX1_130a:MinionBase{
//NAME=防御者
//TEXT=
//MAJ=PALADIN|COST=1|ATK=2|HP=1|RACE=NONE
}
public class EX1_131:MinionBase{
//NAME=迪菲亚头目
//TEXT=<b>连击：</b>召唤一个2/1的迪菲亚强盗。
//MAJ=ROGUE|COST=2|ATK=2|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)>0)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("EX1_131t"),ZoneType.Board);
        }
    }
}
public class EX1_131t:MinionBase{
//NAME=迪菲亚强盗
//TEXT=
//MAJ=ROGUE|COST=1|ATK=2|HP=1|RACE=NONE
}
public class EX1_132:SecretBase{
//NAME=以眼还眼
//TEXT=<b>奥秘：</b> 当你的英雄受到伤害时，对敌方英雄造成等量伤害。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class EX1_133:WeaponBase{
//NAME=毁灭之刃
//TEXT=<b>战吼：</b>造成1点伤害。<b>连击：</b>改为造成2点伤害。
//MAJ=ROGUE|COST=3|ATK=2|HP=2|RACE=NONE
}
public class EX1_134:MinionBase{
//NAME=军情七处特工
//TEXT=<b>连击：</b>造成2点伤害。
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class EX1_136:SecretBase{
//NAME=救赎
//TEXT=<b>奥秘：</b>当一个友方随从死亡时，使其回到战场，并具有1点生命值。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class EX1_137:SpellBase{
//NAME=裂颅之击
//TEXT=对敌方英雄造成$2点伤害；<b>连击：</b>在下个回合将其移回你的手牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class EX1_144:SpellBase{
//NAME=暗影步
//TEXT=将一个友方随从移回你的手牌，它的法力值消耗减少 （2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        new EffectMove(owner.myPlayer,target,ZoneType.Board,ZoneType.Hand).Resolve();
        new EffectChange(owner.myPlayer,owner,target,manaChange:-2).Resolve();
    }
}
public class EX1_145:SpellBase{
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
public class EX1_145e:Ability{
//NAME=伺机待发
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_145o:Ability{
//NAME=伺机待发
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗减少（2）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_154:SpellBase{
//NAME=愤怒
//TEXT=<b>抉择：</b> 对一个随从造成$3点伤害；或者造成$1点伤害并抽一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        new EffectDraw(owner.myPlayer).Resolve();
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
    }
}
public class EX1_154a:SpellBase{
//NAME=阳炎之怒
//TEXT=对一个随从造成$3点伤害。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class EX1_154b:SpellBase{
//NAME=自然之怒
//TEXT=对一个随从造成$1点伤害，抽一张牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class EX1_155:SpellBase{
//NAME=自然印记
//TEXT=<b>抉择：</b> 使一个随从获得+4攻击力；或者+4生命值和<b>嘲讽</b>。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class EX1_155a:SpellBase{
//NAME=猛虎之怒
//TEXT=使一个随从获得+4攻击力。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class EX1_155ae:Ability{
//NAME=自然印记
//TEXT=本随从拥有+4攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_155b:SpellBase{
//NAME=皮糙肉厚
//TEXT=使一个随从获得+4生命值和 <b>嘲讽</b>。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class EX1_155be:Ability{
//NAME=自然印记
//TEXT=本随从拥有+4生命值和<b>嘲讽</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_158:SpellBase{
//NAME=丛林之魂
//TEXT=使你的所有随从获得“<b>亡语：</b>召唤一个2/2的树人”。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class EX1_158e:Ability{
//NAME=丛林之魂
//TEXT=<b>亡语：</b>召唤一个2/2的树人。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_158t:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class EX1_160:SpellBase{
//NAME=野性之力
//TEXT=<b>抉择：</b>使你的所有随从获得+1/+1；或者召唤一只3/2的 猎豹。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_160a:SpellBase{
//NAME=召唤猎豹
//TEXT=召唤一只3/2的猎豹。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_160b:SpellBase{
//NAME=兽群领袖
//TEXT=使你所有的随从获得+1/+1。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_160be:Ability{
//NAME=兽群领袖
//TEXT=+1/+1。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_160t:MinionBase{
//NAME=猎豹
//TEXT=
//MAJ=DRUID|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class EX1_161:SpellBase{
//NAME=自然平衡
//TEXT=消灭一个随从，你的对手抽两张牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
        TaskDraw(ToEn:true);
        TaskDraw(ToEn:true);
    }
}
public class EX1_162:MinionBase{
//NAME=恐狼前锋
//TEXT=相邻的随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class EX1_162_G:MinionBase{
//NAME=恐狼前锋
//TEXT=相邻的随从拥有+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class EX1_162o:Ability{
//NAME=狼群之力
//TEXT={0}使其获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_164:SpellBase{
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
public class EX1_164a:SpellBase{
//NAME=快速生长
//TEXT=获得两个法力水晶。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class EX1_164b:SpellBase{
//NAME=摄取养分
//TEXT=抽三张牌。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class EX1_165:MinionBase{
//NAME=利爪德鲁伊
//TEXT=<b>抉择：</b>变形成为7/6并具有<b>突袭</b>；或者变形成为4/9并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=6|ATK=4|HP=6|RACE=NONE
}
public class EX1_165a:MinionBase{
//NAME=猎豹形态
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=6|ATK=7|HP=6|RACE=BEAST
}
public class EX1_165b:MinionBase{
//NAME=熊形态
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=6|ATK=4|HP=9|RACE=BEAST
}
public class EX1_165t1:MinionBase{
//NAME=利爪德鲁伊
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=6|ATK=7|HP=6|RACE=BEAST
}
public class EX1_165t2:MinionBase{
//NAME=利爪德鲁伊
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=6|ATK=4|HP=9|RACE=BEAST
}
public class EX1_166:MinionBase{
//NAME=丛林守护者
//TEXT=<b>抉择：</b>造成2点伤害；或者<b>沉默</b>一个随从。
//MAJ=DRUID|COST=4|ATK=2|HP=4|RACE=NONE
}
public class EX1_166a:SpellBase{
//NAME=月火术
//TEXT=造成2点伤害。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class EX1_166b:SpellBase{
//NAME=禁魔
//TEXT=<b>沉默</b>一个随从。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class EX1_169:SpellBase{
//NAME=激活
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NATURE
}
public class EX1_170:MinionBase{
//NAME=帝王眼镜蛇
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=BEAST
}
public class EX1_173:SpellBase{
//NAME=星火术
//TEXT=造成$5点伤害。抽一张牌。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=ARCANE
}
public class EX1_178:MinionBase{
//NAME=战争古树
//TEXT=<b>抉择：</b> +5攻击力；或者+5生命值并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=7|ATK=5|HP=5|RACE=NONE
}
public class EX1_178a:SpellBase{
//NAME=扎根
//TEXT=+5生命值并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NONE
}
public class EX1_178ae:Ability{
//NAME=扎根
//TEXT=+5生命值并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_178b:SpellBase{
//NAME=拔根
//TEXT=+5攻击力。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NONE
}
public class EX1_178be:Ability{
//NAME=拔根
//TEXT=+5攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_179:SpellBase{
//NAME=冰刺
//TEXT=对一个随从造成$2点伤害。如果它已被<b>冻结</b>，抽一张牌。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FROST
}
public class EX1_180:SpellBase{
//NAME=智慧秘典
//TEXT=随机将一张法师法术牌置入你的手牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class EX1_181:SpellBase{
//NAME=虚空召唤
//TEXT=随机将一张恶魔牌置入你的 手牌。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class EX1_182:SpellBase{
//NAME=窃取
//TEXT=随机将一张另一职业的卡牌置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class EX1_183:SpellBase{
//NAME=野性赐福
//TEXT=使你的所有随从获得+2/+2和 <b>嘲讽</b>。
//MAJ=DRUID|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class EX1_183e:Ability{
//NAME=野性赐福
//TEXT=+2/+2并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_184:SpellBase{
//NAME=正义
//TEXT=使你的所有随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class EX1_185:MinionBase{
//NAME=攻城恶魔
//TEXT=<b>嘲讽</b> 你的其他恶魔拥有+1攻击力。
//MAJ=WARLOCK|COST=7|ATK=5|HP=8|RACE=DEMON
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
        return (c.raceType.Contains(RaceType.Demon) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "EX1_185e";
    }    
}
public class EX1_185e:Ability{
//NAME=攻城略地
//TEXT=攻城恶魔使本随从获得+1攻击力。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 1;
        }
        return 0;
    }
}
public class EX1_185_G:MinionBase{
//NAME=攻城恶魔
//TEXT=<b>嘲讽</b> 你的其他恶魔拥有+1攻击力。
//MAJ=WARLOCK|COST=7|ATK=5|HP=8|RACE=DEMON
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
    }
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Demon) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "EX1_185e_G";
    }    
}
public class EX1_185e_G:Ability{
//NAME=攻城略地
//TEXT=攻城恶魔使本随从获得+1攻击力。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 2;
        }
        return 0;
    }
}
public class EX1_186:MinionBase{
//NAME=军情七处渗透者
//TEXT=<b>战吼：</b>随机摧毁一个敌方<b>奥秘</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=NONE
}
public class EX1_187:MinionBase{
//NAME=奥术吞噬者
//TEXT=每当你施放一个法术，便获得+2/+2。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=8|RACE=ELEMENTAL
}
public class EX1_187e:Ability{
//NAME=奥术吞噬
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_188:MinionBase{
//NAME=贫瘠之地饲养员
//TEXT=<b>战吼：</b>随机召唤一只野兽。
//MAJ=NEUTRAL|COST=7|ATK=5|HP=5|RACE=NONE
}
public class EX1_189:MinionBase{
//NAME=光明之翼
//TEXT=<b>战吼：</b>随机将一张<b>传说</b>随从牌置入你的 手牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=DRAGON
}
public class EX1_190:MinionBase{
//NAME=大检察官怀特迈恩
//TEXT=<b>战吼：</b>召唤所有在本回合中死亡的友方 随从。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=7|RACE=NONE
}
public class EX1_191:MinionBase{
//NAME=瘟疫使者
//TEXT=<b>战吼：</b>使一个友方随从获得<b>剧毒</b>。
//MAJ=ROGUE|COST=4|ATK=3|HP=3|RACE=UNDEAD
}
public class EX1_191e:Ability{
//NAME=瘟疫感染
//TEXT=<b>剧毒</b>
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_192:SpellBase{
//NAME=圣光闪耀
//TEXT=为你的英雄恢复#5点生命值。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        new EffectHeal(owner.myPlayer,owner,owner.myPlayer.hero[0],5).Resolve();
    }
}
public class EX1_193:MinionBase{
//NAME=心灵咒术师
//TEXT=<b>战吼：</b>复制你对手的牌库中的一张牌，并将其置入你的手牌。
//MAJ=PRIEST|COST=1|ATK=1|HP=2|RACE=UNDEAD
}
public class EX1_194:SpellBase{
//NAME=能量灌注
//TEXT=使一个随从获得+2/+6。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class EX1_194e:Ability{
//NAME=能量灌注
//TEXT=+2/+6。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_195:MinionBase{
//NAME=库尔提拉斯教士
//TEXT=<b>战吼：</b>使一个友方随从获得+2生命值。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=NONE
}
public class EX1_195e:Ability{
//NAME=接受援助
//TEXT=+2生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_196:MinionBase{
//NAME=血色征服者
//TEXT=<b>战吼：</b>直到你的下个回合，使一个敌方随从获得-2攻击力。
//MAJ=PRIEST|COST=1|ATK=2|HP=1|RACE=NONE
}
public class EX1_196e:Ability{
//NAME=屈从
//TEXT=直到你的下个回合，获得-2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_197:SpellBase{
//NAME=暗言术：毁
//TEXT=消灭所有攻击力大于或等于5的随从。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class EX1_198:MinionBase{
//NAME=娜塔莉·塞林
//TEXT=<b>战吼：</b>消灭一个随从并获得其生命值。
//MAJ=PRIEST|COST=8|ATK=8|HP=1|RACE=NONE
}
public class EX1_198e:Ability{
//NAME=遗忘之影
//TEXT=生命值提高。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_238:SpellBase{
//NAME=闪电箭
//TEXT=造成$3点伤害，<b>过载：</b>（1）
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
    }
}
public class EX1_241:SpellBase{
//NAME=熔岩爆裂
//TEXT=造成$5点伤害，<b>过载：</b>（2）
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class EX1_243:MinionBase{
//NAME=尘魔
//TEXT=<b>风怒</b>，<b>过载：</b>（2）
//MAJ=SHAMAN|COST=1|ATK=3|HP=1|RACE=ELEMENTAL
    public override void Init()
    {
        TaskInitAbility("WindFury");
    }
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,2);
    }
}
public class EX1_244:SpellBase{
//NAME=图腾之力
//TEXT=使你的图腾获得+2生命值。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_244e:Ability{
//NAME=图腾之力
//TEXT=+2生命值。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_245:SpellBase{
//NAME=大地震击
//TEXT=<b>沉默</b>一个随从，然后对其造成$1点伤害。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class EX1_246:SpellBase{
//NAME=妖术
//TEXT=使一个随从变形成为一只0/1并具有<b>嘲讽</b>的青蛙。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class EX1_246e:Ability{
//NAME=妖术变形
//TEXT=本随从被变形了！
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_247:WeaponBase{
//NAME=雷铸战斧
//TEXT=<b>过载：</b>（1）
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=NONE
}
public class EX1_248:SpellBase{
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
public class EX1_249:MinionBase{
//NAME=迦顿男爵
//TEXT=在你的回合结束时，对所有其他角色造成2点伤害。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=ELEMENTAL
}
public class EX1_250:MinionBase{
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
public class EX1_251:SpellBase{
//NAME=叉状闪电
//TEXT=随机对两个敌方随从造成$2点伤害，<b>过载：</b>（2）
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.board)
        {
            Pool.Add(c);
        }
        List<Card> ToListDamage = new List<Card>();
        while(true)
        {
            if(ToListDamage.Count==2 || Pool.Count==0)
            {
                break;
            }
            Card ToDamage = Pool.Choice(owner.myPlayer.randomGen);
            if(ToDamage!=null)
            {
                ToListDamage.Add(ToDamage);
            }
        }
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,2);
        TaskDamageTargets(ToListDamage,2);
    }
}
public class EX1_258:MinionBase{
//NAME=无羁元素
//TEXT=在你使用一张具有<b>过载</b>的牌后，便获得+1/+1。
//MAJ=SHAMAN|COST=3|ATK=3|HP=4|RACE=ELEMENTAL
}
public class EX1_258e:Ability{
//NAME=过载
//TEXT=属性值提高。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_259:SpellBase{
//NAME=闪电风暴
//TEXT=对所有敌方随从造成$3点伤害，<b>过载：</b>（1）
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,3);
    }
}
public class EX1_274:MinionBase{
//NAME=虚灵奥术师
//TEXT=在你的回合结束时，如果你控制着<b>奥秘</b>，获得+2/+2。
//MAJ=MAGE|COST=4|ATK=3|HP=3|RACE=NONE
}
public class EX1_274e:Ability{
//NAME=原始的能量！
//TEXT=属性值提高。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_275:SpellBase{
//NAME=冰锥术
//TEXT=<b>冻结</b>一个随从和其相邻的随从，并对它们造成$1点伤害。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class EX1_277:SpellBase{
//NAME=奥术飞弹
//TEXT=造成$3点伤害，随机分配到所有敌人身上。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
    public override void Battlecry(Card target=null)
    {
        TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),3);
    }
}
public class EX1_278:SpellBase{
//NAME=毒刃
//TEXT=造成$1点伤害，抽一张牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_279:SpellBase{
//NAME=炎爆术
//TEXT=造成$10点伤害。
//MAJ=MAGE|COST=10|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,10).Resolve();
    }
}
public class EX1_283:MinionBase{
//NAME=冰霜元素
//TEXT=<b>战吼：</b> <b>冻结</b>一个角色。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=ELEMENTAL
}
public class EX1_284:MinionBase{
//NAME=碧蓝幼龙
//TEXT=<b>法术伤害+1</b>，<b>战吼：</b>抽一张牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=DRAGON
}
public class EX1_287:SecretBase{
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
public class EX1_289:SecretBase{
//NAME=寒冰护体
//TEXT=<b>奥秘：</b>当你的英雄受到攻击时，获得8点护甲值。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class EX1_294:SecretBase{
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
public class EX1_295:SecretBase{
//NAME=寒冰屏障
//TEXT=<b>奥秘：</b>当你的英雄将要承受致命伤害时，防止这些伤害，并使其在本回合中<b>免疫</b>。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTakeDamage(this,EX1_132CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void EX1_132CauseEvent(Card source, Card target, int amount)
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Head)
        {
            if (amount >= owner.myPlayer.hero[0].GetTag(GameTag.Health))
            {
                new EffectMove(owner.myPlayer, owner, ZoneType.Head, ZoneType.Grave).Resolve();
                new EffectGiveAbility(owner.myPlayer, owner, owner.myPlayer.hero[0], "ImmueForOneTurn").Resolve();
            }
        }
    }
}
public class EX1_295o:Ability{
//NAME=寒冰屏障
//TEXT=在本回合中，你的英雄<b>免疫</b>。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_298:MinionBase{
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
public class EX1_301:MinionBase{
//NAME=恶魔卫士
//TEXT=<b>嘲讽，战吼：</b>摧毁你的一个法力水晶。
//MAJ=WARLOCK|COST=3|ATK=3|HP=5|RACE=DEMON
}
public class EX1_302:SpellBase{
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
public class EX1_303:SpellBase{
//NAME=暗影烈焰
//TEXT=消灭一个友方随从，对所有敌方随从造成等同于其攻击力的伤害。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target =null)
    {
        int Num = target.GetTag(GameTag.Attack);
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,Num);
    }
}
public class EX1_304:MinionBase{
//NAME=虚空恐魔
//TEXT=<b>战吼：</b>消灭两侧相邻的随从，并获得他们的攻击力和生命值。
//MAJ=WARLOCK|COST=3|ATK=3|HP=4|RACE=DEMON
}
public class EX1_304e:Ability{
//NAME=吞噬
//TEXT=属性值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_306:MinionBase{
//NAME=魔犬
//TEXT=<b>战吼：</b> 随机弃一张牌。
//MAJ=WARLOCK|COST=2|ATK=4|HP=3|RACE=DEMON
}
public class EX1_308:SpellBase{
//NAME=灵魂之火
//TEXT=造成$4点伤害，随机弃一 张牌。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,4).Resolve();
        TaskRandomDiscard();
    }
}
public class EX1_309:SpellBase{
//NAME=灵魂虹吸
//TEXT=消灭一个随从，为你的英雄恢复#3点生命值。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class EX1_310:MinionBase{
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
public class EX1_312:SpellBase{
//NAME=扭曲虚空
//TEXT=消灭所有随从和地标。
//MAJ=WARLOCK|COST=8|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        TaskDestroyTargets(FindAllMin());
    }
}
public class EX1_313:MinionBase{
//NAME=深渊领主
//TEXT=<b>战吼：</b>对你的英雄造成5点伤害。
//MAJ=WARLOCK|COST=4|ATK=5|HP=6|RACE=DEMON
}
public class EX1_315:MinionBase{
//NAME=召唤传送门
//TEXT=你的随从牌的法力值消耗减少（2）点，但不能少于（1）点。
//MAJ=WARLOCK|COST=4|ATK=0|HP=4|RACE=NONE
}
public class EX1_315e:Ability{
//NAME=召唤传送门
//TEXT=法力值消耗减少（2）点，但不能少于（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_316:SpellBase{
//NAME=力量的代价
//TEXT=使一个友方随从获得+4/+4，该随从会在回合结束时死亡。死得很惨。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class EX1_316e:Ability{
//NAME=力量的代价
//TEXT=本随从拥有+4/+4，但会在回合结束时惨死。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_317:SpellBase{
//NAME=感知恶魔
//TEXT=从你的牌库中抽两张恶魔牌。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        Card Drawn = TaskDrawRace(RaceType.Demon);
        if(Drawn==null)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("EX1_317t"),ZoneType.Hand);
        }
        Card Drawn2 = TaskDrawRace(RaceType.Demon);
        if(Drawn2==null)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("EX1_317t"),ZoneType.Hand);
        }
    }
}
public class EX1_317t:MinionBase{
//NAME=游荡小鬼
//TEXT=<i>你的恶魔用完了！但至少...还有小鬼。</i>
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class EX1_319:MinionBase{
//NAME=烈焰小鬼
//TEXT=<b>战吼：</b>对你的英雄造成3点伤害。
//MAJ=WARLOCK|COST=1|ATK=3|HP=2|RACE=DEMON
    public override void Battlecry(Card target=null)
    {
        TaskDamageMyHero(3);
    }
}
public class EX1_320:SpellBase{
//NAME=末日灾祸
//TEXT=对一个角色造成$3点伤害。如果“末日灾祸”消灭该角色，随机召唤一个恶魔。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class EX1_323:HeroBase{
//NAME=加拉克苏斯大王
//TEXT=<b>战吼：</b>装备一把3/8的血怒。
//MAJ=WARLOCK|COST=8|ATK=0|HP=30|RACE=NONE
}
public class EX1_323h:HeroBase{
//NAME=加拉克苏斯大王
//TEXT=
//MAJ=WARLOCK|COST=0|ATK=0|HP=15|RACE=DEMON
}
public class EX1_323w:WeaponBase{
//NAME=血怒
//TEXT=
//MAJ=WARLOCK|COST=3|ATK=3|HP=8|RACE=NONE
}
public class EX1_332:SpellBase{
//NAME=沉默
//TEXT=<b>沉默</b>一个随从。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class EX1_334:SpellBase{
//NAME=暗影狂乱
//TEXT=直到回合结束，获得一个攻击力小于或等于3的敌方随从的控制权。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class EX1_334e:Ability{
//NAME=暗影狂乱
//TEXT=在本回合中，本随从的控制权发生了变化。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_335:MinionBase{
//NAME=光耀之子
//TEXT=本随从的攻击力始终等同于其生命值。
//MAJ=PRIEST|COST=3|ATK=0|HP=4|RACE=ELEMENTAL
}
public class EX1_3350e:Ability{
//NAME=照耀
//TEXT=+2生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_3354e:Ability{
//NAME=圣光的祝福
//TEXT=+3攻击力。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_339:SpellBase{
//NAME=思维窃取
//TEXT=复制你对手的牌库中的两张牌，并将其置入你的手牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        for(int i=0;i<2;i++)
        {
            Card ToCopy = owner.myPlayer.otherPlayer.deck.Choice(owner.myPlayer.randomGen);
            if(ToCopy!=null)
                TaskCreate(ToCopy.cardDbf,ZoneType.Hand);
        }
    }
}
public class EX1_341:MinionBase{
//NAME=光明之泉
//TEXT=在你的回合开始时，随机为一个受伤的 友方角色恢复#3点生命值。
//MAJ=PRIEST|COST=2|ATK=0|HP=5|RACE=NONE
}
public class EX1_345:SpellBase{
//NAME=控心术
//TEXT=随机将你对手的牌库中的一张随从牌的复制置入战场。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class EX1_345t:MinionBase{
//NAME=空无之影
//TEXT=控心术无效！你对手的牌库中没有 随从牌了！
//MAJ=PRIEST|COST=0|ATK=0|HP=1|RACE=NONE
}
public class EX1_349:SpellBase{
//NAME=神恩术
//TEXT=抽若干数量的牌，直到你的手牌数量等同于你对手的手牌数量。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        while(true)
        {
            if(owner.myPlayer.deck.Count==0)
            {
                break;
            }
            if(owner.myPlayer.hand.Count>=owner.myPlayer.otherPlayer.hand.Count)
            {
                break;
            }
            TaskDraw();
        }
    }
}
public class EX1_350:MinionBase{
//NAME=先知维伦
//TEXT=使你的法术和英雄技能的伤害和治疗效果翻倍。
//MAJ=PRIEST|COST=7|ATK=7|HP=7|RACE=NONE
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return ((c.cardType==CardType.Spell||c.cardType==CardType.HeroPower) && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "VAN_EX1_350e";
    }
}
public class EX1_354:SpellBase{
//NAME=圣疗术
//TEXT=恢复#8点生命值，抽三张牌。
//MAJ=PALADIN|COST=6|ATK=0|HP=0|RACE=HOLY
}
public class EX1_355:SpellBase{
//NAME=受祝福的勇士
//TEXT=使一个随从的攻击力翻倍。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=HOLY
}
public class EX1_355e:Ability{
//NAME=受祝福的勇士
//TEXT=本随从的攻击力翻倍。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_360:SpellBase{
//NAME=谦逊
//TEXT=使一个随从的攻击力变为1。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class EX1_360e:Ability{
//NAME=谦逊
//TEXT=攻击力变为1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_362:MinionBase{
//NAME=银色保卫者
//TEXT=<b>战吼：</b>使一个其他友方随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=2|ATK=3|HP=2|RACE=NONE
}
public class EX1_363:SpellBase{
//NAME=智慧祝福
//TEXT=选择一个随从，每当其进行攻击，便抽一张牌。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class EX1_363e:Ability{
//NAME=智慧祝福
//TEXT=当本随从攻击时，对其施放祝福的玩家抽一张牌。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_363e2:Ability{
//NAME=智慧祝福
//TEXT=当本随从攻击时，敌方玩家抽一张牌。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_365:SpellBase{
//NAME=神圣愤怒
//TEXT=抽一张牌，并造成等同于其法力值消耗的伤害。
//MAJ=PALADIN|COST=5|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        Card c = TaskDraw();
        new EffectDamage(owner.myPlayer,owner,target,c.GetTag(GameTag.Mana)).Resolve();
    }
}
public class EX1_366:WeaponBase{
//NAME=公正之剑
//TEXT=在你召唤一个随从后，使其获得+1/+1，这把武器失去1点耐久度。
//MAJ=PALADIN|COST=3|ATK=1|HP=5|RACE=NONE
}
public class EX1_366e:Ability{
//NAME=伸张正义
//TEXT=拥有+1/+1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_371:SpellBase{
//NAME=保护之手
//TEXT=使一个随从获得<b>圣盾</b>。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class EX1_379:SecretBase{
//NAME=忏悔
//TEXT=<b>奥秘：</b> 在你的对手使用一张随从牌后，使该随从的生命值降为1。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class EX1_379e:Ability{
//NAME=忏悔
//TEXT=生命值降为1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_382:MinionBase{
//NAME=奥尔多卫士
//TEXT=<b>战吼：</b>使一个敌方随从的攻击力变为1。
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,atkChange:1-target.GetTag(GameTag.Attack)).Resolve();
    }
}
public class EX1_382e:Ability{
//NAME=老实点！
//TEXT=攻击力变为1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_383:MinionBase{
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
public class EX1_383t:WeaponBase{
//NAME=灰烬使者
//TEXT=
//MAJ=PALADIN|COST=5|ATK=5|HP=3|RACE=NONE
}
public class EX1_384:SpellBase{
//NAME=复仇之怒
//TEXT=造成$8点伤害，随机分配到所有敌人身上。
//MAJ=PALADIN|COST=6|ATK=0|HP=0|RACE=HOLY
}
public class EX1_390:MinionBase{
//NAME=牛头人战士
//TEXT=<b>嘲讽</b> 受伤时拥有+3攻 击力。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class EX1_390e:Ability{
//NAME=激怒
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_391:SpellBase{
//NAME=猛击
//TEXT=对一个随从造成$2点伤害，如果 它依然存活，则抽一张牌。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class EX1_392:SpellBase{
//NAME=战斗怒火
//TEXT=每有一个受伤的友方角色，便抽一张牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int DamageCnt=0;
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.hero))
        {
            if(c.GetTag(GameTag.Damage)>0)
            {
                DamageCnt+=1;
            }
        }
        for(int i =0;i<DamageCnt;i++)
        {
            TaskDraw();
        }
    }
}
public class EX1_393:MinionBase{
//NAME=阿曼尼狂战士
//TEXT=受伤时拥有+3攻 击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class EX1_393e:Ability{
//NAME=激怒
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_396:MinionBase{
//NAME=魔古山守望者
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=1|HP=7|RACE=NONE
}
public class EX1_398:MinionBase{
//NAME=阿拉希武器匠
//TEXT=<b>战吼：</b>装备一把2/2的武器。
//MAJ=WARRIOR|COST=4|ATK=3|HP=3|RACE=NONE
}
public class EX1_398t:WeaponBase{
//NAME=战斧
//TEXT=
//MAJ=WARRIOR|COST=1|ATK=2|HP=2|RACE=NONE
}
public class EX1_399:MinionBase{
//NAME=古拉巴什狂暴者
//TEXT=每当本随从受到伤害，获得+3攻击力。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=8|RACE=NONE
}
public class EX1_399e:Ability{
//NAME=狂怒
//TEXT=本随从的攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_400:SpellBase{
//NAME=旋风斩
//TEXT=对所有随从造成$1点伤害。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
    }
}
public class EX1_402:MinionBase{
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
public class EX1_405:MinionBase{
//NAME=持盾卫士
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=4|RACE=NONE
}
public class EX1_407:SpellBase{
//NAME=绝命乱斗
//TEXT=随机选择一个随从，消灭除了该随从外的所有其他随从。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=NONE
}
public class EX1_408:SpellBase{
//NAME=致死打击
//TEXT=造成$4点伤害；如果你的生命值小于或等于12点，则改为造成$6点伤害。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=NONE
}
public class EX1_409:SpellBase{
//NAME=升级
//TEXT=如果你装备着武器，使其获得+1/+1。否则装备一把1/3的武器。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target = null)
    {
        base.Battlecry(target);
        if (owner.myPlayer.weapon.Count == 0)
        {
            new EffectCreate(owner.myPlayer,new Card(CardDbf.GetCardDbfByGuid("EX1_409t"), owner.myPlayer), ZoneType.Weapon).Resolve();
            //new EffectChange(owner.myPlayer,owner, owner.myPlayer.hero[0], atkChange: 1).Resolve();
        }
        else
        {
            new EffectChange(owner.myPlayer,owner, owner.myPlayer.weapon[0], atkChange: 1, hpChange: 1).Resolve();
            new EffectChange(owner.myPlayer,owner, owner.myPlayer.hero[0], atkChange: 1).Resolve();
        }
    }
}
public class EX1_409e:Ability{
//NAME=升级
//TEXT=+1攻击力和+1耐久度。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_409t:WeaponBase{
//NAME=重斧
//TEXT=
//MAJ=WARRIOR|COST=1|ATK=1|HP=3|RACE=NONE
}
public class EX1_410:SpellBase{
//NAME=盾牌猛击
//TEXT=你每有1点护甲值，便对一个随从造成1点伤害。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class EX1_411:WeaponBase{
//NAME=血吼
//TEXT=攻击随从不会消耗耐久度，改为降低1点攻击力。
//MAJ=WARRIOR|COST=7|ATK=7|HP=1|RACE=NONE
}
public class EX1_411e:Ability{
//NAME=血性狂暴
//TEXT=不会消耗耐久度。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_411e2:Ability{
//NAME=需要打磨
//TEXT=攻击力降低。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_412:MinionBase{
//NAME=暴怒的狼人
//TEXT=受伤时拥有+1攻击力和<b>风怒</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
    public override void Init()
    {
        //this.m_powers = new List<string>(){"CS2_093","CS2_029","VAN_CS2_024"};
        //owner.SetTag(GameTag.AttacksForOneTurn,2);
        //owner.SetTag(GameTag.AttacksLeftThisTurn,2);//TaskInitAbility("WindFury");
    }
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            if(owner.GetTag(GameTag.Damage)>0)
            {
                return 1;
            }
        }
        return 0;
    }
}
public class EX1_412e:Ability{
//NAME=激怒
//TEXT=+1攻击力并获得<b>风怒</b>.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_414:MinionBase{
//NAME=格罗玛什·地狱咆哮
//TEXT=<b>冲锋</b> 受伤时拥有+6攻 击力。
//MAJ=WARRIOR|COST=8|ATK=4|HP=9|RACE=NONE
}
public class EX1_414e:Ability{
//NAME=激怒
//TEXT=+6攻击力
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_506:MinionBase{
//NAME=鱼人猎潮者
//TEXT=<b>战吼：</b>召唤一个1/1的鱼人斥候。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=MURLOC
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("EX1_506a"),ZoneType.Board);
    }
}
public class EX1_506_G:MinionBase{
//NAME=鱼人猎潮者
//TEXT=<b>战吼：</b>召唤一个1/1的鱼人斥候。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=MURLOC
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("EX1_506a"),ZoneType.Board);
        TaskCreate(CardDbf.GetCardDbfByGuid("EX1_506a"),ZoneType.Board);
    }
}
public class EX1_506a:MinionBase{
//NAME=鱼人斥候
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class EX1_506a_G:MinionBase{
//NAME=鱼人斥候
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class EX1_507:MinionBase{
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
public class EX1_507e:Ability{
//NAME=姆若咯啦啊咯啦！
//TEXT=鱼人领军使其获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 2;
        }
        return 0;
    }
}
public class EX1_507e_G:Ability{
//NAME=姆若咯啦啊咯啦！
//TEXT=鱼人领军使其获得+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 4;
        }
        return 0;
    }
}
public class EX1_508:MinionBase{
//NAME=暗鳞先知
//TEXT=你的其他鱼人拥有+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
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
        return "EX1_508o";
    }
}
public class EX1_508o:Ability{
//NAME=姆啦咯咯若啦咯啦啦哔！
//TEXT=该鱼人拥有+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod)
        {
            return 1;
        }
        return 0;
    }
}
public class EX1_509:MinionBase{
//NAME=鱼人招潮者
//TEXT=每当你召唤一个鱼人，便获得 +1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=MURLOC
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay() && tz==ZoneType.Board)
        {
            if(sc.myPlayer==owner.myPlayer && sc.raceType.Contains(RaceType.Murloc) || sc.raceType.Contains(RaceType.All))
            {
                new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
            }
        }
    }
}
public class EX1_509_G:MinionBase{
//NAME=鱼人招潮者
//TEXT=每当你召唤一个鱼人，便获得 +1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=MURLOC
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay() && tz==ZoneType.Board)
        {
            if(sc.myPlayer==owner.myPlayer && sc.raceType.Contains(RaceType.Murloc) || sc.raceType.Contains(RaceType.All))
            {
                new EffectChange(owner.myPlayer,owner,owner,atkChange:2).Resolve();
            }
        }
    }
}
public class EX1_509e:Ability{
//NAME=吧啦咯咯啦！
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_522:MinionBase{
//NAME=耐心的刺客
//TEXT=<b>潜行</b> <b>剧毒</b>
//MAJ=ROGUE|COST=2|ATK=1|HP=2|RACE=NONE
}
public class EX1_531:MinionBase{
//NAME=食腐土狼
//TEXT=每当一个友方野兽死亡，便获得+2/+1。
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class EX1_531e:Ability{
//NAME=进食充分
//TEXT=攻击力和生命值提高。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_533:SecretBase{
//NAME=误导
//TEXT=<b>奥秘：</b>当一个敌人攻击你的英雄时，改为该敌人随机攻击另一个角色。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_534:MinionBase{
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
public class EX1_534t:MinionBase{
//NAME=土狼
//TEXT=
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class EX1_536:WeaponBase{
//NAME=鹰角弓
//TEXT=每当一个友方<b>奥秘</b>被揭示时，便获得+1耐久度。
//MAJ=HUNTER|COST=3|ATK=3|HP=2|RACE=NONE
}
public class EX1_536e:Ability{
//NAME=升级
//TEXT=耐久度提高。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_537:SpellBase{
//NAME=爆炸射击
//TEXT=对一个随从造成$5点伤害，并对其相邻的随从造成 $2点伤害。
//MAJ=HUNTER|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class EX1_538:SpellBase{
//NAME=关门放狗
//TEXT=战场上每有一个敌方随从，便召唤一个 1/1并具有<b>冲锋</b>的猎犬。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int Num=owner.myPlayer.otherPlayer.board.Count;
        for(int i=0;i<Num;i++)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("EX1_538t"),ZoneType.Board);
        }
    }
}
public class EX1_538t:MinionBase{
//NAME=猎犬
//TEXT=<b>冲锋</b>
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class EX1_539:SpellBase{
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
public class EX1_543:MinionBase{
//NAME=暴龙王克鲁什
//TEXT=<b>冲锋</b>
//MAJ=HUNTER|COST=9|ATK=8|HP=8|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class EX1_544:SpellBase{
//NAME=照明弹
//TEXT=所有随从失去<b>潜行</b>，摧毁所有敌方<b>奥秘</b>，抽一张牌。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDestroyTargets(owner.myPlayer.otherPlayer.head);
        TaskDraw();
    }
}
public class EX1_549:SpellBase{
//NAME=狂野怒火
//TEXT=在本回合中，使一只友方野兽获得+2攻击力和<b>免疫</b>。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class EX1_549o:Ability{
//NAME=狂野怒火
//TEXT=在本回合中，+2攻击力和<b>免疫</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_554:SecretBase{
//NAME=毒蛇陷阱
//TEXT=<b>奥秘：</b>当你的随从受到攻击时，召唤三条1/1的蛇。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_554t:MinionBase{
//NAME=蛇
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class EX1_556:MinionBase{
//NAME=麦田傀儡
//TEXT=<b>亡语：</b>召唤一个2/1的损坏的傀儡。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=MECHANICAL
}
public class EX1_557:MinionBase{
//NAME=纳特·帕格
//TEXT=在你的回合开始时，你有50%的几率额外抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=4|RACE=NONE
}
public class EX1_558:MinionBase{
//NAME=哈里森·琼斯
//TEXT=<b>战吼：</b>摧毁对手的武器，并抽数量等同于其耐久度的牌。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NONE
}
public class EX1_559:MinionBase{
//NAME=大法师安东尼达斯
//TEXT=每当你施放一个法术，将一张“火球术”法术牌置入你的手牌。
//MAJ=MAGE|COST=7|ATK=5|HP=7|RACE=NONE
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
                TaskBuffMyHero();
                //new EffectEmote(owner.myPlayer,owner,"啊哈~").Resolve();
                TaskCreate(CardDbf.GetCardDbfByGuid("CORE_CS2_029"),ZoneType.Hand);
            }
        }
    }
}
public class EX1_560:MinionBase{
//NAME=诺兹多姆
//TEXT=玩家只有15秒的时间来进行他们的回合。
//MAJ=NEUTRAL|COST=9|ATK=8|HP=8|RACE=DRAGON
}
public class EX1_561:MinionBase{
//NAME=阿莱克丝塔萨
//TEXT=<b>战吼：</b> 将一方英雄的剩余生命值变为15。
//MAJ=NEUTRAL|COST=9|ATK=8|HP=8|RACE=DRAGON
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,hpChange:15-target.GetTag(GameTag.Health)).Resolve();
    }
}
public class EX1_561e:Ability{
//NAME=阿莱克丝塔萨之火
//TEXT=生命值变为15。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_561e1:Ability{
//NAME=阿莱克丝塔萨之力
//TEXT=生命值变为15
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_562:MinionBase{
//NAME=奥妮克希亚
//TEXT=<b>战吼：</b>召唤数条1/1的雏龙，直到你的随从数量达到上限。
//MAJ=NEUTRAL|COST=9|ATK=8|HP=8|RACE=DRAGON
}
public class EX1_563:MinionBase{
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
public class EX1_563e:SpellBase{
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.SpellDamageMod)
        {
            return 5;
        }
        return 0;
    }
}
public class EX1_564:MinionBase{
//NAME=无面操纵者
//TEXT=<b>战吼：</b>选择一个随从，成为它的复制。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class EX1_565:MinionBase{
//NAME=火舌图腾
//TEXT=相邻的随从拥有+2攻击力。
//MAJ=SHAMAN|COST=2|ATK=0|HP=3|RACE=TOTEM
}
public class EX1_565o:Ability{
//NAME=火舌
//TEXT=火舌图腾使其获得+2攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_567:WeaponBase{
//NAME=毁灭之锤
//TEXT=<b>风怒，过载：</b>（2）
//MAJ=SHAMAN|COST=5|ATK=2|HP=8|RACE=NONE
}
public class EX1_570:SpellBase{
//NAME=撕咬
//TEXT=使你的英雄获得4点护甲值，并在本回合中获得 +4攻击力。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
}
public class EX1_570e:Ability{
//NAME=撕咬
//TEXT=在本回合中+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_571:SpellBase{
//NAME=自然之力
//TEXT=召唤三个2/2的树人。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class EX1_572:MinionBase{
//NAME=伊瑟拉
//TEXT=在你的回合结束时，随机获取两张梦境牌。
//MAJ=NEUTRAL|COST=9|ATK=4|HP=12|RACE=DRAGON
}
public class EX1_573:MinionBase{
//NAME=塞纳留斯
//TEXT=<b>抉择：</b>使你的所有其他随从获得+2/+2；或者召唤两个2/2并具有<b>嘲讽</b>的树人。
//MAJ=DRUID|COST=8|ATK=5|HP=8|RACE=NONE
}
public class EX1_573a:SpellBase{
//NAME=半神的恩赐
//TEXT=使你的所有其他随从获得+2/+2。
//MAJ=DRUID|COST=8|ATK=0|HP=0|RACE=NONE
}
public class EX1_573ae:Ability{
//NAME=半神的恩赐
//TEXT=+2/+2。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_573b:SpellBase{
//NAME=恩师的教诲
//TEXT=召唤两个2/2并具有<b>嘲讽</b>的树人。
//MAJ=DRUID|COST=8|ATK=0|HP=0|RACE=NONE
}
public class EX1_573t:MinionBase{
//NAME=树人
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class EX1_575:MinionBase{
//NAME=法力之潮图腾
//TEXT=在你的回合结束时，抽一张牌。
//MAJ=SHAMAN|COST=3|ATK=0|HP=3|RACE=TOTEM
}
public class EX1_577:MinionBase{
//NAME=比斯巨兽
//TEXT=<b>亡语：</b> 为你的对手召唤一个3/3的皮普·急智。
//MAJ=NEUTRAL|COST=6|ATK=9|HP=7|RACE=BEAST
    public override void Deathrattle()
    {
        new EffectCreate(owner.myPlayer.otherPlayer,new Card(CardDbf.GetCardDbfByGuid("EX1_finkle"),owner.myPlayer.otherPlayer),ZoneType.Board).Resolve();
    }
}
public class EX1_577_G:MinionBase{
//NAME=比斯巨兽
//TEXT=<b>亡语：</b> 为你的对手召唤一个3/3的皮普·急智。
//MAJ=NEUTRAL|COST=6|ATK=9|HP=7|RACE=BEAST
    public override void Deathrattle()
    {
        new EffectCreate(owner.myPlayer.otherPlayer,new Card(CardDbf.GetCardDbfByGuid("EX1_finkle"),owner.myPlayer.otherPlayer),ZoneType.Board).Resolve();
    }
}
public class EX1_578:SpellBase{
//NAME=野蛮之击
//TEXT=对一个随从造成等同于你的英雄攻击力的伤害。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class EX1_581:SpellBase{
//NAME=闷棍
//TEXT=将一个敌方随从移回你对手的 手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_582:MinionBase{
//NAME=达拉然法师
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=NONE
}
public class EX1_583:MinionBase{
//NAME=艾露恩的女祭司
//TEXT=<b>战吼：</b>为你的英雄恢复#4点生命值。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=4|RACE=NONE
}
public class EX1_584:MinionBase{
//NAME=年迈的法师
//TEXT=<b>战吼：</b>使相邻的随从获得<b>法术伤害+1</b>。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=NONE
}
public class EX1_584e:Ability{
//NAME=肯瑞托的教诲
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_586:MinionBase{
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
public class EX1_587:MinionBase{
//NAME=风语者
//TEXT=<b>战吼：</b>使一个友方随从获得<b>风怒</b>。
//MAJ=SHAMAN|COST=4|ATK=3|HP=3|RACE=NONE
}
public class EX1_590:MinionBase{
//NAME=血骑士
//TEXT=<b>战吼：</b>所有随从失去<b>圣盾</b>。每有一个随从失去圣盾，便获得+3/+3。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class EX1_590e:Ability{
//NAME=穆鲁之影
//TEXT=本随从吞噬了圣盾，攻击力和生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_591:MinionBase{
//NAME=奥金尼灵魂祭司
//TEXT=你的恢复生命值的牌和技能改为造成等量的伤害。
//MAJ=PRIEST|COST=4|ATK=3|HP=5|RACE=NONE
}
public class EX1_591e:Ability{
//NAME=织魂
//TEXT=你的恢复生命值的牌和技能改为造成等量的伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_593:MinionBase{
//NAME=夜刃刺客
//TEXT=<b>战吼：</b>对敌方英雄造成3点伤害。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class EX1_594:SecretBase{
//NAME=蒸发
//TEXT=<b>奥秘：</b>当一个随从攻击你的英雄，将其消灭。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class EX1_595:MinionBase{
//NAME=诅咒教派领袖
//TEXT=在一个友方随从死亡后，抽一张牌。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=UNDEAD
}
public class EX1_596:SpellBase{
//NAME=恶魔之火
//TEXT=对一个随从造成$2点伤害，如果该随从是友方恶魔，则改为使其获得+2/+2。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=FEL
}
public class EX1_596e:Ability{
//NAME=恶魔之火
//TEXT=该恶魔拥有+2/+2。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_597:MinionBase{
//NAME=小鬼召唤师
//TEXT=在你的回合结束时，对本随从造成1点伤害，并召唤一个1/1的 小鬼。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class EX1_598:MinionBase{
//NAME=小鬼
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class EX1_603:MinionBase{
//NAME=严酷的监工
//TEXT=<b>战吼：</b>对一个随从造成1点伤害，并使其获得+2攻击力。
//MAJ=WARRIOR|COST=2|ATK=2|HP=3|RACE=NONE
}
public class EX1_603e:Ability{
//NAME=鞭打成型
//TEXT=+2攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_604:MinionBase{
//NAME=暴乱狂战士
//TEXT=每当一个随从 受到伤害，便获得+1攻击力。
//MAJ=WARRIOR|COST=3|ATK=2|HP=4|RACE=NONE
}
public class EX1_604o:Ability{
//NAME=狂怒
//TEXT=攻击力提高。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_606:SpellBase{
//NAME=盾牌格挡
//TEXT=获得5点护甲值。抽一张牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskBuffMyHero(arm:5);
        TaskDraw();
    }
}
public class EX1_607:SpellBase{
//NAME=怒火中烧
//TEXT=对一个随从造成$1点伤害，并使其获得+2攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
        
        new EffectGiveAbility(owner.myPlayer,owner,target,"WindFury").Resolve();
        new EffectChange(owner.myPlayer,owner,target,atkChange:2).Resolve();
    }
}
public class EX1_607e:Ability{
//NAME=怒火中烧
//TEXT=+2攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_608:MinionBase{
//NAME=巫师学徒
//TEXT=你的法术的法力值消耗减少（1）点。
//MAJ=MAGE|COST=4|ATK=3|HP=2|RACE=NONE
}
public class EX1_608e:Ability{
//NAME=学徒之助
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_609:SecretBase{
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
            new EffectDamage(owner.myPlayer,owner, sc, 4).Resolve();
        }
    }
}
public class EX1_610:SecretBase{
//NAME=爆炸陷阱
//TEXT=<b>奥秘：</b>当你的英雄受到攻击，对所有敌人造成$2点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class EX1_611:SecretBase{
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
public class EX1_611e:Ability{
//NAME=触发陷阱
//TEXT=在下个回合开始时，会被再次<b>冻结</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_612:MinionBase{
//NAME=肯瑞托法师
//TEXT=<b>战吼：</b> 在本回合中，你使用的下一个<b>奥秘</b>的法力值消耗为（0）点。
//MAJ=MAGE|COST=3|ATK=4|HP=3|RACE=NONE
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
public class EX1_612o:Ability{
//NAME=肯瑞托之力
//TEXT=你的下一个奥秘的法力值消耗为（0）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_613:MinionBase{
//NAME=艾德温·范克里夫
//TEXT=<b>连击：</b>在本回合中，你每使用一张其他牌，便获得+2/+2。
//MAJ=ROGUE|COST=3|ATK=2|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int Num = owner.myPlayer.GetTag(GameTag.CntCardUsedThisTurn)*2;
        new EffectChange(owner.myPlayer,owner,owner,atkChange:Num,hpChange:Num).Resolve();
    }
}
public class EX1_613e:Ability{
//NAME=范克里夫的复仇
//TEXT=属性值提高。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_614:MinionBase{
//NAME=萨维斯
//TEXT=在你使用一张牌后，召唤一个2/1的萨特。
//MAJ=NEUTRAL|COST=6|ATK=7|HP=5|RACE=DEMON
}
public class EX1_614t:MinionBase{
//NAME=萨维亚萨特
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=DEMON
}
public class EX1_616:MinionBase{
//NAME=法力怨魂
//TEXT=召唤所有随从的法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class EX1_616e:Ability{
//NAME=抽取法力
//TEXT=法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_617:SpellBase{
//NAME=致命射击
//TEXT=随机消灭一个敌方随从。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDestroyRandomEnemyMinion();
    }
}
public class EX1_619:SpellBase{
//NAME=生而平等
//TEXT=将所有随从的生命值变为1。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
    public override void Battlecry(Card target=null)
    {
        TaskSetHpTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1,hpDef:1);
    }
}
public class EX1_619e:Ability{
//NAME=生而平等
//TEXT=生命值变为1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_620:MinionBase{
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
public class EX1_621:SpellBase{
//NAME=治疗之环
//TEXT=为所有随从恢复#4点生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=HOLY
}
public class EX1_622:SpellBase{
//NAME=暗言术：灭
//TEXT=消灭一个攻击力大于或等于5的随从。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class EX1_623:MinionBase{
//NAME=圣殿执行者
//TEXT=<b>战吼：</b>使一个友方随从获得+3生命值。
//MAJ=PRIEST|COST=5|ATK=5|HP=6|RACE=NONE
}
public class EX1_623e:Ability{
//NAME=生命灌注
//TEXT=+3生命值
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_624:SpellBase{
//NAME=神圣之火
//TEXT=造成$5点伤害。为你的英雄恢复#5点生命值。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=HOLY
}
public class EX1_625:SpellBase{
//NAME=暗影形态
//TEXT=你的英雄技能变为“造成2点伤害”。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class EX1_625t:HeroPowerBase{
//NAME=心灵尖刺
//TEXT=造成$2点伤害。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
    }
}
public class EX1_625t2:HeroPowerBase{
//NAME=心灵碎裂
//TEXT=造成$3点伤害。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_626:SpellBase{
//NAME=群体驱散
//TEXT=<b>沉默</b>所有敌方随从，抽一张牌。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=HOLY
}
public class EX1_finkle:MinionBase{
//NAME=皮普·急智
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class EX1_finkle_G:MinionBase{
//NAME=皮普·急智
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class EX1_tk11:MinionBase{
//NAME=幽灵狼
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class EX1_tk28:MinionBase{
//NAME=松鼠
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class EX1_tk29:MinionBase{
//NAME=魔暴龙
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class EX1_tk31:Ability{
//NAME=精神控制
//TEXT=
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class EX1_tk33:HeroPowerBase{
//NAME=地狱火！
//TEXT=召唤一个6/6的地狱火。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_tk33_2_TB:HeroPowerBase{
//NAME=地狱火！
//TEXT=召唤一个6/6的地狱火。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class EX1_tk34:MinionBase{
//NAME=地狱火
//TEXT=
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=DEMON
}
public class EX1_tk9:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
