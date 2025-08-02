using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
#if UNITY_EDITOR
using UnityEditor;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

public class ChangePrefab : EditorWindow
{
    [MenuItem("Window/ChangePrefab")]
    static void Init()
    {
        ChangePrefab myWindow = (ChangePrefab)EditorWindow.GetWindow(typeof(ChangePrefab), false, "ChangePrefab", true); myWindow.Show();
    }

    Font toChange;
    static Font toChangeFont;
    FontStyle toFontStyle;
    static FontStyle toChangeFontStyle;

    private void OnGUI()
    {
        toChange = (Font)EditorGUILayout.ObjectField(toChange, typeof(Font), true, GUILayout.MinWidth(100f));
        toChangeFont = toChange;
        toFontStyle = (FontStyle)EditorGUILayout.EnumPopup(toFontStyle, GUILayout.MinWidth(100f));
        toChangeFontStyle = toFontStyle;

        GUILayout.Space(10);
        if (GUILayout.Button("Replace Font"))
        {
            ReplaceFont();
        }
        GUILayout.Space(10);
        if (GUILayout.Button("Replace VFX"))
        {
            ReplaceVFX();
        }

        GUILayout.Space(10);
        if (GUILayout.Button("Replace CardDbf"))
        {
            ReplaceCardDbf();
        }

        GUILayout.Space(10);
        if (GUILayout.Button("Gen CardJson From CardDbf"))
        {
            GenCardJsonFromCardDbf();
        }

        GUILayout.Space(10);
        if (GUILayout.Button("Gen CardDbf From CardJson"))
        {
            GenCardDbfFromCardJson();
        }
        GUILayout.Space(10);
        if (GUILayout.Button("Mod CardDbf From CardJson"))
        {
            ModCardDbfFromCardJson();
        }
        if (GUILayout.Button("Gen UserJson From UserAsset"))
        {
            GenUserJsonFromUserAsset();
        }
        GUILayout.Space(10);
        if (GUILayout.Button("ToDataSet"))
        {
            ToDataSet();
        }

        GUILayout.Space(10);

        if (GUILayout.Button("GenGamePlayData"))
        {
            GenGamePlayData();
        }


    }
    public static void GenGamePlayData()
    {
        CardDbf.LoadAllCardDbf();
        //CardDbf.FliterAllCardDbf();
        DeckDbf.FliterAllDeckDbf();
        //DeckDbf.LoadAllDecksFromDisk();
        /*
        foreach (DeckDbf ca in Resources.LoadAll<DeckDbf>("Decks/UsingDecks/"))
        {
            if (ca.DeckName == "AItest")
            {
                DeckDbf.TopDeck = ca;
                DeckDbf.LowDeck = ca;
            }
        }*/
        Game g = Game.CreateGame(new List<int> { (int)GameTag.LowPlayerID, (int)GameTag.TopPlayerID },
            new List<DeckDbf> { DeckDbf.ToDbf(DeckDbf.LowDeck), DeckDbf.ToDbf(DeckDbf.TopDeck) },
            new List<int> {1,1},Visual:false);
        g.StartGame();
    }
    public static void ToDataSet()
    {
        int CNT=0;
        int BatchSize=5000;
        int BatchIndex=1;
        foreach(int id in Viewer.allCardIDs)
        {
            CNT+=1;
            if(CNT>BatchSize*(BatchIndex-1) && CNT<=BatchSize*BatchIndex)
            {
                ImportSV.ExportDataSetID(id); 
            } 
        }       
    }

    public static void GenCardJsonFromCardDbfByModID(int modID)
    {
        /*
        string ModName = miniHearthJsonDef.allModTags[modID];
        List<CardDbf> AllDbf = new List<CardDbf>();
        foreach (CardDbf ca in Resources.LoadAll<CardDbf>("Cards/"+ModName+"/"))
        {
            CardDbf dbf = new CardDbf();
            dbf.ModId = ca.ModId;
            dbf.SetId = ca.SetId;
            dbf.DbfId = ca.DbfId;
            dbf.m_noteMiniGuid = ca.m_noteMiniGuid;
            dbf.CnName = ca.CnName;
            dbf.ScriptName = ca.ScriptName;
            dbf.CardType = ca.CardType;
            dbf.RareType = ca.RareType;
            dbf.RaceType = ca.RaceType;
            dbf.SpellType = ca.SpellType;
            dbf.ManaCost = ca.ManaCost;
            dbf.Attack = ca.Attack;
            dbf.MaxHealth = ca.MaxHealth;
            dbf.Targets = ca.Targets;
            dbf.Classes = ca.Classes;
            dbf.Description = ca.Description;
            AllDbf.Add(dbf);

        }

        string AllStr = "[";
        int N = AllDbf.Count;
        for (int i = 0; i < N; i++)
        {
            AllStr += JsonUtility.ToJson(AllDbf[i]);
            if (i != N - 1)
            {
                AllStr += ",";
            }
        }
        AllStr += "]";
        
        string FileUrl = Application.dataPath + "/Resources/ServerData/"+ModName+".json";
        File.WriteAllText(FileUrl, AllStr);
        */

    }
    public static void GenCardJsonFromCardDbf()
    {
        //foreach (DeckDbf da in Resources.LoadAll<DeckDbf>("Decks/UsingDecks/"))
        //{
        //    DeckDbf.AllDeckDbf.Add(da);
        //}
        //DeckDbf.LoadAllDecksFromDisk();
        GenCardJsonFromCardDbfByModID(1);
        GenCardJsonFromCardDbfByModID(0);

        //CardDbf ca2 = ScriptableObject.CreateInstance<CardDbf>();
        //ca2.RelatedAsset = AllAsset;
        //AssetDatabase.CreateAsset(ca2,"Assets/Resources/PreLoad/PreLoadCardDbfs.asset");

        //AssetDatabase.SaveAssets();
        //AssetDatabase.Refresh();
        //DeckDbf.SaveAllDecksToDisk();
        //UserDbf.LoggedUser = new UserDbf();
        //for(int i =0;i<N;i++)
        //{
        //    UserDbf.LoggedUser.CardCollectionNums.Add(0);
        //}
        //UserDbf.SaveLoggedUserDbfToDisk();
        Debug.Log("Done Gen CardJson from CardDbf !");  
    }

    public static void GenCardDbfFromImage()
    {
        /*
        //Debug.Log(Application.dataPath);
        string json = File.ReadAllText(Application.dataPath + "/Resources/ServerData/ToGen.json");
        List<CardDbf> records = JsonConvert.DeserializeObject<List<CardDbf>>(json);
        foreach (CardDbf dbf in records)
        {
            if (dbf.DbfId == 0)
            {             //Debug.Log(string.Format("Answer: {0}, Mark: {1}", record.Classes[0].ToString(), record.ScriptName));
                CardDbf ca = ScriptableObject.CreateInstance<CardDbf>();
                ca.DbfId = dbf.DbfId;
                ca.SetId = dbf.SetId;

                ca.CnName = dbf.CnName;
                ca.ScriptName = dbf.ScriptName;
                ca.CardType = dbf.CardType;
                ca.RareType = dbf.RareType;
                ca.RaceType = dbf.RaceType;
                ca.ManaCost = dbf.ManaCost;
                ca.Attack = dbf.Attack;
                ca.MaxHealth = dbf.MaxHealth;
                ca.Targets = dbf.Targets;
                ca.Classes = dbf.Classes;
                ca.Description = dbf.Description;
                AssetDatabase.CreateAsset(ca,"Assets/Resources/Cards/blueCube.asset");
            }

        }
        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();  
        */
    }
    public static List<string> allClassTags= new List<string>(){"NEUTRAL", "DEATHKNIGHT", "DEMONHUNTER", "DRUID", "HUNTER", "MAGE", "PALADIN", "PRIEST", "ROGUE", "SHAMAN", "WARLOCK", "WARRIOR", "MONK"};
    //public static List<string> allSetTags= new List<string>(){"ADIY","ALTERAC_VALLEY", "BATTLE_OF_THE_BANDS", "BLACK_TEMPLE", "BOOMSDAY", "BRM", "CORE", "DALARAN", "DARKMOON_FAIRE", "DEMON_HUNTER_INITIATE", "DRAGONS", "EVENT", "EXPERT1", "GANGS", "GILNEAS", "GVG", "HERO_POWERS","HERO_SKINS", "ICECROWN", "ISLAND_VACATION", "KARA", "LEGACY", "LOE", "LOOTAPALOOZA", "NAXX", "OG", "PATH_OF_ARTHAS", "PLACEHOLDER_202204", "RETURN_OF_THE_LICH_KING", "REVENDRETH", "SCHOLOMANCE", "STORMWIND", "TGT", "THE_BARRENS", "THE_SUNKEN_CITY", "TITANS", "TROLL", "ULDUM", "UNGORO", "VANILLA", "WHIZBANGS_WORKSHOP", "WILD_WEST", "WONDERS", "YEAR_OF_THE_DRAGON"};



    public static void ModCardDbfFromCardJson()
    {   
        /*
        string BaseUrl = "Cards/NonCollectibleCards/";
        for(int i =0 ;i<miniHearthJsonDef.allSetTags.Count;i++)
        {
            foreach(CardDbf ca in Resources.LoadAll<CardDbf>(BaseUrl+miniHearthJsonDef.allSetTags[i]+'/'))
            {
                EditorUtility.SetDirty(ca);
                ca.SetId=i;
            }
        }
        */
        /*
        string json = File.ReadAllText(Application.dataPath + "/Scripts/Tools/PyTools/GetAllHearhstoneCard/HSrequest/Jsons/CardDB_zhCN.json");
        List<miniHearthJsonDef> records = JsonConvert.DeserializeObject<List<miniHearthJsonDef>>(json);
        foreach (miniHearthJsonDef dbf in records)
        {
            string Fpath="Cards/";
            if(dbf.collectible)
            {
                Fpath+="CollectibleCards/";
            }
            else
            {
                Fpath+="NonCollectibleCards/";
            }
            if(dbf.cardClass=="" && dbf.classes.Count==0)
            {
                dbf.cardClass="NEUTRAL";
            }
            Fpath+=dbf.set+"/";
            Fpath+=dbf.cardClass+"/";

            UnityEngine.Debug.Log(Fpath+dbf.id);
            CardDbf ca = Resources.Load<CardDbf>(Fpath+dbf.id);
            EditorUtility.SetDirty(ca);
            //ca.Targets = dbf.Targets;
            ca.DbfId = dbf.dbfId;
            ca.ModId=0;
            if(dbf.collectible)
            {
                ca.ModId=1;
            }
            ca.SetId = miniHearthJsonDef.allSetTags.IndexOf(dbf.set);
            
            ca.Classes.Clear();
            if(dbf.cardClass!="")
                ca.Classes.Add((ClassType)miniHearthJsonDef.allClassTags.IndexOf(dbf.cardClass));
            foreach(string dbcls in dbf.classes)
            {
                if(ca.Classes.Contains((ClassType)miniHearthJsonDef.allClassTags.IndexOf(dbcls)))
                {
                }
                else{
                    ca.Classes.Add((ClassType)miniHearthJsonDef.allClassTags.IndexOf(dbcls));
                }  
            }
            */
            /*
            ca.m_noteMiniGuid = dbf.id;
            ca.CnName = dbf.name;
            ca.ManaCost = dbf.cost;
            ca.Attack = dbf.attack;
            ca.MaxHealth = dbf.health;
            if(dbf.durability!=0)
            {
                ca.MaxHealth = dbf.durability;
            }
            if(dbf.armor!=0 && ca.MaxHealth==30)
            {
                ca.MaxHealth = dbf.armor;
            }

            ca.Description = dbf.text;
            ca.ScriptName = dbf.id;


            ca.CardType = (CardType)miniHearthJsonDef.allTypeTags.IndexOf(dbf.type);
            if(dbf.mechanics.Contains("SECRET"))
            {
                ca.CardType=CardType.Secret;
            }
            ca.RareType = (RareType)miniHearthJsonDef.allRareTags.IndexOf(dbf.rarity);

            ca.RaceType.Clear();
            foreach(string dbcls in dbf.races)
            {
                ca.RaceType.Add((RaceType)miniHearthJsonDef.allRaceTags.IndexOf(dbcls));
            }

            ca.SpellType.Clear();
            if(dbf.spellSchool!="")
                ca.SpellType.Add((SpellType)miniHearthJsonDef.allspellSchoolTags.IndexOf(dbf.spellSchool));

            */        
        //}

        AssetDatabase.SaveAssets();
        AssetDatabase.Refresh();     
    }

    public static void GenCardDbfFromCardJson()
    {
        
        string json = File.ReadAllText(Application.dataPath + "/Scripts/Tools/PyTools/GetAllHearhstoneCard/HSrequest/Jsons/CardDB_zhCN.json");
        List<miniHearthJsonDef> records = JsonConvert.DeserializeObject<List<miniHearthJsonDef>>(json);
        List<CardDbf> AllDbf = new List<CardDbf>();
        foreach (miniHearthJsonDef dbf in records)
        {
            if(dbf.techLevel==0)
            {
                continue;
            }
            CardDbf ca = new CardDbf();

            ca.m_noteMiniGuid = dbf.id;

            ca.CnName = dbf.name;
            
            ca.ManaCost = dbf.cost;
            ca.Attack = dbf.attack;
            ca.MaxHealth = dbf.health;
            
            if(dbf.durability!=0)
            {
                ca.MaxHealth = dbf.durability;
            }
            if(dbf.armor!=0 && ca.MaxHealth==30)
            {
                ca.MaxHealth = dbf.armor;
            }

            ca.Description = dbf.text;

            ca.Classes.Clear();
            if(dbf.cardClass!="")
                ca.Classes.Add((ClassType)miniHearthJsonDef.allClassTags.IndexOf(dbf.cardClass));
            foreach(string dbcls in dbf.classes)
            {
                if(ca.Classes.Contains((ClassType)miniHearthJsonDef.allClassTags.IndexOf(dbcls)))
                {
                }
                else{
                    ca.Classes.Add((ClassType)miniHearthJsonDef.allClassTags.IndexOf(dbcls));
                }
                
            }
            ca.CardType = (CardType)miniHearthJsonDef.allTypeTags.IndexOf(dbf.type);
            if(dbf.mechanics.Contains("SECRET"))
            {
                ca.CardType=CardType.Secret;
            }
            UnityEngine.Debug.Log(dbf.rarity);
            ca.RareType = (RareType)miniHearthJsonDef.allRareTags.IndexOf(dbf.rarity);

            ca.RaceType.Clear();
            foreach(string dbcls in dbf.races)
            {
                ca.RaceType.Add((RaceType)miniHearthJsonDef.allRaceTags.IndexOf(dbcls));
            }

            ca.SpellType.Clear();
            if(dbf.spellSchool!="")
                ca.SpellType.Add((SpellSchoolType)miniHearthJsonDef.allspellSchoolTags.IndexOf(dbf.spellSchool));
            //ca.Targets = dbf.Targets;
            ca.DbfId = dbf.dbfId;

            ca.ModId=0;
            if(dbf.collectible)
            {
                ca.ModId=1;
            }
            ca.SetId = miniHearthJsonDef.allSetTags.IndexOf(dbf.set);
            
            AllDbf.Add(ca);
        }


        string AllStr = "[";
        int N = AllDbf.Count;
        for (int i = 0; i < N; i++)
        {
            AllStr += JsonUtility.ToJson(AllDbf[i]);
            if (i != N - 1)
            {
                AllStr += ",";
            }
        }
        AllStr += "]";
        string FileUrl = MyAssetsLoader.GetStreamingsAssetPath() + "/test.json";
        //File.WriteAllText(FileUrl, AllStr);
        using(StreamWriter sw = new StreamWriter(FileUrl,false,Encoding.UTF8))
        {
            sw.WriteLine(AllStr);
            sw.Close();
            sw.Dispose();
        }     
        UnityEngine.Debug.Log("SuccessGenDbfFromJson");
    }
    public static void ReplaceCardDbf()
    {
        /*
        foreach (CardDbf ca in Resources.LoadAll<CardDbf>("AllCards/Hero/"))
        {
            if (ca.CardType == CardType.Hero)
            {
                //ca.CustomEmoteTexts[2] = ca.CnName + "成功解场";
                //ca.CustomEmoteTexts[3] = ca.CnName + "未能解场";
            }
        }
        */
    }
    public static void ReplaceFont()
    {
        Font f = Resources.Load<Font>("Arts/MyArt/Fonts/SourceHanSans-Heavy");

        string[] sdirs = { "Assets/Resources/Prefabs/" };
        var asstIds = AssetDatabase.FindAssets("t:Prefab", sdirs);
        Debug.Log(asstIds.Length.ToString());
        if (toChangeFont == null)
        {
            Debug.Log("Null Font");
        }
        for (int i = 0; i < asstIds.Length; i++)
        {
            string path = AssetDatabase.GUIDToAssetPath(asstIds[i]);
            var pfb = AssetDatabase.LoadAssetAtPath<GameObject>(path);

            Text[] ptc = pfb.GetComponentsInChildren<Text>();
            foreach (Text pc in ptc)
            {
                Debug.Log(pc.text);
                pc.font = f;
                EditorUtility.SetDirty(pc);
            }
        }
    }
    public static void ReplaceVFX()
    {
        string[] sdirs = { "Assets/Resources/Prefabs/SpellsPack/" };
        var asstIds = AssetDatabase.FindAssets("t:Prefab", sdirs);
        Debug.Log(asstIds.Length.ToString());
        for (int i = 0; i < asstIds.Length; i++)
        {
            string path = AssetDatabase.GUIDToAssetPath(asstIds[i]);
            var pfb = AssetDatabase.LoadAssetAtPath<GameObject>(path);
            Debug.Log(path);
            ParticleSystem[] ptc = pfb.GetComponentsInChildren<ParticleSystem>();
            foreach (ParticleSystem pc in ptc)
            {
                //pc.scalingMode = ParticleSystemScalingMode.Hierarchy;//pc.sortingLayerID = -1697044437; pc.sortingOrder = 999;
            }

            //ParticleSystem[] ptc2 = pfb.GetComponentsInChildren<ParticleSystem>();
            //foreach (ParticleSystem pc in ptc2)
            //{
            //}
        }
    }


    public static void GenUserJsonFromUserAsset()
    {
        List<string> AllUserNames = new List<string>(){"admin","CodeBrain_2024","123456"};
        List<string> AllUserPasswords = new List<string>(){"admin_pwd","CodeBrain_pwd","123456"};
        List<UserDbf> AllDbf=new List<UserDbf>();

        for(int i =0;i<AllUserNames.Count;i++)
        {
            UserDbf udb = new UserDbf();
            udb.UserName = AllUserNames[i];
            udb.UserPassword = AllUserPasswords[i];
            AllDbf.Add(udb);
        }
        string AllStr = "[";
        int N = AllDbf.Count;
        for (int i = 0; i < N; i++)
        {
            AllStr += JsonUtility.ToJson(AllDbf[i]);
            if (i != N - 1)
            {
                AllStr += ",";
            }
        }
        AllStr += "]";
        string FileUrl = Application.dataPath + "/Resources/ServerData/AllUsers.json";
        File.WriteAllText(FileUrl, AllStr);
        //UserDbf.SaveLoggedUserDbfToDisk();
        UnityEngine.Debug.Log("GenUserJsonFromUserAsset！");
    }

}

#endif