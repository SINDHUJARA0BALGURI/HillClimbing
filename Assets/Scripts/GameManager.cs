using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameOver gameOver;
    int score = 0;
   
    public void GameOver()
    {
        gameOver.SetUp(score);
    }
}
