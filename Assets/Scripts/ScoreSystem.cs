using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{

    //TODO: make private and do not make static.
    public static int totalScore = 0;
    //TODO: make private and use [SerializedField]
    public static TextMeshProUGUI highScore;
    //TODO: make private and use [SerializedField]
    public static TextMeshProUGUI bestTime;
    //TODO: make private and use [SerializedField]
    public TextMeshProUGUI textBox;

    void Start()
    {
        totalScore = 0;
        textBox = GetComponent<TextMeshProUGUI>();
        displayScore();
    }

    void Update()
    {
        //TODO: We do not need to call displayScore in here. 
        // https://gamedevbeginner.com/events-and-delegates-in-unity/#:~:text=Events%20in%20Unity%20are%20a,from%20within%20their%20own%20class.
        // We can listen an event that named as onScoreChanged
        //OR -> we can sync the score text when the addScore func is called.
        displayScore();
    }

    public static void addScore(Brick brickk)
    {
        totalScore += brickk.getScoreValue();
    }
    public static void addScoreTime(int value)
    {
        totalScore += value;
    }

    private void displayScore()
    {
        textBox.text = "Score: " + totalScore.ToString("F0");
    }
    
    public static int getScore()
    {
        if(totalScore > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", totalScore);
        }
        if(BallMove.getDisplayTime() > PlayerPrefs.GetFloat("bestTime", 0))
        {
            PlayerPrefs.SetFloat("bestTime", (BallMove.getDisplayTime()));
        }
        return totalScore;
    }

    public static int gethighScore()
    {
        return PlayerPrefs.GetInt("highScore", 0);
    }

    public static float getbestTime()
    {
        return PlayerPrefs.GetFloat("bestTime", 0);
    }
}
