using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Historia : MonoBehaviour {
	private string[] falas;
	private Text texto;
	private int cont;
	// Use this for initialization
	void Start () {
		cont = 0;
		falas = new string[5];
		inicializa ();
		texto = gameObject.GetComponentInChildren<Text> ();
		texto.text = falas [cont];
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void continuar(){
		if (cont <= 3) {
			++cont;
			texto.text = falas [cont];
		} else {
			pular ();
		}

	}

	private void inicializa(){
		falas[0] = "Olá, eu sou um besouro e me chamo Beto";
		falas[1] = "Eu era o animal de estimação de um garotinho chamado Caio";
		falas[2] = "Até que um dia Caio foi picado por um mosquito chamado Aedes aegypti";
		falas[3] = "Então Caio pegou Dengue e acabou morrendo";
		falas[4] = "E por isso, agora eu luto contra todos esses mosquitos para que ninguém morra como o Caio";
	}

	public void pular(){
		SceneManager.LoadScene ("fase1");
	}
}
