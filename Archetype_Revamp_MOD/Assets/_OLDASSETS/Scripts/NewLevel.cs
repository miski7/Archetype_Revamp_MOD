using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class NewLevel : MonoBehaviour 
{

	void OnTriggerEnter(Collider player)
	{
		if (player.gameObject.tag == "Player")
		{
			SceneManager.LoadScene(2);
		}
	}
}
