using UnityEngine;
using System.Collections;

public class Crosshair : MonoBehaviour {

	Rect crosshairRect;
	public Texture crosshairImage;

	void Awake()
	{
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	void Start()
	{

		float CrosshairSize = Screen.width * 0.1f;
		crosshairImage = Resources.Load ("Textures/crosshair") as Texture;
		crosshairRect = new Rect (Screen.width / 2 - CrosshairSize / 2, Screen.height / 2 - CrosshairSize/2, CrosshairSize, CrosshairSize);
	}

	void OnGUI()
	{
		GUI.DrawTexture (crosshairRect, crosshairImage);
	}
}
