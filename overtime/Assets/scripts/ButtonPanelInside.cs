using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPanelInside : MonoBehaviour
{
    public GameObject ButtonPanelPressed;
    public GameObject ButtonPanel;
    public GameObject ButtonModel;
    public GameObject ButtonModelPressed;
    public GameObject ButtonPanelInsideBroke;
    public GameObject LightOff;
    public GameObject SpawnAI;
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
                StartCoroutine(pressed(other.gameObject));
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

    /*  void pressed(GameObject player)
      {
          ButtonModel.SetActive(false);
          ButtonModelPressed.SetActive(true);
          ButtonPanelPressed.SetActive(false);
          //ButtonPanel.SetActive(false);

          ButtonPanel.SetActive(value: true);
      }*/
    IEnumerator pressed(GameObject player)
    {
        ButtonModel.SetActive(false);
        ButtonModelPressed.SetActive(true);
        ButtonPanelPressed.SetActive(false);
        ButtonPanel.SetActive(value: false);
        //ButtonPanel.SetActive(false);
        yield return new WaitForSeconds(5);
        ButtonPanelPressed.SetActive(value: true);
        ButtonModelPressed.SetActive(false);
        ButtonPanelInsideBroke.SetActive(true);
        LightOff.SetActive(false);
        SpawnAI.SetActive(true);
    }
}
