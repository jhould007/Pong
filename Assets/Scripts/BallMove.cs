using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Transform ballTransform;
    public Vector3 initialForce = new Vector3();
    
    void Start() { 
        rb.gravityScale = 0;
        rb.AddForce(initialForce);
    }

    void Update() {
        Vector2 currentPos = new Vector2(ballTransform.position.x, ballTransform.position.y); 
    }

  /*  function WaitForSeconds(float seconds) {
        yield WaitForSeconds(seconds); 
    } */

    void OnCollisionEnter2D(Collision2D collision) {

        float yOffset = 0; 

        if (collision.gameObject.name == "Left Barrier") {
            if(ballTransform.position.y > 0) {
                yOffset = ballTransform.position.y; 
            } else if(ballTransform.position.y < 0) {
                yOffset = ballTransform.position.y; 
            }
            ballTransform.Translate(4.8f, -yOffset, 0);
            rb.AddForce(initialForce); 
        }

        if (collision.gameObject.name == "Right Barrier") {
            if (ballTransform.position.y > 0) {
                yOffset = ballTransform.position.y;
            }
            else if (ballTransform.position.y < 0) {
                yOffset = ballTransform.position.y;
            }
            ballTransform.Translate(-4.8f, -yOffset, 0);
            rb.AddForce(initialForce);
        }
    }

}
