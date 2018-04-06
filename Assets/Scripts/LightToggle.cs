using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightToggle : MonoBehaviour {
	public List<Light> list;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.L)) {
			foreach (Light l in list) l.enabled = !l.enabled;
			Debug.Log ("Ahre");
		}		
	}
}
