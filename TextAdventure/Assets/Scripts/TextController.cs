using UnityEngine;
using UnityEngine.UI; //we added UI element of text in the scene, we 'import' it into
// code to program the UI text on the scene
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text; // Blue 'Text' element is coz of import UI function
	// Use this for initialization

	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, freedom

	};
	private States myState;// we can store any state in mystate 

	void Start () {
		myState = States.cell;
	
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {
			state_cell ();
		} else if (myState == States.sheets_0) {
			state_sheets_0 ();
		}
		else if (myState == States.sheets_1) {
			state_sheets_1 ();
		}
		else if (myState == States.lock_0) {
			state_lock_0 ();
		}
		else if (myState == States.lock_1) {
			state_lock_1 ();
		}
		else if (myState == States.mirror) {
			state_mirror ();
		}
		else if (myState == States.cell_mirror) {
			state_cell_mirror();
		}
		else if (myState == States.freedom) {
			state_freedom ();
		}

	}

	void state_cell(){
		
		text.text = "You're in a prison cell and you want to escape. " +
				"There are some dirty sheets on bed, a mirron on the wall " +
				"and the door is locked from outside. \n \n" +
				" Press S to view Sheets, M to view Mirror and L to view Lock";
		if (Input.GetKeyDown(KeyCode.S)) {
			myState = States.sheets_0;
	}
}
	void state_sheets_0(){

		text.text = "You can't believe you sleep in these things. Surely it's " +
			" time somebody changed them. The pleasure of prison life " +
			"I guess!. \n \n" +
			" Press R to return to roaming in your cell ";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
   }

	void state_sheets_1(){
		text.text = "Holding a mirror in your hand doesn't make you look" +
		"any better.\n\n+" +
		"Press R to return to your roaming cell";

		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}


	void state_lock_0(){
		text.text = "This is one of those button locks. You have no idea what the+" +
		"combination is. You wishyou could somehow see where the dirty " +
		"finger prints were, may be it would help \n\n +" +
		"Press R ro return to your roaming cell";

		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}

	}

	void state_lock_1(){
		"You carefully put the mirror through the bars, and turn it round " +
		"so you can see the lock. You can just make out fingerprints around " +
		"the buttons You press the dirty buttons, and hear a click \n\n" +
		"Press O to Open or R to Return to your cell";

		if (Input.GetKeyDown(KeyCode.O))       {myState = States.freedom;
		}
		else if (Input.GetKeyDown(KeyCode.R))  {myState = States.cell_mirror;
		}
	}

	void state_mirror(){
		text.text = "The dirty old mirror on the wall seems loose\n\n" +
		"Press T to take the mirror, or R to return the call";

		if (Input.GetKeyDown(KeyCode.T)) {myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
	}


	void state_cell_mirror(){
		text.text = "You are still in your cell, and you STILL want to escape! There are " +
			"some dirty sheets on the bed, a mark where the mirror was, " +
			"and that pesky door is still there, and firmly locked!\n\n" + 
			"Press S to view Sheets, or L to view Lock" ;

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_1;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_1;
		}
	}

	void state_freedom(){
		text.text = "You're FREE!\n\n" + "Press P to Play Again";

		if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.cell ();
		}
	}
}