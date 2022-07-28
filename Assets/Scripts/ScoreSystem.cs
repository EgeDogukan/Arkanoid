using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ScoreSystem : MonoBehaviour
{

    public static int totalScore = 0;
    public TextMeshProUGUI textBox;

    // Start is called before the first frame update
    void Start()
    {
        totalScore = 0;
        textBox = GetComponent<TextMeshProUGUI>();
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
        return totalScore;
    }
}
