using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Score : MonoBehaviour
{

    public Transform ballTransform;
    public Text blueScoreText;
    public Text redScoreText;
    public int blueScore = 0;
    public int redScore = 0; 

    void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == "Left Barrier") {
            Debug.Log("Red wins this round!");
            redScore++;
            redScoreText.text = "Red: " + redScore; 
        } 

        if (collision.gameObject.name == "Right Barrier") {
            Debug.Log("Blue wins this round!");
            blueScore++;
            blueScoreText.text = "Blue: " + blueScore; 
        }
    }
    
}

/*public Transform ballTransform;
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
        }*/