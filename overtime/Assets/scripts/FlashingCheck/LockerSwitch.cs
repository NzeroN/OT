using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockerSwitch : MonoBehaviour
{
    public GameObject paleMan;
    public GameObject Locker;
    public GameObject HideLocker;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (paleMan.activeSelf)
        {
            Locker.SetActive(false);
            HideLocker.SetActive(true);
        }
    }
}
