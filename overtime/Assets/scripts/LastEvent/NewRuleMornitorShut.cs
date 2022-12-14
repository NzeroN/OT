using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewRuleMornitorShut : MonoBehaviour
{
    public GameObject Shut;
    RawImage iconImage;
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
            if (GameController.sharedGameController.inputController.TestKeyDelay(KeyCode.F))
            {
                pressed(other.gameObject);
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

    void pressed(GameObject player)
    {
        Shut.SetActive(true);
        Destroy(gameObject);
    }
}
