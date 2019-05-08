using UnityEngine;
using System.Collections;

public class Logomoving : MonoBehaviour {
	public int speed = 15;
	RectTransform tytul;
	Vector2 startPos;
	// Use this for initialization
	void Start () {
		tytul = gameObject.GetComponent<RectTransform> ();
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	//	tytul.transform.position = new Vector2 (transform.position.x, Mathf.PingPong (Time.unscaledTime*15, 16)+x);
		if (gameObject.tag == "Instruction") {
			tytul.position = new Vector3 (transform.position.x, Mathf.PingPong (Time.unscaledTime * speed, 16.0f)+startPos.y, 1);
		} else {

			tytul.position =new Vector3 (transform.position.x, Mathf.PingPong (Time.unscaledTime*speed,16.0f)+Screen.height/2,1);

		}
	}
	void OnBecameVisible(){
		speed = 15;
	}
}
