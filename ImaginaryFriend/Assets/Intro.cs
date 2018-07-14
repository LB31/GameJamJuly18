using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

    private int introCount;

    

    [SerializeField]
    private GameObject[] introImages;



    // Use this for initialization
    void Start () {
		introCount = 0;
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NextIntroImage()
    {

     
        introImages[introCount].SetActive(false);
        introCount ++;
        if(introCount < introImages.Length)
        {
            introImages[introCount].SetActive(true);
        }
        else
        {
            SceneManager.LoadScene("Bedroom");
        }

    }

}
