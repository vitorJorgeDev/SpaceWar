using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EfeitoSonoro : MonoBehaviour {

	public static EfeitoSonoro Efeito;

	public AudioClip explosion;
	public AudioClip tiroPlayer;
	public AudioClip tiroInimigo;

	void Awake()
	{
		if (Efeito != null) 
		{
			Debug.LogError ("Há outras instâncias que impedem a execução do áudio.");
		}
		Efeito = this;
	}


	private void GetSound(AudioClip audioJogo)
	{
		AudioSource.PlayClipAtPoint (audioJogo, transform.position);
	}

	public void ExplosionSound()
	{
		GetSound (explosion);	
	}

	public void TiroPlayer()
	{
			GetSound (tiroPlayer);	
	}

	public void TiroInimigo()
	{
		GetSound (tiroInimigo);	
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
