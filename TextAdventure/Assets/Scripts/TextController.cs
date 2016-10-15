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
			text.text = "You're in a prison cell and you want to escape. " +
			"There are some dirty sheets on bed, a mirron on the wall " +
			"and the door is locked from outside. \n \n" +
			" Press S to view Sheets, M to view Mirror and L to view Lock";
		}
	}
}
