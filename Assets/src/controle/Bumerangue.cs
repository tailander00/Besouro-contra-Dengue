using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bumerangue : MonoBehaviour {
	private float velocidade;
	private float distancia;
	private float ultimaAtivacao;

	// Use this for initialization
	void Start () {
		ultimaAtivacao = Time.time;
		gameObject.SetActive (false);
		velocidade = 0.5f;
		distancia = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (gameObject.activeSelf) {
			gameObject.transform.Translate (new Vector3 (velocidade, 0, 0));
			distancia += velocidade;
			if (distancia >= 18 || distancia <= 0 ) {
				velocidade *= -1;
				if (velocidade > 0) {
					gameObject.SetActive (false);
				}
			}
		}
	}
	public void ativa(){
		if (Time.time - ultimaAtivacao >= 5.0f) {
			ultimaAtivacao = Time.time;
			gameObject.SetActive (true);
		}
	}
}
