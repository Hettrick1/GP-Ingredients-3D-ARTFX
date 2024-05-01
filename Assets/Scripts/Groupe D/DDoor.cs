using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DDoor : Interactive
{
    public int levelIndex = 1;
    public override void OnInteraction()
    {
        switch (levelIndex)
        {
            case 1:
                SceneManager.LoadScene("D_DiningRoom");
                break;
            
            case 2:
                //SceneManager.LoadScene("Next Level");
                print("load next level here");
                break;

        }
    }
}
