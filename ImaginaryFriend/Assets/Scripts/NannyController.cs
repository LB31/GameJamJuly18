using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NannyController : MonoBehaviour {
    private GameObject player;
    public bool playerHidden;

    // Use this for initialization
    void Start () {
        player = FindObjectOfType<ChildIdentifier>().gameObject;
        
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * 30);

        if (player != null)
        playerHidden = player.GetComponent<PlayerController>().inSaveZone;
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);

        Vector3 targetDir = player.transform.position - transform.position;
        float angle = Vector3.Angle(targetDir, transform.forward);
        
        if (angle < 20.0f)
        {
            if (!playerHidden)
                Destroy(player);
        }
           
    }
	
}
