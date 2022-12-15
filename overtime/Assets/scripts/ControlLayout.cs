using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLayout : MonoBehaviour
{
    public GameObject layout;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            layout.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.B))
        {
            layout.SetActive(false);
        }
    }
}
