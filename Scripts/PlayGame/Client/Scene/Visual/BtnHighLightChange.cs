using UnityEngine;

public class BtnHighLightChange:MonoBehaviour
{
	public void Start()
	{
		SetHighLightColor(Color.green);
	}
	public void OnMouseEnter()
	{
		SetHighLightColor(Color.white);
		OneSceneManager.Instance.CursorCatch();
	}

	public void OnMouseExit()
	{
		SetHighLightColor(Color.green);
		OneSceneManager.Instance.CursorMove();
	}

    public void SetHighLightColor(Color c)
    {
        float FlareFactor = Mathf.Pow(2, 1);
        float FrameFactor = Mathf.Pow(2, 1);
        if(c.r==1f && c.g==1f && c.b==1f)
        {
            FlareFactor = Mathf.Pow(2, 1);
            FrameFactor = Mathf.Pow(2, 1);
        }
        
        MeshRenderer Rend = this.transform.GetChild(0).gameObject.GetComponent<MeshRenderer>();
        Material newMat = Rend.material;
        newMat.SetColor("_FlareColor", new Color(c.r * FlareFactor, c.g * FlareFactor, c.b * FlareFactor));
        newMat.SetColor("_FrameColor", new Color(c.r * FrameFactor, c.g * FrameFactor, c.b * FrameFactor));
        Rend.material = newMat;
    }
}