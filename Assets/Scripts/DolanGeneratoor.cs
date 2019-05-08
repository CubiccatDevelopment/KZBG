using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DolanGeneratoor : MonoBehaviour {
	int count = 0;
	bool wlaczony;
	public GameObject dolan;
	public GameObject dolan2;

	// Use this for initialization
	void Start () {

		wlaczony = true;
			InvokeRepeating ("generatin", 1, 0.1f);
		}
	
	// Update is called once per frame
	void Update () {

		if (count >= 12) {
			gameObject.SetActive (false);

			count = 0;
		}
	}
	void generatin(){
		if (wlaczony&&count<=12) {
			for (int i = 0; i < 10; i++) {
				if (PlayerPrefs.GetInt ("MIECIU") == 0)
				Instantiate (dolan);
				
				else
					Instantiate (dolan2);
			}
			count++;
		}

	}
	void OnDisable(){
		CancelInvoke ("generatin");
		wlaczony = false;
		count = 0;
	
	}
	void OnEnable(){
		wlaczony = true;
		InvokeRepeating ("generatin", 1, 0.1f);

	}


}
