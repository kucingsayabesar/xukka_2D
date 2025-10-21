using UnityEngine;
using System.Collections;

public class poop_mm : MonoBehaviour {

	public GameObject prefab = null;
	

	
	void OnTriggerEnter2D(Collider2D other)
	{
			Instantiate(prefab, transform.position, Quaternion.identity);
						}
		}
