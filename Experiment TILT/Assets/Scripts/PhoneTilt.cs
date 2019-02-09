using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneTilt : MonoBehaviour {

	public Rigidbody rb;
	public GameObject sphere;
	public int torqueSpeed;
	private Vector3 oldTilt;
	public float ballSpeed;
	public float camTilt;
	public float tiltSpeed;
	public GameObject camRotationAnchor;
	public GameObject camera;

	void Start() {
        rb = sphere.GetComponent<Rigidbody>();
    }
	void FixedUpdate () {

        Vector3 dir = Vector3.zero;
 
        dir.x = Input.acceleration.x;
		rb.AddForce(transform.right * dir.x * ballSpeed);

		// camRotationAnchor.transform.rotation = Quaternion.Euler(0, 0, Input.acceleration.x * camTilt);
		// camera.transform.rotation = Quaternion.Slerp(transform.rotation, camRotationAnchor.transform.rotation, tiltSpeed * Time.deltaTime);
        // dir *= Time.deltaTime;

 		// Quaternion target = Quaternion.Euler(0, 0, Input.acceleration.x * camTilt);
 		// camera.transform.rotation = Quaternion.RotateTowards(transform.rotation, target,  Time.deltaTime * tiltSpeed);


    }
}