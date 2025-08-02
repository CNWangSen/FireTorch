using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Audio;

public class VignettePulse : MonoBehaviour
{
     //public Volume m_Volume;
     //private VolumeComponent m_Vignette;
     public float omg;
     public float bottom;
     public float top;
     public AudioMixer m_AudMixer;
     public AudioSource m_AudSrc;
     public static VignettePulse Instance;
     public bool StartShakeEffect=false;
     void Start()
     {
          VignettePulse.Instance = this;
          //m_Vignette = m_Volume.profile.components[0];
          //m_Vignette.parameters[0].overrideState=true;
     }
     void Update()
     {
          //if(this.StartShakeEffect)
          //{
               float db=(GetDb(m_AudSrc,5,0.0001f)-30f)/45f;
               //UnityEngine.Debug.Log(db);
               omg = UnityEngine.Random.Range(0f,0.1f)+db;
               float ToSet=db;//*(bottom + (Mathf.Sin(omg*Time.realtimeSinceStartup)+1)/2*(top-bottom));
               //m_Vignette.parameters[0].SetValue(new FloatParameter(ToSet));
               //float db = GetDb(m_AudSrc,5,0.0001f);
               //m_Vignette.parameters[0].SetValue(new FloatParameter(((db-30f)/50f)));//
          //}
     }
     public void StartChromaticShake()
     {
          StartShakeEffect=true;
     }
     public void EndChromaticShake()
     {
          StartShakeEffect=false;
          //m_Vignette.parameters[0].SetValue(new FloatParameter(0f));//0.177f));
     }
     void OnDestroy()
     {
     }

     public float GetFreq()
     {
          /*
          int FreLen=512;
          float[] ou=m_AudSrc.GetSpectrumData(FreLen,0,FFTWindow.BlackmanHarris);
          int MaxPos=0;
          float MaxNum=ou[MaxPos];
          for(int i=0;i<40;i++)
          {
               if(ou[i]>MaxNum)
               {
                    MaxPos = i;
                    MaxNum = ou[i];
               }
               //UnityEngine.Debug.Log(f);
          }
          UnityEngine.Debug.Log(MaxPos);
          return (float)MaxPos;
          */
          return 0f;  
     }
     public float GetDb(AudioSource audio, int length, float refValue)
     {
        float[] samples = new float[length];
        audio.GetOutputData(samples, 0); // fill array with samples
        var dbLeft = CalulateDb(length, refValue, samples);
        audio.GetOutputData(samples, 1);
        var dbRight = CalulateDb(length, refValue, samples);
        return Mathf.Max(dbLeft, dbRight);
     }

     private float CalulateDb(int length, float refValue, float[] samples)
     {
        var sum = 0f;
        for (int i = 0; i < length; i++)
        {
            sum += samples[i] * samples[i]; // sum squared samples
        }
        var rmsValue = Mathf.Sqrt(sum / length); // rms = square root of average
        var dbValue = 20 * Mathf.Log10(rmsValue / refValue); // calculate dB
        if (dbValue < -80) dbValue = -80; // clamp it to -160dB min

        return dbValue;
     }

}
