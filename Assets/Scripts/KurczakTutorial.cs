using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KurczakTutorial : MonoBehaviour {
	SpriteRenderer thisImage;
	// Use this for initialization
	void Start () {
		thisImage = gameObject.GetComponent<SpriteRenderer> ();	
		gameObject.GetComponent<AudioSource> ().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void onTouchDown()
	{
		Debug.Log ("1");
		thisImage.color = new Color (255, 255, 255, 255);
		gameObject.GetComponent<AudioSource> ().enabled = true;
		}
}
