using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot_at_barrel : MonoBehaviour {

public GameObject quote;

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "bullet")
		{
			Instantiate(quote, transform.position, Quaternion.identity);
						}
		}
	}