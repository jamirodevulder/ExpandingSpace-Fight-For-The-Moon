using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalBlackHoleP1 : MonoBehaviour {
    
    public float scalespeed;
    private bool hit = false;
    public Vector3 ballposition;
    private GameObject player;
    // Use this for initialization
    void Start () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {



        if (collision.gameObject.name == "ball")
        {
            GameObject.Find("Canvas").GetComponent<ScoreHandler>().addScore(this.gameObject);
        }
            
        
        GetComponent<AudioSource>().Play();
        player = collision.gameObject;
        StartCoroutine(startnextround(collision.gameObject));
        
        

    }
    // Update is called once per frame
    void Update () {
        if (transform.localScale.x < 1 && transform.localScale.y < 1)
        {
            transform.localScale += new Vector3(0.01F, 0.01F, 0);
        }
        if (player != null && player.transform.localScale.x > 0 && player.name == "ball")
        {
            player.transform.localScale -= new Vector3(scalespeed, scalespeed, 0);
            player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
        }
        else if(player != null && player.transform.localScale.x > 0)
        {
            player.transform.localScale -= new Vector3(0.1f, 0.1f, 0);
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
        else if(Player.name == "player1")
        {
            Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeRotation;
            Player.transform.localScale = new Vector3(8, 8, 0);
            Player.transform.position = new Vector3(-13, -7.5f, -4.99f);
        }
        else if(Player.name == "ball")
        {
            Player.GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.None;
            Player.transform.localScale = new Vector3(0.5f, 0.5f, 0);
            Player.transform.position = ballposition;
        }
        Player = null;
        player = null;
        



    }
}
