using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMove : MonoBehaviour {
    public Rigidbody2D rb;
    public Vector3 moveForce = new Vector3();
    public Transform paddlePosition; 

    void Start() {
        rb.gravityScale = 0; 
    }

    void Update() {

        bool wKeyPressed = Input.GetKey("w");
        bool sKeyPressed = Input.GetKey("s");

        if (wKeyPressed) {
            rb.AddForce(moveForce, ForceMode2D.Impulse);
        }

        if(sKeyPressed) {
            rb.AddForce(-moveForce, ForceMode2D.Impulse); 
        }
    }
}
