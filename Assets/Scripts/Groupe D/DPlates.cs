using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DPlates : Interactive
{
    bool isSameSoup;

    [SerializeField] private D_SoupType soupType;

    public override void OnInteraction()
    {
        DBowl bowl = FindObjectOfType<DBowl>();
        SetSoup(bowl.GetSoupIndex());
    }
    public void SetSoup(int soupIndex)
    {
        DBowl bowl = FindObjectOfType<DBowl>();

        if (soupIndex == (int)soupType)
        {
            isSameSoup = true;
            DQuestBook.instance.AddGoodObect(1);
        }
        else
        {
            isSameSoup = false;
            DQuestBook.instance.AddGoodObect(-1);
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


