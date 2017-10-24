/*using UnityEngine;
using System.Collections;
using UnityStandardAssets.Characters.FirstPerson;

public class Robo_Sight_v3 : MonoBehaviour 
{
	// checks to see if there is something in the way

	public float SightAngle;
	public float RayDrawLength;
	public bool playerInSight;
	public Vector3 personalLastSighting;
	public float speed = 45;
	//public float damping = 100;



	private NavMeshAgent nav;
	//private Animator DanAnim;
	private LastPlayerSighting lastPlayerSighting;
	private GameObject player;
	private Vector3 playerPos;
	private Vector3 previousSighting;


	void Awake()
	{
		nav = GetComponent<NavMeshAgent> ();
		//anim = GetComponent<Animator> ();
		lastPlayerSighting = GameObject.FindGameObjectWithTag("GameController").GetComponent<LastPlayerSighting> ();
		//playerAnim = player.GetComponent<Animator> ();
		player = GameObject.FindGameObjectWithTag("Player");

		personalLastSighting = lastPlayerSighting.DanResetPosition;
		previousSighting = lastPlayerSighting.DanResetPosition;

	}
 	
	void Update () 
	{
		if (lastPlayerSighting.DanPosition != previousSighting)
			personalLastSighting = lastPlayerSighting.DanPosition;

		previousSighting = lastPlayerSighting.DanPosition;


		RaycastHit hit;
		playerPos = player.transform.position;

		Vector3 direction = playerPos - transform.position;
		direction = (direction / direction.magnitude) * RayDrawLength;

		Debug.DrawRay (transform.position, direction, Color.green); //this ray is pointing towards the player

		Vector3 forward = transform.forward * RayDrawLength;
		Debug.DrawRay (transform.position, forward, Color.blue);  //this ray is just to show the robot's sight direction

		//Debug.Log (Vector3.Angle (transform.forward, playerPos - transform.position));

		if (Vector3.Angle (transform.forward, playerPos - transform.position) <= SightAngle
		    && Physics.Raycast (transform.position, playerPos - transform.position, out hit, RayDrawLength) 
			&& hit.collider.tag == "Player") 
		{
			Debug.Log ("I see you");
			playerInSight = true;
		}
		else 
		{
			Debug.Log ("I do not see you anymore");
			playerInSight = false;
		}

	}

	void OnTriggerStay (Collider other)
	{
		if (other.gameObject == player) {
		
	

			if (Input.GetKey ("c")) 
			{
				Debug.Log ("player is too quiet to hear");
			} 
			else 
			{
				Debug.Log ("Robot hears something");
				transform.Rotate (Vector3.right * speed * Time.deltaTime, 45);
			}

		}

	}
	
}

*/