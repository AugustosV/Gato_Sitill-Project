using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Sensor : MonoBehaviour {
	
	public Transform Loadcena;
	public Vector3 novapos;
	public bool jogafrente = false;

	// Use this for initialization
	void Start () 
	{
		if (jogafrente == true) 
		{
			novapos = transform.position;
			novapos.z += 35f ;
			//novapos.y = 4f;
			transform.position = novapos;

		}
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		
	}
	void OnTriggerEnter(Collider coll)
	{
		if (coll.CompareTag ("Still")) 
		{
			Instantiate (Loadcena,novapos,transform.rotation);
			Destroy (gameObject);
		}
	}
}
