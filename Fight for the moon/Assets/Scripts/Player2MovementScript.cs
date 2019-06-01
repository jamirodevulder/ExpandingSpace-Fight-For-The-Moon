using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2MovementScript : MonoBehaviour
{
    public float speed = 5;
    public float jumpForce = 10;
<<<<<<< HEAD
    private float firstSpeed = 50;

=======
 
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687
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
<<<<<<< HEAD
        if (Input.GetKeyDown(KeyCode.DownArrow) && grounded)
=======
        if (Input.GetKeyDown(KeyCode.S) && grounded)
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687
        {
            area.forceMagnitude = 1000f;
            animator.SetTrigger("PushGround");
        }
<<<<<<< HEAD
        else if(Input.GetKeyDown(KeyCode.DownArrow) && !grounded)
=======
        else if(Input.GetKeyDown(KeyCode.S) && !grounded)
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687
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


<<<<<<< HEAD
        if(Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow) )
=======
        if(Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.A) )
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687
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
<<<<<<< HEAD
            if(GetComponent<Rigidbody2D>().velocity.magnitude < 2f)
            {
                GetComponent<Rigidbody2D>().AddForce(transform.right * firstSpeed);
            }
          
=======
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody2D>().AddForce(transform.right * -speed);
            GetComponent<SpriteRenderer>().flipX = false;
<<<<<<< HEAD
            if (GetComponent<Rigidbody2D>().velocity.magnitude < 2f)
            {
                GetComponent<Rigidbody2D>().AddForce(transform.right * -firstSpeed);
            }

=======
>>>>>>> 4c76668e3099a5a92c2d9b6a8eccc7a5e2863687
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
