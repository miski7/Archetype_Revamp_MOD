using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class WinGame : MonoBehaviour {
	
	void OnTriggerEnter(Collider Player) 
	{
		Debug.Log ("You Win");
		SceneManager.LoadScene(4);
	}
	
}
