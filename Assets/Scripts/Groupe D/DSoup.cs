using UnityEngine;

public class DSoup : Interactive
{
    [Header("0 : soup de riche | 1 : soupe d'os | 2 : soupe de viande | 3 : soupe de legume")]
    [SerializeField] private int soupIndex;
    public override void OnInteraction()
    {

        DBowl bowl = FindObjectOfType<DBowl>();
        bowl.SetSoup(soupIndex);
    }
}
