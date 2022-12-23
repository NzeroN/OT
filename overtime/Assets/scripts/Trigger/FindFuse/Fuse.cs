using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuse : MonoBehaviour
{
  //  public GameObject oldTime;
   // public GameObject newTime;
    public GameObject littleGirl;
    public GameObject Dialogue;
    public GameObject FuseEvent;
    public GameObject oldObj;
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
           //     oldTime.SetActive(false);
           //     newTime.SetActive(true);
                littleGirl.SetActive(true);
                Dialogue.SetActive(true);
                FuseEvent.SetActive(true);
                oldObj.SetActive(false);
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
