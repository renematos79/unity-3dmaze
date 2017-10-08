using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BugCollider : MonoBehaviour {

	public AudioClip CatchSound;
	private AudioSource AudioSrc;

	// Use this for initialization
	void Start () {
		AudioSrc = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			AudioSrc.Stop ();
			AudioSrc.clip = CatchSound;
			AudioSrc.Play ();
			Destroy(this.gameObject);
		}

	}
}
