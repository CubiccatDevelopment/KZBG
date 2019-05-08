using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventTextBehavior : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Time.timeScale == 0) {
			gameObject.SetActive (false);
		}
		
	}
	IEnumerator Behavior(){

		yield return new WaitForSeconds (2);
		gameObject.SetActive (false);

	}
	void OnEnable(){
		StartCoroutine (Behavior ());
	}
}
