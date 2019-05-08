using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptymalizatorScript : MonoBehaviour {

	public GameObject dolarGener;
	GameObject[] dolany;
	public GameObject rekGener;
	GameObject[] ksiunszki;
	GameObject[] pierogi;

	public GameObject kanapa, Zgener;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (kanapa.gameObject.activeSelf == true) {
			Zgener.gameObject.SetActive (false);
		} else if (kanapa.gameObject.activeSelf == false && Zgener.gameObject.activeSelf == false) {
			Zgener.gameObject.SetActive (true);
		}

		if (dolarGener.activeSelf == true)
			StartCoroutine (KillDola ());
		if (rekGener.activeSelf == true)
			StartCoroutine (KillKsiaz ());

		pierogi = GameObject.FindGameObjectsWithTag ("Pierog");
		foreach (GameObject pier in pierogi) {
			if (pier.gameObject.transform.position.x < -2000)
				StartCoroutine (KillPierog ());
		}
	}

	IEnumerator KillDola(){
		dolany = GameObject.FindGameObjectsWithTag ("Dolar");
		yield return new WaitForSeconds (9);
		foreach (GameObject dola in dolany) {
			Destroy (dola);
		}
	}
	IEnumerator KillKsiaz(){
		ksiunszki = GameObject.FindGameObjectsWithTag ("Ksiazka");
		yield return new WaitForSeconds (9);
		foreach (GameObject webShows in ksiunszki) {
			Destroy (webShows);
		}
	}
	IEnumerator KillPierog(){
		yield return new WaitForSeconds (1);
		foreach (GameObject pier in pierogi) {
			if (pier.gameObject.transform.position.x < -2000)
				Destroy (pier);
			}
		
	}
}
