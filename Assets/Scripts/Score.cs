using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public Text score;
	private int ponto;
	public static Score Placar;


	void Awake ()
	{
		if(Placar != null)
		{
			Debug.LogError ("Não foi possível iniciar contagem");
		}
		Placar = this;
	}


	// Use this for initialization
	void Start () {
		ponto = 0;
	}


	
	// Update is called once per frame
	void Update () {
		// mostraTexto ();

	}

	public int mostraTexto()
	{
		ponto += 10;
		score.text = "Score: " + ponto;
		return ponto;

	}
		
}
