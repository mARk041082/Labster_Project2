using UnityEngine;
using System.Collections;

public class csShootScript : MonoBehaviour {
	
	public float timeBetweenShots = 5.0f;
    public Rigidbody bullet;
    public float bulletSpeed = 500;
    public float bulletLifetime = 10.0f;
    public bool shooting = false;
	public Transform explosion;
	public Transform spPoint;
 
    void Start() {
		//if(gameObject.name =="Tank1"){
        StartShooting();
		//}
    }
 
    void StartShooting() {
		if(GameObject.Find("Tank1")){
        shooting = true;
        StartCoroutine("TimedShooting");
		} else {
		shooting = false;	
			StopCoroutine("TimedShooting");
		}
    }
 
    IEnumerator TimedShooting() {
        while(shooting) {
            if(bullet) {
                Rigidbody newBullet = Instantiate(bullet, transform.position, 
                                          transform.rotation) as Rigidbody;
                newBullet.AddForce(transform.forward * bulletSpeed);
				Instantiate(explosion, spPoint.transform.position, Quaternion.identity);
              //  Physics.IgnoreCollision(collider, newBullet.collider);
                //Destroy(newBullet.gameObject, bulletLifetime);
                yield return new WaitForSeconds(timeBetweenShots);
            }
        }
    }
}
