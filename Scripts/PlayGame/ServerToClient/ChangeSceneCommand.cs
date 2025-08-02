using UnityEngine;

public class ChangeSceneCommand : Command
{
    public string SceneName;

    public ChangeSceneCommand(string sceneName)
    {
        this.SceneName = sceneName;
        Response.ServerSend("ChangeScene");
    }

    public override void StartCommandExecution()
    {
        Command.CommandExecutionComplete();
        UnityEngine.SceneManagement.SceneManager.LoadScene(this.SceneName);
    }
}

public class QuitGameCommand : Command
{
    public QuitGameCommand()
    {
        Response.ServerSend("QuitGame");
    }

    public override void StartCommandExecution()
    {
        Command.CommandExecutionComplete();
        UnityEngine.Application.Quit();
    }
}