using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public TMP_Text dText;

    public bool dialogActive;

    public string [] dialogLines;
    public int currentLine;

    private TileMovementController thePlayer;

	// Use this for initialization
	void Start () {
        thePlayer = FindObjectOfType<TileMovementController>();
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //dBox.SetActive(false);
            //dialogActive = false;
            currentLine++;
        }
		if (currentLine >= dialogLines.Length)
        {
            dBox.SetActive(false);
            dialogActive = false;

            currentLine = 0;
            thePlayer.canMove = true;
        }

        dText.text = dialogLines[currentLine];
    }

    public void ShowBox (string dialogue)
    {
        dialogActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }

    public void ShowDialogie()
    {
        dialogActive = true;
        dBox.SetActive(true);
        thePlayer.canMove = false;
    }

}
