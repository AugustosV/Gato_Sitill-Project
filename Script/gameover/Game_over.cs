using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_over : MonoBehaviour {
	public Text DisText;
	public Text preText;
	public Contaveis cont;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	public void ateOnde(int per) {
		DisText.text= "Distancia" + per;

	}
	public void quantos(int qnt){
		preText.text = "Coins" + qnt;
	
	}
}
