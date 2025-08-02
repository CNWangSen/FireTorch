using System.Collections.Generic;

public class CallBackAfterBothTurnStart:UnitEffectCallBack
{
    public delegate void EventAfterBothTurnStart();
    public event EventAfterBothTurnStart myEv;
    public CallBackAfterBothTurnStart(Ability SourceAbility, EventAfterBothTurnStart Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve()
    {
        this.myEv.Invoke();
    }
}

public class EffectBothTurnStart:UnitEffect
{
    private Game G;
	public EffectBothTurnStart(Game game)
	{
        this.G = game;
	}
	public override void Resolve()
	{
        UnityEngine.Debug.Log("BothTurnStart");
        for(int j=0;j<this.G.PlayersInGame.Count;j++)
        {
            Player p = this.G.PlayersInGame[j];

            List<Card> Po = p.hero.Merge(p.board).Merge(p.power);
            foreach(Card c in p.board)
            {
                foreach(Card cp in c.attachmentList)
                {
                    Po.Add(cp);
                }
            }
            for (int i= Po.Count-1; i>=0 ;i--)
            {
                Po[i].SetTag(GameTag.IsAwake, 1);
                Po[i].SetTag(GameTag.AttacksLeftThisTurn,Po[i].GetTag(GameTag.AttacksForOneTurn));
            }
            for(int i = p.EffectCallBacks.Count-1;i>=0;i--)
            {
                if(p.EffectCallBacks[i] is CallBackAfterTurnStart)
                {
                    p.EffectCallBacks[i].Resolve(); 
                }
            }
            p.SetTag(GameTag.NowTurnNum,this.SourcePlayer.GetTag(GameTag.NowTurnNum)+1);
            p.SetTag(GameTag.IsPlayerTurnEnd,0);        
        }

	}
}