using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_script : MonoBehaviour {
public float time = 0f;
void Update() {
		Destroy(gameObject,time);
	}
}