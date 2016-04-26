using UnityEngine;
using System.Collections;

public class PausedUI : MonoBehaviour {

	public GameObject PanelPause;
	private bool paused = false;

	void Start ()
	{
		PanelPause.SetActive (false);
	}

	void Update ()
	{
		if (Input.GetButtonDown ("Paused")) 
		{
			paused = !paused;
		}

		if (paused) 
		{
			PanelPause.SetActive(true);
			Time.timeScale = 0;
		}

		if (!paused) 
		{
			PanelPause.SetActive(false);
			Time.timeScale = 1;
		}
	}

	public void ButtonResume()
	{
		paused = false;
	}

	public void ButtonRestart ()
	{
		Application.LoadLevel (Application.loadedLevel);
	}

	public void ButtonMainMenu ()
	{
		Application.LoadLevel (0);
	}
}
