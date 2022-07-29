using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{

    TextMeshProUGUI textScore;
    TextMeshProUGUI time;

    // Start is called before the first frame update
    void Start()
    {
        textScore = GetComponentInChildren<TextMeshProUGUI>();
        time = transform.Find("Time").GetComponent<TextMeshProUGUI>();
        displayScore();
        displayTime();
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
