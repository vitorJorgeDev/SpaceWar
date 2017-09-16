using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

	void OnGUI()

	{

		const int buttonWidth = 120;

		const int buttonHeight = 60;



		// Reiniciando a fase!

		if (GUI.Button (

			new Rect (Screen.width / 2 - (buttonWidth / 2), 

				(2 * Screen.height / 4) - (buttonWidth / 2),

				buttonWidth, buttonHeight),

			"Play")) 

		{

			SceneManager.LoadScene("primeironivel");

		}



		// Voltar para o menu!

		if (GUI.Button (

			new Rect (Screen.width / 2 - (buttonWidth / 2), 

				(2 * Screen.height / 2.5f) - (buttonWidth / 2),

				buttonWidth, buttonHeight),

			"Início")) 

		{

			SceneManager.LoadScene("Menu");

		}

	}
}
