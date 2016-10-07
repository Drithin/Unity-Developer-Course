using UnityEngine;
using System.Collections;

public class NumberWizrd : MonoBehaviour {

	int max; //wide scope
	int min; // available to instance
	int guess; 


	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame(){

		print ("===============================================");

		max = 1000; //wide scope
		min = 1; // available to instance
		guess = 500; //need not say "int max" after declaring above
		//it re-declares vars and create new set of vars of same names



		print ("Welcome to Number Wizard");
		print ("Think of a number between 1 and 500 in your head");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print (" Is the number above or below 500");
		print (" Press Up Arrow for above, Down Arrow for below 500");



	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			min = guess; //If guess is above 500, we move min to that level
			GuessNext();
		} else if (Input.GetKeyDown (KeyCode.DownArrow)) {
			max = guess; //If guess is below 500, we move max to that level
			GuessNext();
		} else if (Input.GetKeyDown (KeyCode.Return)) {
			print ("You Won!!!");
			StartGame ();
		}

	}

	void GuessNext(){
		guess = (min + max) / 2;
		print ("Is number above or below " + guess);
	}
}
