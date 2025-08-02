using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Audio;
public class CameraShakeManager : MonoBehaviour
{
    private bool IsShaking;
    private static int ShakeFrame;
    private float ShakeIntense;
    private Vector3 InitPos;
    private Vector3 InitRot;
    private float ShakeDur;
    public Light MainLight;
    public Light SubLight;
    public float MainLightIntense = 0.8f;
    public float SubLightIntense = 0.5f;
    private int LightMode;

    void Awake()
    {
        InitPos = gameObject.transform.position;
        InitRot = gameObject.transform.eulerAngles;
        if (MainLight != null && SubLight != null)
        {
            MainLightIntense = MainLight.intensity;
            SubLightIntense = SubLight.intensity;
        }
    }

    private void Update()
    {
        if (MainLight != null && SubLight != null)
        {
            if (LightMode == -1)
            {
                MainLight.intensity -= 0.05f;
                SubLight.intensity -= 0.05f;
                if (MainLight.intensity <= 0.4f)
                {
                    LightMode = 0;
                    MainLight.intensity = 0.4f;
                    SubLight.intensity = 0.4f;
                }
            }
            if (LightMode == 1)
            {
                MainLight.intensity += 0.05f;
                SubLight.intensity += 0.05f;
                if (MainLight.intensity >= 1f)
                {
                    LightMode = 0;
                    MainLight.intensity = MainLightIntense;
                    SubLight.intensity = SubLightIntense;
                }
            }
        }
        
        float move = 0.01f;
        float rot = 0.05f;
        if (Input.GetKey(KeyCode.Q))
        {
            if(InitPos.y<15f)//8.3f)
                InitPos += new Vector3(0f, move, 0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            InitPos += new Vector3(-move, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.E))
        {
            InitPos += new Vector3(0f, -move, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            InitPos += new Vector3(move, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.S))
        {
            InitPos += new Vector3(0f, 0f, -move);
        }
        if (Input.GetKey(KeyCode.W))
        {
            InitPos += new Vector3(0f, 0f, move);
        }
        if (Input.GetKey(KeyCode.Z))
        {
            InitRot += new Vector3(rot, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.C))
        {
            InitRot += new Vector3(-rot, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.R))
        {
            InitPos = new Vector3(0f, 7.556943f, 0f);
            InitRot = new Vector3(90f,0f,0f);
        }
        if (Input.GetKey(KeyCode.F))
        {
            InitPos = new Vector3(0.03f, 3.996861f, -0.22f);
        }
        this.gameObject.transform.position = InitPos;
        this.gameObject.transform.eulerAngles = InitRot;
        if (IsShaking)
        {
            if (ShakeFrame < 30* ShakeDur)
            {
                Vector3 b = new Vector3();
                b.x = UnityEngine.Random.Range(-ShakeIntense, ShakeIntense);
                b.y = UnityEngine.Random.Range(-ShakeIntense, ShakeIntense);
                b.z = UnityEngine.Random.Range(-ShakeIntense, ShakeIntense);
                this.gameObject.transform.position = InitPos+b;
                ShakeFrame += 1;
            }
            else 
            {
                ShakeFrame = 0;
                IsShaking = false;
                this.gameObject.transform.position = InitPos;
            }
        }
        
    }

    public void StartShake(float Intense, float Dur=1f)
    {

        if (IsShaking == false)
        {
            IsShaking = true;
        }
        else 
        {
            ShakeFrame = 0;
            this.gameObject.transform.position = InitPos;
        }

        ShakeIntense = 0.2f*Intense;
        ShakeDur = Dur;
    }

    public void TurnOffLight()
    {
        LightMode = -1;
    }
    public void TurnUpLight()
    {
        LightMode = 1;
    }
}
