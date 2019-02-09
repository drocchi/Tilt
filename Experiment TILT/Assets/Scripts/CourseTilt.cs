using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseTilt : MonoBehaviour {

	public float torqueSpeed;
	public float stopSpeed;
	public Rigidbody rb;
	public Vector3 torque;
	private Vector3 slowDown;
	
	void Start() {
        rb = GetComponent<Rigidbody>();
    }

	void FixedUpdate () {
		Vector3 bob = new Vector3 (0,0,1);
		//float turn = Input.GetAxis("Horizontal");
		if (Input.GetKey("a")) {
			//rb.AddTorque(transform.forward * torqueSpeed);
			rb.angularVelocity = bob;
		}
		else if (Input.GetKey("d")) {
			//rb.AddTorque(-transform.forward * torqueSpeed);
			rb.angularVelocity = -bob;
		}	
		else{
			if (rb.angularVelocity.z > 0){
				slowDown = new Vector3 (0,0,rb.angularVelocity.z - stopSpeed);
				rb.angularVelocity= slowDown;
			if (rb.angularVelocity.z < 0){
				slowDown = new Vector3 (0,0,rb.angularVelocity.z + stopSpeed);
				rb.angularVelocity= slowDown;
				}
			//rb.angularVelocity = Vector3.zero;
			}	
		Debug.Log(rb.angularVelocity);
		}
	}
}
