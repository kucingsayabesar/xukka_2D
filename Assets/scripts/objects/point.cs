using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class point : MonoBehaviour {

void OnTriggerEnter2D (Collider2D col)
	{
		if (col.gameObject.tag.Equals ("hero"))
		{	ScoreScript.scoreValue += 1;
		Destroy (gameObject);
		}
}
}

