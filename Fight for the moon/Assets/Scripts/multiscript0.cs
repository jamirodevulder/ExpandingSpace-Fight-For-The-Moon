using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class multiscript0 : MonoBehaviour {
     public GameObject pauzescherm;
    public GameObject tandwiel;
    public GameObject MainMenu;
    public GameObject ControllScreenObject;
    public GameObject CreditsScreenObject;
    public GameObject backgroundImage;
    public Image ControllScreen;
    public Image CreditsScreen;
    public Image MainMenuImage;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartLevel()
    {
        SceneManager.LoadScene("Game");
    }
    public void ToControlls()
    {
        MainMenu.SetActive(false);
        backgroundImage.GetComponent<Image>().sprite = ControllScreen.sprite;
        ControllScreenObject.SetActive(true);

    }
    public void StartCredits()
    {
        MainMenu.SetActive(false);
        backgroundImage.GetComponent<Image>().sprite = CreditsScreen.sprite;
        CreditsScreenObject.SetActive(true);


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
    public void BackFromCredits()
    {
        CreditsScreenObject.SetActive(false);
        backgroundImage.GetComponent<Image>().sprite = MainMenuImage.sprite;
        MainMenu.SetActive(true);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
