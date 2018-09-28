using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private int score = 0;
    public GUIText scoreText;

    private void Start()
    {
        score = 0;
        UpdateScore();
    }

    public void GameOver()
	{
		Time.timeScale = 0;
     
	}

    public int AddPoint()
    {
        return score++;
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + this.score;
    }

 

}
