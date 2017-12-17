using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour {
	public static ScoreBoard instance;
	public Text LeftScore;
	public Text RightScore;
	public int LeftScoreNum;
	public int RightScoreNum;

	// Use this for initialization
	void Start () {
		instance = this;
		string currentlvl = Application.loadedLevelName;
		if(currentlvl == "LevelI"){
			LeftScoreNum = RightScoreNum = 0;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnEnable()
	{
		LeftScoreNum  =  PlayerPrefs.GetInt("leftScore");
		RightScoreNum  =  PlayerPrefs.GetInt("rightScore");
	}

	public void LeftPoint(){
		string currentlvl = Application.loadedLevelName;
		LeftScoreNum += 1; 
		LeftScore.text = LeftScoreNum.ToString ();
		if (currentlvl == "LevelI" && LeftScoreNum == 1) {
			PlayerPrefs.SetInt ("leftScore", LeftScoreNum);
			PlayerPrefs.SetInt ("rightScore", RightScoreNum);
			Application.LoadLevel ("LevelII");
		} else if (currentlvl == "LevelII" && LeftScoreNum == 2) {
			PlayerPrefs.SetInt("leftScore", LeftScoreNum);
			PlayerPrefs.SetInt("rightScore", RightScoreNum);
			Application.LoadLevel ("LevelIII");
		} else if (currentlvl == "LevelIII" && LeftScoreNum == 3) {
			PlayerPrefs.SetInt("leftScore", LeftScoreNum);
			PlayerPrefs.SetInt("rightScore", RightScoreNum);
			Application.LoadLevel ("LeftWin");
		}
	}

	public void RightPoint(){
		string currentlvl = Application.loadedLevelName;
		RightScoreNum += 1; 
		RightScore.text = RightScoreNum.ToString();
		if (currentlvl == "LevelI" && RightScoreNum == 1) {
			PlayerPrefs.SetInt ("leftScore", LeftScoreNum);
			PlayerPrefs.SetInt ("rightScore", RightScoreNum);
			Application.LoadLevel ("LevelII");
		} else if (currentlvl == "LevelII" && RightScoreNum == 2) {
			PlayerPrefs.SetInt("leftScore", LeftScoreNum);
			PlayerPrefs.SetInt("rightScore", RightScoreNum);
			Application.LoadLevel ("LevelIII");
		} else if (currentlvl == "LevelIII" && RightScoreNum == 3) {
			PlayerPrefs.SetInt("leftScore", LeftScoreNum);
			PlayerPrefs.SetInt("rightScore", RightScoreNum);
			Application.LoadLevel ("RightWin");
		}
	}
}
