using System.Collections;
using System.Collections.Generic;

public class GVG_001:SpellBase{
//NAME=烈焰轰击
//TEXT=随机对一个敌方随从造成 $4点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class GVG_002:MinionBase{
//NAME=碎雪机器人
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=2|ATK=2|HP=3|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("Freezing");
    }
}
public class GVG_003:SpellBase{
//NAME=不稳定的传送门
//TEXT=随机将一张随从牌置入你的手牌。该牌的法力值消耗减少（3）点。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class GVG_004:MinionBase{
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
public class GVG_005:SpellBase{
//NAME=麦迪文的残影
//TEXT=将每个友方随从的各一张复制置入你的手牌。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=ARCANE
}
public class GVG_006:MinionBase{
//NAME=机械跃迁者
//TEXT=你的机械的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=MECHANICAL
}
public class GVG_006_puzzle:MinionBase{
//NAME=机械跃迁者
//TEXT=你的机械的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=MECHANICAL
}
public class GVG_006e:Ability{
//NAME=跃迁
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_007:MinionBase{
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
public class GVG_008:SpellBase{
//NAME=圣光炸弹
//TEXT=对所有随从造成等同于其攻击力的伤害。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=HOLY
}
public class GVG_009:MinionBase{
//NAME=暗影投弹手
//TEXT=<b>战吼：</b>对每个英雄造成3点伤害。
//MAJ=PRIEST|COST=1|ATK=3|HP=1|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDamageEnemyHero(3);
        TaskDamageMyHero(3);
    }
}
public class GVG_010:SpellBase{
//NAME=维伦的恩泽
//TEXT=使一个随从获得+2/+4和<b>法术伤害+1</b>。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class GVG_010b:Ability{
//NAME=维伦的恩泽
//TEXT=+2/+4并具有<b>法术伤害+1</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_011:MinionBase{
//NAME=缩小射线工程师
//TEXT=<b>战吼：</b>在本回合中，使一个随从获得-3攻击力。
//MAJ=PRIEST|COST=2|ATK=3|HP=2|RACE=NONE
}
public class GVG_011a:Ability{
//NAME=缩小
//TEXT=在本回合中-3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_012:SpellBase{
//NAME=纳鲁之光
//TEXT=恢复#3点生命值。如果目标仍处于受伤状态，则召唤一个圣光护卫者。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class GVG_013:MinionBase{
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
public class GVG_014:MinionBase{
//NAME=沃金
//TEXT=<b>战吼：</b>与另一个随从交换生命值。
//MAJ=PRIEST|COST=5|ATK=6|HP=2|RACE=NONE
}
public class GVG_014a:Ability{
//NAME=暗影笼罩
//TEXT=生命值已被交换。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_015:SpellBase{
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
public class GVG_016:MinionBase{
//NAME=魔能机甲
//TEXT=每当你的对手使用一张卡牌时，便移除你的牌库顶的三张牌。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=MECHANICAL
}
public class GVG_017:SpellBase{
//NAME=召唤宠物
//TEXT=抽一张牌。如果该牌是野兽牌，则其法力值消耗 减少（4）点。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GVG_018:MinionBase{
//NAME=痛苦女王
//TEXT=<b>吸血</b>
//MAJ=WARLOCK|COST=2|ATK=1|HP=4|RACE=DEMON
}
public class GVG_019:SpellBase{
//NAME=恶魔之心
//TEXT=对一个随从造成$5点伤害，如果该随从是友方恶魔，则改为使其获得+5/+5。
//MAJ=WARLOCK|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class GVG_019e:Ability{
//NAME=恶魔之心
//TEXT=+5/+5。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_020:MinionBase{
//NAME=邪能火炮
//TEXT=在你的回合结束时，对一个非机械随从造成2点伤害。
//MAJ=WARLOCK|COST=4|ATK=3|HP=5|RACE=MECHANICAL
}
public class GVG_021:MinionBase{
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
public class GVG_021e:Ability{
//NAME=玛尔加尼斯之握
//TEXT=玛尔加尼斯使其获得+2/+2。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod || tg==GameTag.HealthMod)
        {
            return 2;
        }
        return 0;
    }
    public override void UnRegisterEventEffect()
    {
        if(owner.GetTag(GameTag.Damage)>=2)
        {
            owner.ChangeTag(GameTag.Damage,-2);
        }
        
    }
}
public class TB_BaconUps_060:MinionBase{
//NAME=玛尔加尼斯
//TEXT=你的英雄<b>免疫</b>。你的其他恶魔拥有+2/+2。
//MAJ=WARLOCK|COST=9|ATK=9|HP=7|RACE=DEMON
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
        return (c.raceType.Contains(RaceType.Demon) && (c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board || c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hero) && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        if(c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
        {
            return "TB_BaconUps_060e";
        }
        else{
            return "Immue";
        }
    }
}
public class TB_BaconUps_060e:Ability{
//NAME=玛尔加尼斯之握
//TEXT=玛尔加尼斯使其获得+2/+2。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.AttackMod || tg==GameTag.HealthMod)
        {
            return 4;
        }
        return 0;
    }
    public override void UnRegisterEventEffect()
    {
        if(owner.GetTag(GameTag.Damage)>=4)
        {
            owner.ChangeTag(GameTag.Damage,-4);
        }
        
    }
}

public class GVG_022:SpellBase{
//NAME=修补匠的磨刀油
//TEXT=使你的武器获得+3攻击力。<b>连击：</b>随机使一个友方随从获得+3攻击力。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class GVG_022a:Ability{
//NAME=修补匠的磨刀油
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_022b:Ability{
//NAME=修补匠的磨刀油
//TEXT=+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_023:MinionBase{
//NAME=地精自动理发装置
//TEXT=<b>战吼：</b>使你的武器获得+1攻击力。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=MECHANICAL
}
public class GVG_023a:Ability{
//NAME=锋利无比
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_024:WeaponBase{
//NAME=齿轮大师的扳手
//TEXT=如果你控制任何机械，便拥有 +2攻击力。
//MAJ=ROGUE|COST=3|ATK=1|HP=3|RACE=NONE
}
public class GVG_025:MinionBase{
//NAME=独眼欺诈者
//TEXT=每当你召唤一个海盗，便获得<b>潜行</b>。
//MAJ=ROGUE|COST=2|ATK=4|HP=1|RACE=PIRATE
}
public class GVG_026:SpellBase{
//NAME=假死
//TEXT=触发所有友方随从的<b>亡语</b>。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GVG_027:MinionBase{
//NAME=钢铁武道家
//TEXT=在你的回合结束时，使另一个友方机械获得+2/+2。
//MAJ=ROGUE|COST=3|ATK=2|HP=2|RACE=MECHANICAL
}
public class GVG_027e:Ability{
//NAME=钢铁武学
//TEXT=属性值提高。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_028:MinionBase{
//NAME=加里维克斯
//TEXT=每当你的对手施放一个法术，获得该法术的复制，并使其获得一张幸运币。
//MAJ=ROGUE|COST=6|ATK=5|HP=8|RACE=NONE
}
public class GVG_028t:SpellBase{
//NAME=加里维克斯的幸运币
//TEXT=在本回合中，获得一个法力水晶。<i>（不会触发加里维克斯的效果。）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_029:SpellBase{
//NAME=先祖召唤
//TEXT=每个玩家从手牌中随机将一个随从置入战场。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class GVG_030:MinionBase{
//NAME=电镀机械熊仔
//TEXT=<b>嘲讽，抉择：</b> +1攻击力；或者+1生命值。
//MAJ=DRUID|COST=2|ATK=2|HP=2|RACE=MECHANICAL
}
public class GVG_030a:SpellBase{
//NAME=攻击模式
//TEXT=+1攻击力。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GVG_030ae:Ability{
//NAME=攻击模式
//TEXT=+1攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_030b:SpellBase{
//NAME=坦克模式
//TEXT=+1生命值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GVG_030be:Ability{
//NAME=坦克模式
//TEXT=+1生命值。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_031:SpellBase{
//NAME=回收
//TEXT=将一个敌方随从洗入你对手的 牌库。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class GVG_032:MinionBase{
//NAME=林地树妖
//TEXT=<b>抉择：</b>使每个玩家获得一个法力水晶；或每个玩家抽一张牌。
//MAJ=DRUID|COST=3|ATK=2|HP=4|RACE=NONE
}
public class GVG_032a:SpellBase{
//NAME=水晶赠礼
//TEXT=使每个玩家获得一个法力水晶。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class GVG_032b:SpellBase{
//NAME=卡牌赠礼
//TEXT=每个玩家抽一张牌。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class GVG_033:SpellBase{
//NAME=生命之树
//TEXT=为所有角色恢复所有生命值。
//MAJ=DRUID|COST=9|ATK=0|HP=0|RACE=NATURE
}
public class GVG_034:MinionBase{
//NAME=机械熊豹
//TEXT=每当本随从受到伤害，将一张<b>零件</b>牌置入你的手牌。
//MAJ=DRUID|COST=6|ATK=7|HP=6|RACE=MECHANICAL
}
public class GVG_035:MinionBase{
//NAME=玛洛恩
//TEXT=<b>亡语：</b>进入<b>休眠</b>状态。在2只友方野兽死亡后复活。
//MAJ=DRUID|COST=7|ATK=9|HP=7|RACE=BEAST
}
public class GVG_036:WeaponBase{
//NAME=动力战锤
//TEXT=<b>亡语：</b>随机使一个友方机械获得+2/+2。
//MAJ=SHAMAN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class GVG_036e:Ability{
//NAME=动力增强
//TEXT=+2/+2。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_037:MinionBase{
//NAME=自动漩涡打击装置
//TEXT=<b>风怒</b>
//MAJ=SHAMAN|COST=2|ATK=3|HP=2|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("WindFury");
    }
}
public class GVG_038:SpellBase{
//NAME=连环爆裂
//TEXT=造成$3到$6点伤害，<b>过载：</b>（1）
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        List<int> Dmgs= new List<int>(){3,4,5,6};
        owner.myPlayer.ChangeTag(GameTag.ManaOverLoad,1);
        new EffectDamage(owner.myPlayer,owner,target,Dmgs.Choice(owner.myPlayer.randomGen)).Resolve();
    }
}
public class GVG_039:MinionBase{
//NAME=活力图腾
//TEXT=在你的回合结束时，为你的英雄恢复#4点生命值。
//MAJ=SHAMAN|COST=2|ATK=0|HP=3|RACE=TOTEM
}
public class GVG_040:MinionBase{
//NAME=沙鳞灵魂行者
//TEXT=每当有其他友方鱼人死亡，便抽一张牌。 <b>过载：</b>（1）
//MAJ=SHAMAN|COST=4|ATK=2|HP=5|RACE=MURLOC
}
public class GVG_041:SpellBase{
//NAME=黑暗私语
//TEXT=<b>抉择：</b> 召唤5个小精灵；或者使一个随从获得+5/+5和<b>嘲讽</b>。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class GVG_041a:SpellBase{
//NAME=守护者的呼唤
//TEXT=+5/+5并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class GVG_041b:SpellBase{
//NAME=大自然的防线
//TEXT=召唤5个小精灵。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class GVG_041c:Ability{
//NAME=黑暗私语
//TEXT=+5/+5并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_042:MinionBase{
//NAME=耐普图隆
//TEXT=<b>战吼：</b>随机将四张鱼人牌置入你的手牌，<b>过载：</b>（3）
//MAJ=SHAMAN|COST=7|ATK=7|HP=7|RACE=ELEMENTAL
}
public class GVG_043:WeaponBase{
//NAME=重型刃弩
//TEXT=<b>战吼：</b>随机使一个友方随从获得+1攻击力。
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=NONE
}
public class GVG_043e:Ability{
//NAME=重型刃弩
//TEXT=+2攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_044:MinionBase{
//NAME=蜘蛛坦克
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=MECHANICAL
}
public class GVG_045:SpellBase{
//NAME=小鬼爆破
//TEXT=对一个随从造成$2-$4点伤害。每造成1点伤害，便召唤一个1/1的小鬼。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=FEL
}
public class GVG_045t:MinionBase{
//NAME=小鬼
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class GVG_046:MinionBase{
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
public class GVG_046e:Ability{
//NAME=百兽之王
//TEXT=攻击力提高。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_047:SpellBase{
//NAME=暗中破坏
//TEXT=随机消灭一个敌方随从，<b>连击：</b>并且摧毁你对手的武器。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class GVG_048:MinionBase{
//NAME=金刚刃牙兽
//TEXT=<b>战吼：</b>使你的其他机械获得+2攻击力。
//MAJ=HUNTER|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class GVG_048e:Ability{
//NAME=金刚刃牙
//TEXT=+2攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_049:MinionBase{
//NAME=加兹瑞拉
//TEXT=每当本随从受到伤害，其攻击力翻倍。
//MAJ=HUNTER|COST=7|ATK=6|HP=9|RACE=BEAST
}
public class GVG_049e:Ability{
//NAME=祖尔法拉克之力
//TEXT=攻击力成倍提高。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_050:SpellBase{
//NAME=弹射之刃
//TEXT=随机对一个随从造成$1点伤害。重复此效果，直到某个随从死亡。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class GVG_051:MinionBase{
//NAME=战斗机器人
//TEXT=受伤时拥有+1攻 击力。
//MAJ=WARRIOR|COST=1|ATK=1|HP=3|RACE=MECHANICAL
}
public class GVG_051e:Ability{
//NAME=激怒
//TEXT=+1攻击力
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_052:SpellBase{
//NAME=重碾
//TEXT=消灭一个随从。如果你控制任何受伤的随从，该法术的法力值消耗减少（4）点。
//MAJ=WARRIOR|COST=7|ATK=0|HP=0|RACE=NONE
}
public class GVG_053:MinionBase{
//NAME=盾甲侍女
//TEXT=<b>战吼：</b> 获得5点护甲值。
//MAJ=WARRIOR|COST=5|ATK=5|HP=5|RACE=NONE
}
public class GVG_054:WeaponBase{
//NAME=食人魔战槌
//TEXT=50%几率攻击错误的敌人。
//MAJ=WARRIOR|COST=3|ATK=4|HP=2|RACE=NONE
}
public class GVG_055:MinionBase{
//NAME=废旧螺栓机甲
//TEXT=<b>战吼：</b>使一个友方机械获得+2/+2。
//MAJ=WARRIOR|COST=4|ATK=2|HP=5|RACE=MECHANICAL
    public override void Battlecry(Card target=null)
    {
        if(target.raceType.Contains(RaceType.Mechanical) || target.raceType.Contains(RaceType.All))
        {
            new EffectChange(owner.myPlayer,owner,target,atkChange:2,hpChange:2).Resolve();
        }
    }
}
public class GVG_055_G:MinionBase{
//NAME=废旧螺栓机甲
//TEXT=<b>战吼：</b>使一个友方机械获得+2/+2。
//MAJ=WARRIOR|COST=4|ATK=2|HP=5|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Battlecry(Card target=null)
    {
        if(target.raceType.Contains(RaceType.Mechanical) || target.raceType.Contains(RaceType.All))
        {
            new EffectChange(owner.myPlayer,owner,target,atkChange:4,hpChange:4).Resolve();
        }
    }
}
public class GVG_055e:Ability{
//NAME=旋紧螺栓
//TEXT=+2/+2。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_056:MinionBase{
//NAME=钢铁战蝎
//TEXT=<b>战吼，亡语：</b>将一张“地雷” 牌洗入你对手的牌库。当抽到“地雷”时，便会受到10点伤害。
//MAJ=WARRIOR|COST=6|ATK=6|HP=5|RACE=MECHANICAL
}
public class GVG_056t:SpellBase{
//NAME=地雷
//TEXT=<b>抽到时施放</b> 你受到10点伤害。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class GVG_057:SpellBase{
//NAME=光明圣印
//TEXT=为你的英雄恢复#4点生命值，并在本回合中 获得+2攻击力。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class GVG_057a:Ability{
//NAME=光明圣印
//TEXT=在本回合中，+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_058:MinionBase{
//NAME=护盾机器人
//TEXT=<b>圣盾</b>
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("DivineShield");
    }
}
public class GVG_058_G:MinionBase{
//NAME=护盾机器人
//TEXT=<b>圣盾</b>
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("DivineShield");
    }
}
public class GVG_059:WeaponBase{
//NAME=齿轮光锤
//TEXT=<b>战吼：</b>随机使一个友方随从获得<b>圣盾</b>和<b>嘲讽</b>。
//MAJ=PALADIN|COST=3|ATK=2|HP=3|RACE=NONE
}
public class GVG_060:MinionBase{
//NAME=军需官
//TEXT=<b>战吼：</b>使你的白银之手新兵获得+2/+2。
//MAJ=PALADIN|COST=5|ATK=2|HP=5|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> SliverHands = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.cardDbf.m_noteMiniGuid.Contains("CS2_101t"))
            {
                SliverHands.Add(c);
            }
        }
        TaskBuffTargets(SliverHands,atk:2,hp:2);
    }
}
public class GVG_060e:Ability{
//NAME=装备精良
//TEXT=+2/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_061:SpellBase{
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
public class GVG_062:MinionBase{
//NAME=钴制卫士
//TEXT=每当你召唤一个机械，便获得<b>圣盾</b>。
//MAJ=PALADIN|COST=5|ATK=6|HP=3|RACE=MECHANICAL
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.raceType.Contains(RaceType.Mechanical) || sc.raceType.Contains(RaceType.All))
            {
                if(!owner.HasAbility("DivineShield"))
                    new EffectGiveAbility(owner.myPlayer,owner,owner,"DivineShield").Resolve();
            }
        }
    }
}
public class GVG_062_G:MinionBase{
//NAME=钴制卫士
//TEXT=每当你召唤一个机械，便获得<b>圣盾</b>。
//MAJ=PALADIN|COST=5|ATK=6|HP=3|RACE=MECHANICAL
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
        if(CondInPlay())
        {
            if(sc.raceType.Contains(RaceType.Mechanical) || sc.raceType.Contains(RaceType.All))
            {
                if(!owner.HasAbility("DivineShield"))
                    new EffectGiveAbility(owner.myPlayer,owner,owner,"DivineShield").Resolve();
            }
        }
    }
}
public class GVG_063:MinionBase{
//NAME=伯瓦尔·弗塔根
//TEXT=如果这张牌在你的手牌中，每当一个友方随从死亡，便获得+1攻击力。
//MAJ=PALADIN|COST=5|ATK=1|HP=7|RACE=NONE
}
public class GVG_063a:Ability{
//NAME=惩戒
//TEXT=攻击力提高
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_064:MinionBase{
//NAME=淤泥践踏者
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=MURLOC
}
public class GVG_065:MinionBase{
//NAME=食人魔步兵
//TEXT=50%几率攻击错误的敌人。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=NONE
}
public class GVG_066:MinionBase{
//NAME=砂槌萨满祭司
//TEXT=<b>风怒，过载：</b>（1） 50%几率攻击错误的敌人。
//MAJ=SHAMAN|COST=4|ATK=5|HP=4|RACE=NONE
}
public class GVG_067:MinionBase{
//NAME=碎石穴居人
//TEXT=每当你的对手施放一个法术，便获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class GVG_067a:Ability{
//NAME=魔法代谢
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_068:MinionBase{
//NAME=石腭穴居人壮汉
//TEXT=每当你的对手施放一个法术，获得 +2攻击力。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class GVG_068a:Ability{
//NAME=魔法代谢
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_069:MinionBase{
//NAME=老式治疗机器人
//TEXT=<b>战吼：</b>为你的英雄恢复#8点生命值。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=MECHANICAL
}
public class GVG_069a:Ability{
//NAME=维修
//TEXT=+4生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_070:MinionBase{
//NAME=熟练的水手
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=7|HP=4|RACE=PIRATE
}
public class GVG_071:MinionBase{
//NAME=迷失的陆行鸟
//TEXT=
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=BEAST
}
public class GVG_072:MinionBase{
//NAME=暗影打击装甲
//TEXT=每当一个随从获得治疗，便随机对一个敌人造成1点伤害。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=MECHANICAL
}
public class GVG_073:SpellBase{
//NAME=眼镜蛇射击
//TEXT=对一个随从和敌方英雄造成$3点伤害。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class GVG_074:MinionBase{
//NAME=科赞秘术师
//TEXT=<b>战吼：</b>随机夺取一个敌方<b>奥秘</b>的控制权。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=NONE
}
public class GVG_075:MinionBase{
//NAME=船载火炮
//TEXT=在你召唤一个海盗后，随机对一个敌人造成2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
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
        if(tz==ZoneType.Board && (sc.raceType.Contains(RaceType.Pirate)) && owner.GetTag(GameTag.ZoneType) == (int)ZoneType.Board)
        {
        	Player TargetPlayer = owner.myPlayer.otherPlayer;
            new EffectDamage(owner.myPlayer,owner,TargetPlayer.board.Merge(TargetPlayer.hero).Choice(owner.myPlayer.randomGen),2).Resolve();
        }
    }
}
public class GVG_076:MinionBase{
//NAME=自爆绵羊
//TEXT=<b>亡语：</b>对所有随从造成2点伤害。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=MECHANICAL
}
public class GVG_076a:Ability{
//NAME=活塞强化
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_077:MinionBase{
//NAME=心能魔像
//TEXT=在每个回合结束时，如果本随从是你唯一的随从，则消灭 本随从。
//MAJ=WARLOCK|COST=6|ATK=9|HP=9|RACE=MECHANICAL
}
public class GVG_078:MinionBase{
//NAME=机械雪人
//TEXT=<b>亡语：</b>使每个玩家获得一张<b>零件</b>牌。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=MECHANICAL
}
public class GVG_079:MinionBase{
//NAME=强袭坦克
//TEXT=<b>圣盾</b>
//MAJ=NEUTRAL|COST=8|ATK=7|HP=7|RACE=MECHANICAL
}
public class GVG_080:MinionBase{
//NAME=毒牙德鲁伊
//TEXT=<b>战吼：</b>如果你控制任何野兽，将本随从变形成为7/7。
//MAJ=DRUID|COST=5|ATK=4|HP=4|RACE=NONE
}
public class GVG_080t:MinionBase{
//NAME=毒牙德鲁伊
//TEXT=
//MAJ=DRUID|COST=5|ATK=7|HP=7|RACE=BEAST
}
public class GVG_081:MinionBase{
//NAME=海地精猎手
//TEXT=<b>潜行</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class GVG_082:MinionBase{
//NAME=发条侏儒
//TEXT=<b>亡语：</b>将一张<b>零件</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=MECHANICAL
}
public class GVG_083:MinionBase{
//NAME=高级修理机器人
//TEXT=<b>战吼：</b>使一个友方机械获得+4生命值。
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=MECHANICAL
}
public class GVG_084:MinionBase{
//NAME=飞行器
//TEXT=<b>风怒</b>
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=MECHANICAL
}
public class GVG_085:MinionBase{
//NAME=吵吵机器人
//TEXT=<b>嘲讽，圣盾</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=MECHANICAL
}
public class GVG_086:MinionBase{
//NAME=重型攻城战车
//TEXT=每当你获得 护甲值，使本随从获得+1攻击力。
//MAJ=WARRIOR|COST=5|ATK=5|HP=5|RACE=MECHANICAL
}
public class GVG_086e:Ability{
//NAME=重型护甲
//TEXT=攻击力提高。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_087:MinionBase{
//NAME=热砂港狙击手
//TEXT=你的英雄技能能够以随从为目标。
//MAJ=HUNTER|COST=2|ATK=2|HP=3|RACE=NONE
}
public class GVG_088:MinionBase{
//NAME=食人魔忍者
//TEXT=<b>潜行，</b>50%几率攻击错误的敌人。
//MAJ=ROGUE|COST=5|ATK=6|HP=6|RACE=NONE
}
public class GVG_089:MinionBase{
//NAME=明光祭司
//TEXT=如果在你的回合结束时，你控制一个<b>奥秘</b>，则为你的英雄恢复#4点生命值。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class GVG_090:MinionBase{
//NAME=疯狂爆破者
//TEXT=<b>战吼：</b>造成6点伤害，随机分配到所有其他角色身上。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NONE
}
public class GVG_091:MinionBase{
//NAME=施法者克星X-21
//TEXT=<b>嘲讽</b>。<b>扰魔</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=MECHANICAL
}
public class GVG_092:MinionBase{
//NAME=侏儒实验技师
//TEXT=<b>战吼：</b> 抽一张牌，如果该牌是随从牌，则将其变形成为一只小鸡。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=NONE
}
public class GVG_092t:MinionBase{
//NAME=小鸡
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class GVG_093:MinionBase{
//NAME=活动假人
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=2|RACE=MECHANICAL
}
public class GVG_094:MinionBase{
//NAME=基维斯
//TEXT=在每个玩家的回合结束时，该玩家抽若干牌，直至其手牌数量达到3张。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=4|RACE=MECHANICAL
}
public class GVG_095:MinionBase{
//NAME=地精工兵
//TEXT=如果你对手的手牌数量大于或等于6张，便拥有+4攻击力。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class GVG_096:MinionBase{
//NAME=载人收割机
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（2）的随从。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=MECHANICAL
}
public class GVG_097:MinionBase{
//NAME=小个子驱魔者
//TEXT=<b>嘲讽</b>，<b>战吼：</b>每有一个具有<b>亡语</b>的敌方随从，便获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class GVG_098:MinionBase{
//NAME=诺莫瑞根步兵
//TEXT=<b>冲锋，嘲讽</b>
//MAJ=NEUTRAL|COST=3|ATK=1|HP=4|RACE=NONE
}
public class GVG_099:MinionBase{
//NAME=榴弹投手
//TEXT=<b>战吼：</b>随机对一个敌方随从造成4点伤害。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class GVG_100:MinionBase{
//NAME=漂浮观察者
//TEXT=每当你的英雄在你的回合受到伤害，便获得+2/+2。
//MAJ=WARLOCK|COST=5|ATK=4|HP=4|RACE=DEMON
}
public class GVG_100e:Ability{
//NAME=眼纹纵横
//TEXT=属性值提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_101:MinionBase{
//NAME=血色净化者
//TEXT=<b>战吼：</b> 对所有具有<b>亡语</b>的随从造成2点伤害。
//MAJ=PALADIN|COST=3|ATK=4|HP=3|RACE=NONE
}
public class GVG_101e:Ability{
//NAME=纯洁
//TEXT=属性值提高。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_102:MinionBase{
//NAME=工匠镇技师
//TEXT=<b>战吼：</b>如果你控制一个机械，便获得+1/+1并将一张<b>零件</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class GVG_102e:Ability{
//NAME=工匠镇之力
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_103:MinionBase{
//NAME=微型战斗机甲
//TEXT=在每个回合开始时，获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=MECHANICAL
}
public class GVG_104:MinionBase{
//NAME=大胖
//TEXT=每当你使用一张攻击力为1的随从牌，便使其获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class GVG_104a:Ability{
//NAME=大胖的保护
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_105:MinionBase{
//NAME=载人飞天魔像
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗为（4）的随从。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=4|RACE=MECHANICAL
}
public class GVG_106:MinionBase{
//NAME=回收机器人
//TEXT=每当一个友方机械死亡，便获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=1|HP=5|RACE=MECHANICAL
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.myPlayer==owner.myPlayer && sz==ZoneType.Board && tz==ZoneType.Grave)
            {
                if(sc.raceType.Contains(RaceType.Mechanical) || sc.raceType.Contains(RaceType.All))
                {
                    new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:2).Resolve();
                }
            }
        }
    }
}
public class GVG_106_G:MinionBase{
//NAME=回收机器人
//TEXT=每当一个友方机械死亡，便获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=1|HP=5|RACE=MECHANICAL
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
            if(sc.myPlayer==owner.myPlayer && sz==ZoneType.Board && tz==ZoneType.Grave)
            {
                if(sc.raceType.Contains(RaceType.Mechanical) || sc.raceType.Contains(RaceType.All))
                {
                    new EffectChange(owner.myPlayer,owner,owner,atkChange:4,hpChange:4).Resolve();
                }
            }
        }
    }
}
public class GVG_106e:Ability{
//NAME=废品回收
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_107:MinionBase{
//NAME=强化机器人
//TEXT=<b>战吼：</b>随机使你的其他随从分别获得<b>风怒</b>，<b>嘲讽</b>，或者<b>圣盾</b>效果中的一种。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=MECHANICAL
}
public class GVG_108:MinionBase{
//NAME=侏儒变形师
//TEXT=<b>战吼：</b> 将一个友方随从随机变形成为一个法力值消耗相同的随从。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class GVG_109:MinionBase{
//NAME=小个子法师
//TEXT=<b>潜行，法术伤害+1</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=NONE
}
public class GVG_110:MinionBase{
//NAME=砰砰博士
//TEXT=<b>战吼：</b> 召唤两个1/1的砰砰机器人。<i>警告：该机器人随时可能爆炸。</i>
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("GVG_110t"),ZoneType.Board);
        TaskCreate(CardDbf.GetCardDbfByGuid("GVG_110t"),ZoneType.Board);
    }
}
public class GVG_110t:MinionBase{
//NAME=砰砰机器人
//TEXT=<b>亡语：</b>随机对一个敌人造成1-4点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
    public override void Deathrattle()
    {
        List<int> PossibleDmgs = new List<int>(){1,2,3,4};
        TaskDamageRandomEnemy(PossibleDmgs.Choice(owner.myPlayer.randomGen));
    }
}
public class GVG_111:MinionBase{
//NAME=米米尔隆的头部
//TEXT=在你的回合开始时，如果你控制至少三个机械，则消灭这些机械，并将其组合成V-07-TR-0N。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=MECHANICAL
}
public class GVG_111t:MinionBase{
//NAME=V-07-TR-0N
//TEXT=<b>冲锋</b> <b>超级风怒</b>
//MAJ=NEUTRAL|COST=8|ATK=4|HP=8|RACE=MECHANICAL
}
public class GVG_112:MinionBase{
//NAME=食人魔勇士穆戈尔
//TEXT=所有随从有50%几率攻击错误的敌人。
//MAJ=NEUTRAL|COST=6|ATK=7|HP=6|RACE=NONE
}
public class GVG_113:MinionBase{
//NAME=死神4000型
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=9|RACE=MECHANICAL
}
public class GVG_114:MinionBase{
//NAME=斯尼德的伐木机
//TEXT=<b>亡语：</b>随机召唤一个<b>传说</b>随从。
//MAJ=NEUTRAL|COST=8|ATK=5|HP=7|RACE=MECHANICAL
}
public class GVG_115:MinionBase{
//NAME=托什雷
//TEXT=<b>战吼，亡语：</b> 将一张<b>零件</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=7|RACE=NONE
}
public class GVG_116:MinionBase{
//NAME=瑟玛普拉格
//TEXT=每当一个敌方随从死亡，召唤一个 麻风侏儒。
//MAJ=NEUTRAL|COST=9|ATK=9|HP=7|RACE=MECHANICAL
}
public class GVG_117:MinionBase{
//NAME=加兹鲁维
//TEXT=每当你施放一个法力值消耗为（1）的法术，随机将一张机械牌置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=6|RACE=NONE
}
public class GVG_118:MinionBase{
//NAME=颤地者特罗格佐尔
//TEXT=每当你的对手施放一个法术，召唤一个石腭穴居人壮汉。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=6|RACE=NONE
}
public class GVG_119:MinionBase{
//NAME=布林顿3000型
//TEXT=<b>战吼：</b>为每个玩家装备一把武器。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=4|RACE=MECHANICAL
}
public class GVG_120:MinionBase{
//NAME=赫米特·奈辛瓦里
//TEXT=<b>战吼：</b> 消灭一个野兽。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=3|RACE=NONE
}
public class GVG_121:MinionBase{
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
public class GVG_122:MinionBase{
//NAME=小个子扰咒师
//TEXT=相邻的随从拥有<b>扰魔</b>。
//MAJ=MAGE|COST=4|ATK=2|HP=5|RACE=NONE
}
public class GVG_122e:Ability{
//NAME=扰咒
//TEXT=<b>扰魔</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_123:MinionBase{
//NAME=煤烟喷吐装置
//TEXT=<b>法术伤害+1</b> <b>战吼：</b>如果你控制着其他机械，随机获取一张火焰法术牌。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=MECHANICAL
}
public class GVG_123e:Ability{
//NAME=上紧发条
//TEXT=法术伤害+2。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class GVG_COIN:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
