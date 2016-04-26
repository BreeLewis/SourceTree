using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

	float timeRemaining = 30;
	
	// Deducts the time from the time remaining
	void Update () 
	{
		timeRemaining -= Time.deltaTime;
	}

	//
	void OnGui ()
	{
		if (timeRemaining > 0) {
			GUI.Label (new Rect (100, 100, 200, 100), "Time Remaining: " + timeRemaining);
		} else {
			GUI.Label (new Rect(100,100,100,100), "You're Saved!");
		}
		Application.LoadLevel("TitleScreen");
	}
}
