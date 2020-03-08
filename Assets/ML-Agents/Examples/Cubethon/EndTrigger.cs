using UnityEngine;
using System.Collections;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManager;

	void OnTriggerEnter () {

		gameManager.CompleteLevel ();
	}
}
