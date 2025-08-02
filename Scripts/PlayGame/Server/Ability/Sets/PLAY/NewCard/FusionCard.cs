using System.Collections;
using System.Collections.Generic;


public class BOTA_BOSS_20p2:HeroPowerBase{
//NAME=卡牌融合
//TEXT=使一个友方随从和左边的随从融合。
//MAJ=NEUTRAL|COST=0|ATK=0|HP=0|RACE=NONE
	public override void Battlecry(Card target=null)
	{
		if(target!=null)
		{
			List<Card> ToFuse = new List<Card>();
			ToFuse.Add(target);
			int AliIndex = target.myPlayer.board.IndexOf(target)-1;
			if(AliIndex>=0)
			{
				ToFuse.Add(target.myPlayer.board[AliIndex]);
			}
			new EffectChange(owner.myPlayer,owner,targets:ToFuse).Resolve();

			foreach(Card c in ToFuse)
			{
				new EffectMove(owner.myPlayer,c,ZoneType.Board,ZoneType.Removed).Resolve();
			}
			
			TaskCreate(CardDbf.GetCardDbfByGuid("FUS_001"),ZoneType.Board);
		}
	}
}

public class FUS_001:MinionBase{
//炎魔之王拉格纳罗斯+风行者希尔瓦娜斯
	public override void RegisterEventEffect()
	{
		owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,this.CauseEvent));
	}
	public void CauseEvent()
	{
		if(owner.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
		{
			this.Deathrattle();
		}
	}
	public override void Deathrattle()
	{
        Card ToSteal = owner.myPlayer.otherPlayer.board.Choice(owner.myPlayer.randomGen);
        if(ToSteal!=null)
        {
        	new EffectChange(owner.myPlayer,owner,ToSteal).Resolve();
            new EffectMove(owner.myPlayer.otherPlayer,ToSteal,ZoneType.Board,ZoneType.Board,toEn:true).Resolve();
        }
		TaskDamageRandomEnemy(8);
	}
}


public class FUS_002:MinionBase{
//飞行员帕奇斯+火车王里诺埃
	public override void Battlecry(Card target=null)
	{
		for(int i=0;i<6;i++)
		{
			Card created = TaskCreate(CardDbf.GetCardDbfByGuid("FUS_002t"),ZoneType.Hand);
			new EffectMove(owner.myPlayer,created,ZoneType.Hand,ZoneType.Deck).Resolve();
		}
	}
}
public class FUS_002t:MinionBase{
//降落伞+火车王里诺埃
	public override void Init()
	{
		TaskInitAbility("CastWhenDrawn");
	}
	public override void Battlecry(Card target=null)
	{
		TaskCreate(CardDbf.GetCardDbfByGuid("EX1_116"),ZoneType.Board);
	}
}

public class FUS_003:MinionBase{
//炎魔之王+暴龙王
    public override void Init()
    {
        owner.SetTag(GameTag.AttacksForOneTurn,0);
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
        {
        	Card Summon = TaskCreate(CardDbf.GetCardDbfByGuid("EX1_543"),ZoneType.Board);
        	new EffectChange(owner.myPlayer,owner,Summon).Resolve();
        	Card Target = owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hero).Choice(owner.myPlayer.randomGen);
        	if(Target!=null)
        	{
        		new EffectAttack(owner.myPlayer,Summon,Target).Resolve();
        	}
        	new EffectMove(owner.myPlayer,Summon,ZoneType.Board,ZoneType.Grave).Resolve();
        }
    }
}
//public class FUS_003t:MinionBase{
//炎魔之王+暴龙王
//}