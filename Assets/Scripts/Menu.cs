using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

	void OnGui()
	{
		const int botaoLargura = 9;
		const int botaoAltura = 1;

		if (GUI.Button (new Rect (
			    Screen.width / 2 - (botaoLargura / 2),
			    (2 * Screen.height / 3) - (botaoLargura / 2), botaoLargura, botaoAltura 
		    ), "Iniciar Jogo")) 
		{
			Debug.LogError ("chamada primeiro nivel");
			SceneManager.LoadScene ("primeironivel");
		}

		Debug.LogError ("Não realizou chamada");
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
