using System.Collections;
using System.Collections.Generic;

public class TRL_010:MinionBase{
//NAME=中场拾荒者
//TEXT=<b>潜行</b> <b>超杀</b>：获得3点 护甲值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class TRL_012:SpellBase{
//NAME=图腾重击
//TEXT=造成$2点伤害。 <b>超杀</b>：召唤一个 基础图腾。
//MAJ=SHAMAN|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TRL_015:MinionBase{
//NAME=黑心票贩
//TEXT=<b>超杀</b>：抽两张牌。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=3|RACE=PIRATE
}
public class TRL_020:MinionBase{
//NAME=盲眼游侠
//TEXT=<b>突袭</b> <b>超杀</b>：召唤两个1/1的蝙蝠。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=4|RACE=NONE
}
public class TRL_020t:MinionBase{
//NAME=蝙蝠
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TRL_057:MinionBase{
//NAME=毒蛇守卫
//TEXT=在你的回合结束时，对敌方英雄造成2点 伤害。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=2|RACE=TOTEM
}
public class TRL_058:SpellBase{
//NAME=亡鬼幻象
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗减少（3）点。<b>发现</b>一张法术牌。
//MAJ=SHAMAN|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class TRL_058e:Ability{
//NAME=幻象
//TEXT=在本回合中，你所施放的下一个法术的法力值消耗减少（3）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_059:MinionBase{
//NAME=沼泽游荡者
//TEXT=<b>战吼：</b>将一个友方随从移回你的手牌，并使其获得+2/+2。
//MAJ=SHAMAN|COST=3|ATK=3|HP=3|RACE=ELEMENTAL
}
public class TRL_059e:Ability{
//NAME=淹没
//TEXT=+2/+2。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_060:MinionBase{
//NAME=青蛙之灵
//TEXT=<b>潜行</b>一回合。每当你施放一个法术，从你的牌库中抽取一张法力值消耗增加（1）点的法术牌。
//MAJ=SHAMAN|COST=5|ATK=0|HP=3|RACE=UNDEAD
}
public class TRL_065:HeroBase{
//NAME=祖尔金
//TEXT=<b>战吼：</b> 施放你在本局对战中使用过的所有法术<i>（目标随机而定）</i>。
//MAJ=HUNTER|COST=10|ATK=0|HP=30|RACE=NONE
}
public class TRL_065h:HeroPowerBase{
//NAME=狂暴投掷
//TEXT=造成$2点伤害。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TRL_071:MinionBase{
//NAME=血帆啸猴
//TEXT=<b>突袭</b>，<b>战吼：</b>你每控制一个其他海盗，便获得+1/+1。
//MAJ=ROGUE|COST=2|ATK=1|HP=1|RACE=PIRATE
}
public class TRL_071e:Ability{
//NAME=血帆之旅
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_074:WeaponBase{
//NAME=锯刃齿
//TEXT=<b>亡语：</b>使你的所有随从获得<b>突袭</b>。
//MAJ=ROGUE|COST=1|ATK=1|HP=3|RACE=NONE
}
public class TRL_074e:Ability{
//NAME=尖牙
//TEXT=<b>突袭</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_077:MinionBase{
//NAME=古拉巴什宣传员
//TEXT=<b>战吼：</b> <b>发现</b>一张具有<b>战吼</b>的随从牌的1/1复制，其法力值消耗为（1）点。
//MAJ=ROGUE|COST=7|ATK=5|HP=7|RACE=NONE
}
public class TRL_077e:Ability{
//NAME=言过其实
//TEXT=古拉巴什宣传员将其变为了1/1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_082:SpellBase{
//NAME=终极巫毒
//TEXT=使一个友方随从获得“<b>亡语：</b>随机召唤一个法力值消耗增加（1）点的随从。”
//MAJ=SHAMAN|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class TRL_082e:Ability{
//NAME=巫毒
//TEXT=<b>亡语：</b>随机召唤一个法力值消耗增加（1）点的随从。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_085:MinionBase{
//NAME=泽蒂摩
//TEXT=每当你以一个随从为目标施放法术时，对该随从相邻的随从再次施放。
//MAJ=SHAMAN|COST=3|ATK=1|HP=3|RACE=NONE
}
public class TRL_085e:Ability{
//NAME=泽蒂摩的魔法浪潮
//TEXT=每当你以一个随从为目标施放法术时，该随从相邻的随从同时成为法术的目标。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_092:MinionBase{
//NAME=鲨鱼之灵
//TEXT=<b>潜行</b>一回合。你的随从的<b>战吼</b>和<b>连击</b>触发两次。
//MAJ=ROGUE|COST=4|ATK=0|HP=3|RACE=UNDEAD
}
public class TRL_092e:Ability{
//NAME=鲨鱼之力
//TEXT=你的随从的<b>战吼</b>和<b>连击</b>效果触发两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_096:MinionBase{
//NAME=格里伏塔
//TEXT=<b>战吼：</b><b>发现</b>两张牌。随机交给你的对手其中一张。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=5|RACE=NONE
}
public class TRL_096e:Ability{
//NAME=猜猜看！
//TEXT=猜测你的对手会选择哪一张。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_097:SpellBase{
//NAME=灵媒术
//TEXT=选择一个随从，将一张它的复制置入你的手牌。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=SHADOW
}
public class TRL_111:WeaponBase{
//NAME=猎头者之斧
//TEXT=<b>战吼：</b>如果你控制一个野兽，便获得+1耐久度。
//MAJ=HUNTER|COST=2|ATK=2|HP=2|RACE=NONE
}
public class TRL_111e1:Ability{
//NAME=猎头者之斧
//TEXT=耐久度提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_119:SpellBase{
//NAME=野兽之心
//TEXT=使一个友方野兽获得+1/+1，使其随机攻击一个敌方随从。
//MAJ=HUNTER|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TRL_119e:Ability{
//NAME=野兽之心
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_124:SpellBase{
//NAME=团伙劫掠
//TEXT=从你的牌库中抽两张海盗牌。 <b>连击：</b>并抽一张 武器牌。
//MAJ=ROGUE|COST=3|ATK=0|HP=0|RACE=NONE
}
public class TRL_126:MinionBase{
//NAME=钩牙船长
//TEXT=<b>战吼：</b>从你的牌库中召唤三个海盗，并使其获得<b>突袭</b>。
//MAJ=ROGUE|COST=8|ATK=6|HP=3|RACE=PIRATE
}
public class TRL_127:SpellBase{
//NAME=火炮弹幕
//TEXT=随机对一个敌人造成$3点伤害。你每有一个海盗，就重复 一次。
//MAJ=ROGUE|COST=6|ATK=0|HP=0|RACE=NONE
}
public class TRL_128:SpellBase{
//NAME=再生
//TEXT=恢复#3点生命值。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=HOLY
}
public class TRL_131:MinionBase{
//NAME=沙地苦工
//TEXT=每当你施放一个法术，召唤一个1/1并具有<b>嘲讽</b>的僵尸。
//MAJ=PRIEST|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class TRL_131t:MinionBase{
//NAME=僵尸
//TEXT=<b>嘲讽</b>
//MAJ=PRIEST|COST=1|ATK=1|HP=1|RACE=UNDEAD
}
public class TRL_151:MinionBase{
//NAME=退役冠军
//TEXT=<b>战吼：</b>召唤一个5/5的赛场新秀。
//MAJ=NEUTRAL|COST=5|ATK=1|HP=1|RACE=NONE
}
public class TRL_151t:MinionBase{
//NAME=赛场新秀
//TEXT=
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class TRL_156:SpellBase{
//NAME=盗取武器
//TEXT=<b>发现</b>一张<i>（另一职业的）</i> 武器牌。
//MAJ=ROGUE|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TRL_157:SpellBase{
//NAME=走跳板
//TEXT=消灭一个未受伤的随从。
//MAJ=ROGUE|COST=4|ATK=0|HP=0|RACE=NONE
}
public class TRL_223:MinionBase{
//NAME=迅猛龙之灵
//TEXT=<b>潜行</b>一回合。在你的英雄攻击并消灭一个随从后，抽一张牌。
//MAJ=DRUID|COST=1|ATK=0|HP=3|RACE=UNDEAD
}
public class TRL_232:MinionBase{
//NAME=铁皮恐角龙
//TEXT=<b>超杀：</b>召唤一个5/5的铁皮小恐龙。
//MAJ=DRUID|COST=7|ATK=7|HP=7|RACE=BEAST
    public override void OverKill(Card target = null, int amount = 0)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("TRL_232t"),ZoneType.Board);
    }
}
public class TRL_232t:MinionBase{
//NAME=铁皮小恐龙
//TEXT=
//MAJ=DRUID|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class TRL_232_G:MinionBase{
//NAME=铁皮恐角龙
//TEXT=<b>超杀：</b>召唤一个5/5的铁皮小恐龙。
//MAJ=DRUID|COST=7|ATK=7|HP=7|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
    public override void OverKill(Card target = null, int amount = 0)
    {
        TaskCreate(CardDbf.GetCardDbfByGuid("TRL_232t_G"),ZoneType.Board);
    }
}
public class TRL_232t_G:MinionBase{
//NAME=铁皮小恐龙
//TEXT=
//MAJ=DRUID|COST=5|ATK=5|HP=5|RACE=BEAST
    public override void Init()
    {
        TaskSetGolden();
    }
}

public class TRL_240:MinionBase{
//NAME=野蛮先锋
//TEXT=<b>战吼：</b>对一个敌方随从造成等同于你的英雄攻击力的伤害。
//MAJ=DRUID|COST=2|ATK=2|HP=3|RACE=NONE
}
public class TRL_241:MinionBase{
//NAME=贡克，迅猛龙之神
//TEXT=在你的英雄攻击并消灭一个随从后，便可再次攻击。
//MAJ=DRUID|COST=7|ATK=4|HP=9|RACE=BEAST
}
public class TRL_243:SpellBase{
//NAME=飞扑
//TEXT=在本回合中，使你的英雄获得+2攻击力。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_243e:Ability{
//NAME=飞扑
//TEXT=在本回合中，+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_244:SpellBase{
//NAME=掠食本能
//TEXT=从你的牌库中抽一张野兽牌。将其生命值翻倍。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        Card Drawn = TaskDrawRace(RaceType.Beast);
        new EffectChange(owner.myPlayer,owner,Drawn,hpChange:Drawn.GetTag(GameTag.Health)).Resolve();
    }
}
public class TRL_244e:Ability{
//NAME=掠食本能
//TEXT=生命值翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_245:SpellBase{
//NAME=尖啸
//TEXT=弃掉你手牌中法力值消耗最低的牌。对所有随从造成$2点 伤害。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class TRL_246:SpellBase{
//NAME=虚空契约
//TEXT=摧毁双方牌库中一半的牌。
//MAJ=WARLOCK|COST=8|ATK=0|HP=0|RACE=SHADOW
}
public class TRL_247:MinionBase{
//NAME=护魂者
//TEXT=<b>战吼：</b>随机将三张你在本局对战中弃掉的牌置入你的手牌。
//MAJ=WARLOCK|COST=6|ATK=6|HP=6|RACE=NONE
}
public class TRL_249:SpellBase{
//NAME=残酷集结
//TEXT=消灭一个友方随从。使你的所有随从获得+1/+1。
//MAJ=WARLOCK|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class TRL_249e:Ability{
//NAME=残酷集结
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_251:MinionBase{
//NAME=蝙蝠之灵
//TEXT=<b>潜行</b>一回合。在一个友方随从死亡后，使你手牌中的一张随从牌获得+1/+1。
//MAJ=WARLOCK|COST=2|ATK=0|HP=3|RACE=UNDEAD
}
public class TRL_251e:Ability{
//NAME=希里克的恩赐
//TEXT=蝙蝠之灵使其获得属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_252:MinionBase{
//NAME=高阶祭司耶克里克
//TEXT=<b>嘲讽，吸血</b> 当你弃掉这张牌时，将这张牌的两张复制置入你的手牌。
//MAJ=WARLOCK|COST=4|ATK=3|HP=5|RACE=NONE
}
public class TRL_253:MinionBase{
//NAME=希里克，蝙蝠之神
//TEXT=<b>战吼：</b>用本随从的复制填满你的面板。
//MAJ=WARLOCK|COST=8|ATK=1|HP=1|RACE=BEAST
}
public class TRL_254:SpellBase{
//NAME=神灵印记
//TEXT=<b>抉择：</b> 使一个随从获得+2/+4和<b>嘲讽</b>；或者召唤两个3/2的迅猛龙。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class TRL_254a:SpellBase{
//NAME=贡克的坚韧
//TEXT=使一个随从获得+2/+4和<b>嘲讽</b>。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class TRL_254ae:Ability{
//NAME=神灵印记
//TEXT=+2/+4并具有<b>嘲讽</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_254b:SpellBase{
//NAME=迅猛龙群
//TEXT=召唤两个 3/2的迅猛龙。
//MAJ=DRUID|COST=4|ATK=0|HP=0|RACE=NATURE
}
public class TRL_254t:MinionBase{
//NAME=迅猛龙
//TEXT=
//MAJ=DRUID|COST=2|ATK=3|HP=2|RACE=BEAST
}
public class TRL_255:SpellBase{
//NAME=狂奔怒吼
//TEXT=随机从你的手牌中召唤一个野兽，并使其获得<b>突袭</b>。
//MAJ=DRUID|COST=6|ATK=0|HP=0|RACE=NONE
}
public class TRL_255e:Ability{
//NAME=奔踏！
//TEXT=拥有<b>突袭</b>。
//MAJ=DRUID|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_257:MinionBase{
//NAME=鲜血巨魔工兵
//TEXT=在一个友方随从 死亡后，对敌方英雄造成2点伤害。
//MAJ=WARLOCK|COST=7|ATK=5|HP=8|RACE=NONE
}
public class TRL_258:SpellBase{
//NAME=群体狂乱
//TEXT=使每个随从随机攻击其他随从。
//MAJ=PRIEST|COST=5|ATK=0|HP=0|RACE=SHADOW
    public override void Battlecry(Card target=null)
    {
        List<Card> ToAttack = new List<Card>();
        foreach(Card c in owner.myPlayer.board)
        {
            ToAttack.Add(c);
        }
        foreach(Card c in ToAttack)
        {
            if(c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.GetTag(GameTag.Health)>0)
            {
                Card Target = owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board).Exclude(c).Choice(owner.myPlayer.randomGen);
                new EffectAttack(owner.myPlayer,c,Target).Resolve();
            }
        }
    }
}
public class TRL_259:MinionBase{
//NAME=塔兰吉公主
//TEXT=<b>战吼：</b> 召唤你的手牌中所有你的套牌之外的 随从。
//MAJ=PRIEST|COST=8|ATK=7|HP=5|RACE=NONE
}
public class TRL_260:MinionBase{
//NAME=邦桑迪，死亡之神
//TEXT=<b>战吼：</b>从你的牌库中抽取法力值消耗为（1）的随从，直到达到你的手牌上限。
//MAJ=PRIEST|COST=7|ATK=7|HP=7|RACE=UNDEAD
}
public class TRL_300:MinionBase{
//NAME=西瓦尔拉，猛虎之神
//TEXT=<b>圣盾，突袭，吸血</b> 你每消耗1点法力值用于法术牌上，本牌的法力值消耗便减少（1）点。
//MAJ=PALADIN|COST=25|ATK=7|HP=5|RACE=BEAST
    public override void Init()
    {
        TaskInitAbility("DivineShield");
        TaskInitAbility("LifeSteal");
    }
}
public class TRL_302:SpellBase{
//NAME=暂避锋芒
//TEXT=直到你的 下个回合，你的英雄<b>免疫</b>。
//MAJ=PALADIN|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        new EffectGiveAbility(owner.myPlayer,owner,owner.myPlayer.hero[0],"Immue").Resolve();
    }
}
public class TRL_302e:Ability{
//NAME=暂避锋芒
//TEXT=<b>免疫</b>，直到你的下个回合。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_304:WeaponBase{
//NAME=法拉基战斧
//TEXT=<b>超杀：</b>使你手牌中的一张随从牌 获得+2/+2。
//MAJ=PALADIN|COST=5|ATK=3|HP=3|RACE=NONE
}
public class TRL_304e:Ability{
//NAME=战斗准备
//TEXT=法拉基战斧使其获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_305:SpellBase{
//NAME=新人登场
//TEXT=<b>发现</b>一张法力值消耗为（6）的随从牌。召唤该随从并使其获得<b>嘲讽</b>和<b>圣盾</b>。
//MAJ=PALADIN|COST=7|ATK=0|HP=0|RACE=NONE
}
public class TRL_306:MinionBase{
//NAME=永恒祭司
//TEXT=<b>亡语：</b>将本随从洗入你的牌库。保留所有附加效果。
//MAJ=PALADIN|COST=2|ATK=1|HP=3|RACE=NONE
}
public class TRL_307:SpellBase{
//NAME=圣光闪现
//TEXT=恢复#4点生命值。抽一张牌。
//MAJ=PALADIN|COST=2|ATK=0|HP=0|RACE=HOLY
}
public class TRL_308:MinionBase{
//NAME=高阶祭司塞卡尔
//TEXT=<b>战吼：</b>保留英雄的1点生命值，将其余部分转化为护甲值。
//MAJ=PALADIN|COST=3|ATK=3|HP=4|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        if(owner.myPlayer.hero.Count>0)
        {
            int Amount = owner.myPlayer.hero[0].GetTag(GameTag.Health)-1;
            owner.myPlayer.hero[0].SetTag(GameTag.Damage,Amount);
            TaskBuffMyHero(arm:Amount);            
        }
    }
}
public class TRL_309:MinionBase{
//NAME=猛虎之灵
//TEXT=<b>潜行</b>一回合。在你施放一个法术后，召唤一只属性值 等于其法力值消耗的老虎。
//MAJ=PALADIN|COST=4|ATK=0|HP=3|RACE=UNDEAD
}
public class TRL_309t:MinionBase{
//NAME=老虎
//TEXT=
//MAJ=PALADIN|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TRL_310:SpellBase{
//NAME=元素唤醒
//TEXT=在本回合中，你使用的下一张元素牌的法力值消耗减少（2）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=FIRE
}
public class TRL_310e:Ability{
//NAME=元素唤醒
//TEXT=在本回合中你的下一张元素牌的法力值消耗减少（2）点。
//MAJ=MAGE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_311:MinionBase{
//NAME=奥术暴龙
//TEXT=<b>战吼：</b>如果你在上个回合使用过元素牌，则对所有其他随从造成3点伤害。
//MAJ=MAGE|COST=6|ATK=3|HP=3|RACE=ELEMENTAL
}
public class TRL_312:MinionBase{
//NAME=狂暴咒术师
//TEXT=受伤时拥有 <b>法术伤害+2</b>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=3|RACE=NONE
}
public class TRL_312e:Ability{
//NAME=古拉巴什之力
//TEXT=<b>法术伤害+2</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_313:SpellBase{
//NAME=灼烧
//TEXT=对一个随从造成$4点伤害。如果你在上个回合使用过元素牌，则法力值消耗变为（1）点。
//MAJ=MAGE|COST=4|ATK=0|HP=0|RACE=FIRE
}
public class TRL_315:MinionBase{
//NAME=火焰狂人
//TEXT=每当你的英雄技能消灭一个随从，抽 一张牌。
//MAJ=MAGE|COST=3|ATK=3|HP=4|RACE=NONE
}
public class TRL_316:MinionBase{
//NAME=加亚莱，龙鹰之神
//TEXT=<b>战吼：</b> 在本局对战中，如果你的英雄技能累计造成了8点伤害，则召唤炎魔之王拉格纳罗斯。@<i>（还剩{0}点！）</i>@<i>（已经就绪！）</i>
//MAJ=MAGE|COST=7|ATK=4|HP=4|RACE=BEAST
}
public class TRL_316t:MinionBase{
//NAME=炎魔之王拉格纳罗斯
//TEXT=无法攻击。在你的回合结束时，随机对一个敌人造成8点伤害。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=ELEMENTAL
    public override void Init()
    {
        owner.SetTag(GameTag.AttacksForOneTurn,0);
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,CauseEvent));
    }
    public void CauseEvent()
    {
        TaskDamageRandomEnemy(8);
    }
}
public class TRL_317:SpellBase{
//NAME=冲击波
//TEXT=对所有随从造成$2点伤害。<b>超杀</b>：随机将一张法师法术牌置入你的手牌。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=FIRE
}
public class TRL_318:MinionBase{
//NAME=妖术领主玛拉卡斯
//TEXT=<b>战吼：</b>将你的起始手牌的复制置入手牌<i>（不包括这张牌）</i>。
//MAJ=MAGE|COST=8|ATK=5|HP=5|RACE=NONE
}
public class TRL_319:MinionBase{
//NAME=龙鹰之灵
//TEXT=<b>潜行</b>一回合。你的英雄技能会以选中的随从及其相邻随从作为 目标。
//MAJ=MAGE|COST=2|ATK=0|HP=3|RACE=UNDEAD
}
public class TRL_319e:Ability{
//NAME=龙鹰之力
//TEXT=你的英雄技能会以选中的随从及其相邻随从作为目标。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_321:SpellBase{
//NAME=毁灭打击
//TEXT=对一个受伤的随从造成$4点 伤害。
//MAJ=WARRIOR|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TRL_323:MinionBase{
//NAME=烬鳞幼龙
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便获得5点护甲值。
//MAJ=WARRIOR|COST=5|ATK=5|HP=5|RACE=DRAGON
}
public class TRL_324:SpellBase{
//NAME=重金属狂潮
//TEXT=随机召唤一个法力值消耗等同于你的护甲值<i>（最高不超过10点）</i>的随从。
//MAJ=WARRIOR|COST=6|ATK=0|HP=0|RACE=NONE
}
public class TRL_325:WeaponBase{
//NAME=鞭笞者苏萨斯
//TEXT=<b>超杀</b>：你可以再次攻击。
//MAJ=WARRIOR|COST=6|ATK=4|HP=4|RACE=NONE
}
public class TRL_326:MinionBase{
//NAME=燃棘枪兵
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，则消灭一个受伤的敌方随从。
//MAJ=WARRIOR|COST=3|ATK=3|HP=2|RACE=NONE
}
public class TRL_327:MinionBase{
//NAME=犀牛之灵
//TEXT=<b>潜行</b>一回合。你的具有<b>突袭</b>的随从在它被召唤的回合<b>免疫</b>。
//MAJ=WARRIOR|COST=1|ATK=0|HP=3|RACE=UNDEAD
}
public class TRL_327e:Ability{
//NAME=犀牛之灵庇护
//TEXT=在本回合中<b>免疫</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_328:MinionBase{
//NAME=指挥官沃恩
//TEXT=<b>战吼：</b>复制你手牌中的所有龙牌。
//MAJ=WARRIOR|COST=4|ATK=4|HP=3|RACE=NONE
}
public class TRL_329:MinionBase{
//NAME=阿卡里，犀牛之神
//TEXT=<b>突袭，超杀：</b>从你的牌库中抽一张具有<b>突袭</b>的随从牌，并使其获得+5/+5。
//MAJ=WARRIOR|COST=8|ATK=5|HP=5|RACE=BEAST
}
public class TRL_329e:Ability{
//NAME=犀牛厚皮
//TEXT=+5/+5。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_339:SpellBase{
//NAME=主人的召唤
//TEXT=从你的牌库中<b>发现</b>一张随从牌。如果三张牌都是野兽，则抽取全部三张牌。
//MAJ=HUNTER|COST=3|ATK=0|HP=0|RACE=NONE
    public override void Battlecry(Card target=null)
    {
        List<Card> Pool = new List<Card>();
        foreach(Card c in owner.myPlayer.deck)
        {
            if(c.cardType==CardType.Minion)
            {
                Pool.Add(c);
            }
        }
        List<Card> ToListDiscover = new List<Card>();
        bool AllBeast=true;
        while(true)
        {
            if(ToListDiscover.Count>=3 || Pool.Count==0)
            {
                break;
            }
            Card ToAdd = Pool.Choice(owner.myPlayer.randomGen);

            if(ToAdd!=null)
            {
                Pool.Remove(ToAdd);
                ToListDiscover.Add(ToAdd);                
                if(!ToAdd.raceType.Contains(RaceType.Beast))
                {
                    AllBeast=false;
                }
            }
        }
        if(AllBeast)
        {
            foreach(Card c in ToListDiscover)
            {
                TaskDraw(c);
            }
        }
        else{
            TaskDraw(ToListDiscover.Choice(owner.myPlayer.randomGen));
        }
    }
}
public class TRL_341:MinionBase{
//NAME=树语者
//TEXT=<b>战吼：</b> 将你的所有树人变形成为5/5的古树。
//MAJ=DRUID|COST=5|ATK=4|HP=4|RACE=NONE
}
public class TRL_341t:MinionBase{
//NAME=古树
//TEXT=
//MAJ=DRUID|COST=5|ATK=5|HP=5|RACE=NONE
}
public class TRL_343:MinionBase{
//NAME=战争德鲁伊罗缇
//TEXT=<b>抉择：</b>变形成为罗缇的四种恐龙形态之一。
//MAJ=DRUID|COST=3|ATK=1|HP=2|RACE=NONE
}
public class TRL_343at1:MinionBase{
//NAME=甲龙
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=3|ATK=1|HP=6|RACE=BEAST
}
public class TRL_343at2:MinionBase{
//NAME=战争德鲁伊罗缇
//TEXT=<b>嘲讽</b>
//MAJ=DRUID|COST=3|ATK=1|HP=6|RACE=BEAST
}
public class TRL_343bt1:MinionBase{
//NAME=剜齿虎
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class TRL_343bt2:MinionBase{
//NAME=战争德鲁伊罗缇
//TEXT=<b>突袭</b>
//MAJ=DRUID|COST=3|ATK=4|HP=2|RACE=BEAST
}
public class TRL_343ct1:MinionBase{
//NAME=翼手龙
//TEXT=<b>法术伤害+1</b>
//MAJ=DRUID|COST=3|ATK=1|HP=4|RACE=BEAST
}
public class TRL_343ct2:MinionBase{
//NAME=战争德鲁伊罗缇
//TEXT=<b>法术伤害+1</b>
//MAJ=DRUID|COST=3|ATK=1|HP=4|RACE=BEAST
}
public class TRL_343dt1:MinionBase{
//NAME=暴掠龙
//TEXT=<b>剧毒</b> <b>潜行</b>
//MAJ=DRUID|COST=3|ATK=1|HP=2|RACE=BEAST
}
public class TRL_343dt2:MinionBase{
//NAME=战争德鲁伊罗缇
//TEXT=<b>剧毒</b> <b>潜行</b>
//MAJ=DRUID|COST=3|ATK=1|HP=2|RACE=BEAST
}
public class TRL_343et1:MinionBase{
//NAME=战争德鲁伊罗缇
//TEXT=<b>嘲讽，突袭，剧毒，潜行，法术伤害+1</b>
//MAJ=DRUID|COST=3|ATK=4|HP=6|RACE=BEAST
}
public class TRL_345:MinionBase{
//NAME=卡格瓦，青蛙之神
//TEXT=<b>战吼：</b>将你上回合使用的所有法术牌移回你的手牌。
//MAJ=SHAMAN|COST=6|ATK=4|HP=6|RACE=BEAST
}
public class TRL_347:SpellBase{
//NAME=诱饵射击
//TEXT=造成$3点伤害。<b>超杀：</b>召唤一个5/5的魔暴龙。
//MAJ=HUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class TRL_347t:MinionBase{
//NAME=魔暴龙
//TEXT=
//MAJ=HUNTER|COST=5|ATK=5|HP=5|RACE=BEAST
}
public class TRL_348:MinionBase{
//NAME=魔泉山猫
//TEXT=<b>突袭，战吼：</b>将一张1/1并具有<b>突袭</b>的山猫置入你的手牌。
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TRL_348t:MinionBase{
//NAME=山猫
//TEXT=<b>突袭</b>
//MAJ=HUNTER|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TRL_349:MinionBase{
//NAME=血顶战略家
//TEXT=<b>战吼：</b>如果你装备着武器，<b>发现</b>一张 法术牌。
//MAJ=HUNTER|COST=3|ATK=2|HP=4|RACE=NONE
}
public class TRL_351:SpellBase{
//NAME=蟾蜍雨
//TEXT=召唤三个2/4并具有<b>嘲讽</b>的蟾蜍。 <b>过载：</b>（3）
//MAJ=SHAMAN|COST=6|ATK=0|HP=0|RACE=NONE
}
public class TRL_351t:MinionBase{
//NAME=蟾蜍
//TEXT=<b>嘲讽</b>
//MAJ=SHAMAN|COST=3|ATK=2|HP=4|RACE=BEAST
}
public class TRL_352:WeaponBase{
//NAME=舔舔魔杖
//TEXT=当你有<b>过载</b>的法力水晶时，拥有+2攻击力。
//MAJ=SHAMAN|COST=2|ATK=1|HP=3|RACE=NONE
}
public class TRL_360:WeaponBase{
//NAME=领主之鞭
//TEXT=在你使用一张随从牌后，对其造成1点伤害。
//MAJ=WARRIOR|COST=3|ATK=2|HP=4|RACE=NONE
}
public class TRL_362:SpellBase{
//NAME=巨龙怒吼
//TEXT=随机将两张龙牌置入你的手牌。
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TRL_363:MinionBase{
//NAME=萨隆铁矿监工
//TEXT=<b>亡语：</b>为你的对手召唤一个0/3并具有<b>嘲讽</b>的自由的矿工。
//MAJ=NEUTRAL|COST=1|ATK=2|HP=3|RACE=NONE
}
public class TRL_363t:MinionBase{
//NAME=自由的矿工
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=3|RACE=NONE
}
public class TRL_390:MinionBase{
//NAME=大胆的吞火者
//TEXT=<b>战吼：</b>在本回合中，你的下一个英雄技能会额外造成2点伤害。
//MAJ=MAGE|COST=1|ATK=1|HP=1|RACE=NONE
}
public class TRL_390e:Ability{
//NAME=烈火如织
//TEXT=你的下一个英雄技能会额外造成2点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_390e2:Ability{
//NAME=烈火如织
//TEXT=你的下一个英雄技能会额外造成2点伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_400:SecretBase{
//NAME=裂魂残像
//TEXT=<b>奥秘：</b>当你的随从受到攻击时，召唤一个该随从的复制。
//MAJ=MAGE|COST=3|ATK=0|HP=0|RACE=ARCANE
}
public class TRL_405:MinionBase{
//NAME=狂野兽王
//TEXT=每当你抽到一张野兽牌时，使其获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class TRL_405e:Ability{
//NAME=战争印记
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_406:MinionBase{
//NAME=嗜睡的神枪手
//TEXT=受伤时拥有 +4攻击力。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=4|RACE=NONE
}
public class TRL_406e:Ability{
//NAME=起床气
//TEXT=+4攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_407:MinionBase{
//NAME=茶水小弟
//TEXT=<b>战吼：</b> 在本回合中，你的下一个英雄技能的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class TRL_407e:Ability{
//NAME=优质活水
//TEXT=你的英雄技能的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_408:MinionBase{
//NAME=墓园恐魔
//TEXT=<b>嘲讽</b> 在本局对战中，你每施放一个法术，本牌的法力值消耗便减少（1）点。
//MAJ=PRIEST|COST=12|ATK=7|HP=8|RACE=UNDEAD
}
public class TRL_409:MinionBase{
//NAME=格罗尔，鲨鱼之神
//TEXT=<b>战吼：</b>吞食一个你的牌库中的随从，并获得其属性值。<b>亡语：</b>将被吞食的随从置入手牌。
//MAJ=ROGUE|COST=5|ATK=2|HP=2|RACE=BEAST
    private Card Eaten = null;
    public override void Battlecry(Card target=null)
    {
        List<Card> ToListEat = new List<Card>();
        foreach(Card c in owner.myPlayer.otherPlayer.deck)
        {
            if(c.cardType==CardType.Minion)
            {
                ToListEat.Add(c);
            }
        }
        this.Eaten = ToListEat.Choice(owner.myPlayer.randomGen);
        if(this.Eaten!=null)
        {
            new EffectMove(owner.myPlayer,this.Eaten,(ZoneType)this.Eaten.GetTag(GameTag.ZoneType),ZoneType.Removed).Resolve();
            new EffectChange(owner.myPlayer,owner,owner,atkChange:this.Eaten.GetTag(GameTag.Attack),hpChange:this.Eaten.GetTag(GameTag.Health)).Resolve();
        }
    }
    public override void Deathrattle()
    {
        if(this.Eaten!=null)
        {
            new EffectMove(owner.myPlayer,this.Eaten,(ZoneType)this.Eaten.GetTag(GameTag.ZoneType),ZoneType.Board).Resolve();
        }
    }
}
public class TRL_409e:Ability{
//NAME=血染大海
//TEXT=吞食了{0}并获得其属性值。
//MAJ=ROGUE|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_500:SpellBase{
//NAME=疯入膏肓
//TEXT=摧毁你的三个法力水晶。使你牌库中的所有随从牌获得+2/+2。
//MAJ=PRIEST|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class TRL_500e:Ability{
//NAME=彻底疯狂！
//TEXT=+2/+2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_501:MinionBase{
//NAME=奥金尼幻象
//TEXT=<b>战吼：</b>在本回合中，你的治疗效果转而造成等量的伤害。
//MAJ=PRIEST|COST=2|ATK=3|HP=2|RACE=UNDEAD
}
public class TRL_501e:Ability{
//NAME=黑暗灵魂
//TEXT=你的治疗效果会造成伤害。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_502:MinionBase{
//NAME=亡者之灵
//TEXT=<b>潜行</b>一回合。在一个友方随从死亡后，将它的一张复制洗入你的牌库，其法力值消耗为（1）。
//MAJ=PRIEST|COST=1|ATK=0|HP=3|RACE=UNDEAD
}
public class TRL_502e:Ability{
//NAME=邦桑迪的信徒
//TEXT=邦桑迪将其法力值消耗变为（1）点。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_503:MinionBase{
//NAME=甲虫卵
//TEXT=<b>亡语：</b>召唤三只1/1的甲虫。
//MAJ=NEUTRAL|COST=2|ATK=0|HP=2|RACE=NONE
}
public class TRL_503t:MinionBase{
//NAME=甲虫
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TRL_504:MinionBase{
//NAME=藏宝海湾荷官
//TEXT=<b>战吼：</b>使你的对手获得一张幸运币。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=3|RACE=NONE
}
public class TRL_505:MinionBase{
//NAME=无助的幼雏
//TEXT=<b>亡语：</b>使你手牌中的一张野兽牌法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TRL_505e:Ability{
//NAME=复仇者
//TEXT=法力值消耗减少（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_506:MinionBase{
//NAME=古拉巴什小鸡
//TEXT=<b>超杀：</b> 获得+5攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=BEAST
}
public class TRL_506e:Ability{
//NAME=准备出击
//TEXT=+5攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_507:MinionBase{
//NAME=鲨鳍后援
//TEXT=在你的英雄攻击后，召唤一个1/1的海盗。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=PIRATE
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,CauseEvent));
    }

    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc.GetTag(GameTag.ZoneType) == (int)ZoneType.Hero && CondInPlay())
        {
            TaskCreate(CardDbf.GetCardDbfByGuid("TRL_507t"),ZoneType.Board);
        }
    }
}
public class TRL_507t:MinionBase{
//NAME=海盗杂兵
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=PIRATE
}
public class TRL_508:MinionBase{
//NAME=再生暴徒
//TEXT=在你的回合开始时，为本随从恢复 #2点生命值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class TRL_509:MinionBase{
//NAME=香蕉小丑
//TEXT=<b>战吼：</b>将两根香蕉 置入你的手牌。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NONE
}
public class TRL_509t:SpellBase{
//NAME=香蕉
//TEXT=使一个随从获得+1/+1。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=NONE
}
public class TRL_509te:Ability{
//NAME=香蕉
//TEXT=拥有+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_512:MinionBase{
//NAME=调皮的噬踝者
//TEXT=<b>吸血</b> <b>战吼：</b>造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class TRL_513:MinionBase{
//NAME=莫什奥格执行者
//TEXT=<b>嘲讽</b> <b>圣盾</b>
//MAJ=NEUTRAL|COST=8|ATK=2|HP=14|RACE=NONE
}
public class TRL_514:MinionBase{
//NAME=好斗的侏儒
//TEXT=<b>嘲讽</b> <b>战吼：</b>如果你的对手拥有2个或者更多随从，便获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=NONE
}
public class TRL_514e:Ability{
//NAME=侏儒战意
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_515:MinionBase{
//NAME=场馆保镖
//TEXT=<b>嘲讽</b> 每有一个敌方随从，本牌的法力值消耗便减少（1）点。
//MAJ=NEUTRAL|COST=7|ATK=2|HP=7|RACE=NONE
}
public class TRL_516:MinionBase{
//NAME=古拉巴什供品
//TEXT=在你的回合开始时，消灭本随从，并获得 8点护甲值。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=2|RACE=NONE
}
public class TRL_517:MinionBase{
//NAME=赛场狂热者
//TEXT=<b>战吼：</b>使你手牌中的所有随从牌获得+1/+1。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=3|RACE=NONE
}
public class TRL_517e2:Ability{
//NAME=哇哦！
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_520:MinionBase{
//NAME=鱼人大厨
//TEXT=<b>亡语：</b>从你的牌库中抽两张鱼人牌。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=MURLOC
}
public class TRL_521:MinionBase{
//NAME=竞技场奴隶主
//TEXT=<b>超杀：</b>召唤另一个竞技场奴隶主。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=NONE
}
public class TRL_522:MinionBase{
//NAME=疾疫使者
//TEXT=<b>战吼：</b>如果你在本回合施放了两个法术，则造成2点伤害。
//MAJ=SHAMAN|COST=1|ATK=2|HP=1|RACE=NONE
}
public class TRL_523:MinionBase{
//NAME=火树巫医
//TEXT=<b>战吼：</b>如果你的手牌中有龙牌，便<b>发现</b> 一张法术牌。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NONE
}
public class TRL_524:MinionBase{
//NAME=破盾者
//TEXT=<b>战吼：</b><b>沉默</b>一个具有<b>嘲讽</b>的敌方随从。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=NONE
}
public class TRL_525:MinionBase{
//NAME=竞技场财宝箱
//TEXT=<b>亡语：</b>抽两张牌。
//MAJ=NEUTRAL|COST=4|ATK=0|HP=4|RACE=NONE
}
public class TRL_526:MinionBase{
//NAME=龙喉喷火者
//TEXT=<b>战吼：</b>对所有其他随从造成1点伤害。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=DRAGON
}
public class TRL_527:MinionBase{
//NAME=达卡莱幻术师
//TEXT=<b>战吼：</b>使每个玩家各随机获得一张对方牌库中的卡牌的复制。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=NONE
}
public class TRL_528:MinionBase{
//NAME=阵线破坏者
//TEXT=<b>超杀：</b>本随从的攻击力翻倍。
//MAJ=NEUTRAL|COST=7|ATK=5|HP=10|RACE=UNDEAD
}
public class TRL_528e:Ability{
//NAME=癫狂
//TEXT=攻击力翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_530:MinionBase{
//NAME=蒙面选手
//TEXT=<b>战吼：</b> 如果你控制一个<b>奥秘</b>，则从你的牌库中施放一个<b>奥秘</b>。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=4|RACE=NONE
}
public class TRL_531:MinionBase{
//NAME=暴牙震颤者
//TEXT=<b>亡语：</b>召唤一个3/2的暴牙破坏者。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=NONE
}
public class TRL_531t:MinionBase{
//NAME=暴牙破坏者
//TEXT=
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=NONE
}
public class TRL_532:MinionBase{
//NAME=莫什奥格播报员
//TEXT=攻击本随从的敌人有50%几率攻击其他角色。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=5|RACE=NONE
}
public class TRL_533:MinionBase{
//NAME=冰淇淋小贩
//TEXT=<b>战吼：</b>如果你控制一个被<b>冻结</b>的随从，便获得8点护甲值。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=5|RACE=NONE
}
public class TRL_535:MinionBase{
//NAME=钳嘴龟盾卫
//TEXT=每当相邻的随从受到伤害，改为由本随从承担。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=8|RACE=NONE
}
public class TRL_537:MinionBase{
//NAME=送葬者安德提卡
//TEXT=<b>战吼：</b>获得在本局对战中三个死亡的友方随从的<b>亡语</b>。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=5|RACE=UNDEAD
}
public class TRL_537e:Ability{
//NAME=殉葬亡语
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_541:MinionBase{
//NAME=夺灵者哈卡
//TEXT=<b>亡语：</b>将一张“堕落之血”分别洗入每个玩家的牌库。
//MAJ=NEUTRAL|COST=10|ATK=9|HP=6|RACE=NONE
}
public class TRL_541t:SpellBase{
//NAME=堕落之血
//TEXT=<b>抽到时施放</b> 受到3点伤害。在你抽牌后，将此牌的两张复制洗入你的牌库。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class TRL_542:MinionBase{
//NAME=乌达斯塔
//TEXT=<b>突袭</b> <b>超杀：</b>从你的手牌中召唤一个野兽。
//MAJ=NEUTRAL|COST=9|ATK=7|HP=7|RACE=BEAST
}
public class TRL_543:WeaponBase{
//NAME=血爪
//TEXT=<b>战吼：</b>对你的英雄造成5点伤害。
//MAJ=PALADIN|COST=1|ATK=2|HP=2|RACE=NONE
}
public class TRL_545:MinionBase{
//NAME=赞达拉武士
//TEXT=<b>战吼：</b>在本局对战中，如果你累计恢复了10点生命值，则获得+4/+4和<b>嘲讽</b>。@<i>（还剩{0}点！）</i>@<i>（已经就绪！）</i>
//MAJ=PALADIN|COST=4|ATK=4|HP=4|RACE=NONE
}
public class TRL_545e:Ability{
//NAME=精神焕发
//TEXT=+4/+4并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class TRL_546:MinionBase{
//NAME=暴躁的巨龟
//TEXT=<b>战吼：</b>对你的英雄造成5点伤害。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=5|RACE=BEAST
}
public class TRL_550:MinionBase{
//NAME=阿曼尼战熊
//TEXT=<b>突袭</b> <b>嘲讽</b>
//MAJ=NEUTRAL|COST=7|ATK=5|HP=7|RACE=BEAST
}
public class TRL_551:MinionBase{
//NAME=粗暴的恐怖巨魔
//TEXT=<b>嘲讽，战吼：</b>弃掉你手牌中法力值消耗最低的牌。
//MAJ=WARLOCK|COST=3|ATK=2|HP=6|RACE=NONE
}
public class TRL_555:SpellBase{
//NAME=恶魔之箭
//TEXT=消灭一个随从。你每控制一个随从，本牌的法力值消耗便减少（1）点。
//MAJ=WARLOCK|COST=8|ATK=0|HP=0|RACE=SHADOW
}
public class TRL_564:MinionBase{
//NAME=魔精大师兹伊希
//TEXT=<b>战吼：</b> 将每个玩家的法力水晶重置为五个。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=NONE
}
public class TRL_566:SpellBase{
//NAME=荒野的复仇
//TEXT=召唤在 本回合中死亡的友方野兽。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class TRL_569:MinionBase{
//NAME=看台喷火龙
//TEXT=<b>战吼：</b> 如果你的手牌中有龙牌，则对一个敌方随从造成7点伤害。
//MAJ=NEUTRAL|COST=7|ATK=7|HP=4|RACE=DRAGON
}
public class TRL_570:MinionBase{
//NAME=汤水商贩
//TEXT=每当你为你的英雄恢复3点及以上生命值时，抽一张牌。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=4|RACE=NONE
}
public class TRL_900:MinionBase{
//NAME=哈尔拉兹，山猫之神
//TEXT=<b>战吼：</b>用1/1并具有 <b>突袭</b>的山猫填满你的手牌。
//MAJ=HUNTER|COST=5|ATK=3|HP=2|RACE=BEAST
}
public class TRL_901:MinionBase{
//NAME=山猫之灵
//TEXT=<b>潜行</b>一回合。每当你召唤一个野兽时，使其获得+1/+1。
//MAJ=HUNTER|COST=3|ATK=0|HP=3|RACE=UNDEAD
}
public class TRL_901e:Ability{
//NAME=哈尔拉兹的祝福
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
