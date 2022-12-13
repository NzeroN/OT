using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject events;
    void Start()
    {
        StartCoroutine(waitForFinish());
    }



    IEnumerator waitForFinish()
    {   
        yield return new WaitForSeconds(13);
        Destroy(events);
    }
}
