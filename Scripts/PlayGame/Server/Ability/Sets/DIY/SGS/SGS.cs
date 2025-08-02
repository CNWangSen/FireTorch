using System;
using System.Collections.Generic;

public class SGS_990001:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.otherPlayer.board.Count==0)
		{
			Card Target = owner.myPlayer.otherPlayer.hand.Choice(owner.myPlayer.randomGen);
			if(Target!=null)
				new EffectMove(owner.myPlayer.otherPlayer,Target,ZoneType.Hand,ZoneType.Hand,toEn:true).Resolve();
		}
	}
}
public class SGS_990002:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		Card Target = owner.myPlayer.otherPlayer.hand.Choice(owner.myPlayer.randomGen);
		if(Target!=null)
			new EffectMove(owner.myPlayer.otherPlayer,Target,ZoneType.Hand,ZoneType.Grave).Resolve();
	}
}
public class SGS_990003:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		if(CondHasHero())
			new EffectDamage(owner.myPlayer,owner,target,5+owner.myPlayer.hero[0].GetTag(GameTag.Attack)).Resolve();
	}
}
public class SGS_990004:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		TaskHealMyHero(5);
	}
}
public class SGS_990005:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(atk:5);
	}
}
public class SGS_990006:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		TaskBuffMyHero(arm:10);
	}
}
public class SGS_990007:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		TaskDamageEnemyHero(6);
	}
}
public class SGS_990008:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		TaskDamageTargets(owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero).Merge(owner.myPlayer.board),3);
	}
}
public class SGS_990009:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		List<Card> Targets=owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board);
	    List<int> dmgs=new List<int>();
        foreach(Card c in Targets)
        {
            dmgs.Add(-1);
        }
        new EffectChange(owner.myPlayer,owner,targets:Targets,atkChanges:dmgs).Resolve();
	}
}
public class SGS_990010:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		List<Card> Targets=owner.myPlayer.board.Merge(owner.myPlayer.otherPlayer.board);
	    List<int> dmgs=new List<int>();
        foreach(Card c in Targets)
        {
            dmgs.Add(4);
        }
        new EffectHeal(owner.myPlayer,owner,targets:Targets,amounts:dmgs).Resolve();
	}
}
public class SGS_990011:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		new EffectDraw(owner.myPlayer).Resolve();
		new EffectDraw(owner.myPlayer.otherPlayer).Resolve();
	}
}
public class SGS_990012:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		if(owner.myPlayer.otherPlayer.hero.Count>0)
			new EffectAttack(owner.myPlayer,target,owner.myPlayer.otherPlayer.hero[0]).Resolve();
	}
}
public class SGS_990013:SpellBase
{
	public override void Battlecry(Card target=null)
	{
		new EffectDraw(owner.myPlayer).Resolve();
		new EffectDraw(owner.myPlayer).Resolve();
	}
}