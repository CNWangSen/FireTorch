using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayGameBtnManager : MonoBehaviour
{
    public static void PlayToMenu()
    {
        Command.isGameOver=false;
        Command.CommandQueue.Clear();
        Command.playingQueue=false;
        //Command.LoadRecord();
        //Command.isRecording=false;
        //Command.isReplaying=true;
        if(OneSceneManager.Instance.IsMyScene)
        {
            SceneManager.LoadScene("MainMenuMy");   
        }
        else{
            SceneManager.LoadScene("MainMenuHS");   
        }
    }
}

