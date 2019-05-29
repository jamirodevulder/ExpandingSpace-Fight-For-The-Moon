using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour {
    public Image timer;
    public GameObject player1;
    public GameObject player2;
    public Image[] counter;
    public GameObject countdown;
    
    
	// Use this for initialization
	void Start () {
        countdown.SetActive(true);
        StartCoroutine(startTimer());
         
        
	}
	
	// Update is called once per frame


    IEnumerator startTimer()
    {
        player1.GetComponent<Player1MovementScript>().enabled = false;
        player2.GetComponent<Player2MovementScript>().enabled = false;
        timer.GetComponent<Image>().sprite = counter[0].GetComponent<Image>().sprite;
        yield return new WaitForSeconds(1);
        timer.GetComponent<Image>().sprite = counter[1].GetComponent<Image>().sprite;
        yield return new WaitForSeconds(1);
        timer.GetComponent<Image>().sprite = counter[2].GetComponent<Image>().sprite;
        yield return new WaitForSeconds(1);
        timer.GetComponent<Image>().sprite = counter[3].GetComponent<Image>().sprite;
        yield return new WaitForSeconds(0.5f);
        countdown.SetActive(false);
        player1.GetComponent<Player1MovementScript>().enabled = true;
        player2.GetComponent<Player2MovementScript>().enabled = true;
    }
}
