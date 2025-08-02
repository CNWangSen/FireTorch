using UnityEngine;
using System.Collections;
using System;

public class ShowMessageCommand : Command {

    public string m_message;
    public float m_duration;

    public ShowMessageCommand(string message, float duration)
    {
        this.m_message = message;
        this.m_duration = duration;
        Response.ServerSend("ShowMessage");
    }

    public override void StartCommandExecution()
    {
        if(OneSceneManager.Instance.TurnHinterText!=null)
        {
            OneSceneManager.Instance.TurnHinterText.text="回合结束";//
        }
        MessageManager.Instance.ShowMessage(this.m_message, this.m_duration);
    }
}
