using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour {

	// Use this for initialization

	public GameObject player;       
	private Vector3 cam;        

	// Use this for initialization
	void Start () 
	{
		//soma entre o personagem e a camera
		cam = transform.position - player.transform.position;
	}

	// LateUpdate is called after Update each frame
	void LateUpdate () 
	{
		//soma pra ver a posiçao dele sobre o personagem
		transform.position = player.transform.position + cam;

	}
}

