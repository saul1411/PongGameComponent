using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class OnMouseClick : MonoBehaviour {
	private AssetBundle myLoadedAssetBundle;
	private string[] scenePaths;
	private PaddleControl paddleControl;

	void Awake(){
		paddleControl = gameObject.GetComponent<PaddleControl> ();
	}
	void start(){
		myLoadedAssetBundle = AssetBundle.LoadFromFile("Assets/AssetBundles/scenes");
		scenePaths = myLoadedAssetBundle.GetAllScenePaths();
	}
	void update(){
		
	}
	void OnMouseDown(){
		FindObjectOfType<PaddleControl>().paddleSpeed = 50;
		float startTime = Time.time;
		Debug.Log ("Mouse click detected on Sword Sprite at time: "+ Time.time);
		//SceneManager.LoadScene ("PongScreen2");
	}
}
