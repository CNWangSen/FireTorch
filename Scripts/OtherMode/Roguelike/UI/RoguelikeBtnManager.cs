using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections.Generic;

public class RoguelikeBtnManager : MonoBehaviour
{
    public void RogueToMenu()
    {
        if(OneSceneManager.Instance.IsMyScene)
        {
            SceneManager.LoadScene("MainMenuMy");  
        }
        else{
            SceneManager.LoadScene("MainMenuHS");   
        }
    }

    public TMP_InputField DeckId;
    public void RogueToPlay()
    {
        int did = int.Parse(DeckId.text);

        List<CardDbf> OverrideMyDeck = RoguelikeManager.SetOverrideMyDeck(did);
        if(did!=-1)
        {
            RoguelikeManager.MyDeck.Cards = OverrideMyDeck;
        }

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




    public void ChooseReward1()
    {
        RoguelikeManager.ChooseReward(0);
        RogueToPlay();
    }

    public void ChooseReward2()
    {
        RoguelikeManager.ChooseReward(1);
        RogueToPlay();
    }

    public void ChooseReward3()
    {
        RoguelikeManager.ChooseReward(2);   
        RogueToPlay();
    }


}

