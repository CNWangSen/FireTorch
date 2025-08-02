using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class HoverPreview: MonoBehaviour
{
    public GameObject TurnThisOffWhenPreviewing;      
    public Vector3 TargetPosition;
    public float TargetScale;
    public List<GameObject> previewGameObject;
    public bool ActivateInAwake = false;

    public static HoverPreview currentlyViewing = null;
    public static GameObject HoveringObject = null;

    private static bool _PreviewsAllowed = true;
    private bool Glowing = false;
    public static bool PreviewsAllowed
    {
        get { return _PreviewsAllowed;}

        set 
        { 
            _PreviewsAllowed= value;
            if (!_PreviewsAllowed)
            StopAllPreviews();
        }
    }

    public bool _thisPreviewEnabled = false;
    public bool ThisPreviewEnabled
    {
        get { return _thisPreviewEnabled;}

        set 
        { 
            _thisPreviewEnabled = value;
            if (!_thisPreviewEnabled)
            StopThisPreview();
        }
    }

    public bool OverCollider { get; set;}
    
    void Awake()
    {
        ThisPreviewEnabled = ActivateInAwake;
    }

    public Color HighLightCache = Color.green;
    void OnMouseEnter()
    {
        HoveringObject=this.gameObject.transform.parent.gameObject;
        OneSceneManager.Instance.CursorCatch();
        OverCollider = true;
        OneActorManager mgr = this.gameObject.GetComponentInParent<OneActorManager>();

        if (mgr != null)
        {
            if (mgr.IsHighLighting == false)
            {
                Glowing = false;
                mgr.EnableHighLight(true);
                mgr.SetHighLightColor(Color.white);
            }
            else 
            {
                this.HighLightCache=mgr.HighLightCache;
                Glowing = true;
                mgr.SetHighLightColor(Color.white);
            }
            
        } 
        if (PreviewsAllowed && ThisPreviewEnabled)
        PreviewThisObject();
    }
    
    void OnMouseExit()
    {
        HoveringObject=null;
        OneSceneManager.Instance.CursorMove();
        OverCollider = false;

        OneActorManager mgr = this.gameObject.GetComponentInParent<OneActorManager>();

        if (mgr != null)
        {
            if (Glowing)
            {
                mgr.SetHighLightColor(Color.green);
            }
            else 
            {
                mgr.SetHighLightColor(Color.green);
                mgr.EnableHighLight(false);
            }
        }

        if (!PreviewingSomeCard())
        StopAllPreviews();
    }
    //private Vector3 m_previousRot;
    void PreviewThisObject()
    {
        StopAllPreviews();
        currentlyViewing = this;
        foreach(GameObject obj in currentlyViewing.previewGameObject)
        {
            obj.SetActive(true);
            obj.transform.DOScale(TargetScale,1f).SetEase(Ease.OutQuint);
            obj.transform.DOLocalMove(TargetPosition,1f).SetEase(Ease.OutQuint);
            //m_previousRot=obj.transform.eulerAngles;
            //obj.transform.DOLocalRotate(-obj.transform.eulerAngles,0.1f);
            obj.GetComponentInParent<OneActorManager>().CardNameText.enabled=true;
            obj.GetComponentInParent<OneActorManager>().CardDescriptionText.enabled=true;
        }

    }

    void StopThisPreview()
    {
        foreach(GameObject obj in previewGameObject)
        {
            obj.SetActive(TurnThisOffWhenPreviewing!=null);
            obj.transform.localScale = new Vector3(0.3f,0.3f,0.3f);
            obj.transform.localPosition = Vector3.zero;
        }
    }

    private static void StopAllPreviews()
    {
        if (currentlyViewing != null)
        {
            if (currentlyViewing.previewGameObject != null)
            {

                if (currentlyViewing.TurnThisOffWhenPreviewing==null)
                {
                    foreach (GameObject obj in currentlyViewing.previewGameObject)
                    {
                        obj.SetActive(false);
                    }
                }
                foreach (GameObject obj in currentlyViewing.previewGameObject)
                {
                    //foreach(HoverPreview hp in obj.GetComponentInChildren<HoverPreview>())
                    //{
                    //    hp.StopThisPreview();
                    //}
                    obj.transform.DOScale(new Vector3(0.3f, 0.3f, 0.3f), 1f).SetEase(Ease.OutQuint);
                    obj.transform.DOLocalMove(Vector3.zero, 1f).SetEase(Ease.OutQuint);
                    //obj.transform.DOLocalRotate(-obj.transform.localEulerAngles,0.3f);
                    //obj.transform.localEulerAngles = Vector3.zero;
                    //obj.GetComponentInParent<OneActorManager>().CardNameText.enabled=false;
                    //obj.GetComponentInParent<OneActorManager>().CardDescriptionText.enabled=false;
                }

            }
            currentlyViewing = null;
        }
        
    }

    private static bool PreviewingSomeCard()
    {
        if (!PreviewsAllowed)
        return false;

        HoverPreview[] allHoverBlowups = GameObject.FindObjectsOfType<HoverPreview>();

        foreach (HoverPreview hb in allHoverBlowups)
        {
            if (hb.OverCollider && hb.ThisPreviewEnabled)
            return true;
        }

        return false;
    }

    
}
