using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddBoms : MonoBehaviour {


	private GameObject bom;

	// Use this for initialization
	void Start () {
		bom = (GameObject)Resources.Load ("Prefab/bom");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0) || Input.GetTouch(0).phase == TouchPhase.Began) {
			transform.position = new Vector3 (getRandomfloat() , 0, getRandomfloat() );
			Instantiate (bom, transform.position, transform.rotation);
		}
	}

	float getRandomfloat () {
		return Random.Range (-9, 9);
	}
}
