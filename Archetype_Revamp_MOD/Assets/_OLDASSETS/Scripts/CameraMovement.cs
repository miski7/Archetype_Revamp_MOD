// This file is used for Camera movement and player detection
using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour 	
{

	public float angle;
	public float delay;
	public float cameraSpeed;

	private bool left;
	private bool pause;
	private float restartTime;
	private float currentAngle;


	// Use this for initialization
	void Start () 
		{
			currentAngle = 0.0f;						// currentAngle is set based on the value determined in the scene. This is different based on each camera's settings
			left = true;								// Left boolean is set to the value
			pause = false;								// Pause boolean is set to the value
		}
	
	// Update is called once per frame
	void Update () 
		{

			if (pause) 
				{
					if (Time.realtimeSinceStartup > restartTime) pause = false;
				}
			
			else 
			{
				if (left) 
				{
					currentAngle -= cameraSpeed * Time.deltaTime;        // 
					transform.Rotate (Vector3.up, -cameraSpeed * Time.deltaTime); 						// axis the camera is rotating on. 

					if(currentAngle < -angle/2) 
						{
							left = false;
							pause = true;
							restartTime = Time.realtimeSinceStartup+delay;
						}
				} 

				else 
					{
						currentAngle += cameraSpeed * Time.deltaTime;        // 
						transform.Rotate (Vector3.up, 	cameraSpeed * Time.deltaTime); 						// axis the camera is rotating on. 
						if(currentAngle > angle/2) 
				
						{
							left = true;
							pause = true;
							restartTime = Time.realtimeSinceStartup+delay;
						}
					}
			}
		}

}