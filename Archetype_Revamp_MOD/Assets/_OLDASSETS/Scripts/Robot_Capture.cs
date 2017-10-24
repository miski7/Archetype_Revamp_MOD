using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Robot_Capture : MonoBehaviour 
{
	private GameObject player;
	public float SightAngle;
	public GameObject DetectedMenu;
	public Transform playerCharacter;


	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player")
		{
			
			Debug.Log ("I see you");
			Time.timeScale = 0.0f;
			playerCharacter.GetComponent<FirstPersonController>().enabled = false; 
			DetectedMenu.gameObject.SetActive(true);
		} 

	}
}
