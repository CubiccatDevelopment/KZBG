using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndOfTutorial : MonoBehaviour {
	public GameObject MenuAnimObj;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void klikniety(){
		MenuAnimObj.GetComponent<MenuAnimation> ().PlayGameClear ();
		Debug.Log ("KlikPierogTutorial");
	}
}
