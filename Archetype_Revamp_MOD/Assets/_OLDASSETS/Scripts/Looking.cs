using UnityEngine;
using System.Collections;

public class Looking : MonoBehaviour 
{
	
	/* attached to button*/
	
	private GameObject Player;
	RaycastHit WhatIsHit;
	public float Dist = 10;
	
	
	void Awake()
	{
		Player = GameObject.FindGameObjectWithTag("Player");
	}
	
	void Update () 
	{
		if(Input.GetKeyDown(KeyCode.E))
		{
			
			
			if (Physics.Raycast (Player.transform.position, Player.transform.forward, out WhatIsHit, Dist) && WhatIsHit.transform.gameObject == gameObject) 
			{
				this.gameObject.GetComponent<ButtonClick>().ButtonClicked();
				Debug.Log ("E pressed " + WhatIsHit.collider.gameObject);
			}
		}
		
	}
	
	
}
