using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MessageManager : MonoBehaviour 
{
    public Text MessageText;
    public GameObject MessagePanel;
    public GameObject RecuritPanel;
    public GameObject CombatPanel;

    public static MessageManager Instance;

    void Awake()
    {
        Instance = this;
        MessagePanel.SetActive(false);
    }

    public void ShowMessage(string Message, float Duration)
    {
        StartCoroutine(ShowMessageCoroutine(Message, Duration));
    }

    IEnumerator ShowMessageCoroutine(string Message, float Duration)
    {
        MessageText.enabled=true;
        MessageText.text = Message;
        switch(Message)
        {
            case("招揽随从"):
            RecuritPanel.SetActive(true);
            break;
            case("开始战斗"):
            CombatPanel.SetActive(true);
            break;
            default:
            MessagePanel.SetActive(true);
            break;
        }
        
            
        

        yield return new WaitForSeconds(Duration);

        MessagePanel.SetActive(false);
        RecuritPanel.SetActive(false);
        CombatPanel.SetActive(false);
        MessageText.enabled=false;
        Command.CommandExecutionComplete();
        
    }

    void Update()
    {
        
    }
}
