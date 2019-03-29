using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
	public GameObject volume;

	public void continuar(){
		Time.timeScale = 1.0f;
		gameObject.SetActive(false);
	}

	public void opçoes(){
		volume.gameObject.SetActive (true);
	}

	public void sair(){
		SceneManager.LoadScene ("inicio");
	}
}
