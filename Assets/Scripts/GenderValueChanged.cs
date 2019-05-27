using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenderValueChanged : MonoBehaviour {

	public static string gender = "male";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void MaleChoosed () {

		gender = "male";
	}

	public void FemaleChooded () {

		gender = "female";
	}

	public string GetGender () {

		return gender;
	}
}
