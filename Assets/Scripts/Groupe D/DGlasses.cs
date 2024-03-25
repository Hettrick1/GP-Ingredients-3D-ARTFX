using UnityEngine;

public class DGlasses : Interactive
{
    bool isSameDrink;

    [SerializeField] private D_Drink drinkType;

    public override void OnInteraction()
    {
        DJug glass = FindObjectOfType<DJug>();
        SetDrink(glass.GetDrinkIndex());
    }
    public void SetDrink(int drinkIndex)
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
        
        var mat = transform.GetChild(0).GetComponent<MeshRenderer>().material;
        Color color = mat.color;
        color.a = 0.4f;
        mat.color = color;
        switch (drinkIndex)
        {
            case 0: //eau
                
                mat.color = Color.blue;
                return;
            case 1: //vin
                mat.color = Color.red;
                return;
            case 2: //bi�re
                mat.color = Color.yellow;
                return;
            case 3: //jdf
                mat.color = Color.green;
                return;
        }

    }
    public bool GetIsSameSoup() { return isSameDrink; }
}
