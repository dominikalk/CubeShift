using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuUiManager : MonoBehaviour {

    public Text HighScore;

    // Use this for initialization
    void Start () {
        HighScore.text = "High Score: " + PlayerPrefs.GetInt("HighScore").ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Play()
    {
        SceneManager.LoadScene("level1");
    }
}
