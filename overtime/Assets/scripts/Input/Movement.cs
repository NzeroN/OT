using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                rb.velocity = Vector3.forward * 100;
            }

        }
        else
        {
            if (Input.GetKeyUp(KeyCode.W))
            {
                rb.velocity = Vector3.zero;
            }
        }
    }
}
