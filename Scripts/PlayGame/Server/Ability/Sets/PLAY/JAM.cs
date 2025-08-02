using System.Collections;
using System.Collections.Generic;

public class JAM_000:MinionBase{
//NAME=混搭派送机
//TEXT=在你的手牌中时会获得一项额外效果，该效果每回合都会改变。
//MAJ=MAGE|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class JAM_000t:MinionBase{
//NAME=冰爽派送机
//TEXT=<b>战吼：</b>随机获取两张冰霜法术牌。<i>（每回合都会改变。）</i>
//MAJ=MAGE|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class JAM_000t2:MinionBase{
//NAME=周边派送机
//TEXT=<b>战吼：</b>随机获取两张机械牌。<i>（每回合都会改变。）</i>
//MAJ=MAGE|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class JAM_000t3:MinionBase{
//NAME=现金派送机
//TEXT=<b>战吼：</b> 获取两张幸运币。 <i>（每回合都会 改变。）</i>
//MAJ=MAGE|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class JAM_000t4:MinionBase{
//NAME=神秘派送机
//TEXT=<b>战吼：</b>随机获取两张法师<b>奥秘</b>牌。<i>（每回合都会改变。）</i>
//MAJ=MAGE|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class JAM_001:MinionBase{
//NAME=盛装歌手
//TEXT=在你的回合结束时，抽一张<b>奥秘</b>牌。
//MAJ=MAGE|COST=1|ATK=1|HP=1|RACE=NONE
}
public class JAM_002:SpellBase{
//NAME=星辰能量
//TEXT=随机对一个敌方随从造成$5点伤害。重复此效果，每次伤害减少1点。
//MAJ=MAGE|COST=5|ATK=0|HP=0|RACE=ARCANE
}
public class JAM_003:SecretBase{
//NAME=暗藏深意
//TEXT=<b>奥秘：</b>当你的对手在没有法力值的情况下结束其回合时，随机召唤一个法力值消耗为（3）的随从。
//MAJ=HUNTER|COST=2|ATK=0|HP=0|RACE=NONE
}
public class JAM_004:MinionBase{
//NAME=镂骨恶犬
//TEXT=<b>吸血</b>，<b>突袭</b>。同时对其攻击目标相邻的随从造成伤害。
//MAJ=HUNTER|COST=6|ATK=3|HP=4|RACE=UNDEAD
}
public class JAM_005:MinionBase{
//NAME=约德尔狂吼歌手
//TEXT=<b>战吼：</b> 触发一个友方随从的 <b>亡语</b>，触发两次。
//MAJ=DEATHKNIGHT|COST=4|ATK=3|HP=4|RACE=UNDEAD
}
public class JAM_006:SpellBase{
//NAME=冻感舞步
//TEXT=下个回合，敌方随从牌的法力值消耗增加（5）点。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=FROST
}
public class JAM_006e:Ability{
//NAME=冻感舞步
//TEXT=在本回合中，你的随从牌的法力值消耗增加（5）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_006e2:Ability{
//NAME=冻感舞步
//TEXT=法力值消耗增加（5）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_007:MinionBase{
//NAME=酷炫的食尸鬼
//TEXT=<b>圣盾</b>，<b>复生</b>
//MAJ=DEATHKNIGHT|COST=4|ATK=3|HP=1|RACE=UNDEAD
}
public class JAM_008:SpellBase{
//NAME=直播事故
//TEXT=消灭你的亡灵。再次召唤它们。
//MAJ=DEATHKNIGHT|COST=2|ATK=0|HP=0|RACE=NONE
}
public class JAM_009:LocationBase{
//NAME=闪亮舞池
//TEXT=使你的所有随从获得<b>突袭</b>。
//MAJ=PALADIN|COST=2|ATK=0|HP=2|RACE=NONE
}
public class JAM_009e:Ability{
//NAME=后摇步
//TEXT=<b>突袭</b>
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_010:MinionBase{
//NAME=点唱机图腾
//TEXT=在你的回合结束时，召唤一个1/1的白银之手新兵。
//MAJ=PALADIN|COST=2|ATK=0|HP=4|RACE=TOTEM
}
public class JAM_011:WeaponBase{
//NAME=风领主的管号
//TEXT=<b>风怒</b>。每当你的英雄攻击随从时，将被攻击随从的属性值变为3/3。
//MAJ=SHAMAN|COST=6|ATK=3|HP=4|RACE=NONE
}
public class JAM_011e:Ability{
//NAME=爵士之风
//TEXT=3/3。
//MAJ=SHAMAN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_012:MinionBase{
//NAME=混搭图腾师
//TEXT=在你的手牌中时会获得一项额外效果，该效果每回合都会改变。
//MAJ=SHAMAN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class JAM_012t:MinionBase{
//NAME=扬声图腾师
//TEXT=<b>战吼：</b>召唤一个0/3的立体声图腾。<i>（每回合都会改变。）</i>
//MAJ=SHAMAN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class JAM_012t2:MinionBase{
//NAME=蓝调图腾师
//TEXT=<b>战吼：</b>召唤一个0/3的法力之潮图腾。<i>（每回合都会改变。）</i>
//MAJ=SHAMAN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class JAM_012t3:MinionBase{
//NAME=火热图腾师
//TEXT=<b>战吼：</b>召唤一个0/3的火舌图腾。<i>（每回合都会改变。）</i>
//MAJ=SHAMAN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class JAM_012t4:MinionBase{
//NAME=唱K图腾师
//TEXT=<b>战吼：</b>召唤一个0/4的点唱机图腾。<i>（每回合都会改变。）</i>
//MAJ=SHAMAN|COST=3|ATK=3|HP=2|RACE=NONE
}
public class JAM_013:SpellBase{
//NAME=即兴演奏
//TEXT=使一个友方随从获得+3/+3。对所有其他随从造成$1点伤害。<b>过载：</b>（1）
//MAJ=WARRIOR|COST=2|ATK=0|HP=0|RACE=FIRE
}
public class JAM_013e:Ability{
//NAME=激扬即兴
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_014:MinionBase{
//NAME=后台保镖
//TEXT=<b>嘲讽</b>。<b>战吼：</b>将一个友方随从变形成为本随从的复制。
//MAJ=WARRIOR|COST=4|ATK=4|HP=5|RACE=BEAST
}
public class JAM_015:WeaponBase{
//NAME=混搭音叉
//TEXT=在你的手牌中时会获得一项额外效果，该效果每回合都会改变。
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=NONE
}
public class JAM_015e:Ability{
//NAME=尖利
//TEXT=+2攻击力。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_015t:WeaponBase{
//NAME=尖利音叉
//TEXT=<b>战吼：</b>获得+2攻击力。<i>（每回合都会改变。）</i>
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=NONE
}
public class JAM_015t2:WeaponBase{
//NAME=加固音叉
//TEXT=<b>战吼：</b>获得5点护甲值。<i>（每回合都会改变。）</i>
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=NONE
}
public class JAM_015t3:WeaponBase{
//NAME=弧形音叉
//TEXT=同时对你的英雄攻击目标相邻的随从造成伤害。<i>（每回合都会改变。）</i>0同时对你的英雄攻击目标相邻的随从造成伤害。
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=NONE
}
public class JAM_015t4:WeaponBase{
//NAME=备用音叉
//TEXT=<b>战吼：</b><b>发现</b>一张<b>嘲讽</b>随从牌。<i>（每回合都会改变。）</i> 0<b>战吼：</b><b>发现</b>一张<b>嘲讽</b>随从牌。
//MAJ=WARRIOR|COST=2|ATK=2|HP=2|RACE=NONE
}
public class JAM_016:MinionBase{
//NAME=渊狱贝斯手
//TEXT=<b>嘲讽</b>，<b>吸血</b>。在本局对战中你每装备过一把武器，本牌的法力值消耗便减少（2）点。
//MAJ=DEMONHUNTER|COST=7|ATK=4|HP=7|RACE=DEMON
}
public class JAM_017:SpellBase{
//NAME=突破邪火
//TEXT=使一个随从获得<b>突袭</b>。<b>压轴：</b>以及+1/+1。
//MAJ=WARRIOR|COST=0|ATK=0|HP=0|RACE=FEL
}
public class JAM_017e:Ability{
//NAME=战刃吉他英雄
//TEXT=+1/+1。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_018:SpellBase{
//NAME=混搭狂想曲
//TEXT=对所有随从造成$3点伤害。在你的手牌中时会获得一项额外效果，该效果每回合都会改变。
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class JAM_018t:SpellBase{
//NAME=盛怒狂想曲
//TEXT=对所有随从造成$3点伤害。抽三张牌。<i>（每回合都会改变。）</i>
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class JAM_018t2:SpellBase{
//NAME=高亢狂想曲
//TEXT=对所有随从造成$3点伤害，造成两次。<i>（每回合都会改变。）</i>
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),3);
		TaskDamageTargets(owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board),3);
	}
}
public class JAM_018t3:SpellBase{
//NAME=动情狂想曲
//TEXT=对所有随从造成$3点伤害。在本回合中，使你的英雄获得+5攻击力。<i>（每回合都会改变。）</i>
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class JAM_018t3e:Ability{
//NAME=动情狂想曲
//TEXT=在本回合中获得+5攻击力。
//MAJ=DEMONHUNTER|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_018t4:SpellBase{
//NAME=哀嚎狂想曲
//TEXT=对所有随从造成$3点伤害。召唤一个5/5的恶魔。<i>（每回合都会改变。）</i>
//MAJ=DEMONHUNTER|COST=5|ATK=0|HP=0|RACE=NONE
}
public class JAM_018t5:MinionBase{
//NAME=哀嚎狂热者
//TEXT=
//MAJ=DEMONHUNTER|COST=5|ATK=5|HP=5|RACE=DEMON
}
public class JAM_019:MinionBase{
//NAME=踏韵舞者丽萨
//TEXT=<b>突袭</b>。在你的英雄攻击后，将本随从移回你的手牌并使其法力值消耗变为（1）点。
//MAJ=ROGUE|COST=4|ATK=3|HP=5|RACE=NONE
}
public class JAM_019e:Ability{
//NAME=踏韵起舞
//TEXT=法力值消耗为（1）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_020:MinionBase{
//NAME=挑剔的观众
//TEXT=<b>流放：</b>将一个随从移回其拥有者的手牌。
//MAJ=ROGUE|COST=3|ATK=2|HP=1|RACE=DEMON
}
public class JAM_021:MinionBase{
//NAME=单曲流星
//TEXT=<b>突袭</b>。<b>连击：</b> 获得<b><b>剧毒</b>。</b>
//MAJ=ROGUE|COST=2|ATK=2|HP=1|RACE=UNDEAD
}
public class JAM_022:SpellBase{
//NAME=致聋术
//TEXT=<b>沉默</b>一个随从。<b>连击：</b>并对其造成$2点伤害。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=SHADOW
}
public class JAM_023:MinionBase{
//NAME=盗版海盗
//TEXT=<b>战吼：</b>获取你对手牌库顶的一张 牌的复制。
//MAJ=PRIEST|COST=3|ATK=4|HP=3|RACE=PIRATE
}
public class JAM_024:MinionBase{
//NAME=布景光耀之子
//TEXT=<b>压轴，过量治疗：</b>随机使另一个友方随从获得+2/+2。
//MAJ=PRIEST|COST=4|ATK=3|HP=4|RACE=ELEMENTAL
}
public class JAM_024e:Ability{
//NAME=背景光
//TEXT=+2/+2。
//MAJ=PRIEST|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_025:SpellBase{
//NAME=漏斗蛋糕
//TEXT=为一个随从及其相邻随从恢复#3点生命值。每有一个随从受到<b>过量治疗</b>，便复原一个法力水晶。
//MAJ=PRIEST|COST=1|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		List<Card> ToListBuff = FindAdj(target);
		ToListBuff.Add(target);
		owner.myPlayer.ChangeTag(GameTag.ManaLeft,ToListBuff.Count);
		TaskBuffTargets(ToListBuff);

	}
}
public class JAM_026:MinionBase{
//NAME=人气树精
//TEXT=<b>抉择：</b>复原你的英雄技能；或者使你的下一个英雄技能的法力值消耗为（0）点。
//MAJ=DRUID|COST=2|ATK=2|HP=3|RACE=NONE
}
public class JAM_026a:SpellBase{
//NAME=抚慰弦律
//TEXT=复原你的英雄技能。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class JAM_026b:SpellBase{
//NAME=励志歌词
//TEXT=你的下一个英雄技能的法力值消耗为（0）点。
//MAJ=DRUID|COST=2|ATK=0|HP=0|RACE=NONE
}
public class JAM_026e:Ability{
//NAME=林地的指引
//TEXT=你的下一个英雄技能的法力值消耗为（0）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_027:MinionBase{
//NAME=饭圈迷弟
//TEXT=<b>抉择：</b>使一个友方随从获得+2攻击力和<b>突袭</b>；或者+2生命值和<b>吸血</b>。
//MAJ=PRIEST|COST=2|ATK=2|HP=2|RACE=NONE
}
public class JAM_027a:SpellBase{
//NAME=佐克无敌！
//TEXT=使一个友方随从获得+2攻击力和<b>突袭</b>。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class JAM_027ae:Ability{
//NAME=佐克的铁粉
//TEXT=+2攻击力和<b>突袭</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_027b:SpellBase{
//NAME=毒花少年！
//TEXT=使一个友方随从获得+2生命值和<b>吸血</b>。
//MAJ=PRIEST|COST=2|ATK=0|HP=0|RACE=NONE
}
public class JAM_027be:Ability{
//NAME=赫达尼斯的铁粉
//TEXT=+2生命值和<b>吸血</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_028:MinionBase{
//NAME=鲜血树人
//TEXT=消耗生命值，而非法力值。
//MAJ=DRUID|COST=5|ATK=2|HP=2|RACE=NONE
}
public class JAM_029:MinionBase{
//NAME=末日枭兽
//TEXT=<b>战吼：</b>夺取你对手的一个空的法力水晶。
//MAJ=DRUID|COST=6|ATK=3|HP=4|RACE=NONE
}
public class JAM_030:MinionBase{
//NAME=歌剧魔神范诺登
//TEXT=<b>嘲讽</b>，<b>吸血</b>。本牌的法力值消耗等同于你的牌库中卡牌的数量。
//MAJ=WARLOCK|COST=30|ATK=15|HP=15|RACE=NONE
}
public class JAM_031:SpellBase{
//NAME=回荡混响
//TEXT=召唤一个随从的复制。复制和本体都会在受到伤害后死亡。
//MAJ=WARLOCK|COST=3|ATK=0|HP=0|RACE=SHADOW
}
public class JAM_031e:Ability{
//NAME=回荡混响
//TEXT=受到伤害后死亡。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_032:MinionBase{
//NAME=燃琴小鬼
//TEXT=<b>战吼：</b>随机将法师和术士的各一张火焰法术牌置入你的手牌。
//MAJ=WARLOCK|COST=3|ATK=3|HP=3|RACE=DEMON
}
public class JAM_032e:Ability{
//NAME=Fiddlefire Achievement Enchant
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_033:MinionBase{
//NAME=混搭乐师
//TEXT=<b>突袭</b>。在你的手牌中时会获得一项额外效果，该效果每回合都会改变。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class JAM_033t:MinionBase{
//NAME=教堂乐师
//TEXT=<b>突袭</b>，<b>圣盾</b> <i>（每回合 都会改变。）</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class JAM_033t2:MinionBase{
//NAME=热带乐师
//TEXT=<b>突袭</b>，<b>风怒</b> <i>（每回合 都会改变。）</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class JAM_033t3:MinionBase{
//NAME=浪漫乐师
//TEXT=<b>突袭</b>，<b>吸血</b> <i>（每回合 都会改变。）</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class JAM_033t4:MinionBase{
//NAME=暴躁乐师
//TEXT=<b>突袭</b>，<b>剧毒</b> <i>（每回合 都会改变。）</i>
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=NONE
}
public class JAM_034:MinionBase{
//NAME=音箱践踏者
//TEXT=<b>可交易</b> <b>战吼：</b>下个回合敌方法术的法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=NONE
}
public class JAM_034e:Ability{
//NAME=太吵了
//TEXT=在本回合中，你的法术法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_034e2:Ability{
//NAME=吵闹噪音
//TEXT=法力值消耗增加（2）点。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class JAM_035:MinionBase{
//NAME=恐怖图腾扫兴怪
//TEXT=<b>战吼：</b>弃一张武器牌以抽三张牌。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=4|RACE=NONE
}
public class JAM_036:MinionBase{
//NAME=乐坛灾星玛加萨
//TEXT=<b>战吼：</b>抽五张牌。将抽到的法术牌交给你的对手。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class JAM_037:MinionBase{
//NAME=精英牛头人歌王
//TEXT=<b>压轴：</b>开启摇滚对决！玩家每回合必须消耗所有法力值，否则其英雄会受到8点<i>（或更高）</i>伤害！
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=NONE
}
public class JAM_037t:SpellBase{
//NAME=熔火拨片
//TEXT=在回合结束时爆炸，你的英雄受到8点伤害！<i>（或者消耗你的所有法力值，将本牌的伤害+2并交给你的对手。）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
