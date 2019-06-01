using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< HEAD:Fight for the moon/Assets/Scripts/PauzeScript.cs

public class PauzeScript : MonoBehaviour {

=======
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class multiscript0 : MonoBehaviour {
    public GameObject pauzescherm;
    public GameObject tandwiel;
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687:Fight for the moon/Assets/multiscript0.cs
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
<<<<<<< HEAD:Fight for the moon/Assets/Scripts/PauzeScript.cs
=======
    public void StartLevel()
    {
        SceneManager.LoadScene("Game");
    }
    public void ToControlls()
    {
        SceneManager.LoadScene("Controlls");
    }
    public void StartCredits()
    {
        GameObject.Find("Image").GetComponent<Image>().sprite = Resources.Load<Sprite>("Assets/Sprites/mainMenu/Darken_background.png");
    }
    public void BackMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Resume()
    {
        GameObject.Find("player1").GetComponent<Player1MovementScript>().enabled = true;
        GameObject.Find("player2").GetComponent<Player2MovementScript>().enabled = true;
        pauzescherm.SetActive(false);
        tandwiel.GetComponent<escapePauzeScript>().setEscPressed(false);

    }
    public void Pauze()
    {
        GameObject.Find("player1").GetComponent<Player1MovementScript>().enabled = false;
        GameObject.Find("player2").GetComponent<Player2MovementScript>().enabled = false;
        pauzescherm.SetActive(true);
        tandwiel.GetComponent<escapePauzeScript>().setEscPressed(false);
    }
    public void Exit()
    {
        Application.Quit();
    }
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687:Fight for the moon/Assets/multiscript0.cs
}
