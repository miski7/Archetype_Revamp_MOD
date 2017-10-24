using UnityEngine;
using System.Collections;

public class DialogPlay : MonoBehaviour 
{
	
	public bool PlayedBefore = false;
	public AudioSource Dialog;
	private int TimesEntered = 0;
	
	
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Player") 
		{
			TimesEntered += 1;
			if (TimesEntered == 1) 
			{
				if (PlayedBefore == false) 
				{
					Dialog.GetComponent<AudioSource> ().Play ();
					PlayedBefore = true;
				}
			}
		}
	}
}
