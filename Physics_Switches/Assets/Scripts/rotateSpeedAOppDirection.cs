using UnityEngine;
using System.Collections;

public class rotateSpeedAOppDirection : MonoBehaviour {
	float rotationSpeed = -1;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		print("rotation direction right");
		transform.Rotate( Vector3.forward * rotationSpeed);

	
	}
}
