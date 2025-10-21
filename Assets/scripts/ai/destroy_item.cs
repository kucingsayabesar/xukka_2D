using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_item : MonoBehaviour {
public float time = 0f;
public int item_health = 10;
public GameObject particle;

	void Update()
	{
		if (item_health <= 0)
		{
			Destroy(gameObject, time);
		}
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
			if (other.tag == "tank")
		{
			item_health -= 10;
			Instantiate(particle, transform.position, Quaternion.identity);
		}
	}
}