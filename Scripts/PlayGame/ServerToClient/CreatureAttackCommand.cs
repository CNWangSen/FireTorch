using UnityEngine;
using System.Collections;

public class CreatureAttackCommand : Command 
{
    public int m_sourceID;
    public int m_targetID;
    public int m_conformed;


    public CreatureAttackCommand(int sourceID, int targetID, int conformed)
    {
        this.m_sourceID = sourceID;
        this.m_targetID = targetID;
        this.m_conformed = conformed;
        Response.ServerSend("Attack");
    }

    public override void StartCommandExecution()
    {
        VfxBase.CreateAttackFx(this.m_sourceID,this.m_targetID,this.m_conformed);
    }
}
