using System.Collections;
using System.Collections.Generic;

public class BG29_029:MinionBase{
//NAME=仙鱼教母
//TEXT=在你的回合结束时，随机获取一张 鱼人牌。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=5|RACE=MURLOC
}
public class BG29_029_G:MinionBase{
//NAME=仙鱼教母
//TEXT=在你的回合结束时，随机获取2张鱼人牌。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=10|RACE=MURLOC
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG29_100:MinionBase{
//NAME=奇利亚斯钩爪模块
//TEXT=<b>嘲讽</b> <i>可以与任意奇利亚斯模块三连。</i>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=4|RACE=MECHANICAL
}
public class BG29_100_G:MinionBase{
//NAME=奇利亚斯组合体
//TEXT=<b>
//MAJ=NEUTRAL|COST=2|ATK=6|HP=8|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG29_100_Ge:Ability{
//NAME=奇利亚斯组合体
//TEXT=<b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_100t:MinionBase{
//NAME=奇利亚斯水晶模块
//TEXT=<b>复生</b> <i>可以与任意奇利亚斯模块三连。</i>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=4|RACE=MECHANICAL
}
public class BG29_100t2:MinionBase{
//NAME=奇利亚斯防御模块
//TEXT=<b>圣盾</b> <i>可以与任意奇利亚斯模块三连。</i>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=4|RACE=MECHANICAL
}
public class BG29_100t3:MinionBase{
//NAME=奇利亚斯烟雾模块
//TEXT=<b>潜行</b> <i>可以与任意奇利亚斯模块三连。</i>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=4|RACE=MECHANICAL
}
public class BG29_100t4:MinionBase{
//NAME=奇利亚斯回转模块
//TEXT=<b>风怒</b> <i>可以与任意奇利亚斯模块三连。</i>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=4|RACE=MECHANICAL
}
public class BG29_100t5:MinionBase{
//NAME=奇利亚斯连接模块
//TEXT=<b>磁力</b> <i>可以与任意奇利亚斯模块三连。</i>
//MAJ=NEUTRAL|COST=2|ATK=3|HP=4|RACE=MECHANICAL
}
public class BG29_100te:Ability{
//NAME=奇利亚斯连接模块
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=MECHANICAL
}
public class BG29_120:MinionBase{
//NAME=恨意魔巫
//TEXT=每当本随从攻击时，使本随从右边的随从获得<b>复生</b>。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=2|RACE=UNDEAD
    public override void BeforeAttack(Card target=null)
    {
        int index = owner.myPlayer.board.IndexOf(owner);
        if(index+1 < owner.myPlayer.board.Count && index+1>=0)
        {
            Card ToBuff = owner.myPlayer.board[index+1];
            new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"Reborn").Resolve();
        }
    }
}
public class BG29_120_G:MinionBase{
//NAME=恨意魔巫
//TEXT=每当本随从攻击时，使本随从右边的两个随从获得<b>复生</b>。
//MAJ=NEUTRAL|COST=3|ATK=12|HP=4|RACE=UNDEAD
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void BeforeAttack(Card target=null)
    {
        int index = owner.myPlayer.board.IndexOf(owner);
        if(index+1 < owner.myPlayer.board.Count && index+1>=0)
        {
            Card ToBuff = owner.myPlayer.board[index+1];
            new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"Reborn").Resolve();
        }
        if(index+2 < owner.myPlayer.board.Count && index+2>=0)
        {
            Card ToBuff = owner.myPlayer.board[index+2];
            new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"Reborn").Resolve();
        }
    }
}
public class BG29_120e:Ability{
//NAME=魔巫之恨
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_140:MinionBase{
//NAME=假冒鬼儡
//TEXT=在你的回合结束时，吞食酒馆中的一个随从以获得其属性值。
//MAJ=NEUTRAL|COST=3|ATK=1|HP=1|RACE=DEMON
}
public class BG29_140_G:MinionBase{
//NAME=假冒鬼儡
//TEXT=在你的回合 结束时，吞食酒馆中的一个随从以获得其双倍属性值。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=DEMON
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG29_140e:Ability{
//NAME=食言而肥
//TEXT=吞食了随从的属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_160:MinionBase{
//NAME=炸刺猪头
//TEXT=每当本随从受到伤害，获取一张<b>鲜血宝石</b>。<i>（每场战斗限3次。）</i>3每当本随从受到伤害，获取一张<b>鲜血宝石</b>。<i>（还剩{0}次！）</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=QUILBOAR
}
public class BG29_160_G:MinionBase{
//NAME=炸刺猪头
//TEXT=每当本随从受到伤害，获取两张<b>鲜血宝石</b>。<i>（每场战斗限3次。）</i>3每当本随从受到伤害，获取两张<b>鲜血宝石</b>。<i>（还剩{0}次！）</i>
//MAJ=NEUTRAL|COST=3|ATK=6|HP=8|RACE=QUILBOAR
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG29_300:MinionBase{
//NAME=巨饿冬鳍鱼人
//TEXT=<b>嘲讽</b>。每当本随从受到伤害，使你手牌中的一张随从牌获得+2/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=5|RACE=MURLOC
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class BG29_300_G:MinionBase{
//NAME=巨饿冬鳍鱼人
//TEXT=<b>嘲讽</b>。每当本随从受到伤害，使你手牌中的一张随从牌获得+4/+2。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=10|RACE=MURLOC
    public override void Init()
    {
        TaskInitAbility("Taunt");
        TaskSetGolden();
    }
}
public class BG29_300_Ge:Ability{
//NAME=还是很饿
//TEXT=+4/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_300e:Ability{
//NAME=还是很饿
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_502:MinionBase{
//NAME=桅台哨卫
//TEXT=<b>战吼：</b>使你的其他海盗获得+3生命值。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=2|RACE=PIRATE
}
public class BG29_502_G:MinionBase{
//NAME=桅台哨卫
//TEXT=<b>战吼：</b>使你的其他海盗获得+6生命值。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=4|RACE=PIRATE
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG29_502_Ge:Ability{
//NAME=哨卫警戒
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_502e:Ability{
//NAME=哨卫警戒
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_503:MinionBase{
//NAME=废铁残械
//TEXT=<b>战吼：</b>选择一个友方机械，<b>发现</b>一个机械以对其施加<b>磁力</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=MECHANICAL
}
public class BG29_503_G:MinionBase{
//NAME=废铁残械
//TEXT=<b>战吼：</b>选择一个友方机械，<b>发现</b>2个机械以对其施加<b>磁力</b>。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=8|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG29_503e:Ability{
//NAME=废铁
//TEXT=对一个机械施加<b>磁力</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_610:MinionBase{
//NAME=水灵圣母
//TEXT=每当本随从受到伤害，随机获取一张酒馆法术牌。<i>（每场战斗限3次。）</i>3每当本随从受到伤害，随机获取一张酒馆法术牌。<i>（还剩{0}次！）</i>
//MAJ=NEUTRAL|COST=5|ATK=3|HP=9|RACE=ELEMENTAL
}
public class BG29_610_G:MinionBase{
//NAME=水灵圣母
//TEXT=每当本随从受到伤害，随机获取两张酒馆法术牌。<i>（每场战斗限3次。）</i>3每当本随从受到伤害，随机获取两张酒馆法术牌。<i>（还剩{0}次！）</i>
//MAJ=NEUTRAL|COST=5|ATK=6|HP=18|RACE=ELEMENTAL
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG29_611:MinionBase{
//NAME=拔线机
//TEXT=<b>圣盾</b>。<b>亡语：</b>召唤一个1/1的微型机器人。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=MECHANICAL
    public override void Init()
    {
        TaskInitAbility("DivineShield");
    }
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG_BOT_312t"),ZoneType.Board);
    }
}
public class BG29_611_G:MinionBase{
//NAME=拔线机
//TEXT=<b>圣盾</b>。<b>亡语：</b>召唤一个2/2的微型机器人。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("DivineShield");
    }
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("TB_BaconUps_032t"),ZoneType.Board);
    }
}
public class BG29_708:MinionBase{
//NAME=迟钝的刺鬃
//TEXT=在你的回合开始时，你的<b>鲜血宝石</b>在本局对战中使随从额外获得+1/+1。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=7|RACE=QUILBOAR
}
public class BG29_708_G:MinionBase{
//NAME=迟钝的刺鬃
//TEXT=在你的回合开始时，你的<b>鲜血宝石</b>在本局对战中使随从额外获得+2/+2。
//MAJ=NEUTRAL|COST=6|ATK=12|HP=14|RACE=QUILBOAR
}
public class BG29_800:MinionBase{
//NAME=幼龄忠犬
//TEXT=每当本随从受到伤害，永久获得 +1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=BEAST
}
public class BG29_800_G:MinionBase{
//NAME=幼龄忠犬
//TEXT=每当本随从受到伤害，永久获得 +2攻击力。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=6|RACE=BEAST
}
public class BG29_800_Ge:Ability{
//NAME=最好的狗狗
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_800e:Ability{
//NAME=最好的狗狗
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_801:MinionBase{
//NAME=银羽白鹅
//TEXT=每当本随从受到伤害，召唤一只2/2并具有<b>嘲讽</b>的雏鹅。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=BEAST
    public override void AfterTakeDamage(Card source=null,int amount=0)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG29_801t"),ZoneType.Board);
    }
}
public class BG29_801_G:MinionBase{
//NAME=银羽白鹅
//TEXT=每当本随从受到伤害，召唤一只4/4并具有<b>嘲讽</b>的雏鹅。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=6|RACE=BEAST
    public override void AfterTakeDamage(Card source=null,int amount=0)
    {
        TaskSetGolden();
        TaskCreate(CardDbf.GetCardDbfByGuid("BG29_801_Gt"),ZoneType.Board);
    }
}
public class BG29_801_Gt:MinionBase{
//NAME=银羽雏鹅
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=4|HP=4|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
    }
}
public class BG29_801t:MinionBase{
//NAME=银羽雏鹅
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=0|ATK=2|HP=2|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
}
public class BG29_803:MinionBase{
//NAME=金壳固卫龟
//TEXT=<b>战吼：</b>使你的其他野兽获得+2/+4。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=BEAST
}
public class BG29_803_G:MinionBase{
//NAME=金壳固卫龟
//TEXT=<b>战吼：</b>使你的其他野兽获得+4/+8。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=8|RACE=BEAST
}
public class BG29_803_Ge:Ability{
//NAME=金壳防护
//TEXT=+4/+8。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_803e:Ability{
//NAME=金壳防护
//TEXT=+2/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_806:MinionBase{
//NAME=炫彩灼天者
//TEXT=每当一只友方野兽受到伤害时，使该受伤野兽之外的一只友方野兽永久获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=8|RACE=BEAST
}
public class BG29_806_G:MinionBase{
//NAME=炫彩灼天者
//TEXT=每当一只友方野兽受到伤害时，使该受伤野兽之外的一只友方野兽永久获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=16|RACE=BEAST
}
public class BG29_806_Ge:Ability{
//NAME=天光灼灼
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_806e:Ability{
//NAME=天光灼灼
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_807:MinionBase{
//NAME=鞭笞者特里高雷
//TEXT=每当另一只友方野兽受到伤害时，永久获得+2生命值。
//MAJ=NEUTRAL|COST=5|ATK=9|HP=3|RACE=BEAST
}
public class BG29_807_G:MinionBase{
//NAME=鞭笞者特里高雷
//TEXT=每当另一只友方野兽受到伤害时，永久获得+4生命值。
//MAJ=NEUTRAL|COST=5|ATK=18|HP=6|RACE=BEAST
}
public class BG29_807_Ge:Ability{
//NAME=无情抽笞
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_807e:Ability{
//NAME=无情抽笞
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_808:MinionBase{
//NAME=尖角救星
//TEXT=<b><b>嘲讽</b>。<b>复生</b></b> <b>亡语：</b>使你的随从获得+1生命值并对其造成1点伤害。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=2|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
        TaskInitAbility("Reborn");
    }
}
public class BG29_808_G:MinionBase{
//NAME=尖角救星
//TEXT=<b><b>嘲讽</b>。<b>复生</b></b> <b>亡语：</b>使你的随从获得+1生命值并对其造成1点伤害，触发两次。
//MAJ=NEUTRAL|COST=5|ATK=16|HP=4|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
        TaskInitAbility("Reborn");
    }
}
public class BG29_808e:Ability{
//NAME=救场主角
//TEXT=+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_809:MinionBase{
//NAME=怒火飞羊
//TEXT=每当本随从攻击时，对你的其他随从造成1点伤害。
//MAJ=NEUTRAL|COST=3|ATK=8|HP=8|RACE=BEAST
    public override void BeforeAttack(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Exclude(owner),1);
    }
}
public class BG29_809_G:MinionBase{
//NAME=怒火飞羊
//TEXT=每当本随从攻击时，对你的其他随从造成1点伤害，触发两次。
//MAJ=NEUTRAL|COST=3|ATK=16|HP=16|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void BeforeAttack(Card target=null)
    {
        TaskDamageTargets(owner.myPlayer.board.Exclude(owner),1);
        TaskDamageTargets(owner.myPlayer.board.Exclude(owner),1);
    }
}
public class BG29_810:MinionBase{
//NAME=千纸幼龙
//TEXT=<b>战斗开始时：</b>使你最左边的龙获得+1/+2和<b>风怒</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=DRAGON
    public override void OnCombatStart()
    {
        Card LeftMost = null;
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.raceType.Contains(RaceType.Dragon) || c.raceType.Contains(RaceType.All))
            {
                LeftMost=c;
                break;
            }
        }
        if(LeftMost!=null)
        {
            new EffectChange(owner.myPlayer,owner,LeftMost,atkChange:1,hpChange:2).Resolve();
            new EffectGiveAbility(owner.myPlayer,owner,LeftMost,"WindFury").Resolve();
        }
    }
}
public class BG29_810_G:MinionBase{
//NAME=千纸幼龙
//TEXT=<b>战斗开始时：</b>使你最左边的两条龙获得+1/+2和<b>风怒</b>。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=6|RACE=DRAGON
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void OnCombatStart()
    {
        Card LeftMost = null;
        Card LeftMost2 = null;
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.raceType.Contains(RaceType.Dragon) || c.raceType.Contains(RaceType.All))
            {
                if(LeftMost==null)
                {
                    LeftMost=c;
                }
                else{
                    if(LeftMost2==null)
                    {
                        LeftMost2=c;
                    }
                    else{
                        break;
                    }
                }
            }
        }
        if(LeftMost!=null)
        {
            new EffectChange(owner.myPlayer,owner,LeftMost,atkChange:1,hpChange:2).Resolve();
            new EffectGiveAbility(owner.myPlayer,owner,LeftMost,"WindFury").Resolve();
        }
    }
}
public class BG29_810e:Ability{
//NAME=折住他们
//TEXT=+1/+2和<b>风怒</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_811:MinionBase{
//NAME=福禄神龙玉珑
//TEXT=<b>战斗开始时：</b> 使你等级最低的随从<i>（福禄神龙玉珑除外）</i>变为金色。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=DRAGON
}
public class BG29_811_G:MinionBase{
//NAME=福禄神龙玉珑
//TEXT=<b>战斗开始时：</b>使你等级最低的两个随从<i>（福禄神龙玉珑除外）</i>变为金色。
//MAJ=NEUTRAL|COST=5|ATK=16|HP=16|RACE=DRAGON
}
public class BG29_813:MinionBase{
//NAME=执念诗心龙
//TEXT=<b><b>圣盾</b>。</b>相邻的龙可永久保留战斗阶段受到的你的附加效果。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=3|RACE=DRAGON
    public override void Init()
    {
        TaskInitAbility("DivineShield");
    }
}
public class BG29_813_G:MinionBase{
//NAME=执念诗心龙
//TEXT=<b><b>圣盾</b>。</b>相邻的龙在战斗阶段受到的你的附加效果翻倍，并可永久保留。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=6|RACE=DRAGON
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("DivineShield");
    }
}
public class BG29_813e:Ability{
//NAME=Persistent Poet Player Enchant [DNT]
//TEXT=Adjacent Dragons to a Persistent Poet permanently keep your enchantments from combat.
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_814:MinionBase{
//NAME=错巢龙崽
//TEXT=<b>战斗开始时：</b>获得等同于你当前等级的属性值。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=1|RACE=DRAGON
    public override void OnCombatStart()
    {
        new EffectChange(owner.myPlayer,owner,owner,atkChange:6,hpChange:6).Resolve();
    }
}
public class BG29_814_G:MinionBase{
//NAME=错巢龙崽
//TEXT=<b>战斗开始时：</b>获得等同于你当前等级双倍的属性值。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=2|RACE=DRAGON
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void OnCombatStart()
    {
        new EffectChange(owner.myPlayer,owner,owner,atkChange:12,hpChange:12).Resolve();
    }
}
public class BG29_814e:Ability{
//NAME=不该在这
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_815:MinionBase{
//NAME=骨火巨龙夜之魇
//TEXT=<b>嘲讽</b>。<b>亡语：</b>随机使2个友方随从获得本随从的攻击力。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=6|RACE=DRAGON
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        List<Card> ToListBuff = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c!=owner)
            {
                ToListBuff.Add(c);
            }
        }
        Card Buff1= ToListBuff.Choice(owner.myPlayer.randomGen);
        if(Buff1!=null)
        {
            ToListBuff.Remove(Buff1);
            new EffectChange(owner.myPlayer,owner,Buff1,atkChange:owner.GetTag(GameTag.Attack)).Resolve();
        }
        Card Buff2= ToListBuff.Choice(owner.myPlayer.randomGen);
        if(Buff2!=null)
        {
            new EffectChange(owner.myPlayer,owner,Buff2,atkChange:owner.GetTag(GameTag.Attack)).Resolve();
        }
    }
}
public class BG29_815_G:MinionBase{
//NAME=骨火巨龙夜之魇
//TEXT=<b>嘲讽</b>。<b>亡语：</b> 随机使2个友方随从获得本随从的攻击力，触发两次。
//MAJ=NEUTRAL|COST=4|ATK=20|HP=12|RACE=DRAGON
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        Trigger();
        Trigger();
    }
    public void Trigger()
    {
        List<Card> ToListBuff = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c!=owner)
            {
                ToListBuff.Add(c);
            }
        }
        Card Buff1= ToListBuff.Choice(owner.myPlayer.randomGen);
        if(Buff1!=null)
        {
            ToListBuff.Remove(Buff1);
            new EffectChange(owner.myPlayer,owner,Buff1,atkChange:owner.GetTag(GameTag.Attack)).Resolve();
        }
        Card Buff2= ToListBuff.Choice(owner.myPlayer.randomGen);
        if(Buff2!=null)
        {
            new EffectChange(owner.myPlayer,owner,Buff2,atkChange:owner.GetTag(GameTag.Attack)).Resolve();
        }
    }
}
public class BG29_815e:Ability{
//NAME=燃烧
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_816:MinionBase{
//NAME=咆哮聚群龙
//TEXT=每当一条友方的龙攻击时，使其获得+3/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=6|RACE=DRAGON
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackBeforeAttack(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.raceType.Contains(RaceType.Dragon) && tc.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
            {
                new EffectChange(owner.myPlayer,owner,sc,atkChange:3,hpChange:1).Resolve();
            }
        }
    }
}
public class BG29_816_G:MinionBase{
//NAME=咆哮聚群龙
//TEXT=每当一条友方的龙攻击时，使其获得+6/+2。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=12|RACE=DRAGON
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackBeforeAttack(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.raceType.Contains(RaceType.Dragon) && tc.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
            {
                new EffectChange(owner.myPlayer,owner,sc,atkChange:6,hpChange:2).Resolve();
            }
        }
    }
}
public class BG29_816_Ge:Ability{
//NAME=集结
//TEXT=+6/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_816e:Ability{
//NAME=集结
//TEXT=+3/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_821:MinionBase{
//NAME=狡猾的阿兰纳丝
//TEXT=每当本随从受到伤害，随机对一个敌方随从造成5点伤害。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=10|RACE=DEMON
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
    	if(amount>0)
    	{
    		TaskDamageRandomEnemyMinion(5);
    	}
    }
}
public class BG29_821_G:MinionBase{
//NAME=狡猾的阿兰纳丝
//TEXT=每当本随从受到伤害，随机对一个敌方随从造成5点伤害，触发两次。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=20|RACE=DEMON
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
    	if(amount>0)
    	{
    		TaskDamageRandomEnemyMinion(5);
    		TaskDamageRandomEnemyMinion(5);
    	}
    }
}
public class BG29_831:MinionBase{
//NAME=长牙约翰·库珀
//TEXT=每当本随从受到伤害，获取一张铸币牌。<i>（每场战斗限3次。）</i>3每当本随从受到伤害，获取一张铸币牌。<i>（还剩{0}次！）</i>
//MAJ=NEUTRAL|COST=4|ATK=4|HP=6|RACE=PIRATE
}
public class BG29_831_G:MinionBase{
//NAME=长牙约翰·库珀
//TEXT=每当本随从受到伤害，获取两张铸币牌。<i>（每场战斗限3次。）</i>3每当本随从受到伤害，获取两张铸币牌。<i>（还剩{0}次！）</i>
//MAJ=NEUTRAL|COST=4|ATK=8|HP=12|RACE=PIRATE
}
public class BG29_840:MinionBase{
//NAME=噬月者的勇士
//TEXT=在你使用奇数等级的牌后，使你的奇数等级的随从获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class BG29_840_G:MinionBase{
//NAME=噬月者的勇士
//TEXT=在你使用奇数等级的牌后，使你的奇数等级的随从获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=10|HP=10|RACE=NONE
}
public class BG29_840_Ge:Ability{
//NAME=蚀月有缺
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_840e:Ability{
//NAME=蚀月有缺
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_841:MinionBase{
//NAME=格雷迈恩的勇士
//TEXT=在你使用偶数等级的牌后，使你的偶数等级的随从获得+1/+1。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=NONE
}
public class BG29_841_G:MinionBase{
//NAME=格雷迈恩的勇士
//TEXT=在你使用偶数等级的牌后，使你的偶数等级的随从获得+2/+2。
//MAJ=NEUTRAL|COST=6|ATK=12|HP=12|RACE=NONE
}
public class BG29_841_Ge:Ability{
//NAME=吉尔尼斯的骄傲
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_841e:Ability{
//NAME=吉尔尼斯的骄傲
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_843:MinionBase{
//NAME=火焰舞者
//TEXT=<b>亡语：</b>对所有随从造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=6|HP=3|RACE=NONE
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
        TaskDamageTargets(ToDmg,1);
    }
}
public class BG29_843_G:MinionBase{
//NAME=火焰舞者
//TEXT=<b>亡语：</b>对所有 随从造成1点伤害，触发两次。
//MAJ=NEUTRAL|COST=2|ATK=12|HP=6|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
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
        TaskDamageTargets(ToDmg,1);
        ToDmg = new List<Card>();
        foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
        {
            if(c.GetTag(GameTag.Health)>0)
            {
                ToDmg.Add(c);
            }
        }
        TaskDamageTargets(ToDmg,1);
    }
}
public class BG29_844:MinionBase{
//NAME=辅翼奇美拉
//TEXT=每当本随从受到伤害，使每个类型的各一个友方随从永久获得+1/+1。<i>（每场战斗限两次。）</i>
//MAJ=NEUTRAL|COST=4|ATK=1|HP=6|RACE=ALL
}
public class BG29_844_G:MinionBase{
//NAME=辅翼奇美拉
//TEXT=每当本随从受到伤害，使每个类型的各一个友方随从永久获得+2/+2。<i>（每场战斗限两次。）</i>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=12|RACE=ALL
}
public class BG29_844_Ge:Ability{
//NAME=奇美拉之怒
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_844e:Ability{
//NAME=奇美拉之怒
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_845:MinionBase{
//NAME=助理警卫
//TEXT=<b>战吼：</b>使一个随从获得<b>嘲讽</b>，然后使你的<b>嘲讽</b>随从获得+2/+3。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=3|RACE=NONE
}
public class BG29_845_G:MinionBase{
//NAME=助理警卫
//TEXT=<b>战吼：</b>使一个随从获得<b>嘲讽</b>，然后使你的<b>嘲讽</b>随从获得+4/+6。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=6|RACE=NONE
}
public class BG29_845_Ge:Ability{
//NAME=扶助
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_845e:Ability{
//NAME=扶助
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_845e2:Ability{
//NAME=扶助嘲讽
//TEXT=<b>嘲讽</b>
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_846:MinionBase{
//NAME=记仇的树人
//TEXT=<b>嘲讽</b>。每当本随从受到伤害，使你的随从永久获得+2攻击力。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=12|RACE=NONE
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void AfterTakeDamage(Card source=null,int amount=0)
    {
        TaskBuffTargets(owner.myPlayer.board,atk:2);
    }
}
public class BG29_846_G:MinionBase{
//NAME=记仇的树人
//TEXT=<b>嘲讽</b>。每当本随从受到伤害，使你的随从永久获得+4攻击力。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=24|RACE=NONE
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
    }
    public override void AfterTakeDamage(Card source=null,int amount=0)
    {
        TaskBuffTargets(owner.myPlayer.board,atk:4);
    }
}
public class BG29_846_Ge:Ability{
//NAME=记下仇恨
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_846e:Ability{
//NAME=记下仇恨
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_861:MinionBase{
//NAME=贫瘠之地殴斗者
//TEXT=<b>战吼：</b>随机获取一张<b>亡语</b>随从牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=6|RACE=NONE
}
public class BG29_861_G:MinionBase{
//NAME=贫瘠之地殴斗者
//TEXT=<b>战吼：</b>随机获取2张<b>亡语</b>随从牌。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=12|RACE=NONE
}
public class BG29_862:MinionBase{
//NAME=贫瘠之地咒术师
//TEXT=<b>亡语：</b>随机获取一张<b>战吼</b>随从牌。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=2|RACE=NONE
}
public class BG29_862_G:MinionBase{
//NAME=贫瘠之地咒术师
//TEXT=<b>亡语：</b>随机获取2张<b>战吼</b>随从牌。
//MAJ=NEUTRAL|COST=5|ATK=12|HP=4|RACE=NONE
}
public class BG29_863:MinionBase{
//NAME=食尸卡布拉
//TEXT=在一个友方<b>亡语</b>随从死亡后，使你的随从永久获得+2/+1。
//MAJ=NEUTRAL|COST=6|ATK=4|HP=13|RACE=UNDEAD
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sz==ZoneType.Board&& tz==ZoneType.Grave)
            {
                if(sc.HasAbility("Deathrattle"))
                {
                    TaskBuffTargets(owner.myPlayer.board,atk:2,hp:1);
                }
            }
        }
    }
}
public class BG29_863_G:MinionBase{
//NAME=食尸卡布拉
//TEXT=在一个友方<b>亡语</b>随从死亡后，使你的随从永久获得+4/+2。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=26|RACE=UNDEAD
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
            if(sz==ZoneType.Board&& tz==ZoneType.Grave)
            {
                if(sc.HasAbility("Deathrattle"))
                {
                    TaskBuffTargets(owner.myPlayer.board,atk:4,hp:2);
                }
            }
        }
    }
}
public class BG29_863e:Ability{
//NAME=惊骇
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_864:MinionBase{
//NAME=旱地凶怪
//TEXT=<b>亡语：</b>召唤一个7/7的魔像。在本场战斗中每有一个类型的友方随从死亡，使其获得+7/+7。
//MAJ=NEUTRAL|COST=6|ATK=7|HP=7|RACE=ALL
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG29_864t"),ZoneType.Board);
    }
}
public class BG29_864_G:MinionBase{
//NAME=旱地凶怪
//TEXT=<b>亡语：</b>召唤一个14/14的魔像。在本场战斗中每有一个类型的友方随从死亡，使其获得+14/+14。
//MAJ=NEUTRAL|COST=6|ATK=14|HP=14|RACE=ALL
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void Deathrattle()
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("BG29_864_Gt"),ZoneType.Board);
    }
}
public class BG29_864_Gt:MinionBase{
//NAME=荒弃魔像
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=14|HP=14|RACE=NONE
}
public class BG29_864e2:Ability{
//NAME=凶悍
//TEXT=+7/+7。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_864e3:Ability{
//NAME=凶悍
//TEXT=+14/+14。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_864t:MinionBase{
//NAME=荒弃魔像
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=7|HP=7|RACE=NONE
}
public class BG29_865:MinionBase{
//NAME=领长副官
//TEXT=在一个友方<b>亡语</b>随从死亡后，在下回合获得1枚铸币。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=8|RACE=BEAST
}
public class BG29_865_G:MinionBase{
//NAME=领长副官
//TEXT=在一个友方<b>亡语</b>随从死亡后，在下回合获得2枚铸币。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=16|RACE=BEAST
}
public class BG29_870:MinionBase{
//NAME=死鳞海龙
//TEXT=<b>塑造法术：</b>触发一个友方随从的<b>战吼</b>。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=3|RACE=NAGA
}
public class BG29_870_G:MinionBase{
//NAME=死鳞海龙
//TEXT=<b>塑造法术：</b> 触发一个友方随从的<b>战吼</b>两次。
//MAJ=NEUTRAL|COST=4|ATK=16|HP=6|RACE=NAGA
}
public class BG29_870_Gt:SpellBase{
//NAME=波涛鳞立
//TEXT=触发一个友方随从的<b>战吼</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG29_870t:SpellBase{
//NAME=波涛鳞立
//TEXT=触发一个友方随从的<b>战吼</b>两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG29_871:MinionBase{
//NAME=异种钻地虫
//TEXT=<b>嘲讽</b>。<b>亡语：</b>使你的野兽永久获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=1|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Beast),atk:1,hp:1);
    }
}
public class BG29_871_G:MinionBase{
//NAME=异种钻地虫
//TEXT=<b>嘲讽</b>。<b>亡语：</b>使你的野兽永久获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=2|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
        TaskInitAbility("Taunt");
    }
    public override void Deathrattle()
    {
        TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Beast),atk:2,hp:2);
    }
}
public class BG29_871_Ge:Ability{
//NAME=钻地
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_871e:Ability{
//NAME=钻地
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_872:MinionBase{
//NAME=怨嗣藏宝龙
//TEXT=<b>战斗开始时：</b> 从生命值最高的敌方随从处偷取10/10的属性值。
//MAJ=NEUTRAL|COST=6|ATK=10|HP=10|RACE=DRAGON
	public override void OnCombatStart()
	{
		Card MaxHealth = null;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(MaxHealth==null)
			{
				MaxHealth=c;
			}
			else{
				if(c.GetTag(GameTag.Health) > MaxHealth.GetTag(GameTag.Health))
				{
					MaxHealth = c;
				}
			}
		}
		if(MaxHealth!=null)
		{
			new EffectChange(owner.myPlayer,owner,MaxHealth,atkChange:-10,hpChange:-10).Resolve();
			new EffectChange(owner.myPlayer,owner,owner,atkChange:10,hpChange:10).Resolve();
		}
	}
}
public class BG29_872_G:MinionBase{
//NAME=怨嗣藏宝龙
//TEXT=<b>战斗开始时：</b> 从生命值最高的敌方随从处偷取20/20的属性值。
//MAJ=NEUTRAL|COST=6|ATK=20|HP=20|RACE=DRAGON
    public override void Init()
    {
        TaskSetGolden();
    }
	public override void OnCombatStart()
	{
		Card MaxHealth = null;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(MaxHealth==null)
			{
				MaxHealth=c;
			}
			else{
				if(c.GetTag(GameTag.Health) > MaxHealth.GetTag(GameTag.Health))
				{
					MaxHealth = c;
				}
			}
		}
		if(MaxHealth!=null)
		{
			new EffectChange(owner.myPlayer,owner,MaxHealth,atkChange:-20,hpChange:-20).Resolve();
			new EffectChange(owner.myPlayer,owner,owner,atkChange:20,hpChange:20).Resolve();
		}
	}
}
public class BG29_872_Ge:Ability{
//NAME=蒙受怨恨
//TEXT=-20/-20。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_872_Ge2:Ability{
//NAME=大怨气包
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_872e:Ability{
//NAME=蒙受怨恨
//TEXT=-10/-10。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_872e2:Ability{
//NAME=大怨气包
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_873:MinionBase{
//NAME=魔血黏浆
//TEXT=<b>战吼：</b>在本局对战中，酒馆中的随从拥有+2生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=ELEMENTAL
}
public class BG29_873_G:MinionBase{
//NAME=魔血黏浆
//TEXT=<b>战吼：</b>在本局对战中，酒馆中的随从拥有+4生命值。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=8|RACE=ELEMENTAL
}
public class BG29_873e:Ability{
//NAME=熵能玩家附加效果
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_873e2:Ability{
//NAME=黏浆
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_875:MinionBase{
//NAME=不速来客
//TEXT=<b>战斗开始时：</b>使你的其他随从获得“<b>亡语：</b>召唤一个3/2的影子。”
//MAJ=NEUTRAL|COST=6|ATK=3|HP=2|RACE=UNDEAD
	public override void OnCombatStart()
	{
		List<Card> ToGive = owner.myPlayer.board.Exclude(owner);
		List<string> Abis = new List<string>();
		foreach(Card c in ToGive)
		{
			Abis.Add("BG29_875e");
		}
		new EffectGiveAbility(owner.myPlayer,owner,targets:ToGive,abinames:Abis).Resolve();
	}
}
public class BG29_875_G:MinionBase{
//NAME=不速来客
//TEXT=<b>战斗开始时：</b>使你的其他随从获得“<b>亡语：</b>召唤一个6/4的影子。”
//MAJ=NEUTRAL|COST=6|ATK=6|HP=4|RACE=UNDEAD
    public override void Init()
    {
        TaskSetGolden();
    }
	public override void OnCombatStart()
	{
		List<Card> ToGive = owner.myPlayer.board.Exclude(owner);
		List<string> Abis = new List<string>();
		foreach(Card c in ToGive)
		{
			Abis.Add("BG29_875_Ge");
		}
		new EffectGiveAbility(owner.myPlayer,owner,targets:ToGive,abinames:Abis).Resolve();
	}
}
public class BG29_875_Ge:Ability{
//NAME=未受邀请
//TEXT=<b>亡语：</b>召唤一个6/4的影子。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG29_875_Gt"),ZoneType.Board);
	}
}
public class BG29_875_Gt:MinionBase{
//NAME=影子
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=6|HP=4|RACE=UNDEAD
    public override void Init()
    {
        TaskSetGolden();
    }
}
public class BG29_875e:Ability{
//NAME=未受邀请
//TEXT=<b>亡语：</b>召唤一个3/2的影子。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG29_875t"),ZoneType.Board);
	}
}
public class BG29_875t:MinionBase{
//NAME=影子
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=3|HP=2|RACE=UNDEAD
}
public class BG29_877:MinionBase{
//NAME=魔血岩浆
//TEXT=<b>亡语：</b>在本局对战中，酒馆中的随从拥有+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=1|RACE=ELEMENTAL
}
public class BG29_877_G:MinionBase{
//NAME=魔血岩浆
//TEXT=<b>亡语：</b>在本局对战中，酒馆中的随从拥有+4攻击力。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=2|RACE=ELEMENTAL
}
public class BG29_877e:Ability{
//NAME=邪火玩家附加效果
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_877e2:Ability{
//NAME=岩浆
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_878:MinionBase{
//NAME=傲角铁牛
//TEXT=每当本随从受到伤害，获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=6|ATK=10|HP=16|RACE=BEAST
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
    	if(amount>0)
    	{
    		if(!owner.HasAbility("DivineShield"))
    		{
    			new EffectGiveAbility(owner.myPlayer,owner,owner,"DivineShield").Resolve();
    		}
    	}
    }
}
public class BG29_878_G:MinionBase{
//NAME=傲角铁牛
//TEXT=每当本随从受到伤害，获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=6|ATK=20|HP=32|RACE=BEAST
    public override void Init()
    {
    	TaskSetGolden();
    }
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
    	if(amount>0)
    	{
    		if(!owner.HasAbility("DivineShield"))
    		{
    			new EffectGiveAbility(owner.myPlayer,owner,owner,"DivineShield").Resolve();
    		}
    	}
    }
}
public class BG29_878e:Ability{
//NAME=傲气难驯
//TEXT=<b><b>圣盾</b>。</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_879:MinionBase{
//NAME=甲壳元素
//TEXT=<b>塑造法术：</b>选择一个酒馆中的随从，随机使一个友方随从获得选中随从的属性值。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=NAGA
}
public class BG29_879_G:MinionBase{
//NAME=甲壳元素
//TEXT=<b>塑造法术：</b>选择一个酒馆中的随从，随机使一个友方随从获得选中随从的双倍属性值。
//MAJ=NEUTRAL|COST=5|ATK=10|HP=8|RACE=NAGA
}
public class BG29_879e:Ability{
//NAME=出击甲壳
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_879t:SpellBase{
//NAME=甲壳出击
//TEXT=选择一个酒馆中的随从，随机使一个友方随从获得选中随从的属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG29_879t_G:SpellBase{
//NAME=甲壳出击
//TEXT=选择一个酒馆中的随从，随机使一个友方随从获得选中随从的双倍属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG29_888:MinionBase{
//NAME=微光护卫者
//TEXT=每当本随从攻击时，获得+2/+1。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=3|RACE=DRAGON
    public override void BeforeAttack(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:1).Resolve();
    }
}
public class BG29_888_G:MinionBase{
//NAME=微光护卫者
//TEXT=每当本随从攻击时，获得+4/+2。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=6|RACE=DRAGON
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void BeforeAttack(Card target=null)
    {
        new EffectChange(owner.myPlayer,owner,owner,atkChange:4,hpChange:2).Resolve();
    }
}
public class BG29_888_Ge:Ability{
//NAME=灼热吐息
//TEXT=+4/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_888e:Ability{
//NAME=灼热吐息
//TEXT=+2/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_889:MinionBase{
//NAME=鱼人王子
//TEXT=每当本随从获得属性值时，获得量增加+2/+2<i>（无论本随从在哪）</i>。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=2|RACE=MURLOC
}
public class BG29_889_G:MinionBase{
//NAME=鱼人王子
//TEXT=每当本随从获得属性值时，获得量增加+4/+4<i>（无论本随从在哪）</i>。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=MURLOC
}
public class BG29_889_Ge:Ability{
//NAME=魔力之吻
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_889e:Ability{
//NAME=魔力之吻
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_990:MinionBase{
//NAME=火暴雄鸡
//TEXT=<b>战斗开始时：</b>对相邻随从造成1点伤害并使其获得+4攻击力。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=4|RACE=BEAST
    public override void OnCombatStart()
    {
        List<Card> Adj = FindAdj(owner);
        if(Adj.Count>0)
        {
            TaskDamageTargets(Adj,1);
            TaskBuffTargets(Adj,atk:4);
        }
    }
}
public class BG29_990_G:MinionBase{
//NAME=火暴雄鸡
//TEXT=<b>战斗开始时：</b>对相邻随从造成1点伤害并使其获得+4攻击力，触发两次。
//MAJ=NEUTRAL|COST=2|ATK=6|HP=8|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
    public void Trigger()
    {
        List<Card> Adj = FindAdj(owner);
        if(Adj.Count>0)
        {
            TaskDamageTargets(Adj,1);
            TaskBuffTargets(Adj,atk:4);
        }        
    }
    public override void OnCombatStart()
    {
        Trigger();
        Trigger();
    }
}
public class BG29_990e:Ability{
//NAME=火暴
//TEXT=+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_991:MinionBase{
//NAME=钢铁鱼人II型
//TEXT=<b>复仇（4）：</b>使你手牌中和场上的随从永久获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=5|RACE=MECHANICAL
    private int RevengeCnt = 0;
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.myPlayer==owner.myPlayer)
            {
                if(sz==ZoneType.Board && tz==ZoneType.Grave)
                {
                    this.RevengeCnt+=1;
                    if(this.RevengeCnt%4==0)
                    {
                        TriggBuff();
                    }
                }
            }
        }
    }

    public void TriggBuff()
    {
        TaskBuffTargets(owner.myPlayer.board.Merge(owner.myPlayer.hand),atk:1,hp:1);
    }
}
public class BG29_991_G:MinionBase{
//NAME=钢铁鱼人II型
//TEXT=<b>复仇（4）：</b>使你手牌中和场上的随从永久获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=10|RACE=MECHANICAL
    public override void Init()
    {
        TaskSetGolden();
    }
    private int RevengeCnt = 0;
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(CondInPlay())
        {
            if(sc.myPlayer==owner.myPlayer)
            {
                if(sz==ZoneType.Board && tz==ZoneType.Grave)
                {
                    this.RevengeCnt+=1;
                    if(this.RevengeCnt%4==0)
                    {
                        TriggBuff();
                    }
                }
            }
        }
    }

    public void TriggBuff()
    {
        TaskBuffTargets(owner.myPlayer.board.Merge(owner.myPlayer.hand),atk:2,hp:2);
    }
}
public class BG29_991_Ge:Ability{
//NAME=我，机器鱼人
//TEXT=属性值提高
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG29_991e:Ability{
//NAME=我，机器鱼人
//TEXT=属性值提高
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
