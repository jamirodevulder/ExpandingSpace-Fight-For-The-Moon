﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startwinScreen : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GetComponent<Animator>().SetTrigger("win");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
