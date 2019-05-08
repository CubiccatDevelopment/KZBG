using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Highscores : MonoBehaviour {

	const string privateCode= "Ig0JxP99lUyD-J8LUCojNwzzUHsmeDdkCjmHr5sa6QGw";
	const string publicCode="5930381f758d0b0344398227";
	const string webURL="http://dreamlo.com/lb/";

	public Highscore[] highscorelist;
	static Highscores instance;
	DisplayHighscores highscoresDisplay;


	void Awake(){
		instance = this;
		highscoresDisplay = GetComponent<DisplayHighscores> ();

	}


	public static void AddNewHighscore(string username, int score){
		instance.StartCoroutine(instance.UploadNewHighscore(username,score));
	}

	IEnumerator UploadNewHighscore(string username, int score){
		WWW www = new WWW(webURL + privateCode + "/add/"+ WWW.EscapeURL(username) + "/" + score);
			yield return www;

		if (string.IsNullOrEmpty (www.error)) {
			print ("Upload Succescful");
			DownloadHighscores ();
		}
			else{
				print("Error uploading:" + www.error);
			}
	}

	public void DownloadHighscores(){
		StartCoroutine ("DownloadHighscoreFromDatabase");
	}


	IEnumerator DownloadHighscoreFromDatabase(){
		WWW www = new WWW(webURL + publicCode+ "/pipe/");
		yield return www;

		if (string.IsNullOrEmpty (www.error)) {
			FormatHighscores (www.text);
			highscoresDisplay.OnHighscoresDownloaded (highscorelist);
		}
		else{
			print("Error dowload:" + www.error);
		}
	}



	void FormatHighscores(string textStream){
		string[] entries=textStream.Split(new char[] {'\n'}, System.StringSplitOptions.RemoveEmptyEntries);
		highscorelist = new Highscore[entries.Length];
		for (int i = 0; i < entries.Length; i++) {
			string[] entryInfo = entries [i].Split (new char[] { '|' });
			string username = entryInfo [0];
			int score = int.Parse(entryInfo [1]);
			highscorelist [i] = new Highscore (username, score);
		}
	}

}
public struct Highscore{
	public string username;
	public int score;

					public Highscore(string _username,int _score){
						username = _username;
						score = _score;
					}
}
