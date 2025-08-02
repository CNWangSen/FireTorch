using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
public class ImportSV//: EditorWindow
{
    //[MenuItem("Window/ImportSV")]
    //static void Init()
    //{
    //    ImportSV myWindow = (ImportSV)EditorWindow.GetWindow(typeof(ImportSV), false, "ImportSV", true); myWindow.Show();
    //}

    public static int cardId = 129621020;

    //private void OnGUI()
    //{

    //    GUILayout.Space(10);

    //    EditorGUIUtility.labelWidth = 30;
    //    ImportSV.cardId = EditorGUILayout.IntField("CardID", ImportSV.cardId);
    //    GUILayout.Space(30);
    //    if (GUILayout.Button("ImportSV"))
    //    {
            
    //        Debug.Log(ImportSV.cardId);
    //        LoadCard(ImportSV.cardId);
    //    }
    //}
    public static List<string> SVmaterialFloatPara = new List<string>(){
        "_FlagFront1Flash","_FlagFront1Distortion","_FlagFront1RenderType","_FlagFront1MoveType",
        "_FlagFront2Flash","_FlagFront2Distortion","_FlagFront2RenderType","_FlagFront2MoveType",
        "_FlagMiddleFlash","_FlagMiddleDistortion","_FlagMiddleRenderType","_FlagMiddleMoveType",
        "_FlagBack1Flash","_FlagBack1Distortion","_FlagBack1RenderType","_FlagBack1MoveType",
        "_FlagBack2Flash","_FlagBack2Distortion","_FlagBack2RenderType","_FlagBack2MoveType",
        "_FlagDistortionMoveType",
        "_SleeveSrcFactor",
        "_SleeveDstFactor",
        "_MypageAlpha",
        "_ColorAlpha",
        "_MypageBoundaryAlpha",
        "_MypageDivisionValue",
        "_Front1ScrollU","_Front1ScrollV","_Front1ScrollAngle","_Front1Rotate","_Front1Spiral",
        "_Front1FlashSpeed","_Front1FlashTimeOffset","_Front1FlashMin","_Front1FlashMax",
        "_Front1FixedRotate","_Front1_RenderType","_Front1_MoveType","_Front1_Flash","_Front1_Distortion",

        "_Front2ScrollU","_Front2ScrollV","_Front2ScrollAngle","_Front2Rotate","_Front2Spiral",
        "_Front2FlashSpeed","_Front2FlashTimeOffset","_Front2FlashMin","_Front2FlashMax",
        "_Front2FixedRotate","_Front2_RenderType","_Front2_MoveType","_Front2_Flash","_Front2_Distortion",

        "_MiddleScrollU","_MiddleScrollV","_MiddleScrollAngle","_MiddleRotate","_MiddleSpiral",
        "_MiddleFlashSpeed","_MiddleFlashTimeOffset","_MiddleFlashMin","_MiddleFlashMax",
        "_MiddleFixedRotate","_Middle_RenderType","_Middle_MoveType","_Middle_Flash","_Middle_Distortion",
    
        "_Back1ScrollU","_Back1ScrollV","_Back1ScrollAngle","_Back1Rotate","_Back1Spiral",
        "_Back1FlashSpeed","_Back1FlashTimeOffset","_Back1FlashMin","_Back1FlashMax",
        "_Back1FixedRotate","_Back1_RenderType","_Back1_MoveType","_Back1_Flash","_Back1_Distortion",

        "_Back2ScrollU","_Back2ScrollV","_Back2ScrollAngle","_Back2Rotate","_Back2Spiral",
        "_Back2FlashSpeed","_Back2FlashTimeOffset","_Back2FlashMin","_Back2FlashMax",
        "_Back2FixedRotate","_Back2_RenderType","_Back2_MoveType","_Back2_Flash","_Back2_Distortion",

        "_DistortionScrollU","_DistortionScrollV","_DistortionScrollAngle","_DistortionRotate","_DistortionSpiral",
        "_DistortionFlashSpeed","_DistortionFlashMin","_DistortionFlashMax",
        "_DistortionIntensityU","_DistortionIntensityV","_Distortion_MoveType","_Distortion_Flash",
    };
    public static List<string> SVmaterialColorPara = new List<string>(){
        "_Color","_Front1Color","_Front2Color","_MiddleColor","_Back1Color","_Back2Color",
    };
    public static List<string> SVmaterialTexPara = new List<string>(){
        "_Front1Tex","_Front2Tex","_MiddleTex","_Back1Tex","_Back2Tex","_DistortionTex"
    };

    public static void DownLoadGroupFloat(Material SrcMat,string folderName)
    {
        List<string> ParaStr = new List<string>();
        string savePath = "D:/DocFile/Unity3dRef/Assets/SVDataset/" + folderName + "/" + folderName+"paras.txt";
        foreach(string st in ImportSV.SVmaterialFloatPara)
        {
            float ToWrite = SrcMat.GetFloat(st);

            ParaStr.Add(st);
            //if(ToWrite!=null)
            //{
                ParaStr.Add(ToWrite.ToString());
            //}
            //else{
            //    ParaStr.Add("!");
            //}
        }

        foreach(string st in ImportSV.SVmaterialColorPara)
        {
            Color ToWrite = SrcMat.GetColor(st);

            ParaStr.Add(st+"_R");
            if(ToWrite!=null)
            {
                ParaStr.Add(ToWrite.r.ToString());
            }
            else{
                ParaStr.Add("!");
            }
            ParaStr.Add(st+"_G");
            if(ToWrite!=null)
            {
                ParaStr.Add(ToWrite.g.ToString());
            }
            else{
                ParaStr.Add("!");
            }
            ParaStr.Add(st+"_B");
            if(ToWrite!=null)
            {
                ParaStr.Add(ToWrite.b.ToString());
            }
            else{
                ParaStr.Add("!");
            }
            ParaStr.Add(st+"_A");
            if(ToWrite!=null)
            {
                ParaStr.Add(ToWrite.a.ToString());
            }
            else{
                ParaStr.Add("!");
            }
        }

        foreach(string st in ImportSV.SVmaterialTexPara)
        {
            Vector2 ToWrite = SrcMat.GetTextureScale(st);
            Vector2 ToWrite2 = SrcMat.GetTextureOffset(st);
            ParaStr.Add(st+"_TextureScaleX");
            if(ToWrite!=null)
            {
                ParaStr.Add(ToWrite[0].ToString());
            }
            else{
                ParaStr.Add("!");
            }

            ParaStr.Add(st+"_TextureScaleY");
            if(ToWrite!=null)
            {
                ParaStr.Add(ToWrite[1].ToString());
            }
            else{
                ParaStr.Add("!");
            }

            ParaStr.Add(st+"_TextureOffsetX");
            if(ToWrite2!=null)
            {
                ParaStr.Add(ToWrite2[0].ToString());
            }
            else{
                ParaStr.Add("!");
            }

            ParaStr.Add(st+"_TextureOffsetY");
            if(ToWrite2!=null)
            {
                ParaStr.Add(ToWrite2[1].ToString());
            }
            else{
                ParaStr.Add("!");
            }
        }
        File.WriteAllLines(savePath, ParaStr);
//        DistMat.SetTextureScale(DistTexRef, SrcMat.GetTextureScale(SrcTexRef));
//        DistMat.SetTextureOffset(DistTexRef, SrcMat.GetTextureOffset(SrcTexRef));
/*
        if (DistGroupID == "0")
        {
            CopyFloat(SrcMat, DistMat, "_DistortionIntensityU", "_DisturbAmpX");
            CopyFloat(SrcMat, DistMat, "_DistortionIntensityV", "_DisturbAmpY");
            CopyTexOffset(SrcMat, DistMat, "_MainTex", "_MainTex");
            CopyTexOffset(SrcMat, DistMat, "_MaskTex", "_MaskTex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex0", "_DistortionTex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex1", "_Front1Tex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex2", "_Front2Tex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex3", "_Back1Tex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex4", "_Back2Tex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex5", "_MiddleTex");

        }
        else
        {
            DistMat.SetColor("_BlendColor" + DistGroupID, SrcMat.GetColor("_" + SrcGoupID + "Color"));
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "_RenderType", "_BlendMode" + DistGroupID);//Add 1 sub 2 Trans 3 
        }


        if (SrcMat.GetFloat("_" + SrcGoupID + "_MoveType") == 4)//Fix 1 Pan 2 Rotate 3 Polar 4
        {
            DistMat.SetFloat("_Polar" + DistGroupID, 1);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "Spiral", "_Spiral" + DistGroupID,-1);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollAngle", "_RotateAngle" + DistGroupID);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollU", "_PanY" + DistGroupID);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollV", "_PanX" + DistGroupID,-1);
        }
        if (SrcMat.GetFloat("_" + SrcGoupID + "_MoveType") == 3)//Fix 1 Pan 2 Rotate 3 Polar 4
        {
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "Rotate", "_RotateSpd" + DistGroupID);
        }
        if (SrcMat.GetFloat("_" + SrcGoupID + "_MoveType") == 2)//Fix 1 Pan 2 Rotate 3 Polar 4
        {
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollAngle", "_RotateAngle" + DistGroupID);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollU", "_PanX" + DistGroupID);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollV", "_PanY" + DistGroupID);
        }
        if (SrcMat.GetFloat("_" + SrcGoupID + "_Flash") == 1)//Fix 1 Pan 2 Rotate 3 Polar 4
        {
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "FlashSpeed", "_FlashSpd" + DistGroupID, 0.1f);
        }
*/
    }
//    public static void CopyFloat(Material SrcMat, Material DistMat, string SrcRef, string DistRef, float multi = 1)
//    {
//        DistMat.SetFloat(DistRef, multi * SrcMat.GetFloat(SrcRef));
//    }

    public static void DownLoadTex(Texture2D rawTex,string folderName,string fileName)
    {
        if (rawTex != null)
        {
            byte[] dataBytes = duplicateTexture(rawTex).EncodeToPNG();
            string savePath = "D:/DocFile/Unity3dRef/Assets/SVDataset/" + folderName + "/" + folderName+fileName + ".png";
            FileStream fileStream = File.Open(savePath, FileMode.OpenOrCreate);
            fileStream.Write(dataBytes, 0, dataBytes.Length);
            fileStream.Close();
            //UnityEditor.AssetDatabase.SaveAssets();
            //UnityEditor.AssetDatabase.Refresh();
        }
    }
    public static AssetBundle assetbundle=null;
    public static AssetBundle assetbundle1=null;
    public static AssetBundle assetbundle2=null;
    public static void ExportDataSetID(int cardID)
    {
        //AssetBundle.UnloadAllAssetBundles(false);
        string cardStr = cardID.ToString();
        string cardFileStr = cardStr.Substring(0,8)+"00";
        assetbundle = AssetBundle.LoadFromFile("D:\\DocFile\\Unity3dRef\\Assets\\SVExtract\\card_"+ cardFileStr + ".unity3d");
        //if(ImportSV.assetbundle1==null)
        //{

            assetbundle1 = AssetBundle.LoadFromFile("D:\\DocFile\\Unity3dRef\\Assets\\SVExtract\\card_foiltextures.unity3d");
            assetbundle2 = AssetBundle.LoadFromFile("D:\\DocFile\\Unity3dRef\\Assets\\SVExtract\\card_shader_common.unity3d");    
        //}
        cardStr = cardStr.Insert(8, "1");
        Material material = assetbundle.LoadAsset<Material>(cardStr+"_M");

        /*
        Directory.CreateDirectory("D:/DocFile/Unity3dRef/Assets/SVDataset/"+ cardID.ToString()+"/");
        DownLoadTex(material.GetTexture("_MainTex") as Texture2D, cardID.ToString(), "Raw");
        DownLoadTex(material.GetTexture("_MaskTex") as Texture2D, cardID.ToString(), "Mask");
        DownLoadTex(material.GetTexture("_DistortionTex") as Texture2D, cardID.ToString(), "Distort");
        DownLoadTex(material.GetTexture("_Front1Tex") as Texture2D, cardID.ToString(), "Front1");
        DownLoadTex(material.GetTexture("_Front2Tex") as Texture2D, cardID.ToString(), "Front2");
        DownLoadTex(material.GetTexture("_Back1Tex") as Texture2D, cardID.ToString(), "Back1");
        DownLoadTex(material.GetTexture("_Back2Tex") as Texture2D, cardID.ToString(), "Back2");
        DownLoadTex(material.GetTexture("_MiddleTex") as Texture2D, cardID.ToString(), "Middle");
        */
        DownLoadGroupFloat(material,cardID.ToString());
        material = null;
 
        // 通知Unity来释放未使用的资源
        //Resources.UnloadUnusedAssets();
 
        // 强制进行垃圾回收
        //System.GC.Collect();
        AssetBundle.UnloadAllAssetBundles(true);
        return;        
    }
    public static void LoadCard(int cardID, GameObject plane = null, GameObject planeMy = null)
    {
        AssetBundle.UnloadAllAssetBundles(false);
        string cardStr = cardID.ToString();
        string cardFileStr = cardStr.Substring(0,8)+"00";


        assetbundle = AssetBundle.LoadFromFile("D:\\DocFile\\Unity3dRef\\Assets\\SVExtract\\card_"+ cardFileStr + ".unity3d");
        assetbundle1 = AssetBundle.LoadFromFile("D:\\DocFile\\Unity3dRef\\Assets\\SVExtract\\card_foiltextures.unity3d");
        assetbundle2 = AssetBundle.LoadFromFile("D:\\DocFile\\Unity3dRef\\Assets\\SVExtract\\card_shader_common.unity3d");

        cardStr = cardStr.Insert(8, "1");
        Material material = assetbundle.LoadAsset<Material>(cardStr+"_M");

        //Material.Instantiate<Material>(material);

        if(plane == null)
        {
            plane = GameObject.CreatePrimitive(PrimitiveType.Quad);
            plane.transform.localScale = new Vector3(10, 10, 1);
            plane.transform.eulerAngles = new Vector3(90f, 0f, 0f);
            plane.transform.position = new Vector3(-5f, 0.0001f, 0f);
            plane.name = "Card" + cardID.ToString();
        }

        plane.GetComponent<Renderer>().material = material;
        Directory.CreateDirectory(Application.dataPath + "/Resources/Arts/SVExtract/"+ cardID.ToString()+"/");
        CopyTex(material.GetTexture("_MainTex") as Texture2D, cardID.ToString(), "Raw");
        CopyTex(material.GetTexture("_MaskTex") as Texture2D, cardID.ToString(), "Mask");
        CopyTex(material.GetTexture("_DistortionTex") as Texture2D, cardID.ToString(), "Distort");
        CopyTex(material.GetTexture("_Front1Tex") as Texture2D, cardID.ToString(), "Front1");
        CopyTex(material.GetTexture("_Front2Tex") as Texture2D, cardID.ToString(), "Front2");
        CopyTex(material.GetTexture("_Back1Tex") as Texture2D, cardID.ToString(), "Back1");
        CopyTex(material.GetTexture("_Back2Tex") as Texture2D, cardID.ToString(), "Back2");
        CopyTex(material.GetTexture("_MiddleTex") as Texture2D, cardID.ToString(), "Middle");


        string ReadPathPrefix = "Assets/Resources/Arts/SVExtract/" + cardID.ToString() + "/" + cardID.ToString();
        Material materialMy = new Material(Shader.Find("Custom/GraphicAnimationEffect"));
        AddTex(materialMy, "_MainTex", cardID.ToString(), "Raw");
        AddTex(materialMy, "_MaskTex", cardID.ToString(), "Mask");
        AddTex(materialMy, "_BlendTex0", cardID.ToString(), "Distort");
        AddTex(materialMy, "_BlendTex1", cardID.ToString(), "Front1");
        AddTex(materialMy, "_BlendTex2", cardID.ToString(), "Front2");
        AddTex(materialMy, "_BlendTex3", cardID.ToString(), "Back1");
        AddTex(materialMy, "_BlendTex4", cardID.ToString(), "Back2");
        AddTex(materialMy, "_BlendTex5", cardID.ToString(), "Middle");

        CopyGroupFloat(material, materialMy, "Distortion", "0");
        CopyGroupFloat(material, materialMy, "Front1", "1");
        CopyGroupFloat(material, materialMy, "Front2", "2");
        CopyGroupFloat(material, materialMy, "Back1", "3");
        CopyGroupFloat(material, materialMy, "Back2", "4");
        CopyGroupFloat(material, materialMy, "Middle", "5");

        AssetDatabase.CreateAsset(materialMy, ReadPathPrefix +  "ReCreate.asset");

        if(planeMy == null)
        {
            planeMy = GameObject.CreatePrimitive(PrimitiveType.Quad);
            planeMy.transform.localScale = new Vector3(10, 10, 1);
            planeMy.transform.eulerAngles = new Vector3(90f, 0f, 0f);
            planeMy.transform.position = new Vector3(5f, 0.0001f, 0f);
            planeMy.name = "CardMy" + cardID.ToString();
        }
        planeMy.GetComponent<Renderer>().material = materialMy;
        AssetBundle.UnloadAllAssetBundles(false);
        
        return;
    }
    public static void CopyGroupFloat(Material SrcMat,Material DistMat, string SrcGoupID, string DistGroupID)
    {
        if (DistGroupID == "0")
        {
            CopyFloat(SrcMat, DistMat, "_DistortionIntensityU", "_DisturbAmpX");
            CopyFloat(SrcMat, DistMat, "_DistortionIntensityV", "_DisturbAmpY");
            CopyTexOffset(SrcMat, DistMat, "_MainTex", "_MainTex");
            CopyTexOffset(SrcMat, DistMat, "_MaskTex", "_MaskTex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex0", "_DistortionTex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex1", "_Front1Tex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex2", "_Front2Tex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex3", "_Back1Tex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex4", "_Back2Tex");
            CopyTexOffset(SrcMat, DistMat, "_BlendTex5", "_MiddleTex");
        }
        else
        {
            DistMat.SetColor("_BlendColor" + DistGroupID, SrcMat.GetColor("_" + SrcGoupID + "Color"));
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "_RenderType", "_BlendMode" + DistGroupID);//Add 1 sub 2 Trans 3 
        }


        if (SrcMat.GetFloat("_" + SrcGoupID + "_MoveType") == 4)//Fix 1 Pan 2 Rotate 3 Polar 4
        {
            DistMat.SetFloat("_Polar" + DistGroupID, 1);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "Spiral", "_Spiral" + DistGroupID,-1);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollAngle", "_RotateAngle" + DistGroupID);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollU", "_PanY" + DistGroupID);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollV", "_PanX" + DistGroupID,-1);
        }
        if (SrcMat.GetFloat("_" + SrcGoupID + "_MoveType") == 3)//Fix 1 Pan 2 Rotate 3 Polar 4
        {
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "Rotate", "_RotateSpd" + DistGroupID);
        }
        if (SrcMat.GetFloat("_" + SrcGoupID + "_MoveType") == 2)//Fix 1 Pan 2 Rotate 3 Polar 4
        {
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollAngle", "_RotateAngle" + DistGroupID);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollU", "_PanX" + DistGroupID);
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "ScrollV", "_PanY" + DistGroupID);
        }
        if (SrcMat.GetFloat("_" + SrcGoupID + "_Flash") == 1)//Fix 1 Pan 2 Rotate 3 Polar 4
        {
            CopyFloat(SrcMat, DistMat, "_" + SrcGoupID + "FlashSpeed", "_FlashSpd" + DistGroupID, 0.1f);
        }
    }

    public static void CopyTexOffset(Material SrcMat, Material DistMat, string DistTexRef, string SrcTexRef)
    {
        DistMat.SetTextureScale(DistTexRef, SrcMat.GetTextureScale(SrcTexRef));
        DistMat.SetTextureOffset(DistTexRef, SrcMat.GetTextureOffset(SrcTexRef));
    }
    public static void CopyFloat(Material SrcMat, Material DistMat, string SrcRef, string DistRef, float multi = 1)
    {
        DistMat.SetFloat(DistRef, multi * SrcMat.GetFloat(SrcRef));
    }
    public static void AddTex(Material mat,string TexRef, string folderName, string fileName)
    {
        Texture2D tex = AssetDatabase.LoadAssetAtPath("Assets/Resources/Arts/SVExtract/" + folderName + "/" + folderName + fileName + ".png", typeof(Texture2D)) as Texture2D;
        if (tex != null)
        {
            mat.SetTexture(TexRef,tex);
        }
    }
    public static void CopyTex(Texture2D rawTex,string folderName,string fileName)
    {
        if (rawTex != null)
        {
            byte[] dataBytes = duplicateTexture(rawTex).EncodeToPNG();
            string savePath = Application.dataPath + "/Resources/Arts/SVExtract/" + folderName + "/" + folderName+fileName + ".png";
            FileStream fileStream = File.Open(savePath, FileMode.OpenOrCreate);
            fileStream.Write(dataBytes, 0, dataBytes.Length);
            fileStream.Close();
            UnityEditor.AssetDatabase.SaveAssets();
            UnityEditor.AssetDatabase.Refresh();
        }
    }

    public static Texture2D duplicateTexture(Texture2D source)
    {
        RenderTexture renderTex = RenderTexture.GetTemporary(
                    source.width,
                    source.height,
                    0,
                    RenderTextureFormat.Default,
                    RenderTextureReadWrite.sRGB);

        Graphics.Blit(source, renderTex);
        RenderTexture previous = RenderTexture.active;
        RenderTexture.active = renderTex;
        Texture2D readableText = new Texture2D(source.width, source.height);
        readableText.ReadPixels(new Rect(0, 0, renderTex.width, renderTex.height), 0, 0);
        readableText.Apply();
        RenderTexture.active = previous;
        RenderTexture.ReleaseTemporary(renderTex);
        return readableText;
    }
}
#endif