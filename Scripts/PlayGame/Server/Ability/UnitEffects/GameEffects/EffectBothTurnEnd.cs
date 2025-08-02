using System.Collections.Generic;

public class CallBackAfterBothTurnEnd:UnitEffectCallBack
{
    public delegate void EventAfterBothTurnEnd();
    public event EventAfterBothTurnEnd myEv;
    public CallBackAfterBothTurnEnd(Ability SourceAbility, EventAfterBothTurnEnd Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve()
    {
        this.myEv.Invoke();
    }
}

public class EffectBothTurnEnd:UnitEffect
{

	public EffectBothTurnEnd(Player srcPlayer)
	{
        this.SourcePlayer = srcPlayer;
	}
	public override void Resolve()
	{

        if(this.SourcePlayer.Maker!=null)
        {
            if(this.SourcePlayer.hero.Count==0)
            {
                UnityEngine.Debug.Log("GameEnd");
                return;
            }
            else{
                UnityEngine.Debug.Log(this.SourcePlayer.hero[0].GetTag(GameTag.Health));
                UnityEngine.Debug.Log(this.SourcePlayer.myGame.GetTag(GameTag.NowRoundNum));        
            }
        }

        this.SourcePlayer.SetTag(GameTag.IsPlayerTurnEnd,1);
        Game m_Game = this.SourcePlayer.myGame;
        UnityEngine.Debug.Log("One turn end!");
        foreach(Player p in m_Game.PlayersInGame)
        {
            if(p.GetTag(GameTag.IsPlayerTurnEnd)==0)
            {
                return;
            }
        }
        UnityEngine.Debug.Log("Two turn end");
        




































        for(int j=0;j<m_Game.PlayersInGame.Count;j++)
        {
            Player p = m_Game.PlayersInGame[j];
            foreach(Card c in p.board.Merge(p.hand).Merge(p.power).Merge(p.hero).Merge(p.board))
            {
                c.SetTag(GameTag.AttackFot,0);
                c.SetTag(GameTag.ManaFot,0);
                c.SetTag(GameTag.HealthFot,0);
                c.SetTag(GameTag.CntDamageTakenThisTurn,0);
            }
            p.SetTag(GameTag.BonusManaThisTurn,0);
            //List<Card> Po = this.SourcePlayer.hero.Merge(this.SourcePlayer.board).Merge(this.SourcePlayer.power);
            //for (int i= Po.Count-1; i>=0 ;i--)
            //{
            //   
            //}
            for(int i = p.EffectCallBacks.Count-1;i>=0;i--)
            {
                if(p.EffectCallBacks[i] is CallBackAfterBothTurnEnd)
                {
                    p.EffectCallBacks[i].Resolve(); 
                }
            }          
        }

        //m_Game.SetTag(GameTag.NowPlayingIndex,((m_Game.GetTag(GameTag.NowPlayingIndex)+1)% m_Game.PlayersInGame.Count));
        //if (m_Game.GetTag(GameTag.NowPlayingIndex) == 0)
        //{
        //    m_Game.SetTag(GameTag.NowRoundNum, m_Game.GetTag(GameTag.NowRoundNum)+1);
        //}

        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            foreach(Player p in m_Game.PlayersInGame)
            {
                new StartATurnCommand(p.GetTag(GameTag.IsLowPlayer)).AddToQueue();
                p.Maker.OnTurnStart();
            }
        }
        else
        {
            //new EffectBothTurnStart(m_Game).Resolve();
            foreach(Player p in m_Game.PlayersInGame)
            {
                new EffectTurnStart(p).Resolve();
                if(p.Maker!=null)
                    p.Maker.OnTurnStart();
            } 
        }  
	}
}