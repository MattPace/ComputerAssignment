using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float speed = 5f;
	// Use this for initialization
	void Start () {
		StartCoroutine (Pause ());
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < -11f) {
			ScoreBoard.instance.RightPoint ();
			StartCoroutine (Pause ());
		}

		if (transform.position.x > 11f) {
			ScoreBoard.instance.LeftPoint ();
			StartCoroutine (Pause ());
		}
	}

	void startGame(){

		float sx = Random.Range (0, 2) == 0 ? -1 : 1;
		float sy = Random.Range (0, 2) == 0 ? -1 : 1;

		GetComponent<Rigidbody2D> ().velocity = new Vector3 (speed * sx, speed * sy, 0f);
	}

	IEnumerator Pause(){
		transform.position = Vector3.zero;
		GetComponent<Rigidbody2D> ().velocity = new Vector3 (0f,0f,0f);
		yield return new WaitForSeconds (3f);
		startGame ();
	}
}
