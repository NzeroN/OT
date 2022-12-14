using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleGirlFound : MonoBehaviour
{
    public GameObject oldTime;
    public GameObject newTime;
    public GameObject RuleBrokeMock;
    public GameObject thirdFloor;
    public GameObject thirdFloorLight;
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
                oldTime.SetActive(false);
                newTime.SetActive(true);
                thirdFloorLight.SetActive(true);
                Destroy(thirdFloor);
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
    IEnumerator WaitForNine()
    {
        yield return new WaitForSeconds(2);
    }
}
