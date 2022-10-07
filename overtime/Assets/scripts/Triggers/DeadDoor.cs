using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadDoor : MonoBehaviour
{
    private int count = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("death: " + count);
            count++;
        }
    }
}
