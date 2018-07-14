using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitDeathLevelTrigger : MonoBehaviour {

	private void OnTriggerEnter(Collider other) {
		SceneController.instance.ExitDeathScene();
	}
}
