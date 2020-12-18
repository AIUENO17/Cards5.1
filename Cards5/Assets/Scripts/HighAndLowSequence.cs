using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighAndLowSequence : MonoBehaviour
{

    private enum GameSequence
    {
        Invalide,
        Init,
        Start,
        Deal,
        PlayerJudge,
        Show,
        Result
    }

    private GameSequence gameSequence = GameSequence.Invalide;

    public Dealer dealer;

    public PlayerCard playerCard;

    public CPUCard cpuCard;

    public PlayerJudge playerJudge;

    public GameJudge gameJudge;

    public float waitTime = 3f;

    void Update()
    {
        switch (gameSequence)
        {
            case GameSequence.Invalide:

                gameSequence = GameSequence.Init;
                break;

            case GameSequence.Init:


                playerCard.SetPlayerDeck();
                cpuCard.SetCPUDeck();
                gameSequence = GameSequence.Deal;

                break;
            case GameSequence.Start:

                gameJudge.GameJudgeTextInit();
                gameSequence = GameSequence.Deal;
                break;



            case GameSequence.Deal:
                playerCard.SetPlayerCard();
                cpuCard.SetCPUCard();
                Debug.Log(playerCard.playerCard.Number);
                Debug.Log(cpuCard.cpuCard.Number);
                gameSequence = GameSequence.PlayerJudge;
                break;

            case GameSequence.PlayerJudge:

                if (playerJudge.Judge)
                {
                    gameSequence = GameSequence.Show;

                }
                break;

            case GameSequence.Show:

                cpuCard.ShowCPUCard();

                if (playerJudge.High)
                {
                    if (playerCard.playerCard.Number > cpuCard.cpuCard.Number)
                    {
                        gameJudge.GameJudgeTextView(true);
                    }
                    else
                    {
                        gameJudge.GameJudgeTextView(false);
                    }
                }

                else
                {
                    if (playerCard.playerCard.Number < cpuCard.cpuCard.Number)
                    {
                        gameJudge.GameJudgeTextView(true);
                    }
                    else
                    {
                        gameJudge.GameJudgeTextView(false);
                    }
                }
                waitTime -= Time.deltaTime;

                if (waitTime < 0f)
                {
                    playerJudge.Judge = false;

                    if (dealer.GameEnd(playerCard.GetPlayerDeck()))
                    {
                        gameSequence = GameSequence.Result;
                    }
                    else
                    {
                        gameSequence = GameSequence.Start;
                    }

                    gameSequence = GameSequence.Start;
                    waitTime = 3f;
                }
                break;







        }
    }
}

