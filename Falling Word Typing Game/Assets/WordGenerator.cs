using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour {

	// https://www.randomlists.com/random-words
	private static string[] wordList = {
		"alleged", "distinct", "wild", "cap", "sprout", "undress", "clever", "painstaking", "enthusiastic", "exciting", "slip", "grip", "swanky", "weight", "milk", "quaint", "talk", "scorch", "alarm", "questionable", "joke", "right", "rampant", "broad", "blot", "tall", "found", "produce", "measly", "ticket", "prick", "check", "size", "alluring", "lying", "gray", "next", "knotty", "wiry", "spark", "fold", "snotty", "summer", "step", "buzz", "flash", "nest", "legal", "pull", "popcorn", "party", "peace", "whine", "rat", "ready", "snatch", "deserted", "teeth", "ten", "tow", "thoughtful", "aback", "divide", "apparatus", "mask", "cave", "cheerful", "giants", "quack", "thaw", "glossy", "chicken", "infamous", "ablaze", "boundless", "itch", "hook", "suppose", "harmony", "piquant", "wide", "tart", "women", "laborer", "meeting", "sturdy", "fold", "merciful", "calculating", "unequaled", "face", "soothe", "detail", "great", "crabby", "rural", "manage", "muddle", "scrape", "chance",
	};

	public static string GetRandomWord () {
		int randomIndex = Random.Range (0,wordList.Length-1);
		string randomWord = wordList[randomIndex];
		return randomWord;
	}
}
