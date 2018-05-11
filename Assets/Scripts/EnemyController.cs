using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float enemyHP = 100;
    public float enemyMaxHP = 100;
    public float enemyAttackPower = 25;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (BattleFlow.koratTurn == 2) // if Korat's turn is finished enemy attacks
        {
            Debug.Log("Enemy turn");
            Invoke("LexAttack", 2.5f); // trigger attack animation with a delay so the animations don't overlap
            BattleFlow.koratTurn = 1; // Set turn back to Korat
        }

        if (BattleFlow.damageDisplay == "y")
        {
            enemyHP -= BattleFlow.currentDamage;
            Debug.Log(enemyHP);
            BattleFlow.damageDisplay = "n";
        }

        if (enemyHP<-0)
        {
            Destroy(gameObject);
        }
            
    }

    public void LexAttack()
    {
        GetComponent<Animator>().SetTrigger("LexAttackAnim"); // trigger the melee animation
        GetComponent<Transform>().position = new Vector2(6.8f, -3.744f); // Move to enemy position
        Invoke("ReturnEnemy", 0.6f);
    }

    public void ReturnEnemy()
    {

        GetComponent<Transform>().position = new Vector2(-7.1f, -3.744f); // Move back to original position
        PlayerController.koratHP -= enemyAttackPower; // Enemy attack to take hp off Korat
        Debug.Log("koratHP" + PlayerController.koratHP);

    }


}
