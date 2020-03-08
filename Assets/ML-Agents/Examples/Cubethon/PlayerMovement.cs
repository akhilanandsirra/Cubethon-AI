using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 1000f;
	public float sidewaysForce = 1000f;

	void FixedUpdate () {
		
		rb.AddForce (0, 0, forwardForce * Time.deltaTime);

		if (Input.GetKey (KeyCode.RightArrow)) {
			
			rb.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {

			rb.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		if (rb.position.y < -1f) {

			FindObjectOfType<GameManager> ().EndGame ();
		}
	}
}
