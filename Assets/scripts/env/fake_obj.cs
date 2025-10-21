using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class fake_obj : MonoBehaviour {
		public GameObject prefab = null;

	
	void Start() {
		Instantiate(prefab, transform.position, Quaternion.identity);
		print("object_spawned");
		Destroy(gameObject,.5f);
		}
}