using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreezeEnemyPaddles : MonoBehaviour {
	public float boostDuration = 10;

	// Use this for initialization
	void OnMouseDown()
	{ 
		FindObjectOfType<Enemy> ().speed = 0;
		FindObjectOfType<Enemy1> ().speed = 0;
		FindObjectOfType<Enemy2> ().speed = 0;

		Debug.Log ("Enemy paddles frozen");
		StartCoroutine(ResetEnemyPaddleSpeed());

	}



	IEnumerator ResetEnemyPaddleSpeed()
	{
		// wait some seconds
		yield return new WaitForSeconds(boostDuration);
		// return to normal speed
		FindObjectOfType<Enemy> ().speed = 8;
		FindObjectOfType<Enemy1> ().speed = 8;
		FindObjectOfType<Enemy2> ().speed = 8;
		Debug.Log("Enemy paddles unfrozen"); 
	}
}
