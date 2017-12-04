using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speed = 6;
	public float boostDuration = 10;
 

	Vector2 targetPos;
	GameObject ballobj;

	void Start () {
		ballobj = GameObject.FindGameObjectWithTag ("Ball");
 
	}
	

	void Update () {
		if (ballobj.transform.position.y > -200 && ballobj.transform.position.y < 580 && ballobj.transform.position.x < 1600 && ballobj.transform.position.x > 0) {
			targetPos = Vector2.Lerp (gameObject.transform.position, ballobj.transform.position, Time.deltaTime * speed);
			gameObject.transform.position = new Vector2 (1600, targetPos.y);
		}

		if (Input.GetKeyDown (KeyCode.A)) // freeze paddle
		{
			speed = 0;
			Debug.Log ("Enemy paddle frozen");
			StartCoroutine(ResetEnemyPaddleSpeed());
		}

		if (Input.GetKeyDown (KeyCode.K)) {
			GetComponent<SpriteRenderer> ().enabled = false; 
			GetComponent<Collider2D>().enabled = false;
			Debug.Log ("Enemy paddles removed");
			StartCoroutine (ReturnEnemyPaddles ());
		}
	}

	IEnumerator ResetEnemyPaddleSpeed()
	{
		// wait some seconds
		yield return new WaitForSeconds(boostDuration);
		// return to normal speed
		speed = 6;
		Debug.Log("Enemy paddle unfrozen"); 
	}

	IEnumerator ReturnEnemyPaddles()
	{
		yield return new WaitForSeconds(boostDuration);
		GetComponent<SpriteRenderer> ().enabled = true; 
		GetComponent<Collider2D>().enabled = true;
		Debug.Log ("Enemy paddles returned.");
	}
}
