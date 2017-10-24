using UnityEngine;
using System.Collections;

public class DontDestryOnLoad : MonoBehaviour {
	
	void Awake()
	{
		DontDestroyOnLoad (gameObject);
	}
}
