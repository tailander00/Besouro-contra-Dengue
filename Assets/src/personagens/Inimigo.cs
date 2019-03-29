using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inimigo : MonoBehaviour {
	private float distancia;
	// Use this for initialization
	void Start () {
		distancia = 0;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (new Vector3 (-0.05f, 0.0f));
		distancia += 0.05f;
		if(distancia >= 40)
			Destroy (gameObject);
	}

	void OnCollisionEnter2D(Collision2D colisor){
		if(colisor.gameObject.tag == "ataque"){
			Jogador.getInstance ().addPontos (1);
			Destroy (gameObject);
		}
	}
}
