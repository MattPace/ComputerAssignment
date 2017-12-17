using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObs : MonoBehaviour {

	private Vector3 startPos;
	private Vector3 secondPos;
	private Vector3 nextPos;

	[SerializeField]
	private float speed;

	[SerializeField]
	private Transform positionTransform2;

	[SerializeField]
	private Transform transformB;

	void Start () {
		startPos = positionTransform2.localPosition;
		secondPos = transformB.localPosition;
		nextPos = secondPos;
	}
	
	// Update is called once per frame
	void Update () {
		ObsMove ();
	}

	private void ObsMove(){
		positionTransform2.localPosition = Vector3.MoveTowards (positionTransform2.localPosition, nextPos, speed * Time.deltaTime);
		if (Vector3.Distance (positionTransform2.localPosition, nextPos) <= 0.1) {
			goBack ();
		}
	}

	private void goBack(){
		nextPos = nextPos != startPos ? startPos : secondPos;
	}
}
