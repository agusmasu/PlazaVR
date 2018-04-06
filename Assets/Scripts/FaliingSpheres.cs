using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FaliingSpheres : MonoBehaviour {
	

	private bool _isFirstTime;
	private List<Rigidbody> _spheres;

	// Use this for initialization
	void Start () {
		_spheres = new List<Rigidbody> ();	
		GameObject[] list = GameObject.FindGameObjectsWithTag ("Fallable");
		Debug.Log ("Length = "+ list.Length);
		for (int i = 0; i < list.Length; i++) {
			Rigidbody rb = list [i].GetComponent<Rigidbody> ();
			if (rb != null) {
				Debug.Log ("RB Is Not Null");
				_spheres.Add (rb);
			}
			else Debug.Log ("RB Is Null");
		}
		_isFirstTime = true;
	}
	
	// Update is called once per frame
	void Update () {
				
	}

	void OnTriggerEnter (Collider c){
		if (_isFirstTime) {
			foreach (Rigidbody rb in _spheres) {
				rb.isKinematic = false;
			}
			_isFirstTime = false;
		}
	}


}
