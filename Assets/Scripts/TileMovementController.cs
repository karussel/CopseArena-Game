using System.Collections.Generic;
using UnityEngine;

// © 2017 TheFlyingKeyboard and released under MIT License
// theflyingkeyboard.net

public class TileMovementController : MonoBehaviour {

	private Animator animRef;
    private Rigidbody2D koratRigidBody;

	Vector3 pos;                                // For movement
	float speed = 5.0f;                         // Speed of movement

    private bool playerMoving;
    private Vector2 lastMove;


	void Start () {
		
		animRef = GetComponent<Animator> (); // Reference the animation conditions to this class
        koratRigidBody = GetComponent<Rigidbody2D>();
		pos = transform.position;          // Take the initial position
	}

	void FixedUpdate ()
	{
        playerMoving = false;

        if (Input.GetAxisRaw("Horizontal") > 0.5f || Input.GetAxisRaw("Horizontal") < -0.5f)
        {
            playerMoving = true; // activate animation reference
        }
        if (Input.GetAxisRaw("Vertical") > 0.5f || Input.GetAxisRaw("Vertical") < -0.5f)
        {
            playerMoving = true; // activate animation reference
        }

        if (Input.GetKey(KeyCode.A) && transform.position == pos)        // Left
        {
            pos += Vector3.left;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f); // Saves last movement for animator
        }


		if (Input.GetKey (KeyCode.D) && transform.position == pos) {        // Right
			pos += Vector3.right;
            lastMove = new Vector2(Input.GetAxisRaw("Horizontal"), 0f); // Saves last movement for animator
        }

		if (Input.GetKey (KeyCode.W) && transform.position == pos) {        // Up
			pos += Vector3.up;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical")); // Saves last movement for animator
        }

		if (Input.GetKey (KeyCode.S) && transform.position == pos) {        // Down
			pos += Vector3.down;
            lastMove = new Vector2(0f, Input.GetAxisRaw("Vertical")); // Saves last movement for animator
        }


		animRef.SetFloat ("MoveX", Input.GetAxisRaw ("Horizontal"));
		animRef.SetFloat ("MoveY", Input.GetAxisRaw ("Vertical"));
        animRef.SetBool("PlayerMoving", playerMoving);
        animRef.SetFloat("LastMoveX", lastMove.x);
        animRef.SetFloat("LastMoveY", lastMove.y);

        transform.position = Vector3.MoveTowards (transform.position, pos, Time.deltaTime * speed);    // Move there
		}
	}