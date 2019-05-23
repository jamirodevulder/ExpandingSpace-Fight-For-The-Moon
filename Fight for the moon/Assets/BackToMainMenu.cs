using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class BackToMainMenu : MonoBehaviour {
    public Button button;
	// Use this for initialization
	void Start () {
        button.onClick.AddListener(backtomainmenu);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void backtomainmenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
