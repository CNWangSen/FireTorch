using UnityEngine;
using System.Collections;
using DG.Tweening;

public class DragCreatureAttack : DraggingActions
{
    public void Awake()
    {
        Targets = TargetingOptions.OpposingCharactersTauntFirst;
    }
    public override bool CanDrag
    {
        get
        {
            return base.CanDrag && GetComponentInParent<OneActorManager>().CanAttackNow;
        }
    }

    public override void OnStartDrag()
    {
        base.OnStartDrag();
        //if(tag.Contains("Hero"))
        //{
        //    GetComponentInParent<OneActorManager>().IsActing=true;
        //    transform.parent.DOMove(transform.parent.position+new Vector3(0f,1.5f,0f),0.66f);
        //}
    }
    public override void OnEndDrag()
    {
        if(tag.Contains("Hero"))
        {
            GetComponentInParent<OneActorManager>().IsActing=false;
            //transform.parent.DOMove(new Vector3(0f,0.3f,0f),0.66f);
        }        
        Hide();
        (bool targetValid, int targetID) = IsTargetValid();
        if (!targetValid)
        {
        }
        else
        {
            Request.CilentSend("Attack");
            Player owner = null;
            if (tag.Contains("Low"))
                owner = Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
            else
                owner = Game.NowGame.GetPlayerByID((int)GameTag.TopPlayerID);
            new EffectAttack(owner,SourceId:GetComponentInParent<IDHolder>().UniqueID,TargetId:targetID).Resolve();
        }
        transform.localPosition = new Vector3(0f,0.079f,0f);
    }

    protected override bool DragSuccessful()
    {
        return true;
    }
}
