using UnityEngine;


public enum D_SoupType
{
    Riche,
    Os,
    Viande,
    Legume,
}
public class DSoup : Interactive
{
    [SerializeField] private D_SoupType soupIndex;
    public override void OnInteraction()
    {

        DBowl bowl = FindObjectOfType<DBowl>();
        bowl.SetSoup((int)soupIndex);
    }
}
