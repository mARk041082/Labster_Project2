using UnityEngine;
using System.Collections;

public class csDontDestroyOnLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		audio.Play();
		DontDestroyOnLoad(transform.gameObject);
	}
	
}
