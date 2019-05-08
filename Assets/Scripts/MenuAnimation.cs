using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuAnimation : MonoBehaviour {
	public Toggle tutor;
	Animator anim, achivAnim, komunikatAnim,logoAnim;
	public GameObject panel,komunikat,logo;
	public GameObject ButtonObj;
	public GameObject GameCtr;
	public GameObject Gonciu, Mieciu;
	public GameObject Gon1,Gon2,Miec1,Miec2;
	public GameObject AchivPanel,menuKurczakowe,exitMenu;
	GameObject[] Instruction;
	public GameObject InstructionStart, InstructionStart2, instructionKurczak;
	ButtonController bc;
	GameController gc;

	// Use this for initialization
	void Start () {
		Instruction = GameObject.FindGameObjectsWithTag ("Instruction");

		foreach (GameObject inst in Instruction) {
			inst.gameObject.SetActive (false);
		}

		anim = panel.GetComponent<Animator> ();
		achivAnim = AchivPanel.GetComponent<Animator> ();
		komunikatAnim = komunikat.GetComponent <Animator> ();
		logoAnim = logo.GetComponent<Animator> ();
		anim.enabled = false;
		achivAnim.enabled = false;
		komunikatAnim.enabled = false;
		bc = ButtonObj.gameObject.GetComponent<ButtonController> ();
		gc = GameCtr.gameObject.GetComponent<GameController> ();
		if (PlayerPrefs.GetInt ("Komunikat", 0) == 0) {
			StartCoroutine (Komunikat());
		}
	}
	void Update(){
		Debug.Log("TUTORIAL: "+PlayerPrefs.GetInt("Tutorial"));
		if (PlayerPrefs.GetInt ("Tutorial") == 1) {
			tutor.interactable = true;
			tutor.isOn = false;
			PlayerPrefs.SetInt ("Tutorial", 1);
		}
		if (PlayerPrefs.GetInt ("Tutorial") == 0) {
			tutor.interactable = false;
			tutor.isOn = true;
		}
	}

	public void ShowAchivMenu(){
		AchivPanel.SetActive (true);
		achivAnim.enabled = true;
		achivAnim.Play ("AchivmentMenu");
	}
	public void HideAchivMenu(){
		achivAnim.Play ("AchivmentMenuBack");
		StartCoroutine (DisableAchivMenu ());
	}
	public void ShowMenu(){
		anim.enabled = true;
		anim.Play ("InfoSlide");


	}

	public void HidePanel(){
		anim.Play ("SlideOut");

	}
	public void PlayGame(){
		if (PlayerPrefs.GetInt ("Tutorial") == 1) {
			foreach (GameObject inst in Instruction) {
				inst.gameObject.SetActive (false);
			}
			instructionKurczak.gameObject.SetActive (false);
			logoAnim.enabled = true;
			logoAnim.Play ("Hiding");
			bc.Start ();
			gc.Start ();
			Time.timeScale = 1;

		}
		else{
			menuKurczakowe.gameObject.GetComponent<Animator>().Play("Kurczak_z_TablicaBack");
			InstructionStart.gameObject.SetActive (true);
			InstructionStart2.gameObject.SetActive (true);
			instructionKurczak.gameObject.SetActive (true);
			InstructionStart.gameObject.GetComponent<Logomoving> ().speed = 15;
			instructionKurczak.gameObject.GetComponent<BoxCollider> ().enabled = true;
		}
	}
	public void ExitMenu(){
		if(!exitMenu.activeSelf)
			exitMenu.gameObject.SetActive (true);
		else 
			exitMenu.gameObject.SetActive (false);
	}
	public void TutorialDisable(){
		if (PlayerPrefs.GetInt ("Tutorial", 0) == 1) {
			tutor.isOn = true;
			PlayerPrefs.SetInt ("Tutorial", 0);

		} 
	}
	public void PlayGameClear(){
		PlayerPrefs.SetInt ("Tutorial", 1);
		bc.Start ();
		gc.Start ();
		Time.timeScale = 1;
		foreach (GameObject inst in Instruction) {
			inst.gameObject.SetActive (false);
		}

	}
	public void LinkGonciuKanal(){
		Application.OpenURL ("https://www.youtube.com/user/wybuchajacebeczki");
	}
	public void LinkWebShows(){
		Application.OpenURL ("http://naeba.pl/kolekcja/goracy-towar/webshows-oprawa-miekka");
	}
	public void LinkKindOfStudio(){
		Application.OpenURL ("http://KindOfStudio.pl/");
	}
	public void FacebookKindOfStudio(){
		Application.OpenURL ("https://web.facebook.com/KindOfStudio/");
	}
	public void Hear_The_Lock_Link(){
		Application.OpenURL ("https://play.google.com/store/apps/details?id=com.KindOfStudio.HearTheLock");
	}
	IEnumerator DisableAchivMenu(){
		yield return new WaitForSeconds (1);
		AchivPanel.SetActive (false);
	}

	IEnumerator Komunikat(){
		yield return new WaitForSecondsRealtime (3);
		komunikat.SetActive (true);
		komunikatAnim.enabled = true;
		komunikatAnim.Play ("KrzysztofWiadomosc");
	}
	public void KomunikatBack(){
		komunikatAnim.Play ("KrzysztofWiadomoscBack");
	}
	public void NiePokazuj(){
		if (PlayerPrefs.GetInt ("Komunikat") == 0) {
			PlayerPrefs.SetInt ("Komunikat", 1);
		} else {
			PlayerPrefs.SetInt ("Komunikat", 0);
		}
	}
	public void Wylacz(){
		Application.Quit();
	}
	public void Dotuj(){
		Application.OpenURL ("https://www.paypal.com/pl/cgi-bin/webscr?cmd=_flow&SESSION=XOVpXZp4F-jc_StkocAtK6GXMINamh3BuGPkcMaaupCPmSi0h5Pwyp6qwW0&dispatch=5885d80a13c0db1f8e263663d3faee8d83a0bf7db316a7beb1b14b43acd04037&rapidsState=Donation__DonationFlow___StateDonationLogin&rapidsStateSignature=959f1724f5144b5bfabe0d2fa5678adad552ccb1");
	}
	public void Donate_Click()
	{
		string url = "";

		string business     = "lukasz.kot1282@gmail.com";  // your paypal email
		string description  = "Wspieraj%20inne%20projekty!";            // '%20' represents a space. remember HTML!
		string country      = "PL";                  // AU, US, etc.
		string currency     = "PLN";                 // AUD, USD, etc.

		url += "https://www.paypal.com/cgi-bin/webscr" +
			"?cmd=" + "_donations" +
			"&business=" + business +
			"&lc=" + country +
			"&item_name=" + description +
			"&currency_code=" + currency +
			"&bn=" + "PP%2dDonationsBF";

		Application.OpenURL (url);
	}
	public void CharacterChoosing(){
		if (PlayerPrefs.GetInt ("MIECIU") == 0) {
		//	StartCoroutine ("logoChanging");
			PlayerPrefs.SetInt ("MIECIU", 1);
			Mieciu.gameObject.SetActive (true);
			Gonciu.gameObject.SetActive (false);
			Gon1.gameObject.SetActive (false);
			Gon2.gameObject.SetActive (false);
			Miec1.gameObject.SetActive (false);
			Miec2.gameObject.SetActive (false);
		} else {
		//	StartCoroutine ("logoChanging");
			PlayerPrefs.SetInt ("MIECIU", 0);
			Mieciu.gameObject.SetActive (false);
			Gonciu.gameObject.SetActive (true);

			Gon1.gameObject.SetActive (false);
			Gon2.gameObject.SetActive (false);
			Miec1.gameObject.SetActive (false);
			Miec2.gameObject.SetActive (false);
		}
	}
	IEnumerator logoChanging(){
		logoAnim.enabled = true;
		logoAnim.Play ("Hiding");
		yield return new WaitForSecondsRealtime (1);
		logo.gameObject.SetActive (false);
		logo.gameObject.SetActive (true);
		yield return new WaitForSecondsRealtime (1);
		logoAnim.enabled = false;

	}
}
