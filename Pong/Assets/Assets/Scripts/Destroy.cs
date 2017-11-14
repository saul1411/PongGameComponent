using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Brick") {
			Debug.Log ("Enter Called");
			Destroy (col.gameObject);
		}
	}
}