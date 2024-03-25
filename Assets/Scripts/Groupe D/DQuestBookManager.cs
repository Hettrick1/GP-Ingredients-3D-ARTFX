using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DQuestBookManager : MonoBehaviour
{
    public GameObject[] questsText;

    public GameObject[] buttons;
    public void TurnPageRight()
    {
        if (!DQuestBook.instance.GetIsSoup())
        {
            questsText[0].SetActive(false);
            questsText[1].SetActive(true);
            buttons[1].SetActive(false);
            buttons[0].SetActive(true);
        }
        else
        {
            questsText[2].SetActive(false);
            questsText[3].SetActive(true);
            buttons[1].SetActive(false);
            buttons[0].SetActive(true);
        }
    }
    public void TurnPageLeft()
    {
        if (!DQuestBook.instance.GetIsSoup())
        {
            questsText[0].SetActive(true);
            questsText[1].SetActive(false);
            buttons[0].SetActive(false);
            buttons[1].SetActive(true);
        }
        else
        {
            questsText[2].SetActive(true);
            questsText[3].SetActive(false);
            buttons[0].SetActive(false);
            buttons[1].SetActive(true);
        }
    }
}
