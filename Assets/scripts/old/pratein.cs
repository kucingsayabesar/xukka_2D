using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pratein : MonoBehaviour {

void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag.Equals ("hero")){
		Time.timeScale = 1.5f; 
		Destroy (gameObject);
		Invoke ("slow", 4f);
		}
}
	void slow(){
			Time.timeScale = 1f;
			print("END BAD TRIP");
	}
}