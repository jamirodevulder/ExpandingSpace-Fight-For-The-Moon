using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHandler : MonoBehaviour {
    private int scorePlayer2 = 0;
    private int scorePlayer1 = 0;
    public Text scoreplayer1;
    public Text scoreplayer2;
    public void addScore(GameObject playerThatDied)
    {
        if (playerThatDied.name == "player2")
        {
            scorePlayer2++;
            scoreplayer2.text = scorePlayer2.ToString();
        }
        else
        {
            scorePlayer1++;
            scoreplayer1.text = scorePlayer1.ToString();
        }
    }



	
}
