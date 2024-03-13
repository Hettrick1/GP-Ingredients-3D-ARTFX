using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class DQuestBook : Interactive
{
    [SerializeField]private GameObject questBook;

    bool isShowing;
    public override void OnInteraction()
    {
        if (!isShowing)
        {
            questBook.SetActive(true);
            isShowing = true;
        }
        else
        {
            questBook.SetActive(false);
            isShowing = false;
        }
    }
}
