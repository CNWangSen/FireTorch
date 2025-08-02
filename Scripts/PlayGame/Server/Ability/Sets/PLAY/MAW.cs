using System.Collections;
using System.Collections.Generic;

public class MAW_000:MinionBase{
//NAME=冒牌小鬼
//TEXT=<b>战吼：</b>选择一个友方小鬼，变形成为一个它的复制。
//MAJ=WARLOCK|COST=2|ATK=1|HP=1|RACE=DEMON
}
public class MAW_001:SpellBase{
//NAME=纵火指控
//TEXT=选择一个随从，在你的英雄受到伤害后将其消灭。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class MAW_001e:Ability{
//NAME=纵火庭审
//TEXT=当你的英雄受到伤害时，消灭被指控的随从。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_001e2:Ability{
//NAME=被控纵火
//TEXT=当指控者受到伤害时，本随从死亡。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_002:SpellBase{
//NAME=尸身保护令
//TEXT=<b>发现</b>并复活一个友方随从，使其获得<b>突袭</b>。该随从会在回合结束时死亡。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class MAW_002e:Ability{
//NAME=遗体保护
//TEXT=在回合结束时死亡。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_003:SpellBase{
//NAME=图腾物证
//TEXT=选择一个基础图腾并召唤它。 <b>注能（3个图腾）：</b>改为召唤全部4个。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class MAW_003t:SpellBase{
//NAME=图腾物证
//TEXT=<b>已注能</b> 召唤全部4个基础图腾。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class MAW_004:MinionBase{
//NAME=搜魂者
//TEXT=<b>战吼：</b>将本随从与你对手牌库中的一个随机随从互换。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class MAW_005:MinionBase{
//NAME=栽赃者
//TEXT=<b>战吼：</b>将3张栽赃牌洗入你对手的牌库。当抽到栽赃牌时，使其<b>过载</b>（2）。
//MAJ=SHAMAN|COST=3|ATK=3|HP=3|RACE=NONE
}
public class MAW_005t:SpellBase{
//NAME=遭遇栽赃
//TEXT=<b>抽到时施放</b> <b>过载：</b>（2）
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_006:SecretBase{
//NAME=异议
//TEXT=<b>奥秘：</b>当你的对手使用一张随从牌时，<b>反制</b>该随从。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class MAW_008:MinionBase{
//NAME=盲眼法官
//TEXT=<b>战吼：</b>双方玩家抽若干数量的牌，直到拥有5张手牌。
//MAJ=DEMONHUNTER|COST=4|ATK=5|HP=4|RACE=NONE
}
public class MAW_009:MinionBase{
//NAME=影犬
//TEXT=每当本随从攻击时，使你的其他野兽获得+2/+2。 <b>注能（3只野兽）：</b> 获得<b>突袭</b>。
//MAJ=HUNTER|COST=5|ATK=6|HP=5|RACE=BEAST
}
public class MAW_009e:Ability{
//NAME=噬渊连结
//TEXT=+2/+2。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_009t:MinionBase{
//NAME=影犬
//TEXT=<b>已注能</b> <b>突袭</b>。每当本随从攻击时，使你的其他野兽获得+2/+2。
//MAJ=HUNTER|COST=5|ATK=6|HP=5|RACE=BEAST
}
public class MAW_010:SecretBase{
//NAME=否决动议
//TEXT=<b>奥秘：</b>在你的对手在一回合中使用三张牌后，对敌方英雄造成$6点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class MAW_010t:SecretBase{
//NAME=强化否决动议
//TEXT=<b>奥秘：</b>当你的对手在一回合中使用三张牌后，对敌方英雄造成$9点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class MAW_011:MinionBase{
//NAME=辩护律师纳萨诺斯
//TEXT=<b>战吼：</b><b>发现</b>一个在本局对战中死亡的友方<b>亡语</b>随从，获得其<b>亡语</b>，然后触发。
//MAJ=HUNTER|COST=6|ATK=4|HP=4|RACE=UNDEAD
}
public class MAW_011e:Ability{
//NAME=死亡辩护
//TEXT=从{0}复制的<b>亡语</b>。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_012:SpellBase{
//NAME=邪能之乱
//TEXT=召唤一个在本局对战中死亡的友方恶魔。 <b>注能（3个恶魔）：</b>改为召唤三个。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=FEL
    public override void Battlecry(Card target=null)
    {
        int Num=1;
        if(this.CntDeadDemon>=3)
        {
            Num=3;
        }
        List<CardDbf> Pool = new List<CardDbf>();
        foreach(Card c in owner.myPlayer.grave)
        {
            if(c.cardType==CardType.Minion && c.raceType.Contains(RaceType.Demon))
            {
                Pool.Add(c.cardDbf);
            }
        }
        List<CardDbf> ToListSummon = new List<CardDbf>();
        while(true)
        {
            if(ToListSummon.Count >= Num || Pool.Count==0)
            {
                break;
            }
            CardDbf ToSummon = Pool.Choice(owner.myPlayer.randomGen);
            if(ToSummon!=null)
            {
                Pool.Remove(ToSummon);
                ToListSummon.Add(ToSummon);
            }
        }
        foreach(CardDbf db in ToListSummon)
        {
            TaskCreate(db,ZoneType.Board);
        }
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
    }
    private int CntDeadDemon=0;
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc.cardType==CardType.Minion && sc.raceType.Contains(RaceType.Demon))
        {
            this.CntDeadDemon+=1;
            if(this.CntDeadDemon==3)
            {
                this.UnRegisterEventEffect();
            }
        }
    }
}
public class MAW_012t:SpellBase{
//NAME=邪能之乱
//TEXT=<b>已注能</b> 召唤三个在本局对战中死亡的友方恶魔。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=FEL
}
public class MAW_013:SpellBase{
//NAME=终身刑罚
//TEXT=将一个随从移出对战。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class MAW_014:MinionBase{
//NAME=公诉人梅尔特拉尼克斯
//TEXT=<b>战吼：</b>你的对手在其下回合中只能使用最左边和最右边的牌。
//MAJ=DEMONHUNTER|COST=4|ATK=2|HP=6|RACE=DEMON
}
public class MAW_014e2:Ability{
//NAME=真·无法使用
//TEXT=你只能使用最左边和最右边的手牌。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_015:SpellBase{
//NAME=陪审义务
//TEXT=召唤两个白银之手新兵。使你的白银之手新兵获得+1/+1。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		CardDbf ToSummon = CardDbf.GetCardDbfByGuid("CS2_101t");
		TaskCreate(ToSummon,ZoneType.Board);
		TaskCreate(ToSummon,ZoneType.Board);
        List<Card> SliverHands = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.cardDbf.m_noteMiniGuid.Contains("CS2_101t"))
            {
                SliverHands.Add(c);
            }
        }
        TaskBuffTargets(SliverHands,atk:1,hp:1);
	}
}
public class MAW_015e:Ability{
//NAME=陪审传唤
//TEXT=+1/+1
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_016:SpellBase{
//NAME=法庭秩序
//TEXT=将你的牌库按法力值消耗由高到低重新排序。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskBuffTargets(owner.myPlayer.deck);
    }
}
public class MAW_017:MinionBase{
//NAME=集体诉讼律师
//TEXT=<b>战吼：</b>如果你的牌库中没有中立卡牌，将一个随从的属性值变为1/1。
//MAJ=PALADIN|COST=2|ATK=2|HP=3|RACE=NONE
}
public class MAW_017e:Ability{
//NAME=集体诉讼
//TEXT=1/1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_018:SecretBase{
//NAME=伪证
//TEXT=<b>奥秘：</b>当你的回合开始时，<b>发现</b>并施放另一职业的一个<b>奥秘</b>。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class MAW_019:SpellBase{
//NAME=谋杀指控
//TEXT=选择一个随从，在另一个敌方随从死亡后将其消灭。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class MAW_019e:Ability{
//NAME=谋杀庭审
//TEXT=当另一个敌方随从死亡时，消灭被指控的随从。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_019e2:Ability{
//NAME=被控谋杀
//TEXT=当指控者的一个敌方随从死亡时，本随从死亡。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_020:MinionBase{
//NAME=潦草的书记员
//TEXT=<b>突袭</b>。在本回合中你每使用过一张牌，本牌的法力值消耗便减少（1）点。
//MAJ=ROGUE|COST=6|ATK=4|HP=4|RACE=NONE
}
public class MAW_021:SpellBase{
//NAME=问心无愧
//TEXT=使一个友方随从获得+2/+3和“在你对手的回合<b>扰魔</b>。”
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class MAW_021e:Ability{
//NAME=问心无愧
//TEXT=在你对手的回合<b>扰魔</b>。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_021e2:Ability{
//NAME=纯洁无瑕
//TEXT=无法成为法术或英雄技能的 目标。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_022:MinionBase{
//NAME=控罪心灵密探
//TEXT=<b>嘲讽</b>。<b>亡语：</b>随机复制你对手的两张手牌。
//MAJ=PRIEST|COST=4|ATK=2|HP=6|RACE=DRAGON
}
public class MAW_023:SpellBase{
//NAME=盗窃指控
//TEXT=选择一个随从。在你使用一张从对手处复制的卡牌后，将其消灭。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class MAW_023e:Ability{
//NAME=盗窃庭审
//TEXT=当你使用从对手处复制的卡牌时，消灭被指控的随从。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_023e2:Ability{
//NAME=被控盗窃
//TEXT=当指控者使用从其敌人处复制的卡牌时，本随从死亡。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_024:SpellBase{
//NAME=私法程序
//TEXT=在本局对战的剩余时间内，玩家会在其回合开始时额外抽一张牌。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class MAW_024e2:Ability{
//NAME=噬渊律法
//TEXT=玩家会在其回合开始时额外抽一张牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_024e3:Ability{
//NAME=噬渊律法
//TEXT=在你的回合开始时额外抽一张牌。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_025:MinionBase{
//NAME=噬渊律师
//TEXT=<b>抉择：</b><b>沉默</b>一个随从；或者使一个随从在本回合中获得<b>免疫</b>。
//MAJ=DRUID|COST=2|ATK=1|HP=3|RACE=NONE
}
public class MAW_025a:SpellBase{
//NAME=有罪！
//TEXT=<b>沉默</b>一个随从。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class MAW_025b:SpellBase{
//NAME=无罪！
//TEXT=在本回合中，使一个随从获得 <b>免疫</b>。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class MAW_025e:Ability{
//NAME=证明无罪
//TEXT=在本回合中<b>免疫</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_026:SpellBase{
//NAME=监禁
//TEXT=选择一个随从。使其<b>休眠</b>3回合。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class MAW_026e:Ability{
//NAME=服刑
//TEXT=<b>休眠</b>。 3回合后唤醒。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_026e2:Ability{
//NAME=服刑
//TEXT=
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_027:SpellBase{
//NAME=传唤出庭
//TEXT=使你的对手随机从手牌中召唤一个随从。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class MAW_028:MinionBase{
//NAME=渊誓者法警
//TEXT=<b><b>嘲讽</b>。</b><b>战吼：</b>如果你的护甲值大于或等于4点，获得+4/+4。
//MAJ=WARRIOR|COST=5|ATK=4|HP=4|RACE=NONE
}
public class MAW_028e2:Ability{
//NAME=它被告了！
//TEXT=+4/+4。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_029:MinionBase{
//NAME=武器专家
//TEXT=<b>战吼：</b>如果你装备着武器，使其获得+1/+1。否则，抽一张武器牌。
//MAJ=WARRIOR|COST=3|ATK=3|HP=2|RACE=NONE
}
public class MAW_029e2:Ability{
//NAME=锐利
//TEXT=+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_030:MinionBase{
//NAME=托加斯特管理员
//TEXT=<b>战吼：</b> 每有一个敌方随从，随机从<b>突袭</b>，<b>圣盾</b>或<b>风怒</b>中获得一项。
//MAJ=SHAMAN|COST=8|ATK=6|HP=10|RACE=NONE
}
public class MAW_030e2:Ability{
//NAME=机动
//TEXT=<b>突袭</b>
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_030e3:Ability{
//NAME=清扫
//TEXT=<b>圣盾</b>
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_030e4:Ability{
//NAME=强大
//TEXT=<b>风怒</b>。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_031:MinionBase{
//NAME=冥界侍从
//TEXT=你的<b>注能</b>牌在牌库中也会<b>注能</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class MAW_032:MinionBase{
//NAME=无语的证人
//TEXT=<b>奥秘</b>不会被揭示。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=UNDEAD
}
public class MAW_033:MinionBase{
//NAME=被告希尔瓦娜斯
//TEXT=<b>战吼：</b>消灭一个敌方随从。<b>注能（7）：</b>改为夺取其控制权。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=UNDEAD
}
public class MAW_033t:MinionBase{
//NAME=被告希尔瓦娜斯
//TEXT=<b>已注能</b> <b>战吼：</b>夺取一个敌方随从的控制权。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=UNDEAD
}
public class MAW_034:MinionBase{
//NAME=典狱长
//TEXT=<b>战吼：</b>摧毁你的牌库。本随从获得<b>免疫</b>。
//MAJ=NEUTRAL|COST=10|ATK=10|HP=10|RACE=NONE
}
public class MAW_034e:Ability{
//NAME=渊誓者
//TEXT=典狱长<b>免疫</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_034e2:Ability{
//NAME=渊誓者
//TEXT=无法死亡。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class MAW_101:MinionBase{
//NAME=契约咒术师
//TEXT=你每控制一个<b>奥秘</b>，本牌的法力值消耗便减少（3）点。
//MAJ=MAGE|COST=6|ATK=6|HP=6|RACE=NONE
}
