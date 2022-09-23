using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameEventManager instance { get; private set; }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("Found more than one Game Events Manager in the scene.");
        }
        instance = this;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void onPlayerDeath()
    {

    }
}
