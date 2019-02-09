using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchTilt : MonoBehaviour {

	public Rigidbody rb;
	public int torqueSpeed;
	private bool leftHold;
	private bool rightHold;

	public void Start(){
		rb = GetComponent<Rigidbody>();
		leftHold = false;
		rightHold = false;
	}

	public void FixedUpdate(){
		if(leftHold){
			rb.AddTorque(transform.forward * torqueSpeed);
			Debug.Log("leftHold");
		}
		if(rightHold){
			rb.AddTorque(-transform.forward * torqueSpeed);
			Debug.Log("rightHold");
		}
	}

	public void leftTouch(){
		rb.AddTorque(-transform.forward * torqueSpeed);
	}

	public void leftHoldBegin(){
		leftHold = true;
	}
	public void leftHoldEnd(){
		leftHold = false;
	}

	public void rightTouch(){
		rb.AddTorque(transform.forward * torqueSpeed);
	}

	public void rightHoldBegin(){
		rightHold = true;
		//Debug.Log("right Hold");
	}
	public void rightHoldEnd(){
		rightHold = false;
		//Debug.Log("right hold end");
	}
}
