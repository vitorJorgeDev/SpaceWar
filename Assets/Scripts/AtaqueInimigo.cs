using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtaqueInimigo : MonoBehaviour {

	public CodeArmas arma;
	private bool des = false;
	private Renderer vs;
	private Collider2D obj;

	// Use this for initialization
	void Start () {
		obj.enabled = false;
		arma = GetComponent<CodeArmas> ();
	}

	void Awake(){
		obj = GetComponent<Collider2D> ();
		vs = GetComponent<Renderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (arma != null && arma.tiroIntervalo <= 0)
		{
			arma.Ataque ();	
			EfeitoSonoro.Efeito.TiroInimigo ();
		}

		// Destruir inimigo quando estiver vísivel
		if (vs.estaVisivel (Camera.main)) {
			obj.enabled = true;
			des = true;
		} else {
			if (des) 
			{
				Destroy (gameObject);
			}
		}

	}
}
