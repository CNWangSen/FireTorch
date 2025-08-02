using UnityEngine;
using System.Collections;

public class GameOverCommand : Command{
    public GameOverCommand()
    {        
        Response.ServerSend("GameOver");
    }

    public override void StartCommandExecution()
    {
        if(Command.isRecording)
            Command.SaveRecord();
        OneSceneManager.Instance.ShowGameOver();
        IDHolder.ClearIDHoldersList();
        Command.isGameOver=true;
        Command.CommandQueue.Clear();
    }
}
