using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverRemove : MonoBehaviour
{
    public GameObject hide;
    public GameObject timer;
    void Start()
    {
        Destroy(timer);
        Destroy(hide);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
