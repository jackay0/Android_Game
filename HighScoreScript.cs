using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    public Text highScore;
    // Start is called before the first frame update
    void Start()
    {
        highScore = GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
         highScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore",0).ToString();
    
        if(ScoreScript.scoreValue > PlayerPrefs.GetInt("HighScore",0))
        {
        PlayerPrefs.SetInt("HighScore", ScoreScript.scoreValue);
        highScore.text = "High Score: " + ScoreScript.scoreValue;
        }
    }
}
