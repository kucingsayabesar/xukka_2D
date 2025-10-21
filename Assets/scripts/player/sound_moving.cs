using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class sound_moving : MonoBehaviour	{
public AudioSource audioSource;
public float volume = 0.5f;
public AudioClip jump_snd;

	void Update()
	{
		if (Input.GetKey("space"))
		{
			audioSource.PlayOneShot(jump_snd, volume);
		}
	}
}

