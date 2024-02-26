using UnityEngine;
using UnityEngine.PlayerLoop;

public class WallTorch : Interactive
{
    public GameObject chest;
    public override void OnInteraction()
    {
        //If I want to do the base OnInteraction anyway first
        //base.OnInteraction();
        //Activate light and fire
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(true);
        chest.GetComponent<DChest>().AddTorchCount();
    }
}
