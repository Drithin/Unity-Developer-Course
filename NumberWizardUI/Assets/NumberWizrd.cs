using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizrd : MonoBehaviour {

	int max; //wide scope
	int min; // available to instance
	int guess; 
	public int maxGuessesAllowed=3; // making this instantaneous variable public,
	// we see 'maxGuessesAllowed' option on the game object named NumberWizard which 
	// got a script component added NumberWizard.cs

	public Text foo;


	// Use this for initialization
	void Start () {
		StartGame ();
	}

	void StartGame(){

		print ("===============================================");

		max = 1000; //wide scope
		min = 1; // available to instance
		GuessNext(); //need not say "int max" after declaring above
		//it re-declares vars and create new set of vars of same names






	}

	public void GuessHigher(){
		min = guess; //If guess is above 500, we move min to that level
		GuessNext();
	}

	public void GuessLower (){
		max = guess; //If guess is below 500, we move max to that level
		GuessNext();
	}

	void GuessNext(){
		guess = Random.Range(min, max+1);
		foo.text = guess.ToString();
		maxGuessesAllowed = maxGuessesAllowed - 1;
		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel ("Win");
		}

	}
}
