using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timeLeft;
    public bool timeOn = false;

    public TextMeshProUGUI timerText;

    private void Start()
    {
        timeOn = true;
    }

    private void Update()
    {
        if (timeOn)
        {
            if (timeLeft > 0)
            {
                timeLeft -= Time.deltaTime;
                UpdateTimer(timeLeft);
            }
            else
            {
                Debug.Log("time over");
                timeLeft = 0;
                timeOn = false;
            }
            
        }

        void UpdateTimer(float currentTime)
        {
            currentTime += 1;

            float minutes = Mathf.FloorToInt(currentTime / 60);
            float seconds = Mathf.FloorToInt(currentTime % 60);
            timerText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
        }
        
    }
}
