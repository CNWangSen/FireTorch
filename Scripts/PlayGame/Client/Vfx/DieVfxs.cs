using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class DieHeroDebris : VfxBase
{
    public override Sequence SetInvoke(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject InvokePrefab)
    {
        GameObject actor = Source;
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing=true;
        manager.Actor.SetActive(true);

        Source.SetActive(true);
        if (InvokePrefab != null)
        {
            
            GameObject InvokeFx = GameObject.Instantiate(InvokePrefab, Source.transform.position, Quaternion.Euler(new Vector3(0f, 180f, 0f))) as GameObject;
            InvokeFxs.Add(InvokeFx);
            Sequence DelaySeq = DOTween.Sequence();
            DelaySeq.AppendInterval(0.5f);
            DelaySeq.OnComplete(()=>{
                InvokeFx.transform.GetChild(0).gameObject.SetActive(false);
            });
        }
        Seq.AppendInterval(0.5f);

        return base.SetLaunch(Seq, Source, Target, InvokePrefab);        
    }
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        GameObject actor = Source;
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing=false;
        actor.SetActive(false);
        float BombRange = 5f;
        float BombDur = 4f;
        if (LaunchPrefab != null)
        {
            
            GameObject LaunchFx = GameObject.Instantiate(LaunchPrefab, Source.transform.position, Quaternion.Euler(new Vector3(0f, 180f, 0f))) as GameObject;
            LaunchFxs.Add(LaunchFx);
            
            
            bool UsingHSp = true;
            UberShaderController ub = manager.CardPortait.gameObject.GetComponent<UberShaderController>();
            UberShaderAnimation ani = null;
            //if(ub!=null)
            //{
            //    UsingHSp=true;
                //ani=ub.UberShaderAnimation;
            //}
            
            //Texture2D DebrisTex=MyAssetsLoader.GetCardDbfImageTexutre(manager.CardDbf);
            for (int i = 0; i < 17; i++)
            {
                GameObject Debris = LaunchFx.transform.GetChild(i).gameObject;
                
                if(UsingHSp)
                {
                    Debris.GetComponent<MeshRenderer>().material = manager.CardPortait.material;
                    //UberShaderController m_uberShaderController = Debris.AddComponent<UberShaderController>();
                    //m_uberShaderController.UberShaderAnimation = UnityEngine.Object.Instantiate<UberShaderAnimation>(ani);
                    //m_uberShaderController.m_MaterialIndex = 0;
                    //m_uberShaderController.enabled = true;
                }
                else{
                    Debris.GetComponent<MeshRenderer>().material.SetTexture("_BaseMap", manager.CardPortait.material.GetTexture("_BaseMap"));//.CardDbf.CardImage.texture);
                }
                
                //if(DebrisTex!=null)
                //    Debris.GetComponent<MeshRenderer>().material.SetTexture("_BaseMap", DebrisTex);
                Debris.transform.DOMove(Source.transform.position+new Vector3(UnityEngine.Random.Range(-BombRange, BombRange), UnityEngine.Random.Range(BombRange/2, BombRange), UnityEngine.Random.Range(-BombRange, BombRange)), BombDur).SetEase(Ease.OutExpo);
            }
            OneSceneManager.Instance.CameraShake.StartShake(1f,BombDur/2);
        }
        Seq.AppendInterval(BombDur);
        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
}

public class DieMinionDebris : VfxBase
{
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        GameObject actor = Source;
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = true;
        manager.Actor.SetActive(true);
        manager.CardActor.SetActive(false);
        manager.Portait.GetComponent<MeshRenderer>().material.color = new Color(0.5f, 0.5f, 0.5f, 0.5f);
        if (manager.CustomDeathAudioSource != null && OneSceneManager.Instance.IsMinionAudEnabled)
        {
            manager.CustomDeathAudioSource.Play();
        }

        float BombRange = 0.25f;
        float BombDur = 0.8f;
        actor.transform.DOShakePosition(0.66f, new Vector3(0.1f, 0, 0.1f)).OnComplete(() => {
            manager.Actor.SetActive(false);
            manager.Portait.GetComponent<MeshRenderer>().material.color = new Color(1f, 1f, 1f, 1f);
            manager.IsActing = false;

            if (ImpactPrefab != null)
            {
                GameObject ImpactFx = GameObject.Instantiate(ImpactPrefab, Source.transform.position, Quaternion.Euler(new Vector3(0f, 180f, 0f))) as GameObject;
                ImpactFxs.Add(ImpactFx);
                ImpactFx.transform.rotation = Quaternion.Euler(new Vector3(0f, (float)UnityEngine.Random.Range(0f,360f), 0f));
                /*
                for (int i = 0; i < 13; i++)
                {
                    Vector3 RawPos = Source.transform.position; 
                    Vector3 TopPos = new Vector3(UnityEngine.Random.Range(-BombRange, BombRange), UnityEngine.Random.Range(BombRange / 2, BombRange), UnityEngine.Random.Range(-BombRange, BombRange));
                    GameObject Debris = LaunchFx.transform.GetChild(i).gameObject;
                    Debris.transform.DOMove(RawPos + TopPos, BombDur+UnityEngine.Random.Range(-0.33f,0.33f)).SetEase(Ease.Linear).OnComplete(() => {
                        Vector3 FinalPos = RawPos + TopPos * 2f;
                        FinalPos.y = RawPos.y;
                        Debris.transform.DOMove(FinalPos, BombDur+UnityEngine.Random.Range(-0.33f,0.33f)).SetEase(Ease.Linear).OnComplete(()=>{
                            Debris.transform.DOMove(new Vector3(FinalPos.x,-1f,FinalPos.z), 0.66f+UnityEngine.Random.Range(-0.33f,0.33f)).SetEase(Ease.InQuart);
                        });
                    });
                }
                */
            }
        });
        manager.ActiveCustomDeathVFX();
        Seq.AppendInterval(0.66f+BombDur*2+0.66f);
        return base.SetImpact(Seq, Source, Target, ImpactPrefab);
    }
}