using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector3 initialForce = new Vector3(5, 0, 0);   
    
    void Start() { 
        rb.gravityScale = 0;
        rb.AddForce(initialForce);
    }

    void Update() {
         
    }

}
