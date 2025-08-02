using System.Collections;
using System.Collections.Generic;

public class ULD_003:MinionBase{
//NAME=了不起的杰弗里斯
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则可以许愿获取一张完美的卡牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=ELEMENTAL
    public override void Battlecry(Card target=null)
    {
        TaskDamageEnemyHero(10);
    }
}
public class ULD_131:SpellBase{
//NAME=发掘潜力
//TEXT=<b>任务：</b>在有未使用的法力水晶的情况下结束4个回合。 <b>奖励：</b>奥斯里安之泪。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_131p:HeroPowerBase{
//NAME=奥斯里安之泪
//TEXT=<b>被动</b> 你的<b>抉择</b>卡牌可以同时拥有两种 效果。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_133:MinionBase{
//NAME=水晶商人
//TEXT=在你的回合结束时，如果你有未使用的法力水晶，抽一张牌。
//MAJ=DRUID|COST=2|ATK=1|HP=4|RACE=NONE
}
public class ULD_134:SpellBase{
//NAME=蜂群来袭
//TEXT=选择一个随从。召唤四只1/1的蜜蜂攻击该随从。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULD_134t:MinionBase{
//NAME=蜜蜂
//TEXT=
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class ULD_135:SpellBase{
//NAME=隐秘绿洲
//TEXT=<b>抉择：</b>召唤一棵6/6并具有<b>嘲讽</b>的古树；或者恢复#12点生命值。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class ULD_135a:SpellBase{
//NAME=结识古树
//TEXT=召唤一棵6/6并具有<b>嘲讽</b>的 古树。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class ULD_135at:MinionBase{
//NAME=维尔纳尔古树
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=6|ATK=6|HP=6|RACE=NONE
}
public class ULD_135b:SpellBase{
//NAME=饮用泉水
//TEXT=恢复#12点生命值。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
}
public class ULD_136:SpellBase{
//NAME=不虚此行
//TEXT=<b>发现</b>一张<b>抉择</b>牌。
//MAJ=DRUID|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_137:MinionBase{
//NAME=园艺侏儒
//TEXT=<b>战吼：</b>如果你的手牌中有法力值消耗大于或等于（5）点的法术牌，便召唤两个2/2的树人。
//MAJ=DRUID|COST=4|ATK=2|HP=3|RACE=NONE
}
public class ULD_137t:MinionBase{
//NAME=树人
//TEXT=
//MAJ=DRUID|COST=1|ATK=2|HP=2|RACE=NONE
}
public class ULD_138:MinionBase{
//NAME=阿努比萨斯防御者
//TEXT=<b>嘲讽</b> 在本回合中，如果你施放过法力值消耗大于或等于（5）的法术，则这张牌的法力值消耗为（0）点。
//MAJ=DRUID|COST=5|ATK=3|HP=5|RACE=NONE
}
public class ULD_139:MinionBase{
//NAME=启迪者伊莉斯
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则复制你的手牌。
//MAJ=DRUID|COST=5|ATK=5|HP=5|RACE=NONE
}
public class ULD_140:SpellBase{
//NAME=最最伟大的考古学
//TEXT=<b>任务：</b>抽20张牌。 <b>奖励：</b>源生魔典。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_140e:Ability{
//NAME=源生之力
//TEXT=法力值消耗为（0）点。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_140p:HeroPowerBase{
//NAME=源生魔典
//TEXT=抽一张牌。其法力值消耗为（0）点。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULD_143:SpellBase{
//NAME=法老祝福
//TEXT=使一个随从获得+4/+4，<b>圣盾</b>以及<b>嘲讽</b>。
//MAJ=PALADIN|COST=6|ATK=0|HP=0|RACE=HOLY
}
public class ULD_143e:Ability{
//NAME=法老祝福
//TEXT=+4/+4，<b>圣盾</b>以及<b>嘲讽</b>。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_145:MinionBase{
//NAME=英勇狂热者
//TEXT=每当你召唤一个随从，获得+1攻击力。
//MAJ=PALADIN|COST=1|ATK=2|HP=1|RACE=NONE
}
public class ULD_145e:Ability{
//NAME=狂热
//TEXT=攻击力提高。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_151:MinionBase{
//NAME=拉穆卡恒驯兽师
//TEXT=<b>战吼：</b>随机复制一张你手牌中的野兽牌。
//MAJ=HUNTER|COST=3|ATK=4|HP=3|RACE=NONE
}
public class ULD_152:SecretBase{
//NAME=压感陷阱
//TEXT=<b>奥秘：</b>在你的对手施放一个法术后，随机消灭一个敌方 随从。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULD_154:MinionBase{
//NAME=土狼头领
//TEXT=<b>战吼：</b>如果你控制一个<b>奥秘</b>，便召唤两只2/2的土狼。
//MAJ=HUNTER|COST=4|ATK=3|HP=3|RACE=BEAST
}
public class ULD_154t:MinionBase{
//NAME=土狼
//TEXT=
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=BEAST
}
public class ULD_155:SpellBase{
//NAME=打开宝库
//TEXT=<b>任务：</b>召唤20个随从。<b>奖励：</b>法老的面盔。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_155e:Ability{
//NAME=愤怒咆哮
//TEXT=+2攻击力。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_155p:HeroPowerBase{
//NAME=法老的面盔
//TEXT=使你的所有随从获得+2攻击力。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULD_156:MinionBase{
//NAME=恐龙大师布莱恩
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则召唤暴龙王克鲁什。
//MAJ=HUNTER|COST=7|ATK=2|HP=4|RACE=NONE
}
public class ULD_156t:MinionBase{
//NAME=公爵
//TEXT=<b>突袭</b>
//MAJ=HUNTER|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class ULD_156t2:MinionBase{
//NAME=公爵夫人
//TEXT=<b>突袭</b>
//MAJ=HUNTER|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class ULD_156t3:MinionBase{
//NAME=暴龙王克鲁什
//TEXT=<b>冲锋</b>
//MAJ=HUNTER|COST=9|ATK=8|HP=8|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Charge");
    }
}
public class ULD_157:MinionBase{
//NAME=奋进的探险者
//TEXT=<b>战吼：</b>如果你控制一个<b>任务</b>，抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class ULD_158:MinionBase{
//NAME=沙暴元素
//TEXT=<b>战吼：</b>对所有敌方随从造成1点伤害。 <b>过载：</b>（1）
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=ELEMENTAL
}
public class ULD_160:SpellBase{
//NAME=邪恶交易
//TEXT=<b>发现</b>一张<b>跟班</b>牌。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_161:MinionBase{
//NAME=尼斐塞特鞭笞者
//TEXT=每当本随从攻击时，对你的英雄造成3点伤害。
//MAJ=WARLOCK|COST=3|ATK=4|HP=5|RACE=NONE
}
public class ULD_162:MinionBase{
//NAME=怪盗征募官
//TEXT=<b>战吼：</b>消灭一个友方<b>跟班</b>，召唤一个5/5的恶魔。
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=NONE
}
public class ULD_162t:MinionBase{
//NAME=怪盗恶魔
//TEXT=
//MAJ=WARLOCK|COST=5|ATK=5|HP=5|RACE=DEMON
}
public class ULD_163:MinionBase{
//NAME=过期货物专卖商
//TEXT=<b>战吼：</b>弃掉你手牌中法力值消耗最高的牌。<b>亡语：</b>将弃掉的牌的两张复制置入你的手牌。
//MAJ=WARLOCK|COST=2|ATK=2|HP=1|RACE=UNDEAD
    private CardDbf rem;
    public override void Battlecry(Card target=null)
    {
        Card MaxCost = null;
        foreach(Card c in owner.myPlayer.hand)
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

        if(MaxCost!=null)
        {
            rem = MaxCost.cardDbf;
            new EffectMove(owner.myPlayer,MaxCost,ZoneType.Hand,ZoneType.Grave).Resolve();
        }
    }
    public override void Deathrattle()
    {
        TaskCreate(rem,ZoneType.Hand);
        TaskCreate(rem,ZoneType.Hand);
    }
}
public class ULD_163e:Ability{
//NAME=过期货物
//TEXT=弃掉了{0}。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_165:MinionBase{
//NAME=裂隙屠夫
//TEXT=<b>战吼：</b>消灭一个随从。你的英雄受到等同于该随从生命值的 伤害。
//MAJ=WARLOCK|COST=6|ATK=7|HP=5|RACE=DEMON
}
public class ULD_167:MinionBase{
//NAME=染病的兀鹫
//TEXT=每当你的英雄在自己的回合受到伤害，随机召唤一个法力值消耗为（3）的随从。
//MAJ=WARLOCK|COST=4|ATK=3|HP=5|RACE=BEAST
}
public class ULD_168:MinionBase{
//NAME=黑暗法老塔卡恒
//TEXT=<b>战吼：</b>在本局对战的剩余时间内，你的<b>跟班</b>变为4/4。
//MAJ=WARLOCK|COST=5|ATK=4|HP=4|RACE=NONE
}
public class ULD_168e:Ability{
//NAME=跟班强化
//TEXT=你的<b>跟班</b>变为4/4。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_168e2:Ability{
//NAME=跟班强化
//TEXT=你的<b>跟班</b>变为4/4。
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_168e3:Ability{
//NAME=Lackey Empowerment
//TEXT=4/4.
//MAJ=WARLOCK|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_169:MinionBase{
//NAME=魔古血肉塑造者
//TEXT=<b>突袭</b> 战场上每有一个随从，本牌的法力值消耗便减少（1）点。
//MAJ=SHAMAN|COST=9|ATK=3|HP=4|RACE=NONE
}
public class ULD_170:MinionBase{
//NAME=武装胡蜂
//TEXT=<b>战吼：</b>如果你控制一个<b>跟班</b>，造成3点 伤害。
//MAJ=SHAMAN|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class ULD_171:SpellBase{
//NAME=图腾潮涌
//TEXT=使你的图腾获得+2攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NATURE
	public override void Battlecry(Card target = null)
    {
        base.Battlecry(target);
        List<Card> targets = new List<Card>();
        List<int> Buffs = new List<int>();
        foreach (Card c in owner.myPlayer.board)
        {
            if (c.raceType.Contains(RaceType.Totem))
            {
                targets.Add(c);
                Buffs.Add(2);
            }
        }
        new EffectChange(owner.myPlayer,owner, targets: targets, atkChanges: Buffs).Resolve();
    }
}
public class ULD_171e:Ability{
//NAME=巨大潮涌
//TEXT=+2攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_172:SpellBase{
//NAME=鱼人之灾祸
//TEXT=随机将所有随从变形成为鱼人。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULD_173:MinionBase{
//NAME=维西纳
//TEXT=当你<b>过载</b>时，你的其他随从拥有+2攻击力。
//MAJ=SHAMAN|COST=4|ATK=2|HP=6|RACE=NONE
}
public class ULD_173e:Ability{
//NAME=维西纳的信念
//TEXT=维西纳使本随从获得+2攻击力。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_174:MinionBase{
//NAME=海蛇蛋
//TEXT=<b>亡语：</b>召唤一条3/4的海蛇。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=3|RACE=NONE
}
public class ULD_174t:MinionBase{
//NAME=海蛇
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=BEAST
}
public class ULD_177:MinionBase{
//NAME=八爪巨怪
//TEXT=<b>亡语：</b>抽八张牌。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=BEAST
}
public class ULD_178:MinionBase{
//NAME=希亚玛特
//TEXT=<b>战吼：</b>从<b>突袭，嘲讽，圣盾</b>或<b>风怒</b>中获得两种效果<i>（由你选择）</i>。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=7|RACE=ELEMENTAL
}
public class ULD_178a:SpellBase{
//NAME=希亚玛特之风
//TEXT=使希亚玛特获得<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_178a2:SpellBase{
//NAME=希亚玛特之盾
//TEXT=使希亚玛特获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_178a3:SpellBase{
//NAME=希亚玛特之心
//TEXT=使希亚玛特获得<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_178a4:SpellBase{
//NAME=希亚玛特之速
//TEXT=使希亚玛特获得<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_179:MinionBase{
//NAME=方阵指挥官
//TEXT=你的<b>嘲讽</b>随从拥有+2攻击力。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=NONE
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.HasAbility("Taunt") && c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "ULD_179e";   
    }
}
public class ULD_179e:Ability{
//NAME=纪律严明
//TEXT=方阵指挥官使本随从获得+2攻击力。
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

public class ULD_179_G:MinionBase{
//NAME=方阵指挥官
//TEXT=你的<b>嘲讽</b>随从拥有+2攻击力。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=5|RACE=NONE
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
        return (c.HasAbility("Taunt") && c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "ULD_179e_G";   
    }
}
public class ULD_179e_G:Ability{
//NAME=纪律严明
//TEXT=方阵指挥官使本随从获得+2攻击力。
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
public class ULD_180:MinionBase{
//NAME=中暑的匪徒
//TEXT=在你的回合开始时，本随从有50%的几率陷入沉睡。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=5|RACE=NONE
}
public class ULD_181:SpellBase{
//NAME=地震术
//TEXT=对所有随从造成$5点伤害，再对所有随从造成$2点伤害。
//MAJ=SHAMAN|COST=7|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),5);
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),2);
    }
}
public class ULD_182:MinionBase{
//NAME=乱喷的骆驼
//TEXT=在你的回合结束时，随机对另一个友方随从造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=4|RACE=BEAST
}
public class ULD_183:MinionBase{
//NAME=阿努比萨斯战争使者
//TEXT=<b>亡语：</b>使你手牌中的所有随从牌获得+3/+3。
//MAJ=NEUTRAL|COST=9|ATK=9|HP=6|RACE=NONE
}
public class ULD_183e:Ability{
//NAME=阿努比萨斯之力
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_184:MinionBase{
//NAME=狗头人沙漠步兵
//TEXT=<b>亡语：</b>对敌方英雄造成3点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class ULD_185:MinionBase{
//NAME=神殿狂战士
//TEXT=<b>复生</b> 受伤时拥有+2 攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=UNDEAD
}
public class ULD_185e:Ability{
//NAME=激怒
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_186:MinionBase{
//NAME=法老御猫
//TEXT=<b>战吼： </b>随机将一张<b>复生</b>随从牌置入你的手牌。
//MAJ=ROGUE|COST=1|ATK=1|HP=2|RACE=BEAST
}
public class ULD_188:MinionBase{
//NAME=金甲虫
//TEXT=<b>战吼：发现</b>一张 法力值消耗为（4）的卡牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=BEAST
}
public class ULD_189:MinionBase{
//NAME=无面潜伏者
//TEXT=<b>嘲讽</b>。<b>战吼：</b>将本随从的生命值翻倍。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class ULD_189e:Ability{
//NAME=英勇
//TEXT=生命值翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_190:MinionBase{
//NAME=深坑鳄鱼
//TEXT=<b>战吼：</b>造成5点伤害。
//MAJ=NEUTRAL|COST=8|ATK=5|HP=6|RACE=BEAST
}
public class ULD_191:MinionBase{
//NAME=欢快的同伴
//TEXT=<b>战吼：</b>使一个友方随从获得+2生命值。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=NONE
}
public class ULD_191e:Ability{
//NAME=获得援助
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_193:MinionBase{
//NAME=活化纪念碑
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=10|ATK=10|HP=10|RACE=NONE
}
public class ULD_194:MinionBase{
//NAME=废土巨蝎
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=7|ATK=3|HP=9|RACE=BEAST
}
public class ULD_195:MinionBase{
//NAME=惊恐的仆从
//TEXT=<b>嘲讽，战吼：</b> <b>发现</b>一张具有<b>嘲讽</b>的随从牌。
//MAJ=WARRIOR|COST=2|ATK=2|HP=3|RACE=NONE
}
public class ULD_196:MinionBase{
//NAME=尼斐塞特仪祭师
//TEXT=<b>战吼：</b>为相邻的随从恢复所有生命值。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class ULD_197:MinionBase{
//NAME=流沙元素
//TEXT=<b>战吼：</b>在本回合中，使所有敌方随从获得-2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=ELEMENTAL
}
public class ULD_197e:Ability{
//NAME=陷住
//TEXT=在本回合中-2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_198:MinionBase{
//NAME=魔法幻象
//TEXT=<b>嘲讽</b> 在你的回合开始时，将本随从洗入你的 牌库。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=10|RACE=NONE
}
public class ULD_205:MinionBase{
//NAME=夺烛木乃伊
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=UNDEAD
}
public class ULD_206:MinionBase{
//NAME=焦躁的木乃伊
//TEXT=<b>突袭，复生</b>
//MAJ=WARRIOR|COST=4|ATK=3|HP=2|RACE=UNDEAD
}
public class ULD_207:MinionBase{
//NAME=先祖守护者
//TEXT=<b>吸血，复生</b>
//MAJ=PALADIN|COST=4|ATK=4|HP=2|RACE=UNDEAD
}
public class ULD_208:MinionBase{
//NAME=卡塔图防御者
//TEXT=<b>嘲讽</b>，<b>复生</b>。<b>亡语：</b>为你的英雄恢复#3点生命值。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=4|RACE=UNDEAD
    public override void Init()
    {
        TaskInitAbility("Taunt");
        TaskInitAbility("Reborn");
    }
    public override void Deathrattle()
    {
        TaskHealMyHero(3);
    }
}
public class ULD_209:MinionBase{
//NAME=狐人恶棍
//TEXT=<b>战吼：发现</b>一张法术牌或选择一个 神秘选项。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class ULD_209t:SpellBase{
//NAME=神秘选项
//TEXT=随机将一张法术牌置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_212:MinionBase{
//NAME=刺血狂蝎
//TEXT=<b>战吼：</b>从你对手的手牌中召唤一个随从。攻击该随从。
//MAJ=HUNTER|COST=6|ATK=6|HP=9|RACE=BEAST
}
public class ULD_214:MinionBase{
//NAME=慷慨的木乃伊
//TEXT=<b>复生</b> 你对手的卡牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=4|RACE=UNDEAD
}
public class ULD_214e:Ability{
//NAME=大兴慈善
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_215:MinionBase{
//NAME=被缚的魔像
//TEXT=<b>复生</b> 在你的回合结束时，召唤一只1/1并具有<b>嘲讽</b>的甲虫。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=5|RACE=UNDEAD
}
public class ULD_215t:MinionBase{
//NAME=甲虫
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class ULD_216:SpellBase{
//NAME=尤格-萨隆的谜之匣
//TEXT=随机施放10个法术<i>（目标随机而定）</i>。
//MAJ=MAGE|COST=10|ATK=0|HP=0|RACE=SHADOW
}
public class ULD_217:MinionBase{
//NAME=微型木乃伊
//TEXT=<b>复生</b> 在你的回合结束时，随机使另一个友方随从获得+1攻击力。
//MAJ=PALADIN|COST=2|ATK=1|HP=2|RACE=MECHANICAL
}
public class ULD_217e:Ability{
//NAME=微型包扎
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_229:MinionBase{
//NAME=捣蛋鬼
//TEXT=<b>战吼：</b>交换你和对手的牌库顶的一张牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class ULD_231:MinionBase{
//NAME=连环腿大师
//TEXT=每当你使用一张<b>连击</b>牌时，随机将一张<b>连击</b>牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=1|HP=2|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            List<string> ComboPool = new List<string>(){"ETC_077","ETC_072","EX1_131","VAN_EX1_131","CORE_OG_070","OG_070","EX1_613","VAN_EX1_613","AV_201","DMF_515","ETC_073","VAC_460","RLK_573","VAN_CS2_073","CORE_CS2_073","CS2_073","DMF_519"};
            if(ComboPool.Contains(sc.cardDbf.m_noteMiniGuid))
            {
                TaskCreate(CardDbf.GetCardDbfByGuid(ComboPool.Choice(owner.myPlayer.randomGen)),ZoneType.Hand);
            }
        }
    }
}
public class ULD_236:MinionBase{
//NAME=始祖龟朝圣者
//TEXT=<b>战吼：</b>从你的牌库中 <b>发现</b>一张法术牌，并对随机目标施放。
//MAJ=MAGE|COST=8|ATK=5|HP=5|RACE=NONE
}
public class ULD_238:MinionBase{
//NAME=考古专家雷诺
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则造成10点伤害，随机分配到所有敌方随从身上。
//MAJ=MAGE|COST=6|ATK=4|HP=6|RACE=NONE
}
public class ULD_239:SecretBase{
//NAME=火焰结界
//TEXT=<b>奥秘：</b>在一个随从攻击你的英雄后，对所有敌方随从造成$3点伤害。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FIRE
}
public class ULD_240:MinionBase{
//NAME=对空奥术法师
//TEXT=在你使用一张<b>奥秘</b>牌后，对所有敌方随从造成2点伤害。
//MAJ=MAGE|COST=2|ATK=3|HP=2|RACE=NONE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.cardType==CardType.Secret)
            {
                TaskDamageTargets(owner.myPlayer.otherPlayer.board,2);
            }
        }
    }
}
public class ULD_250:MinionBase{
//NAME=招虫的地精
//TEXT=<b>嘲讽，亡语：</b>将两张1/1并具有<b>嘲讽</b>的“甲虫”置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=NONE
}
public class ULD_253:MinionBase{
//NAME=陵墓守望者
//TEXT=<b>嘲讽</b> <b>战吼：</b>召唤一个本随从的复制。
//MAJ=WARRIOR|COST=8|ATK=3|HP=6|RACE=MECHANICAL
}
public class ULD_256:SpellBase{
//NAME=投入战斗
//TEXT=使你手牌中的所有<b>嘲讽</b>随从牌获得+2/+2。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_256e:Ability{
//NAME=久经战阵
//TEXT=由投入战斗获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_258:MinionBase{
//NAME=硕铠鼠
//TEXT=<b>嘲讽</b> 在你的回合结束时，使你手牌中所有<b>嘲讽</b>随从牌获得+2/+2。
//MAJ=WARRIOR|COST=6|ATK=4|HP=8|RACE=BEAST
}
public class ULD_258e:Ability{
//NAME=坚不可摧
//TEXT=硕铠鼠使其获得属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_262:MinionBase{
//NAME=高阶祭司阿门特
//TEXT=每当你召唤一个随从，将其生命值设置为与本随从相同。
//MAJ=PRIEST|COST=4|ATK=2|HP=7|RACE=NONE
}
public class ULD_262e:Ability{
//NAME=阿门特的祝福
//TEXT=生命值变更。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_265:SpellBase{
//NAME=防腐仪式
//TEXT=使一个随从获得<b>复生</b>。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_266:MinionBase{
//NAME=木奶伊
//TEXT=<b>复生，亡语：</b>随机使一个友方随从获得+1/+1。
//MAJ=PRIEST|COST=2|ATK=1|HP=2|RACE=UNDEAD
}
public class ULD_266e:Ability{
//NAME=木奶伊的祝福
//TEXT=+1/+1。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_268:MinionBase{
//NAME=接引冥神
//TEXT=<b>战吼：</b>随机召唤一个在本局对战中死亡的友方随从。使其获得 <b>复生</b>。
//MAJ=PRIEST|COST=4|ATK=3|HP=1|RACE=NONE
}
public class ULD_269:MinionBase{
//NAME=卑劣的回收者
//TEXT=<b>战吼：</b>消灭一个友方随从，然后将其复活，并具有所有生命值。
//MAJ=PRIEST|COST=3|ATK=3|HP=3|RACE=NONE
}
public class ULD_270:MinionBase{
//NAME=沙蹄搬水工
//TEXT=在你的回合结束时，为一个受伤的友方角色恢复#5点生命值。
//MAJ=PRIEST|COST=5|ATK=5|HP=5|RACE=NONE
}
public class ULD_271:MinionBase{
//NAME=受伤的托维尔人
//TEXT=<b>嘲讽</b>。<b>战吼：</b>对本随从造成3点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=6|RACE=NONE
}
public class ULD_272:SpellBase{
//NAME=神圣涟漪
//TEXT=对所有敌人造成$1点伤害，为所有友方角色 恢复#1点生命值。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class ULD_273:SpellBase{
//NAME=溢流
//TEXT=为所有角色恢复#5点生命值。抽五张牌。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NATURE
}
public class ULD_274:MinionBase{
//NAME=废土刺客
//TEXT=<b>潜行，复生</b>
//MAJ=NEUTRAL|COST=5|ATK=4|HP=2|RACE=UNDEAD
}
public class ULD_275:MinionBase{
//NAME=白骨怨灵
//TEXT=<b>嘲讽，复生</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=5|RACE=UNDEAD
}
public class ULD_276:MinionBase{
//NAME=怪盗图腾
//TEXT=在你的回合结束时，将一张<b>跟班</b>牌置入你的手牌。
//MAJ=SHAMAN|COST=2|ATK=0|HP=2|RACE=TOTEM
}
public class ULD_280:MinionBase{
//NAME=沙赫柯特工兵
//TEXT=<b>亡语：</b>随机将一个敌方随从移回对手的 手牌。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=PIRATE
}
public class ULD_282:MinionBase{
//NAME=陶罐商人
//TEXT=<b>亡语：</b>随机将一张法力值消耗为（1）的随从牌置入你的手牌。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class ULD_285:WeaponBase{
//NAME=钩镰弯刀
//TEXT=<b>连击：</b>获得+2攻击力。
//MAJ=ROGUE|COST=3|ATK=2|HP=2|RACE=NONE
}
public class ULD_285e:Ability{
//NAME=抛光研磨
//TEXT=+2攻击力。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_286:SpellBase{
//NAME=死亡之影
//TEXT=选择一个随从。将三张“阴影”牌洗入你的牌库，当抽到“阴影”时，召唤该随从的一个复制。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class ULD_286t:SpellBase{
//NAME=阴影
//TEXT=<b>抽到时施放</b> 召唤一个{0}。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class ULD_288:MinionBase{
//NAME=被埋葬的安卡
//TEXT=<b>战吼：</b>使你手牌中所有具有<b>亡语</b>的随从牌变为1/1，且法力值消耗为（1）点。
//MAJ=ROGUE|COST=5|ATK=5|HP=5|RACE=UNDEAD
    public override void Battlecry(Card target=null)
    {
        List<Card> ToListBuff = new List<Card>();
        foreach(Card c in owner.myPlayer.hand)
        {
            if(c.cardType==CardType.Minion)
            {
                if(c.HasAbility("Deathrattle"))
                {
                    ToListBuff.Add(c);
                }
            }
        }
        List<int> AttackChanges = new List<int>();
        List<int> HealthChanges = new List<int>();
        List<int> ManaChanges = new List<int>();
        foreach(Card c in ToListBuff)
        {
            AttackChanges.Add(1-c.GetTag(GameTag.Attack));
            HealthChanges.Add(1-c.GetTag(GameTag.Health));
            ManaChanges.Add(1-c.GetTag(GameTag.Mana));
        }
        new EffectChange(owner.myPlayer,owner,targets:ToListBuff,atkChanges:AttackChanges,hpChanges:HealthChanges,manaChanges:ManaChanges).Resolve();
    }
}
public class ULD_288e:Ability{
//NAME=埋葬
//TEXT=被埋葬的安卡将它变成了1/1。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_289:MinionBase{
//NAME=鱼人投手
//TEXT=<b>战吼：</b>将一张随机鱼人牌分别置入每个玩家的手牌。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=MURLOC
}
public class ULD_290:MinionBase{
//NAME=历史爱好者
//TEXT=每当你使用一张随从牌，随机使你手牌中的一张随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class ULD_290e:Ability{
//NAME=博闻多识
//TEXT=历史爱好者使其获得属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_291:SpellBase{
//NAME=腐化水源
//TEXT=<b>任务：</b>使用6张<b>战吼</b>牌。<b>奖励：</b>维尔纳尔之心。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_291p:HeroPowerBase{
//NAME=维尔纳尔之心
//TEXT=在本回合中，你的<b>战吼</b>会触发两次。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULD_291pe:Ability{
//NAME=维尔纳尔之心
//TEXT=在本回合中，你的<b>战吼</b>会触发两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_292:MinionBase{
//NAME=绿洲涌动者
//TEXT=<b>突袭</b> <b>抉择：</b>获得+2/+2；或者召唤一个本随从的复制。
//MAJ=DRUID|COST=5|ATK=3|HP=3|RACE=ELEMENTAL
}
public class ULD_292a:SpellBase{
//NAME=专注爆发
//TEXT=获得+2/+2。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ULD_292ae:Ability{
//NAME=专注
//TEXT=+2/+2。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ULD_292b:SpellBase{
//NAME=分流出击
//TEXT=召唤一个本随从的复制。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ULD_293:MinionBase{
//NAME=云雾王子
//TEXT=<b>战吼：</b> 如果你控制一个<b>奥秘</b>，则造成6点伤害。
//MAJ=MAGE|COST=5|ATK=4|HP=4|RACE=ELEMENTAL
}
public class ULD_304:MinionBase{
//NAME=法奥瑞斯国王
//TEXT=<b>战吼：</b>你手牌中每有一张法术牌，便召唤一个法力值消耗与法术牌相同的随机随从。
//MAJ=NEUTRAL|COST=10|ATK=5|HP=5|RACE=NONE
}
public class ULD_309:MinionBase{
//NAME=矮人考古学家
//TEXT=<b>战吼：</b><b>发现</b>一张卡牌，其法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class ULD_309e:Ability{
//NAME=考古研究
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_324:SpellBase{
//NAME=小鬼油膏
//TEXT=消灭一个随从。将三张“游荡小鬼”洗入你的牌库。
//MAJ=WARLOCK|COST=4|ATK=0|HP=0|RACE=FEL
}
public class ULD_324t:MinionBase{
//NAME=游荡小鬼
//TEXT=
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=DEMON
}
public class ULD_326:SpellBase{
//NAME=劫掠集市
//TEXT=<b>任务：</b>将4张其他职业的卡牌置入你的手牌。 <b>奖励：</b>远古刀锋。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_326p:HeroPowerBase{
//NAME=远古刀锋
//TEXT=装备一把3/2的在攻击时<b>免疫</b>的战刃。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULD_326t:WeaponBase{
//NAME=幻象之刃
//TEXT=你的英雄在攻击时<b>免疫</b>。
//MAJ=ROGUE|COST=2|ATK=3|HP=2|RACE=NONE
}
public class ULD_327:MinionBase{
//NAME=集市恶痞
//TEXT=<b>突袭</b> <b>战吼：</b>随机将一张另一职业的随从牌置入你的手牌。
//MAJ=ROGUE|COST=5|ATK=3|HP=5|RACE=NONE
}
public class ULD_328:SpellBase{
//NAME=聪明的伪装
//TEXT=随机将另一职业的两张法术牌置入你的手牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULD_329:MinionBase{
//NAME=沙丘塑形师
//TEXT=在你施放一个法术后，随机将一张法师随从牌置入你的手牌。
//MAJ=MAGE|COST=3|ATK=3|HP=3|RACE=NONE
}
public class ULD_410:MinionBase{
//NAME=猩红织网蛛
//TEXT=<b>战吼：</b>随机使你手牌中的一张野兽牌的 法力值消耗减少（5）点。
//MAJ=HUNTER|COST=6|ATK=5|HP=5|RACE=BEAST
}
public class ULD_410e:Ability{
//NAME=蛛网包裹
//TEXT=法力值消耗减少（5）点。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_413:WeaponBase{
//NAME=分裂战斧
//TEXT=<b>战吼：</b>召唤你的图腾的复制。
//MAJ=SHAMAN|COST=4|ATK=3|HP=2|RACE=NONE
}
public class ULD_429:SpellBase{
//NAME=猎人工具包
//TEXT=随机将一张猎人野兽牌，<b>奥秘</b>牌和武器牌分别置入你的 手牌。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ULD_430:WeaponBase{
//NAME=沙漠之矛
//TEXT=在你的英雄攻击后，召唤一只1/1并具有<b>突袭</b>的 蝗虫。
//MAJ=HUNTER|COST=3|ATK=1|HP=3|RACE=NONE
}
public class ULD_430t:MinionBase{
//NAME=蝗虫
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class ULD_431:SpellBase{
//NAME=制作木乃伊
//TEXT=<b>任务：</b>使用5张<b>复生</b>随从牌。<b>奖励：</b>帝王裹布。
//MAJ=PALADIN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_431e:Ability{
//NAME=帝王裹装
//TEXT=2/2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_431p:HeroPowerBase{
//NAME=帝王裹布
//TEXT=召唤一个友方随从的2/2的复制。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULD_433:SpellBase{
//NAME=洗劫天空殿
//TEXT=<b>任务：</b>施放10个法术。 <b>奖励：</b>升格卷轴。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_433e:Ability{
//NAME=作弊手段
//TEXT=法力值消耗减少（2）点。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_433p:HeroPowerBase{
//NAME=升格卷轴
//TEXT=随机将一张法师法术牌置入你的手牌。该牌的法力值消耗减少（2）点。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULD_435:MinionBase{
//NAME=纳迦沙漠女巫
//TEXT=<b>战吼：</b>使你手牌中的法术牌法力值消耗变为（5）点。
//MAJ=MAGE|COST=5|ATK=5|HP=5|RACE=NAGA
}
public class ULD_435e:Ability{
//NAME=沙漠巫术
//TEXT=法力值消耗为（5）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_438:MinionBase{
//NAME=萨赫特的傲狮
//TEXT=<b>亡语：</b>从你的牌库中抽两张生命值为1的随从牌。
//MAJ=PALADIN|COST=3|ATK=3|HP=1|RACE=BEAST
}
public class ULD_439:MinionBase{
//NAME=沙漠蜂后
//TEXT=<b>战吼：</b>将两张2/1的“沙漠胡蜂”置入你的 手牌。
//MAJ=PALADIN|COST=2|ATK=3|HP=1|RACE=BEAST
}
public class ULD_439t:MinionBase{
//NAME=沙漠胡蜂
//TEXT=
//MAJ=PALADIN|COST=1|ATK=2|HP=1|RACE=BEAST
}
public class ULD_450:MinionBase{
//NAME=邪犬
//TEXT=<b>吸血</b>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=DEMON
}
public class ULD_500:MinionBase{
//NAME=沙漠爵士芬利
//TEXT=<b>战吼：</b>如果你的牌库里没有相同的牌，则<b>发现</b>一个升级过的英雄技能。
//MAJ=PALADIN|COST=2|ATK=2|HP=3|RACE=MURLOC
}
public class ULD_616:MinionBase{
//NAME=泰坦造物跟班
//TEXT=<b>战吼：</b>使一个友方随从获得+2生命值和 <b>嘲讽</b>。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class ULD_616e:Ability{
//NAME=硬化
//TEXT=+2生命值并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_702:MinionBase{
//NAME=机械法医
//TEXT=在你的对手使用一张随从牌后，使其获得<b>复生</b>。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=MECHANICAL
}
public class ULD_703:MinionBase{
//NAME=沙漠方尖碑
//TEXT=如果你在你的回合结束时控制3座沙漠方尖碑，随机对一个敌人造成5点伤害。
//MAJ=NEUTRAL|COST=5|ATK=0|HP=5|RACE=NONE
}
public class ULD_705:MinionBase{
//NAME=魔古信徒
//TEXT=<b>战吼：</b>如果你的场上满是魔古信徒，则将其全部献祭，并召唤“莱，至高守护者”。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=NONE
}
public class ULD_705t:MinionBase{
//NAME=莱，至高守护者
//TEXT=在你的回合结束时，对所有敌人造成20点伤害。
//MAJ=NEUTRAL|COST=10|ATK=20|HP=20|RACE=NONE
}
public class ULD_706:MinionBase{
//NAME=显眼的诱饵
//TEXT=<b>亡语：</b>每个玩家从手牌中召唤法力值消耗最低的随从。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class ULD_707:SpellBase{
//NAME=愤怒之灾祸
//TEXT=消灭所有受伤的随从。
//MAJ=WARRIOR|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ULD_708:WeaponBase{
//NAME=电缆长枪
//TEXT=在你的英雄攻击后，将一张<b>跟班</b>牌置入你的 手牌。
//MAJ=WARRIOR|COST=3|ATK=2|HP=2|RACE=NONE
}
public class ULD_709:MinionBase{
//NAME=重甲暴徒
//TEXT=每当你的英雄攻击时，便获得5点 护甲值。
//MAJ=WARRIOR|COST=6|ATK=6|HP=7|RACE=NONE
}
public class ULD_711:SpellBase{
//NAME=侵入系统
//TEXT=<b>任务：</b>用你的英雄攻击5次。<b>奖励：</b>安拉斐特之核。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_711p3:HeroPowerBase{
//NAME=安拉斐特之核
//TEXT=召唤一个4/3的魔像。在你的英雄攻击后，复原此技能。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULD_711t:MinionBase{
//NAME=石头魔像
//TEXT=
//MAJ=WARRIOR|COST=3|ATK=4|HP=3|RACE=NONE
}
public class ULD_712:MinionBase{
//NAME=昆虫收藏家
//TEXT=<b>战吼：</b>召唤一只1/1并具有<b>突袭</b>的蝗虫。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class ULD_713:SpellBase{
//NAME=飞蝗虫群
//TEXT=召唤七只1/1并具有<b>突袭</b>的 蝗虫。
//MAJ=HUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class ULD_714:SpellBase{
//NAME=苦修
//TEXT=<b>吸血</b> 对一个随从造成$3点伤害。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class ULD_715:SpellBase{
//NAME=疯狂之灾祸
//TEXT=每个玩家装备一把2/2并具有<b>剧毒</b>的刀。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class ULD_715t:WeaponBase{
//NAME=灾祸狂刀
//TEXT=<b>剧毒</b>
//MAJ=ROGUE|COST=1|ATK=2|HP=2|RACE=NONE
}
public class ULD_716:SpellBase{
//NAME=鱼人为王
//TEXT=从你的牌库中召唤七个鱼人。
//MAJ=PALADIN|COST=8|ATK=0|HP=0|RACE=NONE
}
public class ULD_716e2:Ability{
//NAME=被注视
//TEXT=属性值变成3/3。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_717:SpellBase{
//NAME=火焰之灾祸
//TEXT=消灭你的所有随从。每消灭一个随从，便随机消灭一个敌方随从。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=FIRE
}
public class ULD_718:SpellBase{
//NAME=死亡之灾祸
//TEXT=<b>沉默</b>并消灭所有随从。
//MAJ=PRIEST|COST=9|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
        {
            new EffectGiveAbility(owner.myPlayer,owner,c,"Silent",createVfx:false).Resolve();
        }
        TaskDestroyTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board));
        
    }
}
public class ULD_719:MinionBase{
//NAME=沙漠野兔
//TEXT=<b>战吼：</b>召唤两只1/1的沙漠野兔。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=BEAST
}
public class ULD_720:MinionBase{
//NAME=血誓雇佣兵
//TEXT=<b>战吼：</b>选择一个受伤的友方随从，召唤一个它的复制。
//MAJ=WARRIOR|COST=3|ATK=3|HP=3|RACE=NONE
}
public class ULD_721:MinionBase{
//NAME=月亮巨人守护者
//TEXT=<b>圣盾，复生</b>
//MAJ=NEUTRAL|COST=10|ATK=10|HP=10|RACE=UNDEAD
}
public class ULD_723:MinionBase{
//NAME=鱼人木乃伊
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class ULD_724:SpellBase{
//NAME=激活方尖碑
//TEXT=<b>任务：</b>恢复15点生命值。<b>奖励：</b>方尖碑之眼。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ULD_724e:Ability{
//NAME=方尖碑的凝视
//TEXT=属性值提高。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_724p:HeroPowerBase{
//NAME=方尖碑之眼
//TEXT=恢复#3点生命值。如果你的目标是一个随从，则同时使其获得+3/+3。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULD_726:SpellBase{
//NAME=远古谜团
//TEXT=从你的牌库中抽一张<b>奥秘</b>牌。其法力值消耗为（0）点。
//MAJ=MAGE|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class ULD_726e:Ability{
//NAME=已经破译
//TEXT=法力值消耗为（0）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_727:MinionBase{
//NAME=裹尸匠
//TEXT=<b>战吼：</b><b>发现</b>一个在本局对战中死亡的友方随从。将其洗入你的牌库。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class ULD_728:SpellBase{
//NAME=制伏
//TEXT=将一个随从的攻击力和生命值变为1。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ULD_728e:Ability{
//NAME=被制伏
//TEXT=1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ULD_COIN:SpellBase{
//NAME=幸运币
//TEXT=在本回合中，获得一个 法力水晶。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
