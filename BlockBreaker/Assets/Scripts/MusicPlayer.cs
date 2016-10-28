using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	static  MusicPlayer instance = null; // initiated a static variable instance to null

	void Awake(){
		

		if (instance != null) { // if there isnt a music player instance, then
			Destroy (gameObject); // Destroy the game object
			print ("Game object self destructing");
		} else {
			instance = this;
			// here gameObject mentioned in brackets refer to
			// Music Player Game Object created in the Start Scene
			GameObject.DontDestroyOnLoad (gameObject);

			// instance = this; runs on START of the game and 'DontDestroyOnLoad'
			//as we run the game
		}

	}

	// Use this for initialization
	//void Start () {


		// Here we moved if clause to Awake method, we check console to realize
		// that instance doesn't reach Start() method and game object gets destructed

	//We comment Start() method and moved the if logic to Awake method to avoid
	//delay in music playing between Awake() and Start() method



	//}
	
	// Update is called once per frame
	void Update () {
	
	}
}
