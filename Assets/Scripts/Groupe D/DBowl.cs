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
        for (int i = 0; i < 5; i++) 
        { 
                transform.GetChild(i).gameObject.SetActive(false);
        }

        transform.GetChild(soupIndex + 1).gameObject.SetActive(true);
    }
}
