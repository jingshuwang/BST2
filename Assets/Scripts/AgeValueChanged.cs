using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgeValueChanged : MonoBehaviour {

	public static string age = "under18";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Under18Choosed () {

		age = "under18";
	}

	public void _1850Chooded () {

		age = "_1850";
	}

	public void Above50Choosed () {

		age = "above50";
	}

	public string GetGender () {

		return age;
	}

}
