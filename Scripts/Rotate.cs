﻿using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public float speed = 10f;
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,0, speed * Time.deltaTime);
	}
}
