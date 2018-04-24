using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class game_controller : MonoBehaviour {

    public GameObject gameOverText;
    public bool gameOver = false;

    public static game_controller instance;
    public Text scoreText;
    public Text highScoreText;
    private int score = 0;

	// Use this for initialization
	void Awake ()
    {
		if (instance == null)
        {
            instance = this;
        }
        else if (instance!=null)
        {
            Destroy(gameObject);
        }
	}

    void Start()
    {
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		if(gameOver == true && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Main");
            Time.timeScale = 1; 
        }
	}

    public void playerScored()
    {
        if (gameOver)
        {
            return;
        }
        else
        
        score+=1;
       
        
        scoreText.text = score.ToString();

        if(score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
            highScoreText.text = score.ToString();
        }
    }

    public void playerDied()
    {
        gameOverText.SetActive(true);
        gameOver = true;
    }














}
