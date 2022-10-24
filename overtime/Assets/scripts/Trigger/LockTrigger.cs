using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockTrigger : MonoBehaviour
{
    [HideInInspector]
    public GameObject player;
    [HideInInspector]
    public Camera playerCamera;
    GameObject hudPanel;
    GameObject closePanel;
    public GameObject Text;
    public GameObject phone;
    public GameObject PlayerPhone;
    public GameObject Screen;
    public GameObject ScreenText;
    public GameObject ScreenPass;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerCamera = player.transform.GetChild(0).GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerPhone.activeSelf && ScreenPass.activeSelf)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" && !col.isTrigger)
        {
            if (InfiniteCameraCanSeePoint(Camera.main, this.transform.position))
            {
                if (phone.activeSelf)
                {
                    Text.SetActive(true);
                }
                if (Screen.activeSelf)
                {
                    ScreenText.SetActive(true);
                }
                if (Screen.activeSelf && phone.activeSelf)
                {
                    Text.SetActive(true);
                    ScreenText.SetActive(false);
                }
            }
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player" && !col.isTrigger)
        {
            Text.SetActive(false);
            ScreenText.SetActive(false);
        }
    }
    bool InfiniteCameraCanSeePoint(Camera camera, Vector3 point)
    {
        Vector3 viewportPoint = camera.WorldToViewportPoint(point);
        return (viewportPoint.z > 0 && (new Rect(0, 0, 1, 1)).Contains(viewportPoint));
    }
}

