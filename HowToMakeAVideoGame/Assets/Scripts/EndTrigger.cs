using UnityEngine;

public class EndTrigger : MonoBehaviour {

	public GameManager gameManeger;

	void OnTriggerEnter () {
		gameManeger.CompleteLevel ();
	}
}
