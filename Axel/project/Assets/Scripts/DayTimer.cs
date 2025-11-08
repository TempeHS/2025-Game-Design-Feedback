using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayTimer : MonoBehaviour
{
    public TextMeshProUGUI dayTimerText;
    private static float timeRemaining = 1 * 60; // 15 minutes in seconds
    public static bool timerRunning = false;
    public static bool canGoOutside = true;

    void Awake()
    {
    //Persist this object across scenes
    }

    void Update()
    {
        if (timerRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateTimerDisplay();
            }
            else
            {
                timeRemaining = 0;
                timerRunning = false;
                UpdateTimerDisplay();
            }
        }

        if (timeRemaining <= 10)
        {
            canGoOutside = false;
        }
    }

    void UpdateTimerDisplay()
    {
        int minutes = Mathf.FloorToInt(timeRemaining / 60);
        int seconds = Mathf.FloorToInt(timeRemaining % 60);
        dayTimerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    public void ResetTimer()
    {
        timeRemaining = 1 * 60; // Reset to 15 minutes in seconds
        UpdateTimerDisplay();   // Update the display immediately
    }
}
