using UnityEngine;
using UnityEngine.UI; //we added UI element of text in the scene, we 'import' it into
// code to program the UI text on the scene
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text; // Blue 'Text' element is coz of import UI function
	// Use this for initialization

	private enum States {cell, mirror, sheets_0, lock_0, cell_mirror, sheets_1, lock_1, corridor_0,
		corridor_1, stairs_0, floor, closet_door, stairs_1, in_closet, stairs_2, corridor_2, corridor_3, courtyard

	};
	private States myState;// we can store any state in mystate 

	void Start () {
		myState = States.cell;
	
	}
	
	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {
			cell ();
		} else if (myState == States.sheets_0) {
			sheets_0 ();
		} else if (myState == States.sheets_1) {
			sheets_1 ();
		} else if (myState == States.lock_0) {
			lock_0 ();
		} else if (myState == States.lock_1) {
			lock_1 ();
		} else if (myState == States.mirror) {
			mirror ();
		} else if (myState == States.cell_mirror) {
			cell_mirror ();
		} else if (myState == States.corridor_0) {
			corridor_0 ();
		} else if (myState == States.corridor_0) {
			corridor_0 ();
		} else if (myState == States.stairs_0) {
			stairs_0 ();
		} else if (myState == States.stairs_1) {
			stairs_1 ();
		} else if (myState == States.stairs_2) {
			stairs_2 ();
		} else if (myState == States.courtyard) {
			courtyard ();
		} else if (myState == States.floor) {
			floor ();
		} else if (myState == States.corridor_1) {
			corridor_1 ();
		} else if (myState == States.corridor_2) {
			corridor_2 ();
		} else if (myState == States.corridor_3) {
			corridor_3 ();
		} else if (myState == States.closet_door) {
			closet_door ();
		} else if (myState == States.in_closet) {
			in_closet ();
		}
	}

	void cell(){
		
		text.text = "You're in a prison cell and you want to escape. " +
				"There are some dirty sheets on bed, a mirron on the wall " +
				"and the door is locked from outside. \n \n" +
				" Press S to view Sheets, M to view Mirror and L to view Lock";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets_0;
		} else if (Input.GetKeyDown (KeyCode.M)) {
			myState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.lock_0;
		}
}
	void sheets_0(){

		text.text = "You can't believe you sleep in these things. Surely it's " +
			" time somebody changed them. The pleasure of prison life " +
			"I guess!. \n \n" +
			" Press R to return to roaming in your cell ";
		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}
   }

	void sheets_1(){
		text.text = "Holding a mirror in your hand doesn't make you look" +
		"any better.\n\n+" +
		"Press R to return to your roaming cell";

		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell_mirror;
		}
	}


	void lock_0(){
		text.text = "This is one of those button locks. You have no idea what the+" +
		"combination is. You wishyou could somehow see where the dirty " +
		"finger prints were, may be it would help \n\n +" +
		"Press R ro return to your roaming cell";

		if (Input.GetKeyDown(KeyCode.R)) {
			myState = States.cell;
		}

	}

	void lock_1(){
		text.text = "You carefully put the mirror through the bars, and turn it round " +
		"so you can see the lock. You can just make out fingerprints around " +
		"the buttons You press the dirty buttons, and hear a click \n\n" +
		"Press O to Open or R to Return to your cell";

		if (Input.GetKeyDown(KeyCode.O))       {myState = States.corridor_0;
		}
		else if (Input.GetKeyDown(KeyCode.R))  {myState = States.cell_mirror;
		}
	}

	void mirror(){
		text.text = "The dirty old mirror on the wall seems loose\n\n" +
		"Press T to take the mirror, or R to return the cell";

		if (Input.GetKeyDown(KeyCode.T)) {myState = States.cell_mirror;}
		else if (Input.GetKeyDown(KeyCode.R)) {myState = States.cell_mirror;}
	}


	void cell_mirror(){
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

	void corridor_0(){
		text.text = "You're in a Corridor!\n\n" + "Press S for stairs" +
		" C for closet, Fo to inspect floor and R to return to the corridor";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_0;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.closet_door;
		} else if (Input.GetKeyDown (KeyCode.F)) {
			myState = States.floor;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
	}
}

	void corridor_1(){
		text.text = "Press S to go to stairs, P to pick clothes +" +
		             "from closet";
		if (Input.GetKeyDown (KeyCode.S)) {
			myState = TextController.States.stairs_1;
		} else if (Input.GetKeyDown (KeyCode.P)) {
			myState = States.in_closet;
		}
	}

	void corridor_2(){
		text.text = "Press S to go to stairs and R to return";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = TextController.States.stairs_2;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_2;
		}


	}

	void corridor_3(){
		text.text = "Press S to reach the courtyard and be free";

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = TextController.States.courtyard;
		}
	}

	void closet_door(){
		text.text = "Press R to come back to corridor" +
		" Press C to get in closet door";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = TextController.States.corridor_0;
		} else if (Input.GetKeyDown (KeyCode.C)) {
			myState = States.in_closet;
		}
	}

	void in_closet(){
		text.text = "Press R to go back corridor" +
		" and Press B to be back to the closet "+ "Press D to get " +
		" dressed and go to corridor"+ "Press U to return to closet";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = TextController.States.corridor_2;
		} else if (Input.GetKeyDown (KeyCode.B)) {
			myState = States.in_closet;
		} else if (Input.GetKeyDown (KeyCode.D)) {
			myState = TextController.States.corridor_3;
		} else if (Input.GetKeyDown (KeyCode.U)) {
			myState = States.in_closet;
		}

	}

	void stairs_0(){
		text.text = "Press R to return to stairs" +
		"and S to reach stairs";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = TextController.States.corridor_0;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_0;
		}
	}

	void stairs_1(){
		text.text = " Press S to reach stairs " +
		" and R to return to corridor";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = TextController.States.corridor_1;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_1;
		}
	}

	void stairs_2(){
		text.text = "Press R to return to go to corridor" +
		" and S to get back to stairs";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = TextController.States.corridor_2;
		} else if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.stairs_2;
		}
	}

	void courtyard(){
		text.text = "You are free now!!!" + "Feel free to Play again";

		if (Input.GetKeyDown (KeyCode.P)) {
			myState = TextController.States.corridor_0;
		}
	}

	void floor(){
		text.text = " Press F to reach floor and R to return to Corridor ";

		if (Input.GetKeyDown (KeyCode.F)) {
			myState = TextController.States.floor;
		} else if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.corridor_0;
		}
	}
}





