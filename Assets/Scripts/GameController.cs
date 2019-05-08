using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {
	float difficultyLevel=0.5f;
	float timeKasiasChecking;
	float pukPukTime;
	float timeCounting = 0f;
	bool isHappening;
	int KasiaAnim;

	public bool buttonPressing;


	public GameObject pukPuk;
	public GameObject alert,alert2;
	public GameObject kasia;
	public GameObject kasia2;
	public GameObject PointsBonus;
	public GameObject PukanieDzwiek;


	public void Start () {
		timeCounting = 0;	
		Time.timeScale = 0;
		buttonPressing = false;
	//	Time.timeScale = 1;
		pukPukTime = (Random.value * 7)+2;
	//	StartCoroutine (KasiasChecking ());
	//	Debug.Log (pukPukTime);


		pukPuk.gameObject.SetActive (false);
		kasia.gameObject.SetActive (false);
		PointsBonus.gameObject.SetActive (false);
		alert.gameObject.SetActive (false);

		StopCoroutine (KasiasChecking ());
	}

	void Update () {
		
		timeCounting += Time.deltaTime;

		if (!isHappening) {
			KasiaAnim = Random.Range (0, 2);		//Wybiera animacje kasi
			StartCoroutine (KasiasChecking ());
		}

		if (timeKasiasChecking - timeCounting < pukPukTime && timeKasiasChecking - timeCounting > (pukPukTime-0.2) ||
			timeKasiasChecking - timeCounting < (pukPukTime-0.3) && timeKasiasChecking - timeCounting > (pukPukTime-0.5)) {
			PukanieDzwiek.gameObject.SetActive (false);
			PukanieDzwiek.gameObject.SetActive (true);
	//		Debug.Log ("PUK TIME: " + pukPukTime);
			pukPuk.gameObject.SetActive (true);
			PointsBonus.gameObject.SetActive (true);

		} else {
			pukPuk.gameObject.SetActive (false);
		}

		buttonPressing = false;
	//	Debug.Log ("Pressing: " + buttonPressing);


	}
		
	IEnumerator KasiasChecking(){

		isHappening = true;														//Couses that, funcion execute only once


		timeKasiasChecking = (Random.value * 9)+7;								//Random Value of Kasias reloading
	//	Debug.Log("GENERAL KASIAS SHOWING TIME: "+timeKasiasChecking);
		yield return new WaitForSeconds (timeKasiasChecking);
		if(KasiaAnim==1)
			alert2.gameObject.SetActive (true);
		else
			alert.gameObject.SetActive (true);
		yield return new WaitForSeconds (difficultyLevel);
		alert2.gameObject.SetActive (false);
		alert.gameObject.SetActive (false);
		PointsBonus.gameObject.SetActive (false);

		if(KasiaAnim==1)
		kasia2.gameObject.SetActive (true);
		else {
			kasia.gameObject.SetActive (true);
		}																		//OH NO IT'S KASIA

		yield return new WaitForSeconds (3);									//Time, when Kasia is visible

		kasia.gameObject.SetActive (false);										//Uff...That was close
		kasia2.gameObject.SetActive (false);

		pukPukTime = (Random.value * 5) + 2;
		timeCounting = 0;														//Reset time

		isHappening = false;
	}
	public void isPressed(){
		buttonPressing = true;
	}
		
		
}
