using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public static float koratHP = 100;
    public float koratMaxHP = 100;
    public float koratAttackPower = 30;

    public Transform damagetextObj;
    public Transform hitparticleObj;
    public Transform superauraObj;



    // Use this for initialization
    void Start() {
        }

    void Update()   {

        if (((Input.GetKeyDown(KeyCode.G)) || (BattleFlow.attbtnPressed == "y")) && (BattleFlow.koratTurn == 1)) // battleflow used to order the attacks in case of multiple characters
        {
            BattleFlow.attbtnPressed = "n";
            // .Log("G key pressed");
            BattleFlow.koratDamage = koratAttackPower; // current damage test
            BattleFlow.damageDisplay = "y";
            Invoke("DamageText", 1); // Invoke damage number text with timed delay so the number appears at the same time Korat slashes his sword
            // Debug.Log("Created and destroyed text object with a 1.5 sec delay"); // Invoke damage number text with timed delay so the number appears at the same time Korat slashes his sword
            GetComponent<Animator>().SetTrigger("UpslashAnim"); // trigger the melee animation
            // Debug.Log("Play the Korat attack animation");
            BattleFlow.koratTurn = 2; // set Korat turn to end
            // Debug.Log("Set Korat turn to end");
        }

        if (koratHP <= 0) // If statement to destroy Korat if hp is 0
        {
            BattleFlow.koratStatus = "dead";
            Destroy(gameObject);
            // Debug.Log("Korat died");
        }
    }

    public void DamageText()
    {
        // Debug.Log("DamageText");
        var cloneParticle = // create the hit particle which goes to enemy position
        Instantiate(hitparticleObj, hitparticleObj.transform.position = new Vector2(-7.1f, -3.37f), hitparticleObj.rotation);
        var cloneText = // create the text which displays the hit number
            Instantiate(damagetextObj, new Vector2(-7.71f, -3.37f), damagetextObj.rotation); 
        Destroy(cloneText.gameObject, 1.5f); // Remove hit number text
        Destroy(cloneParticle.gameObject, 1.5f); // Remove hit number text
        DamageTextController.koratDamageDisplay = "n";
    }

}
