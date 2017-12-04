using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

	//Health Bar Variables
	int healthCounter = 0;
	int maxHealth = 5;
	private SpriteRenderer sr;
	public Sprite sr1;
	public Sprite sr2;
	public Sprite sr3;
	public Sprite sr4;
	public Sprite sr5;

	void Start(){
		sr = GetComponent<SpriteRenderer> ();
		if (sr.sprite == null) {
			sr.sprite = sr1;
			Debug.Log ("Sprite Renderer Called");
		}
	}

	void update(){
		if (gameObject != null) {
			Destroy (gameObject);
		}

	}

	void OnCollisionEnter2D(Collision2D col){
		healthCounter += 1;
		Debug.Log ("Health Bar Hit, health Counter = "+healthCounter);
		if (healthCounter == 1) {
			Debug.Log ("Health Counter == 1");
			sr.sprite = sr2;
		}
		if (healthCounter == 2) {
			Debug.Log ("Health Counter == 2");
			sr.sprite = sr3;
		}
		if (healthCounter == 3) {
			Debug.Log ("Health Counter == 3");
			sr.sprite = sr4;
		}
		if (healthCounter == 4) {
			Debug.Log ("Health Counter == 4");
			sr.sprite = sr5;
		}
		if (healthCounter > 4) {
			sr.sprite = null;
		}
		if (healthCounter >= maxHealth) {
			Debug.Log ("Health Bar Destroyed");	
			Destroy (this.gameObject);
		}
	}
}
