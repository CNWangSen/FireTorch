using System.Collections.Generic;

public class CallBackAfterTurnStart:UnitEffectCallBack
{
    public delegate void EventAfterTurnStart();
    public event EventAfterTurnStart myEv;
    public CallBackAfterTurnStart(Ability SourceAbility, EventAfterTurnStart Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve()
    {
        this.myEv.Invoke();
    }
}

public class EffectTurnStart:UnitEffect
{

	public EffectTurnStart(Player srcPlayer)
	{
        this.SourcePlayer = srcPlayer;
	}
	public override void Resolve()
	{
        UnityEngine.Debug.Log("TurnStart");
        List<Card> Po = this.SourcePlayer.hero.Merge(this.SourcePlayer.board).Merge(this.SourcePlayer.power);
        foreach(Card c in this.SourcePlayer.board)
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
        for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
        {
            if(this.SourcePlayer.EffectCallBacks[i] is CallBackAfterTurnStart)
            {
                this.SourcePlayer.EffectCallBacks[i].Resolve(); 
            }
        }
        this.SourcePlayer.SetTag(GameTag.NowTurnNum,this.SourcePlayer.GetTag(GameTag.NowTurnNum)+1);
        this.SourcePlayer.SetTag(GameTag.IsPlayerTurnEnd,0);   

        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer) == 0)
        {
            new RestoreHeroButtonCommand(this.SourcePlayer.GetTag(GameTag.PlayerID)).AddToQueue();
        }
	}
}