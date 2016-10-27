using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		// here gameObject mentioned in brackets refer to
		// Music Player Game Object created in the Start Scene
		GameObject.DontDestroyOnLoad (gameObject);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
