using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour {
	public static SceneController instance = null;
	
	public string deathScene;

	private string sceneBeforeDeath;

    private void Awake() {
		if(instance == null) {
			instance = this;
		} else if(instance != this) {
			Destroy(gameObject);
		}

		DontDestroyOnLoad(gameObject);
	}

	public void ChangeScene(string sceneName) {
		SceneManager.LoadScene(sceneName);
	}

	public void ChangeToDeathScene() {
		sceneBeforeDeath = SceneManager.GetActiveScene().name;
		SceneManager.LoadScene(deathScene);
	}

	public void ExitDeathScene() {
		SceneManager.LoadScene(sceneBeforeDeath);
	}
}
