using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

    private int introCount;



    [SerializeField]
    private GameObject[] introImages;

    public GameObject child;

    // Use this for initialization
    void Start()
    {
        introCount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {

            introCount++;
            if (introCount == 1)
            {
                introImages[0].SetActive(false);
                introImages[1].SetActive(true);
            }
            else
            {
                SceneController.instance.ExitDeathScene();
            }

        }
    }
    
}
