using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogCorrendo : MonoBehaviour {
	float cont;
	void Start () {
	}

	void Update () {
		cont = Random.Range (1,1000);
		if (cont == 1)
		FMODUnity.RuntimeManager.PlayOneShot ("event:/latido_do_cao");
		if (cont == 50)
		FMODUnity.RuntimeManager.PlayOneShot ("event:/rosnado_do_cao");
		if (cont == 100)
		FMODUnity.RuntimeManager.PlayOneShot ("event:/latido_do_cao_2");	
	}
}
