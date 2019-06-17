using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LvLselector : MonoBehaviour {
    public string lvl;
	// Use this for initialization
	void Start () {
		
	}
	

   public void setLvl(string Lvl)
    {
        lvl = Lvl;
    }

    public string getlvl()
    {
        return lvl;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
