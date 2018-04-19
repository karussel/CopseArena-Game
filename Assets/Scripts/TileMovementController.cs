using System.Collections.Generic;
using UnityEngine;

// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net

public class TileMovementController : MonoBehaviour {
	private Animator animRef;
	Vector3 pos;                                // For movement
	float speed = 5.0f;                         // Speed of movement

	void Start () {
		
		animRef = GetComponent<Animator> (); // Reference the animation conditions to this class

		pos = transform.position;          // Take the initial position
	}

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.A) && transform.position == pos) {        // Left
			pos += Vector3.left;

			while (Vector3.left.x < 0) {
				animRef.SetBool("AnimationLeft", true);										// activate left animation bool
			}
		}

		if (Input.GetKey (KeyCode.D) && transform.position == pos) {        // Right
			pos += Vector3.right;

			while (Vector3.right.x > 0) {
				animRef.SetBool("AnimationRight", true);										// activate right animation bool
			}
		}

		if (Input.GetKey (KeyCode.W) && transform.position == pos) {        // Up
			pos += Vector3.up;

			while (Vector3.up.y > 0) {
				animRef.SetBool("AnimationUp", true);										// activate up animation bool
			}
		}

			if (Input.GetKey (KeyCode.S) && transform.position == pos) {        // Down
				pos += Vector3.down;

			while (Vector3.down.y < 0) {
					animRef.SetBool("AnimationDown", true);									// activate down animation bool
				}


			}
		transform.position = Vector3.MoveTowards (transform.position, pos, Time.deltaTime * speed);    // Move there
		}
	}
