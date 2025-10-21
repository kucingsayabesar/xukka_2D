using UnityEngine;
using UnityEngine.SceneManagement;

public class plane : MonoBehaviour {

	public GameObject plane_point1, plane_point2, plane_point3, plane_point4, plane_point5, plane_point6;
	
	void Start() {
			Invoke("point", 2.0f);
			print("heli start");
		}

	void point(){
			transform.position = plane_point1.transform.position;
			Invoke("point1", 0.5f);
	}
	void point1(){
			transform.position = plane_point2.transform.position;
			Invoke("point2", 0.5f);
	}
	void point2(){
			transform.position = plane_point3.transform.position;
			Invoke("point3", 0.5f);
	}
	void point3(){
			transform.position = plane_point4.transform.position;
			Invoke("point4", 0.5f);
	}
			
	void point4(){
			transform.position = plane_point5.transform.position;
			Invoke("point5", 0.5f);
	}
			
	void point5(){
			transform.position = plane_point6.transform.position;
			Invoke("point6", 0.5f);
}
	void point6(){
			transform.position = plane_point6.transform.position;
			//Destroy (gameObject);
			Invoke("point", 0.5f);
}
	}

