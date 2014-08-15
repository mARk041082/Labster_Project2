using UnityEngine;
using System.Collections;

public class csBullet : MonoBehaviour {
	public AudioClip snd;
	public Transform explosion;
	
	void Start (){
		
	}
	
	void OnTriggerEnter (Collider coll) {

	Instantiate(explosion, transform.position, Quaternion.identity);
	AudioSource.PlayClipAtPoint(snd, transform.position);
	Destroy(gameObject);
	}
}
