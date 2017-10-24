using UnityEngine;
using System.Collections;

public class ChangeMusic : MonoBehaviour {

	public AudioClip MainMenuMusic;
	public AudioClip level1Music;
	public AudioClip level2Music;
	public AudioClip level3Music;
	public AudioClip level4Music;
	public AudioClip level5Music;
	public AudioClip level6Music;
	public AudioClip level7Music;
	
	private AudioSource source;


	public void Awake()
	{
		source = GetComponent<AudioSource> ();

		if (FindObjectsOfType (GetType ()).Length > 1)
		{
			Destroy (gameObject);
		}
			
	}

	void OnLevelWasLoaded (int level)
	{
		if (level == 0) 
		{
			source.clip = MainMenuMusic;
			source.Play();
		}
		if (level == 1) 
		{
			source.clip = level1Music;
			source.Play();
		}
		if (level == 2) 
		{
			source.clip = level2Music;
			source.Play();
		}
		if (level == 3) 
		{
			source.clip = level3Music;
			source.Play();
		}
		if (level == 4) 
		{
			source.clip = level4Music;
			source.Play();
		}
		if (level == 5) 
		{
			source.clip = level5Music;
			source.Play();
		}
		if (level == 6) 
		{
			source.clip = level6Music;
			source.Play();
		}
		if (level == 7) 
		{
			source.clip = level7Music;
			source.Play();
		}

	}

}
