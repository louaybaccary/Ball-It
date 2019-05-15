using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour

{
    bool gameHasEnded = false;
    public float delay = 1f;
   [SerializeField] private Text ScoreText;
   [SerializeField] public int Score = 0;
   [SerializeField] private Text highScoreText;
    public GameObject completeLevelUI;
    
    void Start()
    {
        ScoreText = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>();
        ScoreText.text = "Score : " + Score.ToString();
        highScoreText.text = "High Score : "+PlayerPrefs.GetInt("highscore",0).ToString();

    }
    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", delay);
        }
    }
    public void AddScore()
    {
        Score += 10;
        ScoreText.text = "Score : " + Score.ToString();
        if (Score> PlayerPrefs.GetInt ("highscore")){
		PlayerPrefs.SetInt ("highscore", Score);
		highScoreText.text = "High Score : "+Score;
		}
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }
}
