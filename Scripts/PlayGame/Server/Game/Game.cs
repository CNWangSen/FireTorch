using System.Collections.Generic;
using System.Threading;


public class Game
{
    public static Game NowGame;
    public List<Player> PlayersInGame = new List<Player>();
    public List<Card> CardsInGame = new List<Card>();
    //public Dictionary<int, Card> CardsInGame = new Dictionary<int, Card>();
    public SynchronizationContext mainThread = null;
    //private Dictionary<GameTag, int> Property = new Dictionary<GameTag, int>();
    private int[] PropertyArr = new int[100];
    public List<ActionHistory> actionHistorys = new List<ActionHistory>();
    
    public bool UseDRL = false;
    public bool IsTrainingMode = false;
    public GameMode m_Mode=GameMode.WildPlay;//MarvelSnap;//BattleGround;//GameMode.WildPlay;
    
    public int GetTag(GameTag tg)
    {
        return this.PropertyArr[(int)tg];
        /*
        int tagV;
        Property.TryGetValue(tg, out tagV);
        return tagV;
        */
    }
    public void SetTag(GameTag tg, int value)
    {
        this.PropertyArr[(int)tg]=value;
        /*
        int tagV;
        if (Property.TryGetValue(tg, out tagV))
        {
            Property[tg] = value;
        }
        else
        {
            Property.Add(tg, value);
        }
        */
    }
    public Game()
    {
        this.SetTag(GameTag.GameID,0);
        this.SetTag(GameTag.NowPlayingIndex,0);
        this.SetTag(GameTag.GameState,(int)GameState.Loading);
        this.SetTag(GameTag.GameMode,(int)GameMode.BattleGround);
    }
    public Game GetClone()
    {
        Game CloneGame = new Game();
        foreach(Card c in this.CardsInGame)
        {
            CloneGame.CardsInGame.Add(null);
        }
        foreach (Player p in this.PlayersInGame)
        {
            Player ClonePlayer = p.GetClone();
            ClonePlayer.myGame = CloneGame;
            CloneGame.PlayersInGame.Add(ClonePlayer);
        }
        //CloneGame.PlayersInGame[0].simOtherPlayer = CloneGame.PlayersInGame[0];

        for (int i = 0; i < this.PlayersInGame.Count; i++)
        {
            CloneGame.PlayersInGame[i].CloneCardFromPlayer(this.PlayersInGame[i]);
        }

        for(int i=0;i<this.PropertyArr.Length;i++)
        {
            CloneGame.PropertyArr[i] = this.PropertyArr[i];
        }
        //foreach (KeyValuePair<GameTag, int> kv in this.Property)
        //{
        //    CloneGame.SetTag(kv.Key, kv.Value);
        //}
        foreach (ActionHistory history in this.actionHistorys)
        {
            CloneGame.actionHistorys.Add(history.GetClone());
        }

        return CloneGame;
    }
    public Player GetPlayerByID(int id)
    {
        foreach (Player p in PlayersInGame)
        {
            if (p.GetTag(GameTag.PlayerID)==id)
            {
                return p;
            }
        }
        return null;
    }

    public static Game CreateGame(List<int> PlayerIDs=null, List<DeckDbf> PlayerDecks=null, List<int> ControledByAi=null, List<CcgAgent> DLAgents = null,GameMode mode = GameMode.BattleGround, bool Visual=true)
    {
        NowGame = new Game();
        for (int P_i = 0; P_i < PlayerIDs.Count; P_i++)
        {
            Player p = new Player(NowGame, PlayerIDs[P_i]);
            TurnMaker maker = new AITurnMaker();
            maker.p = p;
            p.Maker = maker;

            if(NowGame.UseDRL)
            {
                p.Maker.MyDLAgent = DLAgents[P_i];
                p.Maker.MyDLAgent.p = p;
                if(NowGame.IsTrainingMode)
                {
                    p.SetTag(GameTag.IsSimPlayer,1);
                }
            }
            else{
                p.Maker.MyDLAgent = null;
            }
            if (PlayerIDs[P_i] == (int)GameTag.TopPlayerID)
            {
                maker.m_Strategy = AIstrategy.HBFS;
                if(NowGame.m_Mode==GameMode.BattleGround)
                {
                    maker.m_Strategy=AIstrategy.AFK;
                }
                p.SetTag(GameTag.IsControledByAI,ControledByAi[P_i]);
                p.SetTag(GameTag.IsLowPlayer,0);
                p.SetTag(GameTag.TeamID,0);
                p.randomGen = new System.Random(114);
            }
            else
            {
                maker.m_Strategy = AIstrategy.HBFS;//Balance;// Cheating;
                p.SetTag(GameTag.IsControledByAI,ControledByAi[P_i]);
                p.SetTag(GameTag.IsLowPlayer,1);
                p.SetTag(GameTag.TeamID,1);
                p.randomGen = new System.Random(514);
            }
            if(Visual==false)
            {
                p.SetTag(GameTag.IsSimPlayer,1);
            }
            NowGame.PlayersInGame.Add(p);
        }
        

        List<string> m_HeroPowersGUID=new List<string>{
        "HERO_01bp","HERO_11bp","HERO_10bp",
        "HERO_06bp","HERO_05bp","HERO_08bp",
        "HERO_04bp","HERO_09bp","HERO_03bp",
        "HERO_02bp","HERO_07bp","HERO_01bp",
        "HERO_01bp","HERO_01bp","HERO_01bp"};

        
        for (int P_i = 0; P_i < PlayerIDs.Count; P_i++)
        {
            //NowGame.PlayersInGame[P_i].InitFromDeckDbf(PlayerDecks[P_i]);
            NowGame.PlayersInGame[P_i].deckDbf = PlayerDecks[P_i];

            foreach (CardDbf herodbf in PlayerDecks[P_i].Hero)
            {
                new EffectCreate(NowGame.PlayersInGame[P_i], new Card(herodbf, NowGame.PlayersInGame[P_i]), ZoneType.Hero).Resolve();
                if(NowGame.m_Mode!=GameMode.BattleGround)
                {
                    CardDbf PowDbf = CardDbf.GetCardDbfByGuid(m_HeroPowersGUID[(int)herodbf.Classes[0]]);
                    new EffectCreate(NowGame.PlayersInGame[P_i], new Card(PowDbf, NowGame.PlayersInGame[P_i]), ZoneType.Power).Resolve();
                }
            }


            foreach (CardDbf powdbf in PlayerDecks[P_i].HeroPower)
            {
                new EffectCreate(NowGame.PlayersInGame[P_i], new Card(powdbf, NowGame.PlayersInGame[P_i]), ZoneType.Power).Resolve();
            }

            foreach (CardDbf ca in NowGame.PlayersInGame[P_i].deckDbf.Cards)
            {
                new EffectCreate(NowGame.PlayersInGame[P_i], new Card(ca, NowGame.PlayersInGame[P_i]), ZoneType.Deck).Resolve();
            }
            Card fati = new Card(CardDbf.GetCardDbfByGuid("CORE_CS2_189"), NowGame.PlayersInGame[P_i]);
            fati.SetTag(GameTag.ZoneType, (int)ZoneType.Deck);
            new EffectCreate(NowGame.PlayersInGame[P_i], fati, ZoneType.Grave).Resolve();
            NowGame.PlayersInGame[P_i].grave.Remove(fati);
            NowGame.PlayersInGame[P_i].FatigueCard = fati;
        }
        Game.NowGame.SetTag(GameTag.GameMode,(int)mode);
        Game.NowGame.SetTag(GameTag.GameState,(int)GameState.Running);
        Game.NowGame.SetTag(GameTag.NowRoundNum, 0);
        
        if(NowGame.UseDRL)
        {
            if(NowGame.IsTrainingMode)
            {
                Game CloneGame = NowGame.GetClone();
                foreach(Player p in NowGame.PlayersInGame)
                {
                    p.Maker.MyDLAgent.GameCopy = CloneGame;
                }
                
            }
        }
        return NowGame;
    }

    public void StartGame(){
        if(m_Mode==GameMode.MarvelSnap)
        {
            foreach (Player p in Game.NowGame.PlayersInGame)
            {
                new EffectGameStart(p).Resolve();
            }
            foreach (Player p in Game.NowGame.PlayersInGame)
            {
                p.Maker.OnTurnStart();
                new StartATurnCommand(p.GetTag(GameTag.IsLowPlayer)).AddToQueue(); 
            }
        }
        else{
            Player whoGoesFirst = Game.NowGame.PlayersInGame[Game.NowGame.GetTag(GameTag.NowPlayingIndex)];
            whoGoesFirst.SetTag(GameTag.GoFirst,1);

            foreach (Player p in Game.NowGame.PlayersInGame)
            {
                new EffectGameStart(p).Resolve();
            }

            whoGoesFirst.Maker.OnTurnStart();
            new StartATurnCommand(whoGoesFirst.GetTag(GameTag.IsLowPlayer)).AddToQueue();            
        }

    }

    public void SwitchTurn(Player p=null)
    {
        UnityEngine.Debug.Log("TurnSwitch");
        //if(this.PlayersInGame[this.GetTag(GameTag.NowPlayingIndex)].hero.Count>0)
        if(m_Mode==GameMode.MarvelSnap)
        {
            new EffectBothTurnEnd(p).Resolve();
        }
        else{
            new EffectTurnEnd(this.PlayersInGame[this.GetTag(GameTag.NowPlayingIndex)]).Resolve();
        }   
    }
    public void EndGame()
    {
        this.SetTag(GameTag.GameState,(int)GameState.GameOver);
    }

    public void CleanDeath()
    {
        foreach (Player p in this.PlayersInGame)
        {
            List<Card> AllCardsInGame = p.hero.Merge(p.board).Merge(p.weapon);//.Merge(p.power).Merge(p.hand).Merge(p.deck);
            for(int i = AllCardsInGame.Count-1; i >= 0; i--)
            {
                if(AllCardsInGame[i].IsDying())
                {
                    new EffectDestroy(AllCardsInGame[i].myPlayer,AllCardsInGame[i],AllCardsInGame[i],createVfx:false).Resolve();
                    //AllCardsInGame[i].Die();
                }
            }
        }
        UpdateAura();      
    }
    public void UpdateAura()
    {
        //return;
        List<Card> AllCardsInGame = new List<Card>();

        foreach (Player p in this.PlayersInGame)
        {
            AllCardsInGame = AllCardsInGame.Merge(p.hero.Merge(p.board).Merge(p.weapon).Merge(p.power).Merge(p.hand).Merge(p.deck).Merge(p.grave));
        }


        for(int i = AllCardsInGame.Count-1; i >= 0; i--)
        {
            Card AuraSource = AllCardsInGame[i];
            for(int j = AuraSource.abilityList.Count-1;j>=0;j--)
            {

                Ability AuraSourceAbility = AuraSource.abilityList[j];
                if(AuraSourceAbility.AuraActive()==false)
                {
                    for(int k = AuraSourceAbility.AuraAffecting.Count-1;k>=0;k--)
                    {
                        AuraSourceAbility.AuraAffecting[k].owner.abilityList.Remove(AuraSourceAbility.AuraAffecting[k]);
                        AuraSourceAbility.AuraAffecting[k].UnRegisterEventEffect();
                        AuraSourceAbility.AuraAffecting.RemoveAt(k);
                    }
                }
                else
                {
                    List<Card> TargetsFound = new List<Card>();
                    foreach(Card T in AllCardsInGame)
                    {
                        if(AuraSourceAbility.AuraBuffThis(T))
                        {
                            bool NotAffected=true;
                            for(int k = AuraSourceAbility.AuraAffecting.Count-1;k>=0;k--)
                            {
                                if(AuraSourceAbility.AuraAffecting[k].owner==T)
                                {
                                    NotAffected=false;
                                    break;
                                }
                            }             
                            if(NotAffected)
                                TargetsFound.Add(T);
                        }
                    }
                    for(int k = TargetsFound.Count-1;k>=0;k--)
                    {
                        Card AuraTarget = TargetsFound[k];
                        string AffectingAbilityName = AuraSourceAbility.AuraBuffName(AuraTarget);
                        if(AffectingAbilityName!=null)
                        {
                            new EffectGiveAbility(AuraSource.myPlayer,AuraSource,AuraTarget,AffectingAbilityName,createVfx:false).Resolve();
                            Ability AffectingAbility = AuraTarget.abilityList.Last();
                            AuraSourceAbility.AuraAffecting.Add(AffectingAbility);                                
                        }
                    }
                }
            }             
        }
    }
}

public abstract class TurnMaker
{
    public CcgAgent MyDLAgent;
    public Player p;
    public AIstrategy m_Strategy = AIstrategy.Balance;
    public List<ActionHistory> ToPlay = new List<ActionHistory>();
    public Thread ThinkingThread;
    public virtual void OnTurnStart()
    {
        if(Game.NowGame.UseDRL)
        {
            MyDLAgent.IsMyTurn=true;
            MyDLAgent.Another.IsMyTurn=false;            
        }
        new EffectTurnStart(this.p).Resolve();
        //new ThinkingMarkerOnCommand().AddToQueue();
        //this.p.OnTurnStart();
    }
    public virtual void Think()
    {
    }
    public virtual void Play()
    { 
    }
    public virtual void Wait(object obj)
    { 
    }
}

public class AITurnMaker : TurnMaker
{
    public override void Think()
    {
        //UnityEngine.Debug.Log("StartThink");
        base.Think();
        foreach (Player pInGame in Game.NowGame.PlayersInGame)
        {
            pInGame.randomGen = new System.Random(pInGame.GetTag(GameTag.RandomSeed));
        }

        switch (this.m_Strategy)
        {
            case (AIstrategy.AFK):
                break;
            case (AIstrategy.Facing):
                Facing FAi = new Facing();
                FAi.p = this.p;
                FAi.MakeFacingAITurn();
                break;
            case (AIstrategy.CheatingMCTS):
                MCTSNode rootNode = new MCTSNode(this.p.myGame.GetClone());
                MCTSNode.DoMonteCarloTreeSearch(rootNode);
                break;
            case(AIstrategy.HBFS):
                HBFSNode BF = new HBFSNode();
                BF.m_data = this.p.myGame.GetClone();
                HBFSNode.DoHeuristicBruteForceSearch(BF);
                break;
            default:
                break;
        }

        Game.NowGame.mainThread.Post(new SendOrPostCallback(this.Wait),null);
    }
   
    public override void Wait(object obj)
    {
        //UnityEngine.Debug.Log("EndThink");
        //new ThinkingMarkerOffCommand().AddToQueue();
        switch (this.m_Strategy)
        {
            case(AIstrategy.HBFS):
                this.p.randomGen = new System.Random(42);
                this.p.otherPlayer.randomGen = new System.Random(42);
                foreach (ActionHistory action in HBFSNode.BestAction)
                {
                    if (action.actType == ActionType.PlayCard)
                    {
                        new EffectPlay(this.p, CardId:action.SourceId, TargetId:action.TargetId).Resolve();
                    }
                    if (action.actType == ActionType.CardAttack)
                    {
                        new EffectAttack(this.p,SourceId:action.SourceId,TargetId:action.TargetId).Resolve();
                    }
                    if (action.actType == ActionType.HeroPower)
                    {
                        new EffectUseHeroPower(this.p,SourceId:action.SourceId,TargetId:action.TargetId).Resolve();
                    }

                    if (action.actType == ActionType.ChooseCardToPlay)
                    {
                        this.p.ChoosingTargetForCardID = action.SourceId;
                        this.p.ChoosingTargetActionType = (int) ActionType.ChooseCardToPlay;
                        this.p.ChoosingTargetOpts = action.TargetingOpt;
                    }
                    if (action.actType == ActionType.ChooseCardToAttack)
                    {
                        this.p.ChoosingTargetForCardID = action.SourceId;
                        this.p.ChoosingTargetActionType = (int) ActionType.ChooseCardToAttack;
                        this.p.ChoosingTargetOpts = action.TargetingOpt;
                    }
                    if (action.actType == ActionType.ChoosePowerToUse)
                    {
                        this.p.ChoosingTargetForCardID = action.SourceId;
                        this.p.ChoosingTargetActionType = (int) ActionType.ChoosePowerToUse;
                        this.p.ChoosingTargetOpts = action.TargetingOpt;
                    }
                    //new EffectDelay(5000).Resolve();
                }
                HBFSNode.BestAction.Clear();
                this.p.myGame.SwitchTurn(this.p);
                //new EffectTurnEnd(this.p).Resolve();
                break;
            case(AIstrategy.CheatingMCTS):
                if(MCTSNode.BestAction.Count>0)
                {
                    ActionHistory action = MCTSNode.BestAction[0];
                    MCTSNode.BestAction.Clear();
                    if(action.actType == ActionType.TurnEnd)
                    {
                        this.p.myGame.SwitchTurn(this.p);
                        //new EffectTurnEnd(this.p).Resolve();
                    }
                    else
                    {
                        if (action.actType == ActionType.PlayCard)
                        {
                            new EffectPlay(this.p, CardId:action.SourceId, TargetId:action.TargetId).Resolve();
                        }
                        if (action.actType == ActionType.CardAttack)
                        {
                            new EffectAttack(this.p,SourceId:action.SourceId,TargetId:action.TargetId).Resolve();
                        }
                        if (action.actType == ActionType.HeroPower)
                        {
                            new EffectUseHeroPower(this.p,SourceId:action.SourceId,TargetId:action.TargetId).Resolve();
                        }
                        if (action.actType == ActionType.ChooseCardToPlay)
                        {
                            this.p.ChoosingTargetForCardID = action.SourceId;
                            this.p.ChoosingTargetActionType = (int) ActionType.ChooseCardToPlay;
                            this.p.ChoosingTargetOpts = action.TargetingOpt;
                        }
                        if (action.actType == ActionType.ChooseCardToAttack)
                        {
                            this.p.ChoosingTargetForCardID = action.SourceId;
                            this.p.ChoosingTargetActionType = (int) ActionType.ChooseCardToAttack;
                            this.p.ChoosingTargetOpts = action.TargetingOpt;
                        }
                        if (action.actType == ActionType.ChoosePowerToUse)
                        {
                            this.p.ChoosingTargetForCardID = action.SourceId;
                            this.p.ChoosingTargetActionType = (int) ActionType.ChoosePowerToUse;
                            this.p.ChoosingTargetOpts = action.TargetingOpt;
                        }
                        if(Game.NowGame.mainThread==null)
                            Game.NowGame.mainThread = SynchronizationContext.Current;
                        //new CreateAiThinkingCommand().AddToQueue();
                        this.ThinkingThread = new Thread(this.Think);
                        this.ThinkingThread.Start();
                    } 
                }
                else
                {
                    this.p.myGame.SwitchTurn(this.p);
                    //new EffectTurnEnd(this.p).Resolve();
                }
                break;              
            default:
                this.p.myGame.SwitchTurn(this.p);
                //new EffectTurnEnd(this.p).Resolve();
                break;
        }
    }

    public override void OnTurnStart()
    {
        //Command.CommandExecutionComplete();
        /*
        if(this.p.GetTag(GameTag.IsSimPlayer)==0)
        {
            if (this.p.GetTag(GameTag.IsControledByAI)==0)
            {
                if (this.p.GetTag(GameTag.IsLowPlayer)==1)
                {
                    if (OneSceneManager.Instance.IsBgMode)
                        new ShowMessageCommand("招揽随从", 2.0f).AddToQueue();
                    else
                        new ShowMessageCommand("你的回合", 2.0f).AddToQueue();
                }
            }
            else
            {
                if (OneSceneManager.Instance.IsBgMode)
                    new ShowMessageCommand("你的回合", 2.0f).AddToQueue();
                if (this.p.GetTag(GameTag.IsLowPlayer)==1)
                {
                    new ShowMessageCommand("你的回合", 2.0f).AddToQueue();
                }

            }
        }
        */

        base.OnTurnStart();
        
        if (this.p.GetTag(GameTag.IsControledByAI)==1)
        {
            if(Game.NowGame.UseDRL)
            {

            }
            else{
                if(this.m_Strategy!=AIstrategy.AFK)
                {
                    if(Game.NowGame.mainThread==null)
                        Game.NowGame.mainThread = SynchronizationContext.Current;
                    //new CreateAiThinkingCommand().AddToQueue();
                    this.ThinkingThread = new Thread(this.Think);
                    this.ThinkingThread.Start();     
                }
                else
                {
                    this.p.myGame.SwitchTurn(this.p);
                    //new EffectTurnEnd(this.p).Resolve();                
                }                
            }
        }
        else
        {
        }
    }

}
