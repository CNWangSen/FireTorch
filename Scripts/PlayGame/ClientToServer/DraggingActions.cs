using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;

public class DraggingActions : MonoBehaviour {
    public TargetingOptions Targets = TargetingOptions.NoTarget;
    public GameObject Target;

    
    public virtual void OnStartDrag()
    {
        //new ThinkingMarkerOffCommand().AddToQueue();
        if (Targets == TargetingOptions.NoTarget)
        {
            return;
        }
        Player owner = null;
        if (tag.Contains("Low"))
            owner = Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
        else
            owner = Game.NowGame.GetPlayerByID((int)GameTag.TopPlayerID);
        List<Card> allt = owner.GetValidTargetMatchOption(Targets);
        foreach (Card c in allt)
        {
            GameObject source = IDHolder.GetGameObjectWithID(c.GetTag(GameTag.EntityId));
            if(source!=null)
            {
                source.GetComponentInParent<OneActorManager>().EnableHighLight(true);
                source.GetComponentInParent<OneActorManager>().SetHighLightColor(new Color(1f, 0f, 0f, 1f));                
            }

        }
    }

    public virtual void OnEndDrag(){}

    public virtual (bool,int) IsTargetValid()
    {
        Target = HoverPreview.HoveringObject;
        OneSceneManager.Instance.ArrowTarget.SetActive(false);
        OneSceneManager.Instance.ArrowTarget.transform.DOScale(new Vector3(0.75f,0.75f,0.75f),1f).SetEase(Ease.OutQuint);
        Player owner = null;
        if (tag.Contains("Low"))
            owner = Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
        else
            owner = Game.NowGame.GetPlayerByID((int)GameTag.TopPlayerID);
        List<Card> allt = owner.GetValidTargetMatchOption(Targets);
        List<int> allId = new List<int>();
        foreach (Card c in allt)
        {
            GameObject source = IDHolder.GetGameObjectWithID(c.GetTag(GameTag.EntityId));
            if(source!=null)
            {
                source.GetComponentInParent<OneActorManager>().EnableHighLight(false);
                source.GetComponentInParent<OneActorManager>().SetHighLightColor(new Color(1f, 1f, 1f, 1f));
                allId.Add(c.GetTag(GameTag.EntityId));                
            }
        }

        int targetID=-1;
        bool targetValid = false;
        if (Target != null)
        {
            targetID = Target.GetComponent<IDHolder>().UniqueID;
            if (allId.Contains(targetID))
            {
                targetValid = true;
            }

            Card sour = owner.myGame.CardsInGame[this.gameObject.GetComponentInParent<IDHolder>().UniqueID];
            Card targ = owner.myGame.CardsInGame[targetID];
            if ((sour.cardType==CardType.Spell || sour.cardType==CardType.HeroPower)&&targ.HasAbility("Elusive"))
            {
                targetValid = false;
            }
        }
        return (targetValid,targetID);
    }

    public virtual void OnDraggingInUpdate(Vector3 Position)
    {   
        if (Targets == TargetingOptions.NoTarget)
        {
            return;
        }

        Show();
        Position = Position*2f;//new Vector3((Input.mousePosition.x - 960) / (960 / 8.8f), 0f, (Input.mousePosition.y -540) / (960 / 8.8f));
        SetPositions(transform.parent.position, Position-transform.parent.position);
        GameObject arrowTarget=OneSceneManager.Instance.ArrowTarget;
        if( HoverPreview.HoveringObject != null )
        {
            arrowTarget.SetActive(true);
            arrowTarget.transform.position=HoverPreview.HoveringObject.transform.position+new Vector3(0f,0.2f,0f);
            if(arrowTarget.transform.localScale== new Vector3(0.75f,0.75f,0.75f))
            arrowTarget.transform.DOScale(new Vector3(1f,1f,1f),1f).SetEase(Ease.OutQuint);   
        }
        else
        {
            arrowTarget.SetActive(false);
            arrowTarget.transform.localScale = new Vector3(0.75f,0.75f,0.75f);//transform.DOScale(new Vector3(0.0.75f,0.0.75f,0.0.75f),1f).SetEase(Ease.OutQuint);  
        }
    }

    public virtual bool CanDrag
    {
        get
        {
            return true;// OneSceneManager.Instance.CanControlThisPlayer(playerOwner);
        }
    }

    protected virtual Player playerOwner
    {
        get{

            if (this.gameObject.transform.parent.tag.Contains("Low"))
            return Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID);
            else if (this.gameObject.transform.parent.tag.Contains("Top"))
            return Game.NowGame.GetPlayerByID((int)GameTag.TopPlayerID);
            else
            {
                Debug.LogError("Untagged Card or creature " + transform.parent.name);
                return null;
            }
        }
    }

    protected virtual bool DragSuccessful(){return true;}

    private float height = 0.5f;
    private float segmentLength = 1.1f;//2f;//1.1f;
    private float fadeDistance = 0.1f;//0.1f;
    private float speed = 1f;

    //[SerializeField] GameObject arrowPrefab;
    //[SerializeField] GameObject segmentPrefab;

    private Vector3 start;
    private Vector3 end;
    private Vector3 upwards = new Vector3(0f,1f,0f);

    private Transform arrow;

    readonly List<Transform> segments = new List<Transform>();
    readonly List<MeshRenderer> renderers = new List<MeshRenderer>();

    public void SetPositions(Vector3 start0, Vector3 end0)
    {
        start = start0;
        end = end0;
        UpdateSegments();
    }

    public void Hide()
    {        
        transform.localPosition = Vector3.zero;
        transform.localRotation = Quaternion.Euler(new Vector3(90f,0f,0f));
        foreach(Transform t in segments)
        {
            t.gameObject.SetActive(false);
        }
        arrow.gameObject.SetActive(false);
    }
    public void Show()
    {
        foreach(Transform t in segments)
        {
            t.gameObject.SetActive(true);
        }
        if(arrow!=null)
        arrow.gameObject.SetActive(true);
    }

    public void UpdateSegments()
    {
        //Debug.DrawLine(start, end, Color.yellow);

        float distance = Vector3.Distance(start, end);
        float radius = height / 2f + distance * distance / (8f * height);
        float diff = radius - height;
        float angle = 2f * Mathf.Acos(diff / radius);
        float length = angle * radius;
        float segmentAngle = segmentLength / radius * Mathf.Rad2Deg;

        Vector3 center = new Vector3(0, -diff, distance / 2f);
        Vector3 left = Vector3.zero;
        Vector3 right = new Vector3(0, 0, distance);

        int segmentsCount = (int)(length / segmentLength) + 1;

        CheckSegments(segmentsCount);

        float offset = Time.time * speed * segmentAngle;
        Vector3 firstSegmentPos =
        Quaternion.Euler(Mathf.Repeat(offset, segmentAngle), 0f, 0f) * (left - center) + center;

        float fadeStartDistance = (Quaternion.Euler(segmentAngle / 2f, 0f, 0f) * (left - center) + center).z;

        for (int i = 0; i < segmentsCount; i++)
        {
            Vector3 pos = Quaternion.Euler(segmentAngle * i, 0f, 0f) * (firstSegmentPos - center) + center;
            segments[i].localPosition = pos;
            segments[i].localRotation = Quaternion.FromToRotation(Vector3.up, pos - center);

            MeshRenderer rend = renderers[i];

            if (!rend)
            continue;

            Color currentColor = rend.material.color;
            currentColor.a = GetAlpha(pos.z - left.z, right.z - fadeDistance - pos.z, fadeStartDistance);
            rend.material.color = currentColor;
        }

        if (!arrow)
        arrow = Instantiate(OneSceneManager.Instance.ArrowHead, transform).transform;

        arrow.localPosition = right;
        arrow.localRotation = Quaternion.FromToRotation(Vector3.up, right - center);

        transform.position = start;
        transform.rotation = Quaternion.LookRotation(end - start, upwards);
    }

    void CheckSegments(int segmentsCount)
    {
        while (segments.Count < segmentsCount)
        {
            Transform segment = Instantiate(OneSceneManager.Instance.ArrowDash, transform).transform;
            segments.Add(segment);
            renderers.Add(segment.GetComponentInChildren<MeshRenderer>());
        }

        for (int i = 0; i < segments.Count; i++)
        {
            GameObject segment = segments[i].gameObject;
            if (segment.activeSelf != i < segmentsCount)
            segment.SetActive(i < segmentsCount);
        }
    }

    float GetAlpha(float distance0, float distance1, float distanceMax)
    {
        float alpha=Mathf.Clamp01(Mathf.Clamp01(distance0 / distanceMax) + Mathf.Clamp01(distance1 / distanceMax) - 1f);
        return alpha;
    }
}



/*
 switch (Targets)
 {
     case TargetingOptions.AllCharacters:
     if(Target.tag.Contains("Board") || Target.tag.Contains("Hero"))
     {
         targetValid = true;
     }
     break;
     case TargetingOptions.AllMinions:
     if (Target.tag.Contains("Board"))
     {
         targetValid = true;
     }
     break;
     case TargetingOptions.AllHeros:
     if(Target.tag.Contains("Hero"))
     {
         targetValid = true;
     }
     break;
     case TargetingOptions.AllHands:
     if(Target.tag.Contains("Hand"))
     {
         targetValid=true;
     }
     break;
     case TargetingOptions.AllPowers:
     if(Target.tag.Contains("Power"))
     {
         targetValid=true;
     }
     break;
     case TargetingOptions.EnemyCharacters:
     if (Target.tag.Contains("Board") || Target.tag.Contains("Hero"))
     {
         if ((tag.Contains("Low") && Target.tag.Contains("Top"))
          || (tag.Contains("Top") && Target.tag.Contains("Low")))
         {
             targetValid = true;
         }
     }
     break;
     case TargetingOptions.EnemyCharactersTauntFirst:
         if (Target.tag.Contains("Board") || Target.tag.Contains("Hero"))
         {
             if ((tag.Contains("Low") && Target.tag.Contains("Top"))
              || (tag.Contains("Top") && Target.tag.Contains("Low")))
             {
                 if (owner.IsValidTargetForOption(Targets, Card.CardsCreatedThisGame[targetID]))
                 {
                     targetValid = true;
                 }
             }
         }
         break;
     case TargetingOptions.EnemyMinions:
     if (Target.tag.Contains("Board"))
     {
         if ((tag.Contains("Low") && Target.tag.Contains("Top"))
             || (tag.Contains("Top") && Target.tag.Contains("Low")))
         {
             targetValid = true;
         }
     }
     break;
     case TargetingOptions.EnemyHeros:
     if (Target.tag.Contains("Hero"))
     {
         if ((tag.Contains("Low") && Target.tag.Contains("Top"))
             || (tag.Contains("Top") && Target.tag.Contains("Low")))
         {
             targetValid = true;
         }
     }
     break;
     case TargetingOptions.EnemyHands:
     if (Target.tag.Contains("Hand"))
     {
         if ((tag.Contains("Low") && Target.tag.Contains("Top"))
             || (tag.Contains("Top") && Target.tag.Contains("Low")))
         {
             targetValid = true;
         }
     }
     break; 
     case TargetingOptions.EnemyPowers:
     if (Target.tag.Contains("Power"))
     {
         if ((tag.Contains("Low") && Target.tag.Contains("Top"))
             || (tag.Contains("Top") && Target.tag.Contains("Low")))
         {
             targetValid = true;
         }
     }
     break; 
     case TargetingOptions.YourCharacters:
     if (Target.tag.Contains("Board") || Target.tag.Contains("Hero"))
     {
         if ((tag.Contains("Low") && Target.tag.Contains("Low"))
             || (tag.Contains("Top") && Target.tag.Contains("Top")))
         {
             targetValid = true;
         }
     }
     break;
     case TargetingOptions.YourMinions:
     if (Target.tag.Contains("Board"))
     {
         if ((tag.Contains("Low") && Target.tag.Contains("Low"))
             || (tag.Contains("Top") && Target.tag.Contains("Top")))
         {
             targetValid = true;
         }
     }
     break;
     case TargetingOptions.YourHeros:
     if (Target.tag.Contains("Hero"))
     {
         if ((tag.Contains("Low") && Target.tag.Contains("Low"))
             || (tag.Contains("Top") && Target.tag.Contains("Top")))
         {
             targetValid = true;
         }
     }
     break;

     case TargetingOptions.YourHands:
     if (Target.tag.Contains("Hand"))
     {
         if ((tag.Contains("Low") && Target.tag.Contains("Low"))
             || (tag.Contains("Top") && Target.tag.Contains("Top")))
         {
             targetValid = true;
         }
     }
     break;   
     case TargetingOptions.YourPowers:
     if (Target.tag.Contains("Power"))
     {
         if ((tag.Contains("Low") && Target.tag.Contains("Low"))
             || (tag.Contains("Top") && Target.tag.Contains("Top")))
         {
             targetValid = true;
         }
     }
     break; 
     case TargetingOptions.Any:
         targetValid = true;
     break;
     default:
     Debug.LogWarning("Reached default case in DragSpellOnTarget! Suspicious behaviour!!");
     break;
 }
 */