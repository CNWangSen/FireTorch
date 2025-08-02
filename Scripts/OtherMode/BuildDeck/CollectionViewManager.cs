using UnityEditor;
using UnityEngine;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;

public class CollectionViewManager : MonoBehaviour
{
    List<CardDbf> flitedCards = new List<CardDbf>();
    List<GameObject> showingCards = new List<GameObject>();
    List<CardDbf> showingCardDbfs = new List<CardDbf>();
    List<CardDbf> NowMajorAssets=new List<CardDbf>();
    int showingStartIndex = 0;
    public List<Transform> showSlots = new List<Transform>();
    public List<TextMeshProUGUI> CollectionNumTxts = new List<TextMeshProUGUI>();
    public DeckViewManager dk;
    public Text SearchText;
    public void SortByMana()
    {
        int N=flitedCards.Count;
        for(int i=0;i<N;i++)
        {
            for(int j=0;j<N-i-1;j++)
            {
                if(flitedCards[j].ManaCost > flitedCards[j+1].ManaCost)
                {
                    CardDbf temp = flitedCards[j+1];
                    flitedCards[j+1]=flitedCards[j];
                    flitedCards[j]=temp;
                }
            }
        }
    }

    public void FiltCollectionByManaAll()
    {
        this.FiltCollectionByManaCost(-1);
    }
    public void FiltCollectionByManaEqualZero()
    {
        this.FiltCollectionByManaCost(0);
    }
    public void FiltCollectionByManaEqualOne()
    {
        this.FiltCollectionByManaCost(1);
    }
    public void FiltCollectionByManaEqualTwo()
    {
        this.FiltCollectionByManaCost(2);
    }
    public void FiltCollectionByManaEqualThree()
    {
        this.FiltCollectionByManaCost(3);
    }
    public void FiltCollectionByManaEqualFour()
    {
        this.FiltCollectionByManaCost(4);
    }
    public void FiltCollectionByManaEqualFive()
    {
        this.FiltCollectionByManaCost(5);
    }
    public void FiltCollectionByManaEqualSix()
    {
        this.FiltCollectionByManaCost(6);
    }
    public void FiltCollectionByManaGreaterThanSeven()
    {
        this.FiltCollectionByManaCost(7);
    }

    public void FiltCollectionByMajorAll()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.Monk);
    }
    public void FiltCollectionByMajorNeutral()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.Neutral);
    }
    public void FiltCollectionByMajorDeathKnight()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.DeathKnight);
    }
    public void FiltCollectionByMajorDemonHunter()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.DemonHunter);
    }
    public void FiltCollectionByMajorDruid()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.Druid);
    }
    public void FiltCollectionByMajorHunter()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.Hunter);
    }
    public void FiltCollectionByMajorMage()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.Mage);
    }
    public void FiltCollectionByMajorPaladin()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.Paladin);
    }
    public void FiltCollectionByMajorPriest()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.Priest);
    }
    public void FiltCollectionByMajorRogue()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.Rogue);
    }
    public void FiltCollectionByMajorShaman()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.Shaman);
    }
    public void FiltCollectionByMajorWarlock()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.Warlock);
    }
    public void FiltCollectionByMajorWarrior()
    {
        this.FiltCollectionByMajorIndex((int)ClassType.Warrior);
    }
    public void FiltCollectionByString()
    {
        string ToSearch = SearchText.text;
        flitedCards = CardDbf.FiltByString(NowMajorAssets,ToSearch);
        SortByMana();
        showingStartIndex = 0;
        showingCardDbfs.Clear();
        for (int i = 0; i < showSlots.Count; i++)
        {
            if (showingStartIndex + i < flitedCards.Count)
            {
                showingCardDbfs.Add(flitedCards[showingStartIndex + i]);
            }

        }
        Refresh();        
    }

    public void FiltCollectionByManaCost(int ManaCost)
    {
        if(ManaCost==-1 || ManaCost==7)
        {
            flitedCards = CardDbf.FiltByManaGreaterThan(NowMajorAssets,ManaCost);
        }
        else
        {
            flitedCards = CardDbf.FiltByMana(NowMajorAssets,ManaCost);
        }
        
        SortByMana();
        showingStartIndex = 0;
        showingCardDbfs.Clear();
        for (int i = 0; i < showSlots.Count; i++)
        {
            if (showingStartIndex + i < flitedCards.Count)
            {
                showingCardDbfs.Add(flitedCards[showingStartIndex + i]);
            }

        }
        Refresh();
    }

    public void FiltCollectionByMajorIndex(int MajorIndex)
    {
        if(MajorIndex==-1)
        {
            flitedCards=CardDbf.AllCardDbf;
        }
        else
        {
            flitedCards = CardDbf.FiltByMajor(CardDbf.AllCardDbf,(ClassType)MajorIndex);            
        }

        NowMajorAssets=flitedCards;
        SortByMana();
        showingStartIndex = 0;
        showingCardDbfs.Clear();
        for (int i = 0; i < showSlots.Count; i++)
        {
            if (showingStartIndex + i < flitedCards.Count)
            {
                showingCardDbfs.Add(flitedCards[showingStartIndex + i]);
            }

        }
        Refresh();
    }

    public void Update()
    {

    }
    public void Start()
    {
        CardDbf.LoadAllCardDbf();
        foreach(CardDbf dbf in CardDbf.AllCardDbf)
        {
            flitedCards.Add(dbf);
        }
        NowMajorAssets=flitedCards;
        SortByMana();
        showingStartIndex = 0;
        showingCardDbfs.Clear();
        for (int i = 0; i < showSlots.Count; i++)
        {
            if (showingStartIndex + i < flitedCards.Count)
            {
                //UnityEngine.Debug.Log(flitedCards[showingStartIndex + i].CnName);
                showingCardDbfs.Add(flitedCards[showingStartIndex + i]);
            }

        }
        Refresh();
    }

    public void Refresh()
    {
        foreach (GameObject ob in showingCards)
        {
            Destroy(ob);
        }
        showingCards.Clear();
        for (int i = 0; i < showSlots.Count; i++)
        {
            if(i<showingCardDbfs.Count)
            {
                CollectionNumTxts[i].enabled=true;
                CollectionNumTxts[i].text = "2";//;"x"+UserDbf.LoggedUser.CardCollectionNums[showingCardDbfs[i].DbfId].ToString();
                CreateAViewCardAtPosition(showingCardDbfs[i], showSlots[i].position, Vector3.zero);
            }
            else
            {
                CollectionNumTxts[i].enabled=false;
            }
        }
    }

    public void NextPage()
    {
        if (showingCardDbfs.Count < showSlots.Count)
        {
            return;
        }
        showingStartIndex += 8;
        showingCardDbfs.Clear();
        for (int i = 0; i < showSlots.Count; i++)
        {
            if (showingStartIndex + i < flitedCards.Count)
            {
                showingCardDbfs.Add(flitedCards[showingStartIndex + i]);
            }

        }
        Refresh();
    }
    public void PrePage()
    {
        if (showingStartIndex == 0)
        {
            return;
        }
        showingStartIndex -= 8;
        showingCardDbfs.Clear();

        for (int i = 0; i < showSlots.Count; i++)
        {
            if (showingStartIndex + i < flitedCards.Count)
            {
                showingCardDbfs.Add(flitedCards[showingStartIndex + i]);
            }

        }
        Refresh();
    }



    GameObject CreateAViewCardAtPosition(CardDbf c, Vector3 position, Vector3 eulerAngles)
    {
        eulerAngles = new Vector3(0f, 0f, 0f);
        if(c==null)
        {
            UnityEngine.Debug.Log("EMPTY");
            return null;
        }
        GameObject card = GameObject.Instantiate(OneSceneManager.Instance.CardPrefabs[(int)c.CardType], position, Quaternion.Euler(eulerAngles)) as GameObject;
        //card.transform.localScale = new Vector3(10f,10f,10f);
        OneActorManager manager = card.GetComponent<OneActorManager>();
        manager.UpdateAsset(c);
        manager.CardNameText.enabled=true;
        manager.CardDescriptionText.enabled=true;
        showingCards.Add(card);

        AudioSource au = card.GetComponentInChildren<AudioSource>();
        HoverPreview pv = card.GetComponentInChildren<HoverPreview>();
        pv.TargetPosition = new Vector3(0f, 0f, 0f);
        pv.TargetScale = 1f;
        Draggable dg = card.GetComponentInChildren<Draggable>();
        Destroy(au);
        Destroy(pv);
        Destroy(dg);
        
        card.transform.localScale = new Vector3(1.3f, 1.3f, 1.3f);
        pv.gameObject.AddComponent<AddDeckCardClick>();
        AddDeckCardClick click = pv.gameObject.GetComponentInChildren<AddDeckCardClick>();
        click.ViewCardIndex = showingCards.Count - 1;
        click.mag = this;
        return card;
    }

    public void AddCardToDeck(int ViewCardIndex)
    {
        CardDbf ca = showingCardDbfs[ViewCardIndex];
        if (ca.CardType == CardType.Hero)
        {
            if(ca.ManaCost==0)
            {
                if (DeckDbf.EditingDeck.Hero.Count < 1)
                    DeckDbf.EditingDeck.Hero.Add(ca);                
            }
            else
            {
                if (DeckDbf.EditingDeck.Cards.Count < 30)
                    DeckDbf.EditingDeck.Cards.Add(ca);                
            }

        }
        else
        {
            if (ca.CardType == CardType.HeroPower)
            {
                if (DeckDbf.EditingDeck.HeroPower.Count < 2)
                    DeckDbf.EditingDeck.HeroPower.Add(ca);
            }
            else
            {
                if (DeckDbf.EditingDeck.Cards.Count < 30)
                    DeckDbf.EditingDeck.Cards.Add(ca);
            }
        }
        dk.Refresh();
    }
}