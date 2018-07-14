using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleGameobjectTimer : MonoBehaviour {

    public float cycleTime = 2f;
    public GameObject target;

	// Use this for initialization
	void Start () {
        ToggleOn();
	}

    void ToggleOn()
    {
        if (target) target.SetActive(true);
        Invoke("ToggleOff", cycleTime);
    }

    void ToggleOff()
    {
        if (target) target.SetActive(false);
        Invoke("ToggleOn", cycleTime);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
