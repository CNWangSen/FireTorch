using UnityEngine;
using System.Collections;

public class RemoveDeckCardClick : MonoBehaviour
{
    public int ViewCardIndex;
    public DeckViewManager mag;
        void Awake()
    {
    }

    void OnMouseDown()
    {
        if (DeckDbf.EditingDeck != null)
        {
            mag.RemoveCardFromDeck(ViewCardIndex);

        }
    }

        void Update()
    {

    }
    void OnMouseUp()
    {

    }


}
