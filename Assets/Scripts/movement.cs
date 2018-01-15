using System.Collections;
using System.Collections.Generic;
using CnControls;
using UnityEngine;

public class movement : MonoBehaviour {

    Rigidbody2D rbd;
    float horizontal, vertical;
    public float speed;

	// Use this for initialization
	void Start () {
        rbd = GetComponent<Rigidbody2D>();

    }
	
	// Update is called once per frame
	void FixedUpdate () {

        horizontal = CnInputManager.GetAxis("Horizontal");
        vertical = CnInputManager.GetAxis("Vertical");

        Vector2 movement = new Vector2(horizontal,vertical);

        rbd.AddForce(movement*speed);

        horizontal = vertical = 0F;

    }
}
