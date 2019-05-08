using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DolarBehavior : MonoBehaviour {
	float x,r;

	// Use this for initialization
	void Start () {
		x = Random.Range (-9.0f, 9.0f);
		r = Random.Range (-3.0f, 3.0f);
		transform.position = new Vector3(x,6,0);
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (0, 0, r);
		transform.position+=Vector3.down * Time.deltaTime*5;

		if (Time.timeScale == 0)
			Destroy (gameObject);
	}
}
