using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Jogador : MonoBehaviour{
	private static Jogador jogador;
	public GameObject tiro;
	private GameObject[] municao;
	private int cont;
	public Camera cam;
	private float vida, pontuacao;
	public Slider barraDeVida;
	public Text textPontuacao;

	public static Jogador getInstance(){
		return jogador;
	}

	void Awake(){
		if (jogador == null) {
			jogador = this;
		}
		DontDestroyOnLoad (jogador.gameObject);
	}

	// Use this for initialization
	void Start () {
		municao = new GameObject[5];
		cont = 0;
		vida = 100;
		barraDeVida.maxValue = vida;
		pontuacao = 0;

	}
	
	// Update is called once per frame
	void Update () {
		barraDeVida.value = vida;
		textPontuacao.text = "Pontuação: " + pontuacao.ToString ();
		atira ();
	}

	private void atira(){
		if (Input.GetMouseButtonDown(0)) {
			if (cont < 5) {
				municao [cont] = Instantiate (tiro, this.gameObject.transform.position, this.gameObject.transform.rotation);
				++cont;
			} else if(municao[0]==null){
				cont = 0;
			}
		}
	}
		
	void OnMouseDown(){
		OnMouseDrag ();
	}

	void OnMouseDrag(){

		gameObject.transform.position = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane*30));
	}

	public void addPontos(float pt){
		pontuacao += pt;
	}

	void OnCollisionEnter2D(Collision2D colisor){
		if(colisor.gameObject.tag == "inimigo"){
			vida -= 10;
			if (vida <= 0) {
				SceneManager.LoadScene ("gameOver");
				Destroy (gameObject);
			}

		}
	}
}