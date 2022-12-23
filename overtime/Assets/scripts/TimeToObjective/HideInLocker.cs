using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideInLocker : MonoBehaviour
{
    public GameObject oldObj;
    public GameObject newObj;
    void Start()
    {
        oldObj.SetActive(false);
        newObj.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
