using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTest : MonoBehaviour {

	public GameObject test;
	float speed = 90f;
	float i = 0;
	float allTime = 1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
//		float rotation = Input.GetAxis ("Horizontal") * speed * Time.deltaTime;
//		if (Input.GetMouseButton (0)){
			i += Time.deltaTime;
			if (i <= allTime) {
				test.transform.Rotate (Vector3.up * Time.deltaTime * speed);
			}
		
//		}

	}

//	void Rotate_test () {
//		
//	}
}
