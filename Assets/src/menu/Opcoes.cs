using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Opcoes : MonoBehaviour {
	private Slider volume;
	public AudioMixer mix;

	void Start(){
		volume = GetComponentInChildren<Slider> ();
	}

	void Update(){
		
	}
	public void salvar(){
		mix.SetFloat ("volume",volume.value);
		cancelar ();
	}

	public void cancelar(){
		gameObject.SetActive(false);
	}
}
