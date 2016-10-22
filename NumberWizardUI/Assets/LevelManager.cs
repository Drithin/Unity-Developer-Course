using UnityEngine;
using System.Collections;


// Methods are void coz we are not returning anything from them

public class LevelManager : MonoBehaviour {
	// functions doesn't show up in OnClick() tab
	// we have to make method public for that
	public void LoadLevel(string name){
		Debug.Log (" Level loading requested for " + name);

		Application.LoadLevel (name);


	}

	//Here we are not prompting to load or quit from a particular level
	//so no point of a passing a variable to method
	//We are quitting from the game itself!
	public void QuitLevel(){
		Debug.Log (" I want to Quit ");
		Application.Quit ();


	}
}
