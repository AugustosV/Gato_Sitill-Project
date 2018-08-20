/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rux : MonoBehaviour {
	public int avança;
	public int time;
	[SerializeField]
	private GameObject rux;
	private Vector3 move;
	// Use this for initialization
	void Start () {
		avança = 30;
		time = Random.Range (1,9);
	}
	
	// Update is called once per frame
	void Update () {
		if (time == 3 || time == 6) 
		{
			Instantiate (rux);
			move = new Vector3 (-7, 0, 0);
			 
		}
		else if(time == 5 || time == 8)
		{
			Instantiate (rux);
			move=new Vector3 (8,0,0);
		}
	}
}*/
