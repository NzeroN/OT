using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomFloor : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] ObjectsList; // Not only 18, this script will except any number of game objects you put here.

    void Start()
    {
        ObjectsList[Random.Range(0, ObjectsList.Length)].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
