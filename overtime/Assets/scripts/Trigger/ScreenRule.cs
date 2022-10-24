using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenRule : MonoBehaviour
{
    /*   public GameObject ScreenRules;
       public GameObject ScreenAfter;*/
    RawImage iconImage;
  //  public GameObject prankSeen;

    public bool displayToolTip = false;

    void Start()
    {
        iconImage = transform.GetChild(0).transform.GetChild(0).GetComponent<RawImage>();
        iconImage.enabled = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player" && !other.isTrigger)
        {
            if (displayToolTip)
            {
                iconImage.enabled = true;
            }
            /*  if (GameController.sharedGameController.inputController.TestKeyDelay(KeyCode.F))
              {
                  pressed(other.gameObject);
                  ScreenRules.SetActive(true);
              }*/
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && !other.isTrigger)
        {
            if (displayToolTip)
            {
                iconImage.enabled = false;
             //   prankSeen.SetActive(true);
              //  Destroy(gameObject);
            }

        }
    }

  /*  IEnumerator call()
    {
        yield return new WaitForSeconds(2);
        prank.SetActive(true);
        yield return new WaitForSeconds(2);
        prank.SetActive(false);
        prankSeen.SetActive(true);
    }*/

    /* void pressed(GameObject player)
     {
         ScreenAfter.SetActive(true);
         gameObject.SetActive(false);
     }*/
}
