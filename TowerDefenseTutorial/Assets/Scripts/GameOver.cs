using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	public string menuSceneName = "MainMenu";

	public SceneFader sceneFader;

	public void Retry () {
		// TODO
		sceneFader.FadeTo (SceneManager.GetActiveScene().name);
		// SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
	}

	public void Menu () {
		// TODO
		sceneFader.FadeTo (menuSceneName);
	}
}
