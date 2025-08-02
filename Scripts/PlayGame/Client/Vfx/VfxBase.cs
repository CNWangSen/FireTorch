using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Audio;

public class VfxBase
{
    public bool EarlyCompleted=false;
    public Vector3 GetHeroSourcePos(GameObject Source)
    {
        OneActorManager mgr = Source.GetComponent<OneActorManager>();
        if(mgr!=null)
        {
            if(mgr.zoneType==ZoneType.MinionPower)
            {
                return Source.transform.parent.position;
            }
            else{
                if(mgr.CardDbf.CardType==CardType.Spell)
                {
                    Player owner;
                    GameObject HeroCardObj;
                    //Vector3 MyHeroPos;
                    if (Source.transform.tag.Contains("Low"))
                        HeroCardObj = OneSceneManager.Instance.LowStage.Zones[(int)ZoneType.Hero][0];//Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
                    else
                        HeroCardObj = OneSceneManager.Instance.TopStage.Zones[(int)ZoneType.Hero][0];//Game.NowGame.GetPlayerByID((int)GameTag.TopPlayerID);
                    if(HeroCardObj!=null)
                    {
                        return HeroCardObj.transform.position;
                    } 

                    //return MyHeroPos;
                }
            }
        }
        return Source.transform.position;
    }
    public static void CreateVfx(int sourceID, List<int> targetIDs, VfxAsset vfxAsset = null, VfxType vfxType = VfxType.Damage,float DelayComplete = 0f)
    {
        GameObject source = IDHolder.GetGameObjectWithID(sourceID);
        List<GameObject> targets = new List<GameObject>();
        foreach (int targetID in targetIDs)
        {
            targets.Add(IDHolder.GetGameObjectWithID(targetID));
        }

        if (vfxAsset == null)
        {
            if((int)vfxType<OneSceneManager.Instance.DefaultVfxAsset.Count)
            {
                vfxAsset = OneSceneManager.Instance.DefaultVfxAsset[(int)vfxType];
            }
            else{

            }
            
        }
        if(vfxAsset==null)
        {
            Command.CommandExecutionComplete();
            return;            
        }

        VfxBase OneVfx = System.Activator.CreateInstance(System.Type.GetType(vfxAsset.ScriptName)) as VfxBase;

        Sequence RandomStart = DOTween.Sequence();
        

        Sequence InvokeSeq = DOTween.Sequence();

        InvokeSeq = OneVfx.SetInvoke(InvokeSeq, source, targets, vfxAsset.InvokePrefab);
        foreach (GameObject InvokeObj in OneVfx.InvokeFxs)
        {
            foreach (AudioSource auds in InvokeObj.GetComponentsInChildren<AudioSource>()) 
            {
                if(auds.outputAudioMixerGroup == null)
                    auds.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("SFX")[0];
            }
        }
        InvokeSeq.OnComplete(() =>
        {
            OneVfx.OnDoneInvoke();

            Sequence LaunchSeq = DOTween.Sequence();
            LaunchSeq = OneVfx.SetLaunch(LaunchSeq, source, targets, vfxAsset.LaunchPrefab);
            foreach (GameObject InvokeObj in OneVfx.LaunchFxs)
            {
                foreach (AudioSource auds in InvokeObj.GetComponentsInChildren<AudioSource>())
                {
                    if(auds.outputAudioMixerGroup == null)
                        auds.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("SFX")[0];
                }
            }
            LaunchSeq.OnComplete(() =>
            {
                OneVfx.OnDoneLaunch();

                Sequence ImpactSeq = DOTween.Sequence();
                ImpactSeq = OneVfx.SetImpact(ImpactSeq, source, targets, vfxAsset.ImpactPrefab);
                foreach (GameObject InvokeObj in OneVfx.ImpactFxs)
                {
                    foreach (AudioSource auds in InvokeObj.GetComponentsInChildren<AudioSource>())
                    {
                        if(auds.outputAudioMixerGroup == null)
                            auds.outputAudioMixerGroup = OneSceneManager.Instance.AudMixer.FindMatchingGroups("SFX")[0];
                    }
                }
                ImpactSeq.OnComplete(() =>
                {
                    OneVfx.OnDoneImpact();
                });
                if(!OneVfx.EarlyCompleted)
                {
                    if (DelayComplete != 0f)
                    {
                        Sequence DelaySeq = DOTween.Sequence();
                        DelaySeq.AppendInterval(DelayComplete);
                        DelaySeq.OnComplete(() =>
                        {
                            Command.CommandExecutionComplete();
                        });
                    }
                    else 
                    {
                        Command.CommandExecutionComplete();
                    }                    
                }
            });
        });           
    }

    public static void CreateDropAshFx(int ActorID)
    {
        /*
        GameObject target = IDHolder.GetGameObjectWithID(ActorID);
        GameObject ImpactFx = GameObject.Instantiate(OneSceneManager.Instance.DropAshPrefab, target.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
        Sequence s3 = DOTween.Sequence();
        s3.AppendInterval(5f);
        s3.OnComplete(() => {
            UnityEngine.Object.Destroy(ImpactFx);
        });
        */
    }
    public static void CreateDissolveFx(int ActorID)
    {
        /*
        GameObject target = IDHolder.GetGameObjectWithID(ActorID);
        GameObject ImpactFx = GameObject.Instantiate(OneSceneManager.Instance.DissolvePrefab, target.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
        Sequence s3 = DOTween.Sequence();
        s3.AppendInterval(5f);
        s3.OnComplete(() => {
            UnityEngine.Object.Destroy(ImpactFx);
        });
        */
    }

    public static void CreateDeckToGraveFx(int ActorID)
    {
            GameObject actor = IDHolder.GetGameObjectWithID(ActorID);

            foreach(HoverPreview hp in actor.GetComponentsInChildren<HoverPreview>())
            {
                hp._thisPreviewEnabled=false;
            }
            OneActorManager manager = actor.GetComponent<OneActorManager>();
            //manager.UpdateAssetForZone(ZoneType.Hand);
            manager.CardActor.SetActive(true);
            manager.CardBack.SetActive(false);
            manager.Actor.SetActive(false);
            manager.IsActing = true;
            //OneSceneManager.Instance.DrawCardAudio.Play();
            Sequence s = DOTween.Sequence();
            s.AppendInterval(0f);
            s.Insert(0f, actor.transform.DOMove(actor.transform.position + new Vector3(0f, 1f, 0f), 0.66f));
            if (manager.ControlBy == AreaPosition.Top)
            {
                s.Insert(0.66f, actor.transform.DOMove(actor.transform.position + new Vector3(-2.85f, 5f, -0.7f), 0.66f));
                s.Insert(0.66f,actor.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f,0f,0f)),0.66f));
                s.AppendInterval(0.1f);//s.Insert(1.32f, actor.transform.DOMove(actor.transform.position + new Vector3(-2.85f, 5f, -0.7f), 0.1f));
            }
            else
            {
                s.Insert(0.66f, actor.transform.DOMove(actor.transform.position + new Vector3(-2.9f, 5f, 0.7f), 0.66f));
                s.Insert(0.66f, actor.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, 0f)), 0.66f));
                s.AppendInterval(0.1f);//s.Insert(1.32f, actor.transform.DOMove(actor.transform.position + new Vector3(-2.9f, 5f, 0.7f), 0.1f));
            }

            s.OnComplete(() =>
            {
                if(!OneSceneManager.Instance.IsMyScene)
                {
                    (GameObject ImpactFx,float dr)=manager.GetHSSpellTableVfxIns(SpellType.BURN,AutoDestroy:true,zty:ZoneType.Hand);
                    ImpactFx.transform.position = actor.transform.position;
                    ImpactFx.transform.localScale = new Vector3(0.4f,0.4f,0.4f);                    
                }

                manager.UpdateAssetForZone(ZoneType.Grave);
                //VfxBase.CreateDropAshFx(ActorID);
                actor.GetComponent<OneActorManager>().IsActing = false;
                //actor.SetActive(false);
                Command.CommandExecutionComplete();
            });
    }
    public static void CreateDeckToHandFx(int ActorID)
    {

        GameObject actor = IDHolder.GetGameObjectWithID(ActorID);
        foreach(HoverPreview hp in actor.GetComponentsInChildren<HoverPreview>())
        {
            hp._thisPreviewEnabled=false;
        }
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = true;
        OneSceneManager.Instance.DrawCardAudio.Play();
        Sequence s = DOTween.Sequence();
        s.AppendInterval(0f);
        s.Insert(0f, actor.transform.DOMove(actor.transform.position + new Vector3(0f, 1f, 0f), 0.66f).SetEase(Ease.OutExpo));
        if (manager.ControlBy == AreaPosition.Top)
        {
            //s.Insert(0.66f, actor.transform.DOMove(actor.transform.position + new Vector3(-2.85f, 5f, -0.7f), 0.66f).SetEase(Ease.OutExpo));
            //s.Insert(0.66f,actor.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(180f,0f,0f)),0.66f).SetEase(Ease.OutExpo));
            //s.AppendInterval(0.1f);//s.Insert(1.32f, actor.transform.DOMove(actor.transform.position + new Vector3(-2.85f, 5f, -0.7f), 0.1f));
        }
        else
        {
            s.Insert(0.66f, actor.transform.DOMove(actor.transform.position + new Vector3(-2.9f, 5f, 0.7f), 0.66f).SetEase(Ease.OutExpo));
            s.Insert(0.66f, actor.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, 0f)), 0.66f).SetEase(Ease.OutExpo));
            s.AppendInterval(0.1f);//s.Insert(1.32f, actor.transform.DOMove(actor.transform.position + new Vector3(-2.9f, 5f, 0.7f), 0.1f));
        }

        s.OnComplete(() =>
        {
            foreach(HoverPreview hp in actor.GetComponentsInChildren<HoverPreview>())
            {
                hp._thisPreviewEnabled=true;
            }
            VfxBase.CreateDropAshFx(ActorID);
            actor.GetComponent<OneActorManager>().IsActing = false;
            Command.CommandExecutionComplete();
        });
    }



    public static void CreateHandToHeroFx(int ActorID, List<Vector3> RightTransform)
    {
        GameObject actor = IDHolder.GetGameObjectWithID(ActorID);
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = true;
        actor.transform.DOKill(false);
        manager.Actor.SetActive(false);
        manager.CardActor.SetActive(true);
        manager.CardBack.SetActive(true);
        if (manager.CustomSummonAudioSource != null)
        {
            manager.CustomSummonAudioSource.Play();
        }
        if (manager.CustomStingerAudioSource != null)
        {
            manager.CustomStingerAudioSource.Play();
        }
        Sequence s = DOTween.Sequence();
        VfxBase.CreateDissolveFx(ActorID);
        s.AppendInterval(0f);
        float StartTime=0f;
        float Xoffset=-2f;
        float Zoffset=2f;
        s.Insert(0f, actor.transform.DOMove(RightTransform[0] + new Vector3(0f, 3f, 0f), 0.66f));
        if (manager.ControlBy == AreaPosition.Top)
        {
            StartTime=0.66f;
            Xoffset=2f;
            Zoffset=-2f;
            s.Insert(0.66f, actor.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, 0f)), 0.66f));
        }

        s.Insert(StartTime+0.66f,actor.transform.DOMoveX(RightTransform[0].x+Xoffset,2f).SetEase(Ease.OutExpo));
        s.Insert(StartTime+0.66f,actor.transform.DOMoveY(RightTransform[0].y+1.5f,2f).SetEase(Ease.OutExpo));
        s.Insert(StartTime+0.66f,actor.transform.DOMoveZ(RightTransform[0].z+Zoffset,2f).SetEase(Ease.OutExpo));
        s.Insert(StartTime+2.66f,actor.transform.DOMoveX(RightTransform[0].x,1f).SetEase(Ease.OutExpo));
        s.Insert(StartTime+2.66f,actor.transform.DOMoveY(RightTransform[0].y,1f).SetEase(Ease.OutExpo));
        s.Insert(StartTime+2.66f,actor.transform.DOMoveZ(RightTransform[0].z,1f).SetEase(Ease.OutExpo));
        //s.Insert(1.32f,actor.transform.DOMove(RightTransform[0] + new Vector3(+3f, 0f, -3f),0.66f));

        //actor.transform.position = RightTransform[0] + new Vector3(0f, 2f, 0f);
        //actor.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        //actor.transform.DOMove(RightTransform[0] + new Vector3(0f, 0.5f, 0f), 0.33f)
        s.OnComplete(() =>
        {
            VfxBase.CreateDropAshFx(ActorID);
            actor.GetComponent<OneActorManager>().IsActing = false;
            manager.Actor.SetActive(true);
            manager.CardActor.SetActive(false);
            manager.CardBack.SetActive(false);
            Command.CommandExecutionComplete();
        });
    }

    public static void CreateHandToBoardFx(int ActorID, List<Vector3> RightTransform)
    {

        GameObject actor = IDHolder.GetGameObjectWithID(ActorID);
        actor.transform.DOKill();
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = true;
        manager.Actor.SetActive(false);
        manager.CardActor.SetActive(true);
        manager.CardBack.SetActive(true);


        Sequence s = DOTween.Sequence();
        //VfxBase.CreateDissolveFx(ActorID);
        //s.AppendInterval(dr);
        s.Insert(0, actor.transform.DOMove(RightTransform[0] + new Vector3(0f, 3f, 0f), 0.66f).SetEase(Ease.OutExpo));
        s.Insert(0, actor.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, 0f)), 0.66f).SetEase(Ease.OutExpo));
        float DropTime=0.66f;
        //if (manager.ControlBy == AreaPosition.Top)
        //{
        //    s.Insert(DropTime, actor.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, 0f)), 0.66f));
        //    DropTime+=0.66f;
        //}

        Sequence sDiss = DOTween.Sequence();
        sDiss.AppendInterval(DropTime);
        sDiss.OnComplete(()=>{
            float dr=0f;
            if(!OneSceneManager.Instance.IsMyScene)
            {
                (GameObject ImpactFx, float dr2)=manager.GetHSSpellTableVfxIns(SpellType.SUMMON_OUT_MEDIUM,AutoDestroy:true,zty:ZoneType.Hand,cty:CardType.Minion);
                ImpactFx.transform.position = actor.transform.position;
                ImpactFx.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
                dr=dr2;           
            }
            else{
                
            }

        
            manager.Actor.SetActive(true);
            manager.CardActor.SetActive(false);
            manager.CardBack.SetActive(false); 
            if(OneSceneManager.Instance.IsMinionAudEnabled)
            {
                if (manager.CustomSummonAudioSource != null)
                {
                    manager.CustomSummonAudioSource.Play();
                }
                if (manager.CustomStingerAudioSource != null)
                {
                    manager.CustomStingerAudioSource.Play();
                }                
            }


            Sequence SDrop = DOTween.Sequence();
            SDrop.Insert(dr+0.3f,actor.transform.DORotateQuaternion(Quaternion.Euler(RightTransform[1]),0.33f).SetEase(Ease.OutExpo));
            SDrop.Insert(dr+0.3f,actor.transform.DOMove(RightTransform[0],0.33f).SetEase(Ease.InExpo));
            //actor.transform.position = RightTransform[0] + new Vector3(0f, 2f, 0f);
            //actor.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
            //actor.transform.DOMove(RightTransform[0] + new Vector3(0f, 0.5f, 0f), 0.33f)
            SDrop.OnComplete(() =>
            {
                GameObject HSVFX= manager.ActiveCustomSummonVFX();
                VfxBase.CreateDropAshFx(ActorID);
                actor.GetComponent<OneActorManager>().IsActing = false;
                manager.Actor.SetActive(true);
                manager.ActiveAuraVfx();
                manager.CardActor.SetActive(false);
                manager.CardBack.SetActive(false);
                Command.CommandExecutionComplete();
            });   
        });


    }
    public static void CreateBoardToHandFx(int ActorID, List<Vector3> RightTransform)
    {
        GameObject actor = IDHolder.GetGameObjectWithID(ActorID);
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = true;
        manager.Actor.SetActive(true);
        manager.CardActor.SetActive(false);
        manager.CardBack.SetActive(false);
        actor.transform.DOMove(actor.transform.position + new Vector3(0f, 3f, 0f), 0.66f).OnComplete(() =>
        {
            manager.Actor.SetActive(false);
            if (manager.ControlBy == AreaPosition.Low)
            {
                manager.CardActor.SetActive(true);
            }
            manager.CardBack.SetActive(true);
            VfxBase.CreateDissolveFx(ActorID);
            manager.IsActing = false;
            Command.CommandExecutionComplete();
        });
    }


    public static void CreateAttackFx(int sourceID, int targetID, int conformed=0)
    {
        float Speed=1f;
        GameObject source = IDHolder.GetGameObjectWithID(sourceID);
        GameObject target = IDHolder.GetGameObjectWithID(targetID);

        OneActorManager sourceManager = source.GetComponentInParent<OneActorManager>();

        if(sourceManager!=null)
        {
            if(sourceManager.MythicOffScreenInstance!=null)
            {
                if (sourceManager.CustomAttackAudioSource != null && OneSceneManager.Instance.IsMinionAudEnabled)
                {
                    if(sourceManager.MythicEmoteAudClips.Count>(int)EmoteType.ATTACK)
                    {
                        sourceManager.CustomAttackAudioSource.clip = sourceManager.MythicEmoteAudClips[(int)EmoteType.ATTACK];
                    }
                }
                Animator animator = sourceManager.MythicOffScreenInstance.transform.GetChild(0).GetChild(0).GetComponent<Animator>();
                if(animator!=null)
                {
                    animator.SetTrigger("Start");
                    animator.SetTrigger("Attack");
                }
            }            
        }
        sourceManager.CanAttackNow = false;
        sourceManager.IsActing = true;
        if(Game.NowGame.m_Mode==GameMode.BattleGround)
        {
            sourceManager.EnableHighLight(true);
            sourceManager.SetHighLightColor(new Color(1f, 0f, 0f, 1f));            
        }


        Vector3 initpos = source.transform.position;
        Vector3 hitpos = source.transform.position + 0.97f*(target.transform.position + new Vector3(0f, 0.8f, 0f)-source.transform.position);
        
        if (conformed==0)
        {
            if (sourceManager.CustomAttackAudioSource != null && OneSceneManager.Instance.IsMinionAudEnabled)
            {
                sourceManager.CustomAttackAudioSource.Play();
            }
            Vector3 midpos=initpos + (hitpos - initpos) * -0.3f + new Vector3(0f, 1.5f, 0f);
            if(source.tag.Contains("Hero"))
            {
                midpos=initpos + new Vector3(0f, 2f, 0f);
            }
            source.transform.DOMove(midpos, 0.33f/Speed).SetEase(Ease.OutExpo).OnComplete(() =>
            {
                Command.CommandExecutionComplete();
                Sequence s = DOTween.Sequence();
                s.AppendInterval(2f);
                s.OnComplete(() =>
                {
                    source.GetComponentInParent<OneActorManager>().IsActing = false;
                    //source.GetComponentInParent<OneActorManager>().EnableHighLight(false);
                });
            });
            return;
        }

        int th1 = 6;
        int th2 = 8;
        if(Game.NowGame.m_Mode==GameMode.BattleGround)
        {
            th1=6;
            th2=11;
        }
        //SfxMgr.Get().PlayClip(SfxMgr.Get().FX_MinionAttackLaunch,source);
        source.transform.DOMove(hitpos, 0.33f/Speed).SetEase(Ease.InExpo).OnComplete(() =>
        {
            int damageTakenByTarget = int.Parse(sourceManager.AttackText.text); 
            if (damageTakenByTarget >= 0)
            {
                if (damageTakenByTarget >= th2)//20
                {
                    VfxBase.CreateVfx(sourceID, new List<int>() { targetID }, null, vfxType: VfxType.AtkLarge);
                }
                else
                {
                    if (damageTakenByTarget >= th1)//10
                    {
                        VfxBase.CreateVfx(sourceID, new List<int>() { targetID }, null, vfxType: VfxType.AtkMid);
                    }
                    else
                    {
                        VfxBase.CreateVfx(sourceID, new List<int>() { targetID }, null, vfxType: VfxType.AtkSmall);
                    }
                }
            }
            source.GetComponentInParent<OneActorManager>().IsActing = false;
            if(Game.NowGame.m_Mode==GameMode.BattleGround)
            {
                source.GetComponentInParent<OneActorManager>().EnableHighLight(false);         
            }
        });
    }

    public List<GameObject> InvokeFxs=new List<GameObject>();
    public List<GameObject> LaunchFxs = new List<GameObject>();
    public List<GameObject> ImpactFxs = new List<GameObject>();

    public virtual Sequence SetInvoke(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject InvokePrefab)
    {
        return Seq;
    }

    public virtual Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject InvokePrefab)
    {
        return Seq;
    }

    public virtual Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject InvokePrefab)
    {
        return Seq;
    }
    public virtual void OnDoneInvoke()
    {
        Sequence s = DOTween.Sequence();
        s.PrependInterval(5f);
        s.OnComplete(() => {
            foreach (GameObject obj in InvokeFxs)
            {
                obj.SetActive(false);
            }
        });

    }
    public virtual void OnDoneLaunch()
    {
        Sequence s = DOTween.Sequence();
        s.PrependInterval(0f);
        s.OnComplete(() => {
            foreach (GameObject obj in LaunchFxs)
            {
                obj.SetActive(false);
            }
        });

    }
    public virtual void OnDoneImpact()
    {
        Sequence s = DOTween.Sequence();
        s.PrependInterval(5f);
        s.OnComplete(() => {
            for (int i = InvokeFxs.Count - 1; i >= 0; i--)
            {
                UnityEngine.Object.Destroy(InvokeFxs[i]);
            }
            for (int i = LaunchFxs.Count - 1; i >= 0; i--)
            {
                UnityEngine.Object.Destroy(LaunchFxs[i]);
            }
            for (int i = ImpactFxs.Count - 1; i >= 0; i--)
            {
                UnityEngine.Object.Destroy(ImpactFxs[i]);
            }
        });
    }
}


public class EmptyVfx : VfxBase
{ 
}
public class DieMinionDefault : VfxBase
{
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        GameObject actor = Source;
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = true;
        if(manager.CardDbf.CardType!=CardType.Spell)
            manager.Actor.SetActive(true);
        manager.CardActor.SetActive(false);
        if(manager.Portait!=null)
            manager.Portait.GetComponent<MeshRenderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        actor.transform.DOShakePosition(0.66f, new Vector3(0.5f, 0, 0.5f)).OnComplete(()=> {
            manager.Actor.SetActive(false);
            manager.Portait.GetComponent<MeshRenderer>().material.color = new Color(1f, 1f, 1f, 1f);
            manager.IsActing = false; });
        if (ImpactPrefab != null && !OneSceneManager.Instance.IsMyScene)
        {
            foreach (GameObject target in Target)
            {
                (GameObject ImpactFx,float dr)=manager.GetHSSpellTableVfxIns(SpellType.DEATH,AutoDestroy:true,zty:ZoneType.Board);
                ImpactFx.transform.position = target.transform.position;
                //ImpactFx.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
                //GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, target.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                ImpactFxs.Add(ImpactFx);
                //target.transform.DOShakePosition(ImpactFx.GetComponent<ParticleSystem>().main.duration, strength: 0.01f);
            }
        }
        Seq.AppendInterval(0.66f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}
public class DieWeaponDefault : VfxBase
{
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        GameObject actor = Source;
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = true;
        if(manager.CardDbf.CardType!=CardType.Spell)
            manager.Actor.SetActive(true);
        manager.CardActor.SetActive(false);
        if(manager.Portait!=null)
            manager.Portait.GetComponent<MeshRenderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        actor.transform.DOShakePosition(0.66f, new Vector3(0.5f, 0, 0.5f)).OnComplete(()=> {
            manager.Actor.SetActive(false);
            manager.Portait.GetComponent<MeshRenderer>().material.color = new Color(1f, 1f, 1f, 1f);
            manager.IsActing = false; });
        if (ImpactPrefab != null && !OneSceneManager.Instance.IsMyScene)
        {
            foreach (GameObject target in Target)
            {
                (GameObject ImpactFx,float dr)=manager.GetHSSpellTableVfxIns(SpellType.DEATH,AutoDestroy:true,zty:ZoneType.Weapon);
                ImpactFx.transform.position = target.transform.position;
                //ImpactFx.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
                //GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, target.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                ImpactFxs.Add(ImpactFx);
                //target.transform.DOShakePosition(ImpactFx.GetComponent<ParticleSystem>().main.duration, strength: 0.01f);
            }
        }
        Seq.AppendInterval(0.66f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}

public class DieCardDefault : VfxBase
{
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        GameObject actor = Source;
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = true;
        manager.CardActor.SetActive(true);
        manager.CardBack.SetActive(true);
        if(!OneSceneManager.Instance.IsMyScene)
        {        
            foreach (GameObject target in Target)
            {
                //GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, target.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                //ImpactFxs.Add(ImpactFx);
                //target.transform.DOShakePosition(ImpactFx.GetComponent<ParticleSystem>().main.duration, strength: 0.01f);
                (GameObject ImpactFx,float dr)=manager.GetHSSpellTableVfxIns(SpellType.POWER_UP,AutoDestroy:true,zty:ZoneType.Hand,cty:CardType.Spell);
                ImpactFx.transform.position = target.transform.position;
                ImpactFx.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
                //UnityEngine.Object.Destroy(ImpactFx,0.66f);
                ImpactFxs.Add(ImpactFx);
            }
        }

        float dur = 0.66f;
        Sequence s = DOTween.Sequence();
        s.AppendInterval(0f);
        s.Insert(0f, actor.transform.DOMove(new Vector3(-1f, 3.5f, 0f), dur).SetEase(Ease.OutExpo));
        if (true)//manager.ControlBy == AreaPosition.Top)
        {
            s.Insert(0f, actor.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, 0f)), dur).SetEase(Ease.OutExpo));
            //dur += dur;
            //s.AppendInterval(0.5f);
            //dur += 0.5f;
        }
        s.AppendInterval(0.5f);
        s.OnComplete(() => {
            manager.IsActing = false;
            manager.CardActor.SetActive(false);
            manager.CardBack.SetActive(false);
            //if (ImpactPrefab != null)
            //{
                //foreach (GameObject target in Target)
                //{
                    //GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, target.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                    //ImpactFxs.Add(ImpactFx);
                    //target.transform.DOShakePosition(ImpactFx.GetComponent<ParticleSystem>().main.duration, strength: 0.01f);
                    //(GameObject ImpactFx,float dr)=manager.GetHSSpellTableVfxIns(SpellType.POWER_UP,AutoDestroy:true,zty:ZoneType.Hand,cty:CardType.Spell);
                    //ImpactFx.transform.position = target.transform.position;
                    //ImpactFx.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
                    //UnityEngine.Object.Destroy(ImpactFx,0.66f);
                    //ImpactFxs.Add(ImpactFx);
                //}
            //}
        });
        manager.ActiveCustomDiscardVFX();
        Seq.AppendInterval(dur);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}
public class SpawnHandCardDefault : VfxBase
{
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        GameObject actor = Source;
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = true;
        //manager.Actor.SetActive(false);
        actor.transform.DOShakePosition(0.66f, new Vector3(0.5f, 0, 0.5f)).OnComplete(() => {
            //manager.Actor.SetActive(true);
            manager.IsActing = false;
        });
        if (ImpactPrefab != null && !OneSceneManager.Instance.IsMyScene)
        {
            foreach (GameObject target in Target)
            {
                (GameObject ImpactFx,float dr)=manager.GetHSSpellTableVfxIns(SpellType.SUMMON_OUT_MEDIUM,AutoDestroy:true,zty:ZoneType.Hand);
                ImpactFx.transform.position = target.transform.position;
                ImpactFx.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
                //UnityEngine.Object.Destroy(ImpactFx,0.66f);
                ImpactFxs.Add(ImpactFx);
            }
        }
        manager.ActiveCustomSpawnVFX();
        Seq.AppendInterval(0.66f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}
public class SpawnWeaponDefault : VfxBase
{
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        GameObject actor = Source;
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = true;
        manager.Actor.SetActive(false);
        actor.transform.DOShakePosition(0.66f, new Vector3(0.5f, 0, 0.5f)).OnComplete(() => {
            manager.Actor.SetActive(true);
            manager.IsActing = false;
        });
        if (ImpactPrefab != null && !OneSceneManager.Instance.IsMyScene)
        {
            foreach (GameObject target in Target)
            {
                //GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, target.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                (GameObject ImpactFx,float dr)=manager.GetHSSpellTableVfxIns(SpellType.SUMMON_IN_FRIENDLY,AutoDestroy:false,zty:ZoneType.Weapon);
                ImpactFx.transform.position = target.transform.position;
                UnityEngine.Object.Destroy(ImpactFx,0.66f);
                ImpactFxs.Add(ImpactFx);
                //target.transform.DOShakePosition(ImpactFx.GetComponent<ParticleSystem>().main.duration, strength: 0.01f);
            }
        }
        manager.ActiveCustomSpawnVFX();
        Seq.AppendInterval(0.66f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}
public class SpawnMinionDefault : VfxBase
{
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        GameObject actor = Source;
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = false;
        manager.Actor.SetActive(true);
        //actor.transform.DOShakePosition(0.66f, new Vector3(0.5f, 0, 0.5f)).OnComplete(() => {
        //    manager.Actor.SetActive(true);
        //    manager.IsActing = false;
        //});
        if (manager.CustomStingerAudioSource != null && OneSceneManager.Instance.IsMinionAudEnabled==true)
        {
            manager.CustomStingerAudioSource.Play();
        }
        if (manager.CustomSummonAudioSource != null && OneSceneManager.Instance.IsMinionAudEnabled==true)
        {
            manager.CustomSummonAudioSource.Play();
        }
        if (ImpactPrefab != null && !OneSceneManager.Instance.IsMyScene)
        {
            foreach (GameObject target in Target)
            {
                //GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, target.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                (GameObject ImpactFx,float dr)=manager.GetHSSpellTableVfxIns(SpellType.FRIENDLY_SPAWN_MINION,AutoDestroy:false);
                ImpactFx.transform.position = target.transform.position+new Vector3(-0.03851032f/20f,-0.2753363f/20f,0.115654f/20f);
                UnityEngine.Object.Destroy(ImpactFx,0.66f);
                ImpactFxs.Add(ImpactFx);
                //target.transform.DOShakePosition(ImpactFx.GetComponent<ParticleSystem>().main.duration, strength: 0.01f);
            }
        }
        manager.ActiveCustomSpawnVFX();
        Seq.AppendInterval(0.66f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}
public class StraightShot:VfxBase
{
    public override Sequence SetInvoke(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject InvokePrefab)
    {
        //Camera.main.GetComponent<CameraShakeManager>().TurnOffLight();
        if (InvokePrefab != null)
        {
            GameObject InvokeFx = GameObject.Instantiate(InvokePrefab, Source.transform.position+new Vector3(0f,0.5f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            InvokeFxs.Add(InvokeFx);
            float invokedur = 0.4f;//InvokeFx.GetComponent<ParticleSystem>().main.duration;
            Seq.AppendInterval(invokedur);

        }
        return base.SetInvoke(Seq, Source, Target, InvokePrefab);
    }
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        float launchdur = 0.6f;
        if (LaunchPrefab != null)
        {
            foreach (GameObject target in Target)
            {
                double distance = (target.transform.position.z - Source.transform.position.z) * (target.transform.position.z - Source.transform.position.z) + (target.transform.position.x - Source.transform.position.x) * (target.transform.position.x - Source.transform.position.x);
                distance = System.Math.Sqrt(distance);
                if (distance == 0d)
                {
                    distance = 0.0001d;
                }
                double cos = -(Source.transform.position.x - target.transform.position.x) / distance;
                double thetadir = System.Math.Acos(cos) * 180 / 3.1415926;
                if (Source.transform.position.z < target.transform.position.z)
                {
                    thetadir = 360 - thetadir;
                }
                GameObject LaunchFx = GameObject.Instantiate(LaunchPrefab, Source.transform.position+new Vector3(0f,0.5f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                LaunchFxs.Add(LaunchFx);
                LaunchFx.transform.rotation = Quaternion.Euler(new Vector3(0f, (float)thetadir, 0f));
                LaunchFx.transform.DOMoveX(target.transform.position.x, launchdur).SetEase(Ease.InExpo);
                LaunchFx.transform.DOMoveY(target.transform.position.y+0.1f, launchdur).SetEase(Ease.InExpo);
                LaunchFx.transform.DOMoveZ(target.transform.position.z, launchdur).SetEase(Ease.InExpo);
            }

        }

        Seq.AppendInterval(launchdur);
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        //Camera.main.GetComponent<CameraShakeManager>().TurnUpLight();
        if (ImpactPrefab != null)
        {
            foreach (GameObject target in Target)
            {

                GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, target.transform.position+new Vector3(0f,0.1f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                ImpactFxs.Add(ImpactFx);
                target.transform.DOShakePosition(ImpactFx.GetComponent<ParticleSystem>().main.duration, strength: 0.01f);
            }
        }
        Seq.AppendInterval(5f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}

public class DirectImpact : VfxBase
{
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        if (LaunchPrefab != null)
        {
            GameObject LaunchFx = GameObject.Instantiate(LaunchPrefab, Source.transform.position+new Vector3(0f,0.5f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            LaunchFxs.Add(LaunchFx);
        }
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        if (ImpactPrefab != null)
        {
            foreach (GameObject target in Target)
            {
               double distance = (target.transform.position.z - Source.transform.position.z) * (target.transform.position.z - Source.transform.position.z) + (target.transform.position.x - Source.transform.position.x) * (target.transform.position.x - Source.transform.position.x);
                distance = System.Math.Sqrt(distance);
                if (distance == 0d)
                {
                    distance = 0.0001d;
                }
                double cos = -(Source.transform.position.x - target.transform.position.x) / distance;
                double thetadir = System.Math.Acos(cos) * 180 / 3.1415926;
                if (Source.transform.position.z < target.transform.position.z)
                {
                    thetadir = 360 - thetadir;
                }
                GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, target.transform.position+new Vector3(0f,0.3f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                ImpactFxs.Add(ImpactFx);
                ImpactFx.transform.rotation = Quaternion.Euler(new Vector3(0f, (float)thetadir, 0f));
                //target.GetComponent<OneActorManager>().IsActing=true;
                //target.transform.DOShakePosition(0.4f, strength: 0.01f).OnComplete(()=>{
                //    target.GetComponent<OneActorManager>().IsActing=false;
                //    });
            }
        }
        Seq.AppendInterval(1f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}

public class SimpleImpact : VfxBase
{
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        if (LaunchPrefab != null)
        {
            GameObject LaunchFx = GameObject.Instantiate(LaunchPrefab, Source.transform.position+new Vector3(0f,0.5f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            LaunchFxs.Add(LaunchFx);
        }
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        if (ImpactPrefab != null)
        {
            foreach (GameObject target in Target)
            {
                GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, target.transform.position+new Vector3(0f,1f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                ImpactFxs.Add(ImpactFx);
                //target.GetComponent<OneActorManager>().IsActing=true;
                //target.transform.DOShakePosition(0.4f, strength: 0.01f).OnComplete(()=>{
                //    target.GetComponent<OneActorManager>().IsActing=false;
                //    });
            }
        }
        Seq.AppendInterval(1f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}
public class SimpleImpactRandomRotate : VfxBase
{
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        if (LaunchPrefab != null)
        {
            GameObject LaunchFx = GameObject.Instantiate(LaunchPrefab, Source.transform.position+new Vector3(0f,0.5f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
            LaunchFxs.Add(LaunchFx);
        }
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        if (ImpactPrefab != null)
        {
            foreach (GameObject target in Target)
            {
                GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, target.transform.position+new Vector3(0f,0.3f,0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                ImpactFxs.Add(ImpactFx);
                ImpactFx.transform.rotation = Quaternion.Euler(new Vector3(0f, (float)UnityEngine.Random.Range(0f,360f), 0f));
                //target.GetComponent<OneActorManager>().IsActing=true;
                //target.transform.DOShakePosition(0.4f, strength: 0.01f).OnComplete(()=>{
                //    target.GetComponent<OneActorManager>().IsActing=false;
                //    });
            }
        }
        Seq.AppendInterval(1f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}

public class SourceTopDown : VfxBase
{
    public override Sequence SetInvoke(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject InvokePrefab)
    {
        return base.SetInvoke(Seq, Source, Target, InvokePrefab);
    }
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        float launchdur = 0.4f;
        if (LaunchPrefab != null)
        {
            foreach (GameObject target in Target)
            {
                double distance = (target.transform.position.z - Source.transform.position.z) * (target.transform.position.z - Source.transform.position.z) + (target.transform.position.x - Source.transform.position.x) * (target.transform.position.x - Source.transform.position.x);
                distance = System.Math.Sqrt(distance);
                if (distance == 0d)
                {
                    distance = 0.0001d;
                }
                double cos = -(Source.transform.position.x - target.transform.position.x) / distance;
                double thetadir = System.Math.Acos(cos) * 180 / 3.1415926;
                if (Source.transform.position.z < target.transform.position.z)
                {
                    thetadir = 360 - thetadir;
                }
                GameObject LaunchFx = GameObject.Instantiate(LaunchPrefab, Source.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                LaunchFxs.Add(LaunchFx);
                LaunchFx.transform.rotation = Quaternion.Euler(new Vector3(0f, (float)thetadir, 0f));
                LaunchFx.transform.DOMoveX(target.transform.position.x, launchdur).SetEase(Ease.InExpo);
                LaunchFx.transform.DOMoveY(target.transform.position.y, launchdur).SetEase(Ease.InExpo);
                LaunchFx.transform.DOMoveZ(target.transform.position.z, launchdur).SetEase(Ease.InExpo);
            }

        }

        Seq.AppendInterval(launchdur);
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        if (ImpactPrefab != null)
        {
            foreach (GameObject target in Target)
            {
                GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, target.transform.position, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                ImpactFxs.Add(ImpactFx);
                target.transform.DOShakePosition(ImpactFx.GetComponent<ParticleSystem>().main.duration, strength: 0.01f);
            }
        }
        Seq.AppendInterval(5f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}