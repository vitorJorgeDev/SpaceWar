using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour {

	public int dano = 1;
	public string tag;


	// Use this for initialization
	void Start () {
		Destroy (gameObject, 10);
	}

	void OnTriggerEnter2D(Collider2D c){
		//Debug.LogError ("** OnTriggerEnter2D **");

		if (c.gameObject.tag == tag) 
		{
			VerificaDano vdano = c.gameObject.GetComponent<VerificaDano> ();
			if (vdano != null) 
			{
				vdano.Dano (dano);
				Destroy (gameObject);
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
