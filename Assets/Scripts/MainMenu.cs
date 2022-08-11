using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Text;

public class MainMenu : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI texthighScore, bestTime;
    private StringBuilder highScoreSB = new StringBuilder("High Score: ");
    private StringBuilder bestTimeSB = new StringBuilder("Best Time: ");

    void Start()
    {
        displayhighScore();
        displaybestTime();
    }

    public void playGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quitGame()
    {
        Application.Quit();
    }

    private void displayhighScore()
    {
        texthighScore.text = highScoreSB.Append(ScoreSystem.gethighScore().ToString("F0")).ToString();
    }

    private void displaybestTime()
    {
        bestTime.text = bestTimeSB.Append(ScoreSystem.getbestTime().ToString("F0")).ToString();
    }
}
