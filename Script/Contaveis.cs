using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contaveis : MonoBehaviour {
	public Text coinText;
	public Text metrotx;
	public Game_over over;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	public void percorrido (int metros) {
		
		metrotx.text= metros + "m";

	}

	public void ContaCoins(int la){
		coinText.text = la.ToString ();
	}
}
