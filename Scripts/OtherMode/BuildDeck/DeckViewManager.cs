using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine.UI;
using System.IO;
public class DeckViewManager : MonoBehaviour
{
    List<CardDbf> editingCards = new List<CardDbf>();
    List<GameObject> deckCards = new List<GameObject>();
    public Text DeckNameText;

    public void CleanDeck()
    {
        if (DeckDbf.EditingDeck != null)
        {
            DeckDbf.EditingDeck.DeckName = "空";
            DeckDbf.EditingDeck.Hero = new List<CardDbf>();
            DeckDbf.EditingDeck.HeroPower = new List<CardDbf>();
            DeckDbf.EditingDeck.Cards = new List<CardDbf>();
            Refresh();
        }
    }

    public void RenameDeck(string ipt)
    {
        if (DeckDbf.EditingDeck != null)
        {
            DeckDbf.EditingDeck.DeckName = DeckNameText.text;
        }
    }

    public void Refresh()
    {
        editingCards.Clear();
        foreach (GameObject c in deckCards)
        {
            Destroy(c);
        }
        deckCards.Clear();
        foreach(CardDbf ca in DeckDbf.EditingDeck.Hero)
        { 
            editingCards.Add(ca);
        }
        foreach (CardDbf ca in DeckDbf.EditingDeck.HeroPower)
        {
            editingCards.Add(ca);
        }
        foreach (CardDbf ca in DeckDbf.EditingDeck.Cards)
        {
            editingCards.Add(ca);
        }
        for(int i =0;i< editingCards.Count; i++)
        {
            if (i > 15)
            {
                CreateViewCardAtPosition(editingCards[i], new Vector3(3.5f, 0.1f, 1.4f - (i-16) * 0.2f), new Vector3(90f,0f,0f));
            }
            else 
            {
                CreateViewCardAtPosition(editingCards[i], new Vector3(3f, 0.1f, 1.4f - i * 0.2f), new Vector3(90f,0f,0f));
            }
            
        }
    }

    public GameObject CreateViewCardAtPosition(CardDbf c, Vector3 position, Vector3 eulerAngles)
    {
        GameObject card=GameObject.Instantiate(OneSceneManager.Instance.DeckViewCardPrefab, position, Quaternion.Euler(eulerAngles)) as GameObject;
        OneDeckViewCardManager manager = card.GetComponent<OneDeckViewCardManager>();
        manager.ManaCost.text =c.ManaCost.ToString();
        if (c.CnName.Length > 2)
        {
            manager.Name.text = c.CnName.Substring(0, 3);
        }
        else 
        {
            manager.Name.text = c.CnName;
        }

        Texture2D _texture2d = null;
        if(OneActorManager.UseLocalHSPremium && !OneSceneManager.Instance.IsMyScene)
        {
            _texture2d = HSViewer.GetHSCardRawTexture(c.m_noteMiniGuid);
        }
        if(_texture2d==null)
        {
            _texture2d = MyAssetsLoader.GetCardDbfImageTexutre(c);
        }
        if(_texture2d!=null)
            manager.Graphic.sprite =Sprite.Create(_texture2d, new Rect(0, 0, _texture2d.width, _texture2d.height), Vector2.zero);
        
        deckCards.Add(card);
        card.transform.localScale = new Vector3(0.21f, 0.21f, 0.21f);
        card.AddComponent<RemoveDeckCardClick>();
        RemoveDeckCardClick click = card.GetComponentInChildren<RemoveDeckCardClick>();
        click.ViewCardIndex = deckCards.Count - 1;
        click.mag = this;
        return card;
    }

    public void RemoveCardFromDeck(int index)
    {
        CardDbf ca = editingCards[index];
        if (ca.CardType == CardType.Hero)
        {
            if(ca.ManaCost==0)
            {
                DeckDbf.EditingDeck.Hero.Remove(ca);  
            }
            else
            {
                DeckDbf.EditingDeck.Cards.Remove(ca);
            }
            
        }
        else
        {
            if (ca.CardType == CardType.HeroPower)
            {
                DeckDbf.EditingDeck.HeroPower.Remove(ca);
            }
            else
            {
                DeckDbf.EditingDeck.Cards.Remove(ca);
            }
        }
        Refresh();
    }
}