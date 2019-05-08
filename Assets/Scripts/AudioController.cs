using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour {
	
	bool ifStart;

	AudioSource muzykaTlo;



	void Start () {


		ifStart = false;
		muzykaTlo = GetComponent<AudioSource> ();

		muzykaTlo.Stop ();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale > 0&&!ifStart) {
			muzykaTlo.Play ();
			ifStart = true;
		}
		
	}
}
