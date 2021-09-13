using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

    public GameObject PressToStartText;
    public GameObject GameOverPanel;
    public GameObject MenuButton;
    public GameObject RetryButton;
    public bool gameover;
    public Text highScoreText;
    public Text scoreText;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        gameover = GameManager.instance.gameover;

        GameOver();

        if (Input.GetMouseButtonDown(0))
        {
            PressToStartText.SetActive(false);
        }

        scoreText.text = ScoreManager.instance.score.ToString();
    }

    public void menu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void level1()
    {
        SceneManager.LoadScene("level1");
    }

    void GameOver()
    {
        if (gameover == true)
        {
            ScoreManager.instance.StopScore();
            GameOverPanel.SetActive(true);
            MenuButton.SetActive(true);
            RetryButton.SetActive(true);
            highScoreText.text = "High Score: " + PlayerPrefs.GetInt("HighScore");
        }
    }
}
