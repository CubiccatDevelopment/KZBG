using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour {
	public GameObject instr0,instr1, instr11, instr2, instr22;
	public GameObject kurczak;
	// Use this for initialization
	void Start () {

		instr1.gameObject.SetActive (false);
		instr11.gameObject.SetActive (false);
		instr2.gameObject.SetActive (false);
		instr22.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.timeScale > 0) {
			instr1.gameObject.SetActive (false);
			instr11.gameObject.SetActive (false);
			instr2.gameObject.SetActive (false);
			instr22.gameObject.SetActive (false);
		}
		
	}
	public void tutorial(){
		//instrukcja1[0].gameObject.SetActive (true);
		//instrukcja1[0].gameObject.SetActive (false);
	}
	public void tutorial1(){
		instr0.gameObject.GetComponent<Logomoving> ().speed = 0;
		instr11.gameObject.GetComponent<Logomoving> ().speed = 15;
		instr1.gameObject.SetActive (true);
		instr11.gameObject.SetActive (true);
		kurczak.gameObject.SetActive (true);
	}
	public void tutorial2(){
	//	PlayerPrefs.SetInt ("Tutorial", 1);
		StartCoroutine ("tutorial2W");
	}
	public void tutorial3(){
		instr1.gameObject.SetActive (false);
		instr11.gameObject.SetActive (false);
		instr2.gameObject.SetActive (false);
		instr22.gameObject.SetActive (false);
	}
	void onTouchDown()
	{
		tutorial1 ();

	}
	void onTouchUp(){
		tutorial2 ();
	}
	IEnumerator tutorial2W(){
		yield return new WaitForSecondsRealtime (0.5f);
		instr11.gameObject.GetComponent<Logomoving> ().speed = 0;
		kurczak.GetComponent<SpriteRenderer> ().enabled = false;
		kurczak.GetComponent<BoxCollider> ().enabled = false;
		instr2.gameObject.SetActive (true);
		instr22.gameObject.SetActive (true);
	}
}
