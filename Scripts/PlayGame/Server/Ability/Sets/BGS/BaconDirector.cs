using System.Collections;
using System.Collections.Generic;

public class BaconShopDirectedHero:Ability
{
    private bool IsTop=false;
    public override void Init()
    {
        if(this.IsTop)
        {
            owner.SetTag(GameTag.Damage,29); 
        }
        else{
            owner.SetTag(GameTag.Damage,29);
        }
        
    }
    public override void RegisterEventEffect()
    {
        this.IsTop = (owner.myPlayer.GetTag(GameTag.IsLowPlayer)==0);
        Game.NowGame.m_Mode=GameMode.BattleGround;
        if(owner.myPlayer.Maker!=null)
        {
            owner.myPlayer.Maker.m_Strategy = AIstrategy.AFK;
        }
        base.RegisterEventEffect();
        if(this.IsTop)
        {
            owner.myPlayer.maxnum = new List<int>
            {
                999,10,7,99999,
                5,2,1,1,
                9999,3,
            };
            owner.myPlayer.maxnum[(int)ZoneType.Hero]=2;
        }
        else{
            owner.myPlayer.maxnum = new List<int>
            {
                999,10,7,99999,
                5,2,1,1,
                9999,3,
            };
        }

        //owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,this.PrepareCover));
    }
    public void PrepareCover()
    {
        if(owner.myPlayer.otherPlayer.hero.Count>0)
        {
            owner.myPlayer.otherPlayer.hero[0].SetTag(GameTag.Damage,-100);
            TaskCreate(CardDbf.GetCardDbfByGuid("BG_GVG_113"),ZoneType.Board);
            TaskCreate(CardDbf.GetCardDbfByGuid("BG_GVG_113"),ZoneType.Board);
        }
    }
    public override void UnRegisterEventEffect()
    {
        base.UnRegisterEventEffect();
        owner.myPlayer.RemoveCallBackOf(this);
    }
}

public class BaconShopDirector: Ability
{
    public string TopHero = "FP1_031";
    public string LowHero = "VAN_EX1_572";
    public void PrepareMissionBand()
    {
        for (int i = 0; i < 7; i++)
        {
            Card CreatedCard = new Card(CardDbf.GetCardDbfByGuid("BG21_000_G"), owner.myPlayer);
            if(CreatedCard.cardDbf.CardType==CardType.Minion)
            {
                new EffectCreate(owner.myPlayer,CreatedCard, ZoneType.Board).Resolve();
            }
        } 
        for (int i = 0; i < 0; i++)
        {
            Card CreatedCard = new Card(CardDbf.GetCardDbfByGuid("BG22_001"), owner.myPlayer);
            if(CreatedCard.cardDbf.CardType==CardType.Minion)
            {
                new EffectCreate(owner.myPlayer,CreatedCard, ZoneType.Board).Resolve();
            }
        }        
    }

    private List<string> LowIDs = new List<string>();
    private List<int> GoldenNumTier = new List<int>(){0,7,6,5,4,3,2,0,};
    private List<int> CommonNumTier = new List<int>(){0,0,1,2,3,4,5,7};
    private Dictionary<string,string> GoldenOverrideDict = new Dictionary<string,string>();

    public override void RegisterEventEffect()
    {

        LowIDs.Add("BG22_001");//check 01 幼年克鲁什 BG22_001
        LowIDs.Add("BG25_043");//check 02 赛博格幼龙 BG25_043
        LowIDs.Add("BG27_022");//check 03 自适应路障 BG27_022
        LowIDs.Add("BG27_017");//check 04 黑曜石掠夺者 BG27_017
        LowIDs.Add("BG27_021");//check 07 砰砰飞车 BG27_021
        LowIDs.Add("FP1_010");//check 08 迈克斯纳 FP1_010 TB_BaconUps_155
        LowIDs.Add("BG23_318");//check 09 莽神火车王 BG23_318
        LowIDs.Add("BGS_022");//check 10 扎普·斯里维克 BGS_022 TB_BaconUps_091
        LowIDs.Add("BGS_080");//check 11 破浪巨人 BGS_080 TB_BaconUps_142
        LowIDs.Add("BG24_001");//check 12 花岗岩守护者 BG24_001
        LowIDs.Add("BG21_012");//check 13 普瑞斯托的火炎子嗣 BG21_012
        LowIDs.Add("BG_GVG_113");//check 14 死神4000型 BG_GVG_113 TB_BaconUps_153
        LowIDs.Add("BGS_047");//check 15 亡灵舰长伊丽扎 BGS_047 TB_BaconUps_134
        LowIDs.Add("BG24_004");//check 16 折跃之翼 BG24_004
        LowIDs.Add("BGS_032");//check 17 火焰传令官 BGS_032 TB_BaconUps_103
        LowIDs.Add("BG27_509");//check 18 熊爸爸 BG27_509
        LowIDs.Add("BG25_165");//check 19 砰砰箱博士 BG25_165
        LowIDs.Add("BGS_018");//check 20 巨狼戈德林 BGS_018 TB_BaconUps_085
        LowIDs.Add("BG27_013");//check 21 棘化荆蔓女巫 BG27_013
        LowIDs.Add("BG20_204");//check 22 刺背骑士 BG20_204
        LowIDs.Add("BG21_001");//check 23 苍鳞鳄鱼 BG21_001
        LowIDs.Add("BGS_126");//check 24 野火元素 BGS_126 TB_BaconUps_166
        LowIDs.Add("BG20_401");//check 25 机鱼圣者 BG20_401
        LowIDs.Add("BG27_822");//check 26 砮皂 BG27_822
        LowIDs.Add("BGS_019");//check 27 红色雏龙 BGS_019 TB_BaconUps_102
        LowIDs.Add("BG21_025");//check 28 欧米茄破坏者 BG21_025
        LowIDs.Add("GVG_021");//check 29 玛尔加尼斯 GVG_021 TB_BaconUps_060
        LowIDs.Add("BG23_362");//check 30 艾卓曼德斯 BG23_362
        LowIDs.Add("BG29_878");//check 31 傲角铁牛 BG29_878
        LowIDs.Add("BG29_821");//check 32 狡猾的阿兰纳丝 BG29_821
        LowIDs.Add("BG29_872");//check 33 怨嗣藏宝龙 BG29_872
        LowIDs.Add("BG29_875");//check 34 不速来客 BG29_875
        LowIDs.Add("BG28_904");//check 35 冒进的锚手 BG28_904
        LowIDs.Add("BG31_HERO_802pt4");//check 36 不朽者 BG31_HERO_802pt4
        LowIDs.Add("BG21_000");//check 37 跳蛙 BG21_000
        LowIDs.Add("BG29_815");//check 38 BG29_815 骨火巨龙夜之魇
        LowIDs.Add("BG29_816");//check 39 BG29_816 咆哮聚群龙
        LowIDs.Add("BG26_350");//check 40 低音提琴鱼人 BG26_350
        LowIDs.Add("BG30_119");//check 41 擎旗空中海盗 BG30_119
        LowIDs.Add("BG31_999");//check 42 缝合回收者 BG31_999
        LowIDs.Add("BG26_801");//check 43 重金属双头飞龙 BG26_801
        LowIDs.Add("BG_FP1_024");//check 44 蹒跚的食尸鬼 TB_BaconUps_118

        LowIDs.Add("BGS_044");//100 小鬼妈妈 BGS_044 TB_BaconUps_116
        LowIDs.Add("BGS_079");//101 海浪剃刀号 BGS_079 TB_BaconUps_137
        LowIDs.Add("BGS_008");//102 阴森巨蟒 BGS_008 TB_BaconUps_057
        LowIDs.Add("BG25_806");//103 狡猾的迅猛龙 BG25_806
        LowIDs.Add("BGS_006");//104 斯尼德的伐木机 BGS_006 TB_BaconUps_080
        LowIDs.Add("BG31_835");//105 致命打击者 BG31_835

        //LowIDs.Add("BG_DAL_775");//check 05 坑道爆破师 BG_DAL_775
        //LowIDs.Add("BG27_008");//check 06 机械木马 BG27_008
        //BG26_354 合唱鱼人
        //BG26_802 香蕉猛猿
        //BGS_040 红衣纳迪娜 TB_BaconUps_154
        //BGS_047 亡灵舰长伊丽扎 TB_BaconUps_134
        //BGS_061 海盗无赖 TB_BaconUps_141
        //BGS_060 喊号食人魔 TB_BaconUps_150
        //BGS_067 龙人执行者 TB_BaconUps_117
        //BGS_077 奥术火炮 TB_BaconUps_128
        //BGS_205 永恒者艾丽斯特拉 TB_BaconUps_306
        //BG27_014 奋飞羽鬃兽
        //BG29_120 恨意魔巫
        //BG29_809 怒火飞羊
        //LowIDs.Add("BG27_555");//check 15 舰长伊丽扎·刺刃 BG27_555
        //BG30? BG31?


        //LowIDs = new List<string>(){"GVG_021","GVG_021","GVG_021"};
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

        LowIDs.Shuffle();
        //LowIDs.Insert(0,"BGS_044");
        //LowIDs = new List<string>(){"BG_FP1_024","BG_FP1_024","BG_FP1_024","BG_FP1_024","BG_FP1_024","BG_FP1_024"};    
        base.RegisterEventEffect();
        owner.myPlayer.AddCallBack(new CallBackAfterTurnStart(this,StartCombat));
    }

    public void StartCombat()
    {

        for(int i=0;i<LowIDs.Count;i++)
        {
            Clean();
            if(i%13==0)
            {
                new ChangeBaconShopBgmCommand().AddToQueue();
                //BaconShopChangeBgm.Instance.Change();
            }
            Prepare(i);

            Battle();
            if(i==0)
            {
                //new EffectEmote(owner.myPlayer,null,"如果小恐龙召唤小恐龙",CardDbf.GetCardDbfByGuid("TMP_ICON"),4f).Resolve();
                //new EffectEmote(owner.myPlayer,null,"谁能战胜它们？",CardDbf.GetCardDbfByGuid("TMP_ICON"),4f).Resolve();
            }
            Finish();

        }

        new CreateDelayCommand(1f).AddToQueue();
        new QuitGameCommand().AddToQueue();
    }


    public void Prepare(int index)
    {

        while(owner.myPlayer.hero.Count<1)
        {
            Card CreatedCard = new Card(CardDbf.GetCardDbfByGuid(this.TopHero), owner.myPlayer);
            new EffectCreate(owner.myPlayer,CreatedCard, ZoneType.Hero).Resolve();           
        }
        while(owner.myPlayer.otherPlayer.hero.Count<1)
        {
            Card CreatedCard = new Card(CardDbf.GetCardDbfByGuid(this.LowHero), owner.myPlayer.otherPlayer);
            new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Hero).Resolve();
           
        }
        //owner.myPlayer.hero[0].SetTag(GameTag.Damage,29);
        //owner.myPlayer.otherPlayer.hero[0].SetTag(GameTag.Damage,29);
        PrepareMissionBand();

        string CommonID = this.LowIDs[index];
        string GoldenID = CommonID+"_G";
        if(this.GoldenOverrideDict.ContainsKey(CommonID))
        {
            GoldenID = this.GoldenOverrideDict[CommonID];
        }
        CardDbf dbCommon = CardDbf.GetCardDbfByGuid(CommonID);
        CardDbf dbGolden = CardDbf.GetCardDbfByGuid(GoldenID);
        int tier = dbCommon.ManaCost;
        int GoldenNum=0;
        int CommonNum=7;
        if(dbCommon.ManaCost<GoldenNumTier.Count)
        {
            GoldenNum = GoldenNumTier[dbCommon.ManaCost];
            CommonNum = CommonNumTier[dbCommon.ManaCost];             
        }
 

        if(CommonID=="BG21_000")
        {
            for(int i = 0;i<6;i++)
            {
                Card CreatedCard = new Card(dbGolden, owner.myPlayer.otherPlayer);
                new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Board).Resolve();
            }
            Card Revin = new Card(CardDbf.GetCardDbfByGuid("BG25_354_G"), owner.myPlayer.otherPlayer);
            new EffectCreate(owner.myPlayer.otherPlayer,Revin, ZoneType.Board).Resolve();            
        }
        else if(CommonID=="BG23_318")
        {
            Card Claw = new Card(CardDbf.GetCardDbfByGuid("BGS_078"), owner.myPlayer.otherPlayer);
            Claw.SetTag(GameTag.Attack,1);
            Claw.SetTag(GameTag.Health,100);
            new EffectCreate(owner.myPlayer.otherPlayer,Claw, ZoneType.Board).Resolve(); 
            Card Reckless = new Card(CardDbf.GetCardDbfByGuid("BG23_318"), owner.myPlayer.otherPlayer);
            Reckless.SetTag(GameTag.Attack,0);
            Reckless.SetTag(GameTag.Health,100);
            new EffectCreate(owner.myPlayer.otherPlayer,Reckless, ZoneType.Board).Resolve();
            new EffectGiveAbility(owner.myPlayer.otherPlayer,Reckless,Reckless,"Taunt").Resolve();      
        }
        else if(CommonID=="BGS_044")
        {
            Card Mom = new Card(CardDbf.GetCardDbfByGuid("BGS_044"),owner.myPlayer.otherPlayer);
            Mom.SetTag(GameTag.Attack,12);
            Mom.SetTag(GameTag.Health,100);
            //new EffectGiveAbility(owner.myPlayer);
            new EffectCreate(owner.myPlayer.otherPlayer,Mom,ZoneType.Board).Resolve();
            Card Snip = new Card(CardDbf.GetCardDbfByGuid("TB_BaconUps_075"),owner.myPlayer.otherPlayer);
            Snip.SetTag(GameTag.Attack,0);
            Snip.SetTag(GameTag.Health,50);
            new EffectCreate(owner.myPlayer.otherPlayer,Snip,ZoneType.Board).Resolve();
        }
        else if(CommonID=="BG26_350")
        {
            for (int i = 0; i < 3; i++)
            {
                Card CreatedCard = new Card(CardDbf.GetCardDbfByGuid("BG27_513"), owner.myPlayer.otherPlayer);
                new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Board).Resolve();
            }
            for (int i = 0; i < 4; i++)
            {
                Card CreatedCard = new Card(dbCommon, owner.myPlayer.otherPlayer);
                new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Board).Resolve();
            }
            for (int i = 0; i < 7; i++)
            {
                Card CreatedCard = new Card(CardDbf.GetCardDbfByGuid("BG31_146"), owner.myPlayer.otherPlayer);
                new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Hand).Resolve();
            }              
        }
        else if(CommonID=="BG30_119")
        {
            for (int i = 0; i < 6; i++)
            {
                Card CreatedCard = new Card(CardDbf.GetCardDbfByGuid("BG30_119"), owner.myPlayer.otherPlayer);
                new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Board).Resolve();
            }
            Card CreatedCard2 = new Card(CardDbf.GetCardDbfByGuid("BG27_555"), owner.myPlayer.otherPlayer);
            new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard2, ZoneType.Board).Resolve();               
        }
        else if(CommonID=="BG31_999")
        {
            Card Big1 = new Card(CardDbf.GetCardDbfByGuid("BG28_968"),owner.myPlayer.otherPlayer);
            Card GoldenEat = new Card(CardDbf.GetCardDbfByGuid("BG31_999_G"),owner.myPlayer.otherPlayer);
            Card Big2 = new Card(CardDbf.GetCardDbfByGuid("BG28_968"),owner.myPlayer.otherPlayer);
            Card CommonEat = new Card(CardDbf.GetCardDbfByGuid("BG31_999"),owner.myPlayer.otherPlayer);
            Card Revin = new Card(CardDbf.GetCardDbfByGuid("BG25_354_G"),owner.myPlayer.otherPlayer);
            new EffectCreate(owner.myPlayer.otherPlayer,Big1, ZoneType.Board).Resolve();
            new EffectCreate(owner.myPlayer.otherPlayer,GoldenEat, ZoneType.Board).Resolve(); 
            new EffectCreate(owner.myPlayer.otherPlayer,Big2, ZoneType.Board).Resolve(); 
            new EffectCreate(owner.myPlayer.otherPlayer,CommonEat, ZoneType.Board).Resolve(); 
            new EffectCreate(owner.myPlayer.otherPlayer,Revin, ZoneType.Board).Resolve(); 
        } 
        else if(CommonID=="BG26_801")
        {
            Card Bird1 = new Card(CardDbf.GetCardDbfByGuid("BG27_079"),owner.myPlayer.otherPlayer);
            Card Bird2 = new Card(CardDbf.GetCardDbfByGuid("BG27_079"),owner.myPlayer.otherPlayer);
            Card Bird3 = new Card(CardDbf.GetCardDbfByGuid("BG27_079"),owner.myPlayer.otherPlayer);
            Card Cry1 = new Card(CardDbf.GetCardDbfByGuid("BG23_190"),owner.myPlayer.otherPlayer);
            Card GoldenTrigger = new Card(CardDbf.GetCardDbfByGuid("BG26_801_G"),owner.myPlayer.otherPlayer);
            Card Cry2 = new Card(CardDbf.GetCardDbfByGuid("BG23_190"),owner.myPlayer.otherPlayer);
            Card RevinBroad = new Card(CardDbf.GetCardDbfByGuid("BG27_518_G"),owner.myPlayer.otherPlayer);
            new EffectCreate(owner.myPlayer.otherPlayer,Bird1, ZoneType.Board).Resolve();
            new EffectCreate(owner.myPlayer.otherPlayer,Bird2, ZoneType.Board).Resolve();
            new EffectCreate(owner.myPlayer.otherPlayer,Bird3, ZoneType.Board).Resolve();
            new EffectCreate(owner.myPlayer.otherPlayer,Cry1, ZoneType.Board).Resolve();
            new EffectCreate(owner.myPlayer.otherPlayer,GoldenTrigger, ZoneType.Board).Resolve(); 
            new EffectCreate(owner.myPlayer.otherPlayer,Cry2, ZoneType.Board).Resolve(); 
            new EffectCreate(owner.myPlayer.otherPlayer,RevinBroad, ZoneType.Board).Resolve();             
        }
        else if(CommonID=="BG_FP1_024")
        {
            Card Bird1 = new Card(CardDbf.GetCardDbfByGuid("BG_FP1_024"),owner.myPlayer.otherPlayer);
            new EffectCreate(owner.myPlayer.otherPlayer,Bird1, ZoneType.Board).Resolve();
            new EffectGiveAbility(owner.myPlayer.otherPlayer,Bird1,Bird1,"Poisonous",createVfx:false).Resolve();
            new EffectEmote(owner.myPlayer,Bird1,"剧毒！",null,4f).Resolve(); 
            Card Bird2 = new Card(CardDbf.GetCardDbfByGuid("BG21_025"),owner.myPlayer.otherPlayer);
            new EffectCreate(owner.myPlayer.otherPlayer,Bird2, ZoneType.Board).Resolve();   
        }
        else if(CommonID=="BG29_875")
        {
            for (int i = 0; i < 2; i++)
            {
                Card CreatedCard = new Card(CardDbf.GetCardDbfByGuid("BG29_875"), owner.myPlayer.otherPlayer);
                new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Board).Resolve();
            }
            for (int i = 0; i < 5; i++)
            {
                Card CreatedCard = new Card(CardDbf.GetCardDbfByGuid("BG28_634"), owner.myPlayer.otherPlayer);
                new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Board).Resolve();
            }  
        }
        else{
            for (int i = 0; i < GoldenNum; i++)
            {
                Card CreatedCard = new Card(dbGolden, owner.myPlayer.otherPlayer);
                new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Board).Resolve();
            }
            for (int i = 0; i < CommonNum; i++)
            {
                Card CreatedCard = new Card(dbCommon, owner.myPlayer.otherPlayer);
                new EffectCreate(owner.myPlayer.otherPlayer,CreatedCard, ZoneType.Board).Resolve();
            }            
        }
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
                foreach (Ability abi in c.abilityList)
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
                foreach (Ability abi in c.abilityList)
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
                Winner.hero[0].SetTag(GameTag.Mana,6);
                new EffectChange(Winner,Winner.hero[0], Winner.hero[0], 0, Winner.hero[0].GetTag(GameTag.Mana), 0, 0).Resolve();
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
                    //new EffectChange(Winner,c,Winner.hero[0],0,assignVfxType:VfxType.BaconStar).Resolve();
                    new EffectChange(Winner,Winner.hero[0], Winner.hero[0], 0, c.cardDbf.ManaCost, 0, 0,visualFx:false).Resolve();
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
        for(int i=owner.myPlayer.board.Count-1;i>=0;i--)
        {
            new EffectMove(owner.myPlayer,owner.myPlayer.board[i],ZoneType.Board,ZoneType.Grave).Resolve();
        }
        for(int i=owner.myPlayer.otherPlayer.board.Count-1;i>=0;i--)
        {
            new EffectMove(owner.myPlayer.otherPlayer,owner.myPlayer.otherPlayer.board[i],ZoneType.Board,ZoneType.Grave).Resolve();
        }
        for(int i=owner.myPlayer.hand.Count-1;i>=0;i--)
        {
            new EffectMove(owner.myPlayer,owner.myPlayer.hand[i],ZoneType.Hand,ZoneType.Grave).Resolve();
        }
        for(int i=owner.myPlayer.otherPlayer.hand.Count-1;i>=0;i--)
        {
            new EffectMove(owner.myPlayer.otherPlayer,owner.myPlayer.otherPlayer.hand[i],ZoneType.Hand,ZoneType.Grave).Resolve();
        }        
    }
}


public class TMP_DIR:BaconShopDirector
{
}
public class VAN_EX1_298:BaconShopDirectedHero{
//NAME=炎魔之王拉格纳罗斯
//TEXT=无法攻击。在你的回合结束时，随机对一个敌人造成8点伤害。
//MAJ=NEUTRAL|COST=8|ATK=8|HP=8|RACE=NONE
    /*
    public override void Init()
    {
        owner.SetTag(GameTag.AttacksForOneTurn,0);
    }
    public override void RegisterEventEffect()
    {
        owner.myPlayer.AddCallBack(new CallBackAfterTurnEnd(this,CauseEvent));
    }
    public void CauseEvent()
    {
        if(CondInPlay())
            TaskDamageRandomEnemy(8);
    }
    */
}
public class VAN_EX1_572:BaconShopDirectedHero{
//NAME=伊瑟拉
//TEXT=在你的回合结束时，将一张梦境牌置入你的手牌。
//MAJ=NEUTRAL|COST=9|ATK=4|HP=12|RACE=DRAGON
}

public class FP1_031:BaconShopDirectedHero{
//NAME=瑞文戴尔男爵
//TEXT=你的随从的<b>亡语</b>将触发两次。
//MAJ=NEUTRAL|COST=4|ATK=1|HP=7|RACE=UNDEAD
    public override void RegisterEventEffect()
    {
        //owner.myPlayer.AddCallBack(new CallBackAfterDestroy(this,this.CauseEvent));
    }
    public void CauseEvent(Card source, Card target)
    {
        if(CondInPlay())
        {
            for(int i=0;i<2;i++)
            {
                if (target.abilityList.Count != 0)
                {
                    for (int j = 0; j < target.abilityList.Count; j++)
                    {
                        target.abilityList[j].Deathrattle();
                    }
                }               
            }
        }
    }
}