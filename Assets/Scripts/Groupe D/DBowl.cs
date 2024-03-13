using UnityEngine;

public class DBowl : MonoBehaviour
{
    public static DBowl instance;


    private void Start()
    {
        instance = this;
    }

    public void SetSoup(int soupIndex)
    {
        transform.GetChild(soupIndex+1).gameObject.SetActive(true);
        for (int i = 0; i < 5; i++) 
        { 
            if(i != soupIndex)
            {
                transform.GetChild(i).gameObject.SetActive(false);
            }
        }


        //switch (soupIndex + 1)
        //{

        //    case 0:
        //        break;
            
        //    case 1:
        //        break;

        //    case 2:
        //        break;

        //    case 3:
        //        break;

        //    case 4:
        //        break;

        //    case 5:
        //        break;
        //}
    }
}
