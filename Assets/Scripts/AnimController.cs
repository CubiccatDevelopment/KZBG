using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimController : MonoBehaviour {

	Animator anim;
	Logomoving logo;
	public GameObject kurczakzTablica;
	public GameObject instrukcja;
	public Sprite Mieciu,Gonciu;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
		anim.enabled = false;
		logo = GetComponent<Logomoving> ();
		StartCoroutine (StartAnim ());
		if (PlayerPrefs.GetInt ("MIECIU", 0) == 1) {
			gameObject.GetComponent<Image> ().sprite = Mieciu;
		} else {
			gameObject.GetComponent<Image> ().sprite = Gonciu;
		}
	}
	void Update(){
		if (instrukcja.gameObject.activeSelf==true) {
			anim.enabled = true;
			anim.Play ("Hiding");
		}
		if (Time.timeScale == 0) {
		//	anim.Play ("TytulSlide");
		}
		if (PlayerPrefs.GetInt ("MIECIU", 0) == 1) {
			gameObject.GetComponent<Image> ().sprite = Mieciu;
		} else {
			gameObject.GetComponent<Image> ().sprite = Gonciu;
		}
	}

	public static class CoroutineUtil
	{
		public static IEnumerator WaitForRealSeconds(float time)
		{
			float start = Time.realtimeSinceStartup;
			while (Time.realtimeSinceStartup < start + time)
			{
				yield return null;
			}
		}
	}

	IEnumerator StartAnim(){
		yield return StartCoroutine (CoroutineUtil.WaitForRealSeconds (1.5f));
		anim.enabled = true;
		yield return StartCoroutine (CoroutineUtil.WaitForRealSeconds (1));
		anim.enabled = false;
		kurczakzTablica.SetActive(true);
		yield return StartCoroutine (CoroutineUtil.WaitForRealSeconds (1));
		logo.enabled = true;
	}
	void onAwake(){
		
	}
}
