using System.Collections;
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
