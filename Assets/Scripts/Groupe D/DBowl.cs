using UnityEngine;

public class DBowl : MonoBehaviour
{
    private int soupIndex;
    public void SetSoup(int _soupIndex)
    {
        soupIndex = _soupIndex;

        for (int i = 0; i < 5; i++) 
        { 
                transform.GetChild(i).gameObject.SetActive(false);
        }
        transform.GetChild(soupIndex + 1).gameObject.SetActive(true);
    }
}
