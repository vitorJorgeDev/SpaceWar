using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeArmas : MonoBehaviour {

	public Transform tiroPrefabs;
	public float tiro = 0.35f;
	public float tiroIntervalo;


	// Use this for initialization
	void Start () {
		tiroIntervalo = 0;
		gameObject.layer = 7;
	}
	
	// Update is called once per frame
	void Update () {
		if (tiroIntervalo > 0) 
		{
			tiroIntervalo -= Time.deltaTime;
		}
	}

	public void Ataque()
	{
		if (tiroIntervalo <= 0) 
		{
			tiroIntervalo = tiro;
			Transform tiroTransform = Instantiate (tiroPrefabs) as Transform;
			tiroTransform.gameObject.layer = 7;

			tiroTransform.position = transform.position;
		}
	}
}
