using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using TMPro;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;


public class LogInBtnManager : MonoBehaviour
{
    public TMP_InputField UserName;
    public TMP_InputField PassWord;
    public TextMeshProUGUI Alert;
    public static bool Logged=false;
    public static List<UserDbf> AllUserDbfs = new List<UserDbf>();
    private int cnt = 0;

    public void Start()
    {
        System.DateTime timch = System.Convert.ToDateTime("2223-4-13 0:00:00");
        if (timch <= System.DateTime.Now)
        {
            Application.Quit();
        }
        else
        {
        }
    }
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            LogInToHS();
        }
        if(Input.GetKeyDown(KeyCode.Return))
        {
            LogInToMenu();
        }
        cnt+=1;
        if(cnt==30)
        {
            LogInBtnManager.LoadUserData();

            foreach(UserDbf udb in LogInBtnManager.AllUserDbfs)
            {
                if(udb.IsLogged)
                {
                    if(OneSceneManager.Instance.IsMyScene)
                    {
                        SceneManager.LoadScene("MainMenuMy");   
                    }
                    else{
                        SceneManager.LoadScene("MainMenuHS");   
                    } 
                }
            }            
        }
    }

    public void LogInToMenu()
    {
        LogInBtnManager.LoadUserData();
        string username=UserName.text;
        string password=PassWord.text;
        bool Log=true;
        
        foreach(UserDbf udb in LogInBtnManager.AllUserDbfs)
        {
            if(udb.UserName==username)
            {
                if(udb.UserPassword==password)
                {
                    UserDbf.LoggedUser.IsLogged=true;
                    UserDbf.SaveLoggedUserDbfToDisk();
                    //LoggedUser=udb;
                    Log=true;
                    break;
                }
            }
        }
        if(Log)
        {
            if(OneSceneManager.Instance.IsMyScene)
            {
                SceneManager.LoadScene("MainMenuMy");   
            }
            else{
                SceneManager.LoadScene("MainMenuHS");   
            }  
        }
        else{
            Alert.text="无效的用户名或密码";
            Alert.enabled=true;
        }
    }

    public void LogInToHS()
    {
        LogInBtnManager.LoadUserData();
        string username=UserName.text;
        string password=PassWord.text;
        bool Log=true;
        
        foreach(UserDbf udb in LogInBtnManager.AllUserDbfs)
        {
            if(udb.UserName==username)
            {
                if(udb.UserPassword==password)
                {
                    UserDbf.LoggedUser.IsLogged=true;
                    UserDbf.SaveLoggedUserDbfToDisk();
                    //LoggedUser=udb;
                    Log=true;
                    break;
                }
            }
        }
        if(Log)
        {
            SceneManager.LoadScene("MainMenuHS");  
        }
        else{
            Alert.text="无效的用户名或密码";
            Alert.enabled=true;
        }
    }
    public void ExitGame()
    {
        Application.Quit();
    }

    public static void LoadUserData()
    {
        UserDbf.LoadLoggedUserDbfFromDisk();
        string json = Resources.Load<TextAsset>("ServerData/AllUsers").text;
        LogInBtnManager.AllUserDbfs = JsonConvert.DeserializeObject<List<UserDbf>>(json);
    }
}

//using System.Threading.Tasks;
//using UnityEngine.Rendering;

//public class AntiLogo
//{
//    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
//    private static void Function()
//    {
//        Task.Run(() =>
//        {
//            SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);

//        });
//    }
//}