using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NannyController : MonoBehaviour {
    private GameObject player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<ChildIdentifier>().gameObject;

    }
	
	// Update is called once per frame
	void Update () {
		Vector3 targetDir = player.transform.position - transform.position;
        float angle = Vector3.Angle(targetDir, transform.forward);

        if (angle < 5.0f)
            print("close");
    }
	}
}
