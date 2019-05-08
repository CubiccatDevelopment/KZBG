using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pierog : MonoBehaviour {
	int x,y;
	Ray ray;
	public RaycastHit hit;
	GameObject BubbleSound;
	public GameObject particleEffect;

	GameObject GamePunkty;
	AudioSource pek;
	private ButtonController bc;

	Vector3 pos;

	void Start () {
		GamePunkty = GameObject.FindGameObjectWithTag ("ButtonController");
		bc = GamePunkty.GetComponent<ButtonController> ();

		x = Random.Range (-100, 100);

		GetComponent<Rigidbody> ().AddForce (new Vector2(x,250));
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0,0,7);
		pos = transform.position;
		//GetComponent<Rigidbody> ().AddForce (new Vector2(x,y));
		if(Time.timeScale==0)
			transform.position = new Vector3 (-4000, -200, 1);
	}

	void onTouchDown(){
		PlayerPrefs.SetInt ("Pierog", PlayerPrefs.GetInt ("Pierog", 0) + 1);
		BubbleSound = GameObject.FindGameObjectWithTag ("BubbleSound");
		pek = BubbleSound.GetComponent<AudioSource> ();
		Instantiate (particleEffect,pos,Quaternion.identity);
		bc.stamina = bc.stamina + 1500.0f;
		bc.zlapanePierogi++;
		transform.position = new Vector3 (-4000, -200, 1);
		pek.Play ();
	}
	void OnCollisionEnter(Collision coll)
	{
		if (coll.gameObject.tag == "Destroy") {
			transform.position = new Vector3 (-4000, -200, 1);
		}
	}
	void OnBecameVisible(){

	}

		
}
