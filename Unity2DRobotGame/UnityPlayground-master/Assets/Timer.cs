using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public Text timeText;
    private float gameTime;
    public GameObject WinPanel;

    private void Start()
    {
        gameTime = 1f;

    }
    void GameTimer()
    {
        

        if(WinPanel.activeInHierarchy)
        {
            //gameTime = gameTime;
            int displayTime = (int)gameTime;

            timeText.text = displayTime.ToString() + " Seconds";

            Debug.Log("stopped");
        }
        else
        {
            gameTime += Time.deltaTime;

            int displayTime = (int)gameTime;

            timeText.text = displayTime.ToString() + " Seconds";

            Debug.Log("Counting");
        }
    }

    private void Update()
    {
        GameTimer();
    }
}
