using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DPlates : Interactive
{


    public override void OnInteraction()
    {
        DBowl bowl = FindObjectOfType<DBowl>();
        SetSoup(bowl.GetSoupIndex());
    }
    public void SetSoup(int soupIndex)
    {
        for (int i = 0; i < 5; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        transform.GetChild(soupIndex + 1).gameObject.SetActive(true);
    }
}


