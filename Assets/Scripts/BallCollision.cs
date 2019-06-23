using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{

    public Rigidbody2D rb;
    public Vector3 PaddleCollisionForce = new Vector3(-200, -20, 0);

    void OnCollisionEnter2D(Collision2D collision) {

        if(collision.gameObject.name == "Paddle2") {
            Debug.Log("The ball has hit the red paddle.");
            rb.AddForce(PaddleCollisionForce); 
        }

        if (collision.gameObject.name == "Paddle") {
            Debug.Log("The ball has hit the blue paddle.");
            rb.AddForce(-PaddleCollisionForce);
        }

        if(collision.gameObject.name == "Top Barrier") {
            Debug.Log("The ball has hit the top barrier.");
        }

        if (collision.gameObject.name == "Bottom Barrier") {
            Debug.Log("The ball has hit the bottom barrier.");
        }
    }
}

