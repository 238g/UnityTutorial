using UnityEngine;
using UnityEngine.UI;

public class ResultHUD : MonoBehaviour {

	public Text ScoreTextUI;

	private string scoreBaseText = "スコア: ";

	void Start () {
		SetScoreText (GameManager.score);
	}

	public void SetScoreText (int val){
		ScoreTextUI.text = scoreBaseText + val.ToString ();
	}
}
