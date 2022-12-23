using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShutDownCheck : MonoBehaviour
{
    public GameObject oldObj;
    public GameObject newObj;
    public GameObject Leave;
    public GameObject Friend;
    void Start()
    {
        oldObj.SetActive(false);
        newObj.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (gameObject.activeSelf && Friend.activeSelf)
        {
            newObj.SetActive(false);
            Leave.SetActive(true);
        }
    }
}
