using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEditor;

public class multiscript0 : MonoBehaviour {
    private string[] lvlnames = new string[2];
    public string lvl;
     public GameObject pauzescherm;
    public GameObject tandwiel;
    public GameObject MainMenu;
    public GameObject ControllScreenObject;
    public GameObject CreditsScreenObject;
    public GameObject backgroundImage;
    public GameObject LevelScreenObject;
    public Image ControllScreen;
    public Image CreditsScreen;
    public Image MainMenuImage;
	// Use this for initialization
	void Start () {
        lvlnames[0] = "Game";
        lvlnames[1] = "SoccerGame";
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void StartLevel()
    {
        MainMenu.SetActive(false);
        backgroundImage.GetComponent<Image>().sprite = CreditsScreen.sprite;
        LevelScreenObject.SetActive(true);
    }
    public void StartSceneGame()
    {
        PlayALvl(lvlnames[0]);
    }
    public void StartSceneSoccerGame()
    {
        PlayALvl(lvlnames[1]);
        
    }
    public void StartSceneCombatScene39420()
    {
        SceneManager.LoadScene("CombatScene39420");
        Debug.Log("+Added: HeroBrine");
    }
    public void ToControlls(string lvltoload)
    {
        MainMenu.SetActive(false);
        
        backgroundImage.GetComponent<Image>().sprite = ControllScreen.sprite;
        ControllScreenObject.SetActive(true);
        GameObject.Find("lvlHandler").GetComponent<LvLselector>().setLvl(lvltoload);
        
    }
    public void PlayALvl(string lvltoload)
    {
        LevelScreenObject.SetActive(false);
        ToControlls(lvltoload);
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
    public void BackFromLvlSelect()
    {
        ControllScreenObject.SetActive(false);
        LevelScreenObject.SetActive(false);
        backgroundImage.GetComponent<Image>().sprite = MainMenuImage.sprite;
        MainMenu.SetActive(true);
    }
    public void startGame()
    {
        
        
        SceneManager.LoadScene(GameObject.Find("lvlHandler").GetComponent<LvLselector>().getlvl());
    }
    public void Exit()
    {
        Application.Quit();
    }
}
