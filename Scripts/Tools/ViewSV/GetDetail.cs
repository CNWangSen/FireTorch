using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetDetail : MonoBehaviour
{
    public GameObject Animated;
    public GameObject Mask;
    public GameObject FxR;
    public GameObject FxG;
    public GameObject FxB;
    public GameObject FxA;
    // Start is called before the first frame update
    void Start()
    {
        Mask.GetComponent<MeshRenderer>().material.SetTexture("_BaseMap", Animated.GetComponent<MeshRenderer>().material.GetTexture("_MaskTex"));
        Mask.GetComponent<MeshRenderer>().material.SetColor("_BaseColor", new Color(1, 1, 1, 1));

        Texture R = Animated.GetComponent<MeshRenderer>().material.GetTexture("_BlendTex1");
        if (R != null)
        {
            FxR.GetComponent<MeshRenderer>().material.SetTexture("_BaseMap",R);
            FxR.GetComponent<MeshRenderer>().material.SetColor("_BaseColor", new Color(1, 1, 1, 1));
        }

        Texture G = Animated.GetComponent<MeshRenderer>().material.GetTexture("_BlendTex2");
        if (G != null)
        {
            FxG.GetComponent<MeshRenderer>().material.SetTexture("_BaseMap", G);
            FxG.GetComponent<MeshRenderer>().material.SetColor("_BaseColor", new Color(1, 1, 1, 1));
        }

        Texture B = Animated.GetComponent<MeshRenderer>().material.GetTexture("_BlendTex3");
        if (B != null)
        {
            FxB.GetComponent<MeshRenderer>().material.SetTexture("_BaseMap", B);
            FxB.GetComponent<MeshRenderer>().material.SetColor("_BaseColor", new Color(1, 1, 1, 1));
        }

        Texture A = Animated.GetComponent<MeshRenderer>().material.GetTexture("_BlendTex4");
        if (A != null)
        {
            FxA.GetComponent<MeshRenderer>().material.SetTexture("_BaseMap", A);
            FxA.GetComponent<MeshRenderer>().material.SetColor("_BaseColor", new Color(1, 1, 1, 1));
        }
    }

    public Texture2D GetChannel(Texture2D texture,int cn=0)
    {
        var newTexture = new Texture2D(texture.width, texture.height, TextureFormat.RGBA32, false);
        var colors = texture.GetPixels32();
        var targetColors = newTexture.GetPixels32();
        for (int i = 0, len = colors.Length; i < len; ++i)
        {
            var c = colors[i];
            if (cn == 0)
                targetColors[i] = new Color32(c.r, 0, 0, 255);
            if (cn == 1)
                targetColors[i] = new Color32(0, c.g, 0, 255);
            if (cn == 2)
                targetColors[i] = new Color32(0, 0, c.b, 255);
        }
        newTexture.SetPixels32(targetColors);
        newTexture.Apply();
        return newTexture;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
