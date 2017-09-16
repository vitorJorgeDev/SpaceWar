using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* 
 * Este mesmo script esta sendo reaproveitado em fire (tiro player)
 * */

public class Inimigo : MonoBehaviour {

	public Vector2 velocidade = new Vector2 (5, 5);
	private Vector2 movimento;
	public Vector2 direcao = new Vector2 (-1, 0);

	private Rigidbody2D inimigo;
	public Animator explosion;

	// Use this for initialization
	void Start () {
		
	}

	void Awake(){
		inimigo = GetComponent<Rigidbody2D> ();

	}

	void FixedUpdate(){
		inimigo.velocity = movimento;
	}
	
	// Update is called once per frame
	void Update () {
		movimento = new Vector2 (
			direcao.x * velocidade.x,
			direcao.y * velocidade.y);
	}
		
}
