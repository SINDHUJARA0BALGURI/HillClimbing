using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour
{
   public static Score instance;
   public  int score=0;
    int highScore=0;
    public Text scoreText;
    public Text highScoreText;
    private void Awake()
    {
        instance = this;

    }
    // Start is called before the first frame update
    void Start()
    {
        highScore = PlayerPrefs.GetInt("highScore",0);
        scoreText.text = "Score:"+score.ToString();
        highScoreText.text = "HighScore:"+highScore.ToString();
    }

    // Update is called once per frame
    public void ScoreUp()
    {
        score+=5;
        scoreText.text = "Score:" + score.ToString();
        if(highScore<score)
        PlayerPrefs.SetInt("highScore", score);

    }



}