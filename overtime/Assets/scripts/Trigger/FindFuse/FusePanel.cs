using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FusePanel : MonoBehaviour
{
    public GameObject FusePicked;
    public GameObject Activated;
    RawImage iconImage;

    public bool displayToolTip = false;
    void Start()
    {
        iconImage = transform.GetChild(0).transform.GetChild(0).GetComponent<RawImage>();
        iconImage.enabled = false;
    }

    void OnTriggerStay(Collider other)
    {
        if (FusePicked.activeSelf)
        {
            if (other.gameObject.tag == "Player" && !other.isTrigger)
            {
                if (displayToolTip)
                {
                    iconImage.enabled = true;
                }
                if (GameController.sharedGameController.inputController.TestKeyDelay(KeyCode.F))
                {
                    Activated.SetActive(true);
                    Destroy(gameObject);
                }
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && !other.isTrigger)
        {
            if (displayToolTip)
            {
                iconImage.enabled = false;
            }
        }
    }
}
