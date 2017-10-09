using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollider : MonoBehaviour {

	public AudioClip PlaySound;
	public AudioSource AudioSrc;
	public GameEngine Engine;

	private CreateParticle ParticleInstance = null;

	// Use this for initialization
	void Start () {
		this.ParticleInstance = GetComponent<CreateParticle> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.CompareTag ("Player")) {
			AudioManager.Instance.PlayClip(PlaySound);
			if (this.ParticleInstance != null) {
				this.ParticleInstance.DestroyParticle ();
			}
			if (this.Engine != null) {
				this.Engine.UpdateEggs ();
			}
			Destroy(this.gameObject);
		}
	}
}
