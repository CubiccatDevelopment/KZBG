using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AchivGraphicScript : MonoBehaviour {

	Image parent;
	Image child;

	// Use this for initialization
	void Start () {
		parent = gameObject.transform.parent.GetComponent<Image> ();
		child = gameObject.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		child.color = new Color (child.color.r, child.color.g, child.color.b, parent.color.a);
	

		
	}
}
