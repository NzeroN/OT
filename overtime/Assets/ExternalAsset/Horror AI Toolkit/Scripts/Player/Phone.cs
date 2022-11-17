using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phone : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject PicTook;
    public GameObject ShowRules;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Canvas.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            Canvas.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.R) && PicTook.activeSelf)
        {
            ShowRules.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.R) && PicTook.activeSelf)
        {
            ShowRules.SetActive(false);
        }
    }

}

