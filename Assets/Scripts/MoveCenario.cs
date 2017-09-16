using UnityEngine;
using System.Linq; // Biblioteca importada para utilização de OrderBy
using System.Collections;
using System.Collections.Generic;


public class MoveCenario : MonoBehaviour {

	public float limiteX;
	public float velocidade;

	void Update () {

		// Desloca o fundo
		transform.Translate (Vector2.left * velocidade * Time.deltaTime);

		// Reposiciona o fundo para um novo ciclo
		if (transform.position.x <= limiteX) {
			transform.position = new Vector2 (0.0f, limiteX * 0); 
		}

	}



//	public Vector2 velocidade = new Vector2(1, 1);
//	public Vector2 direcao = new Vector2 (-1, 0);
//
//	// Preparação de loop cenário
//	public float speed;
//	public float limitex; 
//	public float posicaox;
//
//	// Use this for initialization
//	void Start () {
//
//	}
//
//		
//	
//	// Update is called once per frame
//	void Update () {
//
//		// Movimentar o fundo para esquerda
//		transform.Translate(Vector2.left * speed * Time.deltaTime);
//		// Posiciona o fundo para ficar em looping
//		if(transform.position.x < limitex)
//		{
//			transform.position = new Vector3 (posicaox, 0.0f, 0.0f);
//		}
//
//		Vector2 movimento = new Vector2 (
//			velocidade.x * direcao.x,
//			velocidade.y * direcao.y);
//
//		movimento *= Time.deltaTime;
//		transform.Translate (movimento);
//
//
//
//	}


}
