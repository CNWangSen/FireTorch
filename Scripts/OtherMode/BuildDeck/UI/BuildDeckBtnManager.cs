using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class BuildDeckBtnManager : MonoBehaviour
{

    public void DeckToMenu()
    {
        DeckDbf.SaveAllDecksToDisk();
        if(OneSceneManager.Instance.IsMyScene)
        {
            SceneManager.LoadScene("MainMenuMy");
        }
        else{
            SceneManager.LoadScene("MainMenuHS");
        }
    }
}

