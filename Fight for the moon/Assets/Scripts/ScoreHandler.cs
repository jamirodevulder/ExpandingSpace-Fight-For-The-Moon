using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreHandler : MonoBehaviour {
    private int scorePlayer2 = 0;
    private int scorePlayer1 = 0;
    public Image scoreplayer1;
    public Image scoreplayer2;
    private GameObject player1;
    public Image[] score;

    private void Start()
    {
        player1 = GameObject.Find("player1");
    }
    public void addScore(GameObject playerThatDied)
    {
        if (playerThatDied.name == "player1")
        {
            scorePlayer2++;
            scoreplayer2.GetComponent<Image>().sprite = score[scorePlayer2].GetComponent<Image>().sprite;
            if (scorePlayer2 == 3)
            {
                StartCoroutine(winAm());
            }
        }
        else
        {
            scorePlayer1++;
            scoreplayer1.GetComponent<Image>().sprite = score[scorePlayer1].GetComponent<Image>().sprite;
            if(scorePlayer1 == 3)
            {
                StartCoroutine(winSU());
            }
        }
    }


    IEnumerator winAm()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("amerikaWin");
    }
	
    IEnumerator winSU()
    {
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("SovjetUnieWin");
    }
}
