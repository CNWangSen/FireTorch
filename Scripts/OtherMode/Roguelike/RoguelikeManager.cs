using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;


public class RoguelikeManager : MonoBehaviour
{
	public static DeckDbf MyDeck = null;
	public static DeckDbf EnemyDeck = null;
	public static List<DeckDbf> InitialPool = new List<DeckDbf>();
	public static List<DeckDbf> RewardPool = new List<DeckDbf>();
	public static List<DeckDbf> BossPool = new List<DeckDbf>();
	public static List<DeckDbf> RewardDeck = new List<DeckDbf>();
	public static int BossFighted = 0;
	public static int TotalBossNum = 8;
	public static int RewardOptionNum = 3;

	public List<TextMeshProUGUI> RewardDeckNames=new List<TextMeshProUGUI>();

	public void Start()
	{
		CardDbf.LoadAllCardDbf(GameMode.BattleGround);
		DeckDbf.FliterAllDeckDbf();

		RoguelikeManager.RewardDeck.Clear();
		for(int i = 0; i<RewardOptionNum; i++)
		{
			RoguelikeManager.RewardDeck.Add(RoguelikeManager.RewardPool.Choice());
			//RewardDeckNames[i].text = RoguelikeManager.RewardDeck[i].DeckName; 
		}

		RoguelikeManager.EnemyDeck = new DeckDbf();//RoguelikeManager.BossPool.Choice();
		RoguelikeManager.MyDeck = new DeckDbf();//RoguelikeManager.InitialPool.Choice();
		
		RoguelikeManager.EnemyDeck.Hero = new List<CardDbf>();
		RoguelikeManager.EnemyDeck.Hero.Add(CardDbf.GetCardDbfByGuid("FTBG_Bob"));//"FP1_031"));//"VAN_EX1_298"));
		RoguelikeManager.EnemyDeck.Cards = new List<CardDbf>();
		RoguelikeManager.EnemyDeck.HeroPower = new List<CardDbf>();
		RoguelikeManager.EnemyDeck.SideDeck = new List<CardDbf>();

		RoguelikeManager.MyDeck.Hero = new List<CardDbf>();
		RoguelikeManager.MyDeck.Hero.Add(CardDbf.GetCardDbfByGuid("FTBG_Hero"));//"VAN_EX1_572"));
		RoguelikeManager.MyDeck.Cards = new List<CardDbf>();

		RoguelikeManager.MyDeck.HeroPower = new List<CardDbf>();
		RoguelikeManager.MyDeck.SideDeck = new List<CardDbf>();


		for(int i =0; i<1;i++)
		{
			RoguelikeManager.EnemyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("FTBG_DIR"));
			//RoguelikeManager.MyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("BG_CFM_315"));

			//RoguelikeManager.EnemyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("FTBG_Bob"));
			//RoguelikeManager.MyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("BG_CFM_315"));

		}


		for(int i=0; i<1;i++)
		{
			RoguelikeManager.MyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("BG_BOT_911"));
			//RoguelikeManager.MyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("TMP_EDR_020"));
			//RoguelikeManager.MyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("TMP_EDR_007"));
		}
	}

	public static void ChooseReward(int index)
	{
		
		DeckDbf ChosenReward = RoguelikeManager.RewardDeck[index];
		if(RoguelikeManager.MyDeck == null)
		{
			RoguelikeManager.MyDeck=new DeckDbf();
			RoguelikeManager.MyDeck.Hero = ChosenReward.Hero;
			RoguelikeManager.MyDeck.HeroPower=new List<CardDbf>();
			RoguelikeManager.MyDeck.Cards=new List<CardDbf>();
			RoguelikeManager.MyDeck.SideDeck=new List<CardDbf>();
			foreach(CardDbf ca in ChosenReward.HeroPower)
			{
				RoguelikeManager.MyDeck.HeroPower.Add(ca);
			}
			foreach(CardDbf ca in ChosenReward.Cards)
			{
				RoguelikeManager.MyDeck.Cards.Add(ca);
			}
		}
		else
		{
			foreach(CardDbf ca in ChosenReward.Cards)
			{
				RoguelikeManager.MyDeck.Cards.Add(ca);
			}

		}
		

		DeckDbf.LowDeck = RoguelikeManager.MyDeck;
		DeckDbf.TopDeck = RoguelikeManager.EnemyDeck;
		RoguelikeManager.BossFighted += 1;
	}


	public static List<CardDbf> SetOverrideMyDeck(int did)
	{
        List<CardDbf> OverrideMyDeck = new List<CardDbf>();
        List<string> ToSetId = new List<string>();
        ToSetId.Add("BG22_001");//check 01 幼年克鲁什 BG22_001
        ToSetId.Add("BG25_043");//check 02 赛博格幼龙 BG25_043
        ToSetId.Add("BG27_022");//check 03 自适应路障 BG27_022
		ToSetId.Add("BG27_017");//check 04 黑曜石掠夺者 BG27_017
		ToSetId.Add("BG_DAL_775");//check 05 坑道爆破师 BG_DAL_775
        ToSetId.Add("BG27_008");//check 06 机械木马 BG27_008
        ToSetId.Add("BG27_021");//check 07 砰砰飞车 BG27_021
        ToSetId.Add("FP1_010");//check 08 迈克斯纳 FP1_010 TB_BaconUps_155
		ToSetId.Add("BG23_318");//check 09 莽神火车王 BG23_318
		ToSetId.Add("BGS_022");//check 10 扎普·斯里维克 BGS_022 TB_BaconUps_091
        ToSetId.Add("BGS_080");//check 11 破浪巨人 BGS_080 TB_BaconUps_142
        ToSetId.Add("BG24_001");//check 12 花岗岩守护者 BG24_001
        ToSetId.Add("BG21_012");//check 13 普瑞斯托的火炎子嗣 BG21_012
		ToSetId.Add("BG_GVG_113");//check 14 死神4000型 BG_GVG_113 TB_BaconUps_153
		ToSetId.Add("BG27_555");//check 15 舰长伊丽扎·刺刃 BG27_555
        ToSetId.Add("BG24_004");//check 16 折跃之翼 BG24_004
        ToSetId.Add("BGS_032");//check 17 火焰传令官 BGS_032 TB_BaconUps_103
        ToSetId.Add("BG27_509");//check 18 熊爸爸 BG27_509
		ToSetId.Add("BG25_165");//check 19 砰砰箱博士 BG25_165
		ToSetId.Add("BGS_018");//check 20 巨狼戈德林 BGS_018 TB_BaconUps_085
        ToSetId.Add("BG27_013");//check 21 棘化荆蔓女巫 BG27_013
        ToSetId.Add("BG20_204");//check 22 刺背骑士 BG20_204
        ToSetId.Add("BG21_001");//check 23 苍鳞鳄鱼 BG21_001
		ToSetId.Add("BGS_126");//check 24 野火元素 BGS_126 TB_BaconUps_166
		ToSetId.Add("BG20_401");//check 25 机鱼圣者 BG20_401
        ToSetId.Add("BG27_822");//check 26 砮皂 BG27_822
        ToSetId.Add("BGS_019");//check 27 红色雏龙 BGS_019 TB_BaconUps_102
        ToSetId.Add("BG21_025");//check 28 欧米茄破坏者 BG21_025
		ToSetId.Add("GVG_021");//check 29 玛尔加尼斯 GVG_021 TB_BaconUps_060
		ToSetId.Add("BG23_362");//check 30 艾卓曼德斯 BG23_362
		ToSetId.Add("BG29_878");//check 31 傲角铁牛 BG29_878
		ToSetId.Add("BG29_821");//check 32 狡猾的阿兰纳丝 BG29_821
		ToSetId.Add("BG29_872");//check 33 怨嗣藏宝龙 BG29_872
		ToSetId.Add("BG29_875");//check 34 不速来客 BG29_875
		ToSetId.Add("BG28_904");//check 35 冒进的锚手 BG28_904
 		ToSetId.Add("BG31_HERO_802pt4");//check 36 不朽者 BG31_HERO_802pt4
 		
 		Dictionary<string,string> GoldenOverrideDict = new Dictionary<string,string>();
 		GoldenOverrideDict["FP1_010"]="TB_BaconUps_155";
 		GoldenOverrideDict["BGS_022"]="TB_BaconUps_091";
 		GoldenOverrideDict["BGS_080"]="TB_BaconUps_142";
 		GoldenOverrideDict["BG_GVG_113"]="TB_BaconUps_153";
 		GoldenOverrideDict["BGS_032"]="TB_BaconUps_103";
 		GoldenOverrideDict["BGS_018"]="TB_BaconUps_085";
 		GoldenOverrideDict["BGS_126"]="TB_BaconUps_166";
 		GoldenOverrideDict["BGS_019"]="TB_BaconUps_102";
 		GoldenOverrideDict["GVG_021"]="TB_BaconUps_060";

 		//UnityEngine.Debug.Log(did);
 		if(did>=1 && did<=30)
 		{
 			string mID = ToSetId[did-1];
 			CardDbf dbC = CardDbf.GetCardDbfByGuid(mID);
 			CardDbf dbG;
 			if(GoldenOverrideDict.ContainsKey(mID))
 			{
 				dbG = CardDbf.GetCardDbfByGuid(GoldenOverrideDict[mID]);
 			}
 			else{
 				dbG = CardDbf.GetCardDbfByGuid(mID+"_G");
 			}
 			
 			//1-7G
 			//2-6G
 			//3-5G
 			//4-4G
 			//5-2G
 			//6-1G
 			//7-0G
 			List<int> GoldenNumTier = new List<int>(){0,7,6,5,4,3,2,0,};
 			List<int> CommonNumTier = new List<int>(){0,0,1,2,3,4,5,7};
 			int tier = dbC.ManaCost;

 			int NumG=GoldenNumTier[dbC.ManaCost];
 			int NumC=CommonNumTier[dbC.ManaCost];

 			for (int i =0;i<NumG;i++)
 			{
 				OverrideMyDeck.Add(dbG);
 			}
 			for (int i =0;i<NumC;i++)
 			{
 				OverrideMyDeck.Add(dbC);
 			}
 			//UnityEngine.Debug.Log(OverrideMyDeck.Count);
 		}
		return OverrideMyDeck;
	}
}