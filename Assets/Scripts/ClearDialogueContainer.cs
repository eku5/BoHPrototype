using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearDialogueContainer : MonoBehaviour {

	public Text words;
	public Color here;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () 
	{
		if (words.text == "") {

			GameObject.Find ("Dialogue Container").GetComponent<Image> ().color = Color.clear; 
		} else {
			GameObject.Find ("Dialogue Container").GetComponent<Image> ().color = here;
		}
	}
}
