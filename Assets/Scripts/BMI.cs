using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BMI : MonoBehaviour {

	public Text textBMI;
	float valueBMI;

	// Use this for initialization
	void Start () {
		
		valueBMI = GetBMIValue.weight / (GetBMIValue.height * GetBMIValue.height /10000); 
		textBMI.text = valueBMI.ToString("#0.0");


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
