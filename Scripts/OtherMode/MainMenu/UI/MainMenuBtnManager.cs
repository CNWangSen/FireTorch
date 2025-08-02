using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class MainMenuBtnManager : MonoBehaviour
{
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
    public void MenuToLog()
    {
        UserDbf.LoggedUser.IsLogged=false;
        UserDbf.SaveLoggedUserDbfToDisk();
        SceneManager.LoadScene("LogIn");
    }
    public void MenuToPlay()
    {
        if(OneSceneManager.Instance.IsMyScene)
        {
            SceneManager.LoadScene("ChooseDeckMy");   
        }
        else{
            SceneManager.LoadScene("ChooseDeckHS");   
        }
    }

    public void MenuToStore()
    {
        if(OneSceneManager.Instance.IsMyScene)
        {
            SceneManager.LoadScene("StoreMy");   
        }
        else{
            SceneManager.LoadScene("StoreHS");   
        }
    }

    public void MenuToPack()
    {
        if(OneSceneManager.Instance.IsMyScene)
        {
            SceneManager.LoadScene("OpenPackMy");   
        }
        else{
            SceneManager.LoadScene("OpenPackHS");   
        }
    }

    public void MenuToDeck()
    {
        if(OneSceneManager.Instance.IsMyScene)
        {
            SceneManager.LoadScene("BuildDeckMy");   
        }
        else{
            SceneManager.LoadScene("BuildDeckHS");   
        }
    }

    public void MenuToRogue()
    {
        if(OneSceneManager.Instance.IsMyScene)
        {
            SceneManager.LoadScene("RoguelikeMy");   
        }
        else{
            SceneManager.LoadScene("RoguelikeHS");   
        }
    }

    public void ExitGame()
    {
        //SceneManager.LoadScene("LogIn");
        Application.Quit();
    }
}

