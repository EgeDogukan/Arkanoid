using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{

    //TODO: [SerializeField] -> drag and drop the reference
    private TextMeshProUGUI texthighScore;
    //TODO: [SerializeField] -> drag and drop the reference
    private TextMeshProUGUI bestTime;

    void Start()
    {
        //TODO: transform.Find is costly. Use SerializedField and drag dropping instead of transform.Find.
        texthighScore = transform.Find("HighScore").GetComponent<TextMeshProUGUI>();
        bestTime = transform.Find("BestTime").GetComponent<TextMeshProUGUI>();
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
        //TODO: use string builder
        texthighScore.text = "High Score: " + ScoreSystem.gethighScore().ToString("F0");
    }

    private void displaybestTime()
    {
        //TODO: use string builder
        bestTime.text = "Best Time: " + ScoreSystem.getbestTime().ToString("F0");
    }
}
