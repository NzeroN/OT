using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFusE : MonoBehaviour
{
    public GameObject events;
    void Start()
    {
        StartCoroutine(waitForFinish());
    }



    IEnumerator waitForFinish()
    {   
        yield return new WaitForSeconds(5);
        Destroy(events);
    }
}
