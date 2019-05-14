﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1MovementScript : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 10;
    bool grounded;
    public Rigidbody2D Player1;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * -speed);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            grounded = false;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //Debug.Log("Touch ground!");
            grounded = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //Debug.Log("Exit ground!");
            grounded = false;
        }
    }
}
//GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
//transform.position -= new Vector3(+speed, 0, 0) * Time.deltaTime;
