using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giggles : MonoBehaviour
{
    public GameObject giggle;
    void Start()
    {
        
    }
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" && !col.isTrigger)
        {
            giggle.SetActive(true);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player" && !col.isTrigger)
        {
          
        }
    }
}
