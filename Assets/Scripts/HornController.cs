using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HornController : MonoBehaviour {

	AudioSource horn;
	public GameObject MuzykaTlo;
	// Use this for initialization
	void Start () {

		horn = gameObject.GetComponent<AudioSource> ();
		StartCoroutine (StartHorn ());
		
	}
	
	// Update is called once per frame
	void Update () {
		
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

	private IEnumerator StartHorn(){
		yield return StartCoroutine (CoroutineUtil.WaitForRealSeconds (1));
		horn.enabled = true;
		yield return StartCoroutine (CoroutineUtil.WaitForRealSeconds (2));
		MuzykaTlo.SetActive (true);
	}
}
