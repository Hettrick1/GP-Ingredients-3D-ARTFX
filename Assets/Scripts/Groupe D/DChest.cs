using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DChest : Interactive
{
    [SerializeField] private GameObject silverKey;
    private int torches;
    [SerializeField] private int necessaryTorches;
    
    public override void OnInteraction()
    {
        GetComponent<Animator>().SetTrigger("Open");
        silverKey.SetActive(true);
    }
    public void AddTorchCount()
    {
        torches++;
        if (torches == necessaryTorches)
        {
            GetComponent<SphereCollider>().enabled = true;
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(true);
            transform.GetChild(2).gameObject.SetActive(true);
        }
    }
}
