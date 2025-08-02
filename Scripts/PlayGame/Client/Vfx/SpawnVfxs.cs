using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class SpawnHeroSocketIn : VfxBase
{
    public override Sequence SetLaunch(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject LaunchPrefab)
    {
        if(Game.NowGame.m_Mode ==GameMode.BattleGround)
        {
            return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
        }
        GameObject actor = Source;
        int ActorID = actor.GetComponent<IDHolder>().UniqueID;
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        //manager.ActiveCustomSpawnVFX();
        manager.IsActing = true;
        actor.transform.DOKill(false);
        manager.Actor.SetActive(true);
        manager.CardActor.SetActive(false);
        manager.CardBack.SetActive(false);
        if (manager.CustomStingerAudioSource != null && OneSceneManager.Instance.IsMinionAudEnabled==true)
        {
            manager.CustomStingerAudioSource.Play();
        }
        if (manager.CustomSummonAudioSource != null && OneSceneManager.Instance.IsMinionAudEnabled==true)
        {
            manager.CustomSummonAudioSource.Play();
        }

        float Tscale = 2f;
        Vector3 RightTransformPos = manager.ActingTargetPosition;
        VfxBase.CreateDissolveFx(ActorID);
        Seq.AppendInterval(0f);
        float StartTime=0f;
        float Xoffset=-2f;
        float Zoffset=2f;
        Seq.Insert(0f, actor.transform.DOMove(RightTransformPos + new Vector3(0f, 3f, 0f), 0.66f/Tscale).SetEase(Ease.OutExpo));
        if (manager.ControlBy == AreaPosition.Top)
        {
            StartTime=0.66f/Tscale;
            Xoffset=2f;
            Zoffset=-2f;
            Seq.Insert(0.66f/Tscale, actor.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, 0f)), 0.66f/Tscale).SetEase(Ease.OutExpo));
        }

        Seq.Insert(StartTime/Tscale+0.66f/Tscale,actor.transform.DOMoveX(RightTransformPos.x+Xoffset,2f/Tscale).SetEase(Ease.OutExpo));
        Seq.Insert(StartTime/Tscale+0.66f/Tscale,actor.transform.DOMoveY(RightTransformPos.y+1.5f,2f/Tscale).SetEase(Ease.OutExpo));
        Seq.Insert(StartTime/Tscale+0.66f/Tscale,actor.transform.DOMoveZ(RightTransformPos.z+Zoffset,2f/Tscale).SetEase(Ease.OutExpo));
        Seq.Insert(StartTime/Tscale+0.66f/Tscale, actor.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 45f, 0f)), 2f/Tscale).SetEase(Ease.OutExpo));
        Seq.Insert(StartTime/Tscale+2.66f/Tscale,actor.transform.DOMoveX(RightTransformPos.x,1f/Tscale).SetEase(Ease.InExpo));
        Seq.Insert(StartTime/Tscale+2.66f/Tscale,actor.transform.DOMoveY(RightTransformPos.y,1f/Tscale).SetEase(Ease.InExpo));
        Seq.Insert(StartTime/Tscale+2.66f/Tscale,actor.transform.DOMoveZ(RightTransformPos.z,1f/Tscale).SetEase(Ease.InExpo));
        Seq.Insert(StartTime/Tscale+2.66f/Tscale, actor.transform.DORotateQuaternion(Quaternion.Euler(new Vector3(0f, 0f, 0f)), 1f/Tscale).SetEase(Ease.InExpo));
        //s.Insert(1.32f,actor.transform.DOMove(RightTransform[0] + new Vector3(+3f, 0f, -3f),0.66f));

        //actor.transform.position = RightTransform[0] + new Vector3(0f, 2f, 0f);
        //actor.transform.rotation = Quaternion.Euler(new Vector3(0f, 0f, 0f));
        //actor.transform.DOMove(RightTransform[0] + new Vector3(0f, 0.5f, 0f), 0.33f)
        Sequence LaunchSeq = DOTween.Sequence();
        LaunchSeq.AppendInterval(StartTime/Tscale+3.66f/Tscale);
        LaunchSeq.OnComplete(() =>
        {
            VfxBase.CreateDropAshFx(ActorID);
            actor.GetComponent<OneActorManager>().IsActing = false;
            manager.Actor.SetActive(true);
            manager.CardActor.SetActive(false);
            manager.CardBack.SetActive(false);
            Command.CommandExecutionComplete();
        });

        return base.SetLaunch(Seq, Source, Target, LaunchPrefab);
    }
    public override Sequence SetImpact(Sequence Seq, GameObject Source, List<GameObject> Target, GameObject ImpactPrefab)
    {
        if(Game.NowGame.m_Mode==GameMode.BattleGround)
        {
            return base.SetImpact(Seq, Source, Target, ImpactPrefab);
        }
        GameObject actor = Source;
        OneActorManager manager = actor.GetComponent<OneActorManager>();
        manager.IsActing = true;
        manager.Actor.SetActive(false);
        actor.transform.DOShakePosition(0.66f, new Vector3(0.5f, 0, 0.5f)).OnComplete(() => {
            manager.Actor.SetActive(true);
            manager.IsActing = false;
        });
        if (ImpactPrefab != null)
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