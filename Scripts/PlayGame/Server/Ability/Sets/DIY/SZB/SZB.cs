using System.Collections;
using System.Collections.Generic;

public class SZB_123441010:MinionBase
{
	public override void Init()
	{
		new EffectGiveAbility(owner.myPlayer,owner,owner,"Poisonous",createVfx:false).Resolve();
	}
	public override void Battlecry(Card target =null)
	{
		new EffectDamage(owner.myPlayer,owner,target,1).Resolve();
	}
}
public class SZB_124441010:MinionBase
{
	public override void Battlecry(Card target =null)
	{
		if(owner.myPlayer.hero.Count>0)
			new EffectHeal(owner.myPlayer,owner,owner.myPlayer.hero[0],3).Resolve();
		new EffectCreate(owner.myPlayer, new Card(CardDbf.GetCardDbfByGuid("SZB_900444060"), owner.myPlayer), ZoneType.Hand).Resolve();
	}
}
public class SZB_900444060:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		TaskDamageRandomEnemyMinion(5);
	}
}
public class SZB_125441020:MinionBase
{
	public override void Battlecry(Card target=null)
	{
		owner.myPlayer.ChangeTag(GameTag.ManaLeft,2);
		Card Target = owner.myPlayer.otherPlayer.board.Choice(owner.myPlayer.randomGen);
		if(Target!=null)
		{
			new EffectDestroy(owner.myPlayer,owner,Target).Resolve();
		}
		
	}
}
public class SZB_100414010:SpellBase
{
	public override void Battlecry(Card target =null)
	{
		owner.myPlayer.ChangeTag(GameTag.ManaThisTurn,1);
	}
}
public class SZB_124414010:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		if(target!=owner)
		{
			new EffectMove(owner.myPlayer,target,ZoneType.Hand,ZoneType.Grave).Resolve();
			new EffectDraw(owner.myPlayer).Resolve();
			for(int i = 0;i<2;i++)
			{
				TaskDamageRandomEnemyMinion(4);
			}			
		}
	}
}
public class SZB_126421020:MinionBase{
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,CauseEvent1));
        owner.myPlayer.AddCallBack(new CallBackAfterMove(this,CauseEvent2));
    }
    public void CauseEvent1()
    {
        if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
        {
        	if(owner.myPlayer.hero.Count>0)
            	new EffectHeal(owner.myPlayer,owner,owner.myPlayer.hero[0],2).Resolve();          
        }
    }
    public void CauseEvent2(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc==owner && tz==ZoneType.Grave && sz==ZoneType.Hand)
        {
        	new EffectCreate(owner.myPlayer, new Card(owner.cardDbf, owner.myPlayer), ZoneType.Board).Resolve();
        }
    }
}
public class SZB_125411010:MinionBase
{
	public override void Init()
	{
		new EffectGiveAbility(owner.myPlayer,owner,owner,"Charge",createVfx:false).Resolve();
		new EffectGiveAbility(owner.myPlayer,owner,owner,"Poisonous",createVfx:false).Resolve();
	}
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.GetTag(GameTag.ManaThisTurn)>=7)
		{
			new EffectCreate(owner.myPlayer, new Card(owner.cardDbf, owner.myPlayer), ZoneType.Board).Resolve();
		}
	}
}

public class SZB_124424010:MinionBase
{
	public override void Battlecry(Card target=null)
	{
		CardDbf db=CardDbf.GetCardDbfByGuid("SZB_900411030");
		Card M1 = new Card(db,owner.myPlayer);
		Card M2 = new Card(db,owner.myPlayer);
		Card M3 = new Card(db,owner.myPlayer);
		new EffectGiveAbility(owner.myPlayer,owner,M1,"Charge",createVfx:false).Resolve();
		new EffectGiveAbility(owner.myPlayer,owner,M2,"Taunt",createVfx:false).Resolve();
		new EffectGiveAbility(owner.myPlayer,owner,M3,"Poisonous",createVfx:false).Resolve();
		new EffectCreate(owner.myPlayer, M1, ZoneType.Board).Resolve();
		new EffectCreate(owner.myPlayer, M2, ZoneType.Board).Resolve();
		new EffectCreate(owner.myPlayer, M3, ZoneType.Board).Resolve();
	}	
}
