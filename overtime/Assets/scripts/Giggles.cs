using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Giggles : MonoBehaviour
{
    public GameObject giggle;
    public GameObject oldObj;
    public GameObject newObj;
    void Start()
    {
        
    }
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" && !col.isTrigger)
        {
            giggle.SetActive(true);
            oldObj.SetActive(false);
            newObj.SetActive(true);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player" && !col.isTrigger)
        {
          
        }
    }
}
