using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameJudge : MonoBehaviour
{

    public Text JudgeText;

    public void GameJudgeTextInit()
    {
        JudgeText.text = string.Empty;
    }


    public void GameJudgeTextView(bool isWin)
    {
        if (isWin)
        {
            JudgeText.text = "Live!!";

            SceneManager.LoadScene("Clear");
        }
        else
        {
            JudgeText.text = "Die!!";
            
            SceneManager.LoadScene("Result");


        }
    
        
    }

    public void GameResultTextView(bool isWin)
    {
        if (isWin)
        {
            JudgeText.text = "Playerの勝利";
        }
        else
        {
            JudgeText.text = "CPUの勝ち";

        }
    }
}
