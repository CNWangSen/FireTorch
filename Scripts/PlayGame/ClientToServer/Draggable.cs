using UnityEngine;
using System.Collections;
using DG.Tweening;


public class Draggable : MonoBehaviour
{
    private bool dragging = false;
    private DraggingActions da;
    private static Draggable _draggingThis;
    public static Draggable DraggingThis
    {
        get { return Draggable._draggingThis; }
    }
    void Awake()
    {
        this.da = GetComponent<DraggingActions>();
    }

    void OnMouseDown()
    {
        this.da = GetComponent<DraggingActions>();
        if (this.da != null && this.da.CanDrag)
        {
            this.dragging = true;
            HoverPreview.PreviewsAllowed = false;
            Draggable._draggingThis = this;
            this.da.OnStartDrag();
            //yDisplacement = -Camera.main.transform.position.y + transform.position.y;
            //pointerDisplacement = -transform.position + MouseInWorldCoords();
        }
        else
        {
            //EmoteEffect.CreateEmoteEffect(Game.NowGame.GetPlayerByID((int)GameTag.LowPlayerID).hero[0].id, "我不能 那样做");
        }
    }

    void Update()
    {
        if (this.dragging)
        {
            int HalfW=Screen.width/2;
            int HalfH=Screen.height/2;
            float zoff=Camera.main.transform.position.y / 2f;
            this.da.OnDraggingInUpdate(new Vector3((Input.mousePosition.x - HalfW) / (HalfW / zoff), 1f, (Input.mousePosition.y - HalfH) / (HalfW / zoff)));
        }
    }

    void OnMouseUp()
    {
        if (this.dragging)
        {
            this.dragging = false;
            HoverPreview.PreviewsAllowed = true;
            Draggable._draggingThis = null;
            this.da.OnEndDrag();
        }
    }
}
