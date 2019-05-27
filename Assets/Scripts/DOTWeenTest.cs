using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DOTWeenTest : MonoBehaviour {

	public Vector3 movingValue;
	public Transform cube;

	// Use this for initialization
	void Start () {
		cube = GameObject.Find ("Cube").transform;
		movingValue = cube.position;


		cube.transform.DOMove (new Vector3 (10, 10, 10), 1);
	}
	
	// Update is called once per frame
	void Update () {
		cube.position = movingValue;
		
	}
}
