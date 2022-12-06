using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOut : MonoBehaviour
{
    public GameObject lightCut;
    public GameObject PlayAnim;

    public bool displayToolTip = false;

    void Start()
    {
        StartCoroutine(waitForNine());
    }

    private void Update()
    {
    
    }
    IEnumerator waitForNine()
    {
        yield return new WaitForSeconds(5);
        lightCut.SetActive(false);
    }
}
