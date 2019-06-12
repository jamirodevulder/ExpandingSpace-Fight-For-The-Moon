using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerWhoDiedScript : MonoBehaviour {
    private GameObject player1;
    private GameObject player2;
    private GameObject player;
    private bool next = false;
    private bool hit = false;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GetComponent<AudioSource>().Play();
        if (collision.gameObject.name == "player1")
        {
            player1 = collision.gameObject;
        }
        else if (collision.gameObject.name == "player2")
        {
            player2 = collision.gameObject;
        }

            
            StartCoroutine(startnextround(collision.gameObject));
        GameObject.Find("Canvas").GetComponent<ScoreHandler>().addScore(collision.gameObject);
    }


    private void Update()
    {
        //if(transform.localScale.x < 1 && transform.localScale.y < 1)
        //{
        //    transform.localScale += new Vector3(0.01f, 0.01f, 0);
        //}
        //if (player1 != null && player1.transform.localScale.x > 0)
        //{
        //    player1.transform.localScale -= new Vector3(0.1f, 0.1f, 0);
        //    player1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            
        //}
        //if (player2 != null && player2.transform.localScale.x > 0)
        //{
        //    player2.transform.localScale -= new Vector3(0.1f, 0.1f, 0);
        //    player2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;

        //}

    }

  

    IEnumerator startnextround(GameObject Player)
    {

        yield return new WaitForSeconds(5f);
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
        if (Player.name == "player1")
        {
            player1 = null;
        }
        else if (Player.name == "player2")
        {
            player2 = null;
        }
        Player = null;
    }
}
