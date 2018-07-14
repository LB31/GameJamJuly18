using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
    private float startY;


    public float distanceTresureOrigin;
    public float amplitude;
    public float speed;
    public Transform player;
    public float rotateAroundSpeed;
    public Transform objectToProtect;

	// Use this for initialization
	void Start () {
        startY = transform.position.y;
       
    }
	
	// Update is called once per frame
	void Update () {


        float step = speed * Time.deltaTime;
        float distancePlayer = Vector3.Distance(player.position, transform.position);
        float distanceTresure = Vector3.Distance(objectToProtect.position, transform.position);


        if (distancePlayer < 15) {
            transform.LookAt(player);
            transform.position = Vector3.MoveTowards(transform.position, player.position, step);
        }
        else
        {

            if (distanceTresure > distanceTresureOrigin)
            {
                transform.LookAt(objectToProtect);
                transform.position = Vector3.MoveTowards(transform.position, objectToProtect.position, step);
            }
            else
            {
                // Sin needs 2 * PI * speed time to complete a movement from min to max
                // Amplitude is for the amount of movement
                transform.position = new Vector3(transform.position.x, startY + amplitude * Mathf.Sin(speed * Time.time), transform.position.z);
                transform.RotateAround(objectToProtect.position, Vector3.up, -rotateAroundSpeed * Time.deltaTime);
            }
        }


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player.gameObject)
        {
            Debug.Log("Killed");
        }
    }



    }
