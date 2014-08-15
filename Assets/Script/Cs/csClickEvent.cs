using UnityEngine;
using System.Collections;

public class csClickEvent : MonoBehaviour {
	public string levelToLoad;
	public AudioClip click;
	
	void OnMouseEnter(){
		audio.PlayOneShot(click);
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)){
            Application.LoadLevel(levelToLoad);
			audio.PlayOneShot(click);
	}
}
}