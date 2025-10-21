using UnityEngine;
using UnityEngine.SceneManagement;

public class ground_particles : MonoBehaviour {

	public GameObject pesok = null;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "ground"){
			Instantiate(pesok, transform.position, Quaternion.identity);
			}
		}
	}
