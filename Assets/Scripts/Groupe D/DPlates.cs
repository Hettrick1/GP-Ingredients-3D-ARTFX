using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DPlates : Interactive
{
    bool isSameSoup;
    DBowl bowl;
    [SerializeField] private D_SoupType soupType;
    [SerializeField] private int index;

    public override void OnInteraction()
    {
        bowl = FindObjectOfType<DBowl>();
        SetSoup(bowl.GetSoupIndex());
    }
    public void SetSoup(int soupIndex)
    {
        if (soupIndex == (int)soupType)
        {
            isSameSoup = true;
            DQuestBook.instance.AddGoodObect(index, true);
        }
        else
        {
            isSameSoup = false;
            DQuestBook.instance.AddGoodObect(index, false);
        }
        bowl.SetSoup(-1);
        for (int i = 0; i < 5; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        transform.GetChild(soupIndex + 1).gameObject.SetActive(true);

    }
    public bool GetIsSameSoup() { return isSameSoup; }
}


