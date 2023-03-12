using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
   

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(score);
        scoreText.text = "Score: " + PlayerController.Finalscore.ToString();
    }
    
}
