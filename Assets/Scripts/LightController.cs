using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class LightController : MonoBehaviour {

	private Light[] allLights;

	// Use this for initialization
	void Start () {
		allLights = GameObject.FindObjectsOfType<Light> ();

		if (GetComponent<VRTK_ControllerEvents>() == null)
		{
			VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTK_ControllerEvents_ListenerExample", "VRTK_ControllerEvents", "the same"));
			return;
		}

			//Setup controller event listeners
			GetComponent<VRTK_ControllerEvents>().TriggerPressed += new ControllerInteractionEventHandler(DoTriggerPressed);

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.V)) {
			DoTriggerPressed ();
		}
		
	}

	private void DoTriggerPressed(object o, ControllerInteractionEventArgs e){
		for (int i = 0; i < allLights.Length; i++) {
			allLights [i].enabled = !allLights[i].enabled;
		}
	}

	private void DoTriggerPressed(){
		for (int i = 0; i < allLights.Length; i++) {
			allLights [i].enabled = !allLights[i].enabled;
		}
	}
}
