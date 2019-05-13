using UnityEngine;
using UnityEngine.UI;

public class PlayHUD : MonoBehaviour {

	public Text ScoreTextUI;
	public Text TimeTextUI;
	public GameManager gameManager;

	private string scoreBaseText = "スコア: ";
	private string timeBaseText = "タイム: ";

	void Start () {
		SetScoreText (0);
		SetTimeText (gameManager.firstTime);
	}

	public void SetScoreText (int val){
		ScoreTextUI.text = scoreBaseText + val.ToString ();
	}

	public void SetTimeText (int val) {
		TimeTextUI.text = timeBaseText + val.ToString ();
	}
}
