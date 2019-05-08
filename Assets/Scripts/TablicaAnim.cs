using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablicaAnim : MonoBehaviour {
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		gameObject.SetActive (false);
	}

		
	// Update is called once per frame
	public void HideTablica(){
		if(gameObject.activeSelf==true)
		anim.Play ("TablicaPunktyBack");

	}
}
