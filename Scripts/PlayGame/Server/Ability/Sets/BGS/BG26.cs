using System.Collections;
using System.Collections.Generic;

public class BG26_001:MinionBase{
//NAME=童话歌者
//TEXT=<b>战吼：</b>如果你输掉了上一场战斗，使你的其他随从获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=2|HP=3|RACE=NONE
}
public class BG26_001_G:MinionBase{
//NAME=童话歌者
//TEXT=<b>战吼：</b>如果你输掉了上一场战斗，使你的其他随从获得+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=4|HP=6|RACE=NONE
}
public class BG26_001_Ge:Ability{
//NAME=结尾复沓
//TEXT=+4/+4。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_001e:Ability{
//NAME=结尾复沓
//TEXT=+2/+2。
//MAJ=PALADIN|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_018:MinionBase{
//NAME=渣滓招募官
//TEXT=<b>亡语：</b>召唤3个 海盗无赖。
//MAJ=NEUTRAL|COST=5|ATK=9|HP=3|RACE=PIRATE
	public override void Deathrattle()
	{
		CardDbf ToSummon = CardDbf.GetCardDbfByGuid("BGS_061");
		TaskCreate(ToSummon,ZoneType.Board);
		TaskCreate(ToSummon,ZoneType.Board);
		TaskCreate(ToSummon,ZoneType.Board);
	}
}
public class BG26_018_G:MinionBase{
//NAME=渣滓招募官
//TEXT=<b>亡语：</b>召唤3个金色的海盗无赖。
//MAJ=NEUTRAL|COST=5|ATK=18|HP=6|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		CardDbf ToSummon = CardDbf.GetCardDbfByGuid("TB_BaconUps_141");
		TaskCreate(ToSummon,ZoneType.Board);
		TaskCreate(ToSummon,ZoneType.Board);
		TaskCreate(ToSummon,ZoneType.Board);
	}
}
public class BG26_045:MinionBase{
//NAME=螺号鼓吹手
//TEXT=<b>战吼：</b>随机获取一张等级2的酒馆法术牌。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=2|RACE=NAGA
}
public class BG26_045_G:MinionBase{
//NAME=螺号鼓吹手
//TEXT=<b>战吼：</b>随机获取两张等级2的酒馆法术牌。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=4|RACE=NAGA
}
public class BG26_055:MinionBase{
//NAME=再生梦魇
//TEXT=<b>亡语：</b>使一个不同的友方亡灵获得“<b>亡语：</b>召唤一个再生梦魇”。
//MAJ=NEUTRAL|COST=7|ATK=8|HP=5|RACE=UNDEAD
	public override void Deathrattle()
	{
		Card ToBuff = FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Undead).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"BG26_055e").Resolve();
		}
	}
}
public class BG26_055_G:MinionBase{
//NAME=再生梦魇
//TEXT=<b>亡语：</b>使一个不同的友方亡灵获得“<b>亡语：</b>召唤一个金色的再生梦魇”。
//MAJ=NEUTRAL|COST=7|ATK=16|HP=10|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		Card ToBuff = FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Undead).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"BG26_055e").Resolve();
		}
	}
}
public class BG26_055_Ge:Ability{
//NAME=梦魇入心
//TEXT=<b>亡语：</b>召唤一个金色的再生梦魇。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG26_055_G"),ZoneType.Board);
	}
}
public class BG26_055e:Ability{
//NAME=梦魇入心
//TEXT=<b>亡语：</b>召唤一个再生梦魇。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG26_055"),ZoneType.Board);
	}
}
public class BG26_120:MinionBase{
//NAME=蓄势新秀
//TEXT=<b><b>嘲讽</b>。</b>每2个回合，在回合结束时，将本随从的生命值变为你战队中生命值最高的随从的生命值。<i>（还剩{0}个回合！）</i>
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=ELEMENTAL
}
public class BG26_120_G:MinionBase{
//NAME=蓄势新秀
//TEXT=<b><b>嘲讽</b>。</b>每2个回合，在回合结束时，将本随从的生命值变为你战队中生命值最高的随从的生命值的两倍。<i>（还剩{0}个回合！）</i>
//MAJ=NEUTRAL|COST=4|ATK=8|HP=8|RACE=ELEMENTAL
}
public class BG26_120_Ge:Ability{
//NAME=火起来了
//TEXT=生命值变为最高的两倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_120e:Ability{
//NAME=火起来了
//TEXT=生命值变为最高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_124:MinionBase{
//NAME=蓄势模仿者
//TEXT=每2个回合，在回合结束时，随机使你手牌中的一张海盗牌变为金色。<i>（还剩{0}个回合！）</i>2每2个回合，在回合结束时，随机使你手牌中的一张海盗牌变为金色。<i>（就是这个回合！）</i>
//MAJ=NEUTRAL|COST=5|ATK=8|HP=4|RACE=PIRATE
}
public class BG26_124_G:MinionBase{
//NAME=蓄势模仿者
//TEXT=每2个回合，在回合结束时，随机使你手牌中的2张海盗牌变为金色。<i>（还剩{0}个回合！）</i>2每2个回合，在回合结束时，随机使你手牌中的2张海盗牌变为金色。<i>（就是这个回合！）</i>
//MAJ=NEUTRAL|COST=5|ATK=16|HP=8|RACE=PIRATE
}
public class BG26_135:MinionBase{
//NAME=南海卖艺者
//TEXT=<b>战吼：</b>下回合获得1枚铸币。
//MAJ=NEUTRAL|COST=1|ATK=3|HP=1|RACE=PIRATE
}
public class BG26_135_G:MinionBase{
//NAME=南海卖艺者
//TEXT=<b>战吼：</b>下回合获得2枚铸币。
//MAJ=NEUTRAL|COST=1|ATK=6|HP=2|RACE=PIRATE
}
public class BG26_135e:Ability{
//NAME=回合额外铸币
//TEXT=下回合额外获得1枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_137:MinionBase{
//NAME=裁脍鱼人
//TEXT=当本牌在你手牌中时，在你使用一张鱼人牌后，获得+3/+3。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=MURLOC
}
public class BG26_137_G:MinionBase{
//NAME=裁脍鱼人
//TEXT=当本牌在你手牌中时，在你使用一张鱼人牌后，获得+6/+6。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=8|RACE=MURLOC
}
public class BG26_137_Ge:Ability{
//NAME=斤斤计较
//TEXT=+6/+6。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_137e:Ability{
//NAME=斤斤计较
//TEXT=+3/+3。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_146:MinionBase{
//NAME=催眠机器人
//TEXT=<b>磁力</b>。在你的回合结束时，获得+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=MECHANICAL
}
public class BG26_146_G:MinionBase{
//NAME=催眠机器人
//TEXT=<b>磁力</b>。在你的回合结束时，获得+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=MECHANICAL
}
public class BG26_146_Ge:Ability{
//NAME=好梦
//TEXT=+2/+2
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_146_Ge2:Ability{
//NAME=催眠机器人
//TEXT=在你的回合结束时，获得+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_146e:Ability{
//NAME=好梦
//TEXT=+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_146e2:Ability{
//NAME=催眠机器人
//TEXT=在你的回合结束时，获得+1/+1。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_147:MinionBase{
//NAME=手风琴机器人
//TEXT=<b>磁力</b>。在你的回合开始时，获得1枚额外铸币。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MECHANICAL
}
public class BG26_147_G:MinionBase{
//NAME=手风琴机器人
//TEXT=<b>磁力</b>。在你的回合开始时，获得2枚额外铸币。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=6|RACE=MECHANICAL
}
public class BG26_147_Ge:Ability{
//NAME=手风琴机器人
//TEXT=在你的回合开始时，获得2枚额外铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_147e:Ability{
//NAME=手风琴机器人
//TEXT=在你的回合开始时，获得1枚额外铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_148:MinionBase{
//NAME=报废废铁回收机
//TEXT=<b>亡语：</b>随机获取一张<b>磁力</b>机械牌。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=5|RACE=MECHANICAL
}
public class BG26_148_G:MinionBase{
//NAME=报废废铁回收机
//TEXT=<b>亡语：</b>随机获取2张<b>磁力</b>机械牌。
//MAJ=NEUTRAL|COST=4|ATK=12|HP=10|RACE=MECHANICAL
}
public class BG26_149:MinionBase{
//NAME=极性B-Box拳手
//TEXT=每当你对另一个随从施加<b>磁力</b>时，还会对本随从施加<b>磁力</b>。
//MAJ=NEUTRAL|COST=6|ATK=5|HP=10|RACE=MECHANICAL
}
public class BG26_149_G:MinionBase{
//NAME=极性B-Box拳手
//TEXT=每当你对另一个随从施加<b>磁力</b>时，还会对本随从施加<b>磁力</b>两次。
//MAJ=NEUTRAL|COST=6|ATK=10|HP=20|RACE=MECHANICAL
}
public class BG26_149e:Ability{
//NAME=磁极化
//TEXT=额外对一个机械施加<b>磁力</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_152:MinionBase{
//NAME=多面辅助无人机
//TEXT=在你的回合结束时，你的随从每拥有一个<b>磁力</b>效果，使其获得+2/+1。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=MECHANICAL
}
public class BG26_152_G:MinionBase{
//NAME=多面辅助无人机
//TEXT=在你的回合结束时，你的随从每拥有一个<b>磁力</b>效果，使其获得+4/+2。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=8|RACE=MECHANICAL
}
public class BG26_152_Ge:Ability{
//NAME=辅助得力
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_152e:Ability{
//NAME=辅助得力
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_157:MinionBase{
//NAME=作曲鬃师
//TEXT=<b>复仇（2）：</b>对你的所有野猪人各使用2张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=10|RACE=QUILBOAR
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
					if(this.RevengeCnt%2==0)
					{
						TriggBuff();
					}
				}
			}
		}
	}
	public void TriggBuff()
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Quilboar),atk:2,hp:2);
	}
}
public class BG26_157_G:MinionBase{
//NAME=作曲鬃师
//TEXT=<b>复仇（2）：</b>对你的所有野猪人各使用4张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=20|RACE=QUILBOAR
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
					if(this.RevengeCnt%2==0)
					{
						TriggBuff();
					}
				}
			}
		}
	}
	public void TriggBuff()
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board,RaceType.Quilboar),atk:4,hp:4);
	}
}
public class BG26_159:MinionBase{
//NAME=暗膘爵士乐手
//TEXT=<b>战吼：</b>在本局对战中，你的<b>鲜血宝石</b>会额外获得+1生命值。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=3|RACE=QUILBOAR
}
public class BG26_159_G:MinionBase{
//NAME=暗膘爵士乐手
//TEXT=<b>战吼：</b>在本局对战中，你的<b>鲜血宝石</b>会额外获得+2生命值。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=6|RACE=QUILBOAR
}
public class BG26_159pe:Ability{
//NAME=鲜血宝石玩家效果
//TEXT=记录此玩家的鲜血宝石体量。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_160:MinionBase{
//NAME=刺头吹笛人
//TEXT=<b>亡语：</b>在本局对战中，你的<b>鲜血宝石</b>会额外获得+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=5|HP=1|RACE=QUILBOAR
}
public class BG26_160_G:MinionBase{
//NAME=刺头吹笛人
//TEXT=<b>亡语：</b>在本局对战中，你的<b>鲜血宝石</b>会额外获得+2攻击力。
//MAJ=NEUTRAL|COST=3|ATK=10|HP=2|RACE=QUILBOAR
}
public class BG26_162:MinionBase{
//NAME=农场热舞旋风
//TEXT=<b>亡语：</b>在本局对战中，酒馆中的元素拥有+1/+1。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=ELEMENTAL
}
public class BG26_162_G:MinionBase{
//NAME=农场热舞旋风
//TEXT=<b>亡语：</b>在本局对战中，酒馆中的元素拥有+2/+2。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=2|RACE=ELEMENTAL
}
public class BG26_162e:Ability{
//NAME=农场旋风
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_162pe:Ability{
//NAME=农场热舞旋风玩家效果
//TEXT=农场热舞旋风使酒馆中的元素属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_171:MinionBase{
//NAME=沉默的泳者
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+3/+5和<b>潜行</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=3|RACE=NAGA
}
public class BG26_171_G:MinionBase{
//NAME=沉默的泳者
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+6/+10和<b>潜行</b>。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=6|RACE=NAGA
}
public class BG26_171_Ge:Ability{
//NAME=游就对了
//TEXT=直到下个回合，获得+6/+10和<b>潜行</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_171_Gt:SpellBase{
//NAME=游就对了
//TEXT=直到下个回合，使一个随从获得+6/+10和<b>潜行</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG26_171e:Ability{
//NAME=游就对了
//TEXT=直到下个回合，获得+3/+5和<b>潜行</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_171t:SpellBase{
//NAME=游就对了
//TEXT=直到下个回合，使一个随从获得+3/+5和<b>潜行</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG26_172:MinionBase{
//NAME=木琴骷髅
//TEXT=在战斗中，在你召唤一个随从后，永久获得+3生命值。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=1|RACE=UNDEAD
}
public class BG26_172_G:MinionBase{
//NAME=木琴骷髅
//TEXT=在战斗中，在你召唤一个随从后，永久获得+6生命值。
//MAJ=NEUTRAL|COST=4|ATK=12|HP=2|RACE=UNDEAD
}
public class BG26_172_Ge:Ability{
//NAME=出肋拔萃
//TEXT=+6生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_172e:Ability{
//NAME=出肋拔萃
//TEXT=+3生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_174:MinionBase{
//NAME=灵魂回溯者
//TEXT=在你的英雄受到伤害后，回溯该伤害并使本随从获得+1生命值。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=1|RACE=DEMON
}
public class BG26_174_G:MinionBase{
//NAME=灵魂回溯者
//TEXT=在你的英雄受到伤害后，回溯该伤害并使本随从获得+2生命值。
//MAJ=NEUTRAL|COST=2|ATK=6|HP=2|RACE=DEMON
}
public class BG26_174_Ge:Ability{
//NAME=灵魂回溯
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_174e:Ability{
//NAME=灵魂回溯
//TEXT=+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_175:MinionBase{
//NAME=惊喜元素
//TEXT=<b>圣盾</b>。可以与任意元素三连。
//MAJ=NEUTRAL|COST=6|ATK=8|HP=8|RACE=ELEMENTAL
	public override void Init()
	{
		TaskInitAbility("DivineShield");
	}
}
public class BG26_175_G:MinionBase{
//NAME=惊喜元素
//TEXT=<b>圣盾</b>。可以与任意元素三连。
//MAJ=NEUTRAL|COST=6|ATK=16|HP=16|RACE=ELEMENTAL
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("DivineShield");
	}
}
public class BG26_175e:Ability{
//NAME=惊不惊喜！
//TEXT=属性值提高并获得<b>圣盾</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_176:MinionBase{
//NAME=布吉舞怪兽
//TEXT=在你使用一张等级{0}的随从牌后，晋升至下一等级并使你的随从获得+1/+2。1在你使用一张等级6的随从牌后，使你的随从获得+1/+2。
//MAJ=NEUTRAL|COST=6|ATK=3|HP=8|RACE=NONE
}
public class BG26_176_G:MinionBase{
//NAME=布吉舞怪兽
//TEXT=在你使用一张等级{0}的随从牌后，晋升至下一等级并使你的随从获得+2/+4。1在你使用一张等级6的随从牌后，使你的随从获得+2/+4。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=16|RACE=NONE
}
public class BG26_176_Ge:Ability{
//NAME=布吉摇摆
//TEXT=+2/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_176e:Ability{
//NAME=布吉摇摆
//TEXT=+1/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_199:MinionBase{
//NAME=蓄势二重唱
//TEXT=每2个回合，在回合结束时，获取一张本随从左边随从的原始版复制。<i>（还剩{0}个回合！）</i>2每2个回合，在回合结束时，获取一张本随从左边随从的原始版复制。<i>（就是这个回合！）</i>
//MAJ=NEUTRAL|COST=4|ATK=6|HP=6|RACE=NONE
}
public class BG26_199_G:MinionBase{
//NAME=蓄势二重唱
//TEXT=每2个回合，在回合结束时，获取本随从相邻随从的各一张原始版复制。<i>（还剩{0}个回合！）</i>2每2个回合，在回合结束时，获取本随从相邻随从的各一张原始版复制。<i>（就是这个回合！）</i>
//MAJ=NEUTRAL|COST=4|ATK=12|HP=12|RACE=NONE
}
public class BG26_199_Ge:Ability{
//NAME=双重和声
//TEXT={0}回合后获得{5}的2张复制。2回合结束时获得{5}的2张复制。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_199e:Ability{
//NAME=双重和声
//TEXT={0}回合后获得{5}。2回合结束时获得{5}。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_350:MinionBase{
//NAME=低音提琴鱼人
//TEXT=<b>亡语：</b>召唤你手牌中生命值最高的鱼人，其登场仅限本场战斗。
//MAJ=NEUTRAL|COST=3|ATK=7|HP=2|RACE=MURLOC
	public override void Deathrattle()
	{
		Card MaxHealth = null;
		foreach(Card c in owner.myPlayer.hand)
		{
			if(c.cardType==CardType.Minion)
			{
				if(c.raceType.Contains(RaceType.Murloc) || c.raceType.Contains(RaceType.All))
				{
					if(MaxHealth==null)
					{
						MaxHealth=c;
					}
					else{
						if(c.GetTag(GameTag.Health)>MaxHealth.GetTag(GameTag.Health))
						{
							MaxHealth=c;
						}
					}
				}
			}
		}
		if(MaxHealth!=null)
		{
			new EffectMove(owner.myPlayer,MaxHealth,ZoneType.Hand,ZoneType.Board).Resolve();
		}
	}
}
public class BG26_350_G:MinionBase{
//NAME=低音提琴鱼人
//TEXT=<b>亡语：</b>召唤你手牌中生命值最高的2个鱼人，其登场仅限本场战斗。
//MAJ=NEUTRAL|COST=3|ATK=14|HP=4|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		for(int i=0;i<2;i++)
		{
			Card MaxHealth = null;
			foreach(Card c in owner.myPlayer.hand)
			{
				if(c.cardType==CardType.Minion)
				{
					if(c.raceType.Contains(RaceType.Murloc) || c.raceType.Contains(RaceType.All))
					{
						if(MaxHealth==null)
						{
							MaxHealth=c;
						}
						else{
							if(c.GetTag(GameTag.Health)>MaxHealth.GetTag(GameTag.Health))
							{
								MaxHealth=c;
							}
						}
					}
				}
			}
			if(MaxHealth!=null)
			{
				new EffectMove(owner.myPlayer,MaxHealth,ZoneType.Hand,ZoneType.Board).Resolve();
			}			
		}
	}
}
public class BG26_350e2:Ability{
//NAME=无法使用
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_352:MinionBase{
//NAME=蓄势长笛手
//TEXT=每2个回合，在回合结束时，随机使你手牌中的一张随从牌获得+9生命值。<i>（还剩{0}个回合）</i>2每2个回合，在回合结束时，随机使你手牌中的一张随从牌获得+9生命值。<i>（就是这个回合！）</i>
//MAJ=NEUTRAL|COST=2|ATK=2|HP=5|RACE=MURLOC
}
public class BG26_352_G:MinionBase{
//NAME=蓄势长笛手
//TEXT=每2个回合，在回合结束时，随机使你手牌中的一张随从牌获得+18生命值。<i>（还剩{0}个回合）</i>2每2个回合，在回合结束时，随机使你手牌中的一张随从牌获得+18生命值。<i>（就是这个回合！）</i>
//MAJ=NEUTRAL|COST=2|ATK=4|HP=10|RACE=MURLOC
}
public class BG26_352_Ge:Ability{
//NAME=魔笛
//TEXT=+18生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_352e:Ability{
//NAME=魔笛
//TEXT=+9生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_354:MinionBase{
//NAME=合唱鱼人
//TEXT=<b>战斗开始时：</b>获得你手牌中所有随从牌的属性值。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=6|RACE=MURLOC
	public override void OnCombatStart()
	{
		int atk=0;
		int hp=0;
		List<Card> ToListBuff = new List<Card>();
		foreach(Card c in owner.myPlayer.hand)
		{
			if(c.cardType==CardType.Minion)
			{
				atk+=c.GetTag(GameTag.Attack);
				hp+=c.GetTag(GameTag.Health);
				ToListBuff.Add(c);
			}
		}
		TaskBuffTargets(ToListBuff);
		new EffectChange(owner.myPlayer,owner,owner,atkChange:atk,hpChange:hp).Resolve();
	}
}
public class BG26_354_G:MinionBase{
//NAME=合唱鱼人
//TEXT=<b>战斗开始时：</b>获得你手牌中所有随从牌的双倍属性值。
//MAJ=NEUTRAL|COST=6|ATK=12|HP=12|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void OnCombatStart()
	{
		int atk=0;
		int hp=0;
		List<Card> ToListBuff = new List<Card>();
		foreach(Card c in owner.myPlayer.hand)
		{
			if(c.cardType==CardType.Minion)
			{
				atk+=c.GetTag(GameTag.Attack);
				hp+=c.GetTag(GameTag.Health);
				ToListBuff.Add(c);
			}
		}
		TaskBuffTargets(ToListBuff);
		new EffectChange(owner.myPlayer,owner,owner,atkChange:2*atk,hpChange:2*hp).Resolve();
	}
}
public class BG26_354e:Ability{
//NAME=齐唱
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_355:MinionBase{
//NAME=迪斯科曳步舞者
//TEXT=<b>抉择：</b>触发一个友方随从的<b>战吼</b>；或者<b>发现</b>一张<b>战吼</b>随从牌。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=3|RACE=DRAGON
}
public class BG26_355_G:MinionBase{
//NAME=迪斯科曳步舞者
//TEXT=<b>抉择：</b>触发一个友方随从的<b>战吼</b>两次；或者<b>发现</b>2张<b>战吼</b>随从牌。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=6|RACE=DRAGON
}
public class BG26_355_Gt:SpellBase{
//NAME=继续舞下去
//TEXT=触发一个友方随从的<b>战吼</b>两次。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_355_Gt2:SpellBase{
//NAME=新伙伴上台
//TEXT=<b>发现</b>2张<b>战吼</b>随从牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_355t:SpellBase{
//NAME=继续舞下去
//TEXT=触发一个友方随从的<b>战吼</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_355t2:SpellBase{
//NAME=新伙伴上台
//TEXT=<b>发现</b>一张<b>战吼</b>随从牌。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_356:MinionBase{
//NAME=圣殿眠龙
//TEXT=<b>战斗开始时：</b>使你的其他龙获得+8生命值。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=DRAGON
	public override void OnCombatStart()
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Dragon),hp:8);
	}
}
public class BG26_356_G:MinionBase{
//NAME=圣殿眠龙
//TEXT=<b>战斗开始时：</b>使你的其他龙获得+16生命值。
//MAJ=NEUTRAL|COST=5|ATK=10|HP=10|RACE=DRAGON
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void OnCombatStart()
	{
		TaskBuffTargets(FindRace(owner.myPlayer.board.Exclude(owner),RaceType.Dragon),hp:16);
	}
}
public class BG26_356_Ge:Ability{
//NAME=充分休息
//TEXT=+16生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_356e:Ability{
//NAME=充分休息
//TEXT=+8生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_360:MinionBase{
//NAME=寻宝鱼人
//TEXT=<b>亡语：</b>随机使你手牌中的一张随从牌获得+5/+5。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=MURLOC
	public override void Deathrattle()
	{
		Card ToBuff = FindType(owner.myPlayer.hand,CardType.Minion).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:5,hpChange:5).Resolve();
		}
	}
}
public class BG26_360_G:MinionBase{
//NAME=寻宝鱼人
//TEXT=<b>亡语：</b>随机使你手牌中的一张随从牌获得+10/+10。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=6|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		Card ToBuff = FindType(owner.myPlayer.hand,CardType.Minion).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:10,hpChange:10).Resolve();
		}
	}
}
public class BG26_360_Ge:Ability{
//NAME=探寻
//TEXT=+10/+10。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_360e:Ability{
//NAME=探寻
//TEXT=+5/+5。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_361:MinionBase{
//NAME=踏潮疫病鱼人
//TEXT=<b>烈毒</b>
//MAJ=NEUTRAL|COST=4|ATK=2|HP=7|RACE=MURLOC
	public override void Init()
	{
		TaskInitAbility("Toxic");
	}
}
public class BG26_361_G:MinionBase{
//NAME=踏潮疫病鱼人
//TEXT=<b>烈毒</b>
//MAJ=NEUTRAL|COST=4|ATK=4|HP=14|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Toxic");
	}
}
public class BG26_370:MinionBase{
//NAME=饥饿的钳嘴龟
//TEXT=在你召唤一只野兽后，永久获得+1生命值。
//MAJ=NEUTRAL|COST=2|ATK=5|HP=2|RACE=BEAST
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Beast) || sc.raceType.Contains(RaceType.All))
			{
				new EffectChange(owner.myPlayer,owner,owner,hpChange:1).Resolve();
			}
		}
	}
}
public class BG26_370_G:MinionBase{
//NAME=饥饿的钳嘴龟
//TEXT=在你召唤一只野兽后，永久获得+2生命值。
//MAJ=NEUTRAL|COST=2|ATK=10|HP=4|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.raceType.Contains(RaceType.Beast) || sc.raceType.Contains(RaceType.All))
			{
				new EffectChange(owner.myPlayer,owner,owner,hpChange:2).Resolve();
			}
		}
	}
}
public class BG26_370_Ge:Ability{
//NAME=一口夹住
//TEXT=+2生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_370e:Ability{
//NAME=一口夹住
//TEXT=+1生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_501:MinionBase{
//NAME=疾涛吉他手
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得等同于你当前等级的属性值。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=NAGA
}
public class BG26_501_G:MinionBase{
//NAME=疾涛吉他手
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得等同于你当前等级两倍的属性值。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=2|RACE=NAGA
}
public class BG26_501_Ge:Ability{
//NAME=精彩即兴
//TEXT=直到下个回合，属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_501_Gt:SpellBase{
//NAME=精彩即兴
//TEXT=直到下个回合，使一个随从获得等同于你当前等级两倍的属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG26_501e:Ability{
//NAME=精彩即兴
//TEXT=直到下个回合，属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_501t:SpellBase{
//NAME=精彩即兴
//TEXT=直到下个回合，使一个随从获得等同于你当前等级的属性值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG26_502:MinionBase{
//NAME=深沉蓝调歌手
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+1/+1。提升你此后的深沉蓝调效果。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=NAGA
}
public class BG26_502_G:MinionBase{
//NAME=深沉蓝调歌手
//TEXT=<b>塑造法术：</b>直到下个回合，使一个随从获得+2/+2。提升你此后的深沉蓝调效果。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=4|RACE=NAGA
}
public class BG26_502_Ge:Ability{
//NAME=深沉蓝调
//TEXT=直到下个回合，属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_502_Gt:SpellBase{
//NAME=深沉蓝调
//TEXT=直到下个回合，使一个随从获得+2/+2。提升你此后的深沉蓝调效果。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG26_502e:Ability{
//NAME=深沉蓝调
//TEXT=直到下个回合，属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_502pe:Ability{
//NAME=深沉蓝调歌手玩家效果
//TEXT=记录此玩家的深沉蓝调。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_502t:SpellBase{
//NAME=深沉蓝调
//TEXT=直到下个回合，使一个随从获得+1/+1。提升你此后的深沉蓝调效果。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=SPELLCRAFT
}
public class BG26_505:MinionBase{
//NAME=热情沙锤手
//TEXT=每回合一次：当<b>塑造法术</b>的法术被用于本随从时，获取它的一张新复制。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=6|RACE=NAGA
}
public class BG26_505_G:MinionBase{
//NAME=热情沙锤手
//TEXT=每回合一次：当<b>塑造法术</b>的法术被用于本随从时，获取它的2张新复制。
//MAJ=NEUTRAL|COST=4|ATK=12|HP=12|RACE=NAGA
}
public class BG26_522:MinionBase{
//NAME=鬼火钢琴家
//TEXT=<b>战吼：</b>如果你自上回合起受到过伤害，使你的其他恶魔获得+2/+2。
//MAJ=NEUTRAL|COST=3|ATK=4|HP=1|RACE=DEMON
}
public class BG26_522_G:MinionBase{
//NAME=鬼火钢琴家
//TEXT=<b>战吼：</b>如果你自上回合起受到过伤害，使你的其他恶魔获得+4/+4。
//MAJ=NEUTRAL|COST=3|ATK=8|HP=2|RACE=DEMON
}
public class BG26_522_Ge:Ability{
//NAME=鬼火
//TEXT=+4/+4。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_522e:Ability{
//NAME=鬼火
//TEXT=+2/+2。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_523:MinionBase{
//NAME=提克迪奥斯
//TEXT=在你的英雄受到伤害后，使你的恶魔获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=3|RACE=DEMON
}
public class BG26_523_G:MinionBase{
//NAME=提克迪奥斯
//TEXT=在你的英雄受到伤害后，使你的恶魔获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=DEMON
}
public class BG26_523_Ge:Ability{
//NAME=恐惧魔王之拥
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_523e:Ability{
//NAME=恐惧魔王之拥
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_524:MinionBase{
//NAME=舞蹈王子玛克扎尔
//TEXT=每回合中， 有2次<b>刷新</b>会消耗生命值，而非铸币。<i>（还剩2次！）</i>
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=DEMON
}
public class BG26_524_G:MinionBase{
//NAME=舞蹈王子玛克扎尔
//TEXT=每回合中， 有4次<b>刷新</b>会消耗生命值，而非铸币。<i>（还剩4次！）</i>
//MAJ=NEUTRAL|COST=3|ATK=8|HP=6|RACE=DEMON
}
public class BG26_525:MinionBase{
//NAME=奇瑰打击乐手
//TEXT=<b><b>战吼： </b>发现</b>一张恶魔牌，对你的英雄造成等同于其等级的伤害。
//MAJ=NEUTRAL|COST=4|ATK=4|HP=4|RACE=DEMON
}
public class BG26_525_G:MinionBase{
//NAME=奇瑰打击乐手
//TEXT=<b><b>战吼：</b>发现</b>2张恶魔牌，对你的英雄造成等同于其等级的伤害。
//MAJ=NEUTRAL|COST=4|ATK=8|HP=8|RACE=DEMON
}
public class BG26_528:MinionBase{
//NAME=后台保安
//TEXT=<b>战吼：</b>对你的英雄造成1点伤害。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=4|RACE=DEMON
}
public class BG26_528_G:MinionBase{
//NAME=后台保安
//TEXT=<b>战吼：</b>对你的英雄造成1点伤害，触发两次。
//MAJ=NEUTRAL|COST=2|ATK=8|HP=8|RACE=DEMON
}
public class BG26_529:MinionBase{
//NAME=蓄势主唱幼龙
//TEXT=每3个回合，在回合结束时，随机获取一张龙牌。<i>（还剩{0}个回合）</i>3每3个回合，在回合结束时，随机获取一张龙牌。<i>（就是这个回合！）</i>
//MAJ=NEUTRAL|COST=1|ATK=1|HP=1|RACE=DRAGON
}
public class BG26_529_G:MinionBase{
//NAME=蓄势主唱幼龙
//TEXT=每3个回合，在回合结束时，随机获取2张龙牌。<i>（还剩{0}个回合）</i>3每3个回合，在回合结束时，随机获取2张龙牌。<i>（就是这个回合！）</i>
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=DRAGON
}
public class BG26_531:MinionBase{
//NAME=爆裂邦戈鼓手
//TEXT=在你的回合结束时，获取2张<b>鲜血宝石</b>，并额外对本随从使用2张。
//MAJ=NEUTRAL|COST=5|ATK=4|HP=3|RACE=QUILBOAR
}
public class BG26_531_G:MinionBase{
//NAME=爆裂邦戈鼓手
//TEXT=在你的回合结束时，获取4张<b>鲜血宝石</b>，并额外对本随从使用4张。
//MAJ=NEUTRAL|COST=5|ATK=8|HP=6|RACE=QUILBOAR
}
public class BG26_534:MinionBase{
//NAME=狂风小号手
//TEXT=在你出售5个元素后，随机获取一张元素牌。<i>（还剩5个！）</i>
//MAJ=NEUTRAL|COST=5|ATK=6|HP=7|RACE=ELEMENTAL
}
public class BG26_534_G:MinionBase{
//NAME=狂风小号手
//TEXT=在你出售5个元素后，随机获取2张元素牌。<i>（还剩5个！）</i>
//MAJ=NEUTRAL|COST=5|ATK=12|HP=14|RACE=ELEMENTAL
}
public class BG26_535:MinionBase{
//NAME=摇滚岩石
//TEXT=在你使用一张元素牌后，使你的随从获得+2攻击力。<i>（下回合切换为生命值！）</i>0在你使用一张元素牌后，使你的随从获得+2生命值。<i>（下回合切换为攻击力！）</i>
//MAJ=NEUTRAL|COST=6|ATK=5|HP=5|RACE=ELEMENTAL
}
public class BG26_535_G:MinionBase{
//NAME=摇滚岩石
//TEXT=在你使用一张元素牌后，使你的随从获得+4攻击力。<i>（下回合切换为生命值！）</i>0在你使用一张元素牌后，使你的随从获得+4生命值。<i>（下回合切换为攻击力！）</i>
//MAJ=NEUTRAL|COST=6|ATK=10|HP=10|RACE=ELEMENTAL
}
public class BG26_535_Ge:Ability{
//NAME=摇滚起来！
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_535_Ge2:Ability{
//NAME=起来摇滚！
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_535e:Ability{
//NAME=摇滚起来！
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_535e2:Ability{
//NAME=起来摇滚！
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_537:MinionBase{
//NAME=缤纷冰灵
//TEXT=在本局对战中，你每使用过一张元素牌，便拥有+2/+1<i>（无论本随从在哪）</i>。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=1|RACE=ELEMENTAL
}
public class BG26_537_G:MinionBase{
//NAME=缤纷冰灵
//TEXT=在本局对战中，你每使用过一张元素牌，便拥有+4/+2<i>（无论本随从在哪）</i>。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=2|RACE=ELEMENTAL
}
public class BG26_537e:Ability{
//NAME=冰花缤纷
//TEXT=+0攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_537pe:Ability{
//NAME=缤纷冰灵玩家效果
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_590:MinionBase{
//NAME=柔心海妖
//TEXT=每当本随从受到伤害，随机获取一张<b>塑造法术</b>的法术牌。<i>（每场战斗限3次。）</i>3每当本随从受到伤害，随机获取一张<b>塑造法术</b>的法术牌。<i>（还剩{0}次！）</i>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=6|RACE=NAGA
}
public class BG26_590_G:MinionBase{
//NAME=柔心海妖
//TEXT=每当本随从受到伤害，随机获取两张<b>塑造法术</b>的法术牌。<i>（每场战斗限3次。）</i>3每当本随从受到伤害，随机获取两张<b>塑造法术</b>的法术牌。<i>（还剩{0}次！）</i>
//MAJ=NEUTRAL|COST=4|ATK=6|HP=12|RACE=NAGA
}
public class BG26_766:MinionBase{
//NAME=舰队上将特塞斯
//TEXT=在你花掉9枚铸币后，随机获取一张海盗牌。<i>（还剩9枚！）</i>
//MAJ=NEUTRAL|COST=6|ATK=5|HP=6|RACE=PIRATE
}
public class BG26_766_G:MinionBase{
//NAME=舰队上将特塞斯
//TEXT=在你花掉9枚铸币后，随机获取2张海盗牌。<i>（还剩9枚！）</i>
//MAJ=NEUTRAL|COST=6|ATK=10|HP=12|RACE=PIRATE
}
public class BG26_800:MinionBase{
//NAME=魔刃豹
//TEXT=<b>亡语：</b>召唤两只0/1并具有<b>嘲讽</b>的豹宝宝。
//MAJ=NEUTRAL|COST=1|ATK=4|HP=1|RACE=BEAST
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG26_800t"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("BG26_800t"),ZoneType.Board);
	}
}
public class BG26_800_G:MinionBase{
//NAME=魔刃豹
//TEXT=<b>亡语：</b>召唤两只0/2并具有<b>嘲讽</b>的豹宝宝。
//MAJ=NEUTRAL|COST=1|ATK=8|HP=2|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG26_800_Gt"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("BG26_800_Gt"),ZoneType.Board);
	}
}
public class BG26_800_Gt:MinionBase{
//NAME=豹宝宝
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=2|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}
}
public class BG26_800t:MinionBase{
//NAME=豹宝宝
//TEXT=<b>嘲讽</b>
//MAJ=NEUTRAL|COST=1|ATK=0|HP=1|RACE=BEAST
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
}
public class BG26_801:MinionBase{
//NAME=重金属双头飞龙
//TEXT=<b>嘲讽</b>。<b>亡语：</b>触发一个相邻随从的<b>战吼</b>。
//MAJ=NEUTRAL|COST=4|ATK=5|HP=3|RACE=BEAST
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	public override void Deathrattle()
	{
		foreach(Card c in FindAdj(owner))
		{
			new EffectChange(owner.myPlayer,owner,c).Resolve();
            if (c.abilityList.Count != 0)
            {
                for (int i = 0; i < c.abilityList.Count; i++)
                {
                    c.abilityList[i].Battlecry(null);
                }
            }			
		}
	}
}
public class BG26_801_G:MinionBase{
//NAME=重金属双头飞龙
//TEXT=<b>嘲讽</b>。<b>亡语：</b>触发相邻随从的<b>战吼</b>。
//MAJ=NEUTRAL|COST=4|ATK=10|HP=6|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
	}

	public override void Deathrattle()
	{
		for(int j=0;j<3;j++)
		{
			foreach(Card c in FindAdj(owner))
			{
				new EffectChange(owner.myPlayer,owner,c).Resolve();
	            if (c.abilityList.Count != 0)
	            {
	                for (int i = 0; i < c.abilityList.Count; i++)
	                {
	                    c.abilityList[i].Battlecry(null);
	                }
	            }			
			}			
		}
	}
}
public class BG26_802:MinionBase{
//NAME=香蕉猛猿
//TEXT=在战斗中，在你召唤一只野兽后，使其属性值翻倍。
//MAJ=NEUTRAL|COST=5|ATK=3|HP=6|RACE=BEAST
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay() && tz==ZoneType.Board && sc!=owner)
		{
			if(sc.raceType.Contains(RaceType.Beast) || sc.raceType.Contains(RaceType.All))
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:sc.GetTag(GameTag.Attack),hpChange:sc.GetTag(GameTag.Health)).Resolve();
			}
		}
	}
}
public class BG26_802_G:MinionBase{
//NAME=香蕉猛猿
//TEXT=在战斗中，在你召唤一只野兽后，使其属性值变为三倍。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=12|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay() && tz==ZoneType.Board && sc!=owner)
		{
			if(sc.raceType.Contains(RaceType.Beast) || sc.raceType.Contains(RaceType.All))
			{
				new EffectChange(owner.myPlayer,owner,sc,atkChange:2*sc.GetTag(GameTag.Attack),hpChange:2*sc.GetTag(GameTag.Health)).Resolve();
			}
		}
	}
}
public class BG26_802_Ge:Ability{
//NAME=香蕉猛援
//TEXT=属性值变为三倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_802e:Ability{
//NAME=香蕉猛援
//TEXT=属性值翻倍。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_803_Gt:MinionBase{
//NAME=八爪巨怪的触手
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=4|HP=4|RACE=BEAST
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc!=owner)
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:4,hpChange:4).Resolve();
			}
		}
	}
}
public class BG26_803t:MinionBase{
//NAME=八爪巨怪的触手
//TEXT=
//MAJ=NEUTRAL|COST=1|ATK=2|HP=2|RACE=BEAST
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc!=owner)
			{
				new EffectChange(owner.myPlayer,owner,owner,atkChange:2,hpChange:2).Resolve();
			}
		}
	}
}
public class BG26_804:MinionBase{
//NAME=八爪巨怪，说唱卷王
//TEXT=<b>亡语：</b>召唤一个8/8的触手。<i>（在战斗中，在你召唤一个随从后，触手永久获得+2/+2！）</i>
//MAJ=NEUTRAL|COST=5|ATK=8|HP=8|RACE=BEAST

	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG26_803t"),ZoneType.Board);
	}
}
public class BG26_804_G:MinionBase{
//NAME=八爪巨怪，说唱卷王
//TEXT=<b>亡语：</b>召唤一个16/16的触手。<i>（在战斗中，在你召唤一个随从后，触手永久获得+4/+4！）</i>
//MAJ=NEUTRAL|COST=5|ATK=16|HP=16|RACE=BEAST
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("BG26_803_Gt"),ZoneType.Board);
	}
}
public class BG26_805:MinionBase{
//NAME=哼鸣蜂鸟
//TEXT=你的其他野兽拥有+2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=2|HP=4|RACE=BEAST
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Beast) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "BG26_805e";
    }
}
public class BG26_805_G:MinionBase{
//NAME=哼鸣蜂鸟
//TEXT=你的其他野兽拥有+4攻击力。
//MAJ=NEUTRAL|COST=2|ATK=4|HP=8|RACE=BEAST
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
        return (c.raceType.Contains(RaceType.Beast) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "BG26_805_Ge";
    }
}
public class BG26_805_Ge:Ability{
//NAME=着迷
//TEXT=哼鸣蜂鸟使其获得+4攻击力。
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
public class BG26_805e:Ability{
//NAME=着迷
//TEXT=哼鸣蜂鸟使其获得+2攻击力。
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
public class BG26_810:MinionBase{
//NAME=火药运输工
//TEXT=在你花掉4枚铸币后，使你的海盗获得+1攻击力。<i>（还剩4枚！）</i>
//MAJ=NEUTRAL|COST=3|ATK=1|HP=6|RACE=PIRATE
}
public class BG26_810_G:MinionBase{
//NAME=火药运输工
//TEXT=在你花掉4枚铸币后，使你的海盗获得+2攻击力。<i>（还剩4枚！）</i>
//MAJ=NEUTRAL|COST=3|ATK=2|HP=12|RACE=PIRATE
}
public class BG26_810_Ge:Ability{
//NAME=枪炮之威
//TEXT=+2攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_810e:Ability{
//NAME=枪炮之威
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_812:MinionBase{
//NAME=唱片走私犯
//TEXT=在你的回合开始时，获得2枚铸币。如果你控制至少三个海盗，再获得2枚。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=PIRATE
}
public class BG26_812_G:MinionBase{
//NAME=唱片走私犯
//TEXT=在你的回合开始时，获得4枚铸币。如果你控制至少三个海盗，再获得4枚。
//MAJ=NEUTRAL|COST=5|ATK=12|HP=12|RACE=PIRATE
}
public class BG26_813t:SpellBase{
//NAME=点金术
//TEXT=使一个友方随从变为金色。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_814:MinionBase{
//NAME=苦情民谣歌手
//TEXT=<b>战吼：</b>在本回合中，每花一枚铸币，使一个海盗获得+1生命值。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=PIRATE
}
public class BG26_814_G:MinionBase{
//NAME=苦情民谣歌手
//TEXT=<b>战吼：</b>在本回合中，每花一枚铸币，使一个海盗获得+2生命值。
//MAJ=NEUTRAL|COST=3|ATK=6|HP=8|RACE=PIRATE
}
public class BG26_814e:Ability{
//NAME=窗下情歌
//TEXT=+0生命值。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_815:MinionBase{
//NAME=开挂荷官
//TEXT=在你获得铸币后，获得+1/+1。
//MAJ=NEUTRAL|COST=5|ATK=6|HP=6|RACE=PIRATE
}
public class BG26_815_G:MinionBase{
//NAME=开挂荷官
//TEXT=在你获得铸币后，获得+2/+2。
//MAJ=NEUTRAL|COST=5|ATK=12|HP=12|RACE=PIRATE
}
public class BG26_815_Ge:Ability{
//NAME=发牌开挂
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_815e:Ability{
//NAME=发牌开挂
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_817:MinionBase{
//NAME=刀剑收藏家
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=PIRATE
    private List<Card> rem = new List<Card>(); 
    public override void BeforeAttack(Card target=null)
    {
        rem = FindAdj(target);
    }
    public override void AfterAttack(Card target=null)
    {
        /*
        int index=target.myPlayer.board.IndexOf(target);
        List<Card> targets=new List<Card>();
        if(index-1>=0 && index-1<target.myPlayer.board.Count)
        {
            targets.Add(target.myPlayer.board[index-1]);
        }
        if(index+1>=0 && index+1<target.myPlayer.board.Count)
        {
            targets.Add(target.myPlayer.board[index+1]);
        }
        */        
        if(rem.Count>0)
        {
            TaskDamageTargets(rem,owner.GetTag(GameTag.Attack));
        }
    }
}
public class BG26_817_G:MinionBase{
//NAME=刀剑收藏家
//TEXT=同时对其攻击目标相邻的随从造成伤害。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=4|RACE=PIRATE
	public override void Init()
	{
		TaskSetGolden();
	}
    private List<Card> rem = new List<Card>(); 
    public override void BeforeAttack(Card target=null)
    {
        rem = FindAdj(target);
    }
    public override void AfterAttack(Card target=null)
    {
        /*
        int index=target.myPlayer.board.IndexOf(target);
        List<Card> targets=new List<Card>();
        if(index-1>=0 && index-1<target.myPlayer.board.Count)
        {
            targets.Add(target.myPlayer.board[index-1]);
        }
        if(index+1>=0 && index+1<target.myPlayer.board.Count)
        {
            targets.Add(target.myPlayer.board[index+1]);
        }
        */        
        if(rem.Count>0)
        {
            TaskDamageTargets(rem,owner.GetTag(GameTag.Attack));
        }
    }
}
public class BG26_867:MinionBase{
//NAME=三只小野猪
//TEXT=<b>亡语：</b>对你的野猪人使用3张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=QUILBOAR
}
public class BG26_867_G:MinionBase{
//NAME=三只小野猪
//TEXT=<b>亡语：</b>对你的野猪人使用6张<b>鲜血宝石</b>。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=6|RACE=QUILBOAR
}
public class BG26_888:MinionBase{
//NAME=歌剧异术家
//TEXT=<b>烈毒</b>。<b>亡语：</b>使一个友方鱼人获得<b>烈毒</b>。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=2|RACE=MURLOC
	public override void Init()
	{
		TaskInitAbility("Toxic");
	}
	public override void Deathrattle()
	{
		Card ToBuff = FindRace(owner.myPlayer.board,RaceType.Murloc).Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"Toxic").Resolve();
		}
	}
}
public class BG26_888_G:MinionBase{
//NAME=歌剧异术家
//TEXT=<b>烈毒</b>。<b>亡语：</b>使2个友方鱼人获得<b>烈毒</b>。
//MAJ=NEUTRAL|COST=5|ATK=10|HP=4|RACE=MURLOC
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Toxic");
	}
	public override void Deathrattle()
	{
		for(int i=0;i<2;i++)
		{
			Card ToBuff = FindRace(owner.myPlayer.board,RaceType.Murloc).Choice(owner.myPlayer.randomGen);
			if(ToBuff!=null)
			{
				new EffectGiveAbility(owner.myPlayer,owner,ToBuff,"Toxic").Resolve();
			}			
		}
	}
}
public class BG26_888e:Ability{
//NAME=用毒的异术
//TEXT=<b><b>烈毒</b>。</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_921:MinionBase{
//NAME=狼人义警
//TEXT=<b>风怒</b>。本随从总会<i>（尽可能）</i>攻击可以击杀的敌方随从。
//MAJ=NEUTRAL|COST=6|ATK=10|HP=20|RACE=NONE
	private bool ReTarget=false;
	public override void Init()
	{
		//TaskInitAbility("WindFury");
	}
	public override void BeforeAttack(Card target=null)
	{	
		if(this.ReTarget)
		{
			return;
		}
		Card LeastAttack = null;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(LeastAttack==null)
			{
				LeastAttack=c;
			}
			else{
				if(c.GetTag(GameTag.Health)<LeastAttack.GetTag(GameTag.Health))
				{
					LeastAttack=c;
				}
			}
		}
		if(LeastAttack!=null)
		{
			this.ReTarget=true;
			new EffectAttack(owner.myPlayer,owner,LeastAttack).Resolve();
			if(owner.GetTag(GameTag.Health)>0)
			{
				Card LeastAttack2 = null;
				foreach(Card c in owner.myPlayer.otherPlayer.board)
				{
					if(LeastAttack2==null)
					{
						LeastAttack2=c;
					}
					else{
						if(c.GetTag(GameTag.Health)<LeastAttack.GetTag(GameTag.Health))
						{
							LeastAttack2=c;
						}
					}
				}
				if(LeastAttack2!=null)
				{
					new EffectAttack(owner.myPlayer,owner,LeastAttack2).Resolve();
				}
			}
			
		}
		this.ReTarget=false;
		owner.SetTag(GameTag.IsCanceled,1);
		owner.SetTag(GameTag.AttacksLeftThisTurn,0);
	}
}
public class BG26_921_G:MinionBase{
//NAME=狼人义警
//TEXT=<b>风怒</b>。本随从总会<i>（尽可能）</i>攻击可以击杀的敌方随从。
//MAJ=NEUTRAL|COST=6|ATK=20|HP=40|RACE=NONE
	private bool ReTarget=false;
	public override void Init()
	{
		TaskSetGolden();
		//TaskInitAbility("WindFury");
	}
	public override void BeforeAttack(Card target=null)
	{	
		if(this.ReTarget)
		{
			return;
		}
		Card LeastAttack = null;
		foreach(Card c in owner.myPlayer.otherPlayer.board)
		{
			if(LeastAttack==null)
			{
				LeastAttack=c;
			}
			else{
				if(c.GetTag(GameTag.Health)<LeastAttack.GetTag(GameTag.Health))
				{
					LeastAttack=c;
				}
			}
		}
		if(LeastAttack!=null)
		{
			this.ReTarget=true;
			new EffectAttack(owner.myPlayer,owner,LeastAttack).Resolve();
			if(owner.GetTag(GameTag.Health)>0)
			{
				Card LeastAttack2 = null;
				foreach(Card c in owner.myPlayer.otherPlayer.board)
				{
					if(LeastAttack2==null)
					{
						LeastAttack2=c;
					}
					else{
						if(c.GetTag(GameTag.Health)<LeastAttack.GetTag(GameTag.Health))
						{
							LeastAttack2=c;
						}
					}
				}
				if(LeastAttack2!=null)
				{
					new EffectAttack(owner.myPlayer,owner,LeastAttack2).Resolve();
				}
			}
			
		}
		this.ReTarget=false;
		owner.SetTag(GameTag.IsCanceled,1);
		owner.SetTag(GameTag.AttacksLeftThisTurn,0);
	}

}
public class BG26_963:MinionBase{
//NAME=电音合成师
//TEXT=<b>战吼：</b>使你的其他龙获得+3/+2。
//MAJ=NEUTRAL|COST=4|ATK=3|HP=2|RACE=DRAGON
}
public class BG26_963_G:MinionBase{
//NAME=电音合成师
//TEXT=<b>战吼：</b>使你的其他龙获得+6/+4。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=4|RACE=DRAGON
}
public class BG26_963_Ge:Ability{
//NAME=混合成音
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_963e:Ability{
//NAME=混合成音
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_966:MinionBase{
//NAME=风暴使者
//TEXT=在一条不同的友方的龙获得攻击力后，本随从也会获得。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=9|RACE=DRAGON
}
public class BG26_966_G:MinionBase{
//NAME=风暴使者
//TEXT=在一条不同的友方的龙获得攻击力后，本随从也会获得。触发两次。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=18|RACE=DRAGON
}
public class BG26_966e:Ability{
//NAME=挟来风暴
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_969:MinionBase{
//NAME=低保真飞龙
//TEXT=在你的回合结束时，使你攻击力低于本随从的随从获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=3|HP=2|RACE=DRAGON
}
public class BG26_969_G:MinionBase{
//NAME=低保真飞龙
//TEXT=在你的回合结束时，使你攻击力低于本随从的随从获得+2攻击力。
//MAJ=NEUTRAL|COST=2|ATK=6|HP=4|RACE=DRAGON
}
public class BG26_969_Ge:Ability{
//NAME=越飞越高
//TEXT=+2攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_969e:Ability{
//NAME=越飞越高
//TEXT=+1攻击力。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_CFM_636:MinionBase{
//NAME=暗影暴怒者
//TEXT=<b>潜行</b>
//MAJ=ROGUE|COST=3|ATK=5|HP=1|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Stealth");
	}
}
public class BG26_ETC_321:MinionBase{
//NAME=吵吵演艺团
//TEXT=<b>嘲讽</b>，<b>圣盾</b>。<b>亡语：</b>召唤三个1/2并具有<b>嘲讽</b>和<b>圣盾</b>的机械。
//MAJ=PALADIN|COST=9|ATK=3|HP=6|RACE=MECHANICAL
	public override void Init()
	{
		TaskInitAbility("Taunt");
		TaskInitAbility("DivineShield");
	}
	public override void Deathrattle()
	{
		CardDbf ToSummon = CardDbf.GetCardDbfByGuid("BG_GVG_085");
		TaskCreate(ToSummon,ZoneType.Board);
		TaskCreate(ToSummon,ZoneType.Board);
		TaskCreate(ToSummon,ZoneType.Board);
	}
}
public class BG26_ETC_321_G:MinionBase{
//NAME=吵吵演艺团
//TEXT=<b>嘲讽</b>，<b>圣盾</b>。<b>亡语：</b>召唤三个2/4并具有<b>嘲讽</b>和<b>圣盾</b>的机械。
//MAJ=PALADIN|COST=9|ATK=6|HP=12|RACE=MECHANICAL
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("Taunt");
		TaskInitAbility("DivineShield");
	}
	public override void Deathrattle()
	{
		CardDbf ToSummon = CardDbf.GetCardDbfByGuid("BG_GVG_085_G");
		TaskCreate(ToSummon,ZoneType.Board);
		TaskCreate(ToSummon,ZoneType.Board);
		TaskCreate(ToSummon,ZoneType.Board);
	}
}
public class BG26_FP1_005:MinionBase{
//NAME=纳克萨玛斯之影
//TEXT=<b><b>潜行</b>。</b>在你的回合开始时，获得+1/+1。
//MAJ=NEUTRAL|COST=3|ATK=2|HP=2|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Stealth");
	}
}
public class BG26_GIL_513:MinionBase{
//NAME=迷失的幽魂
//TEXT=<b>亡语：</b>使你的所有随从获得+1攻击力。
//MAJ=NEUTRAL|COST=2|ATK=1|HP=1|RACE=UNDEAD
	public override void Deathrattle()
	{
		TaskBuffTargets(owner.myPlayer.board,atk:1);
	}
}
public class BG26_GIL_513e:Ability{
//NAME=恐怖献祭
//TEXT=+1攻击力
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_HERO_100_SKIN_A:HeroBase{
//NAME=精英牛头人酋长，摇滚之王
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG26_HERO_101:HeroBase{
//NAME=霍格船长
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG26_HERO_101_Buddy:MinionBase{
//NAME=辉金水手
//TEXT=在你购买2个海盗后，获得+1/+1并在酒馆中添加一个海盗。<i>（还剩2个）</i>
//MAJ=NEUTRAL|COST=5|ATK=4|HP=7|RACE=PIRATE
}
public class BG26_HERO_101_Buddy_G:MinionBase{
//NAME=辉金水手
//TEXT=在你购买2个海盗后，获得+2/+2并在酒馆中添加一个海盗。<i>（还剩2个）</i>
//MAJ=NEUTRAL|COST=5|ATK=8|HP=14|RACE=PIRATE
}
public class BG26_HERO_101_Buddye:Ability{
//NAME=亮光光
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_HERO_101p:HeroPowerBase{
//NAME=我当船长啦
//TEXT=<b>被动：</b>在你购买一个海盗后，获得1枚铸币。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_HERO_102:HeroBase{
//NAME=因葛，钢铁颂歌
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG26_HERO_102_Buddy:MinionBase{
//NAME=庄严乐师
//TEXT=在你对一个随从使用你的英雄技能后，使其获得本随从一半的攻击力。<i>（下回合切换为生命值！）</i>0在你对一个随从使用你的英雄技能后，使其获得本随从一半的生命值。<i>（下回合切换为攻击力！）</i>
//MAJ=NEUTRAL|COST=3|ATK=4|HP=3|RACE=UNDEAD
}
public class BG26_HERO_102_Buddy_G:MinionBase{
//NAME=庄严乐师
//TEXT=在你对一个随从使用你的英雄技能后，使其获得本随从的攻击力。<i>（下回合切换为生命值！）</i>0在你对一个随从使用你的英雄技能后，使其获得本随从的生命值。<i>（下回合切换为攻击力！）</i>
//MAJ=NEUTRAL|COST=3|ATK=8|HP=6|RACE=UNDEAD
}
public class BG26_HERO_102_Buddye:Ability{
//NAME=庄严肃穆
//TEXT=属性值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_HERO_102p:HeroPowerBase{
//NAME=大调颂歌
//TEXT=使一个随从获得等同于你当前等级的攻击力。<i>（下回合切换为生命值！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_HERO_102p2:HeroPowerBase{
//NAME=小调颂歌
//TEXT=使一个随从获得等同于你当前等级的生命值。<i>（下回合切换为攻击力！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_HERO_102p2e:Ability{
//NAME=小调和声
//TEXT=生命值提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_HERO_102pe:Ability{
//NAME=大调和声
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_HERO_104:HeroBase{
//NAME=摇滚教父沃恩
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=0|HP=30|RACE=NONE
}
public class BG26_HERO_104_Buddy:MinionBase{
//NAME=摇滚犀牛阿卡里
//TEXT=每2个回合，在回合结束时获取你最左边的手牌的一张原始版复制。<i>（还剩{0}个回合！）</i>2每2个回合，在回合结束时获取你最左边的手牌的一张原始版复制。<i>（就是这个回合！）</i>
//MAJ=NEUTRAL|COST=4|ATK=3|HP=3|RACE=BEAST
}
public class BG26_HERO_104_Buddy_G:MinionBase{
//NAME=摇滚犀牛阿卡里
//TEXT=在每个回合结束时，获取你最左边的手牌的一张原始版复制。
//MAJ=NEUTRAL|COST=4|ATK=6|HP=6|RACE=BEAST
}
public class BG26_HERO_104p:HeroPowerBase{
//NAME=蓄势和声
//TEXT=<b>被动</b> 每3个回合，在回合结束时获取你最左边的手牌的一张原始版复制。<i>（还剩{0}个回合！）</i>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_ICC_026:MinionBase{
//NAME=冷酷的死灵法师
//TEXT=<b>战吼：</b>召唤两个1/1的骷髅。
//MAJ=NEUTRAL|COST=4|ATK=2|HP=4|RACE=UNDEAD
}
public class BG26_ICC_027:MinionBase{
//NAME=白骨幼龙
//TEXT=<b>亡语：</b>随机将一张龙牌置入你的手牌。
//MAJ=NEUTRAL|COST=6|ATK=6|HP=5|RACE=DRAGON
}
public class BG26_ICC_028:MinionBase{
//NAME=阳焰瓦格里
//TEXT=<b>战吼：</b>使相邻的随从获得+2生命值。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=4|RACE=UNDEAD
}
public class BG26_ICC_065:MinionBase{
//NAME=白骨大亨
//TEXT=<b>亡语：</b> 将两张1/1的“骷髅”置入你的手牌。
//MAJ=ROGUE|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class BG26_ICC_705:MinionBase{
//NAME=骨魇
//TEXT=<b>战吼：</b>使一个友方随从获得+4/+4和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=5|ATK=5|HP=5|RACE=UNDEAD
}
public class BG26_ICC_705_G:MinionBase{
//NAME=骨魇
//TEXT=<b>战吼：</b>使一个友方随从获得+8/+8和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=5|ATK=10|HP=10|RACE=UNDEAD
}
public class BG26_ICC_705_Ge:Ability{
//NAME=骨魇恩赐
//TEXT=+8/+8和<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_ICC_705e:Ability{
//NAME=骨魇恩赐
//TEXT=+4/+4并具有<b>嘲讽</b>。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_ICC_901:MinionBase{
//NAME=达卡莱附魔师
//TEXT=你的回合结束效果会触发两次。
//MAJ=NEUTRAL|COST=5|ATK=1|HP=5|RACE=NONE
}
public class BG26_ICC_901_G:MinionBase{
//NAME=达卡莱附魔师
//TEXT=你的回合结束效果会触发三次。
//MAJ=NEUTRAL|COST=5|ATK=2|HP=10|RACE=NONE
}
public class BG26_LOOT_534:MinionBase{
//NAME=镀金的石像鬼
//TEXT=<b>亡语：</b>将一张铸币置入你的手牌。
//MAJ=PRIEST|COST=3|ATK=2|HP=2|RACE=UNDEAD
}
public class BG26_OG_248:MinionBase{
//NAME=浆岩暴怒者
//TEXT=
//MAJ=NEUTRAL|COST=3|ATK=1|HP=5|RACE=UNDEAD
}
public class BG26_RLK_117:MinionBase{
//NAME=虚魂下士
//TEXT=在本随从攻击后消灭本随从。
//MAJ=NEUTRAL|COST=1|ATK=5|HP=5|RACE=UNDEAD
	public override void AfterAttack(Card target=null)
	{
		if(CondInPlay())
		{
			new EffectDestroy(owner.myPlayer,owner,owner).Resolve();
		}
	}
}
public class BG26_RLK_117_G:MinionBase{
//NAME=虚魂下士
//TEXT=在本随从攻击后消灭本随从。
//MAJ=NEUTRAL|COST=1|ATK=10|HP=10|RACE=UNDEAD
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void AfterAttack(Card target=null)
	{
		if(CondInPlay())
		{
			new EffectDestroy(owner.myPlayer,owner,owner).Resolve();
		}
	}
}
public class BG26_RLK_119:MinionBase{
//NAME=达卡莱入殓师
//TEXT=<b>战吼：</b>使一个友方亡灵获得<b>复生</b>。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=4|RACE=UNDEAD
}
public class BG26_RLK_119e:Ability{
//NAME=防腐尸
//TEXT=<b>复生</b>
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_RLK_824:MinionBase{
//NAME=肢体商贩
//TEXT=在你召唤一个亡灵后，使其获得+1攻击力。
//MAJ=NEUTRAL|COST=1|ATK=1|HP=2|RACE=UNDEAD
}
public class BG26_RLK_833:MinionBase{
//NAME=骨鸡蛋
//TEXT=<b>亡语：</b>召唤一只3/3的亡灵小鸡。
//MAJ=NEUTRAL|COST=1|ATK=0|HP=2|RACE=UNDEAD
	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("RLK_833t"),ZoneType.Board);
	}
}
public class BG26_SW_047:MinionBase{
//NAME=大领主弗塔根
//TEXT=<b>圣盾</b> 在一个友方随从失去<b>圣盾</b>后，使你手牌中的一张随从牌获得+5/+5。
//MAJ=PALADIN|COST=6|ATK=5|HP=5|RACE=NONE
	public override void Init()
	{
		TaskInitAbility("DivineShield");
	}
}
public class BG26_SW_047_G:MinionBase{
//NAME=大领主弗塔根
//TEXT=<b>圣盾</b> 在一个友方随从失去<b>圣盾</b>后，使你手牌中的一张随从牌获得+10/+10。
//MAJ=PALADIN|COST=6|ATK=10|HP=10|RACE=NONE
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("DivineShield");
	}
}
public class BG26_SW_047_Ge:Ability{
//NAME=大领主的祝福
//TEXT=+10/+10。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_tt_004:MinionBase{
//NAME=腐肉食尸鬼
//TEXT=每当一个随从死亡，便获得+1攻击力。
//MAJ=NEUTRAL|COST=3|ATK=3|HP=3|RACE=UNDEAD
}
public class BG26_tt_004o:Ability{
//NAME=野蛮残食
//TEXT=攻击力提高。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
}
public class BG26_ULD_274:MinionBase{
//NAME=废土刺客
//TEXT=<b>潜行</b>，<b>复生</b>
//MAJ=NEUTRAL|COST=5|ATK=4|HP=2|RACE=UNDEAD
	public override void Init()
	{
		TaskInitAbility("Stealth");
		TaskInitAbility("Reborn");
	}	
}
