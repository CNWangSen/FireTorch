using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class MisdirectionReticle : VfxBase
{
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        float launchdur = 2f;
        float Randomness = 1f;
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
                LaunchFx.transform.rotation = Quaternion.Euler(new Vector3(90f, 0f, 0f));

                Vector3 finalPos = target.transform.position + new Vector3(0f, 0.2f, 0f);
                Vector3 startPos = Source.transform.position + new Vector3(0f, 0.2f, 0f);
                Vector3 midPos = startPos + (finalPos - startPos) * 0.5f;
                Vector3 midVector = midPos - startPos;
                Vector3 controlPos = midPos + (Random.value < 0.5f ? -1f : 1f) * UnityEngine.Random.Range(0.5f, 2f) * new Vector3(-midVector.z, 0f, midVector.x)
                    + new Vector3(UnityEngine.Random.Range(-Randomness, Randomness), UnityEngine.Random.Range(0f, Randomness), UnityEngine.Random.Range(-Randomness, Randomness));
                float t = 0f;
                float dt = 0.033f / launchdur;
                Sequence ProjectileSeq = DOTween.Sequence();
                while (t < 1f)
                {
                    Vector3 p = (1 - t) * (1 - t) * startPos + 2 * t * (1 - t) * controlPos + t * t * finalPos;
                    float x_t = p.x;
                    float y_t = p.y;
                    float z_t = p.z;

                    ProjectileSeq.Insert(t * launchdur, LaunchFx.transform.DOMoveX(x_t, dt * launchdur).SetEase(Ease.Linear));
                    ProjectileSeq.Insert(t * launchdur, LaunchFx.transform.DOMoveY(y_t, dt * launchdur).SetEase(Ease.Linear));
                    ProjectileSeq.Insert(t * launchdur, LaunchFx.transform.DOMoveZ(z_t, dt * launchdur).SetEase(Ease.Linear));
                    t += dt;
                }
                ProjectileSeq.AppendInterval(1f);

            }

        }

        Seq.AppendInterval(launchdur+1f);
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
}


public class BaconStarBurst:VfxBase
{
    private List<GameObject> MyStars = new List<GameObject>();
    private static List<List<Vector3>> Offsets;
    public override Sequence SetInvoke(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject InvokePrefab)
    {
        OneActorManager mgr = Source.GetComponent<OneActorManager>();
        int tier = mgr.CardDbf.ManaCost;
        if(tier>7)
        {
            tier=7;
        }
        if(tier<1)
        {
            tier=1;
        }
        List<Vector3> Offsets = new List<Vector3>();
        float dx=0.15f;
        float dz=0.2f;
        switch(tier)
        {
            case(1):
                Offsets.Add(new Vector3(0f,0f,0f));
                break;
            case(2):
                Offsets.Add(new Vector3(-dx,0f,0f));
                Offsets.Add(new Vector3(dx,0f,0f));
                break;
            case(3):
                Offsets.Add(new Vector3(-dx,0f,-dz));
                Offsets.Add(new Vector3(0f,0f,dz));
                Offsets.Add(new Vector3(dx,0f,-dz));
                break;
            case(4):
                Offsets.Add(new Vector3(-dx,0f,-dz));
                Offsets.Add(new Vector3(-dx,0f,dz));
                Offsets.Add(new Vector3(dx,0f,-dz));
                Offsets.Add(new Vector3(dx,0f,dz));
                break;
            case(5):
                Offsets.Add(new Vector3(-dx,0f,-dz));
                Offsets.Add(new Vector3(-dx,0f,dz));
                Offsets.Add(new Vector3(0f,0f,0f));
                Offsets.Add(new Vector3(dx,0f,-dz));
                Offsets.Add(new Vector3(dx,0f,dz));
                break;
            case(6):
                Offsets.Add(new Vector3(-dx,0f,-dz));
                Offsets.Add(new Vector3(-dx,0f,0f));
                Offsets.Add(new Vector3(-dx,0f,dz));
                Offsets.Add(new Vector3(dx,0f,-dz));
                Offsets.Add(new Vector3(dx,0f,0f));
                Offsets.Add(new Vector3(dx,0f,dz));
                break;
            case(7):
                Offsets.Add(new Vector3(-dx,0f,-dz));
                Offsets.Add(new Vector3(-dx,0f,0f));
                Offsets.Add(new Vector3(-dx,0f,dz));
                Offsets.Add(new Vector3(dx,0f,-dz));
                Offsets.Add(new Vector3(dx,0f,0f));
                Offsets.Add(new Vector3(dx,0f,dz));   
                Offsets.Add(new Vector3(0f,0f,-2*dz));
                break;             
            default:
                break;
        }
        for(int i = 0;i<tier;i++)
        {
            if (InvokePrefab != null)
            {
                Vector3 StarPosOffset = Offsets[i]+new Vector3(0f,0.1f,0.1f);
                GameObject Star = GameObject.Instantiate(InvokePrefab, Source.transform.position+StarPosOffset, Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                MyStars.Add(Star);
                Star.transform.GetChild(0).gameObject.SetActive(true);
            }
        }
        float invokedur = 0.1f;
        Seq.AppendInterval(invokedur);
        return base.SetInvoke(Seq, Source, Target, InvokePrefab);
    }
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        Command.CommandExecutionComplete();
        this.EarlyCompleted=true;
        float launchdelay=0.6f;
        float launchdur = 0.3f;
        Sequence DelaySeq = DOTween.Sequence();
        DelaySeq.AppendInterval(launchdelay);
        Seq.AppendInterval(launchdelay);
        DelaySeq.OnComplete(()=>{
            foreach(GameObject target in Target)
            {
                foreach (GameObject Star in this.MyStars)
                {
                    Star.transform.GetChild(2).gameObject.SetActive(true);
                    Vector3 RawPos = Star.transform.position;
                    Vector3 TargetPos=target.transform.position+new Vector3(-0.45f,0f,-0.4f);
                    double distance = (TargetPos.z - RawPos.z) * (TargetPos.z - RawPos.z) + (TargetPos.x - RawPos.x) * (TargetPos.x - RawPos.x);
                    distance = System.Math.Sqrt(distance);
                    if (distance == 0d)
                    {
                        distance = 0.0001d;
                    }
                    double cos = -(RawPos.x - TargetPos.x) / distance;
                    double thetadir = System.Math.Acos(cos) * 180 / 3.1415926;
                    if (RawPos.z < TargetPos.z)
                    {
                        thetadir = 360 - thetadir;
                    }
                    GameObject LaunchFx = MyStars[0];
                    Star.transform.rotation = Quaternion.Euler(new Vector3(0f, (float)thetadir, 0f));
                    Star.transform.DOMoveX(TargetPos.x, launchdur).SetEase(Ease.InExpo);
                    Star.transform.DOMoveY(TargetPos.y+0.2f, launchdur).SetEase(Ease.InExpo);
                    Star.transform.DOMoveZ(TargetPos.z, launchdur).SetEase(Ease.InExpo);
                }         
            }
        });
        Seq.AppendInterval(launchdur);
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        foreach(GameObject target in Target)
        {
            foreach (GameObject Star in this.MyStars)
            {
                Star.transform.GetChild(0).gameObject.SetActive(false);
                Star.transform.GetChild(1).gameObject.SetActive(true);
                ImpactFxs.Add(Star);
            }            
        }
        Seq.AppendInterval(0f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}