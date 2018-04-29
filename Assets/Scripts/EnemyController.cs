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

            GetComponent<Animator>().SetTrigger("EnemyMelee"); // trigger the melee animation
            GetComponent<Transform>().position = new Vector2(2.8f, -0.42f); // Move to enemy position (temporary position move when final asset done)
        }

    }

    public void returnEnemy()
    {

        GetComponent<Transform>().position = new Vector2(2.8f, -0.42f);

    }


}
