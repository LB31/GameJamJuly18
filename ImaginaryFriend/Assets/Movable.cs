using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionStay(Collision other) {
		if (Input.GetButtonDown("Fire1")){
			transform.position = other.gameObject.transform.position + Vector3.up * 3;
			transform.SetParent(other.transform);
		}
	}

	private void FixedUpdate() {
		if(transform.parent == null) {
			return;
		}

		if (Input.GetButtonDown("Fire1")){
			
			// transform.position = transform.position + transform.parent.forward * 4;
			transform.position = Vector3.Scale(transform.position, new Vector3(1, 0, 1));
			transform.SetParent(null);
		}
	}
}
