using UnityEngine;
using System.Collections;

public class crouch : MonoBehaviour {
	//for crouching script
	private bool constrainCrouch = false;
	private CharacterController characterCollider;
	private float initHeight;


	void Start () 
	{
		characterCollider = gameObject.GetComponent<CharacterController> ();
		initHeight = characterCollider.height;
	}

	void Update()
	{
		float newHeight = initHeight;
		if(Input.GetKey("c") || constrainCrouch) 							//   || = or
			newHeight *= 0.005f;   											// change this value to reduce the crouch height
		float currentHeight = characterCollider.height;
		characterCollider.height = Mathf.Lerp(currentHeight, newHeight, (1.0f - Mathf.Exp(-2.0f*Time.deltaTime))); 	// change the 2 to increase speed of standing/crouching
		transform.position = transform.position + new Vector3(0, (characterCollider.height - currentHeight) / 2, 0);
	}

	void OnTriggerEnter(Collider other) {
		if (other.tag == "vent") {
			constrainCrouch = true;
		}
	}
	
	void OnTriggerExit(Collider other) {
		if (other.tag == "vent") {
			constrainCrouch = false;
		}
	}
}