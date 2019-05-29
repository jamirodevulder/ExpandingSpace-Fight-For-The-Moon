using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2MovementScript : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 10;
    public float firstSpeed;
 
    bool grounded;
    private Animator animator;
    public GameObject landAnimation;
    // Use this for initialization
    void Start ()
    {
        animator = GetComponent<Animator>();
	}

    private void Update()
    {
        AreaEffector2D area = GetComponent<AreaEffector2D>();
        BoxCollider2D pushCollider = GetComponent<BoxCollider2D>();
        if (Input.GetKeyDown(KeyCode.DownArrow) && grounded)
        {
            area.forceMagnitude = 1000f;
            animator.SetTrigger("PushGround");
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow) && !grounded)
        {
            area.forceMagnitude = 1000f;
            animator.SetTrigger("PushAir");
        }
        else
        {
            area.forceMagnitude = 0f;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            area.forceAngle = 135f;
            pushCollider.offset = new Vector2(-0.1f, 0f);
            animator.SetBool("Walk", true);
    
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            area.forceAngle = 45f;
            pushCollider.offset = new Vector2(0.1f, 0f);
            animator.SetBool("Walk", true);
       
        }


        if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow) )
        {
            animator.SetBool("Walk", false);
            
        }
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
            GetComponent<SpriteRenderer>().flipX = true;
            if(GetComponent<Rigidbody2D>().velocity.magnitude < 2f)
            {
                GetComponent<Rigidbody2D>().AddForce(transform.right * firstSpeed);
            }
          
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * -speed);
            GetComponent<SpriteRenderer>().flipX = false;
            if (GetComponent<Rigidbody2D>().velocity.magnitude < 2f)
            {
                GetComponent<Rigidbody2D>().AddForce(transform.right * -firstSpeed);
            }

        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            grounded = false;
            animator.SetBool("Jump", true);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            //Debug.Log("Touch ground!");
            grounded = true;
            animator.SetBool("Jump", false);
            landAnimation.SetActive(true);
            landAnimation.GetComponent<Animator>().SetTrigger("Hitground");
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            //Debug.Log("Exit ground!");
            grounded = false;
            animator.SetBool("Jump", true);
        }
    }
}
//GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
//transform.position -= new Vector3(+speed, 0, 0) * Time.deltaTime;
