using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseActivated : MonoBehaviour
{
    public GameObject lightOff;
    public GameObject lightOn;
    void Start()
    {
        lightOn.SetActive(true);
        Destroy(lightOff);
    }

}
