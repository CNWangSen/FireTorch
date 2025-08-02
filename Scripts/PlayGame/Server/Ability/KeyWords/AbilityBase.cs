using System.Collections.Generic;
using System;

public class AutoChessMinionBase : Ability
{
    public override void AfterMakeDamage(Card target = null, int amount = 0)
    {
        int rawEnergy = owner.GetTag(GameTag.Energy);
        int targetEnergy = rawEnergy+amount;
        if(targetEnergy>10)
        {
            targetEnergy=10;
        }
        int diff = targetEnergy-rawEnergy;
        if(diff>10)
        {
            diff=10;
        }
        new EffectChange(owner.myPlayer,owner,owner,engChange:diff,visualFx:false).Resolve();
    }
    public override void AfterTakeDamage(Card source = null, int amount = 0)
    {
        int rawEnergy = owner.GetTag(GameTag.Energy);
        int targetEnergy = rawEnergy+amount;
        if(targetEnergy>10)
        {
            targetEnergy=10;
        }
        int diff = targetEnergy-rawEnergy;
        if(diff>10)
        {
            diff=10;
        }
        new EffectChange(owner.myPlayer,owner,owner,engChange:diff,visualFx:false).Resolve();
    }
    public override void BeforeAttack(Card target=null)
    {
        if(owner.GetTag(GameTag.Energy)==10)
        {
            new EffectChange(owner.myPlayer,owner,owner,engChange:-10,visualFx:false).Resolve();
            this.BIG();
        }
        
    }
    public virtual void BIG()
    {
        int amount = 3;
        if(owner.cardDbf.m_noteMiniGuid.Contains("H_02"))
        {
            amount=6;
        }
        else if(owner.cardDbf.m_noteMiniGuid.Contains("H_03")){
            amount=12;
        }
        TaskDamageRandomEnemyMinion(amount);
        owner.SetTag(GameTag.IsCanceled,1);
    }
}
public class MercenaryBase : Ability
{
    public List<string> m_powers = new List<string>();
    public override void RegisterEventEffect()
    {

        owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,MercenaryActiveCauseEvent));
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,MercenaryActiveCauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        owner.myPlayer.RemoveCallBackOf(this);
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public virtual void MercenaryActiveCauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
    {
        if (sc == owner)
        {
            if (tz == ZoneType.Board)
            {
                foreach (string s in this.m_powers)
                {
                    new EffectGiveAttachment(owner.myPlayer, owner, owner, new Card(CardDbf.GetCardDbfByGuid(s),owner.myPlayer)).Resolve();
                }
            }
        }
    }
}

public class PlayModeHeroBase : Ability
{
    public bool IsDQQ=true;
    public override void Init()
    {
        //owner.myPlayer.myGame.m_Mode=GameMode.WildPlay;
    }
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,StartTurn));
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,EndTurn));
        owner.myPlayer.AddCallBack(new CallBackAfterGameStart(this,InitDraw));
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,CopyCard));
        owner.myPlayer.maxnum = new List<int>
        {
            999,11,7,99999,
            5,2,2,1,
            9999,3,7,
            4,4,3,
        };
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
        owner.myPlayer.RemoveCallBackOf(this);
        owner.myPlayer.RemoveCallBackOf(this);
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public override void AfterTakeDamage(Card source,int amount)
    {
        if(owner.myPlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            if(owner.GetTag(GameTag.Health)<=0)
                new EffectEmote(owner.myPlayer,owner,"你赢了！").Resolve();
            //new GameOverCommand().AddToQueue();  
        }
    }
    public override void Deathrattle()
    {
        if(owner.myPlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            //new EffectEmote(owner.myPlayer,owner,"打得好，我认输").Resolve();
            new GameOverCommand().AddToQueue();  
        }
    }
    private List<string> m_card = new List<string>();
    public void CopyCard(Card sourceCard, Card targetCard, ZoneType sourceZone, ZoneType targetZone)
    {
    }
    public virtual void EndTurn()
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {
            new EffectChange(owner.myPlayer,owner, owner, 0, -owner.GetTag(GameTag.Attack) + owner.cardDbf.Attack, 0, 0,visualFx:false).Resolve();
        }
    }
    public virtual void StartTurn()
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {
            owner.myPlayer.SetTag(GameTag.ManaThisTurn,owner.myPlayer.GetTag(GameTag.ManaThisTurn)+1);
            owner.myPlayer.SetTag(GameTag.ManaLeft,owner.myPlayer.GetTag(GameTag.ManaThisTurn));
            owner.myPlayer.SetTag(GameTag.ManaLeft,owner.myPlayer.GetTag(GameTag.ManaLeft)-owner.myPlayer.GetTag(GameTag.ManaOverLoad));
            owner.myPlayer.SetTag(GameTag.ManaOverLoad,0);
            TaskBuffMyHero();
            if (owner.myPlayer.otherPlayer.hero.Count > 0 && !this.IsDQQ)
            {
                new EffectDraw(owner.myPlayer).Resolve();
            }
        }
    
    }


    public virtual void InitDraw()
    {
        new EffectEmote(owner.myPlayer,owner,"狩猎开始了！").Resolve();
        //new EffectEmote(owner.myPlayer,null,"狩猎开始了！",owner.cardDbf).Resolve();
        //owner.myPlayer.deck.Shuffle();
        int InitDrawNum = 3;
        int InitManaNum= 10;
        bool DQQmode=false;
        this.IsDQQ=DQQmode;
        //TaskCreate(CardDbf.GetCardDbfByGuid("SGS_990013"),ZoneType.Hand);

        if(owner.myPlayer.GetTag(GameTag.IsControledByAI)==0)
        {
            //InitDrawNum=0;
            //InitManaNum=10;
            //TaskCreate(CardDbf.GetCardDbfByGuid("BOTA_BOSS_20p2"),ZoneType.Power);

            if(DQQmode)
            {
                
                TaskCreate(CardDbf.GetCardDbfByGuid("KAR_028"),ZoneType.Weapon);
                new EffectChange(owner.myPlayer,owner,owner,atkChange:-3).Resolve();
                //owner.myPlayer.hero[0].PropertyArr[(int)GameTag.AttackMod]=0;
                owner.myPlayer.hero[0].SetTag(GameTag.AttacksLeftThisTurn,99999);
                InitDrawNum=0;
                InitManaNum=10;
                List<string> DECK = new List<string>();
                switch (owner.myPlayer.hero[0].cardDbf.Classes[0])
                {
                    case(ClassType.DeathKnight):
                        DECK = new List<string>(){"RLK_035","RLK_709"};
                        break;
                    case(ClassType.DemonHunter):
                        DECK = new List<string>(){"BT_235","BT_514","RLK_209"};
                        break;
                    case(ClassType.Druid):
                        DECK = new List<string>(){"FP1_019","CS2_012"};
                        break;
                    case(ClassType.Hunter):
                        DECK = new List<string>(){"CS2_084","CS2_084","CS2_084","CS2_084","CS2_084","CS2_084","CS2_084"};
                        break;
                    case(ClassType.Mage):
                        DECK = new List<string>(){"AV_218"};
                        break;
                    case(ClassType.Paladin):
                        DECK = new List<string>(){"EX1_619"};
                        break;
                    case(ClassType.Priest):
                        DECK = new List<string>(){"CFM_661","CFM_661","AT_016","ICC_802"};
                        break;
                    case(ClassType.Rogue):
                        DECK = new List<string>(){"CS2_074","CS2_074","CS2_074","CS2_233"};
                        break;
                    case(ClassType.Shaman):
                        DECK = new List<string>(){"ULD_181"};
                        break;
                    case(ClassType.Warlock):
                        DECK = new List<string>(){"TTN_463","GDB_128"};
                        break;
                    case(ClassType.Warrior):
                        DECK = new List<string>(){"EX1_400","CFM_716","CFM_716"};
                        break;
                    default:
                        break;
                }
                
                for(int i=0;i<DECK.Count;i++)
                {
                    //TaskCreate(CardDbf.GetCardDbfByGuid(DECK[i]),ZoneType.Hand);
                }
                foreach(Card c in owner.myPlayer.hand)
                {
                    if(c.classes.Contains(ClassType.Neutral))
                    {
                        //new EffectChange(owner.myPlayer,owner,c,manaChange:1).Resolve();
                    }
                }

                if(owner.cardDbf.m_noteMiniGuid.Contains("HERO_10"))
                {
                    //TaskCreate(CardDbf.GetCardDbfByGuid("BAR_891t2"),ZoneType.Hand);//无中生有            
                }

                //TaskCreate(CardDbf.GetCardDbfByGuid("SC_008"),ZoneType.Hand);//无中生有
            }
            
            
        }
        else{
 
            if(DQQmode)
            {
                new EffectDestroy(owner.myPlayer,owner,owner.myPlayer.power[0]).Resolve();
                TaskCreate(CardDbf.GetCardDbfByGuid("CORE_tt_004"),ZoneType.Hero);
                new EffectMove(owner.myPlayer,owner,ZoneType.Hero,ZoneType.Grave).Resolve();
                InitDrawNum=0;
                InitManaNum=0;
                //owner.myPlayer.SetTag(GameTag.CntJadeGolem,8);
                //TaskBuffMyHero(arm:10000);
                for(int i=0;i<0;i++)
                {
                    TaskCreate(CardDbf.GetCardDbfByGuid("SC_006"),ZoneType.Board);
                    
                }
                //TaskCreate(CardDbf.GetCardDbfByGuid("CS2_127"),ZoneType.Board);
                for(int i=0;i<3;i++)
                {
                    TaskCreate(CardDbf.GetCardDbfByGuid("ICC_900t"),ZoneType.Board);
                    
                }     

                for(int i=0;i<7;i++)
                {
                    TaskCreate(CardDbf.GetCardDbfByGuid("ICC_900t"),ZoneType.Deck);
                    
                }
            }
        }


        owner.myPlayer.SetTag(GameTag.ManaThisTurn,InitManaNum);
        //CardDbf TestDbf = CardDbf.GetCardDbfByGuid("BARL_015H_03");
        //new EffectCreate(owner.myPlayer, new Card(TestDbf, owner.myPlayer), ZoneType.Board).Resolve();
        
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {
            
            for (int i = 0; i < InitDrawNum; i++)
            {
                new EffectDraw(owner.myPlayer).Resolve();
            }

            if (owner.myPlayer.GetTag(GameTag.GoFirst)==0)
            {
                new EffectDraw(owner.myPlayer).Resolve();
                Card Coin = new Card(CardDbf.GetCardDbfByGuid("GAME_005"), owner.myPlayer);
                new EffectCreate(owner.myPlayer, Coin, ZoneType.Hand).Resolve();
                new EffectEmote( owner.myPlayer, null,"后手获得幸运币",Coin.cardDbf).Resolve();
            }
        }
    }
    public override void TakeDamage(Card source = null, int amount = 0)
    {
    }

    public override void BeforeAttack(Card target = null)
    {
        base.BeforeAttack(target);
        for (int i = owner.myPlayer.weapon.Count - 1; i >= 0; i--)
        {
            Card weap = owner.myPlayer.weapon[i];
            for (int j = weap.abilityList.Count - 1; j >= 0; j--)
            {
                weap.abilityList[j].BeforeAttack(target);
            }
        }
    }
}


public class SC_762:MinionBase{
//NAME=鱼人宝宝
//TEXT=
//MAJ=NEUTRAL|COST=0|ATK=1|HP=1|RACE=MURLOC
    public int Remember=0;
    public override void RegisterEventEffect()
    {
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackBeforePlay(this,this.CauseEventBeforeCard));
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterPlay(this,this.CauseEventCard));
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterUseHeroPower(this,this.CauseEventPower));
    }
    public override void UnRegisterEventEffect()
    {
        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
    }
    public void CauseEventBeforeCard(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        this.Remember=sc.GetTag(GameTag.Mana);
        if(this.Remember<0)
        {
            this.Remember=0;
        }
    }
    public bool IsScoreCard(Card c){
        if(c.cardDbf.m_noteMiniGuid=="SC_008")
        {
            return false;
        }
        return true;
    }
    public void CauseEventCard(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(IsScoreCard(sc))
        {
            new EffectChange(owner.myPlayer,owner,owner.myPlayer.otherPlayer.hero[0],hpChange:-this.Remember-2).Resolve();
            //TaskDamageEnemyHero(this.Remember+2);
        }
    }
    public void CauseEventPower(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(IsScoreCard(sc))
        {
            new EffectChange(owner.myPlayer,owner,owner.myPlayer.otherPlayer.hero[0],hpChange:-sc.GetTag(GameTag.Mana)).Resolve();
            //TaskDamageEnemyHero(sc.GetTag(GameTag.Mana));
        }
    }
}

public class HeroBase:PlayModeHeroBase
{

}
public class HeroPowerBase:Ability
{
    public override void Init()
    {
        base.Init();
        new EffectGiveAbility(owner.myPlayer,owner,owner,"Charge",createVfx:false).Resolve();
    }
}

public class MinionBase:Ability
{

}

public class SpellBase:Ability
{

}
public class LocationBase:Ability
{

}
public class SecretBase:Ability
{
	
}

public class WeaponBase:Ability
{
	public Card AttachedTo=null;
	public override void Battlecry(Card target=null)
	{
		if (owner.myPlayer.hero.Count > 0)
		{
			AttachedTo = owner.myPlayer.hero[0];
			//AttachedTo.SetTag(GameTag.AttacksForOneTurn, owner.GetTag(GameTag.AttacksForOneTurn));
            //if(AttachedTo.GetTag(GameTag.AttacksLeftThisTurn))
			//AttachedTo.SetTag(GameTag.AttacksLeftThisTurn, owner.GetTag(GameTag.AttacksForOneTurn));
		}
	}
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,OpenWeapon));
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,CloseWeapon));
		owner.myPlayer.AddCallBack(new CallBackAfterAttack(this,AfterHeroAttack));
		owner.myPlayer.AddCallBack(new CallBackAfterCreate(this,WeaponActiveCauseEvent));
		owner.myPlayer.AddCallBack(new CallBackAfterMove(this,WeaponActiveCauseEvent));
	}

	public virtual void WeaponActiveCauseEvent(Card sc, Card tc, ZoneType sz, ZoneType tz)
	{
		if (sc==owner && owner.myPlayer.hero.Count>0 )
		{
			Game mGame = owner.myPlayer.myGame;
			if(mGame.PlayersInGame[mGame.GetTag(GameTag.NowPlayingIndex)] != owner.myPlayer)
			{
				return;
			}
			if (tz == ZoneType.Weapon)
			{
				new EffectChange(owner.myPlayer,owner, owner.myPlayer.hero[0], 0, owner.GetTag(GameTag.Attack) , 0, 0 , visualFx: false).Resolve();
			}
			if (sz == ZoneType.Weapon && tz == ZoneType.Grave)
			{
				new EffectChange(owner.myPlayer,owner, owner.myPlayer.hero[0], 0, -owner.GetTag(GameTag.Attack) , 0, 0, visualFx: false).Resolve();
			}
		}
	}

	public virtual void AfterHeroAttack(Card sc, Card tc, ZoneType sz, ZoneType tz)
	{
		if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Weapon && owner.myPlayer.hero.Count > 0)
		{
			if (sc == owner.myPlayer.hero[0])
			{
				new EffectChange(owner.myPlayer,owner,owner,0,0,-1,0, visualFx: false).Resolve();
			}
		}

	}
	public virtual void OpenWeapon()
	{
		if((ZoneType)owner.GetTag(GameTag.ZoneType)==ZoneType.Weapon && owner.myPlayer.hero.Count>0)
			new EffectChange(owner.myPlayer,owner, owner.myPlayer.hero[0], 0, owner.GetTag(GameTag.Attack) ,0,0, visualFx: false).Resolve();
	}
	public virtual void CloseWeapon()
	{
		//if((ZoneType)owner.GetTag(GameTag.ZoneType)==ZoneType.Weapon)
		//	new EffectChange(owner.myPlayer,owner, owner.myPlayer.hero[0], 0,-owner.GetTag(GameTag.Attack) ,0,0).Resolve();
	}

}





public class Icon: Ability
{
    private List<string> m_card = new List<string>();
    public void CopyCard(Card sourceCard, Card targetCard, ZoneType sourceZone, ZoneType targetZone)
    {
    }

    public override void Deathrattle()
    {
        if(owner.myPlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            new GameOverCommand().AddToQueue();  
        }
    }
    public override void RegisterEventEffect()
    {
        //HBFSNode.MaxIters=1000;
        //HBFSNode.EarlyOutIters=100;
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,StartTurn));
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,EndTurn));
        owner.myPlayer.AddCallBack(new CallBackAfterGameStart(this,InitDraw));
        owner.myPlayer.AddCallBack(new CallBackAfterPlay(this,CopyCard));
    }


    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void InitDraw()
    {
        bool IsLower = false;
        if(owner.myPlayer.GetTag(GameTag.PlayerID) == (int)GameTag.LowPlayerID)
        {
            IsLower = true;
        }

        owner.myPlayer.SetTag(GameTag.ManaThisTurn,10);
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {   
            int InitDrawNum = UnityEngine.Mathf.Min(owner.myPlayer.deck.Count, 10);
            for (int i = 0; i < InitDrawNum; i++)
            {
                new EffectCreate(owner.myPlayer, new Card(owner.myPlayer.deck[i].cardDbf, owner.myPlayer), ZoneType.Hand).Resolve();
            }
        }

        for (int i = 0; i < owner.myPlayer.deck.Count; i++)
        {
            if (i >= 8) 
            {
                break;
            }
            if (owner.myPlayer.deck[i].cardType == CardType.Minion)
            {
                if(IsLower)
                {

                }
                else{
                    Card CreatedCard = new Card(owner.myPlayer.deck[i].cardDbf, owner.myPlayer);
                    new EffectCreate(owner.myPlayer,CreatedCard, ZoneType.Board).Resolve();                    
                }
            }

        }

    }
    public virtual void StartTurn()
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {
            owner.myPlayer.SetTag(GameTag.ManaThisTurn,owner.myPlayer.GetTag(GameTag.ManaThisTurn)+1);
            owner.myPlayer.SetTag(GameTag.ManaLeft,owner.myPlayer.GetTag(GameTag.ManaThisTurn));
            owner.myPlayer.SetTag(GameTag.ManaLeft,owner.myPlayer.GetTag(GameTag.ManaLeft)-owner.myPlayer.GetTag(GameTag.ManaOverLoad));
            owner.myPlayer.SetTag(GameTag.ManaOverLoad,0);
        }

        if(owner.myPlayer.hero.Count>0)
            owner.myPlayer.hero[0].SetTag(GameTag.AttacksLeftThisTurn, 0);
        //owner.myPlayer.SetTag(GameTag.ManaThisTurn, 10);
        //owner.myPlayer.SetTag(GameTag.ManaLeft, 10);
        //new EffectDraw(owner.myPlayer).Resolve();
    }
    public virtual void EndTurn()
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {
            new EffectChange(owner.myPlayer,owner, owner, 0, -owner.GetTag(GameTag.Attack) + owner.cardDbf.Attack, 0, 0,visualFx:false).Resolve();
        }
    }

    public override void TakeDamage(Card source = null, int amount = 0)
    {

    }

    public override void BeforeAttack(Card target = null)
    {
        base.BeforeAttack(target);
        for (int i = owner.myPlayer.weapon.Count - 1; i >= 0; i--)
        {
            Card weap = owner.myPlayer.weapon[i];
            for (int j = weap.abilityList.Count - 1; j >= 0; j--)
            {
                weap.abilityList[j].BeforeAttack(target);
            }
        }
    }
}

public class TestHis:Icon{}
public class TestMy:Icon{}

