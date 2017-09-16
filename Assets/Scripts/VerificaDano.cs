using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerificaDano : MonoBehaviour {

	public int hp;

	public void Dano(int danoCount){
		hp -= danoCount;
		if (hp <= 0)
		{
			Destroy (gameObject);


			// Adicionando efeito sonoro quando inimigo é destruído
			EfeitoSonoro.Efeito.ExplosionSound ();
			// Explosao animação
			EfeitoExplosao.Explosao.ExplosaoAnimation ();
			// Mostra pontuação para usuário.
			Score.Placar.mostraTexto ();
		}
	}

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
