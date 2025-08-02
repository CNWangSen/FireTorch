using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;

public class genCV:MonoBehaviour
{
    public Camera renderCamera;

    public Material Data;
    public Material Label;
    

    public List<GameObject> Human;

    public GameObject Root;
    public Dictionary<string,Vector3> RawPos=new Dictionary<string,Vector3>();
    public Dictionary<string,Vector3> RawRot=new Dictionary<string,Vector3>();
    public int CNT=0;
    private int MAX=5000;
    private int EV=1;
    public void Start()
    {
        Application.runInBackground=true;
        List<Transform> ToRem = new List<Transform>();
        foreach(Transform t in Root.transform.GetComponentsInChildren<Transform>(true))
        {
            ToRem.Add(t);
        }

        ToRem.Add(renderCamera.transform);
        foreach (Transform t in ToRem)
        {
            string Name = t.gameObject.name;
            Vector3 Pos=Vector3.zero;
            Vector3 Rot=Vector3.zero;

            Pos.x=t.position.x;
            Pos.y=t.position.y;
            Pos.z=t.position.z;
            Rot.x=t.eulerAngles.x;
            Rot.y=t.eulerAngles.y;
            Rot.z=t.eulerAngles.z;

            RawPos.Add(Name,Pos);
            RawRot.Add(Name,Rot);
        }        
    }
    public void Update()
    {
        CNT+=1;
        if(CNT%EV==0 && CNT<=EV*MAX)
        {
            float dp = 0.1f;
            float dr = 1f;
            float ds = 0.03f;

            renderCamera.transform.position=RawPos["renderCamera"]+new Vector3(UnityEngine.Random.Range(-dp,dp),UnityEngine.Random.Range(-dp,dp),UnityEngine.Random.Range(-dp,dp));
            renderCamera.transform.eulerAngles=RawRot["renderCamera"]+new Vector3(UnityEngine.Random.Range(-dr,dr),UnityEngine.Random.Range(-dr,dr),UnityEngine.Random.Range(-dr,dr));

            foreach (Transform t in Root.transform.GetComponentsInChildren<Transform>(true))
            {
                dp = 0.00f;
                dr = 0.1f;
                ds = 0.03f;

                Vector3 Pos = RawPos[t.gameObject.name];
                Vector3 Rot = RawRot[t.gameObject.name];


                t.position=Pos+new Vector3(UnityEngine.Random.Range(-dp,dp),UnityEngine.Random.Range(-dp,dp),UnityEngine.Random.Range(-dp,dp));
                t.eulerAngles=Rot+new Vector3(UnityEngine.Random.Range(-dr,dr),UnityEngine.Random.Range(-dr,dr),UnityEngine.Random.Range(-dr,dr));
                t.localScale = new Vector3(UnityEngine.Random.Range(1f-ds,1f+ds),UnityEngine.Random.Range(1f-ds,1f+ds),UnityEngine.Random.Range(1f-ds,1f+ds));
            }

            foreach(GameObject obj in Human)
            {
                obj.GetComponent<SkinnedMeshRenderer>().material = Data;
            }
            this.SaveImg("//172.16.0.233/ws/CV/RF/data/train/x/"+((int)(CNT/EV)).ToString()+".jpg");
            foreach(GameObject obj in Human)
            {
                obj.GetComponent<SkinnedMeshRenderer>().material = Label;
            }
            this.SaveImg("//172.16.0.233/ws/CV/RF/data/train/y/"+((int)(CNT/EV)).ToString()+".jpg");
        }
    }

    public void SaveImg(string savePath)
    {
        int width = 288*1;
        int height = 384*1;

        if (renderCamera.targetTexture != null){
            RenderTexture.ReleaseTemporary(renderCamera.targetTexture);
            renderCamera.targetTexture = null;
            RenderTexture.active = null;
        }

        // 创建 RenderTexture
        RenderTexture rt = new RenderTexture(width, height, 16, RenderTextureFormat.ARGB32);
        renderCamera.targetTexture = rt;
        GL.Clear(true, true, Color.clear); // 清除颜色和深度缓冲区
        renderCamera.Render();
        RenderTexture.active = rt;

        // 创建 Texture2D 并读取图像数据
        Texture2D image = new Texture2D(width, height, TextureFormat.ARGB32, false);
        image.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        image.Apply();

        // 重要：将 targetTexture 设置为 null，以便相机继续渲染到主屏幕
        renderCamera.targetTexture = null;
        RenderTexture.active = null;

        byte[] bytes = image.EncodeToJPG();
        if (bytes != null){
            File.WriteAllBytes(savePath, bytes);
        }
    }
}