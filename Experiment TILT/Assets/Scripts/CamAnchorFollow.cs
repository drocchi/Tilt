using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamAnchorFollow : MonoBehaviour {

	public Transform sphere;
	public float zOffset;
	public float yOffset;
	//public GameObject sphere;
	void Update () {
		Vector3 current = transform.position;
		current.y = sphere.position.y + yOffset;
		//current.z = sphere.position.z + zOffset;
		transform.position = current;
		//= sphere.transform.position.y;
	}
}
