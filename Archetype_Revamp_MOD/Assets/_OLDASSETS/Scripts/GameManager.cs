/* ==========================
Project Name: Archetype Revamped
File Name: #SCRIPTNAME#
Author1: Mathew Miskimin
Author2: 
Author2: 
Author2: 
Date Created: 2017/09/10

Description of File:
	The GameManager script is responsible for holding all the default variables needed to be referenced within the game. 
This script automatically generates the Game Manager instance and makes sure that there is only one. The game manager 
contains the following variables;

=============================
*/
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour 
{
	public static GameManager instance = null;

	//Public booleans (true or false) go here
	//[Header("Public Bools")]


	//Public floating(numbers with decimals) variables go here
	//[Header("Public Floats")]

	//Public integer(whole numbers) variables go here
	//[Header("Public Ints")]

	void Awake()
	{
		if (instance == null) // if there is no gameobject called GameManager
		{
			instance = this; // create an instance of the GameManager
		} 
		else if (instance != null)  // if there is already a gameobject called GameManager
		{
			Destroy (gameObject); // Delete the gameobject if there is more than one GameManager present in the scene
		}
		DontDestroyOnLoad (gameObject);	// Doesn't get deleted between multiple scenes

	}


}