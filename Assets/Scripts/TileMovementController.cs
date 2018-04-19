using System.Collections.Generic;
using UnityEngine;

// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net

public class TileMovementController : MonoBehaviour {
	private Animator animRef;
	Vector3 pos;                                // For movement
	float speed = 5.0f;                         // Speed of movement


	private bool AnimationLeft;
	private bool AnimationRight;
	private bool AnimationUp;
	private bool AnimationDown;

	void Start () {
		
		animRef = GetComponent<Animator> (); // Reference the animation conditions to this class
		pos = transform.position;          // Take the initial position
	}

	void FixedUpdate ()
	{
		
		AnimationRight = false;
		AnimationUp = false;
		AnimationDown = false;


		if (Input.GetKey (KeyCode.A) && transform.position == pos) {        // Left
			pos += Vector3.left;
			AnimationLeft = true;			// activate left animation bool
			}
			else
		{
			AnimationLeft = false;
		}


		if (Input.GetKey (KeyCode.D) && transform.position == pos) {        // Right
			pos += Vector3.right;
			AnimationRight = true;			// activate right animation bool
			}

		if (Input.GetKey (KeyCode.W) && transform.position == pos) {        // Up
			pos += Vector3.up;
			AnimationUp = true;			// activate up animation bool
			}

		if (Input.GetKey (KeyCode.S) && transform.position == pos) {        // Down
			pos += Vector3.down;
			AnimationDown = true;			// activate down animation bool
			}

		animRef.SetBool ("AnimationLeft", AnimationLeft);
		animRef.SetBool ("AnimationRight", AnimationRight);
		animRef.SetBool ("AnimationUp", AnimationUp);
		animRef.SetBool ("AnimationDown", AnimationDown);

		animRef.SetFloat ("MoveX", Input.GetAxisRaw ("Horizontal"));
		animRef.SetFloat ("MoveY", Input.GetAxisRaw ("Vertical"));

		transform.position = Vector3.MoveTowards (transform.position, pos, Time.deltaTime * speed);    // Move there
		}
	}