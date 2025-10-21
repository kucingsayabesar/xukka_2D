using UnityEngine;
using System.Collections;

public class weather : MonoBehaviour {

	public GameObject effects = null;

	
		void Start () {
		print("it rains!");
		Instantiate(effects, transform.position, Quaternion.identity);
		Invoke("stop", 11.5f);
	}
		void stop(){
			print("nothing");
	}
}