using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreViewer : MonoBehaviour
{

    public Text ScoreText;
    public Text HighScoreText;
    public int Score = 0;
    public int HighScore =0;
    
    // Start is called before the first frame update
   public  void ScoreTextInit()
    {
        ScoreText.text = string.Empty;
        HighScoreText.text = string.Empty;
    }

    // Update is called once per frame
    public void AddScoreViewer(bool isWin)
    {
        if (isWin)
        {
            Score += 1;
            ScoreText.text = $"{Score}";
        }
        else
        {
            HighScore += 1;
            HighScoreText.text = $"{HighScore}";
        }

    }
    public void ADDScoreViewer(bool isLose)
    {

        if (isLose)
        {
            Score += 1;
            ScoreText.text = $"{Score}";
        }
        else
        {
            HighScore += 1;
            HighScoreText.text = $"{HighScore}";
        }
    
    }
}
