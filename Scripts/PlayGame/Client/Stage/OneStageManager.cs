using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine.Audio;
using UnityEngine.UI;

public enum AreaPosition
{
    Low,
    Top,
}
public class OneStageManager : MonoBehaviour
{
    public CcgAgent MyDLAgent;
    public AreaPosition owner;
    public OneStageManager otherStage;
    public bool ControledByAi = false;
    public TextMeshProUGUI ManaText;
    public List<Transform> DeckBound;
    public List<Transform> HandBound;
    public List<Transform> BoardBound;
    public List<Transform> GraveBound;
    public List<Transform> HeadBound;
    public List<Transform> HeroBound;
    public List<Transform> PowerBound;
    public List<Transform> WeaponBound;
    public List<Transform> RemovedBound;
    public List<Transform> AsideBound;
    public List<Transform> MinionPowerBound;
    public List<Transform> BoardLeftBound;
    public List<Transform> BoardRightBound;
    public List<Transform> SiteBound;
    public List<List<Transform>> ZoneBounds;

    public List<List<GameObject>> Zones = new List<List<GameObject>>
    {
        new List<GameObject>(),new List<GameObject>(),new List<GameObject>(),
        new List<GameObject>(),new List<GameObject>(),new List<GameObject>(),
        new List<GameObject>(),new List<GameObject>(),new List<GameObject>(),
        new List<GameObject>(),new List<GameObject>(),new List<GameObject>(),
        new List<GameObject>(),new List<GameObject>(),
    };
    public TextMeshProUGUI DeckCounter;
    public GameObject EmoteBubble;
    public List<AudioClip> EmoteAudioClips;
    public List<string> EmoteTexts;
    public List<GameObject> EmoteChoicePlane;
    public OneActorManager HeroActor;
    public CardDbf HeroAsset;
    public GameObject NarratorPlane;
    private bool IsEmoting = false;
    private int updatetime = 0;

    public int GetFxId(string fxname)
    {
        int fxid = -1;
        switch (fxname)
        {
            case ("Taunt"):
                fxid = 1;
                break;
            case ("Poisonous"):
                fxid = 2;
                break;
            case ("Toxic"):
                fxid = 2;
                break;
            case ("DivineShield"):
                fxid = 3;
                break;
                break;
            case ("DivineShieldPro"):
                fxid = 3;
                break;
            case ("Deathrattle"):
                fxid = 4;
                break;
            case ("Frozen"):
                fxid = 5;
                break;
            case ("Elusive111"):
                fxid = 6;
                break;
            case ("Silent"):
                fxid = 7;
                break;
            case ("WindFury111"):
                fxid = 8;
                break;
            case ("WindFuryPro111"):
                fxid = 8;
                break;
            case ("Immue"):
                fxid = 5;
                break;
            default:
                break;
        }
        return fxid;
    }
    public void GiveActorAttachment(int ActorId, CardDbf asst, int assId)
    {
        GameObject powactor = GameObject.Instantiate(OneSceneManager.Instance.CardPrefabs[(int)CardType.HeroPower], new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
        OneActorManager powmanager = powactor.GetComponent<OneActorManager>();
        powmanager.ControlBy = owner;
        powmanager.m_ActorTargetOpts = asst.Targets;
        powmanager.UpdateAsset(asst, ZoneType.MinionPower);

        IDHolder.AddGameObjectWithID(powactor, assId);
        foreach (Transform t in powactor.GetComponentsInChildren<Transform>())
            t.tag = owner.ToString() + ZoneType.MinionPower.ToString();
        powactor.SetActive(false);

        GameObject actor = IDHolder.GetGameObjectWithID(ActorId);
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        if(asst.Targets!=TargetingOptions.NoTarget)
        {
            manager.DragNoTarget.SetActive(true);
            manager.DragOnTarget.SetActive(false);
            GameObject NoTarget = manager.DragNoTarget;
            NoTarget.GetComponent<Draggable>().enabled = false;
            powactor.transform.parent = NoTarget.transform;
            DragMinionBuySell buysell = NoTarget.GetComponent<DragMinionBuySell>();
            if (buysell != null)
            {
                Destroy(buysell);
            }
            MinionPowerPlane Plane = NoTarget.GetComponent<MinionPowerPlane>();
            if (Plane == null)
            {
                Plane = NoTarget.AddComponent<MinionPowerPlane>();
            }
            
            Plane.powerList.Add(powactor);
        }
        else{
            manager.DragNoTarget.SetActive(true);
            manager.DragOnTarget.SetActive(false);
            GameObject NoTarget = manager.DragNoTarget;
            NoTarget.GetComponent<Draggable>().enabled = false;
            powactor.transform.parent = NoTarget.transform;
            DragMinionBuySell buysell = NoTarget.GetComponent<DragMinionBuySell>();
            if (buysell != null)
            {
                Destroy(buysell);
            }
            MinionPowerPlane Plane = NoTarget.GetComponent<MinionPowerPlane>();
            if (Plane == null)
            {
                Plane = NoTarget.AddComponent<MinionPowerPlane>();
            }
            
            Plane.powerList.Add(powactor);
        }
        




        Command.CommandExecutionComplete();
    }
    public void RemoveActorAttachment(int ActorId, int assid)
    {
        GameObject actor = IDHolder.GetGameObjectWithID(ActorId);
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        GameObject NoTarget = manager.DragNoTarget;
        MinionPowerPlane Plane = NoTarget.GetComponent<MinionPowerPlane>();
        if (Plane == null)
        {
        }
        else
        {
            for (int i = Plane.powerList.Count - 1; i >= 0; i--)
            {
                if (Plane.powerList[i].GetComponent<IDHolder>().UniqueID == assid)
                {
                    Plane.powerList[i].SetActive(false);
                    Plane.powerList.RemoveAt(i);
                    break;
                }
            }
        }
        Command.CommandExecutionComplete();
    }

    public void GiveActorFx(int ActorId, string fxname)
    {
        GameObject actor = IDHolder.GetGameObjectWithID(ActorId);
        if(actor!=null)
        {
            OneActorManager manager = actor.GetComponent<OneActorManager>();
            int fxid = GetFxId(fxname);
            if (fxid >= 0 && fxid < manager.Fx.Count)
                manager.Fx[fxid].SetActive(true);
            if(fxname=="Frozen")
            {
                manager.ActiveFrozenVfx();
            }
            if(fxname=="Immue")
            {
                manager.ActiveImmueVfx();
            }
            if(fxname=="Stealth")
            {
                manager.ActiveStealthVfx();
            }
            if(fxname=="WindFury")
            {
                manager.ActiveWindFuryVfx();
            }            
        }

        Command.CommandExecutionComplete();
    }
    public void RemoveActorFx(int ActorId, string fxname)
    {
        GameObject actor = IDHolder.GetGameObjectWithID(ActorId);
        if(actor!=null)
        {
            OneActorManager manager = actor.GetComponent<OneActorManager>();
            int fxid = GetFxId(fxname);
            if (fxid >= 0 && fxid < manager.Fx.Count)
                manager.Fx[fxid].SetActive(false);
            if(fxname=="Frozen")
            {
                manager.DeActiveFrozenVfx();
            }
            if(fxname=="Immue")
            {
                manager.DeActiveImmueVfx();
            }
            if(fxname=="Stealth")
            {
                manager.DeActiveStealthVfx();
            }
            if(fxname=="WindFury")
            {
                manager.DeActiveWindFuryVfx();
            }
        }
        Command.CommandExecutionComplete();
    }
    public void MorphActorToAsset(int ActorId, ZoneType ActorZone, CardDbf NewAsset)
    {
        IDHolder.GetGameObjectWithID(ActorId).GetComponent<OneActorManager>().UpdateAsset(NewAsset, ActorZone);
        Command.CommandExecutionComplete();
    }
    public void ChangeActorAsset(int ActorId, ZoneType ActorZone, CardDbf NewAsset)
    {
        //IDHolder.GetGameObjectWithID(ActorId).GetComponent<OneActorManager>().Portait.material.SetTexture("_BaseMap", NewAsset.CardImage.texture);//UpdateAsset(NewAsset,ActorZone);
    }
    public GameObject CreateActorAtZone(int ActorId, ZoneType TargetZone, CardDbf ActorAsset, int targetIndex = -1, PremiumType ActorPremium = PremiumType.Normal, int TargetOPT=0, bool IsAuraActor=false, bool IsTriggerActor=false)
    {

        List<Vector3> RightTransform = null;
        if (targetIndex == -1)
        {
            RightTransform = GetTransformForZone(TargetZone, Zones[(int)TargetZone].Count - 1,BoundNumFake:1);
        }
        else
        {
            RightTransform = GetTransformForZone(TargetZone, targetIndex,BoundNumFake:1);
        }

        GameObject actor = GameObject.Instantiate(OneSceneManager.Instance.CardPrefabs[(int)ActorAsset.CardType], RightTransform[0], Quaternion.Euler(RightTransform[1])) as GameObject;
        OneActorManager manager = actor.GetComponent<OneActorManager>();


        if (ActorAsset.CardType == CardType.Hero && TargetZone==ZoneType.Hero)
        {
            HeroAsset=ActorAsset;
            HeroActor = manager;
            /*
            for (int i = 0; i < ActorAsset.CustomEmoteAudioClips.Count; i++)
            {
                EmoteAudioClips[i] = ActorAsset.CustomEmoteAudioClips[i];
                string dst = "";
                for (int j = 0; j < ActorAsset.CustomEmoteTexts[i].Length; j++)
                {
                    dst += ActorAsset.CustomEmoteTexts[i][j];
                    if (j % 1 == 0)
                    {
                        dst += " ";
                    }
                }
                EmoteTexts[i] = dst;
            }
            */
        }
        if(!OneSceneManager.Instance.IsMyScene)
        {
            if(IsAuraActor)
            {
                float d;
                (manager.AuraVfxObject,d) = manager.GetHSSpellTableVfxIns(SpellType.AURA,AutoDestroy:false);
                manager.AuraVfxObject.SetActive(false);
                manager.AuraVfxObject.transform.parent = manager.Actor.transform;
                manager.AuraVfxObject.transform.localPosition = Vector3.zero;
            }
            if(IsTriggerActor)
            {
                float d;
                (manager.TriggerVfxObject,d) = manager.GetHSSpellTableVfxIns(SpellType.TRIGGER,AutoDestroy:false);
                manager.TriggerVfxObject.transform.parent = manager.Actor.transform;
                manager.TriggerVfxObject.transform.localPosition = new Vector3(0.038f,0.0937f,-0.414f);
                manager.TriggerVfxObject.transform.localRotation = Quaternion.Euler(Vector3.zero);
            }

            if(true)
            {
                float d;
                (manager.FrozenVfxObject,d) = manager.GetHSSpellTableVfxIns(SpellType.FROZEN,AutoDestroy:false,cty:ActorAsset.CardType,zty:(ActorAsset.CardType==CardType.Hero ? ZoneType.Hero : ZoneType.Board));
                if(manager.FrozenVfxObject!=null)
                {
                    manager.FrozenVfxObject.SetActive(false);
                    manager.FrozenVfxObject.transform.parent = manager.Actor.transform;
                    manager.FrozenVfxObject.transform.localPosition = Vector3.zero;  
                }          
            }
            if(true)
            {
                float d;
                (manager.ImmueVfxObject,d) = manager.GetHSSpellTableVfxIns(SpellType.IMMUNE,AutoDestroy:false,cty:ActorAsset.CardType,zty:(ActorAsset.CardType==CardType.Hero ? ZoneType.Hero : ZoneType.Board));
                if(manager.ImmueVfxObject!=null)
                {
                    manager.ImmueVfxObject.SetActive(false);
                    manager.ImmueVfxObject.transform.parent = manager.Actor.transform;
                    manager.ImmueVfxObject.transform.localPosition = Vector3.zero;
                }          
            }
            if(true)
            {
                float d;
                (manager.StealthVfxObject,d) = manager.GetHSSpellTableVfxIns(SpellType.STEALTH,AutoDestroy:false,cty:ActorAsset.CardType,zty:(ActorAsset.CardType==CardType.Hero ? ZoneType.Hero : ZoneType.Board));
                if(manager.StealthVfxObject!=null)
                {
                    manager.StealthVfxObject.SetActive(false);
                    manager.StealthVfxObject.transform.parent = manager.Actor.transform;
                    manager.StealthVfxObject.transform.localPosition = Vector3.zero;            
                }
            }
            if(true)
            {
                float d;
                (manager.WindFuryVfxObject,d) = manager.GetHSSpellTableVfxIns(SpellType.WINDFURY_IDLE,AutoDestroy:false,cty:ActorAsset.CardType,zty:(ActorAsset.CardType==CardType.Hero ? ZoneType.Hero : ZoneType.Board));
                if(manager.WindFuryVfxObject!=null)
                {
                    manager.WindFuryVfxObject.SetActive(false);
                    manager.WindFuryVfxObject.transform.parent = manager.Actor.transform;
                    manager.WindFuryVfxObject.transform.localPosition = Vector3.zero;            
                }
            }            
        }

        manager.m_ActorTargetOpts = (TargetingOptions)TargetOPT;

        manager.ControlBy = owner;
        manager.UpdateAsset(ActorAsset, TargetZone, ActorPremium: ActorPremium);
        IDHolder.AddGameObjectWithID(actor,ActorId);

        foreach (Transform t in actor.GetComponentsInChildren<Transform>())
            t.tag = owner.ToString() + TargetZone.ToString();

        if (targetIndex == -1 || targetIndex >= Zones[(int)TargetZone].Count)
        {
            Zones[(int)TargetZone].Add(actor);
        }
        else
        {
            Zones[(int)TargetZone].Insert(targetIndex, actor);
        }

        switch (TargetZone)
        {
            case (ZoneType.Deck):
                Command.CommandExecutionComplete();
                //VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.SpawnCard);
                break;
            case (ZoneType.Hand):
                VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.SpawnCard);
                break;
            case (ZoneType.Board):
                VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.SpawnMinion);
                break;
            case (ZoneType.Hero):
                manager.ActingTargetPosition = RightTransform[0];
                VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.SpawnHero);
                break;
            case (ZoneType.Weapon):
                VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.SpawnWeapon);
                break;
            case (ZoneType.Power):
                VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.SpawnWeapon);
                break;
            default:
                Command.CommandExecutionComplete();
                break;
        }
        if (ActorAsset.m_noteMiniGuid == "DefaultFatigue")
        {
            manager.UpdateAsset(ActorAsset, ZoneType.Grave, ActorPremium: ActorPremium);
        }
        return actor;
    }
    
    public void ChangeActorToZone(int ActorId, ZoneType TargetZone, ZoneType SourceZone, int targetIndex = -1, int ToEn = 0)
    {
        GameObject actor = IDHolder.GetGameObjectWithID(ActorId);
        List<GameObject> sZone = Zones[(int)SourceZone];
        List<GameObject> tZone;
        if (ToEn!=0)
        {
            actor.GetComponent<OneActorManager>().ControlBy = (AreaPosition) (((int)owner+1)%2);
            tZone = otherStage.Zones[(int)TargetZone];
        }
        else
        {
            tZone = Zones[(int)TargetZone];
            actor.GetComponent<OneActorManager>().ControlBy = owner;
        }
        if (TargetZone == ZoneType.Grave)
        {
        //    UnityEngine.Object.Destroy(actor, 10f);
        }
        sZone.Remove(actor);
        
        List<Vector3> RightTransform = null;
        if (targetIndex == -1)
        {
            tZone.Add(actor);
            RightTransform = GetTransformForZone(TargetZone, Zones[(int)TargetZone].Count - 1);
        }
        else
        {
            tZone.Insert(targetIndex, actor);
            RightTransform = GetTransformForZone(TargetZone, targetIndex);
        }
        
        actor.GetComponent<OneActorManager>().UpdateAssetForZone(TargetZone);
        foreach (Transform t in actor.GetComponentsInChildren<Transform>())
            t.tag =  actor.GetComponent<OneActorManager>().ControlBy.ToString() + TargetZone.ToString();

        if (TargetZone == ZoneType.Grave)
        {
            switch (SourceZone)
            {
                case (ZoneType.Hand):
                    if(actor.GetComponent<OneActorManager>().CardDbf.CardType==CardType.Spell)
                    {
                        if (actor.GetComponent<OneActorManager>().CustomSummonAudioSource != null)
                        {
                            actor.GetComponent<OneActorManager>().CustomSummonAudioSource.Play();
                        }
                    }
                    VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.DieCard);
                    break;
                case (ZoneType.Head):
                    VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.DieCard);
                    break;
                case (ZoneType.Board):
                    VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.DieMinion);
                    break;
                case (ZoneType.Hero):
                    VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.DieHero);
                    break;
                case (ZoneType.Aside):
                    VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.DieCard);
                    break;
                case (ZoneType.Deck):
                    VfxBase.CreateDeckToGraveFx(ActorId);
                    break;
                default:
                    VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.DieWeapon);
                    break;
            }
            UnityEngine.Object.Destroy(actor,60f);
        }
        else if (TargetZone == ZoneType.Hero)
        {
            switch (SourceZone)
            {
                case (ZoneType.Hand):
                    actor.GetComponent<OneActorManager>().ActingTargetPosition = RightTransform[0];
                    VfxBase.CreateVfx(ActorId, new List<int>() { ActorId }, null, vfxType: VfxType.SpawnHero);
                    break;
                default:
                     Command.CommandExecutionComplete();
                    break;
            }
        }
        else if (TargetZone == ZoneType.Board)
        {
            switch (SourceZone)
            {
                case (ZoneType.Hand):
                    VfxBase.CreateHandToBoardFx(ActorId, RightTransform);
                    break;
                case (ZoneType.Deck):
                    VfxBase.CreateHandToBoardFx(ActorId, RightTransform);
                    break;
                default:
                    Command.CommandExecutionComplete();
                    break;
            }
        }
        else if (TargetZone == ZoneType.Weapon)
        {
            switch (SourceZone)
            {
                case (ZoneType.Hand):
                    VfxBase.CreateHandToBoardFx(ActorId, RightTransform);
                    break;
                case (ZoneType.Deck):
                    VfxBase.CreateHandToBoardFx(ActorId, RightTransform);
                    break;
                default:
                    Command.CommandExecutionComplete();
                    break;
            }
        }
        else if (TargetZone == ZoneType.Hand)
        {
            switch (SourceZone)
            {
                case (ZoneType.Deck):
                    VfxBase.CreateDeckToHandFx(ActorId);
                    break;
                case (ZoneType.Board):
                    VfxBase.CreateBoardToHandFx(ActorId, RightTransform);
                    break;
                default:
                    Command.CommandExecutionComplete();
                    break;
            }
        }
        else if(TargetZone==ZoneType.Removed)
        {
            UnityEngine.Object.Destroy(actor,60f);
            Command.CommandExecutionComplete();
        }
        else
        {
            Command.CommandExecutionComplete();
        }
    }

    public void Awake()
    {
        ZoneBounds = new List<List<Transform>> {
            DeckBound,HandBound,BoardBound,
            GraveBound,HeadBound,HeroBound,
            PowerBound,WeaponBound,RemovedBound,
            AsideBound,MinionPowerBound,
            BoardLeftBound,BoardRightBound,SiteBound,
        };
    }
    public void ScaleHand()
    {
        if (HandBound[0].position.y == 2f)
        {
            HandBound[0].transform.position = new Vector3(1.2f, 1f, -1.5f);
            HandBound[1].transform.position = new Vector3(2.4f, 1.3f, -1.5f);
        }
        else
        {
            HandBound[0].transform.position = new Vector3(-1.25f, 2f, -1.1f);
            HandBound[1].transform.position = new Vector3(1.25f, 2.3f, -1.1f);
        }
    }
    public void ScaleHandPC()
    {
        if(owner == AreaPosition.Low)
        {
            HandBound[0].transform.position = new Vector3(-1f, 0f, -2.5f);
            HandBound[1].transform.position = new Vector3(1f, 0.3f, -2.5f);            
        }
        else
        {
            HandBound[0].transform.position = new Vector3(-1f, 0f, 2.5f);
            HandBound[1].transform.position = new Vector3(1f, 0.3f, 2.5f); 
        }

    }
    public void Update()
    {
        DeckCounter.text = (Zones[(int)ZoneType.Deck].Count-1).ToString();

        if (Input.GetKeyDown(KeyCode.H) && owner == AreaPosition.Low)
        {
            ScaleHand();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            ScaleHandPC();
        }
        if (Input.GetKeyDown(KeyCode.Z) && owner == AreaPosition.Low)
        {
            //PlayEmote(EmoteType.Greeting);
        }
        if (Input.GetKeyDown(KeyCode.X) && owner == AreaPosition.Low)
        {
            //PlayEmote(EmoteType.WellPlayed);
        }
        if (Input.GetKeyDown(KeyCode.C) && owner == AreaPosition.Low)
        {
            //PlayEmote(EmoteType.Opps);
        }
        if (Input.GetMouseButtonDown(1) && owner == AreaPosition.Low)
        {
            ShowEmoteChoicePlane();
        }
        //if(UnityEngine.Random.Range(0,300)==1 && (owner==AreaPosition.Top))
        //{
        //    PlayEmote((EmoteType)UnityEngine.Random.Range(0,6));
        //}

        //if (updatetime % 4 == 0)
        //{
            CorrectActorPosition();
        //}
        updatetime += 1;
        UpdateFakeDragArrow();

    }
    
    public void ShowEmoteChoicePlane()
    {
        foreach (GameObject obj in EmoteChoicePlane)
        {
            obj.SetActive(true);
        }
    }
    public void HideEmoteChoicePlane()
    {
        foreach (GameObject obj in EmoteChoicePlane)
        {
            obj.SetActive(false);
        }
    }
    public void PlayeGreetingEmote() { PlayEmote(EmoteType.GREETINGS); }
    public void PlayeSurprisedEmote() { PlayEmote(EmoteType.WOW); }
    public void PlayeWellPlayedEmote() { PlayEmote(EmoteType.WELL_PLAYED); }
    public void PlayeOppsEmote() { PlayEmote(EmoteType.OOPS); }
    public void PlayeThanksEmote() { PlayEmote(EmoteType.THANKS); }
    public void PlayeThreatenEmote() { PlayEmote(EmoteType.THREATEN); }
    public void PlayEmote(EmoteType emoType = EmoteType.INVALID)
    {
        if (IsEmoting)
        {
            return;
        }
        if (owner == AreaPosition.Low)
        {
            HideEmoteChoicePlane();
        }
        IsEmoting = true;
        int emoteIndex = (int)emoType;
        if(emoteIndex<HeroActor.MythicEmoteAudClips.Count && emoteIndex<HeroActor.MythicEmoteTexts.Count)
        {
            /*
            Animator animator = HeroActor.MythicOffScreenInstance.transform.GetChild(0).GetChild(0).GetComponent<Animator>();
            if(animator!=null)
            {
                animator.SetTrigger("Start");
                animator.SetTrigger("Emote");
            }
            */
            CreateEmoteAtPosition(HeroActor.gameObject, HeroActor.MythicEmoteTexts[emoteIndex],1f, emoType, aud:HeroActor.MythicEmoteAudClips[emoteIndex],IsCMD:false);


            /*
            EmoteBubble.GetComponentInChildren<Text>().text = dst;
            EmoteBubble.SetActive(true);
            EmoteBubble.GetComponent<AudioSource>().Play();  


            Sequence s = DOTween.Sequence();
            s.AppendInterval(EmoteBubble.GetComponent<AudioSource>().clip.length);
            s.Insert(0f, EmoteBubble.transform.DOScale(new Vector3(1f, 1f, 1f), 1f)).SetEase(Ease.OutBack);
            s.OnComplete(() => {
                EmoteBubble.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 0.5f).SetEase(Ease.InExpo).OnComplete(() => {
                    EmoteBubble.SetActive(false);
                    IsEmoting = false;
                });
            });
            */
        }

    }
    public void CorrectActorPosition()
    {
        for (int z_i = 0; z_i < Zones.Count; z_i++)
        {
            if (z_i == (int)ZoneType.Grave || z_i==(int)ZoneType.Removed)
            {
                continue;
            }

            List<GameObject> SingleZone = Zones[z_i];
            for (int a_i = 0; a_i < SingleZone.Count; a_i++)
            {
                GameObject actor = SingleZone[a_i];
                OneActorManager manager = actor.GetComponent<OneActorManager>();
                /*
                if (z_i == (int)ZoneType.Hand)
                {
                    MeshRenderer[] meshs = actor.GetComponentsInChildren<MeshRenderer>();
                    for (int i = 0; i < meshs.Length; i++)
                    {
                        Debug.Log(meshs[i].sortingLayerName);
                        Debug.Log(meshs[i].sortingOrder.ToString());
                        meshs[i].sortingLayerName = "default";
                        meshs[i].sortingOrder = a_i+1;
                        meshs[i].material.renderQueue = -2000*a_i + 3000;//rendererPriority = a_i + 1;
                        Debug.Log(meshs[i].sortingOrder.ToString());
                    }
                }
                */
                if (manager.IsActing)
                {
                    //continue;
                }
                else
                {

                    List<Vector3> RightTransform = GetTransformForZone((ZoneType)z_i, a_i);
                    float distance = Vector3.Distance(RightTransform[0],actor.transform.position);
                    actor.transform.localScale = RightTransform[2];
                    float th = 0.1f;
                    if(Game.NowGame.m_Mode==GameMode.BattleGround)
                    {
                        th=0.1f;
                    }
                    if(distance<th)
                    {
                        actor.transform.position=RightTransform[0];
                        actor.transform.rotation=Quaternion.Euler(RightTransform[1]);
                    }
                    else{
                        manager.IsActing = true;
                        //actor.transform.DOScale(RightTransform[2],0.297f);
                        actor.transform.DORotateQuaternion(Quaternion.Euler(RightTransform[1]), 0.297f).SetEase(Ease.OutExpo);//DORotate(rotation = Quaternion.Euler(RightTransform[1]));
                        actor.transform.DOMove(RightTransform[0], 0.297f).SetEase(Ease.OutExpo).OnComplete(() =>
                        {
                            manager.IsActing = false;
                        });
                    }
                }

            }
        }
    }

    public List<float> GetAllXForZone(ZoneType TargetZone)
    {
        List<float> allX = new List<float>();
        for (int i = 0; i < Zones[(int)TargetZone].Count; i++)
        {
            allX.Add(GetTransformForZone(TargetZone, i)[0][0]);
        }
        return allX;
    }
    public int GetIndexForActor(int ActorId, ZoneType TargetZone)
    {
        return Zones[(int)TargetZone].IndexOf(IDHolder.GetGameObjectWithID(ActorId));
    }
    public List<Vector3> GetTransformForZone(ZoneType TargetZone, int TargetIndex, int BoundNumFake = 0)
    {
        List<Vector3> newtransform = new List<Vector3>();
        List<Transform> Bound = ZoneBounds[(int)TargetZone];
        int N = Zones[(int)TargetZone].Count+BoundNumFake;
        if(TargetZone == ZoneType.Board)
        {
            if(N>7)
            {
                N=7;
            }
        }
        float y = Bound[0].position.y + (Bound[1].position.y - Bound[0].position.y) / (N + 1) * TargetIndex;
        float z = Bound[0].position.z;//+(Bound[1].position.z-Bound[0].position.z)/(N+1)*TargetIndex;
        float minx = Bound[0].position.x;
        float maxx = Bound[1].position.x;
        float cx = (minx + maxx) / 2f;
        float bw = (maxx - minx);
        float c2 = bw / 6f;
        float c1 = -c2 / 2f;

        Vector3 newpos = new Vector3(0f, y, z);
        newpos.x = cx + c1 * (N - 1) + c2 * TargetIndex;
        Vector3 newrot = new Vector3(0f, 0f, 0f);//Bound[0].rotation.eulerAngles.x, Bound[0].rotation.eulerAngles.y, Bound[0].rotation.eulerAngles.z);
        Vector3 newsize = new Vector3(1f,1f,1f);
        if (TargetZone == ZoneType.Aside)
        {
            if (owner == AreaPosition.Top)
            {
                newrot.x = 180f;
            }
        }
        if(TargetZone == ZoneType.Board &&Game.NowGame.m_Mode==GameMode.BattleGround && false)
        {
            float t = 4*(float)OneSceneManager.Instance.GameTick/30f;
            float boardn = (float)Zones[(int)TargetZone].Count+1;
            float nsize = 0.7f;//0.4f;
            float ind = (float) TargetIndex;
            if (owner == AreaPosition.Top)
            {
                newpos = ZoneTransformVariants.GetBattleGroundTopCurve(t,ind,boardn);
                //nsize=5f;
            }
            else
            {
                newpos = ZoneTransformVariants.GetBattleGroundDownCurve(t,ind,boardn);
            }
            newsize.x=nsize;
            newsize.y=nsize;
            newsize.z=nsize;
        }
        if (TargetZone == ZoneType.Hand)
        {
            float MaxAngle = 45f;
            float ZoffsetEff = 1f;
            if (N <= 3)
            {
                MaxAngle = 0f;
                ZoffsetEff = 0f;
            }
            if (owner == AreaPosition.Top)
            {
                newrot.x = 180f;
                newrot.y = -(newpos.x - cx) / bw * MaxAngle;
                newpos.z += ZoffsetEff*Mathf.Abs(TargetIndex - (N - 1) / 2f) * 0.04f;
            }
            else
            {

                newrot.y = (newpos.x - cx) / bw * MaxAngle;
                newpos.z -= ZoffsetEff*Mathf.Abs(TargetIndex - (N - 1) / 2f) * 0.04f;
            }
        }

        if (TargetZone == ZoneType.Deck)
        {
            newrot.x = Bound[0].eulerAngles.x;//180f;
            newrot.y = Bound[0].eulerAngles.y;//270f;
            newrot.z = Bound[0].eulerAngles.z;//360f;
        }

        if(TargetZone == ZoneType.Hero)
        {
            if(TargetIndex==1)
            {
                //newpos.x+=1f;
                //newpos.y+=-0.2f;
            }
        }
        if (TargetIndex == -1)
        {
            TargetIndex = N - 1;
        }

        newtransform.Add(newpos);
        newtransform.Add(newrot);
        newtransform.Add(newsize);
        return newtransform;
    }


    public bool AllowedToControlThisPlayer
    {
        get;
        set;
    }

    public void UpdateManaPool(int avaiable, int max)
    {
        ManaText.text = avaiable.ToString();//string.Format("{0}/{1}", avaiable.ToString(), max.ToString());
        Command.CommandExecutionComplete();
    }

    public void UpdateFakeDragArrow()
    {
        if (FakeDragSource == null)
        {
            return;
        }
        float Eff = Mathf.Sqrt((float)FakeDragFrame / 20f);
        Vector3 Position = new Vector3(0f, 1f, 0f) + FakeDragSource.transform.position + Eff * (FakeDragTarget.transform.position+new Vector3(0f,0.05f,0f) - FakeDragSource.transform.position);
        FakeDragAction.SetPositions(FakeDragSource.transform.position, Position * 2 - FakeDragSource.transform.position);
        FakeDragFrame += 1;
        if (FakeDragFrame >= 20)
        {
            FakeDragFrame = 20;
        }
    }
    private GameObject FakeDragSource = null;
    private GameObject FakeDragTarget = null;
    private DraggingActions FakeDragAction = null;
    private int FakeDragFrame = 3;
    
    public void CloseWeapon()
    {
        foreach(GameObject weap in this.Zones[(int)ZoneType.Weapon])
        {
            OneActorManager mgr = weap.GetComponent<OneActorManager>();
            if(mgr!=null)
            {
                mgr.ClosePortait();
            }
        }
        Command.CommandExecutionComplete();
    }
    public void RestoreHeroBtn()
    {
        foreach(GameObject pow in this.Zones[(int)ZoneType.Power])
        {
            HeroPowerButton btn = pow.GetComponentInChildren<HeroPowerButton>();
            if(btn!=null)
            {
                btn.FlipFront();
            }
        }
        foreach(GameObject weap in this.Zones[(int)ZoneType.Weapon])
        {
            OneActorManager mgr = weap.GetComponent<OneActorManager>();
            if(mgr!=null)
            {
                mgr.OpenPortait();
            }
        }
        Command.CommandExecutionComplete();
    }
    public void FakeDrag(int sourceID, int targetID = -1)
    {
        
        GameObject source = IDHolder.GetGameObjectWithID(sourceID);
        OneActorManager manager = source.GetComponent<OneActorManager>();
        HeroPowerButton btn = manager.gameObject.GetComponentInChildren<HeroPowerButton>();

        if (targetID == -1)
        {
            if(btn!=null)
            {
                btn.FlipBack();
                Command.CommandExecutionComplete();
            }
            else{
                manager.IsActing = true;
                Sequence s = DOTween.Sequence();
                s.AppendInterval(0f);
                s.Insert(0f, source.transform.DOMove(new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(1f, 2f), UnityEngine.Random.Range(0f, 1f)), 1f).SetEase(Ease.OutExpo));
                s.OnComplete(() =>
                {
                    manager.IsActing = false;
                    Command.CommandExecutionComplete();
                });                
            }
        }
        else
        {
            GameObject target = IDHolder.GetGameObjectWithID(targetID);
            manager.CardDragOnTarget.SetActive(true);
            DraggingActions da = manager.CardDragOnTarget.GetComponent<DraggingActions>();
            FakeDragSource = source;
            FakeDragTarget = target;
            FakeDragAction = da;
            da.Show();
            Sequence s = DOTween.Sequence();
            s.AppendInterval(0.667f);
            s.OnComplete(() =>
            {
                HeroPowerButton btn = manager.gameObject.GetComponentInChildren<HeroPowerButton>();
                if(btn!=null)
                {
                    btn.FlipBack();
                }
                da.Hide();
                FakeDragSource = null;
                FakeDragTarget = null;
                FakeDragAction = null;
                FakeDragFrame = 3;
                manager.CardDragOnTarget.SetActive(false);
                Command.CommandExecutionComplete();
            });
        }
    }

    public void ChangeActorIndex(int ActorId, ZoneType TargetZone, int TargetIndex = -1)
    {
        List<GameObject> tZone = Zones[(int)TargetZone];
        GameObject actor = IDHolder.GetGameObjectWithID(ActorId);
        tZone.Remove(actor);
        if (TargetIndex == -1 || TargetIndex >= tZone.Count)
        {
            tZone.Add(actor);
        }
        else
        {
            tZone.Insert(TargetIndex, actor);
        }
        Command.CommandExecutionComplete();
    }

    public string FillBlank(string rawstr)
    {
        string dst="";
        for(int i=0; i < rawstr.Length;i++)
        {
            if(rawstr[i]!='$' && rawstr[i]!='@' && rawstr[i]!='d')
            {
                dst+=rawstr[i];
                if(i%5==4 && rawstr[i]!='<' && rawstr[i]!='>' && rawstr[i]!='/' && rawstr[i]!='b' && rawstr[i]!='i')
                {
                    dst+=" ";
                }
            }
        }
        return dst;
    }
    public void CreateEmoteAtPosition(GameObject actor, string txt,float dur=1,EmoteType emoType=EmoteType.INVALID,AudioClip aud = null,bool IsCMD=true)
    {
        if(this.EmoteBubble==null)
        {
            if(IsCMD)
                Command.CommandExecutionComplete();
            return;
        }
        if(txt=="狩猎开始了！")
        {
            emoType=EmoteType.START;
            if((int)EmoteType.START < HeroActor.MythicEmoteAudClips.Count)
            {
                aud = HeroActor.MythicEmoteAudClips[(int)EmoteType.START];
                txt = HeroActor.MythicEmoteTexts[(int)EmoteType.START];              
            }

        }
        Vector3 pos = actor.transform.position;
        OneActorManager mgr = actor.GetComponent<OneActorManager>();
        if(mgr!=null)
        {
            if(mgr.MythicOffScreenInstance!=null)
            {
                Animator animator = mgr.MythicOffScreenInstance.transform.GetChild(0).GetChild(0).GetComponent<Animator>();
                if(animator!=null)
                {
                    animator.SetTrigger("Start");
                    animator.SetTrigger("Emote");
                }
            }            
        }

        txt = this.FillBlank(txt);
        if(owner==AreaPosition.Low)
        {
            pos += new Vector3(1f,0.3f,1f);
        }
        else{
            pos += new Vector3(-1f,0.3f,-1f);
        }
        GameObject Emo = GameObject.Instantiate(this.EmoteBubble,pos,Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
        if(Emo!=null)
        {
            if(aud!=null)
            {
                AudioSource audsrc = Emo.AddComponent<AudioSource>();
                audsrc.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("ALoud")[0];
                audsrc.clip = aud;
                audsrc.Play();
                dur = aud.length;
            }
            Emo.SetActive(true);
            Text txPlane = Emo.GetComponentInChildren<Text>();
            txPlane.text = txt; 
            
            Emo.transform.localScale=new Vector3(0f,0f,0f);
            Emo.transform.DOScale(new Vector3(1f,1f,1f),0.3f*Time.timeScale).SetEase(Ease.InBounce);
            Sequence DelaySeq = DOTween.Sequence();
            DelaySeq.AppendInterval(1f*dur);
            DelaySeq.OnComplete(()=>{
                Emo.transform.DOScale(Vector3.zero,1f*Time.timeScale);
                UnityEngine.Object.Destroy(Emo,2f);
                IsEmoting = false;
                if(IsCMD)
                    Command.CommandExecutionComplete();
            });            
        }
        else{
            IsEmoting = false;
            if(IsCMD)
                Command.CommandExecutionComplete();
        }
    }

    public void CreateNarrator(CardDbf db, string txt,float dur)
    {
        dur=Time.timeScale;
        //txt = this.FillBlank(txt);
        Vector3 pos = new Vector3(-0.22f,5f,0.05f);
        if(owner==AreaPosition.Low)
        {
            //pos += new Vector3(0.6f,0.3f,0.6f);
        }
        else{
            //pos += new Vector3(-0.6f,0.3f,-0.6f);
        }
        if(this.NarratorPlane==null)
        {
            Command.CommandExecutionComplete();
            return;
        }
        GameObject Quote = GameObject.Instantiate(this.NarratorPlane,pos,Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
        if(Quote!=null)
        {
            Quote.SetActive(true);
            Text txPlane = Quote.GetComponentInChildren<Text>();
            txPlane.text = txt; 
            GameObject MatReq = Quote.transform.GetChild(1).gameObject;

            bool retHSCardPortaitMat=false;
            Texture2D _texture2d=null;
            retHSCardPortaitMat = HSViewer.SetHSMat(MatReq,db.m_noteMiniGuid);
            
            if(retHSCardPortaitMat==false)
            {
                 _texture2d = MyAssetsLoader.GetCardDbfImageTexutre(db);
            }
            else{
                Material cardPortaitMat = MatReq.GetComponent<Renderer>().material;
                _texture2d = (Texture2D)cardPortaitMat.GetTexture("_MainTex");
            }

            if(_texture2d!=null)
            {
                Image im = Quote.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Image>();
                im.sprite = Sprite.Create(_texture2d, new Rect(0, 0, _texture2d.width, _texture2d.height), Vector2.zero);

                Quote.transform.localScale=new Vector3(0f,0f,0f);
                Quote.transform.DOScale(new Vector3(1f,1f,1f),0.3f*dur).SetEase(Ease.InBounce);
                Sequence DelaySeq = DOTween.Sequence();
                DelaySeq.AppendInterval(1f*dur);
                DelaySeq.OnComplete(()=>{
                    Quote.transform.DOScale(Vector3.zero,1f*dur).OnComplete(()=>{
                        Command.CommandExecutionComplete();
                        UnityEngine.Object.Destroy(Quote,2f); 
                    });

                });                  
            }
            else{
                Command.CommandExecutionComplete();
            }
          
        }
        else{
            Command.CommandExecutionComplete();
        }
    }
}
