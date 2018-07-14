using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour {

    private int introCount;


    [SerializeField]
    private Image currentImage;

    [SerializeField]
	private Sprite[] introImages;
    
    // Use this for initialization
	void Start () {
		introCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void NextIntroImage()
    {
        introCount ++;
        if(introCount < introImages.Length)
        {
            currentImage.sprite = introImages[introCount];
        }
        else
        {
            SceneManager.LoadScene("whatever");
        }

    }

}
