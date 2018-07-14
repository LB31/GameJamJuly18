using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public string inputAxisX = "Horizontal";
	public string inputAxisY = "";
	public string inputAxisZ = "Vertical";

	public float acceleration = 10f;
    public float maxSpeed = 20f;

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate () {
		Rigidbody rb = GetComponent<Rigidbody>();

		Vector3 movement = new Vector3(
			inputAxisX == ""? 0 : Input.GetAxis(inputAxisX),
			inputAxisY == ""? 0 : Input.GetAxis(inputAxisY),
			inputAxisZ == ""? 0 : Input.GetAxis(inputAxisZ)
		);

		movement = movement.normalized;

		rb.AddForce(movement * acceleration, ForceMode.Acceleration);

        rb.velocity = rb.velocity.normalized * Mathf.Min(rb.velocity.magnitude, maxSpeed);

    }
}