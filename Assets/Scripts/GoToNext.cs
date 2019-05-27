using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToNext : MonoBehaviour {

//	public int sceneNum;
	float m_timer = 0;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		m_timer += Time.time;
		if (m_timer >= 50)
		{
			ShowB(1);
			m_timer = 0;
		}
	}

	private void ShowB(int sceneNum)
	{

		SceneManager.LoadScene(sceneNum);
	}

//	public IEnumerator ChangeLevel(){
//
//		float fadeTime = GameObject.Find ("MenuManageer").GetComponent<Fading> ().BeginFade (1);
//		yield return new WaitForSeconds (fadeTime);
//	}
}
