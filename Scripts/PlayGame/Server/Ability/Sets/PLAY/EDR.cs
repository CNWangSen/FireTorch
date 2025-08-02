using System.Collections.Generic;

public class EDR_000:MinionBase
{
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterGameStart(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		owner.myPlayer.ChangeTag(GameTag.MaxTotalMana,5);
		owner.myPlayer.otherPlayer.ChangeTag(GameTag.MaxTotalMana,5);
		new EffectChange(owner.myPlayer,owner,targets:owner.myPlayer.hero.Merge(owner.myPlayer.otherPlayer.hero)).Resolve();
	}
	public override void Battlecry(Card target=null)
	{
		owner.myPlayer.ChangeTag(GameTag.ManaLeft,3);
		TaskBuffMyHero();
	}
}
public class TMP_EDR_001:MinionBase
{
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Dragon) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Hand && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "TMP_EDR_001e";
    }
}
public class TMP_EDR_001e:Ability
{    public override int AfterGetTag(GameTag tg)
    {
        if(tg==GameTag.ManaMod)
        {
            return -owner.cardDbf.ManaCost+1;
        }
        return 0;
    }
}
public class TMP_EDR_002:MinionBase
{
	private List<CardDbf> Killed=new List<CardDbf>();
	public override void Battlecry(Card target=null)
	{
		//new EffectEmote(owner.myPlayer,owner,"杀光他们！").Resolve();
		new EffectEmote(owner.myPlayer,null,"杀光他们！",owner.cardDbf).Resolve();
		List<Card> ToAttack = new List<Card>();
		foreach(Card c in owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board))
		{
			if(c!=owner)
			{
				ToAttack.Add(c);
			}
		}

		while(ToAttack.Count>0 && owner.GetTag(GameTag.Health)>0)
		{
			Card Attacking = ToAttack.Choice(owner.myPlayer.randomGen);
			if(Attacking!=null)
			{
				ToAttack.Remove(Attacking);
				new EffectChange(owner.myPlayer,owner,owner).Resolve();
				new EffectAttack(owner.myPlayer,owner,Attacking).Resolve();
			}
		}
	}
	public override void AfterMakeDamage(Card target = null, int amount=0)
	{
		if(target.GetTag(GameTag.Health)<0)
		{
			Killed.Add(target.cardDbf);
		}
		
	}
	public override void Deathrattle()
	{
		//new EffectEmote(owner.myPlayer,owner,"继承我的遗志！").Resolve();
		//new EffectEmote(owner.myPlayer,null,"继承我的遗志！",owner.cardDbf).Resolve();
		foreach(CardDbf db in Killed)
		{
			TaskCreate(db,ZoneType.Board);
		}
	}
}


public class TMP_EDR_003:MinionBase
{
	public override void Battlecry(Card target=null)
	{
		new EffectEmote(owner.myPlayer,owner,"复活吧，大哥们！").Resolve();
		//new EffectEmote(owner.myPlayer,null,"复活吧，大哥们！",owner.cardDbf).Resolve();
		List<string> ToSummon = new List<string>(){"EX1_298","EX1_105","NEW1_010","GIL_119","DAL_742","WW_440"};
		foreach(string st in ToSummon)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid(st),ZoneType.Board);
		}

		new EffectEmote(owner.myPlayer,null,"狂风，听我号令！",CardDbf.GetCardDbfByGuid("NEW1_010")).Resolve();
		new EffectEmote(owner.myPlayer,null,"元素增强！",CardDbf.GetCardDbfByGuid("GIL_119")).Resolve();
		new EffectEmote(owner.myPlayer,null,"暴走吧，奥拉基！",CardDbf.GetCardDbfByGuid("DAL_742")).Resolve();
	}
}


public class TMP_EDR_004:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		List<string> toCreate = new List<string>(){"TMP_EDR_004t1","TMP_EDR_004t2","TMP_EDR_004t3","TMP_EDR_004t4","TMP_EDR_004t5"};
		foreach(string s in toCreate)
		{
			TaskCreate(CardDbf.GetCardDbfByGuid(s),ZoneType.Hand);
		}
	}
}

public class TMP_EDR_004t1:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		new EffectGiveAbility(owner.myPlayer,owner,target,"Immue").Resolve();
		new EffectChange(owner.myPlayer,owner,target,atkChange:5,hpChange:5).Resolve();
	}
}
public class TMP_EDR_004t2:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		new EffectChange(owner.myPlayer,owner,target).Resolve();
		new EffectMove(owner.myPlayer,target,ZoneType.Board,ZoneType.Deck,toEn:true).Resolve();
	}
}
public class TMP_EDR_004t3:MinionBase
{
	public override void Init()
	{
		TaskInitAbility("Elusive");
	}
}
public class TMP_EDR_004t4:MinionBase
{

}
public class TMP_EDR_004t5:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),5);
	}

}

public class TMP_EDR_005:MinionBase
{
	public override void Init()
	{
		TaskInitAbility("Rush");
	}
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.raceType.Contains(RaceType.Beast) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer);
    }
    public override string AuraBuffName(Card c)
    {
        return "TMP_EDR_005e";
    }
}
public class TMP_EDR_005e:Ability
{    
	public override void RegisterEventEffect()
	{
		owner.ChangeTag(GameTag.DamageEff,1);
	}
	public override void UnRegisterEventEffect()
	{
		owner.ChangeTag(GameTag.DamageEff,-1);
	}
}

public class TMP_EDR_006:MinionBase
{    
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterDiscoverEnd(this,TMP_EDR_006CauseEvent));
    }
    public void TMP_EDR_006CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if (sc == owner)
        {
            new EffectMove(owner.myPlayer, tc, ZoneType.Aside, ZoneType.Hand).Resolve();
            //new EffectEmote(owner.myPlayer,owner,"冲锋吧，无界空宇！").Resolve();
        }
    }
    private List<string> ToListDiscover = new List<string>(){"GDB_142","GIL_820","TOY_501"};
    public override void Battlecry(Card target = null)
    {
    	new EffectEmote(owner.myPlayer,owner,"黑暗赠与你力量！").Resolve();
        List<Card> Op = new List<Card>();
        foreach (string s in this.ToListDiscover)
        {
            Op.Add(new Card(CardDbf.GetCardDbfByGuid(s), owner.myPlayer));
        }
        if(Op.Count>0)
        {
            new EffectDiscoverStart(owner.myPlayer,owner,Op).Resolve();
            new EffectEmote(owner.myPlayer,null,"冲锋吧，无界空宇！",owner.cardDbf).Resolve();
        }
    }
}



public class TMP_EDR_007:MinionBase
{    
	public override void Init()
	{
		TaskSetGolden();
		TaskInitAbility("DivineShieldPro");
		TaskInitAbility("Taunt");
	}

/*
    public override bool AuraActive()
    {
        return (owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board);
    }
    public override bool AuraBuffThis(Card c)
    {
        return (c.HasAbility("DivineShield") && (!c.HasAbility("DivineShieldPro")) &&c.GetTag(GameTag.ZoneType)==(int)ZoneType.Board && c.myPlayer==owner.myPlayer && c!=owner);
    }
    public override string AuraBuffName(Card c)
    {
        return "DivineShieldPro";
    }
*/
}



public class TMP_EDR_008:MinionBase
{
	public override void Battlecry(Card target=null)
	{
		new EffectEmote(owner.myPlayer,owner,"无限爆牌！").Resolve();
	}
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
				Card Created = TaskCreate(CardDbf.GetCardDbfByGuid("ETC_373t"),ZoneType.Board);
				Created.hateCard = sc;
				//if(sc.spellSchool.Contains(SpellSchoolType.N))
			}
		}
	}
}

public class TMP_EDR_009:MinionBase{
	public override void Init()
	{
		TaskInitAbility("Taunt");
		//TaskInitAbility("Elusive");
	}
	public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
    	if(amount>0)
    	{
    		TaskBuffMyHero(arm:1);
    		new EffectChange(owner.myPlayer,owner,owner,atkChange:1).Resolve();
    	}
    }
}

public class TMP_EDR_010:MinionBase
{
	public override void Init()
	{
		TaskInitAbility("Taunt");
	}
	private static int cnt=1;

	public override void Deathrattle()
	{
		for(int i=0;i<TMP_EDR_010.cnt;i++)
		{

			TaskCreate(CardDbf.GetCardDbfByGuid("BG27_017"),ZoneType.Board);
			//TaskCreate(CardDbf.AllBGSdragonDbf.Choice(owner.myPlayer.randomGen),ZoneType.Board);
		}
		//TMP_EDR_010.cnt+=1;
	}
}

public class TMP_EDR_011:MinionBase
{

	public override void Deathrattle()
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("FP1_009"),ZoneType.Board);
		TaskCreate(CardDbf.GetCardDbfByGuid("FP1_009"),ZoneType.Board);
	}
}

public class TMP_EDR_013:MinionBase
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
				new EffectEmote(owner.myPlayer,owner,"来我身边!").Resolve();
		        List<string> ToListSummon = new List<string>(){"NEW1_034"};//"NEW1_032","NEW1_033",
		        CardDbf ToSummon = CardDbf.GetCardDbfByGuid(ToListSummon.Choice(owner.myPlayer.randomGen));
		        TaskCreate(ToSummon,ZoneType.Board);
			}
		}
	}
}
public class TMP_EDR_014:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		new EffectMove(owner.myPlayer,target,ZoneType.Board,ZoneType.Hand).Resolve();
		TaskCreate(CardDbf.GetCardDbfByGuid("TMP_EDR_014t"),ZoneType.Board);
	}
}
public class TMP_EDR_014t:MinionBase
{
	public override void Init()
	{
		TaskInitAbility("Stealth");
	}
}
public class TMP_EDR_015:MinionBase
{

	public static List<CardDbf> Pool=new List<CardDbf>();
	
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,this.CauseEvent));
	}
	public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
	{
		if(sc==owner)
		{
			if(sz==ZoneType.Board && tz==ZoneType.Hand)
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
				TaskCreate(Pool.Choice(owner.myPlayer.randomGen),ZoneType.Board);
				TaskCreate(Pool.Choice(owner.myPlayer.randomGen),ZoneType.Board);
			}
		}
	}
}

public class TMP_EDR_017:WeaponBase
{
	public override void AfterAttack(Card target=null)
	{
		Card MaxCost = null;
		foreach(Card c in owner.myPlayer.deck)
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
			TaskDraw(MaxCost);
	}
}

public class TMP_EDR_016:MinionBase
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
				if(c.GetTag(GameTag.Mana)>MaxCost.GetTag(GameTag.Mana) && c.cardType==CardType.Spell)
				{
					MaxCost=c;
				}
			}
		}
		if(MaxCost!=null)
		{
			rem=MaxCost.cardDbf;
			new EffectMove(owner.myPlayer,MaxCost,ZoneType.Hand,ZoneType.Grave).Resolve();
			owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
		}

	}
	private int Cnt = 0;
	private CardDbf rem = null;
	private void CauseEvent()
	{
		if(Cnt<3)
		{
			Cnt+=1;
			new EffectEmote(owner.myPlayer,null,"无尽大军！",owner.cardDbf).Resolve();
			Card ToCast = TaskCreate(rem,ZoneType.Hand);
			new EffectPlay(owner.myPlayer,ToCast,owner.myPlayer.GetRandomTargetMatchOption(ToCast.cardDbf.Targets)).Resolve();
		}
	}
}

public class TMP_EDR_019:MinionBase{
    private bool on = false;
    public override void Battlecry(Card target = null)
    {

        base.Battlecry(target);
        on = true;
        foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
        {
            new EffectChange(owner.myPlayer,owner, c, -c.cardDbf.ManaCost, 0, 0, 0,visualFx:false).Resolve();
        }
        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,this.CauseEvent));

    }

    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,EX1_145CauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void CauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
    	if(on)
    	{
    		if(tz==ZoneType.Hand)
    			new EffectChange(owner.myPlayer,owner, sc, -sc.cardDbf.ManaCost, 0, 0, 0).Resolve();
    	}
    }
    public void EX1_145CauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if (on && sc!=owner)
        {
        	if(owner.myPlayer.otherPlayer.hero.Count>0)
        	{
        		new EffectEmote(owner.myPlayer,owner,"对手生命！").Resolve();
        		new EffectChange(owner.myPlayer,owner,owner.myPlayer.otherPlayer.hero[0],hpChange:-sc.cardDbf.ManaCost,visualFx:true).Resolve();
        	}
        	
            foreach (Card c in owner.myPlayer.hand.Merge(owner.myPlayer.deck))
            {
                if (c.cardType == CardType.Spell)
                {
                    new EffectChange(owner.myPlayer,owner, c, c.cardDbf.ManaCost, 0, 0, 0,visualFx:false).Resolve();
                }
            }
            on = false;
        }
    }
}

public class TMP_EDR_020:MinionBase
{
	public override void Init()
	{
		TaskInitAbility("WindFury");
	}
	private int Cnt=1;
	public override void BeforeAttack(Card target=null)
	{
		Cnt+=1;
	}
	public override void Deathrattle()
	{
		TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero),Cnt);
	}
}