using UnityEngine;
using System.Collections;

public class ButtonClick : MonoBehaviour {
	
	private bool isClicked;										// This variable is used to check whether the player has clicked the button already.
	private float resetTime;									// This is the time at which the button has to move back to its starting position once it has been clicked and moved in.
	public AudioSource KeypadNoise;
	//public GameObject other;
	// Use this for initialization
	void Start () 
	{
		isClicked = false;		
		resetTime = 0.0f;										// resetTime == 0.0f indicates that the button does not have to be moved.
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (resetTime != 0.0f && resetTime < Time.fixedTime) // If the time is right, move the button back to its original location.
		{  
			transform.Translate(0.02f * Vector3.forward);
			resetTime = 0.0f;
			isClicked = false;
		} 
	}
	
	public void ButtonClicked() 
	{
		if (!isClicked) 
		{										// If the button hasn't been clicked yet, then ....
			transform.Translate(-0.02f * Vector3.forward);			// Move the button in.
			isClicked = true;									// Disallow clicking again.
			resetTime = Time.fixedTime + 1.0f;					// Set time at which the button should move back to its original position.
			KeypadNoise.Play();
			
		}
	}
}