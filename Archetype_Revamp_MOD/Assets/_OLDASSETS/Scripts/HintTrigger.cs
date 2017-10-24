using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HintTrigger : MonoBehaviour 
{

	public GameObject Panel;

	// Use this for initialization
	void OnTriggerEnter (Collider col)
	{
		if (col.gameObject.tag == "Player") 
		{
			Panel.gameObject.SetActive (true);
		}
	}

	void OnTriggerExit ()
	{ 
		Panel.gameObject.SetActive (false);
	}

}
