using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public Transform camAnchor;
	public float smoothSpeed;
	public float rotationSpeed;

  	// Update is called once per frame
	void FixedUpdate () {
		Vector3 desiredPosition = camAnchor.position;
		Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
		transform.position = smoothedPosition;
		transform.rotation = Quaternion.Lerp(transform.rotation, camAnchor.rotation, rotationSpeed);

    	//transform.LookAt(player);
	}
}