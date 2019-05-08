using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSoundBehavior : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.activeSelf == true)
			StartCoroutine (myLife ());
	}

	IEnumerator myLife(){
		yield return new WaitForSeconds (2);
		gameObject.SetActive (false);
	}
}
