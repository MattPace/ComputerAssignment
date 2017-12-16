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
		LeftScoreNum = RightScoreNum = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LeftPoint(){
		LeftScoreNum += 1; 
		LeftScore.text = LeftScoreNum.ToString();
	}

	public void RightPoint(){
		RightScoreNum += 1; 
		RightScore.text = RightScoreNum.ToString();
	}
}
