using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle2Move : MonoBehaviour {
    public Rigidbody2D rb;
    public Vector3 moveForce = new Vector3();
    public Transform paddlePosition;

    void Start() {
        rb.gravityScale = 0;
    }

    void Update() {

        bool upKeyPressed = Input.GetKey("up");
        bool downKeyPressed = Input.GetKey("down");

        if (upKeyPressed) {
            rb.AddForce(moveForce, ForceMode2D.Impulse);
        }

        if (downKeyPressed) {
            rb.AddForce(-moveForce, ForceMode2D.Impulse);
        }
    }
}
