using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneTilt : MonoBehaviour {

	public Rigidbody rb;
	public GameObject sphere;
	public float ballSpeed;

	void Start() {
        rb = sphere.GetComponent<Rigidbody>();
    }
	void FixedUpdate () {

        Vector3 dir = Vector3.zero;
        dir.x = Input.acceleration.x;
		rb.AddForce(transform.right * dir.x * ballSpeed);
    }
}