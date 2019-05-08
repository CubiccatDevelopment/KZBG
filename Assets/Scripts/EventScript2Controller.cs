using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventScript2Controller : MonoBehaviour {
	bool x= true,y=true;
	public GameObject dolary;
	public GameObject dolarGen;
	public GameObject WebGen;
	public GameObject webshows;
	// Use this for initialization
	void Start () {
		dolary.gameObject.SetActive (false);
		webshows.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (dolarGen.activeSelf == true && x) {
			dolary.gameObject.SetActive (true);
			x = false;
		} else
			x = true;
		if (WebGen.activeSelf == true && y) {
			webshows.gameObject.SetActive (true);
			y = false;
		}


	}
}
