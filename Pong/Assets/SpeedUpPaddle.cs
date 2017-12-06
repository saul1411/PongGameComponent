using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedUpPaddle : MonoBehaviour {
 
	public float boostDuration = 10;

	void OnMouseDown()
	{ 
		Debug.Log("Clicked speeduppaddle");
		FindObjectOfType<PaddleControl> ().paddleSpeed = 50;

		StartCoroutine(ResetPaddleSpeed());
	}
		
	IEnumerator ResetPaddleSpeed()
	{
		// wait some seconds
		yield return new WaitForSeconds(boostDuration);
		// return to normal speed
		//paddleSpeed = paddleSpeed / 8;
		FindObjectOfType<PaddleControl> ().paddleSpeed = 25;
		Debug.Log("boost ended"); 
	}


}
