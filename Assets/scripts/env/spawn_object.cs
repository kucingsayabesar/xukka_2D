using UnityEngine;
using UnityEngine.SceneManagement;

public class spawn_object : MonoBehaviour {

	public GameObject object_for_spawn = null;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "hero"){
			Instantiate(object_for_spawn, transform.position, Quaternion.identity);
			print("object_spawned");
			Destroy(gameObject,.5f);
			}
		}
	}

