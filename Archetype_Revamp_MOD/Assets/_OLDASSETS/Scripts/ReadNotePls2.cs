using UnityEngine;
using System.Collections;

public class ReadNotePls2 : MonoBehaviour {
	
	public GameObject Player;
	public float minDist = 1f;
	public Texture NoteTextureHere;
	float dist;
	bool reading = false;
	
	void Update () {
		dist = Vector3.Distance(Player.gameObject.transform.position, gameObject.transform.position);
		if (dist <= minDist) {
			if(Input.GetKeyDown(KeyCode.E)) {
				if(reading) {
					reading = false;
				}
				else {
					reading = true;
				}
			}
		}
		else {
			reading = false;
		}
	}
	
	void OnGUI() {
		if(reading) {
			GUI.Box(new Rect(0, 0, Screen.width, Screen.height), NoteTextureHere);
		}
		//	else if(dist <= minDist) {
		//		GUI.TextArea(new Rect(Screen.height/4, Screen.width/4, 500, 500), "Press 'E' to read.");
		//	}
	}
}