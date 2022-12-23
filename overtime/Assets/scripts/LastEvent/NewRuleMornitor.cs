using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class NewRuleMornitor : MonoBehaviour
{
    public GameObject oldTime;
    public GameObject newTime;
    public GameObject Seen;
    public GameObject SeenUp;
    public GameObject Timer;
    public GameObject oldObj;
    public GameObject newObj;
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
        Seen.SetActive(true);
        SeenUp.SetActive(true);
        Timer.SetActive(true);
        oldTime.SetActive(false);
        newTime.SetActive(true);
        Destroy(gameObject);
        oldObj.SetActive(false);
        newObj.SetActive(true);
    }
}
