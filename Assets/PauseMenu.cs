using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
   public GameObject pauseMenu, pauseButton;

	public void Pause()
	{	
			pauseButton.SetActive(false);
			pauseMenu.SetActive(true);
			Time.timeScale=0f;
	}

	public void Resume()
	{	pauseButton.SetActive(true);
		pauseMenu.SetActive(false);
		Time.timeScale=1f;
	}

	public void Restart()
	{		
		Time.timeScale=1f;
			SceneManager.LoadScene ("Prototype");
	}
	public void Menu()
	{				Time.timeScale=1f;

			SceneManager.LoadScene("Menu");

	}
	public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}


