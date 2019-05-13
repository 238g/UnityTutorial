using UnityEngine;
using System.Collections; //IEnumerator

public class SpawnEnemies : MonoBehaviour {

	public GameObject enemy;
	public GameObject HUDUI;
	public GameManager gameManager;
	public int MaxEnemyCount = 20;

	private float spawnTimer = 1f;
	private float timer = 1f;
	private float worldWidth;
	private float worldHeight;
	private float marginX;
	private float marginY;
	private PlayHUD HUDScript;

	void Start() {
		worldHeight = gameManager.worldHeight;
		worldWidth = gameManager.worldWidth;
		marginX = worldWidth * 0.45f;
		marginY = worldHeight * 0.45f;
		HUDScript = HUDUI.GetComponent<PlayHUD> ();
	}

	private void Update () {
		if (gameManager.isPlaying) {
			SpawnWaveManager ();
			TimeCountManager ();
		}
	}

	void SpawnWaveManager () {
		if (spawnTimer <= 0f) {
			StartCoroutine (SpawnWave());
			spawnTimer = 1.5f;
			return;
		}
		spawnTimer -= Time.deltaTime;
	}

	void TimeCountManager () {
		if (timer <= 0f) {
			gameManager.curTime--;
			HUDScript.SetTimeText (gameManager.curTime);
			if (gameManager.curTime <= 0) {
				gameManager.GameOver ();
			}
			timer = 1f;
			return;
		}
		timer -= Time.deltaTime;
	}

	private IEnumerator SpawnWave () {
		for (int i = 0; i < 3; i++) {
			if (gameManager.curEnemyCount <= MaxEnemyCount) {
				SpawnEnemy (enemy);
				yield return new WaitForSeconds (0.3f);
			}
		}
	}

	private void SpawnEnemy (GameObject enemy) {
		float x = Random.Range (-marginX, marginX);
		float y = Random.Range (-marginY, marginY);
		GameObject enemyInstance = Instantiate (enemy,new Vector3 (x, y, 0.0f),Quaternion.identity);
		Enemy EnemyScript = enemyInstance.GetComponent<Enemy> ();
		EnemyScript.SetHUDUI (HUDUI);
		EnemyScript.SetGameManager (gameManager);
		gameManager.curEnemyCount++;
	}
}
