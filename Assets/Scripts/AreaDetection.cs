using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AreaDetection : MonoBehaviour {

	public string areaName;
	private Text textToEdit;




	// Use this for initialization
	void Start () {
		textToEdit = GameObject.Find ("RoomText").GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter (Collider c){
		textToEdit.text = areaName;
	}
}
