using System.Collections;
using System.Collections.Generic;

public class TMP_910000:MinionBase
{
//旅行管理员杜加尔
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
		List<Card> ToListSummon = new List<Card>();
		while(true)
		{
			if(ToListSummon.Count>=3 || Pool.Count==0)
			{
				break;
			}
			Card ToSummon = Pool.Choice(owner.myPlayer.randomGen);
			ToListSummon.Add(ToSummon);
			for(int i=Pool.Count-1;i>=0;i--)
			{
				if(Pool[i].cardDbf.SetId==ToSummon.cardDbf.SetId)
				{
					Pool.RemoveAt(i);
				}
			}
		}
		/*
		List<string> HACK = new List<string>(){"UNG_099","SW_063","EX1_543"};
		ToListSummon.Clear();
		foreach(string s in HACK)
		{
			foreach(Card c in owner.myPlayer.deck)
			{
				if(c.cardDbf.m_noteMiniGuid == s)
				{
					ToListSummon.Add(c);
					break;
				}
			}			
		}
		*/
		foreach(Card c in ToListSummon)
		{
			new EffectChange(owner.myPlayer,owner,c).Resolve();
			new EffectMove(owner.myPlayer,c,ZoneType.Deck,ZoneType.Board).Resolve();
		}
	}
}


public class TMP_910002:MinionBase
{
    public int CNT=0;
    public bool Double=false;
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterDiscoverEnd(this,ChaoChiXueTuCauseEvent));
        //owner.myPlayer.AddCallBack(new CallBackAfterDiscoverEnd(this,DS1_184CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        owner.myPlayer.RemoveCallBackOf(this);
        //owner.myPlayer.RemoveCallBackOf(this);
    }
    public void ChaoChiXueTuCauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if (sc == owner)
        {
            new EffectMove(owner.myPlayer, tc, ZoneType.Aside, ZoneType.Grave).Resolve();
            if(tc.cardDbf.m_noteMiniGuid=="TMP_910002t2")
            {
            	TaskCreate(CardDbf.GetCardDbfByGuid("VAN_EX1_144"),ZoneType.Hand);
            	TaskCreate(CardDbf.GetCardDbfByGuid("VAN_EX1_144"),ZoneType.Hand);
            }
            if(tc.cardDbf.m_noteMiniGuid=="TMP_910002t3")
            {
            	TaskCreate(CardDbf.GetCardDbfByGuid("VAN_EX1_238"),ZoneType.Hand);
            	TaskCreate(CardDbf.GetCardDbfByGuid("VAN_EX1_238"),ZoneType.Hand);
            }
            //owner.cardDbf.RelatedDbf.RemoveAt(0);
            CNT+=1;
            if(Double==false)
            {
                this.Battlecry();
                Double=true;
            }
        }
    }
    private List<string> ToListDiscover = new List<string>(){"TMP_910002t1","TMP_910002t2","TMP_910002t3"};
    public override void Battlecry(Card target = null)
    {
        Double=false;
        List<Card> Op = new List<Card>();
        foreach (string s in this.ToListDiscover)
        {
            Op.Add(new Card(CardDbf.GetCardDbfByGuid(s), owner.myPlayer));
        }
        if(Op.Count>0)
            new EffectDiscoverStart(owner.myPlayer,owner,Op).Resolve();
    }
}


public class TMP_910003:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		List<Card> Pool = new List<Card>();
		foreach(Card c in owner.myPlayer.hand)
		{
			if(c.cardType==CardType.Minion)
			{
				Pool.Add(c);
			}
		}
		Card ToBuff = Pool.Choice(owner.myPlayer.randomGen);
		if(ToBuff!=null)
		{
			if(Pool.Count==1)
			{
				new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:4,hpChange:4,manaChange:-2).Resolve();
			}
			else{
				new EffectChange(owner.myPlayer,owner,ToBuff,atkChange:4,hpChange:4).Resolve();
			}
		}
	}
}

public class TMP_910007:MinionBase{
	public override void Battlecry(Card target=null)
	{
		Card LeastCost = null;
		Card MaxCost = null;
		foreach(Card c in owner.myPlayer.hand)
		{
			if(c.cardType==CardType.Spell)
			{
				if(LeastCost==null)
				{
					LeastCost=c;
				}
				else{
					if(c.GetTag(GameTag.Mana)>LeastCost.GetTag(GameTag.Mana))
					{
						if(MaxCost==null)
						{
							MaxCost = c;
						}
						else{
							if(c.GetTag(GameTag.Mana)>MaxCost.GetTag(GameTag.Mana))
							{
								MaxCost=c;
							}
						}
					}
				}
			}
		}

		if(MaxCost!=null && LeastCost!=null)
		{
			int TempCost = MaxCost.GetTag(GameTag.Mana);
			new EffectChange(owner.myPlayer,owner,MaxCost,manaChange:-TempCost+LeastCost.GetTag(GameTag.Mana)).Resolve();
			new EffectChange(owner.myPlayer,owner,LeastCost,manaChange:-LeastCost.GetTag(GameTag.Mana)+TempCost).Resolve();
		}
	}
}

public class TMP_910008:SpellBase{
	public override void Battlecry(Card target=null)
	{
		for(int i=0;i<7;i++)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid("ETC_833"),ZoneType.Board);
		}
	}
}

public class TMP_910009:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		CardDbf ManaDbf = CardDbf.GetCardDbfByGuid("EX1_014t");
		for(int i=0;i<8;i++)
		{
			if(owner.myPlayer.hand.Count<10)
			{
				TaskCreate(ManaDbf,ZoneType.Hand);
			}
			else{
				Card Target = owner.myPlayer.board.Choice(owner.myPlayer.randomGen);
				if(Target!=null)
				{
					Card Left = TaskCreate(ManaDbf,ZoneType.Aside);
					new EffectChange(owner.myPlayer,Left,Target,atkChange:1,hpChange:1).Resolve();
					new EffectMove(owner.myPlayer,Left,ZoneType.Aside,ZoneType.Grave).Resolve();				
				}
			}
		}
	}
}

public class TMP_910010:MinionBase
{
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
			new EffectChange(owner.myPlayer,owner,MaxCost).Resolve();
			new EffectMove(owner.myPlayer,MaxCost,ZoneType.Hand,ZoneType.Deck,targetIndex:0).Resolve();
		}
	}
}

public class TMP_910011:SpellBase
{
    public int CNT=0;
    public bool Double=false;
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterDiscoverEnd(this,ChaoChiXueTuCauseEvent));
        //owner.myPlayer.AddCallBack(new CallBackAfterDiscoverEnd(this,DS1_184CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        owner.myPlayer.RemoveCallBackOf(this);
        //owner.myPlayer.RemoveCallBackOf(this);
    }
    private Card Card1;
    private Card Card2;
    public void ChaoChiXueTuCauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if (sc == owner)
        {
            new EffectMove(owner.myPlayer, tc, ZoneType.Aside, ZoneType.Hand).Resolve();
            if(CNT==0)
            {
            	this.Card1=tc;
            }
            else{
            	this.Card2=tc;
            }
            //owner.cardDbf.RelatedDbf.RemoveAt(0);
            CNT+=1;
            if(CNT==2)
            {
            	//Card Target = TaskCreate(CardDbf.GetCardDbfByGuid("VAN_CS2_171"),ZoneType.Hand);
            	int TmpAtk=Card1.GetTag(GameTag.Attack);
            	int TmpHp=Card1.GetTag(GameTag.Health);
            	new EffectChange(owner.myPlayer,owner,Card1,atkChange:Card2.GetTag(GameTag.Attack),hpChange:Card2.GetTag(GameTag.Health)).Resolve();
            	new EffectChange(owner.myPlayer,owner,Card2,atkChange:TmpAtk,hpChange:TmpHp).Resolve();
            }
            if(Double==false)
            {
                this.Battlecry();
                Double=true;
            }
        }
    }
    private List<string> ToListDiscover1 = new List<string>(){"VAN_CS2_171","CS2_127","CS2_127"};
    private List<string> ToListDiscover2 = new List<string>(){"CS2_127","CS2_127","LOOT_526"};
    public override void Battlecry(Card target = null)
    {
        Double=false;
        List<Card> Op = new List<Card>();
        if(CNT==0)
        {
        	foreach (string s in this.ToListDiscover1)
        	{
            	Op.Add(new Card(CardDbf.GetCardDbfByGuid(s), owner.myPlayer));
        	}        	
        }
        else{
        	foreach (string s in this.ToListDiscover2)
        	{
            	Op.Add(new Card(CardDbf.GetCardDbfByGuid(s), owner.myPlayer));
        	}         	
        }

        if(Op.Count>0)
            new EffectDiscoverStart(owner.myPlayer,owner,Op).Resolve();
    }
}




public class TMP_910012:SpellBase
{
	public override void Battlecry(Card target =null)
	{
		new EffectGiveAbility(owner.myPlayer,owner,target,"Rush").Resolve();
		new EffectChange(owner.myPlayer,owner,target,atkChange:1,hpChange:2).Resolve();
		TaskCreate(owner.cardDbf,ZoneType.Hand);
	}
}

public class HERO_09at:PlayModeHeroBase{}


public class TMP_910014:MinionBase{
	public override void Init()
	{
		TaskInitAbility("Taunt");
		//owner.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
	}
	public override void Deathrattle()
	{
		TaskCreate(owner.cardDbf,ZoneType.Board);
	}
}


public class TMP_910015:MinionBase{
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
		owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent2));
		owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent2));
	}
	private int reduced=0;
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		reduced+=1;
	}
	public void CauseEvent2(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sz==ZoneType.Deck&&tz==ZoneType.Hand)
		{
			reduced+=1;
		}
	}
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.ManaMod)
		{
			return 0;//-reduced;
		}
		return 0;
	}
}

public class TMP_910016:MinionBase{
	private bool act=false;
	public override void Battlecry(Card target=null)
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
		act=true;
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(act)
		{
			if(sc!=owner && sc.cardType==CardType.Minion && sc.raceType.Contains(RaceType.Draenei))
			{
				TaskCreate(sc.cardDbf,ZoneType.Board);
				act=false;
			}
		}
	}
}


public class TMP_910017:MinionBase{
	public static List<CardDbf> Pool=new List<CardDbf>();
	
	public override void Battlecry(Card target=null)
	{
		if(Pool.Count==0)
		{
			foreach(CardDbf db in CardDbf.AllCardDbf)
			{
				if(db.CardType==CardType.Minion)
				{
					if(db.ManaCost==2)
					{
						if(!db.Description.Contains("亡语"))
						{
							Pool.Add(db);
						}
					}
				}
			}
		}

		List<Card> AtkSrc = new List<Card>();
		for(int i=0;i<7;i++)
		{
			if(owner.myPlayer.board.Count<7)
			{
				CardDbf ToCreateDbf=Pool.Choice(owner.myPlayer.randomGen);
				Card Created=TaskCreate(ToCreateDbf,ZoneType.Board);
				AtkSrc.Add(Created);
			}
		}
		for(int i=0;i<AtkSrc.Count;i++)
		{
			Card ToAtk = owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero).Choice(owner.myPlayer.randomGen);
			if(ToAtk!=null)
				new EffectAttack(owner.myPlayer,AtkSrc[i],ToAtk).Resolve();
		}
	}
}


public class TMP_910018:MinionBase
{
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(CondInPlay())
		{
			if(sc.cardType==CardType.Spell)
			{
				List<Card> ToListBuff = new List<Card>();
				List<int> ListBuffNums = new List<int>(){-2,2};
				Card Target = owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero).Choice(owner.myPlayer.randomGen);
				if(Target!=null)
				{
					ToListBuff.Add(Target);
					ToListBuff.Add(owner);
					new EffectChange(owner.myPlayer,owner,targets:ToListBuff,hpChanges:ListBuffNums).Resolve();
				}				
			}
		}
	}

}


public class SC_413t:MinionBase
{
	public override void Battlecry(Card target=null)
	{
		for (int i=0;i<1;i++)
		{
			Card Target = owner.myPlayer.otherPlayer.board.Choice(owner.myPlayer.randomGen);
			if(Target!=null)
			{
				int Ex = 10-Target.GetTag(GameTag.Health);
				List<Card> Targets=new List<Card>();
				List<int> Dmgs= new List<int>();
				Targets.Add(Target);
				Dmgs.Add(10);
				if(Ex>0)
				{
					Targets.Add(owner.myPlayer.otherPlayer.hero[0]);
					Dmgs.Add(Ex);
					//new EffectDamage(owner.myPlayer.otherPlayer,Target,owner.myPlayer.otherPlayer.hero[0],Ex).Resolve();
					//TaskDamageEnemyHero(Ex);
				}
				new EffectDamage(owner.myPlayer,owner,targets:Targets,amounts:Dmgs).Resolve();
			}			
		}
		TaskCreate(CardDbf.GetCardDbfByGuid("SC_413t"),ZoneType.Hand);
	}
	public override void Init()
	{
		owner.SetTag(GameTag.Mana,0);
	}
}


public class SC_008:MinionBase
{
	public override void Battlecry(Card target=null)
	{
		int Num = 1;
		foreach(Card c in owner.myPlayer.board)
		{
			if(c!=owner && c.cardDbf.m_noteMiniGuid=="SC_008")
			{
				Num+=1;
			}
		}
		for (int i=0;i<Num;i++)
		{
			Card Target = owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero).Choice(owner.myPlayer.randomGen);
			if(Target!=null)
			{
				List<Card> Targets=new List<Card>();
				List<int> Dmgs= new List<int>();
				Targets.Add(Target);
				Dmgs.Add(2);
				new EffectDamage(owner.myPlayer,owner,targets:Targets,amounts:Dmgs).Resolve();
			}			
		}
		TaskCreate(CardDbf.GetCardDbfByGuid("SC_008"),ZoneType.Hand);
	}
	public override void Init()
	{
		owner.SetTag(GameTag.Mana,0);
	}
}


public class TMP_EDR_021:MinionBase
{
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand)
		{
			new EffectChange(owner.myPlayer,owner,owner,manaChange:-1).Resolve();
		}
	}
	public override void Deathrattle()
	{
		new EffectMove(owner.myPlayer,owner,ZoneType.Board,ZoneType.Hand).Resolve();
	}
}


public class TMP_TLC_001:WeaponBase
{
	public override void RegisterEventEffect()
	{
		base.RegisterEventEffect();
		owner.myPlayer.AddCallBack(new CallBackAfterDiscoverEnd(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		TaskBuffMyHero();
		TaskCreate(CardDbf.GetCardDbfByGuid("EX1_559"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("NX2_033"),ZoneType.Board);
		new EffectChange(owner.myPlayer,owner,owner,0,0,-1,0, visualFx: false).Resolve();
	}
}