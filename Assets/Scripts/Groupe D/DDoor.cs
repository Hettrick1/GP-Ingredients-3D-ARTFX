using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DDoor : Interactive
{

    public override void OnInteraction()
    {
        Debug.LogWarning("LOAD THE NEXT SCENE"); //ce script est le meme pour le premier et le deuxième niveau, il faut donc utiliser un index.
    }
}
