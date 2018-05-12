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

	bool newSoundPlayed;
	bool newSoundCued;
	float soundTimer;
	float soundTimerLength;
	// Use this for initialization
	void Start () {
		newSoundCued = false;
		newSoundPlayed = false;
		currentSoundIndex = 0;
		soundTimer = 0f;
		soundTimerLength = 0f;
		source = GetComponent<AudioSource> ();

//		if (backgroundSounds != backgroundSound[currentSoundIndex]) {
//			currentSoundIndex = soundIndex;
//			backgroundSounds.LoadAudioData = backgroundSound [soundIndex];
//		}

	}

	// Update is called once per frame
	void Update () 
	{
		//Debug.Log (source.isPlaying);

		//Getting Variable from Yarn
		currentSoundIndex = Mathf.RoundToInt (variableStorage.GetValue ("$soundIndex").AsNumber);

		//check if this is a new index, also check that the audio source isn't already playing, and that
		//we haven't played a sound effect yet
		if (backgroundSounds != backgroundSound [currentSoundIndex] ) 
		{
			Debug.Log ("current sound index changed " + currentSoundIndex);
			PlayNewSound ();
			newSoundPlayed = true;
			soundTimer = 0f;
			 
		} 

		if (newSoundPlayed == true) {
			soundTimer += Time.deltaTime;
			if (soundTimer > soundTimerLength) {
				newSoundPlayed = false;
			}
		}

	}

	void PlayNewSound() {
		backgroundSounds = backgroundSound [currentSoundIndex];
		source.clip = backgroundSounds;
		soundTimerLength = backgroundSounds.length;
		source.Play ();
	}
}
