using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetBMIValue : MonoBehaviour {

	public static float height;
	public static float weight;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GetHeight(){
		height = float.Parse(this.GetComponent<InputField>().text);
	}

	public void GetWeight(){
		weight = float.Parse(this.GetComponent<InputField>().text);
	}
}
