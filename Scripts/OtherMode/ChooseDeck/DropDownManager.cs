using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DropDownManager : MonoBehaviour
{
    public bool IsTop=false;
    public Dropdown dp;
    public InputField DeckNameText;
    public CollectionViewManager cvm;
    public void Start()
    {
        Refresh();
    }

    public void Refresh()
    {
        DeckDbf.FliterAllDeckDbf();

        if(IsTop)
        {
            dp.captionText.text = "选择对方卡组";
        }
        else
        {
            dp.captionText.text = "选择我方卡组";
        }
        if(cvm!=null)
        {
            dp.captionText.text = "选择卡组";
        }
        dp.options.Clear();
        foreach (DeckDbf de in DeckDbf.AllDeckDbf)
        {
            Dropdown.OptionData dd = new Dropdown.OptionData();
            dd.text = de.DeckName;
            dp.options.Add(dd);
        }
    }
    public void ConformSelect(int ind)
    {
        foreach (DeckDbf de in DeckDbf.AllDeckDbf)
        {
            if (de.DeckName == dp.captionText.text)
            {
                if (IsTop)
                {
                    DeckDbf.TopDeck = de;
                }
                else 
                {
                    DeckDbf.LowDeck = de;
                }
                break;
            }
        }
    }

    public void EditingSelect(int ind)
    {
        foreach (DeckDbf de in DeckDbf.AllDeckDbf)
        {
            if (de.DeckName == dp.captionText.text)
            {
                DeckDbf.EditingDeck = de;
                DeckNameText.text = de.DeckName;
                cvm.dk.Refresh();
                break;
            }
        }
        
    }
}
