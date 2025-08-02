using System.Collections.Generic;

public class CallBackAfterTurnEnd:UnitEffectCallBack
{
    public delegate void EventAfterTurnEnd();
    public event EventAfterTurnEnd myEv;
    public CallBackAfterTurnEnd(Ability SourceAbility, EventAfterTurnEnd Func)
    {
        this.SourceAbility = SourceAbility;
        this.myEv+=Func;
    }
    public override void Resolve()
    {
        this.myEv.Invoke();
    }
}

public class EffectTurnEnd:UnitEffect
{

	public EffectTurnEnd(Player srcPlayer)
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

        
        foreach(Card c in this.SourcePlayer.board.Merge(this.SourcePlayer.hand).Merge(this.SourcePlayer.power).Merge(this.SourcePlayer.hero).Merge(this.SourcePlayer.board))
        {
            c.SetTag(GameTag.AttackFot,0);
            c.SetTag(GameTag.ManaFot,0);
            c.SetTag(GameTag.HealthFot,0);
            c.SetTag(GameTag.CntDamageTakenThisTurn,0);
        }
        this.SourcePlayer.SetTag(GameTag.BonusManaThisTurn,0);
        //List<Card> Po = this.SourcePlayer.hero.Merge(this.SourcePlayer.board).Merge(this.SourcePlayer.power);
        //for (int i= Po.Count-1; i>=0 ;i--)
        //{
        //   
        //}
        for(int i = this.SourcePlayer.EffectCallBacks.Count-1;i>=0;i--)
        {
            if(this.SourcePlayer.EffectCallBacks[i] is CallBackAfterTurnEnd)
            {
                this.SourcePlayer.EffectCallBacks[i].Resolve(); 
            }
        }

        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer) == 0)
        {
            new CloseWeaponCommand(this.SourcePlayer.GetTag(GameTag.PlayerID)).AddToQueue();
        }

        Game m_Game = this.SourcePlayer.myGame;
        m_Game.SetTag(GameTag.NowPlayingIndex,((m_Game.GetTag(GameTag.NowPlayingIndex)+1)% m_Game.PlayersInGame.Count));
        if (m_Game.GetTag(GameTag.NowPlayingIndex) == 0)
        {
            m_Game.SetTag(GameTag.NowRoundNum, m_Game.GetTag(GameTag.NowRoundNum)+1);
        }

        if (this.SourcePlayer.GetTag(GameTag.IsSimPlayer)==0)
        {
            new StartATurnCommand(m_Game.PlayersInGame[m_Game.GetTag(GameTag.NowPlayingIndex)].GetTag(GameTag.IsLowPlayer)).AddToQueue();
            m_Game.PlayersInGame[m_Game.GetTag(GameTag.NowPlayingIndex)].Maker.OnTurnStart();
        }
        else
        {
            new EffectTurnStart(m_Game.PlayersInGame[m_Game.GetTag(GameTag.NowPlayingIndex)]).Resolve();
            if(m_Game.PlayersInGame[m_Game.GetTag(GameTag.NowPlayingIndex)].Maker!=null)
                m_Game.PlayersInGame[m_Game.GetTag(GameTag.NowPlayingIndex)].Maker.OnTurnStart();
        }
	}
}