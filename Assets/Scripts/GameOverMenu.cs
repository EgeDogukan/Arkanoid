using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{

    TextMeshProUGUI textScore;
    TextMeshProUGUI time;
    TextMeshProUGUI texthighScore;
    TextMeshProUGUI bestTime;

    void Start()
    {
        textScore = GetComponentInChildren<TextMeshProUGUI>();
        texthighScore = transform.Find("HighScore").GetComponent<TextMeshProUGUI>();
        bestTime = transform.Find("BestTime").GetComponent<TextMeshProUGUI>();
        time = transform.Find("Time").GetComponent<TextMeshProUGUI>();
        displayScore();
        displayTime();
        displayhighScore();
        displaybestTime();
    }

    public void playAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    private void displayScore()
    {
        textScore.text = "Score: " + ScoreSystem.getScore().ToString("F0");
    }

private void displayTime()
    {
        time.text = "Time: " + BallMove.getDisplayTime().ToString("F0");
    }

    private void displayhighScore()
    {
        texthighScore.text = "High Score: " + ScoreSystem.gethighScore().ToString("F0");
    }

    private void displaybestTime()
    {
        bestTime.text = "Best Time: " + ScoreSystem.getbestTime().ToString("F0");
    }
}
