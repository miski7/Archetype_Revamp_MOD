using UnityEngine;
using System.Collections;

public class QuitGame : MonoBehaviour {		
		public Color OnMouseOverColor = Color.yellow;
		public Color OnMouseClickColor = Color.red;
		public Color OnMouseExitColor = Color.white;
		
		void OnMouseOver()
		{
			GetComponent<TextMesh>().color = OnMouseOverColor;
			if (Input.GetButton("Fire1"))
			{
				GetComponent<TextMesh>().color = OnMouseClickColor;
			Debug.Log ("Quitting");
				Application.Quit();
			}
		}
		void OnMouseExit()
		{
			GetComponent<TextMesh>().color = OnMouseExitColor;
		}
	}