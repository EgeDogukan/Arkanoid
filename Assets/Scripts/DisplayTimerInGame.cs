using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayTimerInGame : MonoBehaviour
{

    public TextMeshProUGUI timerBox;

    // Start is called before the first frame update
    void Start()
    {
        timerBox = GetComponent<TextMeshProUGUI>();
        displayTime();
    }

    // Update is called once per frame
    void Update()
    {
        displayTime();
    }

    private void displayTime()
    {
        timerBox.text = "Time: " + BallMove.getDisplayTime().ToString("F0");
    }
}
