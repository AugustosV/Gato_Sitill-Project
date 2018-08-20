using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PauseSettings: MonoBehaviour {



	public void Paused ()
	{
		Canvas canvas;

		canvas = GetComponent<Canvas> ();
		canvas.enabled = !canvas.enabled;
		pause ();

	}

	public void pause()
	{
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
	}

	public void Settings()
	{
		
	}
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEditor;

public class Pause: MonoBehaviour {

	Canvas canvas;

	void Start () {
		canvas = GetComponent<Canvas> ();
	}
	void Update () {
		if (Input.GetKeyDown (KeyCode.P)) 
		{ 	
			canvas.enabled = !canvas.enabled;
			pause();
		}
	}
	public void pause()
	{
		Time.timeScale = Time.timeScale == 0 ? 1 : 0;
		//lowpass ();
	}

		void lowpass()
	{
		if (Time.timeScale == 0) {
			paused.TransitionTo (.01f);
		} else
		{Unpaused.TransitionTo (.01f);}
	}
}
*/