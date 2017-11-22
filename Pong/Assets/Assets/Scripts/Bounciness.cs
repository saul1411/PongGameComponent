using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bounciness : MonoBehaviour {

	public float ballVelocity = 2700;

	Rigidbody2D rb2d;
	bool isPlay;
	int randInt;
	public Text text;
	int healthCounter = 0;
	int destroy = 4;

	void Awake () {
		rb2d = gameObject.GetComponent<Rigidbody2D> ();
		randInt = Random.Range (1, 11);
		text.GetComponent<Text> ();
	}

	void Start(){
	}

	void Update () {
		if(rb2d.transform.position.x < -2000 || rb2d.transform.position.x > 2000){
			isPlay = false;
			rb2d.velocity = new Vector2 (0, 0);
			text.text = "Game Over. Press R to restart.";
			if (Input.GetKey (KeyCode.R)) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
			}
		}
		if (Input.GetMouseButton(0) == true && isPlay == false){
			transform.parent = null;
			isPlay = true;
			rb2d.transform.position = new Vector2 (0, 0);
			rb2d.isKinematic = false;
			if(randInt <= 5){
				rb2d.AddForce(new Vector2(ballVelocity, ballVelocity));
			}
			if(randInt > 5){
				rb2d.AddForce(new Vector2(-ballVelocity, -ballVelocity));
			}

		}
	}
	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "Brick") {
			Debug.Log ("Brick Hit");
			Destroy (col.gameObject);
		}
		if (col.gameObject.tag == "HealthBar") {
			healthCounter += 1;
			Debug.Log ("Health Bar Hit");
			if (healthCounter >= destroy) {
				Debug.Log ("Health Bar Destroyed");	
				Destroy (col.gameObject);
			}
		}
	}
}
