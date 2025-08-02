using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


public class FTBG_Fusion : Ability
{
    public void InitDict()
    {
        this.AddFusion("BG_CFM_315","ICC_858","TRL_300");
        this.AddFusion("ICC_858","BG_CFM_315","TRL_300");
    }

    public string FindFusion(string s1,string s2)
    {
        if(FTBG_Fusion.Fusion_Dict.ContainsKey(s1))
        {
            if(FTBG_Fusion.Fusion_Dict[s1].ContainsKey(s2))
            {
                return FTBG_Fusion.Fusion_Dict[s1][s2];
            }
        }
        return "";
    }

    public void AddFusion(string s1,string s2,string mx)
    {
        if(FTBG_Fusion.Fusion_Dict.ContainsKey(s1))
        {
            FTBG_Fusion.Fusion_Dict[s1][s2]=mx;
        }
        else{
            FTBG_Fusion.Fusion_Dict[s1]=new Dictionary<string,string>();
            FTBG_Fusion.Fusion_Dict[s1][s2]=mx;
        }
    }

    public static Dictionary<string,Dictionary<string,string>> Fusion_Dict = new Dictionary<string,Dictionary<string,string>>();
    public static bool InitedDict = false;

    public override void RegisterEventEffect()
    {
        if(!FTBG_Fusion.InitedDict)
        {
            this.InitDict();
            FTBG_Fusion.InitedDict=true;
        }
        base.RegisterEventEffect();
        owner.SetTag(GameTag.AttacksForOneTurn, 100000);
        owner.SetTag(GameTag.AttacksLeftThisTurn, owner.GetTag(GameTag.AttacksForOneTurn));
    }

    public override void Battlecry(Card target=null)
    {
        if(target!=null)
        {
            List<Card> ToFuse = new List<Card>();
            ToFuse.Add(target);
            int AliIndex = target.myPlayer.board.IndexOf(target)+1;
            string s1="";
            string s2="";
            bool FuseIT=false;

            if(AliIndex>=0 && AliIndex< target.myPlayer.board.Count)
            {
                s1=target.cardDbf.m_noteMiniGuid;
                s2=target.myPlayer.board[AliIndex].cardDbf.m_noteMiniGuid;
                ToFuse.Add(target.myPlayer.board[AliIndex]);
          
                string FusedID = this.FindFusion(s1,s2);

                CardDbf FusedDb = null;
                if(FusedID!="")
                    FusedDb = CardDbf.GetCardDbfByGuid(FusedID);
                if(FusedDb!=null)
                {
                    Card Fused = new Card(FusedDb,owner.myPlayer);
                    Fused.SetTag(GameTag.AttackMod,target.PropertyArr[(int)GameTag.AttackMod]+target.myPlayer.board[AliIndex].PropertyArr[(int)GameTag.AttackMod]);
                    Fused.SetTag(GameTag.HealthMod,target.PropertyArr[(int)GameTag.HealthMod]+target.myPlayer.board[AliIndex].PropertyArr[(int)GameTag.HealthMod]);

                    new EffectChange(owner.myPlayer,owner,targets:ToFuse).Resolve();
                    foreach(Card c in ToFuse)
                    {
                        new EffectMove(owner.myPlayer,c,ZoneType.Board,ZoneType.Removed).Resolve();
                    }
                    FuseIT=true;
                    
                    new EffectCreate(owner.myPlayer,Fused,ZoneType.Hand).Resolve();
                    new EffectChange(owner.myPlayer,Fused,Fused,-Fused.GetTag(GameTag.Mana),0,0,0).Resolve();
                }
            }

            if(!FuseIT){
                new EffectChange(owner.myPlayer,target,target,-target.GetTag(GameTag.Mana),0,0,0).Resolve();
                new EffectMove(owner.myPlayer,target,ZoneType.Board,ZoneType.Hand).Resolve();
            }
        }
    }
}


public class FTBG_DIR : Ability
{
    private List<Card> CloneOfHand = new List<Card>();
    private List<Card> CloneOfBoard = new List<Card>();
    private List<Card> CloneOfFrozenBob = new List<Card>();
    private int upgradecost = 6;
    private int prelevel = 1;
    private List<int> _UpgradeCost = new List<int>(){5,6,7,9,9};
    private int roundNum=0;
    private bool IsRecruitPhase=false;
    private int PlayerNum=8;
    private List<CardDbf> AllPlayers = new List<CardDbf>();
    private List<int> AllHps = new List<int>();
    private List<RaceType> AllPlayersRace = new List<RaceType>();
    private int EnemyPlayerIndex=0;

    public void DoBuffPreBand()
    {
        int TotalEnAtk=0;
        int TotalEnHp=0;
        int BuffAtk=0;
        int BuffHp=0;
        int N = owner.myPlayer.board.Count;
        foreach(Card c in CloneOfBoard)
        {
            TotalEnAtk+=c.GetTag(GameTag.Attack);
            TotalEnHp+=c.GetTag(GameTag.Health);
        }
        foreach(Card c in owner.myPlayer.board)
        {
            TotalEnAtk-=c.GetTag(GameTag.Attack);
            TotalEnHp-=c.GetTag(GameTag.Health);
        }
        if(TotalEnAtk<0)
        {
            TotalEnAtk=0;
        }
        if(TotalEnHp<0)
        {
            TotalEnHp=0;
        }
        BuffAtk=roundNum/15;//TotalEnAtk/(2*N)+roundNum/30;//+(owner.cardDbf.MaxHealth-owner.GetTag(GameTag.Health))/30
        BuffHp=roundNum/15;//TotalEnHp/(2*N)+roundNum/30;//+(owner.cardDbf.MaxHealth-owner.GetTag(GameTag.Health))/30
        if(BuffAtk>0)
        {
            foreach(Card c in owner.myPlayer.board)
            {
                new EffectChange(owner.myPlayer,owner,c,0,BuffAtk,0,0,visualFx:false).Resolve();
            }
        }
        if(BuffHp>0)
        {
            foreach(Card c in owner.myPlayer.board)
            {
                new EffectChange(owner.myPlayer,owner,c,0,0,BuffHp,0,visualFx:false).Resolve();
            }
        }
    }
    public List<int> GetTierAndNumForRound(List<CardDbf> TargetAsset)
    {
        int BobLevel=0;
        int N=0;
        int GoldenN=Mathf.Min(Mathf.Max((roundNum-4)/2,0),7);

        switch(roundNum)
        {
            case(1):
            N=1;
            BobLevel=1;
            break;
            case(2):
            N=1;
            BobLevel=1;
            break;
            case(3):
            N=2;
            BobLevel=2;
            break;
            case(4):
            N=4;
            BobLevel=2;
            break;
            case(5):
            N=5;
            BobLevel=2;
            break;
            case(6):
            N=7;
            BobLevel=3;
            break;           
            default:
            N=7;
            BobLevel=3;
            break;
        }
        
        if(roundNum>=11)
        {
            BobLevel=6;
        }
        else if(roundNum>=9)
        {
            BobLevel=5;
        }
        else if(roundNum>=7)
        {
            BobLevel=4;
        }
        else
        {

        }
        return new List<int>{BobLevel,N,GoldenN};
    }
    public List<Card> GetPreBandForRound(List<CardDbf> TargetAsset,int BobLevel,int N,int GoldenN)
    {

        List<Card> PreBand=new List<Card>();
        int nowGolden=0;
        /*foreach(CardDbf ca in TargetAsset)
        {
            if(ca.ManaCost<=BobLevel && PreBand.Count<=N)
            {
                Card BobCard=new Card(ca,owner.myPlayer);
                if(nowGolden<GoldenN)
                {
                    BobCard.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
                    BobCard.SetTag(GameTag.Attack,BobCard.GetTag(GameTag.Attack)+ca.Attack);
                    BobCard.SetTag(GameTag.Health,BobCard.GetTag(GameTag.Health)+ca.MaxHealth);
                    nowGolden+=1;
                }
                PreBand.Add(BobCard);
            }
        }*/
        int RandomNum=0;


        List<CardDbf> NewPool = new List<CardDbf>();//CardDbf.FiltByMana(CardDbf.AllCardDbf, 0);

        for (int j = Mathf.Max((BobLevel-1),1); j <=BobLevel; j++)
        {
            if(j-1<FTBG_Refresh.Pools.Count && j-1>=0)
                NewPool=NewPool.Merge(FTBG_Refresh.Pools[j-1]);
        }
 
        RaceType ToFind = AllPlayersRace[EnemyPlayerIndex];
        List<CardDbf> NewPoolPure = new List<CardDbf>();
        foreach(CardDbf db in NewPool)
        {
            //if(db.RaceType.Contains(ToFind) || db.RaceType.Contains(RaceType.All))
            //{
                NewPoolPure.Add(db);
            //}
        }

    
        for(int i=PreBand.Count;i<N;i++)
        {
            RandomNum+=1;
            CardDbf chosen = NewPoolPure.Choice();
            if(chosen!=null)
            {
                Card BobCard=new Card(chosen,owner.myPlayer);
                if(nowGolden<GoldenN)
                {
                    BobCard.SetTag(GameTag.PremiumType, (int)PremiumType.Golden);
                    BobCard.SetTag(GameTag.Attack,BobCard.GetTag(GameTag.Attack)+chosen.Attack);
                    BobCard.SetTag(GameTag.Health,BobCard.GetTag(GameTag.Health)+chosen.MaxHealth);
                    nowGolden+=1;
                }
                PreBand.Add(BobCard);                
            }
        }
        if(RandomNum>=1)
        {
           for(int i=0;i<PreBand.Count-1;i++)
           {
                for(int j=0;j<PreBand.Count-1-i;j++)
                {
                    if(PreBand[j].GetTag(GameTag.Attack)<PreBand[j+1].GetTag(GameTag.Attack))
                    {
                        Card TempCard = PreBand[j];
                        PreBand[j]=PreBand[j+1];
                        PreBand[j+1]=TempCard;
                    }
                }
            }   
        }
        return PreBand;
    }

    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterGameStart(this,SetCombat));

        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterGameStart(this,PrepareRecurit));
        owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,PrepareCombat));
        //owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,EndCombat));

        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterMove(this,CardCombineCheck));
        owner.myPlayer.otherPlayer.AddCallBack(new CallBackAfterCreate(this,CardCombineCheck));
        List<RaceType> possibleRaces = new List<RaceType>(){RaceType.Demon,RaceType.Murloc,RaceType.Beast,RaceType.Mechanical};
        for(int i =0;i<PlayerNum-1;i++)
        {
            AllPlayers.Add(CardDbf.GetCardDbfByGuid("FTBG_BOSS"+i.ToString()));
            AllHps.Add(50);           
            AllPlayersRace.Add(possibleRaces.Choice(owner.myPlayer.randomGen)); 
        }
        owner.myPlayer.maxnum = new List<int>
        {
            999,10,7,99999,
            5,2,4,1,
            9999,3,
        };
        Game.NowGame.m_Mode=GameMode.BattleGround;
        if(owner.myPlayer.Maker!=null)
        {
            owner.myPlayer.Maker.m_Strategy = AIstrategy.AFK;
        }
        OneSceneManager.Instance.IsBgMode=true;

        GoldenOverrideDict["FP1_010"]="TB_BaconUps_155";
        GoldenOverrideDict["BGS_022"]="TB_BaconUps_091";
        GoldenOverrideDict["BGS_080"]="TB_BaconUps_142";
        GoldenOverrideDict["BG_GVG_113"]="TB_BaconUps_153";
        GoldenOverrideDict["BGS_032"]="TB_BaconUps_103";
        GoldenOverrideDict["BGS_018"]="TB_BaconUps_085";
        GoldenOverrideDict["BGS_126"]="TB_BaconUps_166";
        GoldenOverrideDict["BGS_019"]="TB_BaconUps_102";
        GoldenOverrideDict["GVG_021"]="TB_BaconUps_060";
 
        GoldenOverrideDict["BGS_044"]="TB_BaconUps_116";
        GoldenOverrideDict["BGS_079"]="TB_BaconUps_137";
        GoldenOverrideDict["BGS_008"]="TB_BaconUps_057";
        GoldenOverrideDict["BGS_006"]="TB_BaconUps_080";
        GoldenOverrideDict["BG_FP1_024"]="TB_BaconUps_118";
        GoldenOverrideDict["BGS_047"]="TB_BaconUps_134";
    }
    private string GetGoldenCardID(string rawid)
    {
        //if(GoldenOverrideDict.ContainsKey(rawid))
        //{
        //    return GoldenOverrideDict[rawid];
        //}
        return rawid+"_G";
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);

        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
        owner.myPlayer.RemoveCallBackOf(this);
        owner.myPlayer.RemoveCallBackOf(this);

        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
        owner.myPlayer.otherPlayer.RemoveCallBackOf(this);
    }

    private Dictionary<string,string> GoldenOverrideDict = new Dictionary<string,string>();
    public void CardCombineCheck(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if((ZoneType)owner.GetTag(GameTag.ZoneType)==ZoneType.Deck && IsRecruitPhase)
        {
            if((tz==ZoneType.Board || tz==ZoneType.Hand ) && (PremiumType)sc.GetTag(GameTag.PremiumType)==PremiumType.Normal)
            {
                Card One=null;
                Card Two=null;
                foreach(Card c in owner.myPlayer.otherPlayer.board.Merge(owner.myPlayer.otherPlayer.hand))
                {
                    if(c.cardDbf==sc.cardDbf && c!=sc && (PremiumType)c.GetTag(GameTag.PremiumType)==PremiumType.Normal)
                    {
                        if(One==null)
                        {
                            One=c;
                        }
                        else
                        {
                            if(Two==null)
                            {
                                Two=c;
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }

                if(One!=null && Two!=null)
                {
                    new EffectMove(owner.myPlayer.otherPlayer, One,(ZoneType)One.GetTag(GameTag.ZoneType),ZoneType.Removed,silent:true).Resolve();
                    new EffectMove(owner.myPlayer.otherPlayer, Two,(ZoneType)Two.GetTag(GameTag.ZoneType),ZoneType.Removed,silent:true).Resolve();
                    new EffectMove(owner.myPlayer.otherPlayer, sc,(ZoneType)sc.GetTag(GameTag.ZoneType),ZoneType.Removed,silent:true).Resolve();
                    Card GoldenCard=new Card(CardDbf.GetCardDbfByGuid(GetGoldenCardID(sc.cardDbf.m_noteMiniGuid)),owner.myPlayer.otherPlayer);

                    int AtkMod=One.PropertyArr[(int)GameTag.AttackMod]+Two.PropertyArr[(int)GameTag.AttackMod]+sc.PropertyArr[(int)GameTag.AttackMod];
                    int HpMod=One.PropertyArr[(int)GameTag.HealthMod]+Two.PropertyArr[(int)GameTag.HealthMod]+sc.PropertyArr[(int)GameTag.HealthMod];

                    GoldenCard.SetTag(GameTag.AttackMod,AtkMod);
                    GoldenCard.SetTag(GameTag.HealthMod,HpMod);
                    GoldenCard.SetTag(GameTag.PremiumType,(int)PremiumType.Golden);
                    new EffectCreate(owner.myPlayer.otherPlayer,GoldenCard,ZoneType.Hand).Resolve();
                    new EffectChange(owner.myPlayer.otherPlayer,GoldenCard,GoldenCard,-GoldenCard.GetTag(GameTag.Mana),0,0,0).Resolve();
                }
            }

            if(tz==ZoneType.Board && (PremiumType)sc.GetTag(GameTag.PremiumType)==PremiumType.Golden && IsRecruitPhase && sc.GetTag(GameTag.CardType)==(int)CardType.Minion)
            {
                CardDbf RewardAsset = CardDbf.GetCardDbfByGuid("FTBG_TripleReward");
                int DisLevel=Mathf.Min(owner.myPlayer.otherPlayer.hero[0].GetTag(GameTag.Mana) + 1,5);
                RewardAsset.Description="发现一个等级"+(DisLevel+1).ToString()+"的随从。";
                Card RewardCard = new Card(RewardAsset,owner.myPlayer.otherPlayer);
                RewardCard.abilityList[0].amounts[0]=DisLevel;
                new EffectCreate(owner.myPlayer.otherPlayer,RewardCard,ZoneType.Hand).Resolve();
            }
        }
    }
    public void SetCombat()
    {
        owner.myPlayer.SetTag(GameTag.ManaThisTurn,2);
        owner.myPlayer.otherPlayer.SetTag(GameTag.ManaThisTurn,2);
    }

    public void PrepareRecurit()
    {
        new ChangeBaconShopBgmCommand(true).AddToQueue();
        //BaconShopChangeBgm.Instance.Change(true);
        
        List<CardDbf> sortedAsset= new List<CardDbf>();
        List<int> sortedHp = new List<int>();
        sortedAsset=sortedAsset.Merge(AllPlayers).Mix(owner.myPlayer.otherPlayer.hero[0].cardDbf);
        sortedHp=sortedHp.Merge(AllHps).Mix(owner.myPlayer.otherPlayer.hero[0].GetTag(GameTag.Health) );

        for(int i=0;i<sortedAsset.Count-1;i++)
        {
            for(int j=0;j<sortedAsset.Count-1-i;j++)
            {
                if(sortedHp[j]<sortedHp[j+1])
                {
                    int tempHp = sortedHp[j];
                    CardDbf tempAss = sortedAsset[j];
                    sortedHp[j]=sortedHp[j+1];
                    sortedAsset[j]=sortedAsset[j+1];
                    sortedHp[j+1]=tempHp;
                    sortedAsset[j+1]=tempAss;
                }
            }
        }
        
        List<int> AliveEnemy=new List<int>();
        for(int i =0;i<AllHps.Count;i++)
        {
            if(AllHps[i]>0)
            {
                AliveEnemy.Add(i);
            }
        }

        if(AliveEnemy.Count==0)
        {
            EnemyPlayerIndex=0;
            if(!(owner.myPlayer.GetTag(GameTag.IsSimPlayer)==1))
            {
                new CreateDelayCommand(3f).AddToQueue();
                if(!OneSceneManager.Instance.IsMyScene){
                    new ChangeSceneCommand("ChooseDeckHS").AddToQueue();
                }
                else{
                    new ChangeSceneCommand("ChooseDeckMy").AddToQueue();
                }
            } 
        }
        else
        {        
            EnemyPlayerIndex=AliveEnemy.Choice();
        }

        Card Bob = TaskCreate(CardDbf.GetCardDbfByGuid("FTBG_Bob"),ZoneType.Hero);
        
        List<CardDbf> Soted = new List<CardDbf>();
        foreach (CardDbf db in sortedAsset)
        {
            Soted.Add(db);
        }
        new UpdateLeaderBoardCommand(Soted,sortedHp,AllPlayers[EnemyPlayerIndex]).AddToQueue();
        
        //Add Bob
        //new EffectChange(owner.myPlayer,rt(owner,CardAsset.GetCardAssetByDbfId(owner.cardDbf.DbfId)).Resolve();
        //
        //owner.SetTag(GameTag.Damage,0);
        new EffectChange(owner.myPlayer,owner,Bob,0,owner.myPlayer.otherPlayer.hero[0].GetTag(GameTag.Mana)+1,0,0,visualFx:false).Resolve();

        List<Card> ToDestroy = new List<Card>();
        foreach(Card c in owner.myPlayer.hero)
        {
            if(c.cardDbf.m_noteMiniGuid!="FTBG_Bob")
                ToDestroy.Add(c);
        }
        foreach(Card c in owner.myPlayer.otherPlayer.power)
        {
            ToDestroy.Add(c);
        }
        foreach(Card c in ToDestroy)
        {
            new EffectMove(c.myPlayer,c,ZoneType.Power,ZoneType.Removed,silent:true).Resolve();
        }
        //TaskDestroyTargets(ToDestroy);

        CardDbf Refresh = CardDbf.GetCardDbfByGuid("FTBG_Refresh");
        Card AutoRefresh = new Card(Refresh,owner.myPlayer.otherPlayer);
        new EffectCreate(owner.myPlayer.otherPlayer,AutoRefresh,ZoneType.Power).Resolve();

        CardDbf Freeze = CardDbf.GetCardDbfByGuid("FTBG_Fusion");
        new EffectCreate(owner.myPlayer.otherPlayer,new Card(Freeze,owner.myPlayer.otherPlayer),ZoneType.Power).Resolve();

        if(CloneOfFrozenBob.Count!=0)
        {
            for(int i=0;i<CloneOfFrozenBob.Count;i++)
            {
                Card c = CloneOfFrozenBob[i];
                new EffectCreate(owner.myPlayer,c,ZoneType.Board, silent:true).Resolve();
                new EffectRemoveAbility(owner.myPlayer, owner,c,"Frozen").Resolve();
            }
        }
        else
        {
            owner.myPlayer.otherPlayer.power[0].abilityList[0].Battlecry();
        }

        if (owner.myPlayer.otherPlayer.hero[0].GetTag(GameTag.Mana) + 1 < 6)
        {
            if (prelevel == owner.myPlayer.otherPlayer.hero[0].GetTag(GameTag.Mana) + 1)
            {
                upgradecost -= 1;
            }
            else
            {
                prelevel = owner.myPlayer.otherPlayer.hero[0].GetTag(GameTag.Mana) + 1;
                upgradecost = _UpgradeCost[prelevel-1];
            }
            upgradecost = Mathf.Min(Mathf.Max(upgradecost, 0), 11);

            CardDbf Upgrade = CardDbf.GetCardDbfByGuid("FTBG_Upgrade");
            //Upgrade.ManaCost = upgradecost;
            Upgrade.Description = "升级酒馆， 目前" + (owner.myPlayer.otherPlayer.hero[0].GetTag(GameTag.Mana) + 1).ToString() + "级";
            Card upgrade_power = new Card(Upgrade,owner.myPlayer.otherPlayer);
            new EffectCreate(owner.myPlayer.otherPlayer,upgrade_power,ZoneType.Power).Resolve();

            new EffectChange(owner.myPlayer,upgrade_power, upgrade_power, -(upgrade_power.GetTag(GameTag.Mana) - upgradecost), 0, 0, 0,visualFx:false).Resolve();
        }

        for(int i=0;i<CloneOfBoard.Count;i++)
        {
            Card c = CloneOfBoard[i];
            //c.SetTag(GameTag.AttacksLeftThisTurn,0);
            new EffectCreate(owner.myPlayer.otherPlayer,c,ZoneType.Board, silent:true).Resolve();
        }

        IsRecruitPhase=true;
    }
    public void PrepareCombat()
    {
        new ChangeBaconShopBgmCommand(false).AddToQueue();
        for(int i=owner.myPlayer.hero.Count-1;i>=0;i--)
        {
            new EffectMove(owner.myPlayer,owner.myPlayer.hero[i],ZoneType.Hero,ZoneType.Removed).Resolve();
        }

        TaskCreate(AllPlayers[EnemyPlayerIndex],ZoneType.Hero);

        IsRecruitPhase=false;
        //Clone Alice
        CloneOfHand.Clear();
        CloneOfBoard.Clear();
        CloneOfFrozenBob.Clear();
        foreach(Card c in owner.myPlayer.board)
        {
            if(c.HasAbility("Frozen"))
            {
                Card newC = c.GetClone(owner.myPlayer, true);
                newC.SetTag(GameTag.ZoneType,(int)ZoneType.Removed);
                CloneOfFrozenBob.Add(newC);                 
            }
        }

        foreach (Card c in owner.myPlayer.otherPlayer.board)
        {
            Card newC = new Card(c.cardDbf,owner.myPlayer.otherPlayer);//c.GetClone(owner.myPlayer.otherPlayer, true);
            newC.SetTag(GameTag.ZoneType, (int)ZoneType.Removed);

            List<string> possibelabi = new List<string>(){"DivineShield","Poisonous","Taunt","WindFury"};
            foreach(string s in possibelabi)
            {
                if(c.HasAbility(s) && !newC.HasAbility(s))
                {
                    new EffectGiveAbility(owner.myPlayer,newC,newC,s,createVfx:false).Resolve();
                }                    
            }

            newC.SetTag(GameTag.AttackMod,c.PropertyArr[(int)GameTag.AttackMod]);
            newC.SetTag(GameTag.HealthMod,c.PropertyArr[(int)GameTag.HealthMod]);
            newC.SetTag(GameTag.PremiumType,c.GetTag(GameTag.PremiumType));
            CloneOfBoard.Add(newC);

        }
        foreach (Card c in owner.myPlayer.otherPlayer.hand)
        {
            Card newC = c.GetClone(owner.myPlayer.otherPlayer, true);
            newC.SetTag(GameTag.ZoneType,(int)ZoneType.Removed);
            CloneOfHand.Add(newC);
        }

        //Clean Bob
        new EffectChange(owner.myPlayer,owner,owner.myPlayer.hero[0],0,-owner.myPlayer.hero[0].GetTag(GameTag.Attack),0,0,visualFx:false).Resolve();
        List<Card> Temp = new List<Card>();
        foreach (Card c in owner.myPlayer.board)
        {
            Temp.Add(c);
        }
        foreach (Card c in Temp)
        {
            new EffectMove(owner.myPlayer, c,ZoneType.Board,ZoneType.Removed,silent:true).Resolve();
        }

        for (int i = owner.myPlayer.otherPlayer.power.Count-1; i >= 0; i--)
        {
            new EffectMove(owner.myPlayer.otherPlayer, owner.myPlayer.otherPlayer.power[i],ZoneType.Power,ZoneType.Removed,silent:true).Resolve();
        }
        
        //new EffectCreate(owner.myPlayer,new Card(CardDbf.FiltByType(CardDbf.AllCardDbf, CardType.HeroPower).Choice(),owner.myPlayer),ZoneType.Power).Resolve();


        //new EffectChange(owner.myPlayer,rt(owner,CardAsset.GetCardAssetByDbfId(AllPlayers[EnemyPlayerIndex].DbfId)).Resolve();
        new EffectChange(owner.myPlayer,owner,owner.myPlayer.hero[0],0,0,-owner.myPlayer.hero[0].GetTag(GameTag.Health)+AllHps[EnemyPlayerIndex],0,visualFx:false).Resolve();

        //Add Bob
        roundNum+=1;
        List<int> Res= GetTierAndNumForRound(null);
        int BobLevel=Res[0];
        int N=Res[1];
        int GoldenN=Res[2];
        List<Card> PreBand = GetPreBandForRound(null,BobLevel,N,GoldenN);
        foreach(Card BobCard in PreBand)
        {
           new EffectCreate(owner.myPlayer,BobCard,ZoneType.Board).Resolve();
        }
        DoBuffPreBand();

        this.Battle();
        this.Finish();

        if(owner.myPlayer.hero.Count>0)
        {
            AllHps[EnemyPlayerIndex]=owner.myPlayer.hero[0].GetTag(GameTag.Health);
        }
        else
        {
            AllHps[EnemyPlayerIndex]=0;
        }
        new CreateDelayCommand(0.7f).AddToQueue();
        this.EndCombat();

        this.PrepareRecurit();
        //this.StartCombat();
        //12种1星卡，16种2星卡，17种3星卡，14种4星卡，13种5星卡，9种6星卡
        //1星怪在卡池有18张，同种2星怪15张，同种3星13张，同种4星11张，同种5星9张，同种6星6张
    }

    public void Battle()
    {
        List<Player> AllP = new List<Player> { owner.myPlayer, owner.myPlayer.otherPlayer };
        int PlayerIndex = 0;
        int RoundNum = 0;

        if (owner.myPlayer.board.Count > owner.myPlayer.otherPlayer.board.Count)
        {
            PlayerIndex = 0;
        }
        else if(owner.myPlayer.board.Count < owner.myPlayer.otherPlayer.board.Count)
        {
            PlayerIndex = 1;
        }
        else{
            List<int> IndexList = new List<int>() { 0, 1 };
            PlayerIndex = IndexList.Choice(owner.myPlayer.randomGen);
        }

        foreach (Card m in AllP[PlayerIndex].board)
        {
            m.SetTag(GameTag.AttacksLeftThisTurn, m.GetTag(GameTag.AttacksForOneTurn));
        }
        foreach (Card m in AllP[PlayerIndex].otherPlayer.board)
        {
            m.SetTag(GameTag.AttacksLeftThisTurn, m.GetTag(GameTag.AttacksForOneTurn));
        }

        List<Card> OCS1 = new List<Card>();
        foreach(Card c in AllP[PlayerIndex].board)
        {
            OCS1.Add(c);
        }
        foreach (Card c in OCS1)
        {
            if(c.GetTag(GameTag.ZoneType) == (int)ZoneType.Board)
            {
                List<Ability> ABS = new List<Ability>();
                foreach (Ability abi in c.abilityList)
                {
                    ABS.Add(abi);
                }
                foreach (Ability abi in ABS)
                {
                    abi.OnCombatStart();
                }
            }
        }

        List<Card> OCS2 = new List<Card>();
        foreach(Card c in AllP[PlayerIndex].otherPlayer.board)
        {
            OCS2.Add(c);
        }

        foreach (Card c in OCS2)
        {
            if(c.GetTag(GameTag.ZoneType) == (int)ZoneType.Board)
            {
                List<Ability> ABS = new List<Ability>();
                foreach (Ability abi in c.abilityList)
                {
                    ABS.Add(abi);
                }
                foreach (Ability abi in ABS)
                {
                    abi.OnCombatStart();
                }
            }
        }

        while (owner.myPlayer.board.Count != 0 && owner.myPlayer.otherPlayer.board.Count != 0 && RoundNum < 1000)
        {
            Card Atker = null;
            Card Atked = null;

            foreach (Card m in AllP[PlayerIndex].board)
            {
                if (m.GetTag(GameTag.AttacksLeftThisTurn) > 0 && m.GetTag(GameTag.Attack) > 0)
                {
                    Atker = m;
                    break;
                }
            }
            if (Atker == null)
            {
                foreach (Card m in AllP[PlayerIndex].board)
                {
                    m.SetTag(GameTag.AttacksLeftThisTurn, m.GetTag(GameTag.AttacksForOneTurn));
                }
                foreach (Card m in AllP[PlayerIndex].board)
                {
                    if (m.GetTag(GameTag.AttacksLeftThisTurn) != 0 && m.GetTag(GameTag.Attack) != 0)
                    {
                        Atker = m;
                        break;
                    }
                }
            }

            List<Card> Taunt_Minions = new List<Card>();
            foreach (Card c in AllP[PlayerIndex].otherPlayer.board)
            {
                if (c.HasAbility("Taunt"))
                {
                    Taunt_Minions.Add(c);
                }
            }

            if (Taunt_Minions.Count == 0)
            {
                Atked = AllP[PlayerIndex].otherPlayer.board.Choice(AllP[PlayerIndex].otherPlayer.randomGen);
            }
            else
            {
                Atked = Taunt_Minions.Choice(AllP[PlayerIndex].otherPlayer.randomGen);
            }

            if (Atker != null & Atked != null)
            {
                new EffectAttack(Atker.myPlayer,Atker,Atked).Resolve();
                new CreateDelayCommand(0.5f).AddToQueue();
                if (Atker.GetTag(GameTag.AttacksLeftThisTurn) > 0 && Atker.GetTag(GameTag.Health)>0 && Atker.GetTag(GameTag.ZoneType)==(int)ZoneType.Board)
                {
                    PlayerIndex -= 1;
                }
            }

            PlayerIndex += 1;
            PlayerIndex = PlayerIndex % 2;
            RoundNum += 1;

        }

    }
    public void Finish()
    {
        Player Winner = null;
        if (owner.myPlayer.board.Count != 0)
        {
            Winner = owner.myPlayer;
        }
        else
        {
            if (owner.myPlayer.otherPlayer.board.Count != 0)
            {
                Winner = owner.myPlayer.otherPlayer;
            }
        }
        if (Winner != null)
        {
            UnityEngine.Debug.Log("------------------------------------BG end has winner-------------------");
            
            if(Winner.GetTag(GameTag.IsLowPlayer)==1)
            {
                UnityEngine.Debug.Log("Low Win");
            }
            else{
                UnityEngine.Debug.Log("Top Win");
            }
            UnityEngine.Debug.Log("Board Left Count: "+Winner.board.Count.ToString());
            UnityEngine.Debug.Log("Board ZeroLeftHp: "+Winner.board[0].GetTag(GameTag.Health).ToString());

            //UnityEngine.Debug.Log();
            if(Winner.hero.Count>0 && Winner.otherPlayer.hero.Count>0)
            {
                //Winner.hero[0].SetTag(GameTag.Mana,6);
                new EffectChange(Winner,Winner.hero[0], Winner.hero[0], 0, Winner.hero[0].GetTag(GameTag.Mana), 0, 0,visualFx:false).Resolve();
                foreach (Card c in Winner.board)
                {
                    //Winner.D
                    //new EffectDamage(,c, Winner.otherPlayer.hero[0], c.GetTag(GameTag.Mana)).Resolve();
                    c.SetTag(GameTag.AttacksLeftThisTurn, 0);
                    //new EffectChange(Winner,Winner.hero[0], c).Resolve();
                    new EffectChange(Winner,c,Winner.hero[0],0,assignVfxType:VfxType.BaconStar).Resolve();
                    //new EffectChange(Winner,Winner.hero[0], Winner.hero[0], 0, c.cardDbf.ManaCost, 0, 0).Resolve();
                }
                new CreateDelayCommand(0.85f-0.1f*Winner.board.Count).AddToQueue();
                foreach (Card c in Winner.board)
                {
                    int toBuff = c.cardDbf.ManaCost;
                    if(toBuff>7)
                    {
                        toBuff=7;
                    }
                    //new EffectChange(Winner,c,Winner.hero[0],0,assignVfxType:VfxType.BaconStar).Resolve();
                    new EffectChange(Winner,Winner.hero[0], Winner.hero[0], 0, toBuff, 0, 0,visualFx:false).Resolve();
                    new CreateDelayCommand(0.2f).AddToQueue();
                }
                new CreateDelayCommand(0.4f).AddToQueue();
                new EffectAttack(Winner,Winner.hero[0],Winner.otherPlayer.hero[0]).Resolve();
                //new CreateDelayCommand(10f).AddToQueue();
                new EffectChange(Winner,Winner.hero[0], Winner.hero[0], 0, -Winner.hero[0].GetTag(GameTag.Attack) + Winner.hero[0].cardDbf.Attack, 0, 0, visualFx:false).Resolve();

            }

        }

        //new CreateDelayCommand(1f).AddToQueue();
        //new QuitGameCommand().AddToQueue();
        //UnityEngine.Application.Quit();
        //new ChangeSceneCommand("Roguelike").AddToQueue();
    }

    public void Clean()
    {
        for(int i=owner.myPlayer.hero.Count-1;i>=0;i--)
        {
            new EffectMove(owner.myPlayer,owner.myPlayer.hero[i],ZoneType.Hero,ZoneType.Removed).Resolve();
        }
        for(int i=owner.myPlayer.board.Count-1;i>=0;i--)
        {
            new EffectMove(owner.myPlayer,owner.myPlayer.board[i],ZoneType.Board,ZoneType.Removed).Resolve();
        }
        for(int i=owner.myPlayer.otherPlayer.board.Count-1;i>=0;i--)
        {
            new EffectMove(owner.myPlayer.otherPlayer,owner.myPlayer.otherPlayer.board[i],ZoneType.Board,ZoneType.Removed).Resolve();
        }
        for(int i=owner.myPlayer.hand.Count-1;i>=0;i--)
        {
            new EffectMove(owner.myPlayer,owner.myPlayer.hand[i],ZoneType.Hand,ZoneType.Removed).Resolve();
        }
        for(int i=owner.myPlayer.otherPlayer.hand.Count-1;i>=0;i--)
        {
            new EffectMove(owner.myPlayer.otherPlayer,owner.myPlayer.otherPlayer.hand[i],ZoneType.Hand,ZoneType.Removed).Resolve();
        }        
    }

    public void EndCombat()
    {
            //Clean All Board
        List<Card> Temp = new List<Card>();
        foreach (Card c in owner.myPlayer.board)
        {
            Temp.Add(c);
        }
        foreach (Card c in Temp)
        {
            new EffectMove(owner.myPlayer, c,ZoneType.Board,ZoneType.Removed,silent:true).Resolve();
        }

        List<Card> Temp2 = new List<Card>();
        foreach (Card c in owner.myPlayer.otherPlayer.board)
        {
            Temp2.Add(c);
        }
        foreach (Card c in Temp2)
        {
            new EffectMove(owner.myPlayer.otherPlayer, c,ZoneType.Board,ZoneType.Removed,silent:true).Resolve();
        }

            //Clean Bob Power
        for(int i = owner.myPlayer.power.Count-1;i>=0;i--)
        {
            new EffectMove(owner.myPlayer, owner.myPlayer.power[i],ZoneType.Power,ZoneType.Removed,silent:true).Resolve();
        }

        List<int> ToZ= new List<int>{0,1,2,3,4,5};
        for(int i =0;i<AllHps.Count;i++)
        {
            if(i!=EnemyPlayerIndex)
            {
                if(ToZ.Choice()<=2)
                {
                    AllHps[i]-=(int)((float)ToZ.Choice()*(float)roundNum/4f);                   
                }                
            }
        }
    }
}


public class FTBG_Refresh : Ability
{
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.SetTag(GameTag.AttacksForOneTurn,100000);
        owner.SetTag(GameTag.AttacksLeftThisTurn,owner.GetTag(GameTag.AttacksForOneTurn));
    }

    public static List<List<CardDbf>> Pools = null;
    public override void Battlecry(Card target = null)
    {
        if(Pools==null)
        {
            Pools= new List<List<CardDbf>>(){CardDbf.AllBGS1Dbf,CardDbf.AllBGS2Dbf,CardDbf.AllBGS3Dbf,CardDbf.AllBGS4Dbf,CardDbf.AllBGS5Dbf,CardDbf.AllBGS6Dbf,CardDbf.AllBGS7Dbf};
        }
        base.Battlecry(target);
        List<Card> Temp = new List<Card>();
        foreach (Card c in owner.myPlayer.otherPlayer.board)
        {
            Temp.Add(c);
        }
        foreach (Card c in Temp)
        {
            new EffectMove(owner.myPlayer.otherPlayer, c,ZoneType.Board,ZoneType.Removed,silent:true).Resolve();
        }
        int N=0;
        switch(owner.myPlayer.hero[0].GetTag(GameTag.Mana)+1)
        {
            case(1):
            N=3;
            break;
            case(2):
            N=4;
            break;
            case(3):
            N=4;
            break;
            case(4):
            N=5;
            break;
            case(5):
            N=5;
            break;
            case(6):
            N=6;
            break;
            default:
            N=6;
            break;
        }
        List<CardDbf> NewPool = new List<CardDbf>();//CardDbf.FiltByMana(CardDbf.AllCardDbf, 0);
        for (int j = 1; j <= owner.myPlayer.hero[0].GetTag(GameTag.Mana) + 1; j++)
        {
            if(j-1<Pools.Count && j-1>=0)
                NewPool=NewPool.Merge(Pools[j-1]);
        }

        for (int i = 0; i <N; i++)
        {
            CardDbf chosen = NewPool.Choice();
            if(chosen!=null)
            new EffectCreate(owner.myPlayer.otherPlayer,new Card(chosen,owner.myPlayer.otherPlayer),ZoneType.Board,silent:true).Resolve();
        }
    }

}

public class FTBG_Freeze : Ability
{
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        owner.SetTag(GameTag.AttacksForOneTurn, 100000);
        owner.SetTag(GameTag.AttacksLeftThisTurn, owner.GetTag(GameTag.AttacksForOneTurn));
    }
    private bool Freezed=false;
    public override void Battlecry(Card target = null)
    {
        base.Battlecry(target);
        List<string> abinames = new List<string>();
        for(int i=owner.myPlayer.otherPlayer.board.Count-1;i>=0;i--)
        {
            if(this.Freezed)
            {
                Card c = owner.myPlayer.otherPlayer.board[i];
                new EffectRemoveAbility(owner.myPlayer.otherPlayer, owner, c ,"Frozen").Resolve();
            }
            
            abinames.Add("Frozen");
        }


        if(this.Freezed)
        {
            //new EffectRemoveAbility(owner.myPlayer.otherPlayer, owner,targets:owner.myPlayer.otherPlayer.board,abinames:abinames).Resolve();
        }
        else
        {
            new EffectGiveAbility(owner.myPlayer.otherPlayer, owner,targets:owner.myPlayer.otherPlayer.board,abinames:abinames,createVfx:false).Resolve();
        }
        this.Freezed=!this.Freezed;
    }
}

public class FTBG_Upgrade : Ability
{
    public override void RegisterEventEffect()
    {
        base.RegisterEventEffect();
        //owner.SetTag(GameTag.AttacksForOneTurn, 100000);
        //owner.SetTag(GameTag.AttacksLeftThisTurn, owner.GetTag(GameTag.AttacksForOneTurn));
    }
    public override void Battlecry(Card target = null)
    {
        base.Battlecry(target);
        new EffectChange(owner.myPlayer.otherPlayer,owner.myPlayer.otherPlayer.hero[0],owner.myPlayer.otherPlayer.hero[0],1,1,0,0).Resolve();
        owner.myPlayer.hero[0].SetTag(GameTag.Mana, owner.myPlayer.hero[0].GetTag(GameTag.Mana)+1);
        int upgradecost = Mathf.Min(Mathf.Max(owner.myPlayer.hero[0].GetTag(GameTag.Mana) + 4, 0), 11);
        new EffectChange(owner.myPlayer,owner, owner, -(owner.GetTag(GameTag.Mana) - upgradecost), 0, 0, 0).Resolve();
        new EffectMove(owner.myPlayer,owner,ZoneType.Power,ZoneType.Grave).Resolve();
    }
}


public class FTBG_TripleReward:Ability
{
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterDiscoverEnd(this,TripleRewardCauseEvent));
    }
    public override void UnRegisterEventEffect()
    {
        owner.myPlayer.RemoveCallBackOf(this);
    }
    public void TripleRewardCauseEvent(Card sc,Card tc,ZoneType sz,ZoneType tz)
    {
        if(sc==owner)
        {
            new EffectMove(owner.myPlayer, tc,ZoneType.Aside,ZoneType.Hand).Resolve();
            new EffectChange(owner.myPlayer,tc,tc,-tc.GetTag(GameTag.Mana),0,0,0,visualFx:false).Resolve();
        }
    }
    public override void Battlecry(Card target=null)
    {
        List<Card> Op=new List<Card>();
        
        List<CardDbf> Pool = FTBG_Refresh.Pools[this.amounts[0]];

        Op.Add(new Card(Pool.Choice(owner.myPlayer.randomGen),owner.myPlayer));
        Op.Add(new Card(Pool.Choice(owner.myPlayer.randomGen),owner.myPlayer));
        Op.Add(new Card(Pool.Choice(owner.myPlayer.randomGen),owner.myPlayer));
        new EffectDiscoverStart(owner.myPlayer,owner,Op).Resolve();
    }
}



public class FTBG_BOSS : Ability
{
    public override void RegisterEventEffect()
    {
        owner.myPlayer.maxnum = new List<int>
        {
            999,10,7,99999,
            5,2,4,1,
            9999,3,
        };
        Game.NowGame.m_Mode=GameMode.BattleGround;
        OneSceneManager.Instance.IsBgMode=true;
        if(owner.myPlayer.Maker!=null)
        {
            owner.myPlayer.Maker.m_Strategy = AIstrategy.AFK;
        }
        owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,StartTurn));
        owner.myPlayer.SetTag(GameTag.ManaThisTurn,3);
    }
    public void StartTurn()
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {
            owner.myPlayer.SetTag(GameTag.ManaThisTurn,owner.myPlayer.GetTag(GameTag.ManaThisTurn)+1);
            owner.myPlayer.SetTag(GameTag.ManaLeft,owner.myPlayer.GetTag(GameTag.ManaThisTurn));
            owner.myPlayer.SetTag(GameTag.ManaLeft,owner.myPlayer.GetTag(GameTag.ManaLeft)-owner.myPlayer.GetTag(GameTag.ManaOverLoad));
            owner.myPlayer.SetTag(GameTag.ManaOverLoad,0);
            new EffectChange(owner.myPlayer,owner,owner,visualFx:false).Resolve();
        }        
    }
}

public class FTBG_BOSS0:FTBG_BOSS{}
public class FTBG_BOSS1:FTBG_BOSS{}
public class FTBG_BOSS2:FTBG_BOSS{}
public class FTBG_BOSS3:FTBG_BOSS{}
public class FTBG_BOSS4:FTBG_BOSS{}
public class FTBG_BOSS5:FTBG_BOSS{}
public class FTBG_BOSS6:FTBG_BOSS{}
public class FTBG_BOB:FTBG_BOSS{}


public class FTBG_Hero : Ability
{
    public override void RegisterEventEffect()
    {
        owner.myPlayer.maxnum = new List<int>
        {
            999,10,7,99999,
            5,2,4,1,
            9999,3,
        };
        Game.NowGame.m_Mode=GameMode.BattleGround;
        OneSceneManager.Instance.IsBgMode=true;
        if(owner.myPlayer.Maker!=null)
        {
            owner.myPlayer.Maker.m_Strategy = AIstrategy.AFK;
        }
        owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,StartTurn));
        owner.myPlayer.SetTag(GameTag.ManaThisTurn,3);
    }
    public void StartTurn()
    {
        if ((ZoneType)owner.GetTag(GameTag.ZoneType) == ZoneType.Hero)
        {
            owner.myPlayer.SetTag(GameTag.ManaThisTurn,owner.myPlayer.GetTag(GameTag.ManaThisTurn)+1);
            owner.myPlayer.SetTag(GameTag.ManaLeft,owner.myPlayer.GetTag(GameTag.ManaThisTurn));
            owner.myPlayer.SetTag(GameTag.ManaLeft,owner.myPlayer.GetTag(GameTag.ManaLeft)-owner.myPlayer.GetTag(GameTag.ManaOverLoad));
            owner.myPlayer.SetTag(GameTag.ManaOverLoad,0);
            new EffectChange(owner.myPlayer,owner,owner,visualFx:false).Resolve();
        }        
    }

    public override void Deathrattle()
    {
        //Warning! Client Code In Server!
        if(!(owner.myPlayer.GetTag(GameTag.IsSimPlayer)==1))
        {
            new CreateDelayCommand(3f).AddToQueue();
            if(!OneSceneManager.Instance.IsMyScene){
                new ChangeSceneCommand("ChooseDeckHS").AddToQueue();
            }
            else{
                new ChangeSceneCommand("ChooseDeckMy").AddToQueue();
            }
        } 
    }
}


