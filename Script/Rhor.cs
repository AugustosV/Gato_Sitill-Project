using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rhor : MonoBehaviour {
	public Transform persona;
	public float velocidade;
	public bool perto= false;
	public Vector3 movi;

	// Use this for initialization
	void Start () {
		velocidade = 30f;
		transform.LookAt(persona);
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider este)
	{
		if (este.CompareTag ("Still"))
		{
			transform.Translate (Vector3.forward * velocidade *Time.deltaTime);

		}
	}
	/*void OnColliderEnter(CapsuleCollider ataca)
	{
		if (ataca.CompareTag ("Still")) 
		{
			
		}
	}*/
}
