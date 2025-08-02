using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using System;

//[Serializable]
public class CardDbf
{
    [JsonProperty]
    internal int ModId;
    [JsonProperty]
    internal int SetId;
    [JsonProperty]
    internal int DbfId;
    
    [JsonProperty]
    internal string m_noteMiniGuid;
    [JsonProperty]
    internal List<ClassType> Classes = new List<ClassType>();
    [JsonProperty]
    internal string CnName;
    [JsonProperty]
    internal string ScriptName;
    //public string CardImageName;

    [JsonProperty]
    internal CardType CardType;
    [JsonProperty]
    internal RareType RareType;
    [JsonProperty]
    internal PremiumType PremiumType;
    [JsonProperty]
    internal List<RaceType> RaceType = new List<RaceType>();
    [JsonProperty]
    internal List<SpellSchoolType> SpellType = new List<SpellSchoolType>();
    //public List<MinionType> MinionType;

    [JsonProperty]
    internal int ManaCost;
    [JsonProperty]
    internal int Attack;
    [JsonProperty]
    internal int MaxHealth;
    [JsonProperty]
    internal int Armor;
    [JsonProperty] 
    internal TargetingOptions Targets;

    [JsonProperty]
    internal string Description;
    //public List<int> RelatedDbfId = new List<int>();


    public List<CardDbf> RelatedDbf = new List<CardDbf>();
    //public List<AudioClip> CustomEmoteAudioClips;
    //public List<string> CustomEmoteTexts;
    //public string SpawnVfxAssetName;
    //public string DieVfxAssetName;
    //public string MissileVfxAssetName;
    //public string CustomAudAssetName;
    public CardDbf()
    {

    }

    public bool IsImplemented()
    {
        if(System.Type.GetType(this.m_noteMiniGuid)==null)
        {
            return false;
        }
        //Ability OneAbility = System.Activator.CreateInstance() as Ability;
        //if(OneAbility==null)
        //{
        //    return false;
        //}

        List<string> AbName=new List<string>(){"Init","Battlecry","Deathrattle","RegisterEventEffect","AuraActive","AfterGetTag","AuraActive"};
        foreach(string ab in AbName)
        {
            if (!(System.Type.GetType(this.m_noteMiniGuid).GetMethod(ab).DeclaringType == typeof(Ability)))
            {
                return true;
            }             
        }
        return false;
    }

    public string GetRaceString()
    {
        string RaceString = "";
        foreach(RaceType rc in this.RaceType)
        {
            RaceString+=CardDbf.RaceTypeName[(int)rc];
        }
        //foreach(RaceType rc in this.RaceType)
        //{
        RaceString+=CardDbf.RareTypeName[(int)this.RareType];
        //}
        return RaceString;
    }
    public static List<string> RareTypeName = new List<string>()
    {
        "免费",
        "普通",
        "稀有",
        "史诗",
        "传说"
    };    
    public static List<string> RaceTypeName = new List<string>()
    {
    "全部",
    "野兽",
    "恶魔",
    "龙",
    "元素",
    "人类",
    "机械",
    "鱼人",
    "娜迦",
    "暗夜精灵",
    "兽人",
    "海盗",
    "野猪人",
    "图腾",
    "亡灵",
    "血精灵",
    "树人",
    "地精",
    "高等精灵",
    "古神",
    "狼人",
    "巨魔",
    "食人魔",
    "豺狼人",
    "德莱尼",
    "牛头人",
    "熊猫人",
    "天神",
    "矮人",
    "哥布林",
    "魔像",
    "卵",
    "熊怪",
    "半人马",
    "戈隆德",
    "狐人",
    "无",
    };
    public static List<string> SpellTypeName = new List<string>()
    {      
        "奥术",
        "邪能",
        "火焰",
        "冰霜",
        "神圣",
        "自然",
        "暗影",
        "涌动",
        "酒馆",
        "物伤",
        "",
    };
    public static List<string> ClassTypeName = new List<string>()
    {      
        "中立",
        "死亡骑士",
        "恶魔猎手",
        "德鲁伊",
        "猎人",
        "法师",
        "圣骑士",
        "牧师",
        "潜行者",
        "萨满祭司",
        "术士",
        "战士",
        "武僧",
        "梦境",
        "威姿班",        
    };
    public static List<string> AllSetNames = new List<string>(){"ADIY",
        "ALTERAC_VALLEY","BATTLE_OF_THE_BANDS","BLACK_TEMPLE","BOOMSDAY","BRM",
        "CORE","CORE_T","DALARAN","DARKMOON_FAIRE","DEMON_HUNTER_INITIATE","DRAGONS",
        "EVENT","GANGS","GILNEAS","GVG",
        "HERO_POWERS","HERO_SKINS","ICECROWN","ISLAND_VACATION","KARA",
        "LOE","LOOTAPALOOZA",
        "NAXX","OG","PATH_OF_ARTHAS","PLACEHOLDER_202204",
        "RETURN_OF_THE_LICH_KING","REVENDRETH","SCHOLOMANCE","STORMWIND","TGT","THE_BARRENS",
        "THE_SUNKEN_CITY","TITANS","TROLL","ULDUM","UNGORO",
        "WHIZBANGS_WORKSHOP","WILD_WEST","WONDERS","YEAR_OF_THE_DRAGON"
    };
    public static List<string> AllClassNames = new List<string>(){
        "NEUTRAL","DEATHKNIGHT","DEMONHUNTER","DRUID","HUNTER","MAGE","PALADIN","PRIEST","ROGUE","SHAMAN","WARLOCK","WARRIOR","MONK"
    };
    public static List<CardDbf> FiltByManaGreaterThan(List<CardDbf> ToFilt, int mana)
    {
        List<CardDbf> Filted = new List<CardDbf>();
        foreach (CardDbf asst in ToFilt)
        {
            if (asst.ManaCost>=mana)
            {
                Filted.Add(asst);
            }
        }
        return Filted;
    }

    public static List<CardDbf> FiltByMajor(List<CardDbf> ToFilt, ClassType cls)
    {
        List<CardDbf> Filted = new List<CardDbf>();
        foreach (CardDbf dbf in ToFilt)
        {
            if (dbf.Classes.Contains(cls))
            {
                Filted.Add(dbf);
            }
        }
        return Filted;
    }
    public static List<CardDbf> FiltByMana(List<CardDbf> ToFilt, int mana)
    {
        List<CardDbf> Filted = new List<CardDbf>();
        foreach (CardDbf dbf in ToFilt)
        {
            if (dbf.ManaCost == mana)
            {
                Filted.Add(dbf);
            }
        }
        return Filted;
    }

    public static List<CardDbf> FiltByType(List<CardDbf> ToFilt, CardType crd)
    {
        List<CardDbf> Filted = new List<CardDbf>();
        foreach (CardDbf dbf in ToFilt)
        {
            if (dbf.CardType == crd)
            {
                Filted.Add(dbf);
            }
        }
        return Filted;
    }
    public static List<CardDbf> FiltByRace(List<CardDbf> ToFilt, RaceType cls)
    {
        List<CardDbf> Filted = new List<CardDbf>();
        foreach (CardDbf dbf in ToFilt)
        {
            if (dbf.RaceType.Contains(cls))
            {
                Filted.Add(dbf);
            }
        }
        return Filted;
    }
    public static List<CardDbf> FiltByRare(List<CardDbf> ToFilt, RareType cls)
    {
        List<CardDbf> Filted = new List<CardDbf>();
        foreach (CardDbf dbf in ToFilt)
        {
            if (dbf.RareType == cls)
            {
                Filted.Add(dbf);
            }
        }
        return Filted;
    }

    public static List<CardDbf> FiltByString(List<CardDbf> ToFilt, string str)
    {
        List<CardDbf> Filted = new List<CardDbf>();
        foreach (CardDbf dbf in ToFilt)
        {
            if (dbf.m_noteMiniGuid==str || dbf.Description.Contains(str) || dbf.CnName.Contains(str) || dbf.m_noteMiniGuid.Contains(str) || dbf.GetRaceString().Contains(str))
            {
                Filted.Add(dbf);
            }
        }
        return Filted;
    }
    public static CardDbf GetCardDbfByName(string ScriptName)
    {
        foreach (CardDbf dbf in CardDbf.AllCardDbf)
        {
            if (dbf.m_noteMiniGuid == ScriptName)
            {
                return dbf;
            }
        }
        return null;
    }
    public static CardDbf GetCardDbfByDbfId(int DbfId)
    {
        //foreach(CardDbf dbf in CardDbf.AllCardDbf)
        //{
        //    if(dbf.DbfId == DbfId)
        //    {
        //        return dbf;
        //    }
        //}
        if (CardDbf.AllCardDbfIntCahe.ContainsKey(DbfId))
        {
            return CardDbf.AllCardDbfIntCahe[DbfId];
        }
        return null;
    }
    public static CardDbf GetCardDbfByGuid(string NoteMiniGuid)
    {
        if (CardDbf.AllCardDbfCahe.ContainsKey(NoteMiniGuid))
        {
            return CardDbf.AllCardDbfCahe[NoteMiniGuid];
        }
        return null;
    }

    public static List<CardDbf> AllCardDbf = new List<CardDbf>();
    public static List<CardDbf> AllNonCollectibleCardDbf = new List<CardDbf>();
    private static bool LoadedAll = false;
    private static bool LoadedBG = false;
    private static bool LoadedLT = false;
    private static bool LoadedPlay = false;

    public static Dictionary<string,CardDbf> AllCardDbfCahe = new Dictionary<string,CardDbf>();
    public static Dictionary<int,CardDbf> AllCardDbfIntCahe = new Dictionary<int,CardDbf>();
    public static List<CardDbf> AllBGSminionDbf = new List<CardDbf>();
    public static List<CardDbf> AllBGSdeathrattleDbf = new List<CardDbf>();
    public static List<CardDbf> AllBGSdemonDbf = new List<CardDbf>();
    public static List<CardDbf> AllBGSmurlocDbf = new List<CardDbf>();
    public static List<CardDbf> AllBGSpirateDbf = new List<CardDbf>();
    public static List<CardDbf> AllBGSbeastDbf = new List<CardDbf>();
    public static List<CardDbf> AllBGSdragonDbf = new List<CardDbf>();
    public static List<CardDbf> AllBGSundeadDbf = new List<CardDbf>();
    public static List<CardDbf> AllBGSlegendaryDbf = new List<CardDbf>();
    public static List<CardDbf> AllBGS1Dbf = new List<CardDbf>();
    public static List<CardDbf> AllBGS2Dbf = new List<CardDbf>();
    public static List<CardDbf> AllBGS3Dbf = new List<CardDbf>();
    public static List<CardDbf> AllBGS4Dbf = new List<CardDbf>();
    public static List<CardDbf> AllBGS5Dbf = new List<CardDbf>();
    public static List<CardDbf> AllBGS6Dbf = new List<CardDbf>();
    public static List<CardDbf> AllBGS7Dbf = new List<CardDbf>();
    public static bool CaheUnCollectibleCard = false;

    public static void LoadLT()
    {

    }
    public static void LoadLT_DIY()
    {
        string json5 = Resources.Load<TextAsset>("ServerData/LT/NonCollectibleCards_TorchLT_Hero").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json5))
        {
            //AllBGSminionDbf.Add(db);
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        string json7 = Resources.Load<TextAsset>("ServerData/LT/NonCollectibleCards_TorchLT_Minion_T").text;//"ServerData/BGS/NonCollectibleCards_BGS_Minion_T_Season01").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json7))
        {
            AllBGSminionDbf.Add(db);
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        string json6 = Resources.Load<TextAsset>("ServerData/LT/NonCollectibleCards_TorchLT_Minion").text;//"ServerData/BGS/NonCollectibleCards_TorchBG_SHJ"//"ServerData/BGS/NonCollectibleCards_BGS_Minion_Season01").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json6))
        {
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
            if(db.CardType==CardType.Minion)
            {
                AllBGSminionDbf.Add(db);
                if(db.m_noteMiniGuid.Substring(db.m_noteMiniGuid.Length-2)=="02"|| db.m_noteMiniGuid.Substring(db.m_noteMiniGuid.Length-2)=="03")
                {

                }
                else{
                    switch(db.ManaCost)
                    {
                        case(1):
                            AllBGS1Dbf.Add(db);
                            break;
                        case(2):
                            AllBGS2Dbf.Add(db);
                            break;
                        case(3):
                            AllBGS3Dbf.Add(db);
                            break;
                        case(4):
                            AllBGS4Dbf.Add(db);
                            break;
                        case(5):
                            AllBGS5Dbf.Add(db);
                            break;
                        case(6):
                            AllBGS6Dbf.Add(db);
                            break;
                        case(7):
                            AllBGS7Dbf.Add(db);
                            break;
                    }
                }
            }
        }
    }
    public static void LoadBG_DIY()
    {
        string json71 = Resources.Load<TextAsset>("ServerData/BGS/NonCollectibleCards_TorchBG").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json71))
        {
            //AllBGSminionDbf.Add(db);
            CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        } 
        string json72 = Resources.Load<TextAsset>("ServerData/BGS/NonCollectibleCards_TorchBG_FusionCards").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json72))
        {
            //AllBGSminionDbf.Add(db);
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        } 
    }
    public static void LoadBG()
    {
        string json5 = Resources.Load<TextAsset>("ServerData/BGS/NonCollectibleCards_BGS_Hero").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json5))
        {
            //AllBGSminionDbf.Add(db);
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        string json7 = Resources.Load<TextAsset>("ServerData/BGS/NonCollectibleCards_BGS_Minion_T_Season01").text;//"ServerData/BGS/NonCollectibleCards_BGS_Minion_T_Season01").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        if(OneSceneManager.Instance.IsMyScene)
        {
            json7 = Resources.Load<TextAsset>("ServerData/BGS/NonCollectibleCards_TorchBG_SHJ_T").text;
        }
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json7))
        {
            AllBGSminionDbf.Add(db);
            
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        string json71 = Resources.Load<TextAsset>("ServerData/BGS/NonCollectibleCards_BGS_Minion_Fusion_Season01").text;//"ServerData/BGS/NonCollectibleCards_BGS_Minion_T_Season01").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json71))
        {
            AllBGSminionDbf.Add(db);
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        string json6 = Resources.Load<TextAsset>("ServerData/BGS/NonCollectibleCards_BGS_Minion_Season01").text;//"ServerData/BGS/NonCollectibleCards_TorchBG_SHJ"//"ServerData/BGS/NonCollectibleCards_BGS_Minion_Season01").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        if(OneSceneManager.Instance.IsMyScene)
        {
            json6 = Resources.Load<TextAsset>("ServerData/BGS/NonCollectibleCards_TorchBG_SHJ").text;
        }
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json6))
        {
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
            if(db.CardType==CardType.Minion)
            {
                AllBGSminionDbf.Add(db);
                if(db.m_noteMiniGuid.Contains("t")|| db.m_noteMiniGuid.Substring(db.m_noteMiniGuid.Length-2)=="_G" || db.m_noteMiniGuid.Contains("TB_BaconUps") || db.m_noteMiniGuid.Contains("_Buddy") || db.m_noteMiniGuid.Contains("Reward_"))
                {

                }
                else{
                    switch(db.ManaCost)
                    {
                        case(1):
                            AllBGS1Dbf.Add(db);
                            break;
                        case(2):
                            AllBGS2Dbf.Add(db);
                            break;
                        case(3):
                            AllBGS3Dbf.Add(db);
                            break;
                        case(4):
                            AllBGS4Dbf.Add(db);
                            break;
                        case(5):
                            AllBGS5Dbf.Add(db);
                            break;
                        case(6):
                            AllBGS6Dbf.Add(db);
                            break;
                        case(7):
                            AllBGS7Dbf.Add(db);
                            break;
                    }
                    if(db.RareType==RareType.Legendary)
                    {
                        AllBGSlegendaryDbf.Add(db);
                    }
                    if(db.Description.Contains("<b>亡语：</b>"))
                    {
                        AllBGSdeathrattleDbf.Add(db);
                    }
                    List<int> rcs = new List<int>();
                    foreach(RaceType rc in db.RaceType)
                    {
                        rcs.Add((int)rc);
                    }
                    //List<RaceType> rcs = db.RaceType;

                    if(rcs.Contains(2) || rcs.Contains(0))
                    {
                        AllBGSdemonDbf.Add(db);
                    }
                    if(rcs.Contains(11) || rcs.Contains(0))
                    {
                        AllBGSpirateDbf.Add(db);
                    }
                    if(rcs.Contains(1) || rcs.Contains(0))
                    {
                        AllBGSbeastDbf.Add(db);
                    }
                    if(rcs.Contains(3) || rcs.Contains(0))
                    {
                        AllBGSdragonDbf.Add(db);
                    }
                    if(rcs.Contains(14) || rcs.Contains(0))
                    {
                        AllBGSundeadDbf.Add(db);
                    }
                    if(rcs.Contains(7) || rcs.Contains(0))
                    {
                        AllBGSmurlocDbf.Add(db);
                    }
                }
            }
        }
       
    }
    public static void LoadPlay()
    {
        string json = Resources.Load<TextAsset>("ServerData/Play/CollectibleCards").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        CardDbf.AllCardDbf = JsonConvert.DeserializeObject<List<CardDbf>>(json);
        //Debug.Log(AllCardDbf.Count);

        foreach (CardDbf db in CardDbf.AllCardDbf)
        {
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        int BasicSetID = miniHearthJsonDef.allSetTags.IndexOf("BASIC");
        string json2 = Resources.Load<TextAsset>("ServerData/Play/NonCollectibleCards").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json2))
        {
            if(db.SetId == BasicSetID || CardDbf.CaheUnCollectibleCard)
            {
                CardDbf.AllCardDbf.Add(db);
            }
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        string json7 = Resources.Load<TextAsset>("ServerData/Play/CollectibleCards_HsNewCards").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json7))
        {
            CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }
    }
    public static void LoadDIY()
    {
       string json3 = Resources.Load<TextAsset>("ServerData/DIY/CollectibleCards_SZB").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json3))
        {
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        string json4 = Resources.Load<TextAsset>("ServerData/DIY/CollectibleCards_SGS").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json4))
        {
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        string json10 = Resources.Load<TextAsset>("ServerData/Play/NonCollectibleCards_FusionCards").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json10))
        {
            CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        } 

        string json8 = Resources.Load<TextAsset>("ServerData/DIY/CollectibleCards_SNAP").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json8))
        {
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        string json9 = Resources.Load<TextAsset>("ServerData/DIY/CollectibleCards_YGO").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json9))
        {
            //CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        string json12 = Resources.Load<TextAsset>("ServerData/DIY/CollectibleCards_PVZ_Plants").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json12))
        {
            CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }

        string json11 = Resources.Load<TextAsset>("ServerData/DIY/CollectibleCards_PVZ_Zombies").text;// File.ReadAllText(Application.dataPath + "/Resources/Data/AllCards.json");//"D:/Projects/unity/CusCCG/Assets/Resources/Data/AllCards.json");
        foreach(CardDbf db in JsonConvert.DeserializeObject<List<CardDbf>>(json11))
        {
            CardDbf.AllCardDbf.Add(db);
            AllCardDbfCahe[db.m_noteMiniGuid]=db;
            AllCardDbfIntCahe[db.DbfId]=db;
        }      
    }

    public static void LoadAllCardDbf(GameMode ModId = GameMode.WildPlay)
    {
        if(ModId==GameMode.WildPlay)
        {
            if (CardDbf.LoadedPlay == true)
            {
                return;
            }

            CardDbf.LoadPlay();
            CardDbf.LoadDIY();

            CardDbf.LoadedPlay = true;
        }
        if(ModId==GameMode.BattleGround)
        {
            if (CardDbf.LoadedBG == true)
            {
                return;
            }
            CardDbf.LoadBG();
            CardDbf.LoadBG_DIY();
            CardDbf.LoadedBG = true;
        }
        if(ModId==GameMode.Mercenary)
        {
            if (CardDbf.LoadedLT == true)
            {
                return;
            }
            CardDbf.LoadLT();
            CardDbf.LoadLT_DIY();
            CardDbf.LoadedLT = true;
        }
    }
}