using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Score : MonoBehaviour {

	public Transform player;
	public Text scoreText;
	
	void Update () {

		var score = (player.position.z + 45) / 10;
		scoreText.text = score.ToString ("0");
	}
}
