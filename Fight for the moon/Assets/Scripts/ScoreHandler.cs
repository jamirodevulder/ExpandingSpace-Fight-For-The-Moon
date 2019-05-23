using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {
    private int scorePlayer2 = 0;
    private int scorePlayer1 = 0;
    public Image scoreplayer1;
    public Image scoreplayer2;
    public Image[] score;
    public void addScore(GameObject playerThatDied)
    {
        if (playerThatDied.name == "player1")
        {
            scorePlayer2++;
            scoreplayer2.GetComponent<Image>().sprite = score[scorePlayer2].GetComponent<Image>().sprite;

        }
        else
        {
            scorePlayer1++;
            scoreplayer1.GetComponent<Image>().sprite = score[scorePlayer1].GetComponent<Image>().sprite;

        }
    }



	
}
