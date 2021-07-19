using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public Text scoreText;
    public void SetUp(int score)
    {
        gameObject.SetActive(true);
        scoreText.text = "Score"+score.ToString();
    }
}
