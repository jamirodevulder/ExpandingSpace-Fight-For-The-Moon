using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1MovementScript : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    private float firstSpeed = 50f; //Character quickly accelerates to a minimum speed when moving
    public float MFM = 25f; //Movement Force Multiplier
    private float Transparency = 1f;
    public Rigidbody2D rbP1;
    bool grounded;
    private Animator animator;
    public GameObject landAnimation;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        AreaEffector2D area = GetComponent<AreaEffector2D>();
        BoxCollider2D pushCollider = GetComponent<BoxCollider2D>();
        if (Input.GetKeyDown(KeyCode.S) && grounded)
        {
            if (rbP1.velocity.x <= 0f)
            {
                area.forceMagnitude = 1000f - (rbP1.velocity.x * MFM);
            }
            else
            {
                area.forceMagnitude = 1000f + (rbP1.velocity.x * MFM);
            }
            animator.SetTrigger("PushGround");
            Debug.Log(rbP1.velocity.x);
        }
        else if (Input.GetKeyDown(KeyCode.S) && !grounded)
        {
            if (rbP1.velocity.x <= 0f)
            {
                area.forceMagnitude = 1000f - (rbP1.velocity.x * MFM);
            }
            else
            {
                area.forceMagnitude = 1000f + (rbP1.velocity.x * MFM);
            }
            animator.SetTrigger("PushAir");
            Debug.Log(rbP1.velocity.x);
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
        }
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            animator.SetBool("Walk", false);
        }
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
        if (collision.gameObject.tag == "blackhole")
        {
            GetComponent<Rigidbody2D>().constraints = RigidbodyConstraints2D.FreezeAll;
            for (int i = 0; i < 25; i++)
            {
                Transparency = Transparency - 0.01f;
                GetComponent<SpriteRenderer>().color = new Color(1f, 1f, 1f, Transparency);
                Debug.Log(Transparency);
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            //Debug.Log("Exit ground!");
            grounded = false;
            animator.SetBool("Jump", true);
        }
    }
}
//GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
//transform.position -= new Vector3(+speed, 0, 0) * Time.deltaTime;
