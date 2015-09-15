using UnityEngine;
using System.Collections;

public class PlayerTranscriptMove : MonoBehaviour {

	private float velocity = 8;
	// Use this for initialization
	private Animator anim;

	void Start () {
		anim = this.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
//	void Update () {
//		float h = Input.GetAxis("Horizontal");
//		float v = Input.GetAxis("Vertical");
//		Vector3 vel = rigidbody.velocity;
//		rigidbody.velocity = new Vector3 (h * velocity, vel.y, v * velocity);
//	    
//		if (Mathf.Abs (h) > 0.05f || Mathf.Abs (v) > 0.05f) {
//			transform.rotation = Quaternion.LookRotation(new Vector3(h, 0, v));
//		}
//	}


	void Update () {
		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");
		Vector3 vel = rigidbody.velocity;

		
		if (Mathf.Abs (h) > 0.05f || Mathf.Abs (v) > 0.05f) {
			anim.SetBool ("Move", true);
			rigidbody.velocity = new Vector3 (h * velocity, vel.y, v * velocity);
			transform.LookAt(new Vector3 (h, 0, v) + transform.position);
		} else {
			anim.SetBool ("Move", false);
			rigidbody.velocity = new Vector3 (0, vel.y, 0);
		}
	}
}
