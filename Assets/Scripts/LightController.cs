using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour {
	public GameObject wyzej;
	bool x=false;
	Light light2;
	// Use this for initialization
	void Start () {
		light2 = gameObject.GetComponent<Light> ();
		light2.range = 0;
		x = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (x) {
			light2.range = Mathf.Lerp (light2.range, 14, Time.unscaledDeltaTime / 4);

		}
			
	}
	void OnDisable(){
		light2.range = 0;
		x = true;
	}

}
