using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;



public class TileMovementController : MonoBehaviour {

	private Animator animRef;
    private Rigidbody2D koratRigidBody;

	float speed = 5.0f;                         // Speed of movement

    private bool playerMoving;
    private Vector2 lastMove;

    public bool canMove;


	void Start () {
		
		animRef = GetComponent<Animator> (); // Reference the animation conditions to this class
        koratRigidBody = GetComponent<Rigidbody2D>();

        canMove = true;
	}

	void Update ()
	{
        playerMoving = false;

        if(!canMove)
        {
            koratRigidBody.velocity = Vector2.zero;
            return;
        }


        if (CrossPlatformInputManager.GetAxisRaw("Horizontal") > 0.5f || CrossPlatformInputManager.GetAxisRaw("Horizontal") < -0.5f)
        {
            koratRigidBody.velocity = new Vector2(CrossPlatformInputManager.GetAxisRaw("Horizontal") * speed, koratRigidBody.velocity.y);
            playerMoving = true; // activate animation reference
            lastMove = new Vector2(CrossPlatformInputManager.GetAxisRaw("Horizontal"), 0f);
        }
        if (CrossPlatformInputManager.GetAxisRaw("Vertical") > 0.5f || CrossPlatformInputManager.GetAxisRaw("Vertical") < -0.5f)
        {
            koratRigidBody.velocity = new Vector2(koratRigidBody.velocity.x, CrossPlatformInputManager.GetAxisRaw("Vertical") * speed);
            playerMoving = true; // activate animation reference
            lastMove = new Vector2(0f, CrossPlatformInputManager.GetAxisRaw("Vertical"));
        }

        if (CrossPlatformInputManager.GetAxisRaw("Horizontal") < 0.5 && CrossPlatformInputManager.GetAxisRaw("Horizontal") > -0.5f)
        {
            koratRigidBody.velocity = new Vector2(0f, koratRigidBody.velocity.y);
        }

        if (CrossPlatformInputManager.GetAxisRaw("Vertical") < 0.5 && CrossPlatformInputManager.GetAxisRaw("Vertical") > -0.5f)
        {
            koratRigidBody.velocity = new Vector2(koratRigidBody.velocity.x, 0f);
        }




        animRef.SetFloat ("MoveX", CrossPlatformInputManager.GetAxisRaw ("Horizontal"));
		animRef.SetFloat ("MoveY", CrossPlatformInputManager.GetAxisRaw ("Vertical"));
        animRef.SetBool("PlayerMoving", playerMoving);
        animRef.SetFloat("LastMoveX", lastMove.x);
        animRef.SetFloat("LastMoveY", lastMove.y);

		}

    public void MoveLeft()
    {

    }

    public void MoveRight()
    {

    }

    public void MoveDown()
    {

    }

    public void MoveUp()
    {

    }

}