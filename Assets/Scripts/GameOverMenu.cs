using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Text;

public class GameOverMenu : MonoBehaviour
{
    
    private StringBuilder displayScoreSB = new StringBuilder("Score: ");
    private StringBuilder displayTimeSB = new StringBuilder("Time: ");
    private StringBuilder displayhighScoreSB = new StringBuilder("High Score: ");
    private StringBuilder displaybestTimeSB = new StringBuilder("Best Time: ");
    [SerializeField]
    private TextMeshProUGUI textScore, time, texthighScore, bestTime;

    void Start()
    {
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
        textScore.text = displayScoreSB.Append(ScoreSystem.getScore().ToString("F0")).ToString();
    }

    private void displayTime()
    {
        time.text = displayTimeSB.Append(BallMove.getDisplayTime().ToString("F0")).ToString();
    }

    private void displayhighScore()
    {
        texthighScore.text = displayhighScoreSB.Append(ScoreSystem.gethighScore().ToString("F0")).ToString();
    }

    private void displaybestTime()
    {
        bestTime.text = displaybestTimeSB.Append(ScoreSystem.getbestTime().ToString("F0")).ToString();
    }
}
