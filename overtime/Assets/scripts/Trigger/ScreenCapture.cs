using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenCapture : MonoBehaviour
{
    public GameObject Capture;
    public GameObject TookPic;
    public GameObject Dialogue;
    public GameObject HideButton;
    public GameObject newTime;
    public GameObject oldTime;
    public GameObject RedDoor;
    public GameObject RedDoorA;
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
                TookPic.SetActive(true);
                Capture.SetActive(true);
                Destroy(Dialogue);
                HideButton.SetActive(false);
                oldTime.SetActive(false);
                newTime.SetActive(true);
                RedDoor.SetActive(true);
                RedDoorA.SetActive(true);
                oldObj.SetActive(false);
                newObj.SetActive(true);
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
            if (TookPic.activeSelf)
            {
                Destroy(Capture);
            }
        }
    }

    void pressed(GameObject player)
    {

    }
}
