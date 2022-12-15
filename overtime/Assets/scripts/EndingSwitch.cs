using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingSwitch : MonoBehaviour
{
    public GameObject firstCom;
    public GameObject lastCom;
    public GameObject bad;
    public GameObject truee;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (firstCom.activeSelf && lastCom.activeSelf)
        {
            bad.SetActive(false);
            truee.SetActive(true);
        }

    }
}
