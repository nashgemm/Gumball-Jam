using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumBall : MonoBehaviour {

	public float speed = 1;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += transform.right * Time.deltaTime * speed;

		if (Input.GetKey (KeyCode.Space)) {
			speed++;
		}
	}
}
