using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cellphone : MonoBehaviour {
	
	public float velX = 5f;
	float velY = 0f;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
			rb = GetComponent<Rigidbody2D> ();
		}
	
	// Update is called once per frame
	void Update () {
		rb.velocity = new Vector2 (velX, velY);
		}
	
	void OnTriggerEnter2D(Collider2D col)
	{
	if (col.gameObject.tag == "env"){
		Destroy (gameObject, 0.25f);
		}
	}
}
