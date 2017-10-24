using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class EnemyDetection : MonoBehaviour 
{
// checks to see if there is something in the way
	private GameObject player;
	private Vector3 playerPos;
	public float SightAngle;
	public GameObject DetectedMenu;
	public Transform playerCharacter;
	

	void Start () 
	{
		player = GameObject.FindGameObjectWithTag("Player");
	}

	void Update () 
	{
		RaycastHit hit;
		playerPos = player.transform.position;
		if(Vector3.Angle (transform.forward,playerPos - transform.position) <= SightAngle
		   && Physics.Raycast(transform.position, playerPos - transform.position, out hit, Mathf.Infinity) 
		   && hit.collider.tag == "Player")
		{
			// fail state stuff here !!!!!!!
			Time.timeScale = 0.0f;
			playerCharacter.GetComponent<FirstPersonController>().enabled = false; 
			DetectedMenu.gameObject.SetActive(true);
			//cursor stuff
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
		} 
	}
}
