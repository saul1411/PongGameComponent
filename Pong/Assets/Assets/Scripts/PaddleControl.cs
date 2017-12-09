using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleControl : MonoBehaviour {

	public float paddleSpeed = 2;
	public float boostDuration = 10;

	public Vector2 playerPos;

	void Update () {
		float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical")*paddleSpeed);
		playerPos = new Vector2 (-1600, Mathf.Clamp(yPos, -20, 400));
		gameObject.transform.position = playerPos; 


		if (Input.GetKeyDown (KeyCode.Space)) // paddle speed-up
		{
			Debug.Log("paddle speed boost enabled"); 
			paddleSpeed = paddleSpeed * 8;
			yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical")*paddleSpeed);
			playerPos = new Vector2 (-1600, Mathf.Clamp(yPos, -20, 400));
			gameObject.transform.position = playerPos;

			StartCoroutine(ResetPaddleSpeed());
		}

		if (Input.GetKeyDown (KeyCode.X)) 
		{
			GetComponent<SpriteRenderer> ().enabled = false; 
			GetComponent<Collider2D>().enabled = false; 
			StartCoroutine (NormalizePaddleSize());
		}



	}

	IEnumerator ResetPaddleSpeed()
	{
		// wait some seconds
		yield return new WaitForSeconds(boostDuration);
		// return to normal speed
		paddleSpeed = paddleSpeed / 8;
		Debug.Log("boost ended"); 
	}

	IEnumerator NormalizePaddleSize()
	{
		yield return new WaitForSeconds(boostDuration);
		GetComponent<SpriteRenderer> ().enabled = true; 
		GetComponent<Collider2D>().enabled = true; 
	}
}
