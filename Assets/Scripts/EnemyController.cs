using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {



// Use this for initialization
void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (Input.GetKeyDown("space"))
        {

            GetComponent<Animator>().SetTrigger("LexAttackAnim"); // trigger the melee animation
            GetComponent<Transform>().position = new Vector2(6.8f, -3.744f); // Move to enemy position (temporary position move when final asset done)
        }

    }

    public void ReturnEnemy()
    {

        GetComponent<Transform>().position = new Vector2(-7.1f, -3.744f); // Move back to original position

    }


}
