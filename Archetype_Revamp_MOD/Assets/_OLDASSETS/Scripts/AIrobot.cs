using UnityEngine;
using System.Collections;

[RequireComponent (typeof(UnityEngine.AI.NavMeshAgent))]

public class AIrobot : MonoBehaviour 
{

	private UnityEngine.AI.NavMeshAgent nav;
	private GameObject player;
	private Vector3 playerPos;
	public float SightAngle;
	public float RayDrawLength;

	public float patrolSpeed = 2.0f;
	public Transform[] waypoints;
	
	private int curWaypoint = 0;
	private int maxWaypoint;
	public bool playerInSight = false;

	public float minWaypointDistance = 0.1f;

	private void Awake () 
	{
		nav = GetComponent<UnityEngine.AI.NavMeshAgent> ();
		
		maxWaypoint = waypoints.Length - 1;
	}


	void Start ()
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}

	private void Update () 
	{
		Patrolling();

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
	
	public void Patrolling () {
		
		nav.speed = patrolSpeed;
		
		Vector3 tempLocalPosition;
		Vector3 tempWaypointPosition;
		
		// robots position (x, set y to 0, z)
		tempLocalPosition = transform.position;
		tempLocalPosition.y = 0f;
		
		// Current waypoints position (x, set y to 0, z)
		tempWaypointPosition = waypoints [curWaypoint].position;
		tempWaypointPosition.y = 0f;
		
		// Is the distance between the agent and the current waypoint within the minWaypointDistance?
		if (Vector3.Distance (tempLocalPosition, tempWaypointPosition) <= minWaypointDistance) {
			// Have we reached the last waypoint?
			if (curWaypoint == maxWaypoint)
				// If so, go back to the first waypoint and start over again
				curWaypoint = 0;
			else
				// If we haven't reached the Last waypoint, just move on to the next one
				curWaypoint++;
		}
		
		// Set the destination for the agent
		// The navmesh agent is going to do the rest of the work
		nav.SetDestination (waypoints [curWaypoint].position);
	}
}