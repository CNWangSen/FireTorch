using System.Collections.Generic;

public class Player
{
    public Game myGame;
    public int ChoosingTargetForCardID = -1;
    public int ChoosingTargetActionType;
    public int ChoosingTargetOpts;

    public TurnMaker Maker;
    public PlayerState PlayerState;
    public Card FatigueCard;
    public DeckDbf deckDbf;
    public System.Random randomGen = new System.Random(42);
    public Player otherPlayer
    {
        get
        {
            if (this.GetTag(GameTag.IsLowPlayer) == 1)
                return myGame.GetPlayerByID((int)GameTag.TopPlayerID);
            else
                return myGame.GetPlayerByID((int)GameTag.LowPlayerID);
        }
        set
        {

        }
    }
    public Card ChoiceSource;
    public List<Card> deck = new List<Card>();
    public List<Card> hand = new List<Card>();
    public List<Card> board = new List<Card>();
    public List<Card> grave = new List<Card>();
    public List<Card> head = new List<Card>();
    public List<Card> hero = new List<Card>();
    public List<Card> power = new List<Card>();
    public List<Card> weapon = new List<Card>();
    public List<Card> removed = new List<Card>();
    public List<Card> aside = new List<Card>();
    public List<Card> minionpower = new List<Card>();
    public List<Card> boardleft = new List<Card>();
    public List<Card> boardright =new List<Card>();
    public List<Card> site = new List<Card>();

    public List<UnitEffectCallBack> EffectCallBacks = new List<UnitEffectCallBack>();
    public void AddCallBack(UnitEffectCallBack CallBack)
    {
        this.EffectCallBacks.Add(CallBack);
    }
    public void RemoveCallBackOf(Ability srcAbility)
    {
        for(int i = this.EffectCallBacks.Count-1;i>=0;i--)
        {
            if(this.EffectCallBacks[i].SourceAbility==srcAbility)
            {
                this.EffectCallBacks.RemoveAt(i); 
            }
        }
    }
    
    private List<List<Card>> m_Zone = null;
    public List<List<Card>> zones
    {
        get
        {
            if (m_Zone == null)
            {
                m_Zone = new List<List<Card>>{
                deck,hand,board,grave,
                head,hero,power,weapon,
                removed,aside,minionpower,
                boardleft,boardright,site};
            }

            return m_Zone;
        }
    }

    public List<int> maxnum = new List<int>
    {
        60,10,7,99999,
        5,2,1,1,
        9999,3,
    };
    private int[] PropertyArr = new int[100];
    
    //private Dictionary<GameTag, int> Property = new Dictionary<GameTag, int>();
    public void ChangeTag(GameTag tg, int cvalue)
    {
        this.SetTag(tg,this.GetTag(tg)+cvalue);
    }
    public int GetTag(GameTag tg)
    {
        return this.PropertyArr[(int)tg];
        /*
        if (!Property.ContainsKey(tg))
        {
            Property.Add(tg, 0);
        }
        */
        //int tagV;
        //Property.TryGetValue(tg, out tagV);
        //return tagV;//Property[tg];
    }
    public void SetTag(GameTag tg, int value)
    {
        this.PropertyArr[(int)tg] = value;
        if (tg == GameTag.ManaLeft || tg== GameTag.ManaThisTurn)
        {
            if (value < 0)
            {
                this.PropertyArr[(int)tg] = 0;
            }
            else if (value > this.GetTag(GameTag.MaxTotalMana))
            {
                this.PropertyArr[(int)tg] = this.GetTag(GameTag.MaxTotalMana);
            }
            else
            {
                this.PropertyArr[(int)tg] = value;
            }
            if (this.GetTag(GameTag.IsSimPlayer)==0)
            {
                new UpdateManaCrystalsCommand(this.GetTag(GameTag.PlayerID), this.GetTag(GameTag.ManaThisTurn), this.GetTag(GameTag.ManaLeft)).AddToQueue();
            }
        }
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
        if (tg == GameTag.ManaLeft || tg== GameTag.ManaThisTurn)
        {
            if (value < 0)
            {
                Property[tg] = 0;
            }
            else if (value > this.GetTag(GameTag.MaxTotalMana))
            {
                Property[tg] = this.GetTag(GameTag.MaxTotalMana);
            }
            else
            {
                Property[tg] = value;
            }
            if (this.GetTag(GameTag.IsSimPlayer)==0)
            {
                new UpdateManaCrystalsCommand(this.GetTag(GameTag.PlayerID), this.GetTag(GameTag.ManaThisTurn), this.GetTag(GameTag.ManaLeft)).AddToQueue();
            }
        }
        */
    }

    public Player(Game nowGame = null, int Id = 0)
    {
        this.myGame = nowGame;
        this.SetTag(GameTag.PlayerID,Id);
        this.SetTag(GameTag.MaxTotalMana,10);
    }
    public Player GetClone()
    {
        Player ClonePlayer = new Player();

        for(int i=0;i<this.PropertyArr.Length;i++)
        {
            ClonePlayer.PropertyArr[i] = this.PropertyArr[i];
        }
        ClonePlayer.PropertyArr[(int)GameTag.IsSimPlayer]=1;
        /*
        ClonePlayer.SetTag(GameTag.IsSimPlayer,1);
        //ClonePlayer.actionHistorys = new List<ActionHistory>();
        foreach (KeyValuePair<GameTag, int> kv in this.Property)
        {
            if(kv.Key!=GameTag.IsSimPlayer)
                ClonePlayer.SetTag(kv.Key, kv.Value);
        }
        */
        return ClonePlayer;
    }
    public void CloneCardFromPlayer(Player FromPlayer)
    {
        this.hero = CopyCardList(this, FromPlayer.hero);
        this.power = CopyCardList(this, FromPlayer.power);
        this.deck = CopyCardList(this, FromPlayer.deck);
        this.hand = CopyCardList(this, FromPlayer.hand);
        this.board = CopyCardList(this, FromPlayer.board);
        this.grave = CopyCardList(this, FromPlayer.grave);
        this.FatigueCard = FromPlayer.FatigueCard.GetClone(this);
    }
    public List<Card> CopyCardList(Player distplayer, List<Card> sourceL)
    {
        List<Card> dist = new List<Card>();
        foreach (Card c in sourceL)
        {
            dist.Add(c.GetClone(distplayer));
        }
        return dist;
    }

    public Card GetCardFromID(int CardID)
    {
        if (CardID < 0)
        {
            return null;
        }
        return myGame.CardsInGame[CardID];
    }
    
    public List<Player> GetFriendlyPlayers()
    {
        List<Player> FriendlyPlayers = new List<Player>();
        foreach (Player p in myGame.PlayersInGame)
        {
            if (p.GetTag(GameTag.TeamID) == this.GetTag(GameTag.TeamID))
            {
                FriendlyPlayers.Add(p);
            }
        }
        return FriendlyPlayers;
    }
    public List<Player> GetOpposingPlayers()
    {
        List<Player> OpposingPlayers = new List<Player>();
        foreach (Player p in myGame.PlayersInGame)
        {
            if (p.GetTag(GameTag.TeamID) != this.GetTag(GameTag.TeamID))
            {
                OpposingPlayers.Add(p);
            }
        }
        return OpposingPlayers;
    }

    public List<Card> GetValidTargetMatchOption(TargetingOptions ta)
    {
        List<Card> MatchedCards = new List<Card>();
        switch (ta)
        {
            case TargetingOptions.AllCharacters:
                foreach (Player p in this.myGame.PlayersInGame) 
                    MatchedCards = MatchedCards.Merge(p.hero).Merge(p.board);
                break;
            case TargetingOptions.OpposingCharacters:
                foreach (Player p in this.GetOpposingPlayers())
                    MatchedCards = MatchedCards.Merge(p.hero).Merge(p.board);
                break;
            case TargetingOptions.FriendlyCharacters:
                foreach (Player p in this.GetFriendlyPlayers())
                    MatchedCards = MatchedCards.Merge(p.hero).Merge(p.board);
                break;

            case TargetingOptions.AllMinions:
                foreach (Player p in this.myGame.PlayersInGame)
                    MatchedCards = MatchedCards.Merge(p.board);
                break;
            case TargetingOptions.OpposingMinions:
                foreach (Player p in this.GetOpposingPlayers())
                    MatchedCards = MatchedCards.Merge(p.board);
                break;
            case TargetingOptions.FriendlyMinions:
                foreach (Player p in this.GetFriendlyPlayers())
                    MatchedCards = MatchedCards.Merge(p.board);
                break;


            case TargetingOptions.AllHeros:
                foreach (Player p in this.myGame.PlayersInGame)
                    MatchedCards = MatchedCards.Merge(p.hero);
                break;



            case TargetingOptions.OpposingCharactersTauntFirst:
                foreach (Player p in this.GetOpposingPlayers())
                {
                    foreach (Card c in p.hero.Merge(p.board))
                    {
                        if (c.HasAbility("Taunt") && !c.HasAbility("Stealth"))
                        {
                            MatchedCards.Add(c);
                        }
                    }
                }
                if (MatchedCards.Count == 0)
                {
                    foreach (Player p in this.GetOpposingPlayers())
                    {
                        foreach (Card c in p.hero.Merge(p.board))
                        {
                            if (!c.HasAbility("Stealth"))
                            {
                                MatchedCards.Add(c);
                            }
                        }
                    }
                }
                break;
            case TargetingOptions.OpposingMinionsTauntFirst:
                foreach (Player p in this.GetOpposingPlayers())
                {
                    foreach (Card c in p.board)
                    {
                        if (c.HasAbility("Taunt"))
                        {
                            MatchedCards.Add(c);
                        }
                    }
                }
                if (MatchedCards.Count == 0)
                {
                    MatchedCards = this.GetValidTargetMatchOption(TargetingOptions.OpposingMinions);
                }
                break;
            case TargetingOptions.FriendlyMinionsAndHands:
                MatchedCards = this.board.Merge(this.hand);
                break;
            case TargetingOptions.FriendlyHands:
                MatchedCards = this.hand;
                break;
            case TargetingOptions.OpposingHands:
                MatchedCards = this.otherPlayer.hand;
                break;
            case TargetingOptions.Any:
                foreach (Player p in this.myGame.PlayersInGame)
                    MatchedCards = MatchedCards.Merge(p.board).Merge(p.hand).Merge(p.deck).Merge(p.weapon).Merge(p.power).Merge(p.hero);
                break;
            default:
                break;
        }
        return MatchedCards;
    }

    public Card GetRandomTargetMatchOption(TargetingOptions ta)
    {
        if (ta == TargetingOptions.NoTarget)
        {
            return null;
        }
        List<Card> allt = GetValidTargetMatchOption(ta);
        return allt.Choice(this.randomGen);
    }

    public bool IsValidTargetForOption(TargetingOptions ta, Card ca)
    {
        if (ta == TargetingOptions.NoTarget)
        {
            return true;
        }
        List<Card> allt = GetValidTargetMatchOption(ta);
        return allt.Contains(ca);
    }
}