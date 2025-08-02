using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Text;

/*
[CreateAssetMenu(menuName = "DeckDbf")]

public class DeckDbf : ScriptableObject
{
    public string DeckName = "空";
    public int DbfId;
    public List<CardDbf> Hero;
    public List<CardDbf> HeroPower;
	public List<CardDbf> Cards;
    public List<CardDbf> SideDeck;
    public CardDbf FatigueCard;
    public int DeckScore = 30;
    public bool InRank = false;
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
        List<DeckDbf> records = JsonConvert.DeserializeObject<List<DeckDbf>>(json);
        foreach (DeckDbf dbf in records)
        {
            DeckDbf da = DeckDbf.AllDeckDbf[dbf.DbfId];
            if(da!=null)
            {
                da.DeckName = dbf.DeckName;
                da.Hero = new List<CardDbf>();
                da.HeroPower = new List<CardDbf>();
                da.Cards = new List<CardDbf>();
                da.SideDeck = new List<CardDbf>();
                foreach(int id in dbf.HeroDbfIds)
                {
                    CardDbf cdb = CardDbf.GetCardDbfByDbfId(id);
                    if(cdb!=null)
                        da.Hero.Add(cdb);
                }
                foreach(int id in dbf.HeroPowerDbfIds)
                {
                    CardDbf cdb = CardDbf.GetCardDbfByDbfId(id);
                    if(cdb!=null)
                        da.HeroPower.Add(cdb);
                }
                foreach(int id in dbf.CardsDbfIds)
                {
                    CardDbf cdb = CardDbf.GetCardDbfByDbfId(id);
                    if(cdb!=null)
                        da.Cards.Add(cdb);
                }
                foreach(int id in dbf.SideDeckDbfIds)
                {
                    CardDbf cdb = CardDbf.GetCardDbfByDbfId(id);
                    if(cdb!=null)
                        da.SideDeck.Add(cdb);
                }
                if(dbf.FatigueCardDbfId!=-1)
                    da.FatigueCard=CardDbf.GetCardDbfByDbfId(dbf.FatigueCardDbfId);
                da.DeckScore = dbf.DeckScore;
                da.InRank = dbf.InRank;
            }
        }
    }
    public static int DefaultFatigueID = 549;
    public static void SaveAllDecksToDisk()
    {
        //return;
        List<DeckDbf> AllDbf = new List<DeckDbf>();
        int DbfIdCount=0;
        foreach (DeckDbf da in Resources.LoadAll<DeckDbf>("Decks/UsingDecks/"))
        {
            DeckDbf dbf = new DeckDbf();
            dbf.DeckName = da.DeckName;
            dbf.DbfId = DbfIdCount;
            dbf.HeroDbfIds = new List<int>();
            dbf.HeroPowerDbfIds = new List<int>();
            dbf.CardsDbfIds = new List<int>();
            dbf.SideDeckDbfIds = new List<int>();
            foreach(CardDbf ca in da.Hero)
            {
                if(ca!=null)
                    dbf.HeroDbfIds.Add(ca.DbfId);
            }
            foreach(CardDbf ca in da.HeroPower)
            {
                if(ca!=null)
                    dbf.HeroPowerDbfIds.Add(ca.DbfId);
            }
            foreach(CardDbf ca in da.Cards)
            {
                if(ca!=null)
                    dbf.CardsDbfIds.Add(ca.DbfId);
            }
            foreach(CardDbf ca in da.SideDeck)
            {
                if(ca!=null)
                    dbf.SideDeckDbfIds.Add(ca.DbfId);
            }
            if(da.FatigueCard!=null)
            {
                dbf.FatigueCardDbfId=da.FatigueCard.DbfId;
                DeckDbf.DefaultFatigueID=da.FatigueCard.DbfId;
            }
            else
            {
                dbf.FatigueCardDbfId=DeckDbf.DefaultFatigueID;//CardDbf.GetCardDbfByName("DefaultFatigue").DbfId;//548;
            }
            dbf.DeckScore = da.DeckScore;
            dbf.InRank = da.InRank;

            AllDbf.Add(dbf);
            DbfIdCount += 1;
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
    }


    public static DeckDbf ToDbf(DeckDbf dk)
    {
        DeckDbf dbf = new DeckDbf();
        foreach (CardDbf hero in dk.Hero)
        {
            dbf.Hero.Add(hero);
        }
        foreach (CardDbf power in dk.HeroPower)
        {
            dbf.HeroPower.Add(power);
        }
        foreach (CardDbf card in dk.Cards)
        {
            dbf.Cards.Add(card);
        }
        foreach (CardDbf sd in dk.SideDeck)
        {
            dbf.SideDeck.Add(sd);
        }
        dbf.FatigueCard = CardDbf.GetCardDbfByGuid("GAME_005");
        return dbf;
    }
    public static void FliterTestingDeckDbf()
    {
        foreach (DeckDbf ca in Resources.LoadAll<DeckDbf>("Decks/TestDeck/"))
        {
            if (ca.name == "TestTop")
            {
                TopDeck = ca;
            }
            if (ca.name == "TestLow")
            {
                LowDeck = ca;
            }
        }
    }
    public static void FliterAllDeckDbf()
    {
        AllDeckDbf.Clear();
        foreach (DeckDbf da in Resources.LoadAll<DeckDbf>("Decks/UsingDecks/"))
        {
            DeckDbf.AllDeckDbf.Add(da);
        }
        DeckDbf.LoadAllDecksFromDisk();
        foreach (DeckDbf ca in Resources.LoadAll<DeckDbf>("Decks/UsingDecks/"))
        {
            if (ca.name == "SceneTopDeck")
            {
                TopDeck = ca;
            }
            else
            {
                if (ca.name == "SceneLowDeck")
                {
                    LowDeck = ca;
                }
                else 
                {
                }
            }
        }

        foreach (DeckDbf ca in AllDeckDbf)
        {

        }

    }
}

*/