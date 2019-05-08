using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZBehavior : MonoBehaviour {

	GameObject Gener;

	void Start () {
		Gener = GameObject.Find ("ZzzGener");
		StartCoroutine ("myLife");
	}
	
	// Update is called once per frame
	void Update () {
		if (Gener.gameObject.activeSelf == false)
			Destroy (gameObject);
		
	}

	IEnumerator myLife(){
		yield return new WaitForSeconds (2);
		Destroy (gameObject);
	}
}
