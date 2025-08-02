using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine.UI;
using DG.Tweening;
using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMaker;

public class OpenPackManager : MonoBehaviour
{
    private List<string> cardsToOpenID = new List<string>(){"FUS_002","FUS_002","FUS_002","FUS_002","FUS_002"};
    public List<CardDbf> cardsToOpen=new List<CardDbf>();
    public List<Transform> cardsSlot = new List<Transform>();
    public List<AudioClip> AnnouncerClips = new List<AudioClip>();
    public List<AudioSource> AnnouncerSources = new List<AudioSource>();
    List<GameObject> cardsObj = new List<GameObject>();
    private bool RandomCards=false;
    public GameObject doneBtn;
    public TextMeshProUGUI PackText;
    public bool IsOpeningPack=false;
    public static OpenPackManager Instance;
    public static List<GameObject> FlipFxs = new List<GameObject>();
    public static GameObject PackFxObj;
    public AudioSource PackOpenAudSrc;
    public GameObject PackAniScaler;
    public Transform PackOpenFxPos;
    public Vector3 CenterPos;

    public void Start()
    {
        CardDbf.LoadAllCardDbf();
        Instance=this;
        if(FlipFxs.Count==0)
        {
            GameObject FxObj = HSViewer.GetHSprefab("PackOpeningCardFX.prefab:b32177fb14f134edfb891dc93501b1ce");
            FxObj = HSViewer.AddPlayMakerFSMAudioClip(FxObj,true);
            FxObj = HSViewer.LoadSoundDefForSpellObj(FxObj);
            FlipFxs.Add(null);//free
            FlipFxs.Add(null);//common
            FlipFxs.Add(FxObj.transform.GetChild(4).GetChild(1).gameObject);//rare
            FlipFxs.Add(FxObj.transform.GetChild(2).GetChild(1).gameObject);//epic
            FlipFxs.Add(FxObj.transform.GetChild(3).GetChild(1).gameObject);//legendary
            FlipFxs.Add(null);
            FlipFxs.Add(null);
            FlipFxs.Add(null);
            PackFxObj = HSViewer.GetHSprefab("PackOpeningFX_ICC.prefab:49a143909a35dbb4787d424766e3128e");
            //PackFxObj = HSViewer.AddPlayMakerFSMAudioClip(PackFxObj,true);
            //PackFxObj = HSViewer.LoadSoundDefForSpellObj(PackFxObj);
        }
        CenterPos=Vector3.zero;
        foreach(Transform t in cardsSlot)
        {
            CenterPos+=t.position;
        }
        CenterPos/=5f;
        CenterPos+=new Vector3(0f,3f,0f);
        
        //GameObject fxins = GameObject.Instantiate(FxObj, Vector3.zero, Quaternion.Euler(Vector3.zero)) as GameObject;
    }

    public void Update()
    {
        if(PackText!=null)
        {
            PackText.text = UserDbf.LoggedUser.PackNums[0].ToString();
        }
    }

    public void OpenPack()
    { 
        //PackOpenAudSrc.Play();
        GameObject PackFxIns=null;
        if(PackFxObj!=null)
        {
            PackFxIns = GameObject.Instantiate(PackFxObj, PackOpenFxPos.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            //PackFxIns.SetActive(true);
            PackFxIns.transform.SetParent(PackAniScaler.transform);
            PackFxIns.transform.localScale= new Vector3(0.3f,0.3f,0.3f);
            Spell sp = PackFxIns.GetComponent<Spell>();
            sp.m_fsm = PackFxIns.GetComponent<PlayMakerFSM>();
            if(sp.m_fsm!=null)
            {
                sp.m_fsm.SendEvent("Death");
                sp.m_fsm.SendEvent("Action");
                sp.m_fsm.SendEvent("Birth");                   
            }     

            foreach(Collider c in PackFxIns.GetComponentsInChildren<Collider>())
            {
                c.enabled=false;    
            }      
        }

        if(UserDbf.LoggedUser.PackNums[0]<=0 || this.IsOpeningPack==true)
        {
            return;
        }
        else
        {
            UserDbf.LoggedUser.PackNums[0]-=1;
            this.IsOpeningPack=true;
        }

        cardsToOpen.Clear();
        if(RandomCards)
        {
            for(int i =0;i<cardsSlot.Count;i++)
            {
                cardsToOpen.Add(CardDbf.AllCardDbf.Choice());
            }
        }
        else{
            foreach(string s in cardsToOpenID)
            {
                cardsToOpen.Add(CardDbf.AllCardDbf.Last());//GetCardDbfByGuid(s));
            }
        }

        Sequence Delay = DOTween.Sequence();
        Delay.AppendInterval(2.3f);
        Delay.OnComplete(()=>{
            for(int i =0; i<cardsToOpen.Count; i++)
            {
                //UserDbf.LoggedUser.CardCollectionNums[cardsToOpen[i].DbfId]+=1;
                CreateAOpenCardAtPosition(cardsToOpen[i],cardsSlot[i].position,new Vector3(0f,0f,180f));
            }
            UnityEngine.Object.Destroy(PackFxIns,5f);
        });
    }

    public void DoneOpen()
    {
        this.IsOpeningPack=false;
        foreach (GameObject c in cardsObj)
        {
            Destroy(c);
        }
        cardsObj.Clear();
        doneBtn.SetActive(false);
    }

    GameObject CreateAOpenCardAtPosition(CardDbf c, Vector3 position, Vector3 eulerAngles)
    {
        //eulerAngles = new Vector3(180f,0f,0f);

        GameObject card = GameObject.Instantiate(OneSceneManager.Instance.CardPrefabs[(int)c.CardType], CenterPos, Quaternion.Euler(eulerAngles)) as GameObject;

        card.transform.DOMove(position,1f);

        OneActorManager manager = card.GetComponent<OneActorManager>();
        manager.UpdateAsset(c);
        manager.CardNameText.enabled=true;
        manager.CardDescriptionText.enabled=true;
        cardsObj.Add(card);

        AudioSource au = card.GetComponentInChildren<AudioSource>();
        Destroy(au);
        HoverPreview pv = card.GetComponentInChildren<HoverPreview>();
        pv.TargetPosition = new Vector3(0f, 0f, 0f);
        pv.TargetScale = 1.4f;
        HoverPreview.PreviewsAllowed = false;
        Draggable dg = card.GetComponentInChildren<Draggable>();
        Destroy(dg);
        Destroy(pv);
        card.transform.localScale = new Vector3(1.4f, 1.4f, 1.4f);
        pv.gameObject.AddComponent<RevealCardClick>();
        RevealCardClick click = pv.gameObject.GetComponentInChildren<RevealCardClick>();
        click.ViewCardIndex = cardsObj.Count - 1;
        click.mag = this;
        return card;
    }

    public void RevealCard(int index)
    {
        GameObject card = cardsObj[index];
        GameObject CardFlipFx = FlipFxs[(int)cardsToOpen[index].RareType];
        if(CardFlipFx!=null)
        {
            GameObject CardFlipFxIns = GameObject.Instantiate(CardFlipFx, card.transform.position+new Vector3(1.3f,3f,1f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            CardFlipFxIns.SetActive(true);
            OpenPackManager.NormalizeVFX(CardFlipFxIns);            
        }

        card.transform.DORotate(new Vector3(0f,0f,0f),1f);
        card.transform.DOMove(card.transform.position+new Vector3(0f,1f,0f),1f);
        AnnouncerSources[index].clip = AnnouncerClips[(int)cardsToOpen[index].RareType];
        AnnouncerSources[index].Play();
        bool done = true;
        foreach (GameObject c in cardsObj)
        {
            if (c.GetComponentInChildren<RevealCardClick>().revealed == false)
            {
                done = false;
            }
        }
        if (done)
        {
            HoverPreview.PreviewsAllowed = true;
            doneBtn.SetActive(true);
        }
    }


    public static GameObject NormalizeVFX(GameObject summonins)
    {
        summonins.transform.localScale= new Vector3(0.3f,0.3f,0.3f);
        /*
        Spell sp = summonins.GetComponent<Spell>();
        
        if(sp!=null)
        {
            sp.m_fsm = summonins.GetComponent<PlayMakerFSM>();

            if(sp.m_fsm!=null)
            {
                sp.m_fsm.SendEvent("Cancel");
                sp.m_fsm.SendEvent("Action");
                sp.m_fsm.SendEvent("Birth");                   
            }
        }
        */
        

        
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
                t.gameObject.GetComponent<AudioSource>().enabled=true;
                t.gameObject.GetComponent<AudioSource>().Play();
            }
            if(t.gameObject.GetComponent<Collider>()!=null)
            {
                t.gameObject.GetComponent<Collider>().enabled=false;
            }
        }
        
        float Dur=0f;

        foreach(ParticleSystemRenderer psr in summonins.GetComponentsInChildren<ParticleSystemRenderer>())
        {
            psr.enabled=true;
        }
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
        return summonins; 
    }
}