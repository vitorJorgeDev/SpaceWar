using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoExplosao : MonoBehaviour {

	public static EfeitoExplosao Explosao;
	public Animator explosaoAt;
	// public Animation teste;

	void Awake()
	{
		if (Explosao != null) 
		{
			Debug.LogError ("Efeito não aplicado");
		}

		Explosao = this;
	}

	private void AnimeExplosao (Animator a)
	{
		Animator.Instantiate(explosaoAt);
		//Debug.LogError ("** Teste **");
		a.gameObject.tag = "Animation";
	}

	public void ExplosaoAnimation(){
		AnimeExplosao (explosaoAt);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
