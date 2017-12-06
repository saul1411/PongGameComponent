using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideEnemyPaddles : MonoBehaviour {
	public float boostDuration = 10;

	void OnMouseDown()
	{ 
		FindObjectOfType<Enemy> ().GetComponent<SpriteRenderer> ().enabled = false; 
		FindObjectOfType<Enemy> ().enabled = false;
		FindObjectOfType<Enemy1> ().GetComponent<SpriteRenderer> ().enabled = false; 
		FindObjectOfType<Enemy1> ().enabled = false;
		FindObjectOfType<Enemy2> ().GetComponent<SpriteRenderer> ().enabled = false; 
		FindObjectOfType<Enemy2> ().enabled = false;
		Debug.Log ("Enemy paddles removed");
		StartCoroutine (ReturnEnemyPaddles ());
	}

	IEnumerator ReturnEnemyPaddles()
	{
		yield return new WaitForSeconds(boostDuration);
		FindObjectOfType<Enemy> ().GetComponent<SpriteRenderer> ().enabled = true; 
		FindObjectOfType<Enemy> ().enabled = true;
		FindObjectOfType<Enemy1> ().GetComponent<SpriteRenderer> ().enabled = true; 
		FindObjectOfType<Enemy1> ().enabled = true;
		FindObjectOfType<Enemy2> ().GetComponent<SpriteRenderer> ().enabled = true; 
		FindObjectOfType<Enemy2> ().enabled = true;
		Debug.Log ("Enemy paddles returned.");
	}

}
