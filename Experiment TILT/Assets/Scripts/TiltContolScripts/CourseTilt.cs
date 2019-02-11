using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourseTilt : MonoBehaviour {

	public Rigidbody rb;
	private Vector3 slowDown;
	public float torqueSpeed;
	public float stopSpeed;
	
	void Start() {
        rb = GetComponent<Rigidbody>();
    }

	//comments hold angularVelocity set method
	void FixedUpdate () {
		Vector3 baseVel = new Vector3 (0,0,1);
		//float turn = Input.GetAxis("Horizontal");
		if (Input.GetKey("a")) {
			rb.AddTorque(transform.forward * torqueSpeed);
			//rb.angularVelocity = baseVel;
		}
		else if (Input.GetKey("d")) {
			rb.AddTorque(-transform.forward * torqueSpeed);
			//rb.angularVelocity = -baseVel;
		}	
		// else{
		// 	if (rb.angularVelocity.z > 0){
		// 		slowDown = new Vector3 (0,0,rb.angularVelocity.z - stopSpeed);
		// 		rb.angularVelocity= slowDown;
		// 	if (rb.angularVelocity.z < 0){
		// 		slowDown = new Vector3 (0,0,rb.angularVelocity.z + stopSpeed);
		// 		rb.angularVelocity= slowDown;
		// 		}
		// 	//rb.angularVelocity = Vector3.zero;
		// 	}	
		Debug.Log(rb.angularVelocity);
		}
	}
//}

