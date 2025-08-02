using System.Collections;
using System.Collections.Generic;

public class UpdateLeaderBoardCommand : Command {

    public List<CardDbf> m_allLead;
    public List<int> m_hp;
    public CardDbf m_nxt;

    public UpdateLeaderBoardCommand(List<CardDbf> allLead, List<int> hp,CardDbf nxt)
    {
        this.m_allLead=allLead;
        this.m_hp=hp;
        this.m_nxt=nxt;
        Response.ServerSend("UpdateLeaderBoard");
    }

    public override void StartCommandExecution()
    {
        Command.CommandExecutionComplete();
        OneSceneManager.Instance.UpdateLeaderBoard(this.m_allLead,this.m_hp,this.m_nxt);

    }
}
