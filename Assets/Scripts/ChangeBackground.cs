using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class ChangeBackground : MonoBehaviour {
	public Sprite[] backgroundImages;
	public SpriteRenderer backgroundSr;
	private int currentBackgroundIndex;
	public ExampleVariableStorage variableStorage;
	public int backgroundIndex;

	// Use this for initialization
	void Start () {


	}

	// Update is called once per frame
	void Update () {

		backgroundIndex = Mathf.RoundToInt (variableStorage.GetValue ("$backgroundIndex").AsNumber);
		if (backgroundIndex != currentBackgroundIndex) {
			currentBackgroundIndex = backgroundIndex;
			backgroundSr.sprite = backgroundImages [backgroundIndex];
		}
	}

	[YarnCommand("do")]
	public void doThing(string sent)
	{
		int index = int.Parse (sent);
		Debug.Log (sent + " is the string you sent me!");
	}

}
