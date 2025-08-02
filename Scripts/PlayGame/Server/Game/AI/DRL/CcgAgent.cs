using System.Collections.Generic;
using UnityEngine;
//using Unity.MLAgents;
//using Unity.MLAgents.Sensors;
//using Unity.MLAgents.Actuators;

public class CcgAgent:MonoBehaviour//:Agent
{
	public Player p;
	public Game GameCopy;

	public bool IsResponsibleForReset = false;
	public CcgAgent Another;

	public bool IsPlayingGame = true;
	public bool IsMyTurn = false;
    private float timeBetweenDecisionsAtInference=0.5f;
    float m_TimeSinceDecision;
    public static int CntEpisode = 0;

/*
	public override void OnEpisodeBegin()
	{
		if(IsResponsibleForReset && this.p.myGame.IsTrainingMode)
		{
			if(Another.IsPlayingGame)
			{
				CntEpisode+=1;
				UnityEngine.Debug.Log("New Episode Begin: "+CntEpisode.ToString());
				Game NewGame = GameCopy.GetClone();
				p=NewGame.PlayersInGame[0];
				Another.p = NewGame.PlayersInGame[1];
				NewGame.StartGame();				
			}
		}
	}
	public override void Initialize()
	{

	}

	public override void CollectObservations(VectorSensor sensor)
	{
		//38*4+1=153
		sensor.AddObservation(p.GetTag(GameTag.ManaLeft));
		AddExtendOB(sensor,p.hand,10);
		AddExtendOB(sensor,p.board,7);
		AddExtendOB(sensor,p.power,1);
		AddExtendOB(sensor,p.hero,1);

		AddExtendOB(sensor,Another.p.hand,10);
		AddExtendOB(sensor,Another.p.board,7);
		AddExtendOB(sensor,Another.p.power,1);
		AddExtendOB(sensor,Another.p.hero,1);
	}

	public void AddExtendOB(VectorSensor sensor, List<Card> zone, int FixedNum)
	{
		int Cnt = zone.Count;
		for(int i=0;i<FixedNum;i++)
		{
			if(i<Cnt)
			{
				sensor.AddObservation(zone[i].GetTag(GameTag.Mana));
				sensor.AddObservation(zone[i].GetTag(GameTag.Attack));
				sensor.AddObservation(zone[i].GetTag(GameTag.Health));
				if(zone[i].GetTag(GameTag.ZoneType) == (int)ZoneType.Hand)
				{
					if(zone[i].CanBePlayed())
					{
						sensor.AddObservation(1);
					}
					else{
						sensor.AddObservation(0);
					}
				}
				else if(zone[i].GetTag(GameTag.ZoneType) == (int)ZoneType.Board)
				{
					if(zone[i].GetTag(GameTag.AttacksLeftThisTurn)>0)
					{
						sensor.AddObservation(1);
					}
					else{
						sensor.AddObservation(0);
					}
					
				}
				else{
					sensor.AddObservation(0);
				}
			}
			else{
				sensor.AddObservation(0);
				sensor.AddObservation(0);
				sensor.AddObservation(0);
				sensor.AddObservation(-1);
			}
		}
	}


	public override void WriteDiscreteActionMask(IDiscreteActionMask actionMask)
	{
		//1->10:hand
		//11->17:board
		//18:power
		//var srcIndex = actionBuffers.DiscreteActions[0];
		int CntMyHand = this.p.hand.Count;
		for(int i=1;i<=10;i++)
		{
			actionMask.SetActionEnabled(0,i,false);
			if(CntMyHand>i-1)
			{
				if(this.p.hand[i-1].CanBePlayed())
				{
					actionMask.SetActionEnabled(0,i,true);
				}
			}
		}
		int CntMyBoard = this.p.board.Count;
		for(int i=11;i<=17;i++)
		{
			actionMask.SetActionEnabled(0,i,false);
			if(CntMyBoard>i-11)
			{
				if(this.p.board[i-11].GetTag(GameTag.AttacksLeftThisTurn) > 0)
				{
					actionMask.SetActionEnabled(0,i,true);
				}
			}			
		}

		if(this.p.power[0].GetTag(GameTag.AttacksLeftThisTurn) > 0 && this.p.GetTag(GameTag.ManaLeft)>this.p.power[0].GetTag(GameTag.Mana))
		{
			actionMask.SetActionEnabled(0,18,true);
		}
		else{
			actionMask.SetActionEnabled(0,18,false);
		}

		//1->7:enemy board
		//8:enemy hero
		//var tarIndex = actionBuffers.DiscreteActions[1];
		int CntEnBoard = Another.p.board.Count;
		for(int i=1;i<=7;i++)
		{
			if(CntEnBoard>i-1)
			{
				actionMask.SetActionEnabled(1,i,true);
			}
			else{
				actionMask.SetActionEnabled(1,i,false);
			}
		}
		if(this.Another.p.hero.Count>0)
		{
			actionMask.SetActionEnabled(1,8,true);
		}
		else
		{
			actionMask.SetActionEnabled(1,8,false);
		}
	}
	private int Cnt1=0;
	public override void OnActionReceived(ActionBuffers actionBuffers)
	{
		if(!IsMyTurn || !IsPlayingGame)
		{
			return;
		}
		//1->10:hand
		//11->17:board
		//18:power
		//19:end turn
		var srcIndex = actionBuffers.DiscreteActions[0];

		//1->7:enemy board
		//8:enemy hero
		var tarIndex = actionBuffers.DiscreteActions[1];


		Card srcCard = null;
		Card tarCard = null;
		ActionType act;
		if(srcIndex>=1 && srcIndex<=10)
		{
			srcCard = this.p.hand[srcIndex-1];
			act = ActionType.PlayCard;
			new EffectPlay(this.p, CardId:srcCard.GetTag(GameTag.EntityId), TargetId:-1).Resolve();	
		}
		if(srcIndex>=11 && srcIndex<=17)
		{
			if(this.p.board.Count>srcIndex-11)
			{
				srcCard = this.p.board[srcIndex-11];
				act = ActionType.CardAttack;
				if(tarIndex>=1 && tarIndex<=7)
				{
					tarCard = Another.p.board[tarIndex-1];
				}
				if(tarIndex==8)
				{
					tarCard = Another.p.hero[0];
				}
				if(tarCard!=null)
					new EffectAttack(this.p,SourceId:srcCard.GetTag(GameTag.EntityId),TargetId:tarCard.GetTag(GameTag.EntityId)).Resolve();				
			}
		}
		if(srcIndex==18)
		{
			srcCard = this.p.power[0];
			act = ActionType.CardAttack;
			if(tarIndex>=1 && tarIndex<=7)
			{
				tarCard = Another.p.board[tarIndex-1];
			}
			if(tarIndex==8)
			{
				tarCard = Another.p.hero[0];
			}
			if(tarCard!=null)
				new EffectUseHeroPower(this.p,SourceId:srcCard.GetTag(GameTag.EntityId),TargetId:tarCard.GetTag(GameTag.EntityId)).Resolve();							
		}

		Cnt1+=1;
		if(srcIndex==19 || Cnt1>=50)
		{
			this.IsMyTurn=false;
			this.Another.IsMyTurn=true;
			this.p.myGame.SwitchTurn(this.p);
			UnityEngine.Debug.Log(this.p.GetTag(GameTag.IsLowPlayer).ToString()+"----SwitchTurn----"+Cnt1.ToString());
			Cnt1=0;
		}

		if(p.hero.Count==0)
		{
			UnityEngine.Debug.Log(this.p.GetTag(GameTag.IsLowPlayer).ToString()+"----Lose");
			SetReward(-10f);
			EndEpisode();	
		}
		else if(Another.p.hero.Count==0)
		{
			UnityEngine.Debug.Log(this.p.GetTag(GameTag.IsLowPlayer).ToString()+"----Win");
			SetReward(10f);
			EndEpisode();
		}
	}



	public void FixedUpdate()
	{
		WaitTimeInference();
	}
	public void WaitTimeInference()
	{
		if(!IsMyTurn || !IsPlayingGame)
		{
			return;
		}

        if (Academy.Instance.IsCommunicatorOn)
        {
            RequestDecision();
        }
        else
        {
            if (m_TimeSinceDecision >= timeBetweenDecisionsAtInference)
            {
                m_TimeSinceDecision = 0f;
                RequestDecision();
            }
            else
            {
                m_TimeSinceDecision += Time.fixedDeltaTime;
            }
        }
	}
	*/
}
