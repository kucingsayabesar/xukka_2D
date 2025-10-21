using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health_box : MonoBehaviour {

void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag.Equals ("hero"))
		{	player_health.healthValue += 1;
		Destroy (gameObject);
		}
}
}