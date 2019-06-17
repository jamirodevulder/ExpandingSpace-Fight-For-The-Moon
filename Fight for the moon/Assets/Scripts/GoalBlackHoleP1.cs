using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBlackHoleP1 : MonoBehaviour {
    
    public float scalespeed;
    private bool hit = false;
    public Vector3 ballposition;
    private GameObject player;
    private GameObject player1;
    private GameObject player2;
    private GameObject ball;
    private float Transparency = 1f;
    // Use this for initialization
    void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {



        if (collision.gameObject.name == "ball")
        {
            GameObject.Find("Canvas").GetComponent<ScoreHandler>().addScore(this.gameObject);
        }

        if (collision.gameObject.name == "player1")
        {
            player1 = collision.gameObject;
        }
        else if (collision.gameObject.name == "player2")
        {
            player2 = collision.gameObject;
        }
        else if(collision.gameObject.name == "ball")
        {
            ball = collision.gameObject;
            ball.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            Transparency = 1;
            StartCoroutine(DelayLoop(collision.gameObject));
        }

        GetComponent<AudioSource>().Play();
        StartCoroutine(startnextround(collision.gameObject));
        
        

    }
    // Update is called once per frame
    void Update () {
        if (transform.localScale.x < 1 && transform.localScale.y < 1)
        {
            transform.localScale += new Vector3(0.01F, 0.01F, 0);
        }
        //if (ball != null && ball.transform.localScale.x > 0 && ball.name == "ball")
        //{
           // ball.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        //}
      //  if (player1 != null && player1.transform.localScale.x > 0)
       // {
        //    player1.transform.localScale -= new Vector3(0.1F, 0.1F, 0);
           // player1.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
       // }
       // if (player2 != null && player2.transform.localScale.x > 0)
       // {
        //    player2.transform.localScale -= new Vector3(0.1F, 0.1F, 0);
           // player2.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
       // }
    }


    IEnumerator startnextround(GameObject Player)
    {
        
        yield return new WaitForSeconds(3f);
        if (Player.name == "player2")
        {
            Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            Player.transform.localScale = new Vector3(8, 8, 0);
            Player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1);
            Player.transform.position = new Vector3(13, -7.5f, -4.99f);
        }
        else if(Player.name == "player1")
        {
            Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            Player.transform.localScale = new Vector3(8, 8, 0);
            Player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1);
            Player.transform.position = new Vector3(-13, -7.5f, -4.99f);
            
        }
        else if(Player.name == "ball")
        {
            Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            Player.transform.localScale = new Vector3(6f, 6f, 0);
            Player.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, 1);
            Player.transform.position = ballposition;
        }
        if (Player.name == "player1")
        {
            player1 = null;
        }
        else if (Player.name == "player2")
        {
            player2 = null;
        }
        else if(Player.name == "ball")
        {
            ball = null;
        }
        Player = null;
        player = null;
        



    }
    IEnumerator DelayLoop(GameObject ball)
    {
        for (int i = 0; i < 100; i++)
        {
            Transparency = Transparency - 0.01f;
            ball.GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, Transparency);
            Debug.Log(Transparency);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
