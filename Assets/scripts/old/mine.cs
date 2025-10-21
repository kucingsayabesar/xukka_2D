using UnityEngine;
using UnityEngine.SceneManagement;

public class mine : MonoBehaviour {

	public GameObject spawnpoint;
	public GameObject blood_player = null;
	public GameObject player_grave = null;
	public GameObject sphere = null;

	void OnTriggerEnter2D (Collider2D other) {
		if (other.tag == "hero"){
			Instantiate(sphere, transform.position, Quaternion.identity);
			Instantiate(blood_player, transform.position, Quaternion.identity);
			player_health.healthValue -= 1;
			Destroy(gameObject,.5f);
			StartCoroutine ("pl_grave");
			other.transform.position = spawnpoint.transform.position;
			}
		}
		void pl_grave () {
		Instantiate(player_grave, transform.position, Quaternion.identity);
		}
	}