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
		DontDestroyOnLoad (gameObject);
		instance = this;
		LeftScoreNum = RightScoreNum = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LeftPoint(){
		string currentlvl = Application.loadedLevelName;
		LeftScoreNum += 1; 
		LeftScore.text = LeftScoreNum.ToString();
		if (LeftScoreNum == 1) {
			Application.LoadLevel (currentlvl+"I");
		}
	}

	public void RightPoint(){
		string currentlvl = Application.loadedLevelName;
		RightScoreNum += 1; 
		RightScore.text = RightScoreNum.ToString();
		if (RightScoreNum == 1) {
			Application.LoadLevel (currentlvl+"I");
		}
	}
}
