using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZGenerator : MonoBehaviour {
	public GameObject z;
	public GameObject KrzysSpi;
	GameObject[] Zetki;
	void Start () {
		InvokeRepeating ("checkGener",1,0.7f);
		 
	}
	
	// Update is called once per frame
	void Update () {

		

	}
	void checkGener(){
		if (KrzysSpi.activeSelf == false)
			Instantiate (z);
		
	}



}
