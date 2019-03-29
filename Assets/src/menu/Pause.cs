using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
	public GameObject menu;

	public void pause(){
		Time.timeScale = 0.0f;
		menu.SetActive (true);
	}

}
