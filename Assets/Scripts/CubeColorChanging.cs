using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorChanging : MonoBehaviour {
	
	private List<Color> availableColors;
	private int _actualIndex = 0;

	// Use this for initialization
	void Start () {
		availableColors = new List<Color> ();
		availableColors.Add (Color.red);
		availableColors.Add (Color.blue);
		availableColors.Add (Color.black);
		availableColors.Add (Color.yellow);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider c){
		if (_actualIndex == availableColors.Count)
			_actualIndex = 0;
		else
			_actualIndex++;
		gameObject.GetComponent<Renderer>().material.color = availableColors[_actualIndex];

	}
}
