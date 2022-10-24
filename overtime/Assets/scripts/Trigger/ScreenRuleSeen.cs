using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenRuleSeen : MonoBehaviour
{
    /*   public GameObject ScreenRules;
       public GameObject ScreenAfter;*/
    RawImage iconImage;
    public GameObject prank;
    public GameObject end;
    public GameObject ScreenEnd;

    public bool displayToolTip = false;

    void Start()
    {
        iconImage = transform.GetChild(0).transform.GetChild(0).GetComponent<RawImage>();
        iconImage.enabled = false;
    }

    private void Update()
    {
        if (end.activeSelf)
        {
            StartCoroutine(call());
        }
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
                end.SetActive(true);
            }

        }
    }

    IEnumerator call()
    {
        prank.SetActive(true);
        yield return new WaitForSeconds(10);
        prank.SetActive(false);
        ScreenEnd.SetActive(true);
        Destroy(gameObject);
    }

    /* void pressed(GameObject player)
     {
         ScreenAfter.SetActive(true);
         gameObject.SetActive(false);
     }*/
}
