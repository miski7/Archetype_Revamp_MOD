using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class MainMenuManager : MonoBehaviour 
{
    public Transform MainMenu, optionsMenu, LevelMenu, TutorialMenu, AudioSettingsMenu;

	public void LoadScene (int level)
	{
		SceneManager.LoadScene(level);
	}
	public void QuitGame()
	{
        Debug.Log("Quitting the game!");
		Application.Quit();
	}
    public void OptionsMenu (bool clicked)
    {
        if(clicked)
        {
            optionsMenu.gameObject.SetActive(clicked);
            MainMenu.gameObject.SetActive(false);
			LevelMenu.gameObject.SetActive(false);
			TutorialMenu.gameObject.SetActive(false);
			AudioSettingsMenu.gameObject.SetActive(false);
        }
        else
        {
	        optionsMenu.gameObject.SetActive(clicked);
	        MainMenu.gameObject.SetActive(true);
			LevelMenu.gameObject.SetActive(false);
			TutorialMenu.gameObject.SetActive(false);
			AudioSettingsMenu.gameObject.SetActive(false);
        }
    } 
	public void levelMenu (bool clicked)
	{
		if (clicked) 
		{
			LevelMenu.gameObject.SetActive (clicked);
			optionsMenu.gameObject.SetActive (false);
			MainMenu.gameObject.SetActive (false);
			TutorialMenu.gameObject.SetActive(false);
			AudioSettingsMenu.gameObject.SetActive(false);

		}
		else 
		{
			LevelMenu.gameObject.SetActive (clicked);
			optionsMenu.gameObject.SetActive (false);
			MainMenu.gameObject.SetActive (true);
			TutorialMenu.gameObject.SetActive(false);
			AudioSettingsMenu.gameObject.SetActive(false);
		}
	}
	public void tutorialMenu (bool clicked)
	{
		if(clicked)
		{
			TutorialMenu.gameObject.SetActive(clicked);
			LevelMenu.gameObject.SetActive(false);
			optionsMenu.gameObject.SetActive(false);
			MainMenu.gameObject.SetActive(false);
			AudioSettingsMenu.gameObject.SetActive(false);
		}
		else
		{
			TutorialMenu.gameObject.SetActive(clicked);
			LevelMenu.gameObject.SetActive(false);
			optionsMenu.gameObject.SetActive(false);
			AudioSettingsMenu.gameObject.SetActive(false);
			MainMenu.gameObject.SetActive(true);
		}
	}
	public void AudioMenu(bool clicked)
	{
		if (clicked) 
		{
			AudioSettingsMenu.gameObject.SetActive (clicked);
			TutorialMenu.gameObject.SetActive (false);
			LevelMenu.gameObject.SetActive (false);
			optionsMenu.gameObject.SetActive (false);
			MainMenu.gameObject.SetActive (false);
		} 
		else 
		{
			AudioSettingsMenu.gameObject.SetActive (clicked);
			TutorialMenu.gameObject.SetActive (false);
			LevelMenu.gameObject.SetActive (false);
			optionsMenu.gameObject.SetActive (true);
			MainMenu.gameObject.SetActive (false);
		}
	}

}

