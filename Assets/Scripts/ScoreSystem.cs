using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreSystem : MonoBehaviour
{

    public static int totalScore = 0;
    private Text textBox;

    // Start is called before the first frame update
    void Start()
    {
        textBox = GetComponent<Text>();
        displayScore();
    }

    // Update is called once per frame
    void Update()
    {
        displayScore();
    }

    public static void addScore(Brick brickk)
    {
        totalScore += brickk.getScoreValue();
    }

    private void displayScore()
    {
        textBox.text = "Score: " + totalScore.ToString("F0");
    }

    public static int getScore()
    {
        return totalScore;
    }
}
