using UnityEngine;
using System.Collections;

public class fallObject : MonoBehaviour 
{
	public GameObject rb;

	void Update()
	{
		if (Input.GetKeyDown (KeyCode.E)) 
		{
			rb.GetComponent<Rigidbody>().AddForce (transform.forward * 100);
		}
	}
}