using UnityEngine;
using System.Collections;

public class RunRobot : MonoBehaviour {

	public GameObject Follow;
	public float RotationSpeed = 3.0f;
	public float MovementSpeed = 3.0f;
	private Animator anim;

	void Start () {
	
		anim = this.gameObject.GetComponent<Animator> ();
		//walk anim.SetInteger("Speed", 1);


	}
	
	// Update is called once per frame
	void Update () {
		anim.SetInteger("Speed", 2);
		transform.rotation = Quaternion.Slerp (transform.rotation, 
			Quaternion.LookRotation (Follow.transform.position - transform.position), 
			RotationSpeed * Time.deltaTime);
		transform.position += transform.forward * MovementSpeed * Time.deltaTime;
	}
}
