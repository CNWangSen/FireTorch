using UnityEngine;
using System.Collections;
using DG.Tweening;

public class DragOnTarget : DraggingActions
{

    public override bool CanDrag
    {
        get
        {
            return base.CanDrag && GetComponentInParent<OneActorManager>().CanBePlayedNow;
        }
    }

 
    public override void OnStartDrag()
    {
        base.OnStartDrag();
        GetComponentInParent<OneActorManager>().IsActing = true;
    }


    public override void OnEndDrag()
    {
        Hide();
        GetComponentInParent<OneActorManager>().IsActing = false;
        if (!DragSuccessful())
        {
        }
        else
        {
            (bool targetValid, int targetID) = IsTargetValid();
            if (!targetValid)
            {
            }
            else
            {
                Request.CilentSend("DragOnTarget");
                Player owner = null;
                if (tag.Contains("Low"))
                    owner = Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
                else
                    owner = Game.NowGame.GetPlayerByID((int)GameTag.TopPlayerID);
                new EffectPlay(owner,CardId:GetComponentInParent<IDHolder>().UniqueID, TargetId:targetID).Resolve();
                GetComponentInParent<OneActorManager>().CanBePlayedNow = false;
            }
        }
    }

    protected override bool DragSuccessful()
    {
        bool TableNotFull = (playerOwner.board.Count < 7);
        return true;
    }
}
