using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonController : MonoBehaviour {

	bool klik,eventTextOnce=false,AchiveOnlyOnce;
	float pkt=1.0f,time,bonus,bonus2,pitch,volume,temp;
	public int zlapanePierogi;
	public float stamina;
	double punkciki;
	float damege,damageBonus,buffor,timerValue;
	float globalPoints, timeSpeed = 1.0f;
	int FinishScores,ktoryDzwiek;
	public GameObject PointsBonus;
	public GameObject Kasia;
	public GameObject Kasia2;
	public GameObject AngryKasia;

	// KRZYS
	public GameObject Krzys;
	public GameObject GonciuNieSpi;
	public GameObject GonciuPrzyps;
	public GameObject Smierc;

	// MIECIU

	public GameObject Mieciu;
	public GameObject MieciuNieSpi;
	public GameObject MieciuPrzyps;
	public GameObject MieciuSmierc;

	public GameObject DramaticEffect;
	public GameObject Dolany;
	public GameObject EventText;
	public GameObject Dymek_Goncia;
	public GameObject Timer;
	public GameObject TablicaWynikow;
	public GameObject InputObj;
	public AudioClip a1,a2,a3,a4;
	public GameObject endSound;

	InputField wpisywaniePole;

	public Scrollbar EnergyBar;

	public Text LifeBar;
	public Text Points;
	public Text InformacjaOWpisaniu;
	public Text InfPkt,InfCzas;
	public Text RekordOsobistyP,RekordOsobistyC;
	Text timerText;

	Text event_text;
	SpriteRenderer sr;

	public Sprite notPressed;
	public Sprite pressed;

	AudioSource audio1, kurczak;


	public GameObject AudioObject;
	AudioSource muzykaTlo;

	public void Start () {				//START

		damageBonus=0;
		punkciki=0;
		CancelInvoke("StaminaLosing");
		CancelInvoke ("PointsController");
		timerValue = Time.time;
		FinishScores = 0;

		endSound.SetActive (false);

		AchiveOnlyOnce = true;

		InformacjaOWpisaniu.text = "";

		Dolany.gameObject.SetActive (false);
		DramaticEffect.SetActive (false);
		if (PlayerPrefs.GetInt ("MIECIU", 0) == 1) {
			Mieciu.gameObject.SetActive (true);
			Krzys.gameObject.SetActive (false);
			MieciuNieSpi.gameObject.SetActive (true);
		} else {
			Krzys.gameObject.SetActive (true);
			Mieciu.gameObject.SetActive (false);
			MieciuNieSpi.gameObject.SetActive (false);
		}
		MieciuSmierc.gameObject.SetActive (false);
		MieciuPrzyps.gameObject.SetActive (false);

		Smierc.gameObject.SetActive (false);
		GonciuPrzyps.gameObject.SetActive (false);

		GonciuNieSpi.gameObject.SetActive (true);

		AngryKasia.gameObject.SetActive (false);
		EventText.gameObject.SetActive (true);
		Kasia2.SetActive (false);

		eventTextOnce = false;

		StartCoroutine (PointsWait ());

		StartCoroutine (TablicaHiding ());
																			//Pobieranie instrumentów
		muzykaTlo = AudioObject.gameObject.GetComponent<AudioSource> ();
		wpisywaniePole = InputObj.gameObject.GetComponent<InputField> ();
		wpisywaniePole.interactable=true;
		sr = gameObject.GetComponent <SpriteRenderer> ();
		event_text = EventText.gameObject.GetComponent<Text> ();
		timerText = Timer.gameObject.GetComponent<Text> ();
		AudioSource[] audios = GetComponents<AudioSource> ();
		audio1 = audios [0];
		kurczak = audios [1];
		audio1.Stop ();
		kurczak.Stop ();

		audio1.enabled = true;


		globalPoints = 0;
		stamina = 4000.0f;
		klik = false;

	//	functionOnlyOnce = false;
		//if (!functionOnlyOnce) {
			InvokeRepeating ("StaminaLosing", 0.01f, 0.012f);
			InvokeRepeating ("PointsController", 1, 1);
	//	}


		timeSpeed = 1.0f;
		zlapanePierogi = 0;
		muzykaTlo.pitch = 1.0f;

		event_text.text = "Poziom 1";
		temp = 34.0f;						//SKALOWANIE PASKA ŻYCIA NA ODPOWIEDNIĄ ILOŚĆ SPADKÓW
	}




	
	// Update is called once per frame
	void Update () {
		timerText.text = ""+System.Math.Round(Time.time-timerValue,1);
		punkciki = System.Math.Round(((int)globalPoints*3-(Time.time - timerValue)));
		if (punkciki < 0)
			punkciki = 0;
		LifeBar.text = "STAMINA: " + (int)stamina;
		Points.text =""+punkciki;


	//	EnergyBar.size = stamina / 4000.0f;			//SĄ 34 kafelki
		EnergyBar.size = (temp-0.15f)/34.0f;
		for(float x=0;x<35;x++){
			
			if (stamina / 4000.0f <= x / 34&&stamina/4000.0f >(x-1)/34) {
				temp = x;
			}
				}
		if (stamina == 0)
			EnergyBar.size = 0;

		if (Kasia.activeSelf && klik||Kasia2.activeSelf&&klik) {

			audio1.enabled = false;
			endSound.SetActive (true);
			Points.GetComponent<Outline> ().effectColor = Color.black;
			Points.fontSize = 26;
			muzykaTlo.pitch = 1.0f;
			muzykaTlo.volume = 0.6f;
			audio1.Stop ();
			DramaticEffect.SetActive (true);


			if (PlayerPrefs.GetInt ("MIECIU", 0) == 1) {
				GonciuNieSpi.gameObject.SetActive (true);
				Mieciu.SetActive (false);
				MieciuPrzyps.gameObject.SetActive (true);
			} else {
				GonciuNieSpi.gameObject.SetActive (true);
				Krzys.gameObject.SetActive (false);
				GonciuPrzyps.gameObject.SetActive (true);
			}

			AngryKasia.SetActive (true);
			Kasia.SetActive (false);
			Kasia2.SetActive (false);
			PointsBonus.gameObject.SetActive (true);
			TablicaWynikow.gameObject.SetActive (true);
			pkt = 0;
		//	FinishScores = Mathf.RoundToInt(globalPoints*3-(Time.time - timerValue));
			FinishScores = (int)punkciki;
			InfPkt.text = "Punktów: " + FinishScores;
			InfCzas.text = "Czas [s]: " + System.Math.Round(Time.time-timerValue,1);
			if (FinishScores > PlayerPrefs.GetInt ("RekordPkt")) {
				PlayerPrefs.SetInt ("RekordPkt", FinishScores);
				PlayerPrefs.SetFloat ("RekordCzas", Time.time - timerValue);

			}
			RekordOsobistyP.text = "Punków: " + PlayerPrefs.GetInt ("RekordPkt", 0);
			RekordOsobistyC.text = "Czas: " + System.Math.Round(PlayerPrefs.GetFloat ("RekordCzas"),1);
			if (AchiveOnlyOnce) {

				if (PlayerPrefs.GetInt ("Pierwszy") != 1)
					PlayerPrefs.SetInt ("Pierwszy", 1);
				PlayerPrefs.SetInt ("Smierc", PlayerPrefs.GetInt ("Smierc", 0) + 1);
				float xd = (float)System.Math.Round (Time.time - timerValue, 0);
				PlayerPrefs.SetFloat ("Czas", (PlayerPrefs.GetFloat ("Czas", 0) + xd));
				AchiveOnlyOnce = false;
			}
			Time.timeScale = 0;
			CancelInvoke("StaminaLosing");
			CancelInvoke ("PointsController");
		}

		if (PointsBonus.activeSelf) {			//losowanie dźwięku
			audio1.Play ();
		} 
		//if (!Kasia.activeSelf) {
		//	audio.Stop ();
	//	}

		if (zlapanePierogi == 3) {
			Dolany.gameObject.SetActive (true);
			zlapanePierogi = 0;
		}

		if (PointsBonus.activeSelf && klik) {
			//bonus = 4.0f;
			bonus2 = 15.0f;
			if (!Kasia.activeSelf) {
				Points.GetComponent<Outline> ().effectColor = Color.red;
				Points.fontSize = 30;
			} else {
				Points.GetComponent<Outline> ().effectColor = Color.black;
				Points.fontSize = 26;
			}
		} else {
			bonus = 1.0f;
			bonus2 = 1.0f;
			Points.GetComponent<Outline> ().effectColor = Color.black;
			Points.fontSize = 26;
		}


		if (klik) {
			damege = 0;
			damageBonus = 0;
			time += Time.deltaTime;
			pkt =4 * bonus;

			if (!PointsBonus.activeSelf) {
				bonus2 = 5.0f;
				Points.GetComponent<Outline> ().effectColor = new Color32 (255, 153, 0, 255);
				Points.fontSize = 28;
			}

			if (stamina < 4000.0f) {
				stamina = stamina + pkt;
			}

		} 

		if (stamina > 4000.0f) {
			stamina = 4000.0f;
		}
		if (stamina <= 0) {

			if (PlayerPrefs.GetInt ("MIECIU", 0) == 1) {
				Mieciu.SetActive (false);
				GonciuNieSpi.gameObject.SetActive (true);
				MieciuSmierc.gameObject.SetActive (true);
			} else {
				Krzys.gameObject.SetActive (false);
				GonciuNieSpi.gameObject.SetActive (true);
				Smierc.gameObject.SetActive (true);
			}
				TablicaWynikow.gameObject.SetActive (true);
		//	FinishScores = Mathf.RoundToInt(globalPoints*3-Time.time - timerValue);
			FinishScores = (int)punkciki;
			if (FinishScores < 0)
				FinishScores = 0;
			InfPkt.text = "Punktów: " + FinishScores;
			InfCzas.text = "Czas [s]: " + System.Math.Round(Time.time-timerValue,1);
			if (FinishScores > PlayerPrefs.GetInt ("RekordPkt")) {
				PlayerPrefs.SetInt ("RekordPkt", FinishScores);
				PlayerPrefs.SetFloat ("RekordCzas", Time.time - timerValue);
			}
			RekordOsobistyP.text = "Punkty: " + PlayerPrefs.GetInt ("RekordPkt", 0);
			RekordOsobistyC.text = "Czas: " + System.Math.Round(PlayerPrefs.GetFloat ("RekordCzas"),1);

			if(PlayerPrefs.GetInt("Pierwszy")!=1)
				PlayerPrefs.SetInt ("Pierwszy", 1);
			if (AchiveOnlyOnce) {
				PlayerPrefs.SetInt ("Smierc", PlayerPrefs.GetInt ("Smierc", 0) + 1);
				float xd = (float)System.Math.Round (Time.time - timerValue, 0);
				PlayerPrefs.SetFloat ("Czas", (PlayerPrefs.GetFloat ("Czas", 0) + xd));
				AchiveOnlyOnce = false;
			}

			Time.timeScale = 0;
			audio1.enabled = false;

			CancelInvoke("StaminaLosing");
			CancelInvoke ("PointsController");
		}

		if(Time.timeScale!=0)
		Time.timeScale = timeSpeed;

		if (globalPoints > 350 && globalPoints < 1300) {					//LEVEL 2
			damageBonus=2.8f;
			event_text.text = "Poziom 2 - Szybciej";														
			if (!eventTextOnce)
				startEventText ();
			pkt = pkt * 1.5f;
			muzykaTlo.pitch = 1.1f;
			muzykaTlo.volume = 0.9f;
			timeSpeed = 1.3f;
		} else if (globalPoints > 1300 && globalPoints < 3000) {		//LEVEL 3
			event_text.text = "Poziom 3 - jeszcze szybciej!!!";	
			damageBonus=3.5f;
			if (eventTextOnce) {
				
				startEventText ();
				eventTextOnce = false;
			}
			muzykaTlo.pitch = 1.2f;
			muzykaTlo.volume = 1.2f;
			timeSpeed =	1.9f;
			pkt = pkt * 1.8f;
		} else if (globalPoints > 3000 && globalPoints < 5000) {		//LEVEL 4
			damageBonus=3.5f;
			event_text.text = "Poziom 4 - Bez jaj";														
			if (!eventTextOnce) {
				startEventText ();
				eventTextOnce = true;
			}
			muzykaTlo.pitch = 1.3f;
			muzykaTlo.volume = 1.4f;
			pkt = pkt * 2.3f;
			timeSpeed = 2.5f;
		} else if (globalPoints > 5000 && globalPoints < 6000) {		//BEZ JAJ LEVEL 5
			damageBonus=3.5f;
			event_text.text = "Poziom 5 - Nierealne";														
			if (eventTextOnce) {
				startEventText ();
				eventTextOnce = false;
			}
			muzykaTlo.pitch = 1.4f;
			muzykaTlo.volume = 1.5f;
			pkt = pkt * 2.6f;
			timeSpeed = 3.0f;
		} else if (globalPoints > 6000) {							//ŻODYN LEVEL 6
			event_text.text = "O KUR** - LEVEL 6";	
			damageBonus=3.5f;
			if (!eventTextOnce) {

				startEventText ();
				eventTextOnce = true;
			}
			muzykaTlo.pitch = 1.5f;
			muzykaTlo.volume = 1.6f;
			pkt = pkt * 3.0f;
			timeSpeed = 3.5f;
		}

	}

	void StaminaLosing(){
		if (damege <= 7) {
			stamina = stamina - damege;
		} else {
			stamina = stamina = stamina - damege-damageBonus;
		}
	}


	void PointsController(){
		globalPoints = globalPoints + 1*bonus2;
	}
	void startEventText(){
		EventText.gameObject.SetActive (true);
		eventTextOnce = true;
	}


	void onTouchDown() 
	{
		if (Time.timeScale != 0) {
			sr.sprite = pressed;

			PlayerPrefs.SetInt ("Kurczak", PlayerPrefs.GetInt ("Kurczak", 0) + 1);
		
			kurczak.Play ();
			StopCoroutine( "DymekFunc" );
			Dymek_Goncia.gameObject.SetActive (false);
			StopCoroutine ("PointsWait");
			klik = true;
			pkt = 15.0f;
			if (PlayerPrefs.GetInt ("MIECIU", 0) == 1) {
				Mieciu.gameObject.SetActive (false);
				GonciuNieSpi.gameObject.SetActive (false);
			} else {
				Krzys.gameObject.SetActive (false);
				GonciuNieSpi.gameObject.SetActive (false);
			}
		}
	}
	void onTouchUp(){
		
		if (Time.timeScale != 0) {
			GonciuNieSpi.gameObject.SetActive (true);
			sr.sprite = notPressed;

			StartCoroutine ("PointsWait");
			StartCoroutine ("DymekFunc");
			klik = false;
			pkt = 15.0f;
			time = 0;
			if (PlayerPrefs.GetInt ("MIECIU", 0) == 1) {
				Mieciu.gameObject.SetActive (true);
			} else {
				Krzys.gameObject.SetActive (true);
			}
		}
	}
	void onTouchExit(){
		if (Time.timeScale != 0) {
			GonciuNieSpi.gameObject.SetActive (true);
			sr.sprite = notPressed;

			StartCoroutine ("PointsWait");	
			StartCoroutine ("DymekFunc");
			Dymek_Goncia.gameObject.SetActive (false);
			klik = false;
			pkt = 15.0f;
			time = 0;
			if (PlayerPrefs.GetInt ("MIECIU", 0) == 1) {
				Mieciu.gameObject.SetActive (true);
			} else {
				Krzys.gameObject.SetActive (true);
			}
		}
	}
//	void onTouchStay(){
//		testText.text = "ON TOUCH STAY";
//		if (Time.timeScale != 0) {
//			sr.sprite = pressed;
//
//			kurczak.Play ();
//			Dymek_Goncia.gameObject.SetActive (false);
//			StopCoroutine ("PointsWait");
//			klik = true;
//			pkt = 15.0f;
//			Krzys.gameObject.SetActive (false);
//			GonciuNieSpi.gameObject.SetActive (false);
//		}
//	}

	IEnumerator PointsWait(){
			damege = 0;
			yield return new WaitForSeconds (1);
			damege = 7.0f;

	}
	IEnumerator TablicaHiding(){
		yield return new WaitForSeconds (2);

		TablicaWynikow.gameObject.SetActive (false);
	}
	IEnumerator DymekFunc(){
		
		if(GonciuNieSpi.activeSelf==true){
			ktoryDzwiek = Random.Range (1, 4);
			if (ktoryDzwiek == 1) {
				audio1.clip = a1;
			} else if (ktoryDzwiek== 2) {
				audio1.clip = a2;
			}
			else if (ktoryDzwiek == 3) {
				audio1.clip = a3;
			}
			else {
				audio1.clip = a4;
			}
			yield return new WaitForSeconds (1);
			Dymek_Goncia.gameObject.SetActive (true);
			yield return new WaitForSeconds (2);
			Dymek_Goncia.gameObject.SetActive (false);

		}
	}
	public void wyslijWynik(string nazwa){
		FinishScores = Mathf.RoundToInt(globalPoints*3-Time.time - timerValue);

		wpisywaniePole.interactable=false;
		Highscores.AddNewHighscore (nazwa, FinishScores);
		InformacjaOWpisaniu.text = "Dodano wynik!";

	}

	public void kurczakMute(){
		if (kurczak.volume > 0)
			kurczak.volume = 0;
		else
			kurczak.volume = 1;
	}
	public void muzykawTle(){
		if (!muzykaTlo.mute)
			muzykaTlo.mute = true;
		else
			muzykaTlo.mute = false;
	}
}
