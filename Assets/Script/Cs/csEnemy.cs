using UnityEngine;
using System.Collections;

public class csEnemy : MonoBehaviour {

private int power = 1200;

public Transform bullet;
public Transform target;
public Transform spPoint;
public AudioClip snd;
public Transform explosion;
public Transform explosion2;
public float delayShootTime = 2.0f;
public GameObject enemy;
public GameObject youWin;
public GameObject loseClip;

private float ftime = 0.0f;	
	
IEnumerator Shooting () {
	transform.LookAt(target);				// 아군 방향으로 회전
	ftime += Time.deltaTime;				// 경과 시간 누적 -- ②

	RaycastHit hit;
	Vector3 fwd = transform.TransformDirection(Vector3.forward);
		
	Instantiate(explosion, spPoint.transform.position, Quaternion.identity);
 	Rigidbody obj = (Rigidbody)Instantiate(bullet, spPoint.transform.position, spPoint.transform.rotation); // 포탄
	obj.rigidbody.AddForce(fwd * power);
	yield return new WaitForSeconds(delayShootTime);

	AudioSource.PlayClipAtPoint(snd, spPoint.transform.position);
	ftime = 0;			
	}
	
	void  OnTriggerEnter ( Collider coll  ){
		csScore.player++;	
		print("YOU HIT ENEMY"); 							
		if (csScore.player >= 5) {							
			
			print("WIN");
			Destroy(enemy); 
			//enemyTank.SetActiveRecursively(false);
			youWin.SetActiveRecursively(true);
			loseClip.SetActiveRecursively(true);
			
			
	}
	/*
	void OnTriggerEnter(Collider coll) {
		//if (coll.tag == "BULLET") {
		csScore.player++;
		print("YOU HIT ENEMY"); 							// 점수 증가	
		if (csScore.player >= 5) {	
			//Instantiate(explosion2, transform.position, Quaternion.identity);// 5점 이상이면
			print("WIN");
			Destroy(enemy); 
			youWin.SetActiveRecursively(true);
			loseClip.SetActiveRecursively(true);
			//}
		}
	}
	 */
	}
}
	

