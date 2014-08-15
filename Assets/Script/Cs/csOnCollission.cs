using UnityEngine;
using System.Collections;

public class csOnCollission : MonoBehaviour {

public ParticleEmitter explosionPrefab;
public AudioClip sound;


void Update(){

}

void OnCollisionEnter (Collision coll) {
		
		Instantiate(explosionPrefab, transform.position, transform.rotation);
	
		AudioSource.PlayClipAtPoint(sound, transform.position);
		
		Destroy(gameObject);
	
	
}
}
