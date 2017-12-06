using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargePaddle : MonoBehaviour {

	public bool clicked = false; 
	public float boostDuration = 10;

	// Use this for initialization
	void OnMouseDown () {
		clicked = true;
		Debug.Log ("Clicked Enlarge Paddle");

		FindObjectOfType<PaddleControl> ().GetComponent<SpriteRenderer> ().enabled = false;
		FindObjectOfType<PaddleControl> ().GetComponent<Collider2D>().enabled = false; 


		FindObjectOfType<LargePaddleControl> ().GetComponent<SpriteRenderer> ().enabled = true; 
		FindObjectOfType<LargePaddleControl> ().GetComponent<Collider2D>().enabled = true;

		StartCoroutine (NormalizePaddleSize());

		Debug.Log ("Paddle enlarged");

	}

	IEnumerator NormalizePaddleSize()
	{
		yield return new WaitForSeconds(boostDuration);
		FindObjectOfType<PaddleControl> ().GetComponent<SpriteRenderer> ().enabled = true; 
		FindObjectOfType<PaddleControl> ().GetComponent<Collider2D>().enabled = true; 

		FindObjectOfType<LargePaddleControl> ().GetComponent<SpriteRenderer> ().enabled = false; 
		FindObjectOfType<LargePaddleControl> ().GetComponent<Collider2D>().enabled = false;
		Debug.Log ("Paddle normal size");
	}


}
