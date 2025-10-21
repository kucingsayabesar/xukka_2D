using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terminal : MonoBehaviour {

public GameObject quote;
public GameObject fake_terminal;	

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "hero")
		{	ScoreScript.scoreValue -= 500;
			Instantiate(quote, transform.position, Quaternion.identity);
			Destroy(gameObject,.01f);
									StartCoroutine ("spawn");
						}
		}
		
	void spawn () {
		Instantiate(fake_terminal, transform.position, Quaternion.identity);
	}
	}