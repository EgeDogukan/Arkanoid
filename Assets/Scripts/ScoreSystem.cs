using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{

    public static int totalScore = 0;
    public static TextMeshProUGUI highScore;
    public static TextMeshProUGUI bestTime;
    public TextMeshProUGUI textBox;

    void Start()
    {
        totalScore = 0;
        textBox = GetComponent<TextMeshProUGUI>();
        displayScore();
    }

    void Update()
    {
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
