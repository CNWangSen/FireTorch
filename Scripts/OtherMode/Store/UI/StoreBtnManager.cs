using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using TMPro;

public class StoreBtnManager : MonoBehaviour
{
    public TextMeshProUGUI GoldText;
    public TextMeshProUGUI PackText;
    public void StoreToMenu()
    {
        UserDbf.SaveLoggedUserDbfToDisk();
        if(OneSceneManager.Instance.IsMyScene)
        {
            SceneManager.LoadScene("MainMenuMy");   
        }
        else{
            SceneManager.LoadScene("MainMenuHS");   
        }
    }

    public void Update()
    {
        if(GoldText!=null)
        {
            GoldText.text = "x"+UserDbf.LoggedUser.Gold.ToString();
        }
        if(PackText!=null)
        {
            PackText.text = "x"+UserDbf.LoggedUser.PackNums[0].ToString();
        }
    }

    public void BuyPack()
    {
        if(UserDbf.LoggedUser.Gold>100)
        {
            UserDbf.LoggedUser.Gold-=100;
            UserDbf.LoggedUser.PackNums[0]+=1;
        }
    }
}

