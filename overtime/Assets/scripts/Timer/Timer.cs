using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour
{
    public GameObject player;
    public GameObject timer;
    public GameObject FakePale;
    //  public GameObject oldTime;
    // public GameObject newTime;
    public float timeRemaining = 60;
    public bool timerIsRunning = false;
    public Text timeText;
    private void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                //  oldTime.SetActive(false);
                // newTime.SetActive(true);
                player.transform.position = new Vector3(-71.9589996f, -300.640015f, 84.9199982f);
                FakePale.SetActive(true);
                Destroy(timer);
            }
        }
    }
    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        float milliSeconds = (timeToDisplay % 1) * 1000;
        timeText.text = string.Format("{0:00}:{1:00}:{2:000}", minutes, seconds, milliSeconds);
    }
}