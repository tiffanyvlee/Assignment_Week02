using UnityEngine;
using System.Collections;

public class flipUpCube : MonoBehaviour {
	float rotationSpeed = -1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		// if I hit a specific key, open the trap door
	

				print("rotate speed A");
				transform.Rotate( Vector3.forward * rotationSpeed);


	}
}
