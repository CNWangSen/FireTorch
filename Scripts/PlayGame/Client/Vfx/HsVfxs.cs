using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.Audio;
using HutongGames.PlayMaker.Actions;
using HutongGames.PlayMaker;

public class StraightHearthVfx:VfxBase
{
    public override void OnDoneInvoke()
    {

    }
    public override void OnDoneLaunch()
    {
        
    }
    public override void OnDoneImpact()
    {
        
    }

    public void FadeOutParticles(GameObject VfxObject, float dur)
    {
        Sequence DelaySeq = DOTween.Sequence();
        DelaySeq.AppendInterval(dur);
        DelaySeq.OnComplete(()=>{
            /*
            Spell sp = VfxObject.GetComponent<Spell>();
                
            if(sp!=null)
            {
                sp.m_fsm = VfxObject.GetComponent<PlayMakerFSM>();
                if(sp.m_fsm!=null)
                {
                    sp.m_fsm.SendEvent("Death");
                }
            } 
            */



            Spell sp = VfxObject.GetComponent<Spell>();
            
            if(sp!=null)
            {
                sp.m_fsm = VfxObject.GetComponent<PlayMakerFSM>();

                if(sp.m_fsm!=null)
                {
                    sp.m_fsm.SendEvent("Death");                
                }
            }


            float RemainDur = 5f;
            foreach(ParticleSystem ps in VfxObject.GetComponentsInChildren<ParticleSystem>())
            {
                ps.Stop();
                //if(ps.main.duration>RemainDur)
                //{
                //    RemainDur=ps.main.duration;
                //}
            }
            foreach(MeshRenderer meshs in VfxObject.GetComponentsInChildren<MeshRenderer>())
            {
                meshs.enabled=false;
            }
            foreach(SkinnedMeshRenderer meshs in VfxObject.GetComponentsInChildren<SkinnedMeshRenderer>())
            {
                meshs.enabled=false;
            }
            foreach(AudioSource aus in VfxObject.GetComponentsInChildren<AudioSource>())
            {
                aus.Stop();
            }
            UnityEngine.Object.Destroy(VfxObject,RemainDur);            
        });
    }
    public override Sequence SetInvoke(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject InvokePrefab)
    {
        OneActorManager mgr = Source.GetComponent<OneActorManager>();
        mgr.ActiveTriggerVfx();
        if(mgr.CustomInvokeVfxObject!=null && mgr.CustomInvokeVfxInfo!=null)
        {
            if(mgr.CustomInvokeVfxInfo.m_Enabled)
            {
                UnityEngine.Debug.Log("fucking");
                (GameObject InvokeFx, float invokedur)=mgr.GetVfxIns(mgr.CustomInvokeVfxObject,this.GetHeroSourcePos(Source)+new Vector3(0f,0.5f,0f),AutoDestroy:false);
                Spell sp = InvokeFx.GetComponent<Spell>();
                
                if(sp!=null)
                {
                    sp.m_fsm = InvokeFx.GetComponent<PlayMakerFSM>();

                    if(sp.m_fsm!=null)
                    {
                        sp.m_fsm.SendEvent("Death");
                        sp.m_fsm.SendEvent("Action");
                        sp.m_fsm.SendEvent("Birth");                   
                    }
                }

                //invokedur=30f*invokedur;
                
                //Sequence SeqDie = DOTween.Sequence();
                //SeqDie.AppendInterval(invokedur);
                //SeqDie.OnComplete(()=>
                //{
                //    InvokeFx.transform.DOMove(new Vector3(InvokeFx.transform.position.x,-1f,InvokeFx.transform.position.z),1f).SetEase(Ease.InQuart);
                //});                 
                if(mgr.CustomInvokeVfxInfo.m_DeathAfterAllMissilesFire)
                {
                    FadeOutParticles(InvokeFx,invokedur+1f);
                }
                else{
                    FadeOutParticles(InvokeFx,invokedur);
                    //UnityEngine.Object.Destroy(InvokeFx,invokedur);
                }
                //InvokeFxs.Add(InvokeFx);
                Seq.AppendInterval(invokedur/4f);
            }
        }
        else{
        }
        return base.SetInvoke(Seq, Source, Target, InvokePrefab);
    }
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        Vector3 CorrectSourcePos=this.GetHeroSourcePos(Source);

        OneActorManager mgr = Source.GetComponent<OneActorManager>();

        float launchdur = 0f;
        if(mgr.CustomLaunchReverseVfxObject!=null)
        {
            Sequence ReverseDelay = DOTween.Sequence();
            ReverseDelay.AppendInterval(3f*mgr.CustomLaunchVfxInfo.m_reverseDelay);
            ReverseDelay.OnComplete(()=>{
                int ind=0;
                foreach (GameObject target in Target)
                {
                    Sequence SpawnDelaySeq = DOTween.Sequence();
                    SpawnDelaySeq.AppendInterval((float)ind*0.003f);
                    ind+=1;
                    SpawnDelaySeq.OnComplete(()=>{
                        double distance = (target.transform.position.z - CorrectSourcePos.z) * (target.transform.position.z - CorrectSourcePos.z) + (target.transform.position.x - CorrectSourcePos.x) * (target.transform.position.x - CorrectSourcePos.x);
                        distance = System.Math.Sqrt(distance);
                        if (distance == 0d)
                        {
                            distance = 0.0001d;
                        }
                        double cos = -(CorrectSourcePos.x - target.transform.position.x) / distance;
                        double thetadir = System.Math.Acos(cos) * 180 / 3.1415926;
                        if (CorrectSourcePos.z < target.transform.position.z)
                        {
                            thetadir = 360 - thetadir;
                        }

                        (GameObject LaunchFx, float mlaunchdur)=mgr.GetVfxIns(mgr.CustomLaunchReverseVfxObject,CorrectSourcePos+new Vector3(0f,0.5f,0f),extend:true,AutoDestroy:false);
                        LaunchFx.transform.rotation = Quaternion.Euler(new Vector3(0f, (float)thetadir+90f, 0f));
                        foreach(RenderToTexture rx in LaunchFx.GetComponentsInChildren<RenderToTexture>())
                        {
                            rx.m_ObjectToRender.transform.eulerAngles=Vector3.zero;//rotation=Quaternion.Euler(Vector3.zero);
                        }
                        Vector3[] missilePath = new Vector3[3];
                        missilePath[2] = CorrectSourcePos;
                        missilePath[0] = target.transform.position;
                        missilePath[1] = GenerateMissilePathCenterPoint(missilePath,mgr.CustomLaunchVfxInfo);
                        launchdur=3f*UnityEngine.Random.Range(mgr.CustomLaunchVfxInfo.m_PathDurationMin, mgr.CustomLaunchVfxInfo.m_PathDurationMax);
                        LaunchFx.transform.DOPath(missilePath,launchdur,PathType.CatmullRom,PathMode.Ignore,resolution:10).SetEase(TweenEaseMap[(int)mgr.CustomLaunchVfxInfo.m_PathEaseType]);
                        
                        Spell sp = LaunchFx.GetComponent<Spell>();
                        
                        sp.m_fsm = LaunchFx.GetComponent<PlayMakerFSM>();
                        if(sp.m_fsm!=null)
                        {
                            sp.m_fsm.SendEvent("Death");
                            sp.m_fsm.SendEvent("Action");
                            sp.m_fsm.SendEvent("Birth");                   
                        }
                        FadeOutParticles(LaunchFx,launchdur);
                        //UnityEngine.Object.Destroy(LaunchFx,launchdur);
                    });
                }                
            });
        }
        if (mgr.CustomLaunchVfxObject!=null)
        {
            int ind=0;
            launchdur= 3f*UnityEngine.Random.Range(mgr.CustomLaunchVfxInfo.m_PathDurationMin, mgr.CustomLaunchVfxInfo.m_PathDurationMax)+(float)Target.Count*0.003f;
            foreach (GameObject target in Target)
            {
                Sequence SpawnDelaySeq = DOTween.Sequence();
                SpawnDelaySeq.AppendInterval((float)ind*0.003f);
                SpawnDelaySeq.OnComplete(()=>{
                    double distance = (target.transform.position.z - CorrectSourcePos.z) * (target.transform.position.z - CorrectSourcePos.z) + (target.transform.position.x - CorrectSourcePos.x) * (target.transform.position.x - CorrectSourcePos.x);
                    distance = System.Math.Sqrt(distance);
                    if (distance == 0d)
                    {
                        distance = 0.0001d;
                    }
                    double cos = -(CorrectSourcePos.x - target.transform.position.x) / distance;
                    double thetadir = System.Math.Acos(cos) * 180 / 3.1415926;
                    if (CorrectSourcePos.z < target.transform.position.z)
                    {
                        thetadir = 360 - thetadir;
                    }

                    (GameObject LaunchFx, float mlaunchdur)=mgr.GetVfxIns(mgr.CustomLaunchVfxObject,CorrectSourcePos+new Vector3(0f,0.5f,0f),extend:true,AutoDestroy:false);
                    LaunchFx.transform.rotation = Quaternion.Euler(new Vector3(0f, (float)thetadir+90f, 0f));
                    foreach(RenderToTexture rx in LaunchFx.GetComponentsInChildren<RenderToTexture>())
                    {
                        rx.m_ObjectToRender.transform.eulerAngles=Vector3.zero;//rotation=Quaternion.Euler(Vector3.zero);
                    }
                    Vector3[] missilePath = new Vector3[3];
                    missilePath[0] = CorrectSourcePos;
                    missilePath[2] = target.transform.position;
                    missilePath[1] = GenerateMissilePathCenterPoint(missilePath,mgr.CustomLaunchVfxInfo);
                    launchdur = 3f*UnityEngine.Random.Range(mgr.CustomLaunchVfxInfo.m_PathDurationMin, mgr.CustomLaunchVfxInfo.m_PathDurationMax);
                    if(mgr.CustomLaunchVfxInfo.m_TargetJoint.Length>0)
                    {
                        GameObject JointObj=null;
                        foreach (Transform t in LaunchFx.transform.GetComponentsInChildren<Transform>(true))
                        {
                            if(t.name.Contains(mgr.CustomLaunchVfxInfo.m_TargetJoint))
                            {
                                JointObj = t.gameObject;
                                break;
                            }
                        }
                        if(JointObj!=null)
                        {
                            LaunchFx.transform.LookAt(target.transform,mgr.CustomLaunchVfxInfo.m_JointUpVector);
                            missilePath[2].y=missilePath[2].y+mgr.CustomLaunchVfxInfo.m_TargetHeightOffset;
                            JointObj.transform.DOPath(missilePath,launchdur,PathType.CatmullRom,PathMode.Ignore,resolution:10).SetEase(TweenEaseMap[(int)mgr.CustomLaunchVfxInfo.m_PathEaseType]);
                        }
                        else{
                            LaunchFx.transform.DOPath(missilePath,launchdur,PathType.CatmullRom,PathMode.Ignore,resolution:10).SetEase(TweenEaseMap[(int)mgr.CustomLaunchVfxInfo.m_PathEaseType]);
                        }
                        
                    }
                    else{
                        LaunchFx.transform.DOPath(missilePath,launchdur,PathType.CatmullRom,PathMode.Ignore,resolution:10).SetEase(TweenEaseMap[(int)mgr.CustomLaunchVfxInfo.m_PathEaseType]);
                    }

                    Spell sp = LaunchFx.GetComponent<Spell>();
                    
                    sp.m_fsm = LaunchFx.GetComponent<PlayMakerFSM>();
                    if(sp.m_fsm!=null)
                    {
                        sp.m_fsm.SendEvent("Death");
                        sp.m_fsm.SendEvent("Action");
                        sp.m_fsm.SendEvent("Birth");                   
                    }
                    //UnityEngine.Object.Destroy(LaunchFx,launchdur);
                    FadeOutParticles(LaunchFx,launchdur);
                });
                ind+=1;
            }
        }
        else{
            Vector3 TargetCenter = new Vector3(0f,-0.813f,0f);

            if(Target.Count!=0)
            {
                TargetCenter = Vector3.zero;
                foreach (GameObject target in Target)
                {
                    TargetCenter += target.transform.position;
                }
                TargetCenter/=Target.Count;
            }

            if(mgr.CustomVfxTargetInfo!=null)
            {
                switch(mgr.CustomVfxTargetInfo.m_Behavior)
                {
                    case(SpellTargetBehavior.UNTARGETED):
                        TargetCenter=CorrectSourcePos+new Vector3(0f,0.1f,0f);
                        break;
                    case(SpellTargetBehavior.BOARD_RANDOM):
                        TargetCenter=new Vector3(UnityEngine.Random.Range(-2.83f,2.83f),UnityEngine.Random.Range(-0.813f,0.813f),UnityEngine.Random.Range(-1.07f,1.07f));
                        break;
                    case(SpellTargetBehavior.BOARD_CENTER):
                        TargetCenter=new Vector3(0f,-0.813f,0f); 
                        break;
                    case(SpellTargetBehavior.FRIENDLY_PLAY_ZONE_CENTER):
                        TargetCenter=new Vector3(0f,-0.813f,-0.535f);
                        break;
                    case(SpellTargetBehavior.FRIENDLY_PLAY_ZONE_RANDOM):
                        TargetCenter=new Vector3(UnityEngine.Random.Range(-2.83f,2.83f),UnityEngine.Random.Range(-0.813f,0.813f),UnityEngine.Random.Range(-1.07f,0f));
                        break;
                    case(SpellTargetBehavior.OPPONENT_PLAY_ZONE_CENTER):
                        TargetCenter=new Vector3(0f,-0.813f,0.535f);
                        break;
                    case(SpellTargetBehavior.OPPONENT_PLAY_ZONE_RANDOM):
                        TargetCenter=new Vector3(UnityEngine.Random.Range(-2.83f,2.83f),UnityEngine.Random.Range(-0.813f,0.813f),UnityEngine.Random.Range(0f,1.07f));
                        break;
                    case(SpellTargetBehavior.CHOSEN_TARGET_ONLY):
                        break;
                    case(SpellTargetBehavior.TARGET_ZONE_CENTER):
                        break;
                    case(SpellTargetBehavior.NEW_CREATED_CARDS):
                        break;
                    case(SpellTargetBehavior.NEW_CREATED_CARDS_IN_PLAY):
                        break;
                    default:
                        TargetCenter=new Vector3(0f,-0.813f,0f);
                        break;
                }
            }
            //TargetCenter=new Vector3(0f,-0.813f,0f);
            if(mgr.CustomFriendlyAEVfxObject!=null && !(mgr.ControlBy==AreaPosition.Low && mgr.CustomOpposingAEVfxObject!=null))
            {
                (GameObject LaunchFx, float mlaunchdur)=mgr.GetVfxIns(mgr.CustomFriendlyAEVfxObject,TargetCenter);
                LaunchFx.transform.GetChild(0).localPosition= Vector3.zero;
                launchdur=mlaunchdur/2;
                Spell sp = LaunchFx.GetComponent<Spell>();
                
                sp.m_fsm = LaunchFx.GetComponent<PlayMakerFSM>();
                if(sp.m_fsm!=null)
                {
                    sp.m_fsm.SendEvent("Death");
                    sp.m_fsm.SendEvent("Action");
                    sp.m_fsm.SendEvent("Birth");                   
                }
                LaunchFxs.Add(LaunchFx);
                Sequence SeqDie = DOTween.Sequence();
                SeqDie.AppendInterval(mlaunchdur);
                SeqDie.OnComplete(()=>
                {
                    LaunchFx.transform.DOMove(new Vector3(LaunchFx.transform.position.x,-1f,LaunchFx.transform.position.z),1f).SetEase(Ease.InQuart);
                });           
            }
            else{
                if(mgr.CustomOpposingAEVfxObject!=null)
                {
                    (GameObject LaunchFx, float mlaunchdur)=mgr.GetVfxIns(mgr.CustomOpposingAEVfxObject,TargetCenter);
                    LaunchFx.transform.GetChild(0).localPosition= Vector3.zero;
                    launchdur=mlaunchdur/2;
                    Spell sp = LaunchFx.GetComponent<Spell>();
                    
                    sp.m_fsm = LaunchFx.GetComponent<PlayMakerFSM>();
                    if(sp.m_fsm!=null)
                    {
                        sp.m_fsm.SendEvent("Death");
                        sp.m_fsm.SendEvent("Action");
                        sp.m_fsm.SendEvent("Birth");                   
                    }
                    LaunchFxs.Add(LaunchFx);
                    Sequence SeqDie = DOTween.Sequence();
                    SeqDie.AppendInterval(mlaunchdur);
                    SeqDie.OnComplete(()=>
                    {
                        LaunchFx.transform.DOMove(new Vector3(LaunchFx.transform.position.x,-1f,LaunchFx.transform.position.z),1f).SetEase(Ease.InQuart);
                    });   
                }                
            }
        }
      
        Seq.AppendInterval(launchdur);
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        OneActorManager mgr = Source.GetComponent<OneActorManager>();
        if (mgr.CustomImpactVfxObject!=null && mgr.CustomImpactVfxInfo!=null)
        {
            if(mgr.CustomImpactVfxInfo.m_Enabled)
            {
                float SpawnDealyDurMax = 0f;
                if(Target.Count>1)
                {
                    SpawnDealyDurMax=(float)Target.Count*0.003f;
                }
                foreach (GameObject target in Target)
                {
                    Sequence SpawnDelaySeq = DOTween.Sequence();
                    SpawnDelaySeq.AppendInterval(UnityEngine.Random.Range(mgr.CustomImpactVfxInfo.m_SpawnDelaySecMin,mgr.CustomImpactVfxInfo.m_SpawnDelaySecMax+SpawnDealyDurMax));
                    SpawnDelaySeq.OnComplete(()=>{
                        (GameObject ImpactFx, float impactdur)=mgr.GetVfxIns(mgr.CustomImpactVfxObject,target.transform.position+new Vector3(0f,0.1f,0f));
                        //ImpactFxs.Add(ImpactFx);
                        Spell sp = ImpactFx.GetComponent<Spell>();
                        
                        sp.m_fsm = ImpactFx.GetComponent<PlayMakerFSM>();
                        if(sp.m_fsm!=null)
                        {
                            sp.m_fsm.SendEvent("Death");
                            sp.m_fsm.SendEvent("Action");
                            sp.m_fsm.SendEvent("Birth");                   
                        }
                        FadeOutParticles(ImpactFx,impactdur);
                    });
                }                
            }
        }
        //Seq.AppendInterval(5f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }









    public static List<Ease> TweenEaseMap = new List<Ease>{
            Ease.InQuad,
            // Token: 0x0400D98C RID: 55692
            Ease.OutQuad,
            // Token: 0x0400D98D RID: 55693
            Ease.InOutQuad,
            // Token: 0x0400D98E RID: 55694
            Ease.InCubic,
            // Token: 0x0400D98F RID: 55695
            Ease.OutCubic,
            // Token: 0x0400D990 RID: 55696
            Ease.InOutCubic,
            // Token: 0x0400D991 RID: 55697
            Ease.InQuart,
            // Token: 0x0400D992 RID: 55698
            Ease.OutQuart,
            // Token: 0x0400D993 RID: 55699
            Ease.InOutQuart,
            // Token: 0x0400D994 RID: 55700
            Ease.InQuint,
            // Token: 0x0400D995 RID: 55701
            Ease.OutQuint,
            // Token: 0x0400D996 RID: 55702
            Ease.InOutQuint,
            // Token: 0x0400D997 RID: 55703
            Ease.InSine,
            // Token: 0x0400D998 RID: 55704
            Ease.OutSine,
            // Token: 0x0400D999 RID: 55705
            Ease.InOutSine,
            // Token: 0x0400D99A RID: 55706
            Ease.InExpo,
            // Token: 0x0400D99B RID: 55707
            Ease.OutExpo,
            // Token: 0x0400D99C RID: 55708
            Ease.InOutExpo,
            // Token: 0x0400D99D RID: 55709
            Ease.InCirc,
            // Token: 0x0400D99E RID: 55710
            Ease.OutCirc,
            // Token: 0x0400D99F RID: 55711
            Ease.InOutCirc,
            // Token: 0x0400D9A0 RID: 55712
            Ease.Linear,
            // Token: 0x0400D9A1 RID: 55713
            //spring,
            Ease.InOutBounce,
            // Token: 0x0400D9A2 RID: 55714
            //bounce,
            Ease.InBounce,
            // Token: 0x0400D9A3 RID: 55715
            Ease.InBack,
            // Token: 0x0400D9A4 RID: 55716
            Ease.OutBack,
            // Token: 0x0400D9A5 RID: 55717
            Ease.InOutBack,
            // Token: 0x0400D9A6 RID: 55718
            //elastic,
            Ease.InElastic,
            // Token: 0x0400D9A7 RID: 55719
            //punch
            Ease.OutBounce,
    };
    private Vector3 GenerateMissilePathCenterPoint(Vector3[] path, SpellMissileInfo m_MissileInfo)
    {
        Vector3 vector = path[0];
        Vector3 vector2 = path[2];
        Vector3 a = vector2 - vector;
        float magnitude = a.magnitude;
        Vector3 result = vector;
        bool flag = magnitude <= Mathf.Epsilon;
        if (!flag)
        {
            result = vector + a * (m_MissileInfo.m_CenterOffsetPercent * 0.01f);
        }
        float num = magnitude / m_MissileInfo.m_DistanceScaleFactor;
        if (flag)
        {
            if (m_MissileInfo.m_CenterPointHeightMin <= Mathf.Epsilon && m_MissileInfo.m_CenterPointHeightMax <= Mathf.Epsilon)
            {
                result.y += 2f;
            }
            else
            {
                result.y += UnityEngine.Random.Range(m_MissileInfo.m_CenterPointHeightMin, m_MissileInfo.m_CenterPointHeightMax);
            }
        }
        else
        {
            result.y += num * UnityEngine.Random.Range(m_MissileInfo.m_CenterPointHeightMin, m_MissileInfo.m_CenterPointHeightMax);
        }
        float num2 = 1f;
        if (vector.z > vector2.z)
        {
            num2 = -1f;
        }
        bool flag2 = (UnityEngine.Random.Range(0,2)==1);
        if (m_MissileInfo.m_RightMin == 0f && m_MissileInfo.m_RightMax == 0f)
        {
            flag2 = false;
        }
        if (m_MissileInfo.m_LeftMin == 0f && m_MissileInfo.m_LeftMax == 0f)
        {
            flag2 = true;
        }
        if (flag2)
        {
            if (m_MissileInfo.m_RightMin == m_MissileInfo.m_RightMax || m_MissileInfo.m_DebugForceMax)
            {
                result.x += m_MissileInfo.m_RightMax * num * num2;
            }
            else
            {
                result.x += UnityEngine.Random.Range(m_MissileInfo.m_RightMin * num, m_MissileInfo.m_RightMax * num) * num2;
            }
        }
        else if (m_MissileInfo.m_LeftMin == m_MissileInfo.m_LeftMax || m_MissileInfo.m_DebugForceMax)
        {
            result.x -= m_MissileInfo.m_LeftMax * num * num2;
        }
        else
        {
            result.x -= UnityEngine.Random.Range(m_MissileInfo.m_LeftMin * num, m_MissileInfo.m_LeftMax * num) * num2;
        }
        return result;
    }
/*
    private Vector3 GenerateMissilePathCenterPoint(Vector3[] path, SpellMissileInfo m_MissileInfo)
    {
        Vector3 vector = path[0];
        Vector3 vector2 = path[2];
        Vector3 a = vector2 - vector;
        float magnitude = a.magnitude;
        Vector3 result = vector;
        bool flag = magnitude <= Mathf.Epsilon;
        if (!flag)
        {
            result = vector + a * (m_MissileInfo.m_CenterOffsetPercent * 0.01f);
        }

        float num = magnitude / (m_MissileInfo.m_DistanceScaleFactor*2f);
        if (flag)
        {
            if (m_MissileInfo.m_CenterPointHeightMin <= Mathf.Epsilon && m_MissileInfo.m_CenterPointHeightMax <= Mathf.Epsilon)
            {
                result.y += 1f;
            }
            else
            {
                result.y += 0.5f*UnityEngine.Random.Range(m_MissileInfo.m_CenterPointHeightMin, m_MissileInfo.m_CenterPointHeightMax);
            }
        }
        else
        {
            result.y += num * UnityEngine.Random.Range(m_MissileInfo.m_CenterPointHeightMin, m_MissileInfo.m_CenterPointHeightMax);
        }
        float num2 = 1f;
        if (vector.z > vector2.z)
        {
            num2 = -1f;
        }
        bool flag2 = (UnityEngine.Random.Range(0,2)==1);
        if (m_MissileInfo.m_RightMin == 0f && m_MissileInfo.m_RightMax == 0f)
        {
            flag2 = false;
        }
        if (m_MissileInfo.m_LeftMin == 0f && m_MissileInfo.m_LeftMax == 0f)
        {
            flag2 = true;
        }
        if (flag2)
        {
            if (m_MissileInfo.m_RightMin == m_MissileInfo.m_RightMax || m_MissileInfo.m_DebugForceMax)
            {
                result.x += m_MissileInfo.m_RightMax * num * num2;
            }
            else
            {
                result.x += UnityEngine.Random.Range(m_MissileInfo.m_RightMin * num, m_MissileInfo.m_RightMax * num) * num2;
            }
        }
        else if (m_MissileInfo.m_LeftMin == m_MissileInfo.m_LeftMax || m_MissileInfo.m_DebugForceMax)
        {
            result.x -= m_MissileInfo.m_LeftMax * num * num2;
        }
        else
        {
            result.x -= UnityEngine.Random.Range(m_MissileInfo.m_LeftMin * num, m_MissileInfo.m_LeftMax * num) * num2;
        }
        return result;
    }
*/
}