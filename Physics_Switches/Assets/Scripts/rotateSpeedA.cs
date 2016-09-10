using UnityEngine;
using System.Collections;

public class rotateSpeedA : MonoBehaviour {
	float rotationSpeed = 1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

			print("rotation direction left");
			transform.Rotate( Vector3.forward * rotationSpeed);

	}
}
