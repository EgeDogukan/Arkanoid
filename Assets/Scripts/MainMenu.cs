using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenu : MonoBehaviour
{

    private TextMeshProUGUI texthighScore;
    private TextMeshProUGUI bestTime;

    // Start is called before the first frame update
    void Start()
    {
        texthighScore = transform.Find("HighScore").GetComponent<TextMeshProUGUI>();
        bestTime = transform.Find("BestTime").GetComponent<TextMeshProUGUI>();
        displayhighScore();
        displaybestTime();
    }

    // Update is called once per frame
    void Update()
    {
        
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
        texthighScore.text = "High Score: " + ScoreSystem.gethighScore().ToString("F0");
    }

    private void displaybestTime()
    {
        bestTime.text = "Best Time: " + ScoreSystem.getbestTime().ToString("F0");
    }
}
