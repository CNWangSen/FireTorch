using UnityEngine;
using System.Collections.Generic;
using Newtonsoft.Json;
/*
using System.IO;
using System.Text;

[CreateAssetMenu(menuName = "CardAsset")]

public class CardAsset : ScriptableObject
{
    public int ModId=0;
    public int SetId=-1;
    public int DbfId=-1;
    public string m_noteMiniGuid="";
    public List<ClassType> Classes = new List<ClassType>() { ClassType.Neutral};
    public string CnName = "";
    public string ScriptName ="";
    //public Sprite CardImage;
    public CardType CardType;
    public RareType RareType;
    public List<RaceType> RaceType = new List<RaceType>(){};
    public List<SpellType> SpellType = new List<SpellType>{};
    public int ManaCost = 0;
    public int Attack = 0;
    public int MaxHealth = 0;
    public TargetingOptions Targets = TargetingOptions.NoTarget;
    [TextArea(4, 4)]
    public string Description = ""; 
    //public List<CardAsset> RelatedAsset = new List<CardAsset>();
    //public List<AudioClip> CustomEmoteAudioClips = new List<AudioClip>();
    //public List<string> CustomEmoteTexts = new List<string>();
    public VfxAsset SpawnVfxAsset = null;
    public VfxAsset DieVfxAsset = null;
    public VfxAsset MissileVfxAsset = null;
    public AudAsset CustomAudAsset = null;
    public Material CustomMaterial = null;
    //public int CollectionNum=0;
*/
/*
    public static CardAsset CreateACardAssetFromAnother(CardAsset anoth)
    {
        CardAsset newass = ScriptableObject.CreateInstance<CardAsset>();
        newass.SetId = anoth.SetId;
        newass.DbfId = anoth.DbfId;
        newass.name = anoth.name;
        newass.Classes = anoth.Classes;
        newass.CnName = anoth.CnName;
        //newass.CardImage = anoth.CardImage;
        newass.CardType = anoth.CardType;
        newass.RareType = anoth.RareType;
        newass.RaceType = anoth.RaceType;
        newass.SpellType = anoth.SpellType;
        newass.ManaCost = anoth.ManaCost;
        newass.Attack = anoth.Attack;
        newass.MaxHealth = anoth.MaxHealth;
        newass.Targets = anoth.Targets;
        newass.Description = anoth.Description;

        //newass.RelatedAsset = anoth.RelatedAsset;
        newass.SpawnVfxAsset = anoth.SpawnVfxAsset;
        newass.DieVfxAsset = anoth.DieVfxAsset;
        newass.MissileVfxAsset = anoth.MissileVfxAsset;
        newass.CustomAudAsset = anoth.CustomAudAsset;
        newass.CustomMaterial = anoth.CustomMaterial;
        return newass;
    }

    public static List<CardAsset> FiltByMajor(List<CardAsset> ToFilt, ClassType cls)
    {
        List<CardAsset> Filted = new List<CardAsset>();
        foreach(CardAsset asst in ToFilt)
        {
            if (asst.Classes.Contains(cls))
            {
                Filted.Add(asst);
            }
        }
        return Filted;
    }
    public static List<CardAsset> FiltByManaGreaterThan(List<CardAsset> ToFilt, int mana)
    {
        List<CardAsset> Filted = new List<CardAsset>();
        foreach (CardAsset asst in ToFilt)
        {
            if (asst.ManaCost>=mana)
            {
                Filted.Add(asst);
            }
        }
        return Filted;
    }

    public static List<CardAsset> FiltByMana(List<CardAsset> ToFilt, int mana)
    {
        List<CardAsset> Filted = new List<CardAsset>();
        foreach (CardAsset asst in ToFilt)
        {
            if (asst.ManaCost==mana)
            {
                Filted.Add(asst);
            }
        }
        return Filted;
    }

    public static List<CardAsset> FiltByType(List<CardAsset> ToFilt, CardType crd)
    {
        List<CardAsset> Filted = new List<CardAsset>();
        foreach (CardAsset asst in ToFilt)
        {
            if (asst.CardType==crd)
            {
                Filted.Add(asst);
            }
        }
        return Filted;
    }
    public static List<CardAsset> FiltByRace(List<CardAsset> ToFilt, RaceType cls)
    {
        List<CardAsset> Filted = new List<CardAsset>();
        foreach (CardAsset asst in ToFilt)
        {
            if (asst.RaceType.Contains(cls))
            {
                Filted.Add(asst);
            }
        }
        return Filted;
    }
    public static List<CardAsset> FiltByRare(List<CardAsset> ToFilt, RareType cls)
    {
        List<CardAsset> Filted = new List<CardAsset>();
        foreach (CardAsset asst in ToFilt)
        {
            if (asst.RareType==cls)
            {
                Filted.Add(asst);
            }
        }
        return Filted;
    }

    public static List<CardAsset> FiltBySetId(List<CardAsset> ToFilt, int setId)
    {
        List<CardAsset> Filted = new List<CardAsset>();
        foreach (CardAsset asst in ToFilt)
        {
            if (asst.SetId == setId)
            {
                Filted.Add(asst);
            }
        }
        return Filted;
    }

    public static List<CardAsset> FiltByString(List<CardAsset> ToFilt, string str)
    {
        List<CardAsset> Filted = new List<CardAsset>();
        foreach (CardAsset asst in ToFilt)
        {
            if (asst.Description.Contains(str) || asst.CnName.Contains(str))
            {
                Filted.Add(asst);
            }
        }
        return Filted;
    }
    public static CardAsset GetCardAssetByName(string assName)
    {
        CardAsset Asset = null;
        foreach (CardAsset ass in AllAsset)
        {
            if (ass.ScriptName == assName)
            {
                Asset = ass;
                break;
            }
        }
        return Asset;
    }
    public static CardAsset GetCardAssetByDbf(CardDbf dbf)
    {
        if(dbf!=null)
        {
            string Path="Cards/"+miniHearthJsonDef.allModTags[dbf.ModId]+"/"+miniHearthJsonDef.allSetTags[dbf.SetId]+"/"+dbf.ScriptName;
            CardAsset ass2 = Resources.Load<CardAsset>(Path);
            if(ass2!=null)
            {
                //UnityEngine.Debug.Log("Found");
            }
            else
            {
                UnityEngine.Debug.Log(Path);
            }
            return ass2;
        }
        else{
            return null;
        }        
    }
    public static CardAsset GetCardAssetByDbfId(int DbfId)
    {
        CardDbf dbf=CardDbf.GetCardDbfByDbfId(DbfId);
        return CardAsset.GetCardAssetByDbf(dbf);
        //CardAsset Asset = null;
        //foreach (CardAsset ass in AllAsset)
        //{
        //    if (ass.DbfId == DbfId)
        //    {
        //        Asset = ass;
        //        break;
        //    }
        //}
        //return Asset;
    }

    public static void LoadCardCollectionNumFromDisk()
    {
        return;
        //UnityEngine.Debug.Log("LoadingCardCollectionNumFromDisk");
        //string FileUrl = MyAssetsLoader.GetStreamingsAssetPath() + "/AllCardCollectionNum.json";
        //string json;
        //using(StreamReader sr = new StreamReader(FileUrl))
        //{
        //    json = sr.ReadToEnd();
        //    sr.Close();
        //}
        //List<int> records = JsonConvert.DeserializeObject<List<int>>(json);
        //for(int i=0; i<records.Count; i++)
        //{
        //    CardAsset ca = CardAsset.AllAsset[i];
        //    ca.CollectionNum = records[i];
        //}
    }
    public static void SaveCardCollectionNumToDisk()
    {
        return;
        
        List<int> AllCollectionNum = new List<int>();
        foreach (CardAsset ca in CardAsset.AllAsset)
        {
            AllCollectionNum.Add(ca.CollectionNum);
        }
        
        string AllStr = "[";
        int N = AllCollectionNum.Count;
        for (int i = 0; i < N; i++)
        {
            AllStr += JsonUtility.ToJson(AllCollectionNum[i]);
            if (i != N - 1)
            {
                AllStr += ",";
            }
        }
        AllStr += "]";
        string FileUrl = MyAssetsLoader.GetStreamingsAssetPath() + "/AllCardCollectionNum.json";

        using(StreamWriter sw = new StreamWriter(FileUrl,false,Encoding.UTF8))
        {
            sw.WriteLine(AllStr);
            sw.Close();
            sw.Dispose();
        }
        

    }
    

    public static List<CardAsset> AllAsset = new List<CardAsset>();
    public static List<CardAsset> DiscoverPool = new List<CardAsset>();
    public static bool Flitered = false;
    public static void SetDiscoverPool(List<int> SetIds)
    {
        //foreach()
    }
    public static void FliterAllCardAsset()
    {
        return;
        
        UnityEngine.Debug.Log("LoadingCardsFromDisk");
        if (Flitered)
        {
            return;
        }
        Flitered = true;
        foreach (CardAsset ca in Resources.LoadAll<CardAsset>("Cards/"))
        {
            AllAsset.Add(ca);
        }
        
    }
    */
//}
