using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour {
	private float dificuldade;
	private int cont;
	public GameObject inimigo;

	int teste;

	// Use this for initialization
	void Start () {
		dificuldade = 3;
		cont = 0;
		StartCoroutine(cria());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private IEnumerator cria(){
		Instantiate (inimigo).gameObject.transform.Translate(new Vector3(0,Random.Range (-3.0f, 3.0f)));
		cont++;
		yield return new WaitForSeconds(dificuldade);
		if (cont >= 30) {
			cont = 0;
			if(dificuldade > 0.25f){
				dificuldade -= 0.25f;
			}
		}
		StartCoroutine(cria());
	}
}
