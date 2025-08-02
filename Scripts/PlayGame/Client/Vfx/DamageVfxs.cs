using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using DG.Tweening;

public class MyGraphVFX : VfxBase
{
    public override Sequence SetInvoke(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject InvokePrefab)
    {
        if (InvokePrefab != null)
        {
            GameObject InvokeFx = GameObject.Instantiate(InvokePrefab, Vector3.zero, Quaternion.Euler(Vector3.zero)) as GameObject;
            InvokeFxs.Add(InvokeFx);
            VisualEffect InvokeVFX = InvokeFx.GetComponent<VisualEffect>();
            InvokeVFX.SetVector3("SourcePos", Source.transform.position + new Vector3(0f, 0.2f, 0f));
            Seq.AppendInterval(InvokeVFX.GetFloat("Duration"));
        }
        return base.SetInvoke(Seq, Source, Target, InvokePrefab);
    }
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        float launchdur = 0f;
        if (LaunchPrefab != null)
        {
            foreach (GameObject target in Target)
            {
                GameObject LaunchFx = GameObject.Instantiate(LaunchPrefab, Vector3.zero, Quaternion.Euler(Vector3.zero)) as GameObject;
                LaunchFxs.Add(LaunchFx);
                VisualEffect LaunchVFX = LaunchFx.GetComponent<VisualEffect>();
                LaunchVFX.SetVector3("SourcePos", Source.transform.position + new Vector3(0f, 0.2f, 0f));
                LaunchVFX.SetVector3("TargetPos", target.transform.position + new Vector3(0f, 0.2f, 0f));
                launchdur = Mathf.Max(launchdur,LaunchVFX.GetFloat("Duration"));
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
                GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, Vector3.zero, Quaternion.Euler(Vector3.zero)) as GameObject;
                ImpactFxs.Add(ImpactFx);
                VisualEffect ImpactVFX = ImpactFx.GetComponent<VisualEffect>();
                ImpactVFX.SetVector3("SourcePos", target.transform.position + new Vector3(0f, 0.2f, 0f));
                target.transform.DOShakePosition(ImpactVFX.GetFloat("Duration"), strength: 0.01f);
            }
        }
        Seq.AppendInterval(5f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}
public class DamageStraightFireBall : VfxBase
{
    public override void OnDoneInvoke()
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
    public override void OnDoneImpact()
    {
        Sequence s = DOTween.Sequence();
        s.PrependInterval(6f);
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

public class DamageFlameStrike : VfxBase
{
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        float launchdur = 1f;
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
                GameObject LaunchFx = GameObject.Instantiate(LaunchPrefab, Source.transform.position + new Vector3(0f, 0.1f, 0f), Quaternion.Euler(new Vector3(0f, 0f, 0f))) as GameObject;
                LaunchFxs.Add(LaunchFx);
                LaunchFx.transform.rotation = Quaternion.Euler(new Vector3(0f, (float)thetadir+90f, 0f));
            }

        }

        Seq.AppendInterval(launchdur);
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
    public override void OnDoneLaunch()
    {
        Sequence s = DOTween.Sequence();
        s.PrependInterval(5f);
        s.OnComplete(() => {
            foreach (GameObject obj in LaunchFxs)
            {
                obj.SetActive(false);
            }
        });

    }
    public override void OnDoneImpact()
    {
        Sequence s = DOTween.Sequence();
        s.PrependInterval(6f);
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
public class DamageXZCurve : VfxBase
{
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        float launchdur = 0.4f;
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
                LaunchFx.transform.rotation = Quaternion.Euler(new Vector3(0f, (float)thetadir, 0f));

                Vector3 finalPos = target.transform.position;
                Vector3 startPos = Source.transform.position;
                Vector3 midPos = startPos + (finalPos-startPos) * 0.5f;
                Vector3 midVector = midPos - startPos;
                Vector3 controlPos = midPos + (Random.value <0.5f ? -1f:1f) * UnityEngine.Random.Range(0.5f, 2f) * new Vector3(-midVector.z, 0f, midVector.x) 
                    + new Vector3(UnityEngine.Random.Range(-Randomness, Randomness), UnityEngine.Random.Range(0f, Randomness), UnityEngine.Random.Range(-Randomness, Randomness));
                float t = 0f;
                float dt = 0.033f/launchdur;
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
                //target.transform.DOShakePosition(ImpactFx.GetComponent<ParticleSystem>().main.duration, strength: 0.01f);
            }
        }
        Seq.AppendInterval(5f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}