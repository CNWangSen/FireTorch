using System.Collections.Generic;

public class PVZ_001bp:HeroPowerBase
{
	private static List<string> ZombieSeeds = new List<string>(){"PVZ_001","PVZ_002","PVZ_003","PVZ_004","PVZ_005","PVZ_006","PVZ_007","PVZ_008"};
	public override void Battlecry(Card target=null)
	{
		CardDbf ToSummon = CardDbf.GetCardDbfByGuid(PVZ_001bp.ZombieSeeds.Choice(owner.myPlayer.randomGen));
		for(int i=0;i<1;i++)
		{
			TaskCreate(ToSummon,ZoneType.Board);
		}
	}
}

public class PVZ_001:Ability
{

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
            9999,3,
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
                new EffectEmote(owner.myPlayer,owner,"劈里啪啦").Resolve();
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
            if (owner.myPlayer.otherPlayer.hero.Count > 0)
            {
                new EffectDraw(owner.myPlayer).Resolve();
            }
        }
    
    }


    public virtual void InitDraw()
    {
       	new EffectDestroy(owner.myPlayer,owner,owner.myPlayer.power[0]).Resolve();
        new EffectEmote(owner.myPlayer,owner,"你好邻居").Resolve();
        TaskCreate(CardDbf.GetCardDbfByGuid("PVZ_001bp"),ZoneType.Power);
        //new EffectEmote(owner.myPlayer,null,"狩猎开始了！",owner.cardDbf).Resolve();
        owner.myPlayer.deck.Shuffle();
        int InitDrawNum = 3;
        int InitManaNum= 0;

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

public class PVZ_002:MinionBase
{

}





public class PVZ_003:MinionBase
{

}

public class PVZ_004:MinionBase
{

}

public class PVZ_005:MinionBase
{

}

public class PVZ_006:MinionBase
{

}

public class PVZ_007:MinionBase
{

}

public class PVZ_008:MinionBase
{

}