using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class PauseGame : MonoBehaviour
{
	public Transform player;
	public GameObject PauseMenu;

	public bool Paused = false;
	

	void Update () 
	{
		Pause ();
	}

	public void Pause()
	{
		if (Input.GetKeyDown (KeyCode.Escape)) 
		{
			if (PauseMenu.gameObject.activeInHierarchy == false) 
			{
				Paused = true;
				Time.timeScale = 0f;
				PauseMenu.gameObject.SetActive (true);
				player.GetComponent<FirstPersonController> ().enabled = false;
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.Confined;
			} 
			else 
			{
				Paused = false;
				Time.timeScale = 1f;
				PauseMenu.gameObject.SetActive (false);
				player.GetComponent<FirstPersonController> ().enabled = true;
				Cursor.visible = false;
				Cursor.lockState = CursorLockMode.Locked;
			}
		} 

	}
}