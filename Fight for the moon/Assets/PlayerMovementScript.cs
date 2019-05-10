using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour {
    public float speed = 0;
    public float jumpspeed = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(+speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A) && transform.position.x >= -8.5)
        {
            transform.position -= new Vector3(+speed, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.W))
        {
           
           
              
               GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpspeed), ForceMode2D.Impulse);
               

            
        }

        


       
        

    }
}
