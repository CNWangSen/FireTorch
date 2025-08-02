using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using System.Text;

public class DeckDbf
{
    public List<CardDbf> Hero = new List<CardDbf>();
    public List<CardDbf> HeroPower = new List<CardDbf>();
    public List<CardDbf> Cards = new List<CardDbf>();
    public List<CardDbf> SideDeck = new List<CardDbf>();
    public CardDbf FatigueCard;

    [JsonProperty][SerializeField]
    internal string DeckName;
    [JsonProperty][SerializeField]
    internal int DbfId;
    [JsonProperty][SerializeField]
    internal List<int> HeroDbfIds = new List<int>();
    [JsonProperty][SerializeField]
    internal List<int> HeroPowerDbfIds = new List<int>();
    [JsonProperty][SerializeField]
    internal List<int> CardsDbfIds = new List<int>();
    [JsonProperty][SerializeField]
    internal List<int> SideDeckDbfIds = new List<int>();
    [JsonProperty][SerializeField]
    internal int FatigueCardDbfId;
    [JsonProperty][SerializeField]
    internal int DeckScore = 30;
    [JsonProperty][SerializeField]
    internal bool InRank = false;



    public static List<DeckDbf> AllDeckDbf = new List<DeckDbf>();
    public static DeckDbf TopDeck;
    public static DeckDbf LowDeck;
    public static DeckDbf EditingDeck;

    public static DeckDbf GetDeckDbfByDbfId(int DbfId)
    {
        DeckDbf Asset = null;
        foreach (DeckDbf ass in AllDeckDbf)
        {
            if (ass.DbfId == DbfId)
            {
                Asset = ass;
                break;
            }
        }
        return Asset;
    }

 
    public static void LoadAllDecksFromDisk()
    {
        //return;
        CardDbf.LoadAllCardDbf();
        UnityEngine.Debug.Log("LoadingDecksFromDisk");
        string FileUrl = MyAssetsLoader.GetStreamingsAssetPath() + "/AllDecks.json";
        string json;
        using(StreamReader sr = new StreamReader(FileUrl))
        {
            json = sr.ReadToEnd();
            sr.Close();
        }
        //string json = Resources.Load<TextAsset>("Decks/AllDecks").text;//File.ReadAllText(Application.dataPath + "/Resources/Decks/AllDecks.json");
        DeckDbf.AllDeckDbf = JsonConvert.DeserializeObject<List<DeckDbf>>(json);
        foreach(DeckDbf d in DeckDbf.AllDeckDbf)
        {
            //UnityEngine.Debug.Log(d.DeckName);
            foreach(int i in d.HeroDbfIds)
            {
                d.Hero.Add(CardDbf.GetCardDbfByDbfId(i));
            }
            foreach(int i in d.HeroPowerDbfIds)
            {
                d.HeroPower.Add(CardDbf.GetCardDbfByDbfId(i));
            }
            foreach(int i in d.CardsDbfIds)
            {
                d.Cards.Add(CardDbf.GetCardDbfByDbfId(i));
            }
            //UnityEngine.Debug.Log(d.Hero.Count);
        }
        //DeckDbf NewDeck = new DeckDbf();
        //NewDeck.DeckName="test2";
        //DeckDbf.AllDeckDbf.Insert(0,NewDeck);
    }
    public static int DefaultFatigueID = 549;
    public static void SaveAllDecksToDisk()
    {
        //return;
        List<DeckDbf> AllDbf = DeckDbf.AllDeckDbf;
        foreach(DeckDbf d in AllDeckDbf)
        {
            d.HeroDbfIds=new List<int>();
            foreach(CardDbf c in d.Hero)
            {
                d.HeroDbfIds.Add(c.DbfId);
            }

            d.HeroPowerDbfIds=new List<int>();
            foreach(CardDbf c in d.HeroPower)
            {
                d.HeroPowerDbfIds.Add(c.DbfId);
            }

            d.CardsDbfIds=new List<int>();
            foreach(CardDbf c in d.Cards)
            {
                d.CardsDbfIds.Add(c.DbfId);
            }            
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
        string FileUrl = MyAssetsLoader.GetStreamingsAssetPath() + "/AllDecks.json";
        //File.WriteAllText(FileUrl, AllStr);
        using(StreamWriter sw = new StreamWriter(FileUrl,false,Encoding.UTF8))
        {
            sw.WriteLine(AllStr);
            sw.Close();
            sw.Dispose();
        }
        //DeckDbf.ExportCards();
    }

    public static void ExportCards()
    {
        List<string> lines = new List<string>();
        foreach(DeckDbf d in DeckDbf.AllDeckDbf)
        {
            foreach(CardDbf c in d.Cards)
            {
                if(!c.IsImplemented())
                {
                    if(!lines.Contains(c.CnName))
                        lines.Add(c.CnName);
                }
            }
        }
        System.IO.File.WriteAllLines("D:/Projects/unity/CusCCG/Assets/Scripts/Tools/Docs/CardsToImp.txt",lines);
    }

    public static DeckDbf ToDbf(DeckDbf dk)
    {
        return dk;
    }
    public static void FliterTestingDeckDbf()
    {
    }
    public static void FliterAllDeckDbf()
    {
        AllDeckDbf.Clear();
        DeckDbf.LoadAllDecksFromDisk();
    }

}