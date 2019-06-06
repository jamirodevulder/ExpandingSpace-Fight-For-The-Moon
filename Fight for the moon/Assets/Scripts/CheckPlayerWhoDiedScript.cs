using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerWhoDiedScript : MonoBehaviour {
    private GameObject player;
    private bool next = false;
    private bool hit = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        player = collision.gameObject;
        StartCoroutine(startnextround(collision.gameObject));
        GameObject.Find("Canvas").GetComponent<ScoreHandler>().addScore(player);
    }


    private void Update()
    {
        if(transform.localScale.x < 1 && transform.localScale.y < 1)
        {
            transform.localScale += new Vector3(0.01F, 0.01F, 0);
        }
        if (player != null && player.transform.localScale.x > 0)
        {
            player.transform.localScale -= new Vector3(0.1F, 0.1F, 0);
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            
        }

    }

  

    IEnumerator startnextround(GameObject Player)
    {

        yield return new WaitForSeconds(1f);
        if (Player.name == "player2")
        {
            Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            Player.transform.localScale = new Vector3(8, 8, 0);
            Player.transform.position = new Vector3(13, -7.5f, -4.99f);
        }
        else if (Player.name == "player1")
        {
            Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            Player.transform.localScale = new Vector3(8, 8, 0);
            Player.transform.position = new Vector3(-13, -7.5f, -4.99f);
        }
        Player = null;
        player = null;

    }
}
