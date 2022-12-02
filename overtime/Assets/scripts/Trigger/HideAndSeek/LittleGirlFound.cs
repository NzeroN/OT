using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleGirlFound : MonoBehaviour
{
    public GameObject oldTime;
    public GameObject newTime;
    public GameObject TooLate;
    public GameObject PowerCut;
    public GameObject RuleBrokeMock;
    public GameObject thirdFloor;

    public bool displayToolTip = false;

    void Start()
    {

    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && !other.isTrigger)
        {
            if (displayToolTip)
            {
                RuleBrokeMock.SetActive(true);
                TooLate.SetActive(true);
                oldTime.SetActive(false);
                newTime.SetActive(true);
            }

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && !other.isTrigger)
        {
            //TooLate.SetActive(false);
            //PowerCut.SetActive(false);
            //Destroy(TooLate);
        }
    }
    IEnumerator waitForFive()
    {
        yield return new WaitForSeconds(5);
    }
}
