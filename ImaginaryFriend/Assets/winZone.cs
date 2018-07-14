using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winZone : MonoBehaviour {
    public GameObject winText;

    private void Start()
    {
        winText.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<PlayerController>() != null)
        {
            winText.SetActive(true);
            Destroy(FindObjectOfType<NannyController>().gameObject);
        }
            

    }
}
