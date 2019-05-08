using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimKurczakBack : MonoBehaviour {

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeScale>0.5f)
			anim.Play("Kurczak_z_TablicaBack");

	//	if (Time.timeScale == 0)
			//anim.Play ("Kurczak_z_Tablica");
		
	}
	public void MenuShow(){
		if (Time.timeScale == 0)
			anim.Play ("Kurczak_z_Tablica");
	}
}
