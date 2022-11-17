using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LittleGirlHint : MonoBehaviour
{
    public GameObject SpawnLittleGirlHint;

    /*   public GameObject ScreenRules;
       public GameObject ScreenAfter;*/

    //  public GameObject prankSeen;

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
                SpawnLittleGirlHint.SetActive(true);
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
