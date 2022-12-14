using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonPanelEndOne : MonoBehaviour
{
    public GameObject ButtonPanelPressed;
    RawImage iconImage;
 

    public bool displayToolTip = false;

    void Start()
    {
        iconImage = transform.GetChild(0).transform.GetChild(0).GetComponent<RawImage>();
        iconImage.enabled = false;

    }

    void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player" && !other.isTrigger)
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
        ButtonPanelPressed.SetActive(true);
        gameObject.SetActive(false);
        //SceneManager.LoadScene(3);
    }
}
