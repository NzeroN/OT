using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOut : MonoBehaviour
{
    public GameObject lightCut;
    public GameObject PlayAnim;
    public GameObject RuleClear;
    public GameObject Destruct;
    public bool displayToolTip = false;

    void Start()
    {
        Destroy(RuleClear);
        StartCoroutine(waitForNineLightCut());
        StartCoroutine(waitForTen());
    }

    private void Update()
    {

    }
    IEnumerator waitForNineLightCut()
    {
        yield return new WaitForSeconds(9);
        lightCut.SetActive(false);
    }
    IEnumerator waitForTen()
    {
        yield return new WaitForSeconds(10);
        Destroy(Destruct);
    }
}
