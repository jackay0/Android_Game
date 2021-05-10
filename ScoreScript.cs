using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static int scoreValue = 0;
    public Text score;
 
    void Start()
    {
        scoreValue = 0;
        score = GetComponent<Text> ();
        //highScore = GetComponent<Text> ();
        
    }
    // Update is called once per frame
    void Update()
    {
        score.text = "Jumps: " + scoreValue;
        //highScore.text = PlayerPrefs.GetInt("HighScore",0).ToString();
    
        //if(scoreValue > PlayerPrefs.GetInt("HighScore",0))
        //{
        //PlayerPrefs.SetInt("HighScore", scoreValue);
        //highScore.text = scoreValue.ToString();
        //}
    }
}
