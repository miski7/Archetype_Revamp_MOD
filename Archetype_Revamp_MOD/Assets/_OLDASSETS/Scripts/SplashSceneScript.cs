using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;


public class SplashSceneScript : MonoBehaviour 
{
	public Image FadePanel1;
	public Image FadePanel2;

	IEnumerator Start ()
	{
		FindObjectOfType<GameManager> ();

		FadePanel1.canvasRenderer.SetAlpha (1.0f);
		FadePanel2.canvasRenderer.SetAlpha (1.0f);

		//Initial wait time before the original 3F00 group image
		yield return new WaitForSeconds (1.0f);

		//Fade in of original 3F00 group image
		OriginalTeamFadeIn ();
		yield return new WaitForSeconds (2.5f);

		//Fade in of Mod group members
		ModTeamFadeIn ();
		yield return new WaitForSeconds (2.5f);

		//Load the next scene
		SceneManager.LoadScene("mainMenu");
	}

	void OriginalTeamFadeIn ()
	{
		FadePanel1.CrossFadeAlpha (0.0f, 1.5f, false);
	}
	void ModTeamFadeIn ()
	{
		FadePanel2.CrossFadeAlpha (0.0f, 1.5f, false);
	}
		
	void Update()
	{
		if (Input.anyKeyDown) 
		{
				SceneManager.LoadScene ("MainMenu");
		}		
	}
}