using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEngine : MonoBehaviour {

	public UnityEngine.UI.Text Label;
	public int MaxEggs = 0;
	private int Eggs;

	// Use this for initialization
	void Start () {
		this.Eggs = 0;
		if (this.Label != null) {
			this.Label.text = this.MaxEggs.ToString ();
		}		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateEggs(){
		this.Eggs++;
		if (this.Label != null) {
			this.Label.text = (this.MaxEggs - this.Eggs).ToString();
		}
	}
}
