using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CASA : MonoBehaviour {
	public Vector3 novapos;
	public GameObject lan;
	public Vector2 numeroDela;
	public Vector2 posObs;
	public GameObject[] obstaculos;
	public List<GameObject>Obs;

	public List<GameObject> Coins;

	public bool jogafrente= false;



	public Contaveis contaveis;

	// Use this for initialization
	void Start ()
	{
		
		//Casas = Random.Range(1, 9);
		if (jogafrente == true) 
		{
			novapos = transform.position;
			novapos.z += 46;
			//novapos.y = 4f;
			transform.position = novapos;

		}

		//Instancia Obstaculo
		int newObs=(int)Random.Range(posObs.x, posObs.y);
		for (int i = 0; i < newObs; i++) 
		{
			Obs.Add (Instantiate (obstaculos[Random.Range(0, obstaculos.Length)], transform));
			Obs[i].SetActive (false);
		}

		//Itens coins 
		int newCoins = (int)Random.Range (numeroDela.x, numeroDela.y);
		for (int i = 0; i < newCoins; i++)
		{
			Coins.Add (Instantiate (lan,transform));
			Coins [i].SetActive (false);
		}
		PosiçaoDela();
		ObstaculoPos();
	}
	
	// Update is called once per frame
	void Update ()
	{

		//destroy objetos
		if (transform.position.z <= -50) 
		{
			Destroy (gameObject);
		}
			
	}

	public void PosiçaoDela()
	{
		float min= 5f;
		for(int i=0; i < Coins.Count;i++ )
		{
			float max = min + 0.5f;
			float sorteia = Random.Range (min, max);
			Coins [i].transform.localPosition = new Vector3 (transform.position.x, transform.position.y, sorteia);
			Coins [i].SetActive (true);
			Coins [i].GetComponent<Linha>().posicaoEmx ();
			min = sorteia + 1;
		}
			
	}

	//Posicionando os obstaculos dentro da pista
	public void ObstaculoPos()
	{
		for (int i = 0; i < Obs.Count; i++)
		{
			float minZ= (19f / Obs.Count) + (19f / Obs.Count) * i;
			float maxZ= (19f / Obs.Count) + (19f / Obs.Count) * i + 1;
			float sorteia = Random.Range (minZ, maxZ);
			Obs [i].transform.localPosition = new Vector3 (0, 0, sorteia);
			Obs [i].SetActive (true);
			Obs [i].GetComponent<Linha>().posicaoEmx ();
		}
	}

	public void OnTrigerEnter(Collider coll)
	{
		PosiçaoDela ();
		ObstaculoPos ();

	}
		
		
}



