using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class DetectedMenu : MonoBehaviour {

	public Transform playerCharacter;

	void Awake()
	{
		Time.timeScale = 1f;
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Confined;
	}

	public void RestartLevel()
	{
	
		int CurrentScene = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene (CurrentScene);
		playerCharacter.GetComponent<FirstPersonController>().enabled = true;
		Debug.Log ("time reset");
	}

	public void QuitToMain()
	{
		SceneManager.LoadScene("mainMenu");
	}


}
