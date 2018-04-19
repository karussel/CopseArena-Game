using System.Collections.Generic;
using UnityEngine;

// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net

public class TileMovementController : MonoBehaviour {
	private Animator animRef;
	Vector3 pos;                                // For movement
	float speed = 5.0f;                         // Speed of movement

	public bool animationLeft;					// For activating the left walk animation
	public bool animationRight;					// For activating the right walk animation
	public bool animationUp;					// For activating the up walk animation
	public bool animationDown;					// For activating the down walk animation



	void Start () {
		
		animRef = GetComponent<Animator> (); // Reference the animation conditions to this class

		pos = transform.position;          // Take the initial position
	}

	void FixedUpdate ()
	{
		if (Input.GetKey (KeyCode.A) && transform.position == pos) {        // Left
			pos += Vector3.left;

			while (Vector3.left.x > 0) {
				animationLeft = true; animRef.SetBool("AnimationLeft", true);										// activate left animation bool
			}
		}

		if (Input.GetKey (KeyCode.D) && transform.position == pos) {        // Right
			pos += Vector3.right;

			while (Vector3.left.x < 0) {
				animationRight = true; animRef.SetBool("AnimationRight", true);										// activate right animation bool
			}
		}

		if (Input.GetKey (KeyCode.W) && transform.position == pos) {        // Up
			pos += Vector3.up;

			while (Vector3.left.y > 0) {
				animationUp = true; animRef.SetBool("AnimationUp", true);										// activate up animation bool
			}
		}

			if (Input.GetKey (KeyCode.S) && transform.position == pos) {        // Down
				pos += Vector3.down;

				while (Vector3.left.y < 0) {
				animationDown = true; animRef.SetBool("AnimationDown", true);									// activate down animation bool
				}


			}
		transform.position = Vector3.MoveTowards (transform.position, pos, Time.deltaTime * speed);    // Move there
		}
	}
