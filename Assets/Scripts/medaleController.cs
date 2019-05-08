using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class medaleController : MonoBehaviour {
	public GameObject medal1,medal2,medal3,medal4;
	public GameObject kaktus;
	public Sprite[] medSprite;
	public Sprite[] puchary;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (PlayerPrefs.GetFloat ("Czas") >= 200&&PlayerPrefs.GetFloat ("Czas") < 1000) {
			medal1.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [0];
			if (PlayerPrefs.GetInt ("Braz1", 0) == 0) {
				PlayerPrefs.SetInt ("Braz", PlayerPrefs.GetInt ("Braz", 0) + 1);
				PlayerPrefs.SetInt ("Braz1", 1);
			}
		}
		else if (PlayerPrefs.GetFloat ("Czas") >= 1000&&PlayerPrefs.GetFloat ("Czas") < 5000) {
			
			medal1.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [1];
			if (PlayerPrefs.GetInt ("Sreb1", 0) == 0) {
				PlayerPrefs.SetInt ("Sreb", PlayerPrefs.GetInt ("Sreb", 0) + 1);
				PlayerPrefs.SetInt ("Sreb1", 1);
			}
		}
		else if (PlayerPrefs.GetFloat ("Czas") >= 5000&&PlayerPrefs.GetFloat ("Czas") < 10000) {

			medal1.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [2];
			if (PlayerPrefs.GetInt ("Gold1", 0) == 0) {
				PlayerPrefs.SetInt ("Gold", PlayerPrefs.GetInt ("Gold", 0) + 1);
				PlayerPrefs.SetInt ("Gold1", 1);
			}
			}
		else if (PlayerPrefs.GetFloat ("Czas") >= 10000) {

			medal1.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [3];
			if (PlayerPrefs.GetInt ("Diam1", 0) == 0) {
				PlayerPrefs.SetInt ("Diam", PlayerPrefs.GetInt ("Diam", 0) + 1);
				PlayerPrefs.SetInt ("Diam1", 1);
			}
		}


		if (PlayerPrefs.GetInt ("Kurczak") >= 20 && PlayerPrefs.GetInt ("Kurczak") < 100) {
			medal2.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [4];
			if (PlayerPrefs.GetInt ("Braz2", 0) == 0) {
				PlayerPrefs.SetInt ("Braz", PlayerPrefs.GetInt ("Braz", 0) + 1);
				PlayerPrefs.SetInt ("Braz2", 1);
			}
		}
		else if (PlayerPrefs.GetInt ("Kurczak") >= 100 && PlayerPrefs.GetInt ("Kurczak") < 500) {
			medal2.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [5];
			if (PlayerPrefs.GetInt ("Sreb2", 0) == 0) {
				PlayerPrefs.SetInt ("Sreb", PlayerPrefs.GetInt ("Sreb", 0) + 1);
				PlayerPrefs.SetInt ("Sreb2", 1);
			}
		}
		else if (PlayerPrefs.GetInt ("Kurczak") >= 500 && PlayerPrefs.GetInt ("Kurczak") < 1000) {
			medal2.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [6];
			if (PlayerPrefs.GetInt ("Gold2", 0) == 0) {
				PlayerPrefs.SetInt ("Gold", PlayerPrefs.GetInt ("Gold", 0) + 1);
				PlayerPrefs.SetInt ("Gold2", 1);
			}
		}
		else if (PlayerPrefs.GetInt ("Kurczak") >= 1000) {
			medal2.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [7];
			if (PlayerPrefs.GetInt ("Diam2", 0) == 0) {
				PlayerPrefs.SetInt ("Diam", PlayerPrefs.GetInt ("Diam", 0) + 1);
				PlayerPrefs.SetInt ("Diam2", 1);
			}
		}


		if(PlayerPrefs.GetInt("Pierog") >= 10&&PlayerPrefs.GetInt("Pierog")<50){
			medal3.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [8];
			if (PlayerPrefs.GetInt ("Braz3", 0) == 0) {
				PlayerPrefs.SetInt ("Braz", PlayerPrefs.GetInt ("Braz", 0) + 1);
				PlayerPrefs.SetInt ("Braz3", 1);
			}
		}
		else if(PlayerPrefs.GetInt("Pierog") >= 50&&PlayerPrefs.GetInt("Pierog")<100){
			medal3.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [9];
			if (PlayerPrefs.GetInt ("Sreb3", 0) == 0) {
				PlayerPrefs.SetInt ("Sreb", PlayerPrefs.GetInt ("Sreb", 0) + 1);
				PlayerPrefs.SetInt ("Sreb3", 1);
			}
		}
		else if(PlayerPrefs.GetInt("Pierog") >= 100&&PlayerPrefs.GetInt("Pierog")<200){
			medal3.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [10];
			if (PlayerPrefs.GetInt ("Gold3", 0) == 0) {
				PlayerPrefs.SetInt ("Gold", PlayerPrefs.GetInt ("Gold", 0) + 1);
				PlayerPrefs.SetInt ("Gold3", 1);
			}
		}
		else if(PlayerPrefs.GetInt("Pierog") >= 200){
			medal3.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [11];
			if (PlayerPrefs.GetInt ("Diam3", 0) == 0) {
				PlayerPrefs.SetInt ("Diam", PlayerPrefs.GetInt ("Diam", 0) + 1);
				PlayerPrefs.SetInt ("Diam3", 1);
			}
		}

		if (PlayerPrefs.GetInt ("Smierc") >= 5 && PlayerPrefs.GetInt ("Smierc") < 20) {
			medal4.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [12];
			if (PlayerPrefs.GetInt ("Braz4", 0) == 0) {
				PlayerPrefs.SetInt ("Braz", PlayerPrefs.GetInt ("Braz", 0) + 1);
				PlayerPrefs.SetInt ("Braz4", 1);
			}
		}
		else if (PlayerPrefs.GetInt ("Smierc") >= 20 && PlayerPrefs.GetInt ("Smierc") < 50) {
			medal4.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [13];
			if (PlayerPrefs.GetInt ("Sreb4", 0) == 0) {
				PlayerPrefs.SetInt ("Sreb", PlayerPrefs.GetInt ("Sreb", 0) + 1);
				PlayerPrefs.SetInt ("Sreb4", 1);
			}
		}
		else if (PlayerPrefs.GetInt ("Smierc") >= 50 && PlayerPrefs.GetInt ("Smierc") < 100) {
			medal4.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [14];
			if (PlayerPrefs.GetInt ("Gold4", 0) == 0) {
				PlayerPrefs.SetInt ("Gold", PlayerPrefs.GetInt ("Gold", 0) + 1);
				PlayerPrefs.SetInt ("Gold4", 1);
			}
		}
		else if (PlayerPrefs.GetInt ("Smierc") >= 100) {
			medal4.gameObject.GetComponent<SpriteRenderer> ().sprite = medSprite [15];
			if (PlayerPrefs.GetInt ("Diam4", 0) == 0) {
				PlayerPrefs.SetInt ("Diam", PlayerPrefs.GetInt ("Diam", 0) + 1);
				PlayerPrefs.SetInt ("Diam4", 1);
			}
		}

		if (PlayerPrefs.GetInt ("Diam") == 4) {
			kaktus.gameObject.GetComponent<SpriteRenderer> ().sprite = puchary [3];
		} else if (PlayerPrefs.GetInt ("Gold") == 4) {
			kaktus.gameObject.GetComponent<SpriteRenderer> ().sprite = puchary [2];
		} else if (PlayerPrefs.GetInt ("Sreb") == 4) {
			kaktus.gameObject.GetComponent<SpriteRenderer> ().sprite = puchary [1];
		} else if (PlayerPrefs.GetInt ("Braz") == 4) {
			kaktus.gameObject.GetComponent<SpriteRenderer> ().sprite = puchary [0];

		} else {

		}
	}
}
