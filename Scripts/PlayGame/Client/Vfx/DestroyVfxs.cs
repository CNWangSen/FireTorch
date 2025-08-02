using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DestroyDoom : VfxBase
{
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        if (LaunchPrefab != null)
        {
            GameObject ImpactFx = GameObject.Instantiate(LaunchPrefab, new Vector3(-2.39f, 3.82f, 0.24f), Quaternion.Euler(new Vector3(37.806f, 30.318f, -58.711f))) as GameObject;
            LaunchFxs.Add(ImpactFx);
        }
        Seq.AppendInterval(5f);
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
}

public class DestroyTwistingNether : VfxBase
{
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        if (LaunchPrefab != null)
        {
            GameObject ImpactFx = GameObject.Instantiate(LaunchPrefab, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(37.806f, 30.318f, -58.711f))) as GameObject;
            LaunchFxs.Add(ImpactFx);
            ImpactFx.transform.DOScale(new Vector3(10f,5f,10f), duration:3f).SetEase(Ease.OutExpo).OnComplete(()=> 
            {
                ImpactFx.transform.DOScale(new Vector3(1f, 1f, 1f), duration:2f).SetEase(Ease.Linear);
            });
        }
        foreach (GameObject actor in Target)
        {
            OneActorManager manager = actor.GetComponent<OneActorManager>();
            manager.IsActing = true;
            actor.transform.DOMove(new Vector3(0f,0f,0f),duration:5f).SetEase(Ease.InExpo).OnComplete(()=> {
                manager.IsActing = false;
            });
        }

        Seq.AppendInterval(5f);
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
}


public class DestroyBrawl : VfxBase
{
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        if (LaunchPrefab != null)
        {
            GameObject ImpactFx = GameObject.Instantiate(LaunchPrefab, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(37.806f, 30.318f, -58.711f))) as GameObject;
            LaunchFxs.Add(ImpactFx);
            Sequence Delay = DOTween.Sequence();
            Delay.AppendInterval(1f).OnComplete(()=> {
                GameObject ImpactFx2 = GameObject.Instantiate(LaunchPrefab, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(37.806f, 30.318f, -58.711f))) as GameObject;
                LaunchFxs.Add(ImpactFx2);
                Sequence Delay2 = DOTween.Sequence();
                Delay2.AppendInterval(1f).OnComplete(() => {
                    GameObject ImpactFx3 = GameObject.Instantiate(LaunchPrefab, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(37.806f, 30.318f, -58.711f))) as GameObject;
                    LaunchFxs.Add(ImpactFx3);
                    Sequence Delay3 = DOTween.Sequence();
                    Delay3.AppendInterval(1f).OnComplete(() => {
                        GameObject ImpactFx4 = GameObject.Instantiate(LaunchPrefab, new Vector3(0f, 0f, 0f), Quaternion.Euler(new Vector3(37.806f, 30.318f, -58.711f))) as GameObject;
                        LaunchFxs.Add(ImpactFx4);
                        Sequence Delay4 = DOTween.Sequence();
                        Delay4.AppendInterval(1f).OnComplete(() => {


                        });
                    });
                });
            });
        }
        foreach (GameObject actor in Target)
        {
            OneActorManager manager = actor.GetComponent<OneActorManager>();
            manager.IsActing = true;
            actor.transform.DOMove(new Vector3(0f, 0f, 0f), duration: 2f).SetEase(Ease.InExpo).OnComplete(() => {
                actor.transform.DOShakePosition(duration:UnityEngine.Random.Range(0f,2f),new Vector3(1f,1f,1f)).OnComplete(() =>
                {
                    actor.transform.DOMove(new Vector3(UnityEngine.Random.Range(-3f, 3f), 0f, UnityEngine.Random.Range(-3f, 3f)), 2f).OnComplete(() =>
                         {
                             manager.IsActing = false;
                         });
                });
            });
        }

        Seq.AppendInterval(4f);
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
}