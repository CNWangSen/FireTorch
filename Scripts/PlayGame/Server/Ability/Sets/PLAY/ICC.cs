using System.Collections;
using System.Collections.Generic;

public class ICC_018:MinionBase{
//NAME=幻影海盗
//TEXT=<b>战吼：</b> 获得等同于你的武器属性的属性值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=PIRATE
}
public class ICC_018e:Ability{
//NAME=善用武器
//TEXT=属性值提高。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_019:MinionBase{
//NAME=骷髅法师
//TEXT=<b>亡语：</b>如果此时是你对手的回合，则召唤一个8/8的骷髅。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=2|RACE=UNDEAD
}
public class ICC_019t:MinionBase{
//NAME=巨镰骷髅
//TEXT=
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=UNDEAD
}
public class ICC_021:MinionBase{
//NAME=自爆肿胀蝠
//TEXT=<b>亡语：</b>对所有敌方随从造成2点伤害。
//MAJ=HUNTER|COST=4|ATK=2|HP=1|RACE=BEAST
}
public class ICC_023:MinionBase{
//NAME=雪鳍企鹅
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=BEAST
}
public class ICC_025:MinionBase{
//NAME=骷髅捣蛋鬼
//TEXT=<b>战吼：</b>召唤一个5/5的骷髅。 <b>亡语：</b>为你的对手召唤一个5/5的骷髅。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=UNDEAD
}
public class ICC_025t:MinionBase{
//NAME=骷髅执行者
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class ICC_026:MinionBase{
//NAME=冷酷的死灵法师
//TEXT=<b>战吼：</b>召唤两个1/1的骷髅。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=UNDEAD
}
public class ICC_026t:MinionBase{
//NAME=骷髅
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class ICC_027:MinionBase{
//NAME=白骨幼龙
//TEXT=<b>亡语：</b>随机将一张龙牌置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=5|RACE=DRAGON
}
public class ICC_028:MinionBase{
//NAME=阳焰瓦格里
//TEXT=<b>战吼：</b>使相邻的随从获得+2生命值。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=UNDEAD
}
public class ICC_028e:Ability{
//NAME=瓦格里祝福
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_029:MinionBase{
//NAME=深蓝刃鳞龙兽
//TEXT=在你的回合结束时，随机使另一个友方随从获得+3攻击力。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=DRAGON
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
            TaskBuffRandomTarget(owner.myPlayer.board.Exclude(owner),atk:3);
    }
}
public class ICC_029e:Ability{
//NAME=龙鳞
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_031:MinionBase{
//NAME=暗夜嗥狼
//TEXT=每当本随从受到伤害，获得+2攻击力。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=NONE
}
public class ICC_031e:Ability{
//NAME=嗥！
//TEXT=本随从的攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_032:MinionBase{
//NAME=制毒师
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=5|ATK=2|HP=5|RACE=UNDEAD
}
public class ICC_034:MinionBase{
//NAME=傲慢的十字军
//TEXT=<b>亡语：</b>如果此时是你对手的回合，则召唤一个2/2的食尸鬼。
//MAJ=PALADIN|COST=4|ATK=5|HP=2|RACE=UNDEAD
}
public class ICC_038:MinionBase{
//NAME=正义保护者
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
        TaskInitAbility("DivineShield");
    }
}
public class ICC_038_G:MinionBase{
//NAME=正义保护者
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
        TaskInitAbility("DivineShield");
    }
}
public class ICC_039:SpellBase{
//NAME=黑暗裁决
//TEXT=将一个随从的攻击力和生命值 变为3。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_039e:Ability{
//NAME=裁决判定
//TEXT=属性值变成3/3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_041:SpellBase{
//NAME=亵渎
//TEXT=对所有随从造成$1点伤害，如果有随从死亡，则再次施放该法术。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        int Cnt=0;
        while(true)
        {
            List<Card> ToListDamage = new List<Card>();
            foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
            {
                ToListDamage.Add(c);
            }
            TaskDamageTargets(ToListDamage,1);  
            Cnt+=1;
            if(Cnt>14)
            {
                break;
            }
            bool HasDeath=false;
            foreach(Card c in ToListDamage)
            {
                if(c.GetTag(GameTag.ZoneType)==(int)ZoneType.Grave)
                {
                    HasDeath=true;
                    break;
                }
            }
            if(!HasDeath)
            {
                break;
            }
        }
    }
}
public class ICC_047:MinionBase{
//NAME=命运织网蛛
//TEXT=<b>秘密亡语：</b> <b>抉择：</b>对所有随从造成3点伤害；或者使所有随从获得+2/+2。
//MAJ=DRUID|COST=5|ATK=5|HP=3|RACE=UNDEAD
}
public class ICC_047a:SpellBase{
//NAME=生长
//TEXT=<b>亡语：</b>使所有随从获得+2/+2。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ICC_047b:SpellBase{
//NAME=凋零
//TEXT=<b>亡语：</b>对所有随从造成3点 伤害。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=NONE
}
public class ICC_047e:Ability{
//NAME=生长
//TEXT=+2/+2。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_047t:MinionBase{
//NAME=命运织网蛛
//TEXT=<b>秘密亡语：</b>对所有随从造成3点伤害； 或者使所有随从获得+2/+2。0<b>秘密亡语：</b>使所有随从获得+2/+2。0<b>秘密亡语：</b>对所有随从造成3点伤害。
//MAJ=DRUID|COST=5|ATK=5|HP=3|RACE=UNDEAD
}
public class ICC_047t2:MinionBase{
//NAME=命运织网蛛
//TEXT=<b>亡语：</b>对所有随从造成3点伤害，并使所有随从获得+2/+2。
//MAJ=DRUID|COST=5|ATK=5|HP=3|RACE=UNDEAD
}
public class ICC_049:SpellBase{
//NAME=剧毒箭矢
//TEXT=对一个随从造成$2点伤害，如果它依然存活，则使其获得<b>剧毒</b>。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NATURE
}
public class ICC_049e:Ability{
//NAME=剧毒箭矢
//TEXT=<b>剧毒</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_050:SpellBase{
//NAME=蛛网
//TEXT=召唤两只1/2并具有<b>剧毒</b>的 蜘蛛。
//MAJ=DRUID|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_051:MinionBase{
//NAME=虫群德鲁伊
//TEXT=<b>抉择：</b>变形成为1/2并具有<b>剧毒</b>；或者变形成为1/5并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=2|ATK=1|HP=2|RACE=NONE
}
public class ICC_051a:MinionBase{
//NAME=蜘蛛形态
//TEXT=<b>剧毒</b>
//MAJ=DRUID|COST=2|ATK=1|HP=2|RACE=BEAST
}
public class ICC_051b:MinionBase{
//NAME=甲虫形态
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=2|ATK=1|HP=5|RACE=BEAST
}
public class ICC_051t:MinionBase{
//NAME=虫群德鲁伊
//TEXT=<b>剧毒</b>
//MAJ=DRUID|COST=2|ATK=1|HP=2|RACE=BEAST
}
public class ICC_051t2:MinionBase{
//NAME=虫群德鲁伊
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=2|ATK=1|HP=5|RACE=BEAST
}
public class ICC_051t3:MinionBase{
//NAME=虫群德鲁伊
//TEXT=<b>嘲讽</b> <b>剧毒</b>
//MAJ=DRUID|COST=2|ATK=1|HP=5|RACE=BEAST
}
public class ICC_052:SpellBase{
//NAME=装死
//TEXT=触发一个友方随从的<b>亡语</b>。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ICC_054:SpellBase{
//NAME=传播瘟疫
//TEXT=召唤一只1/5并具有<b>嘲讽</b>的甲虫。如果你的对手拥有的随从更多，则再次施放该法术。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NATURE
    public override void Battlecry(Card target=null)
    {
        int Cnt=0;
        CardDbf ToSummon = CardDbf.GetCardDbfByGuid("ICC_832t4");
        while(true)
        {
            TaskCreate(ToSummon,ZoneType.Board);
            Cnt+=1;
            if(owner.myPlayer.board.Count>=owner.myPlayer.otherPlayer.board.Count || Cnt>=14)
            {
                break;
            }
        }
    }
}
public class ICC_055:SpellBase{
//NAME=吸取灵魂
//TEXT=<b>吸血</b> 对一个随从造成 $3点伤害。
//MAJ=WARLOCK|COST=2|ATK=0|HP=0|RACE=SHADOW
    public override void Init()
    {
        //TaskInitAbility("LifeSteal");
    }
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,3).Resolve();
        if(owner.myPlayer.hero.Count>0)
            new EffectHeal(owner.myPlayer,owner,owner.myPlayer.hero[0],3).Resolve();
    }
}
public class ICC_056:SpellBase{
//NAME=低温静滞
//TEXT=使一个随从获得+3/+3，并使其<b>冻结</b>。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=FROST
}
public class ICC_056e:Ability{
//NAME=冻结之血
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_058:MinionBase{
//NAME=冷冻鱼人
//TEXT=<b>战吼：</b> <b>冻结</b>一个敌人。
//MAJ=SHAMAN|COST=2|ATK=2|HP=2|RACE=MURLOC
}
public class ICC_062:MinionBase{
//NAME=熔甲卫士
//TEXT=<b>亡语：</b>如果此时是你对手的回合，则获得 6点护甲值。
//MAJ=WARRIOR|COST=3|ATK=4|HP=3|RACE=NONE
}
public class ICC_064:WeaponBase{
//NAME=血刃剃刀
//TEXT=[x]<b>战吼，亡语：</b> 对所有随从造成 1点伤害。
//MAJ=WARRIOR|COST=4|ATK=2|HP=2|RACE=NONE
}
public class ICC_065:MinionBase{
//NAME=白骨大亨
//TEXT=<b>亡语：</b> 将两张1/1的“骷髅”置入你的手牌。
//MAJ=ROGUE|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class ICC_067:MinionBase{
//NAME=维库食尸鬼
//TEXT=<b>亡语：</b>如果此时是你对手的回合，则召唤一个2/2的食尸鬼。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=UNDEAD
}
public class ICC_068:MinionBase{
//NAME=寒冰行者
//TEXT=你的英雄技能还会 <b>冻结</b>目标。
//MAJ=MAGE|COST=2|ATK=1|HP=3|RACE=ELEMENTAL
}
public class ICC_069:MinionBase{
//NAME=鬼影巫师
//TEXT=<b>战吼：</b>将一张“镜像”法术牌置入你的手牌。
//MAJ=MAGE|COST=4|ATK=2|HP=6|RACE=UNDEAD
}
public class ICC_071:WeaponBase{
//NAME=光之悲恸
//TEXT=在一个友方随从失去<b>圣盾</b>后，获得+1攻击力。
//MAJ=PALADIN|COST=4|ATK=1|HP=4|RACE=NONE
}
public class ICC_071e:Ability{
//NAME=圣光将熄
//TEXT=攻击力提高。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_075:MinionBase{
//NAME=卑鄙的恐惧魔王
//TEXT=在你的回合结束时，对所有敌方随从造成1点伤害。
//MAJ=WARLOCK|COST=5|ATK=4|HP=5|RACE=DEMON
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
            TaskDamageTargets(owner.myPlayer.otherPlayer.board,1);
    }
}
public class ICC_078:SpellBase{
//NAME=雪崩
//TEXT=<b>冻结</b>一个随从，并对其相邻的随从造成$3点伤害。
//MAJ=SHAMAN|COST=4|ATK=0|HP=0|RACE=FROST
}
public class ICC_079:SpellBase{
//NAME=铁齿铜牙
//TEXT=使你的英雄获得3点护甲值，并在本回合中获得 +3攻击力。
//MAJ=DRUID|COST=3|ATK=0|HP=0|RACE=NONE
}
public class ICC_079e:Ability{
//NAME=铁齿铜牙
//TEXT=在本回合中+3攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_081:MinionBase{
//NAME=达卡莱防御者
//TEXT=<b>嘲讽</b>，<b>过载：</b>（3）
//MAJ=SHAMAN|COST=3|ATK=2|HP=8|RACE=NONE
}
public class ICC_082:SecretBase{
//NAME=寒冰克隆
//TEXT=<b>奥秘：</b>在你的对手使用一张随从牌后，将两张该随从的复制置入你的手牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class ICC_083:MinionBase{
//NAME=末日学徒
//TEXT=你对手法术的法力值消耗增加（1）点。
//MAJ=MAGE|COST=3|ATK=3|HP=2|RACE=UNDEAD
}
public class ICC_083e:Ability{
//NAME=末日
//TEXT=法力值消耗增加（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_085:SpellBase{
//NAME=终极感染
//TEXT=造成$5点伤害。抽五张牌。获得5点护甲值。召唤一个5/5的食尸鬼。
//MAJ=DRUID|COST=10|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectDamage(owner.myPlayer,owner,target,5).Resolve();
        for(int i=0;i<5;i++)
        {
            TaskDraw();
        }
        TaskBuffMyHero(arm:5);
        TaskCreate(CardDbf.GetCardDbfByGuid("ICC_085t"),ZoneType.Board);
    }
}
public class ICC_085t:MinionBase{
//NAME=食尸鬼感染者
//TEXT=
//MAJ=DRUID|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class ICC_086:SpellBase{
//NAME=冰封秘典
//TEXT=将每种不同的<b>奥秘</b>从你的牌库中置入战场。
//MAJ=MAGE|COST=8|ATK=0|HP=0|RACE=FROST
}
public class ICC_088:MinionBase{
//NAME=巫毒妖术师
//TEXT=<b>嘲讽</b> <b>冻结</b>任何受到本随从伤害的角色。
//MAJ=SHAMAN|COST=5|ATK=2|HP=7|RACE=NONE
}
public class ICC_089:SpellBase{
//NAME=冰钓术
//TEXT=从你的牌库中抽两张鱼人牌。
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=FROST
}
public class ICC_090:MinionBase{
//NAME=雪怒巨人
//TEXT=在本局对战中，你每<b>过载</b>一个法力水晶，本牌的法力值消耗便减少（1）点。
//MAJ=SHAMAN|COST=11|ATK=8|HP=8|RACE=ELEMENTAL
}
public class ICC_091:SpellBase{
//NAME=亡者之牌
//TEXT=复制你的手牌并洗入你的牌库。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<CardDbf> ToListShuffle = new List<CardDbf>();
        foreach(Card c in owner.myPlayer.hand)
        {
            ToListShuffle.Add(c.cardDbf);
            TaskCreate(c.cardDbf,ZoneType.Deck,randpos:true);
        }
    }
}
public class ICC_092:MinionBase{
//NAME=阿彻鲁斯老兵
//TEXT=<b>战吼：</b>使一个友方随从获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=UNDEAD
}
public class ICC_092e:Ability{
//NAME=老兵的青睐
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_093:MinionBase{
//NAME=海象人渔夫
//TEXT=<b>战吼：</b>使一个友方随从获得<b>法术伤害+1</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class ICC_093e:Ability{
//NAME=新鲜的鱼！
//TEXT=<b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_094:MinionBase{
//NAME=堕落残阳祭司
//TEXT=<b>战吼：</b>使一个友方随从获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=UNDEAD
}
public class ICC_094e:Ability{
//NAME=祭司的祝福
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_096:MinionBase{
//NAME=熔火巨像
//TEXT=<b>战吼：</b>弃掉你手牌中所有的武器牌，并获得这些武器的属性值。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=UNDEAD
}
public class ICC_096e:Ability{
//NAME=武器熔炼
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_097:MinionBase{
//NAME=墓地蹒跚者
//TEXT=每当你的武器被摧毁时，便获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class ICC_097e:Ability{
//NAME=获得武装
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_098:MinionBase{
//NAME=墓穴潜伏者
//TEXT=<b>战吼：</b>随机将一个在本局对战中死亡并具有<b>亡语</b>的随从置入你的手牌。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=3|RACE=UNDEAD
}
public class ICC_099:MinionBase{
//NAME=自爆憎恶
//TEXT=<b>亡语：</b>对你所有的随从造成5点伤害。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=6|RACE=UNDEAD
}
public class ICC_200:SecretBase{
//NAME=眼镜蛇陷阱
//TEXT=<b>奥秘：</b>当你的随从受到攻击时，召唤一条2/3并具有<b>剧毒</b>的眼镜蛇。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_201:SpellBase{
//NAME=命运骨骰
//TEXT=抽一张牌。如果这张牌有<b>亡语</b>，则再次施放本法术。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        while(true)
        {
            Card Drawn = TaskDraw();
            bool Stop=true;
            if(Drawn!=null)
            {
                if(Drawn.HasAbility("Deathrattle"))
                {
                    Stop=false;
                }
            }
            if(Stop)
            {
                break;
            }
        }
    }
}
public class ICC_204:MinionBase{
//NAME=普崔塞德教授
//TEXT=在你使用一个<b>奥秘</b>后，随机将一个猎人的<b>奥秘</b>置入战场。
//MAJ=HUNTER|COST=4|ATK=5|HP=4|RACE=UNDEAD
}
public class ICC_206:SpellBase{
//NAME=变节
//TEXT=选择一个友方随从，交给你的 对手。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        new EffectMove(owner.myPlayer,target,ZoneType.Board,ZoneType.Board,toEn:true).Resolve();
    }
}
public class ICC_207:SpellBase{
//NAME=吞噬意志
//TEXT=复制你对手的牌库中的三张牌，并将其置入你的手牌。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_210:MinionBase{
//NAME=暗影升腾者
//TEXT=在你的回合结束时，随机使另一个友方随从获得+1/+1。
//MAJ=PRIEST|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class ICC_210e:Ability{
//NAME=升腾
//TEXT=属性值提高。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_212:MinionBase{
//NAME=酷虐侍僧
//TEXT=<b>吸血</b>
//MAJ=PRIEST|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class ICC_213:SpellBase{
//NAME=永恒奴役
//TEXT=<b>发现</b>一个在本局对战中死亡的友方随从，并召唤该随从。
//MAJ=PRIEST|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_214:MinionBase{
//NAME=黑曜石雕像
//TEXT=<b>嘲讽</b>，<b>吸血</b> <b>亡语：</b>随机消灭一个敌方随从。
//MAJ=PRIEST|COST=9|ATK=4|HP=8|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("LifeSteal");
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        TaskDestroyRandomEnemyMinion();
    }
}
public class ICC_215:MinionBase{
//NAME=大主教本尼迪塔斯
//TEXT=<b>战吼：</b>复制你对手的牌库，并洗入你的 牌库。
//MAJ=PRIEST|COST=7|ATK=4|HP=6|RACE=NONE
}
public class ICC_218:MinionBase{
//NAME=咆哮魔
//TEXT=每当本随从受到伤害，随机弃掉 一张牌。
//MAJ=WARLOCK|COST=3|ATK=3|HP=6|RACE=DEMON
}
public class ICC_220:MinionBase{
//NAME=死鳞骑士
//TEXT=<b>吸血</b>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MURLOC
}
public class ICC_221:SpellBase{
//NAME=吸血药膏
//TEXT=在本回合中，你的武器获得 <b>吸血</b>。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NATURE
}
public class ICC_221e:Ability{
//NAME=吸血之毒
//TEXT=在本回合中拥有<b>吸血</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_233:SpellBase{
//NAME=末日回旋镖
//TEXT=对一个随从投掷你的武器。武器会造成伤害，然后移回你的手牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class ICC_235:SpellBase{
//NAME=暗影精华
//TEXT=随机挑选你牌库里的一个随从，召唤一个5/5的复制。
//MAJ=PRIEST|COST=7|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_235e:Ability{
//NAME=暗影精华
//TEXT=攻击力和生命值变为5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_236:WeaponBase{
//NAME=破冰斧
//TEXT=消灭所有受到该武器伤害的被<b>冻结</b>的随从。
//MAJ=SHAMAN|COST=3|ATK=1|HP=3|RACE=NONE
}
public class ICC_238:MinionBase{
//NAME=活化狂战士
//TEXT=在你使用一张随从牌后，对其造成1点 伤害。
//MAJ=WARRIOR|COST=1|ATK=1|HP=3|RACE=NONE
}
public class ICC_240:MinionBase{
//NAME=符文熔铸游魂
//TEXT=在你的回合时，你的武器不会失去 耐久度。
//MAJ=ROGUE|COST=4|ATK=5|HP=3|RACE=UNDEAD
}
public class ICC_240e:Ability{
//NAME=耐久武器
//TEXT=不会失去耐久度。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_243:MinionBase{
//NAME=巨型尸蛛
//TEXT=你的<b>亡语</b>牌的法力值消耗减少（2）点。
//MAJ=HUNTER|COST=5|ATK=4|HP=6|RACE=BEAST
}
public class ICC_243e:Ability{
//NAME=曝尸
//TEXT=法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_244:SpellBase{
//NAME=殊死一搏
//TEXT=使一个随从获得“<b>亡语：</b>回到战场，并具有1点生命值。”
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class ICC_244e:Ability{
//NAME=救赎
//TEXT=<b>亡语：</b>回到战场，并具有1点生命值。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_245:MinionBase{
//NAME=黑色卫士
//TEXT=每当你的英雄获得治疗时，便随机对一个敌方随从造成等量的 伤害。
//MAJ=PALADIN|COST=6|ATK=3|HP=9|RACE=UNDEAD
}
public class ICC_252:MinionBase{
//NAME=冰冷鬼魂
//TEXT=<b>战吼：</b>如果有敌人被<b>冻结</b>，抽一张牌。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=UNDEAD
}
public class ICC_257:MinionBase{
//NAME=唤尸者
//TEXT=<b>战吼：</b>使一个友方随从获得“<b>亡语：</b>再次召唤该随从。”
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class ICC_257e:Ability{
//NAME=借尸还魂
//TEXT=<b>亡语：</b>再次召唤本随从。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_281:SpellBase{
//NAME=灵魂洪炉
//TEXT=从你的牌库中抽两张武器牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_289:MinionBase{
//NAME=莫拉比
//TEXT=每当有其他随从被<b>冻结</b>，将一张被<b>冻结</b>随从的复制置入你的 手牌。
//MAJ=SHAMAN|COST=6|ATK=4|HP=4|RACE=NONE
}
public class ICC_314:MinionBase{
//NAME=巫妖王
//TEXT=<b>嘲讽</b> 在你的回合结束时，随机将一张<b>巫妖王</b>牌置入你的手牌。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=UNDEAD
}
public class ICC_314t1:WeaponBase{
//NAME=霜之哀伤
//TEXT=<b>亡语：</b>召唤被该武器消灭的所有 随从。
//MAJ=DEATHKNIGHT|COST=7|ATK=5|HP=3|RACE=NONE
}
public class ICC_314t1e:Ability{
//NAME=被禁锢的幽魂
//TEXT={0}
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_314t2:SpellBase{
//NAME=冰封王座卫队
//TEXT=移除你的牌库顶的五张牌。召唤其中所有被移除的随从。
//MAJ=DEATHKNIGHT|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_314t3:SpellBase{
//NAME=末日契约
//TEXT=消灭所有随从。每消灭一个随从，移除你的牌库顶的 一张牌。
//MAJ=DEATHKNIGHT|COST=5|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_314t4:SpellBase{
//NAME=死亡之握
//TEXT=从你对手的牌库中偷取一张随从牌，并置入你的手牌。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_314t5:SpellBase{
//NAME=凋零缠绕
//TEXT=对一个敌人造成$5点伤害，或为一个友方角色恢复#5点 生命值。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_314t6:SpellBase{
//NAME=湮灭
//TEXT=消灭一个随从。你的英雄受到等同于该随从生命值的 伤害。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        int ToTake = target.GetTag(GameTag.Health);
        new EffectDestroy(owner.myPlayer,owner,target).Resolve();
        TaskDamageMyHero(ToTake);
    }
}
public class ICC_314t7:SpellBase{
//NAME=反魔法护罩
//TEXT=使你的所有随从获得+2/+2和<b>扰魔</b>。
//MAJ=DEATHKNIGHT|COST=4|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_314t7e:Ability{
//NAME=反魔法护罩
//TEXT=+2/+2和<b>扰魔</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_314t8:SpellBase{
//NAME=死亡凋零
//TEXT=对所有敌人造成$3点伤害。
//MAJ=DEATHKNIGHT|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_405:MinionBase{
//NAME=腐面
//TEXT=在本随从受到伤害并存活下来后，随机召唤一个<b>传说</b>随从。
//MAJ=WARRIOR|COST=8|ATK=4|HP=6|RACE=UNDEAD
}
public class ICC_407:MinionBase{
//NAME=侏儒吸血鬼
//TEXT=<b>战吼：</b>移除你对手的牌库顶的一张牌。
//MAJ=WARLOCK|COST=2|ATK=2|HP=3|RACE=UNDEAD
}
public class ICC_408:MinionBase{
//NAME=瓦格里摄魂者
//TEXT=在本随从受到伤害并存活下来后，召唤一个2/2的食尸鬼。
//MAJ=WARRIOR|COST=3|ATK=1|HP=4|RACE=UNDEAD
}
public class ICC_415:MinionBase{
//NAME=缝合追踪者
//TEXT=<b>战吼：</b> 从你的牌库中<b>发现</b>一张随从牌的复制。
//MAJ=HUNTER|COST=3|ATK=2|HP=2|RACE=UNDEAD
    public override void Battlecry(Card target=null)
    {
        List<CardDbf> Pool = new List<CardDbf>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardType==CardType.Minion)
            {
                Pool.Add(c.cardDbf);
            }
        }
        CardDbf ToCreate = Pool.Choice(owner.myPlayer.randomGen);
        if(ToCreate!=null)
        {
            TaskCreate(ToCreate,ZoneType.Hand);
        }
    }
}
public class ICC_419:MinionBase{
//NAME=熊鲨
//TEXT=<b>扰魔</b>
//MAJ=HUNTER|COST=3|ATK=4|HP=3|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Elusive");
    }
}
public class ICC_450:MinionBase{
//NAME=死亡幽魂
//TEXT=<b>战吼：</b>每有一个受伤的随从，便获得+1/+1。
//MAJ=WARRIOR|COST=5|ATK=3|HP=3|RACE=UNDEAD
}
public class ICC_450e:Ability{
//NAME=嗜血渴望
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_466:MinionBase{
//NAME=萨隆苦囚
//TEXT=<b>嘲讽</b> <b>战吼：</b>召唤一个本随从的复制。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=3|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Battlecry(Card target=null)
    {
        //Card Another = new Card(owner.cardDbf,owner.myPlayer);
        //Another.SetTag(GameTag.Attack,owner.GetTag(GameTag.Attack));
        //Another.SetTag(GameTag.Health,owner.GetTag(GameTag.Health));
        //Another.SetTag(GameTag.Damage,owner.GetTag(GameTag.Damage));
        //new EffectCreate(owner.myPlayer,Another,ZoneType.Board).Resolve();
        TaskCreate(owner.cardDbf,ZoneType.Board);
    }
}
public class ICC_467:MinionBase{
//NAME=亡语者
//TEXT=<b>战吼：</b>在本回合中，使一个友方随从获得<b>免疫</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=UNDEAD
}
public class ICC_467e:Ability{
//NAME=死亡结界
//TEXT=在本回合中<b>免疫</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_468:MinionBase{
//NAME=失心农夫
//TEXT=每当本随从攻击时，对敌方英雄造成2点伤害。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class ICC_469:SpellBase{
//NAME=强制牺牲
//TEXT=选择一个友方随从，消灭该随从和一个随机敌方随从。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_481:HeroBase{
//NAME=死亡先知萨尔
//TEXT=<b>战吼：</b>随机将你的所有随从变形成为法力值消耗增加（2）点的随从。
//MAJ=SHAMAN|COST=5|ATK=0|HP=30|RACE=NONE
}
public class ICC_481p:HeroPowerBase{
//NAME=灵体转化
//TEXT=将一个友方随从随机变形成为一个法力值消耗增加（1）点的随从。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_483e:Ability{
//NAME=霜之哀伤的附加效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_700:MinionBase{
//NAME=开心的食尸鬼
//TEXT=在本回合中，如果你的英雄受到治疗，则 法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class ICC_701:MinionBase{
//NAME=游荡恶鬼
//TEXT=<b>战吼：</b>摧毁双方手牌中和牌库中所有法力值消耗为（1）的 法术牌。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=6|RACE=UNDEAD
}
public class ICC_702:MinionBase{
//NAME=孱弱的掘墓者
//TEXT=<b>亡语：</b>随机将一个具有<b>亡语</b>的随从置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=UNDEAD
}
public class ICC_705:MinionBase{
//NAME=骨魇
//TEXT=<b>战吼：</b>使一个友方随从获得+4/+4和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=7|ATK=5|HP=5|RACE=UNDEAD
    public override void Battlecry(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,target,atkChange:4,hpChange:4).Resolve();
        new EffectGiveAbility(owner.myPlayer,owner,target,"Taunt").Resolve();
    }
}
public class ICC_705e:Ability{
//NAME=骨魇恩赐
//TEXT=+4/+4并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_706:MinionBase{
//NAME=蛛魔拆解者
//TEXT=法术的法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class ICC_706e:Ability{
//NAME=拆解
//TEXT=法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_800h3t:MinionBase{
//NAME=僵尸兽
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class ICC_801:MinionBase{
//NAME=咆哮的指挥官
//TEXT=<b>战吼：</b>从你的牌库中抽一张具有<b>圣盾</b>的随从牌。
//MAJ=PALADIN|COST=3|ATK=2|HP=2|RACE=UNDEAD
}
public class ICC_802:SpellBase{
//NAME=灵魂鞭笞
//TEXT=<b>吸血</b> 对所有随从造成 $1点伤害。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),1);
    }
}
public class ICC_807:MinionBase{
//NAME=硬壳清道夫
//TEXT=<b>战吼：</b>使你具有<b>嘲讽</b>的随从获得+2/+2。
//MAJ=DRUID|COST=4|ATK=2|HP=3|RACE=NONE
}
public class ICC_807e:Ability{
//NAME=硬壳
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_808:MinionBase{
//NAME=地穴领主
//TEXT=<b>嘲讽</b> 在你召唤一个随从后，获得+1生命值。
//MAJ=DRUID|COST=3|ATK=1|HP=6|RACE=UNDEAD
}
public class ICC_808e:Ability{
//NAME=蛛魔之力
//TEXT=生命值提高。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_809:MinionBase{
//NAME=瘟疫科学家
//TEXT=<b>连击：</b>使一个友方随从获得<b>剧毒</b>。
//MAJ=ROGUE|COST=3|ATK=2|HP=3|RACE=UNDEAD
}
public class ICC_809e:Ability{
//NAME=实验体
//TEXT=<b>剧毒</b>
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_810:MinionBase{
//NAME=亡斧惩罚者
//TEXT=<b>战吼：</b>随机使你手牌中一个具有<b>吸血</b>的随从获得+2/+2。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=UNDEAD
}
public class ICC_810e:Ability{
//NAME=嗜血渴望
//TEXT=亡斧惩罚者使其获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_811:MinionBase{
//NAME=莉莉安·沃斯
//TEXT=<b>战吼：</b>随机将你手牌中所有的法术牌替换成<i>（你对手职业的）</i>法术牌。
//MAJ=ROGUE|COST=4|ATK=4|HP=5|RACE=UNDEAD
}
public class ICC_812:MinionBase{
//NAME=绞肉车
//TEXT=<b>亡语：</b>从你的牌库中召唤一个攻击力小于本随从攻击力的随从。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=4|RACE=MECHANICAL
}
public class ICC_820:MinionBase{
//NAME=寒刃勇士
//TEXT=<b>冲锋，吸血</b>
//MAJ=PALADIN|COST=4|ATK=3|HP=2|RACE=UNDEAD
}
public class ICC_823:SpellBase{
//NAME=模拟幻影
//TEXT=复制你手牌中法力值消耗最低的随从牌。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=FROST
}
public class ICC_825:MinionBase{
//NAME=憎恶弓箭手
//TEXT=<b>亡语：</b>随机召唤一个在本局对战中死亡的友方野兽。
//MAJ=HUNTER|COST=7|ATK=6|HP=7|RACE=UNDEAD
}
public class ICC_827:HeroBase{
//NAME=虚空之影瓦莉拉
//TEXT=<b>战吼：</b>获得<b>潜行</b>直到你的下个回合。
//MAJ=ROGUE|COST=9|ATK=0|HP=30|RACE=NONE
}
public class ICC_827e:Ability{
//NAME=暗影映像
//TEXT=始终复制你最后使用的牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_827e3:Ability{
//NAME=暗影之幕
//TEXT=获得<b>潜行</b>直到你的下个回合。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_827p:HeroPowerBase{
//NAME=死亡暗影
//TEXT=<b>被动</b> 在你的回合时，将一张“暗影映像”置入你的手牌。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_827t:SpellBase{
//NAME=暗影映像
//TEXT=每当你使用一张牌，变形成为该卡牌的复制。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_828:HeroBase{
//NAME=死亡猎手雷克萨
//TEXT=<b>战吼：</b> 对所有敌方随从造成2点伤害。
//MAJ=HUNTER|COST=6|ATK=0|HP=30|RACE=NONE
}
public class ICC_828e:Ability{
//NAME=缝合
//TEXT={0}和{1}。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_828p:HeroPowerBase{
//NAME=合成僵尸兽
//TEXT=制造一个自定义的僵尸兽。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_828t:MinionBase{
//NAME=僵尸兽
//TEXT={0} {1}
//MAJ=HUNTER|COST=0|ATK=1|HP=1|RACE=BEAST
}
public class ICC_828t2:MinionBase{
//NAME=倔强的蜗牛
//TEXT=<b>嘲讽</b> <b>剧毒</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=2|RACE=BEAST
}
public class ICC_828t3:MinionBase{
//NAME=巨型黄蜂
//TEXT=<b>潜行</b> <b>剧毒</b>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=BEAST
}
public class ICC_828t4:MinionBase{
//NAME=石皮蜥蜴
//TEXT=<b>圣盾</b> <b>剧毒</b>
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=BEAST
}
public class ICC_828t5:MinionBase{
//NAME=狩猎犬
//TEXT=<b>回响</b> <b>突袭</b>
//MAJ=HUNTER|COST=2|ATK=2|HP=1|RACE=BEAST
}
public class ICC_828t6:MinionBase{
//NAME=邪巢诱捕蛛
//TEXT=<b>剧毒</b> <b>突袭</b>
//MAJ=HUNTER|COST=5|ATK=1|HP=3|RACE=BEAST
}
public class ICC_828t7:MinionBase{
//NAME=凶恶的鳞皮兽
//TEXT=<b>吸血</b> <b>突袭</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=3|RACE=BEAST
}
public class ICC_829:HeroBase{
//NAME=黑锋骑士乌瑟尔
//TEXT=<b>战吼：</b> 装备一把5/3并具有<b>吸血</b>的武器。
//MAJ=PALADIN|COST=9|ATK=0|HP=30|RACE=NONE
}
public class ICC_829p:HeroPowerBase{
//NAME=天启四骑士
//TEXT=召唤一个2/2的天启骑士。如果你控制所有四个天启骑士，消灭敌方英雄。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_829t:WeaponBase{
//NAME=冰墓裁决
//TEXT=<b>吸血</b>
//MAJ=PALADIN|COST=8|ATK=5|HP=3|RACE=NONE
}
public class ICC_829t2:MinionBase{
//NAME=死亡领主纳兹戈林
//TEXT=
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class ICC_829t3:MinionBase{
//NAME=索拉斯·托尔贝恩
//TEXT=
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class ICC_829t4:MinionBase{
//NAME=检察官怀特迈恩
//TEXT=
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class ICC_829t5:MinionBase{
//NAME=达里安·莫格莱尼
//TEXT=
//MAJ=PALADIN|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class ICC_830:HeroBase{
//NAME=暗影收割者安度因
//TEXT=<b>战吼：</b>消灭所有攻击力大于或等于5的随从。
//MAJ=PRIEST|COST=8|ATK=0|HP=30|RACE=NONE
}
public class ICC_830p:HeroPowerBase{
//NAME=虚空形态
//TEXT=造成$2点伤害。在你使用一张牌后，复原此技能。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_831:HeroBase{
//NAME=鲜血掠夺者古尔丹
//TEXT=<b>战吼：</b>召唤所有在本局对战中死亡的友方恶魔。
//MAJ=WARLOCK|COST=10|ATK=0|HP=30|RACE=NONE
}
public class ICC_831p:HeroPowerBase{
//NAME=生命虹吸
//TEXT=<b>吸血</b>，造成$3点伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_832:HeroBase{
//NAME=污染者玛法里奥
//TEXT=<b>抉择：</b>召唤两只具有<b>剧毒</b>的蜘蛛；或者召唤两只具有<b>嘲讽</b>的甲虫。
//MAJ=DRUID|COST=7|ATK=0|HP=30|RACE=NONE
}
public class ICC_832a:SpellBase{
//NAME=甲虫瘟疫
//TEXT=召唤两只1/5并具有<b>嘲讽</b>的 甲虫。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NONE
}
public class ICC_832b:SpellBase{
//NAME=蜘蛛瘟疫
//TEXT=召唤两只1/2并具有<b>剧毒</b>的 蜘蛛。
//MAJ=DRUID|COST=7|ATK=0|HP=0|RACE=NONE
}
public class ICC_832e:Ability{
//NAME=毒牙
//TEXT=在本回合中+3攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_832p:HeroPowerBase{
//NAME=瘟疫领主
//TEXT=<b>抉择：</b>在本回合中获得+$a3攻击力；或者获得+$d3点护甲值。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_832pa:SpellBase{
//NAME=甲虫硬壳
//TEXT=+$d3护甲值。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_832pb:SpellBase{
//NAME=蜘蛛毒牙
//TEXT=+$a3攻击力。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_832t3:MinionBase{
//NAME=冰霜寡妇蛛
//TEXT=<b>剧毒</b>
//MAJ=DRUID|COST=1|ATK=1|HP=2|RACE=BEAST
}
public class ICC_832t4:MinionBase{
//NAME=硬壳圣甲虫
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=2|ATK=1|HP=5|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class ICC_833:HeroBase{
//NAME=冰霜女巫吉安娜
//TEXT=<b>战吼：</b>召唤一个3/6的水元素。在本局对战中，你的所有元素拥有<b>吸血</b>。
//MAJ=MAGE|COST=9|ATK=0|HP=30|RACE=NONE
}
public class ICC_833e:Ability{
//NAME=冰霜女巫
//TEXT=你的所有元素拥有<b>吸血</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_833e2:Ability{
//NAME=冰冷血脉
//TEXT=冰霜女巫吉安娜会使你的所有元素获得<b>吸血</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_833h:HeroPowerBase{
//NAME=冰冷触摸
//TEXT=造成$1点伤害。如果该英雄技能消灭了一个随从，则召唤一个水元素。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_833t:MinionBase{
//NAME=水元素
//TEXT=<b>冻结</b>任何受到本随从伤害的角色。
//MAJ=MAGE|COST=4|ATK=3|HP=6|RACE=ELEMENTAL
}
public class ICC_834:HeroBase{
//NAME=天灾领主加尔鲁什
//TEXT=<b>战吼：</b>装备一把4/3的影之哀伤，影之哀伤同时对其攻击目标相邻的随从造成伤害。
//MAJ=WARRIOR|COST=8|ATK=0|HP=30|RACE=NONE
}
public class ICC_834h:HeroPowerBase{
//NAME=剑刃风暴
//TEXT=对所有随从造成$1点伤害。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class ICC_834w:WeaponBase{
//NAME=影之哀伤
//TEXT=同时对其攻击目标相邻的随从 造成伤害。
//MAJ=WARRIOR|COST=8|ATK=4|HP=3|RACE=NONE
}
public class ICC_835:MinionBase{
//NAME=哈多诺克斯
//TEXT=<b>亡语：</b>召唤所有你在本局对战中死亡的，并具有<b>嘲讽</b>的随从。
//MAJ=DRUID|COST=9|ATK=3|HP=7|RACE=BEAST
    public override void Battlecry(Card target=null)
    {
        List<CardDbf> ToListSummon = new List<CardDbf>();
        foreach(Card c in owner.myPlayer.grave)
        {
            if(c.HasAbility("Taunt") && c.cardType==CardType.Minion)
            {
                ToListSummon.Add(c.cardDbf);
            }
        }
        foreach(CardDbf d in ToListSummon)
        {
            TaskCreate(d,ZoneType.Board);
        }
    }
}
public class ICC_836:SpellBase{
//NAME=冰龙吐息
//TEXT=随机对一个敌方随从造成$2点伤害，并使其<b>冻结</b>。
//MAJ=MAGE|COST=1|ATK=0|HP=0|RACE=FROST
}
public class ICC_837:SpellBase{
//NAME=放马过来
//TEXT=获得10点护甲值。使你对手的手牌中所有随从牌的法力值消耗减少（2）点。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        TaskBuffMyHero(arm:10);
        List<int> mcs = new List<int>();
        List<Card> ToChange = FindType(owner.myPlayer.otherPlayer.hand,CardType.Minion);
        foreach(Card c in ToChange)
        {
            mcs.Add(-2);
        }
        new EffectChange(owner.myPlayer,owner,targets:ToChange,manaChanges:mcs).Resolve();
    }
}
public class ICC_837e:Ability{
//NAME=被挑衅
//TEXT=随从牌的法力值消耗减少（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_838:MinionBase{
//NAME=辛达苟萨
//TEXT=<b>战吼：</b>召唤两个0/1的被冰封的勇士。
//MAJ=MAGE|COST=8|ATK=8|HP=8|RACE=DRAGON
}
public class ICC_838t:MinionBase{
//NAME=被冰封的勇士
//TEXT=<b>亡语：</b>随机将一个<b>传说</b>随从置入你的 手牌。
//MAJ=MAGE|COST=1|ATK=0|HP=1|RACE=NONE
}
public class ICC_841:MinionBase{
//NAME=鲜血女王兰娜瑟尔
//TEXT=<b>吸血</b> 在本局对战中，你每弃掉一张牌，便拥有+1攻击力。
//MAJ=WARLOCK|COST=5|ATK=1|HP=6|RACE=UNDEAD
}
public class ICC_841e:Ability{
//NAME=吸血撕咬
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_849:SpellBase{
//NAME=黑暗之拥
//TEXT=选择一个敌方随从。在你的回合开始时，获得该随从的 控制权。
//MAJ=PRIEST|COST=6|ATK=0|HP=0|RACE=SHADOW
}
public class ICC_849e:Ability{
//NAME=黑暗之拥
//TEXT=在下个回合开始时，失去本随从的控制权。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_850:WeaponBase{
//NAME=暗影之刃
//TEXT=<b>战吼：</b>在本回合中，你的英雄<b>免疫</b>。
//MAJ=ROGUE|COST=3|ATK=3|HP=2|RACE=NONE
}
public class ICC_850e:Ability{
//NAME=暗影护体
//TEXT=在本回合中<b>免疫</b>。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_851:MinionBase{
//NAME=凯雷塞斯王子
//TEXT=<b>战吼：</b>如果你的牌库里没有法力值消耗为（2）的牌，则使你牌库里所有随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
    public override void Battlecry(Card target=null)
    {
        bool HasTwo = false;
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.GetTag(GameTag.Mana)==2)
            {
                HasTwo=true;
            }
        }
        if(!HasTwo)
        {
            TaskBuffTargets(owner.myPlayer.deck,atk:1,hp:1);
        }
    }
}
public class ICC_851e:Ability{
//NAME=凯雷塞斯的祝福
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_852:MinionBase{
//NAME=塔达拉姆王子
//TEXT=<b>战吼：</b>如果你的牌库里没有法力值消耗为（3）的牌，则变形成为一个随从的3/3的复制。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class ICC_852e:Ability{
//NAME=塔达拉姆的幻影
//TEXT=3/3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_853:MinionBase{
//NAME=瓦拉纳王子
//TEXT=<b>战吼：</b>如果你的牌库里没有法力值消耗为（4）的牌，则获得<b>吸血</b>和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=UNDEAD
}
public class ICC_854:MinionBase{
//NAME=阿尔福斯
//TEXT=<b>亡语：</b>随机将一张<b>巫妖王</b>牌置入你的 手牌。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=BEAST
}
public class ICC_855:MinionBase{
//NAME=海德尼尔冰霜骑士
//TEXT=<b>战吼：</b><b>冻结</b>你的其他随从。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=NONE
}
public class ICC_856:MinionBase{
//NAME=织法者
//TEXT=<b>法术伤害+2</b>
//MAJ=NEUTRAL|COST=6|ATK=4|HP=4|RACE=UNDEAD
}
public class ICC_858:MinionBase{
//NAME=浴火者伯瓦尔
//TEXT=<b>圣盾</b> 在一个友方随从失去<b>圣盾</b>后，获得+2攻击力。
//MAJ=PALADIN|COST=5|ATK=1|HP=7|RACE=UNDEAD
    public override void Init()
    {
        TaskInitAbility("DivineShield");
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterRemoveAbility(this,this.CauseEvent));
    }
    public void CauseEvent(Card sourceCard, string Abiname)
    {
        if(CondInPlay())
        {
            if(Abiname=="DivineShield")
            {
                new EffectChange(owner.myPlayer,owner,owner,atkChange:2).Resolve();
            }
        }
    }
}
public class ICC_858_G:MinionBase{
//NAME=浴火者伯瓦尔
//TEXT=<b>圣盾</b> 在一个友方随从失去<b>圣盾</b>后，获得+2攻击力。
//MAJ=PALADIN|COST=5|ATK=1|HP=7|RACE=UNDEAD
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("DivineShield");
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterRemoveAbility(this,this.CauseEvent));
    }
    public void CauseEvent(Card sourceCard, string Abiname)
    {
        if(CondInPlay())
        {
            if(Abiname=="DivineShield")
            {
                new EffectChange(owner.myPlayer,owner,owner,atkChange:4).Resolve();
            }
        }
    }
}
public class ICC_858e:Ability{
//NAME=黯淡之光
//TEXT=攻击力提高。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_900:MinionBase{
//NAME=死灵恶鬼
//TEXT=每当你的其他随从死亡时，召唤一个2/2的食尸鬼。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=3|RACE=UNDEAD
}
public class ICC_900t:MinionBase{
//NAME=食尸鬼
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=UNDEAD
}
public class ICC_901:MinionBase{
//NAME=达卡莱附魔师
//TEXT=你的回合结束效果会触发两次。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=NONE
}
public class ICC_901e:Ability{
//NAME=冰霜魔法
//TEXT=你的回合结束效果会触发两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_902:MinionBase{
//NAME=摧心者
//TEXT=双方英雄技能均无法使用。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=5|RACE=UNDEAD
}
public class ICC_903:MinionBase{
//NAME=血色狂欢者
//TEXT=<b>战吼：</b>消灭一个友方随从，并获得+2/+2。
//MAJ=WARLOCK|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class ICC_903t:Ability{
//NAME=嗜血渴望
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_904:MinionBase{
//NAME=邪骨骷髅
//TEXT=<b>战吼：</b>在本回合中每有一个随从死亡，便获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=1|RACE=UNDEAD
}
public class ICC_904e:Ability{
//NAME=钙化
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class ICC_905:MinionBase{
//NAME=血虫
//TEXT=<b>吸血</b>
//MAJ=NEUTRAL|COST=5|ATK=4|HP=4|RACE=BEAST
}
public class ICC_910:MinionBase{
//NAME=鬼灵匪贼
//TEXT=<b>连击：</b>在本回合中，你每使用一张其他牌，便对一个随从造成2点伤害。
//MAJ=ROGUE|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class ICC_911:MinionBase{
//NAME=哀泣女妖
//TEXT=每当你使用一张牌，便移除你的牌库顶的三张牌。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=5|RACE=UNDEAD
}
public class ICC_912:MinionBase{
//NAME=夺尸者
//TEXT=<b>战吼：</b> 如果你的牌库里有<b>嘲讽</b>随从牌，则获得<b>嘲讽</b>。依此法检定是否可获得<b>圣盾</b>，<b>吸血</b>和<b>风怒</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=UNDEAD
}
public class ICC_913:MinionBase{
//NAME=被污染的狂热者
//TEXT=<b>圣盾</b> <b>法术伤害+1</b>
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=UNDEAD
}
