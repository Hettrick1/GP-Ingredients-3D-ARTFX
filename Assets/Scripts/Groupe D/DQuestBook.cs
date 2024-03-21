using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class DQuestBook : Interactive
{
    [SerializeField] private GameObject questBook;

    bool isShowing, isSoup;

    public static DQuestBook instance;

    int numberOfObjects = 10;
    int nbreOfObjects;

    DPlates[] plates;

    public GameObject[] questsText;

    private void Start()
    {
        instance = this;
        plates = GameObject.FindObjectsOfType<DPlates>();
        foreach (DPlates dp in plates)
        {
            dp.gameObject.GetComponent<SphereCollider>().enabled = false;
        }
    }

    public void AddGoodObect(int AddScore)
    {
        if (nbreOfObjects < numberOfObjects - 1)
        {
            nbreOfObjects += AddScore;
        }
        else if (nbreOfObjects < numberOfObjects)
        {
            if (isSoup)
            {
                GetComponent<AudioSource>().Play();
                foreach (DPlates dp in plates)
                {
                    dp.gameObject.GetComponent<SphereCollider>().enabled = false;
                }
            }
            else
            {
                GetComponent<AudioSource>().Play();


                foreach (DPlates dp in plates)
                {
                    dp.gameObject.GetComponent<SphereCollider>().enabled = true;
                }
            }
        }
    }

    public override void OnInteraction()
    {
        if (!isShowing)
        {
            questBook.SetActive(true);
            if (!isSoup)
            {
                questsText[0].SetActive(true);
            }
            else
            {
                questsText[2].SetActive(true);
            }
            isShowing = true;
        }
        else
        {
            questBook.SetActive(false);
            for(int i = 0; i < questsText.Length; i++)
            {
                questsText[i].SetActive(false);
            }

            isShowing = false;
        }
    }

    public bool GetIsSoup()
    {
        return isSoup;
    }
}

