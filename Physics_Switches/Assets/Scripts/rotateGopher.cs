using UnityEngine;
using System.Collections;

public class rotateGopher : MonoBehaviour {
	float rotationSpeed = -90;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.X)) {
			print("reveal gopher");
			transform.Rotate( Vector3.right * rotationSpeed);
		}
	}
}
