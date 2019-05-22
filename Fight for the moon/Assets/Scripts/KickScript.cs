using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    AreaEffector2D kick;

    // Use this for initialization
    void Start () {
        kick.forceMagnitude = 999f;
    }
	
	// Update is called once per frame
	void Update () {
        AreaEffector2D area = GetComponent<AreaEffector2D>();
        area.forceMagnitude = (666);
        if (Input.GetKeyDown(KeyCode.S))
        {
            area.forceMagnitude = 1000f;
        }
        else
        {
            area.forceMagnitude = 0f;
        }

        if (Input.GetKey(KeyCode.A))
        {
            area.forceAngle = 135f;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            area.forceAngle = 45f;
        }
	}
}
