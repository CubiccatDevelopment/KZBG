using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PierogEffect : MonoBehaviour {



	void Start () {
		StartCoroutine (myLife ());

	}
	
	// Update is called once per frame
	void Update () {

		
	}
	IEnumerator myLife(){
		yield return new WaitForSeconds (1.4f);
		gameObject.SetActive (false);
		Destroy (gameObject);
	}
}
