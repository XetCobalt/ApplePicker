﻿using UnityEngine;
using System.Collections;

public class Apple : MonoBehaviour {

	public static float bottomY = -20f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomY) {
			Destroy(this.gameObject);

			//get a reference to the applepicker component of main camera
			ApplePicker apScript = Camera.main.GetComponent<ApplePicker>();
			//call the public AppleDestroyed() method of apScript
			apScript.AppleDestroyed();
		}
	}
}
