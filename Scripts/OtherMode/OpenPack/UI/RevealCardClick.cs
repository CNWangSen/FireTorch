using UnityEngine;
using System.Collections;

public class RevealCardClick : MonoBehaviour
{
    public int ViewCardIndex;
    public OpenPackManager mag;
    public bool revealed = false;
        void Awake()
    {
    }

    void OnMouseDown()
    {
        if (!revealed)
        {
            revealed = true;
            mag.RevealCard(ViewCardIndex);
        }
    }

        void Update()
    {

    }
    void OnMouseUp()
    {

    }


}
