using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    [SerializeField] private string sceneName;
    [SerializeField] private float changeTime;

    void Update()
    {
        CheckTimer();
        if (Input.GetKeyDown(KeyCode.X))
        {
            changeTime = 0;
        }
    }

    void CheckTimer()
    {
        changeTime -= Time.deltaTime;
        if (changeTime <= 0)
        {
            SceneManager.LoadScene(sceneName);
        }
    }
}
