using UnityEngine;
using UnityEngine.UI; //we added UI element of text in the scene, we 'import' it into
// code to program the UI text on the scene
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text; // Blue 'Text' element is coz of import UI function
	// Use this for initialization
	void Start () {
		text.text = "Hello World";
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown(KeyCode.Space)) {
				text.text = "Space Key Pressed";
		}
	}
}
