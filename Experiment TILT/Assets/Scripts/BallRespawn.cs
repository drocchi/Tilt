using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRespawn : MonoBehaviour {

	private Vector3 respawnPoint;
	public Rigidbody rb;
	void Start(){
		rb = GetComponent<Rigidbody>();
		Vector3 respawnPoint = transform.position;
	}
	void Update () {
		if (transform.position.y < -3){
			rb.velocity = Vector3.zero;
			transform.position = new Vector3 (0, 5, 0);
		}
	}
}
