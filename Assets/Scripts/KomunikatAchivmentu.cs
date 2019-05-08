using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class KomunikatAchivmentu : MonoBehaviour {

	float t;
	public Sprite[] medale;
	Image medal, medal2;
	Text napis;
	Animator anim;
	AudioSource audio5;
	GameObject chilld;
	void Start () {
		chilld = transform.GetChild (0).gameObject;
		audio5 = transform.GetChild(0).gameObject.GetComponent<AudioSource> ();
		anim = transform.GetChild(0).GetComponent<Animator> ();
		medal = transform.GetChild(0).GetChild (1).gameObject.GetComponent<Image> ();
		medal2 = transform.GetChild(0).GetChild (2).gameObject.GetComponent<Image> ();
		napis = transform.GetChild(0).GetChild (3).gameObject.GetComponent<Text> ();
		chilld.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if (PlayerPrefs.GetInt ("Pierwszy") == 1&&PlayerPrefs.GetInt("Pierwszy1")==0&&chilld.activeSelf==false) {
			medal.sprite = medale [0];
			medal2.sprite = medale [0];
			napis.text = "Pierwszy!";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Pierwszy1",1);
		}
		if (PlayerPrefs.GetFloat ("Czas") >=200&&PlayerPrefs.GetInt("Czas1",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [1];
			medal2.sprite = medale [1];
			napis.text = "Uzalezniony od beczki";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Czas1",1);
		}
		if (PlayerPrefs.GetFloat ("Czas") >=1000&&PlayerPrefs.GetInt("Czas2",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [2];
			medal2.sprite = medale [2];
			napis.text = "Zycie dla Krzysztofa";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Czas2",1);
		}
		if (PlayerPrefs.GetFloat ("Czas") >= 5000&&PlayerPrefs.GetInt("Czas3",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [3];
			medal2.sprite = medale [3];
			napis.text = "Czas to dolary";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Czas3",1);
		}
		if (PlayerPrefs.GetFloat ("Czas") >=10000&&PlayerPrefs.GetInt("Czas4",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [4];
			medal2.sprite = medale [4];
			napis.text = "Czas beczkownikow";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Czas4",1);
		}
		if (PlayerPrefs.GetInt ("Kurczak") == 20&&PlayerPrefs.GetInt("Kurczak1",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [5];
			medal2.sprite = medale [5];
			napis.text = "Pan kurczak sie sprzedal";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Kurczak1",1);
		}
		if (PlayerPrefs.GetInt ("Kurczak") == 100&&PlayerPrefs.GetInt("Kurczak2",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [6];
			medal2.sprite = medale [6];
			napis.text = "Wszystko dla pana kurczaka";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Kurczak2",1);
		}
		if (PlayerPrefs.GetInt ("Kurczak") == 500&&PlayerPrefs.GetInt("Kurczak3",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [7];
			medal2.sprite = medale [7];
			napis.text = "Pan kurczak challenge";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Kurczak3",1);
		}
		if (PlayerPrefs.GetInt ("Kurczak") == 1000&&PlayerPrefs.GetInt("Kurczak4",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [8];
			medal2.sprite = medale [8];
			napis.text = "Tu wstaw dzwiek pana kurczaka";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Kurczak4",1);
		}
		if (PlayerPrefs.GetInt ("Pierog") == 10&&PlayerPrefs.GetInt("Pierog1",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [9];
			medal2.sprite = medale [9];
			napis.text = "Znalezione nie kradzione";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Pierog1",1);
		}
		if (PlayerPrefs.GetInt ("Pierog") == 50&&PlayerPrefs.GetInt("Pierog2",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [10];
			medal2.sprite = medale [10];
			napis.text = "Obiadu nie bedzie";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Pierog2",1);
		}
		if (PlayerPrefs.GetInt ("Pierog") == 100&&PlayerPrefs.GetInt("Pierog3",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [11];
			medal2.sprite = medale [11];
			napis.text = "buleczki, pomaranczki, pierozki";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Pierog3",1);
		}
		if (PlayerPrefs.GetInt ("Pierog") == 200&&PlayerPrefs.GetInt("Pierog4",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [12];
			medal2.sprite = medale [12];
			napis.text = "buleczki, pomaranczki, pierozki";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Pierog4",1);
		}
		if (PlayerPrefs.GetInt ("Smierc") == 5&&PlayerPrefs.GetInt("Smierc1",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [13];
			medal2.sprite = medale [13];
			napis.text = "Zycie za lajki";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Smierc1",1);
		}
		if (PlayerPrefs.GetInt ("Smierc") == 20&&PlayerPrefs.GetInt("Smierc2",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [14];
			medal2.sprite = medale [14];
			napis.text = "UKULELE SMIERCI";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Smierc2",1);
		}
		if (PlayerPrefs.GetInt ("Smierc") == 50&&PlayerPrefs.GetInt("Smierc3",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [15];
			medal2.sprite = medale [15];
			napis.text = "Smierc, podatki, niesmieszny krzysztof";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Smierc3",1);
		}
		if (PlayerPrefs.GetInt ("Smierc") == 100&&PlayerPrefs.GetInt("Smierc4",0)==0&&chilld.activeSelf==false) {
			medal.sprite = medale [16];
			medal2.sprite = medale [16];
			napis.text = "Gonciu sie skonczyl";
			chilld.SetActive (true);
			StartCoroutine (stopAnim ());
			audio5.enabled = true;
			PlayerPrefs.SetInt ("Smierc4",1);
		}
			
	}

	IEnumerator stopAnim(){
		yield return new WaitForSecondsRealtime (4);
		chilld.SetActive (false);
		audio5.enabled = false;
	}
}
