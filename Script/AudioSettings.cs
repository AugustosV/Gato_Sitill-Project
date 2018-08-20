using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSettings : MonoBehaviour {
	FMOD.Studio.Bus Music;
	FMOD.Studio.Bus Efeitos;
	FMOD.Studio.Bus Master;
	public float MusicVolume = 0.5f;
	public float EfeitorsVolume = 0.5f;
	public float MasterVolume = 1.0f;


	void Start () 
	{
		Music   = FMODUnity.RuntimeManager.GetBus ("bus:/Master/trilha");
		Efeitos = FMODUnity.RuntimeManager.GetBus ("bus:/Master/efeitos");
		Master  = FMODUnity.RuntimeManager.GetBus ("bus:/Master");
	}

	void Update () 
	{
		Music.setVolume (MusicVolume);
		Efeitos.setVolume (EfeitorsVolume);
		Master.setVolume (MasterVolume);
	}
			
	public void MasterVolumeLevel (float newMasterVolume)
	{
		MasterVolume = newMasterVolume;
	}

	public void MusicVolumeLevel (float newMusicVolume)
	{
		MusicVolume = newMusicVolume;
	}
}
