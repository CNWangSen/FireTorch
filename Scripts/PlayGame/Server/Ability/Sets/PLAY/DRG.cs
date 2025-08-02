using System.Collections;
using System.Collections.Generic;

public class DRG_006:SpellBase{
//NAME=腐蚀吐息
//TEXT=对一个随从造成$3点伤害。如果你的手牌中有龙牌，还会命中敌方英雄。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class DRG_007:WeaponBase{
//NAME=风暴之锤
//TEXT=当你控制着一条龙时，不会失去 耐久度。
//MAJ=HUNTER|COST=3|ATK=3|HP=2|RACE=NONE
}
public class DRG_007e:Ability{
//NAME=风暴轰鸣
//TEXT=当你控制着一条龙时，不会失去耐久度。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_008:SpellBase{
//NAME=正义感召
//TEXT=<b>支线任务：</b> 召唤五个随从。<b>奖励：</b>使你的所有随从获得+1/+1。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DRG_008e:Ability{
//NAME=正义感召
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_010:MinionBase{
//NAME=俯冲狮鹫
//TEXT=<b>突袭，战吼：</b>从你的牌库中抽一张具有<b>突袭</b>的随从牌。
//MAJ=HUNTER|COST=3|ATK=4|HP=1|RACE=BEAST
}
public class DRG_019:MinionBase{
//NAME=废墟之子
//TEXT=<b>突袭</b> <b>战吼：</b>如果你已经<b>祈求</b>过两次，召唤本随从的两个复制。
//MAJ=WARRIOR|COST=3|ATK=3|HP=2|RACE=DRAGON
    public override void Init()
    {
        TaskInitAbility("Rush");
    }
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.GetTag(GameTag.CntInvokeGara) >=2)
        {
            TaskCreate(owner.cardDbf,ZoneType.Board);
            TaskCreate(owner.cardDbf,ZoneType.Board);
        }
    }
}
public class DRG_020:MinionBase{
//NAME=怪盗军需官
//TEXT=<b>战吼：</b>将一张<b>跟班</b>牌置入你的手牌。获得3点护甲值。
//MAJ=WARRIOR|COST=3|ATK=2|HP=3|RACE=NONE
}
public class DRG_021:WeaponBase{
//NAME=仪式斩斧
//TEXT=<b>战吼：</b><b> 祈求</b>迦拉克隆。
//MAJ=WARRIOR|COST=2|ATK=1|HP=2|RACE=NONE
}
public class DRG_022:SpellBase{
//NAME=横冲直撞
//TEXT=迫使一个随从攻击相邻的一个 随从。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DRG_023:MinionBase{
//NAME=空中炮艇
//TEXT=在你召唤一个海盗后，随机对一个敌人造成2点伤害。
//MAJ=WARRIOR|COST=3|ATK=2|HP=5|RACE=MECHANICAL
}
public class DRG_024:MinionBase{
//NAME=空中悍匪
//TEXT=<b>战吼：</b>随机将一张海盗牌置入你的手牌。
//MAJ=WARRIOR|COST=1|ATK=1|HP=2|RACE=PIRATE
}
public class DRG_025:WeaponBase{
//NAME=海盗之锚
//TEXT=在你的英雄攻击后，从你的牌库中抽一张海盗牌。
//MAJ=WARRIOR|COST=3|ATK=2|HP=2|RACE=NONE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,CauseEvent));
    }

    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(owner.myPlayer.hero.Contains(sc) && CondInPlay())
        {
            TaskDrawRace(RaceType.Pirate);
        }
    }
}
public class DRG_026:MinionBase{
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
public class DRG_027:MinionBase{
//NAME=幽影潜藏者
//TEXT=<b>战吼：</b>如果你已经<b>祈求</b>过两次，则将三张幸运币置入你的手牌。
//MAJ=ROGUE|COST=4|ATK=3|HP=3|RACE=NONE
}
public class DRG_028:SpellBase{
//NAME=巨龙宝藏
//TEXT=<b>发现</b>一张另一职业的<b>传说</b> 随从牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DRG_030:SpellBase{
//NAME=赞美迦拉克隆
//TEXT=使一个随从获得+1攻击力。<b>祈求</b>迦拉克隆。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DRG_030e:Ability{
//NAME=赞美迦拉克隆
//TEXT=+1攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_031:MinionBase{
//NAME=死金药剂师
//TEXT=<b>连击：</b>从你的牌库中抽一张<b>亡语</b>随从牌并获得其<b>亡语</b>。
//MAJ=ROGUE|COST=4|ATK=2|HP=5|RACE=NONE
}
public class DRG_031e:Ability{
//NAME=死金注射
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_033:SpellBase{
//NAME=烛火吐息
//TEXT=抽三张牌。如果你的手牌中有龙牌，这张牌的法力值消耗减少（3）点。
//MAJ=ROGUE|COST=6|ATK=0|HP=0|RACE=FIRE
}
public class DRG_034:MinionBase{
//NAME=偷渡者
//TEXT=<b>战吼：</b>如果你的牌库中有对战开始时不在牌库中的牌，则抽取其中的两张。
//MAJ=ROGUE|COST=5|ATK=4|HP=4|RACE=NONE
}
public class DRG_035:MinionBase{
//NAME=血帆飞贼
//TEXT=<b>战吼：</b>将两张1/1的海盗牌置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=PIRATE
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("DRG_035t");
        TaskCreate(ToSummon,ZoneType.Hand);
        TaskCreate(ToSummon,ZoneType.Hand);
    }
}
public class DRG_035t:MinionBase{
//NAME=空中海盗
//TEXT=
//MAJ=ROGUE|COST=1|ATK=1|HP=1|RACE=PIRATE
}
public class DRG_036:MinionBase{
//NAME=蜡烛巨龙
//TEXT=<b>亡语：</b>将一支蜡烛洗入你的牌库。抽到蜡烛时，重新召唤蜡烛巨龙。
//MAJ=ROGUE|COST=5|ATK=7|HP=5|RACE=DRAGON
}
public class DRG_036t:SpellBase{
//NAME=巨龙的蜡烛
//TEXT=<b>抽到时施放</b> 召唤蜡烛巨龙。
//MAJ=ROGUE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DRG_037:MinionBase{
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
public class DRG_049:MinionBase{
//NAME=美味飞鱼
//TEXT=<b>亡语：</b>使你手牌中的一张龙牌获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=MURLOC
}
public class DRG_049e:Ability{
//NAME=进食充分
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_050:MinionBase{
//NAME=虔信狂徒
//TEXT=<b>突袭，战吼：</b> <b>祈求</b>迦拉克隆。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Rush");
    }
    public override void Battlecry(Card target=null)
    {
        new EffectInvokeGara(owner.myPlayer,owner).Resolve();
    }
}
public class DRG_051:SpellBase{
//NAME=人多势众
//TEXT=<b>支线任务：</b> 消耗10点法力值用于随从牌上。<b>奖励：</b>从你的牌库中召唤一个随从。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DRG_052:MinionBase{
//NAME=龙族跟班
//TEXT=<b>战吼：</b> <b>发现</b>一张龙牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DRG_054:MinionBase{
//NAME=雏龙巨婴
//TEXT=<b>战吼：</b>抽一张牌。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=DRAGON
    public override void Battlecry(Card target=null)
    {
        TaskDraw();
    }
}
public class DRG_055:MinionBase{
//NAME=藏宝匪贼
//TEXT=<b>战吼：</b>装备一把你的被摧毁的武器。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=2|RACE=PIRATE
}
public class DRG_056:MinionBase{
//NAME=空降歹徒
//TEXT=在你使用一张海盗牌后，从你的手牌中召唤本随从。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=PIRATE
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,DRG_056CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }

    public void DRG_056CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(tz==ZoneType.Board && (sc.raceType.Contains(RaceType.Pirate)) && owner.GetTag(GameTag.ZoneType) == (int)ZoneType.Hand)
        {
            new EffectMove(owner.myPlayer,owner,ZoneType.Hand,ZoneType.Board).Resolve();
        }
    }
}
public class DRG_057:MinionBase{
//NAME=热气球
//TEXT=在你的回合开始时，获得+1生命值。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=MECHANICAL
}
public class DRG_057e:Ability{
//NAME=飞得更高
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_058:MinionBase{
//NAME=空军指挥官
//TEXT=你手牌中每有一张龙牌，便拥有+2 攻击力。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=NONE
}
public class DRG_058e:Ability{
//NAME=发号施令
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_059:MinionBase{
//NAME=地精滑翔技师
//TEXT=<b>战吼：</b>如果你控制一个机械，便获得+1/+1和<b>突袭</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class DRG_059e:Ability{
//NAME=地精滑翔
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_060:MinionBase{
//NAME=火鹰
//TEXT=<b>战吼：</b>你的对手每有一张手牌，本随从便获得+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=3|RACE=ELEMENTAL
}
public class DRG_060e:Ability{
//NAME=燃起火焰
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_061:MinionBase{
//NAME=旋翼机
//TEXT=<b>突袭，风怒</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=5|RACE=MECHANICAL
}
public class DRG_062:MinionBase{
//NAME=龙眠净化者
//TEXT=<b>战吼：</b> 将你牌库中的所有中立卡牌随机变形成为你的职业的卡牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class DRG_063:MinionBase{
//NAME=龙喉偷猎者
//TEXT=<b>战吼：</b>如果你的对手控制着一条龙，便获得+4/+4和<b>突袭</b>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class DRG_063e:Ability{
//NAME=疯狂偷猎
//TEXT=+4/+4和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_064:MinionBase{
//NAME=祖达克仪祭师
//TEXT=<b>嘲讽，战吼：</b> 随机为你的对手召唤三个法力值消耗为（1）的随从。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=9|RACE=NONE
}
public class DRG_065:MinionBase{
//NAME=角鹰兽
//TEXT=<b>突袭</b> <b>嘲讽</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=6|RACE=BEAST
}
public class DRG_066:MinionBase{
//NAME=辟法奇美拉
//TEXT=<b>剧毒</b>。<b>扰魔</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class DRG_067:MinionBase{
//NAME=巨魔蝙蝠骑士
//TEXT=<b>战吼：</b>随机对一个敌方随从造成3点伤害。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=NONE
}
public class DRG_068:MinionBase{
//NAME=活化龙息
//TEXT=你的随从无法被 <b>冻结</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=ELEMENTAL
}
public class DRG_068e:Ability{
//NAME=暖意融融
//TEXT=无法被<b>冻结</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_069:MinionBase{
//NAME=破甲骑士
//TEXT=<b>战吼：</b> 摧毁你对手的护甲。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class DRG_070:MinionBase{
//NAME=幼龙饲养员
//TEXT=<b>战吼：</b>选择一条友方的龙。将它的一张复制置入你的手牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class DRG_071:MinionBase{
//NAME=厄运信天翁
//TEXT=<b>亡语：</b>将两张1/1的信天翁洗入你对手的 牌库。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=BEAST
}
public class DRG_071t:MinionBase{
//NAME=信天翁
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class DRG_072:MinionBase{
//NAME=飞天鱼人
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，随机召唤两个鱼人。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=MURLOC
}
public class DRG_073:MinionBase{
//NAME=辟法灵龙
//TEXT=<b>扰魔</b>
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=DRAGON
}
public class DRG_074:MinionBase{
//NAME=迷彩飞艇
//TEXT=<b>战吼：</b>直到你的下个回合，使你的其他机械获得<b>潜行</b>。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=MECHANICAL
}
public class DRG_074e:Ability{
//NAME=迷彩遮罩
//TEXT=获得潜行直到你的下个回合。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_075:MinionBase{
//NAME=深蓝系咒师
//TEXT=<b>战吼：</b>随机将两张你职业的法力值消耗为（1）的法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=5|RACE=DRAGON
}
public class DRG_076:MinionBase{
//NAME=无面腐蚀者
//TEXT=<b>突袭</b>。<b>战吼：</b>将你的一个随从变形成为本随从的复制。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NONE
}
public class DRG_077:MinionBase{
//NAME=乌特加德鱼叉射手
//TEXT=<b>战吼：</b>双方玩家抽一张牌。如果是龙牌，则将其召唤。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class DRG_078:MinionBase{
//NAME=深潜炸弹
//TEXT=在你的回合开始时，对所有随从造成 5点伤害。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=5|RACE=NONE
}
public class DRG_079:MinionBase{
//NAME=辟法巨龙
//TEXT=<b>突袭</b>。<b>圣盾</b>。<b>扰魔</b>
//MAJ=NEUTRAL|COST=6|ATK=5|HP=3|RACE=DRAGON
}
public class DRG_081:MinionBase{
//NAME=锐鳞骑士
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，则造成2点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class DRG_082:MinionBase{
//NAME=黏指狗头人
//TEXT=<b>战吼：</b> 偷取对手的武器。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=PIRATE
}
public class DRG_084:MinionBase{
//NAME=触手恐吓者
//TEXT=<b>战吼：</b>每个玩家抽一张牌，交换其法力值消耗。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=5|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card c1 = TaskDraw();
        Card c2 = TaskDraw(ToEn:true);
        if(c1!=null && c2!=null)
        {
            int m1 = c1.GetTag(GameTag.Mana);
            int m2 = c2.GetTag(GameTag.Mana);
            new EffectChange(owner.myPlayer,owner,c1,manaChange:-m1+m2).Resolve();
            new EffectChange(owner.myPlayer,owner,c2,manaChange:-m2+m1).Resolve();
        }
    }
}
public class DRG_084e:Ability{
//NAME=迷乱触手
//TEXT=触手恐吓者交换了其法力值消耗。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_086:MinionBase{
//NAME=多彩龙卵
//TEXT=<b>战吼：</b>秘密<b>发现</b>一条龙作为孵化对象。 <b>亡语：</b>破壳而出！
//MAJ=NEUTRAL|COST=5|ATK=0|HP=3|RACE=NONE
}
public class DRG_086e:Ability{
//NAME=里面藏着什么？
//TEXT=这是个秘密……0里面是{0}！<i>（只有你能看得到。）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_088:MinionBase{
//NAME=恐惧渡鸦
//TEXT=你每控制一只其他恐惧渡鸦，便拥有+3攻击力。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=BEAST
}
public class DRG_088e:Ability{
//NAME=群鸦诡计
//TEXT=每有一只其他恐惧渡鸦便获得+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_089:MinionBase{
//NAME=红龙女王阿莱克丝塔萨
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则随机将两张其他龙牌置入你的手牌，其法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=9|ATK=8|HP=8|RACE=DRAGON
}
public class DRG_089e:Ability{
//NAME=女王特权
//TEXT=法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_090:MinionBase{
//NAME=永恒巨龙姆诺兹多
//TEXT=<b>战吼：</b>使用你的对手上个回合使用的所有卡牌。
//MAJ=PRIEST|COST=8|ATK=8|HP=8|RACE=DRAGON
}
public class DRG_091:MinionBase{
//NAME=舒玛
//TEXT=在你的回合结束时，用1/1的触手填满你的面板。
//MAJ=NEUTRAL|COST=7|ATK=1|HP=7|RACE=NONE
}
public class DRG_091t:MinionBase{
//NAME=触手
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DRG_092:MinionBase{
//NAME=幻化师
//TEXT=每当你抽到一张牌时，随机将其变形成为一张<b>传说</b>随从牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class DRG_095:MinionBase{
//NAME=维拉努斯
//TEXT=<b>战吼：</b>将所有敌方随从的生命值变为1。
//MAJ=HUNTER|COST=6|ATK=7|HP=6|RACE=DRAGON
}
public class DRG_095e:Ability{
//NAME=恐吓
//TEXT=生命值变为1。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_096:MinionBase{
//NAME=班德斯莫什
//TEXT=如果这张牌在你的手牌中，每个回合都会随机变成一张<b>传说</b>随从牌的5/5的复制。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=NONE
}
public class DRG_096e:Ability{
//NAME=变形
//TEXT=随机变形成为<b>传说</b>随从牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_096e2:Ability{
//NAME=变形
//TEXT=5/5。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_099:MinionBase{
//NAME=克罗斯·龙蹄
//TEXT=<b>战吼：</b>抽取迦拉克隆。如果你已经变为迦拉克隆，则释放一场 灾难。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("DRG_099t2t"),ZoneType.Board);
    }
}
public class DRG_099t1:SpellBase{
//NAME=屠戮
//TEXT=对敌方英雄造成5点伤害。为你的英雄恢复5点生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_099t2:SpellBase{
//NAME=复活
//TEXT=召唤一条8/8并具有<b>嘲讽</b>的龙。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_099t2t:MinionBase{
//NAME=重生的巨龙
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=DRAGON
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class DRG_099t3:SpellBase{
//NAME=统御
//TEXT=使你的所有其他随从获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_099t3e:Ability{
//NAME=统御之下
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_099t4:SpellBase{
//NAME=毁灭
//TEXT=对所有其他随从造成5点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_102:MinionBase{
//NAME=碧蓝龙探险者
//TEXT=<b>法术伤害+2</b> <b>战吼：</b><b>发现</b>一张 龙牌。
//MAJ=MAGE|COST=4|ATK=2|HP=3|RACE=DRAGON
}
public class DRG_104:MinionBase{
//NAME=齐恩瓦拉
//TEXT=你在一回合中施放三个法术后，召唤一个5/5的元素。
//MAJ=MAGE|COST=3|ATK=2|HP=5|RACE=ELEMENTAL
}
public class DRG_104t2:MinionBase{
//NAME=冰雪元素
//TEXT=
//MAJ=MAGE|COST=5|ATK=5|HP=5|RACE=ELEMENTAL
}
public class DRG_106:SpellBase{
//NAME=奥术吐息
//TEXT=对一个随从造成$2点伤害。如果你的手牌中有龙牌，便<b>发现</b>一张法术牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class DRG_107:MinionBase{
//NAME=紫罗兰魔翼鸦
//TEXT=<b>亡语：</b>将一张“奥术飞弹”法术牌置入你的 手牌。
//MAJ=MAGE|COST=1|ATK=1|HP=1|RACE=ELEMENTAL
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("EX1_277"),ZoneType.Hand);
    }
}
public class DRG_109:MinionBase{
//NAME=法力巨人
//TEXT=在本局对战中，你每使用一张你的套牌之外的卡牌，本牌的法力值消耗便 减少（1）点。
//MAJ=MAGE|COST=8|ATK=8|HP=8|RACE=ELEMENTAL
}
public class DRG_201:MinionBase{
//NAME=疯狂的灵翼龙
//TEXT=<b>战吼：</b> 如果你的手牌中有龙牌，则对所有其他角色造成3点伤害。
//MAJ=WARLOCK|COST=5|ATK=5|HP=5|RACE=DRAGON
}
public class DRG_202:MinionBase{
//NAME=龙骨荒野异教徒
//TEXT=<b>战吼：</b><b>祈求</b>迦拉克隆。每有一个其他友方随从，便获得+1攻击力。
//MAJ=WARLOCK|COST=3|ATK=1|HP=1|RACE=NONE
}
public class DRG_202e:Ability{
//NAME=异教之力
//TEXT=攻击力提高。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_203:MinionBase{
//NAME=暗藏的信徒
//TEXT=<b>战吼：</b> 如果你已经<b>祈求</b>过两次，则抽三张牌。
//MAJ=WARLOCK|COST=4|ATK=5|HP=4|RACE=UNDEAD
}
public class DRG_204:SpellBase{
//NAME=黑暗天际
//TEXT=随机对一个随从造成$1点伤害。你每有一张手牌，就重复 一次。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=FEL
}
public class DRG_205:SpellBase{
//NAME=虚空吐息
//TEXT=造成$2点伤害。如果你的手牌中有龙牌，则改为造成$4点伤害并具有<b>吸血</b>。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=FEL
}
public class DRG_206:SpellBase{
//NAME=火焰之雨
//TEXT=对所有角色造成$1点伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=FEL
}
public class DRG_207:MinionBase{
//NAME=深渊召唤者
//TEXT=<b>战吼：</b>召唤一个属性值等同于你的手牌数量并具有<b>嘲讽</b>的恶魔。
//MAJ=WARLOCK|COST=6|ATK=2|HP=2|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("DRG_207t");
        int Cnt = owner.myPlayer.hand.Count;
        ToSummon.Attack=Cnt;
        ToSummon.MaxHealth=Cnt;
        ToSummon.ManaCost=Cnt;
        TaskCreate(ToSummon,ZoneType.Board);
    }
}
public class DRG_207t:MinionBase{
//NAME=深渊毁灭者
//TEXT=<b>嘲讽</b>
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class DRG_208:MinionBase{
//NAME=瓦迪瑞斯·邪噬
//TEXT=<b>战吼：</b>将你的手牌上限提高至12张。抽四张牌。
//MAJ=WARLOCK|COST=7|ATK=4|HP=4|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        owner.myPlayer.maxnum[(int)ZoneType.Hand]=12;
        TaskDraw();
        TaskDraw();
        TaskDraw();
        TaskDraw();
    }
}
public class DRG_209:MinionBase{
//NAME=扭曲巨龙泽拉库
//TEXT=每当你的英雄受到伤害，召唤一条6/6的虚空幼龙。
//MAJ=WARLOCK|COST=8|ATK=4|HP=12|RACE=DRAGON
}
public class DRG_209t:MinionBase{
//NAME=虚空幼龙
//TEXT=
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=DRAGON
}
public class DRG_211:MinionBase{
//NAME=猎风巨龙
//TEXT=<b>法术伤害+2</b> <b>过载：</b>（2）
//MAJ=SHAMAN|COST=4|ATK=5|HP=7|RACE=DRAGON
}
public class DRG_213:MinionBase{
//NAME=双头暴虐龙
//TEXT=<b>战吼：</b>随机对两个敌方随从造成4点伤害。
//MAJ=NEUTRAL|COST=8|ATK=4|HP=10|RACE=DRAGON
}
public class DRG_215:SpellBase{
//NAME=风暴之怒
//TEXT=使你的所有随从获得+1/+1。 <b>过载：</b>（1）
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class DRG_215e:Ability{
//NAME=风暴之怒
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_216:MinionBase{
//NAME=电涌风暴
//TEXT=当你有<b>过载</b>的法力水晶时，拥有+1 攻击力。
//MAJ=SHAMAN|COST=1|ATK=1|HP=3|RACE=ELEMENTAL
}
public class DRG_216e:Ability{
//NAME=流电奔涌
//TEXT=+1攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_217:SpellBase{
//NAME=巨龙的兽群
//TEXT=召唤两只2/3并具有<b>嘲讽</b>的幽灵狼。如果你已经<b>祈求</b>过两次，则使它们获得+3/+3。
//MAJ=SHAMAN|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DRG_217e:Ability{
//NAME=迦拉克隆的威能
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_217t:MinionBase{
//NAME=幽灵狼
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class DRG_218:MinionBase{
//NAME=堕落的元素师
//TEXT=<b>战吼：</b><b>祈求</b>迦拉克隆两次。
//MAJ=SHAMAN|COST=5|ATK=3|HP=3|RACE=NONE
}
public class DRG_219:SpellBase{
//NAME=闪电吐息
//TEXT=对一个随从造成$4点伤害。如果你的手牌中有龙牌，则同样对其相邻随从造成伤害。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class DRG_223:MinionBase{
//NAME=遮天雨云
//TEXT=<b>战吼：</b>如果你有<b>过载</b>的法力水晶，造成5点伤害。
//MAJ=SHAMAN|COST=5|ATK=5|HP=5|RACE=ELEMENTAL
}
public class DRG_224:MinionBase{
//NAME=尼索格
//TEXT=<b>战吼：</b>召唤两个0/3的龙卵。下个回合它们将孵化为4/4并具有<b>突袭</b>的幼龙。
//MAJ=SHAMAN|COST=6|ATK=5|HP=5|RACE=DRAGON
}
public class DRG_224t:MinionBase{
//NAME=风暴龙卵
//TEXT=在你的回合开始时，变形成为一条4/4并具有<b>突袭</b>的风暴幼龙。
//MAJ=SHAMAN|COST=1|ATK=0|HP=3|RACE=NONE
}
public class DRG_224t2:MinionBase{
//NAME=风暴幼龙
//TEXT=<b>突袭</b>
//MAJ=SHAMAN|COST=4|ATK=4|HP=4|RACE=DRAGON
}
public class DRG_225:MinionBase{
//NAME=空中飞爪
//TEXT=你的其他机械拥有+1攻击力。<b>战吼：</b>召唤两个1/1的微型 旋翼机。
//MAJ=PALADIN|COST=3|ATK=1|HP=2|RACE=MECHANICAL
}
public class DRG_225e:Ability{
//NAME=机械之力
//TEXT=空中飞爪使其获得+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_225t:MinionBase{
//NAME=微型旋翼机
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=MECHANICAL
}
public class DRG_226:MinionBase{
//NAME=琥珀看守者
//TEXT=<b>战吼：</b> 恢复#8点生命值。
//MAJ=PALADIN|COST=5|ATK=4|HP=6|RACE=DRAGON
}
public class DRG_229:MinionBase{
//NAME=青铜龙探险者
//TEXT=<b>吸血</b> <b>战吼：</b><b>发现</b>一张 龙牌。
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=DRAGON
}
public class DRG_231:MinionBase{
//NAME=光铸远征军
//TEXT=<b>战吼：</b>如果你的牌库中没有中立卡牌，随机将五张圣骑士卡牌置入你的手牌。
//MAJ=PALADIN|COST=7|ATK=7|HP=7|RACE=NONE
}
public class DRG_232:MinionBase{
//NAME=光铸狂热者
//TEXT=<b>战吼：</b> 如果你的牌库中没有中立卡牌，便装备一把4/2的真银圣剑。
//MAJ=PALADIN|COST=4|ATK=4|HP=2|RACE=NONE
}
public class DRG_232t:WeaponBase{
//NAME=真银圣剑
//TEXT=每当你的英雄进攻，便为其恢复#3点生命值。
//MAJ=PALADIN|COST=4|ATK=4|HP=2|RACE=NONE
}
public class DRG_233:SpellBase{
//NAME=沙尘吐息
//TEXT=使一个随从获得+1/+2。如果你的手牌中有龙牌，使其获得<b>圣盾</b>。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DRG_233e:Ability{
//NAME=沙尘吐息
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_235:MinionBase{
//NAME=龙骑士塔瑞萨
//TEXT=<b>亡语：</b>使你手牌中的一张龙牌获得+3/+3以及此<b>亡语</b>。
//MAJ=PALADIN|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class DRG_235d:SpellBase{
//NAME=Dragonrider Talritha Effect Dummy
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_235e:Ability{
//NAME=骑士塔瑞萨
//TEXT=+3/+3以及<b>亡语：</b>使你手牌中的一张龙牌获得+3/+3以及此亡语。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_238ht:WeaponBase{
//NAME=巨龙之爪
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=5|HP=2|RACE=NONE
}
public class DRG_238p:HeroPowerBase{
//NAME=迦拉克隆的巨力
//TEXT=在本回合中，使你的英雄获得+$a3攻击力。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DRG_238p2:HeroPowerBase{
//NAME=迦拉克隆的诡计
//TEXT=将一张<b>跟班</b>牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DRG_238p3:HeroPowerBase{
//NAME=迦拉克隆的恶意
//TEXT=召唤两个1/1的小鬼。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DRG_238p4:HeroPowerBase{
//NAME=迦拉克隆的愤怒
//TEXT=召唤一个2/1并具有<b>突袭</b>的元素。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DRG_238p5:HeroPowerBase{
//NAME=迦拉克隆的智识
//TEXT=随机将一张牧师随从牌置入你的手牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DRG_238t10e:Ability{
//NAME=迦拉克隆的巨力
//TEXT=在本回合中+3攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_238t12t2:MinionBase{
//NAME=龙裔小鬼
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class DRG_238t14t3:MinionBase{
//NAME=啸风元素
//TEXT=<b>突袭</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=1|RACE=ELEMENTAL
}
public class DRG_239:MinionBase{
//NAME=灼光战斗法师
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=NONE
}
public class DRG_242:MinionBase{
//NAME=迦拉克隆之盾
//TEXT=<b>嘲讽，战吼：</b> <b>祈求</b>迦拉克隆。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        new EffectInvokeGara(owner.myPlayer,owner).Resolve();
    }
}
public class DRG_246:SpellBase{
//NAME=时空裂痕
//TEXT=消灭一个随从。<b>祈求</b>迦拉克隆。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DRG_247:SpellBase{
//NAME=封印命运
//TEXT=对一个未受伤的角色造成$3点伤害。<b>祈求</b>迦拉克隆。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DRG_248:SpellBase{
//NAME=霜之祈咒
//TEXT=<b>冻结</b>一个敌人。<b>祈求</b>迦拉克隆。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=FROST
}
public class DRG_249:SpellBase{
//NAME=祈求觉醒
//TEXT=<b>祈求</b>迦拉克隆。对所有随从造成$1点伤害。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        new EffectInvokeGara(owner.myPlayer,owner).Resolve();
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
    }
}
public class DRG_250:SpellBase{
//NAME=邪鬼仪式
//TEXT=<b>祈求</b>迦拉克隆。使你的所有随从获得+1攻击力。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=NONE
}
public class DRG_250e:Ability{
//NAME=邪鬼仪式
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_251:SpellBase{
//NAME=扫清道路
//TEXT=<b>支线任务：</b> 召唤三个<b>突袭</b>随从。<b>奖励：</b>召唤一头4/4并具有<b>突袭</b>的狮鹫。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DRG_251t:MinionBase{
//NAME=狮鹫
//TEXT=<b>突袭</b>
//MAJ=HUNTER|COST=4|ATK=4|HP=4|RACE=BEAST
}
public class DRG_252:MinionBase{
//NAME=相位追猎者
//TEXT=在你使用你的英雄技能后，从你的牌库中施放一个<b>奥秘</b>。
//MAJ=HUNTER|COST=2|ATK=2|HP=3|RACE=BEAST
}
public class DRG_253:MinionBase{
//NAME=矮人神射手
//TEXT=你的英雄技能能够以随从为目标。
//MAJ=HUNTER|COST=1|ATK=1|HP=3|RACE=NONE
}
public class DRG_254:MinionBase{
//NAME=始生龙探险者
//TEXT=<b>剧毒</b> <b>战吼：</b><b>发现</b>一张 龙牌。
//MAJ=HUNTER|COST=3|ATK=2|HP=3|RACE=DRAGON
}
public class DRG_255:SpellBase{
//NAME=病毒增援
//TEXT=<b>支线任务：</b> 使用你的英雄技能三次。<b>奖励：</b>召唤三个2/1的麻风侏儒。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DRG_255t2:MinionBase{
//NAME=麻风侏儒
//TEXT=<b>亡语：</b>对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
    public override void Deathrattle()
    {
        TaskDamageEnemyHero(2);
    }
}
public class DRG_256:MinionBase{
//NAME=灭龙弩炮
//TEXT=在你使用你的英雄技能后，随机对一个敌人造成5点伤害。
//MAJ=HUNTER|COST=4|ATK=3|HP=5|RACE=MECHANICAL
}
public class DRG_257:MinionBase{
//NAME=弗瑞兹·光巢
//TEXT=<b>战吼：</b>使你牌库中龙牌的法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=NONE
}
public class DRG_257e3:Ability{
//NAME=孵化在即
//TEXT=法力值消耗减少。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_258:SpellBase{
//NAME=庇护
//TEXT=<b>支线任务：</b> 在一回合内不受伤害。<b>奖励：</b>召唤一个3/6并具有<b>嘲讽</b>的随从。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DRG_258t:MinionBase{
//NAME=不屈的勇士
//TEXT=<b>嘲讽</b>
//MAJ=PALADIN|COST=4|ATK=3|HP=6|RACE=NONE
}
public class DRG_270:MinionBase{
//NAME=织法巨龙玛里苟斯
//TEXT=<b>战吼：</b> 如果你的手牌中有龙牌，便<b>发现</b>一张升级过的法师法术牌。
//MAJ=MAGE|COST=5|ATK=2|HP=8|RACE=DRAGON
}
public class DRG_270t1:SpellBase{
//NAME=玛里苟斯的奥术智慧
//TEXT=抽四张牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class DRG_270t11:SpellBase{
//NAME=玛里苟斯的奥术飞弹
//TEXT=造成$6点伤害，随机分配到所有敌人身上。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class DRG_270t2:SpellBase{
//NAME=玛里苟斯的智慧秘典
//TEXT=随机将三张法师法术牌置入你的手牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class DRG_270t4:SpellBase{
//NAME=玛里苟斯的魔爆术
//TEXT=对所有敌方随从造成$2点伤害。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class DRG_270t5:SpellBase{
//NAME=玛里苟斯的冰霜新星
//TEXT=<b>冻结</b>所有敌方随从。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FROST
}
public class DRG_270t6:SpellBase{
//NAME=玛里苟斯的变形术
//TEXT=使一个随从变形成为1/1的绵羊。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=ARCANE
}
public class DRG_270t6t:MinionBase{
//NAME=玛里苟斯的绵羊
//TEXT=
//MAJ=MAGE|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class DRG_270t7:SpellBase{
//NAME=玛里苟斯的烈焰风暴
//TEXT=对所有敌方随从造成$8点伤害。
//MAJ=MAGE|COST=7|ATK=0|HP=0|RACE=FIRE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,8);
    }
}
public class DRG_270t8:SpellBase{
//NAME=玛里苟斯的寒冰箭
//TEXT=对一个角色造成$3点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=FROST
}
public class DRG_270t9:SpellBase{
//NAME=玛里苟斯的火球术
//TEXT=造成$8点伤害。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class DRG_300:MinionBase{
//NAME=命运编织者
//TEXT=<b>战吼：</b>如果你已经<b>祈求</b>过两次，则使你的手牌法力值消耗减少（1）点。
//MAJ=PRIEST|COST=4|ATK=3|HP=6|RACE=DRAGON
}
public class DRG_300e:Ability{
//NAME=龙族的命运
//TEXT=法力值消耗减少（1）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_301:SpellBase{
//NAME=怪盗低语
//TEXT=将一张<b>跟班</b>牌置入你的手牌。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_302:SpellBase{
//NAME=墓地符文
//TEXT=使一个随从获得“<b>亡语：</b>召唤该随从的两个复制。”
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class DRG_302e:Ability{
//NAME=墓地符文
//TEXT=<b>亡语：</b>召唤本随从的两个复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_303:MinionBase{
//NAME=迦拉克隆的信徒
//TEXT=<b>战吼：</b> <b>祈求</b>迦拉克隆。
//MAJ=PRIEST|COST=1|ATK=1|HP=2|RACE=NONE
}
public class DRG_304:MinionBase{
//NAME=时空破坏者
//TEXT=<b>亡语：</b>如果你的手牌中有龙牌，则对所有敌方随从造成3点 伤害。
//MAJ=PRIEST|COST=5|ATK=4|HP=5|RACE=DRAGON
    public override void Deathrattle()
    {
        if(CondHoldAnotherRace(RaceType.Dragon))
        {
            TaskDamageTargets(owner.myPlayer.otherPlayer.board,3);
        }
    }
}
public class DRG_306:MinionBase{
//NAME=拉祖尔的信使
//TEXT=<b>战吼：</b>检视三张卡牌。猜中来自你对手手牌中的卡牌，则获取该牌的一张复制。
//MAJ=PRIEST|COST=2|ATK=2|HP=2|RACE=NONE
}
public class DRG_307:SpellBase{
//NAME=永恒吐息
//TEXT=对所有随从造成$2点伤害。如果你的手牌中有龙牌，则只对敌方随从造成伤害。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(CondHoldAnotherRace(RaceType.Dragon))
        {
            TaskDamageTargets(owner.myPlayer.otherPlayer.board,2);
        }
        else{
            TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.board),2);
        }
    }
}
public class DRG_308:MinionBase{
//NAME=夺心者卡什
//TEXT=<b>战吼：</b>选择一个敌方随从。<b>亡语：</b>召唤一个所选随从的新的 复制。
//MAJ=PRIEST|COST=3|ATK=3|HP=3|RACE=NONE
}
public class DRG_308e:Ability{
//NAME=生于暗影
//TEXT=<b>亡语：</b>召唤{0}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_309:MinionBase{
//NAME=时光巨龙诺兹多姆
//TEXT=<b>战吼：</b> 将每个玩家的法力水晶重置为十个。
//MAJ=PALADIN|COST=4|ATK=8|HP=8|RACE=DRAGON
}
public class DRG_310:MinionBase{
//NAME=辟法龙人
//TEXT=<b>嘲讽</b>。<b>扰魔</b>
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=DRAGON
}
public class DRG_311:SpellBase{
//NAME=树木援军
//TEXT=<b>抉择：</b>使一个随从获得+2生命值和<b>嘲讽</b>；或者召唤一个2/2的树人。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class DRG_311a:SpellBase{
//NAME=旋叶起飞
//TEXT=召唤一个2/2的树人。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class DRG_311b:SpellBase{
//NAME=简单维修
//TEXT=使一个随从获得+2生命值和 <b>嘲讽</b>。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class DRG_311e:Ability{
//NAME=孢子强化
//TEXT=+2生命值并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_311t:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class DRG_312:MinionBase{
//NAME=盆栽投手
//TEXT=<b>战吼：</b>召唤一个2/2的树人。
//MAJ=DRUID|COST=2|ATK=1|HP=1|RACE=NONE
}
public class DRG_313:MinionBase{
//NAME=翡翠龙探险者
//TEXT=<b>嘲讽</b> <b>战吼：</b><b>发现</b>一张 龙牌。
//MAJ=DRUID|COST=6|ATK=4|HP=8|RACE=DRAGON
}
public class DRG_314:SpellBase{
//NAME=空气栽培
//TEXT=抽两张牌。你每控制一个树人，本牌的法力值消耗便减少（2）点。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NATURE
}
public class DRG_315:SpellBase{
//NAME=森然巨化
//TEXT=使你牌库中的所有随从牌获得+2/+2，且法力值消耗增加（1）点<i>（最高不超过10点）</i>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        List<Card> MinionInDeck = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardType==CardType.Minion)
            {
                MinionInDeck.Add(c);
            }
        }
        TaskBuffTargets(MinionInDeck,atk:2,hp:2,mana:1);
    }
}
public class DRG_315e:Ability{
//NAME=身材巨化
//TEXT=+2/+2。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_315e2:Ability{
//NAME=费用巨化
//TEXT=法力值消耗增加（1）点。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_317:SpellBase{
//NAME=保护甲板
//TEXT=<b>支线任务：</b> 用你的英雄攻击两次。<b>奖励：</b>将三张“爪击”法术牌置入你的手牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DRG_318:SpellBase{
//NAME=梦境吐息
//TEXT=抽一张牌。如果你的手牌中有龙牌，便获得一个空的法力水晶。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class DRG_319:MinionBase{
//NAME=强力巨树格鲁
//TEXT=<b>嘲讽，战吼：</b>在本局对战的剩余时间内，你的树人拥有+1/+1。
//MAJ=DRUID|COST=7|ATK=5|HP=10|RACE=NONE
}
public class DRG_319e4:Ability{
//NAME=树人崛起
//TEXT=你的树人拥有+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_319e5:Ability{
//NAME=树木之力
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_320:MinionBase{
//NAME=觉醒巨龙伊瑟拉
//TEXT=<b>战吼：</b>将七张“梦境之门”洗入你的牌库。当抽到梦境之门时，随机召唤一条龙。
//MAJ=DRUID|COST=9|ATK=4|HP=12|RACE=DRAGON
}
public class DRG_320t:SpellBase{
//NAME=梦境之门
//TEXT=<b>抽到时施放</b> 随机召唤一条龙。
//MAJ=DRUID|COST=9|ATK=0|HP=0|RACE=NATURE
}
public class DRG_321:SpellBase{
//NAME=火球滚滚
//TEXT=对一个随从造成$8点伤害，超过其生命值的伤害将由左侧或右侧的随从承担。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class DRG_322:MinionBase{
//NAME=乘龙法师
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，在本回合中你所施放的下一个法术的法力值消耗为（0）点。
//MAJ=MAGE|COST=6|ATK=4|HP=4|RACE=NONE
}
public class DRG_322e:Ability{
//NAME=龙族魔法
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗为（0）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_323:SpellBase{
//NAME=学习龙语
//TEXT=<b>支线任务：</b> 消耗8点法力值用于法术牌上。<b>奖励：</b>召唤一条6/6的龙。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DRG_323t:MinionBase{
//NAME=龙族使者
//TEXT=
//MAJ=MAGE|COST=6|ATK=6|HP=6|RACE=DRAGON
}
public class DRG_324:SpellBase{
//NAME=元素盟军
//TEXT=<b>支线任务：</b> 连续两个回合使用元素牌。<b>奖励：</b>从你的牌库中抽三张法术牌。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DRG_401:MinionBase{
//NAME=灰发巫师
//TEXT=<b>战吼：</b>直到你的下个回合，和你的对手交换英雄技能。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class DRG_401d:SpellBase{
//NAME=灰发技能占位
//TEXT=占位关联DRG401e
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_401e:Ability{
//NAME=灰发之力
//TEXT=下个回合与你的对手交换英雄技能。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_402:MinionBase{
//NAME=萨索瓦尔
//TEXT=<b>战吼：</b>选择一个友方随从。将一个它的复制置入你的手牌，牌库以及战场。
//MAJ=NEUTRAL|COST=9|ATK=5|HP=5|RACE=DEMON
}
public class DRG_403:MinionBase{
//NAME=喷灯破坏者
//TEXT=<b>战吼：</b>你对手的下一个英雄技能的法力值消耗为（3）点。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class DRG_403e:Ability{
//NAME=烫烫烫
//TEXT=法力值消耗为（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_500:SpellBase{
//NAME=熔火吐息
//TEXT=对一个随从造成$5点伤害。如果你的手牌中有龙牌，便获得5点护甲值。
//MAJ=WARRIOR|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class DRG_600:HeroBase{
//NAME=邪火巨龙迦拉克隆
//TEXT=<b>战吼：</b>随机召唤一个恶魔。<i>（0）</i>
//MAJ=WARLOCK|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_600t2:HeroBase{
//NAME=天降浩劫迦拉克隆
//TEXT=<b>战吼：</b>随机召唤两个恶魔。<i>（0）</i>
//MAJ=WARLOCK|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_600t3:HeroBase{
//NAME=世界末日迦拉克隆
//TEXT=<b>战吼：</b>随机召唤四个恶魔。装备一只5/2的巨爪。
//MAJ=WARLOCK|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_610:HeroBase{
//NAME=梦魇巨龙迦拉克隆
//TEXT=<b>战吼：</b>抽一张牌，其法力值消耗为（0）点。<i>（0）</i>
//MAJ=ROGUE|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_610e:Ability{
//NAME=迦拉克隆的奇谋
//TEXT=法力值消耗为（0）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_610t2:HeroBase{
//NAME=天降浩劫迦拉克隆
//TEXT=<b>战吼：</b>抽两张牌，其法力值消耗为（0）点。<i>（0）</i>
//MAJ=ROGUE|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_610t3:HeroBase{
//NAME=世界末日迦拉克隆
//TEXT=<b>战吼：</b>抽四张牌，其法力值消耗为（0）点。装备一只5/2的巨爪。
//MAJ=ROGUE|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_620:HeroBase{
//NAME=风暴巨龙迦拉克隆
//TEXT=<b>战吼：</b>召唤两个2/2并具有<b>突袭</b>的风暴。<i>（0）</i>
//MAJ=SHAMAN|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_620t2:HeroBase{
//NAME=天降浩劫迦拉克隆
//TEXT=<b>战吼：</b>召唤两个4/4并具有<b>突袭</b>的风暴。<i>（0）</i>
//MAJ=SHAMAN|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_620t3:HeroBase{
//NAME=世界末日迦拉克隆
//TEXT=<b>战吼：</b>召唤两个8/8并具有<b>突袭</b>的风暴。装备一只5/2的 巨爪。
//MAJ=SHAMAN|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_620t4:MinionBase{
//NAME=成型风暴
//TEXT=<b>突袭</b>
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=ELEMENTAL
}
public class DRG_620t5:MinionBase{
//NAME=活化风暴
//TEXT=<b>突袭</b>
//MAJ=SHAMAN|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class DRG_620t6:MinionBase{
//NAME=狂怒风暴
//TEXT=<b>突袭</b>
//MAJ=SHAMAN|COST=8|ATK=8|HP=8|RACE=ELEMENTAL
}
public class DRG_650:HeroBase{
//NAME=无敌巨龙迦拉克隆
//TEXT=<b>战吼：</b>抽一张随从牌，使其获得+4/+4。<i>（0）</i>
//MAJ=WARRIOR|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_650e:Ability{
//NAME=迦拉克隆的力量
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_650e2:Ability{
//NAME=迦拉克隆的力量
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_650e3:Ability{
//NAME=迦拉克隆的力量
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DRG_650t2:HeroBase{
//NAME=天降浩劫迦拉克隆
//TEXT=<b>战吼：</b>抽两张随从牌，使其获得+4/+4。<i>（0）</i>
//MAJ=WARRIOR|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_650t3:HeroBase{
//NAME=世界末日迦拉克隆
//TEXT=<b>战吼：</b>抽四张随从牌，使其获得+4/+4。装备一只5/2的 巨爪。
//MAJ=WARRIOR|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_660:HeroBase{
//NAME=讳言巨龙迦拉克隆
//TEXT=<b>战吼：</b>随机消灭一个敌方随从。<i>（0）</i>
//MAJ=PRIEST|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_660t2:HeroBase{
//NAME=天降浩劫迦拉克隆
//TEXT=<b>战吼：</b>随机消灭两个敌方随从。<i>（0）</i>
//MAJ=PRIEST|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_660t3:HeroBase{
//NAME=世界末日迦拉克隆
//TEXT=<b>战吼：</b>随机消灭四个敌方随从。装备一只5/2的巨爪。
//MAJ=PRIEST|COST=7|ATK=0|HP=30|RACE=NONE
}
public class DRG_COIN:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
