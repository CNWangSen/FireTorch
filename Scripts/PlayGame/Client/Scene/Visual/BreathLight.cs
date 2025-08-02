using System.Collections;
using UnityEngine;

public class BreathLight : MonoBehaviour
{
    private Light myLight;
    private bool UpGoing=false;
    public float DeltaIntensity = 0.01f;
    public float MaxIntensity = 2f;
    public float MinIntensity = 0.1f;

    // Use this for initialization
    void Start()
    {
        myLight=this.gameObject.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UpGoing)
        {
            myLight.intensity += DeltaIntensity;
            if (myLight.intensity >= MaxIntensity)
            {
                UpGoing = false;
            }
        }
        else 
        {
            myLight.intensity -= DeltaIntensity;
            if (myLight.intensity <= MinIntensity)
            {
                UpGoing = true;
            }
        }
    }
}