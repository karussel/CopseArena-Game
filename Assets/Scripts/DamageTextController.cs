using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DamageTextController : MonoBehaviour {

	// Use this for initialization
	void Start () {

        GetComponent<Renderer>().sortingOrder = 0; // Set text to be above all else in sorting order
        GetComponent<TextMeshPro>().text = BattleFlow.currentDamage.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
