using UnityEngine;
using System.Collections;

public class StartATurnCommand : Command {

    public int m_isLowPlayer;

    public StartATurnCommand(int isLowPlayer)
    {
        this.m_isLowPlayer = isLowPlayer;
        Response.ServerSend("StartTurn");
    }

    public override void StartCommandExecution()
    {
        OneSceneManager.Instance.FlipTurn(this.m_isLowPlayer);
        
        //OneSceneManager.Instance.EndTurnButtonObject.Flip();
        
        //OneSceneManager.Instance.timer.StartTimer();
        //OneSceneManager.Instance.EnableEndTurnButtonOnStart(this.m_isLowPlayer);
    }
}
public class RestoreHeroButtonCommand : Command {
    
    public int playerID;
    public RestoreHeroButtonCommand(int playerID)
    {
        this.playerID = playerID;
        //Response.ServerSend("StartTurn");
    }

    public override void StartCommandExecution()
    {
        //OneSceneManager.Instance.FlipTurn(this.m_isLowPlayer);
        OneSceneManager.Instance.StageDictByPlayerId[this.playerID].RestoreHeroBtn();
        //OneSceneManager.Instance.EndTurnButtonObject.Flip();
        
        //OneSceneManager.Instance.timer.StartTimer();
        //OneSceneManager.Instance.EnableEndTurnButtonOnStart(this.m_isLowPlayer);
    }
}

public class CloseWeaponCommand : Command {
    
    public int playerID;
    public CloseWeaponCommand(int playerID)
    {
        this.playerID = playerID;
        //Response.ServerSend("StartTurn");
    }

    public override void StartCommandExecution()
    {
        //OneSceneManager.Instance.FlipTurn(this.m_isLowPlayer);
        OneSceneManager.Instance.StageDictByPlayerId[this.playerID].CloseWeapon();
        //OneSceneManager.Instance.EndTurnButtonObject.Flip();
        
        //OneSceneManager.Instance.timer.StartTimer();
        //OneSceneManager.Instance.EnableEndTurnButtonOnStart(this.m_isLowPlayer);
    }
}
/*
public class ThinkingMarkerOnCommand:Command
{
    public ThinkingMarkerOnCommand()
    {

    }
    public override void StartCommandExecution()
    {
        //OneSceneManager.Instance.ThinkingMarkerOn();
        Command.CommandExecutionComplete();
    }
}

public class ThinkingMarkerOffCommand:Command
{
    public ThinkingMarkerOffCommand()
    {

    }
    public override void StartCommandExecution()
    {
        //OneSceneManager.Instance.ThinkingMarkerOff();
        Command.CommandExecutionComplete();
    }
}
*/
/*
public class CreateAiThinkingCommand : Command
{
    public CreateAiThinkingCommand()
    {
        Response.ServerSend("CreateVfx");
    }

    public override void StartCommandExecution()
    {
    }
}
*/