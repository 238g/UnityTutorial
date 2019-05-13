using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public static int score = 0;

	public bool  isPlaying = false;
	public float worldWidth;
	public float worldHeight;
	public int curEnemyCount = 0;
	public int firstTime = 60;
	public int curTime = 0;

	private void Awake () {
		isPlaying = true;
		curTime = firstTime;
		SetWorldBounds ();
		TEST (); // TODO comment out
	}

	void Start () {
		score = 0;
	}

	private void SetWorldBounds () {
		Camera cam = Camera.main;
		worldHeight = 2f * cam.orthographicSize;
		worldWidth =  worldHeight * cam.aspect;
	}

	private void TEST () {
	}

	public void GameOver () {
		isPlaying = false;
		SceneManager.LoadScene ("Result");
	}

}
