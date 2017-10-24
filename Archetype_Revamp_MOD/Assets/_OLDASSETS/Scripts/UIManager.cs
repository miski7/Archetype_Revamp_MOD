using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class UIManager : MonoBehaviour {

    public GameObject pausePanel;
    public bool isPaused;

	void Start ()
    {
        isPaused = false;
	}
	
	void Update ()
    {
	    if(isPaused)
        {
            PauseGame(true);
        }
        else
        {
            PauseGame(false);
        }
        if (Input.GetButtonDown("Cancel"))
        {
            SwitchPause();
        }
	}

    void PauseGame (bool state)
    {
        if (state)
        {
            Time.timeScale = 0.0f;          //paused
        }
        else
        {
            Time.timeScale = 1.0f;             //active
        }
        pausePanel.SetActive(state);
    }

    public void SwitchPause()
    {
        if(isPaused)
        {
            isPaused = false;                   // changes the value of isPaused
        }
        else
        {
            isPaused = true;
        }
    }

    public void QuitGame()
    {
		SceneManager.LoadScene("mainMenu");
    }
}