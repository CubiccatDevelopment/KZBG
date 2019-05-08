using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AchivMenuAnimation : MonoBehaviour {

	public GameObject[] Achivments;
	Image widocznosc;
	Text wynik;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < Achivments.Length; i++) {
			
			if (i == 0) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetInt("Pierwszy",0)+"/1";
				if (PlayerPrefs.GetInt ("Pierwszy") == 1) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 1) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetFloat("Czas",0)+"/200";
				if (PlayerPrefs.GetFloat ("Czas") >=200) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 2) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetFloat("Czas",0)+"/1000";
				if (PlayerPrefs.GetFloat ("Czas") >= 1000) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 3) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetFloat("Czas",0)+"/5000";
				if (PlayerPrefs.GetFloat ("Czas") >= 5000) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 4) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetFloat("Czas",0)+"/10000";
				if (PlayerPrefs.GetFloat("Czas") >= 10000) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 5) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetInt("Kurczak",0)+"/20";
				if (PlayerPrefs.GetInt ("Kurczak") >= 20) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 6) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetInt("Kurczak",0)+"/100";
				if (PlayerPrefs.GetInt ("Kurczak") >= 100) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 7) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetInt("Kurczak",0)+"/500";
				if (PlayerPrefs.GetInt ("Kurczak") >= 500) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 8) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetInt("Kurczak",0)+"/1000";
				if (PlayerPrefs.GetInt ("Kurczak") >= 1000) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 9) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetInt("Pierog",0)+"/10";
				if (PlayerPrefs.GetInt ("Pierog") >= 10) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 10) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text =  PlayerPrefs.GetInt("Pierog",0)+"/50";
				if (PlayerPrefs.GetInt ("Pierog") >= 50) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 11) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text =  PlayerPrefs.GetInt("Pierog",0)+"/100";
				if (PlayerPrefs.GetInt ("Pierog") >= 100) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 12) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text =  PlayerPrefs.GetInt("Pierog",0)+"/200";
				if (PlayerPrefs.GetInt ("Pierog") >= 200) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 13) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetInt("Smierc",0)+"/5";
				if (PlayerPrefs.GetInt ("Smierc") >= 5) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 14) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetInt("Smierc",0)+"/20";
				if (PlayerPrefs.GetInt ("Smierc") >= 20) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 15) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetInt("Smierc",0)+"/50";
				if (PlayerPrefs.GetInt ("Smierc") >= 50) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}
			else if (i == 16) {
				Achivments [i].transform.GetChild (2).gameObject.GetComponent<Text> ().text = PlayerPrefs.GetInt("Smierc",0)+"/100";
				if (PlayerPrefs.GetInt ("Smierc") >= 100) {
					widocznosc = Achivments [i].gameObject.GetComponent<Image> ();
					widocznosc.color = Color.white;
				}
			}

		}
	}
}
