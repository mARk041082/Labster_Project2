using UnityEngine;
using System.Collections;

public class csMoveEnemy : MonoBehaviour {
public int rotAng = 15;	// 초당 회전 각도
public Transform target;
	
	void Update () {
	float amtToRot = rotAng * Time.deltaTime;
	//transform.RotateAround(Vector3.zero, Vector3.up, amtToRot);
	transform.RotateAround(target.position, Vector3.up, amtToRot);
}
}
