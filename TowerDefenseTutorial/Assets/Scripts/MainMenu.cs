﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public string levelToLoad = "MainLevel";

	public SceneFader sceneFader;

	public void Play () {
		sceneFader.FadeTo (levelToLoad);
		// SceneManager.LoadScene (levelToLoad);
	}

	public void Quit () {
		Application.Quit ();
	}
}