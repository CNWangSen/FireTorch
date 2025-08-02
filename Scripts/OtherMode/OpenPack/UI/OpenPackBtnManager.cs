using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class OpenPackBtnManager : MonoBehaviour
{
    public void PackToMenu()
    {
        UserDbf.SaveLoggedUserDbfToDisk();
        if(OneSceneManager.Instance.IsMyScene)
        {
            SceneManager.LoadScene("MainMenuMy");   
        }
        else{
            SceneManager.LoadScene("MainMenuHS");   
        }
    }
}

