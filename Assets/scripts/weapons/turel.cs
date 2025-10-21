using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class turel : MonoBehaviour {

	public GameObject shoot_l, shoot_r;
	
	void Update() {
			Invoke("Shoot_l", 0.5f);
			Instantiate(shoot_l, transform.position, Quaternion.identity);			
			print("shoot");
		}
	void Shoot_1() {
			Instantiate(shoot_l, transform.position, Quaternion.identity);			
			print("shoot");
		}		
}


