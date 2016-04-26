using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverManager : MonoBehaviour 
	{
		public float restartDelay = 5f;         // Time to wait before restarting the level
//		public Text restartText; 
		public Text gameOverText;
	
		private bool gameOver;
//		private bool restart;
		Animator anim;                          // Reference to the animator component.
		float restartTimer;                     // Timer to count up to restarting the level
		
		
	void Start ()
	{
		gameOver = false;
//		restart = false;
//		restartText.text = "";
		gameOverText.text = "";
	}
		void Awake ()
		{
			// Set up the reference.
			anim = GetComponent <Animator> ();
		}
		
		
		void Update ()
		{
			// If the player has run out of health...
			if(StaticVars.Health <= 0)
			{
				// ... tell the animator the game is over.
				anim.SetTrigger ("GameOver");
				
				// .. increment a timer to count up to restarting.
				restartTimer += Time.deltaTime;
				
				// .. if it reaches the restart delay...
				if(restartTimer >= restartDelay)
				{
					// .. then reload the currently loaded level.
					Application.LoadLevel(Application.loadedLevel);
				}
			}
/*		if (restart) 
		{
			if (Input.GetKeyDown (KeyCode.R))
			{
				Application.LoadLevel (Application.loadedLevel);
			}
		}  */
	}

/*	IEnumerator Restart ()
	{
		if (gameOver) 
		{
			restartText.text = "Press 'R' for Restart";
			restart = true;
		}
	}
*/
	public void GameOver ()
	{
		gameOverText.text = "Game Over!";
		gameOver = true;
	}

}