using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float velocidade;
	public float distanciaX;

	private Rigidbody2D player;
	private bool analisaDanoInimigo = false;

	public Transform VidaPrefabs;

	List<Transform> vidas = new List<Transform>();

	float vidasDistancia = 2.0f;
	float vidaPosInicialX = -11.94f;
	float vidaPosInicialY = -4.95f;

	Vector2 posicaoInicial;
	Vector3 posicaoMouse;
	VerificaDano verificaDanoPlayer;

	void Start () {
		// Remove a influencia da gravidade 
		GetComponent<Rigidbody2D> ().gravityScale = 0.0f;
		GetComponent<Rigidbody2D> ().constraints = RigidbodyConstraints2D.FreezeAll;
		// Obtem a posicao Inicial do jogador para reposicionar ele quando morrer
		posicaoInicial = transform.position;


		ConfigurarVidas ();
	}


	void Update () {

		CodeArmas arma = GetComponent<CodeArmas> ();
		if (arma != null && arma.tiroIntervalo <= 0)
			arma.Ataque ();

		// Fire1 (botão esquerdo do mouse ou toque na tela do celular)
		if (Input.GetButton("Fire1")) {
			posicaoMouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
			posicaoMouse = new Vector2 (
				posicaoMouse.x+ distanciaX, 
				posicaoMouse.y );
		}

		transform.position = Vector2.Lerp (
			transform.position, 
			posicaoMouse, 
			velocidade * Time.deltaTime 
		);

		print (verificaDanoPlayer.hp + "------" + vidas.Count);

		if (verificaDanoPlayer.hp != vidas.Count) {
								RemoverVida (vidas[0]);
								vidas.RemoveAt (0);
		}
	}



	void ConfigurarVidas(){
	
		verificaDanoPlayer = GetComponent<VerificaDano> ();

		for (var i = 0; i < verificaDanoPlayer.hp; i++) {

			Transform vidaTransform = Instantiate (VidaPrefabs) as Transform;
			vidaTransform.gameObject.layer = 7;
			vidaTransform.position =new Vector2(vidaPosInicialX + vidasDistancia * i,vidaPosInicialY);
			vidas.Add (vidaTransform);
		}
	}

	void RemoverVida(Transform vidaTransform){

		vidaTransform.position = new Vector2 (vidaTransform.position.x, -9f);
	}

	public void somShoot()
	{
		if(Input.touchCount < 0)
			EfeitoSonoro.Efeito.TiroPlayer (); // Som tiro player
	}


		

	void Awake(){
		player = GetComponent<Rigidbody2D> ();
	}

	// Colisão com inimigo
	void OnCollisionEnter2D(Collision2D collision)
	{
		

		if (collision.gameObject.tag == "Inimigo") 
		{

			// Desabilita o collider para nao receber danos
			GetComponent<Collider2D> ().enabled = false;

			transform.position = posicaoInicial;
			// Chama coroutine para ficar 3 segundos invencivel
			StartCoroutine(Invencivel());

			AtaqueInimigo inimigo = collision.gameObject.GetComponent<AtaqueInimigo> ();
			if (inimigo != null) 
			{
				VerificaDano dano = inimigo.GetComponent<VerificaDano> ();
				if (dano != null) 
				{
					dano.Dano (dano.hp);
				}
				analisaDanoInimigo = true;
			}
			if (analisaDanoInimigo) 
			{
				
				
				VerificaDano verificaDano = GetComponent<VerificaDano> ();
				if (verificaDano != null) 
				{
					verificaDano.Dano (1);
				}
			}
		}	
	}

	IEnumerator Invencivel(){

		// Faz o jogador piscar por 3 segundos
		for (int x = 0; x <= 3; x++) {
			yield return new WaitForSeconds (1.0f);
			if (GetComponent<SpriteRenderer> ().enabled) {
				GetComponent<SpriteRenderer> ().enabled = false;
			} else {
				GetComponent<SpriteRenderer> ().enabled = true;
			}
		}

		// Encerra invencibilidade
		GetComponent<SpriteRenderer> ().enabled = true;
		GetComponent<Collider2D> ().enabled = true;

	}

	void OnDestroy()
	{
		transform.parent.gameObject.AddComponent<GameOver> ();

		foreach (var vida in vidas) {
			RemoverVida (vida);
		}
	}
}
