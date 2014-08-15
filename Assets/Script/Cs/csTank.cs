using UnityEngine;
using System.Collections;

public class csTank : MonoBehaviour {
	public float speed = 5f;					
	public float rotSpeed = 120f;				
	public GameObject turret;		
	public Transform explosion;		
	//public AudioClip snd;		
	public GameObject tank;
	public GameObject enemyTank;
	public int power = 2000;
	
	public GameObject bullet_prefab;
	public float bulletImpulse = 20f;
	
	//public GameObject youWin;
	public GameObject youLose;
	public GameObject winClip;
	
	//static csScore csscore;
	/*
	void awake(){
		//csscore = GetComponent<csScore>();
	}
	*/
	void Update() {
	float amtToMove = speed * Time.deltaTime;		
	float amtToRot = rotSpeed * Time.deltaTime;	
	
	float front = Input.GetAxis("Vertical");		
	float ang = Input.GetAxis("Horizontal");		
	//float ang2 = Input.GetAxis("MyTank");			

	transform.Translate(Vector3.forward * front * amtToMove);	
	transform.Rotate(Vector3.up * ang * amtToRot);				
	//turret.transform.Rotate(Vector3.up * ang2 * amtToRot);		
	
 	// 포탄 발사
	if (Input.GetButtonDown("Fire1")) {
		GameObject spPoint; 
		spPoint = GameObject.Find("spawnPoint");
			
		Instantiate(explosion, spPoint.transform.position, Quaternion.identity);
		//AudioSource.PlayClipAtPoint(snd, spPoint.transform.position);
			
			GameObject thebullet = (GameObject)Instantiate(bullet_prefab, spPoint.transform.position, spPoint.transform.rotation);
			thebullet.rigidbody.AddForce(transform.forward * bulletImpulse, ForceMode.Impulse);
		/*
		Instantiate(explosion, spPoint.transform.position, Quaternion.identity);
		//AudioSource.PlayClipAtPoint(snd, spPoint.transform.position);

		Rigidbody myBullet = (Rigidbody)Instantiate(bullet, spPoint.transform.position, spPoint.transform.rotation);
		myBullet.rigidbody.AddForce(spPoint.transform.forward * power);
		*/
			
		}
	
	}
	/*
	void OnTriggerEnter(Collider coll) {
		//if (coll.gameObject.CompareTag("BULLET")) {
		csScore.enemy++;
		//jsScore.lose++;	
		print("ENEMY HIT YOU"); 							// 점수 증가	
		if (csScore.enemy >= 5) {								// 5점 이상이면 
			//Destroy(coll.transform.root.gameObject);		// 적탱크 파괴
			print("WIN");
			Destroy(tank); 
			//enemyTank.SetActiveRecursively(false);
			youLose.SetActiveRecursively(true);
			winClip.SetActiveRecursively(true);
			}
		}
		*/
	
	void  OnTriggerEnter ( Collider coll  ){
	csScore.enemy++;	
		print("HIT"); 							
		if (csScore.enemy >= 5) {							
			
			print("LOSE");
			Destroy(tank); 
			enemyTank.SetActiveRecursively(false);
			youLose.SetActiveRecursively(true);
			winClip.SetActiveRecursively(true);
			
			
}
}
	}
	

