using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide : MonoBehaviour
{
    public GameObject paleMan;
    public GameObject HideWarn;
    public GameObject HasHide;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (paleMan.activeSelf)
        {
            HideWarn.SetActive(true);
        }
        if (HasHide.activeSelf)
        {
            HideWarn.SetActive(false);
        }
    }
}
