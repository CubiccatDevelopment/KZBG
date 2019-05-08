using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DymekController : MonoBehaviour {
	int Tekst;
	public GameObject child;
//	public GameObject gonciu;
	public GameObject ReklamaGener;
	Text tresc;
	// Use this for initialization
	void Start () {
		Tekst = Random.Range (1, 11);
		tresc = child.gameObject.GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Tekst == 8 && gameObject.activeSelf == true) {
			ReklamaGener.gameObject.SetActive (true);
		}
		if (Tekst == 1) {
			tresc.text = "Dziaba dziaba dziaba!";
		} else if (Tekst == 2) {
			tresc.text = "Bumcfksz!";
		} else if (Tekst == 3) {
			tresc.text = "Brykiety, brykiety.";
		} else if (Tekst == 4) {
			tresc.text = "BO MOGE!";
		} else if (Tekst == 5) {
			tresc.text = "Eszelegeszelekk!";
		} else if (Tekst == 6) {
			tresc.text = "Poka bydlaka smierdziela!";
		} else if (Tekst == 7) {
			tresc.text = "Fraszki beczki";
		} else if (Tekst == 8) {
			tresc.text = "Chamska reklama!!!";
		} else if (Tekst == 9) {
			tresc.text = "Lubisz maslo?";
		} else if (Tekst == 10) {
			tresc.text = "Co zrobisz? Nic nie zrobisz.";
		} else if (Tekst == 11) {
			tresc.text = "DO SPOWIEDZI!";
		}
	}
	void OnDisable(){
		tresc.text = "";
		Tekst = Random.Range (1, 11);
	}
}
