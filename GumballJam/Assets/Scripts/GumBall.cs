using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GumBall : MonoBehaviour {

	public float maxSpeed = 30;

	public float startspeed = 1;

	private float speed;
	// Use this for initialization
	void Start () {
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.position += transform.right * Time.deltaTime * startspeed;

		if (Input.GetKey (KeyCode.Space)) {

			if (speed < maxSpeed) {
				
				speed++;

			} 

			else {
				
				speed = maxSpeed;
			}

				
		if (speed > 0) {

			speed--;
		}

		transform.position += transform.right * Time.deltaTime * speed;
	}
	
}
}