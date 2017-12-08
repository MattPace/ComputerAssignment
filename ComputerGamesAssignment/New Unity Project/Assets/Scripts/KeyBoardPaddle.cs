using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyBoardPaddle : MonoBehaviour {

    float paddlePos;
    // Use this for initialization
    void Start () {
        paddlePos = transform.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        // float mousePos;

        
        if (Input.GetKey(KeyCode.W))
        {
            if (transform.position.y <= 3.5f)
            {
                transform.Translate(Vector3.left * 15f * Time.deltaTime);
            }
        }
        else if (Input.GetKey(KeyCode.S))
        {
            if (transform.position.y >= -3.5f)
            {
                transform.Translate(-Vector3.left * 15f * Time.deltaTime);
            }
        }
    }
}
