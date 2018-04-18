using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearDialogueContainer : MonoBehaviour {

	public Text words;
	private Color here;
	private Image image;
	// Use this for initialization
	void Start () {
		image = GetComponent<Image> ();
		here = image.color;
	}

	// Update is called once per frame
	void Update () 
	{
		//First attempt at making the Dialoge Container clear when there is no text.

		if (!words.gameObject.activeInHierarchy) {

			image.color = Color.clear; 
		} else {
			image.color = here;
		}


	}
}
