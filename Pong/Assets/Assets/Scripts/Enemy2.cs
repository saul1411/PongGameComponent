using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour {

	public float speed = 6;

	Vector2 targetPos;
	GameObject ballobj;

	void Start () {
		ballobj = GameObject.FindGameObjectWithTag ("Ball");
	}
	

	void Update () {
		if (ballobj.transform.position.y > 570 && ballobj.transform.position.x < 1600 && ballobj.transform.position.x > 0) {
			targetPos = Vector2.Lerp (gameObject.transform.position, ballobj.transform.position, Time.deltaTime * speed);
			gameObject.transform.position = new Vector2 (1600, targetPos.y);
		}
	}
}
