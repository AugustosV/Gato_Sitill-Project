using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Persona : MonoBehaviour {
	public Animator still;
	public Vector3 lado;
	public int lapontos;
	[SerializeField]
	private Contaveis contaveis;
	public int anda;
	public float distancia= 0;
	public bool começa= false;

	void Start () {
		still = GetComponent<Animator> ();
		anda = 2;
		if (Input.GetKeyDown ("a")) 
		{
			começa = true;
		} 
	
	}

	void Update () {

		if(começa == true)
		{
			transform.Translate (Vector3.forward * anda * Time.deltaTime);
			distancia += Time.deltaTime;
			contaveis.percorrido ((int)distancia);
		}
		still.SetFloat ("corre", 1f);
		MovimentoDoPersonagem ();
	}

	void MovimentoDoPersonagem ()
	{
		if(Input.GetKeyDown (KeyCode.RightArrow) && transform.position.x == 0)
		{
			still.SetTrigger ("direita");
			lado = transform.position;
			lado.x = 0.2f;
			transform.position = lado;

		}
		if(Input.GetKeyDown (KeyCode.RightArrow) && transform.position.x < 0)
		{
			still.SetTrigger ("direita");
			lado = transform.position;
			lado.x = 0;
			transform.position = lado;

		}

		if(Input.GetKeyDown (KeyCode.LeftArrow) && transform.position.x > 0)
		{
			FMODUnity.RuntimeManager.PlayOneShot ("event:/salto_do_gato");
		}

		if(Input.GetKeyDown (KeyCode.LeftArrow) && transform.position.x == 0)
		{
			still.SetTrigger ("esquerda");
			lado = transform.position;
			lado.x = -0.2f;
			transform.position = lado;


		}
		if(Input.GetKeyDown (KeyCode.LeftArrow) && transform.position.x > 0)
		{
			still.SetTrigger ("esquerda");
			lado = transform.position;
			lado.x = 0;
			transform.position = lado;

		}
		if(Input.GetKeyDown (KeyCode.LeftArrow) && transform.position.x < 0)
		{
			FMODUnity.RuntimeManager.PlayOneShot ("event:/salto_do_gato");
		}
			
		//salto do personagem
		if (Input.GetKey (KeyCode.Space)) {
			transform.Translate (Vector3.up * 2.3f * Time.deltaTime);
			still.SetFloat ("pulo", 0.9f);
		} 

		else {
			still.SetFloat ("pulo", 0.4f);
		}
			
	}

     void OnTriggerEnter(Collider other)
	{
		//soma coins
		if (other.CompareTag ("la")) {
			lapontos++;
			contaveis.ContaCoins (lapontos);
			other.gameObject.SetActive (false);
			FMODUnity.RuntimeManager.PlayOneShot ("event:/pontos");
		}

	
		//condiçao de gameover
		if (other.CompareTag ("muro")) {
				still.SetTrigger ("bateu_parede");
				Application.LoadLevel ("Game_Over");
			transform.Translate (Vector3.back * 10* Time.deltaTime);

		}

		if (other.CompareTag ("obstaculo")) {

				still.SetTrigger ("tropeco");
				Time.timeScale -= 0.1f;
				Application.LoadLevel ("Game_Over");
			transform.Translate (Vector3.back * 10* Time.deltaTime);
		}
	}
}