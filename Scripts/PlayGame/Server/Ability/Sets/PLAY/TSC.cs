using System.Collections;
using System.Collections.Generic;

public class TSC_001:MinionBase{
//NAME=海军水雷
//TEXT=<b>亡语：</b>对敌方英雄造成4点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=2|RACE=MECHANICAL
}
public class TSC_002:MinionBase{
//NAME=刺豚拳手
//TEXT=在你的英雄攻击后，对所有敌人造成1点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=PIRATE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,CauseEvent));
    }

    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc.GetTag(GameTag.ZoneType) == (int)ZoneType.Hero && CondInPlay())
        {
            TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),1);
        }
    }
}
public class TSC_006:SpellBase{
//NAME=多重打击
//TEXT=在本回合中使你的英雄获得+2攻击力，并可以额外攻击一次敌方随从。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=FEL
}
public class TSC_006e:Ability{
//NAME=灵魂绑定
//TEXT=在本回合中，+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_006e2:Ability{
//NAME=多重打击效果
//TEXT=+2攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_007:MinionBase{
//NAME=潜水跳板船员
//TEXT=<b>休眠</b>1回合。<b>突袭</b>。攻击时具有<b>免疫</b>。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=4|RACE=PIRATE
}
public class TSC_013:MinionBase{
//NAME=潜水泥鳞鱼人
//TEXT=<b>休眠</b>1回合。<b>突袭</b>，<b>剧毒</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=MURLOC
}
public class TSC_017:MinionBase{
//NAME=巫婆纳迦
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过法术，造成3点伤害。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NAGA
}
public class TSC_020:MinionBase{
//NAME=野蛮的女巫
//TEXT=<b>嘲讽</b>，<b>战吼：</b>交换每个玩家手牌中各一张随机法术牌的法力值消耗。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=7|RACE=NAGA
}
public class TSC_020e:Ability{
//NAME=野蛮暴虐
//TEXT=攻击力已被交换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_020e2:Ability{
//NAME=野蛮暴虐
//TEXT=法力值消耗已被交换。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_023:SpellBase{
//NAME=倒刺捕网
//TEXT=对一个敌人造成$2点伤害。如果你在此牌在你手中时使用过纳迦牌，则再选择一个目标。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TSC_026:MinionBase{
//NAME=可拉克
//TEXT=<b>巨型+1</b> 当你控制可拉克的壳时<b>免疫</b>。
//MAJ=DRUID|COST=7|ATK=6|HP=5|RACE=BEAST
}
public class TSC_026t:MinionBase{
//NAME=可拉克的壳
//TEXT=<b>嘲讽</b>，<b>亡语：</b>获得8点护甲值。
//MAJ=DRUID|COST=5|ATK=0|HP=8|RACE=BEAST
}
public class TSC_029:MinionBase{
//NAME=盖亚，巨力机甲
//TEXT=<b>巨型+2</b> 在一个友方机械攻击后，对所有敌人造成1点伤害。
//MAJ=MAGE|COST=8|ATK=5|HP=7|RACE=MECHANICAL
}
public class TSC_029t:MinionBase{
//NAME=盖亚的钻头
//TEXT=<b>突袭</b>
//MAJ=MAGE|COST=3|ATK=2|HP=3|RACE=MECHANICAL
}
public class TSC_029t2:MinionBase{
//NAME=盖亚的钻头
//TEXT=<b>突袭</b>
//MAJ=MAGE|COST=3|ATK=2|HP=3|RACE=MECHANICAL
}
public class TSC_030:MinionBase{
//NAME=海兽号
//TEXT=<b>巨型+1</b> <b>突袭</b>，<b>圣盾</b>。在本随从攻击后，<b>探底</b>。
//MAJ=PALADIN|COST=7|ATK=4|HP=5|RACE=MECHANICAL
}
public class TSC_030t2:MinionBase{
//NAME=海兽号的探爪
//TEXT=<b>突袭</b>。<b>圣盾</b>。在本随从攻击后，抽一张牌。
//MAJ=PALADIN|COST=3|ATK=4|HP=2|RACE=MECHANICAL
}
public class TSC_032:MinionBase{
//NAME=剑圣奥卡尼
//TEXT=<b>战吼：</b><b>秘密</b>选择一项，当本随从存活时，<b>反制</b>你对手使用的下一张随从牌或法术牌。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=NONE
}
public class TSC_032e3:Ability{
//NAME=拔剑反制
//TEXT=<b>秘密</b>选择，<b>反制</b>你的对手使用的下一张随从或法术牌。0奥卡尼会<b>秘密</b><b>反制</b>你的对手使用的下一张随从牌。0奥卡尼会<b>秘密</b><b>反制</b>你的对手使用的下一张法术牌。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_032t:SpellBase{
//NAME=反制随从
//TEXT=<b>反制</b>你的对手使用的下一张随从牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_032t2:SpellBase{
//NAME=反制法术
//TEXT=<b>反制</b>你的对手使用的下一张法术牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_034:MinionBase{
//NAME=鳄鱼人掠夺者
//TEXT=<b>战吼：</b>抽三张鱼人牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=3|RACE=MURLOC
}
public class TSC_039:MinionBase{
//NAME=艾萨拉的拾荒者
//TEXT=<b>战吼：</b>将一张沉没的拾荒者置于你的牌库底。
//MAJ=WARLOCK|COST=2|ATK=2|HP=3|RACE=MURLOC
}
public class TSC_039t:MinionBase{
//NAME=沉没的拾荒者
//TEXT=<b>战吼：</b>使你的所有其他鱼人获得+1/+1<i>（无论它们在哪）</i>。
//MAJ=WARLOCK|COST=2|ATK=2|HP=3|RACE=MURLOC
}
public class TSC_039te:Ability{
//NAME=姆啦啦咯咯啦
//TEXT=+1/+1
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_052:MinionBase{
//NAME=学校教师
//TEXT=<b>战吼：</b>将一张1/1的纳迦小学生置入你的手牌。<b>发现</b>一个法力值消耗小于或等于（3）点的法术，教会小学生。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=NAGA
}
public class TSC_052t:MinionBase{
//NAME=纳迦小学生
//TEXT=<b>战吼：</b>施放{0}。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NAGA
}
public class TSC_053:MinionBase{
//NAME=虹彩闪鳞纳迦
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NAGA
}
public class TSC_054:MinionBase{
//NAME=机械鲨鱼
//TEXT=在你召唤一个机械后，造成3点伤害，随机分配到所有敌人身上。
//MAJ=MAGE|COST=3|ATK=4|HP=3|RACE=MECHANICAL
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
            TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),3);
        }
    }
}
public class TSC_055:SpellBase{
//NAME=海床传送口
//TEXT=抽一张机械牌。使你手牌中所有机械牌的法力值消耗减少（1）点。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDrawRace(RaceType.Mechanical);
        List<Card> ToBuff = new List<Card>();
        foreach(Card c in owner.myPlayer.hand)
        {
            if(c.raceType.Contains(RaceType.Mechanical))
            {
                ToBuff.Add(c);
            }
        }
        TaskBuffTargets(ToBuff,mana:-1);
    }
}
public class TSC_055e:Ability{
//NAME=机械奇迹
//TEXT=法力值消耗减少（1）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_056:SpellBase{
//NAME=火山术
//TEXT=选择一个随从。当其死亡时，对所有其他随从造成3点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class TSC_056e:Ability{
//NAME=易燃易爆
//TEXT=死亡时，对所有其他随从造成3点伤害。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_057:MinionBase{
//NAME=艾萨拉的背叛者
//TEXT=<b>突袭</b>，<b>亡语：</b>将一张沉没的背叛者置于你的牌库底。
//MAJ=DEMONHUNTER|COST=4|ATK=5|HP=3|RACE=NONE
}
public class TSC_057t:MinionBase{
//NAME=沉没的背叛者
//TEXT=<b>冲锋</b>。在本随从攻击后，随机对一个敌方随从造成5点伤害。
//MAJ=DEMONHUNTER|COST=4|ATK=5|HP=3|RACE=NAGA
}
public class TSC_058:SpellBase{
//NAME=捕掠
//TEXT=造成$2点伤害。如果你在此牌在你手中时使用过纳迦牌，则法力值消耗为（0）点。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=FEL
}
public class TSC_058e:Ability{
//NAME=收获
//TEXT=法力值消耗为（0）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_059:MinionBase{
//NAME=泡泡机器人
//TEXT=<b>战吼：</b> 使你的所有其他机械获得<b>圣盾</b>和<b>嘲讽</b>。
//MAJ=PALADIN|COST=4|ATK=4|HP=4|RACE=MECHANICAL
}
public class TSC_060:MinionBase{
//NAME=闪光翻车鱼
//TEXT=<b>战吼：</b>如果你的手牌中有神圣法术牌，则获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=PALADIN|COST=3|ATK=2|HP=5|RACE=BEAST
}
public class TSC_061:SpellBase{
//NAME=花园惠景
//TEXT=使一个随从获得+4/+4和<b>圣盾</b>。在本局对战中，你每消耗1点法力值用于神圣法术牌上，本牌的法力值消耗便减少（1）点。
//MAJ=PALADIN|COST=10|ATK=0|HP=0|RACE=HOLY
}
public class TSC_061e:Ability{
//NAME=雅致恩典
//TEXT=+4/+4和<b>圣盾</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_064:MinionBase{
//NAME=蛇行死鳞纳迦
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过三个法术，则对所有敌人造成3点伤害。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=NEUTRAL|COST=7|ATK=5|HP=9|RACE=NAGA
}
public class TSC_065:MinionBase{
//NAME=盔中寄居蟹
//TEXT=无法攻击。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=3|RACE=BEAST
}
public class TSC_067:MinionBase{
//NAME=费林大使
//TEXT=<b>战吼：</b>将3张<b>巨型</b>随从牌置于你的牌库底。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class TSC_069:MinionBase{
//NAME=深海融合怪
//TEXT=<b>战吼：</b>选择一个友方随从，<b>发现</b>一张相同类型的随从牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=ALL
}
public class TSC_070:WeaponBase{
//NAME=鱼叉炮
//TEXT=在你的英雄攻击后，<b>探底</b>。如果选中的是野兽牌，使其法力值消耗减少（2）点。
//MAJ=HUNTER|COST=3|ATK=3|HP=2|RACE=NONE
}
public class TSC_071:MinionBase{
//NAME=双弓积骇纳迦
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过法术，你的下一个法术会施放两次。
//MAJ=HUNTER|COST=4|ATK=4|HP=4|RACE=NAGA
}
public class TSC_071e:Ability{
//NAME=双持
//TEXT=你的下一个法术会施放两次。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_071e2:Ability{
//NAME=双发
//TEXT=你的下一个法术会施放两次。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_072:SpellBase{
//NAME=螺号召唤
//TEXT=抽一张纳迦牌和一张法术牌。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskDrawRace(RaceType.Naga);
        TaskDrawType(CardType.Spell);
    }
}
public class TSC_073:MinionBase{
//NAME=拉伊·纳兹亚
//TEXT=在你施放一个法术后，对敌方英雄造成等同于其法力值消耗的 伤害。
//MAJ=HUNTER|COST=2|ATK=2|HP=3|RACE=NAGA
}
public class TSC_074:MinionBase{
//NAME=克托里·光刃
//TEXT=在你对本随从施放一个神圣法术后，再次对另一个友方随从施放该法术。
//MAJ=PALADIN|COST=2|ATK=2|HP=3|RACE=NONE
}
public class TSC_076:SpellBase{
//NAME=永存石中
//TEXT=召唤具有<b>嘲讽</b>的1/2，2/4，4/8的元素各一个。
//MAJ=PALADIN|COST=7|ATK=0|HP=0|RACE=HOLY
}
public class TSC_076t:MinionBase{
//NAME=残损的雕像
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=1|ATK=1|HP=2|RACE=ELEMENTAL
}
public class TSC_076t2:MinionBase{
//NAME=生动的雕像
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=3|ATK=2|HP=4|RACE=ELEMENTAL
}
public class TSC_076t3:MinionBase{
//NAME=光鲜的雕像
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=5|ATK=4|HP=8|RACE=ELEMENTAL
}
public class TSC_079:SpellBase{
//NAME=雷达探测
//TEXT=扫描你牌库底的5张牌。抽取探测到的机械牌，然后洗混你的牌库。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TSC_083:MinionBase{
//NAME=海床救生员
//TEXT=<b>战吼：</b><b>探底</b>。如果选中的是随从牌，使其获得本随从的攻击力和生命值。
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=MECHANICAL
}
public class TSC_083e:Ability{
//NAME=灯光
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_085:MinionBase{
//NAME=携刃信使
//TEXT=在你的英雄攻击后，抽一张海盗牌。
//MAJ=ROGUE|COST=3|ATK=2|HP=5|RACE=PIRATE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,CauseEvent));
    }

    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc.GetTag(GameTag.ZoneType) == (int)ZoneType.Hero && CondInPlay())
        {
            TaskDrawRace(RaceType.Pirate);
        }
    }
}
public class TSC_086:WeaponBase{
//NAME=剑鱼
//TEXT=<b>战吼：</b><b>探底</b>。如果选中的是海盗牌，使这把武器和该海盗获得+2攻击力。
//MAJ=ROGUE|COST=3|ATK=2|HP=3|RACE=NONE
}
public class TSC_086e:Ability{
//NAME=尖头
//TEXT=+2攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_087:MinionBase{
//NAME=指挥官西瓦拉
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过三个法术，则将那些法术置回你的手牌。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=MAGE|COST=4|ATK=3|HP=5|RACE=NAGA
}
public class TSC_209:SpellBase{
//NAME=湍流旋涡
//TEXT=消灭所有随从及其所有的复制<i>（无论它们在哪）</i>。
//MAJ=PRIEST|COST=8|ATK=0|HP=0|RACE=NATURE
}
public class TSC_210:SpellBase{
//NAME=金光闪耀
//TEXT=<b>探底</b>。 如果选中的是法术牌，使其法力值消耗减少（3）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=HOLY
}
public class TSC_211:SpellBase{
//NAME=深海低语
//TEXT=<b>沉默</b>一个友方随从，然后造成等同于其攻击力的伤害，随机分配到所有敌方随从身上。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class TSC_212:MinionBase{
//NAME=侍女
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过三个法术，抽三张牌。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=PRIEST|COST=3|ATK=3|HP=2|RACE=NAGA
}
public class TSC_213:MinionBase{
//NAME=女王护卫
//TEXT=<b>战吼：</b>在本回合中你每施放过一个法术，获得+1/+1。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=NAGA
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,owner,atkChange:3,hpChange:3).Resolve();
    }
}
public class TSC_213e:Ability{
//NAME=潮汐感召
//TEXT=属性值提高。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_215:SpellBase{
//NAME=毒蛇假发
//TEXT=使一个随从获得+1/+2。如果你在此牌在你手中时使用过纳迦牌，将一张毒蛇假发置入你的手牌。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TSC_215e:Ability{
//NAME=假蛇假发
//TEXT=+1/+2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_216:MinionBase{
//NAME=黑水巨鳗
//TEXT=<b>巨型+1</b> <b>吸血</b>
//MAJ=PRIEST|COST=7|ATK=8|HP=10|RACE=BEAST
}
public class TSC_216t:MinionBase{
//NAME=巨鳗的诱饵
//TEXT=在你的回合结束时，随机迫使一个敌方随从攻击黑水巨鳗。
//MAJ=PRIEST|COST=2|ATK=1|HP=4|RACE=BEAST
}
public class TSC_217:MinionBase{
//NAME=游荡贤者
//TEXT=<b>流放：</b>使你最左边和最右边的手牌法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=2|ATK=2|HP=2|RACE=NAGA
}
public class TSC_217e:Ability{
//NAME=游入歧途
//TEXT=法力值消耗减少（1）点。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_218:MinionBase{
//NAME=赛丝诺女士
//TEXT=攻击时<b>免疫</b>。在你施放一个法术后，攻击生命值最低的敌人。
//MAJ=DEMONHUNTER|COST=3|ATK=1|HP=4|RACE=NAGA
}
public class TSC_219:MinionBase{
//NAME=渊狱魔犬希拉格
//TEXT=<b>巨型+4</b> 在你的回合开始时，希拉格的蔓足造成的伤害提高1点。
//MAJ=DEMONHUNTER|COST=7|ATK=3|HP=6|RACE=DEMON
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,this.CauseEvent));
    }
    public override void Battlecry(Card target=null)
    {
        int Index = owner.myPlayer.board.IndexOf(owner);
        TaskCreate(CardDbf.GetCardDbfByGuid("TSC_219t"),ZoneType.Board,pos:Index);
        TaskCreate(CardDbf.GetCardDbfByGuid("TSC_219t2"),ZoneType.Board,pos:Index);
        TaskCreate(CardDbf.GetCardDbfByGuid("TSC_219t3"),ZoneType.Board);
        TaskCreate(CardDbf.GetCardDbfByGuid("TSC_219t4"),ZoneType.Board);
    }
    public void CauseEvent()
    {
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.cardDbf.m_noteMiniGuid.Contains("TSC_219t"))
            {
                if(c.abilityList.Count>0)
                {
                    c.abilityList[0].amounts[2]+=1;
                }
            }
        }
    }
}
public class TSC_219e:Ability{
//NAME=魔眼激光改造
//TEXT=伤害提高。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_219t:MinionBase{
//NAME=希拉格的蔓足
//TEXT=在你的回合结束时，随机对一个敌人造成2点伤害。
//MAJ=DEMONHUNTER|COST=2|ATK=1|HP=2|RACE=DEMON
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
            TaskDamageRandomEnemy(this.amounts[2]);
    }
}
public class TSC_219t2:MinionBase{
//NAME=希拉格的蔓足
//TEXT=在你的回合结束时，随机对一个敌人造成2点伤害。
//MAJ=DEMONHUNTER|COST=2|ATK=1|HP=2|RACE=DEMON
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
            TaskDamageRandomEnemy(this.amounts[2]);
    }
}
public class TSC_219t3:MinionBase{
//NAME=希拉格的蔓足
//TEXT=在你的回合结束时，随机对一个敌人造成2点伤害。
//MAJ=DEMONHUNTER|COST=2|ATK=1|HP=2|RACE=DEMON
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
            TaskDamageRandomEnemy(this.amounts[2]);
    }
}
public class TSC_219t4:MinionBase{
//NAME=希拉格的蔓足
//TEXT=在你的回合结束时，随机对一个敌人造成2点伤害。
//MAJ=DEMONHUNTER|COST=2|ATK=1|HP=2|RACE=DEMON
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
            TaskDamageRandomEnemy(this.amounts[2]);
    }
}
public class TSC_608:SpellBase{
//NAME=无底海渊
//TEXT=抽取你法力值消耗最低的两张随从牌。
//MAJ=DEMONHUNTER|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class TSC_609:MinionBase{
//NAME=库斯卡指挥官
//TEXT=<b>嘲讽</b>。<b>战吼：</b>如果你在此牌在你手中时施放过三个法术，召唤本随从的两个复制。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=DEMONHUNTER|COST=6|ATK=3|HP=7|RACE=NAGA
}
public class TSC_610:MinionBase{
//NAME=刃鲨
//TEXT=<b>战吼：</b>在本回合中，如果你的英雄进行过攻击，对所有敌人造成2点伤害。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=3|RACE=BEAST
}
public class TSC_614:MinionBase{
//NAME=虚鳃鱼人
//TEXT=<b>亡语：</b>使你手牌中的所有鱼人牌获得+1/+1。
//MAJ=WARLOCK|COST=2|ATK=3|HP=2|RACE=MURLOC
}
public class TSC_614e:Ability{
//NAME=虚空注能
//TEXT=+1/+1
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_620:MinionBase{
//NAME=恶鞭海妖
//TEXT=在你使用一张纳迦牌后，复原两个法力水晶。<i>（然后切换至法术牌！）</i>2在你使用一张法术牌后，复原两个法力水晶。<i>（然后切换至纳迦牌！）</i>
//MAJ=MAGE|COST=4|ATK=2|HP=5|RACE=NAGA
}
public class TSC_630:MinionBase{
//NAME=怒脊附魔师
//TEXT=<b>战吼：</b>施放你手牌中火焰，冰霜和自然法术各一张的复制<i>（目标随机而定）</i>。
//MAJ=SHAMAN|COST=7|ATK=5|HP=4|RACE=NAGA
}
public class TSC_631:SpellBase{
//NAME=鱼群聚集
//TEXT=将三张1/1的食人鱼集群置入你的手牌。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TSC_632:MinionBase{
//NAME=械钳虾
//TEXT=<b>圣盾</b>，<b>战吼：</b>随机使你手牌中的一张机械牌获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("DivineShield");
    }
    public override void Battlecry(Card target=null)
    {
        List<Card> BuffPool = new List<Card>();
        foreach(Card c in owner.myPlayer.hand)
        {
            if(c.raceType.Contains(RaceType.Mechanical))
            {
                BuffPool.Add(c);
            }
        }
        Card ToBuff = BuffPool.Choice(owner.myPlayer.randomGen);
        if(ToBuff!=null)
        {
            new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:1,hpChange:1).Resolve();
        }
    }
}
public class TSC_632e:Ability{
//NAME=机械爪
//TEXT=+1/+1
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_633:MinionBase{
//NAME=食人鱼偷猎者
//TEXT=在你的回合结束时，将一张1/1的食人鱼集群置入你的手牌。
//MAJ=SHAMAN|COST=3|ATK=2|HP=5|RACE=MURLOC
}
public class TSC_635:MinionBase{
//NAME=艾萨拉之辉
//TEXT=<b>火焰法术伤害+2</b>。你的自然法术法力值消耗降低（1）点。在你施放一个冰霜法术后，获得3点护甲值。
//MAJ=SHAMAN|COST=3|ATK=3|HP=4|RACE=ELEMENTAL
}
public class TSC_635e:Ability{
//NAME=卡多雷的强劲
//TEXT=法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_637:SpellBase{
//NAME=间歇热泉
//TEXT=造成$2点伤害。<b>探底</b>。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=FIRE
}
public class TSC_638:MinionBase{
//NAME=食人鱼集群
//TEXT=<b>突袭</b> 在你召唤一个食人鱼集群后，获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TSC_638e:Ability{
//NAME=群拥
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_638t:MinionBase{
//NAME=食人鱼集群
//TEXT=<b>突袭</b> 在你召唤一个食人鱼集群后，获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TSC_638t2:MinionBase{
//NAME=食人鱼集群
//TEXT=<b>突袭</b> 在你召唤一个食人鱼集群后，获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TSC_638t3:MinionBase{
//NAME=食人鱼集群
//TEXT=<b>突袭</b> 在你召唤一个食人鱼集群后，获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TSC_638t4:MinionBase{
//NAME=食人鱼集群
//TEXT=<b>突袭</b> 在你召唤一个食人鱼集群后，获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TSC_639:MinionBase{
//NAME=暴食巨鳗格拉格
//TEXT=<b>巨型+3</b> 在一个友方随从死亡后，获得其原始属性值。
//MAJ=SHAMAN|COST=7|ATK=3|HP=5|RACE=BEAST
}
public class TSC_639e:Ability{
//NAME=饱食
//TEXT=属性值提高。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_639e2:Ability{
//NAME=Gulped
//TEXT=Increased stats.
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_639t:MinionBase{
//NAME=格拉格的尾巴
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class TSC_639t2:MinionBase{
//NAME=格拉格的尾巴
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class TSC_639t3:MinionBase{
//NAME=格拉格的尾巴
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class TSC_640:MinionBase{
//NAME=堡礁行者
//TEXT=<b>战吼，亡语：</b>召唤一个1/1的食人鱼集群。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=ELEMENTAL
}
public class TSC_641:MinionBase{
//NAME=艾萨拉女王
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过三个法术，选择一项远古圣物。@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class TSC_641ta:SpellBase{
//NAME=潮汐之戒
//TEXT=在你施放一个法术后，变形成为该法术的法力值消耗为（1）点的复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_641tae:Ability{
//NAME=变幻
//TEXT=变形成为你的法术。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_641tb:SpellBase{
//NAME=上古号角
//TEXT=随机将一张<b>巨型</b>随从置入你的手牌，其法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=0|RACE=NONE
}
public class TSC_641tc:WeaponBase{
//NAME=萨拉塔斯
//TEXT=在你施放一个法术后，对敌方英雄造成2点伤害，失去1点耐久度。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=5|RACE=NONE
}
public class TSC_641td:SpellBase{
//NAME=高戈奈斯潮汐之石
//TEXT=随机将5张法术牌洗入你的牌库，其法力值消耗变为（1）点。抽两张牌。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TSC_641tde:Ability{
//NAME=降低
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_642:MinionBase{
//NAME=海沟勘测机
//TEXT=<b>战吼：</b><b>探底</b>。如果选中的是机械牌，抽取这张牌。
//MAJ=MAGE|COST=1|ATK=2|HP=1|RACE=MECHANICAL
    public override void Battlecry(Card target=null)
    {
        TaskDrawRace(RaceType.Mechanical);
    }
}
public class TSC_643:MinionBase{
//NAME=法术卷积者
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过法术，<b>发现</b>一张法术牌。
//MAJ=MAGE|COST=2|ATK=2|HP=3|RACE=NAGA
}
public class TSC_644:MinionBase{
//NAME=艾萨拉的观月仪
//TEXT=<b>圣盾</b>，<b>战吼：</b>将一张沉没的观月仪置于你的牌库底。
//MAJ=PALADIN|COST=3|ATK=4|HP=2|RACE=MECHANICAL
}
public class TSC_644t:MinionBase{
//NAME=沉没的观月仪
//TEXT=<b>圣盾</b>，<b>战吼：</b>召唤一个本随从的复制。
//MAJ=PALADIN|COST=3|ATK=4|HP=2|RACE=MECHANICAL
}
public class TSC_645:MinionBase{
//NAME=母舰
//TEXT=<b>突袭</b>，<b>亡语：</b>随机召唤两个法力值消耗小于或等于（3）点的机械。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=4|RACE=MECHANICAL
}
public class TSC_646:MinionBase{
//NAME=海底侦察兵
//TEXT=<b>战吼：</b>如果你控制任何机械，则召唤两条2/1的机械鱼。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class TSC_646t:MinionBase{
//NAME=机械鱼
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=MECHANICAL
}
public class TSC_647:MinionBase{
//NAME=潜水俯冲鹈鹕
//TEXT=<b>休眠</b>1回合。 <b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=4|HP=1|RACE=BEAST
}
public class TSC_647e:Ability{
//NAME=跳水
//TEXT=<b>休眠</b>。 1回合后唤醒。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_648:MinionBase{
//NAME=珊瑚培育师
//TEXT=<b>战吼：</b>在本局对战中，你每施放过一个派系的法术，召唤一个3/3的元素。
//MAJ=SHAMAN|COST=5|ATK=3|HP=4|RACE=NAGA
}
public class TSC_648t:MinionBase{
//NAME=珊瑚元素
//TEXT=
//MAJ=SHAMAN|COST=3|ATK=3|HP=3|RACE=ELEMENTAL
}
public class TSC_649:MinionBase{
//NAME=伊妮·积雷
//TEXT=<b>战吼：</b>选择一个友方机械，召唤一个它的具有<b>突袭</b>，<b>风怒</b>和<b>圣盾</b>的复制。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=NONE
}
public class TSC_649e2:Ability{
//NAME=改进强化！
//TEXT=获得<b>突袭</b>，<b>圣盾</b>和<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_650:SpellBase{
//NAME=划水好友
//TEXT=<b>抉择：</b>召唤一只6/6并具有<b>嘲讽</b>的虎鲸；或者六只1/1并具有<b>突袭</b>的海獭。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class TSC_650a:SpellBase{
//NAME=号令虎鲸
//TEXT=召唤一只6/6并具有<b>嘲讽</b>的虎鲸。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class TSC_650d:SpellBase{
//NAME=海獭欢游
//TEXT=召唤六只1/1并具有<b>突袭</b>的海獭。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class TSC_650t:MinionBase{
//NAME=虎鲸
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=6|ATK=6|HP=6|RACE=BEAST
}
public class TSC_650t4:MinionBase{
//NAME=海獭
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TSC_651:SpellBase{
//NAME=海草卷击
//TEXT=对一个随从造成$4点伤害。如果你在此牌在你手中时使用过纳迦牌，使你的英雄在本回合中获得+4攻击力。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class TSC_651e:Ability{
//NAME=爆发生长
//TEXT=在本回合中+4攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_652:MinionBase{
//NAME=妙手园丁
//TEXT=<b>战吼：</b>复原空的法力水晶，数量等同于你手牌中法力值消耗最高的法术牌的法力值。
//MAJ=DRUID|COST=6|ATK=5|HP=5|RACE=NAGA
}
public class TSC_653:MinionBase{
//NAME=底层掠食鱼
//TEXT=<b>亡语：</b>将一张永久具有+2/+2的底层掠食鱼置入你的牌库底。
//MAJ=DRUID|COST=1|ATK=1|HP=3|RACE=BEAST
}
public class TSC_654:SpellBase{
//NAME=水栖形态
//TEXT=<b>探底</b>。如果你在本回合中有足够的法力值使用选中的牌，则抽取这张牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_656:SpellBase{
//NAME=奇迹生长
//TEXT=抽三张牌。召唤一个属性值等同于你的手牌数量并具有<b>嘲讽</b>的植物。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class TSC_656t:MinionBase{
//NAME=海藻爬行者
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=NONE
}
public class TSC_657:MinionBase{
//NAME=嗜睡的藻农
//TEXT=<b>突袭</b>，起始<b>休眠</b>状态。在你施放消耗总计5点法力值的法术后唤醒。
//MAJ=DRUID|COST=1|ATK=4|HP=4|RACE=NAGA
}
public class TSC_657e:Ability{
//NAME=水中安睡
//TEXT=<b>休眠</b>。在你施放消耗总计5点法力值的法术后唤醒。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_658:MinionBase{
//NAME=异端纳迦海德拉
//TEXT=<b>战吼：</b>你在此牌在你手中时每施放过一个法术，便召唤一个法力值消耗等同于该法术的随从。
//MAJ=DRUID|COST=7|ATK=4|HP=5|RACE=NAGA
}
public class TSC_659:MinionBase{
//NAME=海沟追猎者
//TEXT=<b>战吼：</b>随机攻击三个不同的敌人。
//MAJ=WARRIOR|COST=9|ATK=8|HP=9|RACE=BEAST
}
public class TSC_660:MinionBase{
//NAME=奈利，超巨蛇颈龙
//TEXT=<b>巨型+1</b> <b>战吼：</b><b>发现</b>三个海盗来构成奈利的船员团队！
//MAJ=WARRIOR|COST=7|ATK=5|HP=5|RACE=BEAST
}
public class TSC_660e:Ability{
//NAME=佣金
//TEXT=法力值消耗为（1）点。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_660e2:Ability{
//NAME=海盗船员
//TEXT=承载奈利的海盗船员。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_660t:MinionBase{
//NAME=奈利的海盗船
//TEXT=<b>嘲讽</b>，<b>亡语：</b>将奈利的船员团队置入你的手牌。他们的法力值消耗为（1）点。
//MAJ=WARRIOR|COST=5|ATK=2|HP=6|RACE=BEAST
}
public class TSC_702:SpellBase{
//NAME=体型互换
//TEXT=抽两张随从牌，交换其生命值。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=NONE
}
public class TSC_702e:Ability{
//NAME=互换体型
//TEXT=已交换生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_753:MinionBase{
//NAME=血腥恶鳍鱼人
//TEXT=<b>战吼：</b><b>探底</b>。如果选中的是鱼人牌，则使其改为消耗生命值，而非法力值。
//MAJ=WARLOCK|COST=3|ATK=3|HP=4|RACE=MURLOC
}
public class TSC_753e:Ability{
//NAME=新鲜气息
//TEXT=消耗生命值，而非法力值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_772:SpellBase{
//NAME=艾萨拉的卷轴
//TEXT=<b>发现</b>一张火焰，冰霜或自然法术牌。将一张沉没的卷轴置于你的牌库底。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TSC_772t:SpellBase{
//NAME=沉没的卷轴
//TEXT=将你职业的火焰，冰霜和自然法术各一张置入你的手牌。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TSC_775:SpellBase{
//NAME=艾萨拉的祭仪
//TEXT=<b>沉默</b>一个随从，并召唤一个它的复制。将一张沉没的祭仪置于你的牌库底。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TSC_775t:SpellBase{
//NAME=沉没的祭仪
//TEXT=<b>沉默</b>一个随从，并召唤两个它的复制。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TSC_776:MinionBase{
//NAME=艾萨拉的清道夫
//TEXT=<b>战吼：</b>将一张沉没的清道夫置于你的牌库底。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=MECHANICAL
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("TSC_776t"),ZoneType.Deck);
    }
}
public class TSC_776t:MinionBase{
//NAME=沉没的清道夫
//TEXT=<b>战吼：</b>随机将3张机械牌置入你的手牌，其法力值消耗减少（1）点。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=MECHANICAL
    public override void Battlecry(Card target=null)
    {
        for(int i=0;i<3;i++)
        {
            Card ToSummon = TaskCreate(CardDbf.GetCardDbfByGuid("TSC_776"),ZoneType.Hand);
            new EffectChange(owner.myPlayer,owner,ToSummon,manaChange:-1).Resolve();
        }
    }
}
public class TSC_777t0:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t1:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t10:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t11:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t12:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t13:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t14:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t15:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t16:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t17:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t18:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t19:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t2:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t20:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t21:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t22:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t23:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t24:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t25:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t26:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t27:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t28:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t29:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t3:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t30:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t4:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t5:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t6:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t7:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t8:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_777t9:MinionBase{
//NAME=？？？
//TEXT=<b>？？？</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=1|RACE=NONE
}
public class TSC_823:MinionBase{
//NAME=暗水记录员
//TEXT=<b>战吼：</b>你使用的下一张法术牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NAGA
}
public class TSC_823e:Ability{
//NAME=晦暗
//TEXT=你的下一张法术牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_826:MinionBase{
//NAME=重钳执行者
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过法术，抽一张纳迦牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NAGA
}
public class TSC_827:MinionBase{
//NAME=凶恶的滑矛纳迦
//TEXT=在你施放一个法术后，直到你的下个回合，获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=NAGA
}
public class TSC_827e:Ability{
//NAME=凶恶
//TEXT=直到你的下个回合，获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_828:MinionBase{
//NAME=女祭司瓦丽丝琪
//TEXT=<b>战吼：</b>在本回合中你每施放过一个法术，复原一个空的法力水晶。0<i>（复原0个）</i>
//MAJ=PRIEST|COST=1|ATK=1|HP=1|RACE=NAGA
}
public class TSC_829:MinionBase{
//NAME=纳迦巨人
//TEXT=在本局对战中，你每消耗1点法力值用于法术牌上，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=20|ATK=8|HP=8|RACE=NAGA
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            return -owner.myPlayer.GetTag(GameTag.CntManaUsedOnSpell);
        }
        return 0;
    }
}
public class TSC_908:MinionBase{
//NAME=海中向导芬利爵士
//TEXT=<b>战吼：</b>将你的手牌和牌库底的牌交换。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=MURLOC
    public override void Battlecry(Card target=null)
    {
        List<Card> InHand = new List<Card>();
        List<Card> InDeck = new List<Card>();
        foreach(Card c in owner.myPlayer.hand)
        {
            InHand.Add(c);
        }
        for(int i=owner.myPlayer.deck.Count-1;i>=0;i--)
        {
            if(InHand.Count<=InDeck.Count)
            {
                break;
            }
            InDeck.Add(owner.myPlayer.deck[i]);
        }
        for(int i = 0;i<InHand.Count;i++)
        {
            new EffectMove(owner.myPlayer,InHand[i],ZoneType.Hand,ZoneType.Deck).Resolve();
            new EffectMove(owner.myPlayer,InDeck[i],ZoneType.Deck,ZoneType.Hand).Resolve();
        }
    }
}
public class TSC_909:MinionBase{
//NAME=拖网海象人
//TEXT=<b>战吼：</b><b>探底</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=PIRATE
}
public class TSC_911:MinionBase{
//NAME=挖掘专家
//TEXT=<b>战吼：</b><b>探底</b>。选中的牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=NONE
}
public class TSC_912:SpellBase{
//NAME=艾萨拉的舰船
//TEXT=召唤两个3/3并具有<b>潜行</b>的海盗。将一张沉没的舰船置于你的牌库底。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class TSC_912t:SpellBase{
//NAME=沉没的舰船
//TEXT=<b>抽到时施放</b> 召唤两个3/3并具有<b>潜行</b>的海盗。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class TSC_912t2:MinionBase{
//NAME=沉没的海盗
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=PIRATE
}
public class TSC_912t3:MinionBase{
//NAME=艾萨拉的海盗
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=3|ATK=3|HP=3|RACE=PIRATE
}
public class TSC_913:WeaponBase{
//NAME=艾萨拉的三叉戟
//TEXT=<b>亡语：</b>将一张沉没的三叉戟置于你的牌库底。
//MAJ=WARRIOR|COST=3|ATK=3|HP=2|RACE=NONE
}
public class TSC_913t:WeaponBase{
//NAME=沉没的三叉戟
//TEXT=在你的英雄攻击后，对所有敌方随从造成2点伤害。
//MAJ=WARRIOR|COST=3|ATK=3|HP=2|RACE=NONE
}
public class TSC_915:WeaponBase{
//NAME=骸骨战刃
//TEXT=<b>战吼：</b><b>探底</b>。
//MAJ=DEMONHUNTER|COST=5|ATK=5|HP=2|RACE=NONE
}
public class TSC_916:SpellBase{
//NAME=垂钓时光
//TEXT=<b>探底</b>。<b>连击：</b>抽一张牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TSC_917:MinionBase{
//NAME=黑鳞蛮兵
//TEXT=<b>嘲讽</b>，<b>战吼：</b>如果你装备着武器，召唤一个5/6并具有<b>突袭</b>的纳迦。
//MAJ=WARRIOR|COST=7|ATK=5|HP=6|RACE=NAGA
}
public class TSC_917t:MinionBase{
//NAME=火鳞狂战士
//TEXT=<b>突袭</b>
//MAJ=WARRIOR|COST=7|ATK=5|HP=6|RACE=NAGA
}
public class TSC_919:MinionBase{
//NAME=艾萨拉的哨兵
//TEXT=<b>嘲讽</b>，<b>亡语：</b>将一张沉没的哨兵置于你的牌库底。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=6|RACE=NONE
}
public class TSC_919t:MinionBase{
//NAME=沉没的哨兵
//TEXT=<b>圣盾</b>，<b>嘲讽</b>，<b>吸血</b>
//MAJ=NEUTRAL|COST=5|ATK=5|HP=6|RACE=NONE
}
public class TSC_922:MinionBase{
//NAME=驻锚图腾
//TEXT=在你召唤一个法力值消耗为（1）的随从后，使其获得+2/+1。
//MAJ=SHAMAN|COST=2|ATK=0|HP=3|RACE=TOTEM
	public override void RegisterEventEffect()
	{
		base.RegisterEventEffect();
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(tz==ZoneType.Board && owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && sc.GetTag(GameTag.Mana)==1)
		{
			new EffectChange(owner.myPlayer,owner,sc,0,2,1).Resolve();
		}
	}
}
public class TSC_922e:Ability{
//NAME=谁主沉浮
//TEXT=+2/+1
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_923:SpellBase{
//NAME=生物荧光
//TEXT=使你的随从获得<b>法术伤害+1</b>。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class TSC_923e:Ability{
//NAME=荧光
//TEXT=<b>法术伤害+1</b>
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_924:SpellBase{
//NAME=深渊波流
//TEXT=对所有随从造成$4点伤害。使你的对手获得一张深渊诅咒。
//MAJ=WARLOCK|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class TSC_925:SpellBase{
//NAME=岩石海底
//TEXT=召唤一个1/1的鱼人，然后<b>探底</b>。如果选中的是鱼人牌，则再召唤一个。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TSC_925t:MinionBase{
//NAME=寒光潜伏者
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class TSC_926:MinionBase{
//NAME=掩息海星
//TEXT=<b>战吼：</b><b>沉默</b>所有其他随从。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class TSC_927:SpellBase{
//NAME=艾萨拉的花园
//TEXT=使你手牌中的所有随从牌获得+1/+1。将一张沉没的花园置于你的牌库底。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TSC_927e:Ability{
//NAME=水润
//TEXT=+1/+1
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_927t:SpellBase{
//NAME=沉没的花园
//TEXT=使你手牌，牌库和战场上的所有随从获得+1/+1。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TSC_928:MinionBase{
//NAME=安保自动机
//TEXT=在你召唤一个机械后，获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=MECHANICAL
}
public class TSC_928e:Ability{
//NAME=上紧发条
//TEXT=+1/+1
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_929:SecretBase{
//NAME=紧急机动
//TEXT=<b>奥秘：</b>当一个友方随从死亡时，召唤一个它的复制。复制会<b>休眠</b>1回合。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TSC_929t:SecretBase{
//NAME=强化紧急机动
//TEXT=<b>奥秘：</b>当一个友方随从死亡时，召唤两个它的复制。复制会<b>休眠</b>1回合。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TSC_932:SpellBase{
//NAME=血染大海
//TEXT=对一个敌人造成$3点伤害。召唤一条5/5并具有<b>突袭</b>的鲨鱼。
//MAJ=ROGUE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class TSC_932t:MinionBase{
//NAME=虎鲨
//TEXT=<b>突袭</b>
//MAJ=ROGUE|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class TSC_933:MinionBase{
//NAME=镣铐水鬼
//TEXT=<b>连击：</b>将一个敌方随从置于你对手的牌库底。
//MAJ=ROGUE|COST=5|ATK=4|HP=4|RACE=PIRATE
}
public class TSC_934:MinionBase{
//NAME=海盗将领钩牙
//TEXT=<b>战吼：</b>在本局对战中，如果你召唤过7个其他海盗，即可劫掠敌人！@<i>（还剩{0}个！）</i>@<i>（已经就绪！）</i>
//MAJ=ROGUE|COST=7|ATK=7|HP=7|RACE=PIRATE
}
public class TSC_934t:SpellBase{
//NAME=带走补给！
//TEXT=夺取你对手牌库中的5张牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_934t2:SpellBase{
//NAME=带走财物！
//TEXT=夺取你对手的2张手牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_934t3:SpellBase{
//NAME=带走船只！
//TEXT=夺取你对手攻击力最高的随从的控制权。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_935:MinionBase{
//NAME=自私的扇贝
//TEXT=<b>亡语：</b>你的对手抽两张牌。
//MAJ=NEUTRAL|COST=4|ATK=7|HP=7|RACE=BEAST
    public override void Deathrattle()
    {
        new EffectDraw(owner.myPlayer.otherPlayer).Resolve();
        new EffectDraw(owner.myPlayer.otherPlayer).Resolve();
    }
}
public class TSC_936:MinionBase{
//NAME=迅鳞欺诈者
//TEXT=<b>战吼：</b>在本回合中，你的下一张法术牌法力值消耗为（0）点。
//MAJ=ROGUE|COST=4|ATK=2|HP=2|RACE=NAGA
}
public class TSC_936e:Ability{
//NAME=愚弄观众
//TEXT=在本回合中，你的下一张法术牌法力值消耗为（0）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_937:MinionBase{
//NAME=可拉巴托亚
//TEXT=<b>巨型+2</b> 你的可拉巴托亚的钳子拥有+2攻击力。
//MAJ=ROGUE|COST=6|ATK=6|HP=5|RACE=BEAST
}
public class TSC_937e:Ability{
//NAME=甲壳珍宝
//TEXT=+2攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_937t:MinionBase{
//NAME=可拉巴托亚的蟹钳
//TEXT=<b>突袭</b>，<b>亡语：</b>装备一把2/1的蟹钳。
//MAJ=ROGUE|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class TSC_937t2:WeaponBase{
//NAME=可拉巴托亚之钳
//TEXT=
//MAJ=ROGUE|COST=1|ATK=2|HP=1|RACE=NONE
}
public class TSC_937t3:MinionBase{
//NAME=可拉巴托亚的蟹钳
//TEXT=<b>突袭</b>，<b>亡语：</b>装备一把2/1的蟹钳。
//MAJ=ROGUE|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class TSC_938:MinionBase{
//NAME=宝藏守卫
//TEXT=<b>嘲讽</b>，<b>亡语：</b>抽一张牌。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NAGA
}
public class TSC_939:SpellBase{
//NAME=火焰熔铸
//TEXT=摧毁你的武器，然后抽数量等同于其攻击力的牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class TSC_940:SpellBase{
//NAME=深海来客
//TEXT=使你牌库底五张牌的法力值消耗减少（3）点，然后<b>探底</b>。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class TSC_940e2:Ability{
//NAME=暗流汇聚
//TEXT=法力值消耗减少（3）点。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_941:SpellBase{
//NAME=保卫城市
//TEXT=获得3点护甲值。召唤一个2/3并具有<b>嘲讽</b>的纳迦。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TSC_941t:MinionBase{
//NAME=六足纳迦
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=2|ATK=2|HP=3|RACE=NAGA
}
public class TSC_942:MinionBase{
//NAME=黑曜石铸匠
//TEXT=<b>战吼：</b><b>探底</b>。如果选中的是随从牌或武器牌，则使其获得+1/+1。
//MAJ=WARRIOR|COST=2|ATK=3|HP=2|RACE=PIRATE
}
public class TSC_942e:Ability{
//NAME=火焰铸炼
//TEXT=+1/+1
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_943:MinionBase{
//NAME=艾什凡女勋爵
//TEXT=<b>战吼：</b>使你手牌，牌库和战场上的所有武器获得+1/+1。
//MAJ=WARRIOR|COST=5|ATK=5|HP=5|RACE=NONE
}
public class TSC_943e:Ability{
//NAME=刚硬甲壳
//TEXT=+1/+1
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_944:SpellBase{
//NAME=辛艾萨莉之火
//TEXT=将你牌库里的所有卡牌替换成法力值消耗大于或等于（5）点的随从牌。替换后的牌法力值消耗为（5）点。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class TSC_944e:Ability{
//NAME=熔火深渊
//TEXT=法力值消耗为（5）点。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_945:MinionBase{
//NAME=艾萨拉的刃豹
//TEXT=<b>突袭</b>，<b>亡语：</b>将一张沉没的刃豹置于你的牌库底。
//MAJ=HUNTER|COST=4|ATK=4|HP=3|RACE=BEAST
}
public class TSC_945t:MinionBase{
//NAME=沉没的刃豹
//TEXT=<b>突袭</b>，<b>亡语：</b>从你的牌库中召唤一只野兽。
//MAJ=HUNTER|COST=4|ATK=4|HP=3|RACE=BEAST
}
public class TSC_946:SpellBase{
//NAME=海胆尖刺
//TEXT=在本回合中，你的法术具有<b>剧毒</b>。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TSC_946e:Ability{
//NAME=剧毒海胆
//TEXT=你的法术具有<b>剧毒</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_946e2:Ability{
//NAME=剧毒
//TEXT=
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_947:SpellBase{
//NAME=纳迦的鱼群
//TEXT=召唤两条2/2的狮子鱼。如果你在此牌在你手中时使用过纳迦牌，使它们获得+1/+1。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class TSC_947e:Ability{
//NAME=精饲鱼群
//TEXT=+1/+1
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_947t:MinionBase{
//NAME=狮子鱼
//TEXT=
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class TSC_948:SpellBase{
//NAME=艾萨拉的恩赐
//TEXT=抽一张牌。如果你在此牌在你手中时使用过纳迦牌，再抽一张。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class TSC_950:MinionBase{
//NAME=海卓拉顿
//TEXT=<b>巨型+2</b> <b>战吼：</b>使你的海卓拉顿之头获得<b>突袭</b>。
//MAJ=HUNTER|COST=7|ATK=5|HP=5|RACE=BEAST
}
public class TSC_950t:MinionBase{
//NAME=海卓拉顿之头
//TEXT=<b>亡语：</b>如果你控制着海卓拉顿，召唤两个海卓拉顿之头。
//MAJ=HUNTER|COST=2|ATK=3|HP=1|RACE=BEAST
}
public class TSC_950t2:MinionBase{
//NAME=海卓拉顿之头
//TEXT=<b>亡语：</b>如果你控制着海卓拉顿，召唤两个海卓拉顿之头。
//MAJ=HUNTER|COST=2|ATK=3|HP=1|RACE=BEAST
}
public class TSC_952:SpellBase{
//NAME=神圣寿司卷
//TEXT=恢复#2点生命值。在本回合可以重复使用。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=HOLY
}
public class TSC_955:MinionBase{
//NAME=希拉柯丝教徒
//TEXT=<b>战吼：</b>使你的对手获得一张深渊诅咒。
//MAJ=WARLOCK|COST=3|ATK=3|HP=4|RACE=NAGA
}
public class TSC_955t:SpellBase{
//NAME=深渊诅咒
//TEXT=在你的回合开始时，受到{0}点伤害。每一次诅咒都会比上一次更严重。<i>（还剩{1}回合。）</i>
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TSC_956:SpellBase{
//NAME=拖入深渊
//TEXT=对一个随从造成$4点伤害。使你的对手获得一张深渊诅咒。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class TSC_957:SpellBase{
//NAME=鱼饵桶
//TEXT=使你手牌中的所有鱼人牌获得+1/+1。你每控制一个鱼人，重复一次。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TSC_957e:Ability{
//NAME=空桶
//TEXT=+1/+1
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_959:MinionBase{
//NAME=扎库尔
//TEXT=你的深渊诅咒会为你恢复等同于其造成伤害的生命值。<b>战吼：</b>使你的对手获得一张深渊诅咒。
//MAJ=WARLOCK|COST=5|ATK=6|HP=5|RACE=NONE
}
public class TSC_959e:Ability{
//NAME=诅咒
//TEXT=你的深渊诅咒会为你恢复等同于其造成伤害的生命值。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_959e2:Ability{
//NAME=诅咒
//TEXT=在本局对战中，你的诅咒法力值消耗增加（2）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_960:MinionBase{
//NAME=并鳍奇兵
//TEXT=<b>突袭</b>。<b>战吼：</b>召唤一个本随从的复制。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=1|RACE=MURLOC
}
public class TSC_962:MinionBase{
//NAME=老巨鳍
//TEXT=<b>巨型+1</b> <b>战吼：</b>吞食所有敌方随从。<b>亡语：</b>吐出来。
//MAJ=WARLOCK|COST=8|ATK=7|HP=4|RACE=MURLOC
}
public class TSC_962e:Ability{
//NAME=整个吞下
//TEXT=含着随从
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_962e2:Ability{
//NAME=鼓胀
//TEXT=老巨鳍吞食了所有敌方随从！
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_962t:MinionBase{
//NAME=老巨鳍之口
//TEXT=<b>嘲讽</b>，<b>亡语：</b>永久消灭老巨鳍体内的所有随从。
//MAJ=WARLOCK|COST=6|ATK=4|HP=7|RACE=MURLOC
}
public class TSC_963:MinionBase{
//NAME=鱼排斗士
//TEXT=<b>战吼：</b>造成1点伤害。
//MAJ=ROGUE|COST=1|ATK=3|HP=1|RACE=PIRATE
	public override void Battlecry(Card target=null)
	{
		new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
	}
}
public class TSC_COIN1:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TSC_COIN2:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
