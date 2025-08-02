using UnityEngine;
using System.Collections;

public class AddDeckCardClick : MonoBehaviour
{
    public int ViewCardIndex;
    public CollectionViewManager mag;
        void Awake()
    {
    }

    void OnMouseDown()
    {
        if (DeckDbf.EditingDeck != null)
        {
            mag.AddCardToDeck(ViewCardIndex);
            
        }
    }

        void Update()
    {

    }
    void OnMouseUp()
    {

    }


}
