using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

	public GameObject wordPrefab;
	public Transform wordCanvas;

	public WordDisplay SpawnWord () {
		Vector3 randomPosition = new Vector3 (Random.Range(-1.5f,1.5f),7f);

//		GameObject wordObj = Instantiate (wordPrefab, randomPosition, Quaternion.identity, wordCanvas);

//		GameObject wordObj = Instantiate (wordPrefab, randomPosition, Quaternion.identity);
//		wordObj.transform.SetParent (wordCanvas, false);

		GameObject wordObj = Instantiate (wordPrefab, wordCanvas);
		wordObj.transform.position = randomPosition;

		WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay> ();
		return wordDisplay;
	}
}
