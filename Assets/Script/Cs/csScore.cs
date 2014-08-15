using UnityEngine;
using System.Collections;

public class csScore : MonoBehaviour {
	public static int player = 0;		
	public static int enemy = 0;		
	public GUIStyle style;
	
	public void Start() {	
		player = 0;
		enemy = 0;
	}

	public void OnGUI() {			
		GUI.Label(new Rect(20, 10, 120, 20), "Player: "+ player, style);
		GUI.Label(new Rect(20, 30, 120, 20), "Enemy: "+ enemy, style);
	
	}

}
