public class FakeDragCommand : Command
{
    public int m_playerID;
    public int m_sourceID;
    public int m_targetID;
    public bool m_isAI;

    public FakeDragCommand(int playerID, int sourceID,int targetID=-1,bool isAI=true)
    {
        this.m_playerID = playerID;
        this.m_sourceID = sourceID;
        this.m_targetID = targetID;
        this.m_isAI = isAI;
        Response.ServerSend("FakeDrag");
    }

    public override void StartCommandExecution()
    {
        bool Rend=false;
        if(Command.isReplaying)
        {
            Rend=true;
        }
        else
        {
            if(this.m_isAI)
            {
                Rend=true;
                
            }
            else{
                Rend=false;
            }
        }
    
        if(Rend)
        {
            OneSceneManager.Instance.StageDictByPlayerId[this.m_playerID].FakeDrag(this.m_sourceID,this.m_targetID);
        }
        else
        {
            Command.CommandExecutionComplete();
        }
    }
}