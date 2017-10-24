using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]

public class Movie2 : MonoBehaviour 
{
	
	public MovieTexture movie;
	private AudioSource Audio;
	
	void Start() 
	{
		GetComponent<RawImage> ().texture = movie as MovieTexture;
		Audio = GetComponent<AudioSource> ();
		Audio.clip = movie.audioClip;
		movie.Play ();
		Audio.Play ();
	}
	void Update()
	{
		if(movie.isPlaying == false)
		{
			SceneManager.LoadScene (5);		
		}
	}
}
