using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnController : MonoBehaviour {

	public void ToPlay(){
		SceneManager.LoadScene ("Play");
	}

	public void ToTitle(){
		SceneManager.LoadScene ("Title");
	}

	public void Tweet () {
		string tweet = "スコア: " + GameManager.score + "ああああああ #ハッシュタグ";
		string openUrl = "http://twitter.com/intent/tweet?text=" + WWW.EscapeURL (tweet);
		string jsCord = "window.open(\""+openUrl+"\")";
		Application.ExternalEval(jsCord);
//		Application.OpenURL("http://twitter.com/intent/tweet?text=" + WWW.EscapeURL(tweet));

		// https://answers.unity.com/questions/1133713/webgl-open-url-in-new-tab.html

		/*
		window.open(
			'https://twitter.com/intent/tweet?text='+tweetText+'&url='+tweetUrl+'&hashtags='+tweetHashtags, 
			'share window', 
			'menubar=no,toolbar=no,resizable=yes,scrollbars=yes,height=300,width=600'
		);
		*/
	}
}
