using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleFurther : MonoBehaviour
{
    public GameObject NoFurther;
    void Start()
    {

    }


    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" && !col.isTrigger)
        {
            NoFurther.SetActive(true);
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player" && !col.isTrigger)
        {
            NoFurther.SetActive(false);
        }
    }
}
