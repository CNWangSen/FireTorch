using UnityEngine;
using System.Collections;
using DG.Tweening;
using UnityEngine.UI;
public class HeroPowerButton : DraggingActions
{
    private bool highlighted = false;
    public bool Highlighted
    {
        get { return highlighted; }

        set
        {
            highlighted = value;
            GetComponentInParent<OneActorManager>().EnableHighLight(highlighted);
            if (value)
            {
                FlipFront();
                //gameObject.transform.parent.DORotate(new Vector3(0f, 0f, 0f),0.5f).SetEase(Ease.InExpo);
            }
            else 
            {
                //gameObject.transform.parent.DORotate(new Vector3(0f, 0f, 180f),0.5f).SetEase(Ease.InExpo);
            }
        }
    }

    public void FlipBack()
    {
        gameObject.transform.parent.DORotate(new Vector3(0f, 0f, 180f),0.5f).SetEase(Ease.OutExpo);
    }
    public void FlipFront()
    {
        gameObject.transform.parent.DORotate(new Vector3(0f, 0f, 0f),0.5f).SetEase(Ease.InExpo);
    }
    void OnMouseDown()
    {
        if (Targets == TargetingOptions.NoTarget && Highlighted)
        {
            Request.CilentSend("UseHeroPowerNoTarget");
            Player owner = null;
            if (tag.Contains("Low"))
                owner = Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
            else
                owner = Game.NowGame.GetPlayerByID((int)GameTag.TopPlayerID);
            FlipBack();
            new EffectUseHeroPower(owner,SourceId:GetComponentInParent<IDHolder>().UniqueID,TargetId:-1).Resolve();
        }
        else
        {

        }

    }


    public override void OnStartDrag()
    {
        base.OnStartDrag();
        if (Targets == TargetingOptions.NoTarget || Highlighted==false)
        {
            return;
        }

    }


    public override void OnEndDrag()
    {

        if (Targets == TargetingOptions.NoTarget)
        {
            return;
        }
        Hide();
        (bool targetValid, int targetID) = IsTargetValid();
        if (targetValid && Highlighted)
        {   
            Request.CilentSend("UseHeroPowerOnTarget");       
            Player owner = null;
            if (tag.Contains("Low"))
                owner = Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
            else
                owner = Game.NowGame.GetPlayerByID((int)GameTag.TopPlayerID);
            FlipBack();
            new EffectUseHeroPower(owner,SourceId:this.gameObject.transform.parent.GetComponent<IDHolder>().UniqueID,TargetId:targetID).Resolve();
        }
        transform.localPosition = new Vector3(0f, 0f, 0.4f);
    }

    protected override bool DragSuccessful()
    {
        return true;
    }
}
