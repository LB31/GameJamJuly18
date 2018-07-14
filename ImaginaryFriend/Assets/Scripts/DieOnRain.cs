using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOnRain : MonoBehaviour {

    public GameObject player;
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        var pp = new Vector2(player.transform.position.x, player.transform.position.z);
        var tp = new Vector2(transform.position.x, transform.position.z);

        if (Vector2.Distance(pp, tp) > 3)
            SceneController.instance.ChangeToDeathScene();
    }
}
