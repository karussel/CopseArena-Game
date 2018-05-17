using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleFlow : MonoBehaviour {

    public static int koratTurn = 1;
    public static float koratDamage = 0;
    public static float enemyDamage = 0;


    public static string damageDisplay = "n";

    public static string koratStatus = "OK";
    public static string enemyStatus = "OK";
    public static string attbtnPressed = "n";

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if ((koratTurn == 1) && (koratStatus == "dead"))
        {
            koratTurn = 2;
        }
	}
}
