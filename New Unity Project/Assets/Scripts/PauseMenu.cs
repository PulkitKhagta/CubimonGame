using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {
    public static bool GameIsPaused = false;
    public GameObject pauseMenuUI;

	public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
	
	// Quit from the game
	public void Quit () {
        Debug.Log("Quit");
        Application.Quit();
	}
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
       
    }
   
        
}
