using System.Collections.Generic;
//BG31_840 裂骨船长 在战斗中，在你召唤一个不同的随从后，额外召唤一个它的复制。
//BG31_999 缝合回收者 <b>战斗开始时：</b>消灭本随从左边的随从。<b>亡语：</b>再次召唤被消灭随从的完全相同的复制。

public class BG31_999:MinionBase{
	public static bool Act = false;
	public override void OnCombatStart()
	{
		int ind = owner.myPlayer.board.IndexOf(owner);
		if(ind-1 < owner.myPlayer.board.Count && ind-1>=0)
		{
			Act=true;
			new EffectDestroy(owner.myPlayer,owner,owner.myPlayer.board[ind-1]).Resolve();
		}
	}
	public override void Deathrattle()
	{
		if(Act)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid("BG31_999_G"),ZoneType.Board);
		}
	}
}
public class BG31_999_G:MinionBase{
	public static bool Act = false;
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void OnCombatStart()
	{
		List<Card> Adj = FindAdj(owner);
		if(Adj.Count==2)
		{
			Act=true;
		}
		TaskDestroyTargets(Adj);
	}
	public override void Deathrattle()
	{
		if(Act)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid("BG28_968"),ZoneType.Board);
			TaskCreate(CardDbf.GetCardDbfByGuid("BG28_968"),ZoneType.Board);
		}
	}
}
public class BG31_835:MinionBase{
	private int RevengeCnt = 0;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	private List<Card> rem=new List<Card>();
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
	public override void Deathrattle()
	{
		foreach(Card c in this.rem)
		{
			new EffectMove(owner.myPlayer,c,ZoneType.Hand,ZoneType.Board).Resolve();
		}
	}
	public void TriggBuff()
	{
		Card CreatedCard = TaskCreate(CardDbf.AllBGSundeadDbf.Choice(owner.myPlayer.randomGen),ZoneType.Hand);
		this.rem.Add(CreatedCard);
	}
}
public class BG31_835_G:MinionBase{
	public override void Init()
	{
		TaskSetGolden();
	}
	private int RevengeCnt = 0;
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	private List<Card> rem=new List<Card>();
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
	public override void Deathrattle()
	{
		foreach(Card c in this.rem)
		{
			new EffectMove(owner.myPlayer,c,ZoneType.Hand,ZoneType.Board).Resolve();
		}
	}
	public void TriggBuff()
	{
		Card CreatedCard = TaskCreate(CardDbf.AllBGSundeadDbf.Choice(owner.myPlayer.randomGen),ZoneType.Hand);
		this.rem.Add(CreatedCard);
		Card CreatedCard2 = TaskCreate(CardDbf.AllBGSundeadDbf.Choice(owner.myPlayer.randomGen),ZoneType.Hand);
		this.rem.Add(CreatedCard2);
	}
}
public class BG31_HERO_802pt4:MinionBase{
	public override void OnCombatStart()
	{
		int atk =0;
		int hp =0;
		foreach(Card c in FindAdj(owner))
		{
			atk+=c.GetTag(GameTag.Attack);
			hp+=c.GetTag(GameTag.Health);
		}
		new EffectChange(owner.myPlayer,owner,owner,atkChange:atk,hpChange:hp).Resolve();
	}
}

public class BG31_HERO_802pt4_G:MinionBase{
	public override void Init()
	{
		TaskSetGolden();
	}
	public override void OnCombatStart()
	{
		int atk =0;
		int hp =0;
		foreach(Card c in FindAdj(owner))
		{
			atk+=c.GetTag(GameTag.Attack);
			hp+=c.GetTag(GameTag.Health);
		}
		new EffectChange(owner.myPlayer,owner,owner,atkChange:atk*2,hpChange:hp*2).Resolve();
	}
}

public class BG31_146:MinionBase{
	public override void Init()
	{
		//TaskSetGolden();
		TaskInitAbility("DivineShield");
		TaskInitAbility("WindFury");
	}
}
public class BG31_146_G:MinionBase{
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("DivineShield");
		TaskInitAbility("WindFury");
	}
}