using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {
    public Text timer;
    public GameObject player1;
    public GameObject player2;
	// Use this for initialization
	void Start () {
        StartCoroutine(startTimer());
        
	}
	
	// Update is called once per frame


    IEnumerator startTimer()
    {
        player1.GetComponent<Player1MovementScript>().enabled = false;
        player2.GetComponent<Player2MovementScript>().enabled = false;
        timer.text = "3";
        yield return new WaitForSeconds(1);
        timer.text = "2";
        yield return new WaitForSeconds(1);
        timer.text = "1";
        yield return new WaitForSeconds(1);
        timer.text = "GO!";
        yield return new WaitForSeconds(0.5f);
        timer.text = "";
        player1.GetComponent<Player1MovementScript>().enabled = true;
        player2.GetComponent<Player2MovementScript>().enabled = true;
    }
}
