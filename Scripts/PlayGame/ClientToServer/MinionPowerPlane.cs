using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine.UI;
public class MinionPowerPlane : DraggingActions
{
    private bool highlighted = false;
    private bool isOn = false;
    public List<GameObject> powerList = new List<GameObject>();
    public bool Highlighted
    {
        get { return true; }

        set
        {
            highlighted = value;
            GetComponentInParent<OneActorManager>().EnableHighLight(highlighted);
            if (value)
            {
                gameObject.transform.parent.DORotate(new Vector3(0f, 0f, 0f), 0.5f).SetEase(Ease.InExpo);
            }
            else
            {
                gameObject.transform.parent.DORotate(new Vector3(0f, 0f, 180f), 0.5f).SetEase(Ease.InExpo);
            }
        }
    }


    void OnMouseDown()
    {
        isOn = !isOn;
        int nowp = 0;
        foreach (GameObject pow in powerList)
        {

            if (isOn)
            {
                pow.transform.localPosition = new Vector3(0f, 0f, 0f);
                pow.SetActive(isOn);
                pow.transform.DOLocalMove(new Vector3(-2f + nowp * 2f, -1f, -4f), 0.33f).SetEase(Ease.OutQuint);
            }
            else 
            {
                pow.transform.DOLocalMove(new Vector3(0f, 0f, 0f), 0.33f).SetEase(Ease.OutQuint).OnComplete(() => { pow.SetActive(isOn); });
            }
            nowp += 1;
        }

        Player owner = null;
        if (tag.Contains("Low"))
            owner = Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
        else
            owner = Game.NowGame.GetPlayerByID((int)GameTag.TopPlayerID);
        Command.HighlightPlayableCards(owner);
    }


    public override void OnStartDrag()
    {
        base.OnStartDrag();
        return;
    }


    public override void OnEndDrag()
    {
        return;        
    }

    protected override bool DragSuccessful()
    {
        return true;
    }
}
