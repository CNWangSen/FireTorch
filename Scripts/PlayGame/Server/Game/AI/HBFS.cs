using System.Collections.Generic;

public class HBFSNode
{
    public Game m_data = null;

    public HBFSNode m_parent = null;
    public List<ActionHistory> m_action = new List<ActionHistory>();
    public List<HBFSNode> m_children = new List<HBFSNode>();
    
    public int m_visits = 0;
    public float m_wins = 0;
    public float m_heuristicScore = 0f;
    
    public static BoardScorer Scorer = new BalancingScorer();
    public static float BestScore;
    public static List<ActionHistory> BestAction = new List<ActionHistory>();
    public static List<ActionHistory> HistoryActions = new List<ActionHistory>();
    public static int FriendlyPlayerIndex = 0;
    public static int OpponentPlayerIndex = 0;
    public static int MaxIters=10000;
    public static int EarlyOutIters=1000;

    public static void DoHeuristicBruteForceSearch(HBFSNode rootNode)
    {   
        //UnityEngine.Debug.Log(System.DateTime.Now.ToUniversalTime().ToString()+"开始搜索……");  
        int iterations = 0;
        BestScore = -10000f;
        int unchangedtimes = 0;
        Game rawData = rootNode.m_data.GetClone();
        HBFSNode.FriendlyPlayerIndex = rawData.GetTag(GameTag.NowPlayingIndex);
        HBFSNode.OpponentPlayerIndex = (FriendlyPlayerIndex+1)%2;
        while (iterations < HBFSNode.MaxIters && unchangedtimes < HBFSNode.EarlyOutIters)
        {
            //UnityEngine.Debug.Log(System.DateTime.Now.ToUniversalTime().ToString()+"第"+iterations.ToString()+"轮搜索，目前最高得分"+BestScore.ToString());  
            //UnityEngine.Debug.Log("HBFS"+iterations.ToString());
            //UnityEngine.Debug.Log(iterations);
            rootNode = HBFSNode.RunSinglePath(rootNode, rawData);//a sing full path
            float SinglePathScore = HBFSNode.Scorer.GetScore(rootNode.m_data.PlayersInGame[HBFSNode.FriendlyPlayerIndex], rootNode.m_data.PlayersInGame[HBFSNode.OpponentPlayerIndex]);
            rootNode = HBFSNode.BackPropagationPath(rootNode,SinglePathScore);
            if (SinglePathScore > BestScore)
            {
                BestScore = SinglePathScore;
                unchangedtimes = 0;
                BestAction.Clear();
                foreach(ActionHistory act in HBFSNode.HistoryActions)
                {
                    BestAction.Add(act);
                }
            }
            else
            {
                unchangedtimes++;
            }
            iterations++;
        }
        //UnityEngine.Debug.Log(System.DateTime.Now.ToUniversalTime().ToString()+"找到最优解！");  
        //UnityEngine.Debug.Log("HBFS DONE!");    
    }

    public static HBFSNode RunSinglePath(HBFSNode node, Game rawData)
    {
        Game simulationData = rawData.GetClone();
        simulationData.PlayersInGame[0].randomGen = new System.Random(42);
        simulationData.PlayersInGame[1].randomGen = new System.Random(42);
        HBFSNode.HistoryActions.Clear();

        int simtime = 0;
        while (simtime < 100)//a single action in path
        {
            simtime += 1;
            if(node.m_action.Count==0)
            {
                node.m_action = HBFSNode.GetPossibleActionsFromData(simulationData);
                for(int i=0;i<node.m_action.Count;i++)
                {
                    HBFSNode childNode = new HBFSNode();
                    childNode.m_parent = node;
                    node.m_children.Add(childNode);
                }
            }

            int MaxUctActionIndex = HBFSNode.FindMaxUctChildIndex(node);
            ActionHistory simulationAction = node.m_action[MaxUctActionIndex];
            simulationData = HBFSNode.ExploreActionFromData(simulationData, simulationAction);
            node = node.m_children[MaxUctActionIndex];
            node.m_data = simulationData;
            if(node.m_heuristicScore==0f)
            {
                node.m_heuristicScore = HBFSNode.Scorer.GetScore(node.m_data.PlayersInGame[HBFSNode.FriendlyPlayerIndex], node.m_data.PlayersInGame[HBFSNode.OpponentPlayerIndex]);
            }
            HBFSNode.HistoryActions.Add(simulationAction);
            if (simulationAction.actType == ActionType.TurnEnd)
            {
                return node;
            }
        }
        return null;
    }

    public static int FindMaxUctChildIndex(HBFSNode node)
    {
        int candidateNodeIndex = 0;
        float candidateNodeScore = -1000000f;
        for(int i=0;i<node.m_children.Count;i++)
        {
            HBFSNode childNode = node.m_children[i];
            float childScore = HBFSNode.calculateScore(childNode);
            if(childScore > candidateNodeScore)
            {
                candidateNodeIndex = i;
                candidateNodeScore = childScore;
            }
        }        
        return candidateNodeIndex;
    }
    public static float calculateScore(HBFSNode node)
    {
        if(node.m_visits==0)
        {
            return 1000000f;
        }
        float exploitScore = node.m_wins/node.m_visits;
        float exploreScore = (float)System.Math.Sqrt(System.Math.Log(node.m_parent.m_visits)/node.m_visits);
        exploreScore = 200f * exploreScore;
        return exploitScore + exploreScore + node.m_heuristicScore;///(node.m_parent.m_visits + 1);
    }


    public static HBFSNode BackPropagationPath(HBFSNode node, float score)//BackPropagationPath
    {
        while(true)
        {
            node.m_visits += 1;
            node.m_wins += score;
            if(node.m_parent!=null)
            {
                node = node.m_parent;
            }
            else
            {
                break;
            }
        }
        return node;
    }
    
    public static List<ActionHistory> GetPossibleActionsFromData(Game data)
    {
        List<ActionHistory> possibleActions = new List<ActionHistory>();
        
        Player CurrentPlayer = data.PlayersInGame[data.GetTag(GameTag.NowPlayingIndex)];
        if(CurrentPlayer.ChoosingTargetForCardID!=-1)
        {
            Card c = data.CardsInGame[CurrentPlayer.ChoosingTargetForCardID];
            TargetingOptions opts = (TargetingOptions)CurrentPlayer.ChoosingTargetOpts; 
            List<Card> ValidTargets = CurrentPlayer.GetValidTargetMatchOption(opts);
            if(CurrentPlayer.ChoosingTargetActionType == (int) ActionType.ChooseCardToPlay)
            {
                foreach (Card ct in ValidTargets)
                {
                    possibleActions.Add(new ActionHistory(ActionType.PlayCard, c.GetTag(GameTag.EntityId), ct.GetTag(GameTag.EntityId)));
                }                
            }
            if(CurrentPlayer.ChoosingTargetActionType == (int) ActionType.ChooseCardToAttack)
            {
                foreach (Card ct in ValidTargets)
                {
                    possibleActions.Add(new ActionHistory(ActionType.CardAttack, c.GetTag(GameTag.EntityId), ct.GetTag(GameTag.EntityId)));
                }                
            }
            if(CurrentPlayer.ChoosingTargetActionType == (int) ActionType.ChoosePowerToUse)
            {
                foreach (Card ct in ValidTargets)
                {
                    possibleActions.Add(new ActionHistory(ActionType.HeroPower, c.GetTag(GameTag.EntityId), ct.GetTag(GameTag.EntityId)));
                }                
            }
        }
        else
        {
            foreach (Card c in CurrentPlayer.hand)
            {
                if (c.CanBePlayed())
                {
                    if ((TargetingOptions)c.GetTag(GameTag.CardTargetOpt) == TargetingOptions.NoTarget)
                    {
                        possibleActions.Add(new ActionHistory(ActionType.PlayCard, c.GetTag(GameTag.EntityId), -1));
                    }
                    else
                    {
                        List<Card> ValidTargets = CurrentPlayer.GetValidTargetMatchOption((TargetingOptions)c.GetTag(GameTag.CardTargetOpt));
                        if(ValidTargets.Count==1)
                        {
                            possibleActions.Add(new ActionHistory(ActionType.PlayCard, c.GetTag(GameTag.EntityId), ValidTargets[0].GetTag(GameTag.EntityId)));
                        }
                        else if(ValidTargets.Count>1)
                        {
                            possibleActions.Add(new ActionHistory(ActionType.ChooseCardToPlay, c.GetTag(GameTag.EntityId), opt:(int)(TargetingOptions)c.GetTag(GameTag.CardTargetOpt)));
                        }
                        else{

                        }
                        
                        //
                        //foreach (Card ct in ValidTargets)
                        //{
                        //    possibleActions.Add(new ActionHistory(ActionType.PlayCard, c.GetTag(GameTag.EntityId), ct.GetTag(GameTag.EntityId)));
                        //}
                    }
                }
            }
            foreach (Card c in CurrentPlayer.board.Merge(CurrentPlayer.hero))
            {
                if (c.GetTag(GameTag.AttacksLeftThisTurn) > 0 && c.GetTag(GameTag.Attack) > 0 && c.GetTag(GameTag.Health)>0)
                {
                    
                    //List<Card> ValidTargets = CurrentPlayer.GetValidTargetMatchOption(TargetingOptions.OpposingCharactersTauntFirst);
                    //foreach (Card ct in ValidTargets)
                    //{
                    //    possibleActions.Add(new ActionHistory(ActionType.CardAttack, c.GetTag(GameTag.EntityId), ct.GetTag(GameTag.EntityId)));
                    //}
                    List<Card> ValidTargets = CurrentPlayer.GetValidTargetMatchOption(TargetingOptions.OpposingCharactersTauntFirst);
                    if(ValidTargets.Count==1)
                    {
                        possibleActions.Add(new ActionHistory(ActionType.CardAttack, c.GetTag(GameTag.EntityId), ValidTargets[0].GetTag(GameTag.EntityId)));
                    }
                    else if(ValidTargets.Count>1)
                    {
                        possibleActions.Add(new ActionHistory(ActionType.ChooseCardToAttack, c.GetTag(GameTag.EntityId), opt:(int)TargetingOptions.OpposingCharactersTauntFirst));
                    }
                    else{
                        
                    }
                }
            }
            List<Card> AllPowers = new List<Card>();
            foreach(Card c in CurrentPlayer.power)
            {
                AllPowers.Add(c);
            }
            foreach(Card c in CurrentPlayer.board)
            {
                foreach(Card cp in c.attachmentList)
                    AllPowers.Add(cp);
            }

            foreach (Card c in AllPowers)
            {
                if ((CurrentPlayer.GetTag(GameTag.ManaLeft) >= c.GetTag(GameTag.Mana) && c.GetTag(GameTag.AttacksLeftThisTurn) > 0))
                {
                    if ((TargetingOptions)c.GetTag(GameTag.CardTargetOpt) == TargetingOptions.NoTarget)
                    {
                        possibleActions.Add(new ActionHistory(ActionType.HeroPower, c.GetTag(GameTag.EntityId), -1));
                    }
                    else
                    {
                        
                        //List<Card> ValidTargets = CurrentPlayer.GetValidTargetMatchOption((TargetingOptions)c.GetTag(GameTag.CardTargetOpt));
                        //foreach (Card ct in ValidTargets)
                        //{
                        //    possibleActions.Add(new ActionHistory(ActionType.HeroPower, c.GetTag(GameTag.EntityId), ct.GetTag(GameTag.EntityId)));
                        //}
                        List<Card> ValidTargets = CurrentPlayer.GetValidTargetMatchOption((TargetingOptions)c.GetTag(GameTag.CardTargetOpt));
                        if(ValidTargets.Count==1)
                        {
                            possibleActions.Add(new ActionHistory(ActionType.HeroPower, c.GetTag(GameTag.EntityId), ValidTargets[0].GetTag(GameTag.EntityId)));
                        }
                        else if(ValidTargets.Count>1)
                        {
                            possibleActions.Add(new ActionHistory(ActionType.ChoosePowerToUse, c.GetTag(GameTag.EntityId), opt:(int)(TargetingOptions)c.GetTag(GameTag.CardTargetOpt)));
                        }
                        else{
                            
                        }
                    }
                }
            }
            possibleActions.Add(new ActionHistory(ActionType.TurnEnd, 0, 0));
        }
        return possibleActions;
    }
    public static Game ExploreActionFromData(Game data, ActionHistory action)
    {
        Player CurrentPlayer = data.PlayersInGame[data.GetTag(GameTag.NowPlayingIndex)];
        if (action.actType == ActionType.PlayCard)
        {
            CurrentPlayer.ChoosingTargetForCardID=-1;
            new EffectPlay(CurrentPlayer, CardId:action.SourceId, TargetId:action.TargetId).Resolve();
        }
        if (action.actType == ActionType.CardAttack)
        {
            CurrentPlayer.ChoosingTargetForCardID=-1;
            new EffectAttack(CurrentPlayer,SourceId:action.SourceId,TargetId:action.TargetId).Resolve();
        }
        if (action.actType == ActionType.HeroPower)
        {
            CurrentPlayer.ChoosingTargetForCardID=-1;
            new EffectUseHeroPower(CurrentPlayer,SourceId:action.SourceId,TargetId:action.TargetId).Resolve();
        }
        if (action.actType == ActionType.TurnEnd)
        {
            CurrentPlayer.ChoosingTargetForCardID=-1;
            new EffectTurnEnd(CurrentPlayer).Resolve();
        }


        if (action.actType == ActionType.ChooseCardToPlay)
        {
            CurrentPlayer.ChoosingTargetForCardID = action.SourceId;
            CurrentPlayer.ChoosingTargetActionType = (int) ActionType.ChooseCardToPlay;
            CurrentPlayer.ChoosingTargetOpts = action.TargetingOpt;
        }
        if (action.actType == ActionType.ChooseCardToAttack)
        {
            CurrentPlayer.ChoosingTargetForCardID = action.SourceId;
            CurrentPlayer.ChoosingTargetActionType = (int) ActionType.ChooseCardToAttack;
            CurrentPlayer.ChoosingTargetOpts = action.TargetingOpt;
        }
        if (action.actType == ActionType.ChoosePowerToUse)
        {
            CurrentPlayer.ChoosingTargetForCardID = action.SourceId;
            CurrentPlayer.ChoosingTargetActionType = (int) ActionType.ChoosePowerToUse;
            CurrentPlayer.ChoosingTargetOpts = action.TargetingOpt;
        }
        return data;
    }
}