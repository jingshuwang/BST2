﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonNext_Click : MonoBehaviour {

	public int sceneNum;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void OnPointerClick(){

		Debug.Log("OnPointerClick called.");
		SceneManager.LoadScene(sceneNum);

	}


}
