using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerWhoDiedScript : MonoBehaviour {
    private GameObject player;
    public GameObject player1;
    public GameObject player2;
    private bool next = false;
    private bool hit = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!hit)
        {
            hit = true;
            GameObject.Find("Canvas").GetComponent<ScoreHandler>().addScore(collision.gameObject);
            player = collision.gameObject;
        }
        
    }


    private void Update()
    {
        if (player != null && player.transform.localScale.x > 0)
        {
            player.transform.localScale -= new Vector3(0.1F, 0.1F, 0);
        }
        else if (player != null && player.transform.localScale.x <= 0 && !next)
        {
            next = true;
            StartCoroutine(startnextround());
        }

    }

  

    IEnumerator startnextround()
    {
       yield return new WaitForSeconds(1f);
        player1.transform.localScale = new Vector3(5, 5, 0);
        player2.transform.localScale = new Vector3(5, 5, 0);
        player1.transform.position = new Vector3(13, -8, 0);
        player2.transform.position = new Vector3(-13, -8, 0);
        player = null;
        next = false;
        hit = false;


    }
}
