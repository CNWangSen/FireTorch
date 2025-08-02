using System.Collections;
using System.Collections.Generic;

public class BG_25_910t15e:Ability{
//NAME=呀哈！！
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_AT_069:MinionBase{
//NAME=格斗陪练师
//TEXT=<b>嘲讽</b> <b>战吼：</b>使一个随从获得<b>嘲讽</b>。
//MAJ=WARRIOR|COST=2|ATK=3|HP=2|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class BG_AT_069_G:MinionBase{
//NAME=格斗陪练师
//TEXT=<b>嘲讽</b> <b>战吼：</b>使一个随从获得<b>嘲讽</b>。
//MAJ=WARRIOR|COST=2|ATK=6|HP=4|RACE=NONE
    public override void Init()
    {
        owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
        TaskInitAbility("Taunt");
    }
}
public class BG_AV_309:MinionBase{
//NAME=被背小鬼
//TEXT=<b>亡语：</b>召唤一个4/1的小鬼。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=1|RACE=DEMON
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG_AV_309t"),ZoneType.Board);
    }
}
public class BG_AV_309_G:MinionBase{
//NAME=被背小鬼
//TEXT=<b>亡语：</b>召唤一个8/2的小鬼。
//MAJ=NEUTRAL|COST=3|ATK=8|HP=2|RACE=DEMON
    public override void Init()
    {
        owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
    }
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG_AV_309_Gt"),ZoneType.Board);
    }
}
public class BG_AV_309_Gt:MinionBase{
//NAME=背背小鬼
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=8|HP=2|RACE=DEMON
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_AV_309t:MinionBase{
//NAME=背背小鬼
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=4|HP=1|RACE=DEMON
}
public class BG_BOT_312:MinionBase{
//NAME=量产型恐吓机
//TEXT=<b>磁力</b> <b>亡语：</b>召唤三个1/1的微型机器人。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=MECHANICAL
    public override void Deathrattle()
    {
        CardDbf db = CardDbf.GetCardDbfByGuid("BG_BOT_312t");
        TaskCreate(db,ZoneType.Board);
        TaskCreate(db,ZoneType.Board);
        TaskCreate(db,ZoneType.Board);
    }
}
public class BG_BOT_312e:Ability{
//NAME=量产型恐吓机
//TEXT=<b>亡语：</b>召唤三个1/1的微型机器人。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_BOT_312t:MinionBase{
//NAME=微型机器人
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
}
public class BG_BOT_312_G:MinionBase{
//NAME=量产型恐吓机
//TEXT=<b>磁力</b> <b>亡语：</b>召唤三个1/1的微型机器人。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Deathrattle()
    {
        CardDbf db = CardDbf.GetCardDbfByGuid("BG_BOT_312t_G");
        TaskCreate(db,ZoneType.Board);
        TaskCreate(db,ZoneType.Board);
        TaskCreate(db,ZoneType.Board);
    }
}
public class BG_BOT_312t_G:MinionBase{
//NAME=微型机器人
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_BOT_563:MinionBase{
//NAME=战争机兵
//TEXT=<b>磁力</b>
//MAJ=NEUTRAL|COST=5|ATK=6|HP=5|RACE=MECHANICAL
}
public class BG_BOT_563_G:MinionBase{
//NAME=战争机兵
//TEXT=<b>磁力</b>
//MAJ=NEUTRAL|COST=5|ATK=12|HP=10|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_BOT_563_Ge:Ability{
//NAME=战争机兵
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_BOT_563e:Ability{
//NAME=战争机兵
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_BOT_606:MinionBase{
//NAME=爆爆机器人
//TEXT=<b>亡语：</b>随机对一个敌方随从造成4点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=MECHANICAL
    public override void Deathrattle()
    {
        TaskDamageRandomEnemyMinion(4);
    }
}
public class BG_BOT_606_G:MinionBase{
//NAME=爆爆机器人
//TEXT=<b>亡语：</b>随机对一个敌方随从造成4点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=MECHANICAL
    public override void Deathrattle()
    {
        TaskDamageRandomEnemyMinion(4);
        TaskDamageRandomEnemyMinion(4);
    }
}
public class BG_BOT_911:MinionBase{
//NAME=吵吵模组
//TEXT=<b>磁力</b> <b>圣盾</b> <b>嘲讽</b>
//MAJ=PALADIN|COST=4|ATK=2|HP=4|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("DivineShield");
        TaskInitAbility("Taunt");
    }
}
public class BG_BOT_911_G:MinionBase{
//NAME=吵吵模组
//TEXT=<b>磁力</b> <b>圣盾</b> <b>嘲讽</b>
//MAJ=PALADIN|COST=4|ATK=2|HP=4|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("DivineShield");
        TaskInitAbility("Taunt");
    }
}
public class BG_BOT_9112e:Ability{
//NAME=吵吵模组
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_BOT_911e:Ability{
//NAME=吵吵模组
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_BOT_911e2:Ability{
//NAME=Annoy-o-Module
//TEXT=<b>Taunt</b>,
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_BRM_006t:MinionBase{
//NAME=小鬼
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class BG_BT_010:MinionBase{
//NAME=邪鳍导航员
//TEXT=<b>战吼：</b>使你的其他鱼人获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=MURLOC
}
public class BG_BT_703t:MinionBase{
//NAME=被诅咒的阴影
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=7|ATK=7|HP=5|RACE=UNDEAD
    public override void Init()
    {
        TaskInitAbility("Stealth");
    }
}
public class BG_CFM_063:MinionBase{
//NAME=化学怪人
//TEXT=<b>战吼：</b> 使一个随从的攻击力和生命值互换。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class BG_CFM_063_G:MinionBase{
//NAME=化学怪人
//TEXT=<b>战吼：</b> 使一个随从的攻击力和生命值互换。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=8|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_CFM_063e:Ability{
//NAME=化学怪人
//TEXT=攻击力和生命值互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_CFM_315:MinionBase{
//NAME=雄斑虎
//TEXT=<b>战吼：</b>召唤一头1/1的雌斑虎。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG_CFM_315t"),ZoneType.Board);
    }
}
public class BG_CFM_315_G:MinionBase{
//NAME=雄斑虎
//TEXT=<b>战吼：</b>召唤一头1/1的雌斑虎。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG_CFM_315t"),ZoneType.Board);
        TaskCreate(CardDbf.GetCardDbfByGuid("BG_CFM_315t"),ZoneType.Board);
    }
}

public class BG_CFM_315t:MinionBase{
//NAME=雌斑虎
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class BG_CFM_315t_G:MinionBase{
//NAME=雌斑虎
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class BG_CFM_316:MinionBase{
//NAME=瘟疫鼠群
//TEXT=<b>亡语：</b>召唤若干个1/1的老鼠，数量等同于本随从的攻击力。
//MAJ=HUNTER|COST=3|ATK=2|HP=2|RACE=BEAST
    public override void Deathrattle()
    {
        for(int i=0;i<owner.GetTag(GameTag.Attack);i++)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("BG_CFM_316t"),ZoneType.Board);
        }
    }
}
public class BG_CFM_316_G:MinionBase{
//NAME=瘟疫鼠群
//TEXT=<b>亡语：</b>召唤若干个1/1的老鼠，数量等同于本随从的攻击力。
//MAJ=HUNTER|COST=3|ATK=2|HP=2|RACE=BEAST
    public override void Deathrattle()
    {
        for(int i=0;i<owner.GetTag(GameTag.Attack);i++)
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("BG_CFM_316t_G"),ZoneType.Board);
        }
    }
}
public class BG_CFM_316t:MinionBase{
//NAME=老鼠
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class BG_CFM_316t_G:MinionBase{
//NAME=老鼠
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_CS2_065:MinionBase{
//NAME=虚空行者
//TEXT=<b>嘲讽</b>
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class BG_CS2_065_G:MinionBase{
//NAME=虚空行者
//TEXT=<b>嘲讽</b>
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=DEMON
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
    }
}
public class BG_CS2_127:MinionBase{
//NAME=银背族长
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class BG_CS2_127_G:MinionBase{
//NAME=银背族长
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=8|RACE=BEAST
    public override void Init()
    {
        owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
        TaskInitAbility("Taunt");
    }
}
public class BG_CS2_200:MinionBase{
//NAME=石拳食人魔
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=6|HP=7|RACE=NONE
}
public class BG_CS2_200_G:MinionBase{
//NAME=石拳食人魔
//TEXT=<i>六攻七血的身材，他<b>就是</b>值这个等级！</i>
//MAJ=NEUTRAL|COST=0|ATK=6|HP=7|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_DAL_077:MinionBase{
//NAME=毒鳍鱼人
//TEXT=<b>战吼：</b>使一个友方鱼人获得<b>剧毒</b>。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=MURLOC
    public override void Battlecry(Card target=null)
    {
        if(target.raceType.Contains(RaceType.Murloc) || target.raceType.Contains(RaceType.All))
        {
            new EffectGiveAbility(owner.myPlayer,owner,target,"Poisonous").Resolve();
        }
    }
}
public class BG_DAL_077_G:MinionBase{
//NAME=毒鳍鱼人
//TEXT=<b>战吼：</b>使一个友方鱼人获得<b>剧毒</b>。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=MURLOC
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Battlecry(Card target=null)
    {
        if(target.raceType.Contains(RaceType.Murloc) || target.raceType.Contains(RaceType.All))
        {
            new EffectGiveAbility(owner.myPlayer,owner,target,"Poisonous").Resolve();
        }
    }
}
public class BG_DAL_575:MinionBase{
//NAME=卡德加
//TEXT=你的召唤随从的卡牌召唤数量翻倍。
//MAJ=MAGE|COST=2|ATK=2|HP=2|RACE=NONE
}
public class BG_DAL_575_G:MinionBase{
//NAME=卡德加
//TEXT=你的召唤随从的卡牌召唤数量翻倍。
//MAJ=MAGE|COST=2|ATK=2|HP=2|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_DAL_775:MinionBase{
//NAME=坑道爆破师
//TEXT=<b>嘲讽，亡语：</b>对所有随从造成3点伤害。
//MAJ=NEUTRAL|COST=7|ATK=3|HP=7|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        List<Card> ToDmg = new List<Card>();
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
        {
            if(c.GetTag(GameTag.Health)>0)
            {
                ToDmg.Add(c);
            }
        }
        TaskDamageTargets(ToDmg,3);
    }
}
public class BG_DAL_775_G:MinionBase{
//NAME=坑道爆破师
//TEXT=<b>嘲讽，亡语：</b>对所有随从造成3点伤害，触发两次。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=14|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        List<Card> ToDmg = new List<Card>();
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
        {
            if(c.GetTag(GameTag.Health)>0)
            {
                ToDmg.Add(c);
            }
        }
        TaskDamageTargets(ToDmg,3);
        ToDmg = new List<Card>();
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
        {
            if(c.GetTag(GameTag.Health)>0)
            {
                ToDmg.Add(c);
            }
        }
        TaskDamageTargets(ToDmg,3);
    } 
}
public class BG_DMF_533:MinionBase{
//NAME=火圈鬼母
//TEXT=<b>嘲讽，亡语：</b>召唤两个3/2的小鬼。
//MAJ=WARLOCK|COST=6|ATK=6|HP=4|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        CardDbf db = CardDbf.GetCardDbfByGuid("BG_DMF_533t");
        TaskCreate(db,ZoneType.Board);
        TaskCreate(db,ZoneType.Board);
    }
}
public class BG_DMF_533t:MinionBase{
//NAME=火焰小鬼
//TEXT=
//MAJ=WARLOCK|COST=2|ATK=3|HP=2|RACE=DEMON
}
public class BG_DS1_070:MinionBase{
//NAME=驯兽师
//TEXT=<b>战吼：</b>使一个友方野兽获得+2/+2和<b>嘲讽</b>。
//MAJ=HUNTER|COST=4|ATK=4|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(target.raceType.Contains(RaceType.Beast))
        {
            if(target.myPlayer==owner.myPlayer)
            {
                new EffectChange(owner.myPlayer,owner,target,atkChange:2,hpChange:2).Resolve();
                new EffectGiveAbility(owner.myPlayer,owner,target,"Taunt").Resolve();
            }
        }
    }
}
public class BG_DS1_070_G:MinionBase{
//NAME=驯兽师
//TEXT=<b>战吼：</b>使一个友方野兽获得+2/+2和<b>嘲讽</b>。
//MAJ=HUNTER|COST=4|ATK=4|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(target.raceType.Contains(RaceType.Beast))
        {
            if(target.myPlayer==owner.myPlayer)
            {
                new EffectChange(owner.myPlayer,owner,target,atkChange:4,hpChange:4).Resolve();
                new EffectGiveAbility(owner.myPlayer,owner,target,"Taunt").Resolve();
            }
        }
    }
}
public class BG_EX1_059:MinionBase{
//NAME=疯狂的炼金师
//TEXT=<b>战吼：</b> 使一个随从的攻击力和生命值互换。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class BG_EX1_059e:Ability{
//NAME=疯狂药剂
//TEXT=攻击力和生命值互换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_EX1_103:MinionBase{
//NAME=寒光先知
//TEXT=<b>战吼：</b>使你的其他鱼人获得+2生命值。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=MURLOC
    public override void Battlecry(Card target=null)
    {
        TaskBuffTargets(FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Murloc),hp:2);
    }
}
public class BG_EX1_103_G:MinionBase{
//NAME=寒光先知
//TEXT=<b>战吼：</b>使你的其他鱼人获得+2生命值。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=MURLOC
    public override void Battlecry(Card target=null)
    {
        TaskBuffTargets(FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Murloc),hp:4);
    }
}
public class BG_EX1_103e:Ability{
//NAME=鱼人怒吼
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_EX1_170:MinionBase{
//NAME=帝王眼镜蛇
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Poisonous");
    }
}
public class BG_EX1_170_G:MinionBase{
//NAME=帝王眼镜蛇
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=3|ATK=4|HP=6|RACE=BEAST
    public override void Init()
    {
        owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
        TaskInitAbility("Poisonous");
    }
}
public class BG_EX1_507:MinionBase{
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
public class BG_EX1_507_G:MinionBase{
//NAME=鱼人领军
//TEXT=你的其他鱼人拥有+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MURLOC
    public override void Init()
    {
        TaskSetGolden();
    }
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
        return "EX1_507e_G";
    }
}
public class BG_EX1_531:MinionBase{
//NAME=食腐土狼
//TEXT=每当一个友方野兽死亡，便获得+2/+1。
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sz==ZoneType.Board && tz==ZoneType.Grave && sc.raceType.Contains(RaceType.Beast) && sc!=owner)
            {
                new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:1).Resolve();
            }
        }
    }
}
public class BG_EX1_531_G:MinionBase{
//NAME=食腐土狼
//TEXT=每当一个友方野兽死亡，便获得+2/+1。
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
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
            if(sz==ZoneType.Board && tz==ZoneType.Grave && sc.raceType.Contains(RaceType.Beast) && sc!=owner)
            {
                new EffectChange(owner.myPlayer,owner,owner,atkChange:4,hpChange:2).Resolve();
            }
        }
    }
}
public class BG_EX1_534:MinionBase{
//NAME=长鬃草原狮
//TEXT=<b>亡语：</b>召唤两只2/2的土狼。
//MAJ=HUNTER|COST=6|ATK=6|HP=5|RACE=BEAST
    public override void Deathrattle()
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("BG_EX1_534t");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class BG_EX1_534_G:MinionBase{
//NAME=长鬃草原狮
//TEXT=<b>亡语：</b>召唤两只2/2的土狼。
//MAJ=HUNTER|COST=6|ATK=6|HP=5|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Deathrattle()
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("BG_EX1_534t_G");
        TaskCreate(ToSummon,ZoneType.Board);
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class BG_EX1_534t:MinionBase{
//NAME=土狼
//TEXT=
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class BG_EX1_534t_G:MinionBase{
//NAME=土狼
//TEXT=
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
}

public class BG_EX1_554t:MinionBase{
//NAME=蛇
//TEXT=
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class BG_EX1_554t_G:MinionBase{
//NAME=蛇
//TEXT=
//MAJ=HUNTER|COST=1|ATK=2|HP=2|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_EX1_556:MinionBase{
//NAME=麦田傀儡
//TEXT=<b>亡语：</b>召唤一个2/1的损坏的傀儡。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=MECHANICAL
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG_EX1_556t"),ZoneType.Board);
    }
}
public class BG_EX1_556t:MinionBase{
//NAME=损坏的傀儡
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=MECHANICAL
}
public class BG_EX1_556_G:MinionBase{
//NAME=麦田傀儡
//TEXT=<b>亡语：</b>召唤一个2/1的损坏的傀儡。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG_EX1_556t_G"),ZoneType.Board);
    }
}
public class BG_EX1_556t_G:MinionBase{
//NAME=损坏的傀儡
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_EX1_564:MinionBase{
//NAME=无面操纵者
//TEXT=<b>战吼：</b>选择一个随从，成为它的复制。
//MAJ=NEUTRAL|COST=0|ATK=3|HP=3|RACE=NONE
}
public class BG_EX1_564_G:MinionBase{
//NAME=无面操纵者
//TEXT=<b>战吼：</b>选择一个随从，成为它的复制。
//MAJ=NEUTRAL|COST=0|ATK=6|HP=6|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_FP1_005e:Ability{
//NAME=吞噬
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_FP1_014t:MinionBase{
//NAME=塔迪乌斯
//TEXT=
//MAJ=NEUTRAL|COST=10|ATK=11|HP=11|RACE=UNDEAD
}
public class BG_FP1_024:MinionBase{
//NAME=蹒跚的食尸鬼
//TEXT=<b>嘲讽</b>，<b>亡语：</b>对所有随从造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Exclude(owner),1);
    }
}
public class TB_BaconUps_118:MinionBase{
//NAME=蹒跚的食尸鬼
//TEXT=<b>嘲讽</b>，<b>亡语：</b>对所有随从造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Exclude(owner),1);
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Exclude(owner),1);
    }
}

public class BG_FP1_031:MinionBase{
//NAME=瑞文戴尔男爵
//TEXT=你的随从的<b>亡语</b>将触发两次。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=7|RACE=UNDEAD
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterDestroy(this,this.CauseEvent));
    }
    public void CauseEvent(Card source, Card target)
    {
        if(CondInPlay())
        {
            for(int i=0;i<1;i++)
            {
                if (target.abilityList.Count != 0)
                {
                    for (int j = 0; j < target.abilityList.Count; j++)
                    {
                        target.abilityList[j].Deathrattle();
                    }
                }               
            }
        }
    }
}

public class BG_FP1_031_G:MinionBase{
//NAME=瑞文戴尔男爵
//TEXT=你的随从的<b>亡语</b>将触发两次。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=7|RACE=UNDEAD
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterDestroy(this,this.CauseEvent));
    }
    public void CauseEvent(Card source, Card target)
    {
        if(CondInPlay())
        {
            for(int i=0;i<1;i++)
            {
                if (target.abilityList.Count != 0)
                {
                    for (int j = 0; j < target.abilityList.Count; j++)
                    {
                        target.abilityList[j].Deathrattle();
                    }
                    for (int j = 0; j < target.abilityList.Count; j++)
                    {
                        target.abilityList[j].Deathrattle();
                    }
                }               
            }
        }
    }
}
public class BG_GIL_655:MinionBase{
//NAME=腐树巨人
//TEXT=在一个友方随从攻击后，获得+1攻击力。
//MAJ=WARRIOR|COST=5|ATK=2|HP=7|RACE=UNDEAD
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.myPlayer==owner.myPlayer)
            {
                new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
            }
        }
    }
}
public class BG_GIL_655_G:MinionBase{
//NAME=腐树巨人
//TEXT=在一个友方随从攻击后，获得+1攻击力。
//MAJ=WARRIOR|COST=5|ATK=2|HP=7|RACE=UNDEAD
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.myPlayer==owner.myPlayer)
            {
                new EffectChange(owner.myPlayer,owner,owner,atkChange:2).Resolve();
            }
        }
    }
}
public class BG_GIL_655e:Ability{
//NAME=生长
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_GIL_681:MinionBase{
//NAME=梦魇融合怪
//TEXT=<i>本随从拥有全部随从类型。</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=ALL
}
public class BG_GIL_681_G:MinionBase{
//NAME=梦魇融合怪
//TEXT=<i>本随从拥有全部随从类型。</i>
//MAJ=NEUTRAL|COST=3|ATK=6|HP=8|RACE=ALL
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_GVG_027:MinionBase{
//NAME=钢铁武道家
//TEXT=在你的回合结束时，使另一个友方机械获得+2/+2。
//MAJ=ROGUE|COST=3|ATK=2|HP=2|RACE=MECHANICAL
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
        {
            List<Card> Candiate = new List<Card>();
            foreach(Card c in owner.myPlayer.board)
            {
                if(c.raceType.Contains(RaceType.Mechanical) || c.raceType.Contains(RaceType.All))
                {
                    Candiate.Add(c);
                }
            }
            Card ToBuff = Candiate.Choice(owner.myPlayer.randomGen);
            if(ToBuff!=null)
            {
                new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:2,hpChange:2).Resolve();
            }
        }
    }
}
public class BG_GVG_027_G:MinionBase{
//NAME=钢铁武道家
//TEXT=在你的回合结束时，使另一个友方机械获得+2/+2。
//MAJ=ROGUE|COST=3|ATK=2|HP=2|RACE=MECHANICAL
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
        {
            List<Card> Candiate = new List<Card>();
            foreach(Card c in owner.myPlayer.board)
            {
                if(c.raceType.Contains(RaceType.Mechanical) || c.raceType.Contains(RaceType.All))
                {
                    Candiate.Add(c);
                }
            }
            Card ToBuff = Candiate.Choice(owner.myPlayer.randomGen);
            if(ToBuff!=null)
            {
                new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:4,hpChange:4).Resolve();
            }
        }
    }
}
public class BG_GVG_048:MinionBase{
//NAME=金刚刃牙兽
//TEXT=<b>战吼：</b>使你的其他机械获得+2攻击力。
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=MECHANICAL
    public override void Battlecry(Card target=null)
    {
        TaskBuffTargets(FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Mechanical),atk:2);
    }
}
public class BG_GVG_048_G:MinionBase{
//NAME=金刚刃牙兽
//TEXT=<b>战吼：</b>使你的其他机械获得+2攻击力。
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=MECHANICAL
    public override void Battlecry(Card target=null)
    {
        TaskBuffTargets(FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Mechanical),atk:4);
    }
}
public class BG_GVG_085:MinionBase{
//NAME=吵吵机器人
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=0|ATK=1|HP=2|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("Taunt");
        TaskInitAbility("DivineShield");
    }
}
public class BG_GVG_085_G:MinionBase{
//NAME=吵吵机器人
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=0|ATK=2|HP=4|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
        TaskInitAbility("DivineShield");
    }
}
public class BG_GVG_100:MinionBase{
//NAME=漂浮观察者
//TEXT=每当你的英雄在你的回合受到伤害，便获得+2/+2。
//MAJ=WARLOCK|COST=5|ATK=4|HP=4|RACE=DEMON
}
public class BG_GVG_100e:Ability{
//NAME=眼纹纵横
//TEXT=属性值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_GVG_113:MinionBase{
//NAME=死神4000型
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=9|RACE=MECHANICAL
    private List<Card> rem = new List<Card>(); 
    public override void BeforeAttack(Card target=null)
    {
        rem = FindAdj(target);
    }
    public override void AfterAttack(Card target=null)
    {        
        if(rem.Count>0)
        {
            TaskDamageTargets(rem,owner.GetTag(GameTag.Attack));
        }
    }
}
public class BG_GVG_113_G:MinionBase{
//NAME=死神4000型
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=9|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
    private List<Card> rem = new List<Card>(); 
    public override void BeforeAttack(Card target=null)
    {
        rem = FindAdj(target);
    }
    public override void AfterAttack(Card target=null)
    {     
        if(rem.Count>0)
        {
            TaskDamageTargets(rem,owner.GetTag(GameTag.Attack));
        }
    }
}
public class TB_BaconUps_153:MinionBase{
//NAME=死神4000型
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=9|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
    private List<Card> rem = new List<Card>(); 
    public override void BeforeAttack(Card target=null)
    {
        rem = FindAdj(target);
    }
    public override void AfterAttack(Card target=null)
    {     
        if(rem.Count>0)
        {
            TaskDamageTargets(rem,owner.GetTag(GameTag.Attack));
        }
    }
}
public class BG_ICC_026t:MinionBase{
//NAME=骷髅
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=UNDEAD
}
public class BG_ICC_026t_G:MinionBase{
//NAME=骷髅
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=2|HP=2|RACE=UNDEAD
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_ICC_028e:Ability{
//NAME=瓦格里祝福
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_ICC_032:MinionBase{
//NAME=制毒师
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=5|ATK=2|HP=5|RACE=UNDEAD
    public override void Init()
    {
        TaskInitAbility("Poisonous");
    }
}
public class BG_ICC_092:MinionBase{
//NAME=阿彻鲁斯老兵
//TEXT=<b>战吼：</b>使一个友方随从获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=UNDEAD
}
public class BG_ICC_092e:Ability{
//NAME=老兵的青睐
//TEXT=+1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_ICC_094:MinionBase{
//NAME=堕落残阳祭司
//TEXT=<b>战吼：</b>使一个友方随从获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=UNDEAD
}
public class BG_ICC_094e:Ability{
//NAME=祭司的祝福
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_ICC_099:MinionBase{
//NAME=自爆憎恶
//TEXT=<b>亡语：</b>对你所有的随从造成5点伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=6|RACE=UNDEAD
    public override void Deathrattle()
    {
        TaskDamageTargets(owner.myPlayer.board,5);
    }
}
public class BG_ICC_807:MinionBase{
//NAME=硬壳清道夫
//TEXT=<b>战吼：</b>使你具有<b>嘲讽</b>的随从获得+2/+2。
//MAJ=DRUID|COST=4|ATK=2|HP=3|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> ToListBuff = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.HasAbility("Taunt"))
            {
                ToListBuff.Add(c);
            }
        }
        TaskBuffTargets(ToListBuff,atk:2,hp:2);
    }
}

public class BG_ICC_807_G:MinionBase{
//NAME=硬壳清道夫
//TEXT=<b>战吼：</b>使你具有<b>嘲讽</b>的随从获得+2/+2。
//MAJ=DRUID|COST=4|ATK=2|HP=3|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Battlecry(Card target=null)
    {
        List<Card> ToListBuff = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.HasAbility("Taunt"))
            {
                ToListBuff.Add(c);
            }
        }
        TaskBuffTargets(ToListBuff,atk:4,hp:4);
    }
}
public class BG_KAR_005:MinionBase{
//NAME=慈祥的外婆
//TEXT=<b>亡语：</b>召唤一只3/2的大灰狼。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG_KAR_005a"),ZoneType.Board);
    }
}
public class BG_KAR_005_G:MinionBase{
//NAME=慈祥的外婆
//TEXT=<b>亡语：</b>召唤一只3/2的大灰狼。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG_KAR_005a_G"),ZoneType.Board);
    }
}
public class BG_KAR_005a:MinionBase{
//NAME=大灰狼
//TEXT=
//MAJ=HUNTER|COST=1|ATK=3|HP=2|RACE=BEAST
}
public class BG_KAR_005a_G:MinionBase{
//NAME=大灰狼
//TEXT=
//MAJ=HUNTER|COST=1|ATK=3|HP=2|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_LOE_012:MinionBase{
//NAME=盗墓匪贼
//TEXT=<b>亡语：</b>将一张铸币置入你的手牌。
//MAJ=ROGUE|COST=4|ATK=5|HP=4|RACE=UNDEAD
}
public class BG_LOE_077:MinionBase{
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
                foreach(Ability abi in sc.abilityList)
                {
                    abi.Battlecry(tc);
                }
            }
        }
    }
}

public class BG_LOE_077_G:MinionBase{
//NAME=布莱恩·铜须
//TEXT=你的<b>战吼</b>会触发 两次。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
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
                foreach(Ability abi in sc.abilityList)
                {
                    abi.Battlecry(tc);
                }
                foreach(Ability abi in sc.abilityList)
                {
                    abi.Battlecry(tc);
                }
            }
        }
    }
}

public class BG_LOOT_078:MinionBase{
//NAME=洞穴多头蛇
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=BEAST
    private List<Card> rem = new List<Card>(); 
    public override void BeforeAttack(Card target=null)
    {
        rem = FindAdj(target);
    }
    public override void AfterAttack(Card target=null)
    {        
        if(rem.Count>0)
        {
            TaskDamageTargets(rem,owner.GetTag(GameTag.Attack));
        }
    }
}

public class BG_LOOT_078_G:MinionBase{
//NAME=洞穴多头蛇
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
    private List<Card> rem = new List<Card>(); 
    public override void BeforeAttack(Card target=null)
    {
        rem = FindAdj(target);
    }
    public override void AfterAttack(Card target=null)
    {        
        if(rem.Count>0)
        {
            TaskDamageTargets(rem,owner.GetTag(GameTag.Attack));
        }
    }
}
public class BG_LOOT_368:MinionBase{
//NAME=虚空领主
//TEXT=<b>嘲讽，亡语：</b> 召唤三个1/3并具有<b>嘲讽</b>的恶魔。
//MAJ=WARLOCK|COST=9|ATK=3|HP=9|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        CardDbf db = CardDbf.GetCardDbfByGuid("BG_CS2_065");
        TaskCreate(db,ZoneType.Board);
        TaskCreate(db,ZoneType.Board);
        TaskCreate(db,ZoneType.Board);
    }
}
public class BG_LOOT_368_G:MinionBase{
//NAME=虚空领主
//TEXT=<b>嘲讽，亡语：</b> 召唤三个1/3并具有<b>嘲讽</b>的恶魔。
//MAJ=WARLOCK|COST=9|ATK=3|HP=9|RACE=DEMON
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        CardDbf db = CardDbf.GetCardDbfByGuid("BG_CS2_065_G");
        TaskCreate(db,ZoneType.Board);
        TaskCreate(db,ZoneType.Board);
        TaskCreate(db,ZoneType.Board);
    }
}
public class BG_NEW1_027:MinionBase{
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
public class BG_NX2_050:MinionBase{
//NAME=错误产物
//TEXT=<i>本随从拥有全部随从类型。</i>
//MAJ=NEUTRAL|COST=0|ATK=1|HP=3|RACE=ALL
}
public class BG_NX2_050_G:MinionBase{
//NAME=错误产物
//TEXT=<i>本随从拥有全部随从类型。</i>
//MAJ=NEUTRAL|COST=0|ATK=2|HP=6|RACE=ALL
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_OG_145:MinionBase{
//NAME=闹闹机器人
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=5|ATK=3|HP=4|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("Taunt");
        TaskInitAbility("DivineShield");
    }
}
public class BG_OG_145_G:MinionBase{
//NAME=闹闹机器人
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=5|ATK=6|HP=8|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
        TaskInitAbility("DivineShield");
    }
}
public class BG_OG_221:MinionBase{
//NAME=无私的英雄
//TEXT=<b>亡语：</b>随机使一个友方随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
    public override void Deathrattle()
    {
        Card ToGive = owner.myPlayer.board.Exclude(owner).Choice(owner.myPlayer.randomGen);
        if(ToGive!=null)
        {
           new EffectGiveAbility(owner.myPlayer,owner,ToGive,"DivineShield").Resolve(); 
        }
    }
}
public class BG_OG_221_G:MinionBase{
//NAME=无私的英雄
//TEXT=<b>亡语：</b>随机使一个友方随从获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Deathrattle()
    {

        List<Card> Candiate = new List<Card>();
        foreach(Card c in owner.myPlayer.board.Exclude(owner))
        {
            if(!c.HasAbility("DivineShield"))
            {
                Candiate.Add(c);
            }
        }


        Card ToGive1 = Candiate.Choice(owner.myPlayer.randomGen);

        if(ToGive1!=null)
        {
            Candiate.Remove(ToGive1);
            new EffectGiveAbility(owner.myPlayer,owner,ToGive1,"DivineShield").Resolve(); 
        }

        Card ToGive2 = Candiate.Choice(owner.myPlayer.randomGen);

        if(ToGive2!=null)
        {
            new EffectGiveAbility(owner.myPlayer,owner,ToGive2,"DivineShield").Resolve(); 
        }
    }
}
public class BG_OG_256:MinionBase{
//NAME=恩佐斯的子嗣
//TEXT=<b>亡语：</b>使你的所有随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
    public override void Deathrattle()
    {
        TaskBuffTargets(owner.myPlayer.board,atk:1,hp:1);
    }
}
public class BG_OG_256_G:MinionBase{
//NAME=恩佐斯的子嗣
//TEXT=<b>亡语：</b>使你的所有随从获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Deathrattle()
    {
        TaskBuffTargets(owner.myPlayer.board,atk:2,hp:2);
    }
}
public class BG_RLK_538:MinionBase{
//NAME=噬魂者
//TEXT=在一个友方随从死亡后，获得其<b>亡语</b>。
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=UNDEAD
}
public class BG_RLK_538_G:MinionBase{
//NAME=噬魂者
//TEXT=在一个友方随从死亡后，获得其<b>亡语</b>。
//MAJ=WARLOCK|COST=1|ATK=1|HP=3|RACE=UNDEAD
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_RLK_833t:MinionBase{
//NAME=骨积咕咕鸡
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class BG_RLK_833t_G:MinionBase{
//NAME=骨积咕咕鸡
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=6|HP=6|RACE=UNDEAD
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_RLK_957:MinionBase{
//NAME=女妖
//TEXT=<b>亡语：</b>随机使一个友方亡灵获得+2/+1。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=UNDEAD
    public override void Deathrattle()
    {
        List<Card> MyUD = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.raceType.Contains(RaceType.Undead))
            {
                MyUD.Add(c);
            }
        }
        Card ToGive = MyUD.Choice(owner.myPlayer.randomGen);
        if(ToGive!=null)
        {
            new EffectChange(owner.myPlayer,owner,ToGive,atkChange:2,hpChange:1).Resolve();
        }
    }
}
public class BG_RLK_958:MinionBase{
//NAME=骷髅帮手
//TEXT=<b>战吼：</b>使一个友方亡灵获得+2攻击力。
//MAJ=DEATHKNIGHT|COST=1|ATK=1|HP=2|RACE=UNDEAD
}
public class BG_RLK_958e:Ability{
//NAME=骨弓之助
//TEXT=+2攻击力。
//MAJ=DEATHKNIGHT|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_SCH_149:MinionBase{
//NAME=银色自大狂
//TEXT=<b>战吼：</b>将本随从的攻击力与生命值分别变为与战场上最高的数值相同。
//MAJ=PALADIN|COST=2|ATK=1|HP=1|RACE=NONE
}
public class BG_SCH_149e:Ability{
//NAME=超凡绝顶
//TEXT=属性值变为最高值。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_TID_713:MinionBase{
//NAME=可爱泡泡
//TEXT=在本随从受到刚好一点伤害后，消灭本随从。<i>（啪！）</i>
//MAJ=NEUTRAL|COST=1|ATK=5|HP=4|RACE=ELEMENTAL
    public override int BeforeTakeDamage(Card source = null, int amount = 0)
    {
        if(amount==1)
        {
            new EffectDestroy(owner.myPlayer,owner,owner).Resolve();
        }
        return amount;
    }
}
public class BG_TID_713_G:MinionBase{
//NAME=可爱泡泡
//TEXT=在本随从受到刚好两点伤害后，消灭本随从。<i>（啪！）</i>
//MAJ=NEUTRAL|COST=1|ATK=10|HP=8|RACE=ELEMENTAL
    public override void Init()
    {
        TaskSetGolden();
    }
    public override int BeforeTakeDamage(Card source = null, int amount = 0)
    {
        if(amount==2)
        {
            new EffectDestroy(owner.myPlayer,owner,owner).Resolve();
        }
        return amount;
    }
}
public class BG_TSC_069:MinionBase{
//NAME=深海融合怪
//TEXT=<b>战吼：</b>选择一个友方随从，<b>发现</b>一张相同类型的随从牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=ALL
}
public class BG_TSC_069_G:MinionBase{
//NAME=深海融合怪
//TEXT=<b>战吼：</b>选择一个友方随从，<b>发现</b>2张相同类型的随从牌。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=6|RACE=ALL
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_TTN_078:MinionBase{
//NAME=神话观测者
//TEXT=在你召唤一个攻击力高于本随从的随从后，使所有友方随从获得+1攻击力。
//MAJ=HUNTER|COST=4|ATK=1|HP=4|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.GetTag(GameTag.Attack)> owner.GetTag(GameTag.Attack))
            {
                if(tz==ZoneType.Board)
                {
                    TaskBuffTargets(owner.myPlayer.board,atk:1);
                }
            }
        }
    }
}
public class BG_TTN_078_G:MinionBase{
//NAME=神话观测者
//TEXT=在你召唤一个攻击力高于本随从的随从后，使所有友方随从获得+2攻击力。
//MAJ=HUNTER|COST=4|ATK=2|HP=8|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.GetTag(GameTag.Attack)> owner.GetTag(GameTag.Attack))
            {
                if(tz==ZoneType.Board)
                {
                    TaskBuffTargets(owner.myPlayer.board,atk:2);
                }
            }
        }
    }
}
public class BG_TTN_078_Ge:Ability{
//NAME=超自然影响
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_TTN_078e:Ability{
//NAME=超自然影响
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_TTN_401:MinionBase{
//NAME=星界自动机
//TEXT=在本局对战中，你每召唤过一个其他星界自动机，便拥有+1/+1。
//MAJ=PRIEST|COST=1|ATK=1|HP=2|RACE=MECHANICAL
}
public class BG_TTN_401_G:MinionBase{
//NAME=星界自动机
//TEXT=在本局对战中，你每召唤过一个其他星界自动机，便拥有+2/+2。
//MAJ=PRIEST|COST=1|ATK=2|HP=4|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_TTN_401e:Ability{
//NAME=防御矩阵启动
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_TTN_401pe:Ability{
//NAME=星界自动机玩家附加效果[DNT]
//TEXT=记录你召唤过的星界自动机总数。[DNT]
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_TTN_732:MinionBase{
//NAME=发明机器人
//TEXT=每当你<b>磁力</b>吸附一个随从时，使其获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=MECHANICAL
}
public class BG_TTN_732_G:MinionBase{
//NAME=发明机器人
//TEXT=每当你<b>磁力</b>吸附一个随从时，使其获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=6|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG_TTN_732_Ge:Ability{
//NAME=我想到了！
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_TTN_732e:Ability{
//NAME=我想到了！
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_ULD_205:MinionBase{
//NAME=夺烛木乃伊
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=UNDEAD
    public override void Init()
    {
        TaskInitAbility("Reborn");
    }
}
public class BG_ULD_217:MinionBase{
//NAME=微型木乃伊
//TEXT=<b>复生</b> 在你的回合结束时，随机使另一个友方随从获得+1攻击力。
//MAJ=PALADIN|COST=1|ATK=1|HP=2|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("Reborn");
    }
}
public class BG_ULD_217e:Ability{
//NAME=微型包扎
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG_ULD_275:MinionBase{
//NAME=白骨怨灵
//TEXT=<b>嘲讽</b>，<b>复生</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=UNDEAD
    public override void Init()
    {
        TaskInitAbility("Taunt");
        TaskInitAbility("Reborn");
    }
}
public class BG_UNG_073:MinionBase{
//NAME=石塘猎人
//TEXT=<b>战吼：</b>使一个友方鱼人获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=MURLOC
    public override void Battlecry(Card target=null)
    {
        if(target.raceType.Contains(RaceType.Murloc) || target.raceType.Contains(RaceType.All))
        {
            new EffectChange(owner.myPlayer,owner,target,atkChange:1,hpChange:1).Resolve();
        }
    }
}
public class BG_UNG_073_G:MinionBase{
//NAME=石塘猎人
//TEXT=<b>战吼：</b>使一个友方鱼人获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=MURLOC
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Battlecry(Card target=null)
    {
        if(target.raceType.Contains(RaceType.Murloc) || target.raceType.Contains(RaceType.All))
        {
            new EffectChange(owner.myPlayer,owner,target,atkChange:2,hpChange:2).Resolve();
        }
    }
}
