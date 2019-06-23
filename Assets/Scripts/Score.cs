using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform ballTransform;
    Vector2 startPos = new Vector2(0, 0); 

    void Update() {

        Vector2 currentPos = new Vector2(ballTransform.position.x, ballTransform.position.y);

        if (ballTransform.position.x < -4.8) {
            Debug.Log("Red wins this round!");
            ballTransform.Translate(4.8f, 0, 0); 
        }

        if(ballTransform.position.x > 4.8) {
            Debug.Log("Blue wins this round!");
            ballTransform.Translate(-4.8f, 0, 0); 
        }

    }
}

