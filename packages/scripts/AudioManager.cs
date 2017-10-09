using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour {

	public AudioSource AudioSrc;
	public static AudioManager Instance = null;

	// Use this for initialization
	void Start () {
		if (Instance == null) {
			Instance = this;
		} else if (Instance != this) {
			Destroy (this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void PlayClip(AudioClip clip)
	{
		if (clip != null) {
			AudioSrc.clip = clip;
			AudioSrc.Play ();	
		}
	}

	public void Stop(){
		AudioSrc.Stop ();
	}
}
