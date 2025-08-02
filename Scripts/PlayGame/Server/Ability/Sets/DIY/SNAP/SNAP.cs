using System.Collections.Generic;

public class SNAP_Hero:Ability
{
	public override void RegisterEventEffect()
	{
		Game.NowGame.m_Mode = GameMode.MarvelSnap;
        owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,StartTurn));
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,EndTurn));
        owner.myPlayer.AddCallBack(new CallBackAfterGameStart(this,InitDraw));

        owner.myPlayer.maxnum = new List<int>
        {
            999,11,4,99999,
            5,2,2,1,
            9999,3,7,
            4,4,3,
        };
	}

	public void InitDraw()
	{
	    if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {  
	        for (int i = 0; i < 3; i++)
	        {
	            new EffectDraw(owner.myPlayer).Resolve();
	        }
        }
	}

    public void StartTurn()
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {
            owner.myPlayer.SetTag(GameTag.ManaThisTurn,owner.myPlayer.GetTag(GameTag.ManaThisTurn)+1);
            owner.myPlayer.SetTag(GameTag.ManaLeft,owner.myPlayer.GetTag(GameTag.ManaThisTurn));
            owner.myPlayer.SetTag(GameTag.ManaLeft,owner.myPlayer.GetTag(GameTag.ManaLeft)-owner.myPlayer.GetTag(GameTag.ManaOverLoad));
            owner.myPlayer.SetTag(GameTag.ManaOverLoad,0);
            TaskBuffMyHero();
        	if(owner.myPlayer.deck.Count>0)
				new EffectDraw(owner.myPlayer).Resolve();
        }
    }

    public void EndTurn()
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {
            new EffectChange(owner.myPlayer,owner, owner, 0, -owner.GetTag(GameTag.Attack) + owner.cardDbf.Attack, 0, 0,visualFx:false).Resolve();
        }
    }

}
public class SNAP_880000:MinionBase
{
	public override int AfterGetTag(GameTag tg)
	{
		if(tg==GameTag.AttackMod)
		{
			return owner.myPlayer.hand.Count*2;
		}
		if(tg==GameTag.HealthMod)
		{
			return owner.myPlayer.hand.Count*2;
		}
		return 0;
	}
}

public class SNAP_880001:MinionBase
{
	public override void Battlecry(Card target=null)
	{
		Card ToMove = null;
		foreach(Card c in owner.myPlayer.deck)
		{
			if(c.cardType==CardType.Minion)
			{
				ToMove=c;
				break;
			}
		}
		if(ToMove!=null)
		{
			new EffectChange(owner.myPlayer,owner,ToMove).Resolve();
			new EffectMove(owner.myPlayer,ToMove,ZoneType.Deck,ZoneType.Board).Resolve();
		}
	}
}