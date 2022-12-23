using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuseActivated : MonoBehaviour
{
    public GameObject oldTime;
    public GameObject newTime;
    public GameObject lightOff;
    public GameObject lightOn;
    public GameObject FloorUnlock;
    public GameObject oldObj;
    public GameObject newObj;
    void Start()
    {
        lightOn.SetActive(true);
        Destroy(lightOff);
        Destroy(FloorUnlock);
        oldTime.SetActive(false);
        newTime.SetActive(true);
        oldObj.SetActive(false);
        newObj.SetActive(true);
    }

}
