using UnityEngine;
using System.Collections;

public class Elevator: MonoBehaviour 
{
	public GameObject elevator;
	public bool GoUp;

	void Awake()
	{
		GoUp = false;
	}
	
	void OnMouseDown()
	{
		Go();
	}
	void Go ()
	{
		if (GoUp == false) 
		{
			elevator.GetComponent<Animation>().Play("Up");
			GoUp = true;
		}
		else 
		{
			elevator.GetComponent<Animation>().Play("Down");
			GoUp = false;
		} 
	}
	
}