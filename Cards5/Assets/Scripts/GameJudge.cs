using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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
            JudgeText.text = "生存!!";
        }
        else
        {
            JudgeText.text = "死亡!!";
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
