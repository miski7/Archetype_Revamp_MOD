using UnityEngine;
using System.Collections;

public class openDoor : MonoBehaviour {

	private int[] enteredPass;
	public int[] code;

	public GameObject DoorAnimation; // this is the door model with a single animation attached
	public AudioSource Success;
	public AudioSource Failed;

	//public GameObject oldDoor;
	//public GameObject newDoor;

		void Awake()
	{

	}

	public void numberReceived(int num)
	{
		Debug.Log ("Button Clicked");
		for (int i = 0; i< 4; i++) 
		{

			if(enteredPass [i] == -1)
			{
				enteredPass[i] = num;
				break;
			}
		}
	}

		void Start()
	{
		enteredPass = new int[4];
		for (int i = 0; i< 4; i++) 
		{
			enteredPass[i]=-1;
		}
	}

	void Update()
	{
		bool correct = true;
		for (int i = 0; i< 4; i++) 
		{
			correct = correct && enteredPass[i]==code[i];
		}

		if (correct) 
		{
			Debug.Log ("It worked!");
			Success.Play ();
			DoorAnimation.GetComponent<Animation> ().Play ();
			if(Success.isPlaying)
			{
				Failed.enabled = false;
			}
		} 


		if (enteredPass [3] != -1) {
			for (int i = 0; i< 4; i++) 
			{
				enteredPass[i]=-1;
				Failed.Play();
			}
		}

	}


}