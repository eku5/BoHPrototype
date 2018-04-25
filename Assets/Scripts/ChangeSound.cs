using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Yarn.Unity;

public class ChangeSound : MonoBehaviour {


	public AudioClip[] backgroundSound;
	public AudioClip backgroundSounds;
	public int currentSoundIndex;
	public ExampleVariableStorage variableStorage;
	public AudioSource source;
	//public int soundIndex;

	// Use this for initialization
	void Start () {

		source = GetComponent<AudioSource> ();

//		if (backgroundSounds != backgroundSound[currentSoundIndex]) {
//			currentSoundIndex = soundIndex;
//			backgroundSounds.LoadAudioData = backgroundSound [soundIndex];
//		}

	}

	// Update is called once per frame
	void Update () 
	{
		Debug.Log (source.isPlaying);
		currentSoundIndex = Mathf.RoundToInt (variableStorage.GetValue ("$soundIndex").AsNumber);
		if (backgroundSounds != backgroundSound [currentSoundIndex]) 
		{
			backgroundSounds = backgroundSound [currentSoundIndex];


		}

		if (!source.isPlaying) {
			source.Play ();
		}

		source.clip = backgroundSounds;
	}
}
