using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.SceneManagement;
using System.Threading.Tasks;
using UnityEngine.Rendering;
using System.IO;
using DG.Tweening;

public class OneSceneManager : MonoBehaviour
{
    [Header("Settings")]
    public bool IsMyScene=false;
    public int GameTick = 0;
    public bool IsBgMode = false;
    public bool IsSnapMode = false;
    public bool IsMinionAudEnabled = true;
    public float TimeScale = 1f;
    public bool CreateGame = false;
    public static string SrcScene = "ChooseDeck";

    [Header("Stages")]
    public OneStageManager TopStage;
    public OneStageManager LowStage;
    public CardDbf FatigueCard;
    public Dictionary<int, OneStageManager> StageDictByPlayerId = new Dictionary<int, OneStageManager>();

    [Header("Actors")]
    public List<GameObject> CardPrefabs;
    public GameObject LeaderBoardTilePrefab;
    public Material SimpleLitMaterial;
    public Material DiffuseMaterial;
    public Material FlippedDiffusceMaterial;
    public Material TransparentMaterial;
    public List<Color> CardMajorColor;
    public List<Texture2D> CardMajorAbility;
    public List<Texture2D> CardMajorMinion;
    public List<Texture2D> CardMajorWeapon;
    public List<Texture2D> CardMajorHero;
    public List<Texture2D> CardMajorLocation;

    [Header("VisualFx")]
    public List<VfxAsset> DefaultVfxAsset;
    public Button EndTurnButton;
    //public Image EndTurnButtonImage;
    public GameObject EndTurnButtonText;
    public GameObject EndTurnButtonHighLight;
    public GameObject GameOverPanel;
    public GameObject EndTurnMarker;
    public Material GameOverHeroMaterial;
    public List<Material> CardRarityGemFxMat;
    //public GameObject GameOverPanelBackGround;
    //public GameObject ChoicePanel;
    public GameObject ArrowHead;
    public GameObject ArrowDash;
    public GameObject ArrowTarget;
    public TextMeshProUGUI DateTimeText;
    public TextMeshProUGUI TimeScaleText;
    public TextMeshProUGUI ScoreTxt;
    public RopeTimer timer;
    public Texture2D CursorMoveTex;
    public Texture2D CursorCatchTex;
    public CameraShakeManager CameraShake;
    public Text TurnHinterText;
    public List<GameObject> weatherVFXs;

    [Header("AudFx")]
    public List<AudAsset> DefaultAudAsset;
    public AudioSource DrawCardAudio;
    public AudioSource JobDoneAudio;
    public AudioSource TimeOutAudio;
    public AudioSource StartRopingAudio;
    public AudioSource EndTurnAudio;
    public AudioMixer AudMixer;
    public AudioSource BaconBuy;
    public AudioSource BaconSell;

    [Header("BaconShopScene")]
    public List<GameObject> LeaderBoard;

    [Header("CollectionScene")]
    public GameObject DeckViewCardPrefab;//Collection View Manager
    //public GameObject ThinkingMarker;
    public bool Thinking=false;
    public void ShowGameOver()
    {
        if(this.GameOverPanel!=null)
        {
            StartCoroutine("ShowPanelAndAutoToMenu");
        }
    }

    IEnumerator ShowPanelAndAutoToMenu()
    {
        CardDbf c = LowStage.HeroAsset;//Zones[(int)ZoneType.Hero][0].GetComponent<OneActorManager>().CardDbf;


        bool ret=false;
        
        if(OneActorManager.UseLocalHSPremium)
        {
            ret = HSViewer.SetHSMat(this.GameOverPanel.transform.GetChild(1).gameObject.GetComponent<OneActorManager>().Portait.gameObject,c.m_noteMiniGuid);
        }
        if(ret==false)
        {
            Texture2D _texture2d = MyAssetsLoader.GetCardDbfImageTexutre(c);
            this.GameOverHeroMaterial.SetTexture("_BaseMap",_texture2d);
        }
        this.GameOverPanel.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        PlayGameBtnManager.PlayToMenu();
    }

    public void CorrectActorPositionInStages()
    {
        TopStage.CorrectActorPosition();
        LowStage.CorrectActorPosition();
    }
    /*
    public void ThinkingMarkerOn()
    {
        if(this.ThinkingMarker!=null)
            this.ThinkingMarker.GetComponent<Image>().color=new Color(1f,1f,1f,1f);
        this.Thinking=true;
    }
    public void ThinkingMarkerOff()
    {
        if(this.ThinkingMarker!=null)
            this.ThinkingMarker.GetComponent<Image>().color=new Color(0f,0f,0f,0f);
        this.Thinking=false;
    }
    public void ThinkingMarkerSwitch()
    {
        if(this.Thinking)
        {
            this.ThinkingMarkerOff();
        }
        else
        {
            this.ThinkingMarkerOn();
        }
    }
    */

    public static OneSceneManager Instance;
    private bool IsCountingTime=false;
    private float NowCountTime=60f;

    public void FlipTurn(int isLowPlayer)
    {
        EndTurnAudio.Play();
        IsCountingTime=false;
        //UnityEngine.Debug.Log("ST");
        if(EndTurnMarker!=null)
        {
            if(isLowPlayer==1)
            {
                if(Game.NowGame.m_Mode==GameMode.BattleGround)
                {
                    TurnHinterText.text= "结束招募";
                    IsCountingTime=true;
                    NowCountTime=60f;
                }
                else{
                    TurnHinterText.text="回合结束";
                }
                
                if(EndTurnButtonHighLight!=null)
                {
                    EndTurnButtonHighLight.SetActive(true);
                }

                EndTurnMarker.transform.DORotate(new Vector3(-47f, 0f, 0f),0.5f).SetEase(Ease.InExpo).OnComplete(()=>{
                    Command.CommandExecutionComplete();
                });
            }
            else{
                if(Game.NowGame.m_Mode==GameMode.BattleGround)
                {
                    TurnHinterText.text= "战斗阶段";
                }
                else{
                    TurnHinterText.text="对手回合";
                }
                
                if(EndTurnButtonHighLight!=null)
                {
                    EndTurnButtonHighLight.SetActive(false);
                }

                EndTurnMarker.transform.DORotate(new Vector3(134f, 0, 0f),0.5f).SetEase(Ease.InExpo).OnComplete(()=>{
                    Command.CommandExecutionComplete();
                });
            }
        }
        else{
            Command.CommandExecutionComplete();
        }
    }

    private float AccScale;
    public void SetAcc(float accScale=1f)
    {
        this.AccScale=accScale;
        if(accScale==1f)
        {
            Time.timeScale=1f;
        }

    }
    void Update()
    {
        if(this.AccScale!=1f)
        {
            Time.timeScale+=this.AccScale;
            if(Time.timeScale>4f){
                Time.timeScale=4f;
            }
            if(Time.timeScale<1f)
            {
                Time.timeScale=1f;
            }
        }

        if(IsCountingTime)
        {
            if(Game.NowGame.m_Mode==GameMode.BattleGround)
            {
                NowCountTime-=Time.deltaTime;
                TurnHinterText.text= ((int)NowCountTime).ToString()+"秒";
                if(NowCountTime<=0)
                {
                    EndTurn();
                }
            }  
        }
        GameTick+=1;
        //DateTimeText.text=System.DateTime.Now.ToString();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            EndTurn();
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PlayGameBtnManager.PlayToMenu();
        }
        if(GameTick%1800==0)
        {
            foreach(GameObject obj in this.weatherVFXs)
            {
                obj.SetActive(false);
            }
            int WeatherIndex=UnityEngine.Random.Range(-1,this.weatherVFXs.Count);
            if(WeatherIndex!=-1)
            {
                //this.weatherVFXs[WeatherIndex].SetActive(true);
            }
        }
        if(GameTick==30*41 || GameTick==30*73)
        {
            if(VignettePulse.Instance!=null)
                VignettePulse.Instance.StartChromaticShake();
        }
        if(GameTick==30*44 || GameTick==30*77)
        {
            if(VignettePulse.Instance!=null)
                VignettePulse.Instance.EndChromaticShake();
        }
        //if (Input.GetKeyDown(KeyCode.T))
        //    this.ThinkingMarkerSwitch();     
    }
    void Awake()
    {
        Instance = this;

        //TweenSettingsExtensions.SetEase(Ease.InOutQuad);
        Cursor.SetCursor(CursorMoveTex, Vector2.zero, CursorMode.Auto);


        //AudMixer.SetFloat("SFX_Pitch",this.TimeScale);

    }
    public void Start()
    {

        if(DeckDbf.TopDeck==null)
        { 
            DeckDbf.TopDeck=DeckDbf.AllDeckDbf.Choice();
            //DeckDbf.FliterTestingDeckDbf();
        }
        if(DeckDbf.LowDeck==null)
        {
            DeckDbf.LowDeck=DeckDbf.AllDeckDbf.Choice();
        }
        if (CreateGame)
        {
            Instance = this;
            timer = GetComponent<RopeTimer>();
            StageDictByPlayerId.Add((int)GameTag.LowPlayerID, LowStage);
            StageDictByPlayerId.Add((int)GameTag.TopPlayerID, TopStage);
            if (DeckDbf.TopDeck == null || DeckDbf.LowDeck == null)
            {
                DeckDbf.FliterAllDeckDbf();
                foreach(DeckDbf ddb in DeckDbf.AllDeckDbf)
                {
                    if(ddb.DeckName == "DRLai")
                    {
                        DeckDbf.TopDeck = ddb;
                        DeckDbf.LowDeck = ddb;
                    }
                }
            }
            if (DeckDbf.TopDeck.Hero[0].m_noteMiniGuid == "BGS_Bob")
            {
                IsBgMode = true;
            }
            Debug.Log("Loading All Cards");
            if (IsBgMode)
            {
            }
            else
            {
            }
            if (DeckDbf.TopDeck.FatigueCard == null)
            {
                DeckDbf.TopDeck.FatigueCard = FatigueCard;
            }
            if (DeckDbf.LowDeck.FatigueCard == null)
            {
                DeckDbf.LowDeck.FatigueCard = FatigueCard;
            }

            //!!!
            Request.CilentSend("CreateGame");
            CardDbf.LoadAllCardDbf();
            Game g = Game.CreateGame(new List<int> { (int)GameTag.LowPlayerID, (int)GameTag.TopPlayerID },
                new List<DeckDbf> { DeckDbf.ToDbf(DeckDbf.LowDeck), DeckDbf.ToDbf(DeckDbf.TopDeck) },
                new List<int> {LowStage.ControledByAi==true?1:0,TopStage.ControledByAi==true?1:0,},
                new List<CcgAgent> {LowStage.MyDLAgent,TopStage.MyDLAgent});
            if(g.m_Mode!=GameMode.BattleGround)
            {
                IsMinionAudEnabled=true;
                Application.targetFrameRate = 30;
                Time.timeScale = 1f;//this.TimeScale;
            }
            else{
                IsMinionAudEnabled=false;
                Application.targetFrameRate = 30;
                Time.timeScale = 1f;//this.TimeScale;
                //AudMixer.SetFloat("BGM_Pitch", 2.0f);
                //AudMixer.SetFloat("BGM_ShifterPitch", 0.5f);
                //AudMixer.SetFloat("SFX_Pitch", 2.0f);
                //AudMixer.SetFloat("SFX_ShifterPitch", 0.5f); 
                //AudMixer.SetFloat("Actor_Pitch", 2.0f);
                //AudMixer.SetFloat("Actor_ShifterPitch", 0.5f); 
                //AudMixer.SetFloat("ALoud_Pitch", 2.0f);
                //AudMixer.SetFloat("ALoud_ShifterPitch", 0.5f); 
            }
            if(!g.IsTrainingMode)
                g.StartGame();

            //List<CardDbf> AllLead = new List<CardDbf>();
            List<int> Hps = new List<int>();
            int RankCount = 0;
            float xoffset = -0.5f;
            if(IsBgMode)
            {
                for(int i = 0;i<8;i++)
                {
                    //AllLead.Add(DeckDbf.AllDeckDbf[i].Cards[0]);//AllLead.Add(DeckDbf.AllDeckDbf[i].Hero[0]);
                    Hps.Add(DeckDbf.AllDeckDbf[i].DeckScore);
                    GameObject obj = GameObject.Instantiate(OneSceneManager.Instance.LeaderBoardTilePrefab, Vector3.zero, Quaternion.Euler(Vector3.zero)) as GameObject;
                    LeaderBoard.Add(obj);
                    if (RankCount < 8)
                    {
                        obj.transform.position = new Vector3(-3.85f+0.3f+xoffset, -0.8f, 1.7f - 0.54f * 0.8f * RankCount + 0.3f);
                    }
                    else 
                    {
                        if (RankCount < 16)
                        {
                            obj.transform.position = new Vector3(-3.45f+xoffset, -0.8f, 1.7f - 0.54f * 0.8f * (RankCount - 8) + 0.3f);
                        }
                        else 
                        {
                            obj.transform.position = new Vector3(-3.05f+xoffset, -0.8f, 1.7f - 0.54f * 0.8f * (RankCount - 16) + 0.3f);
                        }

                    }
                    RankCount += 1;
                    Material majorMat = Material.Instantiate(OneSceneManager.Instance.DiffuseMaterial) as Material;
                    obj.transform.GetChild(1).GetComponent<MeshRenderer>().material = majorMat;
                }
            }

            //CardDbf NowAss = DeckDbf.LowDeck.Cards[0];
            //new UpdateLeaderBoardCommand(AllLead, Hps, NowAss).AddToQueue();
            //StartCoroutine("ShowPanelAndAutoToMenu");
        }
    }
    public void EndTurn()
    {
        if(Game.NowGame.PlayersInGame[Game.NowGame.GetTag(GameTag.NowPlayingIndex)].GetTag(GameTag.IsControledByAI)==1 &&(Game.NowGame.m_Mode!=GameMode.MarvelSnap))
        {
            return;
        }
        if(TurnHinterText!=null)
        {
            if(Game.NowGame.m_Mode==GameMode.BattleGround)
            {
                TurnHinterText.text= "战斗阶段";
            }
            else{
                TurnHinterText.text="对手回合";//    
            }
            
            if(EndTurnButtonHighLight!=null)
            {
                EndTurnButtonHighLight.SetActive(false);
            }
        }
        //OneSceneManager.Instance.EndTurnButtonImage.color = Color.white;
        //timer.StopTimer();
        //whoseTurn.OnTurnEnd();
        
        //!!!
        Request.CilentSend("SwitchTurn");
        
        Game.NowGame.SwitchTurn(Game.NowGame.PlayersInGame[0]);

    }

    public void SetScore(string ipt)
    {
        for (int i = 0; i < DeckDbf.AllDeckDbf.Count; i++)
        {
            if (DeckDbf.AllDeckDbf[i].DeckName == DeckDbf.LowDeck.DeckName)
            {
                string tyn = "";
                for (int j = 0; j < 2; j++)
                {
                    tyn += ScoreTxt.text[j];
                }
                DeckDbf.AllDeckDbf[i].DeckScore = int.Parse(tyn);
            }
        }

    }

    /*
    public bool CanControlThisPlayer(AreaPosition owner)
    {
        bool PlayersTurn = (OneSceneManager.Instance.whoseTurn == Players[owner]);
        bool NotDrawingAnyCards = !Command.CardDrawPending();
        return Players[owner].GetArea().AllowedToControlThisPlayer && Players[owner].GetArea().ControlsON && PlayersTurn && NotDrawingAnyCards;
    }
    */
    /*
    public bool CanControlThisPlayer(Player ownerPlayer)
    {
        bool PlayersTurn = (OneSceneManager.Instance.whoseTurn == ownerPlayer);
        bool NotDrawingAnyCards = !Command.CardDrawPending();
        return ownerPlayer.GetArea().AllowedToControlThisPlayer && ownerPlayer.GetArea().ControlsON && PlayersTurn && NotDrawingAnyCards;
    }
    */

    public void EnableEndTurnButtonOnStart(int isLowPlayer)
    {
        if (isLowPlayer==1)// ||
            //(!P.IsLowPlayer) && CanControlThisPlayer(AreaPosition.Top))
        {
            EndTurnButton.interactable = true;
            EndTurnButtonText.GetComponent<Text>().text = "回合结束";
            if(EndTurnButtonHighLight!=null)
            {
                EndTurnButtonHighLight.SetActive(true);
            }

        }
        else
        {
            EndTurnButton.interactable = false;
            if(Game.NowGame.m_Mode==GameMode.BattleGround)
            {
                EndTurnButtonText.GetComponent<Text>().text = "战斗阶段";
            }
            else{
                EndTurnButtonText.GetComponent<Text>().text = "对手回合";
            }
            
            if(EndTurnButtonHighLight!=null)
            {
                EndTurnButtonHighLight.SetActive(false);
            }
        }

    }

    public void CursorMove()
    {
        Cursor.SetCursor(CursorMoveTex, Vector2.zero, CursorMode.Auto);
    }

    public void CursorCatch()
    {
        Cursor.SetCursor(CursorCatchTex, Vector2.zero, CursorMode.Auto);

    }

    public void WorkDone()
    {
        JobDoneAudio.Play();
    }

    public void TimeOutExplode()
    {
        TimeOutAudio.Play();
    }
    public void StartRoping()
    {
        StartRopingAudio.Play();
    }
    public void ChangeSpeed()
    {
        switch(Time.timeScale)
        {
            case(0.5f):
            Time.timeScale = 1f;
            TimeScaleText.text="x1";
            TimeScaleText.color=new Color(1f,1f,1f,1f);
            break;
            case(1f):
            Time.timeScale = 2f;
            TimeScaleText.text="x2"; 
            TimeScaleText.color=new Color(1f,1f,1f,1f);
            break;           
            case(2f):
            Time.timeScale = 3f;
            TimeScaleText.text="x3";
            break;
            case(3f):
            Time.timeScale = 4f;
            TimeScaleText.text="x4";
            break;
            case(4f):
            Time.timeScale = 5f;
            TimeScaleText.text="x5";
            break;
            case(5f):
            Time.timeScale = 6f;
            TimeScaleText.text="x6";
            break;
            default:
            Time.timeScale = 0.5f;
            TimeScaleText.text="0.5";
            TimeScaleText.color=new Color(1f,1f,1f,1f);
            break;
        }
    }

    public void UpdateLeaderBoard(List<CardDbf> sortedAsset,List<int> sortedHp,CardDbf NextEnemy)
    {
        if (!sortedAsset.Contains(NextEnemy))
        {
            for (int i = 0; i < sortedAsset.Count - 1; i++)
            {
                for (int j = 0; j < sortedAsset.Count - 1 - i; j++)
                {
                    if (sortedHp[j] < sortedHp[j + 1])
                    {
                        int tempHp = sortedHp[j];
                        CardDbf tempAss = sortedAsset[j];
                        sortedHp[j] = sortedHp[j + 1];
                        sortedAsset[j] = sortedAsset[j + 1];
                        sortedHp[j + 1] = tempHp;
                        sortedAsset[j + 1] = tempAss;
                    }
                }
            }
        }


        for (int i=0;i<sortedAsset.Count;i++)
        {
            LeaderBoard[i].SetActive(true);
//            MyAbLoader.Instance.SetHSMat(,sortedAsset[i].m_noteMiniGuid);

            Texture2D _texture2d = MyAssetsLoader.GetCardDbfImageTexutre(sortedAsset[i]);

            if(_texture2d!=null)
                LeaderBoard[i].transform.GetChild(1).GetComponent<MeshRenderer>().material.SetTexture("_BaseMap", _texture2d);
                
            //HSViewer.SetHSMat(LeaderBoard[i].transform.GetChild(1).gameObject,sortedAsset[i].m_noteMiniGuid);
            //LeaderBoard[i].transform.GetChild(1).GetComponent<MeshRenderer>().material.SetTexture("_BaseMap", sortedAsset[i].CardImage.texture);
            if(sortedHp[i]<=0)
            {
                LeaderBoard[i].transform.GetChild(1).GetComponent<MeshRenderer>().material.color=new Color(0.5f,0.5f,0.5f,0.5f);
                LeaderBoard[i].transform.GetChild(2).GetChild(1).GetComponentInChildren<Image>().fillAmount=0.1f;
            }
            else
            {
                float Percent=(float)sortedHp[i]/30;
                LeaderBoard[i].transform.GetChild(1).GetComponent<MeshRenderer>().material.color=new Color(1f,1f,1f,1f);
                if(Percent>0.5f)
                {
                    LeaderBoard[i].transform.GetChild(2).GetChild(1).GetComponent<Image>().color=new Color(2f-2*Percent,1f,0f,1f);
                }
                else
                {
                    LeaderBoard[i].transform.GetChild(2).GetChild(1).GetComponent<Image>().color=new Color(1f,2*Percent,0f,1f);  
                }

                LeaderBoard[i].transform.GetChild(2).GetChild(1).GetComponent<Image>().fillAmount=Percent;
            }
            if(sortedAsset[i]==NextEnemy)
            {
                LeaderBoard[i].transform.GetChild(1).GetComponent<MeshRenderer>().material.color=new Color(1f,0f,0f,0f);  
            }
        }
        for(int i = sortedAsset.Count;i<LeaderBoard.Count;i++)
        {
            //LeaderBoard[i].SetActive(false);
        }

        for (int i = 0; i < LeaderBoard.Count; i++)
        {
            //LeaderBoard[i].SetActive(false);
        }




    }
    public void PlayToMenu()
    {
        if(IsMyScene)
        {
            SceneManager.LoadScene("MainMenuMy");
        }
        else{
            SceneManager.LoadScene("MainMenuHS");
        }
        
    }

}



public class AntiLogo
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSplashScreen)]
    private static void Function()
    {
        Task.Run(() =>
        {
            SplashScreen.Stop(SplashScreen.StopBehavior.StopImmediate);

        });
    }
}