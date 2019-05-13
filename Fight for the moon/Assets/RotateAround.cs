using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour {

    public float RotateSpeed;
    public float Radius;
    public float spacebetween;


    private Vector2 _centre;
    private float _angle;

    private void Start()
    {
        _centre = GameObject.Find("blackhole").transform.position;
    }

    private void Update()
    {

        _angle +=  +  RotateSpeed * Time.deltaTime;

        var offset = new Vector2(Mathf.Sin(_angle + spacebetween), Mathf.Cos(_angle + spacebetween)) * Radius;
        transform.position = _centre + offset;
    }
}
