using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using DG.Tweening;
using System.Collections.Generic;
using TMPro;
using System.IO;
using UnityEngine.SceneManagement;
using Blizzard.T5.AssetManager;


public class OneActorManager : MonoBehaviour
{
    public static bool UseLocalHSPremium = true;
    public static bool UseLocalHSCardAud = true;
    public CardDbf CardDbf;
    public TargetingOptions m_ActorTargetOpts = TargetingOptions.NoTarget;

    [Header("Board Part")]
    public GameObject Actor;
    public GameObject DragNoTarget;
    public GameObject DragOnTarget;
    public TextMeshProUGUI AttackText;
    public TextMeshProUGUI HealthText;
    public TextMeshProUGUI ArmorText;
    public TextMeshProUGUI EnergyText;
    public TextMeshProUGUI CostText;
    public MeshRenderer Portait;
    public GameObject LegendaryFx;
    public GameObject GoldenLegendaryFx;
    public GameObject AttackGem;
    public GameObject HealthGem;
    public GameObject CostGem;
    public GameObject ArmorGem;
    public GameObject EnergyGem;
    public GameObject PortaitDoorUp;
    public GameObject PortaitDoorDown;

    public List<GameObject> NormalFrame;
    public List<GameObject> GoldenFrame;
    public List<GameObject> MythicFrame;
    public List<GameObject> Fx;
    public GameObject DamageFx;
    public GameObject HighLightQuad;

    public GameObject MythicOffScreenPrefab;
    public GameObject MythicOffScreenInstance;
    public GameObject MythicPortraitMesh;
    public AudioSource MythicEmoteAudSource;
    public List<AudioClip> MythicEmoteAudClips = new List<AudioClip>();
    public List<string> MythicEmoteTexts = new List<string>();
    //public List<GameObject> BaconStars;
    //private bool isInjured = false;

    [Header("Card Part")]
    public GameObject CardActor;
    public GameObject CardBack;
    public GameObject CardDragNoTarget;
    public GameObject CardDragOnTarget;
    public TextMeshProUGUI CardAttackText;
    public TextMeshProUGUI CardHealthText;
    public TextMeshProUGUI CardArmorText;
    public TextMeshProUGUI CardEnergyText;
    public TextMeshProUGUI CardCostText;
    public MeshRenderer CardPortait;
    public MeshRenderer CardMajorIndicator;
    public List<MeshRenderer> CardMajor;

    public GameObject CardLegendaryFx;
    public GameObject GoldenCardLegendaryFx;
    public MeshRenderer CardRarityGemFx;

    public List<GameObject> CardNormalFrame;
    public List<GameObject> CardGoldenFrame;

    public GameObject CardHighLightQuad;

    public Text CardNameText;
    public Text CardDescriptionText;
    public Text CardTypeText;

    public AudioSource CustomSummonAudioSource;
    public AudioSource CustomAttackAudioSource;
    public AudioSource CustomDeathAudioSource;
    public AudioSource CustomTriggerAudioSource;
    public AudioSource CustomStingerAudioSource;
    public GameObject CustomSummonVFXObject;
    public GameObject CustomSpawnVFXObject;
    public GameObject CustomDeathVFXObject;
    public GameObject CustomDiscardVFXObject;

    public GameObject CustomInvokeVfxObject;
    public GameObject CustomLaunchVfxObject;
    public GameObject CustomLaunchReverseVfxObject;
    public GameObject CustomImpactVfxObject;
    public GameObject CustomFriendlyAEVfxObject;
    public GameObject CustomOpposingAEVfxObject;
    public GameObject CustomChainVfxObject;
    
    public SpellStartInfo CustomInvokeVfxInfo;
    public SpellMissileInfo CustomLaunchVfxInfo;
    public SpellImpactInfo CustomImpactVfxInfo;
    public SpellAreaEffectInfo CustomFriendlyAEVfxInfo;
    public SpellAreaEffectInfo CustomOpposingAEVfxInfo;
    public SpellChainInfo CustomChainVfxInfo;
    public SpellTargetInfo CustomVfxTargetInfo;

    public Animation DefaultAttackAnimation;

    public static AnimationClip DefaultAttackReadyClip;
    public static AnimationClip DefaultAttackFinishClip;

    public GameObject AuraVfxObject=null;
    public GameObject TriggerVfxObject=null;
    public GameObject FrozenVfxObject=null;
    public GameObject ImmueVfxObject=null;
    public GameObject StealthVfxObject=null;
    public GameObject WindFuryVfxObject=null;

    public bool IsActing = false;
    public Vector3 ActingTargetPosition;
    public Vector3 ActingTargetRotation;
    public bool IsHighLighting = true;
    public bool InstancedHighLight = false;
    public bool CardGlowEnabled = false;
    public AreaPosition ControlBy= AreaPosition.Low;

    private int mana;
    private int atk;
    private int hp;
    private int arm;
    private int eng;
    private int manaDef;
    private int atkDef;
    private int hpDef;
    private int armDef = 0;
    private CardType cardType;
    public ZoneType zoneType;
    private PremiumType premiumType = PremiumType.Normal;
    private TargetingOptions targets;
    private bool Injured = false;
    private bool IsPortaitOpen = true;

    

    public void SetDesc(string newDesc)
    {
        this.CardDescriptionText.text=newDesc;
    }
    public void UpdateAssetForZone(ZoneType TargetZone,PremiumType ActorPremium=PremiumType.Normal)
    {
        //this.DeActiveAuraVfx();
        if(ActorPremium==PremiumType.Normal)
        {
            ActorPremium=this.premiumType;
        }
        else{
            this.premiumType=ActorPremium;
        }
        zoneType = TargetZone;
        CardActor.SetActive(ControlBy==AreaPosition.Low);
        if(ActorPremium==PremiumType.Golden)
        {
            if(Actor!=null)
            {
                foreach(GameObject gd in GoldenFrame)
                {
                    gd.SetActive(true);
                }
                foreach(GameObject gd in NormalFrame)
                {
                    gd.SetActive(false);
                }
            }
            foreach(GameObject gd in CardGoldenFrame)
            {
                gd.SetActive(true);
            }
            foreach(GameObject gd in CardNormalFrame)
            {
                gd.SetActive(false);
            }
        }
        if (TargetZone == ZoneType.Hand || TargetZone == ZoneType.Deck)
        {
            if (Actor != null)
            {
                Actor.SetActive(false);
                DragNoTarget.SetActive(false);
                DragOnTarget.SetActive(false);
            }
            //CardActor.SetActive(true);
            if(TargetZone==ZoneType.Deck && CanBePlayedNow==false)
            {
                CardActor.SetActive(false);
            }
            CardBack.SetActive(true);
            CardDragNoTarget.SetActive(m_ActorTargetOpts == TargetingOptions.NoTarget);
            CardDragOnTarget.SetActive(m_ActorTargetOpts != TargetingOptions.NoTarget);
            CardDragOnTarget.GetComponent<DragOnTarget>().Targets = m_ActorTargetOpts;
        }

        if (TargetZone == ZoneType.Board || TargetZone==ZoneType.Head || TargetZone == ZoneType.Hero || TargetZone==ZoneType.Weapon || TargetZone==ZoneType.Head)
        {
            Actor.SetActive(true);
            this.ActiveAuraVfx();
            DragNoTarget.SetActive(false);
            DragOnTarget.SetActive(true);
            //DragOnTarget.GetComponent<DragOnTarget>().Targets = TargetingOptions.OpposingCharactersTauntFirst;
            CardActor.SetActive(false);
            CardBack.SetActive(false);
            CardDragNoTarget.SetActive(false);
            CardDragOnTarget.SetActive(false);
            CardDragOnTarget.GetComponent<DragOnTarget>().Targets = m_ActorTargetOpts;
        }
        if(TargetZone == ZoneType.Power || TargetZone==ZoneType.MinionPower)
        {
            //UnityEngine.Debug.Log(CardDbf.m_noteMiniGuid);
            Actor.SetActive(true);
            DragNoTarget.SetActive(m_ActorTargetOpts==TargetingOptions.NoTarget);
            DragOnTarget.SetActive(m_ActorTargetOpts!=TargetingOptions.NoTarget);
            DragNoTarget.GetComponent<HeroPowerButton>().Targets=m_ActorTargetOpts;
            DragOnTarget.GetComponent<HeroPowerButton>().Targets=m_ActorTargetOpts;
            CardActor.SetActive(false);
            CardBack.SetActive(false);
            CardDragNoTarget.SetActive(false);
            CardDragOnTarget.SetActive(false);
            CardDragOnTarget.GetComponent<DragOnTarget>().Targets = m_ActorTargetOpts;
        }
        if (TargetZone == ZoneType.Grave || TargetZone == ZoneType.Removed)
        {
            if(Actor!=null)
            {
                Actor.SetActive(false);
                DragNoTarget.SetActive(false);
                DragOnTarget.SetActive(false); 
            }
            CardActor.SetActive(false);
            CardBack.SetActive(false);
            CardDragNoTarget.SetActive(false);
            CardDragOnTarget.SetActive(false);
            CardDragOnTarget.GetComponent<DragOnTarget>().Targets = m_ActorTargetOpts; 
        }  

        if((TargetZone==ZoneType.Hand && ControlBy==AreaPosition.Top) ||(TargetZone==ZoneType.Deck && CanBePlayedNow==false) )
        {
            CardDragOnTarget.SetActive(false);
            CardDragNoTarget.SetActive(false);
        } 
        if(TargetZone==ZoneType.Board)
        {
            DragNoTarget.SetActive(OneSceneManager.Instance.IsBgMode);
            DragOnTarget.SetActive(!OneSceneManager.Instance.IsBgMode);
        }
        if(TargetZone==ZoneType.Aside)
        {
            if (Actor != null)
            {
                Actor.SetActive(false);
                DragNoTarget.SetActive(false);
                DragOnTarget.SetActive(false);
            }
            CardBack.SetActive(true);
            CardDragNoTarget.SetActive(true);
            CardDragOnTarget.SetActive(false);
            CardDragNoTarget.GetComponent<DragNoTarget>().Targets = TargetingOptions.MakeChoice;

            HoverPreview pv = this.gameObject.GetComponentInChildren<HoverPreview>();
            pv.TargetPosition = new Vector3(0f, 0f, 0f);
            pv.TargetScale = 0.5f;
        }

        CardGlowEnabled = TargetZone == ZoneType.Hand;
    }

    public void SetBaconHighLight()
    {
        this.EnableHighLight();
        switch(CardDbf.ManaCost)
        {
            case(1):
                this.SetHighLightColor(new Color(1f,1f,1f,1f));
                break;
            case(2):
                this.SetHighLightColor(new Color(0f,1f,0f,1f));
                break;
            case(3):
                this.SetHighLightColor(new Color(0f,0f,1f,1f));
                break;
            case(4):
                this.SetHighLightColor(new Color(1f,0f,1f,1f));
                break;
            case(5):
                this.SetHighLightColor(new Color(1f,1f,0f,1f));
                break;
            default:
                break;
        }
    }
    public void EnableHighLight(bool enable=true)
    {
        if(HighLightQuad!=null)
            HighLightQuad.SetActive(enable);
        if (CardHighLightQuad != null)
        {
            CardHighLightQuad.SetActive(CardGlowEnabled&&enable);
        }
        if(enable)
            SetHighLightColor(Color.green);
        IsHighLighting = enable;
    }
    public Color HighLightCache = Color.green;
    public void SetHighLightColor(Color c)
    {

        HighLightCache=c;
        float FlareFactor = Mathf.Pow(2, 3);
        float FrameFactor = Mathf.Pow(2, -1);
        if(c.r==1f && c.g==1f && c.b==1f)
        {
            FlareFactor = Mathf.Pow(2, 0);
            FrameFactor = Mathf.Pow(2, -1);
        }
        if(c.r==0f && c.g==0f && c.b==1f)
        {
            FlareFactor = Mathf.Pow(2, 5);
            FrameFactor = Mathf.Pow(2, 1);
        }
        
        if (HighLightQuad != null)
        {
            MeshRenderer Rend = HighLightQuad.GetComponent<MeshRenderer>();
            Material newMat = Rend.material;
            if (!InstancedHighLight)
                newMat = Material.Instantiate(Rend.material) as Material;
            newMat.SetColor("_FlareColor", new Color(c.r * FlareFactor, c.g * FlareFactor, c.b * FlareFactor));
            newMat.SetColor("_FrameColor", new Color(c.r * FrameFactor, c.g * FrameFactor, c.b * FrameFactor));
            Rend.material = newMat;
        }
        if (CardHighLightQuad != null)
        {
            MeshRenderer CardRend = CardHighLightQuad.GetComponent<MeshRenderer>();
            Material newCardMat = CardRend.material;
            if (!InstancedHighLight)
                newCardMat = Material.Instantiate(CardRend.material) as Material;
            newCardMat.SetColor("_FlareColor", new Color(c.r * FlareFactor, c.g * FlareFactor, c.b * FlareFactor));
            newCardMat.SetColor("_FrameColor", new Color(c.r * FrameFactor, c.g * FrameFactor, c.b * FrameFactor));
            CardRend.material = newCardMat;
            CardHighLightQuad.SetActive(CardGlowEnabled);
        }
        InstancedHighLight = true;
        //if(OneSceneManager.Instance.IsBgMode && c==Color.green)
        //{
            //EnableHighLight(false);
        //}
    }


    public void UpdateAsset(CardDbf asset,ZoneType TargetZone=ZoneType.Hand,PremiumType ActorPremium=PremiumType.Normal)
    {
        CardDbf = asset;
        manaDef = CardDbf.ManaCost;
        atkDef = CardDbf.Attack;
        hpDef = CardDbf.MaxHealth;
        if(ActorPremium==PremiumType.Normal)
        {
            ActorPremium=this.premiumType;
        }
        else{
            this.premiumType=ActorPremium;
        }
        //if (ActorPremium == PremiumType.Golden)
        //{
            //atkDef = 2 * CardDbf.Attack;
            //hpDef = 2 * CardDbf.MaxHealth;
        //}

        UpdateAssetForZone(TargetZone,ActorPremium:ActorPremium);
        UnityEngine.Debug.Log("Updating Asset"+asset.m_noteMiniGuid);
        if(OneSceneManager.Instance.CardMajorAbility.Count>0)
        {
            Material majorMat = Material.Instantiate(OneSceneManager.Instance.SimpleLitMaterial) as Material;
            switch (CardDbf.CardType)
            {
                case (CardType.Spell):
                majorMat.SetTexture("_BaseMap", OneSceneManager.Instance.CardMajorAbility[(int)CardDbf.Classes[0]]);
                break;
                case (CardType.Minion):
                majorMat.SetTexture("_BaseMap", OneSceneManager.Instance.CardMajorMinion[(int)CardDbf.Classes[0]]);
                break;
                case (CardType.Weapon):
                majorMat.SetTexture("_BaseMap", OneSceneManager.Instance.CardMajorWeapon[(int)CardDbf.Classes[0]]);
                break;
                case (CardType.HeroPower):
                majorMat.SetTexture("_BaseMap", OneSceneManager.Instance.CardMajorAbility[(int)CardDbf.Classes[0]]);
                break;
                case (CardType.Hero):
                majorMat.SetTexture("_BaseMap", OneSceneManager.Instance.CardMajorHero[(int)CardDbf.Classes[0]]);
                break;
                case (CardType.Location):
                majorMat.SetTexture("_BaseMap", OneSceneManager.Instance.CardMajorLocation[(int)CardDbf.Classes[0]]);
                break;
                default:
                majorMat.SetTexture("_BaseMap", OneSceneManager.Instance.CardMajorAbility[(int)CardDbf.Classes[0]]);
                break;
            }
            foreach (MeshRenderer mr in CardMajor)
            {
                mr.material = majorMat;
            }        
        }
        if (CardMajorIndicator != null)
        {
            Material majorMat = Material.Instantiate(OneSceneManager.Instance.SimpleLitMaterial) as Material;
            majorMat.SetTexture("_BaseMap", null);
            majorMat.SetColor("_BaseColor", OneSceneManager.Instance.CardMajorColor[(int)CardDbf.Classes[0]]);
            CardMajorIndicator.material = majorMat;
        }
        
        
        if(CardPortait!=null)
        {
            MyAbLoader.Instance.SetHSMat(CardPortait.gameObject,CardDbf.m_noteMiniGuid);
        }
        if(Portait!=null)
        {
            MyAbLoader.Instance.SetHSMat(Portait.gameObject,CardDbf.m_noteMiniGuid);
        }

        //StartCoroutine(IE_LoadMatVfxHSsync());//IE_LoadMatVfxHSSync());

        
        Texture2D _texture2d = null;
        if(CardPortait!=null)
        {
            bool retHSCardPortaitMat=false;
            if(OneActorManager.UseLocalHSPremium)
            {
                retHSCardPortaitMat = HSViewer.SetHSMat(CardPortait.gameObject,CardDbf.m_noteMiniGuid);
            }
            if(retHSCardPortaitMat==false)
            {
                Material cardPortaitMat;
                 _texture2d = MyAssetsLoader.GetCardDbfImageTexutre(asset);
                if (MyAssetsLoader.GetCustomMaterial(asset) != null)
                {
                    cardPortaitMat = Material.Instantiate(MyAssetsLoader.GetCustomMaterial(asset)) as Material;
                    if(_texture2d!=null)
                        cardPortaitMat.SetTexture("_MainTex", _texture2d);
                }
                else
                {
                    cardPortaitMat = Material.Instantiate(OneSceneManager.Instance.DiffuseMaterial) as Material;
                    if(_texture2d!=null)
                        cardPortaitMat.SetTexture("_BaseMap", _texture2d);
                }
                CardPortait.material = cardPortaitMat;
            }
        }            

        if(Portait!=null)
        {
            bool retHSPortaitMat=false;
            if(OneActorManager.UseLocalHSPremium)
            {
                retHSPortaitMat = HSViewer.SetHSMat(Portait.gameObject,CardDbf.m_noteMiniGuid);
            }
            if(retHSPortaitMat==false)
            {
                Material PortaitMat;
                 _texture2d = MyAssetsLoader.GetCardDbfImageTexutre(asset);
                if (MyAssetsLoader.GetCustomMaterial(asset) != null)
                {
                    PortaitMat = Material.Instantiate(MyAssetsLoader.GetCustomMaterial(asset)) as Material;
                    if(_texture2d!=null)
                        PortaitMat.SetTexture("_MainTex", _texture2d);
                }
                else
                {
                    PortaitMat = Material.Instantiate(OneSceneManager.Instance.DiffuseMaterial) as Material;
                    if(_texture2d!=null)
                        PortaitMat.SetTexture("_BaseMap", _texture2d);
                }
                Portait.material = PortaitMat;
            }  
        }
        

        if (ActorPremium==PremiumType.Golden)
        {
            if(GoldenCardLegendaryFx!=null)
                GoldenCardLegendaryFx.SetActive(CardDbf.RareType == RareType.Legendary);
            if(GoldenLegendaryFx!=null)
                GoldenLegendaryFx.SetActive(CardDbf.RareType == RareType.Legendary);
        }
        else
        {
            if (CardLegendaryFx != null)
                CardLegendaryFx.SetActive(CardDbf.RareType == RareType.Legendary);
            if(LegendaryFx!=null)
                LegendaryFx.SetActive(CardDbf.RareType == RareType.Legendary);            
        }


        if (CardRarityGemFx!=null)
        {
            CardRarityGemFx.material = OneSceneManager.Instance.CardRarityGemFxMat[(int)CardDbf.RareType];
        }
        

        if (CardTypeText != null)
        {
            CardTypeText.text = "";
        }
        string tyn = "";
        if (CardDbf.RaceType.Count != 0 && CardTypeText!=null)
        {
            
            for (int i = 0; i < this.CardDbf.RaceType.Count; i++)
            {
                //UnityEngine.Debug.Log("XXX");
                tyn += CardDbf.RaceTypeName[(int)CardDbf.RaceType[i]];
                if (i != this.CardDbf.RaceType.Count - 1)
                {
                    tyn += "|";
                }
            }
            
        }
        if (CardDbf.SpellType.Count != 0 && CardTypeText!=null)
        {
            for (int i = 0; i < this.CardDbf.SpellType.Count; i++)
            {

                tyn += CardDbf.SpellTypeName[(int)CardDbf.SpellType[i]];
                if (i != this.CardDbf.SpellType.Count - 1)
                {
                    tyn += "|";
                }
            }
        }
        CardTypeText.text = tyn;

        CardCostText.text = CardDbf.ManaCost.ToString();
        CardCostText.color = Color.white;
        
        CardNameText.text = CardDbf.CnName;
        //CardNameText.enabled=false;

        string dst="";
        for(int i=0; i < CardDbf.Description.Length;i++)
        {
            if(CardDbf.Description[i]!='$' && CardDbf.Description[i]!='@' && CardDbf.Description[i]!='d')
            {
                dst+=CardDbf.Description[i];
                if(i%1==0 && CardDbf.Description[i]!='<' && CardDbf.Description[i]!='>' && CardDbf.Description[i]!='/' && CardDbf.Description[i]!='b' && CardDbf.Description[i]!='i'&& CardDbf.Description[i]!='r'&& CardDbf.Description[i]!='g')
                {
                    dst+=" ";
                }
            }
        }

        CardDescriptionText.text = dst;
        //CardDescriptionText.enabled=false;
        if(ActorPremium==PremiumType.Golden || CardDbf.CardType==CardType.Weapon)
        {
            CardDescriptionText.color = new Color(1f,1f,1f,1f);
        }
        if (CardTypeText != null)
        {
            //CardTypeText.text = CardDbf.CardType;
        }


        if (CardDbf.CardType != CardType.Spell && CardDbf.CardType != CardType.HeroPower && CardDbf.CardType != CardType.Secret)
        {
            CardAttackText.text = CardDbf.Attack.ToString();
            CardHealthText.text = CardDbf.MaxHealth.ToString();
            CardAttackText.color = Color.white;
            CardHealthText.color = Color.white;
            if(CardDbf.MaxHealth==100000)
            {
                //CardHealthText.color = new Color(1f,1f,1f,0f);
            }
        }
        else
        {
            if (CardAttackText != null)
            {
                CardAttackText.color = new Color(0, 0, 0, 0);
            }
            if (CardHealthText != null)
            {
                CardHealthText.color = new Color(0, 0, 0, 0);
            }
        }


        mana = manaDef;
        atk = atkDef;
        hp = hpDef;
        arm = armDef;
        if (CostText != null)
        {
            CostText.text = CardDbf.ManaCost.ToString();
            CostText.color = Color.white;
        }
        if (AttackText != null)
        {
            AttackText.text = CardDbf.Attack.ToString();
            AttackText.color = Color.white;
            if (CardDbf.Attack == 0 && CardDbf.CardType == CardType.Hero)
            {
                AttackText.color = new Color(1f, 1f, 1f, 0f);
            }
        }
        if (HealthText != null)
        {
            HealthText.text = CardDbf.MaxHealth.ToString();
            HealthText.color = Color.white;
            if(CardDbf.MaxHealth==100000)
            {
                //HealthText.color = new Color(1f,1f,1f,0f);
            }
        }
        if (ArmorText != null)
        {
            ArmorText.text = "0";
            ArmorText.color = new Color(1f, 1f, 1f, 0f);
        }



      
        if (CardDbf.RareType == RareType.Legendary)
        {
        }

        foreach (AudioSource auds in this.gameObject.GetComponentsInChildren<AudioSource>())
        {
            auds.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("SFX")[0];
        }

        AudAsset Aud = MyAssetsLoader.GetCustomAudAsset(CardDbf);
        if (Aud == null)
        {
            int AudIndex = 0;
            if (CardDbf.RaceType.Count != 0)
            {
                AudIndex = (int)CardDbf.RaceType[0];
            }
            if (AudIndex < OneSceneManager.Instance.DefaultAudAsset.Count)
                Aud = OneSceneManager.Instance.DefaultAudAsset[AudIndex];
        }

        if(Aud!=null)
        {
            if (CustomSummonAudioSource != null)
            {
                CustomSummonAudioSource.outputAudioMixerGroup =  OneSceneManager.Instance.AudMixer.FindMatchingGroups("Actor")[0];
                CustomSummonAudioSource.clip = Aud.SpawnClip;
            }
            if (CustomAttackAudioSource != null)
            {
                CustomAttackAudioSource.outputAudioMixerGroup =  OneSceneManager.Instance.AudMixer.FindMatchingGroups("Actor")[0];
                CustomAttackAudioSource.clip = Aud.AttackClip;
            }
            if (CustomDeathAudioSource != null)
            {
                CustomDeathAudioSource.outputAudioMixerGroup =  OneSceneManager.Instance.AudMixer.FindMatchingGroups("Actor")[0];
                CustomDeathAudioSource.clip = Aud.DeathClip;
            }
            if (CustomStingerAudioSource != null)
            {
                CustomStingerAudioSource.outputAudioMixerGroup =  OneSceneManager.Instance.AudMixer.FindMatchingGroups("SFX")[0];
            }
        }

        if(SceneManager.GetActiveScene().name=="PlayGameHS")
        {
            
            if(CardDbf.ScriptName!=CardDbf.m_noteMiniGuid && CardDbf.ScriptName!="" && CardDbf.ScriptName!=null)
            {
                bool svfxret=HSViewer.SetHSSummonSpawnDeathVFX(this.gameObject,CardDbf.ScriptName);
                HSViewer.SetHSInvokeLaunchImpactVfx(this.gameObject,CardDbf.ScriptName);
            }
            else
            {
                bool svfxret=HSViewer.SetHSSummonSpawnDeathVFX(this.gameObject,CardDbf.m_noteMiniGuid);
                HSViewer.SetHSInvokeLaunchImpactVfx(this.gameObject,CardDbf.m_noteMiniGuid);                
            }
            
            if(DefaultAttackAnimation!=null)
            {
                HSViewer.LoadDefaultAttackAniClip();
                //DefaultAttackAnimation.clip =  OneActorManager.DefaultAttackReadyClip;
                DefaultAttackAnimation.AddClip(OneActorManager.DefaultAttackReadyClip,"Ready");
                DefaultAttackAnimation.AddClip(OneActorManager.DefaultAttackFinishClip,"Finish");                
            }
            
            if(OneActorManager.UseLocalHSCardAud)
            {
                MyAssetsLoader.Instance.LoadCardAud(this);
            }
            SetHighLightColor(Color.green);
        }
        

        if(ActorPremium==PremiumType.Mythic)
        {
            if(this.MythicPortraitMesh!=null)
            {
                if(this.MythicOffScreenInstance==null)
                {
                    this.TryLoadMythicOffScrrenPrefab();
                    if(this.MythicOffScreenPrefab!=null)
                    {
                        this.MythicOffScreenInstance = GameObject.Instantiate(this.MythicOffScreenPrefab, new Vector3(-100f*MythicCnt,-100f,-100f), Quaternion.Euler(new Vector3(0f,0f,0f))) as GameObject;
                        Camera RTTcam = this.MythicOffScreenInstance.transform.GetChild(1).GetChild(0).gameObject.GetComponent<Camera>();
                        RenderTexture rtx =new RenderTexture(1080, 1080, 16, RenderTextureFormat.ARGB32);
                        rtx.depth=32;
                        rtx.Create();
                        RTTcam.targetTexture = rtx;
                        MythicCnt+=1;
                        Material mat = Material.Instantiate(OneSceneManager.Instance.TransparentMaterial) as Material;                        
                        mat.SetTexture("_MainTex",rtx);
                        this.MythicPortraitMesh.GetComponent<Renderer>().material = mat;
                        foreach(GameObject obj in this.NormalFrame)
                        {
                            obj.SetActive(false);
                        }
                        foreach(GameObject obj in this.GoldenFrame)
                        {
                            obj.SetActive(false);
                        }
                        foreach(GameObject obj in this.MythicFrame)
                        {
                            obj.SetActive(true);
                        }
                        this.HighLightQuad.transform.localScale=new Vector3(1.7f,1.7f,1.7f);
                    }
                }
            }
            
        }
    }
    private static int MythicCnt=1;
    private void TryLoadMythicOffScrrenPrefab()
    {
        string emoteurl = "CustomSkin/Mythic/"+CardDbf.m_noteMiniGuid+"/Emotes/";
        this.MythicEmoteAudClips.Add(Resources.Load<AudioClip>(emoteurl+"A2THANKS"));
        this.MythicEmoteAudClips.Add(Resources.Load<AudioClip>(emoteurl+"A3WOW"));
        this.MythicEmoteAudClips.Add(Resources.Load<AudioClip>(emoteurl+"A4WELLPLAYED"));
        this.MythicEmoteAudClips.Add(Resources.Load<AudioClip>(emoteurl+"A5OOPS"));
        this.MythicEmoteAudClips.Add(Resources.Load<AudioClip>(emoteurl+"A6GREETINGS"));
        this.MythicEmoteAudClips.Add(Resources.Load<AudioClip>(emoteurl+"A7THREATEN"));
        this.MythicEmoteAudClips.Add(Resources.Load<AudioClip>(emoteurl+"A1START"));
        this.MythicEmoteAudClips.Add(Resources.Load<AudioClip>(emoteurl+"A9CONCEDE"));
        this.MythicEmoteAudClips.Add(Resources.Load<AudioClip>(emoteurl+"A8ATTACK"));
        this.MythicEmoteTexts.Add(Resources.Load<TextAsset>(emoteurl+"A2THANKS").text);
        this.MythicEmoteTexts.Add(Resources.Load<TextAsset>(emoteurl+"A3WOW").text);
        this.MythicEmoteTexts.Add(Resources.Load<TextAsset>(emoteurl+"A4WELLPLAYED").text);
        this.MythicEmoteTexts.Add(Resources.Load<TextAsset>(emoteurl+"A5OOPS").text);
        this.MythicEmoteTexts.Add(Resources.Load<TextAsset>(emoteurl+"A6GREETINGS").text);
        this.MythicEmoteTexts.Add(Resources.Load<TextAsset>(emoteurl+"A7THREATEN").text);
        this.MythicEmoteTexts.Add(Resources.Load<TextAsset>(emoteurl+"A1START").text);
        this.MythicOffScreenPrefab = Resources.Load<GameObject>("CustomSkin/Mythic/"+CardDbf.m_noteMiniGuid+"/OffScreen");
    }
    public void ActiveTriggerVfx()
    {
        if(TriggerVfxObject!=null)
        {
            foreach(ParticleSystem ps in TriggerVfxObject.GetComponentsInChildren<ParticleSystem>())
            {
                ps.Play();
            }
            foreach(AudioSource ads in TriggerVfxObject.GetComponentsInChildren<AudioSource>())
            {
                ads.Play();
            }
            if(CustomTriggerAudioSource!=null)
                CustomTriggerAudioSource.Play();
        }
    }
    public void ActiveAuraVfx()
    {
        if(AuraVfxObject!=null)
        {
            AuraVfxObject.SetActive(true);
            foreach(ParticleSystem ps in AuraVfxObject.GetComponentsInChildren<ParticleSystem>())
            {
                ps.Play();
            }
        }
    }
    public void DeActiveAuraVfx()
    {
        if(AuraVfxObject!=null)
            AuraVfxObject.SetActive(false);
    }
    public void ActiveFrozenVfx()
    {
        if(FrozenVfxObject!=null)
        {
            FrozenVfxObject.SetActive(true);
            foreach(ParticleSystem ps in FrozenVfxObject.GetComponentsInChildren<ParticleSystem>())
            {
                ps.Play();
            }
        }
    }
    public void DeActiveFrozenVfx()
    {
        if(FrozenVfxObject!=null)
            FrozenVfxObject.SetActive(false);
    }
    public void ActiveImmueVfx()
    {
        if(ImmueVfxObject!=null)
        {
            ImmueVfxObject.SetActive(true);
            foreach(ParticleSystem ps in ImmueVfxObject.GetComponentsInChildren<ParticleSystem>())
            {
                ps.Play();
            }
        }
    }
    public void DeActiveImmueVfx()
    {
        if(ImmueVfxObject!=null)
            ImmueVfxObject.SetActive(false);
    }
    public void ActiveStealthVfx()
    {
        if(StealthVfxObject!=null)
        {
            StealthVfxObject.SetActive(true);
            foreach(ParticleSystem ps in StealthVfxObject.GetComponentsInChildren<ParticleSystem>())
            {
                ps.Play();
            }
        }
    }
    public void DeActiveStealthVfx()
    {
        if(StealthVfxObject!=null)
            StealthVfxObject.SetActive(false);
    }
    public void ActiveWindFuryVfx()
    {
        if(WindFuryVfxObject!=null)
        {
            WindFuryVfxObject.SetActive(true);
            foreach(ParticleSystem ps in WindFuryVfxObject.GetComponentsInChildren<ParticleSystem>())
            {
                ps.Play();
            }
        }
    }
    public void DeActiveWindFuryVfx()
    {
        if(WindFuryVfxObject!=null)
            WindFuryVfxObject.SetActive(false);
    }
    public (GameObject,float) ActiveTableSpell(SpellType ty)
    {
        return GetHSSpellTableVfxIns(ty);
    }
    public (GameObject,float) GetHSSpellTableVfxIns(SpellType ty,bool extend=false,bool AutoDestroy=true,ZoneType zty= ZoneType.Board,CardType cty = CardType.Minion)
    {
        GameObject spellPrefab = HSViewer.GetHSSpellFromTable(ty,zty:zty,cty:cty);
        if(ty==null)
        {
            return (null,0f);
        }
        GameObject VfxIns;
        VfxIns=GameObject.Instantiate(spellPrefab, this.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
        VfxIns.transform.localScale= new Vector3(0.5f,0.5f,0.5f);
        //HSViewer.AddPlayMakerFSMAudioClip(VfxIns);
        bool AudStart=false;
        //UnityEngine.GameObjectUtility.RemoveMonoBehavioursWithMissingScript(VfxIns);
        foreach (Transform t in VfxIns.transform.GetComponentsInChildren<Transform>(true))
        {
            //t.localScale=new Vector3(0.3f,0.3f,0.3f);
            t.gameObject.SetActive(true);

            if(t.gameObject.GetComponent<MeshRenderer>()!=null)
            {
                if(ty!=SpellType.TRIGGER && ty!=SpellType.FROZEN && ty!=SpellType.IMMUNE && ty!=SpellType.STEALTH)
                {
                    t.gameObject.GetComponent<MeshRenderer>().enabled=false;
                }
                else{
                    t.gameObject.GetComponent<MeshRenderer>().enabled=true;
                }
            }                


            if(t.gameObject.GetComponent<SkinnedMeshRenderer>()!=null)
            {
                t.gameObject.GetComponent<SkinnedMeshRenderer>().enabled=true;
            }
            if(t.gameObject.GetComponent<AudioSource>()!=null)
            {
                if(!AudStart)
                {
                    AudStart=true;
                    t.gameObject.GetComponent<AudioSource>().enabled=true;
                }
            }
            if(t.gameObject.GetComponent<Animation>()!=null)
            {
                t.gameObject.GetComponent<Animation>().Play();
            }
            //UnityEngine.GameObjectUtility.RemoveMonoBehavioursWithMissingScript(t.gameObject);
        }
        foreach(OffScreenRenderFX osf in VfxIns.GetComponentsInChildren<OffScreenRenderFX>())
        {
            if(osf.ObjectToRender!=null)
            {
                osf.ObjectToRender.SetActive(false);
            }
        }
        foreach(RenderToTexture osf in VfxIns.GetComponentsInChildren<RenderToTexture>())
        {
            if(osf.m_ObjectToRender!=null)
            {
                osf.m_ObjectToRender.SetActive(false);
            }
        }
        float Dur=0f;
        foreach(ParticleSystem ps in VfxIns.GetComponentsInChildren<ParticleSystem>())
        {
            //if(!ps.main.loop)
            //{
            if(ps.main.duration>Dur)
            {
                Dur=ps.main.duration;
            }
            //}
            var main = ps.main;
            main.scalingMode = ParticleSystemScalingMode.Hierarchy;
            ps.GetComponent<Renderer>().enabled=true;
            if(extend)
            {
                main.loop=true;
                Dur=UnityEngine.Random.Range(0.6f,0.7f);
            }
            else{
                //main.loop=false;
                //main.duration=0.3f;
            }
            ps.Play();
        }
        if(AutoDestroy)
        {
            UnityEngine.Object.Destroy(VfxIns,Dur+1f);
        }
        return (VfxIns,Dur);
    }
    public (GameObject,float) GetVfxIns(GameObject vfxPrefab, Vector3 InitPos, bool extend=false, bool AutoDestroy=true)
    {
        GameObject VfxIns=null;
        VfxIns=GameObject.Instantiate(vfxPrefab, InitPos, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
        VfxIns.transform.localScale= new Vector3(0.5f,0.5f,0.5f);
        //HSViewer.AddPlayMakerFSMAudioClip(VfxIns);
        //UnityEngine.GameObjectUtility.RemoveMonoBehavioursWithMissingScript(VfxIns);
        foreach (Transform t in VfxIns.transform.GetComponentsInChildren<Transform>(true))
        {
            //t.localScale=new Vector3(0.3f,0.3f,0.3f);
            /*
            t.gameObject.SetActive(true);
            if(t.gameObject.GetComponent<MeshRenderer>()!=null)
            {
                t.gameObject.GetComponent<MeshRenderer>().enabled=true;
            }
            if(t.gameObject.GetComponent<SkinnedMeshRenderer>()!=null)
            {
                t.gameObject.GetComponent<SkinnedMeshRenderer>().enabled=true;
            }
            if(t.gameObject.GetComponent<AudioSource>()!=null)
            {
                t.gameObject.GetComponent<AudioSource>().enabled=true;
            }
            if(t.gameObject.GetComponent<Animation>()!=null)
            {
                t.gameObject.GetComponent<Animation>().Play();
            }
            */
            if(t.gameObject.name.Contains("Mask"))
            {
                t.gameObject.SetActive(false);
            }
            //UnityEngine.GameObjectUtility.RemoveMonoBehavioursWithMissingScript(t.gameObject);
        }
        /*
        foreach(OffScreenRenderFX osf in VfxIns.GetComponentsInChildren<OffScreenRenderFX>())
        {
            if(osf.ObjectToRender!=null)
            {
                osf.ObjectToRender.SetActive(false);
            }
        }
        foreach(RenderToTexture osf in VfxIns.GetComponentsInChildren<RenderToTexture>())
        {
            if(osf.m_ObjectToRender!=null)
            {
                osf.m_ObjectToRender.SetActive(false);
            }
        }
        */


        
        float Dur=0f;
        foreach(ParticleSystem ps in VfxIns.GetComponentsInChildren<ParticleSystem>())
        {
            if(!ps.main.loop)
            {
                if(ps.main.duration>Dur)
                {
                    Dur=ps.main.duration;
                }
            }
            var main = ps.main;
            main.scalingMode = ParticleSystemScalingMode.Hierarchy;
            //ps.GetComponent<Renderer>().enabled=true;
            if(extend)
            {
                main.loop=true;
                Dur=UnityEngine.Random.Range(0.6f,0.7f);
            }
            else{
                //main.loop=false;
                //main.duration=0.3f;
            }
            //ps.Play();
        }
        if(AutoDestroy)
            UnityEngine.Object.Destroy(VfxIns,Dur+1f);
        return (VfxIns,Dur);
    }
    public GameObject NormalizeVFX(GameObject summonins,bool startfsm=false)
    {
        summonins.transform.localScale= new Vector3(0.5f,0.5f,0.5f);
        if(startfsm)
        {       
            Spell sp = summonins.GetComponent<Spell>();
            
            if(sp!=null)
            {
                sp.m_fsm = summonins.GetComponent<PlayMakerFSM>();

                if(sp.m_fsm!=null)
                {
                    sp.m_fsm.SendEvent("Death");
                    sp.m_fsm.SendEvent("Action");
                    sp.m_fsm.SendEvent("Birth");                   
                }
            }    

            float Dur=0f;
            foreach(ParticleSystem ps in summonins.GetComponentsInChildren<ParticleSystem>())
            {
                if(!ps.main.loop)
                {
                    if(ps.main.duration>Dur)
                    {
                        Dur=ps.main.duration;
                    }
                }
                var main = ps.main;
                main.scalingMode = ParticleSystemScalingMode.Hierarchy;
                ps.Play();
            }

            if(Dur>2f)
                Dur=2f;

            UnityEngine.Object.Destroy(summonins,Dur); 
        }
        else{
            foreach(Transform t in summonins.transform.GetComponentsInChildren<Transform>(true))
            {
                //t.localScale=new Vector3(0.3f,0.3f,0.3f);
                t.gameObject.SetActive(true);
                if(t.gameObject.GetComponent<MeshRenderer>()!=null)
                {
                    t.gameObject.GetComponent<MeshRenderer>().enabled=false;
                }
                if(t.gameObject.GetComponent<AudioSource>()!=null)
                {
                    //t.gameObject.GetComponent<AudioSource>().Play();
                    //t.gameObject.GetComponent<AudioSource>().enabled=false;
                }

            }
            
            float Dur=0f;
            foreach(ParticleSystem ps in summonins.GetComponentsInChildren<ParticleSystem>())
            {
                if(!ps.main.loop)
                {
                    if(ps.main.duration>Dur)
                    {
                        Dur=ps.main.duration;
                    }
                }
                var main = ps.main;
                main.scalingMode = ParticleSystemScalingMode.Hierarchy;
                ps.Play();
            }

            if(Dur>2f)
                Dur=2f;
            Sequence DelaySeq = DOTween.Sequence();
            DelaySeq.AppendInterval(Dur);
            DelaySeq.OnComplete(()=>{
                float RemainDur = 5f;
                foreach(ParticleSystem ps in summonins.GetComponentsInChildren<ParticleSystem>())
                {
                    ps.Stop();
                    //if(ps.main.duration>RemainDur)
                    //{
                    //    RemainDur=ps.main.duration;
                    //}
                }
                foreach(MeshRenderer meshs in summonins.GetComponentsInChildren<MeshRenderer>())
                {
                    meshs.enabled=false;
                }
                foreach(SkinnedMeshRenderer meshs in summonins.GetComponentsInChildren<SkinnedMeshRenderer>())
                {
                    meshs.enabled=false;
                }
                foreach(AudioSource aus in summonins.GetComponentsInChildren<AudioSource>())
                {
                    aus.Stop();
                }
                UnityEngine.Object.Destroy(summonins,RemainDur);            
            });

        }
        return summonins; 
    }
    public GameObject ActiveCustomSummonVFX()
    {
        if(CardDbf.RareType == RareType.Legendary)
            OneSceneManager.Instance.CameraShake.StartShake(0.05f);
        GameObject summonins=null;

        if(this.CustomSummonVFXObject!=null)
        {
            summonins=GameObject.Instantiate(this.CustomSummonVFXObject, this.gameObject.transform.position+ new Vector3(0f,0.1f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            this.NormalizeVFX(summonins,true);
        }
        return summonins;
    }

    public GameObject ActiveCustomSpawnVFX()
    {
        if(CardDbf.RareType == RareType.Legendary)
            OneSceneManager.Instance.CameraShake.StartShake(0.01f);
        GameObject summonins=null;

        if(this.CustomSpawnVFXObject!=null)
        {
            summonins=GameObject.Instantiate(this.CustomSpawnVFXObject, this.gameObject.transform.position+ new Vector3(0f,0.1f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            this.NormalizeVFX(summonins,true);
        }
        return summonins;
    }

    public GameObject ActiveCustomDeathVFX()
    {
        if(CardDbf.RareType == RareType.Legendary)
            OneSceneManager.Instance.CameraShake.StartShake(0.01f);
        GameObject summonins=null;

        if(this.CustomDeathVFXObject!=null)
        {
            summonins=GameObject.Instantiate(this.CustomDeathVFXObject, this.gameObject.transform.position+ new Vector3(0f,0.1f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            this.NormalizeVFX(summonins,true);
        }
        return summonins;
    }

    public GameObject ActiveCustomDiscardVFX()
    {
        if(CardDbf.RareType == RareType.Legendary)
            OneSceneManager.Instance.CameraShake.StartShake(0.01f);
        GameObject summonins=null;

        if(this.CustomDiscardVFXObject!=null)
        {
            summonins=GameObject.Instantiate(this.CustomDiscardVFXObject, this.gameObject.transform.position+ new Vector3(0f,0.1f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            this.NormalizeVFX(summonins,true);
        }
        return summonins;
    }

    private bool canAttackNow = false;
    public bool CanAttackNow
    {
        get
        {
            return canAttackNow;
        }

        set
        {
            canAttackNow = value;
            EnableHighLight(value);
        }
    }


    private bool canBePlayedNow = false;
    public bool CanBePlayedNow
    {
        get
        {
            return canBePlayedNow;
        }

        set
        {
            canBePlayedNow = value;
            if (value == true)
            {
                //UpdateAsset(CardDbf, zoneType);
            }
            EnableHighLight(value);
        }
    }

    private void SetDamageFxAlpha(float alpha)
    {
        if(DamageFx!=null)
        {
            Color ToSet = new Color(1f,1f,1f,alpha);
            Color ToSetShadow = new Color(0f,0f,0f,alpha);
            DamageFx.transform.GetChild(0).GetComponent<Image>().color = ToSet;
            DamageFx.transform.GetChild(1).GetComponent<Text>().color = ToSet;
            DamageFx.transform.GetChild(1).GetComponent<CircleOutline>().effectColor = ToSetShadow;
        }        
    }
    private float DamageFxAlpha = 1f;
    private float DamageFxJustChanged = 1f;
    public void Update()
    {
        if(DamageFxJustChanged>0f)
        {
            DamageFxJustChanged-=0.03f;
        }
        else{
            SetDamageFxAlpha(DamageFxAlpha);
            DamageFxAlpha-=0.04f;
            if(DamageFxAlpha<0f)
            {
                DamageFxAlpha=0f;
            }
        }

    }
    public void EnableDamageFx(int amount)
    {
        if (DamageFx != null)
        {
            DamageFx.SetActive(true);
            DamageFxAlpha=1f;
            DamageFxJustChanged=1f;
            string FxTxt = amount.ToString();
            if(amount>0)
            {
                FxTxt="+"+FxTxt;
                //DamageFx.transform.GetChild(1).GetComponent<Text>().color=Color.white;
            }
            else{
                //DamageFx.transform.GetChild(1).GetComponent<Text>().color=Color.white;
            }

            DamageFx.transform.DOScale(new Vector3(1.2f, 1.2f, 1.2f), 0.1f).SetEase(Ease.OutExpo).OnComplete(() =>
            {
                DamageFx.transform.DOScale(new Vector3(1f, 1f, 1f), 0.1f).SetEase(Ease.InExpo);
            });

            DamageFx.transform.GetChild(1).GetComponent<Text>().text = FxTxt;
            SetDamageFxAlpha(1f);
            Sequence DelaySeq = DOTween.Sequence();
            DelaySeq.AppendInterval(1f);
            DelaySeq.OnComplete(() => {
                //DamageFx.SetActive(false);
            });
        }
    }
    public void TakeDamage(int amount, bool hasEffect = true)
    {
        if (amount >= 0)
        {
            if(amount>0)
                Injured = true;
            float Intense = amount > 7 ? 0.05f : (amount > 5 ? 0.03f : 0.02f);
            if(IsActing==false)
            {
                this.gameObject.transform.DOShakePosition(0.2f,new Vector3(Intense*10f,0f,Intense*10f));
            }
            //this.gameObject.transform.DOShakePosition(Intense,new Vector3(1f,0f,1f),0.3f);
            OneSceneManager.Instance.CameraShake.StartShake(Intense);
            if (hasEffect)
            {
                EnableDamageFx(-amount);
            }
        }
        if (amount < 0)
        {
            int rawHp = int.Parse(HealthText.text);
            int finalHp = rawHp - amount;
            if (finalHp >= CardDbf.MaxHealth)
            {
                Injured=false;
                finalHp = CardDbf.MaxHealth;
                amount = -(finalHp - rawHp);
            }
            if (hasEffect)
            {
                EnableDamageFx(-amount);
            }
        }
    }

    private void SetText(TextMeshProUGUI textMesh, int Set, int Def, bool AntiColor = false)
    {
        if (AntiColor)
        {
            if (Set <= 0)
            {
                Set = 0;
            }
        }
        if (textMesh != null)
        {
            if (textMesh.text == Set.ToString())
            {
                return;
            }
            textMesh.text = Set.ToString();
            if (AntiColor)
            {
                textMesh.color = (Set < Def) ? Color.green :
                    ((Set > Def) ? Color.red :
                    Color.white);

            }
            else
            {
                textMesh.color = (Set < Def) ? Color.red :
                    ((Set > Def) ? Color.green :
                    Color.white);
            }

            textMesh.transform.DOScale(new Vector3(2.2f, 2.2f, 1f), 0.1f).SetEase(Ease.OutExpo).OnComplete(() =>
            {
                textMesh.transform.DOScale(new Vector3(1f, 1f, 1f), 0.1f).SetEase(Ease.InExpo);
            }
            );
        }
    }
    public void SetCardNum(int manaSet = 0, int atkSet = 0, int hpSet = 0, int armSet = 0, int manaDefSet = 0, int atkDefSet = 0, int hpDefSet=-1,int armDefSet =0, int engSet=0,int engDefSet=0)
    {
        SetText(CardCostText, manaSet, manaDef, true);
        SetText(CostText, manaSet, manaDef, true);
        mana = manaSet;
        if(CostText!=null && CardCostText!=null)
        {
            CardCostText.gameObject.SetActive(manaSet!=999999);
            CostText.gameObject.SetActive(manaSet!=999999);
        }

        SetText(CardAttackText, atkSet, atkDef);
        SetText(AttackText, atkSet, atkDef);
        atk = atkSet;

        if(AttackGem!=null)
        {
            AttackText.gameObject.SetActive(atkSet>0 && IsPortaitOpen);
            AttackGem.SetActive(atkSet>0 && IsPortaitOpen);
        }

        if (hpDefSet != -1)
        {
            hpDef = hpDefSet;
        }

        SetText(CardHealthText, hpSet, hpDef);
        if(HealthText!=null)
        {
            if(int.Parse(HealthText.text)==hpSet+1)
            {
                AudioSource aus = HealthText.gameObject.GetComponent<AudioSource>();
                if(aus!=null)
                {
                    aus.Play();
                }
            }            
        }

        SetText(HealthText, hpSet, hpDef);
        if (Injured)
        {
            HealthText.color = Color.red;
        }
        hp = hpSet;
        if(HealthGem!=null)
        {
            HealthText.gameObject.SetActive(hpSet!=999999);
            HealthGem.SetActive(hpSet!=999999);
        }

        SetText(CardArmorText, armSet, armSet);
        SetText(ArmorText, armSet, armSet);
        arm = armSet;

        if(ArmorGem!=null)
        {
            ArmorText.gameObject.SetActive(armSet>0);
            ArmorGem.SetActive(armSet>0);
        }

        SetText(CardEnergyText, engSet, engSet);
        SetText(EnergyText, engSet, engSet);
        eng = engSet;

        if(EnergyGem!=null)
        {
            EnergyText.gameObject.SetActive(engSet>0);
            EnergyGem.SetActive(engSet>0);
        }    
    }
    public void ClosePortait()
    {
        IsPortaitOpen=false;
        if(PortaitDoorUp!=null)
        {
            Animation ani = PortaitDoorUp.transform.GetChild(0).gameObject.GetComponent<Animation>();
            ani.Play("WeaponDoorUpClose"); 
            //PortaitDoorUp.transform.GetChild(0).gameObject.SetActive(true);        
        }
        if(PortaitDoorDown!=null)
        {
            Animation ani = PortaitDoorDown.transform.GetChild(0).gameObject.GetComponent<Animation>();
            ani.Play("WeaponDoorDownClose"); 
            PortaitDoorDown.GetComponent<AudioSource>().Play();
            //PortaitDoorDown.transform.GetChild(0).gameObject.SetActive(true);             
        }
        if(AttackGem!=null)
        {
            AttackGem.SetActive(false);
        }
        AttackText.gameObject.SetActive(false);
    }
    public void OpenPortait()
    {
        IsPortaitOpen=true;
        if(PortaitDoorUp!=null)
        {
            Animation ani = PortaitDoorUp.transform.GetChild(0).gameObject.GetComponent<Animation>();
            ani.Play("WeaponDoorUpOpen"); 
            PortaitDoorUp.GetComponent<AudioSource>().Play();
            //PortaitDoorUp.transform.GetChild(0).gameObject.SetActive(false);            
        }
        if(PortaitDoorDown!=null)
        {
            Animation ani = PortaitDoorDown.transform.GetChild(0).gameObject.GetComponent<Animation>();
            ani.Play("WeaponDoorDownOpen"); 
            //PortaitDoorDown.transform.GetChild(0).gameObject.SetActive(false);             
        }
        if(AttackGem!=null)
        {
            AttackGem.SetActive(true);
        }
        AttackText.gameObject.SetActive(true);
    }

/*
    public static Dictionary<int, Sprite> Merged = new Dictionary<int, Sprite>();
    public Sprite MergeSprite(Sprite SLeft, Sprite SRight, int spriteID)
    {
        if (Merged.ContainsKey(spriteID))
        {
            return Merged[spriteID];
        }
        //GameObject Preload = GameObject.FindGameObjectWithTag("ResourcePreLoad");
        //ResourcePreLoad pr = Preload.GetComponent<ResourcePreLoad>();

        Texture2D TLeft = SLeft.texture;
        Texture2D TRight = SRight.texture;
        Texture2D newTex = new Texture2D(TLeft.width, TLeft.height);
        Color[] CLeft = TLeft.GetPixels();
        Color[] CRight = TRight.GetPixels();
        Color[] newCol = new Color[newTex.width * newTex.height];

        for (int x = 0; x < newTex.width / 2; x++)
        {
            for (int y = 0; y < newTex.height; y++)
            {
                int index = x + y * newTex.width;
                newCol[index] = CLeft[index];
            }
        }
        for (int x = newTex.width / 2; x < newTex.width; x++)
        {
            for (int y = 0; y < newTex.height; y++)
            {
                int index = x + y * newTex.width;
                newCol[index] = CRight[index];
            }
        }
        newTex.SetPixels(newCol);
        newTex.Apply();
        Sprite newSp = Sprite.Create(newTex, new Rect(0, 0, newTex.width, newTex.height), new Vector2(0.5f, 0.5f));
        Merged[spriteID] = newSp;
        return newSp;
    }



    public static Texture2D VerticalFlipTexture(Texture2D texture)
    {
        //得到图片的宽高
        int width = texture.width;
        int height = texture.height;

        Texture2D flipTexture = new Texture2D(width, height);
        for (int i = 0; i < height; i++)
        {
            flipTexture.SetPixels(0, i, width, 1, texture.GetPixels(0, height - i - 1, width, 1));
        }
        flipTexture.Apply();
        return flipTexture;
    }
*/

    private IEnumerator IE_LoadMatVfxHSsync()
    {
        CardDbf asset = this.CardDbf;
        Texture2D _texture2d = null;
        if(CardPortait!=null)
        {
            bool retHSCardPortaitMat=false;
            if(OneActorManager.UseLocalHSPremium)
            {
                retHSCardPortaitMat = HSViewer.SetHSMat(CardPortait.gameObject,CardDbf.m_noteMiniGuid);
            }
            if(retHSCardPortaitMat==false)
            {
                Material cardPortaitMat;
                 _texture2d = MyAssetsLoader.GetCardDbfImageTexutre(asset);
                if (MyAssetsLoader.GetCustomMaterial(asset) != null)
                {
                    cardPortaitMat = Material.Instantiate(MyAssetsLoader.GetCustomMaterial(asset)) as Material;
                    if(_texture2d!=null)
                        cardPortaitMat.SetTexture("_MainTex", _texture2d);
                }
                else
                {
                    cardPortaitMat = Material.Instantiate(OneSceneManager.Instance.DiffuseMaterial) as Material;
                    if(_texture2d!=null)
                        cardPortaitMat.SetTexture("_BaseMap", _texture2d);
                }
                CardPortait.material = cardPortaitMat;
            }
            if(DefaultAttackAnimation!=null)
            {
                HSViewer.LoadDefaultAttackAniClip();
                //DefaultAttackAnimation.clip =  OneActorManager.DefaultAttackReadyClip;
                DefaultAttackAnimation.AddClip(OneActorManager.DefaultAttackReadyClip,"Ready");
                DefaultAttackAnimation.AddClip(OneActorManager.DefaultAttackFinishClip,"Finish");                
            }
        }            

        if(Portait!=null)
        {
            bool retHSPortaitMat=false;
            if(OneActorManager.UseLocalHSPremium)
            {
                retHSPortaitMat = HSViewer.SetHSMat(Portait.gameObject,CardDbf.m_noteMiniGuid);
            }
            if(retHSPortaitMat==false)
            {
                Material PortaitMat;
                 _texture2d = MyAssetsLoader.GetCardDbfImageTexutre(asset);
                if (MyAssetsLoader.GetCustomMaterial(asset) != null)
                {
                    PortaitMat = Material.Instantiate(MyAssetsLoader.GetCustomMaterial(asset)) as Material;
                    if(_texture2d!=null)
                        PortaitMat.SetTexture("_MainTex", _texture2d);
                }
                else
                {
                    PortaitMat = Material.Instantiate(OneSceneManager.Instance.DiffuseMaterial) as Material;
                    if(_texture2d!=null)
                        PortaitMat.SetTexture("_BaseMap", _texture2d);
                }
                Portait.material = PortaitMat;
            }  
        }

        if(SceneManager.GetActiveScene().name=="PlayGameHS")
        {
            if(CardDbf.ScriptName!=CardDbf.m_noteMiniGuid && CardDbf.ScriptName!="" && CardDbf.ScriptName!=null)
            {
                bool svfxret=HSViewer.SetHSSummonSpawnDeathVFX(this.gameObject,CardDbf.ScriptName);
                HSViewer.SetHSInvokeLaunchImpactVfx(this.gameObject,CardDbf.ScriptName);
            }
            else
            {
                bool svfxret=HSViewer.SetHSSummonSpawnDeathVFX(this.gameObject,CardDbf.m_noteMiniGuid);
                HSViewer.SetHSInvokeLaunchImpactVfx(this.gameObject,CardDbf.m_noteMiniGuid);                
            }
        }
        yield return null;
    }

    private IEnumerator IE_LoadFullBundle(string BaseUrl, string BundleName, bool LoadDep=true)
    {
        if(HSViewer.HSABLoading.ContainsKey(BundleName))
        {
            while (HSViewer.HSABLoading[BundleName])
            {
                yield return null;
            }
        }
        else{
            if(HSViewer.abCache.ContainsKey(BundleName))
            {

            }
            else{
                HSViewer.HSABLoading[BundleName] = true;
                AssetBundleCreateRequest abcr = AssetBundle.LoadFromFileAsync(BaseUrl+BundleName);
                yield return abcr;
                HSViewer.abCache[BundleName] = abcr.assetBundle;
                HSViewer.HSABLoading[BundleName] = false;  
            }
        
            if(LoadDep)
            {
                foreach(string dependency in HSViewer.GetDepend(BundleName))
                {
                    if(HSViewer.HSABLoading.ContainsKey(dependency)||HSViewer.abCache.ContainsKey(dependency))
                    {
                        StartCoroutine(IE_LoadFullBundle(BaseUrl,dependency,false));
                        yield return dependency;//AssetBundle.LoadFromFileAsync(BaseUrl+BundleName);
                    }
                    else{
                        StartCoroutine(IE_LoadFullBundle(BaseUrl,dependency,false));
                        yield return dependency;//AssetBundle.LoadFromFileAsync(BaseUrl+BundleName);
                    }
                }
            }          
        }
    }

    private IEnumerator IE_LoadHSJson()
    {
        if(HSViewer.HSABLoading.ContainsKey("asset_manifest.unity3d"))
        {
            while(HSViewer.HSABLoading["asset_manifest.unity3d"])
            {
                yield return null;  
            }
        }
        else{
            HSViewer.HSABLoading["asset_manifest.unity3d"]=true;
            AssetBundleCreateRequest abcrMainfest = AssetBundle.LoadFromFileAsync(HSViewer.absHSdir+"asset_manifest.unity3d");
            yield return abcrMainfest;
            AssetBundle Manifest = abcrMainfest.assetBundle;//AssetBundle.LoadFromFile(absHSdir+"asset_manifest.unity3d");
            HSViewer.abCache["asset_manifest.unity3d"] = Manifest;
            HSViewer.HSABLoading["asset_manifest.unity3d"]=false;
            //abCache[absHSdir+"asset_manifest.unity3d"] = Manifest;
            HSViewer.cata = Manifest.LoadAsset<ScriptableAssetCatalog>("Assets/AssetManifest/base_assets_catalog.asset");
            HSViewer.map = Manifest.LoadAsset<ScriptableAssetMap>("Assets/AssetManifest/AssetMaps/cards_map.asset");
            HSViewer.deps = Manifest.LoadAsset<AssetBundleDependencyGraph>("Assets/AssetManifest/bundle_deps.asset");
            for(int i=0;i < HSViewer.cata.m_assets.Count; i++)
            {
                HSViewer.GUIDIndexDict[HSViewer.cata.m_assets[i].guid] = i;
            }
        }

        if(HSViewer.HSABLoading.ContainsKey("asset_manifest_zhcn.unity3d"))
        {
            while(HSViewer.HSABLoading["asset_manifest_zhcn.unity3d"])
            {
                yield return null;
            }
        }
        else{
            HSViewer.HSABLoading["asset_manifest_zhcn.unity3d"]=true;
            AssetBundleCreateRequest abcrMainfestLocale = AssetBundle.LoadFromFileAsync(HSViewer.absHSdir+"asset_manifest_zhcn.unity3d");
            yield return abcrMainfestLocale;
            AssetBundle ManifestLocale = abcrMainfestLocale.assetBundle;//AssetBundle.LoadFromFile(absHSdir+"asset_manifest_zhcn.unity3d");
            HSViewer.abCache["asset_manifest_zhcn.unity3d"] = ManifestLocale;
            HSViewer.HSABLoading["asset_manifest_zhcn.unity3d"]=false;
            //abCache[absHSdir+"asset_manifest_zhcn.unity3d"] = ManifestLocale;
            HSViewer.cata_cn = ManifestLocale.LoadAsset<ScriptableAssetVariantCatalog>("Assets/AssetManifest/asset_catalog_locale_zhcn.asset");
            for(int i=0;i < HSViewer.cata_cn.m_assets.Count; i++)
            {
                HSViewer.CnGUIDIndexDict[HSViewer.cata_cn.m_assets[i].guid] = i;
            }
            HSViewer.hsjsonready=true;             
        }
    }

    private IEnumerator IE_LoadMatVfxHSAsync()
    {
        if(CardPortait!=null)
        {
            CardPortait.GetComponent<Renderer>().material.color=Color.black;
        }
        if(Portait!=null)
        {
            Portait.GetComponent<Renderer>().material.color=Color.black;
        }
        if(HSViewer.hsjsonready==false)
        {
            yield return StartCoroutine(IE_LoadHSJson());
        }


        Material PortaitMat = null;
        UberShaderAnimation PortaitAni = null;

        bool retHSCardPortaitMat=false;
        if(OneActorManager.UseLocalHSPremium)
        {
            if( CardDbf.m_noteMiniGuid.Contains("SGS_")||CardDbf.m_noteMiniGuid.Contains("TMP_")||CardDbf.m_noteMiniGuid.Contains("SNAP_")||CardDbf.m_noteMiniGuid.Contains("YGO_")||CardDbf.m_noteMiniGuid.Contains("FUS_"))
            {
                retHSCardPortaitMat = false;
            }
            else if( CardDbf.m_noteMiniGuid.Contains("SZB_"))
            {
                retHSCardPortaitMat = Viewer.SetSzbMat(CardPortait.gameObject, CardDbf.m_noteMiniGuid);
            }
            else{
                //(PortaitMat , PortaitAni )= HSViewer.GetHSCardMaterial( CardDbf.m_noteMiniGuid);
                if(HSViewer.matCache.ContainsKey(CardDbf.m_noteMiniGuid))
                {
                    PortaitMat = HSViewer.matCache[CardDbf.m_noteMiniGuid];
                    PortaitAni = HSViewer.ubCache[CardDbf.m_noteMiniGuid];
                }
                else{

                    CardDef def = null;//HSViewer.GetHSCardDef(CardDbf.m_noteMiniGuid);
                    if(HSViewer.cardDefCache.ContainsKey(CardDbf.m_noteMiniGuid))
                    {
                        def = HSViewer.cardDefCache[CardDbf.m_noteMiniGuid];
                    }
                    HSViewer.PrepareHSjson();

                    string HSCardID = HSViewer.GetHSID(CardDbf.m_noteMiniGuid);
                    string CardDefGUID = HSViewer.GetCardDefGUID(HSCardID);
                    string CardDefUrl = HSViewer.GetUrlfromGUID(CardDefGUID);

                    if(CardDefUrl!="")
                    {
                        yield return StartCoroutine(IE_LoadFullBundle(HSViewer.absHSdir,CardDefUrl));
                        AssetBundle assetbundleDef = HSViewer.abCache[CardDefUrl];
                        GameObject defobj = assetbundleDef.LoadAsset<GameObject>(CardDefGUID);
                        def = defobj.GetComponentInChildren<CardDef>();           
                    }

                    if(def==null)
                    {
                        string TempName = "HERO_09bp";
                        if(CardDbf.m_noteMiniGuid!=TempName)
                            def = HSViewer.GetHSCardDef(TempName);
                    }
                    HSViewer.cardDefCache[CardDbf.m_noteMiniGuid] = def;

                    if(def!=null)
                    {
                        //UnityEngine.Debug.Log("FucingLog!!!");
                        string MatID=HSViewer.StripByNote(def.m_PremiumPortraitMaterialPath);
                        string AniID=HSViewer.StripByNote(def.m_PremiumUberShaderAnimationPath);
                        string TexID=HSViewer.StripByNote(def.m_PortraitTexturePath);
                        string PtexID = HSViewer.StripByNote(def.m_PremiumPortraitTexturePath);

                        string MatUrl=HSViewer.GetUrlfromGUID(MatID);
                        string AniUrl=HSViewer.GetUrlfromGUID(AniID);
                        string TexUrl=HSViewer.GetUrlfromGUID(TexID);
                        string PtexUrl=HSViewer.GetUrlfromGUID(PtexID);


                        string SigMatID=HSViewer.StripByNote(def.m_SignaturePortraitMaterialPath);
                        string SigAniID=HSViewer.StripByNote(def.m_SignatureUberShaderAnimationPath);
                        string SigTexID=HSViewer.StripByNote(def.m_SignaturePortraitTexturePath);

                        string SigMatUrl=HSViewer.GetUrlfromGUID(SigMatID);
                        string SigAniUrl=HSViewer.GetUrlfromGUID(SigAniID);
                        string SigTexUrl=HSViewer.GetUrlfromGUID(SigTexID);

                        if(TexID!=""&&TexUrl!="")
                        {
                            //UnityEngine.Debug.Log("ID Valid");
                            //(mat,ub)= HSViewer.LoadCardFromMatAniTex(MatID,AniID,TexID,PtexID,
                            //MatUrl,AniUrl,TexUrl,PtexUrl,SigMatID,SigAniID,SigTexID,SigMatUrl,SigAniUrl,SigTexUrl);    

                            AssetBundle assetbundleMat = null;
                            if(MatUrl!="")
                            {
                                yield return StartCoroutine(IE_LoadFullBundle(HSViewer.absHSdir,MatUrl));
                                assetbundleMat = HSViewer.abCache[MatUrl];
                                //assetbundleMat = HSViewer.LoadFullBundle(HSViewer.absHSdir,MatUrl);
                            }
                            
                            AssetBundle assetbundleAni = null;
                            if(AniUrl!="")
                            {
                                yield return StartCoroutine(IE_LoadFullBundle(HSViewer.absHSdir,AniUrl));
                                assetbundleAni = HSViewer.abCache[AniUrl];
                                //assetbundleAni = HSViewer.LoadFullBundle(HSViewer.absHSdir,AniUrl);
                            }
                            AssetBundle assetbundlePtex = null;
                            if(PtexUrl!="")
                            {
                                yield return StartCoroutine(IE_LoadFullBundle(HSViewer.absHSdir,PtexUrl));
                                assetbundlePtex = HSViewer.abCache[PtexUrl];
                                //assetbundlePtex = HSViewer.LoadFullBundle(HSViewer.absHSdir,PtexUrl);
                            }
                            if(PortaitMat==null)
                            {
                                if(assetbundleMat!=null)
                                {
                                    PortaitMat = assetbundleMat.LoadAsset<Material>(MatID);
                                }
                                if(PortaitMat!=null)
                                {
                                    Texture2D matTex = null;
                                    if(assetbundlePtex!=null)
                                    {
                                        matTex = assetbundlePtex.LoadAsset<Texture2D>(PtexID);
                                    }
                                    if(matTex==null)
                                    {
                                        UnityEngine.Debug.Log("_Pnull!");
                                        yield return StartCoroutine(IE_LoadFullBundle(HSViewer.absHSdir,TexUrl));
                                        AssetBundle assetbundleTex = HSViewer.abCache[TexUrl];
                                        //AssetBundle assetbundleTex = HSViewer.LoadFullBundle(HSViewer.absHSdir,TexUrl);
                                        matTex = assetbundleTex.LoadAsset<Texture2D>(TexID);               
                                    }

                                    if(matTex!=null)
                                    {
                                        PortaitMat.SetTexture("_MainTex",matTex);
                                        //Texture ShadowTex = mat.GetTexture("_ShadowTex");
                                        //if(ShadowTex!=null)
                                        //{
                                        //    string ShadowTexName=ShadowTex.name;
                                        //    UnityEngine.Debug.Log(ShadowTexName);
                                        //}
                                        PortaitMat.SetTexture("_ShadowTex",null);
                                    }

                                    if(assetbundleAni!=null)
                                    {
                                        PortaitAni = assetbundleAni.LoadAsset<UberShaderAnimation>(AniID);
                                    }
                                }
                                if(PortaitMat==null)
                                {
                                    yield return StartCoroutine(IE_LoadFullBundle(HSViewer.absHSdir,TexUrl));
                                    AssetBundle assetbundleTex = HSViewer.abCache[TexUrl];                                    
                                    //AssetBundle assetbundleTex = HSViewer.LoadFullBundle(HSViewer.absHSdir,TexUrl);
                                    if(assetbundleTex!=null)
                                    {
                                        Texture2D matTex = assetbundleTex.LoadAsset<Texture2D>(TexID);
                                        if(matTex!=null)
                                        {
                                            if(OneSceneManager.Instance!=null)
                                            {
                                                PortaitMat = Material.Instantiate(OneSceneManager.Instance.DiffuseMaterial) as Material;
                                                PortaitMat.SetTexture("_BaseMap",matTex);
                                            }
                                        }     
                                    }
                                }
                            }         
                        }   
                    }
                    HSViewer.matCache[CardDbf.m_noteMiniGuid] = PortaitMat;
                    HSViewer.ubCache[CardDbf.m_noteMiniGuid] = PortaitAni;           
                }
                if(PortaitMat!=null)
                {
                    retHSCardPortaitMat = true;
                }
                else{
                    retHSCardPortaitMat = false;
                }          
            }
        }

        if(retHSCardPortaitMat==false)
        {
            Texture2D _texture2d = null;
             _texture2d = MyAssetsLoader.GetCardDbfImageTexutre(this.CardDbf);
            if (MyAssetsLoader.GetCustomMaterial(this.CardDbf) != null)
            {
                PortaitMat = Material.Instantiate(MyAssetsLoader.GetCustomMaterial(this.CardDbf)) as Material;
                if(_texture2d!=null)
                    PortaitMat.SetTexture("_MainTex", _texture2d);
            }
            else
            {
                PortaitMat = Material.Instantiate(OneSceneManager.Instance.DiffuseMaterial) as Material;
                if(_texture2d!=null)
                    PortaitMat.SetTexture("_BaseMap", _texture2d);
            }
        }   

        if(CardPortait!=null)
        {
            CardPortait.GetComponent<Renderer>().material = Material.Instantiate(PortaitMat) as Material;
            if(PortaitAni !=null)
            {
                if(CardPortait.GetComponent<UberShaderController>()!=null)
                {
                    UberShaderController m_uberShaderController = CardPortait.gameObject.GetComponent<UberShaderController>();
                    m_uberShaderController.UberShaderAnimation = UnityEngine.Object.Instantiate<UberShaderAnimation>(PortaitAni);
                    m_uberShaderController.m_MaterialIndex = 0;
                    m_uberShaderController.enabled = true;
                }
                else{
                    UberShaderController m_uberShaderController = CardPortait.gameObject.AddComponent<UberShaderController>();
                    m_uberShaderController.UberShaderAnimation = UnityEngine.Object.Instantiate<UberShaderAnimation>(PortaitAni);
                    m_uberShaderController.m_MaterialIndex = 0;
                    m_uberShaderController.enabled = true;                    
                }
            }   
        }

        if(Portait!=null)
        {
            Portait.GetComponent<Renderer>().material = Material.Instantiate(PortaitMat) as Material;
            if(PortaitAni !=null)
            {
                if(Portait.GetComponent<UberShaderController>()!=null)
                {
                    UberShaderController m_uberShaderController = Portait.gameObject.GetComponent<UberShaderController>();
                    m_uberShaderController.UberShaderAnimation = UnityEngine.Object.Instantiate<UberShaderAnimation>(PortaitAni);
                    m_uberShaderController.m_MaterialIndex = 0;
                    m_uberShaderController.enabled = true;
                }
                else{
                    UberShaderController m_uberShaderController = Portait.gameObject.AddComponent<UberShaderController>();
                    m_uberShaderController.UberShaderAnimation = UnityEngine.Object.Instantiate<UberShaderAnimation>(PortaitAni);
                    m_uberShaderController.m_MaterialIndex = 0;
                    m_uberShaderController.enabled = true;                    
                }
            } 
        }

        if(SceneManager.GetActiveScene().name=="PlayGameHS")
        {
            string VFXname = CardDbf.m_noteMiniGuid;
            if(CardDbf.ScriptName!=CardDbf.m_noteMiniGuid && CardDbf.ScriptName!="" && CardDbf.ScriptName!=null)
            {
                VFXname=CardDbf.ScriptName;
            }

            HSViewer.SetHSSummonSpawnDeathVFX(this.gameObject,VFXname);
            HSViewer.SetHSInvokeLaunchImpactVfx(this.gameObject,VFXname);

            if(DefaultAttackAnimation!=null)
            {
                HSViewer.LoadDefaultAttackAniClip();
                //DefaultAttackAnimation.clip =  OneActorManager.DefaultAttackReadyClip;
                DefaultAttackAnimation.AddClip(OneActorManager.DefaultAttackReadyClip,"Ready");
                DefaultAttackAnimation.AddClip(OneActorManager.DefaultAttackFinishClip,"Finish");                
            }
        }

    }

}