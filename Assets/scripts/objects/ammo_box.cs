using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ammo_box : MonoBehaviour {

	void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag.Equals ("hero"))
		{	ammo_script.ammo_12x70 += 50;
		Destroy (gameObject);
		}
}
}