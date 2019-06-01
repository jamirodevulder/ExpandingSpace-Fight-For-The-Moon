using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1MovementScript : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 10;
    private float firstSpeed = 50;
    bool grounded;
    private Animator animator;
    public GameObject landAnimation;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
<<<<<<< HEAD
       
=======
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687
    }

    private void Update()
    {
        AreaEffector2D area = GetComponent<AreaEffector2D>();
        BoxCollider2D pushCollider = GetComponent<BoxCollider2D>();
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.S) && grounded)
=======
        if (Input.GetKeyDown(KeyCode.DownArrow) && grounded)
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687
        {
            area.forceMagnitude = 1000f;
            animator.SetTrigger("PushGround");
        }
<<<<<<< HEAD
        else if (Input.GetKeyDown(KeyCode.S) && !grounded)
=======
        else if (Input.GetKeyDown(KeyCode.DownArrow) && !grounded)
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687
        {
            area.forceMagnitude = 1000f;
            animator.SetTrigger("PushAir");
        }
        else
        {
            area.forceMagnitude = 0f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            area.forceAngle = 135f;
            pushCollider.offset = new Vector2(-0.1f,0f);
            GetComponent<SpriteRenderer>().flipX = false;
            animator.SetBool("Walk", true);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            area.forceAngle = 45f;
            pushCollider.offset = new Vector2(0.1f, 0f);
            GetComponent<SpriteRenderer>().flipX = true;
            animator.SetBool("Walk", true);
<<<<<<< HEAD
        }


        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Walk", false);
        }
=======
        }


        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            animator.SetBool("Walk", false);
        }
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687
      
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * speed);
            if (GetComponent<Rigidbody2D>().velocity.magnitude < 2f)
            {
                GetComponent<Rigidbody2D>().AddForce(transform.right * firstSpeed);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * -speed);
            if (GetComponent<Rigidbody2D>().velocity.magnitude < 2f)
            {
                GetComponent<Rigidbody2D>().AddForce(transform.right * -firstSpeed);
            }
        }
        if (Input.GetKeyDown(KeyCode.W) && grounded)
        {
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            grounded = false;
            animator.SetBool("Jump", true);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
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
        if (collision.gameObject.tag == "Ground")
        {
            //Debug.Log("Exit ground!");
            grounded = false;
            animator.SetBool("Jump", true);
<<<<<<< HEAD
           
            
=======
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687
        }
        
    }
    
    
}
//GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
//transform.position -= new Vector3(+speed, 0, 0) * Time.deltaTime;
