using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class ChooseDeckBtnManager : MonoBehaviour
{
    public void Awake()
    {
    }

    public GameObject loadingsurf;
    public void ChooseToMenu()
    {
        if(OneSceneManager.Instance.IsMyScene)
        {
            SceneManager.LoadScene("MainMenuMy");
        }
        else{
            SceneManager.LoadScene("MainMenuHS");
        }
    }

    public void ChooseToPlay()
    {
        Command.BeginRecord();
        loadingsurf.SetActive(true);
        if(OneSceneManager.Instance.IsMyScene)
        {
            OneSceneManager.SrcScene = "ChooseDeckMy";
            SceneManager.LoadScene("PlayGameMy");
        }
        else{
            OneSceneManager.SrcScene = "ChooseDeckHS";
            SceneManager.LoadScene("PlayGameHS");
        }
    }

    public void ChooseToSnap()
    {

        //CardDbf.LoadAllCardDbf(GameMode.);
        DeckDbf.FliterAllDeckDbf();

        DeckDbf EnemyDeck = new DeckDbf();
        DeckDbf MyDeck = new DeckDbf();
        
        EnemyDeck.Hero = new List<CardDbf>();
        EnemyDeck.Hero.Add(CardDbf.GetCardDbfByGuid("HERO_01"));//VAN_EX1_298
        EnemyDeck.Cards = new List<CardDbf>();
        EnemyDeck.HeroPower = new List<CardDbf>();
        EnemyDeck.SideDeck = new List<CardDbf>();

        MyDeck.Hero = new List<CardDbf>();
        MyDeck.Hero.Add(CardDbf.GetCardDbfByGuid("HERO_01"));//VAN_EX1_572
        MyDeck.Cards = new List<CardDbf>();

        MyDeck.HeroPower = new List<CardDbf>();
        MyDeck.SideDeck = new List<CardDbf>();


        for(int i =0; i<12;i++)
        {
            EnemyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("SNAP_880000"));//BaconShopDirector
        }


        for(int i=0; i<12;i++)
        {
            MyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("SNAP_880000"));
        }

        DeckDbf.LowDeck = MyDeck;
        DeckDbf.TopDeck = EnemyDeck;

        if(OneSceneManager.Instance.IsMyScene)
        {
            OneSceneManager.SrcScene = "ChooseDeckMy";
            SceneManager.LoadScene("SnapMy");
        }
        else{
            OneSceneManager.SrcScene = "ChooseDeckHS";
            SceneManager.LoadScene("SnapHS");
        }        
    }

    public void ChooseToBgTest()
    {
        CardDbf.LoadAllCardDbf(GameMode.BattleGround);
        DeckDbf.FliterAllDeckDbf();

        DeckDbf EnemyDeck = new DeckDbf();
        DeckDbf MyDeck = new DeckDbf();
        
        EnemyDeck.Hero = new List<CardDbf>();
        EnemyDeck.Hero.Add(CardDbf.GetCardDbfByGuid("VAN_EX1_298"));//VAN_EX1_298
        EnemyDeck.Cards = new List<CardDbf>();
        EnemyDeck.HeroPower = new List<CardDbf>();
        EnemyDeck.SideDeck = new List<CardDbf>();

        MyDeck.Hero = new List<CardDbf>();
        MyDeck.Hero.Add(CardDbf.GetCardDbfByGuid("VAN_EX1_572"));//VAN_EX1_572
        MyDeck.Cards = new List<CardDbf>();

        MyDeck.HeroPower = new List<CardDbf>();
        MyDeck.SideDeck = new List<CardDbf>();


        for(int i =0; i<1;i++)
        {
            EnemyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("TMP_DIR"));//BaconShopDirector
        }


        for(int i=0; i<1;i++)
        {
            MyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("BG_BOT_911"));
        }

        DeckDbf.LowDeck = MyDeck;
        DeckDbf.TopDeck = EnemyDeck;

        if(OneSceneManager.Instance.IsMyScene)
        {
            OneSceneManager.SrcScene = "RoguelikeMy";
            SceneManager.LoadScene("PlayGameMy");   
        }
        else{
            OneSceneManager.SrcScene = "RoguelikeHS";
            SceneManager.LoadScene("PlayGameHS");   
        }
    }
    public void ChooseToBg_LT()
    {
        CardDbf.LoadAllCardDbf(GameMode.Mercenary);
        DeckDbf.FliterAllDeckDbf();

        DeckDbf EnemyDeck = new DeckDbf();
        DeckDbf MyDeck = new DeckDbf();
        
        EnemyDeck.Hero = new List<CardDbf>();
        EnemyDeck.Hero.Add(CardDbf.GetCardDbfByGuid("FTBG_LT_Bob"));//VAN_EX1_298//FTBG_Bob
        EnemyDeck.Cards = new List<CardDbf>();
        EnemyDeck.HeroPower = new List<CardDbf>();
        EnemyDeck.SideDeck = new List<CardDbf>();

        MyDeck.Hero = new List<CardDbf>();
        MyDeck.Hero.Add(CardDbf.GetCardDbfByGuid("FTBG_LT_Hero"));//VAN_EX1_572//FTBG_Hero
        MyDeck.Cards = new List<CardDbf>();

        MyDeck.HeroPower = new List<CardDbf>();
        MyDeck.SideDeck = new List<CardDbf>();


        for(int i =0; i<1;i++)
        {
            EnemyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("FTBG_LT_DIR"));//BaconShopDirector//FTBG_DIR
        }


        for(int i=0; i<1;i++)
        {
            MyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("BG_BOT_911"));
        }

        DeckDbf.LowDeck = MyDeck;
        DeckDbf.TopDeck = EnemyDeck;

        if(OneSceneManager.Instance.IsMyScene)
        {
            OneSceneManager.SrcScene = "RoguelikeMy";
            SceneManager.LoadScene("PlayGameMy");   
        }
        else{
            OneSceneManager.SrcScene = "RoguelikeHS";
            SceneManager.LoadScene("PlayGameHS");   
        }
    }

    public void ChooseToBg()
    {
        CardDbf.LoadAllCardDbf(GameMode.BattleGround);
        DeckDbf.FliterAllDeckDbf();

        DeckDbf EnemyDeck = new DeckDbf();
        DeckDbf MyDeck = new DeckDbf();
        
        EnemyDeck.Hero = new List<CardDbf>();
        EnemyDeck.Hero.Add(CardDbf.GetCardDbfByGuid("FTBG_Bob"));//VAN_EX1_298//FTBG_Bob
        EnemyDeck.Cards = new List<CardDbf>();
        EnemyDeck.HeroPower = new List<CardDbf>();
        EnemyDeck.SideDeck = new List<CardDbf>();

        MyDeck.Hero = new List<CardDbf>();
        MyDeck.Hero.Add(CardDbf.GetCardDbfByGuid("FTBG_Hero"));//VAN_EX1_572//FTBG_Hero
        MyDeck.Cards = new List<CardDbf>();

        MyDeck.HeroPower = new List<CardDbf>();
        MyDeck.SideDeck = new List<CardDbf>();


        for(int i =0; i<1;i++)
        {
            EnemyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("FTBG_DIR"));//BaconShopDirector//FTBG_DIR
        }


        for(int i=0; i<1;i++)
        {
            MyDeck.Cards.Add(CardDbf.GetCardDbfByGuid("BG_BOT_911"));
        }

        DeckDbf.LowDeck = MyDeck;
        DeckDbf.TopDeck = EnemyDeck;

        if(OneSceneManager.Instance.IsMyScene)
        {
            OneSceneManager.SrcScene = "RoguelikeMy";
            SceneManager.LoadScene("PlayGameMy");   
        }
        else{
            OneSceneManager.SrcScene = "RoguelikeHS";
            SceneManager.LoadScene("PlayGameHS");   
        }
    }
    public void SetReplayMode()
    {
        Command.LoadRecord();
        this.ChooseToPlay();
    }
    public void SetRecordMode()
    {
        Command.BeginRecord();
        this.ChooseToPlay();
    }
    public void ChooseToTest()
    {
        SceneManager.LoadScene("Test");//"HSgoldenShow");
    }
}

