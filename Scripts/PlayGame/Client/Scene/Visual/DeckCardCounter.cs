using System.Collections;
using UnityEngine;

public class DeckCardCounter : MonoBehaviour
{

    void Start()
    {
        //this.gameObject.SetActive(false);
    }

    void OnMouseEnter()
    {
        this.gameObject.SetActive(true);
    }

    void OnMouseExit()
    {
        this.gameObject.SetActive(false);
    }
}