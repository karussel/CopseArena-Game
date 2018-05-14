using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float enemyHP = 100;
    public float enemyMaxHP = 100;
    public static float enemyAttackPower = 20;

    public Transform hitparticleObj;
    public Transform damagetextObj;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

        if (BattleFlow.koratTurn == 2) // if Korat's turn is finished enemy attacks
        {
            Invoke("LexAttack", 2.5f); // trigger attack animation with a delay so the animations don't overlap

            BattleFlow.koratTurn = 1; // Set turn back to Korat
        }

        if (BattleFlow.damageDisplay == "y")
        {
            enemyHP -= BattleFlow.koratDamage;
            Debug.Log(enemyHP);
            BattleFlow.damageDisplay = "n";
        }

        if (enemyHP < -0)
        {
            Destroy(gameObject);
        }

    }

    public void LexAttack()
    {
        GetComponent<Animator>().SetTrigger("LexAttackAnim"); // trigger the melee animation
        // Debug.Log("Play enemy attack animation");
        GetComponent<Transform>().position = new Vector2(6.8f, -3.744f); // Move to enemy position
        KoratHit();
        // Debug.Log("Move to enemy location");
        Invoke("ReturnEnemy", 0.6f);
    }

    public void ReturnEnemy()
    {
        GetComponent<Transform>().position = new Vector2(-7.1f, -3.744f); // Move back to original position
        // Debug.Log("Move to original positon");


    }

    public void KoratHit()
    {
        PlayerController.koratHP -= enemyAttackPower; // Enemy attack to take hp off Korat
        Debug.Log("koratHP" + PlayerController.koratHP);
        enemyAttackPower = BattleFlow.enemyDamage;
        var ecloneText = // create the text which displays the amount of damage done
           Instantiate(damagetextObj, new Vector2(7, -3.37f), damagetextObj.rotation);
        BattleFlow.damageDisplay = "n";
        var ecloneParticle = // create a particle effect to show the player has been hit
        Instantiate(hitparticleObj, hitparticleObj.transform.position = new Vector2(7.575f, -3.744f), hitparticleObj.rotation);

        Destroy(ecloneText.gameObject, 1.5f); // Remove hit number text
        Destroy(ecloneParticle.gameObject, 1.5f); // Remove hit number text
    }





}
