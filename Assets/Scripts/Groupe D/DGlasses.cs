using System;
using System.Reflection;
using UnityEngine;

public class DGlasses : Interactive
{
    bool isSameDrink;

    [SerializeField] private D_Drink drinkType;
    [SerializeField] private bool fancyGlass;
    [SerializeField] private int index;

    private void Start()
    {
        transform.GetChild(fancyGlass ? 1 : 0).gameObject.SetActive(true);
        transform.GetChild(fancyGlass ? 0 : 1).gameObject.SetActive(false);
    }

    public override void OnInteraction()
    {
        DJug glass = FindObjectOfType<DJug>();
        SetDrink(glass.GetDrinkIndex());
    }
    public void SetDrink(int drinkIndex)
    {

        if (drinkIndex == (int)drinkType)
        {
            isSameDrink = true;
            DQuestBook.instance.AddGoodObect(index, true);
        }
        else
        {
            isSameDrink = false;
            DQuestBook.instance.AddGoodObect(index, false);
        }


        var mat = transform.GetChild(fancyGlass ? 1 : 0).GetChild(0).GetComponent<MeshRenderer>().material;
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
            case 2: //bière
                mat.color = Color.yellow;
                return;
            case 3: //jdf
                mat.color = Color.green;
                return;
        }

    }
    public bool GetIsSameSoup() { return isSameDrink; }
}
