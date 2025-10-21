using UnityEngine;
using System.Collections;

public class poop : MonoBehaviour {

	public GameObject poopp = null;
	

	
	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "bullet")
		{
			Instantiate(poopp, transform.position, Quaternion.identity);
						}
		}
	}