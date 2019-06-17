using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escapePauzeScript : MonoBehaviour {
   public GameObject pauzeScherm;
    private bool escPressed = false;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape) && !escPressed)
        {
            pauzeScherm.SetActive(true);
            escPressed = true;
            GameObject.Find("player1").GetComponent<Player1MovementScript>().enabled = false;
            GameObject.Find("player2").GetComponent<Player2MovementScript>().enabled = false;
        }
      else if(Input.GetKeyDown(KeyCode.Escape) && escPressed)
        {
            pauzeScherm.SetActive(false);
            escPressed = false;
            GameObject.Find("player1").GetComponent<Player1MovementScript>().enabled = true;
            GameObject.Find("player2").GetComponent<Player2MovementScript>().enabled = true;
        }
        





	}
    public void setEscPressed(bool EscPressed)
    {
        escPressed = EscPressed;
    }
}
