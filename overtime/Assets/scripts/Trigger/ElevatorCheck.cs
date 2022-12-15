using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorCheck : MonoBehaviour
{
    [HideInInspector]
    public GameObject player;
    [HideInInspector]
    public Camera playerCamera;
    GameObject hudPanel;
    GameObject closePanel;
    public GameObject PaleMan;
    public GameObject TooTired;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerCamera = player.transform.GetChild(0).GetComponent<Camera>();

    }

    // Update is called once per frame
    void Update()
    {
        if (PaleMan.activeSelf)
        {
            Destroy(gameObject);
            Destroy(TooTired);
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Player" && !col.isTrigger)
        {
            if (InfiniteCameraCanSeePoint(Camera.main, this.transform.position))
            {
                TooTired.SetActive(true);
            }
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Player" && !col.isTrigger)
        {
            TooTired.SetActive(false);
        }
    }
    bool InfiniteCameraCanSeePoint(Camera camera, Vector3 point)
    {
        Vector3 viewportPoint = camera.WorldToViewportPoint(point);
        return (viewportPoint.z > 0 && (new Rect(0, 0, 1, 1)).Contains(viewportPoint));
    }
}

