using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    private int score = 0;
	public TextMeshProUGUI ScoreText;
    public Menu Menu;
    public Music music;

    private void Start()
    {
        score = 0;
        UpdateScore();
    }


	public void GameOver()
	{
		Time.timeScale = 0;
		Menu.gameObject.SetActive(true);
        music.ToggleMusic(false);
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
		ScoreText.text = "Score: " + this.score;
	}

 

}
