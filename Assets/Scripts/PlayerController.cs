using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public static float koratHP = 100;
    public static float koratMaxHP = 100;
    public Transform damagetextObj;

    

    // Use this for initialization
    void Start() {
        }

    void Update()   {

        if ((Input.GetKeyDown(KeyCode.G)) && (BattleFlow.koratTurn == 1)) // battleflow used to order the attacks in case of multiple characters
        {
            BattleFlow.currentDamage = 25; // current damage test
            BattleFlow.damageDisplay = "y";
            Invoke("DamageText", 1.5f); // Invoke damage number text with timed delay so the number appears at the same time Korat slashes his sword
            GetComponent<Animator>().SetTrigger("UpslashAnim"); // trigger the melee animation
            BattleFlow.koratTurn = 2; // set Korat turn to end
        }

        if (koratHP <= 0)
        {
            BattleFlow.koratStatus = "dead";
            Destroy(gameObject);
        }
    }

    public void DamageText()
    {
        var cloneText =
        Instantiate(damagetextObj, new Vector2(-7.71f, -3.37f), damagetextObj.rotation);
        Destroy(cloneText.gameObject, 1.5f); // Remove hit number text
    }

}
