using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PierogGenerator : MonoBehaviour {

	public GameObject Pierog;
	float x;

	// Use this for initialization
	void Start () {
		x= Random.Range (10, 15);
		InvokeRepeating ("GeneratePierog", 7, x);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void GeneratePierog()
	{
		x= Random.Range (10, 15);
		Instantiate (Pierog);

		//Pierog.transform.position = new Vector3 (0, 0, 0);
		//Pierog.GetComponent<Rigidbody> ().AddForce(transform.up*Random.Range(20,100));

	}
		
}
