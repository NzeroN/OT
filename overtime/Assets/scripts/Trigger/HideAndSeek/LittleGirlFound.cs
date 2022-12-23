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
    public GameObject oldObjForth;
    public GameObject oldObjFifth;
    public GameObject oldObjSixth;
    public GameObject newObj;
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
                Destroy(oldObjForth);
                Destroy(oldObjFifth);
                Destroy(oldObjSixth);
                newObj.SetActive(true);
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
