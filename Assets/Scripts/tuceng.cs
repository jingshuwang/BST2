using UnityEngine;
using System.Collections;
using UnityEngine.UI;//注意这个不能少
//using UnityEditor.Sprites ;
public class tuceng : MonoBehaviour {
	//public GameObject Gmenue;
	public GameObject btnObj ;
	public GameObject caidan;
//	public Sprite   expan;
//	public Sprite  back;
	bool isshow=false ;
	// Use this for initialization
	void Start () {

		caidan.SetActive (isshow);

	}

	// Update is called once per frame
	void Update () {
//		

	}

	public void OnClick(){

		isshow=!isshow;
		caidan.SetActive (isshow);
		Debug.Log ("Button Clicked. ClickHandler.");
	}




}
