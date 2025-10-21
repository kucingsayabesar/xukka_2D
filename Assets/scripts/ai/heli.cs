using UnityEngine;
using UnityEngine.SceneManagement;

public class heli : MonoBehaviour {

	public GameObject heli_point1, heli_point2, heli_point3, heli_point4, heli_point5, heli_point6;
	
	void Start() {
			Invoke("point", 2.0f);
			print("heli start");
		}

	void point(){
			transform.localScale = new Vector3 (transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
			transform.position = heli_point1.transform.position;
			Invoke("point1", 0.5f);
	}
	void point1(){
			transform.position = heli_point2.transform.position;
			Invoke("point2", 0.5f);
	}
	void point2(){
			transform.position = heli_point3.transform.position;
			Invoke("point3", 0.5f);
	}
	void point3(){
			transform.position = heli_point4.transform.position;
			Invoke("point4", 0.5f);
	}
			
	void point4(){
			transform.position = heli_point5.transform.position;
			Invoke("point5", 0.5f);
	}
			
	void point5(){
			transform.position = heli_point6.transform.position;
			Invoke("point6", 0.5f);
}
	void point6(){
			transform.position = heli_point6.transform.position;
			Destroy (gameObject);
			//Invoke("point", 1.0f);
}
	}

