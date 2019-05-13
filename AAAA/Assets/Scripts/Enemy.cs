using UnityEngine;

public class Enemy : MonoBehaviour {

	public float speedZ = 0.3f;

	private float curX = 0.0f;
	private float curY = 0.0f;
	private float curZ = 0.0f;
	private int moveXDir = 1;
	private int moveYDir = 1;
	private int moveZDir = 1;
	private float worldWidth;
	private float worldHeight;
	private float marginX;
	private float marginY;
	private float marginZFront = -0.1f;
	private float marginZBack = 0.45f;
	private float speedX = 0.3f;
	private float speedY = 0.3f;
	private int killBaseScore = 50;
	private GameObject HUDUI;
	private PlayHUD HUDScript;
	private GameManager gameManager;


	private void Start () {
		DirX ();
		DirY ();
		worldHeight = gameManager.worldHeight;
		worldWidth = gameManager.worldWidth;
		marginX = worldWidth * 0.45f;
		marginY = worldHeight * 0.45f;
		curX = transform.position.x;
		curY = transform.position.y;
		curZ = transform.position.z;
	}

	public void SetHUDUI (GameObject _HUDUI) {
		HUDUI = _HUDUI;
		HUDScript = HUDUI.GetComponent<PlayHUD> ();
	}

	public void SetGameManager (GameManager _gameManager) {
		gameManager = _gameManager;
	}

	private void Update () {
		MovePos ();
	}

	private void MovePos () {
		curX += moveXDir * speedX * Time.deltaTime;
		curY += moveYDir * speedY * Time.deltaTime;
		curZ += moveZDir * speedZ * Time.deltaTime;
		transform.position  = new Vector3(curX, curY, curZ);
		if (curX < -marginX) SetNewStatusX (1);
		if (curX > marginX)  SetNewStatusX (-1);
		if (curY < -marginY) SetNewStatusY (1);
		if (curY > marginY) SetNewStatusY (-1);
		if (curZ > marginZBack) moveZDir = -1;
		if (curZ < marginZFront) moveZDir = 1;
	}

	private void SetNewStatusX (int dir) {
		moveXDir = dir;
		SetSpeedX ();
	}

	private void SetNewStatusY (int dir) {
		moveYDir = dir;
		SetSpeedY ();
	}

	private void SetSpeedX () {
		speedX = Random.Range (0.3f,0.8f);
	}

	private void SetSpeedY () {
		speedY = Random.Range (0.3f,0.8f);
	}

	private void DirX () {
		if (RndBool ()) {
			SetNewStatusX (1);
		} else {
			SetNewStatusX (-1);
		}
	}

	private void DirY () {
		if (RndBool ()) {
			SetNewStatusY (1);
		} else {
			SetNewStatusY (-1);
		}
	}

	private void OnMouseDown () {
		Destroy (gameObject);
		gameManager.curEnemyCount--;
		int bonusScore = (int) (curZ * 100);
		GameManager.score += killBaseScore + bonusScore * bonusScore;
		HUDScript.SetScoreText (GameManager.score);
	}

	private bool RndBool () {
		return (Random.value > 0.5f);
	}
}
