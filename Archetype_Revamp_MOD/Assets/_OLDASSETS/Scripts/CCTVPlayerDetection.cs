using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class CCTVPlayerDetection : MonoBehaviour 
{
	// checks to see if there is something in the way
	private GameObject player;
	private Vector3 playerPos;
	public float SightAngle;
	public GameObject AlarmNoise;
	public bool PlayerUndetected = true;
	public Transform playerCharacter;
	public GameObject DetectedMenu;

	
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag("Player");

	}

	/*IEnumerator Alarm ()
	{
		AlarmNoise.GetComponent<AudioSource> ().Play();
		yield return new WaitForSeconds (10);     //Wait for (X) seconds before stopping the music
		AlarmNoise.GetComponent<AudioSource>().Stop();
	}*/
	
	void Update () 
	{
		RaycastHit hit;
		playerPos = player.transform.position;
		if (Vector3.Angle (-transform.right, playerPos - transform.position) <= SightAngle
			&& Physics.Raycast (transform.position, playerPos - transform.position, out hit, Mathf.Infinity) 
			&& hit.collider.tag == "Player") 
		{
			// fail state stuff here !!!!!!!
			Debug.Log ("Target Sighted " + PlayerUndetected);
			PlayerUndetected = false;
			Time.timeScale = 0.0f;
			playerCharacter.GetComponent<FirstPersonController>().enabled = false; 
			DetectedMenu.gameObject.SetActive(true);
						//cursor stuff
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			/*while (!PlayerUndetected) 
			{
				StartCoroutine("Alarm");
				return;
			}*/

		}
		else
		{
			Debug.Log ("Target Lost " + PlayerUndetected);
			PlayerUndetected = true;
		}

	}



}
