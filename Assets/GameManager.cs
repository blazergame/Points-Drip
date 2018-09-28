using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    private int score = 0;
    public GUIText scoreText;
    public Menu Menu;

    private void Start()
    {
        score = 0;
        UpdateScore();
    }


	public void GameOver()
	{
		Time.timeScale = 0;
		Menu.gameObject.SetActive(true);
	}

	public void Restart()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		Time.timeScale = 1;
	}

	public void Quit()
	{
		Application.Quit();
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
