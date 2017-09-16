using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewEnemy : MonoBehaviour { 

	/*
	 * Classe responsável pela geração e visualização
	 * dos inimigos em tela
	 */

	public Transform inimigoPrefab;
	public float geraInimigo = 3f; // A cada 3 segundos gera um inimigo
	private bool posicaoPlayer = false;
	private Transform playerTransform;
	private Vector3 posInimiga;

	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;

		InvokeRepeating ("Inimigos", geraInimigo, geraInimigo);
	}

	private void Inimigos()
	{

		posicaoPlayer = !posicaoPlayer;
		// Vector3 posInimiga;

		if (posicaoPlayer) {
			if (playerTransform != null) 
			{
				posInimiga = new Vector3 (transform.position.x,
					playerTransform.position.y,
					transform.position.z);
			}
		}
		else 
		{
			posInimiga = new Vector3 (transform.position.x,
				Random.Range(-3, 3),
				transform.position.z);
		}

		var iniciarInimigo = Instantiate (inimigoPrefab) as Transform;
		// iniciarInimigo.position = transform.position;
		iniciarInimigo.position = posInimiga;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
