using UnityEngine;
using System.Collections;

public class csCheckAndDestroy : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		GameObject RIP;
		RIP = GameObject.Find("cut_scene_music");
		Destroy(RIP);
	}
}
