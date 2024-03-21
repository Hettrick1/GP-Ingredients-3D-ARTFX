using UnityEngine;

public class DGlasses : Interactive
{
    bool isSameDrink;

    [SerializeField] private D_Drink drinkType;

    public override void OnInteraction()
    {
        DBowl bowl = FindObjectOfType<DBowl>();
        SetSoup(bowl.GetSoupIndex());
    }
    public void SetSoup(int drinkIndex)
    {
        DJug jug = FindObjectOfType<DJug>();

        if (drinkIndex == (int)drinkType)
        {
            isSameDrink = true;
        }
        else
        {
            isSameDrink = false;
        }
        jug.SetDrink(-1);
        for (int i = 0; i < 5; i++)
        {
            transform.GetChild(i).gameObject.SetActive(false);
        }

        transform.GetChild(drinkIndex + 1).gameObject.SetActive(true);

    }
    public bool GetIsSameSoup() { return isSameDrink; }
}
