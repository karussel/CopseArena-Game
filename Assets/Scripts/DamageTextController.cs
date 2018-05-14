using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageTextController : MonoBehaviour {

    public static string koratDamageDisplay = "n";
    public static string enemyDamageDisplay = "n";
    // Use this for initialization
    void Start () {

        GetComponent<Renderer>().sortingOrder = 0; // Set text to be above all else in sorting order
        if (koratDamageDisplay == "y")
        {
            GetComponent<TextMeshPro>().text = BattleFlow.koratDamage.ToString();
        }

        if (enemyDamageDisplay == "y")
        {
            GetComponent<TextMeshPro>().text = BattleFlow.enemyDamage.ToString();
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
