using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	public string inputAxisX = "Horizontal";
	public string inputAxisY = "";
	public string inputAxisZ = "Vertical";

	public Vector3 customDrag;

	public float acceleration = 10f;
    public float maxSpeed = 20f;
	public float jump = 5f;

    public bool inSaveZone;

	// Use this for initialization
	void Start () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<saveZone>() != null)
            inSaveZone = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<saveZone>() != null)
            inSaveZone = false;
    }


    void FixedUpdate () {
		Rigidbody rb = GetComponent<Rigidbody>();

		Vector3 movement = new Vector3(
			inputAxisX == ""? 0 : Input.GetAxis(inputAxisX),
			0,
			inputAxisZ == ""? 0 : Input.GetAxis(inputAxisZ)
		);



		movement = Camera.main.transform.TransformDirection(movement);
		movement = Vector3.Scale(movement, new Vector3(1, 0, 1));
		movement = movement + (inputAxisY == ""? 0 : Input.GetAxis(inputAxisY)) * Vector3.up;
		movement = movement.normalized;

		rb.AddForce(movement * acceleration, ForceMode.Acceleration);

        rb.velocity = rb.velocity.normalized * Mathf.Min(rb.velocity.magnitude, maxSpeed);

		if(Input.GetButtonDown("Jump")) {
			rb.AddForce(Vector3.up * jump, ForceMode.Impulse);

		}

		rb.AddForce(Vector3.Scale(-rb.velocity, customDrag), ForceMode.VelocityChange);
    }
}