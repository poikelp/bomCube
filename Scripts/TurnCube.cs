using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnCube : MonoBehaviour {

	private Rigidbody rigi;
	[SerializeField]
	private float speed = 100000;

	// Use this for initialization
	void Start () {
		rigi = GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 force = Vector3.zero;
		if (Input.GetTouch (0).phase == TouchPhase.Moved) {
			Vector2 delta = Input.GetTouch (0).deltaPosition;
			force = new Vector3 (delta.y, -delta.x, 0); 
		}
		float hori = Input.GetAxis ("Horizontal");
		float vert = Input.GetAxis ("Vertical");
		if (hori != 0 || vert != 0) {
			Debug.Log (hori); 
			force = new Vector3 (vert, -hori, 0);
		}
		force *= Time.deltaTime * speed;
		rigi.AddTorque (force);
	}
}
