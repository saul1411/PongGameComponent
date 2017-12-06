<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LargePaddleControl : MonoBehaviour {

	public float paddleSpeed = 4;
	public float boostDuration = 10;

	public Vector2 playerPos;

	void Start()
	{
		GetComponent<SpriteRenderer> ().enabled = false; 
		GetComponent<Collider2D> ().enabled = false;
	}



	void Update () {

		float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical")*paddleSpeed);
		playerPos = new Vector2 (-1600, Mathf.Clamp(yPos, -20, 400));
		gameObject.transform.position = playerPos; 
	}
 

}
=======
﻿using System.Collections; using System.Collections.Generic; using UnityEngine;  public class LargePaddleControl : MonoBehaviour {  	public float paddleSpeed = 8; 	public float boostDuration = 10;  	public Vector2 playerPos;  	void Start() 	{ 		GetComponent<SpriteRenderer> ().enabled = false;  		GetComponent<Collider2D> ().enabled = false; 	}    	void Update () {  		if (Input.GetKeyDown (KeyCode.X)) { 			GetComponent<SpriteRenderer> ().enabled = true;  			GetComponent<Collider2D>().enabled = true; 			Debug.Log ("Paddle enlarged"); 			StartCoroutine (NormalizePaddleSize()); 		}  		float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical")*paddleSpeed); 		playerPos = new Vector2 (-1600, Mathf.Clamp(yPos, -20, 400)); 		gameObject.transform.position = playerPos;    	}  	IEnumerator NormalizePaddleSize() 	{ 		yield return new WaitForSeconds(boostDuration); 		GetComponent<SpriteRenderer> ().enabled = false;  		GetComponent<Collider2D>().enabled = false; 		Debug.Log ("Paddle normal size"); 	}  } 
>>>>>>> 1b52f0d85616a7de8125d4b5aaaa3a3f6771a28b
