using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {
	private Text pontos;
	// Use this for initialization
	void Start () {
		pontos = gameObject.GetComponentsInChildren<Text> () [1];
		pontos.text = Jogador.getInstance().textPontuacao.text;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void continuar(){
		SceneManager.LoadScene ("fase1");
	}
	public void menu(){
		SceneManager.LoadScene ("inicio");
	}
}
