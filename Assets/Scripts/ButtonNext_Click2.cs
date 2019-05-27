using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNext_Click2 : MonoBehaviour {

	int sceneNum;

	// Use this for initialization
	void Start () {

		if (GenderValueChanged.gender == "male") {
			sceneNum = 9;
		}
		else if (GenderValueChanged.gender == "female"){
			sceneNum = 10;
		}

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnPointerClick(){

		Debug.Log("OnPointerClick called.");
		SceneManager.LoadScene(sceneNum);

	}
}
