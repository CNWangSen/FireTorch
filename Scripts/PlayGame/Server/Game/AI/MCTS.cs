using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;
using System;
using System.Diagnostics;

public class MCTSNode
{
    public Game m_data = null;
    public MCTSNode m_parent = null;
    public List<ActionHistory> m_unexploredChildren = new List<ActionHistory>();
    public List<MCTSNode> m_exploredChildren = new List<MCTSNode>();
    public int m_visits = 0;
    public float m_wins = 0;
    public int ActionIndex = 0;

    public static List<ActionHistory> BestAction = new List<ActionHistory>();
    public static Random rng = new Random();
    public static int AIplayerID = 0;
    public static int SimWinnerID = 0;

    public MCTSNode(Game data)
    {
        this.m_data = data;
        this.m_data.PlayersInGame[0].SetTag(GameTag.IsSimPlayer,1);
        this.m_data.PlayersInGame[1].SetTag(GameTag.IsSimPlayer,1);
        //this.m_data.PlayersInGame[0].randomGen = new System.Random(NewNode.FriendlyPlayer.GetTag(GameTag.RandomSeed));
        //this.m_data.PlayersInGame[1].randomGen = new System.Random(NewNode.OpponentPlayer.GetTag(GameTag.RandomSeed));
    }

    public static void DoMonteCarloTreeSearch(MCTSNode rootNode)
    {
        MCTSNode.BestAction.Clear();
        rootNode.m_unexploredChildren = MCTSNode.GetPossibleActionsFromNode(rootNode);
        if(rootNode.m_unexploredChildren.Count>1)
        {
            MCTSNode.AIplayerID = rootNode.m_data.PlayersInGame[rootNode.m_data.GetTag(GameTag.NowPlayingIndex)].GetTag(GameTag.PlayerID);
            int iterations = 0;
            MCTSNode node = rootNode;
            while(iterations < 200)                                       //21868ms of 1000iters
            {
                node = MCTSNode.Selection(node);                          //12ms of 1000iters
                node = MCTSNode.Expansion(node);                          //2290ms of 1000iters = 2000 Clone + 100 Possible
                int score = MCTSNode.Simulation(node);                    //19922ms of 1000iters = 14389 ExploreAction + 3000 Possible + 1838 Clone
                node = MCTSNode.Backpropagation(node,score);              //7ms of 1000iters
                iterations++;
            }
        }

        MCTSNode nodeFinder = rootNode;
        int wCount = 0;
        while(true)
        {
            wCount+=1;
            MCTSNode candidateNode = MCTSNode.FindMaxUctChild(nodeFinder);
            if(candidateNode==null)
            {
                break;
            }
            ActionHistory act = MCTSNode.GetPossibleActionsFromNode(nodeFinder)[candidateNode.ActionIndex];
            MCTSNode.BestAction.Add(act);
            if(act.actType == ActionType.TurnEnd || wCount > 0)
            {
                break;
            }
            nodeFinder = candidateNode;
        }
    }


    //12ms of 21868, 1000 iter
    public static MCTSNode Selection(MCTSNode node)
    {
        if((node.m_unexploredChildren.Count == 0) && (node.m_exploredChildren.Count !=0))
        {
            return MCTSNode.Selection(MCTSNode.FindMaxUctChild(node));
        }
        return node;
    }
    
    public static MCTSNode FindMaxUctChild(MCTSNode node)
    {
        MCTSNode candidateNode = null;
        float candidateNodeScore = -1000000f;

        //Compare scores for all children, select the best one.
        foreach (MCTSNode childNode in node.m_exploredChildren)
        {
            float childScore = MCTSNode.calculateScore(childNode);
            if(childScore > candidateNodeScore)
            {
                candidateNodeScore = childScore;
                candidateNode = childNode;
            }
        }
        return candidateNode;
    }
    public static float calculateScore(MCTSNode node)
    {
        if(node.m_visits==0)
        {
            return 1000000f;
        }
        float exploitScore = node.m_wins/node.m_visits;
        float exploreScore = (float)System.Math.Sqrt(System.Math.Log(node.m_parent.m_visits)/node.m_visits);
        exploreScore = 0.625f * exploreScore;

        return exploitScore + exploreScore;
    }




    //2126ms of 21868, 1000 iter
    public static MCTSNode Expansion(MCTSNode node)
    {
        //If node is a leaf node -no expansion
        if(node.m_unexploredChildren.Count==0)
        {
            return node;
        }
        //Randomly select an action
        int randomNumber = MCTSNode.rng.Next(0,node.m_unexploredChildren.Count);
        
        MCTSNode CopyNode = new MCTSNode(node.m_data.GetClone());
        MCTSNode newNode = MCTSNode.ExploreActionFromNode(CopyNode,node.m_unexploredChildren[randomNumber]);

        //Remove the new node from the node's possible actions, and add it to the node's children
        node.m_unexploredChildren.RemoveAt(randomNumber);
        newNode.m_parent = node;
        newNode.ActionIndex = randomNumber;
        node.m_exploredChildren.Add(newNode);

        //Generate possible actions for the new node, unless it's a leaf node
        //True if no players are dead
        if(newNode.m_data.PlayersInGame[0].hero.Count!=0 && newNode.m_data.PlayersInGame[1].hero.Count!=0)
        {
            newNode.m_unexploredChildren = MCTSNode.GetPossibleActionsFromNode(newNode);
        }
        else
        {
            newNode.m_unexploredChildren = new List<ActionHistory>();
            newNode.m_exploredChildren = new List<MCTSNode>();
        }

        return newNode;
    }




    //19328ms of 21868, 1000 iter
    public static int Simulation(MCTSNode node)
    {
        MCTSNode simulationNode = new MCTSNode(node.m_data.GetClone());

        //Remember whose turn it is
        //int currentPlayerID = simulationNode.m_data.PlayersInGame[simulationNode.m_data.GetTag(GameTag.NowPlayingIndex)].GetTag(GameTag.PlayerID);
        int simRound=0;

        
        while(true)
        {
            simRound+=1;
            if(simRound>1000)
            {
                UnityEngine.Debug.Log("SimulationTimeOut");
                MCTSNode.SimWinnerID = simulationNode.m_data.PlayersInGame[0].GetTag(GameTag.PlayerID);
                return 0;
            }

            if(simulationNode.m_data.PlayersInGame[0].hero.Count==0)
            {
                MCTSNode.SimWinnerID = simulationNode.m_data.PlayersInGame[1].GetTag(GameTag.PlayerID);
                return 0;
            }
            if(simulationNode.m_data.PlayersInGame[1].hero.Count==0)
            {
                MCTSNode.SimWinnerID = simulationNode.m_data.PlayersInGame[0].GetTag(GameTag.PlayerID);
                return 0;
            }          
            //Check if either player is dead, return score based on whose turn it was originally
            //if(simulationNode.m_data.PlayersInGame[0].hero.Count==0 || simulationNode.m_data.PlayersInGame[1].hero.Count==0)
            //{
            //    if(currentPlayerID == simulationNode.m_data.PlayersInGame[simulationNode.m_data.GetTag(GameTag.NowPlayingIndex)].GetTag(GameTag.PlayerID))
            //    {
            //        
            //        return 1;
            //    }
            //    else
            //    {
            //        return 0;
            //    }
            //}

            //Create every possible action from the simulation Node
            List<ActionHistory> possibleActions = MCTSNode.GetPossibleActionsFromNode(simulationNode);
            int randomNumber = MCTSNode.rng.Next(0,possibleActions.Count);
            simulationNode =  ExploreActionFromNode(simulationNode,possibleActions[randomNumber]);
        }
        
    }




    //7ms of 21868, 1000 iter
    public static MCTSNode Backpropagation(MCTSNode node, int score)
    {

        //Remember whose turn it is
        //int currentPlayerID = node.m_data.PlayersInGame[node.m_data.GetTag(GameTag.NowPlayingIndex)].GetTag(GameTag.PlayerID);

        //While the node has a parent, backpropagate the result of the simulation up the game tree
        int FindParent = 0;
        while(node.m_parent!=null)
        {
            FindParent+=1;
            if(FindParent>1000)
            {
                UnityEngine.Debug.Log("BackpropagationTimeOut");
                return node;
            }
            
            int parentPlayerID = node.m_parent.m_data.PlayersInGame[node.m_parent.m_data.GetTag(GameTag.NowPlayingIndex)].GetTag(GameTag.PlayerID);
            UnityEngine.Debug.Log("IDing");
            UnityEngine.Debug.Log(MCTSNode.SimWinnerID);
            UnityEngine.Debug.Log(MCTSNode.AIplayerID);
            UnityEngine.Debug.Log(parentPlayerID);
            if( parentPlayerID == MCTSNode.AIplayerID)
            {
                if(MCTSNode.SimWinnerID == MCTSNode.AIplayerID)
                {
                    node = MCTSNode.UpdateScore(node,1);
                }
                else{
                    node = MCTSNode.UpdateScore(node,0);
                }
            }
            else{
                if(MCTSNode.SimWinnerID == MCTSNode.AIplayerID)
                {
                    node = MCTSNode.UpdateScore(node,0);
                }
                else{
                    node = MCTSNode.UpdateScore(node,1);
                }
            }
            //if(node.m_parent.m_data.PlayersInGame[node.m_data.GetTag(GameTag.NowPlayingIndex)].GetTag(GameTag.PlayerID) == currentPlayerID)
            //{
            //    node = MCTSNode.UpdateScore(node,score);
            //}
            //else
            //{
            //    if(score == 0)
            //    {
            //        node = MCTSNode.UpdateScore(node,1);
            //    }
            //    if(score == 1)
            //    {
            //        node = MCTSNode.UpdateScore(node,0);
            //    }
            //}
            node = node.m_parent;
        }
        node.m_visits += 1;
        return node;
    }
    public static MCTSNode UpdateScore(MCTSNode node, float score)
    {
        node.m_visits += 1;
        node.m_wins += score;
        return node;
    }


    //3224ms of 21868, 1000 iter
    public static List<ActionHistory> GetPossibleActionsFromNode(MCTSNode node)//Expansion
    {
        Game data = node.m_data;
        //MCTSNode.PossibleActionWatcher.Start();//Stopwatcher
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
                        possibleActions.Add(new ActionHistory(ActionType.ChooseCardToPlay, c.GetTag(GameTag.EntityId), opt:(int)(TargetingOptions)c.GetTag(GameTag.CardTargetOpt)));
                        //List<Card> ValidTargets = CurrentPlayer.GetValidTargetMatchOption((TargetingOptions)c.GetTag(GameTag.CardTargetOpt));
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
                    possibleActions.Add(new ActionHistory(ActionType.ChooseCardToAttack, c.GetTag(GameTag.EntityId), opt:(int)TargetingOptions.OpposingCharactersTauntFirst));
                    //List<Card> ValidTargets = CurrentPlayer.GetValidTargetMatchOption(TargetingOptions.OpposingCharactersTauntFirst);
                    //foreach (Card ct in ValidTargets)
                    //{
                    //    possibleActions.Add(new ActionHistory(ActionType.CardAttack, c.GetTag(GameTag.EntityId), ct.GetTag(GameTag.EntityId)));
                    //}
                }
            }
            foreach (Card c in CurrentPlayer.power)
            {
                if ((CurrentPlayer.GetTag(GameTag.ManaLeft) >= c.GetTag(GameTag.Mana) && c.GetTag(GameTag.AttacksLeftThisTurn) > 0))
                {
                    if ((TargetingOptions)c.GetTag(GameTag.CardTargetOpt) == TargetingOptions.NoTarget)
                    {
                        possibleActions.Add(new ActionHistory(ActionType.HeroPower, c.GetTag(GameTag.EntityId), -1));
                    }
                    else
                    {
                        possibleActions.Add(new ActionHistory(ActionType.ChoosePowerToUse, c.GetTag(GameTag.EntityId), opt:(int)(TargetingOptions)c.GetTag(GameTag.CardTargetOpt)));
                        //List<Card> ValidTargets = CurrentPlayer.GetValidTargetMatchOption((TargetingOptions)c.GetTag(GameTag.CardTargetOpt));
                        //foreach (Card ct in ValidTargets)
                        //{
                        //    possibleActions.Add(new ActionHistory(ActionType.HeroPower, c.GetTag(GameTag.EntityId), ct.GetTag(GameTag.EntityId)));
                        //}
                    }
                }
            }
            possibleActions.Add(new ActionHistory(ActionType.TurnEnd, 0, 0));
        }
        //MCTSNode.PossibleActionWatcher.Stop();
        return possibleActions;
    }

    //14389ms of 21868, 1000 iter
    public static MCTSNode ExploreActionFromNode(MCTSNode node, ActionHistory action)
    {
        //MCTSNode.ExploreActionWatcher.Start();
        Game data = node.m_data;
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
        //MCTSNode.ExploreActionWatcher.Stop();
        return node;
    }
}