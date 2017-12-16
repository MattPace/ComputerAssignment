using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePaddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mousePosInUnits = (Input.mousePosition.y / Screen.height * 13f) - 6.5f;
        float mousePos = Mathf.Clamp(mousePosInUnits, -3.5f, 3.5f);
        Vector3 paddlePosition = new Vector3(this.transform.position.x, mousePos, 0);
        this.transform.position = paddlePosition;
    }
}
