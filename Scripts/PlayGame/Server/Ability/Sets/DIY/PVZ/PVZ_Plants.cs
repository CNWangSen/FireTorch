using System.Collections.Generic;

public class PVZ_000bp:HeroPowerBase{
	private static List<string> PlantSeeds = new List<string>(){"PVZ_101","PVZ_102","PVZ_103","PVZ_104","PVZ_105","PVZ_106","PVZ_107","PVZ_108"};
	public override void Battlecry(Card target=null)
	{
		new EffectChange(owner.myPlayer,owner,owner).Resolve();
		TaskCreate(CardDbf.GetCardDbfByGuid(PVZ_000bp.PlantSeeds.Choice(owner.myPlayer.randomGen)),ZoneType.Hand);
	}
}

public class PVZ_103:MinionBase{


}

public class PVZ_101:MinionBase
{
	public override void RegisterEventEffect(){
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	private void CauseEvent()
	{
		if(CondInPlay())
		{
			new EffectChange(owner.myPlayer,owner,owner).Resolve();
			TaskCreate(CardDbf.GetCardDbfByGuid("PVZ_101t"),ZoneType.Hand);
		}
	}
}
public class PVZ_101t:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		owner.myPlayer.ChangeTag(GameTag.ManaLeft,1);
		TaskBuffMyHero();
	}
}

public class PVZ_102:MinionBase
{
	public override void RegisterEventEffect(){
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	private void CauseEvent()
	{
		if(CondInPlay())
		{
            float minx = -11.86f;
            float maxx = 11.21f;
            float cx = (minx + maxx) / 2f;
            float bw = (maxx - minx);
            float c1 = -bw / 12f;
            float c2 = bw / 6f;

            int myindex = owner.myPlayer.board.IndexOf(owner);
            int myN = owner.myPlayer.board.Count;
            int enN = owner.myPlayer.otherPlayer.board.Count;
            float myx= cx + c1 * (myN - 1) + c2 * myindex;
            bool blocked = false;
            float colw =2f;
            List<Card> ToDmg = new List<Card>();
            List<int> Dmgs = new List<int>();
            for (int i = 0; i < enN; i++)
            {
                float newx = cx + c1 * (enN - 1) + c2 * i;
                float offset = newx - myx;


                if (offset<colw && offset>-colw)
                {
                	ToDmg.Add(owner.myPlayer.otherPlayer.board[i]);
                    Dmgs.Add(2);
                    blocked = true;
                    break;
                }
            }

            if (!blocked)
            {
            	ToDmg.Add(owner.myPlayer.otherPlayer.hero[0]);
            	Dmgs.Add(2);
                //new EffectDamage(owner.myPlayer,owner, owner.myPlayer.otherPlayer.hero[0], 2).Resolve();
            }

            new EffectDamage(owner.myPlayer,owner,targets:ToDmg,amounts:Dmgs).Resolve();
		}
	}
}



public class PVZ_000:Ability
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
                new EffectEmote(owner.myPlayer,owner,"哇啊啊啊").Resolve();
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
        new EffectEmote(owner.myPlayer,owner,"外比八布").Resolve();
        TaskCreate(CardDbf.GetCardDbfByGuid("PVZ_000bp"),ZoneType.Power);
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

