﻿using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {


    private int score = 0;
	public TextMeshProUGUI ScoreText;
    public Menu Menu;
    public Music music;
    public GameObject StartButton;

    private void Start()
    {
        score = 0;                       //Set start score to 0
        UpdateScore();                   //Set initial score tex to 0
        Time.timeScale = 0;              //Freeze game before starting
        Menu.gameObject.SetActive(true); //Displays the menu
        music.ToggleMusic(false);        //Disable music 
    }

    public void RestartGame()
    {
        StartGame();
    }

    public void GameOver()
	{
        SoundManager.PlaySound("SawSound");
		Time.timeScale = 0;
        music.ToggleMusic(false);
        SceneManager.LoadScene("RestartScene");     //Reloads the scene to restart      
    }

    IEnumerator DelayScreen()
    {
        yield return new WaitForSeconds(2f);
    }


    public void StartGame()
	{
        Time.timeScale = 1;                //Start game object movement
        Menu.gameObject.SetActive(false);  //Hide the menu
        music.ToggleMusic(true);           //Turn music on

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

    public void DisappearOnTouch(GameObject gameObject)
    {
        if (gameObject.tag == Helper.Tag.POINT_TAG)
        {
            SoundManager.PlaySound("CoinSound");
            gameObject.SetActive(false);
        }
    }

}
