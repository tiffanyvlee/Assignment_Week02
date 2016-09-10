using UnityEngine;
using System.Collections;

public class Flower_Pivot : MonoBehaviour {
	float rotationSpeed = 2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		print ("rotation flower center");
		transform.Rotate (Vector3.forward * rotationSpeed);

	
	}
}
