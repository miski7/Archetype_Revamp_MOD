using UnityEngine;
using System.Collections;

public class RobotSight : MonoBehaviour 
	{

	void OnTriggerEnter(Collider other) 
	{
		if (other.tag == "Player") {
		
			Debug.Log ("I see you");

		} 
	}

	void OnTriggerExit(Collider other)
	{
		Debug.Log ("where are you");
	}


}
