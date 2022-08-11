using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayTimerInGame : MonoBehaviour
{

    public TextMeshProUGUI timerBox;

    void Start()
    {
        timerBox = GetComponent<TextMeshProUGUI>();
        displayTime();
    }

    void Update()
    {
        displayTime();
    }

    private void displayTime()
    {
        timerBox.text = "Time: " + BallMove.getDisplayTime().ToString("F0");
    }
}
