using UnityEngine;

public enum D_Drink
{
    Eau,
    Vin,
    Bi�re,
    JusDeFruit,
}
public class DBarrel : Interactive
{
    [SerializeField] private D_Drink drinkIndex;
    public override void OnInteraction()
    {

        DJug jug = FindObjectOfType<DJug>();
        jug.SetDrink((int)drinkIndex);
    }
}
