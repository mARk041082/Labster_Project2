using UnityEngine;
using System.Collections;

public class csSmoothFollow : MonoBehaviour {

	
	public Transform target;
	public float distance = 10.0f;
	public float height = 5.0f;
	public float heightDamping = 2.0f;
	public float rotationDamping = 3.0f;
	
	
	[AddComponentMenu("Camera-Control/Smooth Follow")]
	
	void LateUpdate () {
	float wantedRotationAngle;
	float wantedHeight;
		
	float currentRotationAngle;
	float currentHeight;
	// Early out if we don't have a target
	if (!target)
		return;
	
	// Calculate the current rotation angles
	wantedRotationAngle = target.eulerAngles.y;
	wantedHeight = target.position.y + height;
		
	currentRotationAngle = transform.eulerAngles.y;
	currentHeight = transform.position.y;
	
	// Damp the rotation around the y-axis
	currentRotationAngle = Mathf.LerpAngle (currentRotationAngle, wantedRotationAngle, rotationDamping * Time.deltaTime);

	// Damp the height
	currentHeight = Mathf.Lerp (currentHeight, wantedHeight, heightDamping * Time.deltaTime);

	// Convert the angle into a rotation
	Quaternion currentRotation = Quaternion.Euler (0, currentRotationAngle, 180);
	
	// Set the position of the camera on the x-z plane to:
	// distance meters behind the target
	transform.position = target.position;
	transform.position -= currentRotation * Vector3.forward * distance;

	// Set the height of the camera
	//transform.position.y = currentHeight;
	transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
	
	// Always look at the target
	transform.LookAt (target);
}
}
