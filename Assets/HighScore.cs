using UnityEngine;
using System.Collections;

public class HighScore : MonoBehaviour {

	static public int score = 1000;

	// Use this for initialization
	void Start () {
	
	}

	void Awake(){
		//if the applepickerhighscore already exists, read it
		if (PlayerPrefs.HasKey ("ApplePickerHighScore")) {
			score = PlayerPrefs.GetInt("ApplePickerHighScore");
		}
		//assign the high score to applepickerhighscore
		PlayerPrefs.SetInt ("ApplePickerHighScore", score);
	}

	// Update is called once per frame
	void Update () {
		GUIText gt = this.GetComponent<GUIText> ();
		gt.text = "High Score: " + score;

		//update applepickerhighscore in playerprefs if necessary
		if(score > PlayerPrefs.GetInt ("ApplePickerHighScore")){
			PlayerPrefs.SetInt("ApplePickerHighScore", score);
		}
	}
}
