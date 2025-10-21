using UnityEngine;
using UnityEngine.SceneManagement;

public class teleport : MonoBehaviour {

	public GameObject point;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "hero"){
			other.transform.position = point.transform.position;
			}
		}
	}
