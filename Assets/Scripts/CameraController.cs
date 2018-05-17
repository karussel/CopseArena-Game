using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject followTarget; // Follow player etc
	private Vector3 targetPos; 
	public float moveSpeed; // Camera movespeed

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		targetPos = new Vector3 (followTarget.transform.position.x, followTarget.transform.position.y, transform.position.z); // take x and y values from vector
		transform.position = Vector3.Lerp (transform.position, targetPos, moveSpeed + Time.deltaTime); // camera movement updates
	}
}
