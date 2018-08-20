using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Linha : MonoBehaviour 
{
	
	// Use this for initialization
	public void posicaoEmx()
	{
		//sorteia as posiçoes dos objetos apos serem instanciados 
		float sorteiap = Random.Range(-0.25f,0.28f);
		if(sorteiap < 0)
			transform.position = new Vector3 (-0.2f, transform.position.y, transform.position.z);
		
		if(sorteiap < 0.4 && sorteiap > -0.10)
			transform.position = new Vector3 (0.0f, transform.position.y, transform.position.z);

		if(sorteiap > 0)
			transform.position = new Vector3 (0.2f, transform.position.y, transform.position.z);
	}
}
