using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour {
	private int cont;
	// Use this for initialization
	void Start () {
		cont = 0;
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate(0.2f,0,0);
		++cont;
		if (cont >= 100) {
			Destroy (gameObject);
		}
	}
}
