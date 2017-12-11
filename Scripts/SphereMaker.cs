using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMaker : MonoBehaviour {
	private GameObject sphere;
	[SerializeField]
	private int spheresMass = 50;
	private int sphereCount = 0;
	[SerializeField]
	private float coolTime = 1.0f;
	private float time; 

	// Use this for initialization
	void Start () {
		sphere = (GameObject)Resources.Load ("Prefab/sphere");
		for (sphereCount = 0; sphereCount < spheresMass; sphereCount++) {
			Instantiate (sphere, transform.position, transform.rotation);
			transform.position = new Vector3 (getRandomfloat (), 0, getRandomfloat ());
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (sphereCount < spheresMass) {
			if (time > coolTime) {
				Instantiate (sphere, transform.position, transform.rotation);
				transform.position = new Vector3 (getRandomfloat() , 0, getRandomfloat() );
				time = 0;
				sphereCount++;

			}
		}
		time += Time.deltaTime;
	}

	float getRandomfloat () {
		return Random.Range (-9.0f, 9.0f);
	}
}
