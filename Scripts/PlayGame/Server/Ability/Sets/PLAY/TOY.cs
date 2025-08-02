using System.Collections;
using System.Collections.Generic;

public class TOY_000:MinionBase{
//NAME=焦油泥浆怪
//TEXT=<b>嘲讽</b> 在你对手的回合拥有+2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=ELEMENTAL
}
public class TOY_006:MinionBase{
//NAME=甲虫钥匙链
//TEXT=<b>战吼：</b><b>发现</b>一张 法力值消耗为（2）的卡牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TOY_028:MinionBase{
//NAME=团队之灵
//TEXT=<b>潜行</b>一回合。你的英雄在你的回合拥有+2攻击力。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=3|RACE=UNDEAD
}
public class TOY_037:SpellBase{
//NAME=寻物解谜
//TEXT=<b>发现</b>一张<b>奥秘</b>牌，将其法力值消耗变为（1）点。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TOY_046:SpellBase{
//NAME=超值惊喜
//TEXT=<b>发现</b>一张法力值消耗为（4）的随从牌，将其攻击力和生命值变为7。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class TOY_054:MinionBase{
//NAME=卡牌评级师
//TEXT=<b>战吼：</b>如果你在此牌在你手中时施放过法术，从你的牌库中<b>发现</b>一张牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NAGA
}
public class TOY_100:MinionBase{
//NAME=侏儒飞行员诺莉亚
//TEXT=<b>突袭</b>。同时对其攻击目标相邻的随从造成伤害。<b>亡语：</b>对所有敌人造成2点伤害。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=2|RACE=NONE
}
public class TOY_101:MinionBase{
//NAME=暗夜精灵女猎手
//TEXT=<b>战吼：</b>对三个不同的敌人各造成3点伤害。<i>（目标由你选定！）</i>
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class TOY_102:MinionBase{
//NAME=人类步兵
//TEXT=<b>嘲讽</b>。相邻随从在攻击时<b>免疫</b>。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=NONE
}
public class TOY_103:MinionBase{
//NAME=战歌步兵
//TEXT=<b>突袭</b> 在本随从攻击并消灭一个随从后，可再次攻击。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=NONE
}
public class TOY_307:MinionBase{
//NAME=甜蜜雪灵
//TEXT=<b>微缩</b> <b>战吼：</b>随机获取2张<b>临时</b>冰霜法术牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=ELEMENTAL
}
public class TOY_312:MinionBase{
//NAME=恋旧的侏儒
//TEXT=<b>微缩</b> <b>突袭</b>。在本随从在你的回合中造成了刚好消灭目标的伤害后，抽一张牌。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class TOY_330:MinionBase{
//NAME=奇利亚斯豪华版3000型
//TEXT=你可以在构筑 套牌时打造专属于自己的奇利亚斯豪华版3000型！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=MECHANICAL
}
public class TOY_330t12:MinionBase{
//NAME=奇利亚斯豪华版3000型
//TEXT=你可以在构筑 套牌时打造专属于自己的奇利亚斯豪华版3000型！
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("DivineShield");
        TaskInitAbility("Taunt");
        TaskInitAbility("Rush");
        TaskInitAbility("Elusive");
        TaskInitAbility("LifeSteal");
        TaskInitAbility("Poisonous");
        TaskInitAbility("Reborn");
    }
}
public class TOY_340:MinionBase{
//NAME=恋旧的新生
//TEXT=<b>微缩</b> 在你施放本随从登场后的第一个法术时获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class TOY_341:MinionBase{
//NAME=恋旧的小丑
//TEXT=<b>微缩</b> <b>战吼：</b>如果你在此牌在你手中时使用过法力值消耗更高的牌，造成4点伤害。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=5|RACE=NONE
}
public class TOY_350:MinionBase{
//NAME=漆彩帆布龙
//TEXT=<b>战吼：</b>使每只其他友方野兽各获得一项随机<b>额外效果</b>。
//MAJ=HUNTER|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class TOY_351:MinionBase{
//NAME=神秘的蛋
//TEXT=<b>微缩</b> <b>亡语：</b>获取你牌库中一张随机野兽牌的一张复制，其法力值消耗减少（5）点。
//MAJ=HUNTER|COST=5|ATK=0|HP=3|RACE=NONE
}
public class TOY_352:SpellBase{
//NAME=抛接嬉戏
//TEXT=抽一张随从牌。如果是野兽牌，抽一张法术牌。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card Drawn=TaskDrawType(CardType.Minion);
        if(Drawn.raceType.Contains(RaceType.Beast))
        {
            TaskDrawType(CardType.Spell);
        }
    }
}
public class TOY_353:SpellBase{
//NAME=拼布好朋友
//TEXT=获取全部3种动物伙伴，其法力值消耗减少（1）点。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TOY_354:SpellBase{
//NAME=遥控狂潮
//TEXT=召唤六只1/1的猎犬。每有一只放不下的猎犬，使其余猎犬获得+1/+1。
//MAJ=HUNTER|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TOY_355:MinionBase{
//NAME=绵弹枪神赫米特
//TEXT=在一只友方野兽死亡后，随机获取一张来自过去的<b>传说</b>野兽牌，其法力值消耗减少（2）点。
//MAJ=HUNTER|COST=5|ATK=3|HP=6|RACE=NONE
}
public class TOY_356:MinionBase{
//NAME=玩具暴龙
//TEXT=<b>突袭</b> <b>亡语：</b>随机对一个敌人造成7点伤害。
//MAJ=HUNTER|COST=7|ATK=7|HP=7|RACE=BEAST
}
public class TOY_357:MinionBase{
//NAME=抱龙王噗鲁什
//TEXT=<b>冲锋</b> <b>战吼：</b>将所有攻击力小于本随从的随从移回其拥有者的牌库。
//MAJ=HUNTER|COST=9|ATK=6|HP=6|RACE=BEAST
}
public class TOY_358:WeaponBase{
//NAME=遥控器
//TEXT=在你的英雄攻击后，召唤一只1/1的猎犬。
//MAJ=HUNTER|COST=2|ATK=1|HP=3|RACE=NONE
}
public class TOY_359:LocationBase{
//NAME=丛林乐园
//TEXT=随机对一个敌人 造成1点伤害。每有一只友方野兽，重复一次。
//MAJ=HUNTER|COST=2|ATK=0|HP=2|RACE=NONE
}
public class TOY_370:MinionBase{
//NAME=三芯诡烛
//TEXT=<b>战吼：</b>随机对一个敌人造成2点伤害，触发三次。
//MAJ=MAGE|COST=4|ATK=2|HP=3|RACE=ELEMENTAL
}
public class TOY_371:SpellBase{
//NAME=加工失误
//TEXT=抽三张牌。如果你的牌库里没有随从牌，这三张牌的法力值消耗减少（3）点。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=NONE
}
public class TOY_372:SpellBase{
//NAME=匣中古神
//TEXT=随机施放5个法术。如果你的牌库里没有随从牌，则这些法术的法力值消耗大于或等于（5）点。
//MAJ=MAGE|COST=8|ATK=0|HP=0|RACE=SHADOW
}
public class TOY_373:MinionBase{
//NAME=益智大师卡德加
//TEXT=<b>战吼：</b>装备一个会施放有用的法师法术的0/6的魔法智慧之球！
//MAJ=MAGE|COST=6|ATK=5|HP=5|RACE=NONE
}
public class TOY_374:SpellBase{
//NAME=找不同
//TEXT=<b>发现</b>并召唤一个法力值消耗为（3）的随从。如果你的牌库中没有随从牌，重复此效果。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TOY_375:MinionBase{
//NAME=滑冰元素
//TEXT=<b>微缩</b> <b>战吼：</b><b>冻结</b>一个敌方随从，获得等同于其攻击力的护甲值。
//MAJ=MAGE|COST=5|ATK=3|HP=4|RACE=ELEMENTAL
}
public class TOY_376:MinionBase{
//NAME=水彩美术家
//TEXT=<b>战吼：</b>抽一张冰霜法术牌，在你的回合开始时，其法力值消耗减少（1）点。
//MAJ=MAGE|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class TOY_377:SpellBase{
//NAME=霜巫十字绣
//TEXT=对一个角色造成$3点伤害。如果该角色死亡，召唤一个3/6的可以<b><b>冻结</b></b>攻击目标的水元素。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=FROST
}
public class TOY_378:SpellBase{
//NAME=星空投影球
//TEXT=再次施放你在本局对战中施放过的法术，每种法力值消耗各随机一个。<i>（尽可能以敌人为目标）</i>
//MAJ=MAGE|COST=10|ATK=0|HP=0|RACE=ARCANE
    public override void Battlecry(Card target=null)
    {
        List<CardDbf> ToListCast = new List<CardDbf>();
        List<Card> PossibleCards = new List<Card>();
        for(int i=0;i<11;i++)
        {
            PossibleCards.Clear();
            foreach(Card c in owner.myPlayer.grave)
            {
                if(c.cardType==CardType.Spell && c.GetTag(GameTag.Mana) == i)
                {
                    PossibleCards.Add(c);
                }
            }
            Card ToCast = PossibleCards.Choice(owner.myPlayer.randomGen);
            if(ToCast!=null)
            {
                ToListCast.Add(ToCast.cardDbf);
            }
        }
        foreach(CardDbf cdb in ToListCast)
        {
            bool Valid = true;
            Card Target = null;
            if(cdb.Targets!=TargetingOptions.NoTarget)
            {
                Target = owner.myPlayer.GetValidTargetMatchOption(cdb.Targets).Choice(owner.myPlayer.randomGen);
                if(Target==null)
                {
                    Valid=false;
                }
            }
            Card c = TaskCreate(CardDbf.GetCardDbfByGuid(cdb.m_noteMiniGuid),ZoneType.Hand);
            new EffectPlay(owner.myPlayer,c,Target).Resolve();
        }
    }
}
public class TOY_380:MinionBase{
//NAME=黏土巢母
//TEXT=<b>微缩</b> <b>嘲讽</b>。<b>亡语：</b>召唤一条4/4并具有<b>扰魔</b>的雏龙。
//MAJ=PRIEST|COST=6|ATK=3|HP=7|RACE=DRAGON
}
public class TOY_381:MinionBase{
//NAME=纸艺天使
//TEXT=你的英雄技能的法力值消耗为（0）点。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=NONE
}
public class TOY_382:MinionBase{
//NAME=粗心的匠人
//TEXT=<b>亡语：</b> 获取两张法力值消耗为（0）的可以恢复3点生命值的绷带。
//MAJ=PRIEST|COST=3|ATK=3|HP=3|RACE=NONE
}
public class TOY_383:MinionBase{
//NAME=重封者拉兹
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，每当你使用卡牌时，复原你的英雄技能。
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=NONE
}
public class TOY_384:SpellBase{
//NAME=净化之力
//TEXT=<b>沉默</b>所有友方随从，然后使其获得+1/+2。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class TOY_385:MinionBase{
//NAME=时空扭曲者扎里米
//TEXT=<b>战吼：</b>每场对战限一次。如果你召唤过8条其他的龙，获得一个额外回合。@<i>（还剩{0}条！）</i>@<i>（已经就绪！）</i>
//MAJ=PRIEST|COST=5|ATK=4|HP=6|RACE=DRAGON
}
public class TOY_386:MinionBase{
//NAME=礼盒雏龙
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，使该龙牌和本随从获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=DRAGON
}
public class TOY_387:SpellBase{
//NAME=对照鳞摹
//TEXT=抽取你法力值消耗最低和最高的龙牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card LowestCost = null;
        Card HightestCost = null;
        foreach(Card c in owner.myPlayer.deck){
            if(c.raceType.Contains(RaceType.Dragon))
            {
                if(LowestCost==null)
                {
                    LowestCost=c;
                }
                if(HightestCost==null)
                {
                    HightestCost=c;
                }
                int Num = c.GetTag(GameTag.Mana);
                if(Num<=LowestCost.GetTag(GameTag.Mana))
                {
                    LowestCost=c;
                }
                if(Num>=HightestCost.GetTag(GameTag.Mana))
                {
                    HightestCost=c;
                }
            }
        }
        if(LowestCost!=null)
        {
            TaskDraw(LowestCost);
        }
        if(HightestCost!=null)
        {
            if(HightestCost!=LowestCost)
            {
                TaskDraw(HightestCost);
            }
        }
    }
}
public class TOY_388:MinionBase{
//NAME=粉笔美术家
//TEXT=<b>战吼：</b>抽一张随从牌，将其变形成为随机<b>传说</b>随从牌<i>（保留其原始属性值和法力值消耗）</i>。
//MAJ=PRIEST|COST=4|ATK=4|HP=3|RACE=NONE
}
public class TOY_390:MinionBase{
//NAME=清仓销售员
//TEXT=<b>亡语：</b>使你手牌中两张法术牌的法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=NONE
}
public class TOY_391:MinionBase{
//NAME=漫画美术家
//TEXT=<b>战吼：</b>抽一张法力值消耗大于或等于（5）点的随从牌，给它画上滑稽的小胡子！
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=NONE
}
public class TOY_500:SpellBase{
//NAME=苏打火山
//TEXT=<b>吸血</b>。造成$10点伤害，随机分配到所有随从身上。<b>过载：</b>（1）
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=FIRE
    public override void Init()
    {
        TaskInitAbility("LifeSteal");
    }
    public override void Battlecry(Card target=null)
    {
        TaskDamageRandomDistributeTargets(owner.myPlayer.otherPlayer.board,10);
    }
}
public class TOY_501:MinionBase{
//NAME=沙德木刻
//TEXT=<b>微缩</b> <b>战吼：</b>你的下一个<b>战吼</b>会触发3次，但无法伤害敌方英雄。
//MAJ=SHAMAN|COST=6|ATK=5|HP=5|RACE=NONE
}
public class TOY_503:MinionBase{
//NAME=闪岩哨兵
//TEXT=<b>嘲讽</b>。<b>扰魔</b> <b>战吼：</b>召唤一个本随从的复制。
//MAJ=SHAMAN|COST=7|ATK=3|HP=7|RACE=ELEMENTAL
}
public class TOY_504:MinionBase{
//NAME=神秘女巫哈加莎
//TEXT=<b>战吼：</b>抽两张法力值消耗大于或等于（5）点的法术牌，并将其变形成为会施放对应法术的泥浆怪。
//MAJ=SHAMAN|COST=4|ATK=4|HP=3|RACE=NONE
}
public class TOY_505:MinionBase{
//NAME=玩具船
//TEXT=在你召唤一个海盗后，抽一张牌。
//MAJ=ROGUE|COST=2|ATK=2|HP=3|RACE=NONE
   public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,CauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,CauseEvent));
    }

    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(tz==ZoneType.Board && (sc.raceType.Contains(RaceType.Pirate)) && owner.GetTag(GameTag.ZoneType) == (int)ZoneType.Board)
        {
            TaskDraw();
        }
    }
}
public class TOY_506:SpellBase{
//NAME=很久以前……
//TEXT=随机召唤法力 值消耗为（3）的野兽，龙，元素和鱼人各一个。
//MAJ=SHAMAN|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class TOY_507:LocationBase{
//NAME=童话林地
//TEXT=抽一张<b>战吼</b>随从牌，其法力值消耗减少（1）点。
//MAJ=SHAMAN|COST=3|ATK=0|HP=2|RACE=NONE
}
public class TOY_508:SpellBase{
//NAME=立体书
//TEXT=造成$2点伤害。召唤两只0/1并具有<b>嘲讽</b>的青蛙。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class TOY_509:MinionBase{
//NAME=发条演奏家
//TEXT=<b>可交易</b> <b>战吼：</b>对所有敌方随从造成1点伤害。<i>（<b>交易</b>后升级！）</i>
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class TOY_510:SpellBase{
//NAME=挖掘宝藏
//TEXT=抽一张随从牌。如果是海盗牌，获取一张幸运币。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card Drawn = TaskDrawType(CardType.Minion);
        if(Drawn.raceType.Contains(RaceType.Pirate))
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("GAME_005"),ZoneType.Hand);
        }
    }
}
public class TOY_511:MinionBase{
//NAME=大盗金胡子
//TEXT=在你召唤一个海盗后，召唤一个它的复制并使其攻击随机敌人然后死亡。
//MAJ=ROGUE|COST=5|ATK=5|HP=5|RACE=PIRATE
}
public class TOY_512:LocationBase{
//NAME=水晶海湾
//TEXT=在本回合中，你召唤的下一个随从的属性值变为5/5。
//MAJ=ROGUE|COST=3|ATK=0|HP=3|RACE=NONE
}
public class TOY_513:MinionBase{
//NAME=沙画元素
//TEXT=<b>微缩</b> <b>战吼：</b>在本回合中，使你的英雄获得+1攻击力和<b>风怒</b>。
//MAJ=SHAMAN|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class TOY_514:SpellBase{
//NAME=菊花茶具
//TEXT=<b>发现</b>一张另一职业的法术牌，并获取一张它的复制。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TOY_515:MinionBase{
//NAME=水上舞者索尼娅
//TEXT=在你使用一张法力值消耗为（1）的卡牌后，获取一张它的法力值消耗为（0）点的复制。
//MAJ=ROGUE|COST=4|ATK=3|HP=3|RACE=NONE
}
public class TOY_516:MinionBase{
//NAME=折价区海盗
//TEXT=<b>突袭</b>。<b>连击：</b>召唤一个本随从的复制。
//MAJ=ROGUE|COST=3|ATK=3|HP=2|RACE=PIRATE
}
public class TOY_517:MinionBase{
//NAME=泼漆彩鳍鱼人
//TEXT=<b>剧毒</b>。<b>战吼：</b>抽一张<b>突袭</b>随从牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=MURLOC
}
public class TOY_518:MinionBase{
//NAME=宝藏经销商
//TEXT=在你召唤一个海盗后，使它和本随从各获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=PIRATE
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
        if(sc!=owner && tz==ZoneType.Board && (sc.raceType.Contains(RaceType.Pirate)) && owner.GetTag(GameTag.ZoneType) == (int)ZoneType.Board)
        {
        	new EffectChange(owner.myPlayer,owner,sc,atkChange:1).Resolve();
        	new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
        }
    }
}
public class TOY_519:SpellBase{
//NAME=一件不留
//TEXT=随机召唤两个法力值消耗为（4）的随从。在本回合中你每抽过一张牌，本牌的法力值消耗便减少（1）点。
//MAJ=ROGUE|COST=8|ATK=0|HP=0|RACE=NONE
}
public class TOY_520:MinionBase{
//NAME=秘迹观测者
//TEXT=<b>战吼：</b> 随机施放2个<b>奥秘</b>。在你的回合开始时，摧毁这些奥秘。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=DEMON
}
public class TOY_521:MinionBase{
//NAME=沙箱恶霸
//TEXT=<b>微缩</b> <b>战吼：</b>在本回合中，你的下一张牌法力值消耗减少（3）点。
//MAJ=ROGUE|COST=5|ATK=4|HP=3|RACE=PIRATE
}
public class TOY_522:WeaponBase{
//NAME=水弹枪
//TEXT=在你的英雄攻击后，召唤一个1/1的海盗，并使其随机攻击一个敌人。
//MAJ=ROGUE|COST=4|ATK=3|HP=3|RACE=NONE
}
public class TOY_524:MinionBase{
//NAME=游戏主持奈姆希
//TEXT=<b>战吼：</b>抽一张恶魔牌。<b>亡语：</b>与其交换位置。
//MAJ=WARLOCK|COST=5|ATK=3|HP=6|RACE=NONE
}
public class TOY_526:MinionBase{
//NAME=凶魔城堡
//TEXT=<b>战吼：</b>攻击<b>你的</b> 英雄。
//MAJ=WARLOCK|COST=3|ATK=5|HP=6|RACE=DEMON
}
public class TOY_527:SpellBase{
//NAME=诅咒之旅
//TEXT=使一个友方随从获得“<b>亡语：</b>召唤本随从的两个<b>休眠</b>2回合的复制。”
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class TOY_528:MinionBase{
//NAME=伴唱机
//TEXT=你的英雄技能会触发两次。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=MECHANICAL
}
public class TOY_529:SpellBase{
//NAME=死亡轮盘
//TEXT=摧毁你的牌库。5回合后，消灭敌方英雄。
//MAJ=WARLOCK|COST=8|ATK=0|HP=0|RACE=SHADOW
}
public class TOY_530:MinionBase{
//NAME=游乐巨人
//TEXT=在本局对战中 你每抽过一张牌，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=20|ATK=8|HP=8|RACE=MECHANICAL
    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            return -owner.myPlayer.GetTag(GameTag.CntDraw);
        }
        return 0;
    }
}
public class TOY_531:MinionBase{
//NAME=商店经理莉娜
//TEXT=每当你施放一个法术，用法力值消耗相同的随机随从填满你 的面板。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=3|RACE=NONE
}
public class TOY_601:MinionBase{
//NAME=工厂装配机
//TEXT=<b>微缩</b> 在你的回合结束时，召唤一个6/7的机器人并使其攻击一个随机敌人。
//MAJ=NEUTRAL|COST=10|ATK=6|HP=7|RACE=MECHANICAL
}
public class TOY_602:SpellBase{
//NAME=化工泄漏
//TEXT=从你的手牌中召唤法力值消耗最高的随从，然后对其造成$5点伤害。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card MaxCost = null;
        foreach(Card c in owner.myPlayer.hand)
        {
            if(c.cardType==CardType.Minion)
            {
                if(MaxCost==null)
                {
                    MaxCost=c;
                }
                else{
                    if(c.GetTag(GameTag.Mana)>MaxCost.GetTag(GameTag.Mana))
                    {
                        MaxCost=c;
                    }
                }
            }
        }
        if(MaxCost!=null)
        {
            new EffectChange(owner.myPlayer,owner,MaxCost).Resolve();
            new EffectMove(owner.myPlayer,MaxCost,ZoneType.Hand,ZoneType.Board).Resolve();
            new EffectDamage(owner.myPlayer,owner,MaxCost,5).Resolve();
        }
    }
}
public class TOY_603:SpellBase{
//NAME=炮灰出动
//TEXT=选择一个友方机械，召唤一个它的复制并使其攻击随机敌人然后死亡。
//MAJ=WARRIOR|COST=3|ATK=0|HP=0|RACE=NONE
}
public class TOY_604:WeaponBase{
//NAME=砰砰扳手
//TEXT=<b>微缩</b> <b>亡语：</b>随机触发一个友方机械的<b>亡语</b>。
//MAJ=WARRIOR|COST=4|ATK=3|HP=2|RACE=NONE
}
public class TOY_605:SpellBase{
//NAME=质量保证
//TEXT=抽两张<b>嘲讽</b>随从牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TOY_606:MinionBase{
//NAME=测试假人
//TEXT=<b>嘲讽</b>。<b>亡语：</b>造成8点伤害，随机分配到所有敌人身上。
//MAJ=WARRIOR|COST=6|ATK=4|HP=8|RACE=MECHANICAL
}
public class TOY_607:MinionBase{
//NAME=发明家砰砰
//TEXT=<b>战吼：</b>复活两个法力值消耗大于或等于（5）点的友方机械，并使其立即随机攻击敌人。
//MAJ=WARRIOR|COST=8|ATK=7|HP=7|RACE=NONE
}
public class TOY_640:SpellBase{
//NAME=工坊事故
//TEXT=对一个随从造成$5点伤害，相邻的随从均会受到超过其生命值的伤害。<b>流放：</b>获得<b>吸血</b>。
//MAJ=DEMONHUNTER|COST=4|ATK=0|HP=0|RACE=FEL
}
public class TOY_641:WeaponBase{
//NAME=裁判拳套
//TEXT=<b>亡语：</b>抽一张恶魔牌，并使其法力值消耗减少（2）点。
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=2|RACE=NONE
}
public class TOY_642:MinionBase{
//NAME=球霸野猪人
//TEXT=<b>吸血</b>。<b>战吼，亡语：</b>对生命值最低的敌人造成3点伤害。
//MAJ=DEMONHUNTER|COST=4|ATK=3|HP=3|RACE=QUILBOAR
}
public class TOY_643:SpellBase{
//NAME=盲盒
//TEXT=随机获取2张恶魔牌。<b>流放：</b>改为<b>发现</b>。
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TOY_644:SpellBase{
//NAME=红牌
//TEXT=使一个随从<b>休眠</b>2回合。
//MAJ=DEMONHUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TOY_645:SpellBase{
//NAME=小型法术欧珀石
//TEXT=抽一张牌。<i>（用你的英雄攻击2次后升级。）</i>
//MAJ=DEMONHUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TOY_646:MinionBase{
//NAME=捣蛋林精
//TEXT=<b>吸血</b>。<b>嘲讽</b> <b>亡语：</b>对所有敌人造成1点伤害。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=3|RACE=NONE
}
public class TOY_647:MinionBase{
//NAME=玛瑟里顿（未发售版）
//TEXT=<b>休眠</b>2回合。<b>休眠</b>状态下，在你的回合结束时，对所有敌人造成3点伤害。
//MAJ=DEMONHUNTER|COST=8|ATK=12|HP=12|RACE=DEMON
}
public class TOY_651:MinionBase{
//NAME=实验室奴隶主
//TEXT=每当你获得护甲值，召唤另一个实验室奴隶主<i>（每回合一次）</i>。
//MAJ=WARRIOR|COST=4|ATK=3|HP=3|RACE=NONE
}
public class TOY_652:MinionBase{
//NAME=橱窗看客
//TEXT=<b>微缩</b> <b>战吼：</b><b>发现</b>一张恶魔牌，将其属性值与法力值消耗变为与本随从相同。
//MAJ=DEMONHUNTER|COST=5|ATK=6|HP=5|RACE=DEMON
}
public class TOY_670:MinionBase{
//NAME=欢乐的玩具匠
//TEXT=<b>亡语：</b>召唤两个1/2并具有<b>嘲讽</b>和<b>圣盾</b>的 机械。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=1|RACE=NONE
}
public class TOY_700:MinionBase{
//NAME=酷炫的威兹班
//TEXT=你改用威兹班的一副试验套牌来开始 对战！
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class TOY_703:MinionBase{
//NAME=美术家可丽菲罗
//TEXT=<b>战吼：</b>抽一张随从牌，将所有其他友方随从变形成为它的复制。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=5|RACE=ELEMENTAL
}
public class TOY_714:SpellBase{
//NAME=飞速离架
//TEXT=对所有敌方随从造成$1点伤害。你手牌中每有一张龙牌，重复一次。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int Cnt=1;
        foreach(Card c in owner.myPlayer.hand)
        {
            if(c.raceType.Contains(RaceType.Dragon))
            {
                Cnt+=1;
            }
        }
        for(int i=0;i<Cnt;i++)
        {
            TaskDamageTargets(owner.myPlayer.otherPlayer.board,1);
        }
    }
}
public class TOY_716:SpellBase{
//NAME=光速抢购
//TEXT=召唤一个1/2并具有<b>圣盾</b>和<b>嘲讽</b>的机械。使你的随从获得+1/+2。
//MAJ=PALADIN|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TOY_800:SpellBase{
//NAME=闪光试剂瓶
//TEXT=造成$2点伤害。在本回合中，你的下一张牌减少与伤害量相同的法力值消耗。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class TOY_801:MinionBase{
//NAME=绿植幼龙
//TEXT=<b>微缩</b> <b>抉择：</b>获得<b>法术伤害+1</b>；或者抽一张法术牌。
//MAJ=DRUID|COST=4|ATK=3|HP=5|RACE=DRAGON
}
public class TOY_802:MinionBase{
//NAME=发条树苗
//TEXT=<b>可交易</b> <b>战吼：</b>复原1个法力水晶。<i>（<b>交易</b>后升级！）</i>
//MAJ=DRUID|COST=2|ATK=2|HP=1|RACE=NONE
}
public class TOY_803:MinionBase{
//NAME=青玉展品
//TEXT=<b>亡语：</b>在本局对战中，你的青玉展品拥有+1/+1。将2张青玉展品洗入你的牌库。
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=NONE
}
public class TOY_804:SpellBase{
//NAME=林中奇遇
//TEXT=召唤两只2/5并具有<b>嘲讽</b>的甲虫。如果你拥有<b>法术伤害</b>，本牌的法力值消耗减少（3）点。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class TOY_805:SpellBase{
//NAME=缩小术
//TEXT=使你牌库中随从牌的法力值消耗和攻击力减少（1）点。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NATURE
}
public class TOY_806:MinionBase{
//NAME=天空慈母艾维娜
//TEXT=<b>战吼：</b>随机将10张<b>传说</b>随从牌洗入你的牌库，其法力值消耗为（1）点。
//MAJ=DRUID|COST=5|ATK=5|HP=5|RACE=NONE
}
public class TOY_807:MinionBase{
//NAME=欧洛尼乌斯
//TEXT=<b>法术伤害+1</b>。你的法术受到的<b>法术伤害</b>增益效果翻倍。
//MAJ=DRUID|COST=7|ATK=6|HP=6|RACE=NONE
}
public class TOY_808:SpellBase{
//NAME=工匠光环
//TEXT=在你的回合结束时，随机召唤一个法力值消耗为（6）的随从。持续3回合。
//MAJ=PALADIN|COST=7|ATK=0|HP=0|RACE=HOLY
}
public class TOY_809:MinionBase{
//NAME=纸板魔像
//TEXT=<b>战吼：</b>使你手牌，牌库和战场上的光环持续时间提高1回合。
//MAJ=PALADIN|COST=4|ATK=4|HP=4|RACE=NONE
}
public class TOY_810:WeaponBase{
//NAME=画师的美德
//TEXT=<b>吸血</b> 在你的英雄攻击后，使你手牌中的随从牌获得+1/+1。
//MAJ=PALADIN|COST=4|ATK=2|HP=3|RACE=NONE
}
public class TOY_811:MinionBase{
//NAME=绒绒虎
//TEXT=<b>微缩</b> <b>突袭</b>，<b>吸血</b>，<b>圣盾</b>
//MAJ=PALADIN|COST=4|ATK=3|HP=2|RACE=BEAST
}
public class TOY_812:MinionBase{
//NAME=皮普希·彩蹄
//TEXT=<b>亡语：</b>随机从你的牌库中召唤<b>圣盾</b>，<b>突袭</b>和<b>嘲讽</b>随从各一个。
//MAJ=PALADIN|COST=7|ATK=4|HP=4|RACE=NONE
}
public class TOY_813:MinionBase{
//NAME=玩具队长塔林姆
//TEXT=<b>微缩</b> <b>嘲讽</b>。<b>战吼：</b>将一个随从的攻击力和生命值变为与本随从相同。
//MAJ=PALADIN|COST=5|ATK=3|HP=7|RACE=NONE
}
public class TOY_814:MinionBase{
//NAME=玩具兵盒
//TEXT=<b>亡语：</b>召唤五个1/1并具有随机<b>额外效果</b>的士兵。
//MAJ=NEUTRAL|COST=3|ATK=0|HP=2|RACE=NONE
}
public class TOY_820:MinionBase{
//NAME=废弃电子玩偶
//TEXT=在你的回合结束时，消灭一个攻击力低于本随从的随从。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=6|RACE=MECHANICAL
}
public class TOY_821:MinionBase{
//NAME=毛绒暴暴狗
//TEXT=<b>突袭</b> 在你施放一个冰霜法术后，获得<b>复生</b>。
//MAJ=DEATHKNIGHT|COST=3|ATK=4|HP=2|RACE=UNDEAD
}
public class TOY_822:SpellBase{
//NAME=蛛丝缝纫
//TEXT=选择一个友方随从，为其<b>发现</b>一个法力值消耗小于或等于（4）点的法术，当该随从死亡时会施放。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TOY_823:MinionBase{
//NAME=彩虹裁缝
//TEXT=<b>战吼：</b>如果你的套牌中有鲜血，冰霜或邪恶符文牌，则对应获得<b>吸血</b>，<b>复生</b>或<b>突袭</b>。
//MAJ=DEATHKNIGHT|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class TOY_824:MinionBase{
//NAME=黑棘针线师
//TEXT=在你的回合结束时，造成等同于本随从攻击力的伤害，随机分配到所有敌人身上。
//MAJ=DEATHKNIGHT|COST=4|ATK=2|HP=4|RACE=UNDEAD
}
public class TOY_825:SpellBase{
//NAME=小型法术尖晶石
//TEXT=使你手牌中的亡灵牌获得+1/+1。<i>（获得5具<b>尸体</b>后升级。）</i>
//MAJ=DEATHKNIGHT|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TOY_826:SpellBase{
//NAME=绝望线缕
//TEXT=使所有随从获得“<b>亡语：</b>对所有随从造成1点伤害。”
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        List<Card> targs=owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board);
        List<string> abis = new List<string>();
        foreach(Card c in targs)
        {
            TOY_826e newAbi = new TOY_826e();
            newAbi.SrcCard=owner;
            newAbi.AttachTo(c);
            //c.abilityList.Add();
            abis.Add("TOY_827");
        }
        new EffectGiveAbility(owner.myPlayer,owner,targets:targs,abinames:abis).Resolve();
    }
}
public class TOY_826e:SpellBase{
    public Card SrcCard = null;
    public override void Deathrattle()
    {     
        List<Card> targs=owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board);
        List<int> abis = new List<int>();
        foreach(Card c in targs)
        {
            abis.Add(1);
        }
        new EffectDamage(owner.myPlayer,SrcCard,targets:targs,amounts:abis).Resolve();
    }
}
public class TOY_827:MinionBase{
//NAME=蹒跚的僵尸坦克
//TEXT=<b>嘲讽</b>。<b>战吼：</b>消耗5具<b>尸体</b>以召唤一个本随从的复制。
//MAJ=DEATHKNIGHT|COST=2|ATK=3|HP=2|RACE=UNDEAD
}
public class TOY_828:MinionBase{
//NAME=业余傀儡师
//TEXT=<b>微缩</b> <b>嘲讽</b>。<b>亡语：</b>使你手牌中的亡灵牌获得+2/+2。
//MAJ=DEATHKNIGHT|COST=5|ATK=2|HP=6|RACE=UNDEAD
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        
    }
}
public class TOY_829:HeroBase{
//NAME=无头骑士
//TEXT=<b>战吼：</b>消灭攻击力最高的敌方<i>随从</i>！将我的头洗入牌库，你必须找到它的<i>行踪</i>！
//MAJ=DEATHKNIGHT|COST=6|ATK=0|HP=30|RACE=NONE
}
public class TOY_830:MinionBase{
//NAME=玩具医生斯缔修
//TEXT=<b>战吼：</b><b>发现</b>法力值消耗为（5），（3）和（1）点的随从各一个，缝合到本随从上。<b>亡语：</b>召唤发现的法力值消耗为（5）的随从。
//MAJ=DEATHKNIGHT|COST=6|ATK=6|HP=4|RACE=UNDEAD
}
public class TOY_850:LocationBase{
//NAME=魔法妙妙屋
//TEXT=在本回合中获得<b>法术伤害+1</b>。
//MAJ=DRUID|COST=1|ATK=0|HP=3|RACE=NONE
}
public class TOY_851:SpellBase{
//NAME=无底玩具箱
//TEXT=从你的牌库中<b>发现</b>一张牌。如果你拥有<b>法术伤害</b>，复制发现的牌。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class TOY_866:MinionBase{
//NAME=通道沉眠者
//TEXT=起始<b>休眠</b>状态。在7个随从死亡后唤醒。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=5|RACE=BEAST
}
public class TOY_877:SpellBase{
//NAME=星空祈愿
//TEXT=使你手牌，牌库和战场上的所有随从获得+2/+3。
//MAJ=SHAMAN|COST=7|ATK=0|HP=0|RACE=ARCANE
}
public class TOY_878:MinionBase{
//NAME=扮装选手
//TEXT=在你的对手使用一张随从牌后，变形成为它的3/4的复制。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class TOY_879:SpellBase{
//NAME=重新打包
//TEXT=将所有随从封入一个法力值消耗为（2）的箱子，然后将其洗入对手的牌库。
//MAJ=PRIEST|COST=7|ATK=0|HP=0|RACE=NONE
}
public class TOY_880:MinionBase{
//NAME=发条执行者
//TEXT=<b>可交易</b> <b>战吼：</b>召唤本随从的1个复制。<i>（<b>交易</b>后升级！）</i>
//MAJ=PALADIN|COST=6|ATK=3|HP=5|RACE=NONE
}
public class TOY_881:SpellBase{
//NAME=光鲜包装
//TEXT=使一个具有<b>圣盾</b>的随从获得+2/+3。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TOY_882:MinionBase{
//NAME=装饰美术家
//TEXT=<b>战吼：</b>抽一张<b>圣盾</b>随从牌和一张光环牌。
//MAJ=PALADIN|COST=3|ATK=2|HP=3|RACE=NONE
}
public class TOY_883:SpellBase{
//NAME=掀桌子
//TEXT=对所有敌方随从造成$3点伤害。你每有一张其他手牌，本牌的法力值消耗便减少（1）点。
//MAJ=WARLOCK|COST=10|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.otherPlayer.board,3);
    }
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
public class TOY_884:SpellBase{
//NAME=抓娃娃
//TEXT=召唤你牌库中两个恶魔的各一个复制。
//MAJ=WARLOCK|COST=8|ATK=0|HP=0|RACE=SHADOW
}
public class TOY_886:SpellBase{
//NAME=决胜时刻
//TEXT=复活上一个死亡的你的恶魔。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class TOY_891:MinionBase{
//NAME=工坊保洁员
//TEXT=<b>战吼：</b>如果你控制着地标，抽两张牌。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class TOY_893:MinionBase{
//NAME=套娃傀儡
//TEXT=<b>亡语：</b>再次召唤本随从并具有-1/-1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=3|RACE=UNDEAD
}
public class TOY_894:MinionBase{
//NAME=折纸青蛙
//TEXT=<b>突袭</b>。<b>战吼：</b>与另一个随从交换攻击力。
//MAJ=NEUTRAL|COST=5|ATK=1|HP=4|RACE=BEAST
}
public class TOY_895:MinionBase{
//NAME=折纸仙鹤
//TEXT=<b>嘲讽</b>。<b>战吼：</b>与另一个随从交换生命值。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=1|RACE=BEAST
}
public class TOY_896:MinionBase{
//NAME=折纸巨龙
//TEXT=<b>圣盾</b>，<b>吸血</b> <b>战吼：</b>与另一个随从交换属性值。
//MAJ=NEUTRAL|COST=6|ATK=1|HP=1|RACE=DRAGON
}
public class TOY_897:MinionBase{
//NAME=软软多头蛇
//TEXT=<b>亡语：</b>将本随从的一张永久具有翻倍攻击力和生命值的复制洗入你的牌库。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class TOY_906:MinionBase{
//NAME=机械腐面
//TEXT=<b>嘲讽</b>。在本随从受到伤害后，随机获取两张<b>微型</b>牌。
//MAJ=WARRIOR|COST=9|ATK=4|HP=12|RACE=MECHANICAL
}
public class TOY_907:SpellBase{
//NAME=安全护目镜
//TEXT=获得6点护甲值。如果你没有护甲值，本牌的法力值消耗为（0）点。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TOY_908:MinionBase{
//NAME=焰火机师
//TEXT=<b>亡语：</b> 召唤两个1/1的砰砰机器人。<i>警告：该机器人随时可能爆炸。</i>
//MAJ=WARRIOR|COST=5|ATK=5|HP=5|RACE=MECHANICAL
}
public class TOY_913:MinionBase{
//NAME=希希集
//TEXT=<b>亡语：</b>随机获取3张初版恶魔猎手卡牌<i>（品相完美）</i>。
//MAJ=DEMONHUNTER|COST=4|ATK=4|HP=3|RACE=NONE
}
public class TOY_914:MinionBase{
//NAME=邪鬼皇后
//TEXT=<b>嘲讽</b> <b>亡语：</b>召唤两个4/6并具有<b>嘲讽</b>的骑士。
//MAJ=WARLOCK|COST=8|ATK=4|HP=4|RACE=DEMON
}
public class TOY_915:MinionBase{
//NAME=桌游角色扮演玩家
//TEXT=<b>微缩</b> <b>战吼：</b>在本回合中，使一个友方恶魔获得+2攻击力和<b>免疫</b>。
//MAJ=WARLOCK|COST=4|ATK=4|HP=3|RACE=NONE
}
public class TOY_916:MinionBase{
//NAME=速写美术家
//TEXT=<b>战吼：</b>抽一张暗影法术牌，获取一张它的<b>临时</b>复制。
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=NONE
}
public class TOY_943:MinionBase{
//NAME=大作战狂热玩家
//TEXT=在你使用最左或最右边的一张手牌后，随机对一个敌人造成1点伤害。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=NONE
}
public class TOY_960:MinionBase{
//NAME=欢乐术师耶比托
//TEXT=<b>战吼：</b>获取你在本局对战中使用过的每个生命值为1点或攻击力为1点的随从的各一张复制。
//MAJ=NEUTRAL|COST=8|ATK=6|HP=6|RACE=NONE
}
