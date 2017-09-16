using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EntrarNoJogo : MonoBehaviour {

	public string cena;
	public float intervalo = 1.0f;

	IEnumerator Start()
	{
		GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds (intervalo);

		GetComponent<SpriteRenderer> ().enabled = true;
		yield return new WaitForSeconds (intervalo);

		StartCoroutine (Start ());
	}
		
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) 
		{
			SceneManager.LoadScene ("primeironivel");
		}


	}
}
