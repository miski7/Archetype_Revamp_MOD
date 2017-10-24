using UnityEngine;
using System.Collections;

public class RemoveObject : MonoBehaviour {

	public int button;
	public GameObject keypad;


void OnMouseDown() 
	{
		keypad.GetComponent<openDoor> ().numberReceived (button);
	}

	
}