﻿using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {

	public Transform player;
	public Vector3 offset;
	
	void Update () {

		transform.position = player.position + offset;
	}
}
