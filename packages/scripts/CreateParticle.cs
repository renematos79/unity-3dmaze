using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateParticle : MonoBehaviour {

	public GameObject Particle;
	private GameObject ParticleInstance;

	// Use this for initialization
	void Start () {
		if (this.Particle != null) {
			ParticleInstance = Instantiate (this.Particle, this.gameObject.transform.position, Quaternion.identity);
		} else {
			ParticleInstance = null;
		}
	}

	public void DestroyParticle(){
		if (this.ParticleInstance != null) {
			DestroyObject (this.ParticleInstance.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
