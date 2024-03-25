using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class DQuestBook : Interactive
{
    [SerializeField] private GameObject questBook;

    private bool isShowing, isSoup;
    private bool[] isGood = {false, false, false, false, false, false, false, false, false };

    public static DQuestBook instance;

    int numberOfObjects = 10;
    int nbreOfObjects;

    DPlates[] plates;
    DGlasses[] glasses;

    public GameObject[] questsText;

    private void Start()
    {
        instance = this;
        plates = GameObject.FindObjectsOfType<DPlates>();
        glasses = GameObject.FindObjectsOfType<DGlasses>();
        var bowl = FindObjectOfType<DBowl>();
        bowl.gameObject.SetActive(false);

        foreach (DPlates dp in plates)
        {
            dp.gameObject.GetComponent<SphereCollider>().enabled = false;
        }
        foreach (DGlasses dg in glasses)
        {
            dg.gameObject.GetComponent<SphereCollider>().enabled = true;
        }
    }

    public void AddGoodObect(int index, bool _isGood)
    {
        isGood[index] = _isGood;

        print(index + " : " + _isGood);
        if (isValid())
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
                var bowl = FindObjectOfType<DBowl>();
                bowl.gameObject.SetActive(true);
                GetComponent<AudioSource>().Play();
                foreach (DPlates dp in plates)
                {
                    dp.gameObject.GetComponent<SphereCollider>().enabled = true;
                }
                foreach (DGlasses dg in glasses)
                {
                    dg.gameObject.GetComponent<SphereCollider>().enabled = false;
                }

                for(int i = 0; i < isGood.Length; i++)
                {
                    isGood[i] = false;
                }
            }
        }
    }

    private bool isValid()
    {
        foreach (bool i in isGood)
        {
            if (!i)
            {
                return false;
            }
        }

        return true;
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

