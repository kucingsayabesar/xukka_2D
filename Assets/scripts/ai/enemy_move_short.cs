using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class enemy_move_short : MonoBehaviour {

	public GameObject enemy_point1, enemy_point2, enemy_point3, enemy_point4;
	
	void Start() {
			Invoke("point", 0.5f);
			print("enemy move");
		}

	void point(){
			transform.position = enemy_point1.transform.position;
			Invoke("point1", 0.5f);
	}
	void point1(){
			transform.position = enemy_point2.transform.position;
			Invoke("point2", 0.5f);
	}
			
	void point2(){
			transform.position = enemy_point3.transform.position;
			Invoke("point3", 0.5f);
	}
			
	void point3(){
			transform.position = enemy_point4.transform.position;
			transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
			Invoke("point4", 0.5f);
}
	void point4(){
			//Destroy (gameObject);
			Invoke("reverse", 0.5f);
}
	void reverse(){
			transform.position = enemy_point3.transform.position;
			//Destroy (gameObject);
			Invoke("reverse1", 0.5f);
}
	void reverse1(){
			transform.position = enemy_point2.transform.position;
			//Destroy (gameObject);
			Invoke("reverse2", 0.5f);
}
	void reverse2(){
			transform.position = enemy_point1.transform.position;
			//Destroy (gameObject);
			Invoke("reverse3", 0.5f);
}
	void reverse3(){
			//Destroy (gameObject);
			transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
			Invoke("point", 0.5f);
}
	}


