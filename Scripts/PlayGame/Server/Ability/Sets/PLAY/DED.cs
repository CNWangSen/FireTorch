using System.Collections;
using System.Collections.Generic;

public class DED_001:MinionBase{
//NAME=暗礁德鲁伊
//TEXT=<b>抉择：</b>变形成为3/1并具有<b>突袭</b>的鲨鱼；或者变形成为1/3并具有<b>嘲讽</b>的海龟。
//MAJ=DRUID|COST=1|ATK=1|HP=1|RACE=NONE
}
public class DED_001a:MinionBase{
//NAME=鲨鱼形态
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=1|ATK=3|HP=1|RACE=BEAST
}
public class DED_001at:MinionBase{
//NAME=暗礁德鲁伊
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=1|ATK=3|HP=1|RACE=BEAST
}
public class DED_001b:MinionBase{
//NAME=海龟形态
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=1|ATK=1|HP=3|RACE=BEAST
}
public class DED_001bt:MinionBase{
//NAME=暗礁德鲁伊
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=1|ATK=1|HP=3|RACE=BEAST
}
public class DED_001c:MinionBase{
//NAME=暗礁德鲁伊
//TEXT=<b>突袭</b> <b>嘲讽</b>
//MAJ=DRUID|COST=1|ATK=3|HP=3|RACE=BEAST
}
public class DED_002:SpellBase{
//NAME=月光指引
//TEXT=<b>发现</b>你牌库中一张牌的复制。如果你在本回合中使用这张复制，则抽取本体。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=ARCANE
}
public class DED_002e:Ability{
//NAME=月光之路
//TEXT=如果在本回合中使用，则抽取复制的本体。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DED_003:MinionBase{
//NAME=应急木工
//TEXT=<b>战吼：</b>抽一张<b>抉择</b>法术牌并将其拆分。
//MAJ=DRUID|COST=2|ATK=2|HP=1|RACE=PIRATE
}
public class DED_004:WeaponBase{
//NAME=黑水弯刀
//TEXT=<b>可交易</b> 在你<b>交易</b>此牌后，使你手牌中的一张法术牌的法力值消耗减少（1）点。
//MAJ=ROGUE|COST=1|ATK=2|HP=2|RACE=NONE
}
public class DED_004e:Ability{
//NAME=黑水宝藏
//TEXT=法力值消耗减少（1）点。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DED_005:SpellBase{
//NAME=海盗谈判
//TEXT=交换此牌与你对手牌库中的一张牌。
//MAJ=ROGUE|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DED_006:MinionBase{
//NAME=重拳先生
//TEXT=你的海盗拥有<b>冲锋</b>。
//MAJ=NEUTRAL|COST=7|ATK=6|HP=5|RACE=PIRATE
}
public class DED_006e2:Ability{
//NAME=冲锋
//TEXT={0}使其获得<b>冲锋</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DED_007:MinionBase{
//NAME=迪菲亚炸鱼手
//TEXT=<b>战吼：</b> 随机对一个敌人造成2点伤害。每有一只你的野兽，重复一次。
//MAJ=HUNTER|COST=5|ATK=3|HP=2|RACE=PIRATE
}
public class DED_008:MinionBase{
//NAME=巨型鹦鹉
//TEXT=<b>战吼：</b>获取上一个死亡的友方<b>亡语</b>随从的一张复制。
//MAJ=HUNTER|COST=4|ATK=3|HP=4|RACE=BEAST
}
public class DED_009:SpellBase{
//NAME=狗狗饼干
//TEXT=<b>可交易</b> 使一个随从获得+2/+3。在你<b>交易</b>此牌后，使一个友方随从获得<b>突袭</b>。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DED_009e:Ability{
//NAME=乖狗狗！
//TEXT=+2/+3。
//MAJ=HUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DED_500:MinionBase{
//NAME=分赃专员
//TEXT=<b>嘲讽</b>，<b>战吼：</b>交换攻击力最高和最低的随从的攻击力。
//MAJ=PALADIN|COST=5|ATK=2|HP=8|RACE=PIRATE
}
public class DED_500e:Ability{
//NAME=重新分配
//TEXT=攻击力交换。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DED_501:MinionBase{
//NAME=金翼鹦鹉
//TEXT=<b>战吼：</b> 重复你上一个对友方随从施放的法术，施放在本随从身上。
//MAJ=PALADIN|COST=4|ATK=3|HP=4|RACE=BEAST
}
public class DED_502:SpellBase{
//NAME=正义防御
//TEXT=将一个随从的攻击力和生命值变为1，并使你手牌中的一张随从牌获得其失去的属性值。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=HOLY
}
public class DED_502e:Ability{
//NAME=遭受裁决
//TEXT=1/1。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DED_502e2:Ability{
//NAME=圣光眷顾
//TEXT=属性值提高。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DED_503:MinionBase{
//NAME=暗影之刃飞刀手
//TEXT=<b>战吼：</b>如果你在本回合中受到过伤害，则对一个敌方随从造成等量的伤害。
//MAJ=WARLOCK|COST=1|ATK=2|HP=1|RACE=PIRATE
}
public class DED_504:SpellBase{
//NAME=邪恶船运
//TEXT=<b>可交易</b> 召唤2个1/1的小鬼。<i>（被<b>交易</b>时会升级，增加2个！）</i>
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=NONE
}
public class DED_505:MinionBase{
//NAME=碎舰恶魔
//TEXT=<b>战吼，亡语：</b>抽一张法术牌。你的英雄受到等同于法术牌法力值消耗的伤害。
//MAJ=WARLOCK|COST=4|ATK=4|HP=3|RACE=DEMON
}
public class DED_506:SpellBase{
//NAME=贪婪需求
//TEXT=<b>可交易</b> 抽三张牌。如果在本回合被抽到，则法力值消耗为（3）点。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class DED_507:MinionBase{
//NAME=桅台观察员
//TEXT=<b>战吼：</b>对最左边和最右边的敌方随从造成2点伤害。
//MAJ=DEMONHUNTER|COST=3|ATK=2|HP=2|RACE=DEMON
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.otherPlayer.board.Count==0)
        {
            return;
        }
        Card Left = owner.myPlayer.otherPlayer.board[0];
        Card Right = owner.myPlayer.otherPlayer.board.Last();
        List<Card> ToListDamage = new List<Card>(){Left,Right};
        TaskDamageTargets(ToListDamage,2);
    }
}
public class DED_508:SpellBase{
//NAME=试炼场
//TEXT=从你的牌库中召唤两个随从，并使其互相攻击！
//MAJ=DEMONHUNTER|COST=6|ATK=0|HP=0|RACE=NONE
}
public class DED_509:MinionBase{
//NAME=艳丽的金刚鹦鹉
//TEXT=<b>战吼：</b>重复你使用的上一个<b>战吼</b>。
//MAJ=SHAMAN|COST=3|ATK=3|HP=3|RACE=BEAST
}
public class DED_510:MinionBase{
//NAME=艾德温，迪菲亚首脑
//TEXT=<b>战吼：</b>抽一张牌。如果你在本回合中使用抽到的牌，则获得+2/+2并重复此效果。
//MAJ=ROGUE|COST=4|ATK=4|HP=4|RACE=PIRATE
}
public class DED_510e:Ability{
//NAME=迪菲亚补给
//TEXT=如果在本回合中使用，抽一张牌并使艾德温获得+2/+2。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DED_510e2:Ability{
//NAME=兄弟会之王
//TEXT=属性值提高。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DED_511:MinionBase{
//NAME=吸盘钩手
//TEXT=在你的回合结束时，将你的武器变形成为法力值消耗增加（1）点的武器。
//MAJ=SHAMAN|COST=4|ATK=3|HP=6|RACE=PIRATE
}
public class DED_512:SpellBase{
//NAME=不朽护符
//TEXT=<b>可交易</b> 复活1个友方<b>亡语</b>随从。<i>（被<b>交易</b>时会升级！）</i>
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class DED_513:MinionBase{
//NAME=迪菲亚麻风侏儒
//TEXT=<b>战吼：</b>如果你的手牌中有暗影法术牌，则造成2点伤害。
//MAJ=PRIEST|COST=2|ATK=3|HP=2|RACE=PIRATE
    public override void Battlecry(Card target=null)
    {
        foreach(Card c in owner.myPlayer.hand)
        {
            if(c.spellType.Contains(SpellSchoolType.Shadow))
            {
                new EffectDamage(owner.myPlayer,owner,target,2).Resolve();
                break;
            }
        }
    }
}
public class DED_514:MinionBase{
//NAME=仿冒猫猫
//TEXT=<b>战吼：</b>将你对手使用的下一张牌的一张复制置入你的手牌。
//MAJ=PRIEST|COST=3|ATK=3|HP=4|RACE=BEAST
}
public class DED_514e:Ability{
//NAME=仿冒猫猫
//TEXT=将你对手使用的下一张牌的一张复制置入你的手牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DED_515:MinionBase{
//NAME=灰贤鹦鹉
//TEXT=<b>战吼：</b> 重复你施放的上一个法力值消耗大于或等于（6）点的法术。
//MAJ=MAGE|COST=6|ATK=4|HP=5|RACE=BEAST
}
public class DED_516:MinionBase{
//NAME=深水唤醒师
//TEXT=<b>战吼：</b>抽一张法术牌，并获得等同于其法力值消耗的护甲值。
//MAJ=MAGE|COST=4|ATK=3|HP=4|RACE=PIRATE
}
public class DED_517:SpellBase{
//NAME=奥术溢爆
//TEXT=对一个敌方随从造成$8点伤害。召唤一滩残渣，属性值等同于超过目标生命值的伤害。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class DED_517t:MinionBase{
//NAME=奥术残渣
//TEXT=
//MAJ=MAGE|COST=1|ATK=1|HP=1|RACE=ELEMENTAL
}
public class DED_518:SpellBase{
//NAME=操纵火炮
//TEXT=对一个随从造成$3点伤害，并对所有其他随从造成$1点 伤害。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class DED_519:MinionBase{
//NAME=迪菲亚炮手
//TEXT=在你的英雄攻击后，随机对一个敌人造成2点伤害，触发两次。
//MAJ=WARRIOR|COST=3|ATK=3|HP=3|RACE=PIRATE
	public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,CauseEvent));
    }

    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc.GetTag(GameTag.ZoneType) == (int)ZoneType.Hero && CondInPlay())
        {
            TaskDamageRandomEnemy(2);
            TaskDamageRandomEnemy(2);
        }
    }
}
public class DED_521:MinionBase{
//NAME=最疯狂的爆破者
//TEXT=<b>战吼：</b>造成12点伤害，随机分配到所有其他角色身上。
//MAJ=NEUTRAL|COST=8|ATK=9|HP=8|RACE=NONE
}
public class DED_522:MinionBase{
//NAME=厨师曲奇
//TEXT=<b>吸血</b>，<b>亡语：</b>装备一把2/3并具有<b>吸血</b>的搅汤棒。
//MAJ=SHAMAN|COST=3|ATK=2|HP=3|RACE=MURLOC
}
public class DED_522t:WeaponBase{
//NAME=曲奇的搅汤棒
//TEXT=<b>吸血</b>
//MAJ=SHAMAN|COST=3|ATK=2|HP=3|RACE=NONE
}
public class DED_523:MinionBase{
//NAME=葛拉卡蟹杀手
//TEXT=<b>战吼：</b>消灭一只野兽，并获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=PIRATE
}
public class DED_523e:Ability{
//NAME=肚腹满饱
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class DED_524:MinionBase{
//NAME=多系施法者
//TEXT=<b>战吼：</b> 在本局对战中，你每施放过一个不同派系的法术，抽一张牌。0<i>(抽0张牌)</i>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=4|RACE=PIRATE
}
public class DED_525:MinionBase{
//NAME=哥利亚，斯尼德的杰作
//TEXT=<b>战吼：</b>对敌方随从发射五枚火箭，每枚火箭造成2点伤害。<i>（目标由你选定！）</i>
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=MECHANICAL
}
public class DED_527:WeaponBase{
//NAME=铁匠锤
//TEXT=<b>可交易</b> 在你<b>交易</b>此牌后，获得+2耐久度。
//MAJ=WARRIOR|COST=4|ATK=5|HP=1|RACE=NONE
}
public class DED_527e:Ability{
//NAME=锻造
//TEXT=+2耐久度。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
